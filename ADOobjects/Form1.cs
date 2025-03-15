using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;
namespace ADOobjects
{
    public partial class frmADONET : Form
    {
        //OGGETTI ADONET
        SqlConnection cn;   //gestisce la comunicazione fisica con il db
        SqlCommand cmd;     //per impostare il comando (istruzione sql)
        SqlDataAdapter adp;     //per raccogliere i dati. Restituisce una tabella Virtuale

        public frmADONET()
        {
            InitializeComponent();
        }

        private void frmObject_Load(object sender, EventArgs e)
        {
            string dbName = "ANRANGORAMOSDB.MDF";
            string cnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
Application.StartupPath + "\\" + dbName +
";Integrated Security=True;Connect Timeout=30";
            try
            {
                //cn = new SqlConnection();
                //cn.ConnectionString=cnString;
                //OPPURE
                cn = new SqlConnection(cnString);
                cn.Open();
                MessageBox.Show("Connessione con il database " + dbName + " è riuscita");
                popolaCmbMaterie();
                popolaCmbAlunni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void popolaCmbAlunni()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT IDALUNNO,COGNOME+' '+NOME AS NOMINATIVO FROM ALUNNI ORDER BY COGNOME,NOME";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                cmbAlunno.DataSource = null;
                cmbAlunno.DataSource = dt;
                cmbAlunno.DisplayMember = "NOMINATIVO";
                cmbAlunno.ValueMember = "idAlunno";    //FK per quando inseriremo il voto
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void popolaCmbMaterie()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM MATERIE ORDER BY MATERIA";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                cmbMaterie.DataSource = null;
                cmbMaterie.DataSource = dt;
                cmbMaterie.DisplayMember = "MATERIA";
                cmbMaterie.ValueMember= "idMateria";    //PK per quando inseriremo il voto
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNumeroAlunni_Click(object sender, EventArgs e)
        {
            int numeroAlunni;
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM ALUNNI";
                //ExecuteScalar restituisce il primo elemento della prima colonna
                numeroAlunni = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show("Numero alunni= " + numeroAlunni);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVisualizzaAlunni_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string s = "";
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm loaf
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM ALUNNI ORDER BY NOME, COGNOME";
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvAlunni.DataSource = null;
                dgvAlunni.DataSource = dt;
                if (dt.Rows.Count == 0) MessageBox.Show("NESSUN DATO SODDISFA L'ISTRUZIONE SCRITTA");
                else
                {
                    for (int i = 0; i < dt.Rows.Count; i++) s += dt.Rows[i][2] + "\n";
                }
                MessageBox.Show("ECCO I NOMI: \n" + s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string idMateria { get=>cmbMaterie.SelectedValue.ToString(); }
        public string idAlunno { get => cmbAlunno.SelectedValue.ToString(); }
        public int voto { get => (int)nudVoto.Value; }

        private void btnInserireVoto_Click(object sender, EventArgs e)
        {
                DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;//Connessione fatta nel foarm load
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO VOTI(IDMATERIA,IDALUNNO,VOTO)" +
                    "VALUES" +
                    $"('{idMateria}',{idAlunno},{voto});";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT * FROM VOTI";

                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                dgvMaterie.DataSource = null;
                dgvMaterie.DataSource = dt;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
