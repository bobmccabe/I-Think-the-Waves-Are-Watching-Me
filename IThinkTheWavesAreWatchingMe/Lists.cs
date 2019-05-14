using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
// using System.Threading;

namespace IThinkTheWavesAreWatchingMe
{
    class Lists
    {
        public static List<string> NPCRoster = new List<string>(); // All NPCs who are in the game.
        public static List<string> TheLocalDead = new List<string>(); // People who are dead and where the player is.
        public static List<string> TheGlobalDead = new List<string>(); // List comprised of all dead NPCs.
        public static List<string> MyBestiesDeadSibling = new List<string>();
        public static List<string> TheSuspiciousBunch = new List<string>(); // People who are suspicious and where the player is.
        public static List<string> BulletRiddled = new List<string>(); // People who are actively being trageted by a shotgun.
        public static List<string> TalkingNPCs = new List<string>(); // People who are where the player is and can talk.
        public static List<string> MyPosse = new List<string>(); // People who are loyal (4, 5) to the player and also where the player is.
        public static List<string> RemainingNPCs = new List<string>(); // People who are still alive.
        public static List<string> TheDrowned = new List<string>(); // People who drowned? May not use.
        public static List<string> TierOneTraits = new List<string>(); // When querying about a trait, randomize name(s) from this list.
        public static List<string> TierTwoTraits = new List<string>(); // When querying about a trait, randomize name(s) from this list.
        public static List<string> TierThreeTraits = new List<string>(); // When querying about a trait, randomize name(s) from this list.
        public static List<string> DebugSomeoneMoved = new List<string>(); // DEBUG test to capture if people moved, to ensure shuffler is accurate
        public static List<string> Popularity = new List<string>();
        // public static List<string> TheScoringDead = new List<string>(); // Because RemainingNPCs isn't working and I cannot figure out why.

        public static List<string> npcNameOptions = new List<string>
        {
            "Aaron", "Alexander", "Alexis", "Allison", "Amanda",
            "Amy", "Andrea", "Andrew", "Angela", "Anthony",
            "Ashley", "Austin", "Ava", "Barbara", "Benjamin",
            "Betty", "Brandon", "Brittany", "Carlos", "Carol",
            "Carter", "Charles", "Charlotte", "Christopher", "Daniel",
            "David", "Debra", "Dominic", "Donna", "Dorothy", 
            "Dylan", "Elijah", "Ellie", "Emma", "Ethan", 
            "Eva", "Evan", "Hannah", "Heather", "Helen",
            "Henry", "Isaac", "Isabella", "Isaiah", "Jackson",
            "Jacob", "James", "Jason", "Jennifer", "Jessica",
            "Joan", "Jonathan", "Joshua", "Judith", "Julian",
            "Julie", "Justin", "Karen", "Kevin", "Kimberly",
            "Leah", "Liam", "Lillian", "Linda", "Lisa",
            "Logan", "Lucas", "Luke", "Madison", "Margaret",
            "Mary", "Mason", "Matthew", "Melissa", "Mia",
            "Michael", "Michelle", "Morgan", "Nathan", "Nicholas",
            "Noah", "Olivia", "Owen", "Patricia", "Richard", 
            "Robert", "Ruth", "Ryan", "Samantha", "Samuel",
            "Sandra", "Sarah", "Sebastian", "Shirley", "Sophia",
            "Susan", "Tyler", "William", "Wyatt", "Zachary"
        };

        public static void Initialize_Lists()
        {
            // This should populate the remainingNPCs list with everyone on the NPC Roster list.
            // RemainingNPCs.Clear();
            PopulateNPCRoster();
            // Console.WriteLine("NPCRoster Count is: " + NPCRoster.Count);

            //foreach (string n in Lists.NPCRoster)
            //{
            //    Console.WriteLine(n);
            //}

            //int iTwoMilliseconds = 2000;
            //Thread.Sleep(iTwoMilliseconds);

            while (NPCRoster.Count > 0)
            {
                int iAlive = Program.rand.Next(NPCRoster.Count);
                string sAlive = NPCRoster[iAlive];
                RemainingNPCs.Add(sAlive);
                NPCRoster.RemoveAt(iAlive);
                // Now just remove any dead NPCs from the list when they die.
                RemainingNPCs.Remove(NPC_AI.NPC_100);
            }
            PopulateNPCRoster();
            // Program.PressAnyKey();
        }

