using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using OfficeOpenXml;
using System.IO;
using ExcelLibrary.SpreadSheet;
using System.Data.SqlClient;

namespace ImportDbPNS
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        OpenFileDialog op;
        string Dir;
        Dictionary<string, List<Coluna>> DbPnsDictrionary;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtMicroDados.Text = op.FileName;
                Dir = op.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            DbPnsDictrionary = new Dictionary<string, List<Coluna>>();
        }

        private void btnArqEstrutural_Click(object sender, EventArgs e)
        {
            string arq;
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtArqEstrutural.Text = op.FileName;
                arq = op.FileName;

                var a = Workbook.Load(arq);
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
                    lblValidaEstrutura.Text = "Importado com Sucesso!!!";
                    lblValidaEstrutura.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar o arquivo. \nDetalhes: " + ex.Message);
                    lblValidaEstrutura.Text = "Erro ao importar arquivo!";
                    lblValidaEstrutura.BackColor = Color.Red;
                }
                finally
                {
                    
                    lblValidaEstrutura.Visible = true;
                }
            }
        }

        #region teste de Leitura e criação do Insert errada***
        //private void btnInsert_Click(object sender, EventArgs e)
        //{
        //    int ContLinhas = 1;
        //    using (StreamReader sr = new StreamReader(Dir))
        //    {

        //        string line = string.Empty;

        //        lstDados = new List<Nov[]>();


        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            foreach (var item in DbPnsDictrionary.Keys)
        //            {
        //                //criando array para receber variavel(Coluna e seu valor retornado do Arquivo)
        //                cc = new Nov[DbPnsDictrionary[item].Count()];

        //                //Listando todas colunas de tabela especifica "item" e incluindo no Array 
        //                for (int i = 0; i < DbPnsDictrionary[item].Count; i++)
        //                {
        //                    int pos = Convert.ToInt32(DbPnsDictrionary[item][i].Posicao);
        //                    int tam = Convert.ToInt32(DbPnsDictrionary[item][i].Tamanho);

        //                    cc[i] = new Nov();
        //                    cc[i].Nome = DbPnsDictrionary[item][i].Nome;

        //                    string bbb = line.Substring(200, 8);
        //                    cc[i].Valor = line.Substring(pos-1, tam);
        //                }
        //                lstDados.Add(cc);
        //                //Dados a serem trabalhados no insert
        //            }
        //            if(ContLinhas == 20)
        //            {
        //                //fazer inserção e limpar listas
        //                string str = "insert into PNS..{0}  ( ";
        //                string[] a;
        //                string[] b;
        //                int indx;
        //                int qq;
        //                foreach (var item in DbPnsDictrionary.Keys)
        //                {
        //                    int tam = DbPnsDictrionary[item].Count();
        //                    indx= 0;
        //                    a = new string[tam];
        //                    b = new string[tam];
        //                    for (int i = 0; i < tam; i++)
        //                    {
        //                        a[i] = "('";
        //                        b[i] = "('";
        //                    }

        //                    qq = tam;
        //                    Dictionary<string, int> dic = new Dictionary<string, int>();
        //                    foreach (var i in DbPnsDictrionary[item])
        //                    {
        //                        Nov n = new Nov();
        //                        n = lstDados[0].Where(z => z.Nome == i.Nome).FirstOrDefault();

        //                        if (!dic.Keys.Contains(i.Nome))
        //                        {
        //                            a[indx] = a[indx] + i.Nome + ", ";
        //                            dic.Add(i.Nome, indx);

        //                            b[indx] = b[indx] + n.Valor + "', '";
        //                        }
        //                        else
        //                            b[dic[i.Nome]] = b[dic[i.Nome]] + n.Valor + "', '";

        //                        indx++;
        //                    }
        //                    for (int i = 0; i < indx; i++)
        //                    {
        //                        a[i] = a[i].Remove(a.Length - 2, 2);
        //                        a[i] = a[i] + ") ";
        //                        b[i] = b[i].Remove(b.Length - 3, 3);
        //                        b[i] = b[i] + ") ";
        //                    }

        //                    lstDados.Remove(lstDados[0]);


        //                }
        //                for (int i = 0; i < a[].Count(); i++)
        //                {
        //                    a[i] = a[i].Remove(a.Length - 2, 2);
        //                    a[i] = a[i] + ") ";
        //                    b[i] = b[i].Remove(b[i].Length - 2, 2);
        //                    b[i] = b[i] + ";";
        //                }
        //            }

        //            ContLinhas++;
        //        }

        //    }
        //}
        #endregion

        bool result = true;
        private async void btnInsert_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection($"Data Source = {txtEndereco.Text}; Initial Catalog = PNS; User Id = sa; Password = {txtSenhaBD.Text}"); //Cria a conexão com o Banco de dados devido a Dll que tem na pasta do programa.

            conn.Open();
            await teste1();
            conn.Close();
        }
        private Task teste1()
        {
            

            return Task.Factory.StartNew(() =>
            {
                foreach (var item in DbPnsDictrionary.Keys)
                {

                    using (StreamReader sr = new StreamReader(Dir))
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

                            if(ContTotal ==0)
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


                                lblResult.Invoke(new MethodInvoker(() => lblResult.Text = string.Format("Importando tabela:{0}, \nQTD de linhas Alteradas:{1}", item, ContTotal)));
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
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        private void btnNomeclatura_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new SqlConnection($"Data Source = {txtEndereco.Text}; User Id = sa; Password ={txtSenhaBD.Text}"); //Cria a conexão com o Banco de dados devido a Dll que tem na pasta do programa.

                conn.Open();
                string createBD = "drop database PNS;create database PNS;";
                ExecuteInsertDB(createBD);

                string arq;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    txtNomeclatura.Text = op.FileName;
                    arq = op.FileName;

                    var a = Workbook.Load(arq);
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
                                var resp = MessageBox.Show("Já existe a tabela criada, deseja Limpa-lá?", "Deseja limpar a tabela?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (resp == DialogResult.Yes)
                                {
                                    ExecuteInsertDB("truncate table PNS.._Enumerador;");
                                }
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

                        foreach (var item in lstNomeclatura)
                        {
                            str = str + item.Tipo + "', '" + item.Nome + "', '" + item.Valor + "'), ('";
                        }
                        str = str.Remove(str.Length - 4, 4);
                        str = str + ";";
                        string r = "";
                        r = ExecuteInsertDB(str);
                        lstNomeclatura.Clear();


                    }
                }
            }
            catch { MessageBox.Show("Erro ao importar arquivo, tente novamente."); }
            finally { conn.Close(); }
        }

       
    }

}