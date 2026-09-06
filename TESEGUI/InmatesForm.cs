using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TESEGUI
{
    public partial class InmatesForm : Form
    {
        public List<Inmate> inmates = new List<Inmate>();
        public Inmate currentInmate;
        public int currentIndex;
        public InmatesForm()
        {
            InitializeComponent();
        }
        private void InmatesForm_Load(object sender, EventArgs e)
        {
            foreach(Inmate inmate in SaveHolder.save.inmates)
            {
                inmates.Add(inmate.Clone());
            }
            UpdateList(false, -1);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            new NPCInventoryForm().ShowDialog();
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            new ShopForm().ShowDialog();
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
            SaveHolder.save.inmates = inmates;
        }

        private void InmatesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentInmate != null)
            {
                currentInmate.name = NameTextBox.Text;
                currentInmate.strength = StrengthTextBox.Text;
                currentInmate.speed = SpeedTextBox.Text;
                currentInmate.intellect = IntellectTextBox.Text;
                currentInmate.opinion = OpinionTextBox.Text;
                currentInmate.flag2001 = Flag2001CheckBox.Checked;
                inmates[currentIndex] = currentInmate;
            }

            if(InmatesListBox.SelectedIndex != -1)
            {
                int index = InmatesListBox.SelectedIndex;
                Inmate inmate = inmates[index];
                currentInmate = inmate;
                currentIndex = index;
                NameTextBox.Text = inmate.name;
                StrengthTextBox.Text = inmate.strength;
                SpeedTextBox.Text = inmate.speed;
                IntellectTextBox.Text = inmate.intellect;
                OpinionTextBox.Text = inmate.opinion;
                Flag2001CheckBox.Checked = inmate.flag2001;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                inmates.RemoveAt(InmatesListBox.SelectedIndex);
                UpdateList(false, -1);
            }
            catch { }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Inmate inmate = new Inmate("", "", "", "", "", false, new List<Item>() { null, null, null, null, null, null }, 0, false, new List<Item>() { null, null, null, null });
            inmates.Add(inmate);
            UpdateList(true, InmatesListBox.SelectedIndex);
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (currentInmate != null)
            {
                currentInmate.name = NameTextBox.Text;
                UpdateList(true, currentIndex);
            }
        }
        private void UpdateList(bool shouldReselect, int index)
        {
            InmatesListBox.Items.Clear();
            int aIndex = 1;
            foreach (Inmate inmate in inmates)
            {
                InmatesListBox.Items.Add(aIndex.ToString() + ": " + inmate.name);
                aIndex++;
            }
            if (shouldReselect)
            {
                InmatesListBox.SelectedIndex = index;
            }
            else
            {
                InmatesListBox.SelectedIndex = -1;
                NameTextBox.Text = "";
                StrengthTextBox.Text = "";
                SpeedTextBox.Text = "";
                IntellectTextBox.Text = "";
                OpinionTextBox.Text = "";
                Flag2001CheckBox.Checked = false;
                currentInmate = null;
                currentIndex = -1;
            }
        }
    }
}
