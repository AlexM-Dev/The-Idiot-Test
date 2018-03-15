using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Idiot_Test {
    public partial class ctrlResult : UserControl {
        public ctrlResult() {
            InitializeComponent();
        }
        public ctrlResult(string value) {
            InitializeComponent();

            lblExpression.Text = $"Your idiocy level is {value}!";
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            ((Form)Parent).Close();
        }

        private void btnWoah_Click(object sender, EventArgs e) {
            ((Form)Parent).Close();
        }
    }
}
