using Accessibility;
using System.Windows.Forms.VisualStyles;
using TESE;

namespace TESEGUI
{
    public partial class MainForm : Form
    {
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
            fileDialog.Title = "Select a save file.";
            string filter = "TE Save Files (*.dat)|*.dat";
            fileDialog.Filter = filter;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
            }
            else
            {
                Application.Exit();
            }

            string[] rawSave = DecryptSave(path);
            SaveHolder.save = MakeSaveFile(rawSave);
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
            for (int i = 0; i < 6; i++)
            {
                Item item = null;
                if (String.IsNullOrEmpty(rawPlayerInv[i]) || !rawPlayerInv.Contains("_"))
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
            for (int i = 0; i < 17; i++)
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

            int inmateCount = GetINIFinalNum("Inmates", rawSave); //starts at 1
            List<Inmate> inmates = new List<Inmate>();
            if (inmateCount != -1)
            {
                for (int i = 1; i < inmateCount + 1; i++)
                {
                    string rawData = GetINIVar("Inmates", i.ToString(), rawSave);
                    string[] data = rawData.Split("@");
                    string inmateName = data[0];
                    string inmateStrength = data[1];
                    string inmateSpeed = data[2];
                    string inmateIntellect = data[3];
                    string inmateOpinion = data[4];
                    bool flag2001 = data[5] != "0";
                    int inmateCharacter = Convert.ToInt32(data[6]);

                    //shop
                    string rawShopData = data[7];
                    bool hasShop = true;
                    if (rawShopData == "0,0,0,0")
                    {
                        hasShop = false;
                    }
                    string[] shopData = rawShopData.Split(",");
                    List<Item> shopInventory = new List<Item>();
                    if (hasShop)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (!shopData[j].Contains("_"))
                            {
                                shopInventory.Add(null);
                                continue;
                            }
                            string[] itemData = shopData[j].Split("_");
                            Item item = new Item(itemData[0], itemData[1]);
                            shopInventory.Add(item);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            shopInventory.Add(null);
                        }
                    }

                    //inv
                    string rawInmateInv = GetINIVar("Inmate_Inven", i.ToString(), rawSave);
                    string[] inmateInvData = rawInmateInv.Split("@");
                    List<Item> inmateInventory = new List<Item>();
                    for (int j = 0; j < 6; j++)
                    {
                        if (!inmateInvData[j].Contains("_"))
                        {
                            inmateInventory.Add(null);
                            continue;
                        }
                        string[] itemData = inmateInvData[j].Split("_");
                        Item item = new Item(itemData[0], itemData[1]);
                        inmateInventory.Add(item);
                    }

                    //make inmate
                    Inmate inmate = new Inmate(inmateName, inmateStrength, inmateSpeed, inmateIntellect, inmateOpinion, flag2001, inmateInventory, inmateCharacter, hasShop, shopInventory);
                    inmates.Add(inmate);
                }
            }

            int guardCount = GetINIFinalNum("Guards", rawSave); //starts at 1
            List<Guard> guards = new List<Guard>();
            if (guardCount != -1)
            {
                for (int i = 1; i < guardCount + 1; i++)
                {
                    string rawData = GetINIVar("Guards", i.ToString(), rawSave);
                    string[] data = rawData.Split("@");
                    string guardName = data[0];
                    string guardStrength = data[1];
                    string guardSpeed = data[2];
                    string guardIntellect = data[3];
                    string guardOpinion = data[4];
                    List<string> guardPatrol = new List<string>();
                    string rawPatrol = data[5];
                    string[] patrolData = rawPatrol.Split("_");
                    for (int j = 0; j < 5; j++)
                    {
                        guardPatrol.Add(patrolData[j]);
                    }
                    bool flag2001 = data[6] != "0";

                    //inv
                    string rawGuardInv = GetINIVar("Guard_Inven", i.ToString(), rawSave);
                    string[] guardInvData = rawGuardInv.Split("@");
                    List<Item> guardInventory = new List<Item>();
                    for (int j = 0; j < 6; j++)
                    {
                        if (!guardInvData[j].Contains("_"))
                        {
                            guardInventory.Add(null);
                            continue;
                        }
                        string[] itemData = guardInvData[j].Split("_");
                        Item item = new Item(itemData[0], itemData[1]);
                        guardInventory.Add(item);
                    }

                    Guard guard = new Guard(guardName, guardStrength, guardSpeed, guardIntellect, guardOpinion, guardPatrol, flag2001, guardInventory);
                    guards.Add(guard);
                }
            }

            int jobsJanitor = Convert.ToInt32(GetINIVar("Jobs", "Janitor", rawSave));
            int jobsLaundry = Convert.ToInt32(GetINIVar("Jobs", "Laundry", rawSave));
            int jobsWoodshop = Convert.ToInt32(GetINIVar("Jobs", "Woodshop", rawSave));
            int jobsMetalshop = Convert.ToInt32(GetINIVar("Jobs", "Metalshop", rawSave));
            int jobsKitchen = Convert.ToInt32(GetINIVar("Jobs", "Kitchen", rawSave));
            int jobsGardening = Convert.ToInt32(GetINIVar("Jobs", "Gardener", rawSave));
            int jobsTailorshop = Convert.ToInt32(GetINIVar("Jobs", "Tailor", rawSave));
            int jobsDeliveries = Convert.ToInt32(GetINIVar("Jobs", "Deliveries", rawSave));
            int jobsMailman = Convert.ToInt32(GetINIVar("Jobs", "Mailroom", rawSave));
            int jobsLibrary = Convert.ToInt32(GetINIVar("Jobs", "Library", rawSave));

            string trackingCuts = GetINIVar("Tracking", "Cuts", rawSave);
            string trackingChipped = GetINIVar("Tracking", "Chipped", rawSave);
            string trackingDug = GetINIVar("Tracking", "Dug", rawSave);
            string trackingDowned = GetINIVar("Tracking", "Downed", rawSave);
            string trackingOi = GetINIVar("Tracking", "Oi", rawSave);

            int deskCount = GetINIFinalNum("Desks", rawSave); //starts at 0
            List<Desk> desks = new List<Desk>();
            if (deskCount != -1)
            {
                for (int i = 0; i < deskCount; i++)
                {
                    string rawDeskData = GetINIVar("Desks", i.ToString(), rawSave);
                    string[] deskData = rawDeskData.Split("@");
                    string deskPosX = deskData[0];
                    string deskPosy = deskData[1];
                    string objectID = deskData[2];
                    string rawInvData = deskData[3];
                    string[] invData = rawInvData.Split("?");
                    List<Item> deskInv = new List<Item>();
                    for (int j = 0; j < 20; j++)
                    {
                        string rawItemData = invData[j];
                        if (!rawItemData.Contains("_"))
                        {
                            deskInv.Add(null);
                            continue;
                        }
                        string[] itemData = rawItemData.Split("_");
                        Item item = new Item(itemData[0], itemData[1]);
                        deskInv.Add(item);
                    }
                    Desk desk = new Desk(deskPosX, deskPosy, objectID, deskInv);
                    desks.Add(desk);
                }
            }

            int containerCount = GetINIFinalNum("Containers", rawSave); //starts at 1
            List<Container> containers = new List<Container>();
            if (containerCount != -1)
            {
                for (int i = 1; i < containerCount + 1; i++)
                {
                    string rawContainerData = GetINIVar("Containers", i.ToString(), rawSave);
                    string[] containerData = rawContainerData.Split("@");
                    string containerPosX = containerData[0];
                    string containerPosY = containerData[1];
                    string containerDir = containerData[2];
                    string rawInvData = containerData[3];
                    string[] invData = rawInvData.Split("?");
                    List<Item> containerInv = new List<Item>();
                    for (int j = 0; j < 20; j++)
                    {
                        string rawItemData = invData[j];
                        if (!rawItemData.Contains("_"))
                        {
                            containerInv.Add(null);
                            continue;
                        }
                        string[] itemData = rawItemData.Split("_");
                        Item item = new Item(itemData[0], itemData[1]);
                        containerInv.Add(item);
                    }
                    Container container = new Container(containerPosX, containerPosY, containerDir, containerInv);
                    containers.Add(container);
                }
            }

            int floorItemCount = GetINIFinalNum("FloorItems", rawSave); //starts at 1
            List<FloorItem> floorItems = new List<FloorItem>();
            if (floorItemCount != -1)
            {
                for (int i = 1; i < floorItemCount + 1; i++)
                {
                    string rawFloorItemData = GetINIVar("FloorItems", i.ToString(), rawSave);
                    string[] floorItemData = rawFloorItemData.Split("@");
                    string itemPosX = floorItemData[0];
                    string itemPosY = floorItemData[1];
                    string itemLayer = floorItemData[2];
                    string itemID = floorItemData[3];
                    string itemDurab = floorItemData[4];
                    Item item = new Item(itemID, itemDurab);
                    FloorItem floorItem = new FloorItem(itemPosX, itemPosY, itemLayer, item);
                    floorItems.Add(floorItem);
                }
            }

            List<Mine> mines = new List<Mine>();
            List<DugSoil> dugSoils = new List<DugSoil>();
            List<Rock> rocks = new List<Rock>();
            List<Hole> holes = new List<Hole>();
            List<Brace> braces = new List<Brace>();
            List<Alert> alerts = new List<Alert>();
            List<Curtain> curtains = new List<Curtain>();
            List<Stash> stashes = new List<Stash>();
            List<Vent> vents = new List<Vent>();
            List<Slat> slats = new List<Slat>();
            string fakeWalls = GetINIVar("Prison", "FakeWalls", rawSave);
            string removeSlats = GetINIVar("Prison", "RemoveSlats", rawSave);
            string prisonDay = GetINIVar("Prison", "Day", rawSave);
            bool prisonHint1 = GetINIVar("Prison", "Hint1", rawSave) != "0";
            bool prisonHint2 = GetINIVar("Prison", "Hint2", rawSave) != "0";
            bool prisonHint3 = GetINIVar("Prison", "Hint3", rawSave) != "0";
            string prisonVersion = GetINIVar("Prison", "Version", rawSave);

            string rawMineData = GetINIVar("Prison", "Mines", rawSave);
            string[] mineData = rawMineData.Split("@");
            string rawSoilData = GetINIVar("Prison", "DugSoil", rawSave);
            string[] soilData = rawSoilData.Split("@");
            string rawHoleData = GetINIVar("Prison", "Holes", rawSave);
            string[] holeData = rawHoleData.Split("@");
            string rawRockData = GetINIVar("Prison", "Rocks", rawSave);
            string[] rockData = rawRockData.Split("@");
            string rawBraceData = GetINIVar("Prison", "Braces", rawSave);
            string[] braceData = rawBraceData.Split("@");
            string rawAlertData = GetINIVar("Prison", "Alerts", rawSave);
            string[] alertData = rawAlertData.Split("@");
            string rawCurtData = GetINIVar("Prison", "Curts", rawSave);
            string[] curtData = rawCurtData.Split("@");
            string rawStashData = GetINIVar("Prison", "Crates", rawSave);
            string[] stashData = rawStashData.Split("@");
            string rawVentData = GetINIVar("Prison", "FakeVents", rawSave);
            string[] ventData = rawVentData.Split("@");
            string rawSlatData = GetINIVar("Prison", "SlatHP", rawSave);
            string[] slatData = rawSlatData.Split("@");

            for (int i = 0; i < mineData.Length; i++)
            {
                if (String.IsNullOrEmpty(mineData[i]))
                {
                    continue;
                }
                string posX = mineData[i].Split("x")[0];
                string posY = mineData[i].Split("x")[1];
                Mine mine = new Mine(posX, posY);
                mines.Add(mine);
            }
            for (int i = 0; i < soilData.Length; i++)
            {
                if (String.IsNullOrEmpty(soilData[i]))
                {
                    continue;
                }
                string posX = soilData[i].Split("x")[0];
                string posY = soilData[i].Split("x")[1];
                DugSoil soil = new DugSoil(posX, posY);
                dugSoils.Add(soil);
            }
            for (int i = 0; i < holeData.Length; i++)
            {
                if (String.IsNullOrEmpty(holeData[i]))
                {
                    continue;
                }
                string posX = holeData[i].Split("x")[0];
                string posY = holeData[i].Split("x")[1];
                string openLevel = holeData[i].Split("x")[2];
                Hole hole = new Hole(posX, posY, openLevel);
                holes.Add(hole);
            }
            for (int i = 0; i < rockData.Length; i++)
            {
                if (String.IsNullOrEmpty(rockData[i]))
                {
                    continue;
                }
                string posX = rockData[i].Split("x")[0];
                string posY = rockData[i].Split("x")[1];
                string durab = rockData[i].Split("x")[2];
                Rock rock = new Rock(posX, posY, durab);
                rocks.Add(rock);
            }
            for (int i = 0; i < braceData.Length; i++)
            {
                if (String.IsNullOrEmpty(braceData[i]))
                {
                    continue;
                }
                string posX = braceData[i].Split("x")[0];
                string posY = braceData[i].Split("x")[1];
                Brace brace = new Brace(posX, posY);
                braces.Add(brace);
            }
            for (int i = 0; i < alertData.Length; i++)
            {
                if (String.IsNullOrEmpty(alertData[i]))
                {
                    continue;
                }
                string posX = alertData[i].Split("_")[0];
                string posY = alertData[i].Split("_")[1];
                string type = alertData[i].Split("_")[2];
                string dVal = alertData[i].Split("_")[3];
                Alert alert = new Alert(posX, posY, type, dVal);
                alerts.Add(alert);
            }
            for (int i = 0; i < curtData.Length; i++)
            {
                if (String.IsNullOrEmpty(curtData[i]))
                {
                    continue;
                }
                string posX = curtData[i].Split("_")[0];
                string posY = curtData[i].Split("_")[1];
                string type = curtData[i].Split("_")[2];
                Curtain curtain = new Curtain(posX, posY, type);
                curtains.Add(curtain);
            }
            for (int i = 0; i < stashData.Length; i++)
            {
                if (String.IsNullOrEmpty(stashData[i]))
                {
                    continue;
                }
                string posX = stashData[i].Split("_")[0];
                string posY = stashData[i].Split("_")[1];
                string layer = stashData[i].Split("_")[2];
                Stash stash = new Stash(posX, posY, layer);
                stashes.Add(stash);
            }
            for (int i = 0; i < ventData.Length; i++)
            {
                if (String.IsNullOrEmpty(ventData[i]))
                {
                    continue;
                }
                string posX = ventData[i].Split("_")[0];
                string posY = ventData[i].Split("_")[1];
                string durab = ventData[i].Split("_")[2];
                bool isFake = true;
                if (ventData[i].Split("_").Length == 4)
                {
                    if (ventData[i].Split("_")[3] == "-1")
                    {
                        isFake = false;
                    }
                }
                Vent vent = new Vent(posX, posY, durab, isFake);
                vents.Add(vent);
            }
            for (int i = 0; i < slatData.Length; i++)
            {
                if (String.IsNullOrEmpty(slatData[i]))
                {
                    continue;
                }
                string posX = slatData[i].Split("_")[0];
                string posY = slatData[i].Split("_")[1];
                string durab = slatData[i].Split("_")[2];
                Slat slat = new Slat(posX, posY, durab);
                slats.Add(slat);
            }

            //make SaveFile object
            SaveFile save = new SaveFile(playerName, playerSaveHash, playerSaveCode, playerPosX, playerPosY, playerLayer, playerCash, playerHealth, playerHeat, playerFatigue, playerStrength, playerSpeed, playerIntellect, playerPlaytime, playerMap, playerMapName, playerMapType, playerPScore, playerNScore, playerFScore, playerTotSus, playerJob, playerTooltips, playerInventory, playerCharacter, inmates, guards, prisonDay, prisonVersion, prisonHint1, prisonHint2, prisonHint3, mines, dugSoils, rocks, holes, braces, alerts, curtains, stashes, vents, slats, jobsJanitor, jobsGardening, jobsLaundry, jobsKitchen, jobsTailorshop, jobsWoodshop, jobsMetalshop, jobsLibrary, jobsMailman, jobsDeliveries, trackingCuts, trackingChipped, trackingDug, trackingDowned, trackingOi, desks, containers, floorItems);
            return save;
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
        public int GetINIFinalNum(string header, string[] file)
        {
            int headerIndex = -1;
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Contains("[") && file[i].Contains("]") && file[i].Contains(header))
                {
                    headerIndex = i;
                }
            }
            if (headerIndex == -1)
            {
                return -1;
            }

            int biggestNum = -1;
            for (int i = headerIndex + 1; i < file.Length; i++)
            {
                if (file[i].Contains("="))
                {
                    try
                    {
                        biggestNum = Convert.ToInt32(file[i].Split("=")[0]);
                    }
                    catch { }
                }
                else if (file[i].Contains("["))
                {
                    break;
                }
            }
            return biggestNum;
        }

        private void PlayerButton_Click(object sender, EventArgs e)
        {
            new PlayerForm().ShowDialog();
        }

        private void InmatesButton_Click(object sender, EventArgs e)
        {
            new InmatesForm().ShowDialog();
        }

        private void GuardsButton_Click(object sender, EventArgs e)
        {
            new GuardsForm().ShowDialog();
        }

        private void PrisonButton_Click(object sender, EventArgs e)
        {
            new PrisonForm().ShowDialog();
        }

        private void JobsButton_Click(object sender, EventArgs e)
        {
            new JobsForm().ShowDialog();
        }

        private void TrackingButton_Click(object sender, EventArgs e)
        {
            new TrackingForm().ShowDialog();
        }

        private void DesksButton_Click(object sender, EventArgs e)
        {
            new DesksForm().ShowDialog();
        }

        private void ContainersButton_Click(object sender, EventArgs e)
        {
            new ContainersForm().ShowDialog();
        }

        private void FloorItemsButton_Click(object sender, EventArgs e)
        {
            new FloorItemsForm().ShowDialog();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {

        }

        private void PositionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
