using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace PersonLetterTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=PersonLetterDB;Integrated Security=True");

        void fillGrid()
        {
            SqlCommand cmd = new SqlCommand("ShowTPL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SaveTPL", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nameLetter", txtNameLetter.Text);
            cmd.Parameters.AddWithValue("@dataRegistration", dtDataReg.Text);
            cmd.Parameters.AddWithValue("@destination", txtDestination.Text);
            cmd.Parameters.AddWithValue("@sender", txtSender.Text);
            cmd.Parameters.AddWithValue("@tags", txtTags.Text);
            cmd.Parameters.AddWithValue("@contentLetter", txtContent.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Данные сохранены");
            fillGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSearch formaSearch = new FrmSearch();
            formaSearch.ShowDialog();
            txtIdLetter.Text = ParametersSearch.idLetter;
            txtNameLetter.Text = ParametersSearch.nameLetter;
            dtDataReg.Text = ParametersSearch.dateRegisterLetter;
            txtDestination.Text = ParametersSearch.destinationLetter;
            txtSender.Text = ParametersSearch.senderLetter;
            txtTags.Text = ParametersSearch.tagsLetter;
            txtContent.Text = ParametersSearch.contentLetter;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIdLetter.Text != "")
            {
                SqlCommand cmd = new SqlCommand("UpdateTPL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nameLetter", txtNameLetter.Text);
                cmd.Parameters.AddWithValue("@dataRegistration", dtDataReg.Text);
                cmd.Parameters.AddWithValue("@destination", txtDestination.Text);
                cmd.Parameters.AddWithValue("@sender", txtSender.Text);
                cmd.Parameters.AddWithValue("@tags", txtTags.Text);
                cmd.Parameters.AddWithValue("@contentLetter", txtContent.Text);
                cmd.Parameters.AddWithValue("@idLetter", txtIdLetter.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Успешно обновлено");
                fillGrid();
            }
            else
            {
                MessageBox.Show("Чтобы 'обнавить' сначала найдите запись");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIdLetter.Text != "")
            {
                SqlCommand cmd = new SqlCommand("DeleteTPL", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idLetter", txtIdLetter.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Данные удалены");
                fillGrid();
            }
            else
            {
                MessageBox.Show("Чтобы 'удалить' сначала найдите запись");
            }
        }
    }
}
