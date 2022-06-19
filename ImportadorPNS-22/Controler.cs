using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ExcelLibrary.SpreadSheet;

namespace ImportadorPNS_22
{
    public class Controler
    {
        SqlConnection conn;
        Dictionary<string, List<Coluna>> DbPnsDictrionary;
        public Controler()
        {
            DbPnsDictrionary = new Dictionary<string, List<Coluna>>();
        }
        public void StringConexao(string IP, string SenhaBD)
        {
            if (conn == null)
                conn = new SqlConnection($"Data Source ={IP}; Initial Catalog =PNS; User Id =sa; Password ={SenhaBD}");

        }

        public void CriaEstrutura(string estrutura)
        {
            var a = Workbook.Load(estrutura);
            var workSheet = a.Worksheets.First();

            try
            {
                //Percorrendo as linhas  a partir da segunda linha - 1
                for (int i = 1; i <= workSheet.Cells.LastRowIndex; i++)
                {
                    string tab = workSheet.Cells[i, 0].ToString();
                    string b = workSheet.Cells[i, 1].ToString();
                    string b1 = workSheet.Cells[i, 2].ToString();

                    Coluna c = new Coluna() { Nome = workSheet.Cells[i, 1].ToString(), Posicao = workSheet.Cells[i, 2].ToString(), Tamanho = workSheet.Cells[i, 3].ToString() };

                    if (!DbPnsDictrionary.Keys.Contains(tab))
                    {
                        List<Coluna> lstCol = new List<Coluna>();
                        DbPnsDictrionary.Add(tab, lstCol);
                    }
                    DbPnsDictrionary[tab].Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async void CriaNomeclatura(string nomeclatura)
        {
            try
            {
                conn.Open();
                string createBD = "drop database PNS;create database PNS;";
                ExecuteInsertDB(createBD);

                var a = Workbook.Load(nomeclatura);
                var workSheet = a.Worksheets.First();

                List<Nov> lstNomeclatura = new List<Nov>();
                string str = "";
                for (int i = 0; i <= workSheet.Cells.LastRowIndex; i++)
                {

                    Nov c = new Nov() { Tipo = workSheet.Cells[i, 0].ToString(), Nome = workSheet.Cells[i, 1].ToString(), Valor = workSheet.Cells[i, 2].ToString() };
                    lstNomeclatura.Add(c);
                    if (i == 0)
                    {
                        string st = "create table PNS.._Enumerador (Tipo varchar(20), Valor varchar(100), Descricao varchar(1000));";
                        string result = "";
                        result = ExecuteInsertDB(st);

                        if (result.Count() > 10)
                        {
                            ExecuteInsertDB("truncate table PNS.._Enumerador;");
                        }
                    }
                    if (lstNomeclatura.Count() == 200)
                    {
                        str = "insert into PNS.._Enumerador (Tipo, Valor, Descricao) Values ('";

                        foreach (var item in lstNomeclatura)
                        {
                            str = str + item.Tipo + "', '" + item.Nome + "', '" + item.Valor + "'), ('";
                        }
                        str = str.Remove(str.Length - 4, 4);
                        str = str + ";";
                        string res = "";
                        res = ExecuteInsertDB(str);
                        lstNomeclatura.Clear();
                    }


                }
                if (lstNomeclatura.Count() > 1)
                {
                    str = "insert into PNS.._Enumerador (Tipo, Valor, Descricao) Values ('";

                    Task tt = Task.Run(() =>
                    {
                        foreach (var item in lstNomeclatura)
                        {
                            str = str + item.Tipo + "', '" + item.Nome + "', '" + item.Valor + "'), ('";
                        }
                    });

                    await tt;
                    str = str.Remove(str.Length - 4, 4);
                    str = str + ";";
                    string r = "";
                    r = ExecuteInsertDB(str);
                    lstNomeclatura.Clear();




                }
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
            finally { conn.Close(); }
        }


        public Task Importar(string estrutura)
        {


            return Task.Factory.StartNew(() =>
            {
                foreach (var item in DbPnsDictrionary.Keys)
                {

                    using (StreamReader sr = new StreamReader(estrutura))
                    {
                        string line = string.Empty;

                        int ContLinhas = 0;
                        int ContTotal = 0;
                        string str = "insert into PNS.." + item;

                        string create_Table = "Create Table PNS.." + item + " (Id int, ";
                        while ((line = sr.ReadLine()) != null)
                        {
                            string a = " (Id, ";
                            string b = " (" + (ContTotal + 1) + ", '";

                            for (int i = 0; i < DbPnsDictrionary[item].Count; i++)
                            {
                                int pos = Convert.ToInt32(DbPnsDictrionary[item][i].Posicao);
                                int tam = Convert.ToInt32(DbPnsDictrionary[item][i].Tamanho);

                                //cc[i] = new Nov();
                                //cc[i].Nome = DbPnsDictrionary[item][i].Nome;
                                //cc[i].Valor = line.Substring(pos - 1, tam);

                                if (ContLinhas == 0)
                                    a = a + DbPnsDictrionary[item][i].Nome + ", ";

                                if (ContTotal == 0)
                                    create_Table = create_Table + DbPnsDictrionary[item][i].Nome + " varchar(" + tam + "), ";

                                b = b + line.Substring(pos - 1, tam) + "', '";
                            }
                            a = a.Remove(a.Length - 2, 2);
                            a = a + ")";
                            b = b.Remove(b.Length - 3, 3);
                            b = b + "),";


                            if (ContLinhas == 0)
                                str = str + a + " values";
                            str = str + b;

                            if (ContTotal == 0)
                            {
                                create_Table = create_Table.Remove(create_Table.Length - 2, 2);
                                create_Table += ");";
                                string resp = ExecuteInsertDB(create_Table);
                                if (resp.Count() > 10)
                                {
                                    var resposta = MessageBox.Show(resp + " \nDeseja limpar a tabela?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (resposta == DialogResult.Yes)
                                    {
                                        string trunc = "truncate table PNS.." + item + ";";
                                        ExecuteInsertDB(trunc);
                                    }
                                }
                            }


                            ContLinhas++;
                            ContTotal++;
                            int altQtd = str.Length;
                            if (str.Length >= 8000)
                            {

                                ExecuteInsertDB(str);

                                ContLinhas = 0;
                                str = "insert into PNS.." + item;


                            }
                        }
                        if (ContLinhas > 1)
                            ExecuteInsertDB(str);

                    }


                }
            });
        }


        private string ExecuteInsertDB(string SQL_Insert)
        {
            try
            {
                SQL_Insert = SQL_Insert.Remove(SQL_Insert.Length - 1, 1);
                SQL_Insert = SQL_Insert + ";";

                SqlCommand cmd = new SqlCommand(SQL_Insert);

                //conn.Open();
                cmd.Connection = conn;
                int r = cmd.ExecuteNonQuery();
                //conn.Close();
                return r.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
