using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LBSoft;

namespace KoradKA3005P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbcKnob1_Scroll(object sender, ScrollEventArgs e)
        {
            lblLedVoltage.Value = lbcKnob1.Value;
        }

        private void LbcKnob1_KnobChangeValue(object sender, LBSoft.IndustrialCtrls.Knobs.LBKnobEventArgs e)
        {
            lblLedVoltage.Value = lbcKnob1.Value;
        }

        private void BtnAdjVoltage_Click(object sender, EventArgs e)
        {
            lblLedVoltage.ForeColor = Color.Red;
            lblLedCurrent.ForeColor = Color.DarkGray;
        }

        private void BtnAdjCurrent_Click(object sender, EventArgs e)
        {
            lblLedVoltage.ForeColor = Color.DarkGray;
            lblLedCurrent.ForeColor = Color.Red;
        }

        private void BtnSetVoltage_Click(object sender, EventArgs e)
        {

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
