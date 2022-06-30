

namespace ImportadorPNS_22
{
    public partial class Form1 : Form
    {
        OpenFileDialog op;
        string Dir;
        Controler controler;
        bool VerificaLabel = true;
        List<string> lstTabelas;



        public Form1()
        {
            InitializeComponent();
            controler = new Controler();
            op = new OpenFileDialog();
           lstTabelas = new List<string>();
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtBasePNS.Text = op.FileName;
                Dir = op.FileName;
            }
        }

        private void btbEstrutura_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtEstrutura.Text = op.FileName;
            }
            
            controler.CriaEstrutura(txtEstrutura.Text);

            lstTabelas.AddRange(controler.lstTabelas);
            lblProx.Text = "Próxima tabela: "+lstTabelas.FirstOrDefault();
        }

        private void btnNomeclatura_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtNomeclatura.Text = op.FileName;
            }
            controler.StringConexao(txtIPSQL.Text, txtSenhaSQL.Text);
            controler.CriaNomeclatura(txtNomeclatura.Text);
        }

        {

            Thread t = new Thread(AtualizaLabel);
            t.Start();
            await controler.Importar(txtBasePNS.Text);
            VerificaLabel = false;
            //para poder confirmar o andamento

        }
    }
}