using Accessibility;
using TESE;

namespace TESEGUI
{
    public partial class MainForm : Form
    {
        public SaveFile saveFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a save file.");
            
            //get save file
            string path = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select a save file";
            string filter = "Save Files (*.sav)|*.sav";
            fileDialog.Filter = filter;
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
            }
            else
            {
                Application.Exit();
            }

            string[] rawSave = DecryptSave(path);
            saveFile = MakeSaveFile(rawSave);
        }
        private SaveFile MakeSaveFile(string[] rawSave)
        {
            string playerName = GetINIVar("Player", "Name", rawSave);
            string playerSaveHash = GetINIVar("Player", "SavHas", rawSave);
            string playerSaveCode = GetINIVar("Player", "SaveCode", rawSave);
            string[] locationArr = GetINIVar("Player", "Location", rawSave).Split("@");
            string playerPosX = locationArr[0];
            string playerPosY = locationArr[1];
            string playerLayer = locationArr[2];
            string[] vitalsArr = GetINIVar("Player", "Cash_HP_Heat_Fat", rawSave).Split("@");
            string playerCash = vitalsArr[0];
            string playerHealth = vitalsArr[1];
            string playerHeat = vitalsArr[2];
            string playerFatigue = vitalsArr[3];
            string[] statsArr = GetINIVar("Player", "Stats", rawSave).Split("@");
            string playerStrength = statsArr[0];
            string playerSpeed = statsArr[1];
            string playerIntellect = statsArr[2];
            string playerJob = GetINIVar("Player", "Job", rawSave);
            string rawWeapon = GetINIVar("Player", "Weapon", rawSave);
            Item playerWeapon = null;
            if (!String.IsNullOrEmpty(rawWeapon))
            {
                playerWeapon = new Item(rawWeapon.Split("_")[0], rawWeapon.Split("_")[1]);
            }
            string rawOutfit = GetINIVar("Player", "Outfit", rawSave);
            Item playerOutfit = null;
            if (!String.IsNullOrEmpty(rawOutfit))
            {
                playerOutfit = new Item(rawOutfit.Split("_")[0], rawOutfit.Split("_")[1]);
            }
            int playerCharacter = Convert.ToInt32(GetINIVar("Player", "Avatar", rawSave));
            List<Item> playerInventory = new List<Item>();
            string[] rawPlayerInv = GetINIVar("Player", "Inv", rawSave).Split("@");
            for(int i = 0; i < 6; i++)
            {
                Item item = null;
                if (String.IsNullOrEmpty(rawPlayerInv[i]))
                {
                    item = null;
                    playerInventory.Add(item);
                    continue;
                }
                item = new Item(rawPlayerInv[i].Split("_")[0], rawPlayerInv[i].Split("_")[0]);
                playerInventory.Add(item);
            }
            playerInventory.Add(playerWeapon);
            playerInventory.Add(playerOutfit);
            string playerPlaytime = GetINIVar("Player", "Playtime", rawSave);
            string[] rawTooltips = GetINIVar("Player", "Tooltips", rawSave).Split("@");
            List<bool> playerTooltips = new List<bool>();
            for(int i = 0; i < 17; i++)
            {
                bool isTrue = false;
                if (rawTooltips[i] != "0")
                {
                    isTrue = true;
                }
                playerTooltips.Add(isTrue);
            }
            string playerMap = GetINIVar("Player", "Map", rawSave);
            string playerMapName = GetINIVar("Player", "MapName", rawSave);
            string playerMapType = GetINIVar("Player", "MapType", rawSave);
            string[] scoreArr = GetINIVar("Player", "Score", rawSave).Split("@");
            string playerPScore = scoreArr[0];
            string playerNScore = scoreArr[1];
            string playerFScore = scoreArr[2];
            string playerTotSus = scoreArr[3];

        }
        private string[] DecryptSave(string path)
        {
            string key = "mothking";
            BlowfishCompat bf = new BlowfishCompat(key);
            byte[] fileBytes = File.ReadAllBytes(path);
            fileBytes = bf.Decrypt(fileBytes);
            string decrypted = System.Text.Encoding.UTF8.GetString(fileBytes);
            string[] rawSave = decrypted.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            return rawSave;
        }
        public string GetINIVar(string header, string varName, string[] file)
        {
            string line = null;

            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Contains(header) && file[i].Contains('[') && file[i].Contains(']'))
                {
                    for (int j = i; j < file.Length; j++)
                    {
                        if (file[j].Contains("[") && file[j].Contains("]") && j != i)
                        {
                            line = null;
                            break;
                        }
                        if (file[j].Split('=')[0] == varName)
                        {
                            line = file[j];
                            break;
                        }
                    }
                    break;
                }
            }



            if (line == null)
            {
                return null;
            }

            string[] parts = line.Split('=');
            return parts[1].Replace("\n", "").Replace("\r", "");
        }
    }
}
