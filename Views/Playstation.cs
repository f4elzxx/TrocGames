using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TROCGames.View
{
    public partial class Playstation : Form
    {
        public Playstation()
        {
            InitializeComponent();
        }

        private void BtnExitPlaystation_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Playstation_Load(object sender, EventArgs e)
        {

        }
    }
}
