

namespace ImportadorPNS_22
{
    public partial class Form1 : Form
    {
        OpenFileDialog op;
        string Dir;
        Controler controler;



        public Form1()
        {
            InitializeComponent();
            controler = new Controler();
            op = new OpenFileDialog();
           
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

        private void button1_Click(object sender, EventArgs e)
        {

            //para poder confirmar o andamento
            ///lblResult.Invoke(new MethodInvoker(() => lblResult.Text = string.Format("Importando tabela:{0}, \nQTD de linhas Alteradas:{1}", item, ContTotal)));

        }
    }
}