using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class NPC_AI
    {
        // NPC's numerical disposition toward the player.
        public static int iDisposition1;
        public static int iDisposition2;
        public static int iDisposition3;
        public static int iDisposition4;
        public static int iDisposition5;
        public static int iDisposition6;
        public static int iDisposition7;

        // NPC's descriptive disposition toward the player.
        public static string sDisposition1;
        public static string sDisposition2;
        public static string sDisposition3;
        public static string sDisposition4;
        public static string sDisposition5;
        public static string sDisposition6;
        public static string sDisposition7;

        // Gender tokens for referencing NPCs.
        public static string
        sGenderHisHer, sGenderHeShe, sGenderHimHer, sGenderGuyGirl,
        sGenderHisHer01, sGenderHeShe01, sGenderHimHer01, sGenderGuyGirl01,
        sGenderHisHer02, sGenderHeShe02, sGenderHimHer02, sGenderGuyGirl02,
        sGenderHisHer03, sGenderHeShe03, sGenderHimHer03, sGenderGuyGirl03,
        sGenderHisHer04, sGenderHeShe04, sGenderHimHer04, sGenderGuyGirl04,
        sGenderHisHer05, sGenderHeShe05, sGenderHimHer05, sGenderGuyGirl05,
        sGenderHisHer06, sGenderHeShe06, sGenderHimHer06, sGenderGuyGirl06;

        public static string sGenderBrotherSister02;

        // Temp Variables
        public static bool bTempCorpse;

        // The weapons
        public static string
        sTempWeapons, sWeaponType0, sWeaponType1, sWeaponType2, sWeaponType3,
        sWeaponType4, sWeaponType5;

        // Variables created for the NPCs.
        public static string
        NPC_001, NPC_002, NPC_003, NPC_004, NPC_005,
        NPC_006, NPC_007, NPC_008, NPC_009, NPC_010,
        NPC_011, NPC_012, NPC_013, NPC_014, NPC_015,
        NPC_016, NPC_017, NPC_018, NPC_019, NPC_020,
        NPC_021, NPC_022, NPC_023, NPC_024, NPC_025,
        NPC_026, NPC_027, NPC_028, NPC_029, NPC_030,
        NPC_031, NPC_032, NPC_033, NPC_034, NPC_035,
        NPC_036, NPC_037, NPC_038, NPC_039, NPC_040,
        NPC_041, NPC_042, NPC_043, NPC_044, NPC_045,
        NPC_046, NPC_047, NPC_048, NPC_049, NPC_050,
        NPC_051, NPC_052, NPC_053, NPC_054, NPC_055,
        NPC_056, NPC_057, NPC_058, NPC_059, NPC_060,
        NPC_061, NPC_062, NPC_063, NPC_064, NPC_065,
        NPC_066, NPC_067, NPC_068, NPC_069, NPC_070,
        NPC_071, NPC_072, NPC_073, NPC_074, NPC_075,
        NPC_076, NPC_077, NPC_078, NPC_079, NPC_080,
        NPC_081, NPC_082, NPC_083, NPC_084, NPC_085,
        NPC_086, NPC_087, NPC_088, NPC_089, NPC_090,
        NPC_091, NPC_092, NPC_093, NPC_094, NPC_095,
        NPC_096, NPC_097, NPC_098, NPC_099, NPC_100;

        public static string tempNPC;

        // How much money each NPC has available.
        public static int
        iAvailableMacGuffins001, iAvailableMacGuffins002, iAvailableMacGuffins003, iAvailableMacGuffins004, iAvailableMacGuffins005,
        iAvailableMacGuffins006, iAvailableMacGuffins007, iAvailableMacGuffins008, iAvailableMacGuffins009, iAvailableMacGuffins010,
        iAvailableMacGuffins011, iAvailableMacGuffins012, iAvailableMacGuffins013, iAvailableMacGuffins014, iAvailableMacGuffins015,
        iAvailableMacGuffins016, iAvailableMacGuffins017, iAvailableMacGuffins018, iAvailableMacGuffins019, iAvailableMacGuffins020,
        iAvailableMacGuffins021, iAvailableMacGuffins022, iAvailableMacGuffins023, iAvailableMacGuffins024, iAvailableMacGuffins025,
        iAvailableMacGuffins026, iAvailableMacGuffins027, iAvailableMacGuffins028, iAvailableMacGuffins029, iAvailableMacGuffins030,
        iAvailableMacGuffins031, iAvailableMacGuffins032, iAvailableMacGuffins033, iAvailableMacGuffins034, iAvailableMacGuffins035,
        iAvailableMacGuffins036, iAvailableMacGuffins037, iAvailableMacGuffins038, iAvailableMacGuffins039, iAvailableMacGuffins040,
        iAvailableMacGuffins041, iAvailableMacGuffins042, iAvailableMacGuffins043, iAvailableMacGuffins044, iAvailableMacGuffins045,
        iAvailableMacGuffins046, iAvailableMacGuffins047, iAvailableMacGuffins048, iAvailableMacGuffins049, iAvailableMacGuffins050,
        iAvailableMacGuffins051, iAvailableMacGuffins052, iAvailableMacGuffins053, iAvailableMacGuffins054, iAvailableMacGuffins055,
        iAvailableMacGuffins056, iAvailableMacGuffins057, iAvailableMacGuffins058, iAvailableMacGuffins059, iAvailableMacGuffins060,
        iAvailableMacGuffins061, iAvailableMacGuffins062, iAvailableMacGuffins063, iAvailableMacGuffins064, iAvailableMacGuffins065,
        iAvailableMacGuffins066, iAvailableMacGuffins067, iAvailableMacGuffins068, iAvailableMacGuffins069, iAvailableMacGuffins070,
        iAvailableMacGuffins071, iAvailableMacGuffins072, iAvailableMacGuffins073, iAvailableMacGuffins074, iAvailableMacGuffins075,
        iAvailableMacGuffins076, iAvailableMacGuffins077, iAvailableMacGuffins078, iAvailableMacGuffins079, iAvailableMacGuffins080,
        iAvailableMacGuffins081, iAvailableMacGuffins082, iAvailableMacGuffins083, iAvailableMacGuffins084, iAvailableMacGuffins085,
        iAvailableMacGuffins086, iAvailableMacGuffins087, iAvailableMacGuffins088, iAvailableMacGuffins089, iAvailableMacGuffins090,
        iAvailableMacGuffins091, iAvailableMacGuffins092, iAvailableMacGuffins093, iAvailableMacGuffins094, iAvailableMacGuffins095,
        iAvailableMacGuffins096, iAvailableMacGuffins097, iAvailableMacGuffins098, iAvailableMacGuffins099, iAvailableMacGuffins100;

        // What weapon each NPC has.
        public static string
        sAvailableWeapons001, sAvailableWeapons002, sAvailableWeapons003, sAvailableWeapons004, sAvailableWeapons005,
        sAvailableWeapons006, sAvailableWeapons007, sAvailableWeapons008, sAvailableWeapons009, sAvailableWeapons010,
        sAvailableWeapons011, sAvailableWeapons012, sAvailableWeapons013, sAvailableWeapons014, sAvailableWeapons015,
        sAvailableWeapons016, sAvailableWeapons017, sAvailableWeapons018, sAvailableWeapons019, sAvailableWeapons020,
        sAvailableWeapons021, sAvailableWeapons022, sAvailableWeapons023, sAvailableWeapons024, sAvailableWeapons025,
        sAvailableWeapons026, sAvailableWeapons027, sAvailableWeapons028, sAvailableWeapons029, sAvailableWeapons030,
        sAvailableWeapons031, sAvailableWeapons032, sAvailableWeapons033, sAvailableWeapons034, sAvailableWeapons035,
        sAvailableWeapons036, sAvailableWeapons037, sAvailableWeapons038, sAvailableWeapons039, sAvailableWeapons040,
        sAvailableWeapons041, sAvailableWeapons042, sAvailableWeapons043, sAvailableWeapons044, sAvailableWeapons045,
        sAvailableWeapons046, sAvailableWeapons047, sAvailableWeapons048, sAvailableWeapons049, sAvailableWeapons050,
        sAvailableWeapons051, sAvailableWeapons052, sAvailableWeapons053, sAvailableWeapons054, sAvailableWeapons055,
        sAvailableWeapons056, sAvailableWeapons057, sAvailableWeapons058, sAvailableWeapons059, sAvailableWeapons060,
        sAvailableWeapons061, sAvailableWeapons062, sAvailableWeapons063, sAvailableWeapons064, sAvailableWeapons065,
        sAvailableWeapons066, sAvailableWeapons067, sAvailableWeapons068, sAvailableWeapons069, sAvailableWeapons070,
        sAvailableWeapons071, sAvailableWeapons072, sAvailableWeapons073, sAvailableWeapons074, sAvailableWeapons075,
        sAvailableWeapons076, sAvailableWeapons077, sAvailableWeapons078, sAvailableWeapons079, sAvailableWeapons080,
        sAvailableWeapons081, sAvailableWeapons082, sAvailableWeapons083, sAvailableWeapons084, sAvailableWeapons085,
        sAvailableWeapons086, sAvailableWeapons087, sAvailableWeapons088, sAvailableWeapons089, sAvailableWeapons090,
        sAvailableWeapons091, sAvailableWeapons092, sAvailableWeapons093, sAvailableWeapons094, sAvailableWeapons095,
        sAvailableWeapons096, sAvailableWeapons097, sAvailableWeapons098, sAvailableWeapons099, sAvailableWeapons100;

        public static int
        iPlayerSearch, iVictim, iLocation,
        iDeadHerring, iSetSpeaker, iLoyaltyCheck, iTempLoyalty, iLoyaltyCap,
        iOfferedWeapon, iTempMacGuffins;

        public static int
        iRandDesireMax, iDesireRegen, iDesireInertia, iDesireBottom, iDesireEmote,
        iRandDesireEmote, iLuckyHunter, iHunterMax, iHuntPlayer, iHuntRegen,
        iHuntThreshold, iLightningsFirstStrike;

        public static bool bHunting;

        public static string
        sPlayerTalk, sTempLoyalty;

        public static bool
        bCorpse001, bCorpse002, bCorpse003, bCorpse004, bCorpse005, bCorpse006, bCorpse007, bCorpse008, bCorpse009, bCorpse010,
        bCorpse011, bCorpse012, bCorpse013, bCorpse014, bCorpse015, bCorpse016, bCorpse017, bCorpse018, bCorpse019, bCorpse020,
        bCorpse021, bCorpse022, bCorpse023, bCorpse024, bCorpse025, bCorpse026, bCorpse027, bCorpse028, bCorpse029, bCorpse030,
        bCorpse031, bCorpse032, bCorpse033, bCorpse034, bCorpse035, bCorpse036, bCorpse037, bCorpse038, bCorpse039, bCorpse040,
        bCorpse041, bCorpse042, bCorpse043, bCorpse044, bCorpse045, bCorpse046, bCorpse047, bCorpse048, bCorpse049, bCorpse050,
        bCorpse051, bCorpse052, bCorpse053, bCorpse054, bCorpse055, bCorpse056, bCorpse057, bCorpse058, bCorpse059, bCorpse060,
        bCorpse061, bCorpse062, bCorpse063, bCorpse064, bCorpse065, bCorpse066, bCorpse067, bCorpse068, bCorpse069, bCorpse070,
        bCorpse071, bCorpse072, bCorpse073, bCorpse074, bCorpse075, bCorpse076, bCorpse077, bCorpse078, bCorpse079, bCorpse080,
        bCorpse081, bCorpse082, bCorpse083, bCorpse084, bCorpse085, bCorpse086, bCorpse087, bCorpse088, bCorpse089, bCorpse090,
        bCorpse091, bCorpse092, bCorpse093, bCorpse094, bCorpse095, bCorpse096, bCorpse097, bCorpse098, bCorpse099, bCorpse100; // even though there can't be a Corpse100

        public static int
        iLoyalty001, iLoyalty002, iLoyalty003, iLoyalty004, iLoyalty005,
        iLoyalty006, iLoyalty007, iLoyalty008, iLoyalty009, iLoyalty010,
        iLoyalty011, iLoyalty012, iLoyalty013, iLoyalty014, iLoyalty015,
        iLoyalty016, iLoyalty017, iLoyalty018, iLoyalty019, iLoyalty020,
        iLoyalty021, iLoyalty022, iLoyalty023, iLoyalty024, iLoyalty025,
        iLoyalty026, iLoyalty027, iLoyalty028, iLoyalty029, iLoyalty030,
        iLoyalty031, iLoyalty032, iLoyalty033, iLoyalty034, iLoyalty035,
        iLoyalty036, iLoyalty037, iLoyalty038, iLoyalty039, iLoyalty040,
        iLoyalty041, iLoyalty042, iLoyalty043, iLoyalty044, iLoyalty045,
        iLoyalty046, iLoyalty047, iLoyalty048, iLoyalty049, iLoyalty050,
        iLoyalty051, iLoyalty052, iLoyalty053, iLoyalty054, iLoyalty055,
        iLoyalty056, iLoyalty057, iLoyalty058, iLoyalty059, iLoyalty060,
        iLoyalty061, iLoyalty062, iLoyalty063, iLoyalty064, iLoyalty065,
        iLoyalty066, iLoyalty067, iLoyalty068, iLoyalty069, iLoyalty070,
        iLoyalty071, iLoyalty072, iLoyalty073, iLoyalty074, iLoyalty075,
        iLoyalty076, iLoyalty077, iLoyalty078, iLoyalty079, iLoyalty080,
        iLoyalty081, iLoyalty082, iLoyalty083, iLoyalty084, iLoyalty085,
        iLoyalty086, iLoyalty087, iLoyalty088, iLoyalty089, iLoyalty090,
        iLoyalty091, iLoyalty092, iLoyalty093, iLoyalty094, iLoyalty095,
        iLoyalty096, iLoyalty097, iLoyalty098, iLoyalty099, iLoyalty100;

        public static int DesireRoll;

        // the following value forces everyone to move/initialize on turn one
        public static int iStartDesire;

        public static int
        DesireToMove001, DesireToMove002, DesireToMove003, DesireToMove004, DesireToMove005,
        DesireToMove006, DesireToMove007, DesireToMove008, DesireToMove009, DesireToMove010,
        DesireToMove011, DesireToMove012, DesireToMove013, DesireToMove014, DesireToMove015,
        DesireToMove016, DesireToMove017, DesireToMove018, DesireToMove019, DesireToMove020,
        DesireToMove021, DesireToMove022, DesireToMove023, DesireToMove024, DesireToMove025,
        DesireToMove026, DesireToMove027, DesireToMove028, DesireToMove029, DesireToMove030,
        DesireToMove031, DesireToMove032, DesireToMove033, DesireToMove034, DesireToMove035,
        DesireToMove036, DesireToMove037, DesireToMove038, DesireToMove039, DesireToMove040,
        DesireToMove041, DesireToMove042, DesireToMove043, DesireToMove044, DesireToMove045,
        DesireToMove046, DesireToMove047, DesireToMove048, DesireToMove049, DesireToMove050,
        DesireToMove051, DesireToMove052, DesireToMove053, DesireToMove054, DesireToMove055,
        DesireToMove056, DesireToMove057, DesireToMove058, DesireToMove059, DesireToMove060,
        DesireToMove061, DesireToMove062, DesireToMove063, DesireToMove064, DesireToMove065,
        DesireToMove066, DesireToMove067, DesireToMove068, DesireToMove069, DesireToMove070,
        DesireToMove071, DesireToMove072, DesireToMove073, DesireToMove074, DesireToMove075,
        DesireToMove076, DesireToMove077, DesireToMove078, DesireToMove079, DesireToMove080,
        DesireToMove081, DesireToMove082, DesireToMove083, DesireToMove084, DesireToMove085,
        DesireToMove086, DesireToMove087, DesireToMove088, DesireToMove089, DesireToMove090,
        DesireToMove091, DesireToMove092, DesireToMove093, DesireToMove094, DesireToMove095,
        DesireToMove096, DesireToMove097, DesireToMove098, DesireToMove099, DesireToMove100;

        // All NPCs with their starting variables.
        public static int
        NPC001_LastLocation, NPC002_LastLocation, NPC003_LastLocation, NPC004_LastLocation, NPC005_LastLocation,
        NPC006_LastLocation, NPC007_LastLocation, NPC008_LastLocation, NPC009_LastLocation, NPC010_LastLocation,
        NPC011_LastLocation, NPC012_LastLocation, NPC013_LastLocation, NPC014_LastLocation, NPC015_LastLocation,
        NPC016_LastLocation, NPC017_LastLocation, NPC018_LastLocation, NPC019_LastLocation, NPC020_LastLocation,
        NPC021_LastLocation, NPC022_LastLocation, NPC023_LastLocation, NPC024_LastLocation, NPC025_LastLocation,
        NPC026_LastLocation, NPC027_LastLocation, NPC028_LastLocation, NPC029_LastLocation, NPC030_LastLocation,
        NPC031_LastLocation, NPC032_LastLocation, NPC033_LastLocation, NPC034_LastLocation, NPC035_LastLocation,
        NPC036_LastLocation, NPC037_LastLocation, NPC038_LastLocation, NPC039_LastLocation, NPC040_LastLocation,
        NPC041_LastLocation, NPC042_LastLocation, NPC043_LastLocation, NPC044_LastLocation, NPC045_LastLocation,
        NPC046_LastLocation, NPC047_LastLocation, NPC048_LastLocation, NPC049_LastLocation, NPC050_LastLocation,
        NPC051_LastLocation, NPC052_LastLocation, NPC053_LastLocation, NPC054_LastLocation, NPC055_LastLocation,
        NPC056_LastLocation, NPC057_LastLocation, NPC058_LastLocation, NPC059_LastLocation, NPC060_LastLocation,
        NPC061_LastLocation, NPC062_LastLocation, NPC063_LastLocation, NPC064_LastLocation, NPC065_LastLocation,
        NPC066_LastLocation, NPC067_LastLocation, NPC068_LastLocation, NPC069_LastLocation, NPC070_LastLocation,
        NPC071_LastLocation, NPC072_LastLocation, NPC073_LastLocation, NPC074_LastLocation, NPC075_LastLocation,
        NPC076_LastLocation, NPC077_LastLocation, NPC078_LastLocation, NPC079_LastLocation, NPC080_LastLocation,
        NPC081_LastLocation, NPC082_LastLocation, NPC083_LastLocation, NPC084_LastLocation, NPC085_LastLocation,
        NPC086_LastLocation, NPC087_LastLocation, NPC088_LastLocation, NPC089_LastLocation, NPC090_LastLocation,
        NPC091_LastLocation, NPC092_LastLocation, NPC093_LastLocation, NPC094_LastLocation, NPC095_LastLocation,
        NPC096_LastLocation, NPC097_LastLocation, NPC098_LastLocation, NPC099_LastLocation, NPC100_LastLocation;

        public static string
        NPC001_LastStrLocation, NPC002_LastStrLocation, NPC003_LastStrLocation, NPC004_LastStrLocation, NPC005_LastStrLocation,
        NPC006_LastStrLocation, NPC007_LastStrLocation, NPC008_LastStrLocation, NPC009_LastStrLocation, NPC010_LastStrLocation,
        NPC011_LastStrLocation, NPC012_LastStrLocation, NPC013_LastStrLocation, NPC014_LastStrLocation, NPC015_LastStrLocation,
        NPC016_LastStrLocation, NPC017_LastStrLocation, NPC018_LastStrLocation, NPC019_LastStrLocation, NPC020_LastStrLocation,
        NPC021_LastStrLocation, NPC022_LastStrLocation, NPC023_LastStrLocation, NPC024_LastStrLocation, NPC025_LastStrLocation,
        NPC026_LastStrLocation, NPC027_LastStrLocation, NPC028_LastStrLocation, NPC029_LastStrLocation, NPC030_LastStrLocation,
        NPC031_LastStrLocation, NPC032_LastStrLocation, NPC033_LastStrLocation, NPC034_LastStrLocation, NPC035_LastStrLocation,
        NPC036_LastStrLocation, NPC037_LastStrLocation, NPC038_LastStrLocation, NPC039_LastStrLocation, NPC040_LastStrLocation,
        NPC041_LastStrLocation, NPC042_LastStrLocation, NPC043_LastStrLocation, NPC044_LastStrLocation, NPC045_LastStrLocation,
        NPC046_LastStrLocation, NPC047_LastStrLocation, NPC048_LastStrLocation, NPC049_LastStrLocation, NPC050_LastStrLocation,
        NPC051_LastStrLocation, NPC052_LastStrLocation, NPC053_LastStrLocation, NPC054_LastStrLocation, NPC055_LastStrLocation,
        NPC056_LastStrLocation, NPC057_LastStrLocation, NPC058_LastStrLocation, NPC059_LastStrLocation, NPC060_LastStrLocation,
        NPC061_LastStrLocation, NPC062_LastStrLocation, NPC063_LastStrLocation, NPC064_LastStrLocation, NPC065_LastStrLocation,
        NPC066_LastStrLocation, NPC067_LastStrLocation, NPC068_LastStrLocation, NPC069_LastStrLocation, NPC070_LastStrLocation,
        NPC071_LastStrLocation, NPC072_LastStrLocation, NPC073_LastStrLocation, NPC074_LastStrLocation, NPC075_LastStrLocation,
        NPC076_LastStrLocation, NPC077_LastStrLocation, NPC078_LastStrLocation, NPC079_LastStrLocation, NPC080_LastStrLocation,
        NPC081_LastStrLocation, NPC082_LastStrLocation, NPC083_LastStrLocation, NPC084_LastStrLocation, NPC085_LastStrLocation,
        NPC086_LastStrLocation, NPC087_LastStrLocation, NPC088_LastStrLocation, NPC089_LastStrLocation, NPC090_LastStrLocation,
        NPC091_LastStrLocation, NPC092_LastStrLocation, NPC093_LastStrLocation, NPC094_LastStrLocation, NPC095_LastStrLocation,
        NPC096_LastStrLocation, NPC097_LastStrLocation, NPC098_LastStrLocation, NPC099_LastStrLocation, NPC100_LastStrLocation;

        public static int
        NPC001_CurrentNumLocation, NPC002_CurrentNumLocation, NPC003_CurrentNumLocation, NPC004_CurrentNumLocation, NPC005_CurrentNumLocation,
        NPC006_CurrentNumLocation, NPC007_CurrentNumLocation, NPC008_CurrentNumLocation, NPC009_CurrentNumLocation, NPC010_CurrentNumLocation,
        NPC011_CurrentNumLocation, NPC012_CurrentNumLocation, NPC013_CurrentNumLocation, NPC014_CurrentNumLocation, NPC015_CurrentNumLocation,
        NPC016_CurrentNumLocation, NPC017_CurrentNumLocation, NPC018_CurrentNumLocation, NPC019_CurrentNumLocation, NPC020_CurrentNumLocation,
        NPC021_CurrentNumLocation, NPC022_CurrentNumLocation, NPC023_CurrentNumLocation, NPC024_CurrentNumLocation, NPC025_CurrentNumLocation,
        NPC026_CurrentNumLocation, NPC027_CurrentNumLocation, NPC028_CurrentNumLocation, NPC029_CurrentNumLocation, NPC030_CurrentNumLocation,
        NPC031_CurrentNumLocation, NPC032_CurrentNumLocation, NPC033_CurrentNumLocation, NPC034_CurrentNumLocation, NPC035_CurrentNumLocation,
        NPC036_CurrentNumLocation, NPC037_CurrentNumLocation, NPC038_CurrentNumLocation, NPC039_CurrentNumLocation, NPC040_CurrentNumLocation,
        NPC041_CurrentNumLocation, NPC042_CurrentNumLocation, NPC043_CurrentNumLocation, NPC044_CurrentNumLocation, NPC045_CurrentNumLocation,
        NPC046_CurrentNumLocation, NPC047_CurrentNumLocation, NPC048_CurrentNumLocation, NPC049_CurrentNumLocation, NPC050_CurrentNumLocation,
        NPC051_CurrentNumLocation, NPC052_CurrentNumLocation, NPC053_CurrentNumLocation, NPC054_CurrentNumLocation, NPC055_CurrentNumLocation,
        NPC056_CurrentNumLocation, NPC057_CurrentNumLocation, NPC058_CurrentNumLocation, NPC059_CurrentNumLocation, NPC060_CurrentNumLocation,
        NPC061_CurrentNumLocation, NPC062_CurrentNumLocation, NPC063_CurrentNumLocation, NPC064_CurrentNumLocation, NPC065_CurrentNumLocation,
        NPC066_CurrentNumLocation, NPC067_CurrentNumLocation, NPC068_CurrentNumLocation, NPC069_CurrentNumLocation, NPC070_CurrentNumLocation,
        NPC071_CurrentNumLocation, NPC072_CurrentNumLocation, NPC073_CurrentNumLocation, NPC074_CurrentNumLocation, NPC075_CurrentNumLocation,
        NPC076_CurrentNumLocation, NPC077_CurrentNumLocation, NPC078_CurrentNumLocation, NPC079_CurrentNumLocation, NPC080_CurrentNumLocation,
        NPC081_CurrentNumLocation, NPC082_CurrentNumLocation, NPC083_CurrentNumLocation, NPC084_CurrentNumLocation, NPC085_CurrentNumLocation,
        NPC086_CurrentNumLocation, NPC087_CurrentNumLocation, NPC088_CurrentNumLocation, NPC089_CurrentNumLocation, NPC090_CurrentNumLocation,
        NPC091_CurrentNumLocation, NPC092_CurrentNumLocation, NPC093_CurrentNumLocation, NPC094_CurrentNumLocation, NPC095_CurrentNumLocation,
        NPC096_CurrentNumLocation, NPC097_CurrentNumLocation, NPC098_CurrentNumLocation, NPC099_CurrentNumLocation, NPC100_CurrentNumLocation;

        public static string
        NPC001_CurrentStrLocation, NPC002_CurrentStrLocation, NPC003_CurrentStrLocation, NPC004_CurrentStrLocation, NPC005_CurrentStrLocation,
        NPC006_CurrentStrLocation, NPC007_CurrentStrLocation, NPC008_CurrentStrLocation, NPC009_CurrentStrLocation, NPC010_CurrentStrLocation,
        NPC011_CurrentStrLocation, NPC012_CurrentStrLocation, NPC013_CurrentStrLocation, NPC014_CurrentStrLocation, NPC015_CurrentStrLocation,
        NPC016_CurrentStrLocation, NPC017_CurrentStrLocation, NPC018_CurrentStrLocation, NPC019_CurrentStrLocation, NPC020_CurrentStrLocation,
        NPC021_CurrentStrLocation, NPC022_CurrentStrLocation, NPC023_CurrentStrLocation, NPC024_CurrentStrLocation, NPC025_CurrentStrLocation,
        NPC026_CurrentStrLocation, NPC027_CurrentStrLocation, NPC028_CurrentStrLocation, NPC029_CurrentStrLocation, NPC030_CurrentStrLocation,
        NPC031_CurrentStrLocation, NPC032_CurrentStrLocation, NPC033_CurrentStrLocation, NPC034_CurrentStrLocation, NPC035_CurrentStrLocation,
        NPC036_CurrentStrLocation, NPC037_CurrentStrLocation, NPC038_CurrentStrLocation, NPC039_CurrentStrLocation, NPC040_CurrentStrLocation,
        NPC041_CurrentStrLocation, NPC042_CurrentStrLocation, NPC043_CurrentStrLocation, NPC044_CurrentStrLocation, NPC045_CurrentStrLocation,
        NPC046_CurrentStrLocation, NPC047_CurrentStrLocation, NPC048_CurrentStrLocation, NPC049_CurrentStrLocation, NPC050_CurrentStrLocation,
        NPC051_CurrentStrLocation, NPC052_CurrentStrLocation, NPC053_CurrentStrLocation, NPC054_CurrentStrLocation, NPC055_CurrentStrLocation,
        NPC056_CurrentStrLocation, NPC057_CurrentStrLocation, NPC058_CurrentStrLocation, NPC059_CurrentStrLocation, NPC060_CurrentStrLocation,
        NPC061_CurrentStrLocation, NPC062_CurrentStrLocation, NPC063_CurrentStrLocation, NPC064_CurrentStrLocation, NPC065_CurrentStrLocation,
        NPC066_CurrentStrLocation, NPC067_CurrentStrLocation, NPC068_CurrentStrLocation, NPC069_CurrentStrLocation, NPC070_CurrentStrLocation,
        NPC071_CurrentStrLocation, NPC072_CurrentStrLocation, NPC073_CurrentStrLocation, NPC074_CurrentStrLocation, NPC075_CurrentStrLocation,
        NPC076_CurrentStrLocation, NPC077_CurrentStrLocation, NPC078_CurrentStrLocation, NPC079_CurrentStrLocation, NPC080_CurrentStrLocation,
        NPC081_CurrentStrLocation, NPC082_CurrentStrLocation, NPC083_CurrentStrLocation, NPC084_CurrentStrLocation, NPC085_CurrentStrLocation,
        NPC086_CurrentStrLocation, NPC087_CurrentStrLocation, NPC088_CurrentStrLocation, NPC089_CurrentStrLocation, NPC090_CurrentStrLocation,
        NPC091_CurrentStrLocation, NPC092_CurrentStrLocation, NPC093_CurrentStrLocation, NPC094_CurrentStrLocation, NPC095_CurrentStrLocation,
        NPC096_CurrentStrLocation, NPC097_CurrentStrLocation, NPC098_CurrentStrLocation, NPC099_CurrentStrLocation, NPC100_CurrentStrLocation;

        public static int npcBehavior;
        public static int npcIndex;

        public static int iCloseEncounters;

        public static int
        iClose001, iClose002, iClose003, iClose004, iClose005, iClose006, iClose007, iClose008, iClose009, iClose010, iClose011, iClose012, iClose013, iClose014, iClose015,
        iClose016, iClose017, iClose018, iClose019, iClose020, iClose021, iClose022, iClose023, iClose024, iClose025, iClose026, iClose027, iClose028, iClose029, iClose030,
        iClose031, iClose032, iClose033, iClose034, iClose035, iClose036, iClose037, iClose038, iClose039, iClose040, iClose041, iClose042, iClose043, iClose044, iClose045,
        iClose046, iClose047, iClose048, iClose049, iClose050, iClose051, iClose052, iClose053, iClose054, iClose055, iClose056, iClose057, iClose058, iClose059, iClose060,
        iClose061, iClose062, iClose063, iClose064, iClose065, iClose066, iClose067, iClose068, iClose069, iClose070, iClose071, iClose072, iClose073, iClose074, iClose075,
        iClose076, iClose077, iClose078, iClose079, iClose080, iClose081, iClose082, iClose083, iClose084, iClose085, iClose086, iClose087, iClose088, iClose089, iClose090,
        iClose091, iClose092, iClose093, iClose094, iClose095, iClose096, iClose097, iClose098, iClose099, iClose100;

        public static int
        iTempLocation, iTempLastLocation, iTempDesireToMove;

        public static string
        sTempLastLocation, sTempCurrentLocation;

        public static int iRandomWeapon, iScavenge, iRandomNPC;

        public static void Initialize_AI_Variables()
        {
            iDisposition1 = 1;
            iDisposition2 = 2;
            iDisposition3 = 3;
            iDisposition4 = 4;
            iDisposition5 = 5;
            iDisposition6 = 6;
            iDisposition7 = 7;

            sDisposition1 = "Afraid";
            sDisposition2 = "Suspicious";
            sDisposition3 = "Wary";
            sDisposition4 = "Indifferent";
            sDisposition5 = "Pleasant";
            sDisposition6 = "Agreeable";
            sDisposition7 = "Friendly";

            sGenderHisHer = sGenderHeShe = sGenderHimHer = sGenderGuyGirl =
            sGenderHisHer01 = sGenderHeShe01 = sGenderHimHer01 = sGenderGuyGirl01 =
            sGenderHisHer02 = sGenderHeShe02 = sGenderHimHer02 = sGenderGuyGirl02 =
            sGenderHisHer03 = sGenderHeShe03 = sGenderHimHer03 = sGenderGuyGirl03 =
            sGenderHisHer04 = sGenderHeShe04 = sGenderHimHer04 = sGenderGuyGirl04 =
            sGenderHisHer05 = sGenderHeShe05 = sGenderHimHer05 = sGenderGuyGirl05 =
            sGenderHisHer06 = sGenderHeShe06 = sGenderHimHer06 = sGenderGuyGirl06 =
            "null";

            sGenderBrotherSister02 = "null";

            NPC_001 = NPC_002 = NPC_003 = NPC_004 = NPC_005 =
            NPC_006 = NPC_007 = NPC_008 = NPC_009 = NPC_010 =
            NPC_011 = NPC_012 = NPC_013 = NPC_014 = NPC_015 =
            NPC_016 = NPC_017 = NPC_018 = NPC_019 = NPC_020 =
            NPC_021 = NPC_022 = NPC_023 = NPC_024 = NPC_025 =
            NPC_026 = NPC_027 = NPC_028 = NPC_029 = NPC_030 =
            NPC_031 = NPC_032 = NPC_033 = NPC_034 = NPC_035 =
            NPC_036 = NPC_037 = NPC_038 = NPC_039 = NPC_040 =
            NPC_041 = NPC_042 = NPC_043 = NPC_044 = NPC_045 =
            NPC_046 = NPC_047 = NPC_048 = NPC_049 = NPC_050 =
            NPC_051 = NPC_052 = NPC_053 = NPC_054 = NPC_055 =
            NPC_056 = NPC_057 = NPC_058 = NPC_059 = NPC_060 =
            NPC_061 = NPC_062 = NPC_063 = NPC_064 = NPC_065 =
            NPC_066 = NPC_067 = NPC_068 = NPC_069 = NPC_070 =
            NPC_071 = NPC_072 = NPC_073 = NPC_074 = NPC_075 =
            NPC_076 = NPC_077 = NPC_078 = NPC_079 = NPC_080 =
            NPC_081 = NPC_082 = NPC_083 = NPC_084 = NPC_085 =
            NPC_086 = NPC_087 = NPC_088 = NPC_089 = NPC_090 =
            NPC_091 = NPC_092 = NPC_093 = NPC_094 = NPC_095 =
            NPC_096 = NPC_097 = NPC_098 = NPC_099 = NPC_100 =
            tempNPC = "null";

            iAvailableMacGuffins001 = iAvailableMacGuffins002 = iAvailableMacGuffins003 = iAvailableMacGuffins004 = iAvailableMacGuffins005 =
            iAvailableMacGuffins006 = iAvailableMacGuffins007 = iAvailableMacGuffins008 = iAvailableMacGuffins009 = iAvailableMacGuffins010 =
            iAvailableMacGuffins011 = iAvailableMacGuffins012 = iAvailableMacGuffins013 = iAvailableMacGuffins014 = iAvailableMacGuffins015 =
            iAvailableMacGuffins016 = iAvailableMacGuffins017 = iAvailableMacGuffins018 = iAvailableMacGuffins019 = iAvailableMacGuffins020 =
            iAvailableMacGuffins021 = iAvailableMacGuffins022 = iAvailableMacGuffins023 = iAvailableMacGuffins024 = iAvailableMacGuffins025 =
            iAvailableMacGuffins026 = iAvailableMacGuffins027 = iAvailableMacGuffins028 = iAvailableMacGuffins029 = iAvailableMacGuffins030 =
            iAvailableMacGuffins031 = iAvailableMacGuffins032 = iAvailableMacGuffins033 = iAvailableMacGuffins034 = iAvailableMacGuffins035 =
            iAvailableMacGuffins036 = iAvailableMacGuffins037 = iAvailableMacGuffins038 = iAvailableMacGuffins039 = iAvailableMacGuffins040 =
            iAvailableMacGuffins041 = iAvailableMacGuffins042 = iAvailableMacGuffins043 = iAvailableMacGuffins044 = iAvailableMacGuffins045 =
            iAvailableMacGuffins046 = iAvailableMacGuffins047 = iAvailableMacGuffins048 = iAvailableMacGuffins049 = iAvailableMacGuffins050 =
            iAvailableMacGuffins051 = iAvailableMacGuffins052 = iAvailableMacGuffins053 = iAvailableMacGuffins054 = iAvailableMacGuffins055 =
            iAvailableMacGuffins056 = iAvailableMacGuffins057 = iAvailableMacGuffins058 = iAvailableMacGuffins059 = iAvailableMacGuffins060 =
            iAvailableMacGuffins061 = iAvailableMacGuffins062 = iAvailableMacGuffins063 = iAvailableMacGuffins064 = iAvailableMacGuffins065 =
            iAvailableMacGuffins066 = iAvailableMacGuffins067 = iAvailableMacGuffins068 = iAvailableMacGuffins069 = iAvailableMacGuffins070 =
            iAvailableMacGuffins071 = iAvailableMacGuffins072 = iAvailableMacGuffins073 = iAvailableMacGuffins074 = iAvailableMacGuffins075 =
            iAvailableMacGuffins076 = iAvailableMacGuffins077 = iAvailableMacGuffins078 = iAvailableMacGuffins079 = iAvailableMacGuffins080 =
            iAvailableMacGuffins081 = iAvailableMacGuffins082 = iAvailableMacGuffins083 = iAvailableMacGuffins084 = iAvailableMacGuffins085 =
            iAvailableMacGuffins086 = iAvailableMacGuffins087 = iAvailableMacGuffins088 = iAvailableMacGuffins089 = iAvailableMacGuffins090 =
            iAvailableMacGuffins091 = iAvailableMacGuffins092 = iAvailableMacGuffins093 = iAvailableMacGuffins094 = iAvailableMacGuffins095 =
            iAvailableMacGuffins096 = iAvailableMacGuffins097 = iAvailableMacGuffins098 = iAvailableMacGuffins099 = iAvailableMacGuffins100 =
            0;

            sWeaponType0 = "nothing";
            sWeaponType1 = "brick"; // ?
            sWeaponType2 = "bat"; // ?
            sWeaponType3 = "wooden 2x2"; // ?
            sWeaponType4 = "truncheon"; // Worth 5 MacGuffins in sale.
            sWeaponType5 = "colorful, fried fish"; // +1 Posse for accusations

            sAvailableWeapons001 = sAvailableWeapons002 = sAvailableWeapons003 = sAvailableWeapons004 = sAvailableWeapons005 =
            sAvailableWeapons006 = sAvailableWeapons007 = sAvailableWeapons008 = sAvailableWeapons009 = sAvailableWeapons010 =
            sAvailableWeapons011 = sAvailableWeapons012 = sAvailableWeapons013 = sAvailableWeapons014 = sAvailableWeapons015 =
            sAvailableWeapons016 = sAvailableWeapons017 = sAvailableWeapons018 = sAvailableWeapons019 = sAvailableWeapons020 =
            sAvailableWeapons021 = sAvailableWeapons022 = sAvailableWeapons023 = sAvailableWeapons024 = sAvailableWeapons025 =
            sAvailableWeapons026 = sAvailableWeapons027 = sAvailableWeapons028 = sAvailableWeapons029 = sAvailableWeapons030 =
            sAvailableWeapons031 = sAvailableWeapons032 = sAvailableWeapons033 = sAvailableWeapons034 = sAvailableWeapons035 =
            sAvailableWeapons036 = sAvailableWeapons037 = sAvailableWeapons038 = sAvailableWeapons039 = sAvailableWeapons040 =
            sAvailableWeapons041 = sAvailableWeapons042 = sAvailableWeapons043 = sAvailableWeapons044 = sAvailableWeapons045 =
            sAvailableWeapons046 = sAvailableWeapons047 = sAvailableWeapons048 = sAvailableWeapons049 = sAvailableWeapons050 =
            sAvailableWeapons051 = sAvailableWeapons052 = sAvailableWeapons053 = sAvailableWeapons054 = sAvailableWeapons055 =
            sAvailableWeapons056 = sAvailableWeapons057 = sAvailableWeapons058 = sAvailableWeapons059 = sAvailableWeapons060 =
            sAvailableWeapons061 = sAvailableWeapons062 = sAvailableWeapons063 = sAvailableWeapons064 = sAvailableWeapons065 =
            sAvailableWeapons066 = sAvailableWeapons067 = sAvailableWeapons068 = sAvailableWeapons069 = sAvailableWeapons070 =
            sAvailableWeapons071 = sAvailableWeapons072 = sAvailableWeapons073 = sAvailableWeapons074 = sAvailableWeapons075 =
            sAvailableWeapons076 = sAvailableWeapons077 = sAvailableWeapons078 = sAvailableWeapons079 = sAvailableWeapons080 =
            sAvailableWeapons081 = sAvailableWeapons082 = sAvailableWeapons083 = sAvailableWeapons084 = sAvailableWeapons085 =
            sAvailableWeapons086 = sAvailableWeapons087 = sAvailableWeapons088 = sAvailableWeapons089 = sAvailableWeapons090 =
            sAvailableWeapons091 = sAvailableWeapons092 = sAvailableWeapons093 = sAvailableWeapons094 = sAvailableWeapons095 =
            sAvailableWeapons096 = sAvailableWeapons097 = sAvailableWeapons098 = sAvailableWeapons099 = sAvailableWeapons100 =
            sTempWeapons = sWeaponType0;

            bTempCorpse = false;

            bHunting = false;

            iLightningsFirstStrike = 0;
            iPlayerSearch = 0;
            iVictim = 1;
            iLocation = 25;
            iDeadHerring = 0;
            iSetSpeaker = 1;
            iLoyaltyCheck = 4;
            iTempLoyalty = 999;
            iLoyaltyCap = 5;
            iOfferedWeapon = 3;

            iTempMacGuffins = 999;

            // Hunting the Player
            iRandDesireMax = 80;
            iDesireRegen = 10;
            iDesireInertia = 100;
            iDesireBottom = 0;
            iDesireEmote = 65;
            iRandDesireEmote = 0;

            iLuckyHunter = 0; // Bonus to ensure Hunter finds player.
            iHunterMax = 50; // Max value of the Program.random portion of the tracking process.
            iHuntPlayer = 0; // Hunter's current chance of success in tracking the player. It's (1-50) + (25) per turn. It takes the hunter min2/max4 turns to find the player. 
            iHuntRegen = 30; // How quickly the bonus increases.
            iHuntThreshold = 75; // value necessary for Hunter to get lucky and find the player.

            sPlayerTalk = "null";
            sTempLoyalty = "null";

            bCorpse001 = bCorpse002 = bCorpse003 = bCorpse004 = bCorpse005 =
            bCorpse006 = bCorpse007 = bCorpse008 = bCorpse009 = bCorpse010 =
            bCorpse011 = bCorpse012 = bCorpse013 = bCorpse014 = bCorpse015 =
            bCorpse016 = bCorpse017 = bCorpse018 = bCorpse019 = bCorpse020 =
            bCorpse021 = bCorpse022 = bCorpse023 = bCorpse024 = bCorpse025 =
            bCorpse026 = bCorpse027 = bCorpse028 = bCorpse029 = bCorpse030 =
            bCorpse031 = bCorpse032 = bCorpse033 = bCorpse034 = bCorpse035 =
            bCorpse036 = bCorpse037 = bCorpse038 = bCorpse039 = bCorpse040 =
            bCorpse041 = bCorpse042 = bCorpse043 = bCorpse044 = bCorpse045 =
            bCorpse046 = bCorpse047 = bCorpse048 = bCorpse049 = bCorpse050 =
            bCorpse051 = bCorpse052 = bCorpse053 = bCorpse054 = bCorpse055 =
            bCorpse056 = bCorpse057 = bCorpse058 = bCorpse059 = bCorpse060 =
            bCorpse061 = bCorpse062 = bCorpse063 = bCorpse064 = bCorpse065 =
            bCorpse066 = bCorpse067 = bCorpse068 = bCorpse069 = bCorpse070 =
            bCorpse071 = bCorpse072 = bCorpse073 = bCorpse074 = bCorpse075 =
            bCorpse076 = bCorpse077 = bCorpse078 = bCorpse079 = bCorpse080 =
            bCorpse081 = bCorpse082 = bCorpse083 = bCorpse084 = bCorpse085 =
            bCorpse086 = bCorpse087 = bCorpse088 = bCorpse089 = bCorpse090 =
            bCorpse091 = bCorpse092 = bCorpse093 = bCorpse094 = bCorpse095 =
            bCorpse096 = bCorpse097 = bCorpse098 = bCorpse099 = bCorpse100 =
            false; // even though there can't be a Corpse100

            // Set a Program.random starting value (0, 1, or 2) for disposition toward player.
            iLoyalty001 = Program.rand.Next(0, 3);
            iLoyalty002 = Program.rand.Next(0, 3);
            iLoyalty003 = Program.rand.Next(0, 3);
            iLoyalty004 = Program.rand.Next(0, 3);
            iLoyalty005 = Program.rand.Next(0, 3);
            iLoyalty006 = Program.rand.Next(0, 3);
            iLoyalty007 = Program.rand.Next(0, 3);
            iLoyalty008 = Program.rand.Next(0, 3);
            iLoyalty009 = Program.rand.Next(0, 3);
            iLoyalty010 = Program.rand.Next(0, 3);
            iLoyalty011 = Program.rand.Next(0, 3);
            iLoyalty012 = Program.rand.Next(0, 3);
            iLoyalty013 = Program.rand.Next(0, 3);
            iLoyalty014 = Program.rand.Next(0, 3);
            iLoyalty015 = Program.rand.Next(0, 3);
            iLoyalty016 = Program.rand.Next(0, 3);
            iLoyalty017 = Program.rand.Next(0, 3);
            iLoyalty018 = Program.rand.Next(0, 3);
            iLoyalty019 = Program.rand.Next(0, 3);
            iLoyalty020 = Program.rand.Next(0, 3);
            iLoyalty021 = Program.rand.Next(0, 3);
            iLoyalty022 = Program.rand.Next(0, 3);
            iLoyalty023 = Program.rand.Next(0, 3);
            iLoyalty024 = Program.rand.Next(0, 3);
            iLoyalty025 = Program.rand.Next(0, 3);
            iLoyalty026 = Program.rand.Next(0, 3);
            iLoyalty027 = Program.rand.Next(0, 3);
            iLoyalty028 = Program.rand.Next(0, 3);
            iLoyalty029 = Program.rand.Next(0, 3);
            iLoyalty030 = Program.rand.Next(0, 3);
            iLoyalty031 = Program.rand.Next(0, 3);
            iLoyalty032 = Program.rand.Next(0, 3);
            iLoyalty033 = Program.rand.Next(0, 3);
            iLoyalty034 = Program.rand.Next(0, 3);
            iLoyalty035 = Program.rand.Next(0, 3);
            iLoyalty036 = Program.rand.Next(0, 3);
            iLoyalty037 = Program.rand.Next(0, 3);
            iLoyalty038 = Program.rand.Next(0, 3);
            iLoyalty039 = Program.rand.Next(0, 3);
            iLoyalty040 = Program.rand.Next(0, 3);
            iLoyalty041 = Program.rand.Next(0, 3);
            iLoyalty042 = Program.rand.Next(0, 3);
            iLoyalty043 = Program.rand.Next(0, 3);
            iLoyalty044 = Program.rand.Next(0, 3);
            iLoyalty045 = Program.rand.Next(0, 3);
            iLoyalty046 = Program.rand.Next(0, 3);
            iLoyalty047 = Program.rand.Next(0, 3);
            iLoyalty048 = Program.rand.Next(0, 3);
            iLoyalty049 = Program.rand.Next(0, 3);
            iLoyalty050 = Program.rand.Next(0, 3);
            iLoyalty051 = Program.rand.Next(0, 3);
            iLoyalty052 = Program.rand.Next(0, 3);
            iLoyalty053 = Program.rand.Next(0, 3);
            iLoyalty054 = Program.rand.Next(0, 3);
            iLoyalty055 = Program.rand.Next(0, 3);
            iLoyalty056 = Program.rand.Next(0, 3);
            iLoyalty057 = Program.rand.Next(0, 3);
            iLoyalty058 = Program.rand.Next(0, 3);
            iLoyalty059 = Program.rand.Next(0, 3);
            iLoyalty060 = Program.rand.Next(0, 3);
            iLoyalty061 = Program.rand.Next(0, 3);
            iLoyalty062 = Program.rand.Next(0, 3);
            iLoyalty063 = Program.rand.Next(0, 3);
            iLoyalty064 = Program.rand.Next(0, 3);
            iLoyalty065 = Program.rand.Next(0, 3);
            iLoyalty066 = Program.rand.Next(0, 3);
            iLoyalty067 = Program.rand.Next(0, 3);
            iLoyalty068 = Program.rand.Next(0, 3);
            iLoyalty069 = Program.rand.Next(0, 3);
            iLoyalty070 = Program.rand.Next(0, 3);
            iLoyalty071 = Program.rand.Next(0, 3);
            iLoyalty072 = Program.rand.Next(0, 3);
            iLoyalty073 = Program.rand.Next(0, 3);
            iLoyalty074 = Program.rand.Next(0, 3);
            iLoyalty075 = Program.rand.Next(0, 3);
            iLoyalty076 = Program.rand.Next(0, 3);
            iLoyalty077 = Program.rand.Next(0, 3);
            iLoyalty078 = Program.rand.Next(0, 3);
            iLoyalty079 = Program.rand.Next(0, 3);
            iLoyalty080 = Program.rand.Next(0, 3);
            iLoyalty081 = Program.rand.Next(0, 3);
            iLoyalty082 = Program.rand.Next(0, 3);
            iLoyalty083 = Program.rand.Next(0, 3);
            iLoyalty084 = Program.rand.Next(0, 3);
            iLoyalty085 = Program.rand.Next(0, 3);
            iLoyalty086 = Program.rand.Next(0, 3);
            iLoyalty087 = Program.rand.Next(0, 3);
            iLoyalty088 = Program.rand.Next(0, 3);
            iLoyalty089 = Program.rand.Next(0, 3);
            iLoyalty090 = Program.rand.Next(0, 3);
            iLoyalty091 = Program.rand.Next(0, 3);
            iLoyalty092 = Program.rand.Next(0, 3);
            iLoyalty093 = Program.rand.Next(0, 3);
            iLoyalty094 = Program.rand.Next(0, 3);
            iLoyalty095 = Program.rand.Next(0, 3);
            iLoyalty096 = Program.rand.Next(0, 3);
            iLoyalty097 = Program.rand.Next(0, 3);
            iLoyalty098 = Program.rand.Next(0, 3);
            iLoyalty099 = Program.rand.Next(0, 3);
            iLoyalty100 = Program.rand.Next(0, 3);

            iStartDesire = 50;

            DesireToMove001 = DesireToMove002 = DesireToMove003 = DesireToMove004 = DesireToMove005 =
            DesireToMove006 = DesireToMove007 = DesireToMove008 = DesireToMove009 = DesireToMove010 =
            DesireToMove011 = DesireToMove012 = DesireToMove013 = DesireToMove014 = DesireToMove015 =
            DesireToMove016 = DesireToMove017 = DesireToMove018 = DesireToMove019 = DesireToMove020 =
            DesireToMove021 = DesireToMove022 = DesireToMove023 = DesireToMove024 = DesireToMove025 =
            DesireToMove026 = DesireToMove027 = DesireToMove028 = DesireToMove029 = DesireToMove030 =
            DesireToMove031 = DesireToMove032 = DesireToMove033 = DesireToMove034 = DesireToMove035 =
            DesireToMove036 = DesireToMove037 = DesireToMove038 = DesireToMove039 = DesireToMove040 =
            DesireToMove041 = DesireToMove042 = DesireToMove043 = DesireToMove044 = DesireToMove045 =
            DesireToMove046 = DesireToMove047 = DesireToMove048 = DesireToMove049 = DesireToMove050 =
            DesireToMove051 = DesireToMove052 = DesireToMove053 = DesireToMove054 = DesireToMove055 =
            DesireToMove056 = DesireToMove057 = DesireToMove058 = DesireToMove059 = DesireToMove060 =
            DesireToMove061 = DesireToMove062 = DesireToMove063 = DesireToMove064 = DesireToMove065 =
            DesireToMove066 = DesireToMove067 = DesireToMove068 = DesireToMove069 = DesireToMove070 =
            DesireToMove071 = DesireToMove072 = DesireToMove073 = DesireToMove074 = DesireToMove075 =
            DesireToMove076 = DesireToMove077 = DesireToMove078 = DesireToMove079 = DesireToMove080 =
            DesireToMove081 = DesireToMove082 = DesireToMove083 = DesireToMove084 = DesireToMove085 =
            DesireToMove086 = DesireToMove087 = DesireToMove088 = DesireToMove092 = DesireToMove093 =
            DesireToMove094 = DesireToMove095 = DesireToMove096 = DesireToMove097 = DesireToMove098 =
            DesireToMove099 = DesireToMove100 = iStartDesire;

            // These values are lower to encourage these NPCs to stick around the starting spot with
            // the player for longer. Since NPC_090 is a 'red herring', it should allow the player to
            // befriend at least one person who will be around until the late game.
            DesireToMove001 = 10;
            DesireToMove002 = 40;
            DesireToMove003 = 30;
            DesireToMove090 = -10;

            // All NPCs with their starting variables.
            NPC001_LastLocation = 17;
            NPC001_LastStrLocation = LocationEncounters.location_017;

            NPC002_LastLocation = 17;
            NPC002_LastStrLocation = LocationEncounters.location_017;

            NPC003_LastLocation = 17;
            NPC003_LastStrLocation = LocationEncounters.location_017;

            NPC004_LastLocation = 2;
            NPC004_LastStrLocation = LocationEncounters.location_002;

            NPC005_LastLocation = 2;
            NPC005_LastStrLocation = LocationEncounters.location_002;

            NPC006_LastLocation = 2;
            NPC006_LastStrLocation = LocationEncounters.location_002;

            NPC007_LastLocation = 2;
            NPC007_LastStrLocation = LocationEncounters.location_002;

            NPC008_LastLocation = 3;
            NPC008_LastStrLocation = LocationEncounters.location_003;

            NPC009_LastLocation = 3;
            NPC009_LastStrLocation = LocationEncounters.location_003;

            NPC010_LastLocation = 3;
            NPC010_LastStrLocation = LocationEncounters.location_003;

            NPC011_LastLocation = 3;
            NPC011_LastStrLocation = LocationEncounters.location_003;

            NPC012_LastLocation = 4;
            NPC012_LastStrLocation = LocationEncounters.location_004;

            NPC013_LastLocation = 4;
            NPC013_LastStrLocation = LocationEncounters.location_004;

            NPC014_LastLocation = 4;
            NPC014_LastStrLocation = LocationEncounters.location_004;

            NPC015_LastLocation = 4;
            NPC015_LastStrLocation = LocationEncounters.location_004;

            NPC016_LastLocation = 5;
            NPC016_LastStrLocation = LocationEncounters.location_005;

            NPC017_LastLocation = 5;
            NPC017_LastStrLocation = LocationEncounters.location_005;

            NPC018_LastLocation = 5;
            NPC018_LastStrLocation = LocationEncounters.location_005;

            NPC019_LastLocation = 5;
            NPC019_LastStrLocation = LocationEncounters.location_005;

            NPC020_LastLocation = 6;
            NPC020_LastStrLocation = LocationEncounters.location_006;

            NPC021_LastLocation = 6;
            NPC021_LastStrLocation = LocationEncounters.location_006;

            NPC022_LastLocation = 6;
            NPC022_LastStrLocation = LocationEncounters.location_006;

            NPC023_LastLocation = 6;
            NPC023_LastStrLocation = LocationEncounters.location_006;

            NPC024_LastLocation = 7;
            NPC024_LastStrLocation = LocationEncounters.location_007;

            NPC025_LastLocation = 7;
            NPC025_LastStrLocation = LocationEncounters.location_007;

            NPC026_LastLocation = 7;
            NPC026_LastStrLocation = LocationEncounters.location_007;

            NPC027_LastLocation = 7;
            NPC027_LastStrLocation = LocationEncounters.location_007;

            NPC028_LastLocation = 8;
            NPC028_LastStrLocation = LocationEncounters.location_008;

            NPC029_LastLocation = 8;
            NPC029_LastStrLocation = LocationEncounters.location_008;

            NPC030_LastLocation = 8;
            NPC030_LastStrLocation = LocationEncounters.location_008;

            NPC031_LastLocation = 8;
            NPC031_LastStrLocation = LocationEncounters.location_008;

            NPC032_LastLocation = 9;
            NPC032_LastStrLocation = LocationEncounters.location_009;

            NPC033_LastLocation = 9;
            NPC033_LastStrLocation = LocationEncounters.location_009;

            NPC034_LastLocation = 9;
            NPC034_LastStrLocation = LocationEncounters.location_009;

            NPC035_LastLocation = 9;
            NPC035_LastStrLocation = LocationEncounters.location_009;

            NPC036_LastLocation = 10;
            NPC036_LastStrLocation = LocationEncounters.location_010;

            NPC037_LastLocation = 10;
            NPC037_LastStrLocation = LocationEncounters.location_010;

            NPC038_LastLocation = 10;
            NPC038_LastStrLocation = LocationEncounters.location_010;

            NPC039_LastLocation = 10;
            NPC039_LastStrLocation = LocationEncounters.location_010;

            NPC040_LastLocation = 11;
            NPC040_LastStrLocation = LocationEncounters.location_011;

            NPC041_LastLocation = 11;
            NPC041_LastStrLocation = LocationEncounters.location_011;

            NPC042_LastLocation = 11;
            NPC042_LastStrLocation = LocationEncounters.location_011;

            NPC043_LastLocation = 11;
            NPC043_LastStrLocation = LocationEncounters.location_011;

            NPC044_LastLocation = 12;
            NPC044_LastStrLocation = LocationEncounters.location_012;

            NPC045_LastLocation = 12;
            NPC045_LastStrLocation = LocationEncounters.location_012;

            NPC046_LastLocation = 12;
            NPC046_LastStrLocation = LocationEncounters.location_012;

            NPC047_LastLocation = 12;
            NPC047_LastStrLocation = LocationEncounters.location_012;

            NPC048_LastLocation = 13;
            NPC048_LastStrLocation = LocationEncounters.location_013;

            NPC049_LastLocation = 13;
            NPC049_LastStrLocation = LocationEncounters.location_013;

            NPC050_LastLocation = 13;
            NPC050_LastStrLocation = LocationEncounters.location_013;

            NPC051_LastLocation = 13;
            NPC051_LastStrLocation = LocationEncounters.location_013;

            NPC052_LastLocation = 14;
            NPC052_LastStrLocation = LocationEncounters.location_014;

            NPC053_LastLocation = 14;
            NPC053_LastStrLocation = LocationEncounters.location_014;

            NPC054_LastLocation = 14;
            NPC054_LastStrLocation = LocationEncounters.location_014;

            NPC055_LastLocation = 14;
            NPC055_LastStrLocation = LocationEncounters.location_014;

            NPC056_LastLocation = 15;
            NPC056_LastStrLocation = LocationEncounters.location_015;

            NPC057_LastLocation = 15;
            NPC057_LastStrLocation = LocationEncounters.location_015;

            NPC058_LastLocation = 15;
            NPC058_LastStrLocation = LocationEncounters.location_015;

            NPC059_LastLocation = 15;
            NPC059_LastStrLocation = LocationEncounters.location_015;

            NPC060_LastLocation = 16;
            NPC060_LastStrLocation = LocationEncounters.location_016;

            NPC061_LastLocation = 16;
            NPC061_LastStrLocation = LocationEncounters.location_016;

            NPC062_LastLocation = 16;
            NPC062_LastStrLocation = LocationEncounters.location_016;

            NPC063_LastLocation = 16;
            NPC063_LastStrLocation = LocationEncounters.location_016;

            NPC064_LastLocation = 01;
            NPC064_LastStrLocation = LocationEncounters.location_001;

            NPC065_LastLocation = 01;
            NPC065_LastStrLocation = LocationEncounters.location_001;

            NPC066_LastLocation = 01;
            NPC066_LastStrLocation = LocationEncounters.location_001;

            NPC067_LastLocation = 01;
            NPC067_LastStrLocation = LocationEncounters.location_001;

            NPC068_LastLocation = 18;
            NPC068_LastStrLocation = LocationEncounters.location_018;

            NPC069_LastLocation = 18;
            NPC069_LastStrLocation = LocationEncounters.location_018;

            NPC070_LastLocation = 18;
            NPC070_LastStrLocation = LocationEncounters.location_018;

            NPC071_LastLocation = 18;
            NPC071_LastStrLocation = LocationEncounters.location_018;

            NPC072_LastLocation = 19;
            NPC072_LastStrLocation = LocationEncounters.location_019;

            NPC073_LastLocation = 19;
            NPC073_LastStrLocation = LocationEncounters.location_019;

            NPC074_LastLocation = 19;
            NPC074_LastStrLocation = LocationEncounters.location_019;

            NPC075_LastLocation = 19;
            NPC075_LastStrLocation = LocationEncounters.location_019;

            NPC076_LastLocation = 20;
            NPC076_LastStrLocation = LocationEncounters.location_020;

            NPC077_LastLocation = 20;
            NPC077_LastStrLocation = LocationEncounters.location_020;

            NPC078_LastLocation = 20;
            NPC078_LastStrLocation = LocationEncounters.location_020;

            NPC079_LastLocation = 20;
            NPC079_LastStrLocation = LocationEncounters.location_020;

            NPC080_LastLocation = 21;
            NPC080_LastStrLocation = LocationEncounters.location_021;

            NPC081_LastLocation = 21;
            NPC081_LastStrLocation = LocationEncounters.location_021;

            NPC082_LastLocation = 21;
            NPC082_LastStrLocation = LocationEncounters.location_021;

            NPC083_LastLocation = 21;
            NPC083_LastStrLocation = LocationEncounters.location_021;

            NPC084_LastLocation = 22;
            NPC084_LastStrLocation = LocationEncounters.location_022;

            NPC085_LastLocation = 22;
            NPC085_LastStrLocation = LocationEncounters.location_022;

            NPC086_LastLocation = 22;
            NPC086_LastStrLocation = LocationEncounters.location_022;

            NPC087_LastLocation = 22;
            NPC087_LastStrLocation = LocationEncounters.location_022;

            NPC088_LastLocation = 23;
            NPC088_LastStrLocation = LocationEncounters.location_023;

            NPC089_LastLocation = 23;
            NPC089_LastStrLocation = LocationEncounters.location_023;

            NPC090_LastLocation = 17;
            NPC090_LastStrLocation = LocationEncounters.location_017;

            NPC091_LastLocation = 23;
            NPC091_LastStrLocation = LocationEncounters.location_023;

            NPC092_LastLocation = 23;
            NPC092_LastStrLocation = LocationEncounters.location_023;

            NPC093_LastLocation = 24;
            NPC093_LastStrLocation = LocationEncounters.location_024;

            NPC094_LastLocation = 24;
            NPC094_LastStrLocation = LocationEncounters.location_024;

            NPC095_LastLocation = 24;
            NPC095_LastStrLocation = LocationEncounters.location_024;

            NPC096_LastLocation = 24;
            NPC096_LastStrLocation = LocationEncounters.location_024;

            NPC097_LastLocation = 25;
            NPC097_LastStrLocation = LocationEncounters.location_025;

            NPC098_LastLocation = 25;
            NPC098_LastStrLocation = LocationEncounters.location_025;

            NPC099_LastLocation = 25;

            NPC099_LastLocation = 25;
            NPC099_LastStrLocation = LocationEncounters.location_025;

            NPC100_LastLocation = 25;
            NPC100_LastStrLocation = LocationEncounters.location_025;

            iTempLocation = 999;
            iTempLastLocation = 999;
            iTempDesireToMove = 999;
            sTempLastLocation = "null";
            sTempCurrentLocation = "null";

            NPC097_CurrentNumLocation = NPC098_CurrentNumLocation = NPC099_CurrentNumLocation = NPC100_CurrentNumLocation = 25;
            NPC093_CurrentNumLocation = NPC094_CurrentNumLocation = NPC095_CurrentNumLocation = NPC096_CurrentNumLocation = 24;
            NPC088_CurrentNumLocation = NPC089_CurrentNumLocation = NPC091_CurrentNumLocation = NPC092_CurrentNumLocation = 23;
            NPC084_CurrentNumLocation = NPC085_CurrentNumLocation = NPC086_CurrentNumLocation = NPC087_CurrentNumLocation = 22;
            NPC080_CurrentNumLocation = NPC081_CurrentNumLocation = NPC082_CurrentNumLocation = NPC083_CurrentNumLocation = 21;
            NPC076_CurrentNumLocation = NPC077_CurrentNumLocation = NPC078_CurrentNumLocation = NPC079_CurrentNumLocation = 20;
            NPC072_CurrentNumLocation = NPC073_CurrentNumLocation = NPC074_CurrentNumLocation = NPC075_CurrentNumLocation = 19;
            NPC068_CurrentNumLocation = NPC069_CurrentNumLocation = NPC070_CurrentNumLocation = NPC071_CurrentNumLocation = 18;
            NPC001_CurrentNumLocation = NPC002_CurrentNumLocation = NPC003_CurrentNumLocation = NPC090_CurrentNumLocation = 17;
            NPC060_CurrentNumLocation = NPC061_CurrentNumLocation = NPC062_CurrentNumLocation = NPC063_CurrentNumLocation = 16;
            NPC056_CurrentNumLocation = NPC057_CurrentNumLocation = NPC058_CurrentNumLocation = NPC059_CurrentNumLocation = 15;
            NPC052_CurrentNumLocation = NPC053_CurrentNumLocation = NPC054_CurrentNumLocation = NPC055_CurrentNumLocation = 14;
            NPC048_CurrentNumLocation = NPC049_CurrentNumLocation = NPC050_CurrentNumLocation = NPC051_CurrentNumLocation = 13;
            NPC044_CurrentNumLocation = NPC045_CurrentNumLocation = NPC046_CurrentNumLocation = NPC047_CurrentNumLocation = 12;
            NPC040_CurrentNumLocation = NPC041_CurrentNumLocation = NPC042_CurrentNumLocation = NPC043_CurrentNumLocation = 11;
            NPC036_CurrentNumLocation = NPC037_CurrentNumLocation = NPC038_CurrentNumLocation = NPC039_CurrentNumLocation = 10;
            NPC032_CurrentNumLocation = NPC033_CurrentNumLocation = NPC034_CurrentNumLocation = NPC035_CurrentNumLocation = 9;
            NPC028_CurrentNumLocation = NPC029_CurrentNumLocation = NPC030_CurrentNumLocation = NPC031_CurrentNumLocation = 8;
            NPC024_CurrentNumLocation = NPC025_CurrentNumLocation = NPC026_CurrentNumLocation = NPC027_CurrentNumLocation = 7;
            NPC020_CurrentNumLocation = NPC021_CurrentNumLocation = NPC022_CurrentNumLocation = NPC023_CurrentNumLocation = 6;
            NPC016_CurrentNumLocation = NPC017_CurrentNumLocation = NPC018_CurrentNumLocation = NPC019_CurrentNumLocation = 5;
            NPC012_CurrentNumLocation = NPC013_CurrentNumLocation = NPC014_CurrentNumLocation = NPC015_CurrentNumLocation = 4;
            NPC008_CurrentNumLocation = NPC009_CurrentNumLocation = NPC010_CurrentNumLocation = NPC011_CurrentNumLocation = 3;
            NPC004_CurrentNumLocation = NPC005_CurrentNumLocation = NPC006_CurrentNumLocation = NPC007_CurrentNumLocation = 2;
            NPC064_CurrentNumLocation = NPC065_CurrentNumLocation = NPC066_CurrentNumLocation = NPC067_CurrentNumLocation = 1;

            NPC001_CurrentStrLocation = LocationEncounters.location_017;
            NPC002_CurrentStrLocation = LocationEncounters.location_017;
            NPC003_CurrentStrLocation = LocationEncounters.location_017;
            NPC004_CurrentStrLocation = LocationEncounters.location_002;
            NPC005_CurrentStrLocation = LocationEncounters.location_002;
            NPC006_CurrentStrLocation = LocationEncounters.location_002;
            NPC007_CurrentStrLocation = LocationEncounters.location_002;
            NPC008_CurrentStrLocation = LocationEncounters.location_003;
            NPC009_CurrentStrLocation = LocationEncounters.location_003;
            NPC010_CurrentStrLocation = LocationEncounters.location_003;
            NPC011_CurrentStrLocation = LocationEncounters.location_003;
            NPC012_CurrentStrLocation = LocationEncounters.location_004;
            NPC013_CurrentStrLocation = LocationEncounters.location_004;
            NPC014_CurrentStrLocation = LocationEncounters.location_004;
            NPC015_CurrentStrLocation = LocationEncounters.location_004;
            NPC016_CurrentStrLocation = LocationEncounters.location_005;
            NPC017_CurrentStrLocation = LocationEncounters.location_005;
            NPC018_CurrentStrLocation = LocationEncounters.location_005;
            NPC019_CurrentStrLocation = LocationEncounters.location_005;
            NPC020_CurrentStrLocation = LocationEncounters.location_006;
            NPC021_CurrentStrLocation = LocationEncounters.location_006;
            NPC022_CurrentStrLocation = LocationEncounters.location_006;
            NPC023_CurrentStrLocation = LocationEncounters.location_006;
            NPC024_CurrentStrLocation = LocationEncounters.location_007;
            NPC025_CurrentStrLocation = LocationEncounters.location_007;
            NPC026_CurrentStrLocation = LocationEncounters.location_007;
            NPC027_CurrentStrLocation = LocationEncounters.location_007;
            NPC028_CurrentStrLocation = LocationEncounters.location_008;
            NPC029_CurrentStrLocation = LocationEncounters.location_008;
            NPC030_CurrentStrLocation = LocationEncounters.location_008;
            NPC031_CurrentStrLocation = LocationEncounters.location_008;
            NPC032_CurrentStrLocation = LocationEncounters.location_009;
            NPC033_CurrentStrLocation = LocationEncounters.location_009;
            NPC034_CurrentStrLocation = LocationEncounters.location_009;
            NPC035_CurrentStrLocation = LocationEncounters.location_009;
            NPC036_CurrentStrLocation = LocationEncounters.location_010;
            NPC037_CurrentStrLocation = LocationEncounters.location_010;
            NPC038_CurrentStrLocation = LocationEncounters.location_010;
            NPC039_CurrentStrLocation = LocationEncounters.location_010;
            NPC040_CurrentStrLocation = LocationEncounters.location_011;
            NPC041_CurrentStrLocation = LocationEncounters.location_011;
            NPC042_CurrentStrLocation = LocationEncounters.location_011;
            NPC043_CurrentStrLocation = LocationEncounters.location_011;
            NPC044_CurrentStrLocation = LocationEncounters.location_012;
            NPC045_CurrentStrLocation = LocationEncounters.location_012;
            NPC046_CurrentStrLocation = LocationEncounters.location_012;
            NPC047_CurrentStrLocation = LocationEncounters.location_012;
            NPC048_CurrentStrLocation = LocationEncounters.location_013;
            NPC049_CurrentStrLocation = LocationEncounters.location_013;
            NPC050_CurrentStrLocation = LocationEncounters.location_013;
            NPC051_CurrentStrLocation = LocationEncounters.location_013;
            NPC052_CurrentStrLocation = LocationEncounters.location_014;
            NPC053_CurrentStrLocation = LocationEncounters.location_014;
            NPC054_CurrentStrLocation = LocationEncounters.location_014;
            NPC055_CurrentStrLocation = LocationEncounters.location_014;
            NPC056_CurrentStrLocation = LocationEncounters.location_015;
            NPC057_CurrentStrLocation = LocationEncounters.location_015;
            NPC058_CurrentStrLocation = LocationEncounters.location_015;
            NPC059_CurrentStrLocation = LocationEncounters.location_015;
            NPC060_CurrentStrLocation = LocationEncounters.location_016;
            NPC061_CurrentStrLocation = LocationEncounters.location_016;
            NPC062_CurrentStrLocation = LocationEncounters.location_016;
            NPC063_CurrentStrLocation = LocationEncounters.location_016;
            NPC064_CurrentStrLocation = LocationEncounters.location_001;
            NPC065_CurrentStrLocation = LocationEncounters.location_001;
            NPC066_CurrentStrLocation = LocationEncounters.location_001;
            NPC067_CurrentStrLocation = LocationEncounters.location_001;
            NPC068_CurrentStrLocation = LocationEncounters.location_018;
            NPC069_CurrentStrLocation = LocationEncounters.location_018;
            NPC070_CurrentStrLocation = LocationEncounters.location_018;
            NPC071_CurrentStrLocation = LocationEncounters.location_018;
            NPC072_CurrentStrLocation = LocationEncounters.location_019;
            NPC073_CurrentStrLocation = LocationEncounters.location_019;
            NPC074_CurrentStrLocation = LocationEncounters.location_019;
            NPC075_CurrentStrLocation = LocationEncounters.location_019;
            NPC076_CurrentStrLocation = LocationEncounters.location_020;
            NPC077_CurrentStrLocation = LocationEncounters.location_020;
            NPC078_CurrentStrLocation = LocationEncounters.location_020;
            NPC079_CurrentStrLocation = LocationEncounters.location_020;
            NPC080_CurrentStrLocation = LocationEncounters.location_021;
            NPC081_CurrentStrLocation = LocationEncounters.location_021;
            NPC082_CurrentStrLocation = LocationEncounters.location_021;
            NPC083_CurrentStrLocation = LocationEncounters.location_021;
            NPC084_CurrentStrLocation = LocationEncounters.location_022;
            NPC085_CurrentStrLocation = LocationEncounters.location_022;
            NPC086_CurrentStrLocation = LocationEncounters.location_022;
            NPC087_CurrentStrLocation = LocationEncounters.location_022;
            NPC088_CurrentStrLocation = LocationEncounters.location_023;
            NPC089_CurrentStrLocation = LocationEncounters.location_023;
            NPC090_CurrentStrLocation = LocationEncounters.location_017;
            NPC091_CurrentStrLocation = LocationEncounters.location_023;
            NPC092_CurrentStrLocation = LocationEncounters.location_023;
            NPC093_CurrentStrLocation = LocationEncounters.location_024;
            NPC094_CurrentStrLocation = LocationEncounters.location_024;
            NPC095_CurrentStrLocation = LocationEncounters.location_024;
            NPC096_CurrentStrLocation = LocationEncounters.location_024;
            NPC097_CurrentStrLocation = LocationEncounters.location_025;
            NPC098_CurrentStrLocation = LocationEncounters.location_025;
            NPC099_CurrentStrLocation = LocationEncounters.location_025;
            NPC100_CurrentStrLocation = LocationEncounters.location_025;

            iClose001 = iClose002 = iClose003 = iClose004 = iClose005 =
            iClose006 = iClose007 = iClose008 = iClose009 = iClose010 =
            iClose011 = iClose012 = iClose013 = iClose014 = iClose015 =
            iClose016 = iClose017 = iClose018 = iClose019 = iClose020 =
            iClose021 = iClose022 = iClose023 = iClose024 = iClose025 =
            iClose026 = iClose027 = iClose028 = iClose029 = iClose030 =
            iClose031 = iClose032 = iClose033 = iClose034 = iClose035 =
            iClose036 = iClose037 = iClose038 = iClose039 = iClose040 =
            iClose041 = iClose042 = iClose043 = iClose044 = iClose045 =
            iClose046 = iClose047 = iClose048 = iClose049 = iClose050 =
            iClose051 = iClose052 = iClose053 = iClose054 = iClose055 =
            iClose056 = iClose057 = iClose058 = iClose059 = iClose060 =
            iClose061 = iClose062 = iClose063 = iClose064 = iClose065 =
            iClose066 = iClose067 = iClose068 = iClose069 = iClose070 =
            iClose071 = iClose072 = iClose073 = iClose074 = iClose075 =
            iClose076 = iClose077 = iClose078 = iClose079 = iClose080 =
            iClose081 = iClose082 = iClose083 = iClose084 = iClose085 =
            iClose086 = iClose087 = iClose088 = iClose089 = iClose090 =
            iClose091 = iClose092 = iClose093 = iClose094 = iClose095 =
            iClose096 = iClose097 = iClose098 = iClose099 = iClose100 =
            0;
        }

        public static void Initialize_NPCs()
        {
            // A list containing any potential names for use.

            // The following names all NPCs.
            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_001 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_002 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_003 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_004 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_005 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_006 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_007 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_008 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_009 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_010 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_011 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_012 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_013 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_014 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_015 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_016 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_017 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_018 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_019 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_020 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_021 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_022 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_023 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_024 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_025 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_026 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_027 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_028 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_029 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_030 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_031 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_032 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_033 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_034 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_035 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_036 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_037 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_038 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_039 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_040 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_041 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_042 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_043 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_044 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_045 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_046 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_047 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_048 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_049 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_050 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_051 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_052 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_053 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_054 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_055 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex); ;

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_056 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_057 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_058 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_059 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_060 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_061 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_062 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_063 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_064 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_065 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_066 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_067 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_068 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_069 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_070 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_071 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_072 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_073 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_074 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_075 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_076 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_077 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_078 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_079 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_080 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_081 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_082 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_083 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_084 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_085 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_086 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_087 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_088 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_089 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_090 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_091 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_092 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_093 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_094 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_095 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_096 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_097 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_098 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_099 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);

            npcIndex = Program.rand.Next(Lists.npcNameOptions.Count);
            NPC_100 = Lists.npcNameOptions[npcIndex];
            Lists.npcNameOptions.RemoveAt(npcIndex);
        }

        public static void NPCs_Go_Looting()
        {
            // What follows is a really dumb way of doing this, but I was just learning and now it's done/working and I don't feel like re-doing it.

            // NPC001
            iScavenge = Program.rand.Next(1, 15);
            if (iScavenge <= 2) // 14% chance to find ONE macguffin. May need to reduce.
            {
                iAvailableMacGuffins001 = iAvailableMacGuffins001 + 1;
            }
            if (iScavenge == 3) // 7% chance to find a weapon. May need to reduce.
            {
                iRandomWeapon = Program.rand.Next(1, 4);
                if (iRandomWeapon == 1)
                {
                    sAvailableWeapons001 = sWeaponType1;
                }
                if (iRandomWeapon == 2)
                {
                    sAvailableWeapons001 = sWeaponType2;
                }
                if (iRandomWeapon == 3)
                {
                    sAvailableWeapons001 = sWeaponType3;
                }
            }

            // Below repeats for NPC002-NPC100.
            iScavenge = Program.rand.Next(1, 15);
            if (iScavenge <= 2) 
            { 
                iAvailableMacGuffins002 = iAvailableMacGuffins002 + 1; } 
            if (iScavenge == 3)
            { 
                iRandomWeapon = Program.rand.Next(1, 4); 
                if (iRandomWeapon == 1) 
                { 
                    sAvailableWeapons002 = sWeaponType1; 
                } 
                if (iRandomWeapon == 2)
                { 
                    sAvailableWeapons002 = sWeaponType2; 
                } 
                if (iRandomWeapon == 3) 
                { 
                    sAvailableWeapons002 = sWeaponType3; 
                }
            }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins003 = iAvailableMacGuffins003 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons003 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons003 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons003 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins004 = iAvailableMacGuffins004 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons004 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons004 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons004 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins005 = iAvailableMacGuffins005 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons005 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons005 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons005 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins006 = iAvailableMacGuffins006 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons006 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons006 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons006 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins007 = iAvailableMacGuffins007 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons007 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons007 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons007 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins008 = iAvailableMacGuffins008 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons008 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons008 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons008 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins009 = iAvailableMacGuffins009 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons009 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons009 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons009 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins010 = iAvailableMacGuffins010 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons010 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons010 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons010 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins011 = iAvailableMacGuffins011 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons011 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons011 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons011 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins012 = iAvailableMacGuffins012 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons012 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons012 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons012 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins013 = iAvailableMacGuffins013 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons013 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons013 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons013 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins014 = iAvailableMacGuffins014 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons014 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons014 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons014 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins015 = iAvailableMacGuffins015 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons015 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons015 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons015 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins016 = iAvailableMacGuffins016 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons016 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons016 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons016 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins017 = iAvailableMacGuffins017 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons017 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons017 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons017 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins018 = iAvailableMacGuffins018 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons018 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons018 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons018 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins019 = iAvailableMacGuffins019 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons019 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons019 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons019 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins020 = iAvailableMacGuffins020 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons020 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons020 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons020 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins021 = iAvailableMacGuffins021 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons021 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons021 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons021 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins022 = iAvailableMacGuffins022 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons022 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons022 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons022 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins023 = iAvailableMacGuffins023 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons023 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons023 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons023 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins024 = iAvailableMacGuffins024 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons024 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons024 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons024 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins025 = iAvailableMacGuffins025 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons025 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons025 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons025 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins026 = iAvailableMacGuffins026 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons026 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons026 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons026 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins027 = iAvailableMacGuffins027 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons027 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons027 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons027 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins028 = iAvailableMacGuffins028 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons028 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons028 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons028 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins029 = iAvailableMacGuffins029 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons029 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons029 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons029 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins030 = iAvailableMacGuffins030 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons030 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons030 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons030 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins031 = iAvailableMacGuffins031 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons031 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons031 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons031 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins032 = iAvailableMacGuffins032 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons032 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons032 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons032 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins033 = iAvailableMacGuffins033 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons033 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons033 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons033 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins034 = iAvailableMacGuffins034 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons034 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons034 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons034 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins035 = iAvailableMacGuffins035 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons035 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons035 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons035 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins036 = iAvailableMacGuffins036 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons036 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons036 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons036 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins037 = iAvailableMacGuffins037 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons037 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons037 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons037 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins038 = iAvailableMacGuffins038 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons038 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons038 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons038 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins039 = iAvailableMacGuffins039 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons039 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons039 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons039 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins040 = iAvailableMacGuffins040 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons040 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons040 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons040 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins041 = iAvailableMacGuffins041 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons041 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons041 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons041 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins042 = iAvailableMacGuffins042 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons042 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons042 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons042 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins043 = iAvailableMacGuffins043 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons043 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons043 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons043 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins044 = iAvailableMacGuffins044 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons044 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons044 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons044 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins045 = iAvailableMacGuffins045 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons045 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons045 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons045 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins046 = iAvailableMacGuffins046 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons046 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons046 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons046 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins047 = iAvailableMacGuffins047 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons047 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons047 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons047 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins048 = iAvailableMacGuffins048 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons048 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons048 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons048 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins049 = iAvailableMacGuffins049 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons049 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons049 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons049 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins050 = iAvailableMacGuffins050 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons050 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons050 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons050 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins051 = iAvailableMacGuffins051 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons051 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons051 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons051 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins052 = iAvailableMacGuffins052 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons052 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons052 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons052 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins053 = iAvailableMacGuffins053 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons053 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons053 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons053 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins054 = iAvailableMacGuffins054 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons054 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons054 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons054 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins055 = iAvailableMacGuffins055 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons055 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons055 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons055 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins056 = iAvailableMacGuffins056 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons056 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons056 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons056 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins057 = iAvailableMacGuffins057 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons057 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons057 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons057 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins058 = iAvailableMacGuffins058 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons058 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons058 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons058 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins059 = iAvailableMacGuffins059 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons059 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons059 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons059 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins060 = iAvailableMacGuffins060 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons060 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons060 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons060 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins061 = iAvailableMacGuffins061 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons061 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons061 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons061 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins062 = iAvailableMacGuffins062 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons062 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons062 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons062 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins063 = iAvailableMacGuffins063 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons063 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons063 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons063 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins064 = iAvailableMacGuffins064 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons064 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons064 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons064 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins065 = iAvailableMacGuffins065 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons065 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons065 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons065 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins066 = iAvailableMacGuffins066 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons066 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons066 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons066 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins067 = iAvailableMacGuffins067 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons067 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons067 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons067 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins068 = iAvailableMacGuffins068 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons068 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons068 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons068 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins069 = iAvailableMacGuffins069 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons069 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons069 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons069 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins070 = iAvailableMacGuffins070 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons070 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons070 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons070 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins071 = iAvailableMacGuffins071 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons071 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons071 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons071 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins072 = iAvailableMacGuffins072 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons072 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons072 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons072 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins073 = iAvailableMacGuffins073 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons073 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons073 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons073 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins074 = iAvailableMacGuffins074 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons074 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons074 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons074 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins075 = iAvailableMacGuffins075 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons075 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons075 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons075 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins076 = iAvailableMacGuffins076 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons076 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons076 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons076 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins077 = iAvailableMacGuffins077 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons077 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons077 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons077 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins078 = iAvailableMacGuffins078 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons078 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons078 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons078 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins079 = iAvailableMacGuffins079 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons079 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons079 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons079 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins080 = iAvailableMacGuffins080 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons080 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons080 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons080 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins081 = iAvailableMacGuffins081 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons081 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons081 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons081 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins082 = iAvailableMacGuffins082 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons082 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons082 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons082 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins083 = iAvailableMacGuffins083 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons083 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons083 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons083 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins084 = iAvailableMacGuffins084 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons084 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons084 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons084 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins085 = iAvailableMacGuffins085 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons085 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons085 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons085 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins086 = iAvailableMacGuffins086 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons086 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons086 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons086 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins087 = iAvailableMacGuffins087 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons087 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons087 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons087 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins088 = iAvailableMacGuffins088 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons088 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons088 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons088 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins089 = iAvailableMacGuffins089 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons089 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons089 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons089 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins090 = iAvailableMacGuffins090 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons090 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons090 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons090 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins091 = iAvailableMacGuffins091 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons091 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons091 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons091 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins092 = iAvailableMacGuffins092 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons092 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons092 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons092 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins093 = iAvailableMacGuffins093 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons093 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons093 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons093 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins094 = iAvailableMacGuffins094 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons094 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons094 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons094 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins095 = iAvailableMacGuffins095 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons095 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons095 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons095 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins096 = iAvailableMacGuffins096 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons096 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons096 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons096 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins097 = iAvailableMacGuffins097 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons097 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons097 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons097 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins098 = iAvailableMacGuffins098 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons098 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons098 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons098 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins099 = iAvailableMacGuffins099 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons099 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons099 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons099 = sWeaponType3; } }
            iScavenge = Program.rand.Next(1, 15); if (iScavenge <= 2) { iAvailableMacGuffins100 = iAvailableMacGuffins100 + 1; } if (iScavenge == 3)
            { iRandomWeapon = Program.rand.Next(1, 4); if (iRandomWeapon == 1) { sAvailableWeapons100 = sWeaponType1; } if (iRandomWeapon == 2) { sAvailableWeapons100 = sWeaponType2; } if (iRandomWeapon == 3) { sAvailableWeapons100 = sWeaponType3; } }
        }

        public static void NPC100_PantsDownGenderCheck()
        {
            if (NPC_100 == "Aaron" || NPC_100 == "Alexander" || NPC_100 == "Andrew" || NPC_100 == "Anthony" || NPC_100 == "Austin" ||
            NPC_100 == "Benjamin" || NPC_100 == "Brandon" || NPC_100 == "Carlos" || NPC_100 == "Carter" || NPC_100 == "Charles" ||
            NPC_100 == "Christopher" || NPC_100 == "Daniel" || NPC_100 == "David" || NPC_100 == "Dominic" || NPC_100 == "Dylan" ||
            NPC_100 == "Elijah" || NPC_100 == "Ethan" || NPC_100 == "Evan" || NPC_100 == "Henry" ||
            NPC_100 == "Isaac" || NPC_100 == "Isaiah" || NPC_100 == "Jackson" || NPC_100 == "Jacob" || NPC_100 == "James" ||
            NPC_100 == "Jason" || NPC_100 == "Jonathan" || NPC_100 == "Joshua" || NPC_100 == "Julian" || NPC_100 == "Justin" ||
            NPC_100 == "Kevin" || NPC_100 == "Liam" || NPC_100 == "Logan" || NPC_100 == "Lucas" || NPC_100 == "Luke"
            || NPC_100 == "Mason" || NPC_100 == "Matthew" || NPC_100 == "Michael" || NPC_100 == "Nathan" || NPC_100 == "Nicholas" ||
            NPC_100 == "Noah" || NPC_100 == "Owen" || NPC_100 == "Richard" || NPC_100 == "Robert" || NPC_100 == "Ryan" ||
            NPC_100 == "Samuel" || NPC_100 == "Sebastian" || NPC_100 == "Tyler" || NPC_100 == "William" || NPC_100 == "Wyatt" ||
            NPC_100 == "Zachary")
            {
                sGenderHisHer = "his"; // each name will assign a male or female override value;
                sGenderHeShe = "he"; // each name will assign a male or female override value;
                sGenderHimHer = "him"; // each name will assign a male or female override value;
                sGenderGuyGirl = "guy";
            }
            else
            {
                sGenderHisHer = "her"; // each name will assign a male or female override value;
                sGenderHeShe = "she"; // each name will assign a male or female override value;
                sGenderHimHer = "her"; // each name will assign a male or female override value;
                sGenderGuyGirl = "girl";
            }
        }

        public static void tempNPC_PantsDownGenderCheck()
        {
            if (
            tempNPC == "Aaron" || tempNPC == "Alexander" || tempNPC == "Andrew" || tempNPC == "Anthony" || tempNPC == "Austin" ||
            tempNPC == "Benjamin" || tempNPC == "Brandon" || tempNPC == "Carlos" || tempNPC == "Carter" || tempNPC == "Charles" ||
            tempNPC == "Christopher" || tempNPC == "Daniel" || tempNPC == "David" || tempNPC == "Dominic" || tempNPC == "Dylan" ||
            tempNPC == "Elijah" || tempNPC == "Ethan" || tempNPC == "Evan" || tempNPC == "Henry" ||
            tempNPC == "Isaac" || tempNPC == "Isaiah" || tempNPC == "Jackson" || tempNPC == "Jacob" || tempNPC == "James" ||
            tempNPC == "Jason" || tempNPC == "Jonathan" || tempNPC == "Joshua" || tempNPC == "Julian" || tempNPC == "Justin" ||
            tempNPC == "Kevin" || tempNPC == "Liam" || tempNPC == "Logan" || tempNPC == "Lucas" || tempNPC == "Luke"
            || tempNPC == "Mason" || tempNPC == "Matthew" || tempNPC == "Michael" || tempNPC == "Nathan" || tempNPC == "Nicholas" ||
            tempNPC == "Noah" || tempNPC == "Owen" || tempNPC == "Richard" || tempNPC == "Robert" || tempNPC == "Ryan" ||
            tempNPC == "Samuel" || tempNPC == "Sebastian" || tempNPC == "Tyler" || tempNPC == "William" || tempNPC == "Wyatt" ||
            tempNPC == "Zachary")
            {
                sGenderHisHer = "his"; // each name will assign a male or female override value;
                sGenderHeShe = "he"; // each name will assign a male or female override value;
                sGenderHimHer = "him"; // each name will assign a male or female override value;
                sGenderGuyGirl = "guy";
            }
            else
            {
                sGenderHisHer = "her"; // each name will assign a male or female override value;
                sGenderHeShe = "she"; // each name will assign a male or female override value;
                sGenderHimHer = "her"; // each name will assign a male or female override value;
                sGenderGuyGirl = "girl";
            }
        }

        public static void Actors_PantsDownGenderCheck()
        {
            if (RandomEncounters.Actor01 == "Aaron" || RandomEncounters.Actor01 == "Alexander" || RandomEncounters.Actor01 == "Andrew" || RandomEncounters.Actor01 == "Anthony" || RandomEncounters.Actor01 == "Austin" || RandomEncounters.Actor01 == "Benjamin" || RandomEncounters.Actor01 == "Brandon" || RandomEncounters.Actor01 == "Carlos"
            || RandomEncounters.Actor01 == "Carter" || RandomEncounters.Actor01 == "Charles" || RandomEncounters.Actor01 == "Christopher" || RandomEncounters.Actor01 == "Daniel" || RandomEncounters.Actor01 == "David" || RandomEncounters.Actor01 == "Dominic" || RandomEncounters.Actor01 == "Dylan" || RandomEncounters.Actor01 == "Elijah" || RandomEncounters.Actor01 == "Ethan"
            || RandomEncounters.Actor01 == "Evan" || RandomEncounters.Actor01 == "Henry" || RandomEncounters.Actor01 == "Isaac" || RandomEncounters.Actor01 == "Isaiah" || RandomEncounters.Actor01 == "Jackson" || RandomEncounters.Actor01 == "Jacob" || RandomEncounters.Actor01 == "James" || RandomEncounters.Actor01 == "Jason" || RandomEncounters.Actor01 == "Jonathan"
            || RandomEncounters.Actor01 == "Joshua" || RandomEncounters.Actor01 == "Julian" || RandomEncounters.Actor01 == "Justin" || RandomEncounters.Actor01 == "Kevin" || RandomEncounters.Actor01 == "Liam" || RandomEncounters.Actor01 == "Logan" || RandomEncounters.Actor01 == "Lucas" || RandomEncounters.Actor01 == "Luke" || RandomEncounters.Actor01 == "Mason"
            || RandomEncounters.Actor01 == "Matthew" || RandomEncounters.Actor01 == "Michael" || RandomEncounters.Actor01 == "Nathan" || RandomEncounters.Actor01 == "Nicholas" || RandomEncounters.Actor01 == "Noah" || RandomEncounters.Actor01 == "Owen" || RandomEncounters.Actor01 == "Richard" || RandomEncounters.Actor01 == "Robert" || RandomEncounters.Actor01 == "Ryan"
            || RandomEncounters.Actor01 == "Samuel" || RandomEncounters.Actor01 == "Sebastian" || RandomEncounters.Actor01 == "Tyler" || RandomEncounters.Actor01 == "William" || RandomEncounters.Actor01 == "Wyatt" || RandomEncounters.Actor01 == "Zachary")
            { sGenderHisHer01 = "his"; sGenderHeShe01 = "he"; sGenderHimHer01 = "him"; sGenderGuyGirl01 = "guy"; }
            else { sGenderHisHer01 = "her"; sGenderHeShe01 = "she"; sGenderHimHer01 = "her"; sGenderGuyGirl01 = "girl"; }

            if (RandomEncounters.Actor02 == "Aaron" || RandomEncounters.Actor02 == "Alexander" || RandomEncounters.Actor02 == "Andrew" || RandomEncounters.Actor02 == "Anthony" || RandomEncounters.Actor02 == "Austin" || RandomEncounters.Actor02 == "Benjamin" || RandomEncounters.Actor02 == "Brandon" || RandomEncounters.Actor02 == "Carlos"
            || RandomEncounters.Actor02 == "Carter" || RandomEncounters.Actor02 == "Charles" || RandomEncounters.Actor02 == "Christopher" || RandomEncounters.Actor02 == "Daniel" || RandomEncounters.Actor02 == "David" || RandomEncounters.Actor02 == "Dominic" || RandomEncounters.Actor02 == "Dylan" || RandomEncounters.Actor02 == "Elijah" || RandomEncounters.Actor02 == "Ethan"
            || RandomEncounters.Actor02 == "Evan" || RandomEncounters.Actor02 == "Henry" || RandomEncounters.Actor02 == "Isaac" || RandomEncounters.Actor02 == "Isaiah" || RandomEncounters.Actor02 == "Jackson" || RandomEncounters.Actor02 == "Jacob" || RandomEncounters.Actor02 == "James" || RandomEncounters.Actor02 == "Jason" || RandomEncounters.Actor02 == "Jonathan"
            || RandomEncounters.Actor02 == "Joshua" || RandomEncounters.Actor02 == "Julian" || RandomEncounters.Actor02 == "Justin" || RandomEncounters.Actor02 == "Kevin" || RandomEncounters.Actor02 == "Liam" || RandomEncounters.Actor02 == "Logan" || RandomEncounters.Actor02 == "Lucas" || RandomEncounters.Actor02 == "Luke" || RandomEncounters.Actor02 == "Mason"
            || RandomEncounters.Actor02 == "Matthew" || RandomEncounters.Actor02 == "Michael" || RandomEncounters.Actor02 == "Nathan" || RandomEncounters.Actor02 == "Nicholas" || RandomEncounters.Actor02 == "Noah" || RandomEncounters.Actor02 == "Owen" || RandomEncounters.Actor02 == "Richard" || RandomEncounters.Actor02 == "Robert" || RandomEncounters.Actor02 == "Ryan"
            || RandomEncounters.Actor02 == "Samuel" || RandomEncounters.Actor02 == "Sebastian" || RandomEncounters.Actor02 == "Tyler" || RandomEncounters.Actor02 == "William" || RandomEncounters.Actor02 == "Wyatt" || RandomEncounters.Actor02 == "Zachary")
            { sGenderHisHer02 = "his"; sGenderHeShe02 = "he"; sGenderHimHer02 = "him"; sGenderGuyGirl02 = "guy"; sGenderBrotherSister02 = "brother"; }
            else { sGenderHisHer02 = "her"; sGenderHeShe02 = "she"; sGenderHimHer02 = "her"; sGenderGuyGirl02 = "girl"; sGenderBrotherSister02 = "sister"; }

            if (RandomEncounters.Actor03 == "Aaron" || RandomEncounters.Actor03 == "Alexander" || RandomEncounters.Actor03 == "Andrew" || RandomEncounters.Actor03 == "Anthony" || RandomEncounters.Actor03 == "Austin" || RandomEncounters.Actor03 == "Benjamin" || RandomEncounters.Actor03 == "Brandon" || RandomEncounters.Actor03 == "Carlos"
            || RandomEncounters.Actor03 == "Carter" || RandomEncounters.Actor03 == "Charles" || RandomEncounters.Actor03 == "Christopher" || RandomEncounters.Actor03 == "Daniel" || RandomEncounters.Actor03 == "David" || RandomEncounters.Actor03 == "Dominic" || RandomEncounters.Actor03 == "Dylan" || RandomEncounters.Actor03 == "Elijah" || RandomEncounters.Actor03 == "Ethan"
            || RandomEncounters.Actor03 == "Evan" || RandomEncounters.Actor03 == "Henry" || RandomEncounters.Actor03 == "Isaac" || RandomEncounters.Actor03 == "Isaiah" || RandomEncounters.Actor03 == "Jackson" || RandomEncounters.Actor03 == "Jacob" || RandomEncounters.Actor03 == "James" || RandomEncounters.Actor03 == "Jason" || RandomEncounters.Actor03 == "Jonathan"
            || RandomEncounters.Actor03 == "Joshua" || RandomEncounters.Actor03 == "Julian" || RandomEncounters.Actor03 == "Justin" || RandomEncounters.Actor03 == "Kevin" || RandomEncounters.Actor03 == "Liam" || RandomEncounters.Actor03 == "Logan" || RandomEncounters.Actor03 == "Lucas" || RandomEncounters.Actor03 == "Luke" || RandomEncounters.Actor03 == "Mason"
            || RandomEncounters.Actor03 == "Matthew" || RandomEncounters.Actor03 == "Michael" || RandomEncounters.Actor03 == "Nathan" || RandomEncounters.Actor03 == "Nicholas" || RandomEncounters.Actor03 == "Noah" || RandomEncounters.Actor03 == "Owen" || RandomEncounters.Actor03 == "Richard" || RandomEncounters.Actor03 == "Robert" || RandomEncounters.Actor03 == "Ryan"
            || RandomEncounters.Actor03 == "Samuel" || RandomEncounters.Actor03 == "Sebastian" || RandomEncounters.Actor03 == "Tyler" || RandomEncounters.Actor03 == "William" || RandomEncounters.Actor03 == "Wyatt" || RandomEncounters.Actor03 == "Zachary")
            { sGenderHisHer03 = "his"; sGenderHeShe03 = "he"; sGenderHimHer03 = "him"; sGenderGuyGirl03 = "guy"; }
            else { sGenderHisHer03 = "her"; sGenderHeShe03 = "she"; sGenderHimHer03 = "her"; sGenderGuyGirl03 = "girl"; }

            if (RandomEncounters.Actor04 == "Aaron" || RandomEncounters.Actor04 == "Alexander" || RandomEncounters.Actor04 == "Andrew" || RandomEncounters.Actor04 == "Anthony" || RandomEncounters.Actor04 == "Austin" || RandomEncounters.Actor04 == "Benjamin" || RandomEncounters.Actor04 == "Brandon" || RandomEncounters.Actor04 == "Carlos"
            || RandomEncounters.Actor04 == "Carter" || RandomEncounters.Actor04 == "Charles" || RandomEncounters.Actor04 == "Christopher" || RandomEncounters.Actor04 == "Daniel" || RandomEncounters.Actor04 == "David" || RandomEncounters.Actor04 == "Dominic" || RandomEncounters.Actor04 == "Dylan" || RandomEncounters.Actor04 == "Elijah" || RandomEncounters.Actor04 == "Ethan"
            || RandomEncounters.Actor04 == "Evan" || RandomEncounters.Actor04 == "Henry" || RandomEncounters.Actor04 == "Isaac" || RandomEncounters.Actor04 == "Isaiah" || RandomEncounters.Actor04 == "Jackson" || RandomEncounters.Actor04 == "Jacob" || RandomEncounters.Actor04 == "James" || RandomEncounters.Actor04 == "Jason" || RandomEncounters.Actor04 == "Jonathan"
            || RandomEncounters.Actor04 == "Joshua" || RandomEncounters.Actor04 == "Julian" || RandomEncounters.Actor04 == "Justin" || RandomEncounters.Actor04 == "Kevin" || RandomEncounters.Actor04 == "Liam" || RandomEncounters.Actor04 == "Logan" || RandomEncounters.Actor04 == "Lucas" || RandomEncounters.Actor04 == "Luke" || RandomEncounters.Actor04 == "Mason"
            || RandomEncounters.Actor04 == "Matthew" || RandomEncounters.Actor04 == "Michael" || RandomEncounters.Actor04 == "Nathan" || RandomEncounters.Actor04 == "Nicholas" || RandomEncounters.Actor04 == "Noah" || RandomEncounters.Actor04 == "Owen" || RandomEncounters.Actor04 == "Richard" || RandomEncounters.Actor04 == "Robert" || RandomEncounters.Actor04 == "Ryan"
            || RandomEncounters.Actor04 == "Samuel" || RandomEncounters.Actor04 == "Sebastian" || RandomEncounters.Actor04 == "Tyler" || RandomEncounters.Actor04 == "William" || RandomEncounters.Actor04 == "Wyatt" || RandomEncounters.Actor04 == "Zachary")
            { sGenderHisHer04 = "his"; sGenderHeShe04 = "he"; sGenderHimHer04 = "him"; sGenderGuyGirl04 = "guy"; }
            else { sGenderHisHer04 = "her"; sGenderHeShe04 = "she"; sGenderHimHer04 = "her"; sGenderGuyGirl04 = "girl"; }

            if (RandomEncounters.Actor05 == "Aaron" || RandomEncounters.Actor05 == "Alexander" || RandomEncounters.Actor05 == "Andrew" || RandomEncounters.Actor05 == "Anthony" || RandomEncounters.Actor05 == "Austin" || RandomEncounters.Actor05 == "Benjamin" || RandomEncounters.Actor05 == "Brandon" || RandomEncounters.Actor05 == "Carlos"
            || RandomEncounters.Actor05 == "Carter" || RandomEncounters.Actor05 == "Charles" || RandomEncounters.Actor05 == "Christopher" || RandomEncounters.Actor05 == "Daniel" || RandomEncounters.Actor05 == "David" || RandomEncounters.Actor05 == "Dominic" || RandomEncounters.Actor05 == "Dylan" || RandomEncounters.Actor05 == "Elijah" || RandomEncounters.Actor05 == "Ethan"
            || RandomEncounters.Actor05 == "Evan" || RandomEncounters.Actor05 == "Henry" || RandomEncounters.Actor05 == "Isaac" || RandomEncounters.Actor05 == "Isaiah" || RandomEncounters.Actor05 == "Jackson" || RandomEncounters.Actor05 == "Jacob" || RandomEncounters.Actor05 == "James" || RandomEncounters.Actor05 == "Jason" || RandomEncounters.Actor05 == "Jonathan"
            || RandomEncounters.Actor05 == "Joshua" || RandomEncounters.Actor05 == "Julian" || RandomEncounters.Actor05 == "Justin" || RandomEncounters.Actor05 == "Kevin" || RandomEncounters.Actor05 == "Liam" || RandomEncounters.Actor05 == "Logan" || RandomEncounters.Actor05 == "Lucas" || RandomEncounters.Actor05 == "Luke" || RandomEncounters.Actor05 == "Mason"
            || RandomEncounters.Actor05 == "Matthew" || RandomEncounters.Actor05 == "Michael" || RandomEncounters.Actor05 == "Nathan" || RandomEncounters.Actor05 == "Nicholas" || RandomEncounters.Actor05 == "Noah" || RandomEncounters.Actor05 == "Owen" || RandomEncounters.Actor05 == "Richard" || RandomEncounters.Actor05 == "Robert" || RandomEncounters.Actor05 == "Ryan"
            || RandomEncounters.Actor05 == "Samuel" || RandomEncounters.Actor05 == "Sebastian" || RandomEncounters.Actor05 == "Tyler" || RandomEncounters.Actor05 == "William" || RandomEncounters.Actor05 == "Wyatt" || RandomEncounters.Actor05 == "Zachary")
            { sGenderHisHer05 = "his"; sGenderHeShe05 = "he"; sGenderHimHer05 = "him"; sGenderGuyGirl05 = "guy"; }
            else { sGenderHisHer05 = "her"; sGenderHeShe05 = "she"; sGenderHimHer05 = "her"; sGenderGuyGirl05 = "girl"; }

            if (RandomEncounters.Actor06 == "Aaron" || RandomEncounters.Actor06 == "Alexander" || RandomEncounters.Actor06 == "Andrew" || RandomEncounters.Actor06 == "Anthony" || RandomEncounters.Actor06 == "Austin" || RandomEncounters.Actor06 == "Benjamin" || RandomEncounters.Actor06 == "Brandon" || RandomEncounters.Actor06 == "Carlos"
            || RandomEncounters.Actor06 == "Carter" || RandomEncounters.Actor06 == "Charles" || RandomEncounters.Actor06 == "Christopher" || RandomEncounters.Actor06 == "Daniel" || RandomEncounters.Actor06 == "David" || RandomEncounters.Actor06 == "Dominic" || RandomEncounters.Actor06 == "Dylan" || RandomEncounters.Actor06 == "Elijah" || RandomEncounters.Actor06 == "Ethan"
            || RandomEncounters.Actor06 == "Evan" || RandomEncounters.Actor06 == "Henry" || RandomEncounters.Actor06 == "Isaac" || RandomEncounters.Actor06 == "Isaiah" || RandomEncounters.Actor06 == "Jackson" || RandomEncounters.Actor06 == "Jacob" || RandomEncounters.Actor06 == "James" || RandomEncounters.Actor06 == "Jason" || RandomEncounters.Actor06 == "Jonathan"
            || RandomEncounters.Actor06 == "Joshua" || RandomEncounters.Actor06 == "Julian" || RandomEncounters.Actor06 == "Justin" || RandomEncounters.Actor06 == "Kevin" || RandomEncounters.Actor06 == "Liam" || RandomEncounters.Actor06 == "Logan" || RandomEncounters.Actor06 == "Lucas" || RandomEncounters.Actor06 == "Luke" || RandomEncounters.Actor06 == "Mason"
            || RandomEncounters.Actor06 == "Matthew" || RandomEncounters.Actor06 == "Michael" || RandomEncounters.Actor06 == "Nathan" || RandomEncounters.Actor06 == "Nicholas" || RandomEncounters.Actor06 == "Noah" || RandomEncounters.Actor06 == "Owen" || RandomEncounters.Actor06 == "Richard" || RandomEncounters.Actor06 == "Robert" || RandomEncounters.Actor06 == "Ryan"
            || RandomEncounters.Actor06 == "Samuel" || RandomEncounters.Actor06 == "Sebastian" || RandomEncounters.Actor06 == "Tyler" || RandomEncounters.Actor06 == "William" || RandomEncounters.Actor06 == "Wyatt" || RandomEncounters.Actor06 == "Zachary")
            { sGenderHisHer06 = "his"; sGenderHeShe06 = "he"; sGenderHimHer06 = "him"; sGenderGuyGirl06 = "guy"; }
            else { sGenderHisHer06 = "her"; sGenderHeShe06 = "she"; sGenderHimHer06 = "her"; sGenderGuyGirl06 = "girl"; }
        }

        public static void sLookedFor_PantsDownGenderCheck()
        {
            if (Conversation.sLookedForNPC == "Aaron" || Conversation.sLookedForNPC == "Alexander" || Conversation.sLookedForNPC == "Andrew" || Conversation.sLookedForNPC == "Anthony" || Conversation.sLookedForNPC == "Austin" || Conversation.sLookedForNPC == "Benjamin" || Conversation.sLookedForNPC == "Brandon" || Conversation.sLookedForNPC == "Carlos"
            || Conversation.sLookedForNPC == "Carter" || Conversation.sLookedForNPC == "Charles" || Conversation.sLookedForNPC == "Christopher" || Conversation.sLookedForNPC == "Daniel" || Conversation.sLookedForNPC == "David" || Conversation.sLookedForNPC == "Dominic" || Conversation.sLookedForNPC == "Dylan" || Conversation.sLookedForNPC == "Elijah" || Conversation.sLookedForNPC == "Ethan"
            || Conversation.sLookedForNPC == "Evan" || Conversation.sLookedForNPC == "Henry" || Conversation.sLookedForNPC == "Isaac" || Conversation.sLookedForNPC == "Isaiah" || Conversation.sLookedForNPC == "Jackson" || Conversation.sLookedForNPC == "Jacob" || Conversation.sLookedForNPC == "James" || Conversation.sLookedForNPC == "Jason" || Conversation.sLookedForNPC == "Jonathan"
            || Conversation.sLookedForNPC == "Joshua" || Conversation.sLookedForNPC == "Julian" || Conversation.sLookedForNPC == "Justin" || Conversation.sLookedForNPC == "Kevin" || Conversation.sLookedForNPC == "Liam" || Conversation.sLookedForNPC == "Logan" || Conversation.sLookedForNPC == "Lucas" || Conversation.sLookedForNPC == "Luke" || Conversation.sLookedForNPC == "Mason"
            || Conversation.sLookedForNPC == "Matthew" || Conversation.sLookedForNPC == "Michael" || Conversation.sLookedForNPC == "Nathan" || Conversation.sLookedForNPC == "Nicholas" || Conversation.sLookedForNPC == "Noah" || Conversation.sLookedForNPC == "Owen" || Conversation.sLookedForNPC == "Richard" || Conversation.sLookedForNPC == "Robert" || Conversation.sLookedForNPC == "Ryan"
            || Conversation.sLookedForNPC == "Samuel" || Conversation.sLookedForNPC == "Sebastian" || Conversation.sLookedForNPC == "Tyler" || Conversation.sLookedForNPC == "William" || Conversation.sLookedForNPC == "Wyatt" || Conversation.sLookedForNPC == "Zachary")
            {
                sGenderHisHer = "his"; // each name will assign a male or female override value;
                sGenderHeShe = "he"; // each name will assign a male or female override value;
                sGenderHimHer = "him"; // each name will assign a male or female override value; 
                sGenderGuyGirl = "guy";
            }
            else
            {
                sGenderHisHer = "her"; // each name will assign a male or female override value;
                sGenderHeShe = "she"; // each name will assign a male or female override value;
                sGenderHimHer = "her"; // each name will assign a male or female override value;
                sGenderGuyGirl = "girl";
            }
        }

        public static void SetUpForShuffler()
        {
            Notebook.iTempObserved = 0;
            LocationEncounters.bNothingHappening = true;

            iRandomNPC = Program.rand.Next(Lists.NPCRoster.Count); // Pick a random NPC from the list.
            tempNPC = Lists.NPCRoster[iRandomNPC]; // Use "tempNPC" as the currently-selected NPC from the list.

            GetAllNPCLocals();
            tempNPC_PantsDownGenderCheck();
            CorpseOrNot();
        }

        public static void GetAllNPCLocals()
        {
            if (tempNPC == NPC_001) { Conversation.bTempTalked = Conversation.bAlreadyTalked001; sTempWeapons = sAvailableWeapons001; /* Conversation.iSpeaker001 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins001; iTempLocation = NPC001_CurrentNumLocation; iTempLastLocation = NPC001_LastLocation; sTempLastLocation = NPC001_LastStrLocation; sTempCurrentLocation = NPC001_CurrentStrLocation; iTempDesireToMove = DesireToMove001; bTempCorpse = bCorpse001; iCloseEncounters = iClose001; Notebook.bTempNoted = Notebook.bNoted001; Notebook.iTempObserved = Notebook.iObserved001; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne001; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo001; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree001; Notebook.bNoteOne = Notebook.bNoteOne001; Notebook.bNoteTwo = Notebook.bNoteTwo001; Notebook.bNoteThree = Notebook.bNoteThree001; iTempLoyalty = iLoyalty001; bTempCorpse = bCorpse001; Flood.bPutInDanger = Flood.bPutInDanger001; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted001; }
            if (tempNPC == NPC_002) { Conversation.bTempTalked = Conversation.bAlreadyTalked002; sTempWeapons = sAvailableWeapons002; /* Conversation.iSpeaker002 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins002; iTempLocation = NPC002_CurrentNumLocation; iTempLastLocation = NPC002_LastLocation; sTempLastLocation = NPC002_LastStrLocation; sTempCurrentLocation = NPC002_CurrentStrLocation; iTempDesireToMove = DesireToMove002; bTempCorpse = bCorpse002; iCloseEncounters = iClose002; Notebook.bTempNoted = Notebook.bNoted002; Notebook.iTempObserved = Notebook.iObserved002; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne002; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo002; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree002; Notebook.bNoteOne = Notebook.bNoteOne002; Notebook.bNoteTwo = Notebook.bNoteTwo002; Notebook.bNoteThree = Notebook.bNoteThree002; iTempLoyalty = iLoyalty002; bTempCorpse = bCorpse002; Flood.bPutInDanger = Flood.bPutInDanger002; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted002; }
            if (tempNPC == NPC_003) { Conversation.bTempTalked = Conversation.bAlreadyTalked003; sTempWeapons = sAvailableWeapons003; /* Conversation.iSpeaker003 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins003; iTempLocation = NPC003_CurrentNumLocation; iTempLastLocation = NPC003_LastLocation; sTempLastLocation = NPC003_LastStrLocation; sTempCurrentLocation = NPC003_CurrentStrLocation; iTempDesireToMove = DesireToMove003; bTempCorpse = bCorpse003; iCloseEncounters = iClose003; Notebook.bTempNoted = Notebook.bNoted003; Notebook.iTempObserved = Notebook.iObserved003; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne003; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo003; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree003; Notebook.bNoteOne = Notebook.bNoteOne003; Notebook.bNoteTwo = Notebook.bNoteTwo003; Notebook.bNoteThree = Notebook.bNoteThree003; iTempLoyalty = iLoyalty003; bTempCorpse = bCorpse003; Flood.bPutInDanger = Flood.bPutInDanger003; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted003; }
            if (tempNPC == NPC_004) { Conversation.bTempTalked = Conversation.bAlreadyTalked004; sTempWeapons = sAvailableWeapons004; /* Conversation.iSpeaker004 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins004; iTempLocation = NPC004_CurrentNumLocation; iTempLastLocation = NPC004_LastLocation; sTempLastLocation = NPC004_LastStrLocation; sTempCurrentLocation = NPC004_CurrentStrLocation; iTempDesireToMove = DesireToMove004; bTempCorpse = bCorpse004; iCloseEncounters = iClose004; Notebook.bTempNoted = Notebook.bNoted004; Notebook.iTempObserved = Notebook.iObserved004; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne004; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo004; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree004; Notebook.bNoteOne = Notebook.bNoteOne004; Notebook.bNoteTwo = Notebook.bNoteTwo004; Notebook.bNoteThree = Notebook.bNoteThree004; iTempLoyalty = iLoyalty004; bTempCorpse = bCorpse004; Flood.bPutInDanger = Flood.bPutInDanger004; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted004; }
            if (tempNPC == NPC_005) { Conversation.bTempTalked = Conversation.bAlreadyTalked005; sTempWeapons = sAvailableWeapons005; /* Conversation.iSpeaker005 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins005; iTempLocation = NPC005_CurrentNumLocation; iTempLastLocation = NPC005_LastLocation; sTempLastLocation = NPC005_LastStrLocation; sTempCurrentLocation = NPC005_CurrentStrLocation; iTempDesireToMove = DesireToMove005; bTempCorpse = bCorpse005; iCloseEncounters = iClose005; Notebook.bTempNoted = Notebook.bNoted005; Notebook.iTempObserved = Notebook.iObserved005; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne005; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo005; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree005; Notebook.bNoteOne = Notebook.bNoteOne005; Notebook.bNoteTwo = Notebook.bNoteTwo005; Notebook.bNoteThree = Notebook.bNoteThree005; iTempLoyalty = iLoyalty005; bTempCorpse = bCorpse005; Flood.bPutInDanger = Flood.bPutInDanger005; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted005; }
            if (tempNPC == NPC_006) { Conversation.bTempTalked = Conversation.bAlreadyTalked006; sTempWeapons = sAvailableWeapons006; /* Conversation.iSpeaker006 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins006; iTempLocation = NPC006_CurrentNumLocation; iTempLastLocation = NPC006_LastLocation; sTempLastLocation = NPC006_LastStrLocation; sTempCurrentLocation = NPC006_CurrentStrLocation; iTempDesireToMove = DesireToMove006; bTempCorpse = bCorpse006; iCloseEncounters = iClose006; Notebook.bTempNoted = Notebook.bNoted006; Notebook.iTempObserved = Notebook.iObserved006; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne006; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo006; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree006; Notebook.bNoteOne = Notebook.bNoteOne006; Notebook.bNoteTwo = Notebook.bNoteTwo006; Notebook.bNoteThree = Notebook.bNoteThree006; iTempLoyalty = iLoyalty006; bTempCorpse = bCorpse006; Flood.bPutInDanger = Flood.bPutInDanger006; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted006; }
            if (tempNPC == NPC_007) { Conversation.bTempTalked = Conversation.bAlreadyTalked007; sTempWeapons = sAvailableWeapons007; /* Conversation.iSpeaker007 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins007; iTempLocation = NPC007_CurrentNumLocation; iTempLastLocation = NPC007_LastLocation; sTempLastLocation = NPC007_LastStrLocation; sTempCurrentLocation = NPC007_CurrentStrLocation; iTempDesireToMove = DesireToMove007; bTempCorpse = bCorpse007; iCloseEncounters = iClose007; Notebook.bTempNoted = Notebook.bNoted007; Notebook.iTempObserved = Notebook.iObserved007; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne007; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo007; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree007; Notebook.bNoteOne = Notebook.bNoteOne007; Notebook.bNoteTwo = Notebook.bNoteTwo007; Notebook.bNoteThree = Notebook.bNoteThree007; iTempLoyalty = iLoyalty007; bTempCorpse = bCorpse007; Flood.bPutInDanger = Flood.bPutInDanger007; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted007; }
            if (tempNPC == NPC_008) { Conversation.bTempTalked = Conversation.bAlreadyTalked008; sTempWeapons = sAvailableWeapons008; /* Conversation.iSpeaker008 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins008; iTempLocation = NPC008_CurrentNumLocation; iTempLastLocation = NPC008_LastLocation; sTempLastLocation = NPC008_LastStrLocation; sTempCurrentLocation = NPC008_CurrentStrLocation; iTempDesireToMove = DesireToMove008; bTempCorpse = bCorpse008; iCloseEncounters = iClose008; Notebook.bTempNoted = Notebook.bNoted008; Notebook.iTempObserved = Notebook.iObserved008; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne008; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo008; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree008; Notebook.bNoteOne = Notebook.bNoteOne008; Notebook.bNoteTwo = Notebook.bNoteTwo008; Notebook.bNoteThree = Notebook.bNoteThree008; iTempLoyalty = iLoyalty008; bTempCorpse = bCorpse008; Flood.bPutInDanger = Flood.bPutInDanger008; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted008; }
            if (tempNPC == NPC_009) { Conversation.bTempTalked = Conversation.bAlreadyTalked009; sTempWeapons = sAvailableWeapons009; /* Conversation.iSpeaker009 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins009; iTempLocation = NPC009_CurrentNumLocation; iTempLastLocation = NPC009_LastLocation; sTempLastLocation = NPC009_LastStrLocation; sTempCurrentLocation = NPC009_CurrentStrLocation; iTempDesireToMove = DesireToMove009; bTempCorpse = bCorpse009; iCloseEncounters = iClose009; Notebook.bTempNoted = Notebook.bNoted009; Notebook.iTempObserved = Notebook.iObserved009; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne009; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo009; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree009; Notebook.bNoteOne = Notebook.bNoteOne009; Notebook.bNoteTwo = Notebook.bNoteTwo009; Notebook.bNoteThree = Notebook.bNoteThree009; iTempLoyalty = iLoyalty009; bTempCorpse = bCorpse009; Flood.bPutInDanger = Flood.bPutInDanger009; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted009; }
            if (tempNPC == NPC_010) { Conversation.bTempTalked = Conversation.bAlreadyTalked010; sTempWeapons = sAvailableWeapons010; /* Conversation.iSpeaker010 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins010; iTempLocation = NPC010_CurrentNumLocation; iTempLastLocation = NPC010_LastLocation; sTempLastLocation = NPC010_LastStrLocation; sTempCurrentLocation = NPC010_CurrentStrLocation; iTempDesireToMove = DesireToMove010; bTempCorpse = bCorpse010; iCloseEncounters = iClose010; Notebook.bTempNoted = Notebook.bNoted010; Notebook.iTempObserved = Notebook.iObserved010; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne010; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo010; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree010; Notebook.bNoteOne = Notebook.bNoteOne010; Notebook.bNoteTwo = Notebook.bNoteTwo010; Notebook.bNoteThree = Notebook.bNoteThree010; iTempLoyalty = iLoyalty010; bTempCorpse = bCorpse010; Flood.bPutInDanger = Flood.bPutInDanger010; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted010; }
            if (tempNPC == NPC_011) { Conversation.bTempTalked = Conversation.bAlreadyTalked011; sTempWeapons = sAvailableWeapons011; /* Conversation.iSpeaker011 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins011; iTempLocation = NPC011_CurrentNumLocation; iTempLastLocation = NPC011_LastLocation; sTempLastLocation = NPC011_LastStrLocation; sTempCurrentLocation = NPC011_CurrentStrLocation; iTempDesireToMove = DesireToMove011; bTempCorpse = bCorpse011; iCloseEncounters = iClose011; Notebook.bTempNoted = Notebook.bNoted011; Notebook.iTempObserved = Notebook.iObserved011; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne011; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo011; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree011; Notebook.bNoteOne = Notebook.bNoteOne011; Notebook.bNoteTwo = Notebook.bNoteTwo011; Notebook.bNoteThree = Notebook.bNoteThree011; iTempLoyalty = iLoyalty011; bTempCorpse = bCorpse011; Flood.bPutInDanger = Flood.bPutInDanger011; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted011; }
            if (tempNPC == NPC_012) { Conversation.bTempTalked = Conversation.bAlreadyTalked012; sTempWeapons = sAvailableWeapons012; /* Conversation.iSpeaker012 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins012; iTempLocation = NPC012_CurrentNumLocation; iTempLastLocation = NPC012_LastLocation; sTempLastLocation = NPC012_LastStrLocation; sTempCurrentLocation = NPC012_CurrentStrLocation; iTempDesireToMove = DesireToMove012; bTempCorpse = bCorpse012; iCloseEncounters = iClose012; Notebook.bTempNoted = Notebook.bNoted012; Notebook.iTempObserved = Notebook.iObserved012; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne012; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo012; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree012; Notebook.bNoteOne = Notebook.bNoteOne012; Notebook.bNoteTwo = Notebook.bNoteTwo012; Notebook.bNoteThree = Notebook.bNoteThree012; iTempLoyalty = iLoyalty012; bTempCorpse = bCorpse012; Flood.bPutInDanger = Flood.bPutInDanger012; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted012; }
            if (tempNPC == NPC_013) { Conversation.bTempTalked = Conversation.bAlreadyTalked013; sTempWeapons = sAvailableWeapons013; /* Conversation.iSpeaker013 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins013; iTempLocation = NPC013_CurrentNumLocation; iTempLastLocation = NPC013_LastLocation; sTempLastLocation = NPC013_LastStrLocation; sTempCurrentLocation = NPC013_CurrentStrLocation; iTempDesireToMove = DesireToMove013; bTempCorpse = bCorpse013; iCloseEncounters = iClose013; Notebook.bTempNoted = Notebook.bNoted013; Notebook.iTempObserved = Notebook.iObserved013; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne013; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo013; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree013; Notebook.bNoteOne = Notebook.bNoteOne013; Notebook.bNoteTwo = Notebook.bNoteTwo013; Notebook.bNoteThree = Notebook.bNoteThree013; iTempLoyalty = iLoyalty013; bTempCorpse = bCorpse013; Flood.bPutInDanger = Flood.bPutInDanger013; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted013; }
            if (tempNPC == NPC_014) { Conversation.bTempTalked = Conversation.bAlreadyTalked014; sTempWeapons = sAvailableWeapons014; /* Conversation.iSpeaker014 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins014; iTempLocation = NPC014_CurrentNumLocation; iTempLastLocation = NPC014_LastLocation; sTempLastLocation = NPC014_LastStrLocation; sTempCurrentLocation = NPC014_CurrentStrLocation; iTempDesireToMove = DesireToMove014; bTempCorpse = bCorpse014; iCloseEncounters = iClose014; Notebook.bTempNoted = Notebook.bNoted014; Notebook.iTempObserved = Notebook.iObserved014; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne014; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo014; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree014; Notebook.bNoteOne = Notebook.bNoteOne014; Notebook.bNoteTwo = Notebook.bNoteTwo014; Notebook.bNoteThree = Notebook.bNoteThree014; iTempLoyalty = iLoyalty014; bTempCorpse = bCorpse014; Flood.bPutInDanger = Flood.bPutInDanger014; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted014; }
            if (tempNPC == NPC_015) { Conversation.bTempTalked = Conversation.bAlreadyTalked015; sTempWeapons = sAvailableWeapons015; /* Conversation.iSpeaker015 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins015; iTempLocation = NPC015_CurrentNumLocation; iTempLastLocation = NPC015_LastLocation; sTempLastLocation = NPC015_LastStrLocation; sTempCurrentLocation = NPC015_CurrentStrLocation; iTempDesireToMove = DesireToMove015; bTempCorpse = bCorpse015; iCloseEncounters = iClose015; Notebook.bTempNoted = Notebook.bNoted015; Notebook.iTempObserved = Notebook.iObserved015; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne015; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo015; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree015; Notebook.bNoteOne = Notebook.bNoteOne015; Notebook.bNoteTwo = Notebook.bNoteTwo015; Notebook.bNoteThree = Notebook.bNoteThree015; iTempLoyalty = iLoyalty015; bTempCorpse = bCorpse015; Flood.bPutInDanger = Flood.bPutInDanger015; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted015; }
            if (tempNPC == NPC_016) { Conversation.bTempTalked = Conversation.bAlreadyTalked016; sTempWeapons = sAvailableWeapons016; /* Conversation.iSpeaker015 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins016; iTempLocation = NPC016_CurrentNumLocation; iTempLastLocation = NPC016_LastLocation; sTempLastLocation = NPC016_LastStrLocation; sTempCurrentLocation = NPC016_CurrentStrLocation; iTempDesireToMove = DesireToMove016; bTempCorpse = bCorpse016; iCloseEncounters = iClose016; Notebook.bTempNoted = Notebook.bNoted016; Notebook.iTempObserved = Notebook.iObserved016; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne016; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo016; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree016; Notebook.bNoteOne = Notebook.bNoteOne016; Notebook.bNoteTwo = Notebook.bNoteTwo016; Notebook.bNoteThree = Notebook.bNoteThree016; iTempLoyalty = iLoyalty016; bTempCorpse = bCorpse016; Flood.bPutInDanger = Flood.bPutInDanger016; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted016; }
            if (tempNPC == NPC_017) { Conversation.bTempTalked = Conversation.bAlreadyTalked017; sTempWeapons = sAvailableWeapons017; /* Conversation.iSpeaker017 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins017; iTempLocation = NPC017_CurrentNumLocation; iTempLastLocation = NPC017_LastLocation; sTempLastLocation = NPC017_LastStrLocation; sTempCurrentLocation = NPC017_CurrentStrLocation; iTempDesireToMove = DesireToMove017; bTempCorpse = bCorpse017; iCloseEncounters = iClose017; Notebook.bTempNoted = Notebook.bNoted017; Notebook.iTempObserved = Notebook.iObserved017; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne017; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo017; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree017; Notebook.bNoteOne = Notebook.bNoteOne017; Notebook.bNoteTwo = Notebook.bNoteTwo017; Notebook.bNoteThree = Notebook.bNoteThree017; iTempLoyalty = iLoyalty017; bTempCorpse = bCorpse017; Flood.bPutInDanger = Flood.bPutInDanger017; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted017; }
            if (tempNPC == NPC_018) { Conversation.bTempTalked = Conversation.bAlreadyTalked018; sTempWeapons = sAvailableWeapons018; /* Conversation.iSpeaker018 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins018; iTempLocation = NPC018_CurrentNumLocation; iTempLastLocation = NPC018_LastLocation; sTempLastLocation = NPC018_LastStrLocation; sTempCurrentLocation = NPC018_CurrentStrLocation; iTempDesireToMove = DesireToMove018; bTempCorpse = bCorpse018; iCloseEncounters = iClose018; Notebook.bTempNoted = Notebook.bNoted018; Notebook.iTempObserved = Notebook.iObserved018; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne018; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo018; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree018; Notebook.bNoteOne = Notebook.bNoteOne018; Notebook.bNoteTwo = Notebook.bNoteTwo018; Notebook.bNoteThree = Notebook.bNoteThree018; iTempLoyalty = iLoyalty018; bTempCorpse = bCorpse018; Flood.bPutInDanger = Flood.bPutInDanger018; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted018; }
            if (tempNPC == NPC_019) { Conversation.bTempTalked = Conversation.bAlreadyTalked019; sTempWeapons = sAvailableWeapons019; /* Conversation.iSpeaker019 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins019; iTempLocation = NPC019_CurrentNumLocation; iTempLastLocation = NPC019_LastLocation; sTempLastLocation = NPC019_LastStrLocation; sTempCurrentLocation = NPC019_CurrentStrLocation; iTempDesireToMove = DesireToMove019; bTempCorpse = bCorpse019; iCloseEncounters = iClose019; Notebook.bTempNoted = Notebook.bNoted019; Notebook.iTempObserved = Notebook.iObserved019; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne019; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo019; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree019; Notebook.bNoteOne = Notebook.bNoteOne019; Notebook.bNoteTwo = Notebook.bNoteTwo019; Notebook.bNoteThree = Notebook.bNoteThree019; iTempLoyalty = iLoyalty019; bTempCorpse = bCorpse019; Flood.bPutInDanger = Flood.bPutInDanger019; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted019; }
            if (tempNPC == NPC_020) { Conversation.bTempTalked = Conversation.bAlreadyTalked020; sTempWeapons = sAvailableWeapons020; /* Conversation.iSpeaker020 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins020; iTempLocation = NPC020_CurrentNumLocation; iTempLastLocation = NPC020_LastLocation; sTempLastLocation = NPC020_LastStrLocation; sTempCurrentLocation = NPC020_CurrentStrLocation; iTempDesireToMove = DesireToMove020; bTempCorpse = bCorpse020; iCloseEncounters = iClose020; Notebook.bTempNoted = Notebook.bNoted020; Notebook.iTempObserved = Notebook.iObserved020; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne020; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo020; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree020; Notebook.bNoteOne = Notebook.bNoteOne020; Notebook.bNoteTwo = Notebook.bNoteTwo020; Notebook.bNoteThree = Notebook.bNoteThree020; iTempLoyalty = iLoyalty020; bTempCorpse = bCorpse020; Flood.bPutInDanger = Flood.bPutInDanger020; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted020; }
            if (tempNPC == NPC_021) { Conversation.bTempTalked = Conversation.bAlreadyTalked021; sTempWeapons = sAvailableWeapons021; /* Conversation.iSpeaker021 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins021; iTempLocation = NPC021_CurrentNumLocation; iTempLastLocation = NPC021_LastLocation; sTempLastLocation = NPC021_LastStrLocation; sTempCurrentLocation = NPC021_CurrentStrLocation; iTempDesireToMove = DesireToMove021; bTempCorpse = bCorpse021; iCloseEncounters = iClose021; Notebook.bTempNoted = Notebook.bNoted021; Notebook.iTempObserved = Notebook.iObserved021; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne021; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo021; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree021; Notebook.bNoteOne = Notebook.bNoteOne021; Notebook.bNoteTwo = Notebook.bNoteTwo021; Notebook.bNoteThree = Notebook.bNoteThree021; iTempLoyalty = iLoyalty021; bTempCorpse = bCorpse021; Flood.bPutInDanger = Flood.bPutInDanger021; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted021; }
            if (tempNPC == NPC_022) { Conversation.bTempTalked = Conversation.bAlreadyTalked022; sTempWeapons = sAvailableWeapons022; /* Conversation.iSpeaker022 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins022; iTempLocation = NPC022_CurrentNumLocation; iTempLastLocation = NPC022_LastLocation; sTempLastLocation = NPC022_LastStrLocation; sTempCurrentLocation = NPC022_CurrentStrLocation; iTempDesireToMove = DesireToMove022; bTempCorpse = bCorpse022; iCloseEncounters = iClose022; Notebook.bTempNoted = Notebook.bNoted022; Notebook.iTempObserved = Notebook.iObserved022; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne022; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo022; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree022; Notebook.bNoteOne = Notebook.bNoteOne022; Notebook.bNoteTwo = Notebook.bNoteTwo022; Notebook.bNoteThree = Notebook.bNoteThree022; iTempLoyalty = iLoyalty022; bTempCorpse = bCorpse022; Flood.bPutInDanger = Flood.bPutInDanger022; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted022; }
            if (tempNPC == NPC_023) { Conversation.bTempTalked = Conversation.bAlreadyTalked023; sTempWeapons = sAvailableWeapons023; /* Conversation.iSpeaker023 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins023; iTempLocation = NPC023_CurrentNumLocation; iTempLastLocation = NPC023_LastLocation; sTempLastLocation = NPC023_LastStrLocation; sTempCurrentLocation = NPC023_CurrentStrLocation; iTempDesireToMove = DesireToMove023; bTempCorpse = bCorpse023; iCloseEncounters = iClose023; Notebook.bTempNoted = Notebook.bNoted023; Notebook.iTempObserved = Notebook.iObserved023; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne023; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo023; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree023; Notebook.bNoteOne = Notebook.bNoteOne023; Notebook.bNoteTwo = Notebook.bNoteTwo023; Notebook.bNoteThree = Notebook.bNoteThree023; iTempLoyalty = iLoyalty023; bTempCorpse = bCorpse023; Flood.bPutInDanger = Flood.bPutInDanger023; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted023; }
            if (tempNPC == NPC_024) { Conversation.bTempTalked = Conversation.bAlreadyTalked024; sTempWeapons = sAvailableWeapons024; /* Conversation.iSpeaker024 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins024; iTempLocation = NPC024_CurrentNumLocation; iTempLastLocation = NPC024_LastLocation; sTempLastLocation = NPC024_LastStrLocation; sTempCurrentLocation = NPC024_CurrentStrLocation; iTempDesireToMove = DesireToMove024; bTempCorpse = bCorpse024; iCloseEncounters = iClose024; Notebook.bTempNoted = Notebook.bNoted024; Notebook.iTempObserved = Notebook.iObserved024; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne024; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo024; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree024; Notebook.bNoteOne = Notebook.bNoteOne024; Notebook.bNoteTwo = Notebook.bNoteTwo024; Notebook.bNoteThree = Notebook.bNoteThree024; iTempLoyalty = iLoyalty024; bTempCorpse = bCorpse024; Flood.bPutInDanger = Flood.bPutInDanger024; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted024; }
            if (tempNPC == NPC_025) { Conversation.bTempTalked = Conversation.bAlreadyTalked025; sTempWeapons = sAvailableWeapons025; /* Conversation.iSpeaker025 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins025; iTempLocation = NPC025_CurrentNumLocation; iTempLastLocation = NPC025_LastLocation; sTempLastLocation = NPC025_LastStrLocation; sTempCurrentLocation = NPC025_CurrentStrLocation; iTempDesireToMove = DesireToMove025; bTempCorpse = bCorpse025; iCloseEncounters = iClose025; Notebook.bTempNoted = Notebook.bNoted025; Notebook.iTempObserved = Notebook.iObserved025; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne025; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo025; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree025; Notebook.bNoteOne = Notebook.bNoteOne025; Notebook.bNoteTwo = Notebook.bNoteTwo025; Notebook.bNoteThree = Notebook.bNoteThree025; iTempLoyalty = iLoyalty025; bTempCorpse = bCorpse025; Flood.bPutInDanger = Flood.bPutInDanger025; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted025; }
            if (tempNPC == NPC_026) { Conversation.bTempTalked = Conversation.bAlreadyTalked026; sTempWeapons = sAvailableWeapons026; /* Conversation.iSpeaker026 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins026; iTempLocation = NPC026_CurrentNumLocation; iTempLastLocation = NPC026_LastLocation; sTempLastLocation = NPC026_LastStrLocation; sTempCurrentLocation = NPC026_CurrentStrLocation; iTempDesireToMove = DesireToMove026; bTempCorpse = bCorpse026; iCloseEncounters = iClose026; Notebook.bTempNoted = Notebook.bNoted026; Notebook.iTempObserved = Notebook.iObserved026; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne026; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo026; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree026; Notebook.bNoteOne = Notebook.bNoteOne026; Notebook.bNoteTwo = Notebook.bNoteTwo026; Notebook.bNoteThree = Notebook.bNoteThree026; iTempLoyalty = iLoyalty026; bTempCorpse = bCorpse026; Flood.bPutInDanger = Flood.bPutInDanger026; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted026; }
            if (tempNPC == NPC_027) { Conversation.bTempTalked = Conversation.bAlreadyTalked027; sTempWeapons = sAvailableWeapons027; /* Conversation.iSpeaker027 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins027; iTempLocation = NPC027_CurrentNumLocation; iTempLastLocation = NPC027_LastLocation; sTempLastLocation = NPC027_LastStrLocation; sTempCurrentLocation = NPC027_CurrentStrLocation; iTempDesireToMove = DesireToMove027; bTempCorpse = bCorpse027; iCloseEncounters = iClose027; Notebook.bTempNoted = Notebook.bNoted027; Notebook.iTempObserved = Notebook.iObserved027; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne027; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo027; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree027; Notebook.bNoteOne = Notebook.bNoteOne027; Notebook.bNoteTwo = Notebook.bNoteTwo027; Notebook.bNoteThree = Notebook.bNoteThree027; iTempLoyalty = iLoyalty027; bTempCorpse = bCorpse027; Flood.bPutInDanger = Flood.bPutInDanger027; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted027; }
            if (tempNPC == NPC_028) { Conversation.bTempTalked = Conversation.bAlreadyTalked028; sTempWeapons = sAvailableWeapons028; /* Conversation.iSpeaker028 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins028; iTempLocation = NPC028_CurrentNumLocation; iTempLastLocation = NPC028_LastLocation; sTempLastLocation = NPC028_LastStrLocation; sTempCurrentLocation = NPC028_CurrentStrLocation; iTempDesireToMove = DesireToMove028; bTempCorpse = bCorpse028; iCloseEncounters = iClose028; Notebook.bTempNoted = Notebook.bNoted028; Notebook.iTempObserved = Notebook.iObserved028; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne028; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo028; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree028; Notebook.bNoteOne = Notebook.bNoteOne028; Notebook.bNoteTwo = Notebook.bNoteTwo028; Notebook.bNoteThree = Notebook.bNoteThree028; iTempLoyalty = iLoyalty028; bTempCorpse = bCorpse028; Flood.bPutInDanger = Flood.bPutInDanger028; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted028; }
            if (tempNPC == NPC_029) { Conversation.bTempTalked = Conversation.bAlreadyTalked029; sTempWeapons = sAvailableWeapons029; /* Conversation.iSpeaker029 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins029; iTempLocation = NPC029_CurrentNumLocation; iTempLastLocation = NPC029_LastLocation; sTempLastLocation = NPC029_LastStrLocation; sTempCurrentLocation = NPC029_CurrentStrLocation; iTempDesireToMove = DesireToMove029; bTempCorpse = bCorpse029; iCloseEncounters = iClose029; Notebook.bTempNoted = Notebook.bNoted029; Notebook.iTempObserved = Notebook.iObserved029; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne029; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo029; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree029; Notebook.bNoteOne = Notebook.bNoteOne029; Notebook.bNoteTwo = Notebook.bNoteTwo029; Notebook.bNoteThree = Notebook.bNoteThree029; iTempLoyalty = iLoyalty029; bTempCorpse = bCorpse029; Flood.bPutInDanger = Flood.bPutInDanger029; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted029; }
            if (tempNPC == NPC_030) { Conversation.bTempTalked = Conversation.bAlreadyTalked030; sTempWeapons = sAvailableWeapons030; /* Conversation.iSpeaker030 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins030; iTempLocation = NPC030_CurrentNumLocation; iTempLastLocation = NPC030_LastLocation; sTempLastLocation = NPC030_LastStrLocation; sTempCurrentLocation = NPC030_CurrentStrLocation; iTempDesireToMove = DesireToMove030; bTempCorpse = bCorpse030; iCloseEncounters = iClose030; Notebook.bTempNoted = Notebook.bNoted030; Notebook.iTempObserved = Notebook.iObserved030; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne030; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo030; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree030; Notebook.bNoteOne = Notebook.bNoteOne030; Notebook.bNoteTwo = Notebook.bNoteTwo030; Notebook.bNoteThree = Notebook.bNoteThree030; iTempLoyalty = iLoyalty030; bTempCorpse = bCorpse030; Flood.bPutInDanger = Flood.bPutInDanger030; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted030; }
            if (tempNPC == NPC_031) { Conversation.bTempTalked = Conversation.bAlreadyTalked031; sTempWeapons = sAvailableWeapons031; /* Conversation.iSpeaker031 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins031; iTempLocation = NPC031_CurrentNumLocation; iTempLastLocation = NPC031_LastLocation; sTempLastLocation = NPC031_LastStrLocation; sTempCurrentLocation = NPC031_CurrentStrLocation; iTempDesireToMove = DesireToMove031; bTempCorpse = bCorpse031; iCloseEncounters = iClose031; Notebook.bTempNoted = Notebook.bNoted031; Notebook.iTempObserved = Notebook.iObserved031; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne031; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo031; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree031; Notebook.bNoteOne = Notebook.bNoteOne031; Notebook.bNoteTwo = Notebook.bNoteTwo031; Notebook.bNoteThree = Notebook.bNoteThree031; iTempLoyalty = iLoyalty031; bTempCorpse = bCorpse031; Flood.bPutInDanger = Flood.bPutInDanger031; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted031; }
            if (tempNPC == NPC_032) { Conversation.bTempTalked = Conversation.bAlreadyTalked032; sTempWeapons = sAvailableWeapons032; /* Conversation.iSpeaker032 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins032; iTempLocation = NPC032_CurrentNumLocation; iTempLastLocation = NPC032_LastLocation; sTempLastLocation = NPC032_LastStrLocation; sTempCurrentLocation = NPC032_CurrentStrLocation; iTempDesireToMove = DesireToMove032; bTempCorpse = bCorpse032; iCloseEncounters = iClose032; Notebook.bTempNoted = Notebook.bNoted032; Notebook.iTempObserved = Notebook.iObserved032; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne032; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo032; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree032; Notebook.bNoteOne = Notebook.bNoteOne032; Notebook.bNoteTwo = Notebook.bNoteTwo032; Notebook.bNoteThree = Notebook.bNoteThree032; iTempLoyalty = iLoyalty032; bTempCorpse = bCorpse032; Flood.bPutInDanger = Flood.bPutInDanger032; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted032; }
            if (tempNPC == NPC_033) { Conversation.bTempTalked = Conversation.bAlreadyTalked033; sTempWeapons = sAvailableWeapons033; /* Conversation.iSpeaker033 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins033; iTempLocation = NPC033_CurrentNumLocation; iTempLastLocation = NPC033_LastLocation; sTempLastLocation = NPC033_LastStrLocation; sTempCurrentLocation = NPC033_CurrentStrLocation; iTempDesireToMove = DesireToMove033; bTempCorpse = bCorpse033; iCloseEncounters = iClose033; Notebook.bTempNoted = Notebook.bNoted033; Notebook.iTempObserved = Notebook.iObserved033; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne033; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo033; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree033; Notebook.bNoteOne = Notebook.bNoteOne033; Notebook.bNoteTwo = Notebook.bNoteTwo033; Notebook.bNoteThree = Notebook.bNoteThree033; iTempLoyalty = iLoyalty033; bTempCorpse = bCorpse033; Flood.bPutInDanger = Flood.bPutInDanger033; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted033; }
            if (tempNPC == NPC_034) { Conversation.bTempTalked = Conversation.bAlreadyTalked034; sTempWeapons = sAvailableWeapons034; /* Conversation.iSpeaker034 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins034; iTempLocation = NPC034_CurrentNumLocation; iTempLastLocation = NPC034_LastLocation; sTempLastLocation = NPC034_LastStrLocation; sTempCurrentLocation = NPC034_CurrentStrLocation; iTempDesireToMove = DesireToMove034; bTempCorpse = bCorpse034; iCloseEncounters = iClose034; Notebook.bTempNoted = Notebook.bNoted034; Notebook.iTempObserved = Notebook.iObserved034; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne034; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo034; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree034; Notebook.bNoteOne = Notebook.bNoteOne034; Notebook.bNoteTwo = Notebook.bNoteTwo034; Notebook.bNoteThree = Notebook.bNoteThree034; iTempLoyalty = iLoyalty034; bTempCorpse = bCorpse034; Flood.bPutInDanger = Flood.bPutInDanger034; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted034; }
            if (tempNPC == NPC_035) { Conversation.bTempTalked = Conversation.bAlreadyTalked035; sTempWeapons = sAvailableWeapons035; /* Conversation.iSpeaker035 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins035; iTempLocation = NPC035_CurrentNumLocation; iTempLastLocation = NPC035_LastLocation; sTempLastLocation = NPC035_LastStrLocation; sTempCurrentLocation = NPC035_CurrentStrLocation; iTempDesireToMove = DesireToMove035; bTempCorpse = bCorpse035; iCloseEncounters = iClose035; Notebook.bTempNoted = Notebook.bNoted035; Notebook.iTempObserved = Notebook.iObserved035; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne035; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo035; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree035; Notebook.bNoteOne = Notebook.bNoteOne035; Notebook.bNoteTwo = Notebook.bNoteTwo035; Notebook.bNoteThree = Notebook.bNoteThree035; iTempLoyalty = iLoyalty035; bTempCorpse = bCorpse035; Flood.bPutInDanger = Flood.bPutInDanger035; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted035; }
            if (tempNPC == NPC_036) { Conversation.bTempTalked = Conversation.bAlreadyTalked036; sTempWeapons = sAvailableWeapons036; /* Conversation.iSpeaker036 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins036; iTempLocation = NPC036_CurrentNumLocation; iTempLastLocation = NPC036_LastLocation; sTempLastLocation = NPC036_LastStrLocation; sTempCurrentLocation = NPC036_CurrentStrLocation; iTempDesireToMove = DesireToMove036; bTempCorpse = bCorpse036; iCloseEncounters = iClose036; Notebook.bTempNoted = Notebook.bNoted036; Notebook.iTempObserved = Notebook.iObserved036; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne036; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo036; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree036; Notebook.bNoteOne = Notebook.bNoteOne036; Notebook.bNoteTwo = Notebook.bNoteTwo036; Notebook.bNoteThree = Notebook.bNoteThree036; iTempLoyalty = iLoyalty036; bTempCorpse = bCorpse036; Flood.bPutInDanger = Flood.bPutInDanger036; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted036; }
            if (tempNPC == NPC_037) { Conversation.bTempTalked = Conversation.bAlreadyTalked037; sTempWeapons = sAvailableWeapons037; /* Conversation.iSpeaker037 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins037; iTempLocation = NPC037_CurrentNumLocation; iTempLastLocation = NPC037_LastLocation; sTempLastLocation = NPC037_LastStrLocation; sTempCurrentLocation = NPC037_CurrentStrLocation; iTempDesireToMove = DesireToMove037; bTempCorpse = bCorpse037; iCloseEncounters = iClose037; Notebook.bTempNoted = Notebook.bNoted037; Notebook.iTempObserved = Notebook.iObserved037; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne037; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo037; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree037; Notebook.bNoteOne = Notebook.bNoteOne037; Notebook.bNoteTwo = Notebook.bNoteTwo037; Notebook.bNoteThree = Notebook.bNoteThree037; iTempLoyalty = iLoyalty037; bTempCorpse = bCorpse037; Flood.bPutInDanger = Flood.bPutInDanger037; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted037; }
            if (tempNPC == NPC_038) { Conversation.bTempTalked = Conversation.bAlreadyTalked038; sTempWeapons = sAvailableWeapons038; /* Conversation.iSpeaker038 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins038; iTempLocation = NPC038_CurrentNumLocation; iTempLastLocation = NPC038_LastLocation; sTempLastLocation = NPC038_LastStrLocation; sTempCurrentLocation = NPC038_CurrentStrLocation; iTempDesireToMove = DesireToMove038; bTempCorpse = bCorpse038; iCloseEncounters = iClose038; Notebook.bTempNoted = Notebook.bNoted038; Notebook.iTempObserved = Notebook.iObserved038; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne038; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo038; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree038; Notebook.bNoteOne = Notebook.bNoteOne038; Notebook.bNoteTwo = Notebook.bNoteTwo038; Notebook.bNoteThree = Notebook.bNoteThree038; iTempLoyalty = iLoyalty038; bTempCorpse = bCorpse038; Flood.bPutInDanger = Flood.bPutInDanger038; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted038; }
            if (tempNPC == NPC_039) { Conversation.bTempTalked = Conversation.bAlreadyTalked039; sTempWeapons = sAvailableWeapons039; /* Conversation.iSpeaker039 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins039; iTempLocation = NPC039_CurrentNumLocation; iTempLastLocation = NPC039_LastLocation; sTempLastLocation = NPC039_LastStrLocation; sTempCurrentLocation = NPC039_CurrentStrLocation; iTempDesireToMove = DesireToMove039; bTempCorpse = bCorpse039; iCloseEncounters = iClose039; Notebook.bTempNoted = Notebook.bNoted039; Notebook.iTempObserved = Notebook.iObserved039; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne039; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo039; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree039; Notebook.bNoteOne = Notebook.bNoteOne039; Notebook.bNoteTwo = Notebook.bNoteTwo039; Notebook.bNoteThree = Notebook.bNoteThree039; iTempLoyalty = iLoyalty039; bTempCorpse = bCorpse039; Flood.bPutInDanger = Flood.bPutInDanger039; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted039; }
            if (tempNPC == NPC_040) { Conversation.bTempTalked = Conversation.bAlreadyTalked040; sTempWeapons = sAvailableWeapons040; /* Conversation.iSpeaker040 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins040; iTempLocation = NPC040_CurrentNumLocation; iTempLastLocation = NPC040_LastLocation; sTempLastLocation = NPC040_LastStrLocation; sTempCurrentLocation = NPC040_CurrentStrLocation; iTempDesireToMove = DesireToMove040; bTempCorpse = bCorpse040; iCloseEncounters = iClose040; Notebook.bTempNoted = Notebook.bNoted040; Notebook.iTempObserved = Notebook.iObserved040; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne040; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo040; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree040; Notebook.bNoteOne = Notebook.bNoteOne040; Notebook.bNoteTwo = Notebook.bNoteTwo040; Notebook.bNoteThree = Notebook.bNoteThree040; iTempLoyalty = iLoyalty040; bTempCorpse = bCorpse040; Flood.bPutInDanger = Flood.bPutInDanger040; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted040; }
            if (tempNPC == NPC_041) { Conversation.bTempTalked = Conversation.bAlreadyTalked041; sTempWeapons = sAvailableWeapons041; /* Conversation.iSpeaker041 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins041; iTempLocation = NPC041_CurrentNumLocation; iTempLastLocation = NPC041_LastLocation; sTempLastLocation = NPC041_LastStrLocation; sTempCurrentLocation = NPC041_CurrentStrLocation; iTempDesireToMove = DesireToMove041; bTempCorpse = bCorpse041; iCloseEncounters = iClose041; Notebook.bTempNoted = Notebook.bNoted041; Notebook.iTempObserved = Notebook.iObserved041; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne041; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo041; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree041; Notebook.bNoteOne = Notebook.bNoteOne041; Notebook.bNoteTwo = Notebook.bNoteTwo041; Notebook.bNoteThree = Notebook.bNoteThree041; iTempLoyalty = iLoyalty041; bTempCorpse = bCorpse041; Flood.bPutInDanger = Flood.bPutInDanger041; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted041; }
            if (tempNPC == NPC_042) { Conversation.bTempTalked = Conversation.bAlreadyTalked042; sTempWeapons = sAvailableWeapons042; /* Conversation.iSpeaker042 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins042; iTempLocation = NPC042_CurrentNumLocation; iTempLastLocation = NPC042_LastLocation; sTempLastLocation = NPC042_LastStrLocation; sTempCurrentLocation = NPC042_CurrentStrLocation; iTempDesireToMove = DesireToMove042; bTempCorpse = bCorpse042; iCloseEncounters = iClose042; Notebook.bTempNoted = Notebook.bNoted042; Notebook.iTempObserved = Notebook.iObserved042; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne042; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo042; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree042; Notebook.bNoteOne = Notebook.bNoteOne042; Notebook.bNoteTwo = Notebook.bNoteTwo042; Notebook.bNoteThree = Notebook.bNoteThree042; iTempLoyalty = iLoyalty042; bTempCorpse = bCorpse042; Flood.bPutInDanger = Flood.bPutInDanger042; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted042; }
            if (tempNPC == NPC_043) { Conversation.bTempTalked = Conversation.bAlreadyTalked043; sTempWeapons = sAvailableWeapons043; /* Conversation.iSpeaker043 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins043; iTempLocation = NPC043_CurrentNumLocation; iTempLastLocation = NPC043_LastLocation; sTempLastLocation = NPC043_LastStrLocation; sTempCurrentLocation = NPC043_CurrentStrLocation; iTempDesireToMove = DesireToMove043; bTempCorpse = bCorpse043; iCloseEncounters = iClose043; Notebook.bTempNoted = Notebook.bNoted043; Notebook.iTempObserved = Notebook.iObserved043; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne043; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo043; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree043; Notebook.bNoteOne = Notebook.bNoteOne043; Notebook.bNoteTwo = Notebook.bNoteTwo043; Notebook.bNoteThree = Notebook.bNoteThree043; iTempLoyalty = iLoyalty043; bTempCorpse = bCorpse043; Flood.bPutInDanger = Flood.bPutInDanger043; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted043; }
            if (tempNPC == NPC_044) { Conversation.bTempTalked = Conversation.bAlreadyTalked044; sTempWeapons = sAvailableWeapons044; /* Conversation.iSpeaker044 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins044; iTempLocation = NPC044_CurrentNumLocation; iTempLastLocation = NPC044_LastLocation; sTempLastLocation = NPC044_LastStrLocation; sTempCurrentLocation = NPC044_CurrentStrLocation; iTempDesireToMove = DesireToMove044; bTempCorpse = bCorpse044; iCloseEncounters = iClose044; Notebook.bTempNoted = Notebook.bNoted044; Notebook.iTempObserved = Notebook.iObserved044; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne044; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo044; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree044; Notebook.bNoteOne = Notebook.bNoteOne044; Notebook.bNoteTwo = Notebook.bNoteTwo044; Notebook.bNoteThree = Notebook.bNoteThree044; iTempLoyalty = iLoyalty044; bTempCorpse = bCorpse044; Flood.bPutInDanger = Flood.bPutInDanger044; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted044; }
            if (tempNPC == NPC_045) { Conversation.bTempTalked = Conversation.bAlreadyTalked045; sTempWeapons = sAvailableWeapons045; /* Conversation.iSpeaker045 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins045; iTempLocation = NPC045_CurrentNumLocation; iTempLastLocation = NPC045_LastLocation; sTempLastLocation = NPC045_LastStrLocation; sTempCurrentLocation = NPC045_CurrentStrLocation; iTempDesireToMove = DesireToMove045; bTempCorpse = bCorpse045; iCloseEncounters = iClose045; Notebook.bTempNoted = Notebook.bNoted045; Notebook.iTempObserved = Notebook.iObserved045; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne045; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo045; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree045; Notebook.bNoteOne = Notebook.bNoteOne045; Notebook.bNoteTwo = Notebook.bNoteTwo045; Notebook.bNoteThree = Notebook.bNoteThree045; iTempLoyalty = iLoyalty045; bTempCorpse = bCorpse045; Flood.bPutInDanger = Flood.bPutInDanger045; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted045; }
            if (tempNPC == NPC_046) { Conversation.bTempTalked = Conversation.bAlreadyTalked046; sTempWeapons = sAvailableWeapons046; /* Conversation.iSpeaker046 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins046; iTempLocation = NPC046_CurrentNumLocation; iTempLastLocation = NPC046_LastLocation; sTempLastLocation = NPC046_LastStrLocation; sTempCurrentLocation = NPC046_CurrentStrLocation; iTempDesireToMove = DesireToMove046; bTempCorpse = bCorpse046; iCloseEncounters = iClose046; Notebook.bTempNoted = Notebook.bNoted046; Notebook.iTempObserved = Notebook.iObserved046; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne046; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo046; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree046; Notebook.bNoteOne = Notebook.bNoteOne046; Notebook.bNoteTwo = Notebook.bNoteTwo046; Notebook.bNoteThree = Notebook.bNoteThree046; iTempLoyalty = iLoyalty046; bTempCorpse = bCorpse046; Flood.bPutInDanger = Flood.bPutInDanger046; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted046; }
            if (tempNPC == NPC_047) { Conversation.bTempTalked = Conversation.bAlreadyTalked047; sTempWeapons = sAvailableWeapons047; /* Conversation.iSpeaker047 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins047; iTempLocation = NPC047_CurrentNumLocation; iTempLastLocation = NPC047_LastLocation; sTempLastLocation = NPC047_LastStrLocation; sTempCurrentLocation = NPC047_CurrentStrLocation; iTempDesireToMove = DesireToMove047; bTempCorpse = bCorpse047; iCloseEncounters = iClose047; Notebook.bTempNoted = Notebook.bNoted047; Notebook.iTempObserved = Notebook.iObserved047; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne047; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo047; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree047; Notebook.bNoteOne = Notebook.bNoteOne047; Notebook.bNoteTwo = Notebook.bNoteTwo047; Notebook.bNoteThree = Notebook.bNoteThree047; iTempLoyalty = iLoyalty047; bTempCorpse = bCorpse047; Flood.bPutInDanger = Flood.bPutInDanger047; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted047; }
            if (tempNPC == NPC_048) { Conversation.bTempTalked = Conversation.bAlreadyTalked048; sTempWeapons = sAvailableWeapons048; /* Conversation.iSpeaker048 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins048; iTempLocation = NPC048_CurrentNumLocation; iTempLastLocation = NPC048_LastLocation; sTempLastLocation = NPC048_LastStrLocation; sTempCurrentLocation = NPC048_CurrentStrLocation; iTempDesireToMove = DesireToMove048; bTempCorpse = bCorpse048; iCloseEncounters = iClose048; Notebook.bTempNoted = Notebook.bNoted048; Notebook.iTempObserved = Notebook.iObserved048; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne048; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo048; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree048; Notebook.bNoteOne = Notebook.bNoteOne048; Notebook.bNoteTwo = Notebook.bNoteTwo048; Notebook.bNoteThree = Notebook.bNoteThree048; iTempLoyalty = iLoyalty048; bTempCorpse = bCorpse048; Flood.bPutInDanger = Flood.bPutInDanger048; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted048; }
            if (tempNPC == NPC_049) { Conversation.bTempTalked = Conversation.bAlreadyTalked049; sTempWeapons = sAvailableWeapons049; /* Conversation.iSpeaker049 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins049; iTempLocation = NPC049_CurrentNumLocation; iTempLastLocation = NPC049_LastLocation; sTempLastLocation = NPC049_LastStrLocation; sTempCurrentLocation = NPC049_CurrentStrLocation; iTempDesireToMove = DesireToMove049; bTempCorpse = bCorpse049; iCloseEncounters = iClose049; Notebook.bTempNoted = Notebook.bNoted049; Notebook.iTempObserved = Notebook.iObserved049; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne049; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo049; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree049; Notebook.bNoteOne = Notebook.bNoteOne049; Notebook.bNoteTwo = Notebook.bNoteTwo049; Notebook.bNoteThree = Notebook.bNoteThree049; iTempLoyalty = iLoyalty049; bTempCorpse = bCorpse049; Flood.bPutInDanger = Flood.bPutInDanger049; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted049; }
            if (tempNPC == NPC_050) { Conversation.bTempTalked = Conversation.bAlreadyTalked050; sTempWeapons = sAvailableWeapons050; /* Conversation.iSpeaker050 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins050; iTempLocation = NPC050_CurrentNumLocation; iTempLastLocation = NPC050_LastLocation; sTempLastLocation = NPC050_LastStrLocation; sTempCurrentLocation = NPC050_CurrentStrLocation; iTempDesireToMove = DesireToMove050; bTempCorpse = bCorpse050; iCloseEncounters = iClose050; Notebook.bTempNoted = Notebook.bNoted050; Notebook.iTempObserved = Notebook.iObserved050; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne050; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo050; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree050; Notebook.bNoteOne = Notebook.bNoteOne050; Notebook.bNoteTwo = Notebook.bNoteTwo050; Notebook.bNoteThree = Notebook.bNoteThree050; iTempLoyalty = iLoyalty050; bTempCorpse = bCorpse050; Flood.bPutInDanger = Flood.bPutInDanger050; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted050; }
            if (tempNPC == NPC_051) { Conversation.bTempTalked = Conversation.bAlreadyTalked051; sTempWeapons = sAvailableWeapons051; /* Conversation.iSpeaker051 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins051; iTempLocation = NPC051_CurrentNumLocation; iTempLastLocation = NPC051_LastLocation; sTempLastLocation = NPC051_LastStrLocation; sTempCurrentLocation = NPC051_CurrentStrLocation; iTempDesireToMove = DesireToMove051; bTempCorpse = bCorpse051; iCloseEncounters = iClose051; Notebook.bTempNoted = Notebook.bNoted051; Notebook.iTempObserved = Notebook.iObserved051; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne051; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo051; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree051; Notebook.bNoteOne = Notebook.bNoteOne051; Notebook.bNoteTwo = Notebook.bNoteTwo051; Notebook.bNoteThree = Notebook.bNoteThree051; iTempLoyalty = iLoyalty051; bTempCorpse = bCorpse051; Flood.bPutInDanger = Flood.bPutInDanger051; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted051; }
            if (tempNPC == NPC_052) { Conversation.bTempTalked = Conversation.bAlreadyTalked052; sTempWeapons = sAvailableWeapons052; /* Conversation.iSpeaker052 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins052; iTempLocation = NPC052_CurrentNumLocation; iTempLastLocation = NPC052_LastLocation; sTempLastLocation = NPC052_LastStrLocation; sTempCurrentLocation = NPC052_CurrentStrLocation; iTempDesireToMove = DesireToMove052; bTempCorpse = bCorpse052; iCloseEncounters = iClose052; Notebook.bTempNoted = Notebook.bNoted052; Notebook.iTempObserved = Notebook.iObserved052; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne052; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo052; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree052; Notebook.bNoteOne = Notebook.bNoteOne052; Notebook.bNoteTwo = Notebook.bNoteTwo052; Notebook.bNoteThree = Notebook.bNoteThree052; iTempLoyalty = iLoyalty052; bTempCorpse = bCorpse052; Flood.bPutInDanger = Flood.bPutInDanger052; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted052; }
            if (tempNPC == NPC_053) { Conversation.bTempTalked = Conversation.bAlreadyTalked053; sTempWeapons = sAvailableWeapons053; /* Conversation.iSpeaker053 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins053; iTempLocation = NPC053_CurrentNumLocation; iTempLastLocation = NPC053_LastLocation; sTempLastLocation = NPC053_LastStrLocation; sTempCurrentLocation = NPC053_CurrentStrLocation; iTempDesireToMove = DesireToMove053; bTempCorpse = bCorpse053; iCloseEncounters = iClose053; Notebook.bTempNoted = Notebook.bNoted053; Notebook.iTempObserved = Notebook.iObserved053; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne053; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo053; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree053; Notebook.bNoteOne = Notebook.bNoteOne053; Notebook.bNoteTwo = Notebook.bNoteTwo053; Notebook.bNoteThree = Notebook.bNoteThree053; iTempLoyalty = iLoyalty053; bTempCorpse = bCorpse053; Flood.bPutInDanger = Flood.bPutInDanger053; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted053; }
            if (tempNPC == NPC_054) { Conversation.bTempTalked = Conversation.bAlreadyTalked054; sTempWeapons = sAvailableWeapons054; /* Conversation.iSpeaker054 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins054; iTempLocation = NPC054_CurrentNumLocation; iTempLastLocation = NPC054_LastLocation; sTempLastLocation = NPC054_LastStrLocation; sTempCurrentLocation = NPC054_CurrentStrLocation; iTempDesireToMove = DesireToMove054; bTempCorpse = bCorpse054; iCloseEncounters = iClose054; Notebook.bTempNoted = Notebook.bNoted054; Notebook.iTempObserved = Notebook.iObserved054; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne054; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo054; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree054; Notebook.bNoteOne = Notebook.bNoteOne054; Notebook.bNoteTwo = Notebook.bNoteTwo054; Notebook.bNoteThree = Notebook.bNoteThree054; iTempLoyalty = iLoyalty054; bTempCorpse = bCorpse054; Flood.bPutInDanger = Flood.bPutInDanger054; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted054; }
            if (tempNPC == NPC_055) { Conversation.bTempTalked = Conversation.bAlreadyTalked055; sTempWeapons = sAvailableWeapons055; /* Conversation.iSpeaker055 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins055; iTempLocation = NPC055_CurrentNumLocation; iTempLastLocation = NPC055_LastLocation; sTempLastLocation = NPC055_LastStrLocation; sTempCurrentLocation = NPC055_CurrentStrLocation; iTempDesireToMove = DesireToMove055; bTempCorpse = bCorpse055; iCloseEncounters = iClose055; Notebook.bTempNoted = Notebook.bNoted055; Notebook.iTempObserved = Notebook.iObserved055; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne055; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo055; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree055; Notebook.bNoteOne = Notebook.bNoteOne055; Notebook.bNoteTwo = Notebook.bNoteTwo055; Notebook.bNoteThree = Notebook.bNoteThree055; iTempLoyalty = iLoyalty055; bTempCorpse = bCorpse055; Flood.bPutInDanger = Flood.bPutInDanger055; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted055; }
            if (tempNPC == NPC_056) { Conversation.bTempTalked = Conversation.bAlreadyTalked056; sTempWeapons = sAvailableWeapons056; /* Conversation.iSpeaker056 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins056; iTempLocation = NPC056_CurrentNumLocation; iTempLastLocation = NPC056_LastLocation; sTempLastLocation = NPC056_LastStrLocation; sTempCurrentLocation = NPC056_CurrentStrLocation; iTempDesireToMove = DesireToMove056; bTempCorpse = bCorpse056; iCloseEncounters = iClose056; Notebook.bTempNoted = Notebook.bNoted056; Notebook.iTempObserved = Notebook.iObserved056; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne056; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo056; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree056; Notebook.bNoteOne = Notebook.bNoteOne056; Notebook.bNoteTwo = Notebook.bNoteTwo056; Notebook.bNoteThree = Notebook.bNoteThree056; iTempLoyalty = iLoyalty056; bTempCorpse = bCorpse056; Flood.bPutInDanger = Flood.bPutInDanger056; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted056; }
            if (tempNPC == NPC_057) { Conversation.bTempTalked = Conversation.bAlreadyTalked057; sTempWeapons = sAvailableWeapons057; /* Conversation.iSpeaker057 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins057; iTempLocation = NPC057_CurrentNumLocation; iTempLastLocation = NPC057_LastLocation; sTempLastLocation = NPC057_LastStrLocation; sTempCurrentLocation = NPC057_CurrentStrLocation; iTempDesireToMove = DesireToMove057; bTempCorpse = bCorpse057; iCloseEncounters = iClose057; Notebook.bTempNoted = Notebook.bNoted057; Notebook.iTempObserved = Notebook.iObserved057; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne057; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo057; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree057; Notebook.bNoteOne = Notebook.bNoteOne057; Notebook.bNoteTwo = Notebook.bNoteTwo057; Notebook.bNoteThree = Notebook.bNoteThree057; iTempLoyalty = iLoyalty057; bTempCorpse = bCorpse057; Flood.bPutInDanger = Flood.bPutInDanger057; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted057; }
            if (tempNPC == NPC_058) { Conversation.bTempTalked = Conversation.bAlreadyTalked058; sTempWeapons = sAvailableWeapons058; /* Conversation.iSpeaker058 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins058; iTempLocation = NPC058_CurrentNumLocation; iTempLastLocation = NPC058_LastLocation; sTempLastLocation = NPC058_LastStrLocation; sTempCurrentLocation = NPC058_CurrentStrLocation; iTempDesireToMove = DesireToMove058; bTempCorpse = bCorpse058; iCloseEncounters = iClose058; Notebook.bTempNoted = Notebook.bNoted058; Notebook.iTempObserved = Notebook.iObserved058; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne058; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo058; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree058; Notebook.bNoteOne = Notebook.bNoteOne058; Notebook.bNoteTwo = Notebook.bNoteTwo058; Notebook.bNoteThree = Notebook.bNoteThree058; iTempLoyalty = iLoyalty058; bTempCorpse = bCorpse058; Flood.bPutInDanger = Flood.bPutInDanger058; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted058; }
            if (tempNPC == NPC_059) { Conversation.bTempTalked = Conversation.bAlreadyTalked059; sTempWeapons = sAvailableWeapons059; /* Conversation.iSpeaker059 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins059; iTempLocation = NPC059_CurrentNumLocation; iTempLastLocation = NPC059_LastLocation; sTempLastLocation = NPC059_LastStrLocation; sTempCurrentLocation = NPC059_CurrentStrLocation; iTempDesireToMove = DesireToMove059; bTempCorpse = bCorpse059; iCloseEncounters = iClose059; Notebook.bTempNoted = Notebook.bNoted059; Notebook.iTempObserved = Notebook.iObserved059; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne059; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo059; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree059; Notebook.bNoteOne = Notebook.bNoteOne059; Notebook.bNoteTwo = Notebook.bNoteTwo059; Notebook.bNoteThree = Notebook.bNoteThree059; iTempLoyalty = iLoyalty059; bTempCorpse = bCorpse059; Flood.bPutInDanger = Flood.bPutInDanger059; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted059; }
            if (tempNPC == NPC_060) { Conversation.bTempTalked = Conversation.bAlreadyTalked060; sTempWeapons = sAvailableWeapons060; /* Conversation.iSpeaker060 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins060; iTempLocation = NPC060_CurrentNumLocation; iTempLastLocation = NPC060_LastLocation; sTempLastLocation = NPC060_LastStrLocation; sTempCurrentLocation = NPC060_CurrentStrLocation; iTempDesireToMove = DesireToMove060; bTempCorpse = bCorpse060; iCloseEncounters = iClose060; Notebook.bTempNoted = Notebook.bNoted060; Notebook.iTempObserved = Notebook.iObserved060; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne060; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo060; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree060; Notebook.bNoteOne = Notebook.bNoteOne060; Notebook.bNoteTwo = Notebook.bNoteTwo060; Notebook.bNoteThree = Notebook.bNoteThree060; iTempLoyalty = iLoyalty060; bTempCorpse = bCorpse060; Flood.bPutInDanger = Flood.bPutInDanger060; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted060; }
            if (tempNPC == NPC_061) { Conversation.bTempTalked = Conversation.bAlreadyTalked061; sTempWeapons = sAvailableWeapons061; /* Conversation.iSpeaker061 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins061; iTempLocation = NPC061_CurrentNumLocation; iTempLastLocation = NPC061_LastLocation; sTempLastLocation = NPC061_LastStrLocation; sTempCurrentLocation = NPC061_CurrentStrLocation; iTempDesireToMove = DesireToMove061; bTempCorpse = bCorpse061; iCloseEncounters = iClose061; Notebook.bTempNoted = Notebook.bNoted061; Notebook.iTempObserved = Notebook.iObserved061; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne061; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo061; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree061; Notebook.bNoteOne = Notebook.bNoteOne061; Notebook.bNoteTwo = Notebook.bNoteTwo061; Notebook.bNoteThree = Notebook.bNoteThree061; iTempLoyalty = iLoyalty061; bTempCorpse = bCorpse061; Flood.bPutInDanger = Flood.bPutInDanger061; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted061; }
            if (tempNPC == NPC_062) { Conversation.bTempTalked = Conversation.bAlreadyTalked062; sTempWeapons = sAvailableWeapons062; /* Conversation.iSpeaker062 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins062; iTempLocation = NPC062_CurrentNumLocation; iTempLastLocation = NPC062_LastLocation; sTempLastLocation = NPC062_LastStrLocation; sTempCurrentLocation = NPC062_CurrentStrLocation; iTempDesireToMove = DesireToMove062; bTempCorpse = bCorpse062; iCloseEncounters = iClose062; Notebook.bTempNoted = Notebook.bNoted062; Notebook.iTempObserved = Notebook.iObserved062; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne062; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo062; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree062; Notebook.bNoteOne = Notebook.bNoteOne062; Notebook.bNoteTwo = Notebook.bNoteTwo062; Notebook.bNoteThree = Notebook.bNoteThree062; iTempLoyalty = iLoyalty062; bTempCorpse = bCorpse062; Flood.bPutInDanger = Flood.bPutInDanger062; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted062; }
            if (tempNPC == NPC_063) { Conversation.bTempTalked = Conversation.bAlreadyTalked063; sTempWeapons = sAvailableWeapons063; /* Conversation.iSpeaker063 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins063; iTempLocation = NPC063_CurrentNumLocation; iTempLastLocation = NPC063_LastLocation; sTempLastLocation = NPC063_LastStrLocation; sTempCurrentLocation = NPC063_CurrentStrLocation; iTempDesireToMove = DesireToMove063; bTempCorpse = bCorpse063; iCloseEncounters = iClose063; Notebook.bTempNoted = Notebook.bNoted063; Notebook.iTempObserved = Notebook.iObserved063; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne063; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo063; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree063; Notebook.bNoteOne = Notebook.bNoteOne063; Notebook.bNoteTwo = Notebook.bNoteTwo063; Notebook.bNoteThree = Notebook.bNoteThree063; iTempLoyalty = iLoyalty063; bTempCorpse = bCorpse063; Flood.bPutInDanger = Flood.bPutInDanger063; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted063; }
            if (tempNPC == NPC_064) { Conversation.bTempTalked = Conversation.bAlreadyTalked064; sTempWeapons = sAvailableWeapons064; /* Conversation.iSpeaker064 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins064; iTempLocation = NPC064_CurrentNumLocation; iTempLastLocation = NPC064_LastLocation; sTempLastLocation = NPC064_LastStrLocation; sTempCurrentLocation = NPC064_CurrentStrLocation; iTempDesireToMove = DesireToMove064; bTempCorpse = bCorpse064; iCloseEncounters = iClose064; Notebook.bTempNoted = Notebook.bNoted064; Notebook.iTempObserved = Notebook.iObserved064; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne064; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo064; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree064; Notebook.bNoteOne = Notebook.bNoteOne064; Notebook.bNoteTwo = Notebook.bNoteTwo064; Notebook.bNoteThree = Notebook.bNoteThree064; iTempLoyalty = iLoyalty054; bTempCorpse = bCorpse064; Flood.bPutInDanger = Flood.bPutInDanger064; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted064; }
            if (tempNPC == NPC_065) { Conversation.bTempTalked = Conversation.bAlreadyTalked065; sTempWeapons = sAvailableWeapons065; /* Conversation.iSpeaker065 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins065; iTempLocation = NPC065_CurrentNumLocation; iTempLastLocation = NPC065_LastLocation; sTempLastLocation = NPC065_LastStrLocation; sTempCurrentLocation = NPC065_CurrentStrLocation; iTempDesireToMove = DesireToMove065; bTempCorpse = bCorpse065; iCloseEncounters = iClose065; Notebook.bTempNoted = Notebook.bNoted065; Notebook.iTempObserved = Notebook.iObserved065; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne065; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo065; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree065; Notebook.bNoteOne = Notebook.bNoteOne065; Notebook.bNoteTwo = Notebook.bNoteTwo065; Notebook.bNoteThree = Notebook.bNoteThree065; iTempLoyalty = iLoyalty065; bTempCorpse = bCorpse065; Flood.bPutInDanger = Flood.bPutInDanger065; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted065; }
            if (tempNPC == NPC_066) { Conversation.bTempTalked = Conversation.bAlreadyTalked066; sTempWeapons = sAvailableWeapons066; /* Conversation.iSpeaker066 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins066; iTempLocation = NPC066_CurrentNumLocation; iTempLastLocation = NPC066_LastLocation; sTempLastLocation = NPC066_LastStrLocation; sTempCurrentLocation = NPC066_CurrentStrLocation; iTempDesireToMove = DesireToMove066; bTempCorpse = bCorpse066; iCloseEncounters = iClose066; Notebook.bTempNoted = Notebook.bNoted066; Notebook.iTempObserved = Notebook.iObserved066; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne066; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo066; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree066; Notebook.bNoteOne = Notebook.bNoteOne066; Notebook.bNoteTwo = Notebook.bNoteTwo066; Notebook.bNoteThree = Notebook.bNoteThree066; iTempLoyalty = iLoyalty066; bTempCorpse = bCorpse066; Flood.bPutInDanger = Flood.bPutInDanger066; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted066; }
            if (tempNPC == NPC_067) { Conversation.bTempTalked = Conversation.bAlreadyTalked067; sTempWeapons = sAvailableWeapons067; /* Conversation.iSpeaker067 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins067; iTempLocation = NPC067_CurrentNumLocation; iTempLastLocation = NPC067_LastLocation; sTempLastLocation = NPC067_LastStrLocation; sTempCurrentLocation = NPC067_CurrentStrLocation; iTempDesireToMove = DesireToMove067; bTempCorpse = bCorpse067; iCloseEncounters = iClose067; Notebook.bTempNoted = Notebook.bNoted067; Notebook.iTempObserved = Notebook.iObserved067; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne067; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo067; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree067; Notebook.bNoteOne = Notebook.bNoteOne067; Notebook.bNoteTwo = Notebook.bNoteTwo067; Notebook.bNoteThree = Notebook.bNoteThree067; iTempLoyalty = iLoyalty067; bTempCorpse = bCorpse067; Flood.bPutInDanger = Flood.bPutInDanger067; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted067; }
            if (tempNPC == NPC_068) { Conversation.bTempTalked = Conversation.bAlreadyTalked068; sTempWeapons = sAvailableWeapons068; /* Conversation.iSpeaker068 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins068; iTempLocation = NPC068_CurrentNumLocation; iTempLastLocation = NPC068_LastLocation; sTempLastLocation = NPC068_LastStrLocation; sTempCurrentLocation = NPC068_CurrentStrLocation; iTempDesireToMove = DesireToMove068; bTempCorpse = bCorpse068; iCloseEncounters = iClose068; Notebook.bTempNoted = Notebook.bNoted068; Notebook.iTempObserved = Notebook.iObserved068; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne068; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo068; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree068; Notebook.bNoteOne = Notebook.bNoteOne068; Notebook.bNoteTwo = Notebook.bNoteTwo068; Notebook.bNoteThree = Notebook.bNoteThree068; iTempLoyalty = iLoyalty068; bTempCorpse = bCorpse068; Flood.bPutInDanger = Flood.bPutInDanger068; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted068; }
            if (tempNPC == NPC_069) { Conversation.bTempTalked = Conversation.bAlreadyTalked069; sTempWeapons = sAvailableWeapons069; /* Conversation.iSpeaker069 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins069; iTempLocation = NPC069_CurrentNumLocation; iTempLastLocation = NPC069_LastLocation; sTempLastLocation = NPC069_LastStrLocation; sTempCurrentLocation = NPC069_CurrentStrLocation; iTempDesireToMove = DesireToMove069; bTempCorpse = bCorpse069; iCloseEncounters = iClose069; Notebook.bTempNoted = Notebook.bNoted069; Notebook.iTempObserved = Notebook.iObserved069; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne069; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo069; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree069; Notebook.bNoteOne = Notebook.bNoteOne069; Notebook.bNoteTwo = Notebook.bNoteTwo069; Notebook.bNoteThree = Notebook.bNoteThree069; iTempLoyalty = iLoyalty069; bTempCorpse = bCorpse069; Flood.bPutInDanger = Flood.bPutInDanger069; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted069; }
            if (tempNPC == NPC_070) { Conversation.bTempTalked = Conversation.bAlreadyTalked070; sTempWeapons = sAvailableWeapons070; /* Conversation.iSpeaker070 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins070; iTempLocation = NPC070_CurrentNumLocation; iTempLastLocation = NPC070_LastLocation; sTempLastLocation = NPC070_LastStrLocation; sTempCurrentLocation = NPC070_CurrentStrLocation; iTempDesireToMove = DesireToMove070; bTempCorpse = bCorpse070; iCloseEncounters = iClose070; Notebook.bTempNoted = Notebook.bNoted070; Notebook.iTempObserved = Notebook.iObserved070; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne070; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo070; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree070; Notebook.bNoteOne = Notebook.bNoteOne070; Notebook.bNoteTwo = Notebook.bNoteTwo070; Notebook.bNoteThree = Notebook.bNoteThree070; iTempLoyalty = iLoyalty070; bTempCorpse = bCorpse070; Flood.bPutInDanger = Flood.bPutInDanger070; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted070; }
            if (tempNPC == NPC_071) { Conversation.bTempTalked = Conversation.bAlreadyTalked071; sTempWeapons = sAvailableWeapons071; /* Conversation.iSpeaker071 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins071; iTempLocation = NPC071_CurrentNumLocation; iTempLastLocation = NPC071_LastLocation; sTempLastLocation = NPC071_LastStrLocation; sTempCurrentLocation = NPC071_CurrentStrLocation; iTempDesireToMove = DesireToMove071; bTempCorpse = bCorpse071; iCloseEncounters = iClose071; Notebook.bTempNoted = Notebook.bNoted071; Notebook.iTempObserved = Notebook.iObserved071; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne071; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo071; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree071; Notebook.bNoteOne = Notebook.bNoteOne071; Notebook.bNoteTwo = Notebook.bNoteTwo071; Notebook.bNoteThree = Notebook.bNoteThree071; iTempLoyalty = iLoyalty071; bTempCorpse = bCorpse071; Flood.bPutInDanger = Flood.bPutInDanger071; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted071; }
            if (tempNPC == NPC_072) { Conversation.bTempTalked = Conversation.bAlreadyTalked072; sTempWeapons = sAvailableWeapons072; /* Conversation.iSpeaker072 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins072; iTempLocation = NPC072_CurrentNumLocation; iTempLastLocation = NPC072_LastLocation; sTempLastLocation = NPC072_LastStrLocation; sTempCurrentLocation = NPC072_CurrentStrLocation; iTempDesireToMove = DesireToMove072; bTempCorpse = bCorpse072; iCloseEncounters = iClose072; Notebook.bTempNoted = Notebook.bNoted072; Notebook.iTempObserved = Notebook.iObserved072; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne072; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo072; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree072; Notebook.bNoteOne = Notebook.bNoteOne072; Notebook.bNoteTwo = Notebook.bNoteTwo072; Notebook.bNoteThree = Notebook.bNoteThree072; iTempLoyalty = iLoyalty072; bTempCorpse = bCorpse072; Flood.bPutInDanger = Flood.bPutInDanger072; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted072; }
            if (tempNPC == NPC_073) { Conversation.bTempTalked = Conversation.bAlreadyTalked073; sTempWeapons = sAvailableWeapons073; /* Conversation.iSpeaker073 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins073; iTempLocation = NPC073_CurrentNumLocation; iTempLastLocation = NPC073_LastLocation; sTempLastLocation = NPC073_LastStrLocation; sTempCurrentLocation = NPC073_CurrentStrLocation; iTempDesireToMove = DesireToMove073; bTempCorpse = bCorpse073; iCloseEncounters = iClose073; Notebook.bTempNoted = Notebook.bNoted073; Notebook.iTempObserved = Notebook.iObserved073; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne073; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo073; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree073; Notebook.bNoteOne = Notebook.bNoteOne073; Notebook.bNoteTwo = Notebook.bNoteTwo073; Notebook.bNoteThree = Notebook.bNoteThree073; iTempLoyalty = iLoyalty073; bTempCorpse = bCorpse073; Flood.bPutInDanger = Flood.bPutInDanger073; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted073; }
            if (tempNPC == NPC_074) { Conversation.bTempTalked = Conversation.bAlreadyTalked074; sTempWeapons = sAvailableWeapons074; /* Conversation.iSpeaker074 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins074; iTempLocation = NPC074_CurrentNumLocation; iTempLastLocation = NPC074_LastLocation; sTempLastLocation = NPC074_LastStrLocation; sTempCurrentLocation = NPC074_CurrentStrLocation; iTempDesireToMove = DesireToMove074; bTempCorpse = bCorpse074; iCloseEncounters = iClose074; Notebook.bTempNoted = Notebook.bNoted074; Notebook.iTempObserved = Notebook.iObserved074; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne074; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo074; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree074; Notebook.bNoteOne = Notebook.bNoteOne074; Notebook.bNoteTwo = Notebook.bNoteTwo074; Notebook.bNoteThree = Notebook.bNoteThree074; iTempLoyalty = iLoyalty074; bTempCorpse = bCorpse074; Flood.bPutInDanger = Flood.bPutInDanger074; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted074; }
            if (tempNPC == NPC_075) { Conversation.bTempTalked = Conversation.bAlreadyTalked075; sTempWeapons = sAvailableWeapons075; /* Conversation.iSpeaker075 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins075; iTempLocation = NPC075_CurrentNumLocation; iTempLastLocation = NPC075_LastLocation; sTempLastLocation = NPC075_LastStrLocation; sTempCurrentLocation = NPC075_CurrentStrLocation; iTempDesireToMove = DesireToMove075; bTempCorpse = bCorpse075; iCloseEncounters = iClose075; Notebook.bTempNoted = Notebook.bNoted075; Notebook.iTempObserved = Notebook.iObserved075; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne075; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo075; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree075; Notebook.bNoteOne = Notebook.bNoteOne075; Notebook.bNoteTwo = Notebook.bNoteTwo075; Notebook.bNoteThree = Notebook.bNoteThree075; iTempLoyalty = iLoyalty075; bTempCorpse = bCorpse075; Flood.bPutInDanger = Flood.bPutInDanger075; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted075; }
            if (tempNPC == NPC_076) { Conversation.bTempTalked = Conversation.bAlreadyTalked076; sTempWeapons = sAvailableWeapons076; /* Conversation.iSpeaker076 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins076; iTempLocation = NPC076_CurrentNumLocation; iTempLastLocation = NPC076_LastLocation; sTempLastLocation = NPC076_LastStrLocation; sTempCurrentLocation = NPC076_CurrentStrLocation; iTempDesireToMove = DesireToMove076; bTempCorpse = bCorpse076; iCloseEncounters = iClose076; Notebook.bTempNoted = Notebook.bNoted076; Notebook.iTempObserved = Notebook.iObserved076; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne076; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo076; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree076; Notebook.bNoteOne = Notebook.bNoteOne076; Notebook.bNoteTwo = Notebook.bNoteTwo076; Notebook.bNoteThree = Notebook.bNoteThree076; iTempLoyalty = iLoyalty076; bTempCorpse = bCorpse076; Flood.bPutInDanger = Flood.bPutInDanger076; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted076; }
            if (tempNPC == NPC_077) { Conversation.bTempTalked = Conversation.bAlreadyTalked077; sTempWeapons = sAvailableWeapons077; /* Conversation.iSpeaker077 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins077; iTempLocation = NPC077_CurrentNumLocation; iTempLastLocation = NPC077_LastLocation; sTempLastLocation = NPC077_LastStrLocation; sTempCurrentLocation = NPC077_CurrentStrLocation; iTempDesireToMove = DesireToMove077; bTempCorpse = bCorpse077; iCloseEncounters = iClose077; Notebook.bTempNoted = Notebook.bNoted077; Notebook.iTempObserved = Notebook.iObserved077; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne077; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo077; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree077; Notebook.bNoteOne = Notebook.bNoteOne077; Notebook.bNoteTwo = Notebook.bNoteTwo077; Notebook.bNoteThree = Notebook.bNoteThree077; iTempLoyalty = iLoyalty077; bTempCorpse = bCorpse077; Flood.bPutInDanger = Flood.bPutInDanger077; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted077; }
            if (tempNPC == NPC_078) { Conversation.bTempTalked = Conversation.bAlreadyTalked078; sTempWeapons = sAvailableWeapons078; /* Conversation.iSpeaker078 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins078; iTempLocation = NPC078_CurrentNumLocation; iTempLastLocation = NPC078_LastLocation; sTempLastLocation = NPC078_LastStrLocation; sTempCurrentLocation = NPC078_CurrentStrLocation; iTempDesireToMove = DesireToMove078; bTempCorpse = bCorpse078; iCloseEncounters = iClose078; Notebook.bTempNoted = Notebook.bNoted078; Notebook.iTempObserved = Notebook.iObserved078; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne078; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo078; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree078; Notebook.bNoteOne = Notebook.bNoteOne078; Notebook.bNoteTwo = Notebook.bNoteTwo078; Notebook.bNoteThree = Notebook.bNoteThree078; iTempLoyalty = iLoyalty078; bTempCorpse = bCorpse078; Flood.bPutInDanger = Flood.bPutInDanger078; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted078; }
            if (tempNPC == NPC_079) { Conversation.bTempTalked = Conversation.bAlreadyTalked079; sTempWeapons = sAvailableWeapons079; /* Conversation.iSpeaker079 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins079; iTempLocation = NPC079_CurrentNumLocation; iTempLastLocation = NPC079_LastLocation; sTempLastLocation = NPC079_LastStrLocation; sTempCurrentLocation = NPC079_CurrentStrLocation; iTempDesireToMove = DesireToMove079; bTempCorpse = bCorpse079; iCloseEncounters = iClose079; Notebook.bTempNoted = Notebook.bNoted079; Notebook.iTempObserved = Notebook.iObserved079; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne079; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo079; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree079; Notebook.bNoteOne = Notebook.bNoteOne079; Notebook.bNoteTwo = Notebook.bNoteTwo079; Notebook.bNoteThree = Notebook.bNoteThree079; iTempLoyalty = iLoyalty079; bTempCorpse = bCorpse079; Flood.bPutInDanger = Flood.bPutInDanger079; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted079; }
            if (tempNPC == NPC_080) { Conversation.bTempTalked = Conversation.bAlreadyTalked080; sTempWeapons = sAvailableWeapons080; /* Conversation.iSpeaker080 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins080; iTempLocation = NPC080_CurrentNumLocation; iTempLastLocation = NPC080_LastLocation; sTempLastLocation = NPC080_LastStrLocation; sTempCurrentLocation = NPC080_CurrentStrLocation; iTempDesireToMove = DesireToMove080; bTempCorpse = bCorpse080; iCloseEncounters = iClose080; Notebook.bTempNoted = Notebook.bNoted080; Notebook.iTempObserved = Notebook.iObserved080; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne080; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo080; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree080; Notebook.bNoteOne = Notebook.bNoteOne080; Notebook.bNoteTwo = Notebook.bNoteTwo080; Notebook.bNoteThree = Notebook.bNoteThree080; iTempLoyalty = iLoyalty080; bTempCorpse = bCorpse080; Flood.bPutInDanger = Flood.bPutInDanger080; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted080; }
            if (tempNPC == NPC_081) { Conversation.bTempTalked = Conversation.bAlreadyTalked081; sTempWeapons = sAvailableWeapons081; /* Conversation.iSpeaker081 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins081; iTempLocation = NPC081_CurrentNumLocation; iTempLastLocation = NPC081_LastLocation; sTempLastLocation = NPC081_LastStrLocation; sTempCurrentLocation = NPC081_CurrentStrLocation; iTempDesireToMove = DesireToMove081; bTempCorpse = bCorpse081; iCloseEncounters = iClose081; Notebook.bTempNoted = Notebook.bNoted081; Notebook.iTempObserved = Notebook.iObserved081; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne081; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo081; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree081; Notebook.bNoteOne = Notebook.bNoteOne081; Notebook.bNoteTwo = Notebook.bNoteTwo081; Notebook.bNoteThree = Notebook.bNoteThree081; iTempLoyalty = iLoyalty081; bTempCorpse = bCorpse081; Flood.bPutInDanger = Flood.bPutInDanger081; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted081; }
            if (tempNPC == NPC_082) { Conversation.bTempTalked = Conversation.bAlreadyTalked082; sTempWeapons = sAvailableWeapons082; /* Conversation.iSpeaker082 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins082; iTempLocation = NPC082_CurrentNumLocation; iTempLastLocation = NPC082_LastLocation; sTempLastLocation = NPC082_LastStrLocation; sTempCurrentLocation = NPC082_CurrentStrLocation; iTempDesireToMove = DesireToMove082; bTempCorpse = bCorpse082; iCloseEncounters = iClose082; Notebook.bTempNoted = Notebook.bNoted082; Notebook.iTempObserved = Notebook.iObserved082; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne082; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo082; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree082; Notebook.bNoteOne = Notebook.bNoteOne082; Notebook.bNoteTwo = Notebook.bNoteTwo082; Notebook.bNoteThree = Notebook.bNoteThree082; iTempLoyalty = iLoyalty082; bTempCorpse = bCorpse082; Flood.bPutInDanger = Flood.bPutInDanger082; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted082; }
            if (tempNPC == NPC_083) { Conversation.bTempTalked = Conversation.bAlreadyTalked083; sTempWeapons = sAvailableWeapons083; /* Conversation.iSpeaker083 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins083; iTempLocation = NPC083_CurrentNumLocation; iTempLastLocation = NPC083_LastLocation; sTempLastLocation = NPC083_LastStrLocation; sTempCurrentLocation = NPC083_CurrentStrLocation; iTempDesireToMove = DesireToMove083; bTempCorpse = bCorpse083; iCloseEncounters = iClose083; Notebook.bTempNoted = Notebook.bNoted083; Notebook.iTempObserved = Notebook.iObserved083; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne083; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo083; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree083; Notebook.bNoteOne = Notebook.bNoteOne083; Notebook.bNoteTwo = Notebook.bNoteTwo083; Notebook.bNoteThree = Notebook.bNoteThree083; iTempLoyalty = iLoyalty083; bTempCorpse = bCorpse083; Flood.bPutInDanger = Flood.bPutInDanger083; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted083; }
            if (tempNPC == NPC_084) { Conversation.bTempTalked = Conversation.bAlreadyTalked084; sTempWeapons = sAvailableWeapons084; /* Conversation.iSpeaker084 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins084; iTempLocation = NPC084_CurrentNumLocation; iTempLastLocation = NPC084_LastLocation; sTempLastLocation = NPC084_LastStrLocation; sTempCurrentLocation = NPC084_CurrentStrLocation; iTempDesireToMove = DesireToMove084; bTempCorpse = bCorpse084; iCloseEncounters = iClose084; Notebook.bTempNoted = Notebook.bNoted084; Notebook.iTempObserved = Notebook.iObserved084; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne084; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo084; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree084; Notebook.bNoteOne = Notebook.bNoteOne084; Notebook.bNoteTwo = Notebook.bNoteTwo084; Notebook.bNoteThree = Notebook.bNoteThree084; iTempLoyalty = iLoyalty084; bTempCorpse = bCorpse084; Flood.bPutInDanger = Flood.bPutInDanger084; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted084; }
            if (tempNPC == NPC_085) { Conversation.bTempTalked = Conversation.bAlreadyTalked085; sTempWeapons = sAvailableWeapons085; /* Conversation.iSpeaker085 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins085; iTempLocation = NPC085_CurrentNumLocation; iTempLastLocation = NPC085_LastLocation; sTempLastLocation = NPC085_LastStrLocation; sTempCurrentLocation = NPC085_CurrentStrLocation; iTempDesireToMove = DesireToMove085; bTempCorpse = bCorpse085; iCloseEncounters = iClose085; Notebook.bTempNoted = Notebook.bNoted085; Notebook.iTempObserved = Notebook.iObserved085; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne085; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo085; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree085; Notebook.bNoteOne = Notebook.bNoteOne085; Notebook.bNoteTwo = Notebook.bNoteTwo085; Notebook.bNoteThree = Notebook.bNoteThree085; iTempLoyalty = iLoyalty085; bTempCorpse = bCorpse085; Flood.bPutInDanger = Flood.bPutInDanger085; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted085; }
            if (tempNPC == NPC_086) { Conversation.bTempTalked = Conversation.bAlreadyTalked086; sTempWeapons = sAvailableWeapons086; /* Conversation.iSpeaker086 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins086; iTempLocation = NPC086_CurrentNumLocation; iTempLastLocation = NPC086_LastLocation; sTempLastLocation = NPC086_LastStrLocation; sTempCurrentLocation = NPC086_CurrentStrLocation; iTempDesireToMove = DesireToMove086; bTempCorpse = bCorpse086; iCloseEncounters = iClose086; Notebook.bTempNoted = Notebook.bNoted086; Notebook.iTempObserved = Notebook.iObserved086; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne086; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo086; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree086; Notebook.bNoteOne = Notebook.bNoteOne086; Notebook.bNoteTwo = Notebook.bNoteTwo086; Notebook.bNoteThree = Notebook.bNoteThree086; iTempLoyalty = iLoyalty086; bTempCorpse = bCorpse086; Flood.bPutInDanger = Flood.bPutInDanger086; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted086; }
            if (tempNPC == NPC_087) { Conversation.bTempTalked = Conversation.bAlreadyTalked087; sTempWeapons = sAvailableWeapons087; /* Conversation.iSpeaker087 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins087; iTempLocation = NPC087_CurrentNumLocation; iTempLastLocation = NPC087_LastLocation; sTempLastLocation = NPC087_LastStrLocation; sTempCurrentLocation = NPC087_CurrentStrLocation; iTempDesireToMove = DesireToMove087; bTempCorpse = bCorpse087; iCloseEncounters = iClose087; Notebook.bTempNoted = Notebook.bNoted087; Notebook.iTempObserved = Notebook.iObserved087; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne087; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo087; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree087; Notebook.bNoteOne = Notebook.bNoteOne087; Notebook.bNoteTwo = Notebook.bNoteTwo087; Notebook.bNoteThree = Notebook.bNoteThree087; iTempLoyalty = iLoyalty087; bTempCorpse = bCorpse087; Flood.bPutInDanger = Flood.bPutInDanger087; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted087; }
            if (tempNPC == NPC_088) { Conversation.bTempTalked = Conversation.bAlreadyTalked088; sTempWeapons = sAvailableWeapons088; /* Conversation.iSpeaker088 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins088; iTempLocation = NPC088_CurrentNumLocation; iTempLastLocation = NPC088_LastLocation; sTempLastLocation = NPC088_LastStrLocation; sTempCurrentLocation = NPC088_CurrentStrLocation; iTempDesireToMove = DesireToMove088; bTempCorpse = bCorpse088; iCloseEncounters = iClose088; Notebook.bTempNoted = Notebook.bNoted088; Notebook.iTempObserved = Notebook.iObserved088; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne088; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo088; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree088; Notebook.bNoteOne = Notebook.bNoteOne088; Notebook.bNoteTwo = Notebook.bNoteTwo088; Notebook.bNoteThree = Notebook.bNoteThree088; iTempLoyalty = iLoyalty088; bTempCorpse = bCorpse088; Flood.bPutInDanger = Flood.bPutInDanger088; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted088; }
            if (tempNPC == NPC_089) { Conversation.bTempTalked = Conversation.bAlreadyTalked089; sTempWeapons = sAvailableWeapons089; /* Conversation.iSpeaker089 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins089; iTempLocation = NPC089_CurrentNumLocation; iTempLastLocation = NPC089_LastLocation; sTempLastLocation = NPC089_LastStrLocation; sTempCurrentLocation = NPC089_CurrentStrLocation; iTempDesireToMove = DesireToMove089; bTempCorpse = bCorpse089; iCloseEncounters = iClose089; Notebook.bTempNoted = Notebook.bNoted089; Notebook.iTempObserved = Notebook.iObserved089; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne089; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo089; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree089; Notebook.bNoteOne = Notebook.bNoteOne089; Notebook.bNoteTwo = Notebook.bNoteTwo089; Notebook.bNoteThree = Notebook.bNoteThree089; iTempLoyalty = iLoyalty089; bTempCorpse = bCorpse089; Flood.bPutInDanger = Flood.bPutInDanger089; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted089; }
            if (tempNPC == NPC_090) { Conversation.bTempTalked = Conversation.bAlreadyTalked090; sTempWeapons = sAvailableWeapons090; /* Conversation.iSpeaker090 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins090; iTempLocation = NPC090_CurrentNumLocation; iTempLastLocation = NPC090_LastLocation; sTempLastLocation = NPC090_LastStrLocation; sTempCurrentLocation = NPC090_CurrentStrLocation; iTempDesireToMove = DesireToMove090; bTempCorpse = bCorpse090; iCloseEncounters = iClose090; Notebook.bTempNoted = Notebook.bNoted090; Notebook.iTempObserved = Notebook.iObserved090; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne090; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo090; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree090; Notebook.bNoteOne = Notebook.bNoteOne090; Notebook.bNoteTwo = Notebook.bNoteTwo090; Notebook.bNoteThree = Notebook.bNoteThree090; iTempLoyalty = iLoyalty090; bTempCorpse = bCorpse090; Flood.bPutInDanger = Flood.bPutInDanger090; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted090; }
            if (tempNPC == NPC_091) { Conversation.bTempTalked = Conversation.bAlreadyTalked091; sTempWeapons = sAvailableWeapons091; /* Conversation.iSpeaker091 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins091; iTempLocation = NPC091_CurrentNumLocation; iTempLastLocation = NPC091_LastLocation; sTempLastLocation = NPC091_LastStrLocation; sTempCurrentLocation = NPC091_CurrentStrLocation; iTempDesireToMove = DesireToMove091; bTempCorpse = bCorpse091; iCloseEncounters = iClose091; Notebook.bTempNoted = Notebook.bNoted091; Notebook.iTempObserved = Notebook.iObserved091; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne091; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo091; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree091; Notebook.bNoteOne = Notebook.bNoteOne091; Notebook.bNoteTwo = Notebook.bNoteTwo091; Notebook.bNoteThree = Notebook.bNoteThree091; iTempLoyalty = iLoyalty091; bTempCorpse = bCorpse091; Flood.bPutInDanger = Flood.bPutInDanger091; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted091; }
            if (tempNPC == NPC_092) { Conversation.bTempTalked = Conversation.bAlreadyTalked092; sTempWeapons = sAvailableWeapons092; /* Conversation.iSpeaker092 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins092; iTempLocation = NPC092_CurrentNumLocation; iTempLastLocation = NPC092_LastLocation; sTempLastLocation = NPC092_LastStrLocation; sTempCurrentLocation = NPC092_CurrentStrLocation; iTempDesireToMove = DesireToMove092; bTempCorpse = bCorpse092; iCloseEncounters = iClose092; Notebook.bTempNoted = Notebook.bNoted092; Notebook.iTempObserved = Notebook.iObserved092; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne092; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo092; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree092; Notebook.bNoteOne = Notebook.bNoteOne092; Notebook.bNoteTwo = Notebook.bNoteTwo092; Notebook.bNoteThree = Notebook.bNoteThree092; iTempLoyalty = iLoyalty092; bTempCorpse = bCorpse092; Flood.bPutInDanger = Flood.bPutInDanger092; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted092; }
            if (tempNPC == NPC_093) { Conversation.bTempTalked = Conversation.bAlreadyTalked093; sTempWeapons = sAvailableWeapons093; /* Conversation.iSpeaker093 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins093; iTempLocation = NPC093_CurrentNumLocation; iTempLastLocation = NPC093_LastLocation; sTempLastLocation = NPC093_LastStrLocation; sTempCurrentLocation = NPC093_CurrentStrLocation; iTempDesireToMove = DesireToMove093; bTempCorpse = bCorpse093; iCloseEncounters = iClose093; Notebook.bTempNoted = Notebook.bNoted093; Notebook.iTempObserved = Notebook.iObserved093; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne093; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo093; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree093; Notebook.bNoteOne = Notebook.bNoteOne093; Notebook.bNoteTwo = Notebook.bNoteTwo093; Notebook.bNoteThree = Notebook.bNoteThree093; iTempLoyalty = iLoyalty093; bTempCorpse = bCorpse093; Flood.bPutInDanger = Flood.bPutInDanger093; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted093; }
            if (tempNPC == NPC_094) { Conversation.bTempTalked = Conversation.bAlreadyTalked094; sTempWeapons = sAvailableWeapons094; /* Conversation.iSpeaker094 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins094; iTempLocation = NPC094_CurrentNumLocation; iTempLastLocation = NPC094_LastLocation; sTempLastLocation = NPC094_LastStrLocation; sTempCurrentLocation = NPC094_CurrentStrLocation; iTempDesireToMove = DesireToMove094; bTempCorpse = bCorpse094; iCloseEncounters = iClose094; Notebook.bTempNoted = Notebook.bNoted094; Notebook.iTempObserved = Notebook.iObserved094; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne094; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo094; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree094; Notebook.bNoteOne = Notebook.bNoteOne094; Notebook.bNoteTwo = Notebook.bNoteTwo094; Notebook.bNoteThree = Notebook.bNoteThree094; iTempLoyalty = iLoyalty094; bTempCorpse = bCorpse094; Flood.bPutInDanger = Flood.bPutInDanger094; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted094; }
            if (tempNPC == NPC_095) { Conversation.bTempTalked = Conversation.bAlreadyTalked095; sTempWeapons = sAvailableWeapons095; /* Conversation.iSpeaker095 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins095; iTempLocation = NPC095_CurrentNumLocation; iTempLastLocation = NPC095_LastLocation; sTempLastLocation = NPC095_LastStrLocation; sTempCurrentLocation = NPC095_CurrentStrLocation; iTempDesireToMove = DesireToMove095; bTempCorpse = bCorpse095; iCloseEncounters = iClose095; Notebook.bTempNoted = Notebook.bNoted095; Notebook.iTempObserved = Notebook.iObserved095; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne095; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo095; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree095; Notebook.bNoteOne = Notebook.bNoteOne095; Notebook.bNoteTwo = Notebook.bNoteTwo095; Notebook.bNoteThree = Notebook.bNoteThree095; iTempLoyalty = iLoyalty095; bTempCorpse = bCorpse095; Flood.bPutInDanger = Flood.bPutInDanger095; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted095; }
            if (tempNPC == NPC_096) { Conversation.bTempTalked = Conversation.bAlreadyTalked096; sTempWeapons = sAvailableWeapons096; /* Conversation.iSpeaker096 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins096; iTempLocation = NPC096_CurrentNumLocation; iTempLastLocation = NPC096_LastLocation; sTempLastLocation = NPC096_LastStrLocation; sTempCurrentLocation = NPC096_CurrentStrLocation; iTempDesireToMove = DesireToMove096; bTempCorpse = bCorpse096; iCloseEncounters = iClose096; Notebook.bTempNoted = Notebook.bNoted096; Notebook.iTempObserved = Notebook.iObserved096; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne096; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo096; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree096; Notebook.bNoteOne = Notebook.bNoteOne096; Notebook.bNoteTwo = Notebook.bNoteTwo096; Notebook.bNoteThree = Notebook.bNoteThree096; iTempLoyalty = iLoyalty096; bTempCorpse = bCorpse096; Flood.bPutInDanger = Flood.bPutInDanger096; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted096; }
            if (tempNPC == NPC_097) { Conversation.bTempTalked = Conversation.bAlreadyTalked097; sTempWeapons = sAvailableWeapons097; /* Conversation.iSpeaker097 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins097; iTempLocation = NPC097_CurrentNumLocation; iTempLastLocation = NPC097_LastLocation; sTempLastLocation = NPC097_LastStrLocation; sTempCurrentLocation = NPC097_CurrentStrLocation; iTempDesireToMove = DesireToMove097; bTempCorpse = bCorpse097; iCloseEncounters = iClose097; Notebook.bTempNoted = Notebook.bNoted097; Notebook.iTempObserved = Notebook.iObserved097; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne097; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo097; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree097; Notebook.bNoteOne = Notebook.bNoteOne097; Notebook.bNoteTwo = Notebook.bNoteTwo097; Notebook.bNoteThree = Notebook.bNoteThree097; iTempLoyalty = iLoyalty097; bTempCorpse = bCorpse097; Flood.bPutInDanger = Flood.bPutInDanger097; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted097; }
            if (tempNPC == NPC_098) { Conversation.bTempTalked = Conversation.bAlreadyTalked098; sTempWeapons = sAvailableWeapons098; /* Conversation.iSpeaker098 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins098; iTempLocation = NPC098_CurrentNumLocation; iTempLastLocation = NPC098_LastLocation; sTempLastLocation = NPC098_LastStrLocation; sTempCurrentLocation = NPC098_CurrentStrLocation; iTempDesireToMove = DesireToMove098; bTempCorpse = bCorpse098; iCloseEncounters = iClose098; Notebook.bTempNoted = Notebook.bNoted098; Notebook.iTempObserved = Notebook.iObserved098; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne098; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo098; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree098; Notebook.bNoteOne = Notebook.bNoteOne098; Notebook.bNoteTwo = Notebook.bNoteTwo098; Notebook.bNoteThree = Notebook.bNoteThree098; iTempLoyalty = iLoyalty098; bTempCorpse = bCorpse098; Flood.bPutInDanger = Flood.bPutInDanger098; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted098; }
            if (tempNPC == NPC_099) { Conversation.bTempTalked = Conversation.bAlreadyTalked099; sTempWeapons = sAvailableWeapons099; /* Conversation.iSpeaker099 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins099; iTempLocation = NPC099_CurrentNumLocation; iTempLastLocation = NPC099_LastLocation; sTempLastLocation = NPC099_LastStrLocation; sTempCurrentLocation = NPC099_CurrentStrLocation; iTempDesireToMove = DesireToMove099; bTempCorpse = bCorpse099; iCloseEncounters = iClose099; Notebook.bTempNoted = Notebook.bNoted099; Notebook.iTempObserved = Notebook.iObserved099; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne099; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo099; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree099; Notebook.bNoteOne = Notebook.bNoteOne099; Notebook.bNoteTwo = Notebook.bNoteTwo099; Notebook.bNoteThree = Notebook.bNoteThree099; iTempLoyalty = iLoyalty099; bTempCorpse = bCorpse099; Flood.bPutInDanger = Flood.bPutInDanger099; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted099; }
            if (tempNPC == NPC_100) { Conversation.bTempTalked = Conversation.bAlreadyTalked100; sTempWeapons = sAvailableWeapons100; /* Conversation.iSpeaker100 = /* Conversation.iSpeaker; */ iTempMacGuffins = iAvailableMacGuffins100; iTempLocation = NPC100_CurrentNumLocation; iTempLastLocation = NPC100_LastLocation; sTempLastLocation = NPC100_LastStrLocation; sTempCurrentLocation = NPC100_CurrentStrLocation; iTempDesireToMove = DesireToMove100; bTempCorpse = bCorpse100; iCloseEncounters = iClose100; Notebook.bTempNoted = Notebook.bNoted100; Notebook.iTempObserved = Notebook.iObserved100; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne100; NPC_Traits.sTempTraitTwo = NPC_Traits.TraitTwo100; NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree100; Notebook.bNoteOne = Notebook.bNoteOne100; Notebook.bNoteTwo = Notebook.bNoteTwo100; Notebook.bNoteThree = Notebook.bNoteThree100; iTempLoyalty = iLoyalty100; bTempCorpse = bCorpse100; Flood.bPutInDanger = Flood.bPutInDanger100; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted100; }
        }

        public static void GetAllNPCLocals_Conversation()
        {
            if (tempNPC == NPC_001) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree001; Conversation.bTempTalked = Conversation.bAlreadyTalked001; Notebook.bNoteThree = Notebook.bNoteThree001; }
            if (tempNPC == NPC_002) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree002; Conversation.bTempTalked = Conversation.bAlreadyTalked002; Notebook.bNoteThree = Notebook.bNoteThree002; }
            if (tempNPC == NPC_003) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree003; Conversation.bTempTalked = Conversation.bAlreadyTalked003; Notebook.bNoteThree = Notebook.bNoteThree003; }
            if (tempNPC == NPC_004) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree004; Conversation.bTempTalked = Conversation.bAlreadyTalked004; Notebook.bNoteThree = Notebook.bNoteThree004; }
            if (tempNPC == NPC_005) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree005; Conversation.bTempTalked = Conversation.bAlreadyTalked005; Notebook.bNoteThree = Notebook.bNoteThree005; }
            if (tempNPC == NPC_006) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree006; Conversation.bTempTalked = Conversation.bAlreadyTalked006; Notebook.bNoteThree = Notebook.bNoteThree006; }
            if (tempNPC == NPC_007) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree007; Conversation.bTempTalked = Conversation.bAlreadyTalked007; Notebook.bNoteThree = Notebook.bNoteThree007; }
            if (tempNPC == NPC_008) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree008; Conversation.bTempTalked = Conversation.bAlreadyTalked008; Notebook.bNoteThree = Notebook.bNoteThree008; }
            if (tempNPC == NPC_009) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree009; Conversation.bTempTalked = Conversation.bAlreadyTalked009; Notebook.bNoteThree = Notebook.bNoteThree009; }
            if (tempNPC == NPC_010) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree010; Conversation.bTempTalked = Conversation.bAlreadyTalked010; Notebook.bNoteThree = Notebook.bNoteThree010; }
            if (tempNPC == NPC_011) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree011; Conversation.bTempTalked = Conversation.bAlreadyTalked011; Notebook.bNoteThree = Notebook.bNoteThree011; }
            if (tempNPC == NPC_012) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree012; Conversation.bTempTalked = Conversation.bAlreadyTalked012; Notebook.bNoteThree = Notebook.bNoteThree012; }
            if (tempNPC == NPC_013) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree013; Conversation.bTempTalked = Conversation.bAlreadyTalked013; Notebook.bNoteThree = Notebook.bNoteThree013; }
            if (tempNPC == NPC_014) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree014; Conversation.bTempTalked = Conversation.bAlreadyTalked014; Notebook.bNoteThree = Notebook.bNoteThree014; }
            if (tempNPC == NPC_015) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree015; Conversation.bTempTalked = Conversation.bAlreadyTalked015; Notebook.bNoteThree = Notebook.bNoteThree015; }
            if (tempNPC == NPC_016) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree016; Conversation.bTempTalked = Conversation.bAlreadyTalked016; Notebook.bNoteThree = Notebook.bNoteThree016; }
            if (tempNPC == NPC_017) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree017; Conversation.bTempTalked = Conversation.bAlreadyTalked017; Notebook.bNoteThree = Notebook.bNoteThree017; }
            if (tempNPC == NPC_018) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree018; Conversation.bTempTalked = Conversation.bAlreadyTalked018; Notebook.bNoteThree = Notebook.bNoteThree018; }
            if (tempNPC == NPC_019) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree019; Conversation.bTempTalked = Conversation.bAlreadyTalked019; Notebook.bNoteThree = Notebook.bNoteThree019; }
            if (tempNPC == NPC_020) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree020; Conversation.bTempTalked = Conversation.bAlreadyTalked020; Notebook.bNoteThree = Notebook.bNoteThree020; }
            if (tempNPC == NPC_021) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree021; Conversation.bTempTalked = Conversation.bAlreadyTalked021; Notebook.bNoteThree = Notebook.bNoteThree021; }
            if (tempNPC == NPC_022) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree022; Conversation.bTempTalked = Conversation.bAlreadyTalked022; Notebook.bNoteThree = Notebook.bNoteThree022; }
            if (tempNPC == NPC_023) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree023; Conversation.bTempTalked = Conversation.bAlreadyTalked023; Notebook.bNoteThree = Notebook.bNoteThree023; }
            if (tempNPC == NPC_024) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree024; Conversation.bTempTalked = Conversation.bAlreadyTalked024; Notebook.bNoteThree = Notebook.bNoteThree024; }
            if (tempNPC == NPC_025) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree025; Conversation.bTempTalked = Conversation.bAlreadyTalked025; Notebook.bNoteThree = Notebook.bNoteThree025; }
            if (tempNPC == NPC_026) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree026; Conversation.bTempTalked = Conversation.bAlreadyTalked026; Notebook.bNoteThree = Notebook.bNoteThree026; }
            if (tempNPC == NPC_027) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree027; Conversation.bTempTalked = Conversation.bAlreadyTalked027; Notebook.bNoteThree = Notebook.bNoteThree027; }
            if (tempNPC == NPC_028) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree028; Conversation.bTempTalked = Conversation.bAlreadyTalked028; Notebook.bNoteThree = Notebook.bNoteThree028; }
            if (tempNPC == NPC_029) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree029; Conversation.bTempTalked = Conversation.bAlreadyTalked029; Notebook.bNoteThree = Notebook.bNoteThree029; }
            if (tempNPC == NPC_030) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree030; Conversation.bTempTalked = Conversation.bAlreadyTalked030; Notebook.bNoteThree = Notebook.bNoteThree030; }
            if (tempNPC == NPC_031) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree031; Conversation.bTempTalked = Conversation.bAlreadyTalked031; Notebook.bNoteThree = Notebook.bNoteThree031; }
            if (tempNPC == NPC_032) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree032; Conversation.bTempTalked = Conversation.bAlreadyTalked032; Notebook.bNoteThree = Notebook.bNoteThree032; }
            if (tempNPC == NPC_033) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree033; Conversation.bTempTalked = Conversation.bAlreadyTalked033; Notebook.bNoteThree = Notebook.bNoteThree033; }
            if (tempNPC == NPC_034) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree034; Conversation.bTempTalked = Conversation.bAlreadyTalked034; Notebook.bNoteThree = Notebook.bNoteThree034; }
            if (tempNPC == NPC_035) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree035; Conversation.bTempTalked = Conversation.bAlreadyTalked035; Notebook.bNoteThree = Notebook.bNoteThree035; }
            if (tempNPC == NPC_036) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree036; Conversation.bTempTalked = Conversation.bAlreadyTalked036; Notebook.bNoteThree = Notebook.bNoteThree036; }
            if (tempNPC == NPC_037) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree037; Conversation.bTempTalked = Conversation.bAlreadyTalked037; Notebook.bNoteThree = Notebook.bNoteThree037; }
            if (tempNPC == NPC_038) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree038; Conversation.bTempTalked = Conversation.bAlreadyTalked038; Notebook.bNoteThree = Notebook.bNoteThree038; }
            if (tempNPC == NPC_039) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree039; Conversation.bTempTalked = Conversation.bAlreadyTalked039; Notebook.bNoteThree = Notebook.bNoteThree039; }
            if (tempNPC == NPC_040) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree040; Conversation.bTempTalked = Conversation.bAlreadyTalked040; Notebook.bNoteThree = Notebook.bNoteThree040; }
            if (tempNPC == NPC_041) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree041; Conversation.bTempTalked = Conversation.bAlreadyTalked041; Notebook.bNoteThree = Notebook.bNoteThree041; }
            if (tempNPC == NPC_042) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree042; Conversation.bTempTalked = Conversation.bAlreadyTalked042; Notebook.bNoteThree = Notebook.bNoteThree042; }
            if (tempNPC == NPC_043) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree043; Conversation.bTempTalked = Conversation.bAlreadyTalked043; Notebook.bNoteThree = Notebook.bNoteThree043; }
            if (tempNPC == NPC_044) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree044; Conversation.bTempTalked = Conversation.bAlreadyTalked044; Notebook.bNoteThree = Notebook.bNoteThree044; }
            if (tempNPC == NPC_045) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree045; Conversation.bTempTalked = Conversation.bAlreadyTalked045; Notebook.bNoteThree = Notebook.bNoteThree045; }
            if (tempNPC == NPC_046) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree046; Conversation.bTempTalked = Conversation.bAlreadyTalked046; Notebook.bNoteThree = Notebook.bNoteThree046; }
            if (tempNPC == NPC_047) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree047; Conversation.bTempTalked = Conversation.bAlreadyTalked047; Notebook.bNoteThree = Notebook.bNoteThree047; }
            if (tempNPC == NPC_048) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree048; Conversation.bTempTalked = Conversation.bAlreadyTalked048; Notebook.bNoteThree = Notebook.bNoteThree048; }
            if (tempNPC == NPC_049) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree049; Conversation.bTempTalked = Conversation.bAlreadyTalked049; Notebook.bNoteThree = Notebook.bNoteThree049; }
            if (tempNPC == NPC_050) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree050; Conversation.bTempTalked = Conversation.bAlreadyTalked050; Notebook.bNoteThree = Notebook.bNoteThree050; }
            if (tempNPC == NPC_051) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree051; Conversation.bTempTalked = Conversation.bAlreadyTalked051; Notebook.bNoteThree = Notebook.bNoteThree051; }
            if (tempNPC == NPC_052) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree052; Conversation.bTempTalked = Conversation.bAlreadyTalked052; Notebook.bNoteThree = Notebook.bNoteThree052; }
            if (tempNPC == NPC_053) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree053; Conversation.bTempTalked = Conversation.bAlreadyTalked053; Notebook.bNoteThree = Notebook.bNoteThree053; }
            if (tempNPC == NPC_054) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree054; Conversation.bTempTalked = Conversation.bAlreadyTalked054; Notebook.bNoteThree = Notebook.bNoteThree054; }
            if (tempNPC == NPC_055) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree055; Conversation.bTempTalked = Conversation.bAlreadyTalked055; Notebook.bNoteThree = Notebook.bNoteThree055; }
            if (tempNPC == NPC_056) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree056; Conversation.bTempTalked = Conversation.bAlreadyTalked056; Notebook.bNoteThree = Notebook.bNoteThree056; }
            if (tempNPC == NPC_057) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree057; Conversation.bTempTalked = Conversation.bAlreadyTalked057; Notebook.bNoteThree = Notebook.bNoteThree057; }
            if (tempNPC == NPC_058) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree058; Conversation.bTempTalked = Conversation.bAlreadyTalked058; Notebook.bNoteThree = Notebook.bNoteThree058; }
            if (tempNPC == NPC_059) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree059; Conversation.bTempTalked = Conversation.bAlreadyTalked059; Notebook.bNoteThree = Notebook.bNoteThree059; }
            if (tempNPC == NPC_060) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree060; Conversation.bTempTalked = Conversation.bAlreadyTalked060; Notebook.bNoteThree = Notebook.bNoteThree060; }
            if (tempNPC == NPC_061) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree061; Conversation.bTempTalked = Conversation.bAlreadyTalked061; Notebook.bNoteThree = Notebook.bNoteThree061; }
            if (tempNPC == NPC_062) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree062; Conversation.bTempTalked = Conversation.bAlreadyTalked062; Notebook.bNoteThree = Notebook.bNoteThree062; }
            if (tempNPC == NPC_063) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree063; Conversation.bTempTalked = Conversation.bAlreadyTalked063; Notebook.bNoteThree = Notebook.bNoteThree063; }
            if (tempNPC == NPC_064) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree064; Conversation.bTempTalked = Conversation.bAlreadyTalked064; Notebook.bNoteThree = Notebook.bNoteThree064; }
            if (tempNPC == NPC_065) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree065; Conversation.bTempTalked = Conversation.bAlreadyTalked065; Notebook.bNoteThree = Notebook.bNoteThree065; }
            if (tempNPC == NPC_066) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree066; Conversation.bTempTalked = Conversation.bAlreadyTalked066; Notebook.bNoteThree = Notebook.bNoteThree066; }
            if (tempNPC == NPC_067) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree067; Conversation.bTempTalked = Conversation.bAlreadyTalked067; Notebook.bNoteThree = Notebook.bNoteThree067; }
            if (tempNPC == NPC_068) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree068; Conversation.bTempTalked = Conversation.bAlreadyTalked068; Notebook.bNoteThree = Notebook.bNoteThree068; }
            if (tempNPC == NPC_069) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree069; Conversation.bTempTalked = Conversation.bAlreadyTalked069; Notebook.bNoteThree = Notebook.bNoteThree069; }
            if (tempNPC == NPC_070) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree070; Conversation.bTempTalked = Conversation.bAlreadyTalked070; Notebook.bNoteThree = Notebook.bNoteThree070; }
            if (tempNPC == NPC_071) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree071; Conversation.bTempTalked = Conversation.bAlreadyTalked071; Notebook.bNoteThree = Notebook.bNoteThree071; }
            if (tempNPC == NPC_072) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree072; Conversation.bTempTalked = Conversation.bAlreadyTalked072; Notebook.bNoteThree = Notebook.bNoteThree072; }
            if (tempNPC == NPC_073) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree073; Conversation.bTempTalked = Conversation.bAlreadyTalked073; Notebook.bNoteThree = Notebook.bNoteThree073; }
            if (tempNPC == NPC_074) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree074; Conversation.bTempTalked = Conversation.bAlreadyTalked074; Notebook.bNoteThree = Notebook.bNoteThree074; }
            if (tempNPC == NPC_075) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree075; Conversation.bTempTalked = Conversation.bAlreadyTalked075; Notebook.bNoteThree = Notebook.bNoteThree075; }
            if (tempNPC == NPC_076) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree076; Conversation.bTempTalked = Conversation.bAlreadyTalked076; Notebook.bNoteThree = Notebook.bNoteThree076; }
            if (tempNPC == NPC_077) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree077; Conversation.bTempTalked = Conversation.bAlreadyTalked077; Notebook.bNoteThree = Notebook.bNoteThree077; }
            if (tempNPC == NPC_078) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree078; Conversation.bTempTalked = Conversation.bAlreadyTalked078; Notebook.bNoteThree = Notebook.bNoteThree078; }
            if (tempNPC == NPC_079) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree079; Conversation.bTempTalked = Conversation.bAlreadyTalked079; Notebook.bNoteThree = Notebook.bNoteThree079; }
            if (tempNPC == NPC_080) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree080; Conversation.bTempTalked = Conversation.bAlreadyTalked080; Notebook.bNoteThree = Notebook.bNoteThree080; }
            if (tempNPC == NPC_081) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree081; Conversation.bTempTalked = Conversation.bAlreadyTalked081; Notebook.bNoteThree = Notebook.bNoteThree081; }
            if (tempNPC == NPC_082) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree082; Conversation.bTempTalked = Conversation.bAlreadyTalked082; Notebook.bNoteThree = Notebook.bNoteThree082; }
            if (tempNPC == NPC_083) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree083; Conversation.bTempTalked = Conversation.bAlreadyTalked083; Notebook.bNoteThree = Notebook.bNoteThree083; }
            if (tempNPC == NPC_084) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree084; Conversation.bTempTalked = Conversation.bAlreadyTalked084; Notebook.bNoteThree = Notebook.bNoteThree084; }
            if (tempNPC == NPC_085) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree085; Conversation.bTempTalked = Conversation.bAlreadyTalked085; Notebook.bNoteThree = Notebook.bNoteThree085; }
            if (tempNPC == NPC_086) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree086; Conversation.bTempTalked = Conversation.bAlreadyTalked086; Notebook.bNoteThree = Notebook.bNoteThree086; }
            if (tempNPC == NPC_087) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree087; Conversation.bTempTalked = Conversation.bAlreadyTalked087; Notebook.bNoteThree = Notebook.bNoteThree087; }
            if (tempNPC == NPC_088) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree088; Conversation.bTempTalked = Conversation.bAlreadyTalked088; Notebook.bNoteThree = Notebook.bNoteThree088; }
            if (tempNPC == NPC_089) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree089; Conversation.bTempTalked = Conversation.bAlreadyTalked089; Notebook.bNoteThree = Notebook.bNoteThree089; }
            if (tempNPC == NPC_090) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree090; Conversation.bTempTalked = Conversation.bAlreadyTalked090; Notebook.bNoteThree = Notebook.bNoteThree090; }
            if (tempNPC == NPC_091) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree091; Conversation.bTempTalked = Conversation.bAlreadyTalked091; Notebook.bNoteThree = Notebook.bNoteThree091; }
            if (tempNPC == NPC_092) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree092; Conversation.bTempTalked = Conversation.bAlreadyTalked092; Notebook.bNoteThree = Notebook.bNoteThree092; }
            if (tempNPC == NPC_093) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree093; Conversation.bTempTalked = Conversation.bAlreadyTalked093; Notebook.bNoteThree = Notebook.bNoteThree093; }
            if (tempNPC == NPC_094) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree094; Conversation.bTempTalked = Conversation.bAlreadyTalked094; Notebook.bNoteThree = Notebook.bNoteThree094; }
            if (tempNPC == NPC_095) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree095; Conversation.bTempTalked = Conversation.bAlreadyTalked095; Notebook.bNoteThree = Notebook.bNoteThree095; }
            if (tempNPC == NPC_096) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree096; Conversation.bTempTalked = Conversation.bAlreadyTalked096; Notebook.bNoteThree = Notebook.bNoteThree096; }
            if (tempNPC == NPC_097) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree097; Conversation.bTempTalked = Conversation.bAlreadyTalked097; Notebook.bNoteThree = Notebook.bNoteThree097; }
            if (tempNPC == NPC_098) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree098; Conversation.bTempTalked = Conversation.bAlreadyTalked098; Notebook.bNoteThree = Notebook.bNoteThree098; }
            if (tempNPC == NPC_099) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree099; Conversation.bTempTalked = Conversation.bAlreadyTalked099; Notebook.bNoteThree = Notebook.bNoteThree099; }
            if (tempNPC == NPC_100) { NPC_Traits.sTempTraitThree = NPC_Traits.TraitThree100; Conversation.bTempTalked = Conversation.bAlreadyTalked100; Notebook.bNoteThree = Notebook.bNoteThree100; }
        }

        public static void SetAllNPCLocals_Conversation()
        {
            if (tempNPC == NPC_001) { NPC_Traits.TraitThree001 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked001 = Conversation.bTempTalked; Notebook.bNoteThree001 = Notebook.bNoteThree; }
            if (tempNPC == NPC_002) { NPC_Traits.TraitThree002 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked002 = Conversation.bTempTalked; Notebook.bNoteThree002 = Notebook.bNoteThree; }
            if (tempNPC == NPC_003) { NPC_Traits.TraitThree003 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked003 = Conversation.bTempTalked; Notebook.bNoteThree003 = Notebook.bNoteThree; }
            if (tempNPC == NPC_004) { NPC_Traits.TraitThree004 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked004 = Conversation.bTempTalked; Notebook.bNoteThree004 = Notebook.bNoteThree; }
            if (tempNPC == NPC_005) { NPC_Traits.TraitThree005 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked005 = Conversation.bTempTalked; Notebook.bNoteThree005 = Notebook.bNoteThree; }
            if (tempNPC == NPC_006) { NPC_Traits.TraitThree006 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked006 = Conversation.bTempTalked; Notebook.bNoteThree006 = Notebook.bNoteThree; }
            if (tempNPC == NPC_007) { NPC_Traits.TraitThree007 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked007 = Conversation.bTempTalked; Notebook.bNoteThree007 = Notebook.bNoteThree; }
            if (tempNPC == NPC_008) { NPC_Traits.TraitThree008 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked008 = Conversation.bTempTalked; Notebook.bNoteThree008 = Notebook.bNoteThree; }
            if (tempNPC == NPC_009) { NPC_Traits.TraitThree009 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked009 = Conversation.bTempTalked; Notebook.bNoteThree009 = Notebook.bNoteThree; }
            if (tempNPC == NPC_010) { NPC_Traits.TraitThree010 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked010 = Conversation.bTempTalked; Notebook.bNoteThree010 = Notebook.bNoteThree; }
            if (tempNPC == NPC_011) { NPC_Traits.TraitThree011 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked011 = Conversation.bTempTalked; Notebook.bNoteThree011 = Notebook.bNoteThree; }
            if (tempNPC == NPC_012) { NPC_Traits.TraitThree012 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked012 = Conversation.bTempTalked; Notebook.bNoteThree012 = Notebook.bNoteThree; }
            if (tempNPC == NPC_013) { NPC_Traits.TraitThree013 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked013 = Conversation.bTempTalked; Notebook.bNoteThree013 = Notebook.bNoteThree; }
            if (tempNPC == NPC_014) { NPC_Traits.TraitThree014 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked014 = Conversation.bTempTalked; Notebook.bNoteThree014 = Notebook.bNoteThree; }
            if (tempNPC == NPC_015) { NPC_Traits.TraitThree015 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked015 = Conversation.bTempTalked; Notebook.bNoteThree015 = Notebook.bNoteThree; }
            if (tempNPC == NPC_016) { NPC_Traits.TraitThree016 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked016 = Conversation.bTempTalked; Notebook.bNoteThree016 = Notebook.bNoteThree; }
            if (tempNPC == NPC_017) { NPC_Traits.TraitThree017 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked017 = Conversation.bTempTalked; Notebook.bNoteThree017 = Notebook.bNoteThree; }
            if (tempNPC == NPC_018) { NPC_Traits.TraitThree018 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked018 = Conversation.bTempTalked; Notebook.bNoteThree018 = Notebook.bNoteThree; }
            if (tempNPC == NPC_019) { NPC_Traits.TraitThree019 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked019 = Conversation.bTempTalked; Notebook.bNoteThree019 = Notebook.bNoteThree; }
            if (tempNPC == NPC_020) { NPC_Traits.TraitThree020 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked020 = Conversation.bTempTalked; Notebook.bNoteThree020 = Notebook.bNoteThree; }
            if (tempNPC == NPC_021) { NPC_Traits.TraitThree021 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked021 = Conversation.bTempTalked; Notebook.bNoteThree021 = Notebook.bNoteThree; }
            if (tempNPC == NPC_022) { NPC_Traits.TraitThree022 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked022 = Conversation.bTempTalked; Notebook.bNoteThree022 = Notebook.bNoteThree; }
            if (tempNPC == NPC_023) { NPC_Traits.TraitThree023 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked023 = Conversation.bTempTalked; Notebook.bNoteThree023 = Notebook.bNoteThree; }
            if (tempNPC == NPC_024) { NPC_Traits.TraitThree024 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked024 = Conversation.bTempTalked; Notebook.bNoteThree024 = Notebook.bNoteThree; }
            if (tempNPC == NPC_025) { NPC_Traits.TraitThree025 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked025 = Conversation.bTempTalked; Notebook.bNoteThree025 = Notebook.bNoteThree; }
            if (tempNPC == NPC_026) { NPC_Traits.TraitThree026 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked026 = Conversation.bTempTalked; Notebook.bNoteThree026 = Notebook.bNoteThree; }
            if (tempNPC == NPC_027) { NPC_Traits.TraitThree027 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked027 = Conversation.bTempTalked; Notebook.bNoteThree027 = Notebook.bNoteThree; }
            if (tempNPC == NPC_028) { NPC_Traits.TraitThree028 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked028 = Conversation.bTempTalked; Notebook.bNoteThree028 = Notebook.bNoteThree; }
            if (tempNPC == NPC_029) { NPC_Traits.TraitThree029 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked029 = Conversation.bTempTalked; Notebook.bNoteThree029 = Notebook.bNoteThree; }
            if (tempNPC == NPC_030) { NPC_Traits.TraitThree030 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked030 = Conversation.bTempTalked; Notebook.bNoteThree030 = Notebook.bNoteThree; }
            if (tempNPC == NPC_031) { NPC_Traits.TraitThree031 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked031 = Conversation.bTempTalked; Notebook.bNoteThree031 = Notebook.bNoteThree; }
            if (tempNPC == NPC_032) { NPC_Traits.TraitThree032 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked032 = Conversation.bTempTalked; Notebook.bNoteThree032 = Notebook.bNoteThree; }
            if (tempNPC == NPC_033) { NPC_Traits.TraitThree033 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked033 = Conversation.bTempTalked; Notebook.bNoteThree033 = Notebook.bNoteThree; }
            if (tempNPC == NPC_034) { NPC_Traits.TraitThree034 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked034 = Conversation.bTempTalked; Notebook.bNoteThree034 = Notebook.bNoteThree; }
            if (tempNPC == NPC_035) { NPC_Traits.TraitThree035 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked035 = Conversation.bTempTalked; Notebook.bNoteThree035 = Notebook.bNoteThree; }
            if (tempNPC == NPC_036) { NPC_Traits.TraitThree036 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked036 = Conversation.bTempTalked; Notebook.bNoteThree036 = Notebook.bNoteThree; }
            if (tempNPC == NPC_037) { NPC_Traits.TraitThree037 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked037 = Conversation.bTempTalked; Notebook.bNoteThree037 = Notebook.bNoteThree; }
            if (tempNPC == NPC_038) { NPC_Traits.TraitThree038 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked038 = Conversation.bTempTalked; Notebook.bNoteThree038 = Notebook.bNoteThree; }
            if (tempNPC == NPC_039) { NPC_Traits.TraitThree039 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked039 = Conversation.bTempTalked; Notebook.bNoteThree039 = Notebook.bNoteThree; }
            if (tempNPC == NPC_040) { NPC_Traits.TraitThree040 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked040 = Conversation.bTempTalked; Notebook.bNoteThree040 = Notebook.bNoteThree; }
            if (tempNPC == NPC_041) { NPC_Traits.TraitThree041 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked041 = Conversation.bTempTalked; Notebook.bNoteThree041 = Notebook.bNoteThree; }
            if (tempNPC == NPC_042) { NPC_Traits.TraitThree042 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked042 = Conversation.bTempTalked; Notebook.bNoteThree042 = Notebook.bNoteThree; }
            if (tempNPC == NPC_043) { NPC_Traits.TraitThree043 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked043 = Conversation.bTempTalked; Notebook.bNoteThree043 = Notebook.bNoteThree; }
            if (tempNPC == NPC_044) { NPC_Traits.TraitThree044 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked044 = Conversation.bTempTalked; Notebook.bNoteThree044 = Notebook.bNoteThree; }
            if (tempNPC == NPC_045) { NPC_Traits.TraitThree045 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked045 = Conversation.bTempTalked; Notebook.bNoteThree045 = Notebook.bNoteThree; }
            if (tempNPC == NPC_046) { NPC_Traits.TraitThree046 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked046 = Conversation.bTempTalked; Notebook.bNoteThree046 = Notebook.bNoteThree; }
            if (tempNPC == NPC_047) { NPC_Traits.TraitThree047 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked047 = Conversation.bTempTalked; Notebook.bNoteThree047 = Notebook.bNoteThree; }
            if (tempNPC == NPC_048) { NPC_Traits.TraitThree048 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked048 = Conversation.bTempTalked; Notebook.bNoteThree048 = Notebook.bNoteThree; }
            if (tempNPC == NPC_049) { NPC_Traits.TraitThree049 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked049 = Conversation.bTempTalked; Notebook.bNoteThree049 = Notebook.bNoteThree; }
            if (tempNPC == NPC_050) { NPC_Traits.TraitThree050 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked050 = Conversation.bTempTalked; Notebook.bNoteThree050 = Notebook.bNoteThree; }
            if (tempNPC == NPC_051) { NPC_Traits.TraitThree051 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked051 = Conversation.bTempTalked; Notebook.bNoteThree051 = Notebook.bNoteThree; }
            if (tempNPC == NPC_052) { NPC_Traits.TraitThree052 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked052 = Conversation.bTempTalked; Notebook.bNoteThree052 = Notebook.bNoteThree; }
            if (tempNPC == NPC_053) { NPC_Traits.TraitThree053 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked053 = Conversation.bTempTalked; Notebook.bNoteThree053 = Notebook.bNoteThree; }
            if (tempNPC == NPC_054) { NPC_Traits.TraitThree054 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked054 = Conversation.bTempTalked; Notebook.bNoteThree054 = Notebook.bNoteThree; }
            if (tempNPC == NPC_055) { NPC_Traits.TraitThree055 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked055 = Conversation.bTempTalked; Notebook.bNoteThree055 = Notebook.bNoteThree; }
            if (tempNPC == NPC_056) { NPC_Traits.TraitThree056 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked056 = Conversation.bTempTalked; Notebook.bNoteThree056 = Notebook.bNoteThree; }
            if (tempNPC == NPC_057) { NPC_Traits.TraitThree057 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked057 = Conversation.bTempTalked; Notebook.bNoteThree057 = Notebook.bNoteThree; }
            if (tempNPC == NPC_058) { NPC_Traits.TraitThree058 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked058 = Conversation.bTempTalked; Notebook.bNoteThree058 = Notebook.bNoteThree; }
            if (tempNPC == NPC_059) { NPC_Traits.TraitThree059 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked059 = Conversation.bTempTalked; Notebook.bNoteThree059 = Notebook.bNoteThree; }
            if (tempNPC == NPC_060) { NPC_Traits.TraitThree060 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked060 = Conversation.bTempTalked; Notebook.bNoteThree060 = Notebook.bNoteThree; }
            if (tempNPC == NPC_061) { NPC_Traits.TraitThree061 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked061 = Conversation.bTempTalked; Notebook.bNoteThree061 = Notebook.bNoteThree; }
            if (tempNPC == NPC_062) { NPC_Traits.TraitThree062 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked062 = Conversation.bTempTalked; Notebook.bNoteThree062 = Notebook.bNoteThree; }
            if (tempNPC == NPC_063) { NPC_Traits.TraitThree063 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked063 = Conversation.bTempTalked; Notebook.bNoteThree063 = Notebook.bNoteThree; }
            if (tempNPC == NPC_064) { NPC_Traits.TraitThree064 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked064 = Conversation.bTempTalked; Notebook.bNoteThree064 = Notebook.bNoteThree; }
            if (tempNPC == NPC_065) { NPC_Traits.TraitThree065 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked065 = Conversation.bTempTalked; Notebook.bNoteThree065 = Notebook.bNoteThree; }
            if (tempNPC == NPC_066) { NPC_Traits.TraitThree066 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked066 = Conversation.bTempTalked; Notebook.bNoteThree066 = Notebook.bNoteThree; }
            if (tempNPC == NPC_067) { NPC_Traits.TraitThree067 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked067 = Conversation.bTempTalked; Notebook.bNoteThree067 = Notebook.bNoteThree; }
            if (tempNPC == NPC_068) { NPC_Traits.TraitThree068 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked068 = Conversation.bTempTalked; Notebook.bNoteThree068 = Notebook.bNoteThree; }
            if (tempNPC == NPC_069) { NPC_Traits.TraitThree069 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked069 = Conversation.bTempTalked; Notebook.bNoteThree069 = Notebook.bNoteThree; }
            if (tempNPC == NPC_070) { NPC_Traits.TraitThree070 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked070 = Conversation.bTempTalked; Notebook.bNoteThree070 = Notebook.bNoteThree; }
            if (tempNPC == NPC_071) { NPC_Traits.TraitThree071 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked071 = Conversation.bTempTalked; Notebook.bNoteThree071 = Notebook.bNoteThree; }
            if (tempNPC == NPC_072) { NPC_Traits.TraitThree072 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked072 = Conversation.bTempTalked; Notebook.bNoteThree072 = Notebook.bNoteThree; }
            if (tempNPC == NPC_073) { NPC_Traits.TraitThree073 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked073 = Conversation.bTempTalked; Notebook.bNoteThree073 = Notebook.bNoteThree; }
            if (tempNPC == NPC_074) { NPC_Traits.TraitThree074 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked074 = Conversation.bTempTalked; Notebook.bNoteThree074 = Notebook.bNoteThree; }
            if (tempNPC == NPC_075) { NPC_Traits.TraitThree075 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked075 = Conversation.bTempTalked; Notebook.bNoteThree075 = Notebook.bNoteThree; }
            if (tempNPC == NPC_076) { NPC_Traits.TraitThree076 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked076 = Conversation.bTempTalked; Notebook.bNoteThree076 = Notebook.bNoteThree; }
            if (tempNPC == NPC_077) { NPC_Traits.TraitThree077 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked077 = Conversation.bTempTalked; Notebook.bNoteThree077 = Notebook.bNoteThree; }
            if (tempNPC == NPC_078) { NPC_Traits.TraitThree078 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked078 = Conversation.bTempTalked; Notebook.bNoteThree078 = Notebook.bNoteThree; }
            if (tempNPC == NPC_079) { NPC_Traits.TraitThree079 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked079 = Conversation.bTempTalked; Notebook.bNoteThree079 = Notebook.bNoteThree; }
            if (tempNPC == NPC_080) { NPC_Traits.TraitThree080 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked080 = Conversation.bTempTalked; Notebook.bNoteThree080 = Notebook.bNoteThree; }
            if (tempNPC == NPC_081) { NPC_Traits.TraitThree081 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked081 = Conversation.bTempTalked; Notebook.bNoteThree081 = Notebook.bNoteThree; }
            if (tempNPC == NPC_082) { NPC_Traits.TraitThree082 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked082 = Conversation.bTempTalked; Notebook.bNoteThree082 = Notebook.bNoteThree; }
            if (tempNPC == NPC_083) { NPC_Traits.TraitThree083 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked083 = Conversation.bTempTalked; Notebook.bNoteThree083 = Notebook.bNoteThree; }
            if (tempNPC == NPC_084) { NPC_Traits.TraitThree084 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked084 = Conversation.bTempTalked; Notebook.bNoteThree084 = Notebook.bNoteThree; }
            if (tempNPC == NPC_085) { NPC_Traits.TraitThree085 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked085 = Conversation.bTempTalked; Notebook.bNoteThree085 = Notebook.bNoteThree; }
            if (tempNPC == NPC_086) { NPC_Traits.TraitThree086 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked086 = Conversation.bTempTalked; Notebook.bNoteThree086 = Notebook.bNoteThree; }
            if (tempNPC == NPC_087) { NPC_Traits.TraitThree087 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked087 = Conversation.bTempTalked; Notebook.bNoteThree087 = Notebook.bNoteThree; }
            if (tempNPC == NPC_088) { NPC_Traits.TraitThree088 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked088 = Conversation.bTempTalked; Notebook.bNoteThree088 = Notebook.bNoteThree; }
            if (tempNPC == NPC_089) { NPC_Traits.TraitThree089 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked089 = Conversation.bTempTalked; Notebook.bNoteThree089 = Notebook.bNoteThree; }
            if (tempNPC == NPC_090) { NPC_Traits.TraitThree090 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked090 = Conversation.bTempTalked; Notebook.bNoteThree090 = Notebook.bNoteThree; }
            if (tempNPC == NPC_091) { NPC_Traits.TraitThree091 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked091 = Conversation.bTempTalked; Notebook.bNoteThree091 = Notebook.bNoteThree; }
            if (tempNPC == NPC_092) { NPC_Traits.TraitThree092 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked092 = Conversation.bTempTalked; Notebook.bNoteThree092 = Notebook.bNoteThree; }
            if (tempNPC == NPC_093) { NPC_Traits.TraitThree093 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked093 = Conversation.bTempTalked; Notebook.bNoteThree093 = Notebook.bNoteThree; }
            if (tempNPC == NPC_094) { NPC_Traits.TraitThree094 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked094 = Conversation.bTempTalked; Notebook.bNoteThree094 = Notebook.bNoteThree; }
            if (tempNPC == NPC_095) { NPC_Traits.TraitThree095 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked095 = Conversation.bTempTalked; Notebook.bNoteThree095 = Notebook.bNoteThree; }
            if (tempNPC == NPC_096) { NPC_Traits.TraitThree096 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked096 = Conversation.bTempTalked; Notebook.bNoteThree096 = Notebook.bNoteThree; }
            if (tempNPC == NPC_097) { NPC_Traits.TraitThree097 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked097 = Conversation.bTempTalked; Notebook.bNoteThree097 = Notebook.bNoteThree; }
            if (tempNPC == NPC_098) { NPC_Traits.TraitThree098 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked098 = Conversation.bTempTalked; Notebook.bNoteThree098 = Notebook.bNoteThree; }
            if (tempNPC == NPC_099) { NPC_Traits.TraitThree099 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked099 = Conversation.bTempTalked; Notebook.bNoteThree099 = Notebook.bNoteThree; }
            if (tempNPC == NPC_100) { NPC_Traits.TraitThree100 = NPC_Traits.sTempTraitThree; Conversation.bAlreadyTalked100 = Conversation.bTempTalked; Notebook.bNoteThree100 = Notebook.bNoteThree; }
        }

        public static void GetAllNPCLocals_AskMacGuffins()
        {
            if (tempNPC == NPC_001) { iTempMacGuffins = iAvailableMacGuffins001; iTempLoyalty = iLoyalty001; iTempDesireToMove = DesireToMove001; }
            if (tempNPC == NPC_002) { iTempMacGuffins = iAvailableMacGuffins002; iTempLoyalty = iLoyalty002; iTempDesireToMove = DesireToMove002; }
            if (tempNPC == NPC_003) { iTempMacGuffins = iAvailableMacGuffins003; iTempLoyalty = iLoyalty003; iTempDesireToMove = DesireToMove003; }
            if (tempNPC == NPC_004) { iTempMacGuffins = iAvailableMacGuffins004; iTempLoyalty = iLoyalty004; iTempDesireToMove = DesireToMove004; }
            if (tempNPC == NPC_005) { iTempMacGuffins = iAvailableMacGuffins005; iTempLoyalty = iLoyalty005; iTempDesireToMove = DesireToMove005; }
            if (tempNPC == NPC_006) { iTempMacGuffins = iAvailableMacGuffins006; iTempLoyalty = iLoyalty006; iTempDesireToMove = DesireToMove006; }
            if (tempNPC == NPC_007) { iTempMacGuffins = iAvailableMacGuffins007; iTempLoyalty = iLoyalty007; iTempDesireToMove = DesireToMove007; }
            if (tempNPC == NPC_008) { iTempMacGuffins = iAvailableMacGuffins008; iTempLoyalty = iLoyalty008; iTempDesireToMove = DesireToMove008; }
            if (tempNPC == NPC_009) { iTempMacGuffins = iAvailableMacGuffins009; iTempLoyalty = iLoyalty009; iTempDesireToMove = DesireToMove009; }
            if (tempNPC == NPC_010) { iTempMacGuffins = iAvailableMacGuffins010; iTempLoyalty = iLoyalty020; iTempDesireToMove = DesireToMove010; }
            if (tempNPC == NPC_011) { iTempMacGuffins = iAvailableMacGuffins011; iTempLoyalty = iLoyalty011; iTempDesireToMove = DesireToMove011; }
            if (tempNPC == NPC_012) { iTempMacGuffins = iAvailableMacGuffins012; iTempLoyalty = iLoyalty012; iTempDesireToMove = DesireToMove012; }
            if (tempNPC == NPC_013) { iTempMacGuffins = iAvailableMacGuffins013; iTempLoyalty = iLoyalty013; iTempDesireToMove = DesireToMove013; }
            if (tempNPC == NPC_014) { iTempMacGuffins = iAvailableMacGuffins014; iTempLoyalty = iLoyalty014; iTempDesireToMove = DesireToMove014; }
            if (tempNPC == NPC_015) { iTempMacGuffins = iAvailableMacGuffins015; iTempLoyalty = iLoyalty015; iTempDesireToMove = DesireToMove015; }
            if (tempNPC == NPC_016) { iTempMacGuffins = iAvailableMacGuffins016; iTempLoyalty = iLoyalty016; iTempDesireToMove = DesireToMove016; }
            if (tempNPC == NPC_017) { iTempMacGuffins = iAvailableMacGuffins017; iTempLoyalty = iLoyalty017; iTempDesireToMove = DesireToMove017; }
            if (tempNPC == NPC_018) { iTempMacGuffins = iAvailableMacGuffins018; iTempLoyalty = iLoyalty018; iTempDesireToMove = DesireToMove018; }
            if (tempNPC == NPC_019) { iTempMacGuffins = iAvailableMacGuffins019; iTempLoyalty = iLoyalty019; iTempDesireToMove = DesireToMove019; }
            if (tempNPC == NPC_020) { iTempMacGuffins = iAvailableMacGuffins020; iTempLoyalty = iLoyalty020; iTempDesireToMove = DesireToMove020; }
            if (tempNPC == NPC_021) { iTempMacGuffins = iAvailableMacGuffins021; iTempLoyalty = iLoyalty021; iTempDesireToMove = DesireToMove021; }
            if (tempNPC == NPC_022) { iTempMacGuffins = iAvailableMacGuffins022; iTempLoyalty = iLoyalty022; iTempDesireToMove = DesireToMove022; }
            if (tempNPC == NPC_023) { iTempMacGuffins = iAvailableMacGuffins023; iTempLoyalty = iLoyalty023; iTempDesireToMove = DesireToMove023; }
            if (tempNPC == NPC_024) { iTempMacGuffins = iAvailableMacGuffins024; iTempLoyalty = iLoyalty024; iTempDesireToMove = DesireToMove024; }
            if (tempNPC == NPC_025) { iTempMacGuffins = iAvailableMacGuffins025; iTempLoyalty = iLoyalty025; iTempDesireToMove = DesireToMove025; }
            if (tempNPC == NPC_026) { iTempMacGuffins = iAvailableMacGuffins026; iTempLoyalty = iLoyalty026; iTempDesireToMove = DesireToMove026; }
            if (tempNPC == NPC_027) { iTempMacGuffins = iAvailableMacGuffins027; iTempLoyalty = iLoyalty027; iTempDesireToMove = DesireToMove027; }
            if (tempNPC == NPC_028) { iTempMacGuffins = iAvailableMacGuffins028; iTempLoyalty = iLoyalty028; iTempDesireToMove = DesireToMove028; }
            if (tempNPC == NPC_029) { iTempMacGuffins = iAvailableMacGuffins029; iTempLoyalty = iLoyalty029; iTempDesireToMove = DesireToMove029; }
            if (tempNPC == NPC_030) { iTempMacGuffins = iAvailableMacGuffins030; iTempLoyalty = iLoyalty030; iTempDesireToMove = DesireToMove030; }
            if (tempNPC == NPC_031) { iTempMacGuffins = iAvailableMacGuffins031; iTempLoyalty = iLoyalty031; iTempDesireToMove = DesireToMove031; }
            if (tempNPC == NPC_032) { iTempMacGuffins = iAvailableMacGuffins032; iTempLoyalty = iLoyalty032; iTempDesireToMove = DesireToMove032; }
            if (tempNPC == NPC_033) { iTempMacGuffins = iAvailableMacGuffins033; iTempLoyalty = iLoyalty033; iTempDesireToMove = DesireToMove033; }
            if (tempNPC == NPC_034) { iTempMacGuffins = iAvailableMacGuffins034; iTempLoyalty = iLoyalty034; iTempDesireToMove = DesireToMove034; }
            if (tempNPC == NPC_035) { iTempMacGuffins = iAvailableMacGuffins035; iTempLoyalty = iLoyalty035; iTempDesireToMove = DesireToMove035; }
            if (tempNPC == NPC_036) { iTempMacGuffins = iAvailableMacGuffins036; iTempLoyalty = iLoyalty036; iTempDesireToMove = DesireToMove036; }
            if (tempNPC == NPC_037) { iTempMacGuffins = iAvailableMacGuffins037; iTempLoyalty = iLoyalty037; iTempDesireToMove = DesireToMove037; }
            if (tempNPC == NPC_038) { iTempMacGuffins = iAvailableMacGuffins038; iTempLoyalty = iLoyalty038; iTempDesireToMove = DesireToMove038; }
            if (tempNPC == NPC_039) { iTempMacGuffins = iAvailableMacGuffins039; iTempLoyalty = iLoyalty039; iTempDesireToMove = DesireToMove039; }
            if (tempNPC == NPC_040) { iTempMacGuffins = iAvailableMacGuffins040; iTempLoyalty = iLoyalty040; iTempDesireToMove = DesireToMove040; }
            if (tempNPC == NPC_041) { iTempMacGuffins = iAvailableMacGuffins041; iTempLoyalty = iLoyalty041; iTempDesireToMove = DesireToMove041; }
            if (tempNPC == NPC_042) { iTempMacGuffins = iAvailableMacGuffins042; iTempLoyalty = iLoyalty042; iTempDesireToMove = DesireToMove042; }
            if (tempNPC == NPC_043) { iTempMacGuffins = iAvailableMacGuffins043; iTempLoyalty = iLoyalty043; iTempDesireToMove = DesireToMove043; }
            if (tempNPC == NPC_044) { iTempMacGuffins = iAvailableMacGuffins044; iTempLoyalty = iLoyalty044; iTempDesireToMove = DesireToMove044; }
            if (tempNPC == NPC_045) { iTempMacGuffins = iAvailableMacGuffins045; iTempLoyalty = iLoyalty045; iTempDesireToMove = DesireToMove045; }
            if (tempNPC == NPC_046) { iTempMacGuffins = iAvailableMacGuffins046; iTempLoyalty = iLoyalty046; iTempDesireToMove = DesireToMove046; }
            if (tempNPC == NPC_047) { iTempMacGuffins = iAvailableMacGuffins047; iTempLoyalty = iLoyalty047; iTempDesireToMove = DesireToMove047; }
            if (tempNPC == NPC_048) { iTempMacGuffins = iAvailableMacGuffins048; iTempLoyalty = iLoyalty048; iTempDesireToMove = DesireToMove048; }
            if (tempNPC == NPC_049) { iTempMacGuffins = iAvailableMacGuffins049; iTempLoyalty = iLoyalty049; iTempDesireToMove = DesireToMove049; }
            if (tempNPC == NPC_050) { iTempMacGuffins = iAvailableMacGuffins050; iTempLoyalty = iLoyalty050; iTempDesireToMove = DesireToMove050; }
            if (tempNPC == NPC_051) { iTempMacGuffins = iAvailableMacGuffins051; iTempLoyalty = iLoyalty051; iTempDesireToMove = DesireToMove051; }
            if (tempNPC == NPC_052) { iTempMacGuffins = iAvailableMacGuffins052; iTempLoyalty = iLoyalty052; iTempDesireToMove = DesireToMove052; }
            if (tempNPC == NPC_053) { iTempMacGuffins = iAvailableMacGuffins053; iTempLoyalty = iLoyalty053; iTempDesireToMove = DesireToMove053; }
            if (tempNPC == NPC_054) { iTempMacGuffins = iAvailableMacGuffins054; iTempLoyalty = iLoyalty054; iTempDesireToMove = DesireToMove054; }
            if (tempNPC == NPC_055) { iTempMacGuffins = iAvailableMacGuffins055; iTempLoyalty = iLoyalty055; iTempDesireToMove = DesireToMove055; }
            if (tempNPC == NPC_056) { iTempMacGuffins = iAvailableMacGuffins056; iTempLoyalty = iLoyalty056; iTempDesireToMove = DesireToMove056; }
            if (tempNPC == NPC_057) { iTempMacGuffins = iAvailableMacGuffins057; iTempLoyalty = iLoyalty057; iTempDesireToMove = DesireToMove057; }
            if (tempNPC == NPC_058) { iTempMacGuffins = iAvailableMacGuffins058; iTempLoyalty = iLoyalty058; iTempDesireToMove = DesireToMove058; }
            if (tempNPC == NPC_059) { iTempMacGuffins = iAvailableMacGuffins059; iTempLoyalty = iLoyalty059; iTempDesireToMove = DesireToMove059; }
            if (tempNPC == NPC_060) { iTempMacGuffins = iAvailableMacGuffins060; iTempLoyalty = iLoyalty060; iTempDesireToMove = DesireToMove060; }
            if (tempNPC == NPC_061) { iTempMacGuffins = iAvailableMacGuffins061; iTempLoyalty = iLoyalty061; iTempDesireToMove = DesireToMove061; }
            if (tempNPC == NPC_062) { iTempMacGuffins = iAvailableMacGuffins062; iTempLoyalty = iLoyalty062; iTempDesireToMove = DesireToMove062; }
            if (tempNPC == NPC_063) { iTempMacGuffins = iAvailableMacGuffins063; iTempLoyalty = iLoyalty063; iTempDesireToMove = DesireToMove063; }
            if (tempNPC == NPC_064) { iTempMacGuffins = iAvailableMacGuffins064; iTempLoyalty = iLoyalty064; iTempDesireToMove = DesireToMove064; }
            if (tempNPC == NPC_065) { iTempMacGuffins = iAvailableMacGuffins065; iTempLoyalty = iLoyalty065; iTempDesireToMove = DesireToMove065; }
            if (tempNPC == NPC_066) { iTempMacGuffins = iAvailableMacGuffins066; iTempLoyalty = iLoyalty066; iTempDesireToMove = DesireToMove066; }
            if (tempNPC == NPC_067) { iTempMacGuffins = iAvailableMacGuffins067; iTempLoyalty = iLoyalty067; iTempDesireToMove = DesireToMove067; }
            if (tempNPC == NPC_068) { iTempMacGuffins = iAvailableMacGuffins068; iTempLoyalty = iLoyalty068; iTempDesireToMove = DesireToMove068; }
            if (tempNPC == NPC_069) { iTempMacGuffins = iAvailableMacGuffins069; iTempLoyalty = iLoyalty069; iTempDesireToMove = DesireToMove069; }
            if (tempNPC == NPC_070) { iTempMacGuffins = iAvailableMacGuffins070; iTempLoyalty = iLoyalty070; iTempDesireToMove = DesireToMove070; }
            if (tempNPC == NPC_071) { iTempMacGuffins = iAvailableMacGuffins071; iTempLoyalty = iLoyalty071; iTempDesireToMove = DesireToMove071; }
            if (tempNPC == NPC_072) { iTempMacGuffins = iAvailableMacGuffins072; iTempLoyalty = iLoyalty072; iTempDesireToMove = DesireToMove072; }
            if (tempNPC == NPC_073) { iTempMacGuffins = iAvailableMacGuffins073; iTempLoyalty = iLoyalty073; iTempDesireToMove = DesireToMove073; }
            if (tempNPC == NPC_074) { iTempMacGuffins = iAvailableMacGuffins074; iTempLoyalty = iLoyalty074; iTempDesireToMove = DesireToMove074; }
            if (tempNPC == NPC_075) { iTempMacGuffins = iAvailableMacGuffins075; iTempLoyalty = iLoyalty075; iTempDesireToMove = DesireToMove075; }
            if (tempNPC == NPC_076) { iTempMacGuffins = iAvailableMacGuffins076; iTempLoyalty = iLoyalty076; iTempDesireToMove = DesireToMove076; }
            if (tempNPC == NPC_077) { iTempMacGuffins = iAvailableMacGuffins077; iTempLoyalty = iLoyalty077; iTempDesireToMove = DesireToMove077; }
            if (tempNPC == NPC_078) { iTempMacGuffins = iAvailableMacGuffins078; iTempLoyalty = iLoyalty078; iTempDesireToMove = DesireToMove078; }
            if (tempNPC == NPC_079) { iTempMacGuffins = iAvailableMacGuffins079; iTempLoyalty = iLoyalty079; iTempDesireToMove = DesireToMove079; }
            if (tempNPC == NPC_080) { iTempMacGuffins = iAvailableMacGuffins080; iTempLoyalty = iLoyalty080; iTempDesireToMove = DesireToMove080; }
            if (tempNPC == NPC_081) { iTempMacGuffins = iAvailableMacGuffins081; iTempLoyalty = iLoyalty081; iTempDesireToMove = DesireToMove081; }
            if (tempNPC == NPC_082) { iTempMacGuffins = iAvailableMacGuffins082; iTempLoyalty = iLoyalty082; iTempDesireToMove = DesireToMove082; }
            if (tempNPC == NPC_083) { iTempMacGuffins = iAvailableMacGuffins083; iTempLoyalty = iLoyalty083; iTempDesireToMove = DesireToMove083; }
            if (tempNPC == NPC_084) { iTempMacGuffins = iAvailableMacGuffins084; iTempLoyalty = iLoyalty084; iTempDesireToMove = DesireToMove084; }
            if (tempNPC == NPC_085) { iTempMacGuffins = iAvailableMacGuffins085; iTempLoyalty = iLoyalty085; iTempDesireToMove = DesireToMove085; }
            if (tempNPC == NPC_086) { iTempMacGuffins = iAvailableMacGuffins086; iTempLoyalty = iLoyalty086; iTempDesireToMove = DesireToMove086; }
            if (tempNPC == NPC_087) { iTempMacGuffins = iAvailableMacGuffins087; iTempLoyalty = iLoyalty087; iTempDesireToMove = DesireToMove087; }
            if (tempNPC == NPC_088) { iTempMacGuffins = iAvailableMacGuffins088; iTempLoyalty = iLoyalty088; iTempDesireToMove = DesireToMove088; }
            if (tempNPC == NPC_089) { iTempMacGuffins = iAvailableMacGuffins089; iTempLoyalty = iLoyalty089; iTempDesireToMove = DesireToMove089; }
            if (tempNPC == NPC_090) { iTempMacGuffins = iAvailableMacGuffins090; iTempLoyalty = iLoyalty090; iTempDesireToMove = DesireToMove090; }
            if (tempNPC == NPC_091) { iTempMacGuffins = iAvailableMacGuffins091; iTempLoyalty = iLoyalty091; iTempDesireToMove = DesireToMove091; }
            if (tempNPC == NPC_092) { iTempMacGuffins = iAvailableMacGuffins092; iTempLoyalty = iLoyalty092; iTempDesireToMove = DesireToMove092; }
            if (tempNPC == NPC_093) { iTempMacGuffins = iAvailableMacGuffins093; iTempLoyalty = iLoyalty093; iTempDesireToMove = DesireToMove093; }
            if (tempNPC == NPC_094) { iTempMacGuffins = iAvailableMacGuffins094; iTempLoyalty = iLoyalty094; iTempDesireToMove = DesireToMove094; }
            if (tempNPC == NPC_095) { iTempMacGuffins = iAvailableMacGuffins095; iTempLoyalty = iLoyalty095; iTempDesireToMove = DesireToMove095; }
            if (tempNPC == NPC_096) { iTempMacGuffins = iAvailableMacGuffins096; iTempLoyalty = iLoyalty096; iTempDesireToMove = DesireToMove096; }
            if (tempNPC == NPC_097) { iTempMacGuffins = iAvailableMacGuffins097; iTempLoyalty = iLoyalty097; iTempDesireToMove = DesireToMove097; }
            if (tempNPC == NPC_098) { iTempMacGuffins = iAvailableMacGuffins098; iTempLoyalty = iLoyalty098; iTempDesireToMove = DesireToMove098; }
            if (tempNPC == NPC_099) { iTempMacGuffins = iAvailableMacGuffins099; iTempLoyalty = iLoyalty099; iTempDesireToMove = DesireToMove099; }
            if (tempNPC == NPC_100) { iTempMacGuffins = iAvailableMacGuffins100; iTempLoyalty = iLoyalty100; iTempDesireToMove = DesireToMove100; }
        }

        public static void SetAllNPCLocals_AskMacGuffins()
        {
            if (tempNPC == NPC_001) { iAvailableMacGuffins001 = iTempMacGuffins; iLoyalty001 = iTempLoyalty; DesireToMove001 = iTempDesireToMove; }
            if (tempNPC == NPC_002) { iAvailableMacGuffins002 = iTempMacGuffins; iLoyalty002 = iTempLoyalty; DesireToMove002 = iTempDesireToMove; }
            if (tempNPC == NPC_003) { iAvailableMacGuffins003 = iTempMacGuffins; iLoyalty003 = iTempLoyalty; DesireToMove003 = iTempDesireToMove; }
            if (tempNPC == NPC_004) { iAvailableMacGuffins004 = iTempMacGuffins; iLoyalty004 = iTempLoyalty; DesireToMove004 = iTempDesireToMove; }
            if (tempNPC == NPC_005) { iAvailableMacGuffins005 = iTempMacGuffins; iLoyalty005 = iTempLoyalty; DesireToMove005 = iTempDesireToMove; }
            if (tempNPC == NPC_006) { iAvailableMacGuffins006 = iTempMacGuffins; iLoyalty006 = iTempLoyalty; DesireToMove006 = iTempDesireToMove; }
            if (tempNPC == NPC_007) { iAvailableMacGuffins007 = iTempMacGuffins; iLoyalty007 = iTempLoyalty; DesireToMove007 = iTempDesireToMove; }
            if (tempNPC == NPC_008) { iAvailableMacGuffins008 = iTempMacGuffins; iLoyalty008 = iTempLoyalty; DesireToMove008 = iTempDesireToMove; }
            if (tempNPC == NPC_009) { iAvailableMacGuffins009 = iTempMacGuffins; iLoyalty009 = iTempLoyalty; DesireToMove009 = iTempDesireToMove; }
            if (tempNPC == NPC_010) { iAvailableMacGuffins010 = iTempMacGuffins; iLoyalty020 = iTempLoyalty; DesireToMove010 = iTempDesireToMove; }
            if (tempNPC == NPC_011) { iAvailableMacGuffins011 = iTempMacGuffins; iLoyalty011 = iTempLoyalty; DesireToMove011 = iTempDesireToMove; }
            if (tempNPC == NPC_012) { iAvailableMacGuffins012 = iTempMacGuffins; iLoyalty012 = iTempLoyalty; DesireToMove012 = iTempDesireToMove; }
            if (tempNPC == NPC_013) { iAvailableMacGuffins013 = iTempMacGuffins; iLoyalty013 = iTempLoyalty; DesireToMove013 = iTempDesireToMove; }
            if (tempNPC == NPC_014) { iAvailableMacGuffins014 = iTempMacGuffins; iLoyalty014 = iTempLoyalty; DesireToMove014 = iTempDesireToMove; }
            if (tempNPC == NPC_015) { iAvailableMacGuffins015 = iTempMacGuffins; iLoyalty015 = iTempLoyalty; DesireToMove015 = iTempDesireToMove; }
            if (tempNPC == NPC_016) { iAvailableMacGuffins016 = iTempMacGuffins; iLoyalty016 = iTempLoyalty; DesireToMove016 = iTempDesireToMove; }
            if (tempNPC == NPC_017) { iAvailableMacGuffins017 = iTempMacGuffins; iLoyalty017 = iTempLoyalty; DesireToMove017 = iTempDesireToMove; }
            if (tempNPC == NPC_018) { iAvailableMacGuffins018 = iTempMacGuffins; iLoyalty018 = iTempLoyalty; DesireToMove018 = iTempDesireToMove; }
            if (tempNPC == NPC_019) { iAvailableMacGuffins019 = iTempMacGuffins; iLoyalty019 = iTempLoyalty; DesireToMove019 = iTempDesireToMove; }
            if (tempNPC == NPC_020) { iAvailableMacGuffins020 = iTempMacGuffins; iLoyalty020 = iTempLoyalty; DesireToMove020 = iTempDesireToMove; }
            if (tempNPC == NPC_021) { iAvailableMacGuffins021 = iTempMacGuffins; iLoyalty021 = iTempLoyalty; DesireToMove021 = iTempDesireToMove; }
            if (tempNPC == NPC_022) { iAvailableMacGuffins022 = iTempMacGuffins; iLoyalty022 = iTempLoyalty; DesireToMove022 = iTempDesireToMove; }
            if (tempNPC == NPC_023) { iAvailableMacGuffins023 = iTempMacGuffins; iLoyalty023 = iTempLoyalty; DesireToMove023 = iTempDesireToMove; }
            if (tempNPC == NPC_024) { iAvailableMacGuffins024 = iTempMacGuffins; iLoyalty024 = iTempLoyalty; DesireToMove024 = iTempDesireToMove; }
            if (tempNPC == NPC_025) { iAvailableMacGuffins025 = iTempMacGuffins; iLoyalty025 = iTempLoyalty; DesireToMove025 = iTempDesireToMove; }
            if (tempNPC == NPC_026) { iAvailableMacGuffins026 = iTempMacGuffins; iLoyalty026 = iTempLoyalty; DesireToMove026 = iTempDesireToMove; }
            if (tempNPC == NPC_027) { iAvailableMacGuffins027 = iTempMacGuffins; iLoyalty027 = iTempLoyalty; DesireToMove027 = iTempDesireToMove; }
            if (tempNPC == NPC_028) { iAvailableMacGuffins028 = iTempMacGuffins; iLoyalty028 = iTempLoyalty; DesireToMove028 = iTempDesireToMove; }
            if (tempNPC == NPC_029) { iAvailableMacGuffins029 = iTempMacGuffins; iLoyalty029 = iTempLoyalty; DesireToMove029 = iTempDesireToMove; }
            if (tempNPC == NPC_030) { iAvailableMacGuffins030 = iTempMacGuffins; iLoyalty030 = iTempLoyalty; DesireToMove030 = iTempDesireToMove; }
            if (tempNPC == NPC_031) { iAvailableMacGuffins031 = iTempMacGuffins; iLoyalty031 = iTempLoyalty; DesireToMove031 = iTempDesireToMove; }
            if (tempNPC == NPC_032) { iAvailableMacGuffins032 = iTempMacGuffins; iLoyalty032 = iTempLoyalty; DesireToMove032 = iTempDesireToMove; }
            if (tempNPC == NPC_033) { iAvailableMacGuffins033 = iTempMacGuffins; iLoyalty033 = iTempLoyalty; DesireToMove033 = iTempDesireToMove; }
            if (tempNPC == NPC_034) { iAvailableMacGuffins034 = iTempMacGuffins; iLoyalty034 = iTempLoyalty; DesireToMove034 = iTempDesireToMove; }
            if (tempNPC == NPC_035) { iAvailableMacGuffins035 = iTempMacGuffins; iLoyalty035 = iTempLoyalty; DesireToMove035 = iTempDesireToMove; }
            if (tempNPC == NPC_036) { iAvailableMacGuffins036 = iTempMacGuffins; iLoyalty036 = iTempLoyalty; DesireToMove036 = iTempDesireToMove; }
            if (tempNPC == NPC_037) { iAvailableMacGuffins037 = iTempMacGuffins; iLoyalty037 = iTempLoyalty; DesireToMove037 = iTempDesireToMove; }
            if (tempNPC == NPC_038) { iAvailableMacGuffins038 = iTempMacGuffins; iLoyalty038 = iTempLoyalty; DesireToMove038 = iTempDesireToMove; }
            if (tempNPC == NPC_039) { iAvailableMacGuffins039 = iTempMacGuffins; iLoyalty039 = iTempLoyalty; DesireToMove039 = iTempDesireToMove; }
            if (tempNPC == NPC_040) { iAvailableMacGuffins040 = iTempMacGuffins; iLoyalty040 = iTempLoyalty; DesireToMove040 = iTempDesireToMove; }
            if (tempNPC == NPC_041) { iAvailableMacGuffins041 = iTempMacGuffins; iLoyalty041 = iTempLoyalty; DesireToMove041 = iTempDesireToMove; }
            if (tempNPC == NPC_042) { iAvailableMacGuffins042 = iTempMacGuffins; iLoyalty042 = iTempLoyalty; DesireToMove042 = iTempDesireToMove; }
            if (tempNPC == NPC_043) { iAvailableMacGuffins043 = iTempMacGuffins; iLoyalty043 = iTempLoyalty; DesireToMove043 = iTempDesireToMove; }
            if (tempNPC == NPC_044) { iAvailableMacGuffins044 = iTempMacGuffins; iLoyalty044 = iTempLoyalty; DesireToMove044 = iTempDesireToMove; }
            if (tempNPC == NPC_045) { iAvailableMacGuffins045 = iTempMacGuffins; iLoyalty045 = iTempLoyalty; DesireToMove045 = iTempDesireToMove; }
            if (tempNPC == NPC_046) { iAvailableMacGuffins046 = iTempMacGuffins; iLoyalty046 = iTempLoyalty; DesireToMove046 = iTempDesireToMove; }
            if (tempNPC == NPC_047) { iAvailableMacGuffins047 = iTempMacGuffins; iLoyalty047 = iTempLoyalty; DesireToMove047 = iTempDesireToMove; }
            if (tempNPC == NPC_048) { iAvailableMacGuffins048 = iTempMacGuffins; iLoyalty048 = iTempLoyalty; DesireToMove048 = iTempDesireToMove; }
            if (tempNPC == NPC_049) { iAvailableMacGuffins049 = iTempMacGuffins; iLoyalty049 = iTempLoyalty; DesireToMove049 = iTempDesireToMove; }
            if (tempNPC == NPC_050) { iAvailableMacGuffins050 = iTempMacGuffins; iLoyalty050 = iTempLoyalty; DesireToMove050 = iTempDesireToMove; }
            if (tempNPC == NPC_051) { iAvailableMacGuffins051 = iTempMacGuffins; iLoyalty051 = iTempLoyalty; DesireToMove051 = iTempDesireToMove; }
            if (tempNPC == NPC_052) { iAvailableMacGuffins052 = iTempMacGuffins; iLoyalty052 = iTempLoyalty; DesireToMove052 = iTempDesireToMove; }
            if (tempNPC == NPC_053) { iAvailableMacGuffins053 = iTempMacGuffins; iLoyalty053 = iTempLoyalty; DesireToMove053 = iTempDesireToMove; }
            if (tempNPC == NPC_054) { iAvailableMacGuffins054 = iTempMacGuffins; iLoyalty054 = iTempLoyalty; DesireToMove054 = iTempDesireToMove; }
            if (tempNPC == NPC_055) { iAvailableMacGuffins055 = iTempMacGuffins; iLoyalty055 = iTempLoyalty; DesireToMove055 = iTempDesireToMove; }
            if (tempNPC == NPC_056) { iAvailableMacGuffins056 = iTempMacGuffins; iLoyalty056 = iTempLoyalty; DesireToMove056 = iTempDesireToMove; }
            if (tempNPC == NPC_057) { iAvailableMacGuffins057 = iTempMacGuffins; iLoyalty057 = iTempLoyalty; DesireToMove057 = iTempDesireToMove; }
            if (tempNPC == NPC_058) { iAvailableMacGuffins058 = iTempMacGuffins; iLoyalty058 = iTempLoyalty; DesireToMove058 = iTempDesireToMove; }
            if (tempNPC == NPC_059) { iAvailableMacGuffins059 = iTempMacGuffins; iLoyalty059 = iTempLoyalty; DesireToMove059 = iTempDesireToMove; }
            if (tempNPC == NPC_060) { iAvailableMacGuffins060 = iTempMacGuffins; iLoyalty060 = iTempLoyalty; DesireToMove060 = iTempDesireToMove; }
            if (tempNPC == NPC_061) { iAvailableMacGuffins061 = iTempMacGuffins; iLoyalty061 = iTempLoyalty; DesireToMove061 = iTempDesireToMove; }
            if (tempNPC == NPC_062) { iAvailableMacGuffins062 = iTempMacGuffins; iLoyalty062 = iTempLoyalty; DesireToMove062 = iTempDesireToMove; }
            if (tempNPC == NPC_063) { iAvailableMacGuffins063 = iTempMacGuffins; iLoyalty063 = iTempLoyalty; DesireToMove063 = iTempDesireToMove; }
            if (tempNPC == NPC_064) { iAvailableMacGuffins064 = iTempMacGuffins; iLoyalty064 = iTempLoyalty; DesireToMove064 = iTempDesireToMove; }
            if (tempNPC == NPC_065) { iAvailableMacGuffins065 = iTempMacGuffins; iLoyalty065 = iTempLoyalty; DesireToMove065 = iTempDesireToMove; }
            if (tempNPC == NPC_066) { iAvailableMacGuffins066 = iTempMacGuffins; iLoyalty066 = iTempLoyalty; DesireToMove066 = iTempDesireToMove; }
            if (tempNPC == NPC_067) { iAvailableMacGuffins067 = iTempMacGuffins; iLoyalty067 = iTempLoyalty; DesireToMove067 = iTempDesireToMove; }
            if (tempNPC == NPC_068) { iAvailableMacGuffins068 = iTempMacGuffins; iLoyalty068 = iTempLoyalty; DesireToMove068 = iTempDesireToMove; }
            if (tempNPC == NPC_069) { iAvailableMacGuffins069 = iTempMacGuffins; iLoyalty069 = iTempLoyalty; DesireToMove069 = iTempDesireToMove; }
            if (tempNPC == NPC_070) { iAvailableMacGuffins070 = iTempMacGuffins; iLoyalty070 = iTempLoyalty; DesireToMove070 = iTempDesireToMove; }
            if (tempNPC == NPC_071) { iAvailableMacGuffins071 = iTempMacGuffins; iLoyalty071 = iTempLoyalty; DesireToMove071 = iTempDesireToMove; }
            if (tempNPC == NPC_072) { iAvailableMacGuffins072 = iTempMacGuffins; iLoyalty072 = iTempLoyalty; DesireToMove072 = iTempDesireToMove; }
            if (tempNPC == NPC_073) { iAvailableMacGuffins073 = iTempMacGuffins; iLoyalty073 = iTempLoyalty; DesireToMove073 = iTempDesireToMove; }
            if (tempNPC == NPC_074) { iAvailableMacGuffins074 = iTempMacGuffins; iLoyalty074 = iTempLoyalty; DesireToMove074 = iTempDesireToMove; }
            if (tempNPC == NPC_075) { iAvailableMacGuffins075 = iTempMacGuffins; iLoyalty075 = iTempLoyalty; DesireToMove075 = iTempDesireToMove; }
            if (tempNPC == NPC_076) { iAvailableMacGuffins076 = iTempMacGuffins; iLoyalty076 = iTempLoyalty; DesireToMove076 = iTempDesireToMove; }
            if (tempNPC == NPC_077) { iAvailableMacGuffins077 = iTempMacGuffins; iLoyalty077 = iTempLoyalty; DesireToMove077 = iTempDesireToMove; }
            if (tempNPC == NPC_078) { iAvailableMacGuffins078 = iTempMacGuffins; iLoyalty078 = iTempLoyalty; DesireToMove078 = iTempDesireToMove; }
            if (tempNPC == NPC_079) { iAvailableMacGuffins079 = iTempMacGuffins; iLoyalty079 = iTempLoyalty; DesireToMove079 = iTempDesireToMove; }
            if (tempNPC == NPC_080) { iAvailableMacGuffins080 = iTempMacGuffins; iLoyalty080 = iTempLoyalty; DesireToMove080 = iTempDesireToMove; }
            if (tempNPC == NPC_081) { iAvailableMacGuffins081 = iTempMacGuffins; iLoyalty081 = iTempLoyalty; DesireToMove081 = iTempDesireToMove; }
            if (tempNPC == NPC_082) { iAvailableMacGuffins082 = iTempMacGuffins; iLoyalty082 = iTempLoyalty; DesireToMove082 = iTempDesireToMove; }
            if (tempNPC == NPC_083) { iAvailableMacGuffins083 = iTempMacGuffins; iLoyalty083 = iTempLoyalty; DesireToMove083 = iTempDesireToMove; }
            if (tempNPC == NPC_084) { iAvailableMacGuffins084 = iTempMacGuffins; iLoyalty084 = iTempLoyalty; DesireToMove084 = iTempDesireToMove; }
            if (tempNPC == NPC_085) { iAvailableMacGuffins085 = iTempMacGuffins; iLoyalty085 = iTempLoyalty; DesireToMove085 = iTempDesireToMove; }
            if (tempNPC == NPC_086) { iAvailableMacGuffins086 = iTempMacGuffins; iLoyalty086 = iTempLoyalty; DesireToMove086 = iTempDesireToMove; }
            if (tempNPC == NPC_087) { iAvailableMacGuffins087 = iTempMacGuffins; iLoyalty087 = iTempLoyalty; DesireToMove087 = iTempDesireToMove; }
            if (tempNPC == NPC_088) { iAvailableMacGuffins088 = iTempMacGuffins; iLoyalty088 = iTempLoyalty; DesireToMove088 = iTempDesireToMove; }
            if (tempNPC == NPC_089) { iAvailableMacGuffins089 = iTempMacGuffins; iLoyalty089 = iTempLoyalty; DesireToMove089 = iTempDesireToMove; }
            if (tempNPC == NPC_090) { iAvailableMacGuffins090 = iTempMacGuffins; iLoyalty090 = iTempLoyalty; DesireToMove090 = iTempDesireToMove; }
            if (tempNPC == NPC_091) { iAvailableMacGuffins091 = iTempMacGuffins; iLoyalty091 = iTempLoyalty; DesireToMove091 = iTempDesireToMove; }
            if (tempNPC == NPC_092) { iAvailableMacGuffins092 = iTempMacGuffins; iLoyalty092 = iTempLoyalty; DesireToMove092 = iTempDesireToMove; }
            if (tempNPC == NPC_093) { iAvailableMacGuffins093 = iTempMacGuffins; iLoyalty093 = iTempLoyalty; DesireToMove093 = iTempDesireToMove; }
            if (tempNPC == NPC_094) { iAvailableMacGuffins094 = iTempMacGuffins; iLoyalty094 = iTempLoyalty; DesireToMove094 = iTempDesireToMove; }
            if (tempNPC == NPC_095) { iAvailableMacGuffins095 = iTempMacGuffins; iLoyalty095 = iTempLoyalty; DesireToMove095 = iTempDesireToMove; }
            if (tempNPC == NPC_096) { iAvailableMacGuffins096 = iTempMacGuffins; iLoyalty096 = iTempLoyalty; DesireToMove096 = iTempDesireToMove; }
            if (tempNPC == NPC_097) { iAvailableMacGuffins097 = iTempMacGuffins; iLoyalty097 = iTempLoyalty; DesireToMove097 = iTempDesireToMove; }
            if (tempNPC == NPC_098) { iAvailableMacGuffins098 = iTempMacGuffins; iLoyalty098 = iTempLoyalty; DesireToMove098 = iTempDesireToMove; }
            if (tempNPC == NPC_099) { iAvailableMacGuffins099 = iTempMacGuffins; iLoyalty099 = iTempLoyalty; DesireToMove099 = iTempDesireToMove; }
            if (tempNPC == NPC_100) { iAvailableMacGuffins100 = iTempMacGuffins; iLoyalty100 = iTempLoyalty; DesireToMove100 = iTempDesireToMove; }
        }

        public static void GetAllNPCLocals_AskWeapon()
        {
            // NPC_AI.sTempWeapons NPC_AI.iTempLoyalty
            if (tempNPC == NPC_001) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons001; iTempLoyalty = iLoyalty001; }
            if (tempNPC == NPC_002) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons002; iTempLoyalty = iLoyalty002; }
            if (tempNPC == NPC_003) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons003; iTempLoyalty = iLoyalty003; }
            if (tempNPC == NPC_004) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons004; iTempLoyalty = iLoyalty004; }
            if (tempNPC == NPC_005) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons005; iTempLoyalty = iLoyalty005; }
            if (tempNPC == NPC_006) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons006; iTempLoyalty = iLoyalty006; }
            if (tempNPC == NPC_007) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons007; iTempLoyalty = iLoyalty007; }
            if (tempNPC == NPC_008) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons008; iTempLoyalty = iLoyalty008; }
            if (tempNPC == NPC_009) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons009; iTempLoyalty = iLoyalty009; }
            if (tempNPC == NPC_010) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons010; iTempLoyalty = iLoyalty020; }
            if (tempNPC == NPC_011) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons011; iTempLoyalty = iLoyalty011; }
            if (tempNPC == NPC_012) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons012; iTempLoyalty = iLoyalty012; }
            if (tempNPC == NPC_013) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons013; iTempLoyalty = iLoyalty013; }
            if (tempNPC == NPC_014) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons014; iTempLoyalty = iLoyalty014; }
            if (tempNPC == NPC_015) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons015; iTempLoyalty = iLoyalty015; }
            if (tempNPC == NPC_016) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons016; iTempLoyalty = iLoyalty016; }
            if (tempNPC == NPC_017) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons017; iTempLoyalty = iLoyalty017; }
            if (tempNPC == NPC_018) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons018; iTempLoyalty = iLoyalty018; }
            if (tempNPC == NPC_019) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons019; iTempLoyalty = iLoyalty019; }
            if (tempNPC == NPC_020) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons020; iTempLoyalty = iLoyalty020; }
            if (tempNPC == NPC_021) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons021; iTempLoyalty = iLoyalty021; }
            if (tempNPC == NPC_022) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons022; iTempLoyalty = iLoyalty022; }
            if (tempNPC == NPC_023) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons023; iTempLoyalty = iLoyalty023; }
            if (tempNPC == NPC_024) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons024; iTempLoyalty = iLoyalty024; }
            if (tempNPC == NPC_025) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons025; iTempLoyalty = iLoyalty025; }
            if (tempNPC == NPC_026) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons026; iTempLoyalty = iLoyalty026; }
            if (tempNPC == NPC_027) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons027; iTempLoyalty = iLoyalty027; }
            if (tempNPC == NPC_028) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons028; iTempLoyalty = iLoyalty028; }
            if (tempNPC == NPC_029) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons029; iTempLoyalty = iLoyalty029; }
            if (tempNPC == NPC_030) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons030; iTempLoyalty = iLoyalty030; }
            if (tempNPC == NPC_031) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons031; iTempLoyalty = iLoyalty031; }
            if (tempNPC == NPC_032) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons032; iTempLoyalty = iLoyalty032; }
            if (tempNPC == NPC_033) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons033; iTempLoyalty = iLoyalty033; }
            if (tempNPC == NPC_034) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons034; iTempLoyalty = iLoyalty034; }
            if (tempNPC == NPC_035) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons035; iTempLoyalty = iLoyalty035; }
            if (tempNPC == NPC_036) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons036; iTempLoyalty = iLoyalty036; }
            if (tempNPC == NPC_037) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons037; iTempLoyalty = iLoyalty037; }
            if (tempNPC == NPC_038) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons038; iTempLoyalty = iLoyalty038; }
            if (tempNPC == NPC_039) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons039; iTempLoyalty = iLoyalty039; }
            if (tempNPC == NPC_040) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons040; iTempLoyalty = iLoyalty040; }
            if (tempNPC == NPC_041) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons041; iTempLoyalty = iLoyalty041; }
            if (tempNPC == NPC_042) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons042; iTempLoyalty = iLoyalty042; }
            if (tempNPC == NPC_043) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons043; iTempLoyalty = iLoyalty043; }
            if (tempNPC == NPC_044) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons044; iTempLoyalty = iLoyalty044; }
            if (tempNPC == NPC_045) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons045; iTempLoyalty = iLoyalty045; }
            if (tempNPC == NPC_046) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons046; iTempLoyalty = iLoyalty046; }
            if (tempNPC == NPC_047) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons047; iTempLoyalty = iLoyalty047; }
            if (tempNPC == NPC_048) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons048; iTempLoyalty = iLoyalty048; }
            if (tempNPC == NPC_049) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons049; iTempLoyalty = iLoyalty049; }
            if (tempNPC == NPC_050) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons050; iTempLoyalty = iLoyalty050; }
            if (tempNPC == NPC_051) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons051; iTempLoyalty = iLoyalty051; }
            if (tempNPC == NPC_052) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons052; iTempLoyalty = iLoyalty052; }
            if (tempNPC == NPC_053) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons053; iTempLoyalty = iLoyalty053; }
            if (tempNPC == NPC_054) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons054; iTempLoyalty = iLoyalty054; }
            if (tempNPC == NPC_055) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons055; iTempLoyalty = iLoyalty055; }
            if (tempNPC == NPC_056) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons056; iTempLoyalty = iLoyalty056; }
            if (tempNPC == NPC_057) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons057; iTempLoyalty = iLoyalty057; }
            if (tempNPC == NPC_058) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons058; iTempLoyalty = iLoyalty058; }
            if (tempNPC == NPC_059) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons059; iTempLoyalty = iLoyalty059; }
            if (tempNPC == NPC_060) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons060; iTempLoyalty = iLoyalty060; }
            if (tempNPC == NPC_061) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons061; iTempLoyalty = iLoyalty061; }
            if (tempNPC == NPC_062) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons062; iTempLoyalty = iLoyalty062; }
            if (tempNPC == NPC_063) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons063; iTempLoyalty = iLoyalty063; }
            if (tempNPC == NPC_064) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons064; iTempLoyalty = iLoyalty064; }
            if (tempNPC == NPC_065) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons065; iTempLoyalty = iLoyalty065; }
            if (tempNPC == NPC_066) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons066; iTempLoyalty = iLoyalty066; }
            if (tempNPC == NPC_067) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons067; iTempLoyalty = iLoyalty067; }
            if (tempNPC == NPC_068) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons068; iTempLoyalty = iLoyalty068; }
            if (tempNPC == NPC_069) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons069; iTempLoyalty = iLoyalty069; }
            if (tempNPC == NPC_070) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons070; iTempLoyalty = iLoyalty070; }
            if (tempNPC == NPC_071) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons071; iTempLoyalty = iLoyalty071; }
            if (tempNPC == NPC_072) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons072; iTempLoyalty = iLoyalty072; }
            if (tempNPC == NPC_073) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons073; iTempLoyalty = iLoyalty073; }
            if (tempNPC == NPC_074) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons074; iTempLoyalty = iLoyalty074; }
            if (tempNPC == NPC_075) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons075; iTempLoyalty = iLoyalty075; }
            if (tempNPC == NPC_076) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons076; iTempLoyalty = iLoyalty076; }
            if (tempNPC == NPC_077) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons077; iTempLoyalty = iLoyalty077; }
            if (tempNPC == NPC_078) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons078; iTempLoyalty = iLoyalty078; }
            if (tempNPC == NPC_079) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons079; iTempLoyalty = iLoyalty079; }
            if (tempNPC == NPC_080) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons080; iTempLoyalty = iLoyalty080; }
            if (tempNPC == NPC_081) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons081; iTempLoyalty = iLoyalty081; }
            if (tempNPC == NPC_082) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons082; iTempLoyalty = iLoyalty082; }
            if (tempNPC == NPC_083) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons083; iTempLoyalty = iLoyalty083; }
            if (tempNPC == NPC_084) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons084; iTempLoyalty = iLoyalty084; }
            if (tempNPC == NPC_085) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons085; iTempLoyalty = iLoyalty085; }
            if (tempNPC == NPC_086) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons086; iTempLoyalty = iLoyalty086; }
            if (tempNPC == NPC_087) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons087; iTempLoyalty = iLoyalty087; }
            if (tempNPC == NPC_088) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons088; iTempLoyalty = iLoyalty088; }
            if (tempNPC == NPC_089) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons089; iTempLoyalty = iLoyalty089; }
            if (tempNPC == NPC_090) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons090; iTempLoyalty = iLoyalty090; }
            if (tempNPC == NPC_091) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons091; iTempLoyalty = iLoyalty091; }
            if (tempNPC == NPC_092) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons092; iTempLoyalty = iLoyalty092; }
            if (tempNPC == NPC_093) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons093; iTempLoyalty = iLoyalty093; }
            if (tempNPC == NPC_094) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons094; iTempLoyalty = iLoyalty094; }
            if (tempNPC == NPC_095) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons095; iTempLoyalty = iLoyalty095; }
            if (tempNPC == NPC_096) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons096; iTempLoyalty = iLoyalty096; }
            if (tempNPC == NPC_097) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons097; iTempLoyalty = iLoyalty097; }
            if (tempNPC == NPC_098) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons098; iTempLoyalty = iLoyalty098; }
            if (tempNPC == NPC_099) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons099; iTempLoyalty = iLoyalty099; }
            if (tempNPC == NPC_100) { NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons100; iTempLoyalty = iLoyalty100; }
        }

        public static void SetAllNPCLocals_AskWeapon()
        {
            // NPC_AI.sTempWeapons NPC_AI.iTempLoyalty
            if (tempNPC == NPC_001) { NPC_AI.sAvailableWeapons001 = NPC_AI.sTempWeapons; iLoyalty001 = iTempLoyalty; }
            if (tempNPC == NPC_002) { NPC_AI.sAvailableWeapons002 = NPC_AI.sTempWeapons; iLoyalty002 = iTempLoyalty; }
            if (tempNPC == NPC_003) { NPC_AI.sAvailableWeapons003 = NPC_AI.sTempWeapons; iLoyalty003 = iTempLoyalty; }
            if (tempNPC == NPC_004) { NPC_AI.sAvailableWeapons004 = NPC_AI.sTempWeapons; iLoyalty004 = iTempLoyalty; }
            if (tempNPC == NPC_005) { NPC_AI.sAvailableWeapons005 = NPC_AI.sTempWeapons; iLoyalty005 = iTempLoyalty; }
            if (tempNPC == NPC_006) { NPC_AI.sAvailableWeapons006 = NPC_AI.sTempWeapons; iLoyalty006 = iTempLoyalty; }
            if (tempNPC == NPC_007) { NPC_AI.sAvailableWeapons007 = NPC_AI.sTempWeapons; iLoyalty007 = iTempLoyalty; }
            if (tempNPC == NPC_008) { NPC_AI.sAvailableWeapons008 = NPC_AI.sTempWeapons; iLoyalty008 = iTempLoyalty; }
            if (tempNPC == NPC_009) { NPC_AI.sAvailableWeapons009 = NPC_AI.sTempWeapons; iLoyalty009 = iTempLoyalty; }
            if (tempNPC == NPC_010) { NPC_AI.sAvailableWeapons010 = NPC_AI.sTempWeapons; iLoyalty020 = iTempLoyalty; }
            if (tempNPC == NPC_011) { NPC_AI.sAvailableWeapons011 = NPC_AI.sTempWeapons; iLoyalty011 = iTempLoyalty; }
            if (tempNPC == NPC_012) { NPC_AI.sAvailableWeapons012 = NPC_AI.sTempWeapons; iLoyalty012 = iTempLoyalty; }
            if (tempNPC == NPC_013) { NPC_AI.sAvailableWeapons013 = NPC_AI.sTempWeapons; iLoyalty013 = iTempLoyalty; }
            if (tempNPC == NPC_014) { NPC_AI.sAvailableWeapons014 = NPC_AI.sTempWeapons; iLoyalty014 = iTempLoyalty; }
            if (tempNPC == NPC_015) { NPC_AI.sAvailableWeapons015 = NPC_AI.sTempWeapons; iLoyalty015 = iTempLoyalty; }
            if (tempNPC == NPC_016) { NPC_AI.sAvailableWeapons016 = NPC_AI.sTempWeapons; iLoyalty016 = iTempLoyalty; }
            if (tempNPC == NPC_017) { NPC_AI.sAvailableWeapons017 = NPC_AI.sTempWeapons; iLoyalty017 = iTempLoyalty; }
            if (tempNPC == NPC_018) { NPC_AI.sAvailableWeapons018 = NPC_AI.sTempWeapons; iLoyalty018 = iTempLoyalty; }
            if (tempNPC == NPC_019) { NPC_AI.sAvailableWeapons019 = NPC_AI.sTempWeapons; iLoyalty019 = iTempLoyalty; }
            if (tempNPC == NPC_020) { NPC_AI.sAvailableWeapons020 = NPC_AI.sTempWeapons; iLoyalty020 = iTempLoyalty; }
            if (tempNPC == NPC_021) { NPC_AI.sAvailableWeapons021 = NPC_AI.sTempWeapons; iLoyalty021 = iTempLoyalty; }
            if (tempNPC == NPC_022) { NPC_AI.sAvailableWeapons022 = NPC_AI.sTempWeapons; iLoyalty022 = iTempLoyalty; }
            if (tempNPC == NPC_023) { NPC_AI.sAvailableWeapons023 = NPC_AI.sTempWeapons; iLoyalty023 = iTempLoyalty; }
            if (tempNPC == NPC_024) { NPC_AI.sAvailableWeapons024 = NPC_AI.sTempWeapons; iLoyalty024 = iTempLoyalty; }
            if (tempNPC == NPC_025) { NPC_AI.sAvailableWeapons025 = NPC_AI.sTempWeapons; iLoyalty025 = iTempLoyalty; }
            if (tempNPC == NPC_026) { NPC_AI.sAvailableWeapons026 = NPC_AI.sTempWeapons; iLoyalty026 = iTempLoyalty; }
            if (tempNPC == NPC_027) { NPC_AI.sAvailableWeapons027 = NPC_AI.sTempWeapons; iLoyalty027 = iTempLoyalty; }
            if (tempNPC == NPC_028) { NPC_AI.sAvailableWeapons028 = NPC_AI.sTempWeapons; iLoyalty028 = iTempLoyalty; }
            if (tempNPC == NPC_029) { NPC_AI.sAvailableWeapons029 = NPC_AI.sTempWeapons; iLoyalty029 = iTempLoyalty; }
            if (tempNPC == NPC_030) { NPC_AI.sAvailableWeapons030 = NPC_AI.sTempWeapons; iLoyalty030 = iTempLoyalty; }
            if (tempNPC == NPC_031) { NPC_AI.sAvailableWeapons031 = NPC_AI.sTempWeapons; iLoyalty031 = iTempLoyalty; }
            if (tempNPC == NPC_032) { NPC_AI.sAvailableWeapons032 = NPC_AI.sTempWeapons; iLoyalty032 = iTempLoyalty; }
            if (tempNPC == NPC_033) { NPC_AI.sAvailableWeapons033 = NPC_AI.sTempWeapons; iLoyalty033 = iTempLoyalty; }
            if (tempNPC == NPC_034) { NPC_AI.sAvailableWeapons034 = NPC_AI.sTempWeapons; iLoyalty034 = iTempLoyalty; }
            if (tempNPC == NPC_035) { NPC_AI.sAvailableWeapons035 = NPC_AI.sTempWeapons; iLoyalty035 = iTempLoyalty; }
            if (tempNPC == NPC_036) { NPC_AI.sAvailableWeapons036 = NPC_AI.sTempWeapons; iLoyalty036 = iTempLoyalty; }
            if (tempNPC == NPC_037) { NPC_AI.sAvailableWeapons037 = NPC_AI.sTempWeapons; iLoyalty037 = iTempLoyalty; }
            if (tempNPC == NPC_038) { NPC_AI.sAvailableWeapons038 = NPC_AI.sTempWeapons; iLoyalty038 = iTempLoyalty; }
            if (tempNPC == NPC_039) { NPC_AI.sAvailableWeapons039 = NPC_AI.sTempWeapons; iLoyalty039 = iTempLoyalty; }
            if (tempNPC == NPC_040) { NPC_AI.sAvailableWeapons040 = NPC_AI.sTempWeapons; iLoyalty040 = iTempLoyalty; }
            if (tempNPC == NPC_041) { NPC_AI.sAvailableWeapons041 = NPC_AI.sTempWeapons; iLoyalty041 = iTempLoyalty; }
            if (tempNPC == NPC_042) { NPC_AI.sAvailableWeapons042 = NPC_AI.sTempWeapons; iLoyalty042 = iTempLoyalty; }
            if (tempNPC == NPC_043) { NPC_AI.sAvailableWeapons043 = NPC_AI.sTempWeapons; iLoyalty043 = iTempLoyalty; }
            if (tempNPC == NPC_044) { NPC_AI.sAvailableWeapons044 = NPC_AI.sTempWeapons; iLoyalty044 = iTempLoyalty; }
            if (tempNPC == NPC_045) { NPC_AI.sAvailableWeapons045 = NPC_AI.sTempWeapons; iLoyalty045 = iTempLoyalty; }
            if (tempNPC == NPC_046) { NPC_AI.sAvailableWeapons046 = NPC_AI.sTempWeapons; iLoyalty046 = iTempLoyalty; }
            if (tempNPC == NPC_047) { NPC_AI.sAvailableWeapons047 = NPC_AI.sTempWeapons; iLoyalty047 = iTempLoyalty; }
            if (tempNPC == NPC_048) { NPC_AI.sAvailableWeapons048 = NPC_AI.sTempWeapons; iLoyalty048 = iTempLoyalty; }
            if (tempNPC == NPC_049) { NPC_AI.sAvailableWeapons049 = NPC_AI.sTempWeapons; iLoyalty049 = iTempLoyalty; }
            if (tempNPC == NPC_050) { NPC_AI.sAvailableWeapons050 = NPC_AI.sTempWeapons; iLoyalty050 = iTempLoyalty; }
            if (tempNPC == NPC_051) { NPC_AI.sAvailableWeapons051 = NPC_AI.sTempWeapons; iLoyalty051 = iTempLoyalty; }
            if (tempNPC == NPC_052) { NPC_AI.sAvailableWeapons052 = NPC_AI.sTempWeapons; iLoyalty052 = iTempLoyalty; }
            if (tempNPC == NPC_053) { NPC_AI.sAvailableWeapons053 = NPC_AI.sTempWeapons; iLoyalty053 = iTempLoyalty; }
            if (tempNPC == NPC_054) { NPC_AI.sAvailableWeapons054 = NPC_AI.sTempWeapons; iLoyalty054 = iTempLoyalty; }
            if (tempNPC == NPC_055) { NPC_AI.sAvailableWeapons055 = NPC_AI.sTempWeapons; iLoyalty055 = iTempLoyalty; }
            if (tempNPC == NPC_056) { NPC_AI.sAvailableWeapons056 = NPC_AI.sTempWeapons; iLoyalty056 = iTempLoyalty; }
            if (tempNPC == NPC_057) { NPC_AI.sAvailableWeapons057 = NPC_AI.sTempWeapons; iLoyalty057 = iTempLoyalty; }
            if (tempNPC == NPC_058) { NPC_AI.sAvailableWeapons058 = NPC_AI.sTempWeapons; iLoyalty058 = iTempLoyalty; }
            if (tempNPC == NPC_059) { NPC_AI.sAvailableWeapons059 = NPC_AI.sTempWeapons; iLoyalty059 = iTempLoyalty; }
            if (tempNPC == NPC_060) { NPC_AI.sAvailableWeapons060 = NPC_AI.sTempWeapons; iLoyalty060 = iTempLoyalty; }
            if (tempNPC == NPC_061) { NPC_AI.sAvailableWeapons061 = NPC_AI.sTempWeapons; iLoyalty061 = iTempLoyalty; }
            if (tempNPC == NPC_062) { NPC_AI.sAvailableWeapons062 = NPC_AI.sTempWeapons; iLoyalty062 = iTempLoyalty; }
            if (tempNPC == NPC_063) { NPC_AI.sAvailableWeapons063 = NPC_AI.sTempWeapons; iLoyalty063 = iTempLoyalty; }
            if (tempNPC == NPC_064) { NPC_AI.sAvailableWeapons064 = NPC_AI.sTempWeapons; iLoyalty064 = iTempLoyalty; }
            if (tempNPC == NPC_065) { NPC_AI.sAvailableWeapons065 = NPC_AI.sTempWeapons; iLoyalty065 = iTempLoyalty; }
            if (tempNPC == NPC_066) { NPC_AI.sAvailableWeapons066 = NPC_AI.sTempWeapons; iLoyalty066 = iTempLoyalty; }
            if (tempNPC == NPC_067) { NPC_AI.sAvailableWeapons067 = NPC_AI.sTempWeapons; iLoyalty067 = iTempLoyalty; }
            if (tempNPC == NPC_068) { NPC_AI.sAvailableWeapons068 = NPC_AI.sTempWeapons; iLoyalty068 = iTempLoyalty; }
            if (tempNPC == NPC_069) { NPC_AI.sAvailableWeapons069 = NPC_AI.sTempWeapons; iLoyalty069 = iTempLoyalty; }
            if (tempNPC == NPC_070) { NPC_AI.sAvailableWeapons070 = NPC_AI.sTempWeapons; iLoyalty070 = iTempLoyalty; }
            if (tempNPC == NPC_071) { NPC_AI.sAvailableWeapons071 = NPC_AI.sTempWeapons; iLoyalty071 = iTempLoyalty; }
            if (tempNPC == NPC_072) { NPC_AI.sAvailableWeapons072 = NPC_AI.sTempWeapons; iLoyalty072 = iTempLoyalty; }
            if (tempNPC == NPC_073) { NPC_AI.sAvailableWeapons073 = NPC_AI.sTempWeapons; iLoyalty073 = iTempLoyalty; }
            if (tempNPC == NPC_074) { NPC_AI.sAvailableWeapons074 = NPC_AI.sTempWeapons; iLoyalty074 = iTempLoyalty; }
            if (tempNPC == NPC_075) { NPC_AI.sAvailableWeapons075 = NPC_AI.sTempWeapons; iLoyalty075 = iTempLoyalty; }
            if (tempNPC == NPC_076) { NPC_AI.sAvailableWeapons076 = NPC_AI.sTempWeapons; iLoyalty076 = iTempLoyalty; }
            if (tempNPC == NPC_077) { NPC_AI.sAvailableWeapons077 = NPC_AI.sTempWeapons; iLoyalty077 = iTempLoyalty; }
            if (tempNPC == NPC_078) { NPC_AI.sAvailableWeapons078 = NPC_AI.sTempWeapons; iLoyalty078 = iTempLoyalty; }
            if (tempNPC == NPC_079) { NPC_AI.sAvailableWeapons079 = NPC_AI.sTempWeapons; iLoyalty079 = iTempLoyalty; }
            if (tempNPC == NPC_080) { NPC_AI.sAvailableWeapons080 = NPC_AI.sTempWeapons; iLoyalty080 = iTempLoyalty; }
            if (tempNPC == NPC_081) { NPC_AI.sAvailableWeapons081 = NPC_AI.sTempWeapons; iLoyalty081 = iTempLoyalty; }
            if (tempNPC == NPC_082) { NPC_AI.sAvailableWeapons082 = NPC_AI.sTempWeapons; iLoyalty082 = iTempLoyalty; }
            if (tempNPC == NPC_083) { NPC_AI.sAvailableWeapons083 = NPC_AI.sTempWeapons; iLoyalty083 = iTempLoyalty; }
            if (tempNPC == NPC_084) { NPC_AI.sAvailableWeapons084 = NPC_AI.sTempWeapons; iLoyalty084 = iTempLoyalty; }
            if (tempNPC == NPC_085) { NPC_AI.sAvailableWeapons085 = NPC_AI.sTempWeapons; iLoyalty085 = iTempLoyalty; }
            if (tempNPC == NPC_086) { NPC_AI.sAvailableWeapons086 = NPC_AI.sTempWeapons; iLoyalty086 = iTempLoyalty; }
            if (tempNPC == NPC_087) { NPC_AI.sAvailableWeapons087 = NPC_AI.sTempWeapons; iLoyalty087 = iTempLoyalty; }
            if (tempNPC == NPC_088) { NPC_AI.sAvailableWeapons088 = NPC_AI.sTempWeapons; iLoyalty088 = iTempLoyalty; }
            if (tempNPC == NPC_089) { NPC_AI.sAvailableWeapons089 = NPC_AI.sTempWeapons; iLoyalty089 = iTempLoyalty; }
            if (tempNPC == NPC_090) { NPC_AI.sAvailableWeapons090 = NPC_AI.sTempWeapons; iLoyalty090 = iTempLoyalty; }
            if (tempNPC == NPC_091) { NPC_AI.sAvailableWeapons091 = NPC_AI.sTempWeapons; iLoyalty091 = iTempLoyalty; }
            if (tempNPC == NPC_092) { NPC_AI.sAvailableWeapons092 = NPC_AI.sTempWeapons; iLoyalty092 = iTempLoyalty; }
            if (tempNPC == NPC_093) { NPC_AI.sAvailableWeapons093 = NPC_AI.sTempWeapons; iLoyalty093 = iTempLoyalty; }
            if (tempNPC == NPC_094) { NPC_AI.sAvailableWeapons094 = NPC_AI.sTempWeapons; iLoyalty094 = iTempLoyalty; }
            if (tempNPC == NPC_095) { NPC_AI.sAvailableWeapons095 = NPC_AI.sTempWeapons; iLoyalty095 = iTempLoyalty; }
            if (tempNPC == NPC_096) { NPC_AI.sAvailableWeapons096 = NPC_AI.sTempWeapons; iLoyalty096 = iTempLoyalty; }
            if (tempNPC == NPC_097) { NPC_AI.sAvailableWeapons097 = NPC_AI.sTempWeapons; iLoyalty097 = iTempLoyalty; }
            if (tempNPC == NPC_098) { NPC_AI.sAvailableWeapons098 = NPC_AI.sTempWeapons; iLoyalty098 = iTempLoyalty; }
            if (tempNPC == NPC_099) { NPC_AI.sAvailableWeapons099 = NPC_AI.sTempWeapons; iLoyalty099 = iTempLoyalty; }
            if (tempNPC == NPC_100) { NPC_AI.sAvailableWeapons100 = NPC_AI.sTempWeapons; iLoyalty100 = iTempLoyalty; }
        }

        public static void GetAllNPCLocals_AskTrait()
        {
            if (tempNPC == NPC_001) { iTempLoyalty = iLoyalty001; }
            if (tempNPC == NPC_002) { iTempLoyalty = iLoyalty002; }
            if (tempNPC == NPC_003) { iTempLoyalty = iLoyalty003; }
            if (tempNPC == NPC_004) { iTempLoyalty = iLoyalty004; }
            if (tempNPC == NPC_005) { iTempLoyalty = iLoyalty005; }
            if (tempNPC == NPC_006) { iTempLoyalty = iLoyalty006; }
            if (tempNPC == NPC_007) { iTempLoyalty = iLoyalty007; }
            if (tempNPC == NPC_008) { iTempLoyalty = iLoyalty008; }
            if (tempNPC == NPC_009) { iTempLoyalty = iLoyalty009; }
            if (tempNPC == NPC_010) { iTempLoyalty = iLoyalty020; }
            if (tempNPC == NPC_011) { iTempLoyalty = iLoyalty011; }
            if (tempNPC == NPC_012) { iTempLoyalty = iLoyalty012; }
            if (tempNPC == NPC_013) { iTempLoyalty = iLoyalty013; }
            if (tempNPC == NPC_014) { iTempLoyalty = iLoyalty014; }
            if (tempNPC == NPC_015) { iTempLoyalty = iLoyalty015; }
            if (tempNPC == NPC_016) { iTempLoyalty = iLoyalty016; }
            if (tempNPC == NPC_017) { iTempLoyalty = iLoyalty017; }
            if (tempNPC == NPC_018) { iTempLoyalty = iLoyalty018; }
            if (tempNPC == NPC_019) { iTempLoyalty = iLoyalty019; }
            if (tempNPC == NPC_020) { iTempLoyalty = iLoyalty020; }
            if (tempNPC == NPC_021) { iTempLoyalty = iLoyalty021; }
            if (tempNPC == NPC_022) { iTempLoyalty = iLoyalty022; }
            if (tempNPC == NPC_023) { iTempLoyalty = iLoyalty023; }
            if (tempNPC == NPC_024) { iTempLoyalty = iLoyalty024; }
            if (tempNPC == NPC_025) { iTempLoyalty = iLoyalty025; }
            if (tempNPC == NPC_026) { iTempLoyalty = iLoyalty026; }
            if (tempNPC == NPC_027) { iTempLoyalty = iLoyalty027; }
            if (tempNPC == NPC_028) { iTempLoyalty = iLoyalty028; }
            if (tempNPC == NPC_029) { iTempLoyalty = iLoyalty029; }
            if (tempNPC == NPC_030) { iTempLoyalty = iLoyalty030; }
            if (tempNPC == NPC_031) { iTempLoyalty = iLoyalty031; }
            if (tempNPC == NPC_032) { iTempLoyalty = iLoyalty032; }
            if (tempNPC == NPC_033) { iTempLoyalty = iLoyalty033; }
            if (tempNPC == NPC_034) { iTempLoyalty = iLoyalty034; }
            if (tempNPC == NPC_035) { iTempLoyalty = iLoyalty035; }
            if (tempNPC == NPC_036) { iTempLoyalty = iLoyalty036; }
            if (tempNPC == NPC_037) { iTempLoyalty = iLoyalty037; }
            if (tempNPC == NPC_038) { iTempLoyalty = iLoyalty038; }
            if (tempNPC == NPC_039) { iTempLoyalty = iLoyalty039; }
            if (tempNPC == NPC_040) { iTempLoyalty = iLoyalty040; }
            if (tempNPC == NPC_041) { iTempLoyalty = iLoyalty041; }
            if (tempNPC == NPC_042) { iTempLoyalty = iLoyalty042; }
            if (tempNPC == NPC_043) { iTempLoyalty = iLoyalty043; }
            if (tempNPC == NPC_044) { iTempLoyalty = iLoyalty044; }
            if (tempNPC == NPC_045) { iTempLoyalty = iLoyalty045; }
            if (tempNPC == NPC_046) { iTempLoyalty = iLoyalty046; }
            if (tempNPC == NPC_047) { iTempLoyalty = iLoyalty047; }
            if (tempNPC == NPC_048) { iTempLoyalty = iLoyalty048; }
            if (tempNPC == NPC_049) { iTempLoyalty = iLoyalty049; }
            if (tempNPC == NPC_050) { iTempLoyalty = iLoyalty050; }
            if (tempNPC == NPC_051) { iTempLoyalty = iLoyalty051; }
            if (tempNPC == NPC_052) { iTempLoyalty = iLoyalty052; }
            if (tempNPC == NPC_053) { iTempLoyalty = iLoyalty053; }
            if (tempNPC == NPC_054) { iTempLoyalty = iLoyalty054; }
            if (tempNPC == NPC_055) { iTempLoyalty = iLoyalty055; }
            if (tempNPC == NPC_056) { iTempLoyalty = iLoyalty056; }
            if (tempNPC == NPC_057) { iTempLoyalty = iLoyalty057; }
            if (tempNPC == NPC_058) { iTempLoyalty = iLoyalty058; }
            if (tempNPC == NPC_059) { iTempLoyalty = iLoyalty059; }
            if (tempNPC == NPC_060) { iTempLoyalty = iLoyalty060; }
            if (tempNPC == NPC_061) { iTempLoyalty = iLoyalty061; }
            if (tempNPC == NPC_062) { iTempLoyalty = iLoyalty062; }
            if (tempNPC == NPC_063) { iTempLoyalty = iLoyalty063; }
            if (tempNPC == NPC_064) { iTempLoyalty = iLoyalty064; }
            if (tempNPC == NPC_065) { iTempLoyalty = iLoyalty065; }
            if (tempNPC == NPC_066) { iTempLoyalty = iLoyalty066; }
            if (tempNPC == NPC_067) { iTempLoyalty = iLoyalty067; }
            if (tempNPC == NPC_068) { iTempLoyalty = iLoyalty068; }
            if (tempNPC == NPC_069) { iTempLoyalty = iLoyalty069; }
            if (tempNPC == NPC_070) { iTempLoyalty = iLoyalty070; }
            if (tempNPC == NPC_071) { iTempLoyalty = iLoyalty071; }
            if (tempNPC == NPC_072) { iTempLoyalty = iLoyalty072; }
            if (tempNPC == NPC_073) { iTempLoyalty = iLoyalty073; }
            if (tempNPC == NPC_074) { iTempLoyalty = iLoyalty074; }
            if (tempNPC == NPC_075) { iTempLoyalty = iLoyalty075; }
            if (tempNPC == NPC_076) { iTempLoyalty = iLoyalty076; }
            if (tempNPC == NPC_077) { iTempLoyalty = iLoyalty077; }
            if (tempNPC == NPC_078) { iTempLoyalty = iLoyalty078; }
            if (tempNPC == NPC_079) { iTempLoyalty = iLoyalty079; }
            if (tempNPC == NPC_080) { iTempLoyalty = iLoyalty080; }
            if (tempNPC == NPC_081) { iTempLoyalty = iLoyalty081; }
            if (tempNPC == NPC_082) { iTempLoyalty = iLoyalty082; }
            if (tempNPC == NPC_083) { iTempLoyalty = iLoyalty083; }
            if (tempNPC == NPC_084) { iTempLoyalty = iLoyalty084; }
            if (tempNPC == NPC_085) { iTempLoyalty = iLoyalty085; }
            if (tempNPC == NPC_086) { iTempLoyalty = iLoyalty086; }
            if (tempNPC == NPC_087) { iTempLoyalty = iLoyalty087; }
            if (tempNPC == NPC_088) { iTempLoyalty = iLoyalty088; }
            if (tempNPC == NPC_089) { iTempLoyalty = iLoyalty089; }
            if (tempNPC == NPC_090) { iTempLoyalty = iLoyalty090; }
            if (tempNPC == NPC_091) { iTempLoyalty = iLoyalty091; }
            if (tempNPC == NPC_092) { iTempLoyalty = iLoyalty092; }
            if (tempNPC == NPC_093) { iTempLoyalty = iLoyalty093; }
            if (tempNPC == NPC_094) { iTempLoyalty = iLoyalty094; }
            if (tempNPC == NPC_095) { iTempLoyalty = iLoyalty095; }
            if (tempNPC == NPC_096) { iTempLoyalty = iLoyalty096; }
            if (tempNPC == NPC_097) { iTempLoyalty = iLoyalty097; }
            if (tempNPC == NPC_098) { iTempLoyalty = iLoyalty098; }
            if (tempNPC == NPC_099) { iTempLoyalty = iLoyalty099; }
            if (tempNPC == NPC_100) { iTempLoyalty = iLoyalty100; }
        }

        public static void SetAllNPCLocals_AskTrait()
        {
            if (tempNPC == NPC_001) { iLoyalty001 = iTempLoyalty; }
            if (tempNPC == NPC_002) { iLoyalty002 = iTempLoyalty; }
            if (tempNPC == NPC_003) { iLoyalty003 = iTempLoyalty; }
            if (tempNPC == NPC_004) { iLoyalty004 = iTempLoyalty; }
            if (tempNPC == NPC_005) { iLoyalty005 = iTempLoyalty; }
            if (tempNPC == NPC_006) { iLoyalty006 = iTempLoyalty; }
            if (tempNPC == NPC_007) { iLoyalty007 = iTempLoyalty; }
            if (tempNPC == NPC_008) { iLoyalty008 = iTempLoyalty; }
            if (tempNPC == NPC_009) { iLoyalty009 = iTempLoyalty; }
            if (tempNPC == NPC_010) { iLoyalty020 = iTempLoyalty; }
            if (tempNPC == NPC_011) { iLoyalty011 = iTempLoyalty; }
            if (tempNPC == NPC_012) { iLoyalty012 = iTempLoyalty; }
            if (tempNPC == NPC_013) { iLoyalty013 = iTempLoyalty; }
            if (tempNPC == NPC_014) { iLoyalty014 = iTempLoyalty; }
            if (tempNPC == NPC_015) { iLoyalty015 = iTempLoyalty; }
            if (tempNPC == NPC_016) { iLoyalty016 = iTempLoyalty; }
            if (tempNPC == NPC_017) { iLoyalty017 = iTempLoyalty; }
            if (tempNPC == NPC_018) { iLoyalty018 = iTempLoyalty; }
            if (tempNPC == NPC_019) { iLoyalty019 = iTempLoyalty; }
            if (tempNPC == NPC_020) { iLoyalty020 = iTempLoyalty; }
            if (tempNPC == NPC_021) { iLoyalty021 = iTempLoyalty; }
            if (tempNPC == NPC_022) { iLoyalty022 = iTempLoyalty; }
            if (tempNPC == NPC_023) { iLoyalty023 = iTempLoyalty; }
            if (tempNPC == NPC_024) { iLoyalty024 = iTempLoyalty; }
            if (tempNPC == NPC_025) { iLoyalty025 = iTempLoyalty; }
            if (tempNPC == NPC_026) { iLoyalty026 = iTempLoyalty; }
            if (tempNPC == NPC_027) { iLoyalty027 = iTempLoyalty; }
            if (tempNPC == NPC_028) { iLoyalty028 = iTempLoyalty; }
            if (tempNPC == NPC_029) { iLoyalty029 = iTempLoyalty; }
            if (tempNPC == NPC_030) { iLoyalty030 = iTempLoyalty; }
            if (tempNPC == NPC_031) { iLoyalty031 = iTempLoyalty; }
            if (tempNPC == NPC_032) { iLoyalty032 = iTempLoyalty; }
            if (tempNPC == NPC_033) { iLoyalty033 = iTempLoyalty; }
            if (tempNPC == NPC_034) { iLoyalty034 = iTempLoyalty; }
            if (tempNPC == NPC_035) { iLoyalty035 = iTempLoyalty; }
            if (tempNPC == NPC_036) { iLoyalty036 = iTempLoyalty; }
            if (tempNPC == NPC_037) { iLoyalty037 = iTempLoyalty; }
            if (tempNPC == NPC_038) { iLoyalty038 = iTempLoyalty; }
            if (tempNPC == NPC_039) { iLoyalty039 = iTempLoyalty; }
            if (tempNPC == NPC_040) { iLoyalty040 = iTempLoyalty; }
            if (tempNPC == NPC_041) { iLoyalty041 = iTempLoyalty; }
            if (tempNPC == NPC_042) { iLoyalty042 = iTempLoyalty; }
            if (tempNPC == NPC_043) { iLoyalty043 = iTempLoyalty; }
            if (tempNPC == NPC_044) { iLoyalty044 = iTempLoyalty; }
            if (tempNPC == NPC_045) { iLoyalty045 = iTempLoyalty; }
            if (tempNPC == NPC_046) { iLoyalty046 = iTempLoyalty; }
            if (tempNPC == NPC_047) { iLoyalty047 = iTempLoyalty; }
            if (tempNPC == NPC_048) { iLoyalty048 = iTempLoyalty; }
            if (tempNPC == NPC_049) { iLoyalty049 = iTempLoyalty; }
            if (tempNPC == NPC_050) { iLoyalty050 = iTempLoyalty; }
            if (tempNPC == NPC_051) { iLoyalty051 = iTempLoyalty; }
            if (tempNPC == NPC_052) { iLoyalty052 = iTempLoyalty; }
            if (tempNPC == NPC_053) { iLoyalty053 = iTempLoyalty; }
            if (tempNPC == NPC_054) { iLoyalty054 = iTempLoyalty; }
            if (tempNPC == NPC_055) { iLoyalty055 = iTempLoyalty; }
            if (tempNPC == NPC_056) { iLoyalty056 = iTempLoyalty; }
            if (tempNPC == NPC_057) { iLoyalty057 = iTempLoyalty; }
            if (tempNPC == NPC_058) { iLoyalty058 = iTempLoyalty; }
            if (tempNPC == NPC_059) { iLoyalty059 = iTempLoyalty; }
            if (tempNPC == NPC_060) { iLoyalty060 = iTempLoyalty; }
            if (tempNPC == NPC_061) { iLoyalty061 = iTempLoyalty; }
            if (tempNPC == NPC_062) { iLoyalty062 = iTempLoyalty; }
            if (tempNPC == NPC_063) { iLoyalty063 = iTempLoyalty; }
            if (tempNPC == NPC_064) { iLoyalty064 = iTempLoyalty; }
            if (tempNPC == NPC_065) { iLoyalty065 = iTempLoyalty; }
            if (tempNPC == NPC_066) { iLoyalty066 = iTempLoyalty; }
            if (tempNPC == NPC_067) { iLoyalty067 = iTempLoyalty; }
            if (tempNPC == NPC_068) { iLoyalty068 = iTempLoyalty; }
            if (tempNPC == NPC_069) { iLoyalty069 = iTempLoyalty; }
            if (tempNPC == NPC_070) { iLoyalty070 = iTempLoyalty; }
            if (tempNPC == NPC_071) { iLoyalty071 = iTempLoyalty; }
            if (tempNPC == NPC_072) { iLoyalty072 = iTempLoyalty; }
            if (tempNPC == NPC_073) { iLoyalty073 = iTempLoyalty; }
            if (tempNPC == NPC_074) { iLoyalty074 = iTempLoyalty; }
            if (tempNPC == NPC_075) { iLoyalty075 = iTempLoyalty; }
            if (tempNPC == NPC_076) { iLoyalty076 = iTempLoyalty; }
            if (tempNPC == NPC_077) { iLoyalty077 = iTempLoyalty; }
            if (tempNPC == NPC_078) { iLoyalty078 = iTempLoyalty; }
            if (tempNPC == NPC_079) { iLoyalty079 = iTempLoyalty; }
            if (tempNPC == NPC_080) { iLoyalty080 = iTempLoyalty; }
            if (tempNPC == NPC_081) { iLoyalty081 = iTempLoyalty; }
            if (tempNPC == NPC_082) { iLoyalty082 = iTempLoyalty; }
            if (tempNPC == NPC_083) { iLoyalty083 = iTempLoyalty; }
            if (tempNPC == NPC_084) { iLoyalty084 = iTempLoyalty; }
            if (tempNPC == NPC_085) { iLoyalty085 = iTempLoyalty; }
            if (tempNPC == NPC_086) { iLoyalty086 = iTempLoyalty; }
            if (tempNPC == NPC_087) { iLoyalty087 = iTempLoyalty; }
            if (tempNPC == NPC_088) { iLoyalty088 = iTempLoyalty; }
            if (tempNPC == NPC_089) { iLoyalty089 = iTempLoyalty; }
            if (tempNPC == NPC_090) { iLoyalty090 = iTempLoyalty; }
            if (tempNPC == NPC_091) { iLoyalty091 = iTempLoyalty; }
            if (tempNPC == NPC_092) { iLoyalty092 = iTempLoyalty; }
            if (tempNPC == NPC_093) { iLoyalty093 = iTempLoyalty; }
            if (tempNPC == NPC_094) { iLoyalty094 = iTempLoyalty; }
            if (tempNPC == NPC_095) { iLoyalty095 = iTempLoyalty; }
            if (tempNPC == NPC_096) { iLoyalty096 = iTempLoyalty; }
            if (tempNPC == NPC_097) { iLoyalty097 = iTempLoyalty; }
            if (tempNPC == NPC_098) { iLoyalty098 = iTempLoyalty; }
            if (tempNPC == NPC_099) { iLoyalty099 = iTempLoyalty; }
            if (tempNPC == NPC_100) { iLoyalty100 = iTempLoyalty; }
        }

        public static void GetAllNPCLocals_WaitSomewhere()
        {
            if (tempNPC == NPC_001) { iTempLocation = NPC001_CurrentNumLocation; iTempLastLocation = NPC001_LastLocation; sTempLastLocation = NPC001_LastStrLocation; sTempCurrentLocation = NPC001_CurrentStrLocation; iTempLoyalty = iLoyalty001; Flood.bPutInDanger = Flood.bPutInDanger001; }
            if (tempNPC == NPC_002) { iTempLocation = NPC002_CurrentNumLocation; iTempLastLocation = NPC002_LastLocation; sTempLastLocation = NPC002_LastStrLocation; sTempCurrentLocation = NPC002_CurrentStrLocation; iTempLoyalty = iLoyalty002; Flood.bPutInDanger = Flood.bPutInDanger002; }
            if (tempNPC == NPC_003) { iTempLocation = NPC003_CurrentNumLocation; iTempLastLocation = NPC003_LastLocation; sTempLastLocation = NPC003_LastStrLocation; sTempCurrentLocation = NPC003_CurrentStrLocation; iTempLoyalty = iLoyalty003; Flood.bPutInDanger = Flood.bPutInDanger003; }
            if (tempNPC == NPC_004) { iTempLocation = NPC004_CurrentNumLocation; iTempLastLocation = NPC004_LastLocation; sTempLastLocation = NPC004_LastStrLocation; sTempCurrentLocation = NPC004_CurrentStrLocation; iTempLoyalty = iLoyalty004; Flood.bPutInDanger = Flood.bPutInDanger004; }
            if (tempNPC == NPC_005) { iTempLocation = NPC005_CurrentNumLocation; iTempLastLocation = NPC005_LastLocation; sTempLastLocation = NPC005_LastStrLocation; sTempCurrentLocation = NPC005_CurrentStrLocation; iTempLoyalty = iLoyalty005; Flood.bPutInDanger = Flood.bPutInDanger005; }
            if (tempNPC == NPC_006) { iTempLocation = NPC006_CurrentNumLocation; iTempLastLocation = NPC006_LastLocation; sTempLastLocation = NPC006_LastStrLocation; sTempCurrentLocation = NPC006_CurrentStrLocation; iTempLoyalty = iLoyalty006; Flood.bPutInDanger = Flood.bPutInDanger006; }
            if (tempNPC == NPC_007) { iTempLocation = NPC007_CurrentNumLocation; iTempLastLocation = NPC007_LastLocation; sTempLastLocation = NPC007_LastStrLocation; sTempCurrentLocation = NPC007_CurrentStrLocation; iTempLoyalty = iLoyalty007; Flood.bPutInDanger = Flood.bPutInDanger007; }
            if (tempNPC == NPC_008) { iTempLocation = NPC008_CurrentNumLocation; iTempLastLocation = NPC008_LastLocation; sTempLastLocation = NPC008_LastStrLocation; sTempCurrentLocation = NPC008_CurrentStrLocation; iTempLoyalty = iLoyalty008; Flood.bPutInDanger = Flood.bPutInDanger008; }
            if (tempNPC == NPC_009) { iTempLocation = NPC009_CurrentNumLocation; iTempLastLocation = NPC009_LastLocation; sTempLastLocation = NPC009_LastStrLocation; sTempCurrentLocation = NPC009_CurrentStrLocation; iTempLoyalty = iLoyalty009; Flood.bPutInDanger = Flood.bPutInDanger009; }
            if (tempNPC == NPC_010) { iTempLocation = NPC010_CurrentNumLocation; iTempLastLocation = NPC010_LastLocation; sTempLastLocation = NPC010_LastStrLocation; sTempCurrentLocation = NPC010_CurrentStrLocation; iTempLoyalty = iLoyalty010; Flood.bPutInDanger = Flood.bPutInDanger010; }
            if (tempNPC == NPC_011) { iTempLocation = NPC011_CurrentNumLocation; iTempLastLocation = NPC011_LastLocation; sTempLastLocation = NPC011_LastStrLocation; sTempCurrentLocation = NPC011_CurrentStrLocation; iTempLoyalty = iLoyalty011; Flood.bPutInDanger = Flood.bPutInDanger011; }
            if (tempNPC == NPC_012) { iTempLocation = NPC012_CurrentNumLocation; iTempLastLocation = NPC012_LastLocation; sTempLastLocation = NPC012_LastStrLocation; sTempCurrentLocation = NPC012_CurrentStrLocation; iTempLoyalty = iLoyalty012; Flood.bPutInDanger = Flood.bPutInDanger012; }
            if (tempNPC == NPC_013) { iTempLocation = NPC013_CurrentNumLocation; iTempLastLocation = NPC013_LastLocation; sTempLastLocation = NPC013_LastStrLocation; sTempCurrentLocation = NPC013_CurrentStrLocation; iTempLoyalty = iLoyalty013; Flood.bPutInDanger = Flood.bPutInDanger013; }
            if (tempNPC == NPC_014) { iTempLocation = NPC014_CurrentNumLocation; iTempLastLocation = NPC014_LastLocation; sTempLastLocation = NPC014_LastStrLocation; sTempCurrentLocation = NPC014_CurrentStrLocation; iTempLoyalty = iLoyalty014; Flood.bPutInDanger = Flood.bPutInDanger014; }
            if (tempNPC == NPC_015) { iTempLocation = NPC015_CurrentNumLocation; iTempLastLocation = NPC015_LastLocation; sTempLastLocation = NPC015_LastStrLocation; sTempCurrentLocation = NPC015_CurrentStrLocation; iTempLoyalty = iLoyalty015; Flood.bPutInDanger = Flood.bPutInDanger015; }
            if (tempNPC == NPC_016) { iTempLocation = NPC016_CurrentNumLocation; iTempLastLocation = NPC016_LastLocation; sTempLastLocation = NPC016_LastStrLocation; sTempCurrentLocation = NPC016_CurrentStrLocation; iTempLoyalty = iLoyalty016; Flood.bPutInDanger = Flood.bPutInDanger016; }
            if (tempNPC == NPC_017) { iTempLocation = NPC017_CurrentNumLocation; iTempLastLocation = NPC017_LastLocation; sTempLastLocation = NPC017_LastStrLocation; sTempCurrentLocation = NPC017_CurrentStrLocation; iTempLoyalty = iLoyalty017; Flood.bPutInDanger = Flood.bPutInDanger017; }
            if (tempNPC == NPC_018) { iTempLocation = NPC018_CurrentNumLocation; iTempLastLocation = NPC018_LastLocation; sTempLastLocation = NPC018_LastStrLocation; sTempCurrentLocation = NPC018_CurrentStrLocation; iTempLoyalty = iLoyalty018; Flood.bPutInDanger = Flood.bPutInDanger018; }
            if (tempNPC == NPC_019) { iTempLocation = NPC019_CurrentNumLocation; iTempLastLocation = NPC019_LastLocation; sTempLastLocation = NPC019_LastStrLocation; sTempCurrentLocation = NPC019_CurrentStrLocation; iTempLoyalty = iLoyalty019; Flood.bPutInDanger = Flood.bPutInDanger019; }
            if (tempNPC == NPC_020) { iTempLocation = NPC020_CurrentNumLocation; iTempLastLocation = NPC020_LastLocation; sTempLastLocation = NPC020_LastStrLocation; sTempCurrentLocation = NPC020_CurrentStrLocation; iTempLoyalty = iLoyalty020; Flood.bPutInDanger = Flood.bPutInDanger020; }
            if (tempNPC == NPC_021) { iTempLocation = NPC021_CurrentNumLocation; iTempLastLocation = NPC021_LastLocation; sTempLastLocation = NPC021_LastStrLocation; sTempCurrentLocation = NPC021_CurrentStrLocation; iTempLoyalty = iLoyalty021; Flood.bPutInDanger = Flood.bPutInDanger021; }
            if (tempNPC == NPC_022) { iTempLocation = NPC022_CurrentNumLocation; iTempLastLocation = NPC022_LastLocation; sTempLastLocation = NPC022_LastStrLocation; sTempCurrentLocation = NPC022_CurrentStrLocation; iTempLoyalty = iLoyalty022; Flood.bPutInDanger = Flood.bPutInDanger022; }
            if (tempNPC == NPC_023) { iTempLocation = NPC023_CurrentNumLocation; iTempLastLocation = NPC023_LastLocation; sTempLastLocation = NPC023_LastStrLocation; sTempCurrentLocation = NPC023_CurrentStrLocation; iTempLoyalty = iLoyalty023; Flood.bPutInDanger = Flood.bPutInDanger023; }
            if (tempNPC == NPC_024) { iTempLocation = NPC024_CurrentNumLocation; iTempLastLocation = NPC024_LastLocation; sTempLastLocation = NPC024_LastStrLocation; sTempCurrentLocation = NPC024_CurrentStrLocation; iTempLoyalty = iLoyalty024; Flood.bPutInDanger = Flood.bPutInDanger024; }
            if (tempNPC == NPC_025) { iTempLocation = NPC025_CurrentNumLocation; iTempLastLocation = NPC025_LastLocation; sTempLastLocation = NPC025_LastStrLocation; sTempCurrentLocation = NPC025_CurrentStrLocation; iTempLoyalty = iLoyalty025; Flood.bPutInDanger = Flood.bPutInDanger025; }
            if (tempNPC == NPC_026) { iTempLocation = NPC026_CurrentNumLocation; iTempLastLocation = NPC026_LastLocation; sTempLastLocation = NPC026_LastStrLocation; sTempCurrentLocation = NPC026_CurrentStrLocation; iTempLoyalty = iLoyalty026; Flood.bPutInDanger = Flood.bPutInDanger026; }
            if (tempNPC == NPC_027) { iTempLocation = NPC027_CurrentNumLocation; iTempLastLocation = NPC027_LastLocation; sTempLastLocation = NPC027_LastStrLocation; sTempCurrentLocation = NPC027_CurrentStrLocation; iTempLoyalty = iLoyalty027; Flood.bPutInDanger = Flood.bPutInDanger027; }
            if (tempNPC == NPC_028) { iTempLocation = NPC028_CurrentNumLocation; iTempLastLocation = NPC028_LastLocation; sTempLastLocation = NPC028_LastStrLocation; sTempCurrentLocation = NPC028_CurrentStrLocation; iTempLoyalty = iLoyalty028; Flood.bPutInDanger = Flood.bPutInDanger028; }
            if (tempNPC == NPC_029) { iTempLocation = NPC029_CurrentNumLocation; iTempLastLocation = NPC029_LastLocation; sTempLastLocation = NPC029_LastStrLocation; sTempCurrentLocation = NPC029_CurrentStrLocation; iTempLoyalty = iLoyalty029; Flood.bPutInDanger = Flood.bPutInDanger029; }
            if (tempNPC == NPC_030) { iTempLocation = NPC030_CurrentNumLocation; iTempLastLocation = NPC030_LastLocation; sTempLastLocation = NPC030_LastStrLocation; sTempCurrentLocation = NPC030_CurrentStrLocation; iTempLoyalty = iLoyalty030; Flood.bPutInDanger = Flood.bPutInDanger030; }
            if (tempNPC == NPC_031) { iTempLocation = NPC031_CurrentNumLocation; iTempLastLocation = NPC031_LastLocation; sTempLastLocation = NPC031_LastStrLocation; sTempCurrentLocation = NPC031_CurrentStrLocation; iTempLoyalty = iLoyalty031; Flood.bPutInDanger = Flood.bPutInDanger031; }
            if (tempNPC == NPC_032) { iTempLocation = NPC032_CurrentNumLocation; iTempLastLocation = NPC032_LastLocation; sTempLastLocation = NPC032_LastStrLocation; sTempCurrentLocation = NPC032_CurrentStrLocation; iTempLoyalty = iLoyalty032; Flood.bPutInDanger = Flood.bPutInDanger032; }
            if (tempNPC == NPC_033) { iTempLocation = NPC033_CurrentNumLocation; iTempLastLocation = NPC033_LastLocation; sTempLastLocation = NPC033_LastStrLocation; sTempCurrentLocation = NPC033_CurrentStrLocation; iTempLoyalty = iLoyalty033; Flood.bPutInDanger = Flood.bPutInDanger033; }
            if (tempNPC == NPC_034) { iTempLocation = NPC034_CurrentNumLocation; iTempLastLocation = NPC034_LastLocation; sTempLastLocation = NPC034_LastStrLocation; sTempCurrentLocation = NPC034_CurrentStrLocation; iTempLoyalty = iLoyalty034; Flood.bPutInDanger = Flood.bPutInDanger034; }
            if (tempNPC == NPC_035) { iTempLocation = NPC035_CurrentNumLocation; iTempLastLocation = NPC035_LastLocation; sTempLastLocation = NPC035_LastStrLocation; sTempCurrentLocation = NPC035_CurrentStrLocation; iTempLoyalty = iLoyalty035; Flood.bPutInDanger = Flood.bPutInDanger035; }
            if (tempNPC == NPC_036) { iTempLocation = NPC036_CurrentNumLocation; iTempLastLocation = NPC036_LastLocation; sTempLastLocation = NPC036_LastStrLocation; sTempCurrentLocation = NPC036_CurrentStrLocation; iTempLoyalty = iLoyalty036; Flood.bPutInDanger = Flood.bPutInDanger036; }
            if (tempNPC == NPC_037) { iTempLocation = NPC037_CurrentNumLocation; iTempLastLocation = NPC037_LastLocation; sTempLastLocation = NPC037_LastStrLocation; sTempCurrentLocation = NPC037_CurrentStrLocation; iTempLoyalty = iLoyalty037; Flood.bPutInDanger = Flood.bPutInDanger037; }
            if (tempNPC == NPC_038) { iTempLocation = NPC038_CurrentNumLocation; iTempLastLocation = NPC038_LastLocation; sTempLastLocation = NPC038_LastStrLocation; sTempCurrentLocation = NPC038_CurrentStrLocation; iTempLoyalty = iLoyalty038; Flood.bPutInDanger = Flood.bPutInDanger038; }
            if (tempNPC == NPC_039) { iTempLocation = NPC039_CurrentNumLocation; iTempLastLocation = NPC039_LastLocation; sTempLastLocation = NPC039_LastStrLocation; sTempCurrentLocation = NPC039_CurrentStrLocation; iTempLoyalty = iLoyalty039; Flood.bPutInDanger = Flood.bPutInDanger039; }
            if (tempNPC == NPC_040) { iTempLocation = NPC040_CurrentNumLocation; iTempLastLocation = NPC040_LastLocation; sTempLastLocation = NPC040_LastStrLocation; sTempCurrentLocation = NPC040_CurrentStrLocation; iTempLoyalty = iLoyalty040; Flood.bPutInDanger = Flood.bPutInDanger040; }
            if (tempNPC == NPC_041) { iTempLocation = NPC041_CurrentNumLocation; iTempLastLocation = NPC041_LastLocation; sTempLastLocation = NPC041_LastStrLocation; sTempCurrentLocation = NPC041_CurrentStrLocation; iTempLoyalty = iLoyalty041; Flood.bPutInDanger = Flood.bPutInDanger041; }
            if (tempNPC == NPC_042) { iTempLocation = NPC042_CurrentNumLocation; iTempLastLocation = NPC042_LastLocation; sTempLastLocation = NPC042_LastStrLocation; sTempCurrentLocation = NPC042_CurrentStrLocation; iTempLoyalty = iLoyalty042; Flood.bPutInDanger = Flood.bPutInDanger042; }
            if (tempNPC == NPC_043) { iTempLocation = NPC043_CurrentNumLocation; iTempLastLocation = NPC043_LastLocation; sTempLastLocation = NPC043_LastStrLocation; sTempCurrentLocation = NPC043_CurrentStrLocation; iTempLoyalty = iLoyalty043; Flood.bPutInDanger = Flood.bPutInDanger043; }
            if (tempNPC == NPC_044) { iTempLocation = NPC044_CurrentNumLocation; iTempLastLocation = NPC044_LastLocation; sTempLastLocation = NPC044_LastStrLocation; sTempCurrentLocation = NPC044_CurrentStrLocation; iTempLoyalty = iLoyalty044; Flood.bPutInDanger = Flood.bPutInDanger044; }
            if (tempNPC == NPC_045) { iTempLocation = NPC045_CurrentNumLocation; iTempLastLocation = NPC045_LastLocation; sTempLastLocation = NPC045_LastStrLocation; sTempCurrentLocation = NPC045_CurrentStrLocation; iTempLoyalty = iLoyalty045; Flood.bPutInDanger = Flood.bPutInDanger045; }
            if (tempNPC == NPC_046) { iTempLocation = NPC046_CurrentNumLocation; iTempLastLocation = NPC046_LastLocation; sTempLastLocation = NPC046_LastStrLocation; sTempCurrentLocation = NPC046_CurrentStrLocation; iTempLoyalty = iLoyalty046; Flood.bPutInDanger = Flood.bPutInDanger046; }
            if (tempNPC == NPC_047) { iTempLocation = NPC047_CurrentNumLocation; iTempLastLocation = NPC047_LastLocation; sTempLastLocation = NPC047_LastStrLocation; sTempCurrentLocation = NPC047_CurrentStrLocation; iTempLoyalty = iLoyalty047; Flood.bPutInDanger = Flood.bPutInDanger047; }
            if (tempNPC == NPC_048) { iTempLocation = NPC048_CurrentNumLocation; iTempLastLocation = NPC048_LastLocation; sTempLastLocation = NPC048_LastStrLocation; sTempCurrentLocation = NPC048_CurrentStrLocation; iTempLoyalty = iLoyalty048; Flood.bPutInDanger = Flood.bPutInDanger048; }
            if (tempNPC == NPC_049) { iTempLocation = NPC049_CurrentNumLocation; iTempLastLocation = NPC049_LastLocation; sTempLastLocation = NPC049_LastStrLocation; sTempCurrentLocation = NPC049_CurrentStrLocation; iTempLoyalty = iLoyalty049; Flood.bPutInDanger = Flood.bPutInDanger049; }
            if (tempNPC == NPC_050) { iTempLocation = NPC050_CurrentNumLocation; iTempLastLocation = NPC050_LastLocation; sTempLastLocation = NPC050_LastStrLocation; sTempCurrentLocation = NPC050_CurrentStrLocation; iTempLoyalty = iLoyalty050; Flood.bPutInDanger = Flood.bPutInDanger050; }
            if (tempNPC == NPC_051) { iTempLocation = NPC051_CurrentNumLocation; iTempLastLocation = NPC051_LastLocation; sTempLastLocation = NPC051_LastStrLocation; sTempCurrentLocation = NPC051_CurrentStrLocation; iTempLoyalty = iLoyalty051; Flood.bPutInDanger = Flood.bPutInDanger051; }
            if (tempNPC == NPC_052) { iTempLocation = NPC052_CurrentNumLocation; iTempLastLocation = NPC052_LastLocation; sTempLastLocation = NPC052_LastStrLocation; sTempCurrentLocation = NPC052_CurrentStrLocation; iTempLoyalty = iLoyalty052; Flood.bPutInDanger = Flood.bPutInDanger052; }
            if (tempNPC == NPC_053) { iTempLocation = NPC053_CurrentNumLocation; iTempLastLocation = NPC053_LastLocation; sTempLastLocation = NPC053_LastStrLocation; sTempCurrentLocation = NPC053_CurrentStrLocation; iTempLoyalty = iLoyalty053; Flood.bPutInDanger = Flood.bPutInDanger053; }
            if (tempNPC == NPC_054) { iTempLocation = NPC054_CurrentNumLocation; iTempLastLocation = NPC054_LastLocation; sTempLastLocation = NPC054_LastStrLocation; sTempCurrentLocation = NPC054_CurrentStrLocation; iTempLoyalty = iLoyalty054; Flood.bPutInDanger = Flood.bPutInDanger054; }
            if (tempNPC == NPC_055) { iTempLocation = NPC055_CurrentNumLocation; iTempLastLocation = NPC055_LastLocation; sTempLastLocation = NPC055_LastStrLocation; sTempCurrentLocation = NPC055_CurrentStrLocation; iTempLoyalty = iLoyalty055; Flood.bPutInDanger = Flood.bPutInDanger055; }
            if (tempNPC == NPC_056) { iTempLocation = NPC056_CurrentNumLocation; iTempLastLocation = NPC056_LastLocation; sTempLastLocation = NPC056_LastStrLocation; sTempCurrentLocation = NPC056_CurrentStrLocation; iTempLoyalty = iLoyalty056; Flood.bPutInDanger = Flood.bPutInDanger056; }
            if (tempNPC == NPC_057) { iTempLocation = NPC057_CurrentNumLocation; iTempLastLocation = NPC057_LastLocation; sTempLastLocation = NPC057_LastStrLocation; sTempCurrentLocation = NPC057_CurrentStrLocation; iTempLoyalty = iLoyalty057; Flood.bPutInDanger = Flood.bPutInDanger057; }
            if (tempNPC == NPC_058) { iTempLocation = NPC058_CurrentNumLocation; iTempLastLocation = NPC058_LastLocation; sTempLastLocation = NPC058_LastStrLocation; sTempCurrentLocation = NPC058_CurrentStrLocation; iTempLoyalty = iLoyalty058; Flood.bPutInDanger = Flood.bPutInDanger058; }
            if (tempNPC == NPC_059) { iTempLocation = NPC059_CurrentNumLocation; iTempLastLocation = NPC059_LastLocation; sTempLastLocation = NPC059_LastStrLocation; sTempCurrentLocation = NPC059_CurrentStrLocation; iTempLoyalty = iLoyalty059; Flood.bPutInDanger = Flood.bPutInDanger059; }
            if (tempNPC == NPC_060) { iTempLocation = NPC060_CurrentNumLocation; iTempLastLocation = NPC060_LastLocation; sTempLastLocation = NPC060_LastStrLocation; sTempCurrentLocation = NPC060_CurrentStrLocation; iTempLoyalty = iLoyalty060; Flood.bPutInDanger = Flood.bPutInDanger060; }
            if (tempNPC == NPC_061) { iTempLocation = NPC061_CurrentNumLocation; iTempLastLocation = NPC061_LastLocation; sTempLastLocation = NPC061_LastStrLocation; sTempCurrentLocation = NPC061_CurrentStrLocation; iTempLoyalty = iLoyalty061; Flood.bPutInDanger = Flood.bPutInDanger061; }
            if (tempNPC == NPC_062) { iTempLocation = NPC062_CurrentNumLocation; iTempLastLocation = NPC062_LastLocation; sTempLastLocation = NPC062_LastStrLocation; sTempCurrentLocation = NPC062_CurrentStrLocation; iTempLoyalty = iLoyalty062; Flood.bPutInDanger = Flood.bPutInDanger062; }
            if (tempNPC == NPC_063) { iTempLocation = NPC063_CurrentNumLocation; iTempLastLocation = NPC063_LastLocation; sTempLastLocation = NPC063_LastStrLocation; sTempCurrentLocation = NPC063_CurrentStrLocation; iTempLoyalty = iLoyalty063; Flood.bPutInDanger = Flood.bPutInDanger063; }
            if (tempNPC == NPC_064) { iTempLocation = NPC064_CurrentNumLocation; iTempLastLocation = NPC064_LastLocation; sTempLastLocation = NPC064_LastStrLocation; sTempCurrentLocation = NPC064_CurrentStrLocation; iTempLoyalty = iLoyalty064; Flood.bPutInDanger = Flood.bPutInDanger064; }
            if (tempNPC == NPC_065) { iTempLocation = NPC065_CurrentNumLocation; iTempLastLocation = NPC065_LastLocation; sTempLastLocation = NPC065_LastStrLocation; sTempCurrentLocation = NPC065_CurrentStrLocation; iTempLoyalty = iLoyalty065; Flood.bPutInDanger = Flood.bPutInDanger065; }
            if (tempNPC == NPC_066) { iTempLocation = NPC066_CurrentNumLocation; iTempLastLocation = NPC066_LastLocation; sTempLastLocation = NPC066_LastStrLocation; sTempCurrentLocation = NPC066_CurrentStrLocation; iTempLoyalty = iLoyalty066; Flood.bPutInDanger = Flood.bPutInDanger066; }
            if (tempNPC == NPC_067) { iTempLocation = NPC067_CurrentNumLocation; iTempLastLocation = NPC067_LastLocation; sTempLastLocation = NPC067_LastStrLocation; sTempCurrentLocation = NPC067_CurrentStrLocation; iTempLoyalty = iLoyalty067; Flood.bPutInDanger = Flood.bPutInDanger067; }
            if (tempNPC == NPC_068) { iTempLocation = NPC068_CurrentNumLocation; iTempLastLocation = NPC068_LastLocation; sTempLastLocation = NPC068_LastStrLocation; sTempCurrentLocation = NPC068_CurrentStrLocation; iTempLoyalty = iLoyalty068; Flood.bPutInDanger = Flood.bPutInDanger068; }
            if (tempNPC == NPC_069) { iTempLocation = NPC069_CurrentNumLocation; iTempLastLocation = NPC069_LastLocation; sTempLastLocation = NPC069_LastStrLocation; sTempCurrentLocation = NPC069_CurrentStrLocation; iTempLoyalty = iLoyalty069; Flood.bPutInDanger = Flood.bPutInDanger069; }
            if (tempNPC == NPC_070) { iTempLocation = NPC070_CurrentNumLocation; iTempLastLocation = NPC070_LastLocation; sTempLastLocation = NPC070_LastStrLocation; sTempCurrentLocation = NPC070_CurrentStrLocation; iTempLoyalty = iLoyalty070; Flood.bPutInDanger = Flood.bPutInDanger070; }
            if (tempNPC == NPC_071) { iTempLocation = NPC071_CurrentNumLocation; iTempLastLocation = NPC071_LastLocation; sTempLastLocation = NPC071_LastStrLocation; sTempCurrentLocation = NPC071_CurrentStrLocation; iTempLoyalty = iLoyalty071; Flood.bPutInDanger = Flood.bPutInDanger071; }
            if (tempNPC == NPC_072) { iTempLocation = NPC072_CurrentNumLocation; iTempLastLocation = NPC072_LastLocation; sTempLastLocation = NPC072_LastStrLocation; sTempCurrentLocation = NPC072_CurrentStrLocation; iTempLoyalty = iLoyalty072; Flood.bPutInDanger = Flood.bPutInDanger072; }
            if (tempNPC == NPC_073) { iTempLocation = NPC073_CurrentNumLocation; iTempLastLocation = NPC073_LastLocation; sTempLastLocation = NPC073_LastStrLocation; sTempCurrentLocation = NPC073_CurrentStrLocation; iTempLoyalty = iLoyalty073; Flood.bPutInDanger = Flood.bPutInDanger073; }
            if (tempNPC == NPC_074) { iTempLocation = NPC074_CurrentNumLocation; iTempLastLocation = NPC074_LastLocation; sTempLastLocation = NPC074_LastStrLocation; sTempCurrentLocation = NPC074_CurrentStrLocation; iTempLoyalty = iLoyalty074; Flood.bPutInDanger = Flood.bPutInDanger074; }
            if (tempNPC == NPC_075) { iTempLocation = NPC075_CurrentNumLocation; iTempLastLocation = NPC075_LastLocation; sTempLastLocation = NPC075_LastStrLocation; sTempCurrentLocation = NPC075_CurrentStrLocation; iTempLoyalty = iLoyalty075; Flood.bPutInDanger = Flood.bPutInDanger075; }
            if (tempNPC == NPC_076) { iTempLocation = NPC076_CurrentNumLocation; iTempLastLocation = NPC076_LastLocation; sTempLastLocation = NPC076_LastStrLocation; sTempCurrentLocation = NPC076_CurrentStrLocation; iTempLoyalty = iLoyalty076; Flood.bPutInDanger = Flood.bPutInDanger076; }
            if (tempNPC == NPC_077) { iTempLocation = NPC077_CurrentNumLocation; iTempLastLocation = NPC077_LastLocation; sTempLastLocation = NPC077_LastStrLocation; sTempCurrentLocation = NPC077_CurrentStrLocation; iTempLoyalty = iLoyalty077; Flood.bPutInDanger = Flood.bPutInDanger077; }
            if (tempNPC == NPC_078) { iTempLocation = NPC078_CurrentNumLocation; iTempLastLocation = NPC078_LastLocation; sTempLastLocation = NPC078_LastStrLocation; sTempCurrentLocation = NPC078_CurrentStrLocation; iTempLoyalty = iLoyalty078; Flood.bPutInDanger = Flood.bPutInDanger078; }
            if (tempNPC == NPC_079) { iTempLocation = NPC079_CurrentNumLocation; iTempLastLocation = NPC079_LastLocation; sTempLastLocation = NPC079_LastStrLocation; sTempCurrentLocation = NPC079_CurrentStrLocation; iTempLoyalty = iLoyalty079; Flood.bPutInDanger = Flood.bPutInDanger079; }
            if (tempNPC == NPC_080) { iTempLocation = NPC080_CurrentNumLocation; iTempLastLocation = NPC080_LastLocation; sTempLastLocation = NPC080_LastStrLocation; sTempCurrentLocation = NPC080_CurrentStrLocation; iTempLoyalty = iLoyalty080; Flood.bPutInDanger = Flood.bPutInDanger080; }
            if (tempNPC == NPC_081) { iTempLocation = NPC081_CurrentNumLocation; iTempLastLocation = NPC081_LastLocation; sTempLastLocation = NPC081_LastStrLocation; sTempCurrentLocation = NPC081_CurrentStrLocation; iTempLoyalty = iLoyalty081; Flood.bPutInDanger = Flood.bPutInDanger081; }
            if (tempNPC == NPC_082) { iTempLocation = NPC082_CurrentNumLocation; iTempLastLocation = NPC082_LastLocation; sTempLastLocation = NPC082_LastStrLocation; sTempCurrentLocation = NPC082_CurrentStrLocation; iTempLoyalty = iLoyalty082; Flood.bPutInDanger = Flood.bPutInDanger082; }
            if (tempNPC == NPC_083) { iTempLocation = NPC083_CurrentNumLocation; iTempLastLocation = NPC083_LastLocation; sTempLastLocation = NPC083_LastStrLocation; sTempCurrentLocation = NPC083_CurrentStrLocation; iTempLoyalty = iLoyalty083; Flood.bPutInDanger = Flood.bPutInDanger083; }
            if (tempNPC == NPC_084) { iTempLocation = NPC084_CurrentNumLocation; iTempLastLocation = NPC084_LastLocation; sTempLastLocation = NPC084_LastStrLocation; sTempCurrentLocation = NPC084_CurrentStrLocation; iTempLoyalty = iLoyalty084; Flood.bPutInDanger = Flood.bPutInDanger084; }
            if (tempNPC == NPC_085) { iTempLocation = NPC085_CurrentNumLocation; iTempLastLocation = NPC085_LastLocation; sTempLastLocation = NPC085_LastStrLocation; sTempCurrentLocation = NPC085_CurrentStrLocation; iTempLoyalty = iLoyalty085; Flood.bPutInDanger = Flood.bPutInDanger085; }
            if (tempNPC == NPC_086) { iTempLocation = NPC086_CurrentNumLocation; iTempLastLocation = NPC086_LastLocation; sTempLastLocation = NPC086_LastStrLocation; sTempCurrentLocation = NPC086_CurrentStrLocation; iTempLoyalty = iLoyalty086; Flood.bPutInDanger = Flood.bPutInDanger086; }
            if (tempNPC == NPC_087) { iTempLocation = NPC087_CurrentNumLocation; iTempLastLocation = NPC087_LastLocation; sTempLastLocation = NPC087_LastStrLocation; sTempCurrentLocation = NPC087_CurrentStrLocation; iTempLoyalty = iLoyalty087; Flood.bPutInDanger = Flood.bPutInDanger087; }
            if (tempNPC == NPC_088) { iTempLocation = NPC088_CurrentNumLocation; iTempLastLocation = NPC088_LastLocation; sTempLastLocation = NPC088_LastStrLocation; sTempCurrentLocation = NPC088_CurrentStrLocation; iTempLoyalty = iLoyalty088; Flood.bPutInDanger = Flood.bPutInDanger088; }
            if (tempNPC == NPC_089) { iTempLocation = NPC089_CurrentNumLocation; iTempLastLocation = NPC089_LastLocation; sTempLastLocation = NPC089_LastStrLocation; sTempCurrentLocation = NPC089_CurrentStrLocation; iTempLoyalty = iLoyalty089; Flood.bPutInDanger = Flood.bPutInDanger089; }
            if (tempNPC == NPC_090) { iTempLocation = NPC090_CurrentNumLocation; iTempLastLocation = NPC090_LastLocation; sTempLastLocation = NPC090_LastStrLocation; sTempCurrentLocation = NPC090_CurrentStrLocation; iTempLoyalty = iLoyalty090; Flood.bPutInDanger = Flood.bPutInDanger090; }
            if (tempNPC == NPC_091) { iTempLocation = NPC091_CurrentNumLocation; iTempLastLocation = NPC091_LastLocation; sTempLastLocation = NPC091_LastStrLocation; sTempCurrentLocation = NPC091_CurrentStrLocation; iTempLoyalty = iLoyalty091; Flood.bPutInDanger = Flood.bPutInDanger091; }
            if (tempNPC == NPC_092) { iTempLocation = NPC092_CurrentNumLocation; iTempLastLocation = NPC092_LastLocation; sTempLastLocation = NPC092_LastStrLocation; sTempCurrentLocation = NPC092_CurrentStrLocation; iTempLoyalty = iLoyalty092; Flood.bPutInDanger = Flood.bPutInDanger092; }
            if (tempNPC == NPC_093) { iTempLocation = NPC093_CurrentNumLocation; iTempLastLocation = NPC093_LastLocation; sTempLastLocation = NPC093_LastStrLocation; sTempCurrentLocation = NPC093_CurrentStrLocation; iTempLoyalty = iLoyalty093; Flood.bPutInDanger = Flood.bPutInDanger093; }
            if (tempNPC == NPC_094) { iTempLocation = NPC094_CurrentNumLocation; iTempLastLocation = NPC094_LastLocation; sTempLastLocation = NPC094_LastStrLocation; sTempCurrentLocation = NPC094_CurrentStrLocation; iTempLoyalty = iLoyalty094; Flood.bPutInDanger = Flood.bPutInDanger094; }
            if (tempNPC == NPC_095) { iTempLocation = NPC095_CurrentNumLocation; iTempLastLocation = NPC095_LastLocation; sTempLastLocation = NPC095_LastStrLocation; sTempCurrentLocation = NPC095_CurrentStrLocation; iTempLoyalty = iLoyalty095; Flood.bPutInDanger = Flood.bPutInDanger095; }
            if (tempNPC == NPC_096) { iTempLocation = NPC096_CurrentNumLocation; iTempLastLocation = NPC096_LastLocation; sTempLastLocation = NPC096_LastStrLocation; sTempCurrentLocation = NPC096_CurrentStrLocation; iTempLoyalty = iLoyalty096; Flood.bPutInDanger = Flood.bPutInDanger096; }
            if (tempNPC == NPC_097) { iTempLocation = NPC097_CurrentNumLocation; iTempLastLocation = NPC097_LastLocation; sTempLastLocation = NPC097_LastStrLocation; sTempCurrentLocation = NPC097_CurrentStrLocation; iTempLoyalty = iLoyalty097; Flood.bPutInDanger = Flood.bPutInDanger097; }
            if (tempNPC == NPC_098) { iTempLocation = NPC098_CurrentNumLocation; iTempLastLocation = NPC098_LastLocation; sTempLastLocation = NPC098_LastStrLocation; sTempCurrentLocation = NPC098_CurrentStrLocation; iTempLoyalty = iLoyalty098; Flood.bPutInDanger = Flood.bPutInDanger098; }
            if (tempNPC == NPC_099) { iTempLocation = NPC099_CurrentNumLocation; iTempLastLocation = NPC099_LastLocation; sTempLastLocation = NPC099_LastStrLocation; sTempCurrentLocation = NPC099_CurrentStrLocation; iTempLoyalty = iLoyalty099; Flood.bPutInDanger = Flood.bPutInDanger099; }
            if (tempNPC == NPC_100) { iTempLocation = NPC100_CurrentNumLocation; iTempLastLocation = NPC100_LastLocation; sTempLastLocation = NPC100_LastStrLocation; sTempCurrentLocation = NPC100_CurrentStrLocation; iTempLoyalty = iLoyalty100; Flood.bPutInDanger = Flood.bPutInDanger100; }
        }

        public static void GetAllSetSpeakerLocals()
        {
            if (iSetSpeaker == Conversation.iSpeaker001)
            { 
                iTempMacGuffins = iAvailableMacGuffins001; 
                sTempWeapons = sAvailableWeapons001; 
                iTempLoyalty = iLoyalty001; 
                iTempDesireToMove = DesireToMove001; 
                bTempCorpse = bCorpse001; 
            }
            if (iSetSpeaker == Conversation.iSpeaker002)
            { iTempMacGuffins = iAvailableMacGuffins002; sTempWeapons = sAvailableWeapons002; iTempLoyalty = iLoyalty002; iTempDesireToMove = DesireToMove002; bTempCorpse = bCorpse002; }
            if (iSetSpeaker == Conversation.iSpeaker003)
            { iTempMacGuffins = iAvailableMacGuffins003; sTempWeapons = sAvailableWeapons003; iTempLoyalty = iLoyalty003; iTempDesireToMove = DesireToMove003; bTempCorpse = bCorpse003; }
            if (iSetSpeaker == Conversation.iSpeaker004)
            { iTempMacGuffins = iAvailableMacGuffins004; sTempWeapons = sAvailableWeapons004; iTempLoyalty = iLoyalty004; iTempDesireToMove = DesireToMove004; bTempCorpse = bCorpse004; }
            if (iSetSpeaker == Conversation.iSpeaker005)
            { iTempMacGuffins = iAvailableMacGuffins005; sTempWeapons = sAvailableWeapons005; iTempLoyalty = iLoyalty005; iTempDesireToMove = DesireToMove005; bTempCorpse = bCorpse005; }
            if (iSetSpeaker == Conversation.iSpeaker006)
            { iTempMacGuffins = iAvailableMacGuffins006; sTempWeapons = sAvailableWeapons006; iTempLoyalty = iLoyalty006; iTempDesireToMove = DesireToMove006; bTempCorpse = bCorpse006; }
            if (iSetSpeaker == Conversation.iSpeaker007)
            { iTempMacGuffins = iAvailableMacGuffins007; sTempWeapons = sAvailableWeapons007; iTempLoyalty = iLoyalty007; iTempDesireToMove = DesireToMove007; bTempCorpse = bCorpse007; }
            if (iSetSpeaker == Conversation.iSpeaker008)
            { iTempMacGuffins = iAvailableMacGuffins008; sTempWeapons = sAvailableWeapons008; iTempLoyalty = iLoyalty008; iTempDesireToMove = DesireToMove008; bTempCorpse = bCorpse008; }
            if (iSetSpeaker == Conversation.iSpeaker009)
            { iTempMacGuffins = iAvailableMacGuffins009; sTempWeapons = sAvailableWeapons009; iTempLoyalty = iLoyalty009; iTempDesireToMove = DesireToMove009; bTempCorpse = bCorpse009; }
            if (iSetSpeaker == Conversation.iSpeaker010)
            { iTempMacGuffins = iAvailableMacGuffins010; sTempWeapons = sAvailableWeapons010; iTempLoyalty = iLoyalty020; iTempDesireToMove = DesireToMove010; bTempCorpse = bCorpse010; }
            if (iSetSpeaker == Conversation.iSpeaker011)
            { iTempMacGuffins = iAvailableMacGuffins011; sTempWeapons = sAvailableWeapons011; iTempLoyalty = iLoyalty011; iTempDesireToMove = DesireToMove011; bTempCorpse = bCorpse011; }
            if (iSetSpeaker == Conversation.iSpeaker012)
            { iTempMacGuffins = iAvailableMacGuffins012; sTempWeapons = sAvailableWeapons012; iTempLoyalty = iLoyalty012; iTempDesireToMove = DesireToMove012; bTempCorpse = bCorpse012; }
            if (iSetSpeaker == Conversation.iSpeaker013)
            { iTempMacGuffins = iAvailableMacGuffins013; sTempWeapons = sAvailableWeapons013; iTempLoyalty = iLoyalty013; iTempDesireToMove = DesireToMove013; bTempCorpse = bCorpse013; }
            if (iSetSpeaker == Conversation.iSpeaker014)
            { iTempMacGuffins = iAvailableMacGuffins014; sTempWeapons = sAvailableWeapons014; iTempLoyalty = iLoyalty014; iTempDesireToMove = DesireToMove014; bTempCorpse = bCorpse014; }
            if (iSetSpeaker == Conversation.iSpeaker015)
            { iTempMacGuffins = iAvailableMacGuffins015; sTempWeapons = sAvailableWeapons015; iTempLoyalty = iLoyalty015; iTempDesireToMove = DesireToMove015; bTempCorpse = bCorpse015; }
            if (iSetSpeaker == Conversation.iSpeaker016)
            { iTempMacGuffins = iAvailableMacGuffins016; sTempWeapons = sAvailableWeapons016; iTempLoyalty = iLoyalty016; iTempDesireToMove = DesireToMove016; bTempCorpse = bCorpse016; }
            if (iSetSpeaker == Conversation.iSpeaker017)
            { iTempMacGuffins = iAvailableMacGuffins017; sTempWeapons = sAvailableWeapons017; iTempLoyalty = iLoyalty017; iTempDesireToMove = DesireToMove017; bTempCorpse = bCorpse017; }
            if (iSetSpeaker == Conversation.iSpeaker018)
            { iTempMacGuffins = iAvailableMacGuffins018; sTempWeapons = sAvailableWeapons018; iTempLoyalty = iLoyalty018; iTempDesireToMove = DesireToMove018; bTempCorpse = bCorpse018; }
            if (iSetSpeaker == Conversation.iSpeaker019)
            { iTempMacGuffins = iAvailableMacGuffins019; sTempWeapons = sAvailableWeapons019; iTempLoyalty = iLoyalty019; iTempDesireToMove = DesireToMove019; bTempCorpse = bCorpse019; }
            if (iSetSpeaker == Conversation.iSpeaker020)
            { iTempMacGuffins = iAvailableMacGuffins020; sTempWeapons = sAvailableWeapons020; iTempLoyalty = iLoyalty020; iTempDesireToMove = DesireToMove020; bTempCorpse = bCorpse020; }
            if (iSetSpeaker == Conversation.iSpeaker021)
            { iTempMacGuffins = iAvailableMacGuffins021; sTempWeapons = sAvailableWeapons021; iTempLoyalty = iLoyalty021; iTempDesireToMove = DesireToMove021; bTempCorpse = bCorpse021; }
            if (iSetSpeaker == Conversation.iSpeaker022)
            { iTempMacGuffins = iAvailableMacGuffins022; sTempWeapons = sAvailableWeapons022; iTempLoyalty = iLoyalty022; iTempDesireToMove = DesireToMove022; bTempCorpse = bCorpse022; }
            if (iSetSpeaker == Conversation.iSpeaker023)
            { iTempMacGuffins = iAvailableMacGuffins023; sTempWeapons = sAvailableWeapons023; iTempLoyalty = iLoyalty023; iTempDesireToMove = DesireToMove023; bTempCorpse = bCorpse023; }
            if (iSetSpeaker == Conversation.iSpeaker024)
            { iTempMacGuffins = iAvailableMacGuffins024; sTempWeapons = sAvailableWeapons024; iTempLoyalty = iLoyalty024; iTempDesireToMove = DesireToMove024; bTempCorpse = bCorpse024; }
            if (iSetSpeaker == Conversation.iSpeaker025)
            { iTempMacGuffins = iAvailableMacGuffins025; sTempWeapons = sAvailableWeapons025; iTempLoyalty = iLoyalty025; iTempDesireToMove = DesireToMove025; bTempCorpse = bCorpse025; }
            if (iSetSpeaker == Conversation.iSpeaker026)
            { iTempMacGuffins = iAvailableMacGuffins026; sTempWeapons = sAvailableWeapons026; iTempLoyalty = iLoyalty026; iTempDesireToMove = DesireToMove026; bTempCorpse = bCorpse026; }
            if (iSetSpeaker == Conversation.iSpeaker027)
            { iTempMacGuffins = iAvailableMacGuffins027; sTempWeapons = sAvailableWeapons027; iTempLoyalty = iLoyalty027; iTempDesireToMove = DesireToMove027; bTempCorpse = bCorpse027; }
            if (iSetSpeaker == Conversation.iSpeaker028)
            { iTempMacGuffins = iAvailableMacGuffins028; sTempWeapons = sAvailableWeapons028; iTempLoyalty = iLoyalty028; iTempDesireToMove = DesireToMove028; bTempCorpse = bCorpse028; }
            if (iSetSpeaker == Conversation.iSpeaker029)
            { iTempMacGuffins = iAvailableMacGuffins029; sTempWeapons = sAvailableWeapons029; iTempLoyalty = iLoyalty029; iTempDesireToMove = DesireToMove029; bTempCorpse = bCorpse029; }
            if (iSetSpeaker == Conversation.iSpeaker030)
            { iTempMacGuffins = iAvailableMacGuffins030; sTempWeapons = sAvailableWeapons030; iTempLoyalty = iLoyalty030; iTempDesireToMove = DesireToMove030; bTempCorpse = bCorpse030; }
            if (iSetSpeaker == Conversation.iSpeaker031)
            { iTempMacGuffins = iAvailableMacGuffins031; sTempWeapons = sAvailableWeapons031; iTempLoyalty = iLoyalty031; iTempDesireToMove = DesireToMove031; bTempCorpse = bCorpse031; }
            if (iSetSpeaker == Conversation.iSpeaker032)
            { iTempMacGuffins = iAvailableMacGuffins032; sTempWeapons = sAvailableWeapons032; iTempLoyalty = iLoyalty032; iTempDesireToMove = DesireToMove032; bTempCorpse = bCorpse032; }
            if (iSetSpeaker == Conversation.iSpeaker033)
            { iTempMacGuffins = iAvailableMacGuffins033; sTempWeapons = sAvailableWeapons033; iTempLoyalty = iLoyalty033; iTempDesireToMove = DesireToMove033; bTempCorpse = bCorpse033; }
            if (iSetSpeaker == Conversation.iSpeaker034)
            { iTempMacGuffins = iAvailableMacGuffins034; sTempWeapons = sAvailableWeapons034; iTempLoyalty = iLoyalty034; iTempDesireToMove = DesireToMove034; bTempCorpse = bCorpse034; }
            if (iSetSpeaker == Conversation.iSpeaker035)
            { iTempMacGuffins = iAvailableMacGuffins035; sTempWeapons = sAvailableWeapons035; iTempLoyalty = iLoyalty035; iTempDesireToMove = DesireToMove035; bTempCorpse = bCorpse035; }
            if (iSetSpeaker == Conversation.iSpeaker036)
            { iTempMacGuffins = iAvailableMacGuffins036; sTempWeapons = sAvailableWeapons036; iTempLoyalty = iLoyalty036; iTempDesireToMove = DesireToMove036; bTempCorpse = bCorpse036; }
            if (iSetSpeaker == Conversation.iSpeaker037)
            { iTempMacGuffins = iAvailableMacGuffins037; sTempWeapons = sAvailableWeapons037; iTempLoyalty = iLoyalty037; iTempDesireToMove = DesireToMove037; bTempCorpse = bCorpse037; }
            if (iSetSpeaker == Conversation.iSpeaker038)
            { iTempMacGuffins = iAvailableMacGuffins038; sTempWeapons = sAvailableWeapons038; iTempLoyalty = iLoyalty038; iTempDesireToMove = DesireToMove038; bTempCorpse = bCorpse038; }
            if (iSetSpeaker == Conversation.iSpeaker039)
            { iTempMacGuffins = iAvailableMacGuffins039; sTempWeapons = sAvailableWeapons039; iTempLoyalty = iLoyalty039; iTempDesireToMove = DesireToMove039; bTempCorpse = bCorpse039; }
            if (iSetSpeaker == Conversation.iSpeaker040)
            { iTempMacGuffins = iAvailableMacGuffins040; sTempWeapons = sAvailableWeapons040; iTempLoyalty = iLoyalty040; iTempDesireToMove = DesireToMove040; bTempCorpse = bCorpse040; }
            if (iSetSpeaker == Conversation.iSpeaker041)
            { iTempMacGuffins = iAvailableMacGuffins041; sTempWeapons = sAvailableWeapons041; iTempLoyalty = iLoyalty041; iTempDesireToMove = DesireToMove041; bTempCorpse = bCorpse041; }
            if (iSetSpeaker == Conversation.iSpeaker042)
            { iTempMacGuffins = iAvailableMacGuffins042; sTempWeapons = sAvailableWeapons042; iTempLoyalty = iLoyalty042; iTempDesireToMove = DesireToMove042; bTempCorpse = bCorpse042; }
            if (iSetSpeaker == Conversation.iSpeaker043)
            { iTempMacGuffins = iAvailableMacGuffins043; sTempWeapons = sAvailableWeapons043; iTempLoyalty = iLoyalty043; iTempDesireToMove = DesireToMove043; bTempCorpse = bCorpse043; }
            if (iSetSpeaker == Conversation.iSpeaker044)
            { iTempMacGuffins = iAvailableMacGuffins044; sTempWeapons = sAvailableWeapons044; iTempLoyalty = iLoyalty044; iTempDesireToMove = DesireToMove044; bTempCorpse = bCorpse044; }
            if (iSetSpeaker == Conversation.iSpeaker045)
            { iTempMacGuffins = iAvailableMacGuffins045; sTempWeapons = sAvailableWeapons045; iTempLoyalty = iLoyalty045; iTempDesireToMove = DesireToMove045; bTempCorpse = bCorpse045; }
            if (iSetSpeaker == Conversation.iSpeaker046)
            { iTempMacGuffins = iAvailableMacGuffins046; sTempWeapons = sAvailableWeapons046; iTempLoyalty = iLoyalty046; iTempDesireToMove = DesireToMove046; bTempCorpse = bCorpse046; }
            if (iSetSpeaker == Conversation.iSpeaker047)
            { iTempMacGuffins = iAvailableMacGuffins047; sTempWeapons = sAvailableWeapons047; iTempLoyalty = iLoyalty047; iTempDesireToMove = DesireToMove047; bTempCorpse = bCorpse047; }
            if (iSetSpeaker == Conversation.iSpeaker048)
            { iTempMacGuffins = iAvailableMacGuffins048; sTempWeapons = sAvailableWeapons048; iTempLoyalty = iLoyalty048; iTempDesireToMove = DesireToMove048; bTempCorpse = bCorpse048; }
            if (iSetSpeaker == Conversation.iSpeaker049)
            { iTempMacGuffins = iAvailableMacGuffins049; sTempWeapons = sAvailableWeapons049; iTempLoyalty = iLoyalty049; iTempDesireToMove = DesireToMove049; bTempCorpse = bCorpse049; }
            if (iSetSpeaker == Conversation.iSpeaker050)
            { iTempMacGuffins = iAvailableMacGuffins050; sTempWeapons = sAvailableWeapons050; iTempLoyalty = iLoyalty050; iTempDesireToMove = DesireToMove050; bTempCorpse = bCorpse050; }
            if (iSetSpeaker == Conversation.iSpeaker051)
            { iTempMacGuffins = iAvailableMacGuffins051; sTempWeapons = sAvailableWeapons051; iTempLoyalty = iLoyalty051; iTempDesireToMove = DesireToMove051; bTempCorpse = bCorpse051; }
            if (iSetSpeaker == Conversation.iSpeaker052)
            { iTempMacGuffins = iAvailableMacGuffins052; sTempWeapons = sAvailableWeapons052; iTempLoyalty = iLoyalty052; iTempDesireToMove = DesireToMove052; bTempCorpse = bCorpse052; }
            if (iSetSpeaker == Conversation.iSpeaker053)
            { iTempMacGuffins = iAvailableMacGuffins053; sTempWeapons = sAvailableWeapons053; iTempLoyalty = iLoyalty053; iTempDesireToMove = DesireToMove053; bTempCorpse = bCorpse053; }
            if (iSetSpeaker == Conversation.iSpeaker054)
            { iTempMacGuffins = iAvailableMacGuffins054; sTempWeapons = sAvailableWeapons054; iTempLoyalty = iLoyalty054; iTempDesireToMove = DesireToMove054; bTempCorpse = bCorpse054; }
            if (iSetSpeaker == Conversation.iSpeaker055)
            { iTempMacGuffins = iAvailableMacGuffins055; sTempWeapons = sAvailableWeapons055; iTempLoyalty = iLoyalty055; iTempDesireToMove = DesireToMove055; bTempCorpse = bCorpse055; }
            if (iSetSpeaker == Conversation.iSpeaker056)
            { iTempMacGuffins = iAvailableMacGuffins056; sTempWeapons = sAvailableWeapons056; iTempLoyalty = iLoyalty056; iTempDesireToMove = DesireToMove056; bTempCorpse = bCorpse056; }
            if (iSetSpeaker == Conversation.iSpeaker057)
            { iTempMacGuffins = iAvailableMacGuffins057; sTempWeapons = sAvailableWeapons057; iTempLoyalty = iLoyalty057; iTempDesireToMove = DesireToMove057; bTempCorpse = bCorpse057; }
            if (iSetSpeaker == Conversation.iSpeaker058)
            { iTempMacGuffins = iAvailableMacGuffins058; sTempWeapons = sAvailableWeapons058; iTempLoyalty = iLoyalty058; iTempDesireToMove = DesireToMove058; bTempCorpse = bCorpse058; }
            if (iSetSpeaker == Conversation.iSpeaker059)
            { iTempMacGuffins = iAvailableMacGuffins059; sTempWeapons = sAvailableWeapons059; iTempLoyalty = iLoyalty059; iTempDesireToMove = DesireToMove059; bTempCorpse = bCorpse059; }
            if (iSetSpeaker == Conversation.iSpeaker060)
            { iTempMacGuffins = iAvailableMacGuffins060; sTempWeapons = sAvailableWeapons060; iTempLoyalty = iLoyalty060; iTempDesireToMove = DesireToMove060; bTempCorpse = bCorpse060; }
            if (iSetSpeaker == Conversation.iSpeaker061)
            { iTempMacGuffins = iAvailableMacGuffins061; sTempWeapons = sAvailableWeapons061; iTempLoyalty = iLoyalty061; iTempDesireToMove = DesireToMove061; bTempCorpse = bCorpse061; }
            if (iSetSpeaker == Conversation.iSpeaker062)
            { iTempMacGuffins = iAvailableMacGuffins062; sTempWeapons = sAvailableWeapons062; iTempLoyalty = iLoyalty062; iTempDesireToMove = DesireToMove062; bTempCorpse = bCorpse062; }
            if (iSetSpeaker == Conversation.iSpeaker063)
            { iTempMacGuffins = iAvailableMacGuffins063; sTempWeapons = sAvailableWeapons063; iTempLoyalty = iLoyalty063; iTempDesireToMove = DesireToMove063; bTempCorpse = bCorpse063; }
            if (iSetSpeaker == Conversation.iSpeaker064)
            { iTempMacGuffins = iAvailableMacGuffins064; sTempWeapons = sAvailableWeapons064; iTempLoyalty = iLoyalty064; iTempDesireToMove = DesireToMove064; bTempCorpse = bCorpse064; }
            if (iSetSpeaker == Conversation.iSpeaker065)
            { iTempMacGuffins = iAvailableMacGuffins065; sTempWeapons = sAvailableWeapons065; iTempLoyalty = iLoyalty065; iTempDesireToMove = DesireToMove065; bTempCorpse = bCorpse065; }
            if (iSetSpeaker == Conversation.iSpeaker066)
            { iTempMacGuffins = iAvailableMacGuffins066; sTempWeapons = sAvailableWeapons066; iTempLoyalty = iLoyalty066; iTempDesireToMove = DesireToMove066; bTempCorpse = bCorpse066; }
            if (iSetSpeaker == Conversation.iSpeaker067)
            { iTempMacGuffins = iAvailableMacGuffins067; sTempWeapons = sAvailableWeapons067; iTempLoyalty = iLoyalty067; iTempDesireToMove = DesireToMove067; bTempCorpse = bCorpse067; }
            if (iSetSpeaker == Conversation.iSpeaker068)
            { iTempMacGuffins = iAvailableMacGuffins068; sTempWeapons = sAvailableWeapons068; iTempLoyalty = iLoyalty068; iTempDesireToMove = DesireToMove068; bTempCorpse = bCorpse068; }
            if (iSetSpeaker == Conversation.iSpeaker069)
            { iTempMacGuffins = iAvailableMacGuffins069; sTempWeapons = sAvailableWeapons069; iTempLoyalty = iLoyalty069; iTempDesireToMove = DesireToMove069; bTempCorpse = bCorpse069; }
            if (iSetSpeaker == Conversation.iSpeaker070)
            { iTempMacGuffins = iAvailableMacGuffins070; sTempWeapons = sAvailableWeapons070; iTempLoyalty = iLoyalty070; iTempDesireToMove = DesireToMove070; bTempCorpse = bCorpse070; }
            if (iSetSpeaker == Conversation.iSpeaker071)
            { iTempMacGuffins = iAvailableMacGuffins071; sTempWeapons = sAvailableWeapons071; iTempLoyalty = iLoyalty071; iTempDesireToMove = DesireToMove071; bTempCorpse = bCorpse071; }
            if (iSetSpeaker == Conversation.iSpeaker072)
            { iTempMacGuffins = iAvailableMacGuffins072; sTempWeapons = sAvailableWeapons072; iTempLoyalty = iLoyalty072; iTempDesireToMove = DesireToMove072; bTempCorpse = bCorpse072; }
            if (iSetSpeaker == Conversation.iSpeaker073)
            { iTempMacGuffins = iAvailableMacGuffins073; sTempWeapons = sAvailableWeapons073; iTempLoyalty = iLoyalty073; iTempDesireToMove = DesireToMove073; bTempCorpse = bCorpse073; }
            if (iSetSpeaker == Conversation.iSpeaker074)
            { iTempMacGuffins = iAvailableMacGuffins074; sTempWeapons = sAvailableWeapons074; iTempLoyalty = iLoyalty074; iTempDesireToMove = DesireToMove074; bTempCorpse = bCorpse074; }
            if (iSetSpeaker == Conversation.iSpeaker075)
            { iTempMacGuffins = iAvailableMacGuffins075; sTempWeapons = sAvailableWeapons075; iTempLoyalty = iLoyalty075; iTempDesireToMove = DesireToMove075; bTempCorpse = bCorpse075; }
            if (iSetSpeaker == Conversation.iSpeaker076)
            { iTempMacGuffins = iAvailableMacGuffins076; sTempWeapons = sAvailableWeapons076; iTempLoyalty = iLoyalty076; iTempDesireToMove = DesireToMove076; bTempCorpse = bCorpse076; }
            if (iSetSpeaker == Conversation.iSpeaker077)
            { iTempMacGuffins = iAvailableMacGuffins077; sTempWeapons = sAvailableWeapons077; iTempLoyalty = iLoyalty077; iTempDesireToMove = DesireToMove077; bTempCorpse = bCorpse077; }
            if (iSetSpeaker == Conversation.iSpeaker078)
            { iTempMacGuffins = iAvailableMacGuffins078; sTempWeapons = sAvailableWeapons078; iTempLoyalty = iLoyalty078; iTempDesireToMove = DesireToMove078; bTempCorpse = bCorpse078; }
            if (iSetSpeaker == Conversation.iSpeaker079)
            { iTempMacGuffins = iAvailableMacGuffins079; sTempWeapons = sAvailableWeapons079; iTempLoyalty = iLoyalty079; iTempDesireToMove = DesireToMove079; bTempCorpse = bCorpse079; }
            if (iSetSpeaker == Conversation.iSpeaker080)
            { iTempMacGuffins = iAvailableMacGuffins080; sTempWeapons = sAvailableWeapons080; iTempLoyalty = iLoyalty080; iTempDesireToMove = DesireToMove080; bTempCorpse = bCorpse080; }
            if (iSetSpeaker == Conversation.iSpeaker081)
            { iTempMacGuffins = iAvailableMacGuffins081; sTempWeapons = sAvailableWeapons081; iTempLoyalty = iLoyalty081; iTempDesireToMove = DesireToMove081; bTempCorpse = bCorpse081; }
            if (iSetSpeaker == Conversation.iSpeaker082)
            { iTempMacGuffins = iAvailableMacGuffins082; sTempWeapons = sAvailableWeapons082; iTempLoyalty = iLoyalty082; iTempDesireToMove = DesireToMove082; bTempCorpse = bCorpse082; }
            if (iSetSpeaker == Conversation.iSpeaker083)
            { iTempMacGuffins = iAvailableMacGuffins083; sTempWeapons = sAvailableWeapons083; iTempLoyalty = iLoyalty083; iTempDesireToMove = DesireToMove083; bTempCorpse = bCorpse083; }
            if (iSetSpeaker == Conversation.iSpeaker084)
            { iTempMacGuffins = iAvailableMacGuffins084; sTempWeapons = sAvailableWeapons084; iTempLoyalty = iLoyalty084; iTempDesireToMove = DesireToMove084; bTempCorpse = bCorpse084; }
            if (iSetSpeaker == Conversation.iSpeaker085)
            { iTempMacGuffins = iAvailableMacGuffins085; sTempWeapons = sAvailableWeapons085; iTempLoyalty = iLoyalty085; iTempDesireToMove = DesireToMove085; bTempCorpse = bCorpse085; }
            if (iSetSpeaker == Conversation.iSpeaker086)
            { iTempMacGuffins = iAvailableMacGuffins086; sTempWeapons = sAvailableWeapons086; iTempLoyalty = iLoyalty086; iTempDesireToMove = DesireToMove086; bTempCorpse = bCorpse086; }
            if (iSetSpeaker == Conversation.iSpeaker087)
            { iTempMacGuffins = iAvailableMacGuffins087; sTempWeapons = sAvailableWeapons087; iTempLoyalty = iLoyalty087; iTempDesireToMove = DesireToMove087; bTempCorpse = bCorpse087; }
            if (iSetSpeaker == Conversation.iSpeaker088)
            { iTempMacGuffins = iAvailableMacGuffins088; sTempWeapons = sAvailableWeapons088; iTempLoyalty = iLoyalty088; iTempDesireToMove = DesireToMove088; bTempCorpse = bCorpse088; }
            if (iSetSpeaker == Conversation.iSpeaker089)
            { iTempMacGuffins = iAvailableMacGuffins089; sTempWeapons = sAvailableWeapons089; iTempLoyalty = iLoyalty089; iTempDesireToMove = DesireToMove089; bTempCorpse = bCorpse089; }
            if (iSetSpeaker == Conversation.iSpeaker090)
            { iTempMacGuffins = iAvailableMacGuffins090; sTempWeapons = sAvailableWeapons090; iTempLoyalty = iLoyalty090; iTempDesireToMove = DesireToMove090; bTempCorpse = bCorpse090; }
            if (iSetSpeaker == Conversation.iSpeaker091)
            { iTempMacGuffins = iAvailableMacGuffins091; sTempWeapons = sAvailableWeapons091; iTempLoyalty = iLoyalty091; iTempDesireToMove = DesireToMove091; bTempCorpse = bCorpse091; }
            if (iSetSpeaker == Conversation.iSpeaker092)
            { iTempMacGuffins = iAvailableMacGuffins092; sTempWeapons = sAvailableWeapons092; iTempLoyalty = iLoyalty092; iTempDesireToMove = DesireToMove092; bTempCorpse = bCorpse092; }
            if (iSetSpeaker == Conversation.iSpeaker093)
            { iTempMacGuffins = iAvailableMacGuffins093; sTempWeapons = sAvailableWeapons093; iTempLoyalty = iLoyalty093; iTempDesireToMove = DesireToMove093; bTempCorpse = bCorpse093; }
            if (iSetSpeaker == Conversation.iSpeaker094)
            { iTempMacGuffins = iAvailableMacGuffins094; sTempWeapons = sAvailableWeapons094; iTempLoyalty = iLoyalty094; iTempDesireToMove = DesireToMove094; bTempCorpse = bCorpse094; }
            if (iSetSpeaker == Conversation.iSpeaker095)
            { iTempMacGuffins = iAvailableMacGuffins095; sTempWeapons = sAvailableWeapons095; iTempLoyalty = iLoyalty095; iTempDesireToMove = DesireToMove095; bTempCorpse = bCorpse095; }
            if (iSetSpeaker == Conversation.iSpeaker096)
            { iTempMacGuffins = iAvailableMacGuffins096; sTempWeapons = sAvailableWeapons096; iTempLoyalty = iLoyalty096; iTempDesireToMove = DesireToMove096; bTempCorpse = bCorpse096; }
            if (iSetSpeaker == Conversation.iSpeaker097)
            { iTempMacGuffins = iAvailableMacGuffins097; sTempWeapons = sAvailableWeapons097; iTempLoyalty = iLoyalty097; iTempDesireToMove = DesireToMove097; bTempCorpse = bCorpse097; }
            if (iSetSpeaker == Conversation.iSpeaker098)
            { iTempMacGuffins = iAvailableMacGuffins098; sTempWeapons = sAvailableWeapons098; iTempLoyalty = iLoyalty098; iTempDesireToMove = DesireToMove098; bTempCorpse = bCorpse098; }
            if (iSetSpeaker == Conversation.iSpeaker099)
            { iTempMacGuffins = iAvailableMacGuffins099; sTempWeapons = sAvailableWeapons099; iTempLoyalty = iLoyalty099; iTempDesireToMove = DesireToMove099; bTempCorpse = bCorpse099; }
            if (iSetSpeaker == Conversation.iSpeaker100)
            { iTempMacGuffins = iAvailableMacGuffins100; sTempWeapons = sAvailableWeapons100; iTempLoyalty = iLoyalty100; iTempDesireToMove = DesireToMove100; bTempCorpse = bCorpse100; }
        }

        public static void SetAllNPCLocals()
        {
            // Set results!
            if (tempNPC == NPC_001) { Conversation.bAlreadyTalked001 = Conversation.bTempTalked; sAvailableWeapons001 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker001; iAvailableMacGuffins001 = iTempMacGuffins; NPC001_CurrentNumLocation = iTempLocation; NPC001_LastLocation = iTempLastLocation; NPC001_LastStrLocation = sTempLastLocation; NPC001_CurrentStrLocation = sTempCurrentLocation; DesireToMove001 = iTempDesireToMove; bCorpse001 = bTempCorpse; iClose001 = iCloseEncounters; Notebook.bNoted001 = Notebook.bTempNoted; Notebook.iObserved001 = Notebook.iTempObserved; NPC_Traits.TraitOne001 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo001 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree001 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne001 = Notebook.bNoteOne; Notebook.bNoteTwo001 = Notebook.bNoteTwo; Notebook.bNoteThree001 = Notebook.bNoteThree; iLoyalty001 = iTempLoyalty; bCorpse001 = bTempCorpse; Flood.bPutInDanger001 = Flood.bPutInDanger; }
            if (tempNPC == NPC_002) { Conversation.bAlreadyTalked002 = Conversation.bTempTalked; sAvailableWeapons002 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker002; iAvailableMacGuffins002 = iTempMacGuffins; NPC002_CurrentNumLocation = iTempLocation; NPC002_LastLocation = iTempLastLocation; NPC002_LastStrLocation = sTempLastLocation; NPC002_CurrentStrLocation = sTempCurrentLocation; DesireToMove002 = iTempDesireToMove; bCorpse002 = bTempCorpse; iClose002 = iCloseEncounters; Notebook.bNoted002 = Notebook.bTempNoted; Notebook.iObserved002 = Notebook.iTempObserved; NPC_Traits.TraitOne002 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo002 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree002 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne002 = Notebook.bNoteOne; Notebook.bNoteTwo002 = Notebook.bNoteTwo; Notebook.bNoteThree002 = Notebook.bNoteThree; iLoyalty002 = iTempLoyalty; bCorpse002 = bTempCorpse; Flood.bPutInDanger002 = Flood.bPutInDanger; }
            if (tempNPC == NPC_003) { Conversation.bAlreadyTalked003 = Conversation.bTempTalked; sAvailableWeapons003 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker003; iAvailableMacGuffins003 = iTempMacGuffins; NPC003_CurrentNumLocation = iTempLocation; NPC003_LastLocation = iTempLastLocation; NPC003_LastStrLocation = sTempLastLocation; NPC003_CurrentStrLocation = sTempCurrentLocation; DesireToMove003 = iTempDesireToMove; bCorpse003 = bTempCorpse; iClose003 = iCloseEncounters; Notebook.bNoted003 = Notebook.bTempNoted; Notebook.iObserved003 = Notebook.iTempObserved; NPC_Traits.TraitOne003 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo003 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree003 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne003 = Notebook.bNoteOne; Notebook.bNoteTwo003 = Notebook.bNoteTwo; Notebook.bNoteThree003 = Notebook.bNoteThree; iLoyalty003 = iTempLoyalty; bCorpse003 = bTempCorpse; Flood.bPutInDanger003 = Flood.bPutInDanger; }
            if (tempNPC == NPC_004) { Conversation.bAlreadyTalked004 = Conversation.bTempTalked; sAvailableWeapons004 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker004; iAvailableMacGuffins004 = iTempMacGuffins; NPC004_CurrentNumLocation = iTempLocation; NPC004_LastLocation = iTempLastLocation; NPC004_LastStrLocation = sTempLastLocation; NPC004_CurrentStrLocation = sTempCurrentLocation; DesireToMove004 = iTempDesireToMove; bCorpse004 = bTempCorpse; iClose004 = iCloseEncounters; Notebook.bNoted004 = Notebook.bTempNoted; Notebook.iObserved004 = Notebook.iTempObserved; NPC_Traits.TraitOne004 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo004 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree004 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne004 = Notebook.bNoteOne; Notebook.bNoteTwo004 = Notebook.bNoteTwo; Notebook.bNoteThree004 = Notebook.bNoteThree; iLoyalty004 = iTempLoyalty; bCorpse004 = bTempCorpse; Flood.bPutInDanger004 = Flood.bPutInDanger; }
            if (tempNPC == NPC_005) { Conversation.bAlreadyTalked005 = Conversation.bTempTalked; sAvailableWeapons005 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker005; iAvailableMacGuffins005 = iTempMacGuffins; NPC005_CurrentNumLocation = iTempLocation; NPC005_LastLocation = iTempLastLocation; NPC005_LastStrLocation = sTempLastLocation; NPC005_CurrentStrLocation = sTempCurrentLocation; DesireToMove005 = iTempDesireToMove; bCorpse005 = bTempCorpse; iClose005 = iCloseEncounters; Notebook.bNoted005 = Notebook.bTempNoted; Notebook.iObserved005 = Notebook.iTempObserved; NPC_Traits.TraitOne005 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo005 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree005 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne005 = Notebook.bNoteOne; Notebook.bNoteTwo005 = Notebook.bNoteTwo; Notebook.bNoteThree005 = Notebook.bNoteThree; iLoyalty005 = iTempLoyalty; bCorpse005 = bTempCorpse; Flood.bPutInDanger005 = Flood.bPutInDanger; }
            if (tempNPC == NPC_006) { Conversation.bAlreadyTalked006 = Conversation.bTempTalked; sAvailableWeapons006 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker006; iAvailableMacGuffins006 = iTempMacGuffins; NPC006_CurrentNumLocation = iTempLocation; NPC006_LastLocation = iTempLastLocation; NPC006_LastStrLocation = sTempLastLocation; NPC006_CurrentStrLocation = sTempCurrentLocation; DesireToMove006 = iTempDesireToMove; bCorpse006 = bTempCorpse; iClose006 = iCloseEncounters; Notebook.bNoted006 = Notebook.bTempNoted; Notebook.iObserved006 = Notebook.iTempObserved; NPC_Traits.TraitOne006 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo006 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree006 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne006 = Notebook.bNoteOne; Notebook.bNoteTwo006 = Notebook.bNoteTwo; Notebook.bNoteThree006 = Notebook.bNoteThree; iLoyalty006 = iTempLoyalty; bCorpse006 = bTempCorpse; Flood.bPutInDanger006 = Flood.bPutInDanger; }
            if (tempNPC == NPC_007) { Conversation.bAlreadyTalked007 = Conversation.bTempTalked; sAvailableWeapons007 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker007; iAvailableMacGuffins007 = iTempMacGuffins; NPC007_CurrentNumLocation = iTempLocation; NPC007_LastLocation = iTempLastLocation; NPC007_LastStrLocation = sTempLastLocation; NPC007_CurrentStrLocation = sTempCurrentLocation; DesireToMove007 = iTempDesireToMove; bCorpse007 = bTempCorpse; iClose007 = iCloseEncounters; Notebook.bNoted007 = Notebook.bTempNoted; Notebook.iObserved007 = Notebook.iTempObserved; NPC_Traits.TraitOne007 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo007 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree007 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne007 = Notebook.bNoteOne; Notebook.bNoteTwo007 = Notebook.bNoteTwo; Notebook.bNoteThree007 = Notebook.bNoteThree; iLoyalty007 = iTempLoyalty; bCorpse007 = bTempCorpse; Flood.bPutInDanger007 = Flood.bPutInDanger; }
            if (tempNPC == NPC_008) { Conversation.bAlreadyTalked008 = Conversation.bTempTalked; sAvailableWeapons008 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker008; iAvailableMacGuffins008 = iTempMacGuffins; NPC008_CurrentNumLocation = iTempLocation; NPC008_LastLocation = iTempLastLocation; NPC008_LastStrLocation = sTempLastLocation; NPC008_CurrentStrLocation = sTempCurrentLocation; DesireToMove008 = iTempDesireToMove; bCorpse008 = bTempCorpse; iClose008 = iCloseEncounters; Notebook.bNoted008 = Notebook.bTempNoted; Notebook.iObserved008 = Notebook.iTempObserved; NPC_Traits.TraitOne008 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo008 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree008 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne008 = Notebook.bNoteOne; Notebook.bNoteTwo008 = Notebook.bNoteTwo; Notebook.bNoteThree008 = Notebook.bNoteThree; iLoyalty008 = iTempLoyalty; bCorpse008 = bTempCorpse; Flood.bPutInDanger008 = Flood.bPutInDanger; }
            if (tempNPC == NPC_009) { Conversation.bAlreadyTalked009 = Conversation.bTempTalked; sAvailableWeapons009 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker009; iAvailableMacGuffins009 = iTempMacGuffins; NPC009_CurrentNumLocation = iTempLocation; NPC009_LastLocation = iTempLastLocation; NPC009_LastStrLocation = sTempLastLocation; NPC009_CurrentStrLocation = sTempCurrentLocation; DesireToMove009 = iTempDesireToMove; bCorpse009 = bTempCorpse; iClose009 = iCloseEncounters; Notebook.bNoted009 = Notebook.bTempNoted; Notebook.iObserved009 = Notebook.iTempObserved; NPC_Traits.TraitOne009 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo009 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree009 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne009 = Notebook.bNoteOne; Notebook.bNoteTwo009 = Notebook.bNoteTwo; Notebook.bNoteThree009 = Notebook.bNoteThree; iLoyalty009 = iTempLoyalty; bCorpse009 = bTempCorpse; Flood.bPutInDanger009 = Flood.bPutInDanger; }
            if (tempNPC == NPC_010) { Conversation.bAlreadyTalked010 = Conversation.bTempTalked; sAvailableWeapons010 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker010; iAvailableMacGuffins010 = iTempMacGuffins; NPC010_CurrentNumLocation = iTempLocation; NPC010_LastLocation = iTempLastLocation; NPC010_LastStrLocation = sTempLastLocation; NPC010_CurrentStrLocation = sTempCurrentLocation; DesireToMove010 = iTempDesireToMove; bCorpse010 = bTempCorpse; iClose010 = iCloseEncounters; Notebook.bNoted010 = Notebook.bTempNoted; Notebook.iObserved010 = Notebook.iTempObserved; NPC_Traits.TraitOne010 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo010 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree010 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne010 = Notebook.bNoteOne; Notebook.bNoteTwo010 = Notebook.bNoteTwo; Notebook.bNoteThree010 = Notebook.bNoteThree; iLoyalty010 = iTempLoyalty; bCorpse010 = bTempCorpse; Flood.bPutInDanger010 = Flood.bPutInDanger; }
            if (tempNPC == NPC_011) { Conversation.bAlreadyTalked011 = Conversation.bTempTalked; sAvailableWeapons011 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker011; iAvailableMacGuffins011 = iTempMacGuffins; NPC011_CurrentNumLocation = iTempLocation; NPC011_LastLocation = iTempLastLocation; NPC011_LastStrLocation = sTempLastLocation; NPC011_CurrentStrLocation = sTempCurrentLocation; DesireToMove011 = iTempDesireToMove; bCorpse011 = bTempCorpse; iClose011 = iCloseEncounters; Notebook.bNoted011 = Notebook.bTempNoted; Notebook.iObserved011 = Notebook.iTempObserved; NPC_Traits.TraitOne011 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo011 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree011 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne011 = Notebook.bNoteOne; Notebook.bNoteTwo011 = Notebook.bNoteTwo; Notebook.bNoteThree011 = Notebook.bNoteThree; iLoyalty011 = iTempLoyalty; bCorpse011 = bTempCorpse; Flood.bPutInDanger011 = Flood.bPutInDanger; }
            if (tempNPC == NPC_012) { Conversation.bAlreadyTalked012 = Conversation.bTempTalked; sAvailableWeapons012 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker012; iAvailableMacGuffins012 = iTempMacGuffins; NPC012_CurrentNumLocation = iTempLocation; NPC012_LastLocation = iTempLastLocation; NPC012_LastStrLocation = sTempLastLocation; NPC012_CurrentStrLocation = sTempCurrentLocation; DesireToMove012 = iTempDesireToMove; bCorpse012 = bTempCorpse; iClose012 = iCloseEncounters; Notebook.bNoted012 = Notebook.bTempNoted; Notebook.iObserved012 = Notebook.iTempObserved; NPC_Traits.TraitOne012 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo012 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree012 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne012 = Notebook.bNoteOne; Notebook.bNoteTwo012 = Notebook.bNoteTwo; Notebook.bNoteThree012 = Notebook.bNoteThree; iLoyalty012 = iTempLoyalty; bCorpse012 = bTempCorpse; Flood.bPutInDanger012 = Flood.bPutInDanger; }
            if (tempNPC == NPC_013) { Conversation.bAlreadyTalked013 = Conversation.bTempTalked; sAvailableWeapons013 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker013; iAvailableMacGuffins013 = iTempMacGuffins; NPC013_CurrentNumLocation = iTempLocation; NPC013_LastLocation = iTempLastLocation; NPC013_LastStrLocation = sTempLastLocation; NPC013_CurrentStrLocation = sTempCurrentLocation; DesireToMove013 = iTempDesireToMove; bCorpse013 = bTempCorpse; iClose013 = iCloseEncounters; Notebook.bNoted013 = Notebook.bTempNoted; Notebook.iObserved013 = Notebook.iTempObserved; NPC_Traits.TraitOne013 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo013 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree013 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne013 = Notebook.bNoteOne; Notebook.bNoteTwo013 = Notebook.bNoteTwo; Notebook.bNoteThree013 = Notebook.bNoteThree; iLoyalty013 = iTempLoyalty; bCorpse013 = bTempCorpse; Flood.bPutInDanger013 = Flood.bPutInDanger; }
            if (tempNPC == NPC_014) { Conversation.bAlreadyTalked014 = Conversation.bTempTalked; sAvailableWeapons014 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker014; iAvailableMacGuffins014 = iTempMacGuffins; NPC014_CurrentNumLocation = iTempLocation; NPC014_LastLocation = iTempLastLocation; NPC014_LastStrLocation = sTempLastLocation; NPC014_CurrentStrLocation = sTempCurrentLocation; DesireToMove014 = iTempDesireToMove; bCorpse014 = bTempCorpse; iClose014 = iCloseEncounters; Notebook.bNoted014 = Notebook.bTempNoted; Notebook.iObserved014 = Notebook.iTempObserved; NPC_Traits.TraitOne014 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo014 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree014 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne014 = Notebook.bNoteOne; Notebook.bNoteTwo014 = Notebook.bNoteTwo; Notebook.bNoteThree014 = Notebook.bNoteThree; iLoyalty014 = iTempLoyalty; bCorpse014 = bTempCorpse; Flood.bPutInDanger014 = Flood.bPutInDanger; }
            if (tempNPC == NPC_015) { Conversation.bAlreadyTalked015 = Conversation.bTempTalked; sAvailableWeapons015 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker015; iAvailableMacGuffins015 = iTempMacGuffins; NPC015_CurrentNumLocation = iTempLocation; NPC015_LastLocation = iTempLastLocation; NPC015_LastStrLocation = sTempLastLocation; NPC015_CurrentStrLocation = sTempCurrentLocation; DesireToMove015 = iTempDesireToMove; bCorpse015 = bTempCorpse; iClose015 = iCloseEncounters; Notebook.bNoted015 = Notebook.bTempNoted; Notebook.iObserved015 = Notebook.iTempObserved; NPC_Traits.TraitOne015 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo015 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree015 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne015 = Notebook.bNoteOne; Notebook.bNoteTwo015 = Notebook.bNoteTwo; Notebook.bNoteThree015 = Notebook.bNoteThree; iLoyalty015 = iTempLoyalty; bCorpse015 = bTempCorpse; Flood.bPutInDanger015 = Flood.bPutInDanger; }
            if (tempNPC == NPC_016) { Conversation.bAlreadyTalked016 = Conversation.bTempTalked; sAvailableWeapons016 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker016; iAvailableMacGuffins016 = iTempMacGuffins; NPC016_CurrentNumLocation = iTempLocation; NPC016_LastLocation = iTempLastLocation; NPC016_LastStrLocation = sTempLastLocation; NPC016_CurrentStrLocation = sTempCurrentLocation; DesireToMove016 = iTempDesireToMove; bCorpse016 = bTempCorpse; iClose016 = iCloseEncounters; Notebook.bNoted016 = Notebook.bTempNoted; Notebook.iObserved016 = Notebook.iTempObserved; NPC_Traits.TraitOne016 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo016 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree016 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne016 = Notebook.bNoteOne; Notebook.bNoteTwo016 = Notebook.bNoteTwo; Notebook.bNoteThree016 = Notebook.bNoteThree; iLoyalty016 = iTempLoyalty; bCorpse016 = bTempCorpse; Flood.bPutInDanger016 = Flood.bPutInDanger; }
            if (tempNPC == NPC_017) { Conversation.bAlreadyTalked017 = Conversation.bTempTalked; sAvailableWeapons017 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker017; iAvailableMacGuffins017 = iTempMacGuffins; NPC017_CurrentNumLocation = iTempLocation; NPC017_LastLocation = iTempLastLocation; NPC017_LastStrLocation = sTempLastLocation; NPC017_CurrentStrLocation = sTempCurrentLocation; DesireToMove017 = iTempDesireToMove; bCorpse017 = bTempCorpse; iClose017 = iCloseEncounters; Notebook.bNoted017 = Notebook.bTempNoted; Notebook.iObserved017 = Notebook.iTempObserved; NPC_Traits.TraitOne017 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo017 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree017 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne017 = Notebook.bNoteOne; Notebook.bNoteTwo017 = Notebook.bNoteTwo; Notebook.bNoteThree017 = Notebook.bNoteThree; iLoyalty017 = iTempLoyalty; bCorpse017 = bTempCorpse; Flood.bPutInDanger017 = Flood.bPutInDanger; }
            if (tempNPC == NPC_018) { Conversation.bAlreadyTalked018 = Conversation.bTempTalked; sAvailableWeapons018 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker018; iAvailableMacGuffins018 = iTempMacGuffins; NPC018_CurrentNumLocation = iTempLocation; NPC018_LastLocation = iTempLastLocation; NPC018_LastStrLocation = sTempLastLocation; NPC018_CurrentStrLocation = sTempCurrentLocation; DesireToMove018 = iTempDesireToMove; bCorpse018 = bTempCorpse; iClose018 = iCloseEncounters; Notebook.bNoted018 = Notebook.bTempNoted; Notebook.iObserved018 = Notebook.iTempObserved; NPC_Traits.TraitOne018 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo018 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree018 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne018 = Notebook.bNoteOne; Notebook.bNoteTwo018 = Notebook.bNoteTwo; Notebook.bNoteThree018 = Notebook.bNoteThree; iLoyalty018 = iTempLoyalty; bCorpse018 = bTempCorpse; Flood.bPutInDanger018 = Flood.bPutInDanger; }
            if (tempNPC == NPC_019) { Conversation.bAlreadyTalked019 = Conversation.bTempTalked; sAvailableWeapons019 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker019; iAvailableMacGuffins019 = iTempMacGuffins; NPC019_CurrentNumLocation = iTempLocation; NPC019_LastLocation = iTempLastLocation; NPC019_LastStrLocation = sTempLastLocation; NPC019_CurrentStrLocation = sTempCurrentLocation; DesireToMove019 = iTempDesireToMove; bCorpse019 = bTempCorpse; iClose019 = iCloseEncounters; Notebook.bNoted019 = Notebook.bTempNoted; Notebook.iObserved019 = Notebook.iTempObserved; NPC_Traits.TraitOne019 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo019 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree019 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne019 = Notebook.bNoteOne; Notebook.bNoteTwo019 = Notebook.bNoteTwo; Notebook.bNoteThree019 = Notebook.bNoteThree; iLoyalty019 = iTempLoyalty; bCorpse019 = bTempCorpse; Flood.bPutInDanger019 = Flood.bPutInDanger; }
            if (tempNPC == NPC_020) { Conversation.bAlreadyTalked020 = Conversation.bTempTalked; sAvailableWeapons020 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker020; iAvailableMacGuffins020 = iTempMacGuffins; NPC020_CurrentNumLocation = iTempLocation; NPC020_LastLocation = iTempLastLocation; NPC020_LastStrLocation = sTempLastLocation; NPC020_CurrentStrLocation = sTempCurrentLocation; DesireToMove020 = iTempDesireToMove; bCorpse020 = bTempCorpse; iClose020 = iCloseEncounters; Notebook.bNoted020 = Notebook.bTempNoted; Notebook.iObserved020 = Notebook.iTempObserved; NPC_Traits.TraitOne020 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo020 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree020 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne020 = Notebook.bNoteOne; Notebook.bNoteTwo020 = Notebook.bNoteTwo; Notebook.bNoteThree020 = Notebook.bNoteThree; iLoyalty020 = iTempLoyalty; bCorpse020 = bTempCorpse; Flood.bPutInDanger020 = Flood.bPutInDanger; }
            if (tempNPC == NPC_021) { Conversation.bAlreadyTalked021 = Conversation.bTempTalked; sAvailableWeapons021 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker021; iAvailableMacGuffins021 = iTempMacGuffins; NPC021_CurrentNumLocation = iTempLocation; NPC021_LastLocation = iTempLastLocation; NPC021_LastStrLocation = sTempLastLocation; NPC021_CurrentStrLocation = sTempCurrentLocation; DesireToMove021 = iTempDesireToMove; bCorpse021 = bTempCorpse; iClose021 = iCloseEncounters; Notebook.bNoted021 = Notebook.bTempNoted; Notebook.iObserved021 = Notebook.iTempObserved; NPC_Traits.TraitOne021 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo021 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree021 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne021 = Notebook.bNoteOne; Notebook.bNoteTwo021 = Notebook.bNoteTwo; Notebook.bNoteThree021 = Notebook.bNoteThree; iLoyalty021 = iTempLoyalty; bCorpse021 = bTempCorpse; Flood.bPutInDanger021 = Flood.bPutInDanger; }
            if (tempNPC == NPC_022) { Conversation.bAlreadyTalked022 = Conversation.bTempTalked; sAvailableWeapons022 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker022; iAvailableMacGuffins022 = iTempMacGuffins; NPC022_CurrentNumLocation = iTempLocation; NPC022_LastLocation = iTempLastLocation; NPC022_LastStrLocation = sTempLastLocation; NPC022_CurrentStrLocation = sTempCurrentLocation; DesireToMove022 = iTempDesireToMove; bCorpse022 = bTempCorpse; iClose022 = iCloseEncounters; Notebook.bNoted022 = Notebook.bTempNoted; Notebook.iObserved022 = Notebook.iTempObserved; NPC_Traits.TraitOne022 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo022 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree022 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne022 = Notebook.bNoteOne; Notebook.bNoteTwo022 = Notebook.bNoteTwo; Notebook.bNoteThree022 = Notebook.bNoteThree; iLoyalty022 = iTempLoyalty; bCorpse022 = bTempCorpse; Flood.bPutInDanger022 = Flood.bPutInDanger; }
            if (tempNPC == NPC_023) { Conversation.bAlreadyTalked023 = Conversation.bTempTalked; sAvailableWeapons023 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker023; iAvailableMacGuffins023 = iTempMacGuffins; NPC023_CurrentNumLocation = iTempLocation; NPC023_LastLocation = iTempLastLocation; NPC023_LastStrLocation = sTempLastLocation; NPC023_CurrentStrLocation = sTempCurrentLocation; DesireToMove023 = iTempDesireToMove; bCorpse023 = bTempCorpse; iClose023 = iCloseEncounters; Notebook.bNoted023 = Notebook.bTempNoted; Notebook.iObserved023 = Notebook.iTempObserved; NPC_Traits.TraitOne023 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo023 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree023 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne023 = Notebook.bNoteOne; Notebook.bNoteTwo023 = Notebook.bNoteTwo; Notebook.bNoteThree023 = Notebook.bNoteThree; iLoyalty023 = iTempLoyalty; bCorpse023 = bTempCorpse; Flood.bPutInDanger023 = Flood.bPutInDanger; }
            if (tempNPC == NPC_024) { Conversation.bAlreadyTalked024 = Conversation.bTempTalked; sAvailableWeapons024 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker024; iAvailableMacGuffins024 = iTempMacGuffins; NPC024_CurrentNumLocation = iTempLocation; NPC024_LastLocation = iTempLastLocation; NPC024_LastStrLocation = sTempLastLocation; NPC024_CurrentStrLocation = sTempCurrentLocation; DesireToMove024 = iTempDesireToMove; bCorpse024 = bTempCorpse; iClose024 = iCloseEncounters; Notebook.bNoted024 = Notebook.bTempNoted; Notebook.iObserved024 = Notebook.iTempObserved; NPC_Traits.TraitOne024 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo024 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree024 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne024 = Notebook.bNoteOne; Notebook.bNoteTwo024 = Notebook.bNoteTwo; Notebook.bNoteThree024 = Notebook.bNoteThree; iLoyalty024 = iTempLoyalty; bCorpse024 = bTempCorpse; Flood.bPutInDanger024 = Flood.bPutInDanger; }
            if (tempNPC == NPC_025) { Conversation.bAlreadyTalked025 = Conversation.bTempTalked; sAvailableWeapons025 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker025; iAvailableMacGuffins025 = iTempMacGuffins; NPC025_CurrentNumLocation = iTempLocation; NPC025_LastLocation = iTempLastLocation; NPC025_LastStrLocation = sTempLastLocation; NPC025_CurrentStrLocation = sTempCurrentLocation; DesireToMove025 = iTempDesireToMove; bCorpse025 = bTempCorpse; iClose025 = iCloseEncounters; Notebook.bNoted025 = Notebook.bTempNoted; Notebook.iObserved025 = Notebook.iTempObserved; NPC_Traits.TraitOne025 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo025 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree025 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne025 = Notebook.bNoteOne; Notebook.bNoteTwo025 = Notebook.bNoteTwo; Notebook.bNoteThree025 = Notebook.bNoteThree; iLoyalty025 = iTempLoyalty; bCorpse025 = bTempCorpse; Flood.bPutInDanger025 = Flood.bPutInDanger; }
            if (tempNPC == NPC_026) { Conversation.bAlreadyTalked026 = Conversation.bTempTalked; sAvailableWeapons026 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker026; iAvailableMacGuffins026 = iTempMacGuffins; NPC026_CurrentNumLocation = iTempLocation; NPC026_LastLocation = iTempLastLocation; NPC026_LastStrLocation = sTempLastLocation; NPC026_CurrentStrLocation = sTempCurrentLocation; DesireToMove026 = iTempDesireToMove; bCorpse026 = bTempCorpse; iClose026 = iCloseEncounters; Notebook.bNoted026 = Notebook.bTempNoted; Notebook.iObserved026 = Notebook.iTempObserved; NPC_Traits.TraitOne026 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo026 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree026 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne026 = Notebook.bNoteOne; Notebook.bNoteTwo026 = Notebook.bNoteTwo; Notebook.bNoteThree026 = Notebook.bNoteThree; iLoyalty026 = iTempLoyalty; bCorpse026 = bTempCorpse; Flood.bPutInDanger026 = Flood.bPutInDanger; }
            if (tempNPC == NPC_027) { Conversation.bAlreadyTalked027 = Conversation.bTempTalked; sAvailableWeapons027 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker027; iAvailableMacGuffins027 = iTempMacGuffins; NPC027_CurrentNumLocation = iTempLocation; NPC027_LastLocation = iTempLastLocation; NPC027_LastStrLocation = sTempLastLocation; NPC027_CurrentStrLocation = sTempCurrentLocation; DesireToMove027 = iTempDesireToMove; bCorpse027 = bTempCorpse; iClose027 = iCloseEncounters; Notebook.bNoted027 = Notebook.bTempNoted; Notebook.iObserved027 = Notebook.iTempObserved; NPC_Traits.TraitOne027 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo027 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree027 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne027 = Notebook.bNoteOne; Notebook.bNoteTwo027 = Notebook.bNoteTwo; Notebook.bNoteThree027 = Notebook.bNoteThree; iLoyalty027 = iTempLoyalty; bCorpse027 = bTempCorpse; Flood.bPutInDanger027 = Flood.bPutInDanger; }
            if (tempNPC == NPC_028) { Conversation.bAlreadyTalked028 = Conversation.bTempTalked; sAvailableWeapons028 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker028; iAvailableMacGuffins028 = iTempMacGuffins; NPC028_CurrentNumLocation = iTempLocation; NPC028_LastLocation = iTempLastLocation; NPC028_LastStrLocation = sTempLastLocation; NPC028_CurrentStrLocation = sTempCurrentLocation; DesireToMove028 = iTempDesireToMove; bCorpse028 = bTempCorpse; iClose028 = iCloseEncounters; Notebook.bNoted028 = Notebook.bTempNoted; Notebook.iObserved028 = Notebook.iTempObserved; NPC_Traits.TraitOne028 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo028 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree028 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne028 = Notebook.bNoteOne; Notebook.bNoteTwo028 = Notebook.bNoteTwo; Notebook.bNoteThree028 = Notebook.bNoteThree; iLoyalty028 = iTempLoyalty; bCorpse028 = bTempCorpse; Flood.bPutInDanger028 = Flood.bPutInDanger; }
            if (tempNPC == NPC_029) { Conversation.bAlreadyTalked029 = Conversation.bTempTalked; sAvailableWeapons029 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker029; iAvailableMacGuffins029 = iTempMacGuffins; NPC029_CurrentNumLocation = iTempLocation; NPC029_LastLocation = iTempLastLocation; NPC029_LastStrLocation = sTempLastLocation; NPC029_CurrentStrLocation = sTempCurrentLocation; DesireToMove029 = iTempDesireToMove; bCorpse029 = bTempCorpse; iClose029 = iCloseEncounters; Notebook.bNoted029 = Notebook.bTempNoted; Notebook.iObserved029 = Notebook.iTempObserved; NPC_Traits.TraitOne029 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo029 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree029 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne029 = Notebook.bNoteOne; Notebook.bNoteTwo029 = Notebook.bNoteTwo; Notebook.bNoteThree029 = Notebook.bNoteThree; iLoyalty029 = iTempLoyalty; bCorpse029 = bTempCorpse; Flood.bPutInDanger029 = Flood.bPutInDanger; }
            if (tempNPC == NPC_030) { Conversation.bAlreadyTalked030 = Conversation.bTempTalked; sAvailableWeapons030 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker030; iAvailableMacGuffins030 = iTempMacGuffins; NPC030_CurrentNumLocation = iTempLocation; NPC030_LastLocation = iTempLastLocation; NPC030_LastStrLocation = sTempLastLocation; NPC030_CurrentStrLocation = sTempCurrentLocation; DesireToMove030 = iTempDesireToMove; bCorpse030 = bTempCorpse; iClose030 = iCloseEncounters; Notebook.bNoted030 = Notebook.bTempNoted; Notebook.iObserved030 = Notebook.iTempObserved; NPC_Traits.TraitOne030 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo030 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree030 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne030 = Notebook.bNoteOne; Notebook.bNoteTwo030 = Notebook.bNoteTwo; Notebook.bNoteThree030 = Notebook.bNoteThree; iLoyalty030 = iTempLoyalty; bCorpse030 = bTempCorpse; Flood.bPutInDanger030 = Flood.bPutInDanger; }
            if (tempNPC == NPC_031) { Conversation.bAlreadyTalked031 = Conversation.bTempTalked; sAvailableWeapons031 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker031; iAvailableMacGuffins031 = iTempMacGuffins; NPC031_CurrentNumLocation = iTempLocation; NPC031_LastLocation = iTempLastLocation; NPC031_LastStrLocation = sTempLastLocation; NPC031_CurrentStrLocation = sTempCurrentLocation; DesireToMove031 = iTempDesireToMove; bCorpse031 = bTempCorpse; iClose031 = iCloseEncounters; Notebook.bNoted031 = Notebook.bTempNoted; Notebook.iObserved031 = Notebook.iTempObserved; NPC_Traits.TraitOne031 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo031 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree031 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne031 = Notebook.bNoteOne; Notebook.bNoteTwo031 = Notebook.bNoteTwo; Notebook.bNoteThree031 = Notebook.bNoteThree; iLoyalty031 = iTempLoyalty; bCorpse031 = bTempCorpse; Flood.bPutInDanger031 = Flood.bPutInDanger; }
            if (tempNPC == NPC_032) { Conversation.bAlreadyTalked032 = Conversation.bTempTalked; sAvailableWeapons032 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker032; iAvailableMacGuffins032 = iTempMacGuffins; NPC032_CurrentNumLocation = iTempLocation; NPC032_LastLocation = iTempLastLocation; NPC032_LastStrLocation = sTempLastLocation; NPC032_CurrentStrLocation = sTempCurrentLocation; DesireToMove032 = iTempDesireToMove; bCorpse032 = bTempCorpse; iClose032 = iCloseEncounters; Notebook.bNoted032 = Notebook.bTempNoted; Notebook.iObserved032 = Notebook.iTempObserved; NPC_Traits.TraitOne032 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo032 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree032 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne032 = Notebook.bNoteOne; Notebook.bNoteTwo032 = Notebook.bNoteTwo; Notebook.bNoteThree032 = Notebook.bNoteThree; iLoyalty032 = iTempLoyalty; bCorpse032 = bTempCorpse; Flood.bPutInDanger032 = Flood.bPutInDanger; }
            if (tempNPC == NPC_033) { Conversation.bAlreadyTalked033 = Conversation.bTempTalked; sAvailableWeapons033 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker033; iAvailableMacGuffins033 = iTempMacGuffins; NPC033_CurrentNumLocation = iTempLocation; NPC033_LastLocation = iTempLastLocation; NPC033_LastStrLocation = sTempLastLocation; NPC033_CurrentStrLocation = sTempCurrentLocation; DesireToMove033 = iTempDesireToMove; bCorpse033 = bTempCorpse; iClose033 = iCloseEncounters; Notebook.bNoted033 = Notebook.bTempNoted; Notebook.iObserved033 = Notebook.iTempObserved; NPC_Traits.TraitOne033 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo033 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree033 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne033 = Notebook.bNoteOne; Notebook.bNoteTwo033 = Notebook.bNoteTwo; Notebook.bNoteThree033 = Notebook.bNoteThree; iLoyalty033 = iTempLoyalty; bCorpse033 = bTempCorpse; Flood.bPutInDanger033 = Flood.bPutInDanger; }
            if (tempNPC == NPC_034) { Conversation.bAlreadyTalked034 = Conversation.bTempTalked; sAvailableWeapons034 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker034; iAvailableMacGuffins034 = iTempMacGuffins; NPC034_CurrentNumLocation = iTempLocation; NPC034_LastLocation = iTempLastLocation; NPC034_LastStrLocation = sTempLastLocation; NPC034_CurrentStrLocation = sTempCurrentLocation; DesireToMove034 = iTempDesireToMove; bCorpse034 = bTempCorpse; iClose034 = iCloseEncounters; Notebook.bNoted034 = Notebook.bTempNoted; Notebook.iObserved034 = Notebook.iTempObserved; NPC_Traits.TraitOne034 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo034 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree034 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne034 = Notebook.bNoteOne; Notebook.bNoteTwo034 = Notebook.bNoteTwo; Notebook.bNoteThree034 = Notebook.bNoteThree; iLoyalty034 = iTempLoyalty; bCorpse034 = bTempCorpse; Flood.bPutInDanger034 = Flood.bPutInDanger; }
            if (tempNPC == NPC_035) { Conversation.bAlreadyTalked035 = Conversation.bTempTalked; sAvailableWeapons035 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker035; iAvailableMacGuffins035 = iTempMacGuffins; NPC035_CurrentNumLocation = iTempLocation; NPC035_LastLocation = iTempLastLocation; NPC035_LastStrLocation = sTempLastLocation; NPC035_CurrentStrLocation = sTempCurrentLocation; DesireToMove035 = iTempDesireToMove; bCorpse035 = bTempCorpse; iClose035 = iCloseEncounters; Notebook.bNoted035 = Notebook.bTempNoted; Notebook.iObserved035 = Notebook.iTempObserved; NPC_Traits.TraitOne035 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo035 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree035 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne035 = Notebook.bNoteOne; Notebook.bNoteTwo035 = Notebook.bNoteTwo; Notebook.bNoteThree035 = Notebook.bNoteThree; iLoyalty035 = iTempLoyalty; bCorpse035 = bTempCorpse; Flood.bPutInDanger035 = Flood.bPutInDanger; }
            if (tempNPC == NPC_036) { Conversation.bAlreadyTalked036 = Conversation.bTempTalked; sAvailableWeapons036 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker036; iAvailableMacGuffins036 = iTempMacGuffins; NPC036_CurrentNumLocation = iTempLocation; NPC036_LastLocation = iTempLastLocation; NPC036_LastStrLocation = sTempLastLocation; NPC036_CurrentStrLocation = sTempCurrentLocation; DesireToMove036 = iTempDesireToMove; bCorpse036 = bTempCorpse; iClose036 = iCloseEncounters; Notebook.bNoted036 = Notebook.bTempNoted; Notebook.iObserved036 = Notebook.iTempObserved; NPC_Traits.TraitOne036 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo036 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree036 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne036 = Notebook.bNoteOne; Notebook.bNoteTwo036 = Notebook.bNoteTwo; Notebook.bNoteThree036 = Notebook.bNoteThree; iLoyalty036 = iTempLoyalty; bCorpse036 = bTempCorpse; Flood.bPutInDanger036 = Flood.bPutInDanger; }
            if (tempNPC == NPC_037) { Conversation.bAlreadyTalked037 = Conversation.bTempTalked; sAvailableWeapons037 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker037; iAvailableMacGuffins037 = iTempMacGuffins; NPC037_CurrentNumLocation = iTempLocation; NPC037_LastLocation = iTempLastLocation; NPC037_LastStrLocation = sTempLastLocation; NPC037_CurrentStrLocation = sTempCurrentLocation; DesireToMove037 = iTempDesireToMove; bCorpse037 = bTempCorpse; iClose037 = iCloseEncounters; Notebook.bNoted037 = Notebook.bTempNoted; Notebook.iObserved037 = Notebook.iTempObserved; NPC_Traits.TraitOne037 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo037 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree037 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne037 = Notebook.bNoteOne; Notebook.bNoteTwo037 = Notebook.bNoteTwo; Notebook.bNoteThree037 = Notebook.bNoteThree; iLoyalty037 = iTempLoyalty; bCorpse037 = bTempCorpse; Flood.bPutInDanger037 = Flood.bPutInDanger; }
            if (tempNPC == NPC_038) { Conversation.bAlreadyTalked038 = Conversation.bTempTalked; sAvailableWeapons038 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker038; iAvailableMacGuffins038 = iTempMacGuffins; NPC038_CurrentNumLocation = iTempLocation; NPC038_LastLocation = iTempLastLocation; NPC038_LastStrLocation = sTempLastLocation; NPC038_CurrentStrLocation = sTempCurrentLocation; DesireToMove038 = iTempDesireToMove; bCorpse038 = bTempCorpse; iClose038 = iCloseEncounters; Notebook.bNoted038 = Notebook.bTempNoted; Notebook.iObserved038 = Notebook.iTempObserved; NPC_Traits.TraitOne038 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo038 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree038 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne038 = Notebook.bNoteOne; Notebook.bNoteTwo038 = Notebook.bNoteTwo; Notebook.bNoteThree038 = Notebook.bNoteThree; iLoyalty038 = iTempLoyalty; bCorpse038 = bTempCorpse; Flood.bPutInDanger038 = Flood.bPutInDanger; }
            if (tempNPC == NPC_039) { Conversation.bAlreadyTalked039 = Conversation.bTempTalked; sAvailableWeapons039 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker039; iAvailableMacGuffins039 = iTempMacGuffins; NPC039_CurrentNumLocation = iTempLocation; NPC039_LastLocation = iTempLastLocation; NPC039_LastStrLocation = sTempLastLocation; NPC039_CurrentStrLocation = sTempCurrentLocation; DesireToMove039 = iTempDesireToMove; bCorpse039 = bTempCorpse; iClose039 = iCloseEncounters; Notebook.bNoted039 = Notebook.bTempNoted; Notebook.iObserved039 = Notebook.iTempObserved; NPC_Traits.TraitOne039 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo039 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree039 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne039 = Notebook.bNoteOne; Notebook.bNoteTwo039 = Notebook.bNoteTwo; Notebook.bNoteThree039 = Notebook.bNoteThree; iLoyalty039 = iTempLoyalty; bCorpse039 = bTempCorpse; Flood.bPutInDanger039 = Flood.bPutInDanger; }
            if (tempNPC == NPC_040) { Conversation.bAlreadyTalked040 = Conversation.bTempTalked; sAvailableWeapons040 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker040; iAvailableMacGuffins040 = iTempMacGuffins; NPC040_CurrentNumLocation = iTempLocation; NPC040_LastLocation = iTempLastLocation; NPC040_LastStrLocation = sTempLastLocation; NPC040_CurrentStrLocation = sTempCurrentLocation; DesireToMove040 = iTempDesireToMove; bCorpse040 = bTempCorpse; iClose040 = iCloseEncounters; Notebook.bNoted040 = Notebook.bTempNoted; Notebook.iObserved040 = Notebook.iTempObserved; NPC_Traits.TraitOne040 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo040 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree040 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne040 = Notebook.bNoteOne; Notebook.bNoteTwo040 = Notebook.bNoteTwo; Notebook.bNoteThree040 = Notebook.bNoteThree; iLoyalty040 = iTempLoyalty; bCorpse040 = bTempCorpse; Flood.bPutInDanger040 = Flood.bPutInDanger; }
            if (tempNPC == NPC_041) { Conversation.bAlreadyTalked041 = Conversation.bTempTalked; sAvailableWeapons041 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker041; iAvailableMacGuffins041 = iTempMacGuffins; NPC041_CurrentNumLocation = iTempLocation; NPC041_LastLocation = iTempLastLocation; NPC041_LastStrLocation = sTempLastLocation; NPC041_CurrentStrLocation = sTempCurrentLocation; DesireToMove041 = iTempDesireToMove; bCorpse041 = bTempCorpse; iClose041 = iCloseEncounters; Notebook.bNoted041 = Notebook.bTempNoted; Notebook.iObserved041 = Notebook.iTempObserved; NPC_Traits.TraitOne041 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo041 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree041 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne041 = Notebook.bNoteOne; Notebook.bNoteTwo041 = Notebook.bNoteTwo; Notebook.bNoteThree041 = Notebook.bNoteThree; iLoyalty041 = iTempLoyalty; bCorpse041 = bTempCorpse; Flood.bPutInDanger041 = Flood.bPutInDanger; }
            if (tempNPC == NPC_042) { Conversation.bAlreadyTalked042 = Conversation.bTempTalked; sAvailableWeapons042 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker042; iAvailableMacGuffins042 = iTempMacGuffins; NPC042_CurrentNumLocation = iTempLocation; NPC042_LastLocation = iTempLastLocation; NPC042_LastStrLocation = sTempLastLocation; NPC042_CurrentStrLocation = sTempCurrentLocation; DesireToMove042 = iTempDesireToMove; bCorpse042 = bTempCorpse; iClose042 = iCloseEncounters; Notebook.bNoted042 = Notebook.bTempNoted; Notebook.iObserved042 = Notebook.iTempObserved; NPC_Traits.TraitOne042 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo042 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree042 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne042 = Notebook.bNoteOne; Notebook.bNoteTwo042 = Notebook.bNoteTwo; Notebook.bNoteThree042 = Notebook.bNoteThree; iLoyalty042 = iTempLoyalty; bCorpse042 = bTempCorpse; Flood.bPutInDanger042 = Flood.bPutInDanger; }
            if (tempNPC == NPC_043) { Conversation.bAlreadyTalked043 = Conversation.bTempTalked; sAvailableWeapons043 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker043; iAvailableMacGuffins043 = iTempMacGuffins; NPC043_CurrentNumLocation = iTempLocation; NPC043_LastLocation = iTempLastLocation; NPC043_LastStrLocation = sTempLastLocation; NPC043_CurrentStrLocation = sTempCurrentLocation; DesireToMove043 = iTempDesireToMove; bCorpse043 = bTempCorpse; iClose043 = iCloseEncounters; Notebook.bNoted043 = Notebook.bTempNoted; Notebook.iObserved043 = Notebook.iTempObserved; NPC_Traits.TraitOne043 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo043 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree043 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne043 = Notebook.bNoteOne; Notebook.bNoteTwo043 = Notebook.bNoteTwo; Notebook.bNoteThree043 = Notebook.bNoteThree; iLoyalty043 = iTempLoyalty; bCorpse043 = bTempCorpse; Flood.bPutInDanger043 = Flood.bPutInDanger; }
            if (tempNPC == NPC_044) { Conversation.bAlreadyTalked044 = Conversation.bTempTalked; sAvailableWeapons044 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker044; iAvailableMacGuffins044 = iTempMacGuffins; NPC044_CurrentNumLocation = iTempLocation; NPC044_LastLocation = iTempLastLocation; NPC044_LastStrLocation = sTempLastLocation; NPC044_CurrentStrLocation = sTempCurrentLocation; DesireToMove044 = iTempDesireToMove; bCorpse044 = bTempCorpse; iClose044 = iCloseEncounters; Notebook.bNoted044 = Notebook.bTempNoted; Notebook.iObserved044 = Notebook.iTempObserved; NPC_Traits.TraitOne044 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo044 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree044 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne044 = Notebook.bNoteOne; Notebook.bNoteTwo044 = Notebook.bNoteTwo; Notebook.bNoteThree044 = Notebook.bNoteThree; iLoyalty044 = iTempLoyalty; bCorpse044 = bTempCorpse; Flood.bPutInDanger044 = Flood.bPutInDanger; }
            if (tempNPC == NPC_045) { Conversation.bAlreadyTalked045 = Conversation.bTempTalked; sAvailableWeapons045 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker045; iAvailableMacGuffins045 = iTempMacGuffins; NPC045_CurrentNumLocation = iTempLocation; NPC045_LastLocation = iTempLastLocation; NPC045_LastStrLocation = sTempLastLocation; NPC045_CurrentStrLocation = sTempCurrentLocation; DesireToMove045 = iTempDesireToMove; bCorpse045 = bTempCorpse; iClose045 = iCloseEncounters; Notebook.bNoted045 = Notebook.bTempNoted; Notebook.iObserved045 = Notebook.iTempObserved; NPC_Traits.TraitOne045 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo045 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree045 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne045 = Notebook.bNoteOne; Notebook.bNoteTwo045 = Notebook.bNoteTwo; Notebook.bNoteThree045 = Notebook.bNoteThree; iLoyalty045 = iTempLoyalty; bCorpse045 = bTempCorpse; Flood.bPutInDanger045 = Flood.bPutInDanger; }
            if (tempNPC == NPC_046) { Conversation.bAlreadyTalked046 = Conversation.bTempTalked; sAvailableWeapons046 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker046; iAvailableMacGuffins046 = iTempMacGuffins; NPC046_CurrentNumLocation = iTempLocation; NPC046_LastLocation = iTempLastLocation; NPC046_LastStrLocation = sTempLastLocation; NPC046_CurrentStrLocation = sTempCurrentLocation; DesireToMove046 = iTempDesireToMove; bCorpse046 = bTempCorpse; iClose046 = iCloseEncounters; Notebook.bNoted046 = Notebook.bTempNoted; Notebook.iObserved046 = Notebook.iTempObserved; NPC_Traits.TraitOne046 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo046 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree046 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne046 = Notebook.bNoteOne; Notebook.bNoteTwo046 = Notebook.bNoteTwo; Notebook.bNoteThree046 = Notebook.bNoteThree; iLoyalty046 = iTempLoyalty; bCorpse046 = bTempCorpse; Flood.bPutInDanger046 = Flood.bPutInDanger; }
            if (tempNPC == NPC_047) { Conversation.bAlreadyTalked047 = Conversation.bTempTalked; sAvailableWeapons047 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker047; iAvailableMacGuffins047 = iTempMacGuffins; NPC047_CurrentNumLocation = iTempLocation; NPC047_LastLocation = iTempLastLocation; NPC047_LastStrLocation = sTempLastLocation; NPC047_CurrentStrLocation = sTempCurrentLocation; DesireToMove047 = iTempDesireToMove; bCorpse047 = bTempCorpse; iClose047 = iCloseEncounters; Notebook.bNoted047 = Notebook.bTempNoted; Notebook.iObserved047 = Notebook.iTempObserved; NPC_Traits.TraitOne047 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo047 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree047 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne047 = Notebook.bNoteOne; Notebook.bNoteTwo047 = Notebook.bNoteTwo; Notebook.bNoteThree047 = Notebook.bNoteThree; iLoyalty047 = iTempLoyalty; bCorpse047 = bTempCorpse; Flood.bPutInDanger047 = Flood.bPutInDanger; }
            if (tempNPC == NPC_048) { Conversation.bAlreadyTalked048 = Conversation.bTempTalked; sAvailableWeapons048 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker048; iAvailableMacGuffins048 = iTempMacGuffins; NPC048_CurrentNumLocation = iTempLocation; NPC048_LastLocation = iTempLastLocation; NPC048_LastStrLocation = sTempLastLocation; NPC048_CurrentStrLocation = sTempCurrentLocation; DesireToMove048 = iTempDesireToMove; bCorpse048 = bTempCorpse; iClose048 = iCloseEncounters; Notebook.bNoted048 = Notebook.bTempNoted; Notebook.iObserved048 = Notebook.iTempObserved; NPC_Traits.TraitOne048 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo048 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree048 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne048 = Notebook.bNoteOne; Notebook.bNoteTwo048 = Notebook.bNoteTwo; Notebook.bNoteThree048 = Notebook.bNoteThree; iLoyalty048 = iTempLoyalty; bCorpse048 = bTempCorpse; Flood.bPutInDanger048 = Flood.bPutInDanger; }
            if (tempNPC == NPC_049) { Conversation.bAlreadyTalked049 = Conversation.bTempTalked; sAvailableWeapons049 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker049; iAvailableMacGuffins049 = iTempMacGuffins; NPC049_CurrentNumLocation = iTempLocation; NPC049_LastLocation = iTempLastLocation; NPC049_LastStrLocation = sTempLastLocation; NPC049_CurrentStrLocation = sTempCurrentLocation; DesireToMove049 = iTempDesireToMove; bCorpse049 = bTempCorpse; iClose049 = iCloseEncounters; Notebook.bNoted049 = Notebook.bTempNoted; Notebook.iObserved049 = Notebook.iTempObserved; NPC_Traits.TraitOne049 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo049 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree049 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne049 = Notebook.bNoteOne; Notebook.bNoteTwo049 = Notebook.bNoteTwo; Notebook.bNoteThree049 = Notebook.bNoteThree; iLoyalty049 = iTempLoyalty; bCorpse049 = bTempCorpse; Flood.bPutInDanger049 = Flood.bPutInDanger; }
            if (tempNPC == NPC_050) { Conversation.bAlreadyTalked050 = Conversation.bTempTalked; sAvailableWeapons050 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker050; iAvailableMacGuffins050 = iTempMacGuffins; NPC050_CurrentNumLocation = iTempLocation; NPC050_LastLocation = iTempLastLocation; NPC050_LastStrLocation = sTempLastLocation; NPC050_CurrentStrLocation = sTempCurrentLocation; DesireToMove050 = iTempDesireToMove; bCorpse050 = bTempCorpse; iClose050 = iCloseEncounters; Notebook.bNoted050 = Notebook.bTempNoted; Notebook.iObserved050 = Notebook.iTempObserved; NPC_Traits.TraitOne050 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo050 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree050 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne050 = Notebook.bNoteOne; Notebook.bNoteTwo050 = Notebook.bNoteTwo; Notebook.bNoteThree050 = Notebook.bNoteThree; iLoyalty050 = iTempLoyalty; bCorpse050 = bTempCorpse; Flood.bPutInDanger050 = Flood.bPutInDanger; }
            if (tempNPC == NPC_051) { Conversation.bAlreadyTalked051 = Conversation.bTempTalked; sAvailableWeapons051 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker051; iAvailableMacGuffins051 = iTempMacGuffins; NPC051_CurrentNumLocation = iTempLocation; NPC051_LastLocation = iTempLastLocation; NPC051_LastStrLocation = sTempLastLocation; NPC051_CurrentStrLocation = sTempCurrentLocation; DesireToMove051 = iTempDesireToMove; bCorpse051 = bTempCorpse; iClose051 = iCloseEncounters; Notebook.bNoted051 = Notebook.bTempNoted; Notebook.iObserved051 = Notebook.iTempObserved; NPC_Traits.TraitOne051 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo051 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree051 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne051 = Notebook.bNoteOne; Notebook.bNoteTwo051 = Notebook.bNoteTwo; Notebook.bNoteThree051 = Notebook.bNoteThree; iLoyalty051 = iTempLoyalty; bCorpse051 = bTempCorpse; Flood.bPutInDanger051 = Flood.bPutInDanger; }
            if (tempNPC == NPC_052) { Conversation.bAlreadyTalked052 = Conversation.bTempTalked; sAvailableWeapons052 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker052; iAvailableMacGuffins052 = iTempMacGuffins; NPC052_CurrentNumLocation = iTempLocation; NPC052_LastLocation = iTempLastLocation; NPC052_LastStrLocation = sTempLastLocation; NPC052_CurrentStrLocation = sTempCurrentLocation; DesireToMove052 = iTempDesireToMove; bCorpse052 = bTempCorpse; iClose052 = iCloseEncounters; Notebook.bNoted052 = Notebook.bTempNoted; Notebook.iObserved052 = Notebook.iTempObserved; NPC_Traits.TraitOne052 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo052 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree052 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne052 = Notebook.bNoteOne; Notebook.bNoteTwo052 = Notebook.bNoteTwo; Notebook.bNoteThree052 = Notebook.bNoteThree; iLoyalty052 = iTempLoyalty; bCorpse052 = bTempCorpse; Flood.bPutInDanger052 = Flood.bPutInDanger; }
            if (tempNPC == NPC_053) { Conversation.bAlreadyTalked053 = Conversation.bTempTalked; sAvailableWeapons053 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker053; iAvailableMacGuffins053 = iTempMacGuffins; NPC053_CurrentNumLocation = iTempLocation; NPC053_LastLocation = iTempLastLocation; NPC053_LastStrLocation = sTempLastLocation; NPC053_CurrentStrLocation = sTempCurrentLocation; DesireToMove053 = iTempDesireToMove; bCorpse053 = bTempCorpse; iClose053 = iCloseEncounters; Notebook.bNoted053 = Notebook.bTempNoted; Notebook.iObserved053 = Notebook.iTempObserved; NPC_Traits.TraitOne053 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo053 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree053 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne053 = Notebook.bNoteOne; Notebook.bNoteTwo053 = Notebook.bNoteTwo; Notebook.bNoteThree053 = Notebook.bNoteThree; iLoyalty053 = iTempLoyalty; bCorpse053 = bTempCorpse; Flood.bPutInDanger053 = Flood.bPutInDanger; }
            if (tempNPC == NPC_054) { Conversation.bAlreadyTalked054 = Conversation.bTempTalked; sAvailableWeapons054 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker054; iAvailableMacGuffins054 = iTempMacGuffins; NPC054_CurrentNumLocation = iTempLocation; NPC054_LastLocation = iTempLastLocation; NPC054_LastStrLocation = sTempLastLocation; NPC054_CurrentStrLocation = sTempCurrentLocation; DesireToMove054 = iTempDesireToMove; bCorpse054 = bTempCorpse; iClose054 = iCloseEncounters; Notebook.bNoted054 = Notebook.bTempNoted; Notebook.iObserved054 = Notebook.iTempObserved; NPC_Traits.TraitOne054 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo054 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree054 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne054 = Notebook.bNoteOne; Notebook.bNoteTwo054 = Notebook.bNoteTwo; Notebook.bNoteThree054 = Notebook.bNoteThree; iLoyalty054 = iTempLoyalty; bCorpse054 = bTempCorpse; Flood.bPutInDanger054 = Flood.bPutInDanger; }
            if (tempNPC == NPC_055) { Conversation.bAlreadyTalked055 = Conversation.bTempTalked; sAvailableWeapons055 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker055; iAvailableMacGuffins055 = iTempMacGuffins; NPC055_CurrentNumLocation = iTempLocation; NPC055_LastLocation = iTempLastLocation; NPC055_LastStrLocation = sTempLastLocation; NPC055_CurrentStrLocation = sTempCurrentLocation; DesireToMove055 = iTempDesireToMove; bCorpse055 = bTempCorpse; iClose055 = iCloseEncounters; Notebook.bNoted055 = Notebook.bTempNoted; Notebook.iObserved055 = Notebook.iTempObserved; NPC_Traits.TraitOne055 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo055 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree055 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne055 = Notebook.bNoteOne; Notebook.bNoteTwo055 = Notebook.bNoteTwo; Notebook.bNoteThree055 = Notebook.bNoteThree; iLoyalty055 = iTempLoyalty; bCorpse055 = bTempCorpse; Flood.bPutInDanger055 = Flood.bPutInDanger; }
            if (tempNPC == NPC_056) { Conversation.bAlreadyTalked056 = Conversation.bTempTalked; sAvailableWeapons056 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker056; iAvailableMacGuffins056 = iTempMacGuffins; NPC056_CurrentNumLocation = iTempLocation; NPC056_LastLocation = iTempLastLocation; NPC056_LastStrLocation = sTempLastLocation; NPC056_CurrentStrLocation = sTempCurrentLocation; DesireToMove056 = iTempDesireToMove; bCorpse056 = bTempCorpse; iClose056 = iCloseEncounters; Notebook.bNoted056 = Notebook.bTempNoted; Notebook.iObserved056 = Notebook.iTempObserved; NPC_Traits.TraitOne056 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo056 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree056 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne056 = Notebook.bNoteOne; Notebook.bNoteTwo056 = Notebook.bNoteTwo; Notebook.bNoteThree056 = Notebook.bNoteThree; iLoyalty056 = iTempLoyalty; bCorpse056 = bTempCorpse; Flood.bPutInDanger056 = Flood.bPutInDanger; }
            if (tempNPC == NPC_057) { Conversation.bAlreadyTalked057 = Conversation.bTempTalked; sAvailableWeapons057 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker057; iAvailableMacGuffins057 = iTempMacGuffins; NPC057_CurrentNumLocation = iTempLocation; NPC057_LastLocation = iTempLastLocation; NPC057_LastStrLocation = sTempLastLocation; NPC057_CurrentStrLocation = sTempCurrentLocation; DesireToMove057 = iTempDesireToMove; bCorpse057 = bTempCorpse; iClose057 = iCloseEncounters; Notebook.bNoted057 = Notebook.bTempNoted; Notebook.iObserved057 = Notebook.iTempObserved; NPC_Traits.TraitOne057 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo057 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree057 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne057 = Notebook.bNoteOne; Notebook.bNoteTwo057 = Notebook.bNoteTwo; Notebook.bNoteThree057 = Notebook.bNoteThree; iLoyalty057 = iTempLoyalty; bCorpse057 = bTempCorpse; Flood.bPutInDanger057 = Flood.bPutInDanger; }
            if (tempNPC == NPC_058) { Conversation.bAlreadyTalked058 = Conversation.bTempTalked; sAvailableWeapons058 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker058; iAvailableMacGuffins058 = iTempMacGuffins; NPC058_CurrentNumLocation = iTempLocation; NPC058_LastLocation = iTempLastLocation; NPC058_LastStrLocation = sTempLastLocation; NPC058_CurrentStrLocation = sTempCurrentLocation; DesireToMove058 = iTempDesireToMove; bCorpse058 = bTempCorpse; iClose058 = iCloseEncounters; Notebook.bNoted058 = Notebook.bTempNoted; Notebook.iObserved058 = Notebook.iTempObserved; NPC_Traits.TraitOne058 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo058 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree058 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne058 = Notebook.bNoteOne; Notebook.bNoteTwo058 = Notebook.bNoteTwo; Notebook.bNoteThree058 = Notebook.bNoteThree; iLoyalty058 = iTempLoyalty; bCorpse058 = bTempCorpse; Flood.bPutInDanger058 = Flood.bPutInDanger; }
            if (tempNPC == NPC_059) { Conversation.bAlreadyTalked059 = Conversation.bTempTalked; sAvailableWeapons059 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker059; iAvailableMacGuffins059 = iTempMacGuffins; NPC059_CurrentNumLocation = iTempLocation; NPC059_LastLocation = iTempLastLocation; NPC059_LastStrLocation = sTempLastLocation; NPC059_CurrentStrLocation = sTempCurrentLocation; DesireToMove059 = iTempDesireToMove; bCorpse059 = bTempCorpse; iClose059 = iCloseEncounters; Notebook.bNoted059 = Notebook.bTempNoted; Notebook.iObserved059 = Notebook.iTempObserved; NPC_Traits.TraitOne059 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo059 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree059 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne059 = Notebook.bNoteOne; Notebook.bNoteTwo059 = Notebook.bNoteTwo; Notebook.bNoteThree059 = Notebook.bNoteThree; iLoyalty059 = iTempLoyalty; bCorpse059 = bTempCorpse; Flood.bPutInDanger059 = Flood.bPutInDanger; }
            if (tempNPC == NPC_060) { Conversation.bAlreadyTalked060 = Conversation.bTempTalked; sAvailableWeapons060 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker060; iAvailableMacGuffins060 = iTempMacGuffins; NPC060_CurrentNumLocation = iTempLocation; NPC060_LastLocation = iTempLastLocation; NPC060_LastStrLocation = sTempLastLocation; NPC060_CurrentStrLocation = sTempCurrentLocation; DesireToMove060 = iTempDesireToMove; bCorpse060 = bTempCorpse; iClose060 = iCloseEncounters; Notebook.bNoted060 = Notebook.bTempNoted; Notebook.iObserved060 = Notebook.iTempObserved; NPC_Traits.TraitOne060 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo060 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree060 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne060 = Notebook.bNoteOne; Notebook.bNoteTwo060 = Notebook.bNoteTwo; Notebook.bNoteThree060 = Notebook.bNoteThree; iLoyalty060 = iTempLoyalty; bCorpse060 = bTempCorpse; Flood.bPutInDanger060 = Flood.bPutInDanger; }
            if (tempNPC == NPC_061) { Conversation.bAlreadyTalked061 = Conversation.bTempTalked; sAvailableWeapons061 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker061; iAvailableMacGuffins061 = iTempMacGuffins; NPC061_CurrentNumLocation = iTempLocation; NPC061_LastLocation = iTempLastLocation; NPC061_LastStrLocation = sTempLastLocation; NPC061_CurrentStrLocation = sTempCurrentLocation; DesireToMove061 = iTempDesireToMove; bCorpse061 = bTempCorpse; iClose061 = iCloseEncounters; Notebook.bNoted061 = Notebook.bTempNoted; Notebook.iObserved061 = Notebook.iTempObserved; NPC_Traits.TraitOne061 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo061 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree061 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne061 = Notebook.bNoteOne; Notebook.bNoteTwo061 = Notebook.bNoteTwo; Notebook.bNoteThree061 = Notebook.bNoteThree; iLoyalty061 = iTempLoyalty; bCorpse061 = bTempCorpse; Flood.bPutInDanger061 = Flood.bPutInDanger; }
            if (tempNPC == NPC_062) { Conversation.bAlreadyTalked062 = Conversation.bTempTalked; sAvailableWeapons062 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker062; iAvailableMacGuffins062 = iTempMacGuffins; NPC062_CurrentNumLocation = iTempLocation; NPC062_LastLocation = iTempLastLocation; NPC062_LastStrLocation = sTempLastLocation; NPC062_CurrentStrLocation = sTempCurrentLocation; DesireToMove062 = iTempDesireToMove; bCorpse062 = bTempCorpse; iClose062 = iCloseEncounters; Notebook.bNoted062 = Notebook.bTempNoted; Notebook.iObserved061 = Notebook.iTempObserved; NPC_Traits.TraitOne062 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo062 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree062 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne062 = Notebook.bNoteOne; Notebook.bNoteTwo062 = Notebook.bNoteTwo; Notebook.bNoteThree062 = Notebook.bNoteThree; iLoyalty062 = iTempLoyalty; bCorpse062 = bTempCorpse; Flood.bPutInDanger062 = Flood.bPutInDanger; }
            if (tempNPC == NPC_063) { Conversation.bAlreadyTalked063 = Conversation.bTempTalked; sAvailableWeapons063 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker063; iAvailableMacGuffins063 = iTempMacGuffins; NPC063_CurrentNumLocation = iTempLocation; NPC063_LastLocation = iTempLastLocation; NPC063_LastStrLocation = sTempLastLocation; NPC063_CurrentStrLocation = sTempCurrentLocation; DesireToMove063 = iTempDesireToMove; bCorpse063 = bTempCorpse; iClose063 = iCloseEncounters; Notebook.bNoted063 = Notebook.bTempNoted; Notebook.iObserved063 = Notebook.iTempObserved; NPC_Traits.TraitOne063 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo063 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree063 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne063 = Notebook.bNoteOne; Notebook.bNoteTwo063 = Notebook.bNoteTwo; Notebook.bNoteThree063 = Notebook.bNoteThree; iLoyalty063 = iTempLoyalty; bCorpse063 = bTempCorpse; Flood.bPutInDanger063 = Flood.bPutInDanger; }
            if (tempNPC == NPC_064) { Conversation.bAlreadyTalked064 = Conversation.bTempTalked; sAvailableWeapons064 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker064; iAvailableMacGuffins064 = iTempMacGuffins; NPC064_CurrentNumLocation = iTempLocation; NPC064_LastLocation = iTempLastLocation; NPC064_LastStrLocation = sTempLastLocation; NPC064_CurrentStrLocation = sTempCurrentLocation; DesireToMove064 = iTempDesireToMove; bCorpse064 = bTempCorpse; iClose064 = iCloseEncounters; Notebook.bNoted064 = Notebook.bTempNoted; Notebook.iObserved064 = Notebook.iTempObserved; NPC_Traits.TraitOne064 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo064 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree064 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne064 = Notebook.bNoteOne; Notebook.bNoteTwo064 = Notebook.bNoteTwo; Notebook.bNoteThree064 = Notebook.bNoteThree; iLoyalty064 = iTempLoyalty; bCorpse064 = bTempCorpse; Flood.bPutInDanger064 = Flood.bPutInDanger; }
            if (tempNPC == NPC_065) { Conversation.bAlreadyTalked065 = Conversation.bTempTalked; sAvailableWeapons065 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker065; iAvailableMacGuffins065 = iTempMacGuffins; NPC065_CurrentNumLocation = iTempLocation; NPC065_LastLocation = iTempLastLocation; NPC065_LastStrLocation = sTempLastLocation; NPC065_CurrentStrLocation = sTempCurrentLocation; DesireToMove065 = iTempDesireToMove; bCorpse065 = bTempCorpse; iClose065 = iCloseEncounters; Notebook.bNoted065 = Notebook.bTempNoted; Notebook.iObserved065 = Notebook.iTempObserved; NPC_Traits.TraitOne065 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo065 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree065 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne065 = Notebook.bNoteOne; Notebook.bNoteTwo065 = Notebook.bNoteTwo; Notebook.bNoteThree065 = Notebook.bNoteThree; iLoyalty065 = iTempLoyalty; bCorpse065 = bTempCorpse; Flood.bPutInDanger065 = Flood.bPutInDanger; }
            if (tempNPC == NPC_066) { Conversation.bAlreadyTalked066 = Conversation.bTempTalked; sAvailableWeapons066 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker066; iAvailableMacGuffins066 = iTempMacGuffins; NPC066_CurrentNumLocation = iTempLocation; NPC066_LastLocation = iTempLastLocation; NPC066_LastStrLocation = sTempLastLocation; NPC066_CurrentStrLocation = sTempCurrentLocation; DesireToMove066 = iTempDesireToMove; bCorpse066 = bTempCorpse; iClose066 = iCloseEncounters; Notebook.bNoted066 = Notebook.bTempNoted; Notebook.iObserved066 = Notebook.iTempObserved; NPC_Traits.TraitOne066 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo066 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree066 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne066 = Notebook.bNoteOne; Notebook.bNoteTwo066 = Notebook.bNoteTwo; Notebook.bNoteThree066 = Notebook.bNoteThree; iLoyalty066 = iTempLoyalty; bCorpse066 = bTempCorpse; Flood.bPutInDanger066 = Flood.bPutInDanger; }
            if (tempNPC == NPC_067) { Conversation.bAlreadyTalked067 = Conversation.bTempTalked; sAvailableWeapons067 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker067; iAvailableMacGuffins067 = iTempMacGuffins; NPC067_CurrentNumLocation = iTempLocation; NPC067_LastLocation = iTempLastLocation; NPC067_LastStrLocation = sTempLastLocation; NPC067_CurrentStrLocation = sTempCurrentLocation; DesireToMove067 = iTempDesireToMove; bCorpse067 = bTempCorpse; iClose067 = iCloseEncounters; Notebook.bNoted067 = Notebook.bTempNoted; Notebook.iObserved067 = Notebook.iTempObserved; NPC_Traits.TraitOne067 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo067 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree067 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne067 = Notebook.bNoteOne; Notebook.bNoteTwo067 = Notebook.bNoteTwo; Notebook.bNoteThree067 = Notebook.bNoteThree; iLoyalty067 = iTempLoyalty; bCorpse067 = bTempCorpse; Flood.bPutInDanger067 = Flood.bPutInDanger; }
            if (tempNPC == NPC_068) { Conversation.bAlreadyTalked068 = Conversation.bTempTalked; sAvailableWeapons068 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker068; iAvailableMacGuffins068 = iTempMacGuffins; NPC068_CurrentNumLocation = iTempLocation; NPC068_LastLocation = iTempLastLocation; NPC068_LastStrLocation = sTempLastLocation; NPC068_CurrentStrLocation = sTempCurrentLocation; DesireToMove068 = iTempDesireToMove; bCorpse068 = bTempCorpse; iClose068 = iCloseEncounters; Notebook.bNoted068 = Notebook.bTempNoted; Notebook.iObserved068 = Notebook.iTempObserved; NPC_Traits.TraitOne068 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo068 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree068 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne068 = Notebook.bNoteOne; Notebook.bNoteTwo068 = Notebook.bNoteTwo; Notebook.bNoteThree068 = Notebook.bNoteThree; iLoyalty068 = iTempLoyalty; bCorpse068 = bTempCorpse; Flood.bPutInDanger068 = Flood.bPutInDanger; }
            if (tempNPC == NPC_069) { Conversation.bAlreadyTalked069 = Conversation.bTempTalked; sAvailableWeapons069 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker069; iAvailableMacGuffins069 = iTempMacGuffins; NPC069_CurrentNumLocation = iTempLocation; NPC069_LastLocation = iTempLastLocation; NPC069_LastStrLocation = sTempLastLocation; NPC069_CurrentStrLocation = sTempCurrentLocation; DesireToMove069 = iTempDesireToMove; bCorpse069 = bTempCorpse; iClose069 = iCloseEncounters; Notebook.bNoted069 = Notebook.bTempNoted; Notebook.iObserved069 = Notebook.iTempObserved; NPC_Traits.TraitOne069 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo069 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree069 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne069 = Notebook.bNoteOne; Notebook.bNoteTwo069 = Notebook.bNoteTwo; Notebook.bNoteThree069 = Notebook.bNoteThree; iLoyalty069 = iTempLoyalty; bCorpse069 = bTempCorpse; Flood.bPutInDanger069 = Flood.bPutInDanger; }
            if (tempNPC == NPC_070) { Conversation.bAlreadyTalked070 = Conversation.bTempTalked; sAvailableWeapons070 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker070; iAvailableMacGuffins070 = iTempMacGuffins; NPC070_CurrentNumLocation = iTempLocation; NPC070_LastLocation = iTempLastLocation; NPC070_LastStrLocation = sTempLastLocation; NPC070_CurrentStrLocation = sTempCurrentLocation; DesireToMove070 = iTempDesireToMove; bCorpse070 = bTempCorpse; iClose070 = iCloseEncounters; Notebook.bNoted070 = Notebook.bTempNoted; Notebook.iObserved070 = Notebook.iTempObserved; NPC_Traits.TraitOne070 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo070 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree070 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne070 = Notebook.bNoteOne; Notebook.bNoteTwo070 = Notebook.bNoteTwo; Notebook.bNoteThree070 = Notebook.bNoteThree; iLoyalty070 = iTempLoyalty; bCorpse070 = bTempCorpse; Flood.bPutInDanger070 = Flood.bPutInDanger; }
            if (tempNPC == NPC_071) { Conversation.bAlreadyTalked071 = Conversation.bTempTalked; sAvailableWeapons071 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker071; iAvailableMacGuffins071 = iTempMacGuffins; NPC071_CurrentNumLocation = iTempLocation; NPC071_LastLocation = iTempLastLocation; NPC071_LastStrLocation = sTempLastLocation; NPC071_CurrentStrLocation = sTempCurrentLocation; DesireToMove071 = iTempDesireToMove; bCorpse071 = bTempCorpse; iClose071 = iCloseEncounters; Notebook.bNoted071 = Notebook.bTempNoted; Notebook.iObserved071 = Notebook.iTempObserved; NPC_Traits.TraitOne071 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo071 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree071 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne071 = Notebook.bNoteOne; Notebook.bNoteTwo071 = Notebook.bNoteTwo; Notebook.bNoteThree071 = Notebook.bNoteThree; iLoyalty071 = iTempLoyalty; bCorpse071 = bTempCorpse; Flood.bPutInDanger071 = Flood.bPutInDanger; }
            if (tempNPC == NPC_072) { Conversation.bAlreadyTalked001 = Conversation.bTempTalked; sAvailableWeapons001 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker001; iAvailableMacGuffins001 = iTempMacGuffins; NPC072_CurrentNumLocation = iTempLocation; NPC072_LastLocation = iTempLastLocation; NPC072_LastStrLocation = sTempLastLocation; NPC072_CurrentStrLocation = sTempCurrentLocation; DesireToMove072 = iTempDesireToMove; bCorpse072 = bTempCorpse; iClose072 = iCloseEncounters; Notebook.bNoted072 = Notebook.bTempNoted; Notebook.iObserved072 = Notebook.iTempObserved; NPC_Traits.TraitOne072 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo072 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree072 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne072 = Notebook.bNoteOne; Notebook.bNoteTwo072 = Notebook.bNoteTwo; Notebook.bNoteThree072 = Notebook.bNoteThree; iLoyalty072 = iTempLoyalty; bCorpse072 = bTempCorpse; Flood.bPutInDanger072 = Flood.bPutInDanger; }
            if (tempNPC == NPC_073) { Conversation.bAlreadyTalked073 = Conversation.bTempTalked; sAvailableWeapons073 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker073; iAvailableMacGuffins073 = iTempMacGuffins; NPC073_CurrentNumLocation = iTempLocation; NPC073_LastLocation = iTempLastLocation; NPC073_LastStrLocation = sTempLastLocation; NPC073_CurrentStrLocation = sTempCurrentLocation; DesireToMove073 = iTempDesireToMove; bCorpse073 = bTempCorpse; iClose073 = iCloseEncounters; Notebook.bNoted073 = Notebook.bTempNoted; Notebook.iObserved073 = Notebook.iTempObserved; NPC_Traits.TraitOne073 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo073 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree073 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne073 = Notebook.bNoteOne; Notebook.bNoteTwo073 = Notebook.bNoteTwo; Notebook.bNoteThree073 = Notebook.bNoteThree; iLoyalty073 = iTempLoyalty; bCorpse073 = bTempCorpse; Flood.bPutInDanger073 = Flood.bPutInDanger; }
            if (tempNPC == NPC_074) { Conversation.bAlreadyTalked074 = Conversation.bTempTalked; sAvailableWeapons074 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker074; iAvailableMacGuffins074 = iTempMacGuffins; NPC074_CurrentNumLocation = iTempLocation; NPC074_LastLocation = iTempLastLocation; NPC074_LastStrLocation = sTempLastLocation; NPC074_CurrentStrLocation = sTempCurrentLocation; DesireToMove074 = iTempDesireToMove; bCorpse074 = bTempCorpse; iClose074 = iCloseEncounters; Notebook.bNoted074 = Notebook.bTempNoted; Notebook.iObserved074 = Notebook.iTempObserved; NPC_Traits.TraitOne074 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo074 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree074 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne074 = Notebook.bNoteOne; Notebook.bNoteTwo074 = Notebook.bNoteTwo; Notebook.bNoteThree074 = Notebook.bNoteThree; iLoyalty074 = iTempLoyalty; bCorpse074 = bTempCorpse; Flood.bPutInDanger074 = Flood.bPutInDanger; }
            if (tempNPC == NPC_075) { Conversation.bAlreadyTalked075 = Conversation.bTempTalked; sAvailableWeapons075 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker075; iAvailableMacGuffins075 = iTempMacGuffins; NPC075_CurrentNumLocation = iTempLocation; NPC075_LastLocation = iTempLastLocation; NPC075_LastStrLocation = sTempLastLocation; NPC075_CurrentStrLocation = sTempCurrentLocation; DesireToMove075 = iTempDesireToMove; bCorpse075 = bTempCorpse; iClose075 = iCloseEncounters; Notebook.bNoted075 = Notebook.bTempNoted; Notebook.iObserved075 = Notebook.iTempObserved; NPC_Traits.TraitOne075 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo075 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree075 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne075 = Notebook.bNoteOne; Notebook.bNoteTwo075 = Notebook.bNoteTwo; Notebook.bNoteThree075 = Notebook.bNoteThree; iLoyalty075 = iTempLoyalty; bCorpse075 = bTempCorpse; Flood.bPutInDanger075 = Flood.bPutInDanger; }
            if (tempNPC == NPC_076) { Conversation.bAlreadyTalked076 = Conversation.bTempTalked; sAvailableWeapons076 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker076; iAvailableMacGuffins076 = iTempMacGuffins; NPC076_CurrentNumLocation = iTempLocation; NPC076_LastLocation = iTempLastLocation; NPC076_LastStrLocation = sTempLastLocation; NPC076_CurrentStrLocation = sTempCurrentLocation; DesireToMove076 = iTempDesireToMove; bCorpse076 = bTempCorpse; iClose076 = iCloseEncounters; Notebook.bNoted076 = Notebook.bTempNoted; Notebook.iObserved076 = Notebook.iTempObserved; NPC_Traits.TraitOne076 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo076 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree076 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne076 = Notebook.bNoteOne; Notebook.bNoteTwo076 = Notebook.bNoteTwo; Notebook.bNoteThree076 = Notebook.bNoteThree; iLoyalty076 = iTempLoyalty; bCorpse076 = bTempCorpse; Flood.bPutInDanger076 = Flood.bPutInDanger; }
            if (tempNPC == NPC_077) { Conversation.bAlreadyTalked077 = Conversation.bTempTalked; sAvailableWeapons077 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker077; iAvailableMacGuffins077 = iTempMacGuffins; NPC077_CurrentNumLocation = iTempLocation; NPC077_LastLocation = iTempLastLocation; NPC077_LastStrLocation = sTempLastLocation; NPC077_CurrentStrLocation = sTempCurrentLocation; DesireToMove077 = iTempDesireToMove; bCorpse077 = bTempCorpse; iClose077 = iCloseEncounters; Notebook.bNoted077 = Notebook.bTempNoted; Notebook.iObserved077 = Notebook.iTempObserved; NPC_Traits.TraitOne077 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo077 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree077 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne077 = Notebook.bNoteOne; Notebook.bNoteTwo077 = Notebook.bNoteTwo; Notebook.bNoteThree077 = Notebook.bNoteThree; iLoyalty077 = iTempLoyalty; bCorpse077 = bTempCorpse; Flood.bPutInDanger077 = Flood.bPutInDanger; }
            if (tempNPC == NPC_078) { Conversation.bAlreadyTalked078 = Conversation.bTempTalked; sAvailableWeapons078 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker078; iAvailableMacGuffins078 = iTempMacGuffins; NPC078_CurrentNumLocation = iTempLocation; NPC078_LastLocation = iTempLastLocation; NPC078_LastStrLocation = sTempLastLocation; NPC078_CurrentStrLocation = sTempCurrentLocation; DesireToMove078 = iTempDesireToMove; bCorpse078 = bTempCorpse; iClose078 = iCloseEncounters; Notebook.bNoted078 = Notebook.bTempNoted; Notebook.iObserved078 = Notebook.iTempObserved; NPC_Traits.TraitOne078 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo078 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree078 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne078 = Notebook.bNoteOne; Notebook.bNoteTwo078 = Notebook.bNoteTwo; Notebook.bNoteThree078 = Notebook.bNoteThree; iLoyalty078 = iTempLoyalty; bCorpse078 = bTempCorpse; Flood.bPutInDanger078 = Flood.bPutInDanger; }
            if (tempNPC == NPC_079) { Conversation.bAlreadyTalked079 = Conversation.bTempTalked; sAvailableWeapons079 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker079; iAvailableMacGuffins079 = iTempMacGuffins; NPC079_CurrentNumLocation = iTempLocation; NPC079_LastLocation = iTempLastLocation; NPC079_LastStrLocation = sTempLastLocation; NPC079_CurrentStrLocation = sTempCurrentLocation; DesireToMove079 = iTempDesireToMove; bCorpse079 = bTempCorpse; iClose079 = iCloseEncounters; Notebook.bNoted079 = Notebook.bTempNoted; Notebook.iObserved079 = Notebook.iTempObserved; NPC_Traits.TraitOne079 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo079 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree079 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne079 = Notebook.bNoteOne; Notebook.bNoteTwo079 = Notebook.bNoteTwo; Notebook.bNoteThree079 = Notebook.bNoteThree; iLoyalty079 = iTempLoyalty; bCorpse079 = bTempCorpse; Flood.bPutInDanger079 = Flood.bPutInDanger; }
            if (tempNPC == NPC_080) { Conversation.bAlreadyTalked080 = Conversation.bTempTalked; sAvailableWeapons080 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker080; iAvailableMacGuffins080 = iTempMacGuffins; NPC080_CurrentNumLocation = iTempLocation; NPC080_LastLocation = iTempLastLocation; NPC080_LastStrLocation = sTempLastLocation; NPC080_CurrentStrLocation = sTempCurrentLocation; DesireToMove080 = iTempDesireToMove; bCorpse080 = bTempCorpse; iClose080 = iCloseEncounters; Notebook.bNoted080 = Notebook.bTempNoted; Notebook.iObserved080 = Notebook.iTempObserved; NPC_Traits.TraitOne080 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo080 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree080 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne080 = Notebook.bNoteOne; Notebook.bNoteTwo080 = Notebook.bNoteTwo; Notebook.bNoteThree080 = Notebook.bNoteThree; iLoyalty080 = iTempLoyalty; bCorpse080 = bTempCorpse; Flood.bPutInDanger080 = Flood.bPutInDanger; }
            if (tempNPC == NPC_081) { Conversation.bAlreadyTalked081 = Conversation.bTempTalked; sAvailableWeapons081 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker081; iAvailableMacGuffins081 = iTempMacGuffins; NPC081_CurrentNumLocation = iTempLocation; NPC081_LastLocation = iTempLastLocation; NPC081_LastStrLocation = sTempLastLocation; NPC081_CurrentStrLocation = sTempCurrentLocation; DesireToMove081 = iTempDesireToMove; bCorpse081 = bTempCorpse; iClose081 = iCloseEncounters; Notebook.bNoted081 = Notebook.bTempNoted; Notebook.iObserved081 = Notebook.iTempObserved; NPC_Traits.TraitOne081 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo081 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree081 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne081 = Notebook.bNoteOne; Notebook.bNoteTwo081 = Notebook.bNoteTwo; Notebook.bNoteThree081 = Notebook.bNoteThree; iLoyalty081 = iTempLoyalty; bCorpse081 = bTempCorpse; Flood.bPutInDanger081 = Flood.bPutInDanger; }
            if (tempNPC == NPC_082) { Conversation.bAlreadyTalked082 = Conversation.bTempTalked; sAvailableWeapons082 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker082; iAvailableMacGuffins082 = iTempMacGuffins; NPC082_CurrentNumLocation = iTempLocation; NPC082_LastLocation = iTempLastLocation; NPC082_LastStrLocation = sTempLastLocation; NPC082_CurrentStrLocation = sTempCurrentLocation; DesireToMove082 = iTempDesireToMove; bCorpse082 = bTempCorpse; iClose082 = iCloseEncounters; Notebook.bNoted082 = Notebook.bTempNoted; Notebook.iObserved082 = Notebook.iTempObserved; NPC_Traits.TraitOne082 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo082 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree082 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne082 = Notebook.bNoteOne; Notebook.bNoteTwo082 = Notebook.bNoteTwo; Notebook.bNoteThree082 = Notebook.bNoteThree; iLoyalty082 = iTempLoyalty; bCorpse082 = bTempCorpse; Flood.bPutInDanger082 = Flood.bPutInDanger; }
            if (tempNPC == NPC_083) { Conversation.bAlreadyTalked083 = Conversation.bTempTalked; sAvailableWeapons083 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker083; iAvailableMacGuffins083 = iTempMacGuffins; NPC083_CurrentNumLocation = iTempLocation; NPC083_LastLocation = iTempLastLocation; NPC083_LastStrLocation = sTempLastLocation; NPC083_CurrentStrLocation = sTempCurrentLocation; DesireToMove083 = iTempDesireToMove; bCorpse083 = bTempCorpse; iClose083 = iCloseEncounters; Notebook.bNoted083 = Notebook.bTempNoted; Notebook.iObserved083 = Notebook.iTempObserved; NPC_Traits.TraitOne083 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo083 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree083 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne083 = Notebook.bNoteOne; Notebook.bNoteTwo083 = Notebook.bNoteTwo; Notebook.bNoteThree083 = Notebook.bNoteThree; iLoyalty083 = iTempLoyalty; bCorpse083 = bTempCorpse; Flood.bPutInDanger083 = Flood.bPutInDanger; }
            if (tempNPC == NPC_084) { Conversation.bAlreadyTalked084 = Conversation.bTempTalked; sAvailableWeapons084 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker084; iAvailableMacGuffins084 = iTempMacGuffins; NPC084_CurrentNumLocation = iTempLocation; NPC084_LastLocation = iTempLastLocation; NPC084_LastStrLocation = sTempLastLocation; NPC084_CurrentStrLocation = sTempCurrentLocation; DesireToMove084 = iTempDesireToMove; bCorpse084 = bTempCorpse; iClose084 = iCloseEncounters; Notebook.bNoted084 = Notebook.bTempNoted; Notebook.iObserved084 = Notebook.iTempObserved; NPC_Traits.TraitOne084 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo084 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree084 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne084 = Notebook.bNoteOne; Notebook.bNoteTwo084 = Notebook.bNoteTwo; Notebook.bNoteThree084 = Notebook.bNoteThree; iLoyalty084 = iTempLoyalty; bCorpse084 = bTempCorpse; Flood.bPutInDanger084 = Flood.bPutInDanger; }
            if (tempNPC == NPC_085) { Conversation.bAlreadyTalked085 = Conversation.bTempTalked; sAvailableWeapons085 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker085; iAvailableMacGuffins085 = iTempMacGuffins; NPC085_CurrentNumLocation = iTempLocation; NPC085_LastLocation = iTempLastLocation; NPC085_LastStrLocation = sTempLastLocation; NPC085_CurrentStrLocation = sTempCurrentLocation; DesireToMove085 = iTempDesireToMove; bCorpse085 = bTempCorpse; iClose085 = iCloseEncounters; Notebook.bNoted085 = Notebook.bTempNoted; Notebook.iObserved085 = Notebook.iTempObserved; NPC_Traits.TraitOne085 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo085 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree085 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne085 = Notebook.bNoteOne; Notebook.bNoteTwo085 = Notebook.bNoteTwo; Notebook.bNoteThree085 = Notebook.bNoteThree; iLoyalty085 = iTempLoyalty; bCorpse085 = bTempCorpse; Flood.bPutInDanger085 = Flood.bPutInDanger; }
            if (tempNPC == NPC_086) { Conversation.bAlreadyTalked086 = Conversation.bTempTalked; sAvailableWeapons086 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker086; iAvailableMacGuffins086 = iTempMacGuffins; NPC086_CurrentNumLocation = iTempLocation; NPC086_LastLocation = iTempLastLocation; NPC086_LastStrLocation = sTempLastLocation; NPC086_CurrentStrLocation = sTempCurrentLocation; DesireToMove086 = iTempDesireToMove; bCorpse086 = bTempCorpse; iClose086 = iCloseEncounters; Notebook.bNoted086 = Notebook.bTempNoted; Notebook.iObserved086 = Notebook.iTempObserved; NPC_Traits.TraitOne086 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo086 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree086 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne086 = Notebook.bNoteOne; Notebook.bNoteTwo086 = Notebook.bNoteTwo; Notebook.bNoteThree086 = Notebook.bNoteThree; iLoyalty086 = iTempLoyalty; bCorpse086 = bTempCorpse; Flood.bPutInDanger087 = Flood.bPutInDanger; }
            if (tempNPC == NPC_087) { Conversation.bAlreadyTalked087 = Conversation.bTempTalked; sAvailableWeapons087 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker087; iAvailableMacGuffins087 = iTempMacGuffins; NPC087_CurrentNumLocation = iTempLocation; NPC087_LastLocation = iTempLastLocation; NPC087_LastStrLocation = sTempLastLocation; NPC087_CurrentStrLocation = sTempCurrentLocation; DesireToMove087 = iTempDesireToMove; bCorpse087 = bTempCorpse; iClose087 = iCloseEncounters; Notebook.bNoted087 = Notebook.bTempNoted; Notebook.iObserved087 = Notebook.iTempObserved; NPC_Traits.TraitOne087 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo087 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree087 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne087 = Notebook.bNoteOne; Notebook.bNoteTwo087 = Notebook.bNoteTwo; Notebook.bNoteThree087 = Notebook.bNoteThree; iLoyalty087 = iTempLoyalty; bCorpse087 = bTempCorpse; Flood.bPutInDanger087 = Flood.bPutInDanger; }
            if (tempNPC == NPC_088) { Conversation.bAlreadyTalked088 = Conversation.bTempTalked; sAvailableWeapons088 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker088; iAvailableMacGuffins088 = iTempMacGuffins; NPC088_CurrentNumLocation = iTempLocation; NPC088_LastLocation = iTempLastLocation; NPC088_LastStrLocation = sTempLastLocation; NPC088_CurrentStrLocation = sTempCurrentLocation; DesireToMove088 = iTempDesireToMove; bCorpse088 = bTempCorpse; iClose088 = iCloseEncounters; Notebook.bNoted088 = Notebook.bTempNoted; Notebook.iObserved088 = Notebook.iTempObserved; NPC_Traits.TraitOne088 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo088 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree088 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne088 = Notebook.bNoteOne; Notebook.bNoteTwo088 = Notebook.bNoteTwo; Notebook.bNoteThree088 = Notebook.bNoteThree; iLoyalty088 = iTempLoyalty; bCorpse088 = bTempCorpse; Flood.bPutInDanger088 = Flood.bPutInDanger; }
            if (tempNPC == NPC_089) { Conversation.bAlreadyTalked089 = Conversation.bTempTalked; sAvailableWeapons089 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker089; iAvailableMacGuffins089 = iTempMacGuffins; NPC089_CurrentNumLocation = iTempLocation; NPC089_LastLocation = iTempLastLocation; NPC089_LastStrLocation = sTempLastLocation; NPC089_CurrentStrLocation = sTempCurrentLocation; DesireToMove089 = iTempDesireToMove; bCorpse089 = bTempCorpse; iClose089 = iCloseEncounters; Notebook.bNoted089 = Notebook.bTempNoted; Notebook.iObserved089 = Notebook.iTempObserved; NPC_Traits.TraitOne089 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo089 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree089 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne089 = Notebook.bNoteOne; Notebook.bNoteTwo089 = Notebook.bNoteTwo; Notebook.bNoteThree089 = Notebook.bNoteThree; iLoyalty089 = iTempLoyalty; bCorpse089 = bTempCorpse; Flood.bPutInDanger089 = Flood.bPutInDanger; }
            if (tempNPC == NPC_090) { Conversation.bAlreadyTalked090 = Conversation.bTempTalked; sAvailableWeapons090 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker090; iAvailableMacGuffins090 = iTempMacGuffins; NPC090_CurrentNumLocation = iTempLocation; NPC090_LastLocation = iTempLastLocation; NPC090_LastStrLocation = sTempLastLocation; NPC090_CurrentStrLocation = sTempCurrentLocation; DesireToMove090 = iTempDesireToMove; bCorpse090 = bTempCorpse; iClose090 = iCloseEncounters; Notebook.bNoted090 = Notebook.bTempNoted; Notebook.iObserved090 = Notebook.iTempObserved; NPC_Traits.TraitOne090 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo090 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree090 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne090 = Notebook.bNoteOne; Notebook.bNoteTwo090 = Notebook.bNoteTwo; Notebook.bNoteThree090 = Notebook.bNoteThree; iLoyalty090 = iTempLoyalty; bCorpse090 = bTempCorpse; Flood.bPutInDanger090 = Flood.bPutInDanger; }
            if (tempNPC == NPC_091) { Conversation.bAlreadyTalked091 = Conversation.bTempTalked; sAvailableWeapons091 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker091; iAvailableMacGuffins091 = iTempMacGuffins; NPC091_CurrentNumLocation = iTempLocation; NPC091_LastLocation = iTempLastLocation; NPC091_LastStrLocation = sTempLastLocation; NPC091_CurrentStrLocation = sTempCurrentLocation; DesireToMove091 = iTempDesireToMove; bCorpse091 = bTempCorpse; iClose091 = iCloseEncounters; Notebook.bNoted091 = Notebook.bTempNoted; Notebook.iObserved091 = Notebook.iTempObserved; NPC_Traits.TraitOne091 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo091 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree091 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne091 = Notebook.bNoteOne; Notebook.bNoteTwo091 = Notebook.bNoteTwo; Notebook.bNoteThree091 = Notebook.bNoteThree; iLoyalty091 = iTempLoyalty; bCorpse091 = bTempCorpse; Flood.bPutInDanger091 = Flood.bPutInDanger; }
            if (tempNPC == NPC_092) { Conversation.bAlreadyTalked092 = Conversation.bTempTalked; sAvailableWeapons092 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker092; iAvailableMacGuffins092 = iTempMacGuffins; NPC092_CurrentNumLocation = iTempLocation; NPC092_LastLocation = iTempLastLocation; NPC092_LastStrLocation = sTempLastLocation; NPC092_CurrentStrLocation = sTempCurrentLocation; DesireToMove092 = iTempDesireToMove; bCorpse092 = bTempCorpse; iClose092 = iCloseEncounters; Notebook.bNoted092 = Notebook.bTempNoted; Notebook.iObserved092 = Notebook.iTempObserved; NPC_Traits.TraitOne092 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo092 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree092 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne092 = Notebook.bNoteOne; Notebook.bNoteTwo092 = Notebook.bNoteTwo; Notebook.bNoteThree092 = Notebook.bNoteThree; iLoyalty092 = iTempLoyalty; bCorpse092 = bTempCorpse; Flood.bPutInDanger092 = Flood.bPutInDanger; }
            if (tempNPC == NPC_093) { Conversation.bAlreadyTalked093 = Conversation.bTempTalked; sAvailableWeapons093 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker093; iAvailableMacGuffins093 = iTempMacGuffins; NPC093_CurrentNumLocation = iTempLocation; NPC093_LastLocation = iTempLastLocation; NPC093_LastStrLocation = sTempLastLocation; NPC093_CurrentStrLocation = sTempCurrentLocation; DesireToMove093 = iTempDesireToMove; bCorpse093 = bTempCorpse; iClose093 = iCloseEncounters; Notebook.bNoted093 = Notebook.bTempNoted; Notebook.iObserved093 = Notebook.iTempObserved; NPC_Traits.TraitOne093 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo093 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree093 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne093 = Notebook.bNoteOne; Notebook.bNoteTwo093 = Notebook.bNoteTwo; Notebook.bNoteThree093 = Notebook.bNoteThree; iLoyalty093 = iTempLoyalty; bCorpse093 = bTempCorpse; Flood.bPutInDanger093 = Flood.bPutInDanger; }
            if (tempNPC == NPC_094) { Conversation.bAlreadyTalked094 = Conversation.bTempTalked; sAvailableWeapons094 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker094; iAvailableMacGuffins094 = iTempMacGuffins; NPC094_CurrentNumLocation = iTempLocation; NPC094_LastLocation = iTempLastLocation; NPC094_LastStrLocation = sTempLastLocation; NPC094_CurrentStrLocation = sTempCurrentLocation; DesireToMove094 = iTempDesireToMove; bCorpse094 = bTempCorpse; iClose094 = iCloseEncounters; Notebook.bNoted094 = Notebook.bTempNoted; Notebook.iObserved094 = Notebook.iTempObserved; NPC_Traits.TraitOne094 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo094 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree094 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne094 = Notebook.bNoteOne; Notebook.bNoteTwo094 = Notebook.bNoteTwo; Notebook.bNoteThree094 = Notebook.bNoteThree; iLoyalty094 = iTempLoyalty; bCorpse094 = bTempCorpse; Flood.bPutInDanger094 = Flood.bPutInDanger; }
            if (tempNPC == NPC_095) { Conversation.bAlreadyTalked095 = Conversation.bTempTalked; sAvailableWeapons095 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker095; iAvailableMacGuffins095 = iTempMacGuffins; NPC095_CurrentNumLocation = iTempLocation; NPC095_LastLocation = iTempLastLocation; NPC095_LastStrLocation = sTempLastLocation; NPC095_CurrentStrLocation = sTempCurrentLocation; DesireToMove095 = iTempDesireToMove; bCorpse095 = bTempCorpse; iClose095 = iCloseEncounters; Notebook.bNoted095 = Notebook.bTempNoted; Notebook.iObserved095 = Notebook.iTempObserved; NPC_Traits.TraitOne095 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo095 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree095 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne095 = Notebook.bNoteOne; Notebook.bNoteTwo095 = Notebook.bNoteTwo; Notebook.bNoteThree095 = Notebook.bNoteThree; iLoyalty095 = iTempLoyalty; bCorpse095 = bTempCorpse; Flood.bPutInDanger095 = Flood.bPutInDanger; }
            if (tempNPC == NPC_096) { Conversation.bAlreadyTalked096 = Conversation.bTempTalked; sAvailableWeapons096 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker096; iAvailableMacGuffins096 = iTempMacGuffins; NPC096_CurrentNumLocation = iTempLocation; NPC096_LastLocation = iTempLastLocation; NPC096_LastStrLocation = sTempLastLocation; NPC096_CurrentStrLocation = sTempCurrentLocation; DesireToMove096 = iTempDesireToMove; bCorpse096 = bTempCorpse; iClose096 = iCloseEncounters; Notebook.bNoted096 = Notebook.bTempNoted; Notebook.iObserved096 = Notebook.iTempObserved; NPC_Traits.TraitOne096 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo096 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree096 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne096 = Notebook.bNoteOne; Notebook.bNoteTwo096 = Notebook.bNoteTwo; Notebook.bNoteThree096 = Notebook.bNoteThree; iLoyalty096 = iTempLoyalty; bCorpse096 = bTempCorpse; Flood.bPutInDanger096 = Flood.bPutInDanger; }
            if (tempNPC == NPC_097) { Conversation.bAlreadyTalked097 = Conversation.bTempTalked; sAvailableWeapons097 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker097; iAvailableMacGuffins097 = iTempMacGuffins; NPC097_CurrentNumLocation = iTempLocation; NPC097_LastLocation = iTempLastLocation; NPC097_LastStrLocation = sTempLastLocation; NPC097_CurrentStrLocation = sTempCurrentLocation; DesireToMove097 = iTempDesireToMove; bCorpse097 = bTempCorpse; iClose097 = iCloseEncounters; Notebook.bNoted097 = Notebook.bTempNoted; Notebook.iObserved097 = Notebook.iTempObserved; NPC_Traits.TraitOne097 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo097 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree097 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne097 = Notebook.bNoteOne; Notebook.bNoteTwo097 = Notebook.bNoteTwo; Notebook.bNoteThree097 = Notebook.bNoteThree; iLoyalty097 = iTempLoyalty; bCorpse097 = bTempCorpse; Flood.bPutInDanger097 = Flood.bPutInDanger; }
            if (tempNPC == NPC_098) { Conversation.bAlreadyTalked098 = Conversation.bTempTalked; sAvailableWeapons098 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker098; iAvailableMacGuffins098 = iTempMacGuffins; NPC098_CurrentNumLocation = iTempLocation; NPC098_LastLocation = iTempLastLocation; NPC098_LastStrLocation = sTempLastLocation; NPC098_CurrentStrLocation = sTempCurrentLocation; DesireToMove098 = iTempDesireToMove; bCorpse098 = bTempCorpse; iClose098 = iCloseEncounters; Notebook.bNoted098 = Notebook.bTempNoted; Notebook.iObserved098 = Notebook.iTempObserved; NPC_Traits.TraitOne098 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo098 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree098 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne098 = Notebook.bNoteOne; Notebook.bNoteTwo098 = Notebook.bNoteTwo; Notebook.bNoteThree098 = Notebook.bNoteThree; iLoyalty098 = iTempLoyalty; bCorpse098 = bTempCorpse; Flood.bPutInDanger098 = Flood.bPutInDanger; }
            if (tempNPC == NPC_099) { Conversation.bAlreadyTalked099 = Conversation.bTempTalked; sAvailableWeapons099 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker099; iAvailableMacGuffins099 = iTempMacGuffins; NPC099_CurrentNumLocation = iTempLocation; NPC099_LastLocation = iTempLastLocation; NPC099_LastStrLocation = sTempLastLocation; NPC099_CurrentStrLocation = sTempCurrentLocation; DesireToMove099 = iTempDesireToMove; bCorpse099 = bTempCorpse; iClose099 = iCloseEncounters; Notebook.bNoted099 = Notebook.bTempNoted; Notebook.iObserved099 = Notebook.iTempObserved; NPC_Traits.TraitOne099 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo099 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree099 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne099 = Notebook.bNoteOne; Notebook.bNoteTwo099 = Notebook.bNoteTwo; Notebook.bNoteThree099 = Notebook.bNoteThree; iLoyalty099 = iTempLoyalty; bCorpse099 = bTempCorpse; Flood.bPutInDanger099 = Flood.bPutInDanger; }
            if (tempNPC == NPC_100) { Conversation.bAlreadyTalked100 = Conversation.bTempTalked; sAvailableWeapons100 = sTempWeapons; Conversation.iSpeaker = Conversation.iSpeaker100; iAvailableMacGuffins100 = iTempMacGuffins; NPC100_CurrentNumLocation = iTempLocation; NPC100_LastLocation = iTempLastLocation; NPC100_LastStrLocation = sTempLastLocation; NPC100_CurrentStrLocation = sTempCurrentLocation; DesireToMove100 = iTempDesireToMove; bCorpse100 = bTempCorpse; iClose100 = iCloseEncounters; Notebook.bNoted100 = Notebook.bTempNoted; Notebook.iObserved100 = Notebook.iTempObserved; NPC_Traits.TraitOne100 = NPC_Traits.sTempTraitOne; NPC_Traits.TraitTwo100 = NPC_Traits.sTempTraitTwo; NPC_Traits.TraitThree100 = NPC_Traits.sTempTraitThree; Notebook.bNoteOne100 = Notebook.bNoteOne; Notebook.bNoteTwo100 = Notebook.bNoteTwo; Notebook.bNoteThree100 = Notebook.bNoteThree; iLoyalty100 = iTempLoyalty; bCorpse100 = bTempCorpse; Flood.bPutInDanger100 = Flood.bPutInDanger; }
        }

        public static void SetAllNPCLocals_TalkingSystem()
        {
            if (tempNPC == NPC_001)
            { 
                iAvailableMacGuffins001 = iTempMacGuffins; 
                sAvailableWeapons001 = sTempWeapons; 
                iLoyalty001 = iTempLoyalty; 
                DesireToMove001 = iTempDesireToMove; 
                bCorpse001 = bTempCorpse; 
                NPC001_CurrentStrLocation = sTempCurrentLocation; 
                NPC001_LastLocation = iTempLastLocation;
                NPC001_CurrentNumLocation = iTempLocation; 
                NPC001_LastStrLocation = sTempLastLocation; 
                Flood.bPutInDanger001 = Flood.bPutInDanger; 
            }
            if (tempNPC == NPC_002)
            { iAvailableMacGuffins002 = iTempMacGuffins; sAvailableWeapons002 = sTempWeapons; iLoyalty002 = iTempLoyalty; DesireToMove002 = iTempDesireToMove; bCorpse002 = bTempCorpse; NPC002_CurrentStrLocation = sTempCurrentLocation; NPC002_LastLocation = iTempLastLocation; NPC002_CurrentNumLocation = iTempLocation; NPC002_LastStrLocation = sTempLastLocation; Flood.bPutInDanger002 = Flood.bPutInDanger; }
            if (tempNPC == NPC_003)
            { iAvailableMacGuffins003 = iTempMacGuffins; sAvailableWeapons003 = sTempWeapons; iLoyalty003 = iTempLoyalty; DesireToMove003 = iTempDesireToMove; bCorpse003 = bTempCorpse; NPC003_CurrentStrLocation = sTempCurrentLocation; NPC003_LastLocation = iTempLastLocation; NPC003_CurrentNumLocation = iTempLocation; NPC003_LastStrLocation = sTempLastLocation; Flood.bPutInDanger003 = Flood.bPutInDanger; }
            if (tempNPC == NPC_004)
            { iAvailableMacGuffins004 = iTempMacGuffins; sAvailableWeapons004 = sTempWeapons; iLoyalty004 = iTempLoyalty; DesireToMove004 = iTempDesireToMove; bCorpse004 = bTempCorpse; NPC004_CurrentStrLocation = sTempCurrentLocation; NPC004_LastLocation = iTempLastLocation; NPC004_CurrentNumLocation = iTempLocation; NPC004_LastStrLocation = sTempLastLocation; Flood.bPutInDanger004 = Flood.bPutInDanger; }
            if (tempNPC == NPC_005)
            { iAvailableMacGuffins005 = iTempMacGuffins; sAvailableWeapons005 = sTempWeapons; iLoyalty005 = iTempLoyalty; DesireToMove005 = iTempDesireToMove; bCorpse005 = bTempCorpse; NPC005_CurrentStrLocation = sTempCurrentLocation; NPC005_LastLocation = iTempLastLocation; NPC005_CurrentNumLocation = iTempLocation; NPC005_LastStrLocation = sTempLastLocation; Flood.bPutInDanger005 = Flood.bPutInDanger; }
            if (tempNPC == NPC_006)
            { iAvailableMacGuffins006 = iTempMacGuffins; sAvailableWeapons006 = sTempWeapons; iLoyalty006 = iTempLoyalty; DesireToMove006 = iTempDesireToMove; bCorpse006 = bTempCorpse; NPC006_CurrentStrLocation = sTempCurrentLocation; NPC006_LastLocation = iTempLastLocation; NPC006_CurrentNumLocation = iTempLocation; NPC006_LastStrLocation = sTempLastLocation; Flood.bPutInDanger006 = Flood.bPutInDanger; }
            if (tempNPC == NPC_007)
            { iAvailableMacGuffins007 = iTempMacGuffins; sAvailableWeapons007 = sTempWeapons; iLoyalty007 = iTempLoyalty; DesireToMove007 = iTempDesireToMove; bCorpse007 = bTempCorpse; NPC007_CurrentStrLocation = sTempCurrentLocation; NPC007_LastLocation = iTempLastLocation; NPC007_CurrentNumLocation = iTempLocation; NPC007_LastStrLocation = sTempLastLocation; Flood.bPutInDanger007 = Flood.bPutInDanger; }
            if (tempNPC == NPC_008)
            { iAvailableMacGuffins008 = iTempMacGuffins; sAvailableWeapons008 = sTempWeapons; iLoyalty008 = iTempLoyalty; DesireToMove008 = iTempDesireToMove; bCorpse008 = bTempCorpse; NPC008_CurrentStrLocation = sTempCurrentLocation; NPC008_LastLocation = iTempLastLocation; NPC008_CurrentNumLocation = iTempLocation; NPC008_LastStrLocation = sTempLastLocation; Flood.bPutInDanger008 = Flood.bPutInDanger; }
            if (tempNPC == NPC_009)
            { iAvailableMacGuffins009 = iTempMacGuffins; sAvailableWeapons009 = sTempWeapons; iLoyalty009 = iTempLoyalty; DesireToMove009 = iTempDesireToMove; bCorpse009 = bTempCorpse; NPC009_CurrentStrLocation = sTempCurrentLocation; NPC009_LastLocation = iTempLastLocation; NPC009_CurrentNumLocation = iTempLocation; NPC009_LastStrLocation = sTempLastLocation; Flood.bPutInDanger009 = Flood.bPutInDanger; }
            if (tempNPC == NPC_010)
            { iAvailableMacGuffins010 = iTempMacGuffins; sAvailableWeapons010 = sTempWeapons; iLoyalty020 = iTempLoyalty; DesireToMove010 = iTempDesireToMove; bCorpse010 = bTempCorpse; NPC010_CurrentStrLocation = sTempCurrentLocation; NPC010_LastLocation = iTempLastLocation; NPC010_CurrentNumLocation = iTempLocation; NPC010_LastStrLocation = sTempLastLocation; Flood.bPutInDanger010 = Flood.bPutInDanger; }
            if (tempNPC == NPC_011)
            { iAvailableMacGuffins011 = iTempMacGuffins; sAvailableWeapons011 = sTempWeapons; iLoyalty011 = iTempLoyalty; DesireToMove011 = iTempDesireToMove; bCorpse011 = bTempCorpse; NPC011_CurrentStrLocation = sTempCurrentLocation; NPC011_LastLocation = iTempLastLocation; NPC011_CurrentNumLocation = iTempLocation; NPC011_LastStrLocation = sTempLastLocation; Flood.bPutInDanger011 = Flood.bPutInDanger; }
            if (tempNPC == NPC_012)
            { iAvailableMacGuffins012 = iTempMacGuffins; sAvailableWeapons012 = sTempWeapons; iLoyalty012 = iTempLoyalty; DesireToMove012 = iTempDesireToMove; bCorpse012 = bTempCorpse; NPC012_CurrentStrLocation = sTempCurrentLocation; NPC012_LastLocation = iTempLastLocation; NPC012_CurrentNumLocation = iTempLocation; NPC012_LastStrLocation = sTempLastLocation; Flood.bPutInDanger012 = Flood.bPutInDanger; }
            if (tempNPC == NPC_013)
            { iAvailableMacGuffins013 = iTempMacGuffins; sAvailableWeapons013 = sTempWeapons; iLoyalty013 = iTempLoyalty; DesireToMove013 = iTempDesireToMove; bCorpse013 = bTempCorpse; NPC013_CurrentStrLocation = sTempCurrentLocation; NPC013_LastLocation = iTempLastLocation; NPC013_CurrentNumLocation = iTempLocation; NPC013_LastStrLocation = sTempLastLocation; Flood.bPutInDanger013 = Flood.bPutInDanger; }
            if (tempNPC == NPC_014)
            { iAvailableMacGuffins014 = iTempMacGuffins; sAvailableWeapons014 = sTempWeapons; iLoyalty014 = iTempLoyalty; DesireToMove014 = iTempDesireToMove; bCorpse014 = bTempCorpse; NPC014_CurrentStrLocation = sTempCurrentLocation; NPC014_LastLocation = iTempLastLocation; NPC014_CurrentNumLocation = iTempLocation; NPC014_LastStrLocation = sTempLastLocation; Flood.bPutInDanger014 = Flood.bPutInDanger; }
            if (tempNPC == NPC_015)
            { iAvailableMacGuffins015 = iTempMacGuffins; sAvailableWeapons015 = sTempWeapons; iLoyalty015 = iTempLoyalty; DesireToMove015 = iTempDesireToMove; bCorpse015 = bTempCorpse; NPC015_CurrentStrLocation = sTempCurrentLocation; NPC015_LastLocation = iTempLastLocation; NPC015_CurrentNumLocation = iTempLocation; NPC015_LastStrLocation = sTempLastLocation; Flood.bPutInDanger015 = Flood.bPutInDanger; }
            if (tempNPC == NPC_016)
            { iAvailableMacGuffins016 = iTempMacGuffins; sAvailableWeapons016 = sTempWeapons; iLoyalty016 = iTempLoyalty; DesireToMove016 = iTempDesireToMove; bCorpse016 = bTempCorpse; NPC016_CurrentStrLocation = sTempCurrentLocation; NPC016_LastLocation = iTempLastLocation; NPC016_CurrentNumLocation = iTempLocation; NPC016_LastStrLocation = sTempLastLocation; Flood.bPutInDanger016 = Flood.bPutInDanger; }
            if (tempNPC == NPC_017)
            { iAvailableMacGuffins017 = iTempMacGuffins; sAvailableWeapons017 = sTempWeapons; iLoyalty017 = iTempLoyalty; DesireToMove017 = iTempDesireToMove; bCorpse017 = bTempCorpse; NPC017_CurrentStrLocation = sTempCurrentLocation; NPC017_LastLocation = iTempLastLocation; NPC017_CurrentNumLocation = iTempLocation; NPC017_LastStrLocation = sTempLastLocation; Flood.bPutInDanger017 = Flood.bPutInDanger; }
            if (tempNPC == NPC_018)
            { iAvailableMacGuffins018 = iTempMacGuffins; sAvailableWeapons018 = sTempWeapons; iLoyalty018 = iTempLoyalty; DesireToMove018 = iTempDesireToMove; bCorpse018 = bTempCorpse; NPC018_CurrentStrLocation = sTempCurrentLocation; NPC018_LastLocation = iTempLastLocation; NPC018_CurrentNumLocation = iTempLocation; NPC018_LastStrLocation = sTempLastLocation; Flood.bPutInDanger018 = Flood.bPutInDanger; }
            if (tempNPC == NPC_019)
            { iAvailableMacGuffins019 = iTempMacGuffins; sAvailableWeapons019 = sTempWeapons; iLoyalty019 = iTempLoyalty; DesireToMove019 = iTempDesireToMove; bCorpse019 = bTempCorpse; NPC019_CurrentStrLocation = sTempCurrentLocation; NPC019_LastLocation = iTempLastLocation; NPC019_CurrentNumLocation = iTempLocation; NPC019_LastStrLocation = sTempLastLocation; Flood.bPutInDanger019 = Flood.bPutInDanger; }
            if (tempNPC == NPC_020)
            { iAvailableMacGuffins020 = iTempMacGuffins; sAvailableWeapons020 = sTempWeapons; iLoyalty020 = iTempLoyalty; DesireToMove020 = iTempDesireToMove; bCorpse020 = bTempCorpse; NPC020_CurrentStrLocation = sTempCurrentLocation; NPC020_LastLocation = iTempLastLocation; NPC020_CurrentNumLocation = iTempLocation; NPC020_LastStrLocation = sTempLastLocation; Flood.bPutInDanger020 = Flood.bPutInDanger; }
            if (tempNPC == NPC_021)
            { iAvailableMacGuffins021 = iTempMacGuffins; sAvailableWeapons021 = sTempWeapons; iLoyalty021 = iTempLoyalty; DesireToMove021 = iTempDesireToMove; bCorpse021 = bTempCorpse; NPC021_CurrentStrLocation = sTempCurrentLocation; NPC021_LastLocation = iTempLastLocation; NPC021_CurrentNumLocation = iTempLocation; NPC021_LastStrLocation = sTempLastLocation; Flood.bPutInDanger021 = Flood.bPutInDanger; }
            if (tempNPC == NPC_022)
            { iAvailableMacGuffins022 = iTempMacGuffins; sAvailableWeapons022 = sTempWeapons; iLoyalty022 = iTempLoyalty; DesireToMove022 = iTempDesireToMove; bCorpse022 = bTempCorpse; NPC022_CurrentStrLocation = sTempCurrentLocation; NPC022_LastLocation = iTempLastLocation; NPC022_CurrentNumLocation = iTempLocation; NPC022_LastStrLocation = sTempLastLocation; Flood.bPutInDanger022 = Flood.bPutInDanger; }
            if (tempNPC == NPC_023)
            { iAvailableMacGuffins023 = iTempMacGuffins; sAvailableWeapons023 = sTempWeapons; iLoyalty023 = iTempLoyalty; DesireToMove023 = iTempDesireToMove; bCorpse023 = bTempCorpse; NPC023_CurrentStrLocation = sTempCurrentLocation; NPC023_LastLocation = iTempLastLocation; NPC023_CurrentNumLocation = iTempLocation; NPC023_LastStrLocation = sTempLastLocation; Flood.bPutInDanger023 = Flood.bPutInDanger; }
            if (tempNPC == NPC_024)
            { iAvailableMacGuffins024 = iTempMacGuffins; sAvailableWeapons024 = sTempWeapons; iLoyalty024 = iTempLoyalty; DesireToMove024 = iTempDesireToMove; bCorpse024 = bTempCorpse; NPC024_CurrentStrLocation = sTempCurrentLocation; NPC024_LastLocation = iTempLastLocation; NPC024_CurrentNumLocation = iTempLocation; NPC024_LastStrLocation = sTempLastLocation; Flood.bPutInDanger024 = Flood.bPutInDanger; }
            if (tempNPC == NPC_025)
            { iAvailableMacGuffins025 = iTempMacGuffins; sAvailableWeapons025 = sTempWeapons; iLoyalty025 = iTempLoyalty; DesireToMove025 = iTempDesireToMove; bCorpse025 = bTempCorpse; NPC025_CurrentStrLocation = sTempCurrentLocation; NPC025_LastLocation = iTempLastLocation; NPC025_CurrentNumLocation = iTempLocation; NPC025_LastStrLocation = sTempLastLocation; Flood.bPutInDanger025 = Flood.bPutInDanger; }
            if (tempNPC == NPC_026)
            { iAvailableMacGuffins026 = iTempMacGuffins; sAvailableWeapons026 = sTempWeapons; iLoyalty026 = iTempLoyalty; DesireToMove026 = iTempDesireToMove; bCorpse026 = bTempCorpse; NPC026_CurrentStrLocation = sTempCurrentLocation; NPC026_LastLocation = iTempLastLocation; NPC026_CurrentNumLocation = iTempLocation; NPC026_LastStrLocation = sTempLastLocation; Flood.bPutInDanger026 = Flood.bPutInDanger; }
            if (tempNPC == NPC_027)
            { iAvailableMacGuffins027 = iTempMacGuffins; sAvailableWeapons027 = sTempWeapons; iLoyalty027 = iTempLoyalty; DesireToMove027 = iTempDesireToMove; bCorpse027 = bTempCorpse; NPC027_CurrentStrLocation = sTempCurrentLocation; NPC027_LastLocation = iTempLastLocation; NPC027_CurrentNumLocation = iTempLocation; NPC027_LastStrLocation = sTempLastLocation; Flood.bPutInDanger027 = Flood.bPutInDanger; }
            if (tempNPC == NPC_028)
            { iAvailableMacGuffins028 = iTempMacGuffins; sAvailableWeapons028 = sTempWeapons; iLoyalty028 = iTempLoyalty; DesireToMove028 = iTempDesireToMove; bCorpse028 = bTempCorpse; NPC028_CurrentStrLocation = sTempCurrentLocation; NPC028_LastLocation = iTempLastLocation; NPC028_CurrentNumLocation = iTempLocation; NPC028_LastStrLocation = sTempLastLocation; Flood.bPutInDanger028 = Flood.bPutInDanger; }
            if (tempNPC == NPC_029)
            { iAvailableMacGuffins029 = iTempMacGuffins; sAvailableWeapons029 = sTempWeapons; iLoyalty029 = iTempLoyalty; DesireToMove029 = iTempDesireToMove; bCorpse029 = bTempCorpse; NPC029_CurrentStrLocation = sTempCurrentLocation; NPC029_LastLocation = iTempLastLocation; NPC029_CurrentNumLocation = iTempLocation; NPC029_LastStrLocation = sTempLastLocation; Flood.bPutInDanger029 = Flood.bPutInDanger; }
            if (tempNPC == NPC_030)
            { iAvailableMacGuffins030 = iTempMacGuffins; sAvailableWeapons030 = sTempWeapons; iLoyalty030 = iTempLoyalty; DesireToMove030 = iTempDesireToMove; bCorpse030 = bTempCorpse; NPC030_CurrentStrLocation = sTempCurrentLocation; NPC030_LastLocation = iTempLastLocation; NPC030_CurrentNumLocation = iTempLocation; NPC030_LastStrLocation = sTempLastLocation; Flood.bPutInDanger030 = Flood.bPutInDanger; }
            if (tempNPC == NPC_031)
            { iAvailableMacGuffins031 = iTempMacGuffins; sAvailableWeapons031 = sTempWeapons; iLoyalty031 = iTempLoyalty; DesireToMove031 = iTempDesireToMove; bCorpse031 = bTempCorpse; NPC031_CurrentStrLocation = sTempCurrentLocation; NPC031_LastLocation = iTempLastLocation; NPC031_CurrentNumLocation = iTempLocation; NPC031_LastStrLocation = sTempLastLocation; Flood.bPutInDanger031 = Flood.bPutInDanger; }
            if (tempNPC == NPC_032)
            { iAvailableMacGuffins032 = iTempMacGuffins; sAvailableWeapons032 = sTempWeapons; iLoyalty032 = iTempLoyalty; DesireToMove032 = iTempDesireToMove; bCorpse032 = bTempCorpse; NPC032_CurrentStrLocation = sTempCurrentLocation; NPC032_LastLocation = iTempLastLocation; NPC032_CurrentNumLocation = iTempLocation; NPC032_LastStrLocation = sTempLastLocation; Flood.bPutInDanger032 = Flood.bPutInDanger; }
            if (tempNPC == NPC_033)
            { iAvailableMacGuffins033 = iTempMacGuffins; sAvailableWeapons033 = sTempWeapons; iLoyalty033 = iTempLoyalty; DesireToMove033 = iTempDesireToMove; bCorpse033 = bTempCorpse; NPC033_CurrentStrLocation = sTempCurrentLocation; NPC033_LastLocation = iTempLastLocation; NPC033_CurrentNumLocation = iTempLocation; NPC033_LastStrLocation = sTempLastLocation; Flood.bPutInDanger033 = Flood.bPutInDanger; }
            if (tempNPC == NPC_034)
            { iAvailableMacGuffins034 = iTempMacGuffins; sAvailableWeapons034 = sTempWeapons; iLoyalty034 = iTempLoyalty; DesireToMove034 = iTempDesireToMove; bCorpse034 = bTempCorpse; NPC034_CurrentStrLocation = sTempCurrentLocation; NPC034_LastLocation = iTempLastLocation; NPC034_CurrentNumLocation = iTempLocation; NPC034_LastStrLocation = sTempLastLocation; Flood.bPutInDanger034 = Flood.bPutInDanger; }
            if (tempNPC == NPC_035)
            { iAvailableMacGuffins035 = iTempMacGuffins; sAvailableWeapons035 = sTempWeapons; iLoyalty035 = iTempLoyalty; DesireToMove035 = iTempDesireToMove; bCorpse035 = bTempCorpse; NPC035_CurrentStrLocation = sTempCurrentLocation; NPC035_LastLocation = iTempLastLocation; NPC035_CurrentNumLocation = iTempLocation; NPC035_LastStrLocation = sTempLastLocation; Flood.bPutInDanger035 = Flood.bPutInDanger; }
            if (tempNPC == NPC_036)
            { iAvailableMacGuffins036 = iTempMacGuffins; sAvailableWeapons036 = sTempWeapons; iLoyalty036 = iTempLoyalty; DesireToMove036 = iTempDesireToMove; bCorpse036 = bTempCorpse; NPC036_CurrentStrLocation = sTempCurrentLocation; NPC036_LastLocation = iTempLastLocation; NPC036_CurrentNumLocation = iTempLocation; NPC036_LastStrLocation = sTempLastLocation; Flood.bPutInDanger036 = Flood.bPutInDanger; }
            if (tempNPC == NPC_037)
            { iAvailableMacGuffins037 = iTempMacGuffins; sAvailableWeapons037 = sTempWeapons; iLoyalty037 = iTempLoyalty; DesireToMove037 = iTempDesireToMove; bCorpse037 = bTempCorpse; NPC037_CurrentStrLocation = sTempCurrentLocation; NPC037_LastLocation = iTempLastLocation; NPC037_CurrentNumLocation = iTempLocation; NPC037_LastStrLocation = sTempLastLocation; Flood.bPutInDanger037 = Flood.bPutInDanger; }
            if (tempNPC == NPC_038)
            { iAvailableMacGuffins038 = iTempMacGuffins; sAvailableWeapons038 = sTempWeapons; iLoyalty038 = iTempLoyalty; DesireToMove038 = iTempDesireToMove; bCorpse038 = bTempCorpse; NPC038_CurrentStrLocation = sTempCurrentLocation; NPC038_LastLocation = iTempLastLocation; NPC038_CurrentNumLocation = iTempLocation; NPC038_LastStrLocation = sTempLastLocation; Flood.bPutInDanger038 = Flood.bPutInDanger; }
            if (tempNPC == NPC_039)
            { iAvailableMacGuffins039 = iTempMacGuffins; sAvailableWeapons039 = sTempWeapons; iLoyalty039 = iTempLoyalty; DesireToMove039 = iTempDesireToMove; bCorpse039 = bTempCorpse; NPC039_CurrentStrLocation = sTempCurrentLocation; NPC039_LastLocation = iTempLastLocation; NPC039_CurrentNumLocation = iTempLocation; NPC039_LastStrLocation = sTempLastLocation; Flood.bPutInDanger039 = Flood.bPutInDanger; }
            if (tempNPC == NPC_040)
            { iAvailableMacGuffins040 = iTempMacGuffins; sAvailableWeapons040 = sTempWeapons; iLoyalty040 = iTempLoyalty; DesireToMove040 = iTempDesireToMove; bCorpse040 = bTempCorpse; NPC040_CurrentStrLocation = sTempCurrentLocation; NPC040_LastLocation = iTempLastLocation; NPC040_CurrentNumLocation = iTempLocation; NPC040_LastStrLocation = sTempLastLocation; Flood.bPutInDanger040 = Flood.bPutInDanger; }
            if (tempNPC == NPC_041)
            { iAvailableMacGuffins041 = iTempMacGuffins; sAvailableWeapons041 = sTempWeapons; iLoyalty041 = iTempLoyalty; DesireToMove041 = iTempDesireToMove; bCorpse041 = bTempCorpse; NPC041_CurrentStrLocation = sTempCurrentLocation; NPC041_LastLocation = iTempLastLocation; NPC041_CurrentNumLocation = iTempLocation; NPC041_LastStrLocation = sTempLastLocation; Flood.bPutInDanger041 = Flood.bPutInDanger; }
            if (tempNPC == NPC_042)
            { iAvailableMacGuffins042 = iTempMacGuffins; sAvailableWeapons042 = sTempWeapons; iLoyalty042 = iTempLoyalty; DesireToMove042 = iTempDesireToMove; bCorpse042 = bTempCorpse; NPC042_CurrentStrLocation = sTempCurrentLocation; NPC042_LastLocation = iTempLastLocation; NPC042_CurrentNumLocation = iTempLocation; NPC042_LastStrLocation = sTempLastLocation; Flood.bPutInDanger042 = Flood.bPutInDanger; }
            if (tempNPC == NPC_043)
            { iAvailableMacGuffins043 = iTempMacGuffins; sAvailableWeapons043 = sTempWeapons; iLoyalty043 = iTempLoyalty; DesireToMove043 = iTempDesireToMove; bCorpse043 = bTempCorpse; NPC043_CurrentStrLocation = sTempCurrentLocation; NPC043_LastLocation = iTempLastLocation; NPC043_CurrentNumLocation = iTempLocation; NPC043_LastStrLocation = sTempLastLocation; Flood.bPutInDanger043 = Flood.bPutInDanger; }
            if (tempNPC == NPC_044)
            { iAvailableMacGuffins044 = iTempMacGuffins; sAvailableWeapons044 = sTempWeapons; iLoyalty044 = iTempLoyalty; DesireToMove044 = iTempDesireToMove; bCorpse044 = bTempCorpse; NPC044_CurrentStrLocation = sTempCurrentLocation; NPC044_LastLocation = iTempLastLocation; NPC044_CurrentNumLocation = iTempLocation; NPC044_LastStrLocation = sTempLastLocation; Flood.bPutInDanger044 = Flood.bPutInDanger; }
            if (tempNPC == NPC_045)
            { iAvailableMacGuffins045 = iTempMacGuffins; sAvailableWeapons045 = sTempWeapons; iLoyalty045 = iTempLoyalty; DesireToMove045 = iTempDesireToMove; bCorpse045 = bTempCorpse; NPC045_CurrentStrLocation = sTempCurrentLocation; NPC045_LastLocation = iTempLastLocation; NPC045_CurrentNumLocation = iTempLocation; NPC045_LastStrLocation = sTempLastLocation; Flood.bPutInDanger045 = Flood.bPutInDanger; }
            if (tempNPC == NPC_046)
            { iAvailableMacGuffins046 = iTempMacGuffins; sAvailableWeapons046 = sTempWeapons; iLoyalty046 = iTempLoyalty; DesireToMove046 = iTempDesireToMove; bCorpse046 = bTempCorpse; NPC046_CurrentStrLocation = sTempCurrentLocation; NPC046_LastLocation = iTempLastLocation; NPC046_CurrentNumLocation = iTempLocation; NPC046_LastStrLocation = sTempLastLocation; Flood.bPutInDanger046 = Flood.bPutInDanger; }
            if (tempNPC == NPC_047)
            { iAvailableMacGuffins047 = iTempMacGuffins; sAvailableWeapons047 = sTempWeapons; iLoyalty047 = iTempLoyalty; DesireToMove047 = iTempDesireToMove; bCorpse047 = bTempCorpse; NPC047_CurrentStrLocation = sTempCurrentLocation; NPC047_LastLocation = iTempLastLocation; NPC047_CurrentNumLocation = iTempLocation; NPC047_LastStrLocation = sTempLastLocation; Flood.bPutInDanger047 = Flood.bPutInDanger; }
            if (tempNPC == NPC_048)
            { iAvailableMacGuffins048 = iTempMacGuffins; sAvailableWeapons048 = sTempWeapons; iLoyalty048 = iTempLoyalty; DesireToMove048 = iTempDesireToMove; bCorpse048 = bTempCorpse; NPC048_CurrentStrLocation = sTempCurrentLocation; NPC048_LastLocation = iTempLastLocation; NPC048_CurrentNumLocation = iTempLocation; NPC048_LastStrLocation = sTempLastLocation; Flood.bPutInDanger048 = Flood.bPutInDanger; }
            if (tempNPC == NPC_049)
            { iAvailableMacGuffins049 = iTempMacGuffins; sAvailableWeapons049 = sTempWeapons; iLoyalty049 = iTempLoyalty; DesireToMove049 = iTempDesireToMove; bCorpse049 = bTempCorpse; NPC049_CurrentStrLocation = sTempCurrentLocation; NPC049_LastLocation = iTempLastLocation; NPC049_CurrentNumLocation = iTempLocation; NPC049_LastStrLocation = sTempLastLocation; Flood.bPutInDanger049 = Flood.bPutInDanger; }
            if (tempNPC == NPC_050)
            { iAvailableMacGuffins050 = iTempMacGuffins; sAvailableWeapons050 = sTempWeapons; iLoyalty050 = iTempLoyalty; DesireToMove050 = iTempDesireToMove; bCorpse050 = bTempCorpse; NPC050_CurrentStrLocation = sTempCurrentLocation; NPC050_LastLocation = iTempLastLocation; NPC050_CurrentNumLocation = iTempLocation; NPC050_LastStrLocation = sTempLastLocation; Flood.bPutInDanger050 = Flood.bPutInDanger; }
            if (tempNPC == NPC_051)
            { iAvailableMacGuffins051 = iTempMacGuffins; sAvailableWeapons051 = sTempWeapons; iLoyalty051 = iTempLoyalty; DesireToMove051 = iTempDesireToMove; bCorpse051 = bTempCorpse; NPC051_CurrentStrLocation = sTempCurrentLocation; NPC051_LastLocation = iTempLastLocation; NPC051_CurrentNumLocation = iTempLocation; NPC051_LastStrLocation = sTempLastLocation; Flood.bPutInDanger051 = Flood.bPutInDanger; }
            if (tempNPC == NPC_052)
            { iAvailableMacGuffins052 = iTempMacGuffins; sAvailableWeapons052 = sTempWeapons; iLoyalty052 = iTempLoyalty; DesireToMove052 = iTempDesireToMove; bCorpse052 = bTempCorpse; NPC052_CurrentStrLocation = sTempCurrentLocation; NPC052_LastLocation = iTempLastLocation; NPC052_CurrentNumLocation = iTempLocation; NPC052_LastStrLocation = sTempLastLocation; Flood.bPutInDanger052 = Flood.bPutInDanger; }
            if (tempNPC == NPC_053)
            { iAvailableMacGuffins053 = iTempMacGuffins; sAvailableWeapons053 = sTempWeapons; iLoyalty053 = iTempLoyalty; DesireToMove053 = iTempDesireToMove; bCorpse053 = bTempCorpse; NPC053_CurrentStrLocation = sTempCurrentLocation; NPC053_LastLocation = iTempLastLocation; NPC053_CurrentNumLocation = iTempLocation; NPC053_LastStrLocation = sTempLastLocation; Flood.bPutInDanger053 = Flood.bPutInDanger; }
            if (tempNPC == NPC_054)
            { iAvailableMacGuffins054 = iTempMacGuffins; sAvailableWeapons054 = sTempWeapons; iLoyalty054 = iTempLoyalty; DesireToMove054 = iTempDesireToMove; bCorpse054 = bTempCorpse; NPC054_CurrentStrLocation = sTempCurrentLocation; NPC054_LastLocation = iTempLastLocation; NPC054_CurrentNumLocation = iTempLocation; NPC054_LastStrLocation = sTempLastLocation; Flood.bPutInDanger054 = Flood.bPutInDanger; }
            if (tempNPC == NPC_055)
            { iAvailableMacGuffins055 = iTempMacGuffins; sAvailableWeapons055 = sTempWeapons; iLoyalty055 = iTempLoyalty; DesireToMove055 = iTempDesireToMove; bCorpse055 = bTempCorpse; NPC055_CurrentStrLocation = sTempCurrentLocation; NPC055_LastLocation = iTempLastLocation; NPC055_CurrentNumLocation = iTempLocation; NPC055_LastStrLocation = sTempLastLocation; Flood.bPutInDanger055 = Flood.bPutInDanger; }
            if (tempNPC == NPC_056)
            { iAvailableMacGuffins056 = iTempMacGuffins; sAvailableWeapons056 = sTempWeapons; iLoyalty056 = iTempLoyalty; DesireToMove056 = iTempDesireToMove; bCorpse056 = bTempCorpse; NPC056_CurrentStrLocation = sTempCurrentLocation; NPC056_LastLocation = iTempLastLocation; NPC056_CurrentNumLocation = iTempLocation; NPC056_LastStrLocation = sTempLastLocation; Flood.bPutInDanger056 = Flood.bPutInDanger; }
            if (tempNPC == NPC_057)
            { iAvailableMacGuffins057 = iTempMacGuffins; sAvailableWeapons057 = sTempWeapons; iLoyalty057 = iTempLoyalty; DesireToMove057 = iTempDesireToMove; bCorpse057 = bTempCorpse; NPC057_CurrentStrLocation = sTempCurrentLocation; NPC057_LastLocation = iTempLastLocation; NPC057_CurrentNumLocation = iTempLocation; NPC057_LastStrLocation = sTempLastLocation; Flood.bPutInDanger057 = Flood.bPutInDanger; }
            if (tempNPC == NPC_058)
            { iAvailableMacGuffins058 = iTempMacGuffins; sAvailableWeapons058 = sTempWeapons; iLoyalty058 = iTempLoyalty; DesireToMove058 = iTempDesireToMove; bCorpse058 = bTempCorpse; NPC058_CurrentStrLocation = sTempCurrentLocation; NPC058_LastLocation = iTempLastLocation; NPC058_CurrentNumLocation = iTempLocation; NPC058_LastStrLocation = sTempLastLocation; Flood.bPutInDanger058 = Flood.bPutInDanger; }
            if (tempNPC == NPC_059)
            { iAvailableMacGuffins059 = iTempMacGuffins; sAvailableWeapons059 = sTempWeapons; iLoyalty059 = iTempLoyalty; DesireToMove059 = iTempDesireToMove; bCorpse059 = bTempCorpse; NPC059_CurrentStrLocation = sTempCurrentLocation; NPC059_LastLocation = iTempLastLocation; NPC059_CurrentNumLocation = iTempLocation; NPC059_LastStrLocation = sTempLastLocation; Flood.bPutInDanger059 = Flood.bPutInDanger; }
            if (tempNPC == NPC_060)
            { iAvailableMacGuffins060 = iTempMacGuffins; sAvailableWeapons060 = sTempWeapons; iLoyalty060 = iTempLoyalty; DesireToMove060 = iTempDesireToMove; bCorpse060 = bTempCorpse; NPC060_CurrentStrLocation = sTempCurrentLocation; NPC060_LastLocation = iTempLastLocation; NPC060_CurrentNumLocation = iTempLocation; NPC060_LastStrLocation = sTempLastLocation; Flood.bPutInDanger060 = Flood.bPutInDanger; }
            if (tempNPC == NPC_061)
            { iAvailableMacGuffins061 = iTempMacGuffins; sAvailableWeapons061 = sTempWeapons; iLoyalty061 = iTempLoyalty; DesireToMove061 = iTempDesireToMove; bCorpse061 = bTempCorpse; NPC061_CurrentStrLocation = sTempCurrentLocation; NPC061_LastLocation = iTempLastLocation; NPC061_CurrentNumLocation = iTempLocation; NPC061_LastStrLocation = sTempLastLocation; Flood.bPutInDanger061 = Flood.bPutInDanger; }
            if (tempNPC == NPC_062)
            { iAvailableMacGuffins062 = iTempMacGuffins; sAvailableWeapons062 = sTempWeapons; iLoyalty062 = iTempLoyalty; DesireToMove062 = iTempDesireToMove; bCorpse062 = bTempCorpse; NPC062_CurrentStrLocation = sTempCurrentLocation; NPC062_LastLocation = iTempLastLocation; NPC062_CurrentNumLocation = iTempLocation; NPC062_LastStrLocation = sTempLastLocation; Flood.bPutInDanger062 = Flood.bPutInDanger; }
            if (tempNPC == NPC_063)
            { iAvailableMacGuffins063 = iTempMacGuffins; sAvailableWeapons063 = sTempWeapons; iLoyalty063 = iTempLoyalty; DesireToMove063 = iTempDesireToMove; bCorpse063 = bTempCorpse; NPC063_CurrentStrLocation = sTempCurrentLocation; NPC063_LastLocation = iTempLastLocation; NPC063_CurrentNumLocation = iTempLocation; NPC063_LastStrLocation = sTempLastLocation; Flood.bPutInDanger063 = Flood.bPutInDanger; }
            if (tempNPC == NPC_064)
            { iAvailableMacGuffins064 = iTempMacGuffins; sAvailableWeapons064 = sTempWeapons; iLoyalty064 = iTempLoyalty; DesireToMove064 = iTempDesireToMove; bCorpse064 = bTempCorpse; NPC064_CurrentStrLocation = sTempCurrentLocation; NPC064_LastLocation = iTempLastLocation; NPC064_CurrentNumLocation = iTempLocation; NPC064_LastStrLocation = sTempLastLocation; Flood.bPutInDanger064 = Flood.bPutInDanger; }
            if (tempNPC == NPC_065)
            { iAvailableMacGuffins065 = iTempMacGuffins; sAvailableWeapons065 = sTempWeapons; iLoyalty065 = iTempLoyalty; DesireToMove065 = iTempDesireToMove; bCorpse065 = bTempCorpse; NPC065_CurrentStrLocation = sTempCurrentLocation; NPC065_LastLocation = iTempLastLocation; NPC065_CurrentNumLocation = iTempLocation; NPC065_LastStrLocation = sTempLastLocation; Flood.bPutInDanger065 = Flood.bPutInDanger; }
            if (tempNPC == NPC_066)
            { iAvailableMacGuffins066 = iTempMacGuffins; sAvailableWeapons066 = sTempWeapons; iLoyalty066 = iTempLoyalty; DesireToMove066 = iTempDesireToMove; bCorpse066 = bTempCorpse; NPC066_CurrentStrLocation = sTempCurrentLocation; NPC066_LastLocation = iTempLastLocation; NPC066_CurrentNumLocation = iTempLocation; NPC066_LastStrLocation = sTempLastLocation; Flood.bPutInDanger066 = Flood.bPutInDanger; }
            if (tempNPC == NPC_067)
            { iAvailableMacGuffins067 = iTempMacGuffins; sAvailableWeapons067 = sTempWeapons; iLoyalty067 = iTempLoyalty; DesireToMove067 = iTempDesireToMove; bCorpse067 = bTempCorpse; NPC067_CurrentStrLocation = sTempCurrentLocation; NPC067_LastLocation = iTempLastLocation; NPC067_CurrentNumLocation = iTempLocation; NPC067_LastStrLocation = sTempLastLocation; Flood.bPutInDanger067 = Flood.bPutInDanger; }
            if (tempNPC == NPC_068)
            { iAvailableMacGuffins068 = iTempMacGuffins; sAvailableWeapons068 = sTempWeapons; iLoyalty068 = iTempLoyalty; DesireToMove068 = iTempDesireToMove; bCorpse068 = bTempCorpse; NPC068_CurrentStrLocation = sTempCurrentLocation; NPC068_LastLocation = iTempLastLocation; NPC068_CurrentNumLocation = iTempLocation; NPC068_LastStrLocation = sTempLastLocation; Flood.bPutInDanger068 = Flood.bPutInDanger; }
            if (tempNPC == NPC_069)
            { iAvailableMacGuffins069 = iTempMacGuffins; sAvailableWeapons069 = sTempWeapons; iLoyalty069 = iTempLoyalty; DesireToMove069 = iTempDesireToMove; bCorpse069 = bTempCorpse; NPC069_CurrentStrLocation = sTempCurrentLocation; NPC069_LastLocation = iTempLastLocation; NPC069_CurrentNumLocation = iTempLocation; NPC069_LastStrLocation = sTempLastLocation; Flood.bPutInDanger069 = Flood.bPutInDanger; }
            if (tempNPC == NPC_070)
            { iAvailableMacGuffins070 = iTempMacGuffins; sAvailableWeapons070 = sTempWeapons; iLoyalty070 = iTempLoyalty; DesireToMove070 = iTempDesireToMove; bCorpse070 = bTempCorpse; NPC070_CurrentStrLocation = sTempCurrentLocation; NPC070_LastLocation = iTempLastLocation; NPC070_CurrentNumLocation = iTempLocation; NPC070_LastStrLocation = sTempLastLocation; Flood.bPutInDanger070 = Flood.bPutInDanger; }
            if (tempNPC == NPC_071)
            { iAvailableMacGuffins071 = iTempMacGuffins; sAvailableWeapons071 = sTempWeapons; iLoyalty071 = iTempLoyalty; DesireToMove071 = iTempDesireToMove; bCorpse071 = bTempCorpse; NPC071_CurrentStrLocation = sTempCurrentLocation; NPC071_LastLocation = iTempLastLocation; NPC071_CurrentNumLocation = iTempLocation; NPC071_LastStrLocation = sTempLastLocation; Flood.bPutInDanger071 = Flood.bPutInDanger; }
            if (tempNPC == NPC_072)
            { iAvailableMacGuffins072 = iTempMacGuffins; sAvailableWeapons072 = sTempWeapons; iLoyalty072 = iTempLoyalty; DesireToMove072 = iTempDesireToMove; bCorpse072 = bTempCorpse; NPC072_CurrentStrLocation = sTempCurrentLocation; NPC072_LastLocation = iTempLastLocation; NPC072_CurrentNumLocation = iTempLocation; NPC072_LastStrLocation = sTempLastLocation; Flood.bPutInDanger072 = Flood.bPutInDanger; }
            if (tempNPC == NPC_073)
            { iAvailableMacGuffins073 = iTempMacGuffins; sAvailableWeapons073 = sTempWeapons; iLoyalty073 = iTempLoyalty; DesireToMove073 = iTempDesireToMove; bCorpse073 = bTempCorpse; NPC073_CurrentStrLocation = sTempCurrentLocation; NPC073_LastLocation = iTempLastLocation; NPC073_CurrentNumLocation = iTempLocation; NPC073_LastStrLocation = sTempLastLocation; Flood.bPutInDanger073 = Flood.bPutInDanger; }
            if (tempNPC == NPC_074)
            { iAvailableMacGuffins074 = iTempMacGuffins; sAvailableWeapons074 = sTempWeapons; iLoyalty074 = iTempLoyalty; DesireToMove074 = iTempDesireToMove; bCorpse074 = bTempCorpse; NPC074_CurrentStrLocation = sTempCurrentLocation; NPC074_LastLocation = iTempLastLocation; NPC074_CurrentNumLocation = iTempLocation; NPC074_LastStrLocation = sTempLastLocation; Flood.bPutInDanger074 = Flood.bPutInDanger; }
            if (tempNPC == NPC_075)
            { iAvailableMacGuffins075 = iTempMacGuffins; sAvailableWeapons075 = sTempWeapons; iLoyalty075 = iTempLoyalty; DesireToMove075 = iTempDesireToMove; bCorpse075 = bTempCorpse; NPC075_CurrentStrLocation = sTempCurrentLocation; NPC075_LastLocation = iTempLastLocation; NPC075_CurrentNumLocation = iTempLocation; NPC075_LastStrLocation = sTempLastLocation; Flood.bPutInDanger075 = Flood.bPutInDanger; }
            if (tempNPC == NPC_076)
            { iAvailableMacGuffins076 = iTempMacGuffins; sAvailableWeapons076 = sTempWeapons; iLoyalty076 = iTempLoyalty; DesireToMove076 = iTempDesireToMove; bCorpse076 = bTempCorpse; NPC076_CurrentStrLocation = sTempCurrentLocation; NPC076_LastLocation = iTempLastLocation; NPC076_CurrentNumLocation = iTempLocation; NPC076_LastStrLocation = sTempLastLocation; Flood.bPutInDanger076 = Flood.bPutInDanger; }
            if (tempNPC == NPC_077)
            { iAvailableMacGuffins077 = iTempMacGuffins; sAvailableWeapons077 = sTempWeapons; iLoyalty077 = iTempLoyalty; DesireToMove077 = iTempDesireToMove; bCorpse077 = bTempCorpse; NPC077_CurrentStrLocation = sTempCurrentLocation; NPC077_LastLocation = iTempLastLocation; NPC077_CurrentNumLocation = iTempLocation; NPC077_LastStrLocation = sTempLastLocation; Flood.bPutInDanger077 = Flood.bPutInDanger; }
            if (tempNPC == NPC_078)
            { iAvailableMacGuffins078 = iTempMacGuffins; sAvailableWeapons078 = sTempWeapons; iLoyalty078 = iTempLoyalty; DesireToMove078 = iTempDesireToMove; bCorpse078 = bTempCorpse; NPC078_CurrentStrLocation = sTempCurrentLocation; NPC078_LastLocation = iTempLastLocation; NPC078_CurrentNumLocation = iTempLocation; NPC078_LastStrLocation = sTempLastLocation; Flood.bPutInDanger078 = Flood.bPutInDanger; }
            if (tempNPC == NPC_079)
            { iAvailableMacGuffins079 = iTempMacGuffins; sAvailableWeapons079 = sTempWeapons; iLoyalty079 = iTempLoyalty; DesireToMove079 = iTempDesireToMove; bCorpse079 = bTempCorpse; NPC079_CurrentStrLocation = sTempCurrentLocation; NPC079_LastLocation = iTempLastLocation; NPC079_CurrentNumLocation = iTempLocation; NPC079_LastStrLocation = sTempLastLocation; Flood.bPutInDanger079 = Flood.bPutInDanger; }
            if (tempNPC == NPC_080)
            { iAvailableMacGuffins080 = iTempMacGuffins; sAvailableWeapons080 = sTempWeapons; iLoyalty080 = iTempLoyalty; DesireToMove080 = iTempDesireToMove; bCorpse080 = bTempCorpse; NPC080_CurrentStrLocation = sTempCurrentLocation; NPC080_LastLocation = iTempLastLocation; NPC080_CurrentNumLocation = iTempLocation; NPC080_LastStrLocation = sTempLastLocation; Flood.bPutInDanger080 = Flood.bPutInDanger; }
            if (tempNPC == NPC_081)
            { iAvailableMacGuffins081 = iTempMacGuffins; sAvailableWeapons081 = sTempWeapons; iLoyalty081 = iTempLoyalty; DesireToMove081 = iTempDesireToMove; bCorpse081 = bTempCorpse; NPC081_CurrentStrLocation = sTempCurrentLocation; NPC081_LastLocation = iTempLastLocation; NPC081_CurrentNumLocation = iTempLocation; NPC081_LastStrLocation = sTempLastLocation; Flood.bPutInDanger081 = Flood.bPutInDanger; }
            if (tempNPC == NPC_082)
            { iAvailableMacGuffins082 = iTempMacGuffins; sAvailableWeapons082 = sTempWeapons; iLoyalty082 = iTempLoyalty; DesireToMove082 = iTempDesireToMove; bCorpse082 = bTempCorpse; NPC082_CurrentStrLocation = sTempCurrentLocation; NPC082_LastLocation = iTempLastLocation; NPC082_CurrentNumLocation = iTempLocation; NPC082_LastStrLocation = sTempLastLocation; Flood.bPutInDanger082 = Flood.bPutInDanger; }
            if (tempNPC == NPC_083)
            { iAvailableMacGuffins083 = iTempMacGuffins; sAvailableWeapons083 = sTempWeapons; iLoyalty083 = iTempLoyalty; DesireToMove083 = iTempDesireToMove; bCorpse083 = bTempCorpse; NPC083_CurrentStrLocation = sTempCurrentLocation; NPC083_LastLocation = iTempLastLocation; NPC083_CurrentNumLocation = iTempLocation; NPC083_LastStrLocation = sTempLastLocation; Flood.bPutInDanger083 = Flood.bPutInDanger; }
            if (tempNPC == NPC_084)
            { iAvailableMacGuffins084 = iTempMacGuffins; sAvailableWeapons084 = sTempWeapons; iLoyalty084 = iTempLoyalty; DesireToMove084 = iTempDesireToMove; bCorpse084 = bTempCorpse; NPC084_CurrentStrLocation = sTempCurrentLocation; NPC084_LastLocation = iTempLastLocation; NPC084_CurrentNumLocation = iTempLocation; NPC084_LastStrLocation = sTempLastLocation; Flood.bPutInDanger084 = Flood.bPutInDanger; }
            if (tempNPC == NPC_085)
            { iAvailableMacGuffins085 = iTempMacGuffins; sAvailableWeapons085 = sTempWeapons; iLoyalty085 = iTempLoyalty; DesireToMove085 = iTempDesireToMove; bCorpse085 = bTempCorpse; NPC085_CurrentStrLocation = sTempCurrentLocation; NPC085_LastLocation = iTempLastLocation; NPC085_CurrentNumLocation = iTempLocation; NPC085_LastStrLocation = sTempLastLocation; Flood.bPutInDanger085 = Flood.bPutInDanger; }
            if (tempNPC == NPC_086)
            { iAvailableMacGuffins086 = iTempMacGuffins; sAvailableWeapons086 = sTempWeapons; iLoyalty086 = iTempLoyalty; DesireToMove086 = iTempDesireToMove; bCorpse086 = bTempCorpse; NPC086_CurrentStrLocation = sTempCurrentLocation; NPC086_LastLocation = iTempLastLocation; NPC086_CurrentNumLocation = iTempLocation; NPC086_LastStrLocation = sTempLastLocation; Flood.bPutInDanger086 = Flood.bPutInDanger; }
            if (tempNPC == NPC_087)
            { iAvailableMacGuffins087 = iTempMacGuffins; sAvailableWeapons087 = sTempWeapons; iLoyalty087 = iTempLoyalty; DesireToMove087 = iTempDesireToMove; bCorpse087 = bTempCorpse; NPC087_CurrentStrLocation = sTempCurrentLocation; NPC087_LastLocation = iTempLastLocation; NPC087_CurrentNumLocation = iTempLocation; NPC087_LastStrLocation = sTempLastLocation; Flood.bPutInDanger087 = Flood.bPutInDanger; }
            if (tempNPC == NPC_088)
            { iAvailableMacGuffins088 = iTempMacGuffins; sAvailableWeapons088 = sTempWeapons; iLoyalty088 = iTempLoyalty; DesireToMove088 = iTempDesireToMove; bCorpse088 = bTempCorpse; NPC088_CurrentStrLocation = sTempCurrentLocation; NPC088_LastLocation = iTempLastLocation; NPC088_CurrentNumLocation = iTempLocation; NPC088_LastStrLocation = sTempLastLocation; Flood.bPutInDanger088 = Flood.bPutInDanger; }
            if (tempNPC == NPC_089)
            { iAvailableMacGuffins089 = iTempMacGuffins; sAvailableWeapons089 = sTempWeapons; iLoyalty089 = iTempLoyalty; DesireToMove089 = iTempDesireToMove; bCorpse089 = bTempCorpse; NPC089_CurrentStrLocation = sTempCurrentLocation; NPC089_LastLocation = iTempLastLocation; NPC089_CurrentNumLocation = iTempLocation; NPC089_LastStrLocation = sTempLastLocation; Flood.bPutInDanger089 = Flood.bPutInDanger; }
            if (tempNPC == NPC_090)
            { iAvailableMacGuffins090 = iTempMacGuffins; sAvailableWeapons090 = sTempWeapons; iLoyalty090 = iTempLoyalty; DesireToMove090 = iTempDesireToMove; bCorpse090 = bTempCorpse; NPC090_CurrentStrLocation = sTempCurrentLocation; NPC090_LastLocation = iTempLastLocation; NPC090_CurrentNumLocation = iTempLocation; NPC090_LastStrLocation = sTempLastLocation; Flood.bPutInDanger090 = Flood.bPutInDanger; }
            if (tempNPC == NPC_091)
            { iAvailableMacGuffins091 = iTempMacGuffins; sAvailableWeapons091 = sTempWeapons; iLoyalty091 = iTempLoyalty; DesireToMove091 = iTempDesireToMove; bCorpse091 = bTempCorpse; NPC091_CurrentStrLocation = sTempCurrentLocation; NPC091_LastLocation = iTempLastLocation; NPC091_CurrentNumLocation = iTempLocation; NPC091_LastStrLocation = sTempLastLocation; Flood.bPutInDanger091 = Flood.bPutInDanger; }
            if (tempNPC == NPC_092)
            { iAvailableMacGuffins092 = iTempMacGuffins; sAvailableWeapons092 = sTempWeapons; iLoyalty092 = iTempLoyalty; DesireToMove092 = iTempDesireToMove; bCorpse092 = bTempCorpse; NPC092_CurrentStrLocation = sTempCurrentLocation; NPC092_LastLocation = iTempLastLocation; NPC092_CurrentNumLocation = iTempLocation; NPC092_LastStrLocation = sTempLastLocation; Flood.bPutInDanger092 = Flood.bPutInDanger; }
            if (tempNPC == NPC_093)
            { iAvailableMacGuffins093 = iTempMacGuffins; sAvailableWeapons093 = sTempWeapons; iLoyalty093 = iTempLoyalty; DesireToMove093 = iTempDesireToMove; bCorpse093 = bTempCorpse; NPC093_CurrentStrLocation = sTempCurrentLocation; NPC093_LastLocation = iTempLastLocation; NPC093_CurrentNumLocation = iTempLocation; NPC093_LastStrLocation = sTempLastLocation; Flood.bPutInDanger093 = Flood.bPutInDanger; }
            if (tempNPC == NPC_094)
            { iAvailableMacGuffins094 = iTempMacGuffins; sAvailableWeapons094 = sTempWeapons; iLoyalty094 = iTempLoyalty; DesireToMove094 = iTempDesireToMove; bCorpse094 = bTempCorpse; NPC094_CurrentStrLocation = sTempCurrentLocation; NPC094_LastLocation = iTempLastLocation; NPC094_CurrentNumLocation = iTempLocation; NPC094_LastStrLocation = sTempLastLocation; Flood.bPutInDanger094 = Flood.bPutInDanger; }
            if (tempNPC == NPC_095)
            { iAvailableMacGuffins095 = iTempMacGuffins; sAvailableWeapons095 = sTempWeapons; iLoyalty095 = iTempLoyalty; DesireToMove095 = iTempDesireToMove; bCorpse095 = bTempCorpse; NPC095_CurrentStrLocation = sTempCurrentLocation; NPC095_LastLocation = iTempLastLocation; NPC095_CurrentNumLocation = iTempLocation; NPC095_LastStrLocation = sTempLastLocation; Flood.bPutInDanger095 = Flood.bPutInDanger; }
            if (tempNPC == NPC_096)
            { iAvailableMacGuffins096 = iTempMacGuffins; sAvailableWeapons096 = sTempWeapons; iLoyalty096 = iTempLoyalty; DesireToMove096 = iTempDesireToMove; bCorpse096 = bTempCorpse; NPC096_CurrentStrLocation = sTempCurrentLocation; NPC096_LastLocation = iTempLastLocation; NPC096_CurrentNumLocation = iTempLocation; NPC096_LastStrLocation = sTempLastLocation; Flood.bPutInDanger096 = Flood.bPutInDanger; }
            if (tempNPC == NPC_097)
            { iAvailableMacGuffins097 = iTempMacGuffins; sAvailableWeapons097 = sTempWeapons; iLoyalty097 = iTempLoyalty; DesireToMove097 = iTempDesireToMove; bCorpse097 = bTempCorpse; NPC097_CurrentStrLocation = sTempCurrentLocation; NPC097_LastLocation = iTempLastLocation; NPC097_CurrentNumLocation = iTempLocation; NPC097_LastStrLocation = sTempLastLocation; Flood.bPutInDanger097 = Flood.bPutInDanger; }
            if (tempNPC == NPC_098)
            { iAvailableMacGuffins098 = iTempMacGuffins; sAvailableWeapons098 = sTempWeapons; iLoyalty098 = iTempLoyalty; DesireToMove098 = iTempDesireToMove; bCorpse098 = bTempCorpse; NPC098_CurrentStrLocation = sTempCurrentLocation; NPC098_LastLocation = iTempLastLocation; NPC098_CurrentNumLocation = iTempLocation; NPC098_LastStrLocation = sTempLastLocation; Flood.bPutInDanger098 = Flood.bPutInDanger; }
            if (tempNPC == NPC_099)
            { iAvailableMacGuffins099 = iTempMacGuffins; sAvailableWeapons099 = sTempWeapons; iLoyalty099 = iTempLoyalty; DesireToMove099 = iTempDesireToMove; bCorpse099 = bTempCorpse; NPC099_CurrentStrLocation = sTempCurrentLocation; NPC099_LastLocation = iTempLastLocation; NPC099_CurrentNumLocation = iTempLocation; NPC099_LastStrLocation = sTempLastLocation; Flood.bPutInDanger099 = Flood.bPutInDanger; }
            if (tempNPC == NPC_100)
            { iAvailableMacGuffins100 = iTempMacGuffins; sAvailableWeapons100 = sTempWeapons; iLoyalty100 = iTempLoyalty; DesireToMove100 = iTempDesireToMove; bCorpse100 = bTempCorpse; NPC100_CurrentStrLocation = sTempCurrentLocation; NPC100_LastLocation = iTempLastLocation; NPC100_CurrentNumLocation = iTempLocation; NPC100_LastStrLocation = sTempLastLocation; Flood.bPutInDanger100 = Flood.bPutInDanger; }
        }

        public static void GetNPCLocals_MyBestFriend()
        {
            // Reset the TEMP variables, just in case.
            RandomEncounters.bBestFriend_Corpse = false;
            RandomEncounters.iBestFriend_CurrentNumLocation = 0;
            RandomEncounters.iBestFriend_DesireToMove = 0;
            RandomEncounters.iBestFriend_Disposition = 0;
            RandomEncounters.iBestFriend_MacGuffins = 0;

            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_001) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins001; RandomEncounters.iBestFriend_CurrentNumLocation = NPC001_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty001; RandomEncounters.iBestFriend_DesireToMove = DesireToMove001; RandomEncounters.bBestFriend_Corpse = bCorpse001; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_002) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins002; RandomEncounters.iBestFriend_CurrentNumLocation = NPC002_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty002; RandomEncounters.iBestFriend_DesireToMove = DesireToMove002; RandomEncounters.bBestFriend_Corpse = bCorpse002; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_003) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins003; RandomEncounters.iBestFriend_CurrentNumLocation = NPC003_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty003; RandomEncounters.iBestFriend_DesireToMove = DesireToMove003; RandomEncounters.bBestFriend_Corpse = bCorpse003; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_004) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins004; RandomEncounters.iBestFriend_CurrentNumLocation = NPC004_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty004; RandomEncounters.iBestFriend_DesireToMove = DesireToMove004; RandomEncounters.bBestFriend_Corpse = bCorpse004; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_005) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins005; RandomEncounters.iBestFriend_CurrentNumLocation = NPC005_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty005; RandomEncounters.iBestFriend_DesireToMove = DesireToMove005; RandomEncounters.bBestFriend_Corpse = bCorpse005; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_006) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins006; RandomEncounters.iBestFriend_CurrentNumLocation = NPC006_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty006; RandomEncounters.iBestFriend_DesireToMove = DesireToMove006; RandomEncounters.bBestFriend_Corpse = bCorpse006; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_007) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins007; RandomEncounters.iBestFriend_CurrentNumLocation = NPC007_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty007; RandomEncounters.iBestFriend_DesireToMove = DesireToMove007; RandomEncounters.bBestFriend_Corpse = bCorpse007; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_008) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins008; RandomEncounters.iBestFriend_CurrentNumLocation = NPC008_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty008; RandomEncounters.iBestFriend_DesireToMove = DesireToMove008; RandomEncounters.bBestFriend_Corpse = bCorpse008; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_009) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins009; RandomEncounters.iBestFriend_CurrentNumLocation = NPC009_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty009; RandomEncounters.iBestFriend_DesireToMove = DesireToMove009; RandomEncounters.bBestFriend_Corpse = bCorpse009; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_010) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins010; RandomEncounters.iBestFriend_CurrentNumLocation = NPC010_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty020; RandomEncounters.iBestFriend_DesireToMove = DesireToMove010; RandomEncounters.bBestFriend_Corpse = bCorpse010; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_011) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins011; RandomEncounters.iBestFriend_CurrentNumLocation = NPC011_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty011; RandomEncounters.iBestFriend_DesireToMove = DesireToMove011; RandomEncounters.bBestFriend_Corpse = bCorpse011; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_012) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins012; RandomEncounters.iBestFriend_CurrentNumLocation = NPC012_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty012; RandomEncounters.iBestFriend_DesireToMove = DesireToMove012; RandomEncounters.bBestFriend_Corpse = bCorpse012; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_013) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins013; RandomEncounters.iBestFriend_CurrentNumLocation = NPC013_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty013; RandomEncounters.iBestFriend_DesireToMove = DesireToMove013; RandomEncounters.bBestFriend_Corpse = bCorpse013; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_014) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins014; RandomEncounters.iBestFriend_CurrentNumLocation = NPC014_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty014; RandomEncounters.iBestFriend_DesireToMove = DesireToMove014; RandomEncounters.bBestFriend_Corpse = bCorpse014; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_015) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins015; RandomEncounters.iBestFriend_CurrentNumLocation = NPC015_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty015; RandomEncounters.iBestFriend_DesireToMove = DesireToMove015; RandomEncounters.bBestFriend_Corpse = bCorpse015; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_016) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins016; RandomEncounters.iBestFriend_CurrentNumLocation = NPC016_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty016; RandomEncounters.iBestFriend_DesireToMove = DesireToMove016; RandomEncounters.bBestFriend_Corpse = bCorpse016; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_017) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins017; RandomEncounters.iBestFriend_CurrentNumLocation = NPC017_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty017; RandomEncounters.iBestFriend_DesireToMove = DesireToMove017; RandomEncounters.bBestFriend_Corpse = bCorpse017; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_018) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins018; RandomEncounters.iBestFriend_CurrentNumLocation = NPC018_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty018; RandomEncounters.iBestFriend_DesireToMove = DesireToMove018; RandomEncounters.bBestFriend_Corpse = bCorpse018; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_019) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins019; RandomEncounters.iBestFriend_CurrentNumLocation = NPC019_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty019; RandomEncounters.iBestFriend_DesireToMove = DesireToMove019; RandomEncounters.bBestFriend_Corpse = bCorpse019; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_020) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins020; RandomEncounters.iBestFriend_CurrentNumLocation = NPC020_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty020; RandomEncounters.iBestFriend_DesireToMove = DesireToMove020; RandomEncounters.bBestFriend_Corpse = bCorpse020; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_021) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins021; RandomEncounters.iBestFriend_CurrentNumLocation = NPC021_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty021; RandomEncounters.iBestFriend_DesireToMove = DesireToMove021; RandomEncounters.bBestFriend_Corpse = bCorpse021; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_022) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins022; RandomEncounters.iBestFriend_CurrentNumLocation = NPC022_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty022; RandomEncounters.iBestFriend_DesireToMove = DesireToMove022; RandomEncounters.bBestFriend_Corpse = bCorpse022; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_023) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins023; RandomEncounters.iBestFriend_CurrentNumLocation = NPC023_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty023; RandomEncounters.iBestFriend_DesireToMove = DesireToMove023; RandomEncounters.bBestFriend_Corpse = bCorpse023; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_024) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins024; RandomEncounters.iBestFriend_CurrentNumLocation = NPC024_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty024; RandomEncounters.iBestFriend_DesireToMove = DesireToMove024; RandomEncounters.bBestFriend_Corpse = bCorpse024; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_025) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins025; RandomEncounters.iBestFriend_CurrentNumLocation = NPC025_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty025; RandomEncounters.iBestFriend_DesireToMove = DesireToMove025; RandomEncounters.bBestFriend_Corpse = bCorpse025; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_026) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins026; RandomEncounters.iBestFriend_CurrentNumLocation = NPC026_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty026; RandomEncounters.iBestFriend_DesireToMove = DesireToMove026; RandomEncounters.bBestFriend_Corpse = bCorpse026; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_027) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins027; RandomEncounters.iBestFriend_CurrentNumLocation = NPC027_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty027; RandomEncounters.iBestFriend_DesireToMove = DesireToMove027; RandomEncounters.bBestFriend_Corpse = bCorpse027; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_028) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins028; RandomEncounters.iBestFriend_CurrentNumLocation = NPC028_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty028; RandomEncounters.iBestFriend_DesireToMove = DesireToMove028; RandomEncounters.bBestFriend_Corpse = bCorpse028; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_029) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins029; RandomEncounters.iBestFriend_CurrentNumLocation = NPC029_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty029; RandomEncounters.iBestFriend_DesireToMove = DesireToMove029; RandomEncounters.bBestFriend_Corpse = bCorpse029; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_030) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins030; RandomEncounters.iBestFriend_CurrentNumLocation = NPC030_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty030; RandomEncounters.iBestFriend_DesireToMove = DesireToMove030; RandomEncounters.bBestFriend_Corpse = bCorpse030; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_031) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins031; RandomEncounters.iBestFriend_CurrentNumLocation = NPC031_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty031; RandomEncounters.iBestFriend_DesireToMove = DesireToMove031; RandomEncounters.bBestFriend_Corpse = bCorpse031; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_032) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins032; RandomEncounters.iBestFriend_CurrentNumLocation = NPC032_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty032; RandomEncounters.iBestFriend_DesireToMove = DesireToMove032; RandomEncounters.bBestFriend_Corpse = bCorpse032; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_033) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins033; RandomEncounters.iBestFriend_CurrentNumLocation = NPC033_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty033; RandomEncounters.iBestFriend_DesireToMove = DesireToMove033; RandomEncounters.bBestFriend_Corpse = bCorpse033; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_034) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins034; RandomEncounters.iBestFriend_CurrentNumLocation = NPC034_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty034; RandomEncounters.iBestFriend_DesireToMove = DesireToMove034; RandomEncounters.bBestFriend_Corpse = bCorpse034; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_035) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins035; RandomEncounters.iBestFriend_CurrentNumLocation = NPC035_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty035; RandomEncounters.iBestFriend_DesireToMove = DesireToMove035; RandomEncounters.bBestFriend_Corpse = bCorpse035; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_036) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins036; RandomEncounters.iBestFriend_CurrentNumLocation = NPC036_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty036; RandomEncounters.iBestFriend_DesireToMove = DesireToMove036; RandomEncounters.bBestFriend_Corpse = bCorpse036; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_037) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins037; RandomEncounters.iBestFriend_CurrentNumLocation = NPC037_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty037; RandomEncounters.iBestFriend_DesireToMove = DesireToMove037; RandomEncounters.bBestFriend_Corpse = bCorpse037; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_038) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins038; RandomEncounters.iBestFriend_CurrentNumLocation = NPC038_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty038; RandomEncounters.iBestFriend_DesireToMove = DesireToMove038; RandomEncounters.bBestFriend_Corpse = bCorpse038; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_039) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins039; RandomEncounters.iBestFriend_CurrentNumLocation = NPC039_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty039; RandomEncounters.iBestFriend_DesireToMove = DesireToMove039; RandomEncounters.bBestFriend_Corpse = bCorpse039; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_040) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins040; RandomEncounters.iBestFriend_CurrentNumLocation = NPC040_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty040; RandomEncounters.iBestFriend_DesireToMove = DesireToMove040; RandomEncounters.bBestFriend_Corpse = bCorpse040; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_041) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins041; RandomEncounters.iBestFriend_CurrentNumLocation = NPC041_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty041; RandomEncounters.iBestFriend_DesireToMove = DesireToMove041; RandomEncounters.bBestFriend_Corpse = bCorpse041; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_042) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins042; RandomEncounters.iBestFriend_CurrentNumLocation = NPC042_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty042; RandomEncounters.iBestFriend_DesireToMove = DesireToMove042; RandomEncounters.bBestFriend_Corpse = bCorpse042; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_043) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins043; RandomEncounters.iBestFriend_CurrentNumLocation = NPC043_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty043; RandomEncounters.iBestFriend_DesireToMove = DesireToMove043; RandomEncounters.bBestFriend_Corpse = bCorpse043; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_044) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins044; RandomEncounters.iBestFriend_CurrentNumLocation = NPC044_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty044; RandomEncounters.iBestFriend_DesireToMove = DesireToMove044; RandomEncounters.bBestFriend_Corpse = bCorpse044; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_045) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins045; RandomEncounters.iBestFriend_CurrentNumLocation = NPC045_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty045; RandomEncounters.iBestFriend_DesireToMove = DesireToMove045; RandomEncounters.bBestFriend_Corpse = bCorpse045; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_046) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins046; RandomEncounters.iBestFriend_CurrentNumLocation = NPC046_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty046; RandomEncounters.iBestFriend_DesireToMove = DesireToMove046; RandomEncounters.bBestFriend_Corpse = bCorpse046; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_047) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins047; RandomEncounters.iBestFriend_CurrentNumLocation = NPC047_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty047; RandomEncounters.iBestFriend_DesireToMove = DesireToMove047; RandomEncounters.bBestFriend_Corpse = bCorpse047; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_048) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins048; RandomEncounters.iBestFriend_CurrentNumLocation = NPC048_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty048; RandomEncounters.iBestFriend_DesireToMove = DesireToMove048; RandomEncounters.bBestFriend_Corpse = bCorpse048; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_049) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins049; RandomEncounters.iBestFriend_CurrentNumLocation = NPC049_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty049; RandomEncounters.iBestFriend_DesireToMove = DesireToMove049; RandomEncounters.bBestFriend_Corpse = bCorpse049; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_050) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins050; RandomEncounters.iBestFriend_CurrentNumLocation = NPC050_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty050; RandomEncounters.iBestFriend_DesireToMove = DesireToMove050; RandomEncounters.bBestFriend_Corpse = bCorpse050; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_051) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins051; RandomEncounters.iBestFriend_CurrentNumLocation = NPC051_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty051; RandomEncounters.iBestFriend_DesireToMove = DesireToMove051; RandomEncounters.bBestFriend_Corpse = bCorpse051; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_052) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins052; RandomEncounters.iBestFriend_CurrentNumLocation = NPC052_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty052; RandomEncounters.iBestFriend_DesireToMove = DesireToMove052; RandomEncounters.bBestFriend_Corpse = bCorpse052; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_053) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins053; RandomEncounters.iBestFriend_CurrentNumLocation = NPC053_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty053; RandomEncounters.iBestFriend_DesireToMove = DesireToMove053; RandomEncounters.bBestFriend_Corpse = bCorpse053; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_054) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins054; RandomEncounters.iBestFriend_CurrentNumLocation = NPC054_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty054; RandomEncounters.iBestFriend_DesireToMove = DesireToMove054; RandomEncounters.bBestFriend_Corpse = bCorpse054; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_055) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins055; RandomEncounters.iBestFriend_CurrentNumLocation = NPC055_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty055; RandomEncounters.iBestFriend_DesireToMove = DesireToMove055; RandomEncounters.bBestFriend_Corpse = bCorpse055; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_056) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins056; RandomEncounters.iBestFriend_CurrentNumLocation = NPC056_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty056; RandomEncounters.iBestFriend_DesireToMove = DesireToMove056; RandomEncounters.bBestFriend_Corpse = bCorpse056; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_057) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins057; RandomEncounters.iBestFriend_CurrentNumLocation = NPC057_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty057; RandomEncounters.iBestFriend_DesireToMove = DesireToMove057; RandomEncounters.bBestFriend_Corpse = bCorpse057; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_058) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins058; RandomEncounters.iBestFriend_CurrentNumLocation = NPC058_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty058; RandomEncounters.iBestFriend_DesireToMove = DesireToMove058; RandomEncounters.bBestFriend_Corpse = bCorpse058; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_059) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins059; RandomEncounters.iBestFriend_CurrentNumLocation = NPC059_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty059; RandomEncounters.iBestFriend_DesireToMove = DesireToMove059; RandomEncounters.bBestFriend_Corpse = bCorpse059; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_060) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins060; RandomEncounters.iBestFriend_CurrentNumLocation = NPC060_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty060; RandomEncounters.iBestFriend_DesireToMove = DesireToMove060; RandomEncounters.bBestFriend_Corpse = bCorpse060; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_061) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins061; RandomEncounters.iBestFriend_CurrentNumLocation = NPC061_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty061; RandomEncounters.iBestFriend_DesireToMove = DesireToMove061; RandomEncounters.bBestFriend_Corpse = bCorpse061; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_062) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins062; RandomEncounters.iBestFriend_CurrentNumLocation = NPC062_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty062; RandomEncounters.iBestFriend_DesireToMove = DesireToMove062; RandomEncounters.bBestFriend_Corpse = bCorpse062; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_063) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins063; RandomEncounters.iBestFriend_CurrentNumLocation = NPC063_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty063; RandomEncounters.iBestFriend_DesireToMove = DesireToMove063; RandomEncounters.bBestFriend_Corpse = bCorpse063; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_064) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins064; RandomEncounters.iBestFriend_CurrentNumLocation = NPC064_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty064; RandomEncounters.iBestFriend_DesireToMove = DesireToMove064; RandomEncounters.bBestFriend_Corpse = bCorpse064; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_065) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins065; RandomEncounters.iBestFriend_CurrentNumLocation = NPC065_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty065; RandomEncounters.iBestFriend_DesireToMove = DesireToMove065; RandomEncounters.bBestFriend_Corpse = bCorpse065; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_066) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins066; RandomEncounters.iBestFriend_CurrentNumLocation = NPC066_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty066; RandomEncounters.iBestFriend_DesireToMove = DesireToMove066; RandomEncounters.bBestFriend_Corpse = bCorpse066; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_067) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins067; RandomEncounters.iBestFriend_CurrentNumLocation = NPC067_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty067; RandomEncounters.iBestFriend_DesireToMove = DesireToMove067; RandomEncounters.bBestFriend_Corpse = bCorpse067; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_068) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins068; RandomEncounters.iBestFriend_CurrentNumLocation = NPC068_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty068; RandomEncounters.iBestFriend_DesireToMove = DesireToMove068; RandomEncounters.bBestFriend_Corpse = bCorpse068; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_069) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins069; RandomEncounters.iBestFriend_CurrentNumLocation = NPC069_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty069; RandomEncounters.iBestFriend_DesireToMove = DesireToMove069; RandomEncounters.bBestFriend_Corpse = bCorpse069; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_070) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins070; RandomEncounters.iBestFriend_CurrentNumLocation = NPC070_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty070; RandomEncounters.iBestFriend_DesireToMove = DesireToMove070; RandomEncounters.bBestFriend_Corpse = bCorpse070; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_071) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins071; RandomEncounters.iBestFriend_CurrentNumLocation = NPC071_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty071; RandomEncounters.iBestFriend_DesireToMove = DesireToMove071; RandomEncounters.bBestFriend_Corpse = bCorpse071; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_072) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins072; RandomEncounters.iBestFriend_CurrentNumLocation = NPC072_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty072; RandomEncounters.iBestFriend_DesireToMove = DesireToMove072; RandomEncounters.bBestFriend_Corpse = bCorpse072; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_073) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins073; RandomEncounters.iBestFriend_CurrentNumLocation = NPC073_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty073; RandomEncounters.iBestFriend_DesireToMove = DesireToMove073; RandomEncounters.bBestFriend_Corpse = bCorpse073; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_074) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins074; RandomEncounters.iBestFriend_CurrentNumLocation = NPC074_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty074; RandomEncounters.iBestFriend_DesireToMove = DesireToMove074; RandomEncounters.bBestFriend_Corpse = bCorpse074; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_075) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins075; RandomEncounters.iBestFriend_CurrentNumLocation = NPC075_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty075; RandomEncounters.iBestFriend_DesireToMove = DesireToMove075; RandomEncounters.bBestFriend_Corpse = bCorpse075; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_076) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins076; RandomEncounters.iBestFriend_CurrentNumLocation = NPC076_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty076; RandomEncounters.iBestFriend_DesireToMove = DesireToMove076; RandomEncounters.bBestFriend_Corpse = bCorpse076; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_077) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins077; RandomEncounters.iBestFriend_CurrentNumLocation = NPC077_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty077; RandomEncounters.iBestFriend_DesireToMove = DesireToMove077; RandomEncounters.bBestFriend_Corpse = bCorpse077; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_078) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins078; RandomEncounters.iBestFriend_CurrentNumLocation = NPC078_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty078; RandomEncounters.iBestFriend_DesireToMove = DesireToMove078; RandomEncounters.bBestFriend_Corpse = bCorpse078; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_079) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins079; RandomEncounters.iBestFriend_CurrentNumLocation = NPC079_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty079; RandomEncounters.iBestFriend_DesireToMove = DesireToMove079; RandomEncounters.bBestFriend_Corpse = bCorpse079; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_080) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins080; RandomEncounters.iBestFriend_CurrentNumLocation = NPC080_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty080; RandomEncounters.iBestFriend_DesireToMove = DesireToMove080; RandomEncounters.bBestFriend_Corpse = bCorpse080; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_081) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins081; RandomEncounters.iBestFriend_CurrentNumLocation = NPC081_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty081; RandomEncounters.iBestFriend_DesireToMove = DesireToMove081; RandomEncounters.bBestFriend_Corpse = bCorpse081; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_082) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins082; RandomEncounters.iBestFriend_CurrentNumLocation = NPC082_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty082; RandomEncounters.iBestFriend_DesireToMove = DesireToMove082; RandomEncounters.bBestFriend_Corpse = bCorpse082; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_083) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins083; RandomEncounters.iBestFriend_CurrentNumLocation = NPC083_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty083; RandomEncounters.iBestFriend_DesireToMove = DesireToMove083; RandomEncounters.bBestFriend_Corpse = bCorpse083; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_084) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins084; RandomEncounters.iBestFriend_CurrentNumLocation = NPC084_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty084; RandomEncounters.iBestFriend_DesireToMove = DesireToMove084; RandomEncounters.bBestFriend_Corpse = bCorpse084; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_085) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins085; RandomEncounters.iBestFriend_CurrentNumLocation = NPC085_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty085; RandomEncounters.iBestFriend_DesireToMove = DesireToMove085; RandomEncounters.bBestFriend_Corpse = bCorpse085; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_086) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins086; RandomEncounters.iBestFriend_CurrentNumLocation = NPC086_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty086; RandomEncounters.iBestFriend_DesireToMove = DesireToMove086; RandomEncounters.bBestFriend_Corpse = bCorpse086; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_087) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins087; RandomEncounters.iBestFriend_CurrentNumLocation = NPC087_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty087; RandomEncounters.iBestFriend_DesireToMove = DesireToMove087; RandomEncounters.bBestFriend_Corpse = bCorpse087; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_088) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins088; RandomEncounters.iBestFriend_CurrentNumLocation = NPC088_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty088; RandomEncounters.iBestFriend_DesireToMove = DesireToMove088; RandomEncounters.bBestFriend_Corpse = bCorpse088; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_089) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins089; RandomEncounters.iBestFriend_CurrentNumLocation = NPC089_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty089; RandomEncounters.iBestFriend_DesireToMove = DesireToMove089; RandomEncounters.bBestFriend_Corpse = bCorpse089; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_090) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins090; RandomEncounters.iBestFriend_CurrentNumLocation = NPC090_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty090; RandomEncounters.iBestFriend_DesireToMove = DesireToMove090; RandomEncounters.bBestFriend_Corpse = bCorpse090; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_091) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins091; RandomEncounters.iBestFriend_CurrentNumLocation = NPC091_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty091; RandomEncounters.iBestFriend_DesireToMove = DesireToMove091; RandomEncounters.bBestFriend_Corpse = bCorpse091; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_092) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins092; RandomEncounters.iBestFriend_CurrentNumLocation = NPC092_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty092; RandomEncounters.iBestFriend_DesireToMove = DesireToMove092; RandomEncounters.bBestFriend_Corpse = bCorpse092; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_093) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins093; RandomEncounters.iBestFriend_CurrentNumLocation = NPC093_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty093; RandomEncounters.iBestFriend_DesireToMove = DesireToMove093; RandomEncounters.bBestFriend_Corpse = bCorpse093; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_094) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins094; RandomEncounters.iBestFriend_CurrentNumLocation = NPC094_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty094; RandomEncounters.iBestFriend_DesireToMove = DesireToMove094; RandomEncounters.bBestFriend_Corpse = bCorpse094; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_095) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins095; RandomEncounters.iBestFriend_CurrentNumLocation = NPC095_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty095; RandomEncounters.iBestFriend_DesireToMove = DesireToMove095; RandomEncounters.bBestFriend_Corpse = bCorpse095; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_096) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins096; RandomEncounters.iBestFriend_CurrentNumLocation = NPC096_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty096; RandomEncounters.iBestFriend_DesireToMove = DesireToMove096; RandomEncounters.bBestFriend_Corpse = bCorpse096; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_097) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins097; RandomEncounters.iBestFriend_CurrentNumLocation = NPC097_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty097; RandomEncounters.iBestFriend_DesireToMove = DesireToMove097; RandomEncounters.bBestFriend_Corpse = bCorpse097; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_098) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins098; RandomEncounters.iBestFriend_CurrentNumLocation = NPC098_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty098; RandomEncounters.iBestFriend_DesireToMove = DesireToMove098; RandomEncounters.bBestFriend_Corpse = bCorpse098; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_099) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins099; RandomEncounters.iBestFriend_CurrentNumLocation = NPC099_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty099; RandomEncounters.iBestFriend_DesireToMove = DesireToMove099; RandomEncounters.bBestFriend_Corpse = bCorpse099; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_100) { RandomEncounters.iBestFriend_MacGuffins = iAvailableMacGuffins100; RandomEncounters.iBestFriend_CurrentNumLocation = NPC100_CurrentNumLocation; RandomEncounters.iBestFriend_Disposition = iLoyalty100; RandomEncounters.iBestFriend_DesireToMove = DesireToMove100; RandomEncounters.bBestFriend_Corpse = bCorpse100; }
        }
        
        public static void SetNPCLocals_MyBestFriend()
        {
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_001) { iAvailableMacGuffins001 = RandomEncounters.iBestFriend_MacGuffins; NPC001_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty001 = RandomEncounters.iBestFriend_Disposition; DesireToMove001 = RandomEncounters.iBestFriend_DesireToMove; bCorpse001 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_002) { iAvailableMacGuffins002 = RandomEncounters.iBestFriend_MacGuffins; NPC002_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty002 = RandomEncounters.iBestFriend_Disposition; DesireToMove002 = RandomEncounters.iBestFriend_DesireToMove; bCorpse002 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_003) { iAvailableMacGuffins003 = RandomEncounters.iBestFriend_MacGuffins; NPC003_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty003 = RandomEncounters.iBestFriend_Disposition; DesireToMove003 = RandomEncounters.iBestFriend_DesireToMove; bCorpse003 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_004) { iAvailableMacGuffins004 = RandomEncounters.iBestFriend_MacGuffins; NPC004_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty004 = RandomEncounters.iBestFriend_Disposition; DesireToMove004 = RandomEncounters.iBestFriend_DesireToMove; bCorpse004 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_005) { iAvailableMacGuffins005 = RandomEncounters.iBestFriend_MacGuffins; NPC005_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty005 = RandomEncounters.iBestFriend_Disposition; DesireToMove005 = RandomEncounters.iBestFriend_DesireToMove; bCorpse005 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_006) { iAvailableMacGuffins006 = RandomEncounters.iBestFriend_MacGuffins; NPC006_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty006 = RandomEncounters.iBestFriend_Disposition; DesireToMove006 = RandomEncounters.iBestFriend_DesireToMove; bCorpse006 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_007) { iAvailableMacGuffins007 = RandomEncounters.iBestFriend_MacGuffins; NPC007_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty007 = RandomEncounters.iBestFriend_Disposition; DesireToMove007 = RandomEncounters.iBestFriend_DesireToMove; bCorpse007 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_008) { iAvailableMacGuffins008 = RandomEncounters.iBestFriend_MacGuffins; NPC008_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty008 = RandomEncounters.iBestFriend_Disposition; DesireToMove008 = RandomEncounters.iBestFriend_DesireToMove; bCorpse008 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_009) { iAvailableMacGuffins009 = RandomEncounters.iBestFriend_MacGuffins; NPC009_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty009 = RandomEncounters.iBestFriend_Disposition; DesireToMove009 = RandomEncounters.iBestFriend_DesireToMove; bCorpse009 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_010) { iAvailableMacGuffins010 = RandomEncounters.iBestFriend_MacGuffins; NPC010_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty020 = RandomEncounters.iBestFriend_Disposition; DesireToMove010 = RandomEncounters.iBestFriend_DesireToMove; bCorpse010 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_011) { iAvailableMacGuffins011 = RandomEncounters.iBestFriend_MacGuffins; NPC011_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty011 = RandomEncounters.iBestFriend_Disposition; DesireToMove011 = RandomEncounters.iBestFriend_DesireToMove; bCorpse011 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_012) { iAvailableMacGuffins012 = RandomEncounters.iBestFriend_MacGuffins; NPC012_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty012 = RandomEncounters.iBestFriend_Disposition; DesireToMove012 = RandomEncounters.iBestFriend_DesireToMove; bCorpse012 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_013) { iAvailableMacGuffins013 = RandomEncounters.iBestFriend_MacGuffins; NPC013_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty013 = RandomEncounters.iBestFriend_Disposition; DesireToMove013 = RandomEncounters.iBestFriend_DesireToMove; bCorpse013 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_014) { iAvailableMacGuffins014 = RandomEncounters.iBestFriend_MacGuffins; NPC014_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty014 = RandomEncounters.iBestFriend_Disposition; DesireToMove014 = RandomEncounters.iBestFriend_DesireToMove; bCorpse014 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_015) { iAvailableMacGuffins015 = RandomEncounters.iBestFriend_MacGuffins; NPC015_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty015 = RandomEncounters.iBestFriend_Disposition; DesireToMove015 = RandomEncounters.iBestFriend_DesireToMove; bCorpse015 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_016) { iAvailableMacGuffins016 = RandomEncounters.iBestFriend_MacGuffins; NPC016_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty016 = RandomEncounters.iBestFriend_Disposition; DesireToMove016 = RandomEncounters.iBestFriend_DesireToMove; bCorpse016 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_017) { iAvailableMacGuffins017 = RandomEncounters.iBestFriend_MacGuffins; NPC017_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty017 = RandomEncounters.iBestFriend_Disposition; DesireToMove017 = RandomEncounters.iBestFriend_DesireToMove; bCorpse017 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_018) { iAvailableMacGuffins018 = RandomEncounters.iBestFriend_MacGuffins; NPC018_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty018 = RandomEncounters.iBestFriend_Disposition; DesireToMove018 = RandomEncounters.iBestFriend_DesireToMove; bCorpse018 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_019) { iAvailableMacGuffins019 = RandomEncounters.iBestFriend_MacGuffins; NPC019_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty019 = RandomEncounters.iBestFriend_Disposition; DesireToMove019 = RandomEncounters.iBestFriend_DesireToMove; bCorpse019 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_020) { iAvailableMacGuffins020 = RandomEncounters.iBestFriend_MacGuffins; NPC020_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty020 = RandomEncounters.iBestFriend_Disposition; DesireToMove020 = RandomEncounters.iBestFriend_DesireToMove; bCorpse020 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_021) { iAvailableMacGuffins021 = RandomEncounters.iBestFriend_MacGuffins; NPC021_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty021 = RandomEncounters.iBestFriend_Disposition; DesireToMove021 = RandomEncounters.iBestFriend_DesireToMove; bCorpse021 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_022) { iAvailableMacGuffins022 = RandomEncounters.iBestFriend_MacGuffins; NPC022_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty022 = RandomEncounters.iBestFriend_Disposition; DesireToMove022 = RandomEncounters.iBestFriend_DesireToMove; bCorpse022 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_023) { iAvailableMacGuffins023 = RandomEncounters.iBestFriend_MacGuffins; NPC023_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty023 = RandomEncounters.iBestFriend_Disposition; DesireToMove023 = RandomEncounters.iBestFriend_DesireToMove; bCorpse023 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_024) { iAvailableMacGuffins024 = RandomEncounters.iBestFriend_MacGuffins; NPC024_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty024 = RandomEncounters.iBestFriend_Disposition; DesireToMove024 = RandomEncounters.iBestFriend_DesireToMove; bCorpse024 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_025) { iAvailableMacGuffins025 = RandomEncounters.iBestFriend_MacGuffins; NPC025_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty025 = RandomEncounters.iBestFriend_Disposition; DesireToMove025 = RandomEncounters.iBestFriend_DesireToMove; bCorpse025 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_026) { iAvailableMacGuffins026 = RandomEncounters.iBestFriend_MacGuffins; NPC026_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty026 = RandomEncounters.iBestFriend_Disposition; DesireToMove026 = RandomEncounters.iBestFriend_DesireToMove; bCorpse026 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_027) { iAvailableMacGuffins027 = RandomEncounters.iBestFriend_MacGuffins; NPC027_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty027 = RandomEncounters.iBestFriend_Disposition; DesireToMove027 = RandomEncounters.iBestFriend_DesireToMove; bCorpse027 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_028) { iAvailableMacGuffins028 = RandomEncounters.iBestFriend_MacGuffins; NPC028_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty028 = RandomEncounters.iBestFriend_Disposition; DesireToMove028 = RandomEncounters.iBestFriend_DesireToMove; bCorpse028 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_029) { iAvailableMacGuffins029 = RandomEncounters.iBestFriend_MacGuffins; NPC029_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty029 = RandomEncounters.iBestFriend_Disposition; DesireToMove029 = RandomEncounters.iBestFriend_DesireToMove; bCorpse029 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_030) { iAvailableMacGuffins030 = RandomEncounters.iBestFriend_MacGuffins; NPC030_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty030 = RandomEncounters.iBestFriend_Disposition; DesireToMove030 = RandomEncounters.iBestFriend_DesireToMove; bCorpse030 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_031) { iAvailableMacGuffins031 = RandomEncounters.iBestFriend_MacGuffins; NPC031_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty031 = RandomEncounters.iBestFriend_Disposition; DesireToMove031 = RandomEncounters.iBestFriend_DesireToMove; bCorpse031 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_032) { iAvailableMacGuffins032 = RandomEncounters.iBestFriend_MacGuffins; NPC032_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty032 = RandomEncounters.iBestFriend_Disposition; DesireToMove032 = RandomEncounters.iBestFriend_DesireToMove; bCorpse032 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_033) { iAvailableMacGuffins033 = RandomEncounters.iBestFriend_MacGuffins; NPC033_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty033 = RandomEncounters.iBestFriend_Disposition; DesireToMove033 = RandomEncounters.iBestFriend_DesireToMove; bCorpse033 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_034) { iAvailableMacGuffins034 = RandomEncounters.iBestFriend_MacGuffins; NPC034_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty034 = RandomEncounters.iBestFriend_Disposition; DesireToMove034 = RandomEncounters.iBestFriend_DesireToMove; bCorpse034 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_035) { iAvailableMacGuffins035 = RandomEncounters.iBestFriend_MacGuffins; NPC035_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty035 = RandomEncounters.iBestFriend_Disposition; DesireToMove035 = RandomEncounters.iBestFriend_DesireToMove; bCorpse035 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_036) { iAvailableMacGuffins036 = RandomEncounters.iBestFriend_MacGuffins; NPC036_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty036 = RandomEncounters.iBestFriend_Disposition; DesireToMove036 = RandomEncounters.iBestFriend_DesireToMove; bCorpse036 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_037) { iAvailableMacGuffins037 = RandomEncounters.iBestFriend_MacGuffins; NPC037_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty037 = RandomEncounters.iBestFriend_Disposition; DesireToMove037 = RandomEncounters.iBestFriend_DesireToMove; bCorpse037 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_038) { iAvailableMacGuffins038 = RandomEncounters.iBestFriend_MacGuffins; NPC038_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty038 = RandomEncounters.iBestFriend_Disposition; DesireToMove038 = RandomEncounters.iBestFriend_DesireToMove; bCorpse038 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_039) { iAvailableMacGuffins039 = RandomEncounters.iBestFriend_MacGuffins; NPC039_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty039 = RandomEncounters.iBestFriend_Disposition; DesireToMove039 = RandomEncounters.iBestFriend_DesireToMove; bCorpse039 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_040) { iAvailableMacGuffins040 = RandomEncounters.iBestFriend_MacGuffins; NPC040_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty040 = RandomEncounters.iBestFriend_Disposition; DesireToMove040 = RandomEncounters.iBestFriend_DesireToMove; bCorpse040 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_041) { iAvailableMacGuffins041 = RandomEncounters.iBestFriend_MacGuffins; NPC041_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty041 = RandomEncounters.iBestFriend_Disposition; DesireToMove041 = RandomEncounters.iBestFriend_DesireToMove; bCorpse041 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_042) { iAvailableMacGuffins042 = RandomEncounters.iBestFriend_MacGuffins; NPC042_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty042 = RandomEncounters.iBestFriend_Disposition; DesireToMove042 = RandomEncounters.iBestFriend_DesireToMove; bCorpse042 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_043) { iAvailableMacGuffins043 = RandomEncounters.iBestFriend_MacGuffins; NPC043_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty043 = RandomEncounters.iBestFriend_Disposition; DesireToMove043 = RandomEncounters.iBestFriend_DesireToMove; bCorpse043 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_044) { iAvailableMacGuffins044 = RandomEncounters.iBestFriend_MacGuffins; NPC044_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty044 = RandomEncounters.iBestFriend_Disposition; DesireToMove044 = RandomEncounters.iBestFriend_DesireToMove; bCorpse044 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_045) { iAvailableMacGuffins045 = RandomEncounters.iBestFriend_MacGuffins; NPC045_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty045 = RandomEncounters.iBestFriend_Disposition; DesireToMove045 = RandomEncounters.iBestFriend_DesireToMove; bCorpse045 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_046) { iAvailableMacGuffins046 = RandomEncounters.iBestFriend_MacGuffins; NPC046_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty046 = RandomEncounters.iBestFriend_Disposition; DesireToMove046 = RandomEncounters.iBestFriend_DesireToMove; bCorpse046 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_047) { iAvailableMacGuffins047 = RandomEncounters.iBestFriend_MacGuffins; NPC047_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty047 = RandomEncounters.iBestFriend_Disposition; DesireToMove047 = RandomEncounters.iBestFriend_DesireToMove; bCorpse047 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_048) { iAvailableMacGuffins048 = RandomEncounters.iBestFriend_MacGuffins; NPC048_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty048 = RandomEncounters.iBestFriend_Disposition; DesireToMove048 = RandomEncounters.iBestFriend_DesireToMove; bCorpse048 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_049) { iAvailableMacGuffins049 = RandomEncounters.iBestFriend_MacGuffins; NPC049_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty049 = RandomEncounters.iBestFriend_Disposition; DesireToMove049 = RandomEncounters.iBestFriend_DesireToMove; bCorpse049 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_050) { iAvailableMacGuffins050 = RandomEncounters.iBestFriend_MacGuffins; NPC050_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty050 = RandomEncounters.iBestFriend_Disposition; DesireToMove050 = RandomEncounters.iBestFriend_DesireToMove; bCorpse050 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_051) { iAvailableMacGuffins051 = RandomEncounters.iBestFriend_MacGuffins; NPC051_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty051 = RandomEncounters.iBestFriend_Disposition; DesireToMove051 = RandomEncounters.iBestFriend_DesireToMove; bCorpse051 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_052) { iAvailableMacGuffins052 = RandomEncounters.iBestFriend_MacGuffins; NPC052_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty052 = RandomEncounters.iBestFriend_Disposition; DesireToMove052 = RandomEncounters.iBestFriend_DesireToMove; bCorpse052 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_053) { iAvailableMacGuffins053 = RandomEncounters.iBestFriend_MacGuffins; NPC053_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty053 = RandomEncounters.iBestFriend_Disposition; DesireToMove053 = RandomEncounters.iBestFriend_DesireToMove; bCorpse053 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_054) { iAvailableMacGuffins054 = RandomEncounters.iBestFriend_MacGuffins; NPC054_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty054 = RandomEncounters.iBestFriend_Disposition; DesireToMove054 = RandomEncounters.iBestFriend_DesireToMove; bCorpse054 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_055) { iAvailableMacGuffins055 = RandomEncounters.iBestFriend_MacGuffins; NPC055_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty055 = RandomEncounters.iBestFriend_Disposition; DesireToMove055 = RandomEncounters.iBestFriend_DesireToMove; bCorpse055 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_056) { iAvailableMacGuffins056 = RandomEncounters.iBestFriend_MacGuffins; NPC056_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty056 = RandomEncounters.iBestFriend_Disposition; DesireToMove056 = RandomEncounters.iBestFriend_DesireToMove; bCorpse056 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_057) { iAvailableMacGuffins057 = RandomEncounters.iBestFriend_MacGuffins; NPC057_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty057 = RandomEncounters.iBestFriend_Disposition; DesireToMove057 = RandomEncounters.iBestFriend_DesireToMove; bCorpse057 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_058) { iAvailableMacGuffins058 = RandomEncounters.iBestFriend_MacGuffins; NPC058_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty058 = RandomEncounters.iBestFriend_Disposition; DesireToMove058 = RandomEncounters.iBestFriend_DesireToMove; bCorpse058 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_059) { iAvailableMacGuffins059 = RandomEncounters.iBestFriend_MacGuffins; NPC059_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty059 = RandomEncounters.iBestFriend_Disposition; DesireToMove059 = RandomEncounters.iBestFriend_DesireToMove; bCorpse059 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_060) { iAvailableMacGuffins060 = RandomEncounters.iBestFriend_MacGuffins; NPC060_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty060 = RandomEncounters.iBestFriend_Disposition; DesireToMove060 = RandomEncounters.iBestFriend_DesireToMove; bCorpse060 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_061) { iAvailableMacGuffins061 = RandomEncounters.iBestFriend_MacGuffins; NPC061_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty061 = RandomEncounters.iBestFriend_Disposition; DesireToMove061 = RandomEncounters.iBestFriend_DesireToMove; bCorpse061 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_062) { iAvailableMacGuffins062 = RandomEncounters.iBestFriend_MacGuffins; NPC062_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty062 = RandomEncounters.iBestFriend_Disposition; DesireToMove062 = RandomEncounters.iBestFriend_DesireToMove; bCorpse062 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_063) { iAvailableMacGuffins063 = RandomEncounters.iBestFriend_MacGuffins; NPC063_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty063 = RandomEncounters.iBestFriend_Disposition; DesireToMove063 = RandomEncounters.iBestFriend_DesireToMove; bCorpse063 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_064) { iAvailableMacGuffins064 = RandomEncounters.iBestFriend_MacGuffins; NPC064_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty064 = RandomEncounters.iBestFriend_Disposition; DesireToMove064 = RandomEncounters.iBestFriend_DesireToMove; bCorpse064 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_065) { iAvailableMacGuffins065 = RandomEncounters.iBestFriend_MacGuffins; NPC065_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty065 = RandomEncounters.iBestFriend_Disposition; DesireToMove065 = RandomEncounters.iBestFriend_DesireToMove; bCorpse065 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_066) { iAvailableMacGuffins066 = RandomEncounters.iBestFriend_MacGuffins; NPC066_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty066 = RandomEncounters.iBestFriend_Disposition; DesireToMove066 = RandomEncounters.iBestFriend_DesireToMove; bCorpse066 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_067) { iAvailableMacGuffins067 = RandomEncounters.iBestFriend_MacGuffins; NPC067_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty067 = RandomEncounters.iBestFriend_Disposition; DesireToMove067 = RandomEncounters.iBestFriend_DesireToMove; bCorpse067 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_068) { iAvailableMacGuffins068 = RandomEncounters.iBestFriend_MacGuffins; NPC068_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty068 = RandomEncounters.iBestFriend_Disposition; DesireToMove068 = RandomEncounters.iBestFriend_DesireToMove; bCorpse068 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_069) { iAvailableMacGuffins069 = RandomEncounters.iBestFriend_MacGuffins; NPC069_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty069 = RandomEncounters.iBestFriend_Disposition; DesireToMove069 = RandomEncounters.iBestFriend_DesireToMove; bCorpse069 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_070) { iAvailableMacGuffins070 = RandomEncounters.iBestFriend_MacGuffins; NPC070_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty070 = RandomEncounters.iBestFriend_Disposition; DesireToMove070 = RandomEncounters.iBestFriend_DesireToMove; bCorpse070 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_071) { iAvailableMacGuffins071 = RandomEncounters.iBestFriend_MacGuffins; NPC071_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty071 = RandomEncounters.iBestFriend_Disposition; DesireToMove071 = RandomEncounters.iBestFriend_DesireToMove; bCorpse071 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_072) { iAvailableMacGuffins072 = RandomEncounters.iBestFriend_MacGuffins; NPC072_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty072 = RandomEncounters.iBestFriend_Disposition; DesireToMove072 = RandomEncounters.iBestFriend_DesireToMove; bCorpse072 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_073) { iAvailableMacGuffins073 = RandomEncounters.iBestFriend_MacGuffins; NPC073_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty073 = RandomEncounters.iBestFriend_Disposition; DesireToMove073 = RandomEncounters.iBestFriend_DesireToMove; bCorpse073 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_074) { iAvailableMacGuffins074 = RandomEncounters.iBestFriend_MacGuffins; NPC074_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty074 = RandomEncounters.iBestFriend_Disposition; DesireToMove074 = RandomEncounters.iBestFriend_DesireToMove; bCorpse074 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_075) { iAvailableMacGuffins075 = RandomEncounters.iBestFriend_MacGuffins; NPC075_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty075 = RandomEncounters.iBestFriend_Disposition; DesireToMove075 = RandomEncounters.iBestFriend_DesireToMove; bCorpse075 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_076) { iAvailableMacGuffins076 = RandomEncounters.iBestFriend_MacGuffins; NPC076_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty076 = RandomEncounters.iBestFriend_Disposition; DesireToMove076 = RandomEncounters.iBestFriend_DesireToMove; bCorpse076 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_077) { iAvailableMacGuffins077 = RandomEncounters.iBestFriend_MacGuffins; NPC077_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty077 = RandomEncounters.iBestFriend_Disposition; DesireToMove077 = RandomEncounters.iBestFriend_DesireToMove; bCorpse077 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_078) { iAvailableMacGuffins078 = RandomEncounters.iBestFriend_MacGuffins; NPC078_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty078 = RandomEncounters.iBestFriend_Disposition; DesireToMove078 = RandomEncounters.iBestFriend_DesireToMove; bCorpse078 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_079) { iAvailableMacGuffins079 = RandomEncounters.iBestFriend_MacGuffins; NPC079_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty079 = RandomEncounters.iBestFriend_Disposition; DesireToMove079 = RandomEncounters.iBestFriend_DesireToMove; bCorpse079 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_080) { iAvailableMacGuffins080 = RandomEncounters.iBestFriend_MacGuffins; NPC080_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty080 = RandomEncounters.iBestFriend_Disposition; DesireToMove080 = RandomEncounters.iBestFriend_DesireToMove; bCorpse080 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_081) { iAvailableMacGuffins081 = RandomEncounters.iBestFriend_MacGuffins; NPC081_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty081 = RandomEncounters.iBestFriend_Disposition; DesireToMove081 = RandomEncounters.iBestFriend_DesireToMove; bCorpse081 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_082) { iAvailableMacGuffins082 = RandomEncounters.iBestFriend_MacGuffins; NPC082_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty082 = RandomEncounters.iBestFriend_Disposition; DesireToMove082 = RandomEncounters.iBestFriend_DesireToMove; bCorpse082 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_083) { iAvailableMacGuffins083 = RandomEncounters.iBestFriend_MacGuffins; NPC083_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty083 = RandomEncounters.iBestFriend_Disposition; DesireToMove083 = RandomEncounters.iBestFriend_DesireToMove; bCorpse083 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_084) { iAvailableMacGuffins084 = RandomEncounters.iBestFriend_MacGuffins; NPC084_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty084 = RandomEncounters.iBestFriend_Disposition; DesireToMove084 = RandomEncounters.iBestFriend_DesireToMove; bCorpse084 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_085) { iAvailableMacGuffins085 = RandomEncounters.iBestFriend_MacGuffins; NPC085_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty085 = RandomEncounters.iBestFriend_Disposition; DesireToMove085 = RandomEncounters.iBestFriend_DesireToMove; bCorpse085 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_086) { iAvailableMacGuffins086 = RandomEncounters.iBestFriend_MacGuffins; NPC086_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty086 = RandomEncounters.iBestFriend_Disposition; DesireToMove086 = RandomEncounters.iBestFriend_DesireToMove; bCorpse086 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_087) { iAvailableMacGuffins087 = RandomEncounters.iBestFriend_MacGuffins; NPC087_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty087 = RandomEncounters.iBestFriend_Disposition; DesireToMove087 = RandomEncounters.iBestFriend_DesireToMove; bCorpse087 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_088) { iAvailableMacGuffins088 = RandomEncounters.iBestFriend_MacGuffins; NPC088_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty088 = RandomEncounters.iBestFriend_Disposition; DesireToMove088 = RandomEncounters.iBestFriend_DesireToMove; bCorpse088 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_089) { iAvailableMacGuffins089 = RandomEncounters.iBestFriend_MacGuffins; NPC089_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty089 = RandomEncounters.iBestFriend_Disposition; DesireToMove089 = RandomEncounters.iBestFriend_DesireToMove; bCorpse089 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_090) { iAvailableMacGuffins090 = RandomEncounters.iBestFriend_MacGuffins; NPC090_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty090 = RandomEncounters.iBestFriend_Disposition; DesireToMove090 = RandomEncounters.iBestFriend_DesireToMove; bCorpse090 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_091) { iAvailableMacGuffins091 = RandomEncounters.iBestFriend_MacGuffins; NPC091_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty091 = RandomEncounters.iBestFriend_Disposition; DesireToMove091 = RandomEncounters.iBestFriend_DesireToMove; bCorpse091 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_092) { iAvailableMacGuffins092 = RandomEncounters.iBestFriend_MacGuffins; NPC092_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty092 = RandomEncounters.iBestFriend_Disposition; DesireToMove092 = RandomEncounters.iBestFriend_DesireToMove; bCorpse092 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_093) { iAvailableMacGuffins093 = RandomEncounters.iBestFriend_MacGuffins; NPC093_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty093 = RandomEncounters.iBestFriend_Disposition; DesireToMove093 = RandomEncounters.iBestFriend_DesireToMove; bCorpse093 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_094) { iAvailableMacGuffins094 = RandomEncounters.iBestFriend_MacGuffins; NPC094_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty094 = RandomEncounters.iBestFriend_Disposition; DesireToMove094 = RandomEncounters.iBestFriend_DesireToMove; bCorpse094 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_095) { iAvailableMacGuffins095 = RandomEncounters.iBestFriend_MacGuffins; NPC095_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty095 = RandomEncounters.iBestFriend_Disposition; DesireToMove095 = RandomEncounters.iBestFriend_DesireToMove; bCorpse095 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_096) { iAvailableMacGuffins096 = RandomEncounters.iBestFriend_MacGuffins; NPC096_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty096 = RandomEncounters.iBestFriend_Disposition; DesireToMove096 = RandomEncounters.iBestFriend_DesireToMove; bCorpse096 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_097) { iAvailableMacGuffins097 = RandomEncounters.iBestFriend_MacGuffins; NPC097_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty097 = RandomEncounters.iBestFriend_Disposition; DesireToMove097 = RandomEncounters.iBestFriend_DesireToMove; bCorpse097 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_098) { iAvailableMacGuffins098 = RandomEncounters.iBestFriend_MacGuffins; NPC098_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty098 = RandomEncounters.iBestFriend_Disposition; DesireToMove098 = RandomEncounters.iBestFriend_DesireToMove; bCorpse098 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_099) { iAvailableMacGuffins099 = RandomEncounters.iBestFriend_MacGuffins; NPC099_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty099 = RandomEncounters.iBestFriend_Disposition; DesireToMove099 = RandomEncounters.iBestFriend_DesireToMove; bCorpse099 = RandomEncounters.bBestFriend_Corpse; }
            if (RandomEncounters.sBestFriend_Name == NPC_AI.NPC_100) { iAvailableMacGuffins100 = RandomEncounters.iBestFriend_MacGuffins; NPC100_CurrentNumLocation = RandomEncounters.iBestFriend_CurrentNumLocation; iLoyalty100 = RandomEncounters.iBestFriend_Disposition; DesireToMove100 = RandomEncounters.iBestFriend_DesireToMove; bCorpse100 = RandomEncounters.bBestFriend_Corpse; }

            // Reset the TEMP variables, just in case.
            RandomEncounters.bBestFriend_Corpse = false;
            RandomEncounters.iBestFriend_CurrentNumLocation = 0;
            RandomEncounters.iBestFriend_DesireToMove = 0;
            RandomEncounters.iBestFriend_Disposition = 0;
            RandomEncounters.iBestFriend_MacGuffins = 0;
        }

        public static void CorpseOrNot()
        {
            if (bTempCorpse) // Start by checking if the random NPC is a corpse.
            {
                if (Variables.iCurrentLocation == iTempLocation) // If a corpse, and if the random NPC is at the same location as the player.
                {
                    Lists.TheLocalDead.Add(tempNPC);                   
                }
            }
        }

        public static void Shuffler_01To89()
        {
            RandomEncounters.YourVeryOwnBestie();

            if (tempNPC == RandomEncounters.sBestFriend_Name)
            {
                return; // remove tempNPC from shuffler, if that tempNPC is the player's best friend.
            }

            // 1-89 Shuffler
            if ((bTempCorpse == false) && (tempNPC == NPC_001 || tempNPC == NPC_002 || tempNPC == NPC_003 || tempNPC == NPC_004 || tempNPC == NPC_005 || tempNPC == NPC_006 || tempNPC == NPC_007 || tempNPC == NPC_008 ||
                tempNPC == NPC_009 || tempNPC == NPC_010 || tempNPC == NPC_011 || tempNPC == NPC_012 || tempNPC == NPC_013 || tempNPC == NPC_014 || tempNPC == NPC_015 || tempNPC == NPC_016 || tempNPC == NPC_017 ||
                tempNPC == NPC_018 || tempNPC == NPC_019 || tempNPC == NPC_020 || tempNPC == NPC_021 || tempNPC == NPC_022 || tempNPC == NPC_023 || tempNPC == NPC_024 || tempNPC == NPC_025 || tempNPC == NPC_026 ||
                tempNPC == NPC_027 || tempNPC == NPC_028 || tempNPC == NPC_029 || tempNPC == NPC_030 || tempNPC == NPC_031 || tempNPC == NPC_032 || tempNPC == NPC_033 || tempNPC == NPC_034 || tempNPC == NPC_035 ||
                tempNPC == NPC_036 || tempNPC == NPC_037 || tempNPC == NPC_038 || tempNPC == NPC_039 || tempNPC == NPC_040 || tempNPC == NPC_041 || tempNPC == NPC_042 || tempNPC == NPC_043 || tempNPC == NPC_044 ||
                tempNPC == NPC_045 || tempNPC == NPC_046 || tempNPC == NPC_047 || tempNPC == NPC_048 || tempNPC == NPC_049 || tempNPC == NPC_050 || tempNPC == NPC_051 || tempNPC == NPC_052 || tempNPC == NPC_053 ||
                tempNPC == NPC_054 || tempNPC == NPC_055 || tempNPC == NPC_056 || tempNPC == NPC_057 || tempNPC == NPC_058 || tempNPC == NPC_059 || tempNPC == NPC_060 || tempNPC == NPC_061 || tempNPC == NPC_062 ||
                tempNPC == NPC_063 || tempNPC == NPC_064 || tempNPC == NPC_065 || tempNPC == NPC_066 || tempNPC == NPC_067 || tempNPC == NPC_068 || tempNPC == NPC_069 || tempNPC == NPC_070 || tempNPC == NPC_071 ||
                tempNPC == NPC_072 || tempNPC == NPC_073 || tempNPC == NPC_074 || tempNPC == NPC_075 || tempNPC == NPC_076 || tempNPC == NPC_077 || tempNPC == NPC_078 || tempNPC == NPC_079 || tempNPC == NPC_080 ||
                tempNPC == NPC_081 || tempNPC == NPC_082 || tempNPC == NPC_083 || tempNPC == NPC_084 || tempNPC == NPC_085 || tempNPC == NPC_086 || tempNPC == NPC_087 || tempNPC == NPC_088 || tempNPC == NPC_089))
            {
                if (bTempCorpse == false && iTempLoyalty == -1)
                {
                    iTempDesireToMove = iTempDesireToMove + 35; // if someone is afraid, they will move much more often.
                }
                DesireRoll = Program.rand.Next(1, iRandDesireMax) + iTempDesireToMove; // should we shuffle? Has to be kept outside the below if statements   
                if (iTempLastLocation == iTempLocation)
                {
                    if (bTempCorpse == false && DesireRoll >= iDesireInertia) // if what I rolled is greater than 100, then roll again to move.
                    {
                        Flood.bPutInDanger = false; // Any time the NPC moves, they are acting of their own free will and not the player's will, so the player is not responsible for their death.
                        iLocation = Program.rand.Next(1, 26);
                        Lists.DebugSomeoneMoved.Add(tempNPC);
                        while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 1))
                        {
                            iLocation = Program.rand.Next(1, 26);
                        }
                        sTempLastLocation = sTempCurrentLocation;
                        if (iLocation == 1) { sTempCurrentLocation = LocationEncounters.location_001; }
                        if (iLocation == 2) { sTempCurrentLocation = LocationEncounters.location_002; }
                        if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                        if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                        if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                        if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                        if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                        if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                        if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                        if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                        if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                        if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                        if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                        if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                        if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                        if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                        if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                        if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                        if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                        if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                        if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                        if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                        if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                        if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                        if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                        if (Variables.iCurrentLocation == iTempLocation) // checking to see if the player is where the NPC is at the moment, just prior to actually moving
                        {
                            Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; // and then tell the player where I'm going
                        }
                        iTempLastLocation = iTempLocation;
                        iTempLocation = iLocation; // Put us where we said we were moving to!
                        //if (Variables.iCurrentLocation == iTempLocation)
                        //{
                        //    Console.WriteLine("In the distance, you see " + tempNPC + " approaching from " + sTempLastLocation); iCloseEncounters++; Notebook.bTempNoted = false;
                        //}
                    }
                    else if (bTempCorpse == false && DesireRoll < iDesireInertia) // I am not a corpse, and I have decided NOT to move.
                    { // Decide to emote or "just be here".
                        iTempDesireToMove = iTempDesireToMove + iDesireRegen; // add 10 to desire if we didn't move last turn
                        iTempLastLocation = iTempLocation; // I didn't move last turn, so now I won't say I just arrived.
                        if (Variables.iCurrentLocation == iTempLocation)
                        {
                            if (iTempLoyalty >= 4)
                            {
                                Lists.MyPosse.Add(tempNPC);
                            }
                            Lists.TalkingNPCs.Add(tempNPC);
                            iCloseEncounters++; // I am where the player is, so increment seen var.
                            Notebook.bTempNoted = false; // reset their noted value so they can again be caught by the suspicious flag.
                            if (tempNPC == "Aaron" || tempNPC == "Alexander" || tempNPC == "Andrew" || tempNPC == "Anthony" || tempNPC == "Austin" || tempNPC == "Benjamin" || tempNPC == "Brandon" || tempNPC == "Carlos"
                            || tempNPC == "Carter" || tempNPC == "Charles" || tempNPC == "Christopher" || tempNPC == "Daniel" || tempNPC == "David" || tempNPC == "Dominic" || tempNPC == "Dylan" || tempNPC == "Elijah" || tempNPC == "Ethan"
                            || tempNPC == "Evan" || tempNPC == "Henry" || tempNPC == "Isaac" || tempNPC == "Isaiah" || tempNPC == "Jackson" || tempNPC == "Jacob" || tempNPC == "James" || tempNPC == "Jason" || tempNPC == "Jonathan"
                            || tempNPC == "Joshua" || tempNPC == "Julian" || tempNPC == "Justin" || tempNPC == "Kevin" || tempNPC == "Liam" || tempNPC == "Logan" || tempNPC == "Lucas" || tempNPC == "Luke" || tempNPC == "Mason"
                            || tempNPC == "Matthew" || tempNPC == "Michael" || tempNPC == "Nathan" || tempNPC == "Nicholas" || tempNPC == "Noah" || tempNPC == "Owen" || tempNPC == "Richard" || tempNPC == "Robert" || tempNPC == "Ryan"
                            || tempNPC == "Samuel" || tempNPC == "Sebastian" || tempNPC == "Tyler" || tempNPC == "William" || tempNPC == "Wyatt" || tempNPC == "Zachary")
                            {
                                sGenderHisHer = "his"; // each name will assign a male or female override value;
                                sGenderHeShe = "he"; // each name will assign a male or female override value;
                                sGenderHimHer = "him"; // each name will assign a male or female override value; 
                            }
                            else
                            {
                                sGenderHisHer = "her"; // each name will assign a male or female override value;
                                sGenderHeShe = "she"; // each name will assign a male or female override value;
                                sGenderHimHer = "her"; // each name will assign a male or female override value;
                            }
                            iRandDesireEmote = Program.rand.Next(1, 101);
                            if ((iRandDesireEmote >= iDesireEmote) && (tempNPC == NPC_001 || tempNPC == NPC_002 || tempNPC == NPC_003 || tempNPC == NPC_004 || tempNPC == NPC_005 || tempNPC == NPC_006 || tempNPC == NPC_007 || tempNPC == NPC_008 ||
                            tempNPC == NPC_009 || tempNPC == NPC_010 || tempNPC == NPC_011 || tempNPC == NPC_012 || tempNPC == NPC_013 || tempNPC == NPC_014 || tempNPC == NPC_015 || tempNPC == NPC_016 || tempNPC == NPC_017 ||
                            tempNPC == NPC_018 || tempNPC == NPC_019 || tempNPC == NPC_020 || tempNPC == NPC_021 || tempNPC == NPC_022 || tempNPC == NPC_023 || tempNPC == NPC_024 || tempNPC == NPC_025 || tempNPC == NPC_026 ||
                            tempNPC == NPC_027 || tempNPC == NPC_028 || tempNPC == NPC_029 || tempNPC == NPC_030 || tempNPC == NPC_031 || tempNPC == NPC_032 || tempNPC == NPC_033 || tempNPC == NPC_034 || tempNPC == NPC_035 ||
                            tempNPC == NPC_036 || tempNPC == NPC_037 || tempNPC == NPC_038 || tempNPC == NPC_039 || tempNPC == NPC_040 || tempNPC == NPC_041 || tempNPC == NPC_042 || tempNPC == NPC_043 || tempNPC == NPC_044 ||
                            tempNPC == NPC_045 || tempNPC == NPC_046 || tempNPC == NPC_047 || tempNPC == NPC_048 || tempNPC == NPC_049 || tempNPC == NPC_050 || tempNPC == NPC_051 || tempNPC == NPC_052 || tempNPC == NPC_053 ||
                            tempNPC == NPC_054 || tempNPC == NPC_055 || tempNPC == NPC_056 || tempNPC == NPC_057 || tempNPC == NPC_058 || tempNPC == NPC_059 || tempNPC == NPC_060 || tempNPC == NPC_061 || tempNPC == NPC_062 ||
                            tempNPC == NPC_063 || tempNPC == NPC_064 || tempNPC == NPC_065 || tempNPC == NPC_066 || tempNPC == NPC_067 || tempNPC == NPC_068 || tempNPC == NPC_069 || tempNPC == NPC_070 || tempNPC == NPC_071 ||
                            tempNPC == NPC_072 || tempNPC == NPC_073 || tempNPC == NPC_074 || tempNPC == NPC_075 || tempNPC == NPC_076 || tempNPC == NPC_077 || tempNPC == NPC_078 || tempNPC == NPC_079 || tempNPC == NPC_080 ||
                            tempNPC == NPC_081 || tempNPC == NPC_082 || tempNPC == NPC_083 || tempNPC == NPC_084 || tempNPC == NPC_085 || tempNPC == NPC_086 || tempNPC == NPC_087 || tempNPC == NPC_088 || tempNPC == NPC_089))
                            { // Pick a random emote
                                if (Variables.iRemainingTurns <= Variables.iTurn05 && Variables.iRemainingTurns > Variables.iTurn15) // 120-109 minutes remaining
                                {
                                    npcBehavior = Program.rand.Next(1, 19);
                                    if (npcBehavior == 1)
                                    { Console.WriteLine(String.Format(Conversation.sLine001, tempNPC)); }
                                    if (npcBehavior == 2)
                                    { Console.WriteLine(String.Format(Conversation.sLine002, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 3)
                                    { Console.WriteLine(String.Format(Conversation.sLine003, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 4)
                                    { Console.WriteLine(String.Format(Conversation.sLine004, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 5)
                                    { Console.WriteLine(String.Format(Conversation.sLine005, tempNPC)); }
                                    if (npcBehavior == 6)
                                    { Console.WriteLine(String.Format(Conversation.sLine006, tempNPC)); }
                                    if (npcBehavior == 7)
                                    { Console.WriteLine(String.Format(Conversation.sLine007, tempNPC)); }
                                    if (npcBehavior == 8)
                                    { Console.WriteLine(String.Format(Conversation.sLine008, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 9)
                                    { Console.WriteLine(String.Format(Conversation.sLine009, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 10)
                                    { Console.WriteLine(String.Format(Conversation.sLine010, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 11)
                                    { Console.WriteLine(String.Format(Conversation.sLine011, tempNPC)); }
                                    if (npcBehavior == 12)
                                    { Console.WriteLine(String.Format(Conversation.sLine012, tempNPC)); }
                                    if (npcBehavior == 13)
                                    { Console.WriteLine(String.Format(Conversation.sLine013, tempNPC)); }
                                    if (npcBehavior == 14)
                                    { Console.WriteLine(String.Format(Conversation.sLine014, tempNPC)); }
                                    if (npcBehavior == 15)
                                    { Console.WriteLine(String.Format(Conversation.sLine015, tempNPC)); }
                                    if (npcBehavior == 16)
                                    { Console.WriteLine(String.Format(Conversation.sLine016, tempNPC)); }
                                    if (npcBehavior == 17)
                                    { Console.WriteLine(String.Format(Conversation.sLine017, tempNPC)); }
                                    if (npcBehavior == 18)
                                    { Console.WriteLine(String.Format(Conversation.sLine018, tempNPC)); }
                                }
                                else if (Variables.iRemainingTurns <= Variables.iTurn15 && Variables.iRemainingTurns >= Variables.iTurn25) // 108-098 minutes remaining
                                {
                                    npcBehavior = Program.rand.Next(1, 17);
                                    if (npcBehavior == 1)
                                    { Console.WriteLine(String.Format(Conversation.sLine100, tempNPC)); }
                                    if (npcBehavior == 2)
                                    { Console.WriteLine(String.Format(Conversation.sLine101, tempNPC)); }
                                    if (npcBehavior == 3)
                                    { Console.WriteLine(String.Format(Conversation.sLine102, tempNPC)); }
                                    if (npcBehavior == 4)
                                    { Console.WriteLine(String.Format(Conversation.sLine103, tempNPC)); }
                                    if (npcBehavior == 5)
                                    { Console.WriteLine(String.Format(Conversation.sLine104, tempNPC, sGenderHimHer)); }
                                    if (npcBehavior == 6)
                                    { Console.WriteLine(String.Format(Conversation.sLine105, tempNPC, sGenderHisHer, sGenderHeShe)); }
                                    if (npcBehavior == 7)
                                    { Console.WriteLine(String.Format(Conversation.sLine106, tempNPC)); }
                                    if (npcBehavior == 8)
                                    { Console.WriteLine(String.Format(Conversation.sLine107, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 9)
                                    { Console.WriteLine(String.Format(Conversation.sLine108, tempNPC)); }
                                    if (npcBehavior == 10)
                                    { Console.WriteLine(String.Format(Conversation.sLine109, tempNPC)); }
                                    if (npcBehavior == 11)
                                    { Console.WriteLine(String.Format(Conversation.sLine110, tempNPC)); }
                                    if (npcBehavior == 12)
                                    { Console.WriteLine(String.Format(Conversation.sLine111, tempNPC)); }
                                    if (npcBehavior == 13)
                                    { Console.WriteLine(String.Format(Conversation.sLine112, tempNPC, sGenderHimHer)); }
                                    if (npcBehavior == 14)
                                    { Console.WriteLine(String.Format(Conversation.sLine113, tempNPC)); }
                                    if (npcBehavior == 15)
                                    { Console.WriteLine(String.Format(Conversation.sLine114, tempNPC)); }
                                    if (npcBehavior == 16)
                                    { Console.WriteLine(String.Format(Conversation.sLine115, tempNPC)); }
                                }
                                else if (Variables.iRemainingTurns < Variables.iTurn25 && Variables.iRemainingTurns >= Variables.iTurn45) // 097-035 minutes remaining
                                {
                                    npcBehavior = Program.rand.Next(1, 22);
                                    if (npcBehavior == 1)
                                    { Console.WriteLine(String.Format(Conversation.sLine200, tempNPC)); }
                                    if (npcBehavior == 2)
                                    { Console.WriteLine(String.Format(Conversation.sLine201, tempNPC, sGenderHeShe)); }
                                    if (npcBehavior == 3)
                                    { Console.WriteLine(String.Format(Conversation.sLine202, tempNPC)); }
                                    if (npcBehavior == 4)
                                    { Console.WriteLine(String.Format(Conversation.sLine203, tempNPC, sGenderHeShe)); }
                                    if (npcBehavior == 5)
                                    { Console.WriteLine(String.Format(Conversation.sLine204, tempNPC)); }
                                    if (npcBehavior == 6)
                                    { Console.WriteLine(String.Format(Conversation.sLine205, tempNPC)); }
                                    if (npcBehavior == 7)
                                    { Console.WriteLine(String.Format(Conversation.sLine206, tempNPC)); }
                                    if (npcBehavior == 8)
                                    { Console.WriteLine(String.Format(Conversation.sLine207, tempNPC)); }
                                    if (npcBehavior == 9)
                                    { Console.WriteLine(String.Format(Conversation.sLine208, tempNPC)); }
                                    if (npcBehavior == 10)
                                    { Console.WriteLine(String.Format(Conversation.sLine209, tempNPC)); }
                                    if (npcBehavior == 11)
                                    { Console.WriteLine(String.Format(Conversation.sLine210, tempNPC)); }
                                    if (npcBehavior == 12)
                                    { Console.WriteLine(String.Format(Conversation.sLine211, tempNPC)); }
                                    if (npcBehavior == 13)
                                    { Console.WriteLine(String.Format(Conversation.sLine212, tempNPC)); }
                                    if (npcBehavior == 14)
                                    { Console.WriteLine(String.Format(Conversation.sLine213, tempNPC)); }
                                    if (npcBehavior == 15)
                                    { Console.WriteLine(String.Format(Conversation.sLine214, tempNPC)); }
                                    if (npcBehavior == 16)
                                    { Console.WriteLine(String.Format(Conversation.sLine215, tempNPC)); }
                                    if (npcBehavior == 17)
                                    { Console.WriteLine(String.Format(Conversation.sLine216, tempNPC)); }
                                    if (npcBehavior == 18)
                                    { Console.WriteLine(String.Format(Conversation.sLine217, tempNPC)); }
                                    if (npcBehavior == 19)
                                    { Console.WriteLine(String.Format(Conversation.sLine218, tempNPC)); }
                                    if (npcBehavior == 20)
                                    { Console.WriteLine(String.Format(Conversation.sLine219, tempNPC)); }
                                    if (npcBehavior == 21)
                                    { Console.WriteLine(String.Format(Conversation.sLine220, tempNPC)); }
                                }
                                else if (Variables.iRemainingTurns < Variables.iTurn45 && Variables.iRemainingTurns > Variables.iTurn55) // 034-017 minutes remaining
                                {
                                    npcBehavior = Program.rand.Next(1, 26);
                                    if (npcBehavior == 1)
                                    { Console.WriteLine(String.Format(Conversation.sLine300, tempNPC)); }
                                    if (npcBehavior == 2)
                                    { Console.WriteLine(String.Format(Conversation.sLine301, tempNPC, sGenderHeShe)); }
                                    if (npcBehavior == 3)
                                    { Console.WriteLine(String.Format(Conversation.sLine302, tempNPC)); }
                                    if (npcBehavior == 4)
                                    { Console.WriteLine(String.Format(Conversation.sLine303, tempNPC)); }
                                    if (npcBehavior == 5)
                                    { Console.WriteLine(String.Format(Conversation.sLine304, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 6)
                                    { Console.WriteLine(String.Format(Conversation.sLine305, tempNPC)); }
                                    if (npcBehavior == 7)
                                    { Console.WriteLine(String.Format(Conversation.sLine306, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 8)
                                    { Console.WriteLine(String.Format(Conversation.sLine307, tempNPC, sGenderHisHer)); }
                                    if (npcBehavior == 9)
                                    { Console.WriteLine(String.Format(Conversation.sLine308, tempNPC)); }
                                    if (npcBehavior == 10)
                                    { Console.WriteLine(String.Format(Conversation.sLine309, tempNPC)); }
                                    if (npcBehavior == 11)
                                    { Console.WriteLine(String.Format(Conversation.sLine310, tempNPC)); }
                                    if (npcBehavior == 12)
                                    { Console.WriteLine(String.Format(Conversation.sLine311, tempNPC)); }
                                    if (npcBehavior == 13)
                                    { Console.WriteLine(String.Format(Conversation.sLine312, tempNPC)); }
                                    if (npcBehavior == 14)
                                    { Console.WriteLine(String.Format(Conversation.sLine313, tempNPC)); }
                                    if (npcBehavior == 15)
                                    { Console.WriteLine(String.Format(Conversation.sLine314, tempNPC)); }
                                    if (npcBehavior == 16)
                                    { Console.WriteLine(String.Format(Conversation.sLine315, tempNPC)); }
                                    if (npcBehavior == 17)
                                    { Console.WriteLine(String.Format(Conversation.sLine316, tempNPC, sGenderHeShe)); }
                                    if (npcBehavior == 18)
                                    { Console.WriteLine(String.Format(Conversation.sLine317, tempNPC, sGenderHeShe)); }
                                    if (npcBehavior == 19)
                                    { Console.WriteLine(String.Format(Conversation.sLine318, tempNPC)); }
                                    if (npcBehavior == 20)
                                    { Console.WriteLine(String.Format(Conversation.sLine319, tempNPC)); }
                                    if (npcBehavior == 21)
                                    { Console.WriteLine(String.Format(Conversation.sLine320, tempNPC)); }
                                    if (npcBehavior == 22)
                                    { Console.WriteLine(String.Format(Conversation.sLine321, tempNPC)); }
                                    if (npcBehavior == 23)
                                    { Console.WriteLine(String.Format(Conversation.sLine322, tempNPC)); }
                                    if (npcBehavior == 24)
                                    { Console.WriteLine(String.Format(Conversation.sLine323, tempNPC)); }
                                    if (npcBehavior == 25)
                                    { Console.WriteLine(String.Format(Conversation.sLine324, tempNPC)); }
                                }
                                else if (Variables.iRemainingTurns <= Variables.iTurn55) // 016-000 minutes remaining
                                {
                                    npcBehavior = Program.rand.Next(1, 7);
                                    if (npcBehavior == 1)
                                    { Console.WriteLine(String.Format(Conversation.sLine600, tempNPC)); }
                                    if (npcBehavior == 2)
                                    { Console.WriteLine(String.Format(Conversation.sLine601, tempNPC)); }
                                    if (npcBehavior == 3)
                                    { Console.WriteLine(String.Format(Conversation.sLine602, tempNPC)); }
                                    if (npcBehavior == 4)
                                    { Console.WriteLine(String.Format(Conversation.sLine603, tempNPC)); }
                                    if (npcBehavior == 5)
                                    { Console.WriteLine(String.Format(Conversation.sLine604, tempNPC)); }
                                    if (npcBehavior == 6)
                                    { Console.WriteLine(String.Format(Conversation.sLine605, tempNPC)); }
                                }
                            }
                            else if (iRandDesireEmote < iDesireEmote)
                            { Console.WriteLine(tempNPC + " is here."); }
                        }
                    }
                }
                if (bTempCorpse == false && iTempLastLocation != iTempLocation) // I am not a corpse, and IF I just moved last turn.
                {
                    iTempDesireToMove = iDesireBottom; // We just moved, so set DTM to 0 to keep NPCs from moving too much.
                    iTempLastLocation = iTempLocation;
                    if (Variables.iCurrentLocation == iTempLocation) // Only say this if I am where the player is.
                    {
                        if (iTempLoyalty >= 4)
                        {
                            Lists.MyPosse.Add(tempNPC);
                        }
                        Lists.TalkingNPCs.Add(tempNPC);
                        if (!Variables.bAnyoneHere)
                        { Console.WriteLine(); Variables.bAnyoneHere = true; }
                        Variables.bAnyoneHere = true;
                        Console.WriteLine(tempNPC + " arrives from the direction of " + sTempLastLocation);
                        iCloseEncounters++; // increment the number of times I've been around the player.
                        Notebook.bTempNoted = false; // reset their noted value so they can again be caught by the suspicious flag.
                    }
                }
            }
            // End Shuffler 1-89
        }

        public static void NPC100_ShufflerOverride()
        {
            // Special Killer Code to override/properly report the killer moving to your location when he successfully hunts.
            NPC100_PantsDownGenderCheck();
            if (tempNPC == NPC_100 && Variables.iRemainingTurns == Variables.iTurn50) // It's turn 20
            {
                if (!Variables.bAnyoneHere)
                { Console.WriteLine(); }
                Variables.bAnyoneHere = true;
                iCloseEncounters++; Notebook.bTempNoted = false; Console.WriteLine(tempNPC + " arrives from the direction of " + sTempLastLocation);
                sTempLastLocation = Variables.sGetLocation;
                iTempLocation = Variables.iCurrentLocation; // Killer moved to player's location
                sTempCurrentLocation = Variables.sGetLocation; // Killer moved to player's location
                Variables.bAboutToDie = true;
                iLuckyHunter = 0; // reset this so that the killer doesn't become the Terminator
                bHunting = true;
                // Console.WriteLine("1. NPC100_CurrentNumLocation: " + NPC100_CurrentNumLocation);
            }
            else if ((tempNPC == NPC_100) && (iTempLocation == Variables.iCurrentLocation) && (Variables.iRemainingTurns < Variables.iTurn50)) // turn 19 or lower
            {
                Variables.bAnyoneHere = true;
                Console.WriteLine(tempNPC + " is here.");
                iCloseEncounters++;
                Notebook.bTempNoted = false;
                Variables.bAboutToDie = true;
                bHunting = true;
                sTempLastLocation = sTempCurrentLocation; // 1st: set my last location
                sTempCurrentLocation = Variables.sGetLocation; // 4th: Set current location to where I am
                iLuckyHunter = 0; // reset this so that the killer doesn't become the Terminator
                // Console.WriteLine("2. NPC100_CurrentNumLocation: " + NPC100_CurrentNumLocation);
            }
            else if ((tempNPC == NPC_100) && (iTempLocation != Variables.iCurrentLocation) && (Variables.iRemainingTurns < Variables.iTurn50)) // turn 19 or lower
            {
                iHuntPlayer = Program.rand.Next(1, iHunterMax) + iLuckyHunter;
                if (iHuntPlayer >= iHuntThreshold) // If I find the player
                {
                    sTempLastLocation = sTempCurrentLocation; // 1st: set my last location
                    iTempLocation = Variables.iCurrentLocation; // 2nd: Set killer's location to where the player is
                    if (!Variables.bAnyoneHere)
                    { Console.WriteLine(); }
                    Variables.bAnyoneHere = true;
                    iCloseEncounters++; Notebook.bTempNoted = false; Console.WriteLine(tempNPC + " arrives from the direction of " + sTempLastLocation); //3rd: says that I arrived from that last location
                    sTempCurrentLocation = Variables.sGetLocation; // 4th: Set current location to where I am
                    Variables.bAboutToDie = true;
                    iLuckyHunter = 0; // reset this so that the killer doesn't become the Terminator
                    bHunting = true;
                    // Console.WriteLine("3. NPC100_CurrentNumLocation: " + NPC100_CurrentNumLocation);
                }
                else if (iHuntPlayer < iHuntThreshold) // I don't find the player...
                {
                    // NPC100_LastStrLocation = NPC100_CurrentStrLocation;
                    // NPC100_CurrentNumLocation = Variables.iCurrentLocation;
                    bHunting = true;
                    // Console.WriteLine("4. NPC100_CurrentNumLocation: " + NPC100_CurrentNumLocation);
                } // set to true so I'll kill NPCs
            }
        }

        public static void Shuffler_90To100()
        {
            RandomEncounters.YourVeryOwnBestie();

            if (tempNPC == RandomEncounters.sBestFriend_Name)
            {
                return; // remove tempNPC from shuffler, if that tempNPC is the player's best friend.
            }

            tempNPC_PantsDownGenderCheck();

            if ((bTempCorpse == false) && 
            tempNPC == NPC_090 || tempNPC == NPC_091 || tempNPC == NPC_092 || tempNPC == NPC_093 || tempNPC == NPC_094 ||
            tempNPC == NPC_095 || tempNPC == NPC_096 || tempNPC == NPC_097 || tempNPC == NPC_098 || tempNPC == NPC_099 ||
            (tempNPC == NPC_100 && Variables.iRemainingTurns > Variables.iTurn50))
            {
                Flood.bTempFloodMoved = false;
                if (bTempCorpse == false && iTempLoyalty == -1)
                {
                    iTempDesireToMove = iTempDesireToMove + 35; // if someone is afraid, they will move much more often.
                }
                // Check if they are at a bad location during the flooding stages.
                if (bTempCorpse == false && Variables.iRemainingTurns <= 31 && Variables.iRemainingTurns >= 29 && iTempLocation == 1)
                {
                    iLocation = Program.rand.Next(2, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 2))
                    { iLocation = Program.rand.Next(2, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 2) { sTempCurrentLocation = LocationEncounters.location_002; }
                    if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                    if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                    if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                    if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 28 && (iTempLocation == 1 || iTempLocation == 2))
                {
                    iLocation = Program.rand.Next(3, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 3))
                    { iLocation = Program.rand.Next(3, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                    if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                    if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                    if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 27 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3))
                {
                    iLocation = Program.rand.Next(4, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 4))
                    { iLocation = Program.rand.Next(4, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                    if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                    if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 26 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4))
                {
                    iLocation = Program.rand.Next(5, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 5))
                    { iLocation = Program.rand.Next(5, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                    if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 25 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5))
                {
                    iLocation = Program.rand.Next(6, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 6))
                    { iLocation = Program.rand.Next(6, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 24 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6))
                {
                    iLocation = Program.rand.Next(7, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 7))
                    { iLocation = Program.rand.Next(7, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 23 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7))
                {
                    iLocation = Program.rand.Next(8, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 8))
                    { iLocation = Program.rand.Next(8, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns <= 22 && (Variables.iRemainingTurns >= 19 && iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8))
                {
                    iLocation = Program.rand.Next(9, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 9))
                    { iLocation = Program.rand.Next(9, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 18 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9))
                {
                    iLocation = Program.rand.Next(10, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 10))
                    { iLocation = Program.rand.Next(10, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 17 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10))
                {
                    iLocation = Program.rand.Next(11, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 11))
                    { iLocation = Program.rand.Next(11, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 16 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11))
                {
                    iLocation = Program.rand.Next(12, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 12))
                    { iLocation = Program.rand.Next(12, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 15 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12))
                {
                    iLocation = Program.rand.Next(13, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 13))
                    { iLocation = Program.rand.Next(13, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 14 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13))
                {
                    iLocation = Program.rand.Next(14, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 14))
                    { iLocation = Program.rand.Next(14, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 13 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14))
                {
                    iLocation = Program.rand.Next(15, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 15))
                    { iLocation = Program.rand.Next(15, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 12 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15))
                {
                    iLocation = Program.rand.Next(16, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 16))
                    { iLocation = Program.rand.Next(16, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 11 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16))
                {
                    iLocation = Program.rand.Next(17, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 17))
                    { iLocation = Program.rand.Next(17, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 10 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17))
                {
                    iLocation = Program.rand.Next(18, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 18))
                    { iLocation = Program.rand.Next(18, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 9 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18))
                {
                    iLocation = Program.rand.Next(19, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 19))
                    { iLocation = Program.rand.Next(19, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 8 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18 || iTempLocation == 19))
                {
                    iLocation = Program.rand.Next(20, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 20))
                    { iLocation = Program.rand.Next(20, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 7 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18 || iTempLocation == 19 || iTempLocation == 20))
                {
                    iLocation = Program.rand.Next(21, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 21))
                    { iLocation = Program.rand.Next(21, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 6 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18 || iTempLocation == 19 || iTempLocation == 20 || iTempLocation == 21))
                {
                    iLocation = Program.rand.Next(22, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 22))
                    { iLocation = Program.rand.Next(22, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 5 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18 || iTempLocation == 19 || iTempLocation == 20 || iTempLocation == 21 || iTempLocation == 22))
                {
                    iLocation = Program.rand.Next(23, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 23))
                    { iLocation = Program.rand.Next(23, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns == 4 && (iTempLocation == 1 || iTempLocation == 2 || iTempLocation == 3 || iTempLocation == 4 || iTempLocation == 5 || iTempLocation == 6 || iTempLocation == 7 || iTempLocation == 8 || iTempLocation == 9 || iTempLocation == 10 || iTempLocation == 11 || iTempLocation == 12 || iTempLocation == 13 || iTempLocation == 14 || iTempLocation == 15 || iTempLocation == 16 || iTempLocation == 17 || iTempLocation == 18 || iTempLocation == 19 || iTempLocation == 20 || iTempLocation == 21 || iTempLocation == 22 || iTempLocation == 23))
                {
                    iLocation = Program.rand.Next(24, 26);
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 24))
                    { iLocation = Program.rand.Next(24, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Variables.iRemainingTurns <= 3 && iTempLocation != 25) // Essentially, if someone is not at space 25, make sure they go to space 25. This is a fail safe that should never fire.
                {
                    iLocation = Program.rand.Next(25, 26); // HA. Yes. I am going to roll a random number that must be 1. :p I'm all about non-optimization. Obvs. 
                    Lists.DebugSomeoneMoved.Add(tempNPC);
                    while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 25))
                    { iLocation = Program.rand.Next(25, 26); }
                    sTempLastLocation = sTempCurrentLocation;
                    if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                    if (Variables.iCurrentLocation == iTempLocation)
                    { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                    iTempLastLocation = iTempLocation; iTempLocation = iLocation; Flood.bTempFloodMoved = true;
                }
                else if (bTempCorpse == false && Flood.bTempFloodMoved == false) // I slipped through all of the above, so I'm not in danger. Do something below.
                {
                    DesireRoll = Program.rand.Next(1, iRandDesireMax) + iTempDesireToMove; // should we shuffle? Has to be kept outside the below if statements   
                    if (iTempLastLocation == iTempLocation) // I have not moved in the last turn.
                    {
                        if (DesireRoll >= iDesireInertia) // if what I rolled is greater than 100, then roll again to move.
                        {
                            if (Variables.iRemainingTurns <= 31 && Variables.iRemainingTurns >= 29) // I want to move, I haven't moved recently, but there is a flood happening, limit my move choices. Don't go to a flooded area!
                            {
                                iLocation = Program.rand.Next(2, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 2))
                                { iLocation = Program.rand.Next(2, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 2) { sTempCurrentLocation = LocationEncounters.location_002; }
                                if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                                if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                                if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 28)
                            {
                                iLocation = Program.rand.Next(3, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 3))
                                { iLocation = Program.rand.Next(3, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                                if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                                if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 27)
                            {
                                iLocation = Program.rand.Next(4, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 4))
                                { iLocation = Program.rand.Next(4, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                                if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 26)
                            {
                                iLocation = Program.rand.Next(5, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 5))
                                { iLocation = Program.rand.Next(5, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 25)
                            {
                                iLocation = Program.rand.Next(6, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 6))
                                { iLocation = Program.rand.Next(6, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 24)
                            {
                                iLocation = Program.rand.Next(7, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 7))
                                { iLocation = Program.rand.Next(7, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 23)
                            {
                                iLocation = Program.rand.Next(8, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 8))
                                { iLocation = Program.rand.Next(8, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns <= 22 && Variables.iRemainingTurns >= 19)
                            {
                                iLocation = Program.rand.Next(9, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 9))
                                { iLocation = Program.rand.Next(9, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 18)
                            {
                                iLocation = Program.rand.Next(10, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 10))
                                { iLocation = Program.rand.Next(10, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 17)
                            {
                                iLocation = Program.rand.Next(11, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 11))
                                { iLocation = Program.rand.Next(11, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 16)
                            {
                                iLocation = Program.rand.Next(12, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 12))
                                { iLocation = Program.rand.Next(12, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 15)
                            {
                                iLocation = Program.rand.Next(13, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 13))
                                { iLocation = Program.rand.Next(13, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 14)
                            {
                                iLocation = Program.rand.Next(14, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 14))
                                { iLocation = Program.rand.Next(14, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 13)
                            {
                                iLocation = Program.rand.Next(15, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 15))
                                { iLocation = Program.rand.Next(15, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 12)
                            {
                                iLocation = Program.rand.Next(16, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 16))
                                { iLocation = Program.rand.Next(16, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 11)
                            {
                                iLocation = Program.rand.Next(17, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 17))
                                { iLocation = Program.rand.Next(17, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 10)
                            {
                                iLocation = Program.rand.Next(18, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 18))
                                { iLocation = Program.rand.Next(18, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 9)
                            {
                                iLocation = Program.rand.Next(19, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 19))
                                { iLocation = Program.rand.Next(19, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 8)
                            {
                                iLocation = Program.rand.Next(20, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 20))
                                { iLocation = Program.rand.Next(20, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 7)
                            {
                                iLocation = Program.rand.Next(21, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 21))
                                { iLocation = Program.rand.Next(21, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 6)
                            {
                                iLocation = Program.rand.Next(22, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 22))
                                { iLocation = Program.rand.Next(22, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 5)
                            {
                                iLocation = Program.rand.Next(23, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 23))
                                { iLocation = Program.rand.Next(23, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns == 4)
                            {
                                iLocation = Program.rand.Next(24, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation > 25) || (iLocation < 24))
                                { iLocation = Program.rand.Next(24, 26); }
                                sTempLastLocation = sTempCurrentLocation;
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation)
                                { Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns <= 3 && tempNPC != NPC_100) // if it's the last three turns, I want to move (but can't!), and I'm not the killer
                            {
                                int iLastWords = Program.rand.Next(1, 7);
                                npcBehavior = Program.rand.Next(1, 7);
                                if (iLastWords == 1)
                                { Console.WriteLine(String.Format(Conversation.sLine600, tempNPC)); }
                                if (iLastWords == 2)
                                { Console.WriteLine(String.Format(Conversation.sLine601, tempNPC)); }
                                if (iLastWords == 3)
                                { Console.WriteLine(String.Format(Conversation.sLine602, tempNPC)); }
                                if (iLastWords == 4)
                                { Console.WriteLine(String.Format(Conversation.sLine603, tempNPC)); }
                                if (iLastWords == 5)
                                { Console.WriteLine(String.Format(Conversation.sLine604, tempNPC)); }
                                if (iLastWords == 6)
                                { Console.WriteLine(String.Format(Conversation.sLine605, tempNPC)); }
                                //iLocation = Program.rand.Next(25, 26); // HA. Yes. I am going to roll a random number that must be 1. :p I'm all about non-optimization. Obvs.
                                //while ((iLocation > 25) || (iLocation < 25))
                                //{ iLocation = Program.rand.Next(25, 26); }
                                //sTempLastLocation = sTempCurrentLocation;
                                //if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                //if (Variables.iCurrentLocation == iTempLocation)
                                //{ Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; }
                                //iTempLastLocation = iTempLocation; iTempLocation = iLocation;
                            }
                            else if (Variables.iRemainingTurns > 31)
                            {
                                iLocation = Program.rand.Next(1, 26);
                                Lists.DebugSomeoneMoved.Add(tempNPC);
                                while ((iLocation == iTempLocation) || (iLocation < 1) || (iLocation > 25))
                                {
                                    iLocation = Program.rand.Next(1, 26);
                                }
                                // if (Variables.iCurrentLocation == iTempLocation)
                                // {
                                sTempLastLocation = sTempCurrentLocation;
                                //  }
                                if (iLocation == 1) { sTempCurrentLocation = LocationEncounters.location_001; }
                                if (iLocation == 2) { sTempCurrentLocation = LocationEncounters.location_002; }
                                if (iLocation == 3) { sTempCurrentLocation = LocationEncounters.location_003; }
                                if (iLocation == 4) { sTempCurrentLocation = LocationEncounters.location_004; }
                                if (iLocation == 5) { sTempCurrentLocation = LocationEncounters.location_005; }
                                if (iLocation == 6) { sTempCurrentLocation = LocationEncounters.location_006; }
                                if (iLocation == 7) { sTempCurrentLocation = LocationEncounters.location_007; }
                                if (iLocation == 8) { sTempCurrentLocation = LocationEncounters.location_008; }
                                if (iLocation == 9) { sTempCurrentLocation = LocationEncounters.location_009; }
                                if (iLocation == 10) { sTempCurrentLocation = LocationEncounters.location_010; }
                                if (iLocation == 11) { sTempCurrentLocation = LocationEncounters.location_011; }
                                if (iLocation == 12) { sTempCurrentLocation = LocationEncounters.location_012; }
                                if (iLocation == 13) { sTempCurrentLocation = LocationEncounters.location_013; }
                                if (iLocation == 14) { sTempCurrentLocation = LocationEncounters.location_014; }
                                if (iLocation == 15) { sTempCurrentLocation = LocationEncounters.location_015; }
                                if (iLocation == 16) { sTempCurrentLocation = LocationEncounters.location_016; }
                                if (iLocation == 17) { sTempCurrentLocation = LocationEncounters.location_017; }
                                if (iLocation == 18) { sTempCurrentLocation = LocationEncounters.location_018; }
                                if (iLocation == 19) { sTempCurrentLocation = LocationEncounters.location_019; }
                                if (iLocation == 20) { sTempCurrentLocation = LocationEncounters.location_020; }
                                if (iLocation == 21) { sTempCurrentLocation = LocationEncounters.location_021; }
                                if (iLocation == 22) { sTempCurrentLocation = LocationEncounters.location_022; }
                                if (iLocation == 23) { sTempCurrentLocation = LocationEncounters.location_023; }
                                if (iLocation == 24) { sTempCurrentLocation = LocationEncounters.location_024; }
                                if (iLocation == 25) { sTempCurrentLocation = LocationEncounters.location_025; }
                                if (Variables.iCurrentLocation == iTempLocation) // checking to see if the player is where the NPC is at the moment, just prior to actually moving
                                {
                                    Console.WriteLine(tempNPC + " just left, and is walking in the direction of " + sTempCurrentLocation); iCloseEncounters++; Notebook.bTempNoted = false; // and then tell the player where I'm going
                                }
                                iTempLastLocation = iTempLocation;
                                iTempLocation = iLocation; // Put us where we said we were moving to!
                                //if (Variables.iCurrentLocation == iTempLocation)
                                //{
                                //    Console.WriteLine("In the distance, you see " + tempNPC + " approaching from " + sTempLastLocation); iCloseEncounters++; Notebook.bTempNoted = false;
                                //}
                            }
                        }
                        else if (bTempCorpse == false && DesireRoll < iDesireInertia) // I am not a corpse, and I have decided NOT to move.
                        { // Decide to emote or "just be here".
                            iTempDesireToMove = iTempDesireToMove + iDesireRegen; // add 10 to desire if we didn't move last turn
                            iTempLastLocation = iTempLocation; // I didn't move last turn, so now I won't say I just arrived.
                            if (Variables.iCurrentLocation == iTempLocation)
                            {
                                if (iTempLoyalty >= 4)
                                {
                                    Lists.MyPosse.Add(tempNPC);
                                }
                                Lists.TalkingNPCs.Add(tempNPC);
                                iCloseEncounters++; // I am where the player is, so increment seen var.
                                Notebook.bTempNoted = false; // reset their noted value so they can again be caught by the suspicious flag.
                                if (tempNPC == "Aaron" || tempNPC == "Alexander" || tempNPC == "Andrew" || tempNPC == "Anthony" || tempNPC == "Austin" || tempNPC == "Benjamin" || tempNPC == "Brandon" || tempNPC == "Carlos"
                                || tempNPC == "Carter" || tempNPC == "Charles" || tempNPC == "Christopher" || tempNPC == "Daniel" || tempNPC == "David" || tempNPC == "Dominic" || tempNPC == "Dylan" || tempNPC == "Elijah" || tempNPC == "Ethan"
                                || tempNPC == "Evan" || tempNPC == "Henry" || tempNPC == "Isaac" || tempNPC == "Isaiah" || tempNPC == "Jackson" || tempNPC == "Jacob" || tempNPC == "James" || tempNPC == "Jason" || tempNPC == "Jonathan"
                                || tempNPC == "Joshua" || tempNPC == "Julian" || tempNPC == "Justin" || tempNPC == "Kevin" || tempNPC == "Liam" || tempNPC == "Logan" || tempNPC == "Lucas" || tempNPC == "Luke" || tempNPC == "Mason"
                                || tempNPC == "Matthew" || tempNPC == "Michael" || tempNPC == "Nathan" || tempNPC == "Nicholas" || tempNPC == "Noah" || tempNPC == "Owen" || tempNPC == "Richard" || tempNPC == "Robert" || tempNPC == "Ryan"
                                || tempNPC == "Samuel" || tempNPC == "Sebastian" || tempNPC == "Tyler" || tempNPC == "William" || tempNPC == "Wyatt" || tempNPC == "Zachary")
                                {
                                    sGenderHisHer = "his"; // each name will assign a male or female override value;
                                    sGenderHeShe = "he"; // each name will assign a male or female override value;
                                    sGenderHimHer = "him"; // each name will assign a male or female override value; 
                                }
                                else
                                {
                                    sGenderHisHer = "her"; // each name will assign a male or female override value;
                                    sGenderHeShe = "she"; // each name will assign a male or female override value;
                                    sGenderHimHer = "her"; // each name will assign a male or female override value;
                                }
                                iRandDesireEmote = Program.rand.Next(1, 101);
                                if (iRandDesireEmote >= iDesireEmote)
                                { // Pick a random emote
                                    if (Variables.iRemainingTurns <= Variables.iTurn05 && Variables.iRemainingTurns > Variables.iTurn30) // 120-101 minutes remaining
                                    {
                                        npcBehavior = Program.rand.Next(1, 25);
                                        if (npcBehavior == 1)
                                        { Console.WriteLine(String.Format(Conversation.sLine001, tempNPC)); }
                                        if (npcBehavior == 2)
                                        { Console.WriteLine(String.Format(Conversation.sLine005, tempNPC)); }
                                        if (npcBehavior == 3)
                                        { Console.WriteLine(String.Format(Conversation.sLine011, tempNPC)); }
                                        if (npcBehavior == 4)
                                        { Console.WriteLine(String.Format(Conversation.sLine013, tempNPC)); }
                                        if (npcBehavior == 5)
                                        { Console.WriteLine(String.Format(Conversation.sLine400, tempNPC)); }
                                        if (npcBehavior == 6)
                                        { Console.WriteLine(String.Format(Conversation.sLine401, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 7)
                                        { Console.WriteLine(String.Format(Conversation.sLine402, tempNPC, sGenderHeShe)); }
                                        if (npcBehavior == 8)
                                        { Console.WriteLine(String.Format(Conversation.sLine403, tempNPC, sGenderHeShe)); }
                                        if (npcBehavior == 9)
                                        { Console.WriteLine(String.Format(Conversation.sLine404, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 10)
                                        { Console.WriteLine(String.Format(Conversation.sLine405, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 11)
                                        { Console.WriteLine(String.Format(Conversation.sLine406, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 12)
                                        { Console.WriteLine(String.Format(Conversation.sLine407, tempNPC)); }
                                        if (npcBehavior == 13)
                                        { Console.WriteLine(String.Format(Conversation.sLine408, tempNPC)); }
                                        if (npcBehavior == 14)
                                        { Console.WriteLine(String.Format(Conversation.sLine409, tempNPC, sGenderHeShe, sGenderHimHer)); }
                                        if (npcBehavior == 15)
                                        { Console.WriteLine(String.Format(Conversation.sLine410, tempNPC)); }
                                        if (npcBehavior == 16)
                                        { Console.WriteLine(String.Format(Conversation.sLine411, tempNPC)); }
                                        if (npcBehavior == 17)
                                        { Console.WriteLine(String.Format(Conversation.sLine412, tempNPC)); }
                                        if (npcBehavior == 18)
                                        { Console.WriteLine(String.Format(Conversation.sLine413, tempNPC)); }
                                        if (npcBehavior == 19)
                                        { Console.WriteLine(String.Format(Conversation.sLine414, tempNPC)); }
                                        if (npcBehavior == 20)
                                        { Console.WriteLine(String.Format(Conversation.sLine415, tempNPC)); }
                                        if (npcBehavior == 21)
                                        { Console.WriteLine(String.Format(Conversation.sLine416, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 22)
                                        { Console.WriteLine(String.Format(Conversation.sLine417, tempNPC)); }
                                        if (npcBehavior == 23)
                                        { Console.WriteLine(String.Format(Conversation.sLine418, tempNPC)); }
                                        if (npcBehavior == 24)
                                        { Console.WriteLine(String.Format(Conversation.sLine419, tempNPC)); }
                                    }
                                    else if (Variables.iRemainingTurns <= Variables.iTurn30 && Variables.iRemainingTurns > Variables.iTurn55) // 100-017 minutes remaining
                                    {
                                        npcBehavior = Program.rand.Next(1, 29);
                                        if (npcBehavior == 1)
                                        { Console.WriteLine(String.Format(Conversation.sLine001, tempNPC)); }
                                        if (npcBehavior == 2)
                                        { Console.WriteLine(String.Format(Conversation.sLine005, tempNPC)); }
                                        if (npcBehavior == 3)
                                        { Console.WriteLine(String.Format(Conversation.sLine011, tempNPC)); }
                                        if (npcBehavior == 4)
                                        { Console.WriteLine(String.Format(Conversation.sLine013, tempNPC)); }
                                        if (npcBehavior == 5)
                                        { Console.WriteLine(String.Format(Conversation.sLine200, tempNPC)); }
                                        if (npcBehavior == 6)
                                        { Console.WriteLine(String.Format(Conversation.sLine204, tempNPC)); }
                                        if (npcBehavior == 7)
                                        { Console.WriteLine(String.Format(Conversation.sLine218, tempNPC)); }
                                        if (npcBehavior == 8)
                                        { Console.WriteLine(String.Format(Conversation.sLine220, tempNPC)); }
                                        if (npcBehavior == 9)
                                        { Console.WriteLine(String.Format(Conversation.sLine400, tempNPC)); }
                                        if (npcBehavior == 10)
                                        { Console.WriteLine(String.Format(Conversation.sLine401, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 11)
                                        { Console.WriteLine(String.Format(Conversation.sLine402, tempNPC, sGenderHeShe)); }
                                        if (npcBehavior == 12)
                                        { Console.WriteLine(String.Format(Conversation.sLine403, tempNPC, sGenderHeShe)); }
                                        if (npcBehavior == 13)
                                        { Console.WriteLine(String.Format(Conversation.sLine404, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 14)
                                        { Console.WriteLine(String.Format(Conversation.sLine405, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 15)
                                        { Console.WriteLine(String.Format(Conversation.sLine406, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 16)
                                        { Console.WriteLine(String.Format(Conversation.sLine407, tempNPC)); }
                                        if (npcBehavior == 17)
                                        { Console.WriteLine(String.Format(Conversation.sLine408, tempNPC)); }
                                        if (npcBehavior == 18)
                                        { Console.WriteLine(String.Format(Conversation.sLine409, tempNPC, sGenderHeShe, sGenderHimHer)); }
                                        if (npcBehavior == 19)
                                        { Console.WriteLine(String.Format(Conversation.sLine410, tempNPC)); }
                                        if (npcBehavior == 20)
                                        { Console.WriteLine(String.Format(Conversation.sLine411, tempNPC)); }
                                        if (npcBehavior == 21)
                                        { Console.WriteLine(String.Format(Conversation.sLine412, tempNPC)); }
                                        if (npcBehavior == 22)
                                        { Console.WriteLine(String.Format(Conversation.sLine413, tempNPC)); }
                                        if (npcBehavior == 23)
                                        { Console.WriteLine(String.Format(Conversation.sLine414, tempNPC)); }
                                        if (npcBehavior == 24)
                                        { Console.WriteLine(String.Format(Conversation.sLine415, tempNPC)); }
                                        if (npcBehavior == 25)
                                        { Console.WriteLine(String.Format(Conversation.sLine416, tempNPC, sGenderHisHer)); }
                                        if (npcBehavior == 26)
                                        { Console.WriteLine(String.Format(Conversation.sLine417, tempNPC)); }
                                        if (npcBehavior == 27)
                                        { Console.WriteLine(String.Format(Conversation.sLine418, tempNPC)); }
                                        if (npcBehavior == 28)
                                        { Console.WriteLine(String.Format(Conversation.sLine419, tempNPC)); }
                                    }
                                    else if (Variables.iRemainingTurns <= Variables.iTurn55) // 016-000 minutes remaining
                                    {
                                        npcBehavior = Program.rand.Next(1, 7);
                                        if (npcBehavior == 1)
                                        { Console.WriteLine(String.Format(Conversation.sLine600, tempNPC)); }
                                        if (npcBehavior == 2)
                                        { Console.WriteLine(String.Format(Conversation.sLine601, tempNPC)); }
                                        if (npcBehavior == 3)
                                        { Console.WriteLine(String.Format(Conversation.sLine602, tempNPC)); }
                                        if (npcBehavior == 4)
                                        { Console.WriteLine(String.Format(Conversation.sLine603, tempNPC)); }
                                        if (npcBehavior == 5)
                                        { Console.WriteLine(String.Format(Conversation.sLine604, tempNPC)); }
                                        if (npcBehavior == 6)
                                        { Console.WriteLine(String.Format(Conversation.sLine605, tempNPC)); }
                                    }
                                }
                                else if (iRandDesireEmote < iDesireEmote)
                                { Console.WriteLine(tempNPC + " is here."); }
                            }
                        }
                    }
                    if (bTempCorpse == false && iTempLastLocation != iTempLocation) // I am not a corpse, and IF I just moved last turn.
                    {
                        iTempDesireToMove = iDesireBottom; // We just moved, so set DTM to 0 to keep NPCs from moving too much.
                        iTempLastLocation = iTempLocation;
                        if (Variables.iCurrentLocation == iTempLocation) // Only say this if I am where the player is.
                        {
                            if (iTempLoyalty >= 4)
                            {
                                Lists.MyPosse.Add(tempNPC);
                            }
                            Lists.TalkingNPCs.Add(tempNPC);
                            if (!Variables.bAnyoneHere)
                            { Console.WriteLine(); }
                            Variables.bAnyoneHere = true;
                            Console.WriteLine(tempNPC + " arrives from the direction of " + sTempLastLocation);
                            iCloseEncounters++; // increment the number of times I've been around the player.
                            Notebook.bTempNoted = false; // reset their noted value so they can again be caught by the suspicious flag.
                        }
                    }
                }
            }
            if (!Title.bAchievement06)
            {
                if (iTempLoyalty >= 4) { Lists.Popularity.Add(tempNPC); }
            }
        }

        public static void CanIStopShufflingYet()
        {
            Lists.NPCRoster.RemoveAt(NPC_AI.iRandomNPC);
            if (Lists.NPCRoster.Count == 0) // ... Once we've moved through every NPC, shuffling ends, & results are printed.
            {
                NPC_AI.SoWhoAllIsDead();
            }
        }

        public static void SoWhoAllIsDead()
        {
            Lists.TheLocalDead.Sort();

            if (Lists.TheLocalDead.Count > 0)
            {
                Console.WriteLine();
            }

            foreach (string value in Lists.TheLocalDead)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("The dead body of " + value + " is here.");
                tempNPC = value;
                GetAllNPCLocals();
                if (!Notebook.bCorpseSpotted && Variables.iRemainingTurns >= Variables.iTurn50)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Any references to " + value + " are now removed from your notebook.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Notebook.bCorpseSpotted = true;
                    Conversation.SavebCorpseSpotted_tempNPC();
                } 
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void AnyoneHere_NeedShufflerSpace()
        {
            if (
            (Variables.iCurrentLocation == NPC001_CurrentNumLocation && bCorpse001 == false) ||
            (Variables.iCurrentLocation == NPC002_CurrentNumLocation && bCorpse002 == false) ||
            (Variables.iCurrentLocation == NPC003_CurrentNumLocation && bCorpse003 == false) ||
            (Variables.iCurrentLocation == NPC004_CurrentNumLocation && bCorpse004 == false) ||
            (Variables.iCurrentLocation == NPC005_CurrentNumLocation && bCorpse005 == false) ||
            (Variables.iCurrentLocation == NPC006_CurrentNumLocation && bCorpse006 == false) ||
            (Variables.iCurrentLocation == NPC007_CurrentNumLocation && bCorpse007 == false) ||
            (Variables.iCurrentLocation == NPC008_CurrentNumLocation && bCorpse008 == false) ||
            (Variables.iCurrentLocation == NPC009_CurrentNumLocation && bCorpse009 == false) ||
            (Variables.iCurrentLocation == NPC010_CurrentNumLocation && bCorpse010 == false) ||
            (Variables.iCurrentLocation == NPC011_CurrentNumLocation && bCorpse011 == false) ||
            (Variables.iCurrentLocation == NPC012_CurrentNumLocation && bCorpse012 == false) ||
            (Variables.iCurrentLocation == NPC013_CurrentNumLocation && bCorpse013 == false) ||
            (Variables.iCurrentLocation == NPC014_CurrentNumLocation && bCorpse014 == false) ||
            (Variables.iCurrentLocation == NPC015_CurrentNumLocation && bCorpse015 == false) ||
            (Variables.iCurrentLocation == NPC016_CurrentNumLocation && bCorpse016 == false) ||
            (Variables.iCurrentLocation == NPC017_CurrentNumLocation && bCorpse017 == false) ||
            (Variables.iCurrentLocation == NPC018_CurrentNumLocation && bCorpse018 == false) ||
            (Variables.iCurrentLocation == NPC019_CurrentNumLocation && bCorpse019 == false) ||
            (Variables.iCurrentLocation == NPC020_CurrentNumLocation && bCorpse020 == false) ||
            (Variables.iCurrentLocation == NPC021_CurrentNumLocation && bCorpse021 == false) ||
            (Variables.iCurrentLocation == NPC022_CurrentNumLocation && bCorpse022 == false) ||
            (Variables.iCurrentLocation == NPC023_CurrentNumLocation && bCorpse023 == false) ||
            (Variables.iCurrentLocation == NPC024_CurrentNumLocation && bCorpse024 == false) ||
            (Variables.iCurrentLocation == NPC025_CurrentNumLocation && bCorpse025 == false) ||
            (Variables.iCurrentLocation == NPC026_CurrentNumLocation && bCorpse026 == false) ||
            (Variables.iCurrentLocation == NPC027_CurrentNumLocation && bCorpse027 == false) ||
            (Variables.iCurrentLocation == NPC028_CurrentNumLocation && bCorpse028 == false) ||
            (Variables.iCurrentLocation == NPC029_CurrentNumLocation && bCorpse029 == false) ||
            (Variables.iCurrentLocation == NPC030_CurrentNumLocation && bCorpse030 == false) ||
            (Variables.iCurrentLocation == NPC031_CurrentNumLocation && bCorpse031 == false) ||
            (Variables.iCurrentLocation == NPC032_CurrentNumLocation && bCorpse032 == false) ||
            (Variables.iCurrentLocation == NPC033_CurrentNumLocation && bCorpse033 == false) ||
            (Variables.iCurrentLocation == NPC034_CurrentNumLocation && bCorpse034 == false) ||
            (Variables.iCurrentLocation == NPC035_CurrentNumLocation && bCorpse035 == false) ||
            (Variables.iCurrentLocation == NPC036_CurrentNumLocation && bCorpse036 == false) ||
            (Variables.iCurrentLocation == NPC037_CurrentNumLocation && bCorpse037 == false) ||
            (Variables.iCurrentLocation == NPC038_CurrentNumLocation && bCorpse038 == false) ||
            (Variables.iCurrentLocation == NPC039_CurrentNumLocation && bCorpse039 == false) ||
            (Variables.iCurrentLocation == NPC040_CurrentNumLocation && bCorpse040 == false) ||
            (Variables.iCurrentLocation == NPC041_CurrentNumLocation && bCorpse041 == false) ||
            (Variables.iCurrentLocation == NPC042_CurrentNumLocation && bCorpse042 == false) ||
            (Variables.iCurrentLocation == NPC043_CurrentNumLocation && bCorpse043 == false) ||
            (Variables.iCurrentLocation == NPC044_CurrentNumLocation && bCorpse044 == false) ||
            (Variables.iCurrentLocation == NPC045_CurrentNumLocation && bCorpse045 == false) ||
            (Variables.iCurrentLocation == NPC046_CurrentNumLocation && bCorpse046 == false) ||
            (Variables.iCurrentLocation == NPC047_CurrentNumLocation && bCorpse047 == false) ||
            (Variables.iCurrentLocation == NPC048_CurrentNumLocation && bCorpse048 == false) ||
            (Variables.iCurrentLocation == NPC049_CurrentNumLocation && bCorpse049 == false) ||
            (Variables.iCurrentLocation == NPC050_CurrentNumLocation && bCorpse050 == false) ||
            (Variables.iCurrentLocation == NPC051_CurrentNumLocation && bCorpse051 == false) ||
            (Variables.iCurrentLocation == NPC052_CurrentNumLocation && bCorpse052 == false) ||
            (Variables.iCurrentLocation == NPC053_CurrentNumLocation && bCorpse053 == false) ||
            (Variables.iCurrentLocation == NPC054_CurrentNumLocation && bCorpse054 == false) ||
            (Variables.iCurrentLocation == NPC055_CurrentNumLocation && bCorpse055 == false) ||
            (Variables.iCurrentLocation == NPC056_CurrentNumLocation && bCorpse056 == false) ||
            (Variables.iCurrentLocation == NPC057_CurrentNumLocation && bCorpse057 == false) ||
            (Variables.iCurrentLocation == NPC058_CurrentNumLocation && bCorpse058 == false) ||
            (Variables.iCurrentLocation == NPC059_CurrentNumLocation && bCorpse059 == false) ||
            (Variables.iCurrentLocation == NPC060_CurrentNumLocation && bCorpse060 == false) ||
            (Variables.iCurrentLocation == NPC061_CurrentNumLocation && bCorpse061 == false) ||
            (Variables.iCurrentLocation == NPC062_CurrentNumLocation && bCorpse062 == false) ||
            (Variables.iCurrentLocation == NPC063_CurrentNumLocation && bCorpse063 == false) ||
            (Variables.iCurrentLocation == NPC064_CurrentNumLocation && bCorpse064 == false) ||
            (Variables.iCurrentLocation == NPC065_CurrentNumLocation && bCorpse065 == false) ||
            (Variables.iCurrentLocation == NPC066_CurrentNumLocation && bCorpse066 == false) ||
            (Variables.iCurrentLocation == NPC067_CurrentNumLocation && bCorpse067 == false) ||
            (Variables.iCurrentLocation == NPC068_CurrentNumLocation && bCorpse068 == false) ||
            (Variables.iCurrentLocation == NPC069_CurrentNumLocation && bCorpse069 == false) ||
            (Variables.iCurrentLocation == NPC070_CurrentNumLocation && bCorpse070 == false) ||
            (Variables.iCurrentLocation == NPC071_CurrentNumLocation && bCorpse071 == false) ||
            (Variables.iCurrentLocation == NPC072_CurrentNumLocation && bCorpse072 == false) ||
            (Variables.iCurrentLocation == NPC073_CurrentNumLocation && bCorpse073 == false) ||
            (Variables.iCurrentLocation == NPC074_CurrentNumLocation && bCorpse074 == false) ||
            (Variables.iCurrentLocation == NPC075_CurrentNumLocation && bCorpse075 == false) ||
            (Variables.iCurrentLocation == NPC076_CurrentNumLocation && bCorpse076 == false) ||
            (Variables.iCurrentLocation == NPC077_CurrentNumLocation && bCorpse077 == false) ||
            (Variables.iCurrentLocation == NPC078_CurrentNumLocation && bCorpse078 == false) ||
            (Variables.iCurrentLocation == NPC079_CurrentNumLocation && bCorpse079 == false) ||
            (Variables.iCurrentLocation == NPC080_CurrentNumLocation && bCorpse080 == false) ||
            (Variables.iCurrentLocation == NPC081_CurrentNumLocation && bCorpse081 == false) ||
            (Variables.iCurrentLocation == NPC082_CurrentNumLocation && bCorpse082 == false) ||
            (Variables.iCurrentLocation == NPC083_CurrentNumLocation && bCorpse083 == false) ||
            (Variables.iCurrentLocation == NPC084_CurrentNumLocation && bCorpse084 == false) ||
            (Variables.iCurrentLocation == NPC085_CurrentNumLocation && bCorpse085 == false) ||
            (Variables.iCurrentLocation == NPC086_CurrentNumLocation && bCorpse086 == false) ||
            (Variables.iCurrentLocation == NPC087_CurrentNumLocation && bCorpse087 == false) ||
            (Variables.iCurrentLocation == NPC088_CurrentNumLocation && bCorpse088 == false) ||
            (Variables.iCurrentLocation == NPC089_CurrentNumLocation && bCorpse089 == false) ||
            (Variables.iCurrentLocation == NPC090_CurrentNumLocation && bCorpse090 == false) ||
            (Variables.iCurrentLocation == NPC091_CurrentNumLocation && bCorpse091 == false) ||
            (Variables.iCurrentLocation == NPC092_CurrentNumLocation && bCorpse092 == false) ||
            (Variables.iCurrentLocation == NPC093_CurrentNumLocation && bCorpse093 == false) ||
            (Variables.iCurrentLocation == NPC094_CurrentNumLocation && bCorpse094 == false) ||
            (Variables.iCurrentLocation == NPC095_CurrentNumLocation && bCorpse095 == false) ||
            (Variables.iCurrentLocation == NPC096_CurrentNumLocation && bCorpse096 == false) ||
            (Variables.iCurrentLocation == NPC097_CurrentNumLocation && bCorpse097 == false) ||
            (Variables.iCurrentLocation == NPC098_CurrentNumLocation && bCorpse098 == false) ||
            (Variables.iCurrentLocation == NPC099_CurrentNumLocation && bCorpse099 == false) ||
            (Variables.iCurrentLocation == NPC100_CurrentNumLocation && bCorpse100 == false) || // Of course, if the killer is dead it's already game over.
            (RandomEncounters.bMyBestFriend))
            {
                Console.WriteLine();
                Variables.bAnyoneHere = true;
            }
        }

        public static void IsAnyoneHere()
        {
            // Is anyone here check
            Variables.bAnyoneHere = false;

            if (
            (Variables.iCurrentLocation == NPC001_CurrentNumLocation && bCorpse001 == false) || 
            (Variables.iCurrentLocation == NPC002_CurrentNumLocation && bCorpse002 == false) || 
            (Variables.iCurrentLocation == NPC003_CurrentNumLocation && bCorpse003 == false) ||
            (Variables.iCurrentLocation == NPC004_CurrentNumLocation && bCorpse004 == false) || 
            (Variables.iCurrentLocation == NPC005_CurrentNumLocation && bCorpse005 == false) || 
            (Variables.iCurrentLocation == NPC006_CurrentNumLocation && bCorpse006 == false) ||
            (Variables.iCurrentLocation == NPC007_CurrentNumLocation && bCorpse007 == false) || 
            (Variables.iCurrentLocation == NPC008_CurrentNumLocation && bCorpse008 == false) || 
            (Variables.iCurrentLocation == NPC009_CurrentNumLocation && bCorpse009 == false) ||
            (Variables.iCurrentLocation == NPC010_CurrentNumLocation && bCorpse010 == false) || 
            (Variables.iCurrentLocation == NPC011_CurrentNumLocation && bCorpse011 == false) || 
            (Variables.iCurrentLocation == NPC012_CurrentNumLocation && bCorpse012 == false) ||
            (Variables.iCurrentLocation == NPC013_CurrentNumLocation && bCorpse013 == false) || 
            (Variables.iCurrentLocation == NPC014_CurrentNumLocation && bCorpse014 == false) ||
            (Variables.iCurrentLocation == NPC015_CurrentNumLocation && bCorpse015 == false) ||
            (Variables.iCurrentLocation == NPC016_CurrentNumLocation && bCorpse016 == false) ||
            (Variables.iCurrentLocation == NPC017_CurrentNumLocation && bCorpse017 == false) ||
            (Variables.iCurrentLocation == NPC018_CurrentNumLocation && bCorpse018 == false) ||
            (Variables.iCurrentLocation == NPC019_CurrentNumLocation && bCorpse019 == false) || 
            (Variables.iCurrentLocation == NPC020_CurrentNumLocation && bCorpse020 == false) || 
            (Variables.iCurrentLocation == NPC021_CurrentNumLocation && bCorpse021 == false) ||
            (Variables.iCurrentLocation == NPC022_CurrentNumLocation && bCorpse022 == false) || 
            (Variables.iCurrentLocation == NPC023_CurrentNumLocation && bCorpse023 == false) || 
            (Variables.iCurrentLocation == NPC024_CurrentNumLocation && bCorpse024 == false) ||
            (Variables.iCurrentLocation == NPC025_CurrentNumLocation && bCorpse025 == false) ||
            (Variables.iCurrentLocation == NPC026_CurrentNumLocation && bCorpse026 == false) ||
            (Variables.iCurrentLocation == NPC027_CurrentNumLocation && bCorpse027 == false) ||
            (Variables.iCurrentLocation == NPC028_CurrentNumLocation && bCorpse028 == false) ||
            (Variables.iCurrentLocation == NPC029_CurrentNumLocation && bCorpse029 == false) || 
            (Variables.iCurrentLocation == NPC030_CurrentNumLocation && bCorpse030 == false) ||
            (Variables.iCurrentLocation == NPC031_CurrentNumLocation && bCorpse031 == false) || 
            (Variables.iCurrentLocation == NPC032_CurrentNumLocation && bCorpse032 == false) || 
            (Variables.iCurrentLocation == NPC033_CurrentNumLocation && bCorpse033 == false) ||
            (Variables.iCurrentLocation == NPC034_CurrentNumLocation && bCorpse034 == false) ||
            (Variables.iCurrentLocation == NPC035_CurrentNumLocation && bCorpse035 == false) ||
            (Variables.iCurrentLocation == NPC036_CurrentNumLocation && bCorpse036 == false) ||
            (Variables.iCurrentLocation == NPC037_CurrentNumLocation && bCorpse037 == false) || 
            (Variables.iCurrentLocation == NPC038_CurrentNumLocation && bCorpse038 == false) || 
            (Variables.iCurrentLocation == NPC039_CurrentNumLocation && bCorpse039 == false) ||
            (Variables.iCurrentLocation == NPC040_CurrentNumLocation && bCorpse040 == false) ||
            (Variables.iCurrentLocation == NPC041_CurrentNumLocation && bCorpse041 == false) ||
            (Variables.iCurrentLocation == NPC042_CurrentNumLocation && bCorpse042 == false) ||
            (Variables.iCurrentLocation == NPC043_CurrentNumLocation && bCorpse043 == false) || 
            (Variables.iCurrentLocation == NPC044_CurrentNumLocation && bCorpse044 == false) || 
            (Variables.iCurrentLocation == NPC045_CurrentNumLocation && bCorpse045 == false) ||
            (Variables.iCurrentLocation == NPC046_CurrentNumLocation && bCorpse046 == false) || 
            (Variables.iCurrentLocation == NPC047_CurrentNumLocation && bCorpse047 == false) || 
            (Variables.iCurrentLocation == NPC048_CurrentNumLocation && bCorpse048 == false) ||
            (Variables.iCurrentLocation == NPC049_CurrentNumLocation && bCorpse049 == false) || 
            (Variables.iCurrentLocation == NPC050_CurrentNumLocation && bCorpse050 == false) || 
            (Variables.iCurrentLocation == NPC051_CurrentNumLocation && bCorpse051 == false) ||
            (Variables.iCurrentLocation == NPC052_CurrentNumLocation && bCorpse052 == false) || 
            (Variables.iCurrentLocation == NPC053_CurrentNumLocation && bCorpse053 == false) ||
            (Variables.iCurrentLocation == NPC054_CurrentNumLocation && bCorpse054 == false) ||
            (Variables.iCurrentLocation == NPC055_CurrentNumLocation && bCorpse055 == false) ||
            (Variables.iCurrentLocation == NPC056_CurrentNumLocation && bCorpse056 == false) || 
            (Variables.iCurrentLocation == NPC057_CurrentNumLocation && bCorpse057 == false) ||
            (Variables.iCurrentLocation == NPC058_CurrentNumLocation && bCorpse058 == false) || 
            (Variables.iCurrentLocation == NPC059_CurrentNumLocation && bCorpse059 == false) || 
            (Variables.iCurrentLocation == NPC060_CurrentNumLocation && bCorpse060 == false) ||
            (Variables.iCurrentLocation == NPC061_CurrentNumLocation && bCorpse061 == false) ||
            (Variables.iCurrentLocation == NPC062_CurrentNumLocation && bCorpse062 == false) || 
            (Variables.iCurrentLocation == NPC063_CurrentNumLocation && bCorpse063 == false) ||
            (Variables.iCurrentLocation == NPC064_CurrentNumLocation && bCorpse064 == false) || 
            (Variables.iCurrentLocation == NPC065_CurrentNumLocation && bCorpse065 == false) || 
            (Variables.iCurrentLocation == NPC066_CurrentNumLocation && bCorpse066 == false) ||
            (Variables.iCurrentLocation == NPC067_CurrentNumLocation && bCorpse067 == false) || 
            (Variables.iCurrentLocation == NPC068_CurrentNumLocation && bCorpse068 == false) || 
            (Variables.iCurrentLocation == NPC069_CurrentNumLocation && bCorpse069 == false) ||
            (Variables.iCurrentLocation == NPC070_CurrentNumLocation && bCorpse070 == false) || 
            (Variables.iCurrentLocation == NPC071_CurrentNumLocation && bCorpse071 == false) || 
            (Variables.iCurrentLocation == NPC072_CurrentNumLocation && bCorpse072 == false) ||
            (Variables.iCurrentLocation == NPC073_CurrentNumLocation && bCorpse073 == false) || 
            (Variables.iCurrentLocation == NPC074_CurrentNumLocation && bCorpse074 == false) || 
            (Variables.iCurrentLocation == NPC075_CurrentNumLocation && bCorpse075 == false) ||
            (Variables.iCurrentLocation == NPC076_CurrentNumLocation && bCorpse076 == false) ||
            (Variables.iCurrentLocation == NPC077_CurrentNumLocation && bCorpse077 == false) || 
            (Variables.iCurrentLocation == NPC078_CurrentNumLocation && bCorpse078 == false) ||
            (Variables.iCurrentLocation == NPC079_CurrentNumLocation && bCorpse079 == false) ||
            (Variables.iCurrentLocation == NPC080_CurrentNumLocation && bCorpse080 == false) || 
            (Variables.iCurrentLocation == NPC081_CurrentNumLocation && bCorpse081 == false) ||
            (Variables.iCurrentLocation == NPC082_CurrentNumLocation && bCorpse082 == false) || 
            (Variables.iCurrentLocation == NPC083_CurrentNumLocation && bCorpse083 == false) || 
            (Variables.iCurrentLocation == NPC084_CurrentNumLocation && bCorpse084 == false) ||
            (Variables.iCurrentLocation == NPC085_CurrentNumLocation && bCorpse085 == false) || 
            (Variables.iCurrentLocation == NPC086_CurrentNumLocation && bCorpse086 == false) || 
            (Variables.iCurrentLocation == NPC087_CurrentNumLocation && bCorpse087 == false) ||
            (Variables.iCurrentLocation == NPC088_CurrentNumLocation && bCorpse088 == false) || 
            (Variables.iCurrentLocation == NPC089_CurrentNumLocation && bCorpse089 == false) || 
            (Variables.iCurrentLocation == NPC090_CurrentNumLocation && bCorpse090 == false) ||
            (Variables.iCurrentLocation == NPC091_CurrentNumLocation && bCorpse091 == false) || 
            (Variables.iCurrentLocation == NPC092_CurrentNumLocation && bCorpse092 == false) || 
            (Variables.iCurrentLocation == NPC093_CurrentNumLocation && bCorpse093 == false) ||
            (Variables.iCurrentLocation == NPC094_CurrentNumLocation && bCorpse094 == false) || 
            (Variables.iCurrentLocation == NPC095_CurrentNumLocation && bCorpse095 == false) || 
            (Variables.iCurrentLocation == NPC096_CurrentNumLocation && bCorpse096 == false) ||
            (Variables.iCurrentLocation == NPC097_CurrentNumLocation && bCorpse097 == false) || 
            (Variables.iCurrentLocation == NPC098_CurrentNumLocation && bCorpse098 == false) || 
            (Variables.iCurrentLocation == NPC099_CurrentNumLocation && bCorpse099 == false) ||
            (Variables.iCurrentLocation == NPC100_CurrentNumLocation && bCorpse100 == false))
            {
                Variables.bAnyoneHere = true;
            }
            else
            {
                Variables.bAnyoneHere = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("There is no one here at the moment.");
            }
        }

        public static void Reset_iLoyalty()
        {
            if (iLoyalty001 > iLoyaltyCap) { iLoyalty001 = iLoyaltyCap; } if (iLoyalty002 > iLoyaltyCap) { iLoyalty002 = iLoyaltyCap; } if (iLoyalty003 > iLoyaltyCap) { iLoyalty003 = iLoyaltyCap; }
            if (iLoyalty004 > iLoyaltyCap) { iLoyalty004 = iLoyaltyCap; } if (iLoyalty005 > iLoyaltyCap) { iLoyalty005 = iLoyaltyCap; } if (iLoyalty006 > iLoyaltyCap) { iLoyalty006 = iLoyaltyCap; }
            if (iLoyalty007 > iLoyaltyCap) { iLoyalty007 = iLoyaltyCap; } if (iLoyalty008 > iLoyaltyCap) { iLoyalty008 = iLoyaltyCap; } if (iLoyalty009 > iLoyaltyCap) { iLoyalty009 = iLoyaltyCap; }
            if (iLoyalty010 > iLoyaltyCap) { iLoyalty010 = iLoyaltyCap; } if (iLoyalty011 > iLoyaltyCap) { iLoyalty011 = iLoyaltyCap; } if (iLoyalty012 > iLoyaltyCap) { iLoyalty012 = iLoyaltyCap; }
            if (iLoyalty013 > iLoyaltyCap) { iLoyalty013 = iLoyaltyCap; } if (iLoyalty014 > iLoyaltyCap) { iLoyalty014 = iLoyaltyCap; } if (iLoyalty015 > iLoyaltyCap) { iLoyalty015 = iLoyaltyCap; }
            if (iLoyalty016 > iLoyaltyCap) { iLoyalty016 = iLoyaltyCap; } if (iLoyalty017 > iLoyaltyCap) { iLoyalty017 = iLoyaltyCap; } if (iLoyalty018 > iLoyaltyCap) { iLoyalty018 = iLoyaltyCap; }
            if (iLoyalty019 > iLoyaltyCap) { iLoyalty019 = iLoyaltyCap; } if (iLoyalty020 > iLoyaltyCap) { iLoyalty020 = iLoyaltyCap; } if (iLoyalty021 > iLoyaltyCap) { iLoyalty021 = iLoyaltyCap; }
            if (iLoyalty022 > iLoyaltyCap) { iLoyalty022 = iLoyaltyCap; } if (iLoyalty023 > iLoyaltyCap) { iLoyalty023 = iLoyaltyCap; } if (iLoyalty024 > iLoyaltyCap) { iLoyalty024 = iLoyaltyCap; }
            if (iLoyalty025 > iLoyaltyCap) { iLoyalty025 = iLoyaltyCap; } if (iLoyalty026 > iLoyaltyCap) { iLoyalty026 = iLoyaltyCap; } if (iLoyalty027 > iLoyaltyCap) { iLoyalty027 = iLoyaltyCap; }
            if (iLoyalty028 > iLoyaltyCap) { iLoyalty028 = iLoyaltyCap; } if (iLoyalty029 > iLoyaltyCap) { iLoyalty029 = iLoyaltyCap; } if (iLoyalty030 > iLoyaltyCap) { iLoyalty030 = iLoyaltyCap; }
            if (iLoyalty031 > iLoyaltyCap) { iLoyalty031 = iLoyaltyCap; } if (iLoyalty032 > iLoyaltyCap) { iLoyalty032 = iLoyaltyCap; } if (iLoyalty033 > iLoyaltyCap) { iLoyalty033 = iLoyaltyCap; }
            if (iLoyalty034 > iLoyaltyCap) { iLoyalty034 = iLoyaltyCap; } if (iLoyalty035 > iLoyaltyCap) { iLoyalty035 = iLoyaltyCap; } if (iLoyalty036 > iLoyaltyCap) { iLoyalty036 = iLoyaltyCap; }
            if (iLoyalty037 > iLoyaltyCap) { iLoyalty037 = iLoyaltyCap; } if (iLoyalty038 > iLoyaltyCap) { iLoyalty038 = iLoyaltyCap; } if (iLoyalty039 > iLoyaltyCap) { iLoyalty039 = iLoyaltyCap; }
            if (iLoyalty040 > iLoyaltyCap) { iLoyalty040 = iLoyaltyCap; } if (iLoyalty041 > iLoyaltyCap) { iLoyalty041 = iLoyaltyCap; } if (iLoyalty042 > iLoyaltyCap) { iLoyalty042 = iLoyaltyCap; }
            if (iLoyalty043 > iLoyaltyCap) { iLoyalty043 = iLoyaltyCap; } if (iLoyalty044 > iLoyaltyCap) { iLoyalty044 = iLoyaltyCap; } if (iLoyalty045 > iLoyaltyCap) { iLoyalty045 = iLoyaltyCap; }
            if (iLoyalty046 > iLoyaltyCap) { iLoyalty046 = iLoyaltyCap; } if (iLoyalty047 > iLoyaltyCap) { iLoyalty047 = iLoyaltyCap; } if (iLoyalty048 > iLoyaltyCap) { iLoyalty048 = iLoyaltyCap; }
            if (iLoyalty049 > iLoyaltyCap) { iLoyalty049 = iLoyaltyCap; } if (iLoyalty050 > iLoyaltyCap) { iLoyalty050 = iLoyaltyCap; } if (iLoyalty051 > iLoyaltyCap) { iLoyalty051 = iLoyaltyCap; }
            if (iLoyalty052 > iLoyaltyCap) { iLoyalty052 = iLoyaltyCap; } if (iLoyalty053 > iLoyaltyCap) { iLoyalty053 = iLoyaltyCap; } if (iLoyalty054 > iLoyaltyCap) { iLoyalty054 = iLoyaltyCap; }
            if (iLoyalty055 > iLoyaltyCap) { iLoyalty055 = iLoyaltyCap; } if (iLoyalty056 > iLoyaltyCap) { iLoyalty056 = iLoyaltyCap; } if (iLoyalty057 > iLoyaltyCap) { iLoyalty057 = iLoyaltyCap; }
            if (iLoyalty058 > iLoyaltyCap) { iLoyalty058 = iLoyaltyCap; } if (iLoyalty059 > iLoyaltyCap) { iLoyalty059 = iLoyaltyCap; } if (iLoyalty060 > iLoyaltyCap) { iLoyalty060 = iLoyaltyCap; }
            if (iLoyalty061 > iLoyaltyCap) { iLoyalty061 = iLoyaltyCap; } if (iLoyalty062 > iLoyaltyCap) { iLoyalty062 = iLoyaltyCap; } if (iLoyalty063 > iLoyaltyCap) { iLoyalty063 = iLoyaltyCap; }
            if (iLoyalty064 > iLoyaltyCap) { iLoyalty064 = iLoyaltyCap; } if (iLoyalty065 > iLoyaltyCap) { iLoyalty065 = iLoyaltyCap; } if (iLoyalty066 > iLoyaltyCap) { iLoyalty066 = iLoyaltyCap; }
            if (iLoyalty067 > iLoyaltyCap) { iLoyalty067 = iLoyaltyCap; } if (iLoyalty068 > iLoyaltyCap) { iLoyalty068 = iLoyaltyCap; } if (iLoyalty069 > iLoyaltyCap) { iLoyalty069 = iLoyaltyCap; }
            if (iLoyalty070 > iLoyaltyCap) { iLoyalty070 = iLoyaltyCap; } if (iLoyalty071 > iLoyaltyCap) { iLoyalty071 = iLoyaltyCap; } if (iLoyalty072 > iLoyaltyCap) { iLoyalty072 = iLoyaltyCap; }
            if (iLoyalty073 > iLoyaltyCap) { iLoyalty073 = iLoyaltyCap; } if (iLoyalty074 > iLoyaltyCap) { iLoyalty074 = iLoyaltyCap; } if (iLoyalty075 > iLoyaltyCap) { iLoyalty075 = iLoyaltyCap; }
            if (iLoyalty076 > iLoyaltyCap) { iLoyalty076 = iLoyaltyCap; } if (iLoyalty077 > iLoyaltyCap) { iLoyalty077 = iLoyaltyCap; } if (iLoyalty078 > iLoyaltyCap) { iLoyalty078 = iLoyaltyCap; }
            if (iLoyalty079 > iLoyaltyCap) { iLoyalty079 = iLoyaltyCap; } if (iLoyalty080 > iLoyaltyCap) { iLoyalty080 = iLoyaltyCap; } if (iLoyalty081 > iLoyaltyCap) { iLoyalty081 = iLoyaltyCap; }
            if (iLoyalty082 > iLoyaltyCap) { iLoyalty082 = iLoyaltyCap; } if (iLoyalty083 > iLoyaltyCap) { iLoyalty083 = iLoyaltyCap; } if (iLoyalty084 > iLoyaltyCap) { iLoyalty084 = iLoyaltyCap; }
            if (iLoyalty085 > iLoyaltyCap) { iLoyalty085 = iLoyaltyCap; } if (iLoyalty086 > iLoyaltyCap) { iLoyalty086 = iLoyaltyCap; } if (iLoyalty087 > iLoyaltyCap) { iLoyalty087 = iLoyaltyCap; }
            if (iLoyalty088 > iLoyaltyCap) { iLoyalty088 = iLoyaltyCap; } if (iLoyalty089 > iLoyaltyCap) { iLoyalty089 = iLoyaltyCap; } if (iLoyalty090 > iLoyaltyCap) { iLoyalty090 = iLoyaltyCap; }
            if (iLoyalty091 > iLoyaltyCap) { iLoyalty091 = iLoyaltyCap; } if (iLoyalty092 > iLoyaltyCap) { iLoyalty092 = iLoyaltyCap; } if (iLoyalty093 > iLoyaltyCap) { iLoyalty093 = iLoyaltyCap; }
            if (iLoyalty094 > iLoyaltyCap) { iLoyalty094 = iLoyaltyCap; } if (iLoyalty095 > iLoyaltyCap) { iLoyalty095 = iLoyaltyCap; } if (iLoyalty096 > iLoyaltyCap) { iLoyalty096 = iLoyaltyCap; }
            if (iLoyalty097 > iLoyaltyCap) { iLoyalty097 = iLoyaltyCap; } if (iLoyalty098 > iLoyaltyCap) { iLoyalty098 = iLoyaltyCap; } if (iLoyalty099 > iLoyaltyCap) { iLoyalty099 = iLoyaltyCap; }
            if (iLoyalty100 > iLoyaltyCap) { iLoyalty100 = iLoyaltyCap; }
        }

        public static void GetDisposition()
        {
            if (iTempLoyalty == -1) { sTempLoyalty = "Afraid"; }
            if (iTempLoyalty == 0) { sTempLoyalty = "Suspicious"; }
            if (iTempLoyalty == 1) { sTempLoyalty = "Wary"; }
            if (iTempLoyalty == 2) { sTempLoyalty = "Indifferent"; }
            if (iTempLoyalty == 3) { sTempLoyalty = "Pleasant"; }
            if (iTempLoyalty == 4) { sTempLoyalty = "Agreeable"; }
            if (iTempLoyalty == 5) { sTempLoyalty = "Friendly"; }
        }
    }
}