        public static void Update_Lists()
        {
            // PopulateNPCRoster();

            //if (NPC_AI.bCorpse001)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_001); }
            //if (NPC_AI.bCorpse002)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_002); }
            //if (NPC_AI.bCorpse003)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_003); }
            //if (NPC_AI.bCorpse004)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_004); }
            //if (NPC_AI.bCorpse005)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_005); }
            //if (NPC_AI.bCorpse006)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_006); }
            //if (NPC_AI.bCorpse007)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_007); }
            //if (NPC_AI.bCorpse008)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_008); }
            //if (NPC_AI.bCorpse009)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_009); }
            //if (NPC_AI.bCorpse010)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_010); }
            //if (NPC_AI.bCorpse011)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_011); }
            //if (NPC_AI.bCorpse012)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_012); }
            //if (NPC_AI.bCorpse013)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_013); }
            //if (NPC_AI.bCorpse014)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_014); }
            //if (NPC_AI.bCorpse015)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_015); }
            //if (NPC_AI.bCorpse016)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_016); }
            //if (NPC_AI.bCorpse017)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_017); }
            //if (NPC_AI.bCorpse018)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_018); }
            //if (NPC_AI.bCorpse019)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_019); }
            //if (NPC_AI.bCorpse020)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_020); }
            //if (NPC_AI.bCorpse021)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_021); }
            //if (NPC_AI.bCorpse022)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_022); }
            //if (NPC_AI.bCorpse023)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_023); }
            //if (NPC_AI.bCorpse024)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_024); }
            //if (NPC_AI.bCorpse025)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_025); }
            //if (NPC_AI.bCorpse026)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_026); }
            //if (NPC_AI.bCorpse027)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_027); }
            //if (NPC_AI.bCorpse028)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_028); }
            //if (NPC_AI.bCorpse029)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_029); }
            //if (NPC_AI.bCorpse030)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_030); }
            //if (NPC_AI.bCorpse031)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_031); }
            //if (NPC_AI.bCorpse032)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_032); }
            //if (NPC_AI.bCorpse033)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_033); }
            //if (NPC_AI.bCorpse034)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_034); }
            //if (NPC_AI.bCorpse035)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_035); }
            //if (NPC_AI.bCorpse036)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_036); }
            //if (NPC_AI.bCorpse037)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_037); }
            //if (NPC_AI.bCorpse038)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_038); }
            //if (NPC_AI.bCorpse039)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_039); }
            //if (NPC_AI.bCorpse040)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_040); }
            //if (NPC_AI.bCorpse041)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_041); }
            //if (NPC_AI.bCorpse042)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_042); }
            //if (NPC_AI.bCorpse043)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_043); }
            //if (NPC_AI.bCorpse044)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_044); }
            //if (NPC_AI.bCorpse045)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_045); }
            //if (NPC_AI.bCorpse046)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_046); }
            //if (NPC_AI.bCorpse047)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_047); }
            //if (NPC_AI.bCorpse048)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_048); }
            //if (NPC_AI.bCorpse049)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_049); }
            //if (NPC_AI.bCorpse050)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_050); }
            //if (NPC_AI.bCorpse051)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_051); }
            //if (NPC_AI.bCorpse052)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_052); }
            //if (NPC_AI.bCorpse053)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_053); }
            //if (NPC_AI.bCorpse054)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_054); }
            //if (NPC_AI.bCorpse055)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_055); }
            //if (NPC_AI.bCorpse056)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_056); }
            //if (NPC_AI.bCorpse057)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_057); }
            //if (NPC_AI.bCorpse058)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_058); }
            //if (NPC_AI.bCorpse059)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_059); }
            //if (NPC_AI.bCorpse060)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_060); }
            //if (NPC_AI.bCorpse061)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_061); }
            //if (NPC_AI.bCorpse062)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_062); }
            //if (NPC_AI.bCorpse063)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_063); }
            //if (NPC_AI.bCorpse064)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_064); }
            //if (NPC_AI.bCorpse065)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_065); }
            //if (NPC_AI.bCorpse066)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_066); }
            //if (NPC_AI.bCorpse067)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_067); }
            //if (NPC_AI.bCorpse068)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_068); }
            //if (NPC_AI.bCorpse069)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_069); }
            //if (NPC_AI.bCorpse070)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_070); }
            //if (NPC_AI.bCorpse071)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_071); }
            //if (NPC_AI.bCorpse072)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_072); }
            //if (NPC_AI.bCorpse073)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_073); }
            //if (NPC_AI.bCorpse074)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_074); }
            //if (NPC_AI.bCorpse075)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_075); }
            //if (NPC_AI.bCorpse076)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_076); }
            //if (NPC_AI.bCorpse077)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_077); }
            //if (NPC_AI.bCorpse078)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_078); }
            //if (NPC_AI.bCorpse079)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_079); }
            //if (NPC_AI.bCorpse080)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_080); }
            //if (NPC_AI.bCorpse081)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_081); }
            //if (NPC_AI.bCorpse082)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_082); }
            //if (NPC_AI.bCorpse083)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_083); }
            //if (NPC_AI.bCorpse084)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_084); }
            //if (NPC_AI.bCorpse085)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_085); }
            //if (NPC_AI.bCorpse086)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_086); }
            //if (NPC_AI.bCorpse087)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_087); }
            //if (NPC_AI.bCorpse088)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_088); }
            //if (NPC_AI.bCorpse089)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_089); }
            //if (NPC_AI.bCorpse090)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_090); }
            //if (NPC_AI.bCorpse091)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_091); }
            //if (NPC_AI.bCorpse092)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_092); }
            //if (NPC_AI.bCorpse093)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_093); }
            //if (NPC_AI.bCorpse094)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_094); }
            //if (NPC_AI.bCorpse095)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_095); }
            //if (NPC_AI.bCorpse096)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_096); }
            //if (NPC_AI.bCorpse097)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_097); }
            //if (NPC_AI.bCorpse098)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_098); }
            //if (NPC_AI.bCorpse099)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_099); }
            //if (NPC_AI.bCorpse100)
            //{ RemainingNPCs.Remove(NPC_AI.NPC_100); }
        }

