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

        private void InitCustomFontCollection()
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.DSEG7Classic_Bold.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.DSEG7Classic_Bold;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            //After that we can create font and assign font to label
            lblLedVoltage.Font = new Font(pfc.Families[0], lblLedVoltage.Font.Size);
            lblLedVoltage.Text = "0000";
            lblLedVoltage.TextAlign = ContentAlignment.MiddleRight;

            lblLedCurrent.Font = new Font(pfc.Families[0], lblLedCurrent.Font.Size);
            lblLedCurrent.Text = "0000";
            lblLedCurrent.TextAlign = ContentAlignment.MiddleRight;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitCustomFontCollection();


        }

        private void LbcKnob1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void LbcKnob1_KnobChangeValue(object sender, LBSoft.IndustrialCtrls.Knobs.LBKnobEventArgs e)
        {
            lblLedVoltage.Text = $"{lbcKnob1.Value:00.0}";
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
    }
}
