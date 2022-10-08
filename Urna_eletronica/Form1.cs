namespace Urna_eletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (num_1 == false) 
            {
                txt_num1.Text = "1";
            }
            else 
            {
                txt_num2.Text = "1"; 
            }
        }
        private void limpar() 
        {
            txt_num1.Clear();
            txt_num1.ReadOnly = false;
            txt_num2.Clear();
            txt_num2.ReadOnly = false;
            lblnome.Text = "";
            lblpartido.Text = "";
            pictureBox1.Image=null;
            voto_computado = false;
            num_1 = false;
            num_2 = false;
        }

        Candidatos candidatos = new Candidatos();
        bool voto_computado = false , num_1 = false , num_2 = false;
        conexao bd = new conexao();
        string sql;

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {
            int caracter = txt_num1.Text.Length;
            

            if (caracter >= 1 ) 
            {
                txt_num1.ReadOnly = true;
                num_1 = true;
            }
        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {
            int caracter = txt_num2.Text.Length;       
            if (caracter >= 1)
            {
                txt_num2.ReadOnly = true;
                num_2 = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "2";
            }
            else
            {
                txt_num2.Text = "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "3";
            }
            else
            {
                txt_num2.Text = "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "4";
            }
            else
            {
                txt_num2.Text = "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "5";
            }
            else
            {
                txt_num2.Text = "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "6";
            }
            else
            {
                txt_num2.Text = "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "7";
            }
            else
            {
                txt_num2.Text = "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "8";
            }
            else
            {
                txt_num2.Text = "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "9";
            }
            else
            {
                txt_num2.Text = "9";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (num_1 == false)
            {
                txt_num1.Text = "0";
            }
            else
            {
                txt_num2.Text = "0";
            }
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {
            if(voto_computado == false) 
            {
                MessageBox.Show("Aperte novamente o botão BRANCO \npara computar seu voto em branco ");
                voto_computado = true;
            }
            else
            {
                sql = string.Format("insert into voto values(null,'Voto em Branco','','00')"
                       );
                bd.AlterarTabelas(sql);
                MessageBox.Show("Voto computado");
            }
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_resultado cad = new frm_resultado();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txt_num1.Text) * 10, num2 = int.Parse(txt_num2.Text); ;               
                int voto = num1 + num2;

                candidatos.candidato(voto);
                string nome_candidato = candidatos.nome , partido = candidatos.partido;

          

                if (voto_computado == false && candidatos.existe == true) {            
                    pictureBox1.Load(candidatos.img);
                    lblnome.Text = nome_candidato;
                    lblpartido.Text = partido;
                    MessageBox.Show("Aperte o botão Confirmar para computar o voto");
                    voto_computado = true;
                }

                else if (voto_computado == true && candidatos.existe == true)
                {
                    sql = string.Format("insert into voto values(null,'{0}','{1}','{2}')",
                       candidatos.nome, candidatos.partido , candidatos.num);
                    bd.AlterarTabelas(sql);
                    MessageBox.Show("Voto computado");
                    limpar();
                }

                else if (candidatos.existe == false) 
                {
                    MessageBox.Show("Candidato não existente");
                    limpar();
                }

               

            }
            catch(Exception ex) {
                if(txt_num1.Text == "" || txt_num2.Text == "") 
                { 
                    MessageBox.Show("Digite um numero");
                }
                limpar();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}