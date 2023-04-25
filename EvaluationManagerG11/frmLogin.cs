using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG11 {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textUserName_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtUserName.Text == "") {
                MessageBox.Show("Korisničko ime nije unešeno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