        public static void ResetAllLists()
        {
            npcNameOptions.Clear();
            
            NPCRoster.Clear();
            TheLocalDead.Clear();
            TheGlobalDead.Clear();
            MyBestiesDeadSibling.Clear();
            TheSuspiciousBunch.Clear();
            BulletRiddled.Clear();
            TalkingNPCs.Clear();
            MyPosse.Clear();
            RemainingNPCs.Clear();
            TheDrowned.Clear();
            TierOneTraits.Clear();
            TierTwoTraits.Clear();
            TierThreeTraits.Clear();
            DebugSomeoneMoved.Clear();
            Popularity.Clear();
        }

        public static void ClearMostLists()
        {
            NPCRoster.Clear();
            TheLocalDead.Clear();
            TheSuspiciousBunch.Clear();
            BulletRiddled.Clear();
            TalkingNPCs.Clear();
            MyPosse.Clear();
            TheDrowned.Clear();
            DebugSomeoneMoved.Clear();
            Popularity.Clear();
        }

        public static void PopulateNPCRoster()
        {
            NPCRoster.Clear();
            NPCRoster.Add(NPC_AI.NPC_001); NPCRoster.Add(NPC_AI.NPC_002); NPCRoster.Add(NPC_AI.NPC_003); NPCRoster.Add(NPC_AI.NPC_004); NPCRoster.Add(NPC_AI.NPC_005);
            NPCRoster.Add(NPC_AI.NPC_006); NPCRoster.Add(NPC_AI.NPC_007); NPCRoster.Add(NPC_AI.NPC_008); NPCRoster.Add(NPC_AI.NPC_009); NPCRoster.Add(NPC_AI.NPC_010);
            NPCRoster.Add(NPC_AI.NPC_011); NPCRoster.Add(NPC_AI.NPC_012); NPCRoster.Add(NPC_AI.NPC_013); NPCRoster.Add(NPC_AI.NPC_014); NPCRoster.Add(NPC_AI.NPC_015);
            NPCRoster.Add(NPC_AI.NPC_016); NPCRoster.Add(NPC_AI.NPC_017); NPCRoster.Add(NPC_AI.NPC_018); NPCRoster.Add(NPC_AI.NPC_019); NPCRoster.Add(NPC_AI.NPC_020);
            NPCRoster.Add(NPC_AI.NPC_021); NPCRoster.Add(NPC_AI.NPC_022); NPCRoster.Add(NPC_AI.NPC_023); NPCRoster.Add(NPC_AI.NPC_024); NPCRoster.Add(NPC_AI.NPC_025);
            NPCRoster.Add(NPC_AI.NPC_026); NPCRoster.Add(NPC_AI.NPC_027); NPCRoster.Add(NPC_AI.NPC_028); NPCRoster.Add(NPC_AI.NPC_029); NPCRoster.Add(NPC_AI.NPC_030);
            NPCRoster.Add(NPC_AI.NPC_031); NPCRoster.Add(NPC_AI.NPC_032); NPCRoster.Add(NPC_AI.NPC_033); NPCRoster.Add(NPC_AI.NPC_034); NPCRoster.Add(NPC_AI.NPC_035);
            NPCRoster.Add(NPC_AI.NPC_036); NPCRoster.Add(NPC_AI.NPC_037); NPCRoster.Add(NPC_AI.NPC_038); NPCRoster.Add(NPC_AI.NPC_039); NPCRoster.Add(NPC_AI.NPC_040);
            NPCRoster.Add(NPC_AI.NPC_041); NPCRoster.Add(NPC_AI.NPC_042); NPCRoster.Add(NPC_AI.NPC_043); NPCRoster.Add(NPC_AI.NPC_044); NPCRoster.Add(NPC_AI.NPC_045);
            NPCRoster.Add(NPC_AI.NPC_046); NPCRoster.Add(NPC_AI.NPC_047); NPCRoster.Add(NPC_AI.NPC_048); NPCRoster.Add(NPC_AI.NPC_049); NPCRoster.Add(NPC_AI.NPC_050);
            NPCRoster.Add(NPC_AI.NPC_051); NPCRoster.Add(NPC_AI.NPC_052); NPCRoster.Add(NPC_AI.NPC_053); NPCRoster.Add(NPC_AI.NPC_054); NPCRoster.Add(NPC_AI.NPC_055);
            NPCRoster.Add(NPC_AI.NPC_056); NPCRoster.Add(NPC_AI.NPC_057); NPCRoster.Add(NPC_AI.NPC_058); NPCRoster.Add(NPC_AI.NPC_059); NPCRoster.Add(NPC_AI.NPC_060);
            NPCRoster.Add(NPC_AI.NPC_061); NPCRoster.Add(NPC_AI.NPC_062); NPCRoster.Add(NPC_AI.NPC_063); NPCRoster.Add(NPC_AI.NPC_064); NPCRoster.Add(NPC_AI.NPC_065);
            NPCRoster.Add(NPC_AI.NPC_066); NPCRoster.Add(NPC_AI.NPC_067); NPCRoster.Add(NPC_AI.NPC_068); NPCRoster.Add(NPC_AI.NPC_069); NPCRoster.Add(NPC_AI.NPC_070);
            NPCRoster.Add(NPC_AI.NPC_071); NPCRoster.Add(NPC_AI.NPC_072); NPCRoster.Add(NPC_AI.NPC_073); NPCRoster.Add(NPC_AI.NPC_074); NPCRoster.Add(NPC_AI.NPC_075);
            NPCRoster.Add(NPC_AI.NPC_076); NPCRoster.Add(NPC_AI.NPC_077); NPCRoster.Add(NPC_AI.NPC_078); NPCRoster.Add(NPC_AI.NPC_079); NPCRoster.Add(NPC_AI.NPC_080);
            NPCRoster.Add(NPC_AI.NPC_081); NPCRoster.Add(NPC_AI.NPC_082); NPCRoster.Add(NPC_AI.NPC_083); NPCRoster.Add(NPC_AI.NPC_084); NPCRoster.Add(NPC_AI.NPC_085);
            NPCRoster.Add(NPC_AI.NPC_086); NPCRoster.Add(NPC_AI.NPC_087); NPCRoster.Add(NPC_AI.NPC_088); NPCRoster.Add(NPC_AI.NPC_089); NPCRoster.Add(NPC_AI.NPC_090);
            NPCRoster.Add(NPC_AI.NPC_091); NPCRoster.Add(NPC_AI.NPC_092); NPCRoster.Add(NPC_AI.NPC_093); NPCRoster.Add(NPC_AI.NPC_094); NPCRoster.Add(NPC_AI.NPC_095);
            NPCRoster.Add(NPC_AI.NPC_096); NPCRoster.Add(NPC_AI.NPC_097); NPCRoster.Add(NPC_AI.NPC_098); NPCRoster.Add(NPC_AI.NPC_099); NPCRoster.Add(NPC_AI.NPC_100);
        }

