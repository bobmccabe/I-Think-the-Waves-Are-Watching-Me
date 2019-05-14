using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Flood
    {
        public static bool bTempFloodMoved = false;
        public static bool bPutInDanger = false;
        
        // Has the player stumbled into the waves once already?
        public static bool bSecondChanceToDrown = false;

        public static bool
        bPutInDanger001, bPutInDanger002, bPutInDanger003, bPutInDanger004, bPutInDanger005,
        bPutInDanger006, bPutInDanger007, bPutInDanger008, bPutInDanger009, bPutInDanger010,
        bPutInDanger011, bPutInDanger012, bPutInDanger013, bPutInDanger014, bPutInDanger015,
        bPutInDanger016, bPutInDanger017, bPutInDanger018, bPutInDanger019, bPutInDanger020,
        bPutInDanger021, bPutInDanger022, bPutInDanger023, bPutInDanger024, bPutInDanger025,
        bPutInDanger026, bPutInDanger027, bPutInDanger028, bPutInDanger029, bPutInDanger030,
        bPutInDanger031, bPutInDanger032, bPutInDanger033, bPutInDanger034, bPutInDanger035,
        bPutInDanger036, bPutInDanger037, bPutInDanger038, bPutInDanger039, bPutInDanger040,
        bPutInDanger041, bPutInDanger042, bPutInDanger043, bPutInDanger044, bPutInDanger045,
        bPutInDanger046, bPutInDanger047, bPutInDanger048, bPutInDanger049, bPutInDanger050,
        bPutInDanger051, bPutInDanger052, bPutInDanger053, bPutInDanger054, bPutInDanger055,
        bPutInDanger056, bPutInDanger057, bPutInDanger058, bPutInDanger059, bPutInDanger060,
        bPutInDanger061, bPutInDanger062, bPutInDanger063, bPutInDanger064, bPutInDanger065,
        bPutInDanger066, bPutInDanger067, bPutInDanger068, bPutInDanger069, bPutInDanger070,
        bPutInDanger071, bPutInDanger072, bPutInDanger073, bPutInDanger074, bPutInDanger075,
        bPutInDanger076, bPutInDanger077, bPutInDanger078, bPutInDanger079, bPutInDanger080,
        bPutInDanger081, bPutInDanger082, bPutInDanger083, bPutInDanger084, bPutInDanger085,
        bPutInDanger086, bPutInDanger087, bPutInDanger088, bPutInDanger089, bPutInDanger090,
        bPutInDanger091, bPutInDanger092, bPutInDanger093, bPutInDanger094, bPutInDanger095,
        bPutInDanger096, bPutInDanger097, bPutInDanger098, bPutInDanger099, bPutInDanger100;

        public static void Initialize_Flood()
        {
            bPutInDanger001 = bPutInDanger002 = bPutInDanger003 = bPutInDanger004 = bPutInDanger005 =
            bPutInDanger006 = bPutInDanger007 = bPutInDanger008 = bPutInDanger009 = bPutInDanger010 = 
            bPutInDanger011 = bPutInDanger012 = bPutInDanger013 = bPutInDanger014 = bPutInDanger015 =
            bPutInDanger016 = bPutInDanger017 = bPutInDanger018 = bPutInDanger019 = bPutInDanger020 =
            bPutInDanger021 = bPutInDanger022 = bPutInDanger023 = bPutInDanger024 = bPutInDanger025 =
            bPutInDanger026 = bPutInDanger027 = bPutInDanger028 = bPutInDanger029 = bPutInDanger030 =
            bPutInDanger031 = bPutInDanger032 = bPutInDanger033 = bPutInDanger034 = bPutInDanger035 =
            bPutInDanger036 = bPutInDanger037 = bPutInDanger038 = bPutInDanger039 = bPutInDanger040 =
            bPutInDanger041 = bPutInDanger042 = bPutInDanger043 = bPutInDanger044 = bPutInDanger045 =
            bPutInDanger046 = bPutInDanger047 = bPutInDanger048 = bPutInDanger049 = bPutInDanger050 =
            bPutInDanger051 = bPutInDanger052 = bPutInDanger053 = bPutInDanger054 = bPutInDanger055 =
            bPutInDanger056 = bPutInDanger057 = bPutInDanger058 = bPutInDanger059 = bPutInDanger060 =
            bPutInDanger061 = bPutInDanger062 = bPutInDanger063 = bPutInDanger064 = bPutInDanger065 =
            bPutInDanger066 = bPutInDanger067 = bPutInDanger068 = bPutInDanger069 = bPutInDanger070 =
            bPutInDanger071 = bPutInDanger072 = bPutInDanger073 = bPutInDanger074 = bPutInDanger075 =
            bPutInDanger076 = bPutInDanger077 = bPutInDanger078 = bPutInDanger079 = bPutInDanger080 =
            bPutInDanger081 = bPutInDanger082 = bPutInDanger083 = bPutInDanger084 = bPutInDanger085 =
            bPutInDanger086 = bPutInDanger087 = bPutInDanger088 = bPutInDanger089 = bPutInDanger090 =
            bPutInDanger091 = bPutInDanger092 = bPutInDanger093 = bPutInDanger094 = bPutInDanger095 =
            bPutInDanger096 = bPutInDanger097 = bPutInDanger098 = bPutInDanger099 = bPutInDanger100 = false;
        }

        public static void HereComesTheFlood()
        {
            // Flood the Island at specific intervals.
            // The March of the Tidal Waves.
            Console.ForegroundColor = ConsoleColor.Green;
            if (Variables.iRemainingTurns >31)
            {
                Variables.iStage = 0;
            }
            if (Variables.iRemainingTurns <= 31 && Variables.iRemainingTurns >= 1)
            {
                Console.WriteLine();
            }
            if (Variables.iRemainingTurns == 31)
            {
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_001);
                // bLocation001 = false;
                Variables.iStage = 1;
            }
            if (Variables.iRemainingTurns == 30)
            { 
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_001 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves have ceased their advance for a moment.");
                Variables.iStage = 1;
            }
            if (Variables.iRemainingTurns == 29)
            {
                Console.WriteLine("The tidal waves have resumed their advance.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_002);
                // bLocation002 = false;
                Variables.iStage = 2;
            }
            if (Variables.iRemainingTurns == 28)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_002 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_003);
                // bLocation003 = false;
                Variables.iStage = 3;
            }
            if (Variables.iRemainingTurns == 27)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_003 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_004);
                // bLocation004 = false;
                Variables.iStage = 4;
            }
            if (Variables.iRemainingTurns == 26)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_004 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_005);
                // bLocation005 = false;
                Variables.iStage = 5;
            }
            if (Variables.iRemainingTurns == 25)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_005 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_006);
                // bLocation006 = false;
                Variables.iStage = 6;
            }
            if (Variables.iRemainingTurns == 24)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_006 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_007);
                // bLocation007 = false;
                Variables.iStage = 7;
            }
            if (Variables.iRemainingTurns == 23)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_007 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_008);
                // bLocation008 = false;
                Variables.iStage = 8;
            }
            if (Variables.iRemainingTurns == 22)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_008 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves have ceased their advance for a moment.");
            }
            if (Variables.iRemainingTurns <= 21 && Variables.iRemainingTurns > 19)
            {
                Console.WriteLine("The tidal waves have ceased their advance for a moment.");
            }
            if (Variables.iRemainingTurns == 19)
            {
                Console.WriteLine("The tidal waves have resumed their advance.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_009);
                // bLocation009 = false;
                Variables.iStage = 9;
            }
            if (Variables.iRemainingTurns == 18)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_009 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_010);
                // bLocation010 = false;
                Variables.iStage = 10;
            }
            if (Variables.iRemainingTurns == 17)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_010 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_011);
                // bLocation011 = false;
                Variables.iStage = 11;
            }
            if (Variables.iRemainingTurns == 16)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_011 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_012);
                // bLocation012 = false;
                Variables.iStage = 12;
            }
            if (Variables.iRemainingTurns == 15)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_012 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_013);
                // bLocation013 = false;
                Variables.iStage = 13;
            }
            if (Variables.iRemainingTurns == 14)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_013 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_014);
                // bLocation014 = false;
                Variables.iStage = 14;
            }
            if (Variables.iRemainingTurns == 13)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_014 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_015);
                // bLocation015 = false;
                Variables.iStage = 15;
            }
            if (Variables.iRemainingTurns == 12)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_015 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_016);
                // bLocation016 = false;
                Variables.iStage = 16;
            }
            if (Variables.iRemainingTurns == 11)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_016 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_017);
                // bLocation017 = false;
                Variables.iStage = 17;
            }
            if (Variables.iRemainingTurns == 10)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_017 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_018);
                // bLocation018 = false;
                Variables.iStage = 18;
            }
            if (Variables.iRemainingTurns == 9)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_018 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_019);
                // bLocation019 = false;
                Variables.iStage = 19;
            }
            if (Variables.iRemainingTurns == 8)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_019 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_020);
                // bLocation020 = false;
                Variables.iStage = 20;
            }
            if (Variables.iRemainingTurns == 7)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_020 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_021);
                // bLocation021 = false;
                Variables.iStage = 21;
            }
            if (Variables.iRemainingTurns == 6)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_021 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_022);
                // bLocation022 = false;
                Variables.iStage = 22;
            }
            if (Variables.iRemainingTurns == 5)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_022 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_023);
                // bLocation023 = false;
                Variables.iStage = 23;
            }
            if (Variables.iRemainingTurns == 4)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_023 + " The area is no longer accessible.");
                Console.WriteLine("The tidal waves are pushing eastward and are about to destroy " + LocationEncounters.location_024);
                // bLocation024 = false;
                Variables.iStage = 24;
            }
            if (Variables.iRemainingTurns == 3)
            {
                Console.WriteLine("The tidal waves have claimed " + LocationEncounters.location_024);
                Variables.iStage = 25;
            }
            if (Variables.iRemainingTurns <= 2)
            {
                Console.WriteLine("The tidal waves have ceased their advance for a moment.");
            }
        }

        public static void FloodBlocksSomeLocations()
        {
            if (Variables.iStage == 0) // No restrictions to player if area 1 can be accessed.
            {
                Search.bLocation001 = true; Search.bLocation002 = true; Search.bLocation003 = true; Search.bLocation004 = true; Search.bLocation005 = true;
                Search.bLocation006 = true; Search.bLocation007 = true; Search.bLocation008 = true; Search.bLocation009 = true; Search.bLocation010 = true;
                Search.bLocation011 = true; Search.bLocation012 = true; Search.bLocation013 = true; Search.bLocation014 = true; Search.bLocation015 = true;
                Search.bLocation016 = true; Search.bLocation017 = true; Search.bLocation018 = true; Search.bLocation019 = true; Search.bLocation020 = true;
                Search.bLocation021 = true; Search.bLocation022 = true; Search.bLocation023 = true; Search.bLocation024 = true;
            } 
            if (Variables.iStage == 1) { } // (No 1) If area 1 is about to go.
            if (Variables.iStage == 2) { Search.bLocation001 = false; } // (No 1, No 2) If area 1 is claimed, and 2 is about to go.
            if (Variables.iStage == 3) { Search.bLocation002 = false; } // (No 2, No 3) If area 2 is claimed, and 3 is about to go.
            if (Variables.iStage == 4) { Search.bLocation003 = false; } // (No 3, No 4) If area 3 is claimed, and 4 is about to go.
            if (Variables.iStage == 5) { Search.bLocation004 = false; } // (No 4, No 5) If area 4 is claimed, and 5 is about to go.
            if (Variables.iStage == 6) { Search.bLocation005 = false; } // (No 5, No 6) If area 5 is claimed, and 6 is about to go.
            if (Variables.iStage == 7) { Search.bLocation006 = false; } // (No 6, No 7) If area 6 is claimed, and 7 is about to go.
            if (Variables.iStage == 8) { Search.bLocation007 = false; } // (No 7, No 8) If area 7 is claimed, and 8 is about to go.
            if (Variables.iStage == 9) { Search.bLocation008 = false; } // (No 8, No 9) If area 8 is claimed, and 9 is about to go.
            if (Variables.iStage == 10) { Search.bLocation009 = false; } // (No 9, No 10) If area 9 is claimed, and 10 is about to go.
            if (Variables.iStage == 11) { Search.bLocation010 = false; } // (No 10, No 11) If area 10 is claimed, and 11 is about to go.
            if (Variables.iStage == 12) { Search.bLocation011 = false; } // (No 11, No 12) If area 11 is claimed, and 12 is about to go.
            if (Variables.iStage == 13) { Search.bLocation012 = false; } // (No 12, No 13) If area 12 is claimed, and 13 is about to go.
            if (Variables.iStage == 14) { Search.bLocation013 = false; } // (No 13, No 14) If area 13 is claimed, and 14 is about to go.
            if (Variables.iStage == 15) { Search.bLocation014 = false; } // (No 14, No 15) If area 14 is claimed, and 15 is about to go.
            if (Variables.iStage == 16) { Search.bLocation015 = false; } // (No 15, No 16) If area 15 is claimed, and 16 is about to go.
            if (Variables.iStage == 17) { Search.bLocation016 = false; } // (No 16, No 17) If area 16 is claimed, and 17 is about to go.
            if (Variables.iStage == 18) { Search.bLocation017 = false; } // (No 17, No 18) If area 17 is claimed, and 18 is about to go.
            if (Variables.iStage == 19) { Search.bLocation018 = false; } // (No 18, No 19) If area 18 is claimed, and 19 is about to go.
            if (Variables.iStage == 20) { Search.bLocation019 = false; } // (No 19, No 20) If area 19 is claimed, and 20 is about to go.
            if (Variables.iStage == 21) { Search.bLocation020 = false; } // (No 20, No 21) If area 20 is claimed, and 21 is about to go.
            if (Variables.iStage == 22) { Search.bLocation021 = false; } // (No 21, No 22) If area 21 is claimed, and 22 is about to go.
            if (Variables.iStage == 23) { Search.bLocation022 = false; } // (No 22, No 23) If area 22 is claimed, and 23 is about to go.
            if (Variables.iStage == 24) { Search.bLocation023 = false; } // (No 23, No 24) If area 23 is claimed, and 24 is about to go.
            if (Variables.iStage == 25) { Search.bLocation024 = false; } // If area 24 is out but 25 is still good.
            Console.ForegroundColor = ConsoleColor.Gray;
            // End flooding.
        }

        public static void HopeYouNPCsCanSwim()
        {
            // Drown people if necessary
            if (NPC_AI.iTempLocation == 1 && !Search.bLocation001 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 2 && !Search.bLocation002 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 3 && !Search.bLocation003 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 4 && !Search.bLocation004 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 5 && !Search.bLocation005 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 6 && !Search.bLocation006 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 7 && !Search.bLocation007 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 8 && !Search.bLocation008 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 9 && !Search.bLocation009 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 10 && !Search.bLocation010 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 11 && !Search.bLocation011 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 12 && !Search.bLocation012 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 13 && !Search.bLocation013 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 14 && !Search.bLocation014 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 15 && !Search.bLocation015 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 16 && !Search.bLocation016 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 17 && !Search.bLocation017 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 18 && !Search.bLocation018 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 19 && !Search.bLocation019 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 20 && !Search.bLocation020 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 21 && !Search.bLocation021 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 22 && !Search.bLocation022 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 23 && !Search.bLocation023 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
            if (NPC_AI.iTempLocation == 24 && !Search.bLocation024 && !NPC_AI.bTempCorpse) { if (!bPutInDanger) { /* Console.WriteLine(NPC_AI.tempNPC + "says 'I drowned but I was not put in danger!'"); */} if (bPutInDanger) { Variables.iAcciKilled = Variables.iAcciKilled + 1; /* Console.WriteLine("Adding ONE to Variables.iAcciKilled."); */ } NPC_AI.iTempDesireToMove = -100; NPC_AI.bTempCorpse = true; Lists.RemainingNPCs.Remove(NPC_AI.tempNPC); Lists.TheDrowned.Add(NPC_AI.tempNPC); }
        }

        public static void ThePlayerCantSwim()
        {
            // Drowning random chance
            // int iMayDrown = rand.Next(1, 101);
            if (/*iMayDrown >= 41 && */ !bSecondChanceToDrown || RandomEncounters.bFloodProof) // Second-chance players aren't drowned, Flood proof players aren't drowned.
            {
                if (Variables.iCurrentLocation <= 1 && Variables.iStage >= 1) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 2 && Variables.iStage >= 3) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 3 && Variables.iStage >= 4) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 4 && Variables.iStage >= 5) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 5 && Variables.iStage >= 6) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 6 && Variables.iStage >= 7) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 7 && Variables.iStage >= 8) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 8 && Variables.iStage >= 9) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 9 && Variables.iStage >= 10) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 10 && Variables.iStage >= 11) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 11 && Variables.iStage >= 12) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 12 && Variables.iStage >= 13) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 13 && Variables.iStage >= 14) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 14 && Variables.iStage >= 15) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 15 && Variables.iStage >= 16) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 16 && Variables.iStage >= 17) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 17 && Variables.iStage >= 18) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 18 && Variables.iStage >= 19) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 19 && Variables.iStage >= 20) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 20 && Variables.iStage >= 21) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 21 && Variables.iStage >= 22) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 22 && Variables.iStage >= 23) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 23 && Variables.iStage >= 24) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }
                if (Variables.iCurrentLocation <= 24 && Variables.iStage >= 25) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine902); Variables.sGetLocation = LocationEncounters.location_025; Variables.iCurrentLocation = 25; bSecondChanceToDrown = true; Program.PressAnyKey(); Variables.turnEnded = true; RandomEncounters.bEncounter = true; }

            }
            if (/*iMayDrown <= 40 || */ bSecondChanceToDrown) // Drown player, if necessary
            {
                if (Variables.iCurrentLocation <= 1 && Variables.iStage >= 1) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 2 && Variables.iStage >= 3) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 3 && Variables.iStage >= 4) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 4 && Variables.iStage >= 5) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 5 && Variables.iStage >= 6) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 6 && Variables.iStage >= 7) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 7 && Variables.iStage >= 8) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 8 && Variables.iStage >= 9) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 9 && Variables.iStage >= 10) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 10 && Variables.iStage >= 11) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 11 && Variables.iStage >= 12) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 12 && Variables.iStage >= 13) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 13 && Variables.iStage >= 14) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 14 && Variables.iStage >= 15) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 15 && Variables.iStage >= 16) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 16 && Variables.iStage >= 17) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 17 && Variables.iStage >= 18) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 18 && Variables.iStage >= 19) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 19 && Variables.iStage >= 20) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 20 && Variables.iStage >= 21) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 21 && Variables.iStage >= 22) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 22 && Variables.iStage >= 23) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 23 && Variables.iStage >= 24) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
                if (Variables.iCurrentLocation <= 24 && Variables.iStage >= 25) { Console.Clear(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(Conversation.sLine900); Console.WriteLine(Conversation.sLine901); if (!Title.bAchievement07) { Console.ForegroundColor = ConsoleColor.Green; Title.bAchievement07 = true; Console.WriteLine("   Secret Discovered: " + Title.sAchievement07); } Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0; Variables.playerSurvived = Variables.sPlayerState2; Program.PressAnyKey(); }
            }

            // End drowning the player
        }
    }
}