using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace responsi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tbDepKar.Items.Add("1");
            tbDepKar.Items.Add("2");
            tbDepKar.Items.Add("3");
            tbDepKar.Items.Add("4");
            tbDepKar.Items.Add("5");
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=Rafth2003.;Database=Responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        private object idDep1;

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.ComboBox GetTbDepKar()
        {
            return tbDepKar;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select id_karyawan, nama, id_dep from karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                sql = @"select * from insert_kr(_name; _id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", tbDepKar.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil di inputkan", "well done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoad.PerformClick();
                    tbNamaKaryawan = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ( r == null)
            {
                MessageBox.Show("Pilih data karyawan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah data benar?","Hapus data terkonfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {

            }
        }
    }
}
