//2016245983
//Nxele Siphenathi
//CSIS2614 project 9
//Due date:15 April 2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class CfrmTextEditor : Form
    {
        CDynamicStack<string> stack = new CDynamicStack<string>(0);
        public CfrmTextEditor()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlgFont = new FontDialog();
            if (dlgFont.ShowDialog() == DialogResult.OK);
            {
                rchtxtEditor.SelectionFont = dlgFont.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlgColour = new ColorDialog();
            if(dlgColour.ShowDialog()== DialogResult.OK)
            {
                rchtxtEditor.SelectionColor = dlgColour.Color;
            }
        }

        private void rchtxtEditor_TextChanged(object sender, EventArgs e)
        {

            stack.Push(rchtxtEditor.Rtf);
            lstbxRedo.Items.Add(stack.Pop());
          
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by \nName :Nxele Siphenathi\nStudent number: 2016245983\nAs\nCSIS2614 project 9");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CfrmTextEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                rchtxtEditor.SelectionFont = new Font(rchtxtEditor.SelectionFont, FontStyle.Underline);

            }
            if (e.Control == true && e.KeyCode == Keys.I)
            {
                rchtxtEditor.SelectionFont = new Font(rchtxtEditor.SelectionFont, FontStyle.Italic);
            }
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                rchtxtEditor.SelectionFont = new Font(rchtxtEditor.SelectionFont, FontStyle.Bold);

            }
        }
    }
}
//blob:https://www.youtube.com/82d8d005-e024-4b09-a6eb-42b6096d9d02
//https://stackoverflow.com/questions/821347/how-to-selectively-underline-strings-in-richtextbox
