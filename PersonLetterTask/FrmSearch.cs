using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonLetterTask
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=PersonLetterDB;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ShowTPLbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idLetter", textBox1.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // da.Fill(dt);
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ShowTPL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // da.Fill(dt);
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ParametersSearch.idLetter = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ParametersSearch.nameLetter = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ParametersSearch.dateRegisterLetter = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ParametersSearch.destinationLetter = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ParametersSearch.senderLetter = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ParametersSearch.tagsLetter = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ParametersSearch.contentLetter = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.Close();
        }
    }
}
