using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TESEGUI
{
    public partial class GuardsForm : Form
    {
        public GuardsForm()
        {
            InitializeComponent();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            new NPCInventoryForm().ShowDialog();
        }

        private void CharacterButton_Click(object sender, EventArgs e)
        {
            new CharacterForm().ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void GuardsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }
    }
}
