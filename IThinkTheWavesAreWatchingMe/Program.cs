using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Program
    {
        public static Random rand = new Random();
        public static int iInitializeGame;

        public static void Game_StartNewGame()
        {
            iInitializeGame = 0;
            Lists.ResetAllLists();
            
            Lists.PopulateNPCNameOptions();

            // Initialize variables for a NEW GAME.
            if (iInitializeGame == 0)
            {
                Initialize_NewGame();

                NPC_Traits.Assign_Traits(); // Must follow Initialize because that contains a method which erases the assigned traits.

                // Access save game to see if the player has discovered any secrets.
                SaveDocument.AccessData();

                iInitializeGame = 1;
            }
        }

        static void Main(string[] args)
        {
            Game_StartNewGame();

            // Title screen.
            Title.ScreenDimensions();
            Title.TitleScreen();

            // Gah. Start the game. Get on with it already.
            while (Variables.bGameActive)
            {
                if (iInitializeGame == 1)
                {
                    Lists.Initialize_Lists();
                    iInitializeGame = 2;
                }

                if (Variables.iRemainingTurns > Variables.iTurn60) // end of game, i.e. 0 turns remaining
                {
                    // First, check for cutscene. These scenes preempt the game display.
                    Cutscenes.ShouldSomethingBePlaying();

                    // Second, check for Bunny Text. And ditto the aforementioned preemption.
                    TheBunny.BunnyText();

                    // NPCs Scavenge each round, behind the scenes.
                    NPC_AI.NPCs_Go_Looting();

                    // Opening cutscene. Odd place for it but its a legacy of the port.
                    Cutscenes.GameStart_Cutscene();

                    if (Variables.iRemainingTurns != 125) // Ugly, but this is to prevent text from flashing on screen and then instantly disappearing, on turn 125.
                    {

                        // Display Header Info (minutes remaining, current location). First thing player sees outside of story text.
                        Display_UIHeader();

                        // If everyone is dead, set the proper variable accordingly.
                        AnyoneStillAliveICanFixThat();

                        if (Variables.iRemainingTurns == (Variables.iTurn50 - 1)) // If turn = 19.
                        {
                            RandomEncounters.DitchTheBestie();
                        }

                        // Reset the Lists I'm using to track data.
                        Lists.ClearMostLists();

                        // Populate the NPC Roster list
                        Lists.PopulateNPCRoster();

                        // Check/Increment Island Flooding
                        Flood.HereComesTheFlood();
                        Flood.FloodBlocksSomeLocations();

                        // Add space before shuffler, if anyone is here:
                        NPC_AI.AnyoneHere_NeedShufflerSpace();

                        // The "Shuffler" Loop where NPC actions are shown.
                        // Order: NPCs come/go/emote, corpse, lightning, bunny.
                        for (int i = 1; Lists.NPCRoster.Count > 0; i++)
                        {
                            NPC_AI.SetUpForShuffler();
                            NPC_AI.Shuffler_01To89();
                            NPC_AI.NPC100_ShufflerOverride();
                            NPC_AI.Shuffler_90To100();
                            Notebook.DoYouComeHereOftenYouLookFamiliar();
                            Flood.HopeYouNPCsCanSwim();
                            NPC_AI.SetAllNPCLocals();
                            NPC_AI.CanIStopShufflingYet(); // Note: Triggers SoWhoAllIsDead() when everyone has been accounted for.
                        }

                        TheBunny.BunnyCode();
                        Title.ButPopularityIsImportant();

                        // Reset NPC Roster, modify spacing.
                        Lists.PopulateNPCRoster();
                        NPC_AI.IsAnyoneHere();

                        // The killer's attack routine.
                        NPC_AI.NPC100_PantsDownGenderCheck();
                        Killer.KillerIsHunting();
                    }

                    // Random Encounters
                    RandomEncounters.PickAnyRandomEncounter(); // Launches Run_RandomEncounter##();
                    RandomEncounters.Resolve_RandomEncounters(); // Launches SetAllActorLocals(); & Initialize_Actors();

                    // Drown Player (if necessary, of course)
                    Flood.ThePlayerCantSwim();

                    // Random Encounter #8, The Special Friend
                    RandomEncounters.YourVeryOwnBestie();

                    // Player options.
                    PlayerOptions.PlayerOptionsList();
                    
                    // Dock one turn and Loop (unless game is over)
                    Variables.waitMove = true;
                    Variables.iRemainingTurns--;
                    Console.Clear();

                    if (Variables.iRemainingTurns == 0)
                    {
                        Cutscenes.GameOver_OutOfTurns();
                    }
                }
                else
                {
                    // Handle game over scoring, etc.
                    Title.ShowScore();
                }
            }
        }

        public static void Initialize_NewGame()
        {
            AccusationEncounters.Initialize_Accusation();
            Conversation.Initialize_Conversation();
            Flood.Initialize_Flood();
            // Lists.Initialize_Lists();
            LocationEncounters.Initialize_Locations();
            Map.Initialize_Map();
            Movement.Initialize_Movement();
            Notebook.Initialize_Notebook();
            NPC_AI.Initialize_AI_Variables();
            NPC_AI.Initialize_NPCs();
            NPC_Traits.Initialize_Traits();
            RandomEncounters.Initialize_Actors();
            RandomEncounters.Initialize_RandomEncounters();
            Search.Initialize_Search();
            TheBunny.Initialize_Bunny();
            Title.Initialize_TitleVars();
            Title.Initialize_Secrets();
            Variables.Initialize_MainVars();
        }

        public static void PressAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press any key when you're ready.)");
            Console.ReadKey(true);
            Console.Clear();
        }

        public static void AnyoneStillAliveICanFixThat()
        {
            // Track if NPCs are alive
            if (
            NPC_AI.bCorpse001 && NPC_AI.bCorpse002 && NPC_AI.bCorpse003 && NPC_AI.bCorpse004 && NPC_AI.bCorpse005 &&
            NPC_AI.bCorpse006 && NPC_AI.bCorpse007 && NPC_AI.bCorpse008 && NPC_AI.bCorpse009 && NPC_AI.bCorpse010 &&
            NPC_AI.bCorpse011 && NPC_AI.bCorpse012 && NPC_AI.bCorpse013 && NPC_AI.bCorpse014 && NPC_AI.bCorpse015 &&
            NPC_AI.bCorpse016 && NPC_AI.bCorpse017 && NPC_AI.bCorpse018 && NPC_AI.bCorpse019 && NPC_AI.bCorpse020 &&
            NPC_AI.bCorpse021 && NPC_AI.bCorpse022 && NPC_AI.bCorpse023 && NPC_AI.bCorpse024 && NPC_AI.bCorpse025 &&
            NPC_AI.bCorpse026 && NPC_AI.bCorpse027 && NPC_AI.bCorpse028 && NPC_AI.bCorpse029 && NPC_AI.bCorpse030 &&
            NPC_AI.bCorpse031 && NPC_AI.bCorpse032 && NPC_AI.bCorpse033 && NPC_AI.bCorpse034 && NPC_AI.bCorpse035 &&
            NPC_AI.bCorpse036 && NPC_AI.bCorpse037 && NPC_AI.bCorpse038 && NPC_AI.bCorpse039 && NPC_AI.bCorpse040 &&
            NPC_AI.bCorpse041 && NPC_AI.bCorpse042 && NPC_AI.bCorpse043 && NPC_AI.bCorpse044 && NPC_AI.bCorpse045 &&
            NPC_AI.bCorpse046 && NPC_AI.bCorpse047 && NPC_AI.bCorpse048 && NPC_AI.bCorpse049 && NPC_AI.bCorpse050 &&
            NPC_AI.bCorpse051 && NPC_AI.bCorpse052 && NPC_AI.bCorpse053 && NPC_AI.bCorpse054 && NPC_AI.bCorpse055 &&
            NPC_AI.bCorpse056 && NPC_AI.bCorpse057 && NPC_AI.bCorpse058 && NPC_AI.bCorpse059 && NPC_AI.bCorpse060 &&
            NPC_AI.bCorpse061 && NPC_AI.bCorpse062 && NPC_AI.bCorpse063 && NPC_AI.bCorpse064 && NPC_AI.bCorpse065 &&
            NPC_AI.bCorpse066 && NPC_AI.bCorpse067 && NPC_AI.bCorpse068 && NPC_AI.bCorpse069 && NPC_AI.bCorpse070 &&
            NPC_AI.bCorpse071 && NPC_AI.bCorpse072 && NPC_AI.bCorpse073 && NPC_AI.bCorpse074 && NPC_AI.bCorpse075 &&
            NPC_AI.bCorpse076 && NPC_AI.bCorpse077 && NPC_AI.bCorpse078 && NPC_AI.bCorpse079 && NPC_AI.bCorpse080 &&
            NPC_AI.bCorpse081 && NPC_AI.bCorpse082 && NPC_AI.bCorpse083 && NPC_AI.bCorpse084 && NPC_AI.bCorpse085 &&
            NPC_AI.bCorpse086 && NPC_AI.bCorpse087 && NPC_AI.bCorpse088 && NPC_AI.bCorpse089)
            //  && bCorpse090 && bCorpse091 && bCorpse092 && bCorpse093 && bCorpse094 && bCorpse095 && bCorpse096 && bCorpse097 && bCorpse098 && bCorpse099
            {
                // Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("DEBUG: NPCs 1 through NPCs 89 are all dead! DooOoOOoOoOooOOOOoooOOOM!"); Console.ForegroundColor = ConsoleColor.Yellow;
                Variables.bAllDead = true;
            }

            if (NPC_AI.bCorpse001) { Lists.TheGlobalDead.Add(NPC_AI.NPC_001); }
            if (NPC_AI.bCorpse002) { Lists.TheGlobalDead.Add(NPC_AI.NPC_002); }
            if (NPC_AI.bCorpse003) { Lists.TheGlobalDead.Add(NPC_AI.NPC_003); }
            if (NPC_AI.bCorpse004) { Lists.TheGlobalDead.Add(NPC_AI.NPC_004); }
            if (NPC_AI.bCorpse005) { Lists.TheGlobalDead.Add(NPC_AI.NPC_005); }
            if (NPC_AI.bCorpse006) { Lists.TheGlobalDead.Add(NPC_AI.NPC_006); }
            if (NPC_AI.bCorpse007) { Lists.TheGlobalDead.Add(NPC_AI.NPC_007); }
            if (NPC_AI.bCorpse008) { Lists.TheGlobalDead.Add(NPC_AI.NPC_008); }
            if (NPC_AI.bCorpse009) { Lists.TheGlobalDead.Add(NPC_AI.NPC_009); }
            if (NPC_AI.bCorpse010) { Lists.TheGlobalDead.Add(NPC_AI.NPC_010); }
            if (NPC_AI.bCorpse011) { Lists.TheGlobalDead.Add(NPC_AI.NPC_011); }
            if (NPC_AI.bCorpse012) { Lists.TheGlobalDead.Add(NPC_AI.NPC_012); }
            if (NPC_AI.bCorpse013) { Lists.TheGlobalDead.Add(NPC_AI.NPC_013); }
            if (NPC_AI.bCorpse014) { Lists.TheGlobalDead.Add(NPC_AI.NPC_014); }
            if (NPC_AI.bCorpse015) { Lists.TheGlobalDead.Add(NPC_AI.NPC_015); }
            if (NPC_AI.bCorpse016) { Lists.TheGlobalDead.Add(NPC_AI.NPC_016); }
            if (NPC_AI.bCorpse017) { Lists.TheGlobalDead.Add(NPC_AI.NPC_017); }
            if (NPC_AI.bCorpse018) { Lists.TheGlobalDead.Add(NPC_AI.NPC_018); }
            if (NPC_AI.bCorpse019) { Lists.TheGlobalDead.Add(NPC_AI.NPC_019); }
            if (NPC_AI.bCorpse020) { Lists.TheGlobalDead.Add(NPC_AI.NPC_020); }
            if (NPC_AI.bCorpse021) { Lists.TheGlobalDead.Add(NPC_AI.NPC_021); }
            if (NPC_AI.bCorpse022) { Lists.TheGlobalDead.Add(NPC_AI.NPC_022); }
            if (NPC_AI.bCorpse023) { Lists.TheGlobalDead.Add(NPC_AI.NPC_023); }
            if (NPC_AI.bCorpse024) { Lists.TheGlobalDead.Add(NPC_AI.NPC_024); }
            if (NPC_AI.bCorpse025) { Lists.TheGlobalDead.Add(NPC_AI.NPC_025); }
            if (NPC_AI.bCorpse026) { Lists.TheGlobalDead.Add(NPC_AI.NPC_026); }
            if (NPC_AI.bCorpse027) { Lists.TheGlobalDead.Add(NPC_AI.NPC_027); }
            if (NPC_AI.bCorpse028) { Lists.TheGlobalDead.Add(NPC_AI.NPC_028); }
            if (NPC_AI.bCorpse029) { Lists.TheGlobalDead.Add(NPC_AI.NPC_029); }
            if (NPC_AI.bCorpse030) { Lists.TheGlobalDead.Add(NPC_AI.NPC_030); }
            if (NPC_AI.bCorpse031) { Lists.TheGlobalDead.Add(NPC_AI.NPC_031); }
            if (NPC_AI.bCorpse032) { Lists.TheGlobalDead.Add(NPC_AI.NPC_032); }
            if (NPC_AI.bCorpse033) { Lists.TheGlobalDead.Add(NPC_AI.NPC_033); }
            if (NPC_AI.bCorpse034) { Lists.TheGlobalDead.Add(NPC_AI.NPC_034); }
            if (NPC_AI.bCorpse035) { Lists.TheGlobalDead.Add(NPC_AI.NPC_035); }
            if (NPC_AI.bCorpse036) { Lists.TheGlobalDead.Add(NPC_AI.NPC_036); }
            if (NPC_AI.bCorpse037) { Lists.TheGlobalDead.Add(NPC_AI.NPC_037); }
            if (NPC_AI.bCorpse038) { Lists.TheGlobalDead.Add(NPC_AI.NPC_038); }
            if (NPC_AI.bCorpse039) { Lists.TheGlobalDead.Add(NPC_AI.NPC_039); }
            if (NPC_AI.bCorpse040) { Lists.TheGlobalDead.Add(NPC_AI.NPC_040); }
            if (NPC_AI.bCorpse041) { Lists.TheGlobalDead.Add(NPC_AI.NPC_041); }
            if (NPC_AI.bCorpse042) { Lists.TheGlobalDead.Add(NPC_AI.NPC_042); }
            if (NPC_AI.bCorpse043) { Lists.TheGlobalDead.Add(NPC_AI.NPC_043); }
            if (NPC_AI.bCorpse044) { Lists.TheGlobalDead.Add(NPC_AI.NPC_044); }
            if (NPC_AI.bCorpse045) { Lists.TheGlobalDead.Add(NPC_AI.NPC_045); }
            if (NPC_AI.bCorpse046) { Lists.TheGlobalDead.Add(NPC_AI.NPC_046); }
            if (NPC_AI.bCorpse047) { Lists.TheGlobalDead.Add(NPC_AI.NPC_047); }
            if (NPC_AI.bCorpse048) { Lists.TheGlobalDead.Add(NPC_AI.NPC_048); }
            if (NPC_AI.bCorpse049) { Lists.TheGlobalDead.Add(NPC_AI.NPC_049); }
            if (NPC_AI.bCorpse050) { Lists.TheGlobalDead.Add(NPC_AI.NPC_050); }
            if (NPC_AI.bCorpse051) { Lists.TheGlobalDead.Add(NPC_AI.NPC_051); }
            if (NPC_AI.bCorpse052) { Lists.TheGlobalDead.Add(NPC_AI.NPC_052); }
            if (NPC_AI.bCorpse053) { Lists.TheGlobalDead.Add(NPC_AI.NPC_053); }
            if (NPC_AI.bCorpse054) { Lists.TheGlobalDead.Add(NPC_AI.NPC_054); }
            if (NPC_AI.bCorpse055) { Lists.TheGlobalDead.Add(NPC_AI.NPC_055); }
            if (NPC_AI.bCorpse056) { Lists.TheGlobalDead.Add(NPC_AI.NPC_056); }
            if (NPC_AI.bCorpse057) { Lists.TheGlobalDead.Add(NPC_AI.NPC_057); }
            if (NPC_AI.bCorpse058) { Lists.TheGlobalDead.Add(NPC_AI.NPC_058); }
            if (NPC_AI.bCorpse059) { Lists.TheGlobalDead.Add(NPC_AI.NPC_059); }
            if (NPC_AI.bCorpse060) { Lists.TheGlobalDead.Add(NPC_AI.NPC_060); }
            if (NPC_AI.bCorpse061) { Lists.TheGlobalDead.Add(NPC_AI.NPC_061); }
            if (NPC_AI.bCorpse062) { Lists.TheGlobalDead.Add(NPC_AI.NPC_062); }
            if (NPC_AI.bCorpse063) { Lists.TheGlobalDead.Add(NPC_AI.NPC_063); }
            if (NPC_AI.bCorpse064) { Lists.TheGlobalDead.Add(NPC_AI.NPC_064); }
            if (NPC_AI.bCorpse065) { Lists.TheGlobalDead.Add(NPC_AI.NPC_065); }
            if (NPC_AI.bCorpse066) { Lists.TheGlobalDead.Add(NPC_AI.NPC_066); }
            if (NPC_AI.bCorpse067) { Lists.TheGlobalDead.Add(NPC_AI.NPC_067); }
            if (NPC_AI.bCorpse068) { Lists.TheGlobalDead.Add(NPC_AI.NPC_068); }
            if (NPC_AI.bCorpse069) { Lists.TheGlobalDead.Add(NPC_AI.NPC_069); }
            if (NPC_AI.bCorpse070) { Lists.TheGlobalDead.Add(NPC_AI.NPC_070); }
            if (NPC_AI.bCorpse071) { Lists.TheGlobalDead.Add(NPC_AI.NPC_071); }
            if (NPC_AI.bCorpse072) { Lists.TheGlobalDead.Add(NPC_AI.NPC_072); }
            if (NPC_AI.bCorpse073) { Lists.TheGlobalDead.Add(NPC_AI.NPC_073); }
            if (NPC_AI.bCorpse074) { Lists.TheGlobalDead.Add(NPC_AI.NPC_074); }
            if (NPC_AI.bCorpse075) { Lists.TheGlobalDead.Add(NPC_AI.NPC_075); }
            if (NPC_AI.bCorpse076) { Lists.TheGlobalDead.Add(NPC_AI.NPC_076); }
            if (NPC_AI.bCorpse077) { Lists.TheGlobalDead.Add(NPC_AI.NPC_077); }
            if (NPC_AI.bCorpse078) { Lists.TheGlobalDead.Add(NPC_AI.NPC_078); }
            if (NPC_AI.bCorpse079) { Lists.TheGlobalDead.Add(NPC_AI.NPC_079); }
            if (NPC_AI.bCorpse080) { Lists.TheGlobalDead.Add(NPC_AI.NPC_080); }
            if (NPC_AI.bCorpse081) { Lists.TheGlobalDead.Add(NPC_AI.NPC_081); }
            if (NPC_AI.bCorpse082) { Lists.TheGlobalDead.Add(NPC_AI.NPC_082); }
            if (NPC_AI.bCorpse083) { Lists.TheGlobalDead.Add(NPC_AI.NPC_083); }
            if (NPC_AI.bCorpse084) { Lists.TheGlobalDead.Add(NPC_AI.NPC_084); }
            if (NPC_AI.bCorpse085) { Lists.TheGlobalDead.Add(NPC_AI.NPC_085); }
            if (NPC_AI.bCorpse086) { Lists.TheGlobalDead.Add(NPC_AI.NPC_086); }
            if (NPC_AI.bCorpse087) { Lists.TheGlobalDead.Add(NPC_AI.NPC_087); }
            if (NPC_AI.bCorpse088) { Lists.TheGlobalDead.Add(NPC_AI.NPC_088); }
            if (NPC_AI.bCorpse089) { Lists.TheGlobalDead.Add(NPC_AI.NPC_089); }
            if (NPC_AI.bCorpse090) { Lists.TheGlobalDead.Add(NPC_AI.NPC_090); }
            if (NPC_AI.bCorpse091) { Lists.TheGlobalDead.Add(NPC_AI.NPC_091); }
            if (NPC_AI.bCorpse092) { Lists.TheGlobalDead.Add(NPC_AI.NPC_092); }
            if (NPC_AI.bCorpse093) { Lists.TheGlobalDead.Add(NPC_AI.NPC_093); }
            if (NPC_AI.bCorpse094) { Lists.TheGlobalDead.Add(NPC_AI.NPC_094); }
            if (NPC_AI.bCorpse095) { Lists.TheGlobalDead.Add(NPC_AI.NPC_095); }
            if (NPC_AI.bCorpse096) { Lists.TheGlobalDead.Add(NPC_AI.NPC_096); }
            if (NPC_AI.bCorpse097) { Lists.TheGlobalDead.Add(NPC_AI.NPC_097); }
            if (NPC_AI.bCorpse098) { Lists.TheGlobalDead.Add(NPC_AI.NPC_098); }
            if (NPC_AI.bCorpse099) { Lists.TheGlobalDead.Add(NPC_AI.NPC_099); }
            if (NPC_AI.bCorpse100) { Lists.TheGlobalDead.Add(NPC_AI.NPC_100); }
        }

        public static void Display_UIHeader()
        {
            // "UI"
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Variables.iRemainingTurns != 1) { Console.WriteLine("There are " + Variables.iRemainingTurns + " minutes remaining, and you are at " + Variables.sGetLocation); }
            if (Variables.iRemainingTurns == 1) { Console.WriteLine("There is " + Variables.iRemainingTurns + " minute remaining, and you are at " + Variables.sGetLocation); }
        }
    }
}