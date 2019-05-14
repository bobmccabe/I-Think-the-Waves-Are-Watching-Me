using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Killer
    {
        public static void KillerIsHunting()
        {
            if (NPC_AI.bHunting && NPC_AI.NPC100_CurrentNumLocation == Variables.iCurrentLocation && !LocationEncounters.bDontAuto23)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                Console.WriteLine("Fatigue washes over you as " + NPC_AI.NPC_100 + " approaches.");
                NPC_AI.NPC100_CurrentStrLocation = Variables.sGetLocation; // Killer moved to player's location

                int iKillerBye = Program.rand.Next(1, 6);
                if (iKillerBye == 1) { Console.WriteLine(NPC_AI.NPC_100 + " smiles sadly. 'I know you don't want to die. But this isn't death.'"); }
                if (iKillerBye == 2) { Console.WriteLine(NPC_AI.NPC_100 + " shakes " + NPC_AI.sGenderHisHer + " head. 'You don't have to be afraid. It's OK.'"); }
                if (iKillerBye == 3) { Console.WriteLine(NPC_AI.NPC_100 + " says, 'You're a fighter, aren't you. But isn't fighting tiring?'"); }
                if (iKillerBye == 4) { Console.WriteLine(NPC_AI.NPC_100 + " says, 'You can't run forever. Either I catch you or the waves do.'"); }
                if (iKillerBye == 5) { Console.WriteLine(NPC_AI.NPC_100 + " says, 'Poor dear. You must be tired. Don't you want sleep now?'"); }

                // Now that the killer is at the player's location, point the ol' shotgun of doom at the player.
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("If you don't leave right now, you're certain that you're going to close");
                Console.WriteLine("your eyes and never wake up again.");
                Variables.bAboutToDie = true;
                NPC_AI.iLuckyHunter = 0; // reset this so that the killer doesn't become the Terminator 
                NPC_AI.bHunting = false;
            }
            // if the killer is not where the player is, and there are 19-or-less turns left. hunt the player! kill red herrings.
            else if ((NPC_AI.NPC100_CurrentNumLocation != Variables.iCurrentLocation) && 
            (Variables.iRemainingTurns <= Variables.iTurn50) && !LocationEncounters.bDontAuto23)
            
            {
                NPC_AI.iHuntPlayer = Program.rand.Next(1, NPC_AI.iHunterMax) + NPC_AI.iLuckyHunter;
                if (NPC_AI.iHuntPlayer < NPC_AI.iHuntThreshold && (NPC_AI.bCorpse090 == false) || (NPC_AI.bCorpse091 == false) || (NPC_AI.bCorpse092 == false) || (NPC_AI.bCorpse093 == false) || (NPC_AI.bCorpse094 == false)
                    || (NPC_AI.bCorpse095 == false) || (NPC_AI.bCorpse096 == false) || (NPC_AI.bCorpse097 == false) || (NPC_AI.bCorpse098 == false) || (NPC_AI.bCorpse099 == false))
                {
                    NPC_AI.iLuckyHunter = NPC_AI.iLuckyHunter + NPC_AI.iHuntRegen;
                    while (true)
                    {
                        NPC_AI.iDeadHerring = Program.rand.Next(1, 11); // The 10 Red Herrings: NPCs 90, 91, 92, 93, 94, 95, 96, 97, 98, and 99.                            
                        if (NPC_AI.bCorpse090 == false && NPC_AI.iDeadHerring == 1)
                        {
                            NPC_AI.NPC090_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC90.");
                            NPC_AI.bCorpse090 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_090);
                            break;
                        }
                        if (NPC_AI.bCorpse091 == false && NPC_AI.iDeadHerring == 2)
                        {
                            NPC_AI.NPC091_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC91.");
                            NPC_AI.bCorpse091 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_091);
                            break;
                        }
                        if (NPC_AI.bCorpse092 == false && NPC_AI.iDeadHerring == 3)
                        {
                            NPC_AI.NPC092_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC92.");
                            NPC_AI.bCorpse092 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_092);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse093 == false && NPC_AI.iDeadHerring == 4)
                        {
                            NPC_AI.NPC093_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC93.");
                            NPC_AI.bCorpse093 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_093);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse094 == false && NPC_AI.iDeadHerring == 5)
                        {
                            NPC_AI.NPC094_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC94.");
                            NPC_AI.bCorpse094 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_094);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse095 == false && NPC_AI.iDeadHerring == 6)
                        {
                            NPC_AI.NPC095_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC95.");
                            NPC_AI.bCorpse095 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_095);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse096 == false && NPC_AI.iDeadHerring == 7)
                        {
                            NPC_AI.NPC096_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC96.");
                            NPC_AI.bCorpse096 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_096);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse097 == false && NPC_AI.iDeadHerring == 8)
                        {
                            NPC_AI.NPC097_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC97.");
                            NPC_AI.bCorpse097 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_097);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse098 == false && NPC_AI.iDeadHerring == 9)
                        {
                            NPC_AI.NPC098_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            // Console.WriteLine("DEBUG: I just killed NPC98.");
                            NPC_AI.bCorpse098 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_098);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                        if (NPC_AI.bCorpse099 == false && NPC_AI.iDeadHerring == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine();
                            NPC_AI.NPC099_CurrentNumLocation = NPC_AI.NPC100_CurrentNumLocation;
                            // Console.WriteLine("DEBUG: I just killed NPC99.");
                            NPC_AI.bCorpse099 = true;
                            Lists.RemainingNPCs.Remove(NPC_AI.NPC_099);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                    }
                }
                // once all herrings are dead, this keeps the killer hunting instead of quitting around turn 5
                else if (NPC_AI.iHuntPlayer < NPC_AI.iHuntThreshold && NPC_AI.bCorpse090 && NPC_AI.bCorpse091 && NPC_AI.bCorpse092 && NPC_AI.bCorpse093 && NPC_AI.bCorpse094 && NPC_AI.bCorpse095 && NPC_AI.bCorpse096 && NPC_AI.bCorpse097 && NPC_AI.bCorpse098 && NPC_AI.bCorpse099 && !LocationEncounters.bDontAuto23)
                {
                    NPC_AI.iLuckyHunter = NPC_AI.iLuckyHunter + NPC_AI.iHuntRegen;
                }
            }
            // THE KILLER'S SPREE CODE STARTS HERE

            else if ((Variables.iCurrentLocation != NPC_AI.NPC100_CurrentNumLocation) && (Variables.iRemainingTurns > Variables.iTurn45)) // if the killer is not where the player is, and there are 35 or more turns left (after 35, let the flood handle it)... do some damage! Spree time!
            {
                if (Variables.iRemainingTurns < Variables.iTurn10)
                {
                    int iRemainingTargets = Program.rand.Next(0, 2); // Changed from 0-3 targets to 0-1 targets.

                    // Clear the list, and then fill it to make sure everything is good.
                    Lists.PopulateNPCRoster();

                    while ((iRemainingTargets > 0) && (!Variables.bAllDead)) // So long as there are people left to kill, get to killing.
                    {
                        int TargetIndex = Program.rand.Next(0, 89); // Pick a random NPC from the list of Living NPCs (which is all 100 characters).
                        string tempTarget = Lists.NPCRoster[TargetIndex]; // Use "tempTarget" to declare who is next to die.
                        int InfiniteLoop = 1;
                        if (tempTarget == NPC_AI.NPC_001) { NPC_AI.iTempLocation = NPC_AI.NPC001_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty001; NPC_AI.bTempCorpse = NPC_AI.bCorpse001; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_002) { NPC_AI.iTempLocation = NPC_AI.NPC002_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty002; NPC_AI.bTempCorpse = NPC_AI.bCorpse002; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_003) { NPC_AI.iTempLocation = NPC_AI.NPC003_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty003; NPC_AI.bTempCorpse = NPC_AI.bCorpse003; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_004) { NPC_AI.iTempLocation = NPC_AI.NPC004_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty004; NPC_AI.bTempCorpse = NPC_AI.bCorpse004; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_005) { NPC_AI.iTempLocation = NPC_AI.NPC005_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty005; NPC_AI.bTempCorpse = NPC_AI.bCorpse005; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_006) { NPC_AI.iTempLocation = NPC_AI.NPC006_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty006; NPC_AI.bTempCorpse = NPC_AI.bCorpse006; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_007) { NPC_AI.iTempLocation = NPC_AI.NPC007_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty007; NPC_AI.bTempCorpse = NPC_AI.bCorpse007; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_008) { NPC_AI.iTempLocation = NPC_AI.NPC008_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty008; NPC_AI.bTempCorpse = NPC_AI.bCorpse008; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_009) { NPC_AI.iTempLocation = NPC_AI.NPC009_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty009; NPC_AI.bTempCorpse = NPC_AI.bCorpse009; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_010) { NPC_AI.iTempLocation = NPC_AI.NPC010_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty010; NPC_AI.bTempCorpse = NPC_AI.bCorpse010; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_011) { NPC_AI.iTempLocation = NPC_AI.NPC011_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty011; NPC_AI.bTempCorpse = NPC_AI.bCorpse011; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_012) { NPC_AI.iTempLocation = NPC_AI.NPC012_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty012; NPC_AI.bTempCorpse = NPC_AI.bCorpse012; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_013) { NPC_AI.iTempLocation = NPC_AI.NPC013_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty013; NPC_AI.bTempCorpse = NPC_AI.bCorpse013; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_014) { NPC_AI.iTempLocation = NPC_AI.NPC014_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty014; NPC_AI.bTempCorpse = NPC_AI.bCorpse014; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_015) { NPC_AI.iTempLocation = NPC_AI.NPC015_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty015; NPC_AI.bTempCorpse = NPC_AI.bCorpse015; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_016) { NPC_AI.iTempLocation = NPC_AI.NPC016_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty016; NPC_AI.bTempCorpse = NPC_AI.bCorpse016; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_017) { NPC_AI.iTempLocation = NPC_AI.NPC017_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty017; NPC_AI.bTempCorpse = NPC_AI.bCorpse017; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_018) { NPC_AI.iTempLocation = NPC_AI.NPC018_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty018; NPC_AI.bTempCorpse = NPC_AI.bCorpse018; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_019) { NPC_AI.iTempLocation = NPC_AI.NPC019_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty019; NPC_AI.bTempCorpse = NPC_AI.bCorpse019; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_020) { NPC_AI.iTempLocation = NPC_AI.NPC020_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty020; NPC_AI.bTempCorpse = NPC_AI.bCorpse020; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_021) { NPC_AI.iTempLocation = NPC_AI.NPC021_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty021; NPC_AI.bTempCorpse = NPC_AI.bCorpse021; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_022) { NPC_AI.iTempLocation = NPC_AI.NPC022_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty022; NPC_AI.bTempCorpse = NPC_AI.bCorpse022; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_023) { NPC_AI.iTempLocation = NPC_AI.NPC023_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty023; NPC_AI.bTempCorpse = NPC_AI.bCorpse023; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_024) { NPC_AI.iTempLocation = NPC_AI.NPC024_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty024; NPC_AI.bTempCorpse = NPC_AI.bCorpse024; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_025) { NPC_AI.iTempLocation = NPC_AI.NPC025_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty025; NPC_AI.bTempCorpse = NPC_AI.bCorpse025; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_026) { NPC_AI.iTempLocation = NPC_AI.NPC026_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty026; NPC_AI.bTempCorpse = NPC_AI.bCorpse026; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_027) { NPC_AI.iTempLocation = NPC_AI.NPC027_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty027; NPC_AI.bTempCorpse = NPC_AI.bCorpse027; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_028) { NPC_AI.iTempLocation = NPC_AI.NPC028_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty028; NPC_AI.bTempCorpse = NPC_AI.bCorpse028; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_029) { NPC_AI.iTempLocation = NPC_AI.NPC029_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty029; NPC_AI.bTempCorpse = NPC_AI.bCorpse029; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_030) { NPC_AI.iTempLocation = NPC_AI.NPC030_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty030; NPC_AI.bTempCorpse = NPC_AI.bCorpse030; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_031) { NPC_AI.iTempLocation = NPC_AI.NPC031_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty031; NPC_AI.bTempCorpse = NPC_AI.bCorpse031; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_032) { NPC_AI.iTempLocation = NPC_AI.NPC032_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty032; NPC_AI.bTempCorpse = NPC_AI.bCorpse032; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_033) { NPC_AI.iTempLocation = NPC_AI.NPC033_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty033; NPC_AI.bTempCorpse = NPC_AI.bCorpse033; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_034) { NPC_AI.iTempLocation = NPC_AI.NPC034_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty034; NPC_AI.bTempCorpse = NPC_AI.bCorpse034; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_035) { NPC_AI.iTempLocation = NPC_AI.NPC035_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty035; NPC_AI.bTempCorpse = NPC_AI.bCorpse035; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_036) { NPC_AI.iTempLocation = NPC_AI.NPC036_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty036; NPC_AI.bTempCorpse = NPC_AI.bCorpse036; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_037) { NPC_AI.iTempLocation = NPC_AI.NPC037_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty037; NPC_AI.bTempCorpse = NPC_AI.bCorpse037; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_038) { NPC_AI.iTempLocation = NPC_AI.NPC038_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty038; NPC_AI.bTempCorpse = NPC_AI.bCorpse038; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_039) { NPC_AI.iTempLocation = NPC_AI.NPC039_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty039; NPC_AI.bTempCorpse = NPC_AI.bCorpse039; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_040) { NPC_AI.iTempLocation = NPC_AI.NPC040_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty040; NPC_AI.bTempCorpse = NPC_AI.bCorpse040; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_041) { NPC_AI.iTempLocation = NPC_AI.NPC041_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty041; NPC_AI.bTempCorpse = NPC_AI.bCorpse041; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_042) { NPC_AI.iTempLocation = NPC_AI.NPC042_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty042; NPC_AI.bTempCorpse = NPC_AI.bCorpse042; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_043) { NPC_AI.iTempLocation = NPC_AI.NPC043_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty043; NPC_AI.bTempCorpse = NPC_AI.bCorpse043; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_044) { NPC_AI.iTempLocation = NPC_AI.NPC044_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty044; NPC_AI.bTempCorpse = NPC_AI.bCorpse044; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_045) { NPC_AI.iTempLocation = NPC_AI.NPC045_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty045; NPC_AI.bTempCorpse = NPC_AI.bCorpse045; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_046) { NPC_AI.iTempLocation = NPC_AI.NPC046_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty046; NPC_AI.bTempCorpse = NPC_AI.bCorpse046; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_047) { NPC_AI.iTempLocation = NPC_AI.NPC047_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty047; NPC_AI.bTempCorpse = NPC_AI.bCorpse047; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_048) { NPC_AI.iTempLocation = NPC_AI.NPC048_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty048; NPC_AI.bTempCorpse = NPC_AI.bCorpse048; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_049) { NPC_AI.iTempLocation = NPC_AI.NPC049_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty049; NPC_AI.bTempCorpse = NPC_AI.bCorpse049; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_050) { NPC_AI.iTempLocation = NPC_AI.NPC050_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty050; NPC_AI.bTempCorpse = NPC_AI.bCorpse050; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_051) { NPC_AI.iTempLocation = NPC_AI.NPC051_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty051; NPC_AI.bTempCorpse = NPC_AI.bCorpse051; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_052) { NPC_AI.iTempLocation = NPC_AI.NPC052_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty052; NPC_AI.bTempCorpse = NPC_AI.bCorpse052; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_053) { NPC_AI.iTempLocation = NPC_AI.NPC053_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty053; NPC_AI.bTempCorpse = NPC_AI.bCorpse053; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_054) { NPC_AI.iTempLocation = NPC_AI.NPC054_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty054; NPC_AI.bTempCorpse = NPC_AI.bCorpse054; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_055) { NPC_AI.iTempLocation = NPC_AI.NPC055_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty055; NPC_AI.bTempCorpse = NPC_AI.bCorpse055; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_056) { NPC_AI.iTempLocation = NPC_AI.NPC056_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty056; NPC_AI.bTempCorpse = NPC_AI.bCorpse056; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_057) { NPC_AI.iTempLocation = NPC_AI.NPC057_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty057; NPC_AI.bTempCorpse = NPC_AI.bCorpse057; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_058) { NPC_AI.iTempLocation = NPC_AI.NPC058_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty058; NPC_AI.bTempCorpse = NPC_AI.bCorpse058; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_059) { NPC_AI.iTempLocation = NPC_AI.NPC059_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty059; NPC_AI.bTempCorpse = NPC_AI.bCorpse059; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_060) { NPC_AI.iTempLocation = NPC_AI.NPC060_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty060; NPC_AI.bTempCorpse = NPC_AI.bCorpse060; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_061) { NPC_AI.iTempLocation = NPC_AI.NPC061_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty061; NPC_AI.bTempCorpse = NPC_AI.bCorpse061; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_062) { NPC_AI.iTempLocation = NPC_AI.NPC062_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty062; NPC_AI.bTempCorpse = NPC_AI.bCorpse062; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_063) { NPC_AI.iTempLocation = NPC_AI.NPC063_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty063; NPC_AI.bTempCorpse = NPC_AI.bCorpse063; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_064) { NPC_AI.iTempLocation = NPC_AI.NPC064_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty064; NPC_AI.bTempCorpse = NPC_AI.bCorpse064; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_065) { NPC_AI.iTempLocation = NPC_AI.NPC065_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty065; NPC_AI.bTempCorpse = NPC_AI.bCorpse065; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_066) { NPC_AI.iTempLocation = NPC_AI.NPC066_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty066; NPC_AI.bTempCorpse = NPC_AI.bCorpse066; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_067) { NPC_AI.iTempLocation = NPC_AI.NPC067_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty067; NPC_AI.bTempCorpse = NPC_AI.bCorpse067; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_068) { NPC_AI.iTempLocation = NPC_AI.NPC068_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty068; NPC_AI.bTempCorpse = NPC_AI.bCorpse068; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_069) { NPC_AI.iTempLocation = NPC_AI.NPC069_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty069; NPC_AI.bTempCorpse = NPC_AI.bCorpse069; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_070) { NPC_AI.iTempLocation = NPC_AI.NPC070_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty070; NPC_AI.bTempCorpse = NPC_AI.bCorpse070; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_071) { NPC_AI.iTempLocation = NPC_AI.NPC071_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty071; NPC_AI.bTempCorpse = NPC_AI.bCorpse071; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_072) { NPC_AI.iTempLocation = NPC_AI.NPC072_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty072; NPC_AI.bTempCorpse = NPC_AI.bCorpse072; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_073) { NPC_AI.iTempLocation = NPC_AI.NPC073_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty073; NPC_AI.bTempCorpse = NPC_AI.bCorpse073; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_074) { NPC_AI.iTempLocation = NPC_AI.NPC074_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty074; NPC_AI.bTempCorpse = NPC_AI.bCorpse074; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_075) { NPC_AI.iTempLocation = NPC_AI.NPC075_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty075; NPC_AI.bTempCorpse = NPC_AI.bCorpse075; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_076) { NPC_AI.iTempLocation = NPC_AI.NPC076_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty076; NPC_AI.bTempCorpse = NPC_AI.bCorpse076; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_077) { NPC_AI.iTempLocation = NPC_AI.NPC077_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty077; NPC_AI.bTempCorpse = NPC_AI.bCorpse077; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_078) { NPC_AI.iTempLocation = NPC_AI.NPC078_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty078; NPC_AI.bTempCorpse = NPC_AI.bCorpse078; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_079) { NPC_AI.iTempLocation = NPC_AI.NPC079_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty079; NPC_AI.bTempCorpse = NPC_AI.bCorpse079; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_080) { NPC_AI.iTempLocation = NPC_AI.NPC080_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty080; NPC_AI.bTempCorpse = NPC_AI.bCorpse080; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_081) { NPC_AI.iTempLocation = NPC_AI.NPC081_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty081; NPC_AI.bTempCorpse = NPC_AI.bCorpse081; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_082) { NPC_AI.iTempLocation = NPC_AI.NPC082_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty082; NPC_AI.bTempCorpse = NPC_AI.bCorpse082; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_083) { NPC_AI.iTempLocation = NPC_AI.NPC083_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty083; NPC_AI.bTempCorpse = NPC_AI.bCorpse083; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_084) { NPC_AI.iTempLocation = NPC_AI.NPC084_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty084; NPC_AI.bTempCorpse = NPC_AI.bCorpse084; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_085) { NPC_AI.iTempLocation = NPC_AI.NPC085_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty085; NPC_AI.bTempCorpse = NPC_AI.bCorpse085; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_086) { NPC_AI.iTempLocation = NPC_AI.NPC086_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty086; NPC_AI.bTempCorpse = NPC_AI.bCorpse086; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_087) { NPC_AI.iTempLocation = NPC_AI.NPC087_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty087; NPC_AI.bTempCorpse = NPC_AI.bCorpse087; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_088) { NPC_AI.iTempLocation = NPC_AI.NPC088_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty088; NPC_AI.bTempCorpse = NPC_AI.bCorpse088; InfiniteLoop = InfiniteLoop + 1; }
                        if (tempTarget == NPC_AI.NPC_089) { NPC_AI.iTempLocation = NPC_AI.NPC089_CurrentNumLocation; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty089; NPC_AI.bTempCorpse = NPC_AI.bCorpse089; InfiniteLoop = InfiniteLoop + 1; }
                        // KILLER SPREE STARTS
                        if (tempTarget == RandomEncounters.sBestFriend_Name) // this should prevent infinite loops with the player's best friend.
                        {
                            Lists.RemainingNPCs.Remove(tempTarget);
                            iRemainingTargets--; // Remove one target from total to kill.
                        }
                        if ((Variables.iCurrentLocation != NPC_AI.iTempLocation) && (NPC_AI.bTempCorpse == false)) // Only run if our target is not where the player is, and the target is not already a corpse.
                        {
                            if (NPC_AI.iTempLoyalty > 2) // loyalty == 3, 4, or 5
                            {
                                NPC_AI.iLoyaltyCheck = Program.rand.Next(1, 4); // 2/3rds chance to ignore someone to whom the player has loyalty
                                if (NPC_AI.iLoyaltyCheck <= 2)
                                { /* Console.WriteLine("DEBUG: I tried to kill a loyal person, but got stopped at Loyalty Check!"); */ }
                                else if (NPC_AI.iLoyaltyCheck == 3) // from 1, 2 or 3, roll a 3
                                {
                                    // Console.WriteLine("DEBUG: Loyalty Check did not stop me! Death!");
                                    NPC_AI.bTempCorpse = true;
                                    Lists.RemainingNPCs.Remove(tempTarget);
                                    Lists.BulletRiddled.Add(tempTarget);
                                    iRemainingTargets--; // Remove one target from total to kill.
                                    // Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("A gunshot rings out."); Console.ForegroundColor = ConsoleColor.Yellow; iTargets--; //Console.WriteLine(NPC_AI.NPC_001 + " died!");
                                }
                            }
                            else if (NPC_AI.iTempLoyalty <= 2) // from 1, 2, or 3, roll a 1 or 2
                            {
                                NPC_AI.bTempCorpse = true;
                                Lists.RemainingNPCs.Remove(tempTarget);
                                Lists.BulletRiddled.Add(tempTarget);
                                iRemainingTargets--; // Remove one target from total to kill.
                                // Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("A gunshot rings out."); Console.ForegroundColor = ConsoleColor.Yellow; iTargets--; //Console.WriteLine(NPC_AI.NPC_001 + " died!");
                            }
                        }
                        // KILLER SPREE ENDS
                        if (tempTarget == NPC_AI.NPC_001) { NPC_AI.bCorpse001 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_002) { NPC_AI.bCorpse002 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_003) { NPC_AI.bCorpse003 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_004) { NPC_AI.bCorpse004 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_005) { NPC_AI.bCorpse005 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_006) { NPC_AI.bCorpse006 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_007) { NPC_AI.bCorpse007 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_008) { NPC_AI.bCorpse008 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_009) { NPC_AI.bCorpse009 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_010) { NPC_AI.bCorpse010 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_011) { NPC_AI.bCorpse011 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_012) { NPC_AI.bCorpse012 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_013) { NPC_AI.bCorpse013 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_014) { NPC_AI.bCorpse014 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_015) { NPC_AI.bCorpse015 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_016) { NPC_AI.bCorpse016 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_017) { NPC_AI.bCorpse017 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_018) { NPC_AI.bCorpse018 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_019) { NPC_AI.bCorpse019 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_020) { NPC_AI.bCorpse020 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_021) { NPC_AI.bCorpse021 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_022) { NPC_AI.bCorpse022 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_023) { NPC_AI.bCorpse023 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_024) { NPC_AI.bCorpse024 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_025) { NPC_AI.bCorpse025 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_026) { NPC_AI.bCorpse026 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_027) { NPC_AI.bCorpse027 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_028) { NPC_AI.bCorpse028 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_029) { NPC_AI.bCorpse029 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_030) { NPC_AI.bCorpse030 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_031) { NPC_AI.bCorpse031 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_032) { NPC_AI.bCorpse032 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_033) { NPC_AI.bCorpse033 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_034) { NPC_AI.bCorpse034 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_035) { NPC_AI.bCorpse035 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_036) { NPC_AI.bCorpse036 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_037) { NPC_AI.bCorpse037 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_038) { NPC_AI.bCorpse038 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_039) { NPC_AI.bCorpse039 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_040) { NPC_AI.bCorpse040 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_041) { NPC_AI.bCorpse041 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_042) { NPC_AI.bCorpse042 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_043) { NPC_AI.bCorpse043 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_044) { NPC_AI.bCorpse044 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_045) { NPC_AI.bCorpse045 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_046) { NPC_AI.bCorpse046 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_047) { NPC_AI.bCorpse047 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_048) { NPC_AI.bCorpse048 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_049) { NPC_AI.bCorpse049 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_050) { NPC_AI.bCorpse050 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_051) { NPC_AI.bCorpse051 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_052) { NPC_AI.bCorpse052 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_053) { NPC_AI.bCorpse053 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_054) { NPC_AI.bCorpse054 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_055) { NPC_AI.bCorpse055 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_056) { NPC_AI.bCorpse056 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_057) { NPC_AI.bCorpse057 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_058) { NPC_AI.bCorpse058 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_059) { NPC_AI.bCorpse059 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_060) { NPC_AI.bCorpse060 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_061) { NPC_AI.bCorpse061 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_062) { NPC_AI.bCorpse062 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_063) { NPC_AI.bCorpse063 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_064) { NPC_AI.bCorpse064 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_065) { NPC_AI.bCorpse065 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_066) { NPC_AI.bCorpse066 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_067) { NPC_AI.bCorpse067 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_068) { NPC_AI.bCorpse068 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_069) { NPC_AI.bCorpse069 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_070) { NPC_AI.bCorpse070 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_071) { NPC_AI.bCorpse071 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_072) { NPC_AI.bCorpse072 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_073) { NPC_AI.bCorpse073 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_074) { NPC_AI.bCorpse074 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_075) { NPC_AI.bCorpse075 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_076) { NPC_AI.bCorpse076 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_077) { NPC_AI.bCorpse077 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_078) { NPC_AI.bCorpse078 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_079) { NPC_AI.bCorpse079 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_080) { NPC_AI.bCorpse080 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_081) { NPC_AI.bCorpse081 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_082) { NPC_AI.bCorpse082 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_083) { NPC_AI.bCorpse083 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_084) { NPC_AI.bCorpse084 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_085) { NPC_AI.bCorpse085 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_086) { NPC_AI.bCorpse086 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_087) { NPC_AI.bCorpse087 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_088) { NPC_AI.bCorpse088 = NPC_AI.bTempCorpse; }
                        if (tempTarget == NPC_AI.NPC_089) { NPC_AI.bCorpse089 = NPC_AI.bTempCorpse; }
                        Program.AnyoneStillAliveICanFixThat();
                    }
                    // After the spree-killing while-loop has completed, let us know what the damage is:
                    if (Lists.BulletRiddled.Count > 0)
                    {
                        //while (Lists.BulletRiddled.Count > 0)
                        //{
                        //    iVictim = rand.Next(Lists.BulletRiddled.Count); // Pick a random dead NPC from the TheLocalDead list.
                        //    string sVictim = Lists.BulletRiddled[iVictim]; // Use "tempNPC" as the currently-selected NPC from the list.
                        //    Console.ForegroundColor = ConsoleColor.Red;
                        //    Console.WriteLine("Lightning reaches from the heavens to jitter along the ground. " + sVictim + " is gone.");
                        //    // Console.WriteLine("The dead body of " + sVictim + " is here.");
                        //    Lists.BulletRiddled.RemoveAt(iVictim);
                        //    Console.ForegroundColor = ConsoleColor.Yellow;
                        //}
                        Console.WriteLine();
                        // if (Lists.BulletRiddled.Count >= 2)
                        // { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Dark red arcs of lightning flare across the night sky."); }
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("In the distance, dark-red lightning gives the island a bloody-red color.");
                        // { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Black-red flashes of lightning give the island a blood-red color."); }  
                        if (NPC_AI.iLightningsFirstStrike == 0)
                        {
                            NPC_AI.iLightningsFirstStrike = 1;
                        }
                    }
                }
            }
        }
    }
}