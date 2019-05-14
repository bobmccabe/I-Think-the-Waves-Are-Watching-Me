using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class PlayerOptions
    {
        public static bool bNotebookTip = false;

        public static void PlayerOptionsList()
        {
            RandomEncounters.bBestFriendsReportsOnce = false; // this makes sure that if an NPC is following the player, they only report once and not 100x.

            Console.WriteLine();
            if (RandomEncounters.bEncounter == false && Variables.playerSurvived == Variables.sPlayerState3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("MacGuffins: " + Variables.iFoundMacGuffins + "; Weapon: " + Variables.weaponName);
                Console.WriteLine();

                NewbieTipsAreForNewbies();
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose an action (actions advance time by one minute):");
                Console.ForegroundColor = ConsoleColor.White;

                if (Variables.bAnyoneHere == true && Variables.iRemainingTurns <= Variables.iTurn20)
                {
                    Console.WriteLine("(T)alk/Barter/Accuse | (M)ove to Location | Read (N)otebook | Search for (I)tems | (E)xplore Area | (P)ass Turn | (Q)uit"); // , or (H)elp.
                }
                else if (Variables.bAnyoneHere == true && Variables.iRemainingTurns > Variables.iTurn30)
                {
                    Console.WriteLine("(T)alk/Barter | (M)ove to Location | Read (N)otebook | Search for (I)tems | (E)xplore Area | (P)ass Turn | (Q)uit"); // , or (H)elp.

                }
                else if (Variables.bAnyoneHere == false)
                {
                    Console.WriteLine("(M)ove to Location | Read (N)otebook | Search for (I)tems | (E)xplore Area | (P)ass Turn | (Q)uit"); // , or (H)elp.
                }
                Console.WriteLine();
                Variables.playerAction = Console.ReadLine();
                Variables.playerAction.ToLower();
                Console.WriteLine();

                // while Variables.playerAction check, oh noes. :'( no more holding down enter to skip turns for easy testing.

                // With debug cheats activated:
                //while (
                //Variables.playerAction != "&" && Variables.playerAction != "^" && Variables.playerAction != "1" &&
                //Variables.playerAction != "2" && Variables.playerAction != "3" && Variables.playerAction != "i" &&
                //Variables.playerAction != "t" && Variables.playerAction != "m" && Variables.playerAction != "n" &&
                //Variables.playerAction != "e" && Variables.playerAction != "p" && Variables.playerAction != "q" &&
                //Variables.playerAction != "x" && Variables.playerAction != "4" && Variables.playerAction != "5")

                // Cheats free!
                while (
                Variables.playerAction != "i" && Variables.playerAction != "t" && Variables.playerAction != "m" &&
                Variables.playerAction != "n" && Variables.playerAction != "e" && Variables.playerAction != "p" &&
                Variables.playerAction != "q")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose from the list, such as 'm' for '(M)ove to Location'.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Variables.playerAction = Console.ReadLine();
                    Console.WriteLine();
                    Variables.playerAction.ToLower();
                }
                Console.Clear();
                switch (Variables.playerAction.ToLower())
                {
                    case "&": // Debug Cheat: Give lewts!
                        Option_Cheat_FatLewts();
                        break;
                    case "^": // Debug Cheat: Kill the Killer 
                        Option_Cheat_KillTheKiller();
                        break;
                    case "1": // Debug Cheat: Give 1st Clue
                        Option_Cheat_GimmeTheFirstClue();
                        break;
                    case "2": // Debug Cheat: Give 2nd Clue
                        Option_Cheat_GimmeTheSecondClue();
                        break;
                    case "3": // Debug Cheat: Give 3rd Clue
                        Option_Cheat_GimmeTheThirdClue();
                        break;
                    case "4": // Auto-kill NPC_076
                        Option_Cheat_KillNPC099();
                        break;
                    case "5": // Jump to turn 23; this is stupidly risky for bugs, don't use!
                        Option_Cheat_JumpForwardInTime();
                        break;
                    case "i": // SEARCH area for Items (MacGuffins or Weapons)
                        Option_SearchForItems();
                        break;
                    case "t": // Talk, Barter, or Accuse
                        Conversation.Option_LetsGetTalking();
                        break;
                    case "e": // EXPLORE area, i.e. find things to do at locations like the lighthouse, police station, bar (everyone drinks, strangers give you MacGuffins), etc.
                        Option_ExploreArea();
                        break;
                    case "q": // Quit the game.
                        Option_QuitTheGame();
                        break;
                    case "p": // Pass
                        Option_PassTurn();
                        break;
                    case "n": // Notebook
                        Notebook.Option_CompulsivelyWritingEverythingDown();
                        break;
                    case "x": // Debug Cheat: Where is everyone?
                        Option_Cheat_WhereIsEveryone();
                        break;
                    case "m": // Move
                        Movement.Option_LetsGetMoving();
                        break;
                }
            }
        }

        public static void Option_Cheat_FatLewts()
        {
            Console.WriteLine("You decide to make it rain... MacGuffins!");
            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 100;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   Gained 100 MacGuffins.");
            Program.PressAnyKey();
        }

        public static void Option_Cheat_KillTheKiller()
        {
            Console.WriteLine("You decide to auto-kill the killer!");
            NPC_AI.bCorpse100 = true;
            Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
            Program.PressAnyKey();
        }

        public static void Option_Cheat_WhereIsEveryone()
        {
            if (Variables.bAboutToDie == true)
            {
                if (Variables.weaponName == NPC_AI.sWeaponType0) // no need to fix "shotgun" text with cheating since most will never see it.
                {
                    Console.WriteLine("If ever there were a time to cheat, now would be that time. ");
                    Console.WriteLine("Unfortunately, choosing to cheat isn't going to save you now.");
                    Console.WriteLine("An explosion erupts from the shotgun... and then everything is still.");
                    Variables.playerSurvived = Variables.sPlayerState1;
                    Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                }
                else if (Variables.weaponName != NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("If only choosing to cheat could somehow save you from the deadly blast of a shotgun. Alas, it will not.");
                    Console.WriteLine("The " + Variables.weaponName + " you're holding, however, will do nicely. You sacrifice it to buy yourself some time to come up with a better plan than cheating.");
                    Console.WriteLine("While you lost the " + Variables.weaponName + " in the process, you're still alive.");
                    Variables.weaponName = NPC_AI.sWeaponType0;
                }
            }
            else if (Variables.bAboutToDie == false)
            {
                if (NPC_AI.bCorpse001)
                { Console.WriteLine("The dead! NPC001 is now " + NPC_AI.NPC_001 + " is now at map location #" + NPC_AI.NPC001_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC001_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose001); }
                if (NPC_AI.bCorpse002)
                { Console.WriteLine("The dead! NPC002 is now " + NPC_AI.NPC_002 + " is now at map location #" + NPC_AI.NPC002_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC002_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose002); }
                if (NPC_AI.bCorpse003)
                { Console.WriteLine("The dead! NPC003 is now " + NPC_AI.NPC_003 + " is now at map location #" + NPC_AI.NPC003_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC003_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose003); }
                if (NPC_AI.bCorpse004)
                { Console.WriteLine("The dead! NPC004 is now " + NPC_AI.NPC_004 + " is now at map location #" + NPC_AI.NPC004_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC004_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose004); }
                if (NPC_AI.bCorpse005)
                { Console.WriteLine("The dead! NPC005 is now " + NPC_AI.NPC_005 + " is now at map location #" + NPC_AI.NPC005_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC005_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose005); }
                if (NPC_AI.bCorpse006)
                { Console.WriteLine("The dead! NPC006 is now " + NPC_AI.NPC_006 + " is now at map location #" + NPC_AI.NPC006_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC006_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose006); }
                if (NPC_AI.bCorpse007)
                { Console.WriteLine("The dead! NPC007 is now " + NPC_AI.NPC_007 + " is now at map location #" + NPC_AI.NPC007_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC007_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose007); }
                if (NPC_AI.bCorpse008)
                { Console.WriteLine("The dead! NPC008 is now " + NPC_AI.NPC_008 + " is now at map location #" + NPC_AI.NPC008_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC008_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose008); }
                if (NPC_AI.bCorpse009)
                { Console.WriteLine("The dead! NPC009 is now " + NPC_AI.NPC_009 + " is now at map location #" + NPC_AI.NPC009_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC009_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose009); }
                if (NPC_AI.bCorpse010)
                { Console.WriteLine("The dead! NPC010 is now " + NPC_AI.NPC_010 + " is now at map location #" + NPC_AI.NPC010_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC010_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose010); }
                if (NPC_AI.bCorpse011)
                { Console.WriteLine("The dead! NPC011 is now " + NPC_AI.NPC_011 + " is now at map location #" + NPC_AI.NPC011_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC011_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose011); }
                if (NPC_AI.bCorpse012)
                { Console.WriteLine("The dead! NPC012 is now " + NPC_AI.NPC_012 + " is now at map location #" + NPC_AI.NPC012_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC012_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose012); }
                if (NPC_AI.bCorpse013)
                { Console.WriteLine("The dead! NPC013 is now " + NPC_AI.NPC_013 + " is now at map location #" + NPC_AI.NPC013_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC013_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose013); }
                if (NPC_AI.bCorpse014)
                { Console.WriteLine("The dead! NPC014 is now " + NPC_AI.NPC_014 + " is now at map location #" + NPC_AI.NPC014_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC014_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose014); }
                if (NPC_AI.bCorpse015)
                { Console.WriteLine("The dead! NPC015 is now " + NPC_AI.NPC_015 + " is now at map location #" + NPC_AI.NPC015_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC015_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose015); }
                if (NPC_AI.bCorpse016)
                { Console.WriteLine("The dead! NPC016 is now " + NPC_AI.NPC_016 + " is now at map location #" + NPC_AI.NPC016_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC016_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose016); }
                if (NPC_AI.bCorpse017)
                { Console.WriteLine("The dead! NPC017 is now " + NPC_AI.NPC_017 + " is now at map location #" + NPC_AI.NPC017_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC017_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose017); }
                if (NPC_AI.bCorpse018)
                { Console.WriteLine("The dead! NPC018 is now " + NPC_AI.NPC_018 + " is now at map location #" + NPC_AI.NPC018_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC018_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose018); }
                if (NPC_AI.bCorpse019)
                { Console.WriteLine("The dead! NPC019 is now " + NPC_AI.NPC_019 + " is now at map location #" + NPC_AI.NPC019_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC019_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose019); }
                if (NPC_AI.bCorpse020)
                { Console.WriteLine("The dead! NPC020 is now " + NPC_AI.NPC_020 + " is now at map location #" + NPC_AI.NPC020_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC020_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose020); }
                if (NPC_AI.bCorpse021)
                { Console.WriteLine("The dead! NPC021 is now " + NPC_AI.NPC_021 + " is now at map location #" + NPC_AI.NPC021_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC021_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose021); }
                if (NPC_AI.bCorpse022)
                { Console.WriteLine("The dead! NPC022 is now " + NPC_AI.NPC_022 + " is now at map location #" + NPC_AI.NPC022_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC022_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose022); }
                if (NPC_AI.bCorpse023)
                { Console.WriteLine("The dead! NPC023 is now " + NPC_AI.NPC_023 + " is now at map location #" + NPC_AI.NPC023_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC023_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose023); }
                if (NPC_AI.bCorpse024)
                { Console.WriteLine("The dead! NPC024 is now " + NPC_AI.NPC_024 + " is now at map location #" + NPC_AI.NPC024_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC024_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose024); }
                if (NPC_AI.bCorpse025)
                { Console.WriteLine("The dead! NPC025 is now " + NPC_AI.NPC_025 + " is now at map location #" + NPC_AI.NPC025_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC025_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose025); }
                if (NPC_AI.bCorpse026)
                { Console.WriteLine("The dead! NPC026 is now " + NPC_AI.NPC_026 + " is now at map location #" + NPC_AI.NPC026_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC026_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose026); }
                if (NPC_AI.bCorpse027)
                { Console.WriteLine("The dead! NPC027 is now " + NPC_AI.NPC_027 + " is now at map location #" + NPC_AI.NPC027_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC027_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose027); }
                if (NPC_AI.bCorpse028)
                { Console.WriteLine("The dead! NPC028 is now " + NPC_AI.NPC_028 + " is now at map location #" + NPC_AI.NPC028_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC028_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose028); }
                if (NPC_AI.bCorpse029)
                { Console.WriteLine("The dead! NPC029 is now " + NPC_AI.NPC_029 + " is now at map location #" + NPC_AI.NPC029_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC029_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose029); }
                if (NPC_AI.bCorpse030)
                { Console.WriteLine("The dead! NPC030 is now " + NPC_AI.NPC_030 + " is now at map location #" + NPC_AI.NPC030_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC030_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose030); }
                if (NPC_AI.bCorpse031)
                { Console.WriteLine("The dead! NPC031 is now " + NPC_AI.NPC_031 + " is now at map location #" + NPC_AI.NPC031_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC031_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose031); }
                if (NPC_AI.bCorpse032)
                { Console.WriteLine("The dead! NPC032 is now " + NPC_AI.NPC_032 + " is now at map location #" + NPC_AI.NPC032_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC032_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose032); }
                if (NPC_AI.bCorpse033)
                { Console.WriteLine("The dead! NPC033 is now " + NPC_AI.NPC_033 + " is now at map location #" + NPC_AI.NPC033_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC033_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose033); }
                if (NPC_AI.bCorpse034)
                { Console.WriteLine("The dead! NPC034 is now " + NPC_AI.NPC_034 + " is now at map location #" + NPC_AI.NPC034_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC034_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose034); }
                if (NPC_AI.bCorpse035)
                { Console.WriteLine("The dead! NPC035 is now " + NPC_AI.NPC_035 + " is now at map location #" + NPC_AI.NPC035_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC035_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose035); }
                if (NPC_AI.bCorpse036)
                { Console.WriteLine("The dead! NPC036 is now " + NPC_AI.NPC_036 + " is now at map location #" + NPC_AI.NPC036_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC036_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose036); }
                if (NPC_AI.bCorpse037)
                { Console.WriteLine("The dead! NPC037 is now " + NPC_AI.NPC_037 + " is now at map location #" + NPC_AI.NPC037_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC037_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose037); }
                if (NPC_AI.bCorpse038)
                { Console.WriteLine("The dead! NPC038 is now " + NPC_AI.NPC_038 + " is now at map location #" + NPC_AI.NPC038_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC038_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose038); }
                if (NPC_AI.bCorpse039)
                { Console.WriteLine("The dead! NPC039 is now " + NPC_AI.NPC_039 + " is now at map location #" + NPC_AI.NPC039_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC039_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose039); }
                if (NPC_AI.bCorpse040)
                { Console.WriteLine("The dead! NPC040 is now " + NPC_AI.NPC_040 + " is now at map location #" + NPC_AI.NPC040_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC040_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose040); }
                if (NPC_AI.bCorpse041)
                { Console.WriteLine("The dead! NPC041 is now " + NPC_AI.NPC_041 + " is now at map location #" + NPC_AI.NPC041_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC041_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose041); }
                if (NPC_AI.bCorpse042)
                { Console.WriteLine("The dead! NPC042 is now " + NPC_AI.NPC_042 + " is now at map location #" + NPC_AI.NPC042_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC042_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose042); }
                if (NPC_AI.bCorpse043)
                { Console.WriteLine("The dead! NPC043 is now " + NPC_AI.NPC_043 + " is now at map location #" + NPC_AI.NPC043_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC043_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose043); }
                if (NPC_AI.bCorpse044)
                { Console.WriteLine("The dead! NPC044 is now " + NPC_AI.NPC_044 + " is now at map location #" + NPC_AI.NPC044_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC044_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose044); }
                if (NPC_AI.bCorpse045)
                { Console.WriteLine("The dead! NPC045 is now " + NPC_AI.NPC_045 + " is now at map location #" + NPC_AI.NPC045_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC045_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose045); }
                if (NPC_AI.bCorpse046)
                { Console.WriteLine("The dead! NPC046 is now " + NPC_AI.NPC_046 + " is now at map location #" + NPC_AI.NPC046_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC046_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose046); }
                if (NPC_AI.bCorpse047)
                { Console.WriteLine("The dead! NPC047 is now " + NPC_AI.NPC_047 + " is now at map location #" + NPC_AI.NPC047_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC047_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose047); }
                if (NPC_AI.bCorpse048)
                { Console.WriteLine("The dead! NPC048 is now " + NPC_AI.NPC_048 + " is now at map location #" + NPC_AI.NPC048_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC048_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose048); }
                if (NPC_AI.bCorpse049)
                { Console.WriteLine("The dead! NPC049 is now " + NPC_AI.NPC_049 + " is now at map location #" + NPC_AI.NPC049_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC049_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose049); }
                if (NPC_AI.bCorpse050)
                { Console.WriteLine("The dead! NPC050 is now " + NPC_AI.NPC_050 + " is now at map location #" + NPC_AI.NPC050_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC050_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose050); }
                if (NPC_AI.bCorpse051)
                { Console.WriteLine("The dead! NPC051 is now " + NPC_AI.NPC_051 + " is now at map location #" + NPC_AI.NPC051_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC051_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose051); }
                if (NPC_AI.bCorpse052)
                { Console.WriteLine("The dead! NPC052 is now " + NPC_AI.NPC_052 + " is now at map location #" + NPC_AI.NPC052_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC052_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose052); }
                if (NPC_AI.bCorpse053)
                { Console.WriteLine("The dead! NPC053 is now " + NPC_AI.NPC_053 + " is now at map location #" + NPC_AI.NPC053_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC053_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose053); }
                if (NPC_AI.bCorpse054)
                { Console.WriteLine("The dead! NPC054 is now " + NPC_AI.NPC_054 + " is now at map location #" + NPC_AI.NPC054_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC054_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose054); }
                if (NPC_AI.bCorpse055)
                { Console.WriteLine("The dead! NPC055 is now " + NPC_AI.NPC_055 + " is now at map location #" + NPC_AI.NPC055_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC055_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose055); }
                if (NPC_AI.bCorpse056)
                { Console.WriteLine("The dead! NPC056 is now " + NPC_AI.NPC_056 + " is now at map location #" + NPC_AI.NPC056_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC056_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose056); }
                if (NPC_AI.bCorpse057)
                { Console.WriteLine("The dead! NPC057 is now " + NPC_AI.NPC_057 + " is now at map location #" + NPC_AI.NPC057_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC057_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose057); }
                if (NPC_AI.bCorpse058)
                { Console.WriteLine("The dead! NPC058 is now " + NPC_AI.NPC_058 + " is now at map location #" + NPC_AI.NPC058_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC058_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose058); }
                if (NPC_AI.bCorpse059)
                { Console.WriteLine("The dead! NPC059 is now " + NPC_AI.NPC_059 + " is now at map location #" + NPC_AI.NPC059_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC059_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose059); }
                if (NPC_AI.bCorpse060)
                { Console.WriteLine("The dead! NPC060 is now " + NPC_AI.NPC_060 + " is now at map location #" + NPC_AI.NPC060_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC060_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose060); }
                if (NPC_AI.bCorpse061)
                { Console.WriteLine("The dead! NPC061 is now " + NPC_AI.NPC_061 + " is now at map location #" + NPC_AI.NPC061_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC061_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose061); }
                if (NPC_AI.bCorpse062)
                { Console.WriteLine("The dead! NPC062 is now " + NPC_AI.NPC_062 + " is now at map location #" + NPC_AI.NPC062_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC062_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose062); }
                if (NPC_AI.bCorpse063)
                { Console.WriteLine("The dead! NPC063 is now " + NPC_AI.NPC_063 + " is now at map location #" + NPC_AI.NPC063_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC063_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose063); }
                if (NPC_AI.bCorpse064)
                { Console.WriteLine("The dead! NPC064 is now " + NPC_AI.NPC_064 + " is now at map location #" + NPC_AI.NPC064_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC064_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose064); }
                if (NPC_AI.bCorpse065)
                { Console.WriteLine("The dead! NPC065 is now " + NPC_AI.NPC_065 + " is now at map location #" + NPC_AI.NPC065_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC065_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose065); }
                if (NPC_AI.bCorpse066)
                { Console.WriteLine("The dead! NPC066 is now " + NPC_AI.NPC_066 + " is now at map location #" + NPC_AI.NPC066_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC066_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose066); }
                if (NPC_AI.bCorpse067)
                { Console.WriteLine("The dead! NPC067 is now " + NPC_AI.NPC_067 + " is now at map location #" + NPC_AI.NPC067_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC067_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose067); }
                if (NPC_AI.bCorpse068)
                { Console.WriteLine("The dead! NPC068 is now " + NPC_AI.NPC_068 + " is now at map location #" + NPC_AI.NPC068_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC068_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose068); }
                if (NPC_AI.bCorpse069)
                { Console.WriteLine("The dead! NPC069 is now " + NPC_AI.NPC_069 + " is now at map location #" + NPC_AI.NPC069_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC069_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose069); }
                if (NPC_AI.bCorpse070)
                { Console.WriteLine("The dead! NPC070 is now " + NPC_AI.NPC_070 + " is now at map location #" + NPC_AI.NPC070_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC070_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose070); }
                if (NPC_AI.bCorpse071)
                { Console.WriteLine("The dead! NPC071 is now " + NPC_AI.NPC_071 + " is now at map location #" + NPC_AI.NPC071_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC071_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose071); }
                if (NPC_AI.bCorpse072)
                { Console.WriteLine("The dead! NPC072 is now " + NPC_AI.NPC_072 + " is now at map location #" + NPC_AI.NPC072_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC072_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose072); }
                if (NPC_AI.bCorpse073)
                { Console.WriteLine("The dead! NPC073 is now " + NPC_AI.NPC_073 + " is now at map location #" + NPC_AI.NPC073_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC073_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose073); }
                if (NPC_AI.bCorpse074)
                { Console.WriteLine("The dead! NPC074 is now " + NPC_AI.NPC_074 + " is now at map location #" + NPC_AI.NPC074_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC074_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose074); }
                if (NPC_AI.bCorpse075)
                { Console.WriteLine("The dead! NPC075 is now " + NPC_AI.NPC_075 + " is now at map location #" + NPC_AI.NPC075_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC075_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose075); }
                if (NPC_AI.bCorpse076)
                { Console.WriteLine("The dead! NPC076 is now " + NPC_AI.NPC_076 + " is now at map location #" + NPC_AI.NPC076_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC076_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose076); }
                if (NPC_AI.bCorpse077)
                { Console.WriteLine("The dead! NPC077 is now " + NPC_AI.NPC_077 + " is now at map location #" + NPC_AI.NPC077_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC077_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose077); }
                if (NPC_AI.bCorpse078)
                { Console.WriteLine("The dead! NPC078 is now " + NPC_AI.NPC_078 + " is now at map location #" + NPC_AI.NPC078_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC078_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose078); }
                if (NPC_AI.bCorpse079)
                { Console.WriteLine("The dead! NPC079 is now " + NPC_AI.NPC_079 + " is now at map location #" + NPC_AI.NPC079_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC079_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose079); }
                if (NPC_AI.bCorpse080)
                { Console.WriteLine("The dead! NPC080 is now " + NPC_AI.NPC_080 + " is now at map location #" + NPC_AI.NPC080_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC080_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose080); }
                if (NPC_AI.bCorpse081)
                { Console.WriteLine("The dead! NPC081 is now " + NPC_AI.NPC_081 + " is now at map location #" + NPC_AI.NPC081_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC081_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose081); }
                if (NPC_AI.bCorpse082)
                { Console.WriteLine("The dead! NPC082 is now " + NPC_AI.NPC_082 + " is now at map location #" + NPC_AI.NPC082_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC082_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose082); }
                if (NPC_AI.bCorpse083)
                { Console.WriteLine("The dead! NPC083 is now " + NPC_AI.NPC_083 + " is now at map location #" + NPC_AI.NPC083_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC083_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose083); }
                if (NPC_AI.bCorpse084)
                { Console.WriteLine("The dead! NPC084 is now " + NPC_AI.NPC_084 + " is now at map location #" + NPC_AI.NPC084_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC084_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose084); }
                if (NPC_AI.bCorpse085)
                { Console.WriteLine("The dead! NPC085 is now " + NPC_AI.NPC_085 + " is now at map location #" + NPC_AI.NPC085_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC085_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose085); }
                if (NPC_AI.bCorpse086)
                { Console.WriteLine("The dead! NPC086 is now " + NPC_AI.NPC_086 + " is now at map location #" + NPC_AI.NPC086_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC086_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose086); }
                if (NPC_AI.bCorpse087)
                { Console.WriteLine("The dead! NPC087 is now " + NPC_AI.NPC_087 + " is now at map location #" + NPC_AI.NPC087_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC087_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose087); }
                if (NPC_AI.bCorpse088)
                { Console.WriteLine("The dead! NPC088 is now " + NPC_AI.NPC_088 + " is now at map location #" + NPC_AI.NPC088_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC088_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose088); }
                if (NPC_AI.bCorpse089)
                { Console.WriteLine("The dead! NPC089 is now " + NPC_AI.NPC_089 + " is now at map location #" + NPC_AI.NPC089_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC089_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose089); }
                if (NPC_AI.bCorpse090)
                { Console.WriteLine("The dead! NPC090 is now " + NPC_AI.NPC_090 + " is now at map location #" + NPC_AI.NPC090_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC090_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose090); }
                if (NPC_AI.bCorpse091)
                { Console.WriteLine("The dead! NPC091 is now " + NPC_AI.NPC_091 + " is now at map location #" + NPC_AI.NPC091_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC091_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose091); }
                if (NPC_AI.bCorpse092)
                { Console.WriteLine("The dead! NPC092 is now " + NPC_AI.NPC_092 + " is now at map location #" + NPC_AI.NPC092_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC092_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose092); }
                if (NPC_AI.bCorpse093)
                { Console.WriteLine("The dead! NPC093 is now " + NPC_AI.NPC_093 + " is now at map location #" + NPC_AI.NPC093_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC093_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose093); }
                if (NPC_AI.bCorpse094)
                { Console.WriteLine("The dead! NPC094 is now " + NPC_AI.NPC_094 + " is now at map location #" + NPC_AI.NPC094_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC094_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose094); }
                if (NPC_AI.bCorpse095)
                { Console.WriteLine("The dead! NPC095 is now " + NPC_AI.NPC_095 + " is now at map location #" + NPC_AI.NPC095_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC095_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose095); }
                if (NPC_AI.bCorpse096)
                { Console.WriteLine("The dead! NPC096 is now " + NPC_AI.NPC_096 + " is now at map location #" + NPC_AI.NPC096_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC096_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose096); }
                if (NPC_AI.bCorpse097)
                { Console.WriteLine("The dead! NPC097 is now " + NPC_AI.NPC_097 + " is now at map location #" + NPC_AI.NPC097_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC097_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose097); }
                if (NPC_AI.bCorpse098)
                { Console.WriteLine("The dead! NPC098 is now " + NPC_AI.NPC_098 + " is now at map location #" + NPC_AI.NPC098_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC098_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose098); }
                if (NPC_AI.bCorpse099)
                { Console.WriteLine("The dead! NPC099 is now " + NPC_AI.NPC_099 + " is now at map location #" + NPC_AI.NPC099_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC099_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose099); }
                // no NPC_AI.bCorpse100 because the killer doesn't get auto-killed/shuffled like the other NPCs.

                Console.WriteLine();
                Console.WriteLine("DEBUG CHEATZ: Everyone else (the living) appears here.");
                Console.WriteLine();

                if (!NPC_AI.bCorpse001)
                { Console.WriteLine("The living! NPC001 is now " + NPC_AI.NPC_001 + " is now at map location #" + NPC_AI.NPC001_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC001_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose001); }
                if (!NPC_AI.bCorpse002)
                { Console.WriteLine("The living! NPC002 is now " + NPC_AI.NPC_002 + " is now at map location #" + NPC_AI.NPC002_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC002_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose002); }
                if (!NPC_AI.bCorpse003)
                { Console.WriteLine("The living! NPC003 is now " + NPC_AI.NPC_003 + " is now at map location #" + NPC_AI.NPC003_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC003_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose003); }
                if (!NPC_AI.bCorpse004)
                { Console.WriteLine("The living! NPC004 is now " + NPC_AI.NPC_004 + " is now at map location #" + NPC_AI.NPC004_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC004_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose004); }
                if (!NPC_AI.bCorpse005)
                { Console.WriteLine("The living! NPC005 is now " + NPC_AI.NPC_005 + " is now at map location #" + NPC_AI.NPC005_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC005_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose005); }
                if (!NPC_AI.bCorpse006)
                { Console.WriteLine("The living! NPC006 is now " + NPC_AI.NPC_006 + " is now at map location #" + NPC_AI.NPC006_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC006_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose006); }
                if (!NPC_AI.bCorpse007)
                { Console.WriteLine("The living! NPC007 is now " + NPC_AI.NPC_007 + " is now at map location #" + NPC_AI.NPC007_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC007_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose007); }
                if (!NPC_AI.bCorpse008)
                { Console.WriteLine("The living! NPC008 is now " + NPC_AI.NPC_008 + " is now at map location #" + NPC_AI.NPC008_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC008_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose008); }
                if (!NPC_AI.bCorpse009)
                { Console.WriteLine("The living! NPC009 is now " + NPC_AI.NPC_009 + " is now at map location #" + NPC_AI.NPC009_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC009_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose009); }
                if (!NPC_AI.bCorpse010)
                { Console.WriteLine("The living! NPC010 is now " + NPC_AI.NPC_010 + " is now at map location #" + NPC_AI.NPC010_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC010_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose010); }
                if (!NPC_AI.bCorpse011)
                { Console.WriteLine("The living! NPC011 is now " + NPC_AI.NPC_011 + " is now at map location #" + NPC_AI.NPC011_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC011_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose011); }
                if (!NPC_AI.bCorpse012)
                { Console.WriteLine("The living! NPC012 is now " + NPC_AI.NPC_012 + " is now at map location #" + NPC_AI.NPC012_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC012_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose012); }
                if (!NPC_AI.bCorpse013)
                { Console.WriteLine("The living! NPC013 is now " + NPC_AI.NPC_013 + " is now at map location #" + NPC_AI.NPC013_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC013_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose013); }
                if (!NPC_AI.bCorpse014)
                { Console.WriteLine("The living! NPC014 is now " + NPC_AI.NPC_014 + " is now at map location #" + NPC_AI.NPC014_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC014_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose014); }
                if (!NPC_AI.bCorpse015)
                { Console.WriteLine("The living! NPC015 is now " + NPC_AI.NPC_015 + " is now at map location #" + NPC_AI.NPC015_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC015_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose015); }
                if (!NPC_AI.bCorpse016)
                { Console.WriteLine("The living! NPC016 is now " + NPC_AI.NPC_016 + " is now at map location #" + NPC_AI.NPC016_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC016_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose016); }
                if (!NPC_AI.bCorpse017)
                { Console.WriteLine("The living! NPC017 is now " + NPC_AI.NPC_017 + " is now at map location #" + NPC_AI.NPC017_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC017_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose017); }
                if (!NPC_AI.bCorpse018)
                { Console.WriteLine("The living! NPC018 is now " + NPC_AI.NPC_018 + " is now at map location #" + NPC_AI.NPC018_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC018_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose018); }
                if (!NPC_AI.bCorpse019)
                { Console.WriteLine("The living! NPC019 is now " + NPC_AI.NPC_019 + " is now at map location #" + NPC_AI.NPC019_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC019_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose019); }
                if (!NPC_AI.bCorpse020)
                { Console.WriteLine("The living! NPC020 is now " + NPC_AI.NPC_020 + " is now at map location #" + NPC_AI.NPC020_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC020_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose020); }
                if (!NPC_AI.bCorpse021)
                { Console.WriteLine("The living! NPC021 is now " + NPC_AI.NPC_021 + " is now at map location #" + NPC_AI.NPC021_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC021_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose021); }
                if (!NPC_AI.bCorpse022)
                { Console.WriteLine("The living! NPC022 is now " + NPC_AI.NPC_022 + " is now at map location #" + NPC_AI.NPC022_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC022_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose022); }
                if (!NPC_AI.bCorpse023)
                { Console.WriteLine("The living! NPC023 is now " + NPC_AI.NPC_023 + " is now at map location #" + NPC_AI.NPC023_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC023_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose023); }
                if (!NPC_AI.bCorpse024)
                { Console.WriteLine("The living! NPC024 is now " + NPC_AI.NPC_024 + " is now at map location #" + NPC_AI.NPC024_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC024_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose024); }
                if (!NPC_AI.bCorpse025)
                { Console.WriteLine("The living! NPC025 is now " + NPC_AI.NPC_025 + " is now at map location #" + NPC_AI.NPC025_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC025_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose025); }
                if (!NPC_AI.bCorpse026)
                { Console.WriteLine("The living! NPC026 is now " + NPC_AI.NPC_026 + " is now at map location #" + NPC_AI.NPC026_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC026_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose026); }
                if (!NPC_AI.bCorpse027)
                { Console.WriteLine("The living! NPC027 is now " + NPC_AI.NPC_027 + " is now at map location #" + NPC_AI.NPC027_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC027_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose027); }
                if (!NPC_AI.bCorpse028)
                { Console.WriteLine("The living! NPC028 is now " + NPC_AI.NPC_028 + " is now at map location #" + NPC_AI.NPC028_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC028_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose028); }
                if (!NPC_AI.bCorpse029)
                { Console.WriteLine("The living! NPC029 is now " + NPC_AI.NPC_029 + " is now at map location #" + NPC_AI.NPC029_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC029_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose029); }
                if (!NPC_AI.bCorpse030)
                { Console.WriteLine("The living! NPC030 is now " + NPC_AI.NPC_030 + " is now at map location #" + NPC_AI.NPC030_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC030_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose030); }
                if (!NPC_AI.bCorpse031)
                { Console.WriteLine("The living! NPC031 is now " + NPC_AI.NPC_031 + " is now at map location #" + NPC_AI.NPC031_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC031_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose031); }
                if (!NPC_AI.bCorpse032)
                { Console.WriteLine("The living! NPC032 is now " + NPC_AI.NPC_032 + " is now at map location #" + NPC_AI.NPC032_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC032_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose032); }
                if (!NPC_AI.bCorpse033)
                { Console.WriteLine("The living! NPC033 is now " + NPC_AI.NPC_033 + " is now at map location #" + NPC_AI.NPC033_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC033_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose033); }
                if (!NPC_AI.bCorpse034)
                { Console.WriteLine("The living! NPC034 is now " + NPC_AI.NPC_034 + " is now at map location #" + NPC_AI.NPC034_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC034_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose034); }
                if (!NPC_AI.bCorpse035)
                { Console.WriteLine("The living! NPC035 is now " + NPC_AI.NPC_035 + " is now at map location #" + NPC_AI.NPC035_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC035_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose035); }
                if (!NPC_AI.bCorpse036)
                { Console.WriteLine("The living! NPC036 is now " + NPC_AI.NPC_036 + " is now at map location #" + NPC_AI.NPC036_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC036_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose036); }
                if (!NPC_AI.bCorpse037)
                { Console.WriteLine("The living! NPC037 is now " + NPC_AI.NPC_037 + " is now at map location #" + NPC_AI.NPC037_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC037_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose037); }
                if (!NPC_AI.bCorpse038)
                { Console.WriteLine("The living! NPC038 is now " + NPC_AI.NPC_038 + " is now at map location #" + NPC_AI.NPC038_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC038_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose038); }
                if (!NPC_AI.bCorpse039)
                { Console.WriteLine("The living! NPC039 is now " + NPC_AI.NPC_039 + " is now at map location #" + NPC_AI.NPC039_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC039_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose039); }
                if (!NPC_AI.bCorpse040)
                { Console.WriteLine("The living! NPC040 is now " + NPC_AI.NPC_040 + " is now at map location #" + NPC_AI.NPC040_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC040_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose040); }
                if (!NPC_AI.bCorpse041)
                { Console.WriteLine("The living! NPC041 is now " + NPC_AI.NPC_041 + " is now at map location #" + NPC_AI.NPC041_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC041_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose041); }
                if (!NPC_AI.bCorpse042)
                { Console.WriteLine("The living! NPC042 is now " + NPC_AI.NPC_042 + " is now at map location #" + NPC_AI.NPC042_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC042_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose042); }
                if (!NPC_AI.bCorpse043)
                { Console.WriteLine("The living! NPC043 is now " + NPC_AI.NPC_043 + " is now at map location #" + NPC_AI.NPC043_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC043_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose043); }
                if (!NPC_AI.bCorpse044)
                { Console.WriteLine("The living! NPC044 is now " + NPC_AI.NPC_044 + " is now at map location #" + NPC_AI.NPC044_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC044_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose044); }
                if (!NPC_AI.bCorpse045)
                { Console.WriteLine("The living! NPC045 is now " + NPC_AI.NPC_045 + " is now at map location #" + NPC_AI.NPC045_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC045_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose045); }
                if (!NPC_AI.bCorpse046)
                { Console.WriteLine("The living! NPC046 is now " + NPC_AI.NPC_046 + " is now at map location #" + NPC_AI.NPC046_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC046_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose046); }
                if (!NPC_AI.bCorpse047)
                { Console.WriteLine("The living! NPC047 is now " + NPC_AI.NPC_047 + " is now at map location #" + NPC_AI.NPC047_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC047_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose047); }
                if (!NPC_AI.bCorpse048)
                { Console.WriteLine("The living! NPC048 is now " + NPC_AI.NPC_048 + " is now at map location #" + NPC_AI.NPC048_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC048_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose048); }
                if (!NPC_AI.bCorpse049)
                { Console.WriteLine("The living! NPC049 is now " + NPC_AI.NPC_049 + " is now at map location #" + NPC_AI.NPC049_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC049_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose049); }
                if (!NPC_AI.bCorpse050)
                { Console.WriteLine("The living! NPC050 is now " + NPC_AI.NPC_050 + " is now at map location #" + NPC_AI.NPC050_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC050_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose050); }
                if (!NPC_AI.bCorpse051)
                { Console.WriteLine("The living! NPC051 is now " + NPC_AI.NPC_051 + " is now at map location #" + NPC_AI.NPC051_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC051_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose051); }
                if (!NPC_AI.bCorpse052)
                { Console.WriteLine("The living! NPC052 is now " + NPC_AI.NPC_052 + " is now at map location #" + NPC_AI.NPC052_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC052_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose052); }
                if (!NPC_AI.bCorpse053)
                { Console.WriteLine("The living! NPC053 is now " + NPC_AI.NPC_053 + " is now at map location #" + NPC_AI.NPC053_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC053_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose053); }
                if (!NPC_AI.bCorpse054)
                { Console.WriteLine("The living! NPC054 is now " + NPC_AI.NPC_054 + " is now at map location #" + NPC_AI.NPC054_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC054_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose054); }
                if (!NPC_AI.bCorpse055)
                { Console.WriteLine("The living! NPC055 is now " + NPC_AI.NPC_055 + " is now at map location #" + NPC_AI.NPC055_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC055_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose055); }
                if (!NPC_AI.bCorpse056)
                { Console.WriteLine("The living! NPC056 is now " + NPC_AI.NPC_056 + " is now at map location #" + NPC_AI.NPC056_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC056_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose056); }
                if (!NPC_AI.bCorpse057)
                { Console.WriteLine("The living! NPC057 is now " + NPC_AI.NPC_057 + " is now at map location #" + NPC_AI.NPC057_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC057_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose057); }
                if (!NPC_AI.bCorpse058)
                { Console.WriteLine("The living! NPC058 is now " + NPC_AI.NPC_058 + " is now at map location #" + NPC_AI.NPC058_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC058_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose058); }
                if (!NPC_AI.bCorpse059)
                { Console.WriteLine("The living! NPC059 is now " + NPC_AI.NPC_059 + " is now at map location #" + NPC_AI.NPC059_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC059_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose059); }
                if (!NPC_AI.bCorpse060)
                { Console.WriteLine("The living! NPC060 is now " + NPC_AI.NPC_060 + " is now at map location #" + NPC_AI.NPC060_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC060_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose060); }
                if (!NPC_AI.bCorpse061)
                { Console.WriteLine("The living! NPC061 is now " + NPC_AI.NPC_061 + " is now at map location #" + NPC_AI.NPC061_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC061_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose061); }
                if (!NPC_AI.bCorpse062)
                { Console.WriteLine("The living! NPC062 is now " + NPC_AI.NPC_062 + " is now at map location #" + NPC_AI.NPC062_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC062_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose062); }
                if (!NPC_AI.bCorpse063)
                { Console.WriteLine("The living! NPC063 is now " + NPC_AI.NPC_063 + " is now at map location #" + NPC_AI.NPC063_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC063_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose063); }
                if (!NPC_AI.bCorpse064)
                { Console.WriteLine("The living! NPC064 is now " + NPC_AI.NPC_064 + " is now at map location #" + NPC_AI.NPC064_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC064_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose064); }
                if (!NPC_AI.bCorpse065)
                { Console.WriteLine("The living! NPC065 is now " + NPC_AI.NPC_065 + " is now at map location #" + NPC_AI.NPC065_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC065_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose065); }
                if (!NPC_AI.bCorpse066)
                { Console.WriteLine("The living! NPC066 is now " + NPC_AI.NPC_066 + " is now at map location #" + NPC_AI.NPC066_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC066_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose066); }
                if (!NPC_AI.bCorpse067)
                { Console.WriteLine("The living! NPC067 is now " + NPC_AI.NPC_067 + " is now at map location #" + NPC_AI.NPC067_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC067_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose067); }
                if (!NPC_AI.bCorpse068)
                { Console.WriteLine("The living! NPC068 is now " + NPC_AI.NPC_068 + " is now at map location #" + NPC_AI.NPC068_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC068_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose068); }
                if (!NPC_AI.bCorpse069)
                { Console.WriteLine("The living! NPC069 is now " + NPC_AI.NPC_069 + " is now at map location #" + NPC_AI.NPC069_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC069_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose069); }
                if (!NPC_AI.bCorpse070)
                { Console.WriteLine("The living! NPC070 is now " + NPC_AI.NPC_070 + " is now at map location #" + NPC_AI.NPC070_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC070_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose070); }
                if (!NPC_AI.bCorpse071)
                { Console.WriteLine("The living! NPC071 is now " + NPC_AI.NPC_071 + " is now at map location #" + NPC_AI.NPC071_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC071_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose071); }
                if (!NPC_AI.bCorpse072)
                { Console.WriteLine("The living! NPC072 is now " + NPC_AI.NPC_072 + " is now at map location #" + NPC_AI.NPC072_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC072_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose072); }
                if (!NPC_AI.bCorpse073)
                { Console.WriteLine("The living! NPC073 is now " + NPC_AI.NPC_073 + " is now at map location #" + NPC_AI.NPC073_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC073_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose073); }
                if (!NPC_AI.bCorpse074)
                { Console.WriteLine("The living! NPC074 is now " + NPC_AI.NPC_074 + " is now at map location #" + NPC_AI.NPC074_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC074_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose074); }
                if (!NPC_AI.bCorpse075)
                { Console.WriteLine("The living! NPC075 is now " + NPC_AI.NPC_075 + " is now at map location #" + NPC_AI.NPC075_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC075_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose075); }
                if (!NPC_AI.bCorpse076)
                { Console.WriteLine("The living! NPC076 is now " + NPC_AI.NPC_076 + " is now at map location #" + NPC_AI.NPC076_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC076_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose076); }
                if (!NPC_AI.bCorpse077)
                { Console.WriteLine("The living! NPC077 is now " + NPC_AI.NPC_077 + " is now at map location #" + NPC_AI.NPC077_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC077_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose077); }
                if (!NPC_AI.bCorpse078)
                { Console.WriteLine("The living! NPC078 is now " + NPC_AI.NPC_078 + " is now at map location #" + NPC_AI.NPC078_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC078_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose078); }
                if (!NPC_AI.bCorpse079)
                { Console.WriteLine("The living! NPC079 is now " + NPC_AI.NPC_079 + " is now at map location #" + NPC_AI.NPC079_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC079_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose079); }
                if (!NPC_AI.bCorpse080)
                { Console.WriteLine("The living! NPC080 is now " + NPC_AI.NPC_080 + " is now at map location #" + NPC_AI.NPC080_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC080_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose080); }
                if (!NPC_AI.bCorpse081)
                { Console.WriteLine("The living! NPC081 is now " + NPC_AI.NPC_081 + " is now at map location #" + NPC_AI.NPC081_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC081_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose081); }
                if (!NPC_AI.bCorpse082)
                { Console.WriteLine("The living! NPC082 is now " + NPC_AI.NPC_082 + " is now at map location #" + NPC_AI.NPC082_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC082_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose082); }
                if (!NPC_AI.bCorpse083)
                { Console.WriteLine("The living! NPC083 is now " + NPC_AI.NPC_083 + " is now at map location #" + NPC_AI.NPC083_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC083_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose083); }
                if (!NPC_AI.bCorpse084)
                { Console.WriteLine("The living! NPC084 is now " + NPC_AI.NPC_084 + " is now at map location #" + NPC_AI.NPC084_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC084_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose084); }
                if (!NPC_AI.bCorpse085)
                { Console.WriteLine("The living! NPC085 is now " + NPC_AI.NPC_085 + " is now at map location #" + NPC_AI.NPC085_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC085_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose085); }
                if (!NPC_AI.bCorpse086)
                { Console.WriteLine("The living! NPC086 is now " + NPC_AI.NPC_086 + " is now at map location #" + NPC_AI.NPC086_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC086_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose086); }
                if (!NPC_AI.bCorpse087)
                { Console.WriteLine("The living! NPC087 is now " + NPC_AI.NPC_087 + " is now at map location #" + NPC_AI.NPC087_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC087_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose087); }
                if (!NPC_AI.bCorpse088)
                { Console.WriteLine("The living! NPC088 is now " + NPC_AI.NPC_088 + " is now at map location #" + NPC_AI.NPC088_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC088_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose088); }
                if (!NPC_AI.bCorpse089)
                { Console.WriteLine("The living! NPC089 is now " + NPC_AI.NPC_089 + " is now at map location #" + NPC_AI.NPC089_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC089_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose089); }
                if (!NPC_AI.bCorpse090)
                { Console.WriteLine("The living! NPC090 is now " + NPC_AI.NPC_090 + " is now at map location #" + NPC_AI.NPC090_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC090_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose090); }
                if (!NPC_AI.bCorpse091)
                { Console.WriteLine("The living! NPC091 is now " + NPC_AI.NPC_091 + " is now at map location #" + NPC_AI.NPC091_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC091_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose091); }
                if (!NPC_AI.bCorpse092)
                { Console.WriteLine("The living! NPC092 is now " + NPC_AI.NPC_092 + " is now at map location #" + NPC_AI.NPC092_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC092_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose092); }
                if (!NPC_AI.bCorpse093)
                { Console.WriteLine("The living! NPC093 is now " + NPC_AI.NPC_093 + " is now at map location #" + NPC_AI.NPC093_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC093_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose093); }
                if (!NPC_AI.bCorpse094)
                { Console.WriteLine("The living! NPC094 is now " + NPC_AI.NPC_094 + " is now at map location #" + NPC_AI.NPC094_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC094_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose094); }
                if (!NPC_AI.bCorpse095)
                { Console.WriteLine("The living! NPC095 is now " + NPC_AI.NPC_095 + " is now at map location #" + NPC_AI.NPC095_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC095_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose095); }
                if (!NPC_AI.bCorpse096)
                { Console.WriteLine("The living! NPC096 is now " + NPC_AI.NPC_096 + " is now at map location #" + NPC_AI.NPC096_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC096_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose096); }
                if (!NPC_AI.bCorpse097)
                { Console.WriteLine("The living! NPC097 is now " + NPC_AI.NPC_097 + " is now at map location #" + NPC_AI.NPC097_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC097_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose097); }
                if (!NPC_AI.bCorpse098)
                { Console.WriteLine("The living! NPC098 is now " + NPC_AI.NPC_098 + " is now at map location #" + NPC_AI.NPC098_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC098_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose098); }
                if (!NPC_AI.bCorpse099)
                { Console.WriteLine("The living! NPC099 is now " + NPC_AI.NPC_099 + " is now at map location #" + NPC_AI.NPC099_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC099_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose099); }
                else { }
                Console.WriteLine();
                Console.WriteLine("DEBUG CHEATZ: And, finally, our killer... <Hit any key to return to the game.>");
                Console.WriteLine();
                Console.WriteLine("The killer! NPC100 is now " + NPC_AI.NPC_100 + " and is at map location #" + NPC_AI.NPC100_CurrentNumLocation + " a.k.a. " + NPC_AI.NPC100_CurrentStrLocation + "; Times Seen: " + NPC_AI.iClose100);
                // Variables.iRemainingTurns++ // add one turn so that the player doesn't lose a turn for cheating
                // it should already be false, of course.
            }
            Program.PressAnyKey();
        }

        public static void Option_Cheat_GimmeTheFirstClue()
        {
            // Console.WriteLine(Conversation.sLine500, NPC_Traits.TraitOneBunny);
            NPC_Traits.bTraitOneBunny = true; /*bTraitOneBunny = false;*/ LocationEncounters.bNothingHappening = false; // nothinghappening keeps random encounters from launching at the same time
            TheBunny.iBunnyLocation = 0;
            TheBunny.iBunnyDodge = 999; // must be greater than 2 to catch the second bunny scene
            TheBunny.iBunnyStage = 2;
            NPC_Traits.bTraitOne01Bunny = true;
            Program.PressAnyKey();
        }

        public static void Option_Cheat_GimmeTheSecondClue()
        {
            // Console.WriteLine(sLine501, TraitTwoBunny);
            NPC_Traits.bTraitTwoBunny = true; NPC_Traits.bTraitOneBunny = false; LocationEncounters.bNothingHappening = false; // nothinghappening keeps random encounters from launching at the same time
            TheBunny.iBunnyLocation = 0;
            TheBunny.iBunnyStage = 3;
            TheBunny.iBunnyDodge = 0;
            NPC_Traits.bTraitTwo01Bunny = true;
            Program.PressAnyKey();
        }

        public static void Option_Cheat_GimmeTheThirdClue()
        {
            // Console.WriteLine(sLine502, TraitThreeBunny);
            NPC_Traits.bTraitThreeBunny = true; NPC_Traits.bTraitTwoBunny = false; NPC_Traits.bTraitOneBunny = false; LocationEncounters.bNothingHappening = false; // nothinghappening "helps" random encounters from launching at the same time, if the player is actively pursuing bunny
            TheBunny.iBunnyLocation = 0;
            TheBunny.iBunnyStage = 5;
            TheBunny.iBunnyGift = 3;
            NPC_Traits.bTraitThree01Bunny = true;
            Program.PressAnyKey();
        }

        public static void Option_Cheat_KillNPC099()
        {
            NPC_AI.bCorpse099 = true;
        }

        public static void Option_Cheat_JumpForwardInTime()
        {
            Variables.iRemainingTurns = Variables.iTurn50 + 2;
        }

        public static void Option_SearchForItems()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("You decide to investigate the area to see if you can find something useful.");
            Console.WriteLine();
            if (Variables.bAboutToDie == true)
            {
                if (Variables.weaponName == NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("But you feel so tired, much too tired to look around. You decide,");
                    Console.WriteLine("instead, to lie down. The water is so warm, and wraps around you like a");
                    Console.WriteLine("blanket. You close your eyes and float away, a smile on your face.");
                    Variables.playerSurvived = Variables.sPlayerState1;
                    Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                }
                else if (Variables.weaponName != NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("But you feel so tired, much too tired to look around. The idea of lying");
                    Console.WriteLine("down in the water feels so good, seems so right. And you're about to do");
                    Console.WriteLine("it when you realize there's a " + Variables.weaponName + " in your hand. You toss");
                    Console.WriteLine("it at " + NPC_AI.NPC_100 + " and in the process feel some energy return to you.");
                    Console.WriteLine("You have a second chance to run away, if you would take it.");
                    Variables.weaponName = NPC_AI.sWeaponType0;
                }
            }
            if (Variables.bAboutToDie == false)
            {
                if (
                (Variables.iCurrentLocation == 1 && Search.bSearchedLocation_A01 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 2 && Search.bSearchedLocation_A02 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 3 && Search.bSearchedLocation_A03 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 4 && Search.bSearchedLocation_A04 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 5 && Search.bSearchedLocation_A05 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 6 && Search.bSearchedLocation_A06 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 7 && Search.bSearchedLocation_A07 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 8 && Search.bSearchedLocation_A08 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 9 && Search.bSearchedLocation_A09 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 10 && Search.bSearchedLocation_A10 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 11 && Search.bSearchedLocation_A11 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 12 && Search.bSearchedLocation_A12 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 13 && Search.bSearchedLocation_A13 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 14 && Search.bSearchedLocation_A14 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 15 && Search.bSearchedLocation_A15 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 16 && Search.bSearchedLocation_A16 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 17 && Search.bSearchedLocation_A17 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 18 && Search.bSearchedLocation_A18 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 19 && Search.bSearchedLocation_A19 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 20 && Search.bSearchedLocation_A20 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 21 && Search.bSearchedLocation_A21 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 22 && Search.bSearchedLocation_A22 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 23 && Search.bSearchedLocation_A23 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 24 && Search.bSearchedLocation_A24 && !LocationEncounters.bLightHouseUsed) ||
                (Variables.iCurrentLocation == 25 && Search.bSearchedLocation_A25 && !LocationEncounters.bLightHouseUsed))
                {
                    Console.WriteLine("Unfortunately, you have already searched this area. There is nothing");
                    Console.WriteLine("new to find here.");
                    Program.PressAnyKey();
                    return;
                }

                if (
                (Variables.iCurrentLocation == 1 && Search.bSearchedLocation_B01) ||
                (Variables.iCurrentLocation == 2 && Search.bSearchedLocation_B02) ||
                (Variables.iCurrentLocation == 3 && Search.bSearchedLocation_B03) ||
                (Variables.iCurrentLocation == 4 && Search.bSearchedLocation_B04) ||
                (Variables.iCurrentLocation == 5 && Search.bSearchedLocation_B05) ||
                (Variables.iCurrentLocation == 6 && Search.bSearchedLocation_B06) ||
                (Variables.iCurrentLocation == 7 && Search.bSearchedLocation_B07) ||
                (Variables.iCurrentLocation == 8 && Search.bSearchedLocation_B08) ||
                (Variables.iCurrentLocation == 9 && Search.bSearchedLocation_B09) ||
                (Variables.iCurrentLocation == 10 && Search.bSearchedLocation_B10) ||
                (Variables.iCurrentLocation == 11 && Search.bSearchedLocation_B11) ||
                (Variables.iCurrentLocation == 12 && Search.bSearchedLocation_B12) ||
                (Variables.iCurrentLocation == 13 && Search.bSearchedLocation_B13) ||
                (Variables.iCurrentLocation == 14 && Search.bSearchedLocation_B14) ||
                (Variables.iCurrentLocation == 15 && Search.bSearchedLocation_B15) ||
                (Variables.iCurrentLocation == 16 && Search.bSearchedLocation_B16) ||
                (Variables.iCurrentLocation == 17 && Search.bSearchedLocation_B17) ||
                (Variables.iCurrentLocation == 18 && Search.bSearchedLocation_B18) ||
                (Variables.iCurrentLocation == 19 && Search.bSearchedLocation_B19) ||
                (Variables.iCurrentLocation == 20 && Search.bSearchedLocation_B20) ||
                (Variables.iCurrentLocation == 21 && Search.bSearchedLocation_B21) ||
                (Variables.iCurrentLocation == 22 && Search.bSearchedLocation_B22) ||
                (Variables.iCurrentLocation == 23 && Search.bSearchedLocation_B23) ||
                (Variables.iCurrentLocation == 24 && Search.bSearchedLocation_B24) ||
                (Variables.iCurrentLocation == 25 && Search.bSearchedLocation_B25))
                {
                    Console.WriteLine("Having already searched this area after activating the lighthouse, you");
                    Console.WriteLine("are certain there is nothing left to be found here.");
                    Program.PressAnyKey();
                    return;
                }

                if (!LocationEncounters.bLightHouseUsed)
                {
                    NPC_AI.iPlayerSearch = Program.rand.Next(1, 101);
                    if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 55)
                    {
                        Console.WriteLine("You spot a metallic glint. You look closer.");
                        Console.WriteLine();
                        NPC_AI.iPlayerSearch = Program.rand.Next(1, 101);
                        if (RandomEncounters.bMetalDetector)
                        {
                            NPC_AI.iPlayerSearch = 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your fish-acquired talent for finding MacGuffins kicks in.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                        if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 40)
                        {
                            Console.WriteLine("It's a MacGuffin. You tuck it away into your pocket.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 1 MacGuffin.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 1;
                        }
                        else if (NPC_AI.iPlayerSearch >= 41 && NPC_AI.iPlayerSearch <= 80)
                        {
                            Console.WriteLine("Surprise! It's two MacGuffins. You tuck them away into your pocket.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 2 MacGuffins.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 2;
                        }
                        else
                        {
                            Console.WriteLine("Lucky day, it's three MacGuffins. You tuck them away into your pocket.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 3 MacGuffins.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 3;
                        }
                    }
                    else if (NPC_AI.iPlayerSearch >= 56 && NPC_AI.iPlayerSearch <= 90)
                    {
                        Console.WriteLine("You think you see something. You look closer.");
                        NPC_AI.iPlayerSearch = Program.rand.Next(1, 101);
                        if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 40)
                        {
                            Console.WriteLine("You thought you saw a MacGuffin. But it's actually nothing.");
                        }
                        else if (NPC_AI.iPlayerSearch >= 41 && NPC_AI.iPlayerSearch <= 80)
                        {
                            Console.WriteLine("You found a weapon, but it's broken. You leave it where it was.");
                        }
                        else
                        {
                            Console.WriteLine("It turns out it's nothing useful at all.");
                        }
                    }
                    else
                    {
                        if (Variables.weaponName != NPC_AI.sWeaponType0)
                        {
                            Console.WriteLine("You found something you could use as a weapon, but what you have is better.");
                            Console.WriteLine("You leave it where it is.");
                        }
                        else
                        {
                            Console.WriteLine("You found something to protect yourself with.");
                            Variables.foundWeapon = true;
                            if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 35)
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType1 + ". It's heavy to hold, but it'll hurt someone.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType1 + ".");
                                Variables.weaponName = NPC_AI.sWeaponType1;
                            }
                            else if (NPC_AI.iPlayerSearch >= 36 && NPC_AI.iPlayerSearch <= 70)
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType2 + ". It doesn't look durable, but it'll do some damage.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType2 + ".");
                                Variables.weaponName = NPC_AI.sWeaponType2;
                            }
                            else
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType3 + ". This will do nicely.");
                                Variables.weaponName = NPC_AI.sWeaponType3;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType3 + ".");
                            }
                        }
                    }
                    if (Variables.iCurrentLocation == 1 && !Search.bSearchedLocation_A01) { Search.bSearchedLocation_A01 = true; }
                    if (Variables.iCurrentLocation == 2 && !Search.bSearchedLocation_A02) { Search.bSearchedLocation_A02 = true; }
                    if (Variables.iCurrentLocation == 3 && !Search.bSearchedLocation_A03) { Search.bSearchedLocation_A03 = true; }
                    if (Variables.iCurrentLocation == 4 && !Search.bSearchedLocation_A04) { Search.bSearchedLocation_A04 = true; }
                    if (Variables.iCurrentLocation == 5 && !Search.bSearchedLocation_A05) { Search.bSearchedLocation_A05 = true; }
                    if (Variables.iCurrentLocation == 6 && !Search.bSearchedLocation_A06) { Search.bSearchedLocation_A06 = true; }
                    if (Variables.iCurrentLocation == 7 && !Search.bSearchedLocation_A07) { Search.bSearchedLocation_A07 = true; }
                    if (Variables.iCurrentLocation == 8 && !Search.bSearchedLocation_A08) { Search.bSearchedLocation_A08 = true; }
                    if (Variables.iCurrentLocation == 9 && !Search.bSearchedLocation_A09) { Search.bSearchedLocation_A09 = true; }
                    if (Variables.iCurrentLocation == 10 && !Search.bSearchedLocation_A10) { Search.bSearchedLocation_A10 = true; }
                    if (Variables.iCurrentLocation == 11 && !Search.bSearchedLocation_A11) { Search.bSearchedLocation_A11 = true; }
                    if (Variables.iCurrentLocation == 12 && !Search.bSearchedLocation_A12) { Search.bSearchedLocation_A12 = true; }
                    if (Variables.iCurrentLocation == 13 && !Search.bSearchedLocation_A13) { Search.bSearchedLocation_A13 = true; }
                    if (Variables.iCurrentLocation == 14 && !Search.bSearchedLocation_A14) { Search.bSearchedLocation_A14 = true; }
                    if (Variables.iCurrentLocation == 15 && !Search.bSearchedLocation_A15) { Search.bSearchedLocation_A15 = true; }
                    if (Variables.iCurrentLocation == 16 && !Search.bSearchedLocation_A16) { Search.bSearchedLocation_A16 = true; }
                    if (Variables.iCurrentLocation == 17 && !Search.bSearchedLocation_A17) { Search.bSearchedLocation_A17 = true; }
                    if (Variables.iCurrentLocation == 18 && !Search.bSearchedLocation_A18) { Search.bSearchedLocation_A18 = true; }
                    if (Variables.iCurrentLocation == 19 && !Search.bSearchedLocation_A19) { Search.bSearchedLocation_A19 = true; }
                    if (Variables.iCurrentLocation == 20 && !Search.bSearchedLocation_A20) { Search.bSearchedLocation_A20 = true; }
                    if (Variables.iCurrentLocation == 21 && !Search.bSearchedLocation_A21) { Search.bSearchedLocation_A21 = true; }
                    if (Variables.iCurrentLocation == 22 && !Search.bSearchedLocation_A22) { Search.bSearchedLocation_A22 = true; }
                    if (Variables.iCurrentLocation == 23 && !Search.bSearchedLocation_A23) { Search.bSearchedLocation_A23 = true; }
                    if (Variables.iCurrentLocation == 24 && !Search.bSearchedLocation_A24) { Search.bSearchedLocation_A24 = true; }
                    if (Variables.iCurrentLocation == 25 && !Search.bSearchedLocation_A25) { Search.bSearchedLocation_A25 = true; }
                }
                if (LocationEncounters.bLightHouseUsed)
                {
                    Console.WriteLine("As you look around, you see faint shimmering highlighting various");
                    Console.WriteLine("objects on the ground. It must be a result of activating the lighthouse,");
                    Console.WriteLine("you think. This certainly makes it much easier to see if there's anything");
                    Console.WriteLine("useful lying around.");
                    Console.WriteLine();
                    NPC_AI.iPlayerSearch = Program.rand.Next(1, 101);
                    if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 75)
                    {
                        NPC_AI.iPlayerSearch = Program.rand.Next(1, 101);
                        if (RandomEncounters.bMetalDetector) 
                        {
                            NPC_AI.iPlayerSearch = 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your fish-acquired talent for finding MacGuffins kicks in.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                        }
                        if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 74)
                        {
                            Console.WriteLine("It doesn't take you long at all to track down three MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 3 MacGuffins.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 3;
                        }
                        else if (NPC_AI.iPlayerSearch >= 75 && NPC_AI.iPlayerSearch <= 89)
                        {
                            Console.WriteLine("You spot a couple MacGuffins right away, but thanks to the effect from");
                            Console.WriteLine("the lighthouse you spot another two MacGuffins shortly after.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 4 MacGuffins.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 4;
                        }
                        else if (NPC_AI.iPlayerSearch >= 90)
                        {
                            Console.WriteLine("You spot a MacGuffin right away, and as you pocket it you spot another,");
                            Console.WriteLine("and then another. As you grab those two, you spot three more. Lucky");
                            Console.WriteLine("day, that's six MacGuffins quickly found.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 6 MacGuffins.");
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 6;
                        }
                    }
                    else if (NPC_AI.iPlayerSearch >= 76 && NPC_AI.iPlayerSearch <= 85)
                    {
                        Console.WriteLine("You think you see something. You look closer.");
                        Console.WriteLine("You spot one lonely MacGuffin. One is better than none.");
                        Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 1;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   Gained 1 MacGuffin.");
                    }
                    else if (NPC_AI.iPlayerSearch >= 86 && NPC_AI.iPlayerSearch <= 100)
                    {
                        if (Variables.weaponName != NPC_AI.sWeaponType0)
                        {
                            Console.WriteLine("You found something to use as a weapon, but what you have is better.");
                            Console.WriteLine("You leave it where it is.");
                        }
                        else
                        {
                            Console.WriteLine("You found something to protect yourself with.");
                            Variables.foundWeapon = true;
                            if (NPC_AI.iPlayerSearch >= 1 && NPC_AI.iPlayerSearch <= 35)
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType1 + ". It's heavy to hold, but it'll hurt someone.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType1 + ".");
                                Variables.weaponName = NPC_AI.sWeaponType1;
                            }
                            else if (NPC_AI.iPlayerSearch >= 36 && NPC_AI.iPlayerSearch <= 70)
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType2 + ". It doesn't look durable, but it'll do some damage.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType2 + ".");
                                Variables.weaponName = NPC_AI.sWeaponType2;
                            }
                            else
                            {
                                Console.WriteLine("You found a " + NPC_AI.sWeaponType3 + ". This will do nicely for now.");
                                Variables.weaponName = NPC_AI.sWeaponType3;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType3 + ".");
                            }
                        }
                    }
                    if (Variables.iCurrentLocation == 1 && !Search.bSearchedLocation_B01 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B01 = true; }
                    if (Variables.iCurrentLocation == 2 && !Search.bSearchedLocation_B02 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B02 = true; }
                    if (Variables.iCurrentLocation == 3 && !Search.bSearchedLocation_B03 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B03 = true; }
                    if (Variables.iCurrentLocation == 4 && !Search.bSearchedLocation_B04 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B04 = true; }
                    if (Variables.iCurrentLocation == 5 && !Search.bSearchedLocation_B05 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B05 = true; }
                    if (Variables.iCurrentLocation == 6 && !Search.bSearchedLocation_B06 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B06 = true; }
                    if (Variables.iCurrentLocation == 7 && !Search.bSearchedLocation_B07 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B07 = true; }
                    if (Variables.iCurrentLocation == 8 && !Search.bSearchedLocation_B08 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B08 = true; }
                    if (Variables.iCurrentLocation == 9 && !Search.bSearchedLocation_B09 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B09 = true; }
                    if (Variables.iCurrentLocation == 10 && !Search.bSearchedLocation_B10 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B10 = true; }
                    if (Variables.iCurrentLocation == 11 && !Search.bSearchedLocation_B11 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B11 = true; }
                    if (Variables.iCurrentLocation == 12 && !Search.bSearchedLocation_B12 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B12 = true; }
                    if (Variables.iCurrentLocation == 13 && !Search.bSearchedLocation_B13 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B13 = true; }
                    if (Variables.iCurrentLocation == 14 && !Search.bSearchedLocation_B14 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B14 = true; }
                    if (Variables.iCurrentLocation == 15 && !Search.bSearchedLocation_B15 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B15 = true; }
                    if (Variables.iCurrentLocation == 16 && !Search.bSearchedLocation_B16 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B16 = true; }
                    if (Variables.iCurrentLocation == 17 && !Search.bSearchedLocation_B17 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B17 = true; }
                    if (Variables.iCurrentLocation == 18 && !Search.bSearchedLocation_B18 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B18 = true; }
                    if (Variables.iCurrentLocation == 19 && !Search.bSearchedLocation_B19 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B19 = true; }
                    if (Variables.iCurrentLocation == 20 && !Search.bSearchedLocation_B20 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B20 = true; }
                    if (Variables.iCurrentLocation == 21 && !Search.bSearchedLocation_B21 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B21 = true; }
                    if (Variables.iCurrentLocation == 22 && !Search.bSearchedLocation_B22 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B22 = true; }
                    if (Variables.iCurrentLocation == 23 && !Search.bSearchedLocation_B23 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B23 = true; }
                    if (Variables.iCurrentLocation == 24 && !Search.bSearchedLocation_B24 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B24 = true; }
                    if (Variables.iCurrentLocation == 25 && !Search.bSearchedLocation_B25 && LocationEncounters.bLightHouseUsed) { Search.bSearchedLocation_B25 = true; }
                }
            }
            Variables.turnEnded = true;
            Program.PressAnyKey();
        }

        public static void Option_ExploreArea()
        {
            if (Variables.iCurrentLocation == 1) // The Bridge
            {
                LocationEncounters.StoryAtTheBridge();
            }
            if (Variables.iCurrentLocation == 2) // The Strip Mall and Shops
            {
                LocationEncounters.StoryAtTheShops();
            }
            if (Variables.iCurrentLocation == 3) // The Northwest Beach
            {
                LocationEncounters.StoryAtTheNWBeach();
            }
            if (Variables.iCurrentLocation == 4) // The Clock Tower
            {
                LocationEncounters.StoryAtTheClockTower();
            }
            if (Variables.iCurrentLocation == 5) // Main Street
            {
                LocationEncounters.StoryAtMainStreet();
            }
            if (Variables.iCurrentLocation == 6) // The Bus Terminal
            {
                LocationEncounters.StoryAtTheBusTerminal();
            }
            if (Variables.iCurrentLocation == 7) // Downtown and the Office Districts
            {
                LocationEncounters.StoryAtTheOfficeDistrict();
            }
            if (Variables.iCurrentLocation == 8) // The Bar District
            {
                LocationEncounters.StoryAtTheBarDistrict();
            }
            if (Variables.iCurrentLocation == 9) // The Apartments
            {
                LocationEncounters.StoryAtTheApartments();
            }
            if (Variables.iCurrentLocation == 10) // The Lighthouse
            {
                LocationEncounters.StoryAtTheLighthouse();
            }
            if (Variables.iCurrentLocation == 11) // The Church
            {
                LocationEncounters.StoryAtTheChurch();
            }
            if (Variables.iCurrentLocation == 12) // Bay Street
            {
                LocationEncounters.StoryAtBayStreet();
            }
            if (Variables.iCurrentLocation == 13) // The Docks
            {
                LocationEncounters.StoryAtTheDocks();
            }
            if (Variables.iCurrentLocation == 14) // The Police Station
            {
                LocationEncounters.StoryAtThePoliceStation();
            }
            if (Variables.iCurrentLocation == 15) // The Abandoned Factory
            {
                LocationEncounters.StoryAtTheAbandonedFactory();
            }
            if (Variables.iCurrentLocation == 16) // The Post Office
            {
                LocationEncounters.StoryAtThePostOffice();
            }
            if (Variables.iCurrentLocation == 17) // The Courthouse
            {
                LocationEncounters.StoryAtTheCourthouse();
            }
            if (Variables.iCurrentLocation == 18) // The Water Tower
            {
                LocationEncounters.StoryAtTheWaterTower();
            }
            if (Variables.iCurrentLocation == 19) // The Golf Course
            {
                LocationEncounters.StoryAtTheGolfCourse();
            }
            if (Variables.iCurrentLocation == 20) // The Hiking Trails
            {
                LocationEncounters.StoryAtTheHikingTrails();
            }
            if (Variables.iCurrentLocation == 21) // Ocean Street
            {
                LocationEncounters.StoryAtOceanStreet();
            }
            if (Variables.iCurrentLocation == 22) // The Boardwalk
            {
                LocationEncounters.StoryAtTheBoardwalk();
            }
            if (Variables.iCurrentLocation == 23) // The Dunes
            {
                LocationEncounters.StoryAtTheDunes();
            }
            if (Variables.iCurrentLocation == 24) // The Southeast Beach
            {
                LocationEncounters.StoryAtTheSEBeach();
            }
            if (Variables.iCurrentLocation == 25) // The Jetty
            {
                LocationEncounters.StoryAtTheJetty();
            }
            Program.PressAnyKey();
        }

        public static void Option_PassTurn()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if (Variables.bAboutToDie == true)
            {
                if (Variables.weaponName == NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("With no weapons, no plan, and fatigue adding more weight to your");
                    Console.WriteLine("eyelids, you feel the fight fall away from you completely. Instead of");
                    Console.WriteLine("running, you close your eyes and lie down. Warmth envelops you in a");
                    Console.WriteLine("way you could never have imagined, and you feel yourself float away.");
                    Variables.playerSurvived = Variables.sPlayerState1;
                    Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                }
                else if (Variables.weaponName != NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("With fatigue adding weight to your eyelids, you want nothing more than");
                    Console.WriteLine("to close them and let sleep come fully upon you. And, for a moment,");
                    Console.WriteLine("you do just that -- but then instinct kicks in. The texture of the brick in");
                    Console.WriteLine("your hands sparks something, and you open your eyes to look down");
                    Console.WriteLine("upon it. You throw the brick at Isabella, and feel energy return to you.");
                    Console.WriteLine("You have a second chance to run away, if you would take it.");
                    Variables.weaponName = NPC_AI.sWeaponType0;
                }
            }
            else if (Variables.bAboutToDie == false)
            {
                Console.WriteLine("You decide to get comfortable, waiting to see who comes and who goes.");
                Variables.turnEnded = true;
            }
            Program.PressAnyKey();
        }

        public static void Option_QuitTheGame()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Are you sure you want to quit the game? (y)es or (n)o?");
            Console.WriteLine("(All progress will be lost.)");
            Console.WriteLine();
            string sQuitter = Console.ReadLine();
            sQuitter.ToLower();
            Console.WriteLine();
            while (sQuitter != "y" && sQuitter != "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                sQuitter = Console.ReadLine();
                sQuitter.ToLower();
                Console.WriteLine();
            }
            if (sQuitter == "y")
            {
                Variables.iFinishingTurn = Variables.iRemainingTurns;
                Variables.iRemainingTurns = 0;
                Variables.playerSurvived = Variables.sPlayerState4;
                Console.WriteLine("Game ending.");
            }
            if (sQuitter == "n")
            {
                Console.WriteLine("Whew! We almost lost you. Back to the game!");
                Variables.turnEnded = true;
            }
            Program.PressAnyKey();
        }

        public static void NewbieTipsAreForNewbies()
        {
            if (NPC_AI.iLightningsFirstStrike == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: The lightning hits where murders have occurred. If you see lightning");
                Console.WriteLine("in the distance, then that means that the killer is somewhere else.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                NPC_AI.iLightningsFirstStrike = 2;
            }
            if (Variables.iRemainingTurns == Variables.iTurn05)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: Use the 'Search' menu to look for MacGuffins or weapons.");
                Console.WriteLine("'Talk/Barter' allows you to learn about people, and more. If you");
                Console.WriteLine("'Explore' the area, you may find something special to do. You can also");
                Console.WriteLine("'Move' around the city, or just 'Pass' to spend time studying people.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (Notebook.iNotebookHasInfo >= 1 && !bNotebookTip)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You've added a note to your notebook. Use the 'Notebook' menu to");
                Console.WriteLine("review your notes and observations.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                bNotebookTip = true;
            }
            if (Variables.iRemainingTurns == Variables.iTurn20 - 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You can now 'accuse' people. If you think you know who the killer");
                Console.WriteLine("is, and you're ready for a confrontation, enter the 'Talk/Barter/Accuse'");
                Console.WriteLine("menu and choose to 'Voice your suspicions'.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}