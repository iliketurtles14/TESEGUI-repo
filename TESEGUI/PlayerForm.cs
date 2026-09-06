using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TESEGUI
{
    public partial class PlayerForm : Form
    {
        private Dictionary<string, string> jobDict = new Dictionary<string, string>
        {
            { "Janitor", "Janitor" }, { "Gardening", "Gardener" }, { "Library", "Library" },
            { "Mailman", "Mailroom" }, { "Deliveries", "Deliveries" }, { "Laundry", "Laundry" },
            { "Kitchen", "Kitchen" }, { "Tailorshop", "Tailor" }, { "Woodshop", "Woodshop" },
            { "Metalshop", "Metalshop" }
        };
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            NameTextBox.Text = SaveHolder.save.playerName;
            SaveHashTextBox.Text = SaveHolder.save.playerSaveHash;
            SaveCodeTextBox.Text = SaveHolder.save.playerSaveCode;
            PosXTextBox.Text = SaveHolder.save.playerPosX;
            PosYTextBox.Text = SaveHolder.save.playerPosY;
            LayerTextBox.Text = SaveHolder.save.playerLayer;
            CashTextBox.Text = SaveHolder.save.playerCash;
            HealthTextBox.Text = SaveHolder.save.playerHealth;
            HeatTextBox.Text = SaveHolder.save.playerHeat;
            FatigueTextBox.Text = SaveHolder.save.playerFatigue;
            StrengthTextBox.Text = SaveHolder.save.playerStrength;
            SpeedTextBox.Text = SaveHolder.save.playerSpeed;
            IntellectTextBox.Text = SaveHolder.save.playerIntellect;
            PlaytimeTextBox.Text = SaveHolder.save.playerPlaytime;
            MapTextBox.Text = SaveHolder.save.playerMap;
            MapNameTextBox.Text = SaveHolder.save.playerMapName;
            MapTypeTextBox.Text = SaveHolder.save.playerMapType;
            PScoreTextBox.Text = SaveHolder.save.playerPScore;
            NScoreTextBox.Text = SaveHolder.save.playerNScore;
            FScoreTextBox.Text = SaveHolder.save.playerFScore;
            TotalSuspicionTextBox.Text = SaveHolder.save.playerTotSus;
            string job = SaveHolder.save.playerJob;
            bool checkedJobButton = false;
            foreach(Control c in Controls)
            {
                if(c.Name == job + "Button")
                {
                    RadioButton rb = c as RadioButton;
                    rb.Checked = true;
                    checkedJobButton = true;
                    break;
                }
            }
            if (!checkedJobButton)
            {
                foreach(Control c in Controls)
                {
                    if(c.Name == "NoneButton")
                    {
                        RadioButton rb = c as RadioButton;
                        rb.Checked = true;
                        break;
                    }
                }
            }
            List<string> checkedTooltips = new List<string>();
            for(int i = 0; i < 17; i++)
            {
                if (SaveHolder.save.playerTooltips[i])
                {
                    checkedTooltips.Add((i + 1).ToString());
                }
            }
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(CheckBox) && checkedTooltips.Contains(c.Name.Replace("Tooltips", "").Replace("CheckBox", "")))
                {
                    CheckBox cb = c as CheckBox;
                    cb.Checked = true;
                }
            }
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            new InventoryForm().ShowDialog();
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
            SaveHolder.save.playerName = NameTextBox.Text;
            SaveHolder.save.playerSaveHash = SaveHashTextBox.Text;
            SaveHolder.save.playerSaveCode = SaveCodeTextBox.Text;
            SaveHolder.save.playerPosX = PosXTextBox.Text;
            SaveHolder.save.playerPosY = PosYTextBox.Text;
            SaveHolder.save.playerLayer = LayerTextBox.Text;
            SaveHolder.save.playerCash = CashTextBox.Text;
            SaveHolder.save.playerHealth = HealthTextBox.Text;
            SaveHolder.save.playerHeat = HeatTextBox.Text;
            SaveHolder.save.playerFatigue = FatigueTextBox.Text;
            SaveHolder.save.playerStrength = StrengthTextBox.Text;
            SaveHolder.save.playerSpeed = SpeedTextBox.Text;
            SaveHolder.save.playerIntellect = IntellectTextBox.Text;
            SaveHolder.save.playerPlaytime = PlaytimeTextBox.Text;
            SaveHolder.save.playerMap = MapTextBox.Text;
            SaveHolder.save.playerMapName = MapNameTextBox.Text;
            SaveHolder.save.playerMapType = MapTypeTextBox.Text;
            SaveHolder.save.playerPScore = PScoreTextBox.Text;
            SaveHolder.save.playerNScore = NScoreTextBox.Text;
            SaveHolder.save.playerFScore = FScoreTextBox.Text;
            SaveHolder.save.playerTotSus = TotalSuspicionTextBox.Text;
            string job = "";
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(RadioButton) && c.Name != "NoneButton")
                {
                    RadioButton rb = c as RadioButton;
                    if (rb.Checked)
                    {
                        job = c.Name.Replace("Button", "");
                        job = jobDict[job];
                        break;
                    }
                }
            }
            SaveHolder.save.playerJob = job;
            List<int> tooltipNums = new List<int>();
            foreach(Control c in Controls)
            {
                if(c.GetType() == typeof(CheckBox))
                {
                    CheckBox bc = c as CheckBox;
                    if (bc.Checked)
                    {
                        tooltipNums.Add(Convert.ToInt32(c.Name.Replace("Tooltips", "").Replace("CheckBox", "")) - 1);
                    }
                }
            }
            for(int i = 0; i < 17; i++)
            {
                if (tooltipNums.Contains(i))
                {
                    SaveHolder.save.playerTooltips[i] = true;
                }
                else
                {
                    SaveHolder.save.playerTooltips[i] = false;
                }
            }
        }
    }
}
