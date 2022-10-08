using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_eletronica
{
    public partial class frm_resultado : Form
    {
        public frm_resultado()
        {
            InitializeComponent();
        }

        conexao bd = new conexao();
        Candidatos candidatos = new Candidatos();
        string sql;
        DataTable buscar = new DataTable();

        public void listar_13()
        {
            candidatos.candidato(13);
            pictureBox3.Load(candidatos.img);

            sql = string.Format(@"select count(*) as 'cont_lula' from voto where numero = 13;");
            buscar = bd.ConsultarTabelas(sql);

            int qt_votos = Int32.Parse(buscar.Rows[0].Field<Int64>("cont_lula").ToString());
            lbl_voto_lula.Text = qt_votos.ToString();
        }

        public void listar_22()
        {
            candidatos.candidato(22);
            pictureBox1.Load(candidatos.img);

            sql = string.Format(@"select count(*) as 'cont_bolso' from voto where numero = 22;");
            buscar = bd.ConsultarTabelas(sql);

            int qt_votos = Int32.Parse(buscar.Rows[0].Field<Int64>("cont_bolso").ToString());
            lbl_voto_bolsonaro.Text = qt_votos.ToString();
        }

        public void listar_12()
        {
            candidatos.candidato(12);
            pictureBox4.Load(candidatos.img);

            sql = string.Format(@"select count(*) as 'cont_ciro' from voto where numero = 12;");
            buscar = bd.ConsultarTabelas(sql);

            int qt_votos = Int32.Parse(buscar.Rows[0].Field<Int64>("cont_ciro").ToString());
            lbl_voto_ciro.Text = qt_votos.ToString();
        }

        public void listar_15()
        {
            candidatos.candidato(15);
            pictureBox2.Load(candidatos.img);

            sql = string.Format(@"select count(*) as 'cont_tebet' from voto where numero = 15;");
            buscar = bd.ConsultarTabelas(sql);

            int qt_votos = Int32.Parse(buscar.Rows[0].Field<Int64>("cont_tebet").ToString());
            lbl_voto_tebete.Text = qt_votos.ToString();
        }

        private void frm_resultado_Load(object sender, EventArgs e)
        {

            listar_12();
            listar_13();
            listar_15();
            listar_22();

        }
    }
}
