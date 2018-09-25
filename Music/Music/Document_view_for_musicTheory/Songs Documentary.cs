using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Document_view_for_musicTheory
{
    public partial class Songs_Documentary : Form
    {
        public Songs_Documentary(string chordsUsed, List<string> chrodList)
        {
            InitializeComponent();
            textBox_chordsUsed.Text = "";
            listBox_scales.Items.Clear();

            textBox_chordsUsed.Text = chordsUsed;
            foreach (var item in chrodList)
            {
                listBox_scales.Items.Add(item);
            }
        }
    }
}