        public static void PopulateTalkingNPCs()
        {
            if (Variables.iCurrentLocation == NPC_AI.NPC001_CurrentNumLocation && NPC_AI.bCorpse001 == false) { TalkingNPCs.Add(NPC_AI.NPC_001); }
            if (Variables.iCurrentLocation == NPC_AI.NPC002_CurrentNumLocation && NPC_AI.bCorpse002 == false) { TalkingNPCs.Add(NPC_AI.NPC_002); }
            if (Variables.iCurrentLocation == NPC_AI.NPC003_CurrentNumLocation && NPC_AI.bCorpse003 == false) { TalkingNPCs.Add(NPC_AI.NPC_003); }
            if (Variables.iCurrentLocation == NPC_AI.NPC004_CurrentNumLocation && NPC_AI.bCorpse004 == false) { TalkingNPCs.Add(NPC_AI.NPC_004); }
            if (Variables.iCurrentLocation == NPC_AI.NPC005_CurrentNumLocation && NPC_AI.bCorpse005 == false) { TalkingNPCs.Add(NPC_AI.NPC_005); }
            if (Variables.iCurrentLocation == NPC_AI.NPC006_CurrentNumLocation && NPC_AI.bCorpse006 == false) { TalkingNPCs.Add(NPC_AI.NPC_006); }
            if (Variables.iCurrentLocation == NPC_AI.NPC007_CurrentNumLocation && NPC_AI.bCorpse007 == false) { TalkingNPCs.Add(NPC_AI.NPC_007); }
            if (Variables.iCurrentLocation == NPC_AI.NPC008_CurrentNumLocation && NPC_AI.bCorpse008 == false) { TalkingNPCs.Add(NPC_AI.NPC_008); }
            if (Variables.iCurrentLocation == NPC_AI.NPC009_CurrentNumLocation && NPC_AI.bCorpse009 == false) { TalkingNPCs.Add(NPC_AI.NPC_009); }
            if (Variables.iCurrentLocation == NPC_AI.NPC010_CurrentNumLocation && NPC_AI.bCorpse010 == false) { TalkingNPCs.Add(NPC_AI.NPC_010); }
            if (Variables.iCurrentLocation == NPC_AI.NPC011_CurrentNumLocation && NPC_AI.bCorpse011 == false) { TalkingNPCs.Add(NPC_AI.NPC_011); }
            if (Variables.iCurrentLocation == NPC_AI.NPC012_CurrentNumLocation && NPC_AI.bCorpse012 == false) { TalkingNPCs.Add(NPC_AI.NPC_012); }
            if (Variables.iCurrentLocation == NPC_AI.NPC013_CurrentNumLocation && NPC_AI.bCorpse013 == false) { TalkingNPCs.Add(NPC_AI.NPC_013); }
            if (Variables.iCurrentLocation == NPC_AI.NPC014_CurrentNumLocation && NPC_AI.bCorpse014 == false) { TalkingNPCs.Add(NPC_AI.NPC_014); }
            if (Variables.iCurrentLocation == NPC_AI.NPC015_CurrentNumLocation && NPC_AI.bCorpse015 == false) { TalkingNPCs.Add(NPC_AI.NPC_015); }
            if (Variables.iCurrentLocation == NPC_AI.NPC016_CurrentNumLocation && NPC_AI.bCorpse016 == false) { TalkingNPCs.Add(NPC_AI.NPC_016); }
            if (Variables.iCurrentLocation == NPC_AI.NPC017_CurrentNumLocation && NPC_AI.bCorpse017 == false) { TalkingNPCs.Add(NPC_AI.NPC_017); }
            if (Variables.iCurrentLocation == NPC_AI.NPC018_CurrentNumLocation && NPC_AI.bCorpse018 == false) { TalkingNPCs.Add(NPC_AI.NPC_018); }
            if (Variables.iCurrentLocation == NPC_AI.NPC019_CurrentNumLocation && NPC_AI.bCorpse019 == false) { TalkingNPCs.Add(NPC_AI.NPC_019); }
            if (Variables.iCurrentLocation == NPC_AI.NPC020_CurrentNumLocation && NPC_AI.bCorpse020 == false) { TalkingNPCs.Add(NPC_AI.NPC_020); }
            if (Variables.iCurrentLocation == NPC_AI.NPC021_CurrentNumLocation && NPC_AI.bCorpse021 == false) { TalkingNPCs.Add(NPC_AI.NPC_021); }
            if (Variables.iCurrentLocation == NPC_AI.NPC022_CurrentNumLocation && NPC_AI.bCorpse022 == false) { TalkingNPCs.Add(NPC_AI.NPC_022); }
            if (Variables.iCurrentLocation == NPC_AI.NPC023_CurrentNumLocation && NPC_AI.bCorpse023 == false) { TalkingNPCs.Add(NPC_AI.NPC_023); }
            if (Variables.iCurrentLocation == NPC_AI.NPC024_CurrentNumLocation && NPC_AI.bCorpse024 == false) { TalkingNPCs.Add(NPC_AI.NPC_024); }
            if (Variables.iCurrentLocation == NPC_AI.NPC025_CurrentNumLocation && NPC_AI.bCorpse025 == false) { TalkingNPCs.Add(NPC_AI.NPC_025); }
            if (Variables.iCurrentLocation == NPC_AI.NPC026_CurrentNumLocation && NPC_AI.bCorpse026 == false) { TalkingNPCs.Add(NPC_AI.NPC_026); }
            if (Variables.iCurrentLocation == NPC_AI.NPC027_CurrentNumLocation && NPC_AI.bCorpse027 == false) { TalkingNPCs.Add(NPC_AI.NPC_027); }
            if (Variables.iCurrentLocation == NPC_AI.NPC028_CurrentNumLocation && NPC_AI.bCorpse028 == false) { TalkingNPCs.Add(NPC_AI.NPC_028); }
            if (Variables.iCurrentLocation == NPC_AI.NPC029_CurrentNumLocation && NPC_AI.bCorpse029 == false) { TalkingNPCs.Add(NPC_AI.NPC_029); }
            if (Variables.iCurrentLocation == NPC_AI.NPC030_CurrentNumLocation && NPC_AI.bCorpse030 == false) { TalkingNPCs.Add(NPC_AI.NPC_030); }
            if (Variables.iCurrentLocation == NPC_AI.NPC031_CurrentNumLocation && NPC_AI.bCorpse031 == false) { TalkingNPCs.Add(NPC_AI.NPC_031); }
            if (Variables.iCurrentLocation == NPC_AI.NPC032_CurrentNumLocation && NPC_AI.bCorpse032 == false) { TalkingNPCs.Add(NPC_AI.NPC_032); }
            if (Variables.iCurrentLocation == NPC_AI.NPC033_CurrentNumLocation && NPC_AI.bCorpse033 == false) { TalkingNPCs.Add(NPC_AI.NPC_033); }
            if (Variables.iCurrentLocation == NPC_AI.NPC034_CurrentNumLocation && NPC_AI.bCorpse034 == false) { TalkingNPCs.Add(NPC_AI.NPC_034); }
            if (Variables.iCurrentLocation == NPC_AI.NPC035_CurrentNumLocation && NPC_AI.bCorpse035 == false) { TalkingNPCs.Add(NPC_AI.NPC_035); }
            if (Variables.iCurrentLocation == NPC_AI.NPC036_CurrentNumLocation && NPC_AI.bCorpse036 == false) { TalkingNPCs.Add(NPC_AI.NPC_036); }
            if (Variables.iCurrentLocation == NPC_AI.NPC037_CurrentNumLocation && NPC_AI.bCorpse037 == false) { TalkingNPCs.Add(NPC_AI.NPC_037); }
            if (Variables.iCurrentLocation == NPC_AI.NPC038_CurrentNumLocation && NPC_AI.bCorpse038 == false) { TalkingNPCs.Add(NPC_AI.NPC_038); }
            if (Variables.iCurrentLocation == NPC_AI.NPC039_CurrentNumLocation && NPC_AI.bCorpse039 == false) { TalkingNPCs.Add(NPC_AI.NPC_039); }
            if (Variables.iCurrentLocation == NPC_AI.NPC040_CurrentNumLocation && NPC_AI.bCorpse040 == false) { TalkingNPCs.Add(NPC_AI.NPC_040); }
            if (Variables.iCurrentLocation == NPC_AI.NPC041_CurrentNumLocation && NPC_AI.bCorpse041 == false) { TalkingNPCs.Add(NPC_AI.NPC_041); }
            if (Variables.iCurrentLocation == NPC_AI.NPC042_CurrentNumLocation && NPC_AI.bCorpse042 == false) { TalkingNPCs.Add(NPC_AI.NPC_042); }
            if (Variables.iCurrentLocation == NPC_AI.NPC043_CurrentNumLocation && NPC_AI.bCorpse043 == false) { TalkingNPCs.Add(NPC_AI.NPC_043); }
            if (Variables.iCurrentLocation == NPC_AI.NPC044_CurrentNumLocation && NPC_AI.bCorpse044 == false) { TalkingNPCs.Add(NPC_AI.NPC_044); }
            if (Variables.iCurrentLocation == NPC_AI.NPC045_CurrentNumLocation && NPC_AI.bCorpse045 == false) { TalkingNPCs.Add(NPC_AI.NPC_045); }
            if (Variables.iCurrentLocation == NPC_AI.NPC046_CurrentNumLocation && NPC_AI.bCorpse046 == false) { TalkingNPCs.Add(NPC_AI.NPC_046); }
            if (Variables.iCurrentLocation == NPC_AI.NPC047_CurrentNumLocation && NPC_AI.bCorpse047 == false) { TalkingNPCs.Add(NPC_AI.NPC_047); }
            if (Variables.iCurrentLocation == NPC_AI.NPC048_CurrentNumLocation && NPC_AI.bCorpse048 == false) { TalkingNPCs.Add(NPC_AI.NPC_048); }
            if (Variables.iCurrentLocation == NPC_AI.NPC049_CurrentNumLocation && NPC_AI.bCorpse049 == false) { TalkingNPCs.Add(NPC_AI.NPC_049); }
            if (Variables.iCurrentLocation == NPC_AI.NPC050_CurrentNumLocation && NPC_AI.bCorpse050 == false) { TalkingNPCs.Add(NPC_AI.NPC_050); }
            if (Variables.iCurrentLocation == NPC_AI.NPC051_CurrentNumLocation && NPC_AI.bCorpse051 == false) { TalkingNPCs.Add(NPC_AI.NPC_051); }
            if (Variables.iCurrentLocation == NPC_AI.NPC052_CurrentNumLocation && NPC_AI.bCorpse052 == false) { TalkingNPCs.Add(NPC_AI.NPC_052); }
            if (Variables.iCurrentLocation == NPC_AI.NPC053_CurrentNumLocation && NPC_AI.bCorpse053 == false) { TalkingNPCs.Add(NPC_AI.NPC_053); }
            if (Variables.iCurrentLocation == NPC_AI.NPC054_CurrentNumLocation && NPC_AI.bCorpse054 == false) { TalkingNPCs.Add(NPC_AI.NPC_054); }
            if (Variables.iCurrentLocation == NPC_AI.NPC055_CurrentNumLocation && NPC_AI.bCorpse055 == false) { TalkingNPCs.Add(NPC_AI.NPC_055); }
            if (Variables.iCurrentLocation == NPC_AI.NPC056_CurrentNumLocation && NPC_AI.bCorpse056 == false) { TalkingNPCs.Add(NPC_AI.NPC_056); }
            if (Variables.iCurrentLocation == NPC_AI.NPC057_CurrentNumLocation && NPC_AI.bCorpse057 == false) { TalkingNPCs.Add(NPC_AI.NPC_057); }
            if (Variables.iCurrentLocation == NPC_AI.NPC058_CurrentNumLocation && NPC_AI.bCorpse058 == false) { TalkingNPCs.Add(NPC_AI.NPC_058); }
            if (Variables.iCurrentLocation == NPC_AI.NPC059_CurrentNumLocation && NPC_AI.bCorpse059 == false) { TalkingNPCs.Add(NPC_AI.NPC_059); }
            if (Variables.iCurrentLocation == NPC_AI.NPC060_CurrentNumLocation && NPC_AI.bCorpse060 == false) { TalkingNPCs.Add(NPC_AI.NPC_060); }
            if (Variables.iCurrentLocation == NPC_AI.NPC061_CurrentNumLocation && NPC_AI.bCorpse061 == false) { TalkingNPCs.Add(NPC_AI.NPC_061); }
            if (Variables.iCurrentLocation == NPC_AI.NPC062_CurrentNumLocation && NPC_AI.bCorpse062 == false) { TalkingNPCs.Add(NPC_AI.NPC_062); }
            if (Variables.iCurrentLocation == NPC_AI.NPC063_CurrentNumLocation && NPC_AI.bCorpse063 == false) { TalkingNPCs.Add(NPC_AI.NPC_063); }
            if (Variables.iCurrentLocation == NPC_AI.NPC064_CurrentNumLocation && NPC_AI.bCorpse064 == false) { TalkingNPCs.Add(NPC_AI.NPC_064); }
            if (Variables.iCurrentLocation == NPC_AI.NPC065_CurrentNumLocation && NPC_AI.bCorpse065 == false) { TalkingNPCs.Add(NPC_AI.NPC_065); }
            if (Variables.iCurrentLocation == NPC_AI.NPC066_CurrentNumLocation && NPC_AI.bCorpse066 == false) { TalkingNPCs.Add(NPC_AI.NPC_066); }
            if (Variables.iCurrentLocation == NPC_AI.NPC067_CurrentNumLocation && NPC_AI.bCorpse067 == false) { TalkingNPCs.Add(NPC_AI.NPC_067); }
            if (Variables.iCurrentLocation == NPC_AI.NPC068_CurrentNumLocation && NPC_AI.bCorpse068 == false) { TalkingNPCs.Add(NPC_AI.NPC_068); }
            if (Variables.iCurrentLocation == NPC_AI.NPC069_CurrentNumLocation && NPC_AI.bCorpse069 == false) { TalkingNPCs.Add(NPC_AI.NPC_069); }
            if (Variables.iCurrentLocation == NPC_AI.NPC070_CurrentNumLocation && NPC_AI.bCorpse070 == false) { TalkingNPCs.Add(NPC_AI.NPC_070); }
            if (Variables.iCurrentLocation == NPC_AI.NPC071_CurrentNumLocation && NPC_AI.bCorpse071 == false) { TalkingNPCs.Add(NPC_AI.NPC_071); }
            if (Variables.iCurrentLocation == NPC_AI.NPC072_CurrentNumLocation && NPC_AI.bCorpse072 == false) { TalkingNPCs.Add(NPC_AI.NPC_072); }
            if (Variables.iCurrentLocation == NPC_AI.NPC073_CurrentNumLocation && NPC_AI.bCorpse073 == false) { TalkingNPCs.Add(NPC_AI.NPC_073); }
            if (Variables.iCurrentLocation == NPC_AI.NPC074_CurrentNumLocation && NPC_AI.bCorpse074 == false) { TalkingNPCs.Add(NPC_AI.NPC_074); }
            if (Variables.iCurrentLocation == NPC_AI.NPC075_CurrentNumLocation && NPC_AI.bCorpse075 == false) { TalkingNPCs.Add(NPC_AI.NPC_075); }
            if (Variables.iCurrentLocation == NPC_AI.NPC076_CurrentNumLocation && NPC_AI.bCorpse076 == false) { TalkingNPCs.Add(NPC_AI.NPC_076); }
            if (Variables.iCurrentLocation == NPC_AI.NPC077_CurrentNumLocation && NPC_AI.bCorpse077 == false) { TalkingNPCs.Add(NPC_AI.NPC_077); }
            if (Variables.iCurrentLocation == NPC_AI.NPC078_CurrentNumLocation && NPC_AI.bCorpse078 == false) { TalkingNPCs.Add(NPC_AI.NPC_078); }
            if (Variables.iCurrentLocation == NPC_AI.NPC079_CurrentNumLocation && NPC_AI.bCorpse079 == false) { TalkingNPCs.Add(NPC_AI.NPC_079); }
            if (Variables.iCurrentLocation == NPC_AI.NPC080_CurrentNumLocation && NPC_AI.bCorpse080 == false) { TalkingNPCs.Add(NPC_AI.NPC_080); }
            if (Variables.iCurrentLocation == NPC_AI.NPC081_CurrentNumLocation && NPC_AI.bCorpse081 == false) { TalkingNPCs.Add(NPC_AI.NPC_081); }
            if (Variables.iCurrentLocation == NPC_AI.NPC082_CurrentNumLocation && NPC_AI.bCorpse082 == false) { TalkingNPCs.Add(NPC_AI.NPC_082); }
            if (Variables.iCurrentLocation == NPC_AI.NPC083_CurrentNumLocation && NPC_AI.bCorpse083 == false) { TalkingNPCs.Add(NPC_AI.NPC_083); }
            if (Variables.iCurrentLocation == NPC_AI.NPC084_CurrentNumLocation && NPC_AI.bCorpse084 == false) { TalkingNPCs.Add(NPC_AI.NPC_084); }
            if (Variables.iCurrentLocation == NPC_AI.NPC085_CurrentNumLocation && NPC_AI.bCorpse085 == false) { TalkingNPCs.Add(NPC_AI.NPC_085); }
            if (Variables.iCurrentLocation == NPC_AI.NPC086_CurrentNumLocation && NPC_AI.bCorpse086 == false) { TalkingNPCs.Add(NPC_AI.NPC_086); }
            if (Variables.iCurrentLocation == NPC_AI.NPC087_CurrentNumLocation && NPC_AI.bCorpse087 == false) { TalkingNPCs.Add(NPC_AI.NPC_087); }
            if (Variables.iCurrentLocation == NPC_AI.NPC088_CurrentNumLocation && NPC_AI.bCorpse088 == false) { TalkingNPCs.Add(NPC_AI.NPC_088); }
            if (Variables.iCurrentLocation == NPC_AI.NPC089_CurrentNumLocation && NPC_AI.bCorpse089 == false) { TalkingNPCs.Add(NPC_AI.NPC_089); }
            if (Variables.iCurrentLocation == NPC_AI.NPC090_CurrentNumLocation && NPC_AI.bCorpse090 == false) { TalkingNPCs.Add(NPC_AI.NPC_090); }
            if (Variables.iCurrentLocation == NPC_AI.NPC091_CurrentNumLocation && NPC_AI.bCorpse091 == false) { TalkingNPCs.Add(NPC_AI.NPC_091); }
            if (Variables.iCurrentLocation == NPC_AI.NPC092_CurrentNumLocation && NPC_AI.bCorpse092 == false) { TalkingNPCs.Add(NPC_AI.NPC_092); }
            if (Variables.iCurrentLocation == NPC_AI.NPC093_CurrentNumLocation && NPC_AI.bCorpse093 == false) { TalkingNPCs.Add(NPC_AI.NPC_093); }
            if (Variables.iCurrentLocation == NPC_AI.NPC094_CurrentNumLocation && NPC_AI.bCorpse094 == false) { TalkingNPCs.Add(NPC_AI.NPC_094); }
            if (Variables.iCurrentLocation == NPC_AI.NPC095_CurrentNumLocation && NPC_AI.bCorpse095 == false) { TalkingNPCs.Add(NPC_AI.NPC_095); }
            if (Variables.iCurrentLocation == NPC_AI.NPC096_CurrentNumLocation && NPC_AI.bCorpse096 == false) { TalkingNPCs.Add(NPC_AI.NPC_096); }
            if (Variables.iCurrentLocation == NPC_AI.NPC097_CurrentNumLocation && NPC_AI.bCorpse097 == false) { TalkingNPCs.Add(NPC_AI.NPC_097); }
            if (Variables.iCurrentLocation == NPC_AI.NPC098_CurrentNumLocation && NPC_AI.bCorpse098 == false) { TalkingNPCs.Add(NPC_AI.NPC_098); }
            if (Variables.iCurrentLocation == NPC_AI.NPC099_CurrentNumLocation && NPC_AI.bCorpse099 == false) { TalkingNPCs.Add(NPC_AI.NPC_099); }
            if (Variables.iCurrentLocation == NPC_AI.NPC100_CurrentNumLocation && NPC_AI.bCorpse100 == false) { TalkingNPCs.Add(NPC_AI.NPC_100); }
        }

