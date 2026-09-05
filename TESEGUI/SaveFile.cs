using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace TESEGUI
{
    public class SaveFile
    {
        public string playerName;
        public string playerSaveHash;
        public string playerSaveCode;
        public string playerPosX;
        public string playerPosY;
        public string playerLayer;
        public string playerCash;
        public string playerHealth;
        public string playerHeat;
        public string playerFatigue;
        public string playerStrength;
        public string playerSpeed;
        public string playerIntellect;
        public string playerPlaytime;
        public string playerMap;
        public string playerMapName;
        public string playerMapType;
        public string playerPScore;
        public string playerNScore;
        public string playerFScore;
        public string playerTotSus;
        public string playerJob;
        public List<bool> playerTooltips;
        public List<Item> playerInventory; //weapon is at index 6 and outfit is at index 7
        public int playerCharacter;
        public List<Inmate> inmates;
        public List<Guard> guards;
        public string prisonDay;
        public string prisonVersion;
        public bool prisonHint1;
        public bool prisonHint2;
        public bool prisonHint3;
        public List<Mine> prisonMines;
        public List<DugSoil> prisonDugSoils;
        public List<Rock> prisonRocks;
        public List<Hole> prisonHoles;
        public List<Brace> prisonBraces;
        public List<Alert> prisonAlerts;
        public List<Curtain> prisonCurtains;
        public List<Stash> prisonStashes;
        public List<Vent> prisonVents;
        public List<Slat> prisonSlats;
        public List<Wall> prisonWalls;
        public List<Removed> prisonRemoveds;
        public int jobsJanitor;
        public int jobsGardening;
        public int jobsLaundry;
        public int jobsKitchen;
        public int jobsTailorshop;
        public int jobsWoodshop;
        public int jobsMetalshop;
        public int jobsLibrary;
        public int jobsMailman;
        public int jobsDeliveries;
        public string trackingCuts;
        public string trackingChipped;
        public string trackingDug;
        public string trackingDowned;
        public string trackingOi;
        public List<Desk> desks;
        public List<Container> containers;
        public List<FloorItem> floorItems;
        public SaveFile(string playerName, string playerSaveHash, string playerSaveCode,
            string playerPosX, string playerPosY, string playerLayer, string playerCash,
            string playerHealth, string playerHeat, string playerFatigue, string playerStrength,
            string playerSpeed, string playerIntellect, string playerPlaytime, string playerMap,
            string playerMapName, string playerMapType, string playerPScore, string playerNScore,
            string playerFScore, string playerTotSus, string playerJob, List<bool> playerTooltips,
            List<Item> playerInventory, int playerCharacter, List<Inmate> inmates, List<Guard> guards,
            string prisonDay, string prisonVersion, bool prisonHint1, bool prisonHint2, bool prisonHint3,
            List<Mine> prisonMines, List<DugSoil> prisonDugSoils, List<Rock> prisonRocks,
            List<Hole> prisonHoles, List<Brace> prisonBraces, List<Alert> prisonAlerts,
            List<Curtain> prisonCurtains, List<Stash> prisonStashes, List<Vent> prisonVents,
            List<Slat> prisonSlats, List<Wall> prisonWalls, List<Removed> prisonRemoveds,
            int jobsJanitor, int jobsGardening, int jobsLaundry, int jobsKitchen, int jobsTailorshop,
            int jobsWoodshop, int jobsMetalshop, int jobsLibrary, int jobsMailman, int jobsDeliveries,
            string trackingCuts, string trackingChipped, string trackingDug, string trackingDowned,
            string trackingOi, List<Desk> desks, List<Container> containers, List<FloorItem> floorItems)
        {
            this.playerName = playerName;
            this.playerSaveHash = playerSaveHash;
            this.playerSaveCode = playerSaveCode;
            this.playerPosX = playerPosX;
            this.playerPosY = playerPosY;
            this.playerLayer = playerLayer;
            this.playerCash = playerCash;
            this.playerHealth = playerHealth;
            this.playerHeat = playerHeat;
            this.playerFatigue = playerFatigue;
            this.playerStrength = playerStrength;
            this.playerSpeed = playerSpeed;
            this.playerIntellect = playerIntellect;
            this.playerPlaytime = playerPlaytime;
            this.playerMap = playerMap;
            this.playerMapName = playerMapName;
            this.playerMapType = playerMapType;
            this.playerPScore = playerPScore;
            this.playerNScore = playerNScore;
            this.playerFScore = playerFScore;
            this.playerTotSus = playerTotSus;
            this.playerJob = playerJob;
            this.playerTooltips = playerTooltips;
            this.playerInventory = playerInventory;
            this.playerCharacter = playerCharacter;
            this.inmates = inmates;
            this.guards = guards;
            this.prisonDay = prisonDay;
            this.prisonVersion = prisonVersion;
            this.prisonHint1 = prisonHint1;
            this.prisonHint2 = prisonHint2;
            this.prisonHint3 = prisonHint3;
            this.prisonMines = prisonMines;
            this.prisonDugSoils = prisonDugSoils;
            this.prisonRocks = prisonRocks;
            this.prisonHoles = prisonHoles;
            this.prisonBraces = prisonBraces;
            this.prisonAlerts = prisonAlerts;
            this.prisonCurtains = prisonCurtains;
            this.prisonStashes = prisonStashes;
            this.prisonVents = prisonVents;
            this.prisonSlats = prisonSlats;
            this.prisonWalls = prisonWalls;
            this.prisonRemoveds = prisonRemoveds;
            this.jobsJanitor = jobsJanitor;
            this.jobsGardening = jobsGardening;
            this.jobsLaundry = jobsLaundry;
            this.jobsKitchen = jobsKitchen;
            this.jobsTailorshop = jobsTailorshop;
            this.jobsWoodshop = jobsWoodshop;
            this.jobsMetalshop = jobsMetalshop;
            this.jobsLibrary = jobsLibrary;
            this.jobsMailman = jobsMailman;
            this.jobsDeliveries = jobsDeliveries;
            this.trackingCuts = trackingCuts;
            this.trackingChipped = trackingChipped;
            this.trackingDug = trackingDug;
            this.trackingDowned = trackingDowned;
            this.trackingOi = trackingOi;
            this.desks = desks;
            this.containers = containers;
            this.floorItems = floorItems;
        }
    }
}
