using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Termpaper
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            try {


                Variables obj = new Variables();
                
                obj.Name = textName.Text;
                obj.Phone = textPhone.Text;
                obj.Country = textCountry.Text;
                obj.Email = textEmail.Text;
                AddStudents a = new AddStudents();
                a.add(obj);
                
                MessageBox.Show("Sucessfully saved");


            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