        public static void PopulateNPCNameOptions()
        {
            npcNameOptions.Add("Aaron"); npcNameOptions.Add("Alexander"); npcNameOptions.Add("Alexis"); npcNameOptions.Add("Allison"); npcNameOptions.Add("Amanda");
            npcNameOptions.Add("Amy"); npcNameOptions.Add("Andrea"); npcNameOptions.Add("Andrew"); npcNameOptions.Add("Angela"); npcNameOptions.Add("Anthony");
            npcNameOptions.Add("Ashley"); npcNameOptions.Add("Austin"); npcNameOptions.Add("Ava"); npcNameOptions.Add("Barbara"); npcNameOptions.Add("Betty");
            npcNameOptions.Add("Benjamin"); npcNameOptions.Add("Brandon"); npcNameOptions.Add("Brittany"); npcNameOptions.Add("Carlos"); npcNameOptions.Add("Carol");
            npcNameOptions.Add("Carter"); npcNameOptions.Add("Charles"); npcNameOptions.Add("Charlotte"); npcNameOptions.Add("Christopher"); npcNameOptions.Add("Daniel");
            npcNameOptions.Add("David"); npcNameOptions.Add("Debra"); npcNameOptions.Add("Dominic"); npcNameOptions.Add("Donna"); npcNameOptions.Add("Dorothy");
            npcNameOptions.Add("Dylan"); npcNameOptions.Add("Elijah"); npcNameOptions.Add("Ellie"); npcNameOptions.Add("Emma"); npcNameOptions.Add("Ethan");
            npcNameOptions.Add("Eva"); npcNameOptions.Add("Evan"); npcNameOptions.Add("Hannah"); npcNameOptions.Add("Heather"); npcNameOptions.Add("Helen");
            npcNameOptions.Add("Henry"); npcNameOptions.Add("Isaac"); npcNameOptions.Add("Isabella"); npcNameOptions.Add("Isaiah"); npcNameOptions.Add("Jackson");
            npcNameOptions.Add("Jacob"); npcNameOptions.Add("James"); npcNameOptions.Add("Jason"); npcNameOptions.Add("Jennifer"); npcNameOptions.Add("Jessica");
            npcNameOptions.Add("Joan"); npcNameOptions.Add("Jonathan"); npcNameOptions.Add("Joshua"); npcNameOptions.Add("Judith"); npcNameOptions.Add("Julian");
            npcNameOptions.Add("Julie"); npcNameOptions.Add("Justin"); npcNameOptions.Add("Karen"); npcNameOptions.Add("Kevin"); npcNameOptions.Add("Kimberly");
            npcNameOptions.Add("Leah"); npcNameOptions.Add("Liam"); npcNameOptions.Add("Lillian"); npcNameOptions.Add("Linda"); npcNameOptions.Add("Lisa");
            npcNameOptions.Add("Logan"); npcNameOptions.Add("Lucas"); npcNameOptions.Add("Luke"); npcNameOptions.Add("Madison"); npcNameOptions.Add("Margaret");
            npcNameOptions.Add("Mary"); npcNameOptions.Add("Mason"); npcNameOptions.Add("Matthew"); npcNameOptions.Add("Melissa"); npcNameOptions.Add("Mia");
            npcNameOptions.Add("Michael"); npcNameOptions.Add("Michelle"); npcNameOptions.Add("Morgan"); npcNameOptions.Add("Nathan"); npcNameOptions.Add("Nicholas");
            npcNameOptions.Add("Noah"); npcNameOptions.Add("Olivia"); npcNameOptions.Add("Owen"); npcNameOptions.Add("Patricia"); npcNameOptions.Add("Richard");
            npcNameOptions.Add("Robert"); npcNameOptions.Add("Ruth"); npcNameOptions.Add("Ryan"); npcNameOptions.Add("Samantha"); npcNameOptions.Add("Samuel");
            npcNameOptions.Add("Sandra"); npcNameOptions.Add("Sarah"); npcNameOptions.Add("Sebastian"); npcNameOptions.Add("Shirley"); npcNameOptions.Add("Sophia");
            npcNameOptions.Add("Susan"); npcNameOptions.Add("Tyler"); npcNameOptions.Add("William"); npcNameOptions.Add("Wyatt"); npcNameOptions.Add("Zachary");
        }
    }
}