using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Title
    {
        // Secrets (i.e. achievements)
        public static bool
        bAchievement01, bAchievement02, bAchievement03, bAchievement04, bAchievement05,
        bAchievement06, bAchievement07, bAchievement08, bAchievement09, bAchievement10,
        bAchievement11, bAchievement12, bAchievement13, bAchievement14, bAchievement15,
        bAchievement16, bAchievement17, bAchievement18, bAchievement19, bAchievement20,
        bAchievement21, bAchievement22, bAchievement23, bAchievement24;

        public static bool
        bLoadAchievement01, bLoadAchievement02, bLoadAchievement03, bLoadAchievement04, bLoadAchievement05,
        bLoadAchievement06, bLoadAchievement07, bLoadAchievement08, bLoadAchievement09, bLoadAchievement10,
        bLoadAchievement11, bLoadAchievement12, bLoadAchievement13, bLoadAchievement14, bLoadAchievement15,
        bLoadAchievement16, bLoadAchievement17, bLoadAchievement18, bLoadAchievement19, bLoadAchievement20,
        bLoadAchievement21, bLoadAchievement22, bLoadAchievement23, bLoadAchievement24;

        public static string
        sAchievement01, sAchievement02, sAchievement03, sAchievement04, sAchievement05,
        sAchievement06, sAchievement07, sAchievement08, sAchievement09, sAchievement10,
        sAchievement11, sAchievement12, sAchievement13, sAchievement14, sAchievement15,
        sAchievement16, sAchievement17, sAchievement18, sAchievement19, sAchievement20,
        sAchievement21, sAchievement22, sAchievement23, sAchievement24;

        public static string FilePath, sTitleMenuChoice;

        public static void ScreenDimensions()
        {
            int width = (Console.LargestWindowWidth * 6 / 10);
            int height = (Console.LargestWindowHeight * 8 / 10);
            Console.SetWindowSize(width, height);
            System.Console.SetWindowPosition(0, 0);  // sets window position to upper left
        }

        public static void TitleScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("I Think The Waves Are Watching Me.");
            Console.WriteLine("By Bob McCabe.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Build: " + Variables.iBuild);
            Console.WriteLine();
            Console.WriteLine("(G)etting Started.");
            Console.WriteLine("(P)lay the Game.");
            Console.WriteLine("(S)ecrets I've unlocked.");
            Console.WriteLine("(C)redits/Thanks.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            sTitleMenuChoice = Console.ReadLine();
            sTitleMenuChoice.ToLower();
            Console.WriteLine();
            while (sTitleMenuChoice != "g" && sTitleMenuChoice != "p" && sTitleMenuChoice != "s" && sTitleMenuChoice != "c")
            {
                TitleScreen();
            }

            switch (sTitleMenuChoice.ToLower())
            {
                case "g": // Getting Started
                    GettingStarted();
                    break;
                case "p": // Play the Game
                    Program.Game_StartNewGame();
                    break;
                case "s": // Unlocked Secrets
                    Get_Secrets();
                    break;
                case "c": // Credits
                    Credits();
                    break;
            }
        }

        public static void GettingStarted()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("Once you choose to play, you'll find yourself in an island town at the");
            Console.WriteLine("end of its days. Tidal waves have surrounded the island, and it won't be");
            Console.WriteLine("long before they come crashing down and the island is lost forever.");
            Console.WriteLine();
            Console.WriteLine("But there may be no one left to witness that event. Soon after you");
            Console.WriteLine("begin, a stranger will move throughout the town, leaving a trail of");
            Console.WriteLine("corpses and jagged red lightning in their wake.");
            Console.WriteLine();
            Console.WriteLine("Who would do this, and why? With the help of a rabbit, you may figure");
            Console.WriteLine("out the who, if not the why. But the answer to why may be somewhere");
            Console.WriteLine("on the island, too.");
            Console.WriteLine();
            Console.WriteLine("I Think the Waves are Watching Me is a game about mystery, of");
            Console.WriteLine("exploration and discovery. The characters and their traits, and even ");
            Console.WriteLine("when some events occur, are randomly generated, giving you the");
            Console.WriteLine("opportunity to discover new things each time you play.");
            Console.WriteLine();
            Console.WriteLine("But when you start, you may find yourself a bit overwhelmed. That clock");
            Console.WriteLine("is ticking down, and things are happening, and -- it's OK. Take a deep");
            Console.WriteLine("breath. Here are a couple suggestions:");
            Console.WriteLine();
            Console.WriteLine("1) Talk to, or just watch, some people to get a sense of who you think");
            Console.WriteLine("you can trust, to enlist their help, or maybe to ask for some 'MacGuffins'.");
            Console.WriteLine();
            Console.WriteLine("2) Take some time to wander around and explore the locations. Maybe");
            Console.WriteLine("you'll find a safe and wonder about a combination. Maybe you'll treat");
            Console.WriteLine("everyone to a round at the bar. Or maybe you'll shine some light on");
            Console.WriteLine("things from the lighthouse.");
            Console.WriteLine();
            Console.WriteLine("And if someone wants to speak with you, it may not be a bad idea to");
            Console.WriteLine("stop what you're doing and find out what they want. On the other hand,");
            Console.WriteLine("if they're giving you a bad vibe...");
            Console.WriteLine();
            Console.WriteLine("These are your last minutes on the island. And this town is your");
            Console.WriteLine("playground. What happens next depends on what you decide.");
            Program.PressAnyKey();
            TitleScreen();
        }

        public static void GameOver_PlayAgainOption()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Any updates about this game, or future games, will be posted at");
            Console.WriteLine("trickybuddha.com");
            Console.WriteLine();
            Console.WriteLine("Thank you for playing. And now that you have played, I would love to");
            Console.WriteLine("hear what you thought about my game. By pressing 'f', a questionnaire");
            Console.WriteLine("will open up in your browser (directed at http://goo.gl/AuozNN).");
            Console.WriteLine("Any information you provide will be greatly appreciated.");
            Console.WriteLine("TIP: when asked for the build number, please specify build: " + Variables.iBuild);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(Press 'y' to play again. Press 'f' to offer feedback via the survey.)");
            Console.WriteLine("(Press any other key to quit the game.)");
            Console.WriteLine();
            ConsoleKeyInfo Feedback = Console.ReadKey();
            while (Feedback.KeyChar == 'f')
            {
                if (Feedback.KeyChar == 'f')
                {
                    Uri myUri = new Uri("http://goo.gl/AuozNN");
                    System.Diagnostics.Process.Start(myUri.AbsoluteUri);
                    Feedback = Console.ReadKey();
                }
            }
            if (Feedback.KeyChar == 'y')
            {
                TitleScreen();
            }
            if (Feedback.KeyChar != 'f' && Feedback.KeyChar != 'y')
            {
                Variables.bGameActive = false;
            }
            //switch (Variables.bGameActive.ToLower())
            //{
            //    //case "y":
            //    //    Variables.bGameActive = "y";
            //    //    // Initialize variables!

            //    //    Console.Clear();
            //    //    break;
            //    case "n":
            //        Variables.bGameActive = "n";
            //        break;
            //    default:
            //        Variables.bGameActive = "n";
            //        break;
            //}
        }

        public static void Initialize_TitleVars()
        {
            bAchievement01 = bAchievement02 = bAchievement03 = bAchievement04 = bAchievement05 =
            bAchievement06 = bAchievement07 = bAchievement08 = bAchievement09 = bAchievement10 =
            bAchievement11 = bAchievement12 = bAchievement13 = bAchievement14 = bAchievement15 =
            bAchievement16 = bAchievement17 = bAchievement18 = bAchievement19 = bAchievement20 =
            bAchievement21 = bAchievement22 = bAchievement23 = bAchievement24 = false;

            bLoadAchievement01 = bLoadAchievement02 = bLoadAchievement03 = bLoadAchievement04 = bLoadAchievement05 =
            bLoadAchievement06 = bLoadAchievement07 = bLoadAchievement08 = bLoadAchievement09 = bLoadAchievement10 =
            bLoadAchievement11 = bLoadAchievement12 = bLoadAchievement13 = bLoadAchievement14 = bLoadAchievement15 =
            bLoadAchievement16 = bLoadAchievement17 = bLoadAchievement18 = bLoadAchievement19 = bLoadAchievement20 =
            bLoadAchievement21 = bLoadAchievement22 = bLoadAchievement23 = bLoadAchievement24 = false;
        }

        public static void Initialize_Secrets()
        {
            FilePath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "WatchingWaveResults.txt");
            StreamWriter sw = new StreamWriter(FilePath, true);
            sw.Close();

            // Which of the 12 Secrets that the player has earned, with a reminder on how they earned it.
            sAchievement01 = "'Booze solves all problems.'\n\r      Reminder: You drank until you blacked out.";
            sAchievement02 = "'There are stranger ways to fry a fish.'\n\r      Reminder: Found the underwater fish kingdom.";
            sAchievement03 = "'What we don't see is everything we know.'\n\r      Reminder: You spoke with the censored figure.";
            sAchievement04 = "'But I beat the game, right?'\n\r      Reminder: You identified-and-stopped the killer.";
            sAchievement05 = "'Escaping from a fantasy.'\n\r      Reminder: You took your MacGuffins to the Jetty and went home.";
            sAchievement06 = "'It's true: you can buy friendship.'\n\r      Reminder: You made at least 10 people like you.";
            sAchievement07 = "'That's one possible outcome.'\n\r      Reminder: You were swept away by the tidal waves.";
            sAchievement08 = "'Whose side are you on?'\n\r      Reminder: You caused 10 innocents to die. (But is anyone really 'innocent'?)";
            sAchievement09 = "'Hit the snooze button.'\n\r      Reminder: You used the clocktower to gain some extra time.";
            sAchievement10 = "'Not that kind of cracker.'\n\r      Reminder: You opened the safe and made off with some MacGuffins.";
            sAchievement11 = "'A real fixer-upper.'\n\r      Reminder: You fixed the lighthouse's light.";
            sAchievement12 = "'Aren't we nosy'\n\r      Reminder: You discovered all of these secrets.";

            // Which of the 12 Secrets that the player has NOT YET earned, with a HINT on how to earn it.
            sAchievement13 = "'Booze solves all problems.'\n\r      Hint: Have some drinks, make some friends. But bring plenty of MacGuffins.";
            sAchievement14 = "'There are stranger ways to fry a fish.'\n\r      Hint: When given the chance to peep on an amorous couple, you take it.";
            sAchievement15 = "'What we don't see is everything we know.'\n\r      Hint: Stop asking what it's all about, and get an answer.";
            sAchievement16 = "'But I beat the game, right?'\n\r      Hint: Stop the killer before the killer stops you.";
            sAchievement17 = "'Escaping from a fantasy.'\n\r      Hint: You'd get this for escaping the island, but that's not possible. Right?";
            sAchievement18 = "'It's true: you can buy friendship.'\n\r      Hint: Make people like you. How many people? You tell me.";
            sAchievement19 = "'That's one possible outcome.'\n\r      Hint: Ever think to try not avoiding the tidal waves?";
            sAchievement20 = "'Whose side are you on?'\n\r      Hint: The stranger isn't the only person who can kill.";
            sAchievement21 = "'Hit the snooze button.'\n\r      Hint: Snooze buttons go with clocks. See a clock anywhere?";
            sAchievement22 = "'Not that kind of cracker.'\n\r      Hint: Break into a safe, if you're clever enough.";
            sAchievement23 = "'A real fixer-upper.'\n\r      Hint: Too bad that lighthouse is in a state of disrepair.";
            sAchievement24 = "'Aren't we nosy'\n\r      Hint: Unlock all of the secrets to earn this.";
        }

        public static void Credits()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("Thank you so much for taking the time to play this game.");
            Console.WriteLine();
            Console.WriteLine("Thanks to my wife, Candice Kaffenberger, who pushed me and");
            Console.WriteLine("supported me. She made this game possible.");
            Console.WriteLine();
            Console.WriteLine("Thanks again to Candice, and also to Sean Molofee, for all of the time");
            Console.WriteLine("that they spent listening to me talk about this game idea, and for giving");
            Console.WriteLine("me new ideas to work with.");
            Console.WriteLine();
            Console.WriteLine("Thanks to the website game-testing.org, without which I never would");
            Console.WriteLine("have been introduced to my volunteer editor, Joel Webster. Joel single-");
            Console.WriteLine("handedly reviewed the massive amount of text in this game, and found");
            Console.WriteLine("dozens of the mistakes that had eluded me.");
            Console.WriteLine();
            Console.WriteLine("The site also brought me 'Katzy' and Devi Acharya, who graciously");
            Console.WriteLine("supported me with time spent reporting problems and mistakes, as well");
            Console.WriteLine("as putting a lot of effort into understanding what I was trying to make.");
            Console.WriteLine();
            Console.WriteLine("And, finally, thanks to everyone above, as well as Erin Garcia, Matt");
            Console.WriteLine("Battaglia, Chris Weiss, and Cat Jarret for playing the game multiple");
            Console.WriteLine("times and helping me to understand the parts that were fun and the");
            Console.WriteLine("parts that needed to be improved.");
            Console.WriteLine();
            Console.WriteLine("In memory of Steve Sparks, a great friend who I will never stop missing.");
            Program.PressAnyKey();
            TitleScreen();
        }

        public static void Get_Secrets()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            string file = File.ReadAllText(FilePath);
            if (file.Contains("Booze solves all problems.")) { bAchievement01 = true; }
            if (file.Contains("There are stranger ways to fry a fish.")) { bAchievement02 = true; }
            if (file.Contains("What we don't see is everything we know.")) { bAchievement03 = true; }
            if (file.Contains("But I beat the game, right?")) { bAchievement04 = true; }
            if (file.Contains("Escaping from a fantasy.")) { bAchievement05 = true; }
            if (file.Contains("It's true: you can buy friendship.")) { bAchievement06 = true; }
            if (file.Contains("That's one possible outcome.")) { bAchievement07 = true; }
            if (file.Contains("Whose side are you on?")) { bAchievement08 = true; }
            if (file.Contains("Hit the snooze button.")) { bAchievement09 = true; }
            if (file.Contains("Not that kind of cracker.")) { bAchievement10 = true; }
            if (file.Contains("A real fixer-upper.")) { bAchievement11 = true; }

            bLoadAchievement01 = (from line in File.ReadAllLines(FilePath) where line == "Booze solves all problems." select line).Count() > 0;
            bLoadAchievement02 = (from line in File.ReadAllLines(FilePath) where line == "There are stranger ways to fry a fish." select line).Count() > 0;
            bLoadAchievement03 = (from line in File.ReadAllLines(FilePath) where line == "What we don't see is everything we know." select line).Count() > 0;
            bLoadAchievement04 = (from line in File.ReadAllLines(FilePath) where line == "But I beat the game, right?" select line).Count() > 0;
            bLoadAchievement05 = (from line in File.ReadAllLines(FilePath) where line == "Escaping from a fantasy." select line).Count() > 0;
            bLoadAchievement06 = (from line in File.ReadAllLines(FilePath) where line == "It's true: you can buy friendship." select line).Count() > 0;
            bLoadAchievement07 = (from line in File.ReadAllLines(FilePath) where line == "That's one possible outcome." select line).Count() > 0;
            bLoadAchievement08 = (from line in File.ReadAllLines(FilePath) where line == "Whose side are you on?" select line).Count() > 0;
            bLoadAchievement09 = (from line in File.ReadAllLines(FilePath) where line == "Hit the snooze button." select line).Count() > 0;
            bLoadAchievement10 = (from line in File.ReadAllLines(FilePath) where line == "Not that kind of cracker." select line).Count() > 0;
            bLoadAchievement11 = (from line in File.ReadAllLines(FilePath) where line == "A real fixer-upper." select line).Count() > 0;

            if (bLoadAchievement01) { bAchievement01 = true; }
            if (bLoadAchievement02) { bAchievement02 = true; }
            if (bLoadAchievement03) { bAchievement03 = true; }
            if (bLoadAchievement04) { bAchievement04 = true; }
            if (bLoadAchievement05) { bAchievement05 = true; }
            if (bLoadAchievement06) { bAchievement06 = true; }
            if (bLoadAchievement07) { bAchievement07 = true; }
            if (bLoadAchievement08) { bAchievement08 = true; }
            if (bLoadAchievement09) { bAchievement09 = true; }
            if (bLoadAchievement10) { bAchievement10 = true; }
            if (bLoadAchievement11) { bAchievement11 = true; }

            if (
            bAchievement01 && bAchievement02 && bAchievement03 && bAchievement04 && bAchievement05 &&
            bAchievement06 && bAchievement07 && bAchievement08 && bAchievement09 && bAchievement10 &&
            bAchievement11) { bAchievement12 = true; }

            Console.WriteLine("Secrets you have discovered:");
            Console.WriteLine();
            if (bAchievement01) { Console.WriteLine("   " + sAchievement01); }
            if (bAchievement02) { Console.WriteLine("   " + sAchievement02); }
            if (bAchievement03) { Console.WriteLine("   " + sAchievement03); }
            if (bAchievement04) { Console.WriteLine("   " + sAchievement04); }
            if (bAchievement05) { Console.WriteLine("   " + sAchievement05); }
            if (bAchievement06) { Console.WriteLine("   " + sAchievement06); }
            if (bAchievement07) { Console.WriteLine("   " + sAchievement07); }
            if (bAchievement08) { Console.WriteLine("   " + sAchievement08); }
            if (bAchievement09) { Console.WriteLine("   " + sAchievement09); }
            if (bAchievement10) { Console.WriteLine("   " + sAchievement10); }
            if (bAchievement11) { Console.WriteLine("   " + sAchievement11); }
            if (bAchievement12) { Console.WriteLine("   " + sAchievement12); }

            Console.WriteLine();
            Console.WriteLine("Secrets yet to be discovered:");
            Console.WriteLine();
            if (!bAchievement01) { Console.WriteLine("   " + sAchievement13); }
            if (!bAchievement02) { Console.WriteLine("   " + sAchievement14); }
            if (!bAchievement03) { Console.WriteLine("   " + sAchievement15); }
            if (!bAchievement04) { Console.WriteLine("   " + sAchievement16); }
            if (!bAchievement05) { Console.WriteLine("   " + sAchievement17); }
            if (!bAchievement06) { Console.WriteLine("   " + sAchievement18); }
            if (!bAchievement07) { Console.WriteLine("   " + sAchievement19); }
            if (!bAchievement08) { Console.WriteLine("   " + sAchievement20); }
            if (!bAchievement09) { Console.WriteLine("   " + sAchievement21); }
            if (!bAchievement10) { Console.WriteLine("   " + sAchievement22); }
            if (!bAchievement11) { Console.WriteLine("   " + sAchievement23); }
            if (!bAchievement12) { Console.WriteLine("   " + sAchievement24); }

            if (
            !bAchievement01 && !bAchievement02 && !bAchievement03 && !bAchievement04 && !bAchievement05 &&
            !bAchievement06 && !bAchievement07 && !bAchievement08 && !bAchievement09 && !bAchievement10 &&
            !bAchievement11 && !bAchievement12) { Console.WriteLine("    You haven't discovered any... yet."); }
            Program.PressAnyKey();
            TitleScreen();
        }

        public static void ButPopularityIsImportant()
        {
            if (!bAchievement06)
            {
                if (Lists.Popularity.Count >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    bAchievement06 = true;
                    Console.WriteLine("   Secret Discovered: " + sAchievement06);
                }
            }
            if (!bAchievement08)
            {
                if (Variables.iAcciKilled >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    bAchievement08 = true;
                    Console.WriteLine("   Secret Discovered: " + sAchievement08);
                }
            }
        }

        public static void ShowScore()
        {
            double dScoreMod = 0;
            double dTotalScore = 0;
            if (Variables.playerSurvived == Variables.sPlayerState1) { dScoreMod = 0.75; }
            if (Variables.playerSurvived == Variables.sPlayerState2) { dScoreMod = 0.5; }
            if (Variables.playerSurvived == Variables.sPlayerState3) { dScoreMod = 1.25; }
            if (Variables.playerSurvived == Variables.sPlayerState4) { dScoreMod = 0; }
            if (Variables.playerSurvived == Variables.sPlayerState5) { dScoreMod = 1.25; }
            double dPre20 = 0;
            double dMac = (Variables.iFoundMacGuffins * 2) + (Variables.iFinishingMac * 2);
            double dRemTurns = Variables.iFinishingTurn * 5;
            double dSurvivors = Lists.RemainingNPCs.Count * 10;
            double dAcciKilled = Variables.iAcciKilled * 75;
            double dRandEncounters = Variables.iRandEncounters * 10;
            int iDiscoveredClues = 0;
            if (NPC_Traits.bTraitThreeBunny) { iDiscoveredClues = 3; }
            if (NPC_Traits.bTraitTwoBunny) { iDiscoveredClues = 2; }
            if (NPC_Traits.bTraitOneBunny) { iDiscoveredClues = 1; }
            if (!NPC_Traits.bTraitOneBunny && !NPC_Traits.bTraitTwoBunny && !NPC_Traits.bTraitThreeBunny) { iDiscoveredClues = 0; }
            double dDiscoveredClues = iDiscoveredClues * 50;
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Score!
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("The game is over."); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("You spent " + NPC_AI.iClose100 + " minutes around the killer.");
            Console.WriteLine("You made " + Notebook.iNotebookHasInfo + " entries in your notebook.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Secrets Discovered (To Date):"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            if (bAchievement01) { Console.WriteLine("   " + sAchievement01); }
            if (bAchievement02) { Console.WriteLine("   " + sAchievement02); }
            if (bAchievement03) { Console.WriteLine("   " + sAchievement03); }
            if (bAchievement04) { Console.WriteLine("   " + sAchievement04); }
            if (bAchievement05) { Console.WriteLine("   " + sAchievement05); }
            if (bAchievement06) { Console.WriteLine("   " + sAchievement06); }
            if (bAchievement07) { Console.WriteLine("   " + sAchievement07); }
            if (bAchievement08) { Console.WriteLine("   " + sAchievement08); }
            if (bAchievement09) { Console.WriteLine("   " + sAchievement09); }
            if (bAchievement10) { Console.WriteLine("   " + sAchievement10); }
            if (bAchievement11) { Console.WriteLine("   " + sAchievement11); }
            if (bAchievement12) { Console.WriteLine("   " + sAchievement12); }
            if (!bAchievement01 && !bAchievement02 && !bAchievement03 && !bAchievement04 && !bAchievement05 &&
            !bAchievement06 && !bAchievement07 && !bAchievement08 && !bAchievement09 && !bAchievement10)
            { Console.WriteLine("None."); }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Your Score:"); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            if (Variables.iFinishingTurn > 20 && NPC_AI.bCorpse100 && !LocationEncounters.bDontAuto23) { dPre20 = 100; Console.WriteLine("+100 points for figuring out the killer's identity."); }
            if (Variables.iFinishingTurn <= 20 && NPC_AI.bCorpse100 && !LocationEncounters.bDontAuto23) { dPre20 = 50; Console.WriteLine("+50 points for meeting the killer and getting to the final turns."); }
            if (NPC_AI.bCorpse100 == false) { Console.WriteLine("+0 points for failing to stop the killer."); }
            Console.WriteLine("+10 points/Survivor: You earned " + dSurvivors + " points since " + Lists.RemainingNPCs.Count + " people survived.");
            Console.WriteLine("+2 points/MacGuffin: You earned " + (dMac) + " points for having " + (Variables.iFoundMacGuffins + Variables.iFinishingMac) + " MacGuffins.");
            if (Variables.iFinishingMac > 0) { Console.WriteLine("   You had " + Variables.iFinishingMac + " MacGuffins prior to losing them when you met the killer."); }
            if (Variables.iFinishingMac > 0 && Variables.iFoundMacGuffins > 0) { Console.WriteLine("   You then found " + Variables.iFoundMacGuffins + " more MacGuffins."); }
            Console.WriteLine("+5 points/Turn Remaining: You earned " + (dRemTurns) + " points since " + (Variables.iFinishingTurn) + " turns remained.");
            Console.WriteLine("+10 points/Random Encounter Completed: You earned " + dRandEncounters + " points since you resolved " + Variables.iRandEncounters + " encounters.");
            Console.WriteLine("+50 points/Clue Found: You earned " + dDiscoveredClues + " points for finding " + iDiscoveredClues + " clues.");
            Console.WriteLine();
            Console.WriteLine("-75 points/Person you caused to die. You lost " + dAcciKilled + " points since " + Variables.iAcciKilled + " people died, directly/indirectly, because of you.");
            Console.WriteLine();
            double dSubScore = (dMac) + (dRemTurns) + dRandEncounters + (dPre20) + (dSurvivors) - (dAcciKilled) + (dDiscoveredClues);
            if (dSubScore >= 0)
            {
                dTotalScore = dSubScore * dScoreMod;
            }
            if (dSubScore < 0)
            {
                dTotalScore = dSubScore + (dSubScore * dScoreMod * -1);
            }
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Subtotal: " + dSubScore); Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("You: " + Variables.playerSurvived + " (Modifiers: Survived (x1.25), Slept (x0.75), Swept Away (x0.5), Abandoned Hope (x0).");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("TOTAL: " + dTotalScore);
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                FilePath = Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "WatchingWaveResults.txt");
                StreamWriter sw = new StreamWriter(FilePath, true);
                // Score, printed!
                sw.WriteLine("*****");
                sw.WriteLine();
                sw.WriteLine("You spent " + NPC_AI.iClose100 + " minutes around the killer.");
                sw.WriteLine("You made " + Notebook.iNotebookHasInfo + " entries in your notebook.");
                sw.WriteLine();
                sw.WriteLine("Secrets Discovered (To Date):");
                sw.WriteLine();
                if (bAchievement01) { sw.WriteLine("   " + sAchievement01); }
                if (bAchievement02) { sw.WriteLine("   " + sAchievement02); }
                if (bAchievement03) { sw.WriteLine("   " + sAchievement03); }
                if (bAchievement04) { sw.WriteLine("   " + sAchievement04); }
                if (bAchievement05) { sw.WriteLine("   " + sAchievement05); }
                if (bAchievement06) { sw.WriteLine("   " + sAchievement06); }
                if (bAchievement07) { sw.WriteLine("   " + sAchievement07); }
                if (bAchievement08) { sw.WriteLine("   " + sAchievement08); }
                if (bAchievement09) { sw.WriteLine("   " + sAchievement09); }
                if (bAchievement10) { sw.WriteLine("   " + sAchievement10); }
                if (bAchievement11) { sw.WriteLine("   " + sAchievement11); }
                if (bAchievement12) { sw.WriteLine("   " + sAchievement12); }
                if (!bAchievement01 && !bAchievement02 && !bAchievement03 && !bAchievement04 && !bAchievement05 &&
                !bAchievement06 && !bAchievement07 && !bAchievement08 && !bAchievement09 && !bAchievement10)
                { sw.WriteLine("None."); }
                sw.WriteLine();
                sw.WriteLine("Your Score:");
                sw.WriteLine();
                if (Variables.iFinishingTurn > 20 && NPC_AI.bCorpse100 && !LocationEncounters.bDontAuto23) { dPre20 = 100; sw.WriteLine("+100 points for figuring out who was marking people for death."); }
                if (Variables.iFinishingTurn <= 20 && NPC_AI.bCorpse100 && !LocationEncounters.bDontAuto23) { dPre20 = 50; sw.WriteLine("+50 points for stopping the one who would mark others for death."); }
                if (NPC_AI.bCorpse100 == false) { sw.WriteLine("+0 points for failing to stop the killer."); }
                sw.WriteLine("+10 points/Survivor: You earned " + dSurvivors + " points since " + Lists.RemainingNPCs.Count + " people survived.");
                sw.WriteLine("+2 points/MacGuffin: You earned " + (dMac) + " points for having " + (Variables.iFoundMacGuffins + Variables.iFinishingMac) + " MacGuffins.");
                if (Variables.iFinishingMac > 0) { sw.WriteLine("   You had " + Variables.iFinishingMac + " MacGuffins prior to losing them when you met the killer."); }
                if (Variables.iFinishingMac > 0 && Variables.iFoundMacGuffins > 0) { sw.WriteLine("   You then found " + Variables.iFoundMacGuffins + " more MacGuffins."); }
                sw.WriteLine("+5 points/Turn Remaining: You earned " + (dRemTurns) + " points since " + (Variables.iFinishingTurn) + " turns remained.");
                sw.WriteLine("+10 points/Random Encounter Completed: You earned " + dRandEncounters + " points since you resolved " + Variables.iRandEncounters + " encounters.");
                sw.WriteLine("+50 points/Clue Found: You earned " + dDiscoveredClues + " points for finding " + iDiscoveredClues + " clues.");
                sw.WriteLine();
                sw.WriteLine("-250 points/Person you caused to die. You lost " + dAcciKilled + " points since " + Variables.iAcciKilled + " people died, directly/indirectly, because of you.");
                sw.WriteLine();
                dSubScore = (dMac) + (dRemTurns) + dRandEncounters + (dPre20) + (dSurvivors) - (dAcciKilled) + (dDiscoveredClues);
                if (dSubScore >= 0)
                {
                    dTotalScore = dSubScore * dScoreMod;
                }
                if (dSubScore < 0)
                {
                    dTotalScore = dSubScore + (dSubScore * dScoreMod * -1);
                }
                sw.WriteLine("Subtotal: " + dSubScore);
                sw.WriteLine();
                sw.WriteLine("You: " + Variables.playerSurvived + " (Modifiers: Stopped Fate (x1.25), Slept (x0.75), Swept Away (x0.5), Abandoned Hope (x0).");
                sw.WriteLine();
                sw.WriteLine("TOTAL: " + dTotalScore);
                sw.WriteLine();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Saving playthrough results as 'WatchingWaveResults.txt' at the root of the 'My Documents' folder.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
            GameOver_PlayAgainOption();
        }
    }
}
