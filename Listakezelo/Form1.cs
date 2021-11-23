using System;
using System.Windows.Forms;

namespace Listakezelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateItemsCount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (! listBox.Items.Contains(textBoxNewItem.Text))
                listBox.Items.Add(textBoxNewItem.Text);
            UpdateItemsCount();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
            UpdateItemsCount();
        }

        private void UpdateItemsCount()
        {
            labelItemsCount.Text = listBox.Items.Count.ToString();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            UpdateItemsCount();
        }

        private void buttonBgColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)  
            {  
                listBox.BackColor = colorDialog.Color;
            }  
            
        }

        private void buttonTxtColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)  
            {  
                listBox.ForeColor = colorDialog.Color;
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            listBox.Sorted = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}