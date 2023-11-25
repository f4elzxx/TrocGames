using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TROCGames
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPlaystation_Click(object sender, EventArgs e)
        {
            View.Playstation janela = new View.Playstation();
            janela.Show();
        }

        private void BtnXbox_Click(object sender, EventArgs e)
        {
            View.Xbox janela = new View.Xbox();
                Janela.Show();
        }
    }
}
