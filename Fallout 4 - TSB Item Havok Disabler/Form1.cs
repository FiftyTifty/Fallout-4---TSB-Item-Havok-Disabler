using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Fallout_4___TSB_Item_Havok_Disabler_MainCode;

namespace Fallout_4___TSB_Item_Havok_Disabler
{
    public partial class formProgramWindow : Form
    {
        public formProgramWindow()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formButtonLoadBlueprint_Click(object sender, EventArgs e)
        {

            if (dialogOpenBlueprint.ShowDialog() == DialogResult.OK)
            {
                formTextBlueprintPath.Text = dialogOpenBlueprint.FileName;
            }

        }

        private void formButtonBegin_Click(object sender, EventArgs e)
        {

            if (File.Exists(formTextBlueprintPath.Text))
            {
                MainCode.ProcessBlueprint(formTextBlueprintPath.Text);
            }

        }
    }
}
