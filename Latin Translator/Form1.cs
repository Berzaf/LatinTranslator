/* Program: Latin Translator
 * Programmer: Berzaf Teklu
 * September, 3, 2020
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class LatinTranslator : Form
    {
        public LatinTranslator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LatinTranslator_Load(object sender, EventArgs e)
        {

        }

        private void btnLatinSinister_Click(object sender, EventArgs e)
        {
            //display "Left" in lblOutput
            lblOutput.Text = "Left";
            lblOutput.Left = 40;
        }

        private void btmLatinMedium_Click(object sender, EventArgs e)
        {
            //display "Center" in lblOutput
            lblOutput.Text = "Center";
            lblOutput.Left = (this.ClientSize.Width - lblOutput.Width) / 2;

        }

        private void btnLatinDexter_Click(object sender, EventArgs e)
        {
            //display "Right" in lblOutput
            lblOutput.Text = "Right";
            lblOutput.Left = 450;


        }
    }
}
