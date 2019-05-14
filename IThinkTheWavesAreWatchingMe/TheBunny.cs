using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class TheBunny
    {
        // Variables for managing the bunny.
        public static int iBunnyHop;
        public static int iBunnyRun;
        public static int iBunnyDodge;
        public static int iBunnyStage;
        public static int iBunnyGift;
        public static int iClueNPC;
        public static int iGiftLocation;
        public static int iTempRemainingTurns;
        public static string sClueNPC;
        public static bool bClueNPC;
        public static bool bTooLateBunny;
        public static bool bBunnyIntro;
        public static bool bBunnyFirstHop;
        public static bool bBunnyPauseToHide;
        public static bool bHurry;
        public static bool bSceneAlreadyPlayed;

        public static string
        sBunnyRiddleOne, sBunnyRiddleTwo,
        sBunnyRiddleOneA, sBunnyRiddleOneB, sBunnyRiddleOneC, sBunnyRiddleOneD, sBunnyRiddleOneE,
        sBunnyRiddleOneF, sBunnyRiddleOneG, sBunnyRiddleOneH, sBunnyRiddleOneI, sBunnyRiddleOneJ,
        sBunnyRiddleOneK, sBunnyRiddleOneL, sBunnyRiddleOneM, sBunnyRiddleOneN, sBunnyRiddleOneO,
        sBunnyRiddleOneP, sBunnyRiddleOneQ, sBunnyRiddleOneR, sBunnyRiddleOneS, sBunnyRiddleOneT,
        sBunnyRiddleOneU, sBunnyRiddleOneV, sBunnyRiddleOneW, sBunnyRiddleOneX, sBunnyRiddleOneY;

        public static string
        sBunnyRiddleTwoA, sBunnyRiddleTwoB, sBunnyRiddleTwoC, sBunnyRiddleTwoD, sBunnyRiddleTwoE,
        sBunnyRiddleTwoF, sBunnyRiddleTwoG, sBunnyRiddleTwoH;

        public static string sBunnyLocation;
        public static int iBunnyLocation;

        public static void Initialize_Bunny()
        {
            sBunnyRiddleOne = string.Empty;
            sBunnyRiddleTwo = string.Empty;

            sBunnyRiddleOneA = "'When times get tough and friends just can't be found / There you'll find\n\rme, where I lay me down. Name this song before we drown, and you'll\n\rknow to find me there.'"; // BRIDGE over troubled water
            sBunnyRiddleOneB = "'If you look to find me, it's easily known, for I am where a swap would\n\rdo -- fair trade always as the rule.'"; // Trade at SHOPS
            sBunnyRiddleOneC = "'TEMP: A romantic stroll, this they say, but is it just cliché?\n\rIn the sand you'll find me, kept path-bound by the stars.'"; // NW Beach
            sBunnyRiddleOneD = "'With time fleeting I'm wary to refute the ends of your pursuit. But if\n\ryou seek me, you can't dispute to when I am en route.'"; // Clock Tower/Time
            sBunnyRiddleOneE = "'TEMP: Find me at Main Street.'"; // Main Street
            sBunnyRiddleOneF = "'For one to get from here to there, one choice is good as any. But if that\n\rone is turned to many, I'll transport for a penny.'"; // Bus Terminal
            sBunnyRiddleOneG = "'TEMP: Is it really necessary to go here for the project?\n\rCould be, would be -- though listen to the music.'"; // Downtown/Office Seinfeld Bottle Deposit
            sBunnyRiddleOneH = "'If you're on a journey for camaraderie, you're as like to find me here as\n\ra priest, a minister, and a rabbit.'"; // Bar District
            sBunnyRiddleOneI = "'Because its root is set apart, stillness you will find -- so that when you\n\rmust retire, we'll lie us down in night's attire.'"; // Apartments
            sBunnyRiddleOneJ = "'In the dark of sea our hearts are emptied and deprived, and then the\n\rlight which burns so bright tells us we've arrived.'"; // Lighthouse
            sBunnyRiddleOneK = "'If you are alone, you may long for an assembly. And there among our\n\rbrothers, our lord does care for we.'"; // Church
            sBunnyRiddleOneL = "'TEMP: Find me at Bay Street.'"; // Bay Street
            sBunnyRiddleOneM = "'TEMP: Find me at docks.'"; // Docks
            sBunnyRiddleOneN = "'TEMP: Find me at the police station.'"; // Police Station
            sBunnyRiddleOneO = "'A plant it's called, and from it smoke does billow, but that is not the\n\rfavor for which those crafters labored.'"; // Abandoned Factory
            sBunnyRiddleOneP = "'If there's something to be said, note it with a pen. Handed to a courier,\n\rfrom me-to-you and back again.'"; // Post Office
            sBunnyRiddleOneQ = "'To tip the scale a nudge, some would not begrudge. But if you find me\n\rwith a clue, then know your eyes did not misjudge.'"; // BENCH == COURTHOUSE
            sBunnyRiddleOneR = "'If you're ever wont of smile, give a quick glance to the west. Unless you're\n\rthere, with me, for sure -- then it's from a clue expressed.'"; // Water Tower
            sBunnyRiddleOneS = "'Down the rabbit hole in one, a clue proves us best. Take two or three\n\ror more, then birds are brought to nest.'"; // Golf Course
            sBunnyRiddleOneT = "'From here-to-there, and there-to-here, back-and-forth we go. One foot\n\rin front of the other other, one clue before another.'"; // Hiking Trails
            sBunnyRiddleOneU = "'TEMP: Find me at Ocean street.'"; // Ocean Street
            sBunnyRiddleOneV = "'TEMP: Find me at the boardwalk.'"; // Boardwalk
            sBunnyRiddleOneW = "'Crafted by the wind, these hills are sand not stone. But if it's that this\n\rclue be known, you must find me sitting prone.'"; // Dunes
            sBunnyRiddleOneX = "'TEMP: Find me at the SE Beach.'"; // SE Beach
            sBunnyRiddleOneY = "'A cause's way for manipulation, to stand with arm outstretched, to\n\rwatch the currents swirl around you isn't so farfetched.'"; // The Jetty

            sBunnyRiddleTwoA = "'{0}, with a bright light, likes cutting through the dark. A replica\n\rwon't stop a ship, but with that gift you'll find me.'"; // Lighthouse
            sBunnyRiddleTwoB = "'The words of gods are not the very thing to make {0} wary. Bring a\n\rgift, do not tarry, and with me you'be merry.'"; // Church
            sBunnyRiddleTwoC = "'TEMP: {0} wants you to go to Bay Street. '"; // Bay Street
            sBunnyRiddleTwoD = "'One who walked on water was seen upon a time. Now with sticks we\n\rglide under summer's sun. Find {0} one and your run is done.'"; // Docks
            sBunnyRiddleTwoE = "'The metal it's on may not be copper, but it's {0}'s desire. Deliver a\n\rpin and call it an honor, and I'll serve you up your clue.'"; // Police Station
            sBunnyRiddleTwoF = "'TEMP: {0} wants you to go to the Abandoned Factory.'"; // Abandoned Factory
            sBunnyRiddleTwoG = "'A mark of approval, or made of rubber, an indent in the ground, gift\n\ryou one to {0}, and then I will be found.'"; // Post Office
            sBunnyRiddleTwoH = "'It's not a bench that {0} wants, though it's where you'll find a\n\rcharter, a symbol of integrity, a clue with which I'll barter.'"; // Courthouse

            sBunnyLocation = "null";
            iBunnyLocation = 0;

            // Variables for managing the bunny.
            iBunnyHop = 0;
            iBunnyRun = 0;
            iBunnyDodge = 0;
            iBunnyStage = 0;
            iBunnyGift = 0;
            iClueNPC = 0;
            iGiftLocation = 0;
            iTempRemainingTurns = 0;

            sClueNPC = "";

            bClueNPC = false;
            bTooLateBunny = false;
            bBunnyIntro = false;
            bBunnyFirstHop = false;
            bBunnyPauseToHide = false;
            bHurry = false;
            bSceneAlreadyPlayed = false;
        }

        public static void BunnyText()
        {
            // Fourth (and final?) Bunny Appearance
            // if (remainingTurns < iTurn6 && iBunnyStage == 5) -- commenting this out because the final bunny appearance needs to always happen
            if (Variables.iRemainingTurns == (Variables.iTurn50) - 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("It's not until you're confident that " + NPC_AI.NPC_100 + " isn't giving chase before you");
                Console.WriteLine("stop. With hands on hips, head tilted back, you take a deep breath, then");
                Console.WriteLine("another.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("When you lower your head, you see a bunny sniffing around just a few");
                Console.WriteLine("feet away. It looks up at you, frozen in worry, then returns to sniffing");
                Console.WriteLine("around at the ground.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("'The doorway to escape insists it exists, its way to make way. Now, not");
                Console.WriteLine("then. But true. To you. Save others you can't, not now, no how -- but");
                Console.WriteLine("the door, know how: to the jetty you'll go with five. Ply your cuneus");
                Console.WriteLine("[MacGuffins] to pry the sentry, pry the sentry to make your path.'");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("'If I bring five MacGuffins to the jetty, I can escape?'");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You speak the question aloud, but no one answers. 'I guess the");
                Console.WriteLine("MacGuffins were pretty important after all. If we had all known that");
                Console.WriteLine("from the start....' You let the thought trail away. This isn't the time to");
                Console.WriteLine("think about what's done.");
                if (Variables.iFoundMacGuffins > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("And then you feel your heart stop. Panic rips through you. You pat");
                    Console.WriteLine("yourself down and check every pocket. Gone. All the MacGuffins you had");
                    Console.WriteLine("are now gone. You desperately look at the ground around you, and then");
                    Console.WriteLine("back toward where you came from. Nothing. You drop to your knees,");
                    Console.WriteLine("equal parts frustration and despair weighing you down.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Lost " + Variables.iFoundMacGuffins + " MacGuffins.");
                    Variables.iFinishingMac = Variables.iFoundMacGuffins;
                    Variables.iFoundMacGuffins = 0;
                }
                Program.PressAnyKey();
            }
            // Third Bunny Appearance
            if (iClueNPC == 89 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC089_CurrentNumLocation; }
            if (iClueNPC == 90 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC090_CurrentNumLocation; }
            if (iClueNPC == 91 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC091_CurrentNumLocation; }
            if (iClueNPC == 92 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC092_CurrentNumLocation; }
            if (iClueNPC == 93 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC093_CurrentNumLocation; }
            if (iClueNPC == 94 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC094_CurrentNumLocation; }
            if (iClueNPC == 95 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC095_CurrentNumLocation; }
            if (iClueNPC == 96 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC096_CurrentNumLocation; }
            if (iClueNPC == 97 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC097_CurrentNumLocation; }
            if (iClueNPC == 98 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC098_CurrentNumLocation; }
            if (iClueNPC == 99 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC099_CurrentNumLocation; }
            if (iClueNPC == 100 && iBunnyStage < 5) { iBunnyLocation = NPC_AI.NPC100_CurrentNumLocation; }

            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyGift == 2 && iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("As you approach " + sClueNPC + " with the token you found, you see the bunny");
                Console.WriteLine("peeking out from behind. It thumps its hind leg on the ground, quickly");
                Console.WriteLine("at first, then slower -- but rhythmically, hypnotically. As its eyes begin to ");
                Console.WriteLine("close, you brace for the feeling of floating in darkness.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("When its eyes close completely, you close your own -- then open them");
                Console.WriteLine("and look around. You're floating, but not in water. There's velvet");
                Console.WriteLine("stretched out all around you, but it's ripped and torn; light streams");
                Console.WriteLine("through at every opening.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The spears of light are intense and sharp, jagged at the ends, and every");
                Console.WriteLine("one's directed at you. They pierce you, but cause no pain. You look");
                Console.WriteLine("down at yourself and see all that is within -- through muscles and organs ");
                Console.WriteLine("and bones to your very core.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("It is there you see a small, shadowy figure. It holds an arm up to cover");
                Console.WriteLine("its face from the light. Something wells up inside you, like sadness -- or");
                Console.WriteLine("perhaps injustice. The creature is a tiny thing, and as you");
                Console.WriteLine("watch it you know that it " + NPC_Traits.TraitThreeBunny + " --");
                Console.WriteLine("and the realization brings you joy; it's a life all its own.");
                Console.WriteLine("And that's just what's on the surface, not even all that's within.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The sound of tearing fabric echoes around you, and velvet falls away to");
                Console.WriteLine("allow more light to expose the creature until there is only light and");
                Console.WriteLine("there can be no shadow. And so it disappears from sight. But you feel it");
                Console.WriteLine("within you still, as part of you. And that makes you proud for some");
                Console.WriteLine("reason. Perhaps connection brings understanding, and comfort.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("As you ponder, darkened, angry eyes open where the shadow had been.");
                Console.WriteLine("Their rage absorbs the light and restores shadowy substance with such");
                Console.WriteLine("intensity that the spears grow dim and fade away completely, their");
                Console.WriteLine("edges turning soft at first, and then to liquid. When you're floating in");
                Console.WriteLine("blackness once more, you feel the rage re-directed. It moves around");
                Console.WriteLine("within you and comfort is taken with fear, connection replaced by");
                Console.WriteLine("desperation to escape.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You claw at your chest and open your mouth as pain erupts from within,");
                Console.WriteLine("and the sound of bones stretching and breaking fill your head. Soon");
                Console.WriteLine("consciousness gives away and you fall into even deeper blackness.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("When you open your eyes again, you're lying on the ground and soaked");
                Console.WriteLine("with sweat. Instinctively, you clutch at your chest -- and thankfully find");
                Console.WriteLine("it unscathed. Shaky, but otherwise feeling OK, you stand up and try to");
                Console.WriteLine("write down what you remember of the figure within.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   You wrote in your notes that the shadowy figure " + NPC_Traits.TraitThreeBunny + ".");
                Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5; // The "5" represents a short delay before a new cutscene may fire.
                bSceneAlreadyPlayed = true;
                Program.PressAnyKey();
            } // If you found the bunny in time...
            if (iBunnyStage == 3 && Variables.iRemainingTurns <= Variables.iTurn40 && Variables.iRemainingTurns >= Variables.iTurn50) // Third Bunny Clue!
            {
                iClueNPC = Program.rand.Next(90, 100); 

                // NPC 90-100 it's probably not bad to have a small chance that you interact with the killer without knowing it,
                // plus it ensures no infinite loops if 89-99 are all somehow dead
                // I originally allowed NPC089 to be viable, but once NPC089 was killed after being picked, breaking the mission.
                // Using 90-100 is much safer.

                while (iClueNPC < 90 || iClueNPC > 99 || !bClueNPC)
                {
                    iClueNPC = Program.rand.Next(89, 100); //NPC 89-100

                    if (iClueNPC == 90) { sClueNPC = NPC_AI.NPC_090; if (NPC_AI.bCorpse090) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 91) { sClueNPC = NPC_AI.NPC_091; if (NPC_AI.bCorpse091) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 92) { sClueNPC = NPC_AI.NPC_092; if (NPC_AI.bCorpse092) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 93) { sClueNPC = NPC_AI.NPC_093; if (NPC_AI.bCorpse093) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 94) { sClueNPC = NPC_AI.NPC_094; if (NPC_AI.bCorpse094) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 95) { sClueNPC = NPC_AI.NPC_095; if (NPC_AI.bCorpse095) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 96) { sClueNPC = NPC_AI.NPC_096; if (NPC_AI.bCorpse096) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 97) { sClueNPC = NPC_AI.NPC_097; if (NPC_AI.bCorpse097) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 98) { sClueNPC = NPC_AI.NPC_098; if (NPC_AI.bCorpse098) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 99) { sClueNPC = NPC_AI.NPC_099; if (NPC_AI.bCorpse099) { bClueNPC = false; } bClueNPC = true; }
                    if (iClueNPC == 100) { sClueNPC = NPC_AI.NPC_100; if (NPC_AI.bCorpse100) { bClueNPC = false; } bClueNPC = true; }
                }
                iBunnyHop = Program.rand.Next(10, 26); //Ignoring first 9 locations since they're flood affected, 8 Potential Riddles, but only one per game
                // This gives you 15 turns to find the gift, then find the person and get to the rabbit -- and have some frenzied time left to find the killer
                // while (iBunnyHop == currentLocation || iBunnyHop == 0) doesn't matter if the bunny gives you a clue to where you are since you still have
                // to find the NPC, I guess.
                // { iBunnyHop = rand.Next(10, 26); }
                if (iBunnyHop == 10) { iGiftLocation = 10; sBunnyRiddleTwo = sBunnyRiddleTwoA; }
                if (iBunnyHop == 11) { iGiftLocation = 10; sBunnyRiddleTwo = sBunnyRiddleTwoA; }
                if (iBunnyHop == 12) { iGiftLocation = 10; sBunnyRiddleTwo = sBunnyRiddleTwoA; }
                if (iBunnyHop == 13) { iGiftLocation = 11; sBunnyRiddleTwo = sBunnyRiddleTwoB; }
                if (iBunnyHop == 14) { iGiftLocation = 11; sBunnyRiddleTwo = sBunnyRiddleTwoB; }
                if (iBunnyHop == 15) { iGiftLocation = 13; sBunnyRiddleTwo = sBunnyRiddleTwoD; }
                if (iBunnyHop == 16) { iGiftLocation = 13; sBunnyRiddleTwo = sBunnyRiddleTwoD; }
                if (iBunnyHop == 17) { iGiftLocation = 13; sBunnyRiddleTwo = sBunnyRiddleTwoD; }
                if (iBunnyHop == 18) { iGiftLocation = 14; sBunnyRiddleTwo = sBunnyRiddleTwoE; }
                if (iBunnyHop == 19) { iGiftLocation = 14; sBunnyRiddleTwo = sBunnyRiddleTwoE; }
                if (iBunnyHop == 20) { iGiftLocation = 16; sBunnyRiddleTwo = sBunnyRiddleTwoG; }
                if (iBunnyHop == 21) { iGiftLocation = 16; sBunnyRiddleTwo = sBunnyRiddleTwoG; }
                if (iBunnyHop == 22) { iGiftLocation = 16; sBunnyRiddleTwo = sBunnyRiddleTwoG; }
                if (iBunnyHop == 23) { iGiftLocation = 17; sBunnyRiddleTwo = sBunnyRiddleTwoH; }
                if (iBunnyHop == 24) { iGiftLocation = 17; sBunnyRiddleTwo = sBunnyRiddleTwoH; }
                if (iBunnyHop == 25) { iGiftLocation = 17; sBunnyRiddleTwo = sBunnyRiddleTwoH; }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("In the distance you see a bunny quickly hopping along. It stops and");
                Console.WriteLine("sniffs the air when it spots you, then hops over to you.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("'Another chance to play -- hip-hip and hoo-ray. I've no sleigh, but I've a");
                Console.WriteLine("gift -- and I've hidden it away. A gift for whom? Not me, not you. For");
                Console.WriteLine(sClueNPC + ", true-true. Find what it is and gift it, and find-you-me a third");
                Console.WriteLine("time. You'll see, you'll see, the last -- enough to aid discovery.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("But where is the gift? And where " + sClueNPC + "? I'll help with one, and leave");
                Console.WriteLine("you on your own with the other.");
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(sBunnyRiddleTwo, sClueNPC);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The bunny promises a third-and-final vision if you can bring a gift to");
                Console.WriteLine(sClueNPC + ". Its riddle should help you know where to (E)xplore.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Just in case, you write the riddle in your notebook.");
                Notebook.iNotebookHasInfo++;
                Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5;
                Program.PressAnyKey();
            }
            // Second Bunny Appearance
            if (iBunnyDodge > 2 && iBunnyStage == 2 && Variables.iRemainingTurns >= Variables.iTurn50) { iBunnyDodge = 0; }
            if ((iBunnyDodge == 0 || (iTempRemainingTurns - Variables.iRemainingTurns) > 2) && iBunnyStage == 2
                && Variables.iRemainingTurns <= Variables.iTurn35 && Variables.iRemainingTurns >= Variables.iTurn50) // Second Bunny Clue!
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                if ((bTooLateBunny || (iTempRemainingTurns - Variables.iRemainingTurns) > 2) && Variables.iCurrentLocation == iBunnyLocation)
                {
                    Console.WriteLine("You spot the fountain-borne bunny from earlier, still peering down over");
                    Console.WriteLine("the edge from atop a two-foot high column of water.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("'Found me you did, but too late, too late. Another try, perhaps, another");
                    Console.WriteLine("chance to sate? Another try for the gift of sight, or at least to placate.");
                    Console.WriteLine();
                    iTempRemainingTurns = Variables.iRemainingTurns;
                }
                if (!bTooLateBunny)
                {
                    Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5;
                    Console.WriteLine("Ahead, water bubbles up from the ground, then rises in a thick column a");
                    Console.WriteLine("couple feet tall. As you approach, there is rumbling, the water churns");
                    Console.WriteLine("violently, and it then explodes upward to at least twice your height");
                    Console.WriteLine("before settling back down. Icy droplets from the surge splash down.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Atop the two-foot watery column is a small bunny. It hops around the ");
                    Console.WriteLine("perimeter, peering over the edge to the ground below.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("'Curious you be. To see? Yes-yes? He or she? The one who marks? Hee-");
                    Console.WriteLine("hee. An identity! It would have us know it, and only one hoop to narrow");
                    Console.WriteLine("it; a microcosm to encapsulate, not to frustrate, no-no, but to abate.'");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("'Hide, I will -- somewhere-somewhere. With two minutes time you'll");
                    Console.WriteLine("find me, and gain a glimpse of he -- or she. But if it's more than two");
                    Console.WriteLine("minutes, once again must you partake in this game of insight. To even");
                    Console.WriteLine("out the stakes, a clue I provide. Find me there:'");
                    bTooLateBunny = true;
                    iTempRemainingTurns = Variables.iRemainingTurns;
                    iBunnyLocation = Variables.iCurrentLocation;
                    bBunnyPauseToHide = true;
                }
                if (Variables.iCurrentLocation == iBunnyLocation)
                {
                    iBunnyHop = Program.rand.Next(1, 26);
                    while (iBunnyHop == Variables.iCurrentLocation || iBunnyHop == 3 || iBunnyHop == 5 || iBunnyHop == 7 || iBunnyHop == 12 || iBunnyHop == 13 || iBunnyHop == 14 || iBunnyHop == 21 || iBunnyHop == 22 || iBunnyHop == 24)
                    { iBunnyHop = Program.rand.Next(1, 26); }
                    if (iBunnyHop == 1) { sBunnyRiddleOne = sBunnyRiddleOneA; }
                    if (iBunnyHop == 2) { sBunnyRiddleOne = sBunnyRiddleOneB; }
                    if (iBunnyHop == 4) { sBunnyRiddleOne = sBunnyRiddleOneD; }
                    if (iBunnyHop == 6) { sBunnyRiddleOne = sBunnyRiddleOneF; }
                    if (iBunnyHop == 8) { sBunnyRiddleOne = sBunnyRiddleOneH; }
                    if (iBunnyHop == 9) { sBunnyRiddleOne = sBunnyRiddleOneI; }
                    if (iBunnyHop == 10) { sBunnyRiddleOne = sBunnyRiddleOneJ; }
                    if (iBunnyHop == 11) { sBunnyRiddleOne = sBunnyRiddleOneK; }
                    if (iBunnyHop == 15) { sBunnyRiddleOne = sBunnyRiddleOneO; }
                    if (iBunnyHop == 16) { sBunnyRiddleOne = sBunnyRiddleOneP; }
                    if (iBunnyHop == 17) { sBunnyRiddleOne = sBunnyRiddleOneQ; }
                    if (iBunnyHop == 18) { sBunnyRiddleOne = sBunnyRiddleOneR; }
                    if (iBunnyHop == 19) { sBunnyRiddleOne = sBunnyRiddleOneS; }
                    if (iBunnyHop == 20) { sBunnyRiddleOne = sBunnyRiddleOneT; }
                    if (iBunnyHop == 23) { sBunnyRiddleOne = sBunnyRiddleOneW; }
                    if (iBunnyHop == 25) { sBunnyRiddleOne = sBunnyRiddleOneY; }
                    Console.WriteLine();
                    Console.WriteLine("A book suddenly washes out from within the fountain, narrowly missing");
                    Console.WriteLine("the bunny before landing at your feet, soaked through and with ink");
                    Console.WriteLine("pooling across its open face. A small blurb of text is legible. You read it");
                    Console.WriteLine("as the book dissolves.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(sBunnyRiddleOne);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("It seems the bunny will grant you a second vision if you can use its");
                    Console.WriteLine("riddle to find where it's hiding, and get there in two minutes or less.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Just in case, you write the riddle in your notebook.");
                    Notebook.iNotebookHasInfo++;
                    Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5;
                    iTempRemainingTurns = Variables.iRemainingTurns;
                    Program.PressAnyKey();

                    LocationEncounters.bNothingHappening = false;
                    iBunnyDodge = 0;
                    if (iBunnyHop == 1) { iBunnyLocation = 1; }
                    if (iBunnyHop == 2) { iBunnyLocation = 2; }
                    if (iBunnyHop == 4) { iBunnyLocation = 4; }
                    if (iBunnyHop == 6) { iBunnyLocation = 6; }
                    if (iBunnyHop == 8) { iBunnyLocation = 8; }
                    if (iBunnyHop == 9) { iBunnyLocation = 9; }
                    if (iBunnyHop == 10) { iBunnyLocation = 10; }
                    if (iBunnyHop == 11) { iBunnyLocation = 11; }
                    if (iBunnyHop == 15) { iBunnyLocation = 15; }
                    if (iBunnyHop == 16) { iBunnyLocation = 16; }
                    if (iBunnyHop == 17) { iBunnyLocation = 17; }
                    if (iBunnyHop == 18) { iBunnyLocation = 18; }
                    if (iBunnyHop == 19) { iBunnyLocation = 19; }
                    if (iBunnyHop == 20) { iBunnyLocation = 20; }
                    if (iBunnyHop == 23) { iBunnyLocation = 23; }
                    if (iBunnyHop == 25) { iBunnyLocation = 25; }
                    if (iBunnyHop == 0 || iBunnyHop == 3 || iBunnyHop == 5 || iBunnyHop == 7 || iBunnyHop == 12 || iBunnyHop == 13 || iBunnyHop == 14 ||
                    iBunnyHop == 21 || iBunnyHop == 22 || iBunnyHop == 24 || iBunnyHop == 26)
                    { Console.WriteLine("UH OH! SOMETHING MAY HAVE GONE BUGGY!"); } // But no one has ever seen this, so obviously I'm superhuman and nothing ever goes buggy.
                }
            }
            if (iBunnyDodge <= 2 && iBunnyStage == 2 && Variables.iRemainingTurns <= Variables.iTurn35 && Variables.iRemainingTurns >= Variables.iTurn50) { iBunnyDodge++; }
            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyStage == 2 && !bBunnyPauseToHide && Variables.iRemainingTurns >= Variables.iTurn50) // If you found the bunny in time...
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You glance around to see if you can spot the bunny, and notice it right");
                Console.WriteLine("away. With a smile, you walk over to it. The bunny looks up as you");
                Console.WriteLine("approach. It's chewing on something, but stops when it sees you. Then");
                Console.WriteLine("it stands upright and sniffs at the air.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("At first the sniffs are shallow, but as they become longer its eyes grow");
                Console.WriteLine("heavier. And as they close, the world grows darker until you're floating");
                Console.WriteLine("in darkened waters, familiar black velvet dousing the star-filled sky.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("However, it's not completely dark. There's a faint, filtered light perhaps");
                Console.WriteLine("ten feet away. You swim toward it, but find yourself no closer and so");
                Console.WriteLine("you keep swimming. At first you feel fatigue, and then your muscles");
                Console.WriteLine("ache. Doubt creeps in, then cramps attack your muscles, but you keep");
                Console.WriteLine("swimming. You think to quit a thousand times, and feel mad that you");
                Console.WriteLine("keep swimming, but there is nothing else and so you swim. It is only");
                Console.WriteLine("when you reach a place of contentedness, when you know you will");
                Console.WriteLine("never stop, that you finally take your first stroke, and then your second.");
                Console.WriteLine("On your third stroke, you reach the faint light -- or, more accurately, a");
                Console.WriteLine("wall of velvet from through which shines a light.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You grab it in both hands and pull, tearing the fabric. On the other side");
                Console.WriteLine("you see a backlit silhouette who is looking for you. As you realize the");
                Console.WriteLine("figure " + NPC_Traits.TraitTwoBunny + ", it spots you. Surprised, neither of you");
                Console.WriteLine("move -- and then the light goes out and you are alone.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hours pass. Then days. You float on your back, staring up at the sky and");
                Console.WriteLine("holding on to the silhouette you saw. As time passes, a sparkling light");
                Console.WriteLine("appears far above you, and then another. Before long the sky is filled");
                Console.WriteLine("with dozens of tiny pricks of light. At first it seems that the lights are");
                Console.WriteLine("slowly moving away from you, but then you think the water is draining,");
                Console.WriteLine("before finally understanding that the water is pulling away.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("When you reach ground, the water continues to pull away -- the lights");
                Console.WriteLine("ever brightening until you are dry and the lights shine brightly enough");
                Console.WriteLine("for you to see the enormous tidal waves surrounding you anew. You");
                Console.WriteLine("now know it won't be long before they march again.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   You wrote in your notes that the shadowy figure " + NPC_Traits.TraitTwoBunny + ".");
                Program.PressAnyKey();
                NPC_Traits.bTraitTwoBunny = true; NPC_Traits.bTraitTwo01Bunny = true; NPC_Traits.bTraitOneBunny = false; LocationEncounters.bNothingHappening = false; // nothinghappening keeps random encounters from launching at the same time
                iBunnyLocation = 0;
                iBunnyStage = 3;
                iBunnyDodge = 0;
            }
            bBunnyPauseToHide = false;
            if (Variables.iRemainingTurns <= 94 && iBunnyStage == 0 && Variables.iRemainingTurns >= Variables.iTurn50 && bBunnyFirstHop) // First Bunny Clue!
            {
                iBunnyHop = Program.rand.Next(1, 26);
                while (iBunnyHop == Variables.iCurrentLocation || iBunnyHop == 0)
                { iBunnyHop = Program.rand.Next(1, 26); }
                if (iBunnyHop == 1) { sBunnyLocation = LocationEncounters.location_001; iBunnyLocation = 1; }
                if (iBunnyHop == 2) { sBunnyLocation = LocationEncounters.location_002; iBunnyLocation = 2; }
                if (iBunnyHop == 3) { sBunnyLocation = LocationEncounters.location_003; iBunnyLocation = 3; }
                if (iBunnyHop == 4) { sBunnyLocation = LocationEncounters.location_004; iBunnyLocation = 4; }
                if (iBunnyHop == 5) { sBunnyLocation = LocationEncounters.location_005; iBunnyLocation = 5; }
                if (iBunnyHop == 6) { sBunnyLocation = LocationEncounters.location_006; iBunnyLocation = 6; }
                if (iBunnyHop == 7) { sBunnyLocation = LocationEncounters.location_007; iBunnyLocation = 7; }
                if (iBunnyHop == 8) { sBunnyLocation = LocationEncounters.location_008; iBunnyLocation = 8; }
                if (iBunnyHop == 9) { sBunnyLocation = LocationEncounters.location_009; iBunnyLocation = 9; }
                if (iBunnyHop == 10) { sBunnyLocation = LocationEncounters.location_010; iBunnyLocation = 10; }
                if (iBunnyHop == 11) { sBunnyLocation = LocationEncounters.location_011; iBunnyLocation = 11; }
                if (iBunnyHop == 12) { sBunnyLocation = LocationEncounters.location_012; iBunnyLocation = 12; }
                if (iBunnyHop == 13) { sBunnyLocation = LocationEncounters.location_013; iBunnyLocation = 13; }
                if (iBunnyHop == 14) { sBunnyLocation = LocationEncounters.location_014; iBunnyLocation = 14; }
                if (iBunnyHop == 15) { sBunnyLocation = LocationEncounters.location_015; iBunnyLocation = 15; }
                if (iBunnyHop == 16) { sBunnyLocation = LocationEncounters.location_016; iBunnyLocation = 16; }
                if (iBunnyHop == 17) { sBunnyLocation = LocationEncounters.location_017; iBunnyLocation = 17; }
                if (iBunnyHop == 18) { sBunnyLocation = LocationEncounters.location_018; iBunnyLocation = 18; }
                if (iBunnyHop == 19) { sBunnyLocation = LocationEncounters.location_019; iBunnyLocation = 19; }
                if (iBunnyHop == 20) { sBunnyLocation = LocationEncounters.location_020; iBunnyLocation = 20; }
                if (iBunnyHop == 21) { sBunnyLocation = LocationEncounters.location_021; iBunnyLocation = 21; }
                if (iBunnyHop == 22) { sBunnyLocation = LocationEncounters.location_022; iBunnyLocation = 22; }
                if (iBunnyHop == 23) { sBunnyLocation = LocationEncounters.location_023; iBunnyLocation = 23; }
                if (iBunnyHop == 24) { sBunnyLocation = LocationEncounters.location_024; iBunnyLocation = 24; }
                if (iBunnyHop == 25) { sBunnyLocation = LocationEncounters.location_025; iBunnyLocation = 25; }
                if (!LocationEncounters.bDontAuto23)
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    //Console.WriteLine("A bunny hops off to " + sBunnyLocation + " It seems to want you to follow it.");
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    //Console.WriteLine("   Just in case, you write down where the bunny went.");
                    //Program.PressAnyKey();
                }
            }
            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyStage == 1 && Variables.iRemainingTurns >= Variables.iTurn50)
            {
                iBunnyRun = Program.rand.Next(1, 11);
                if (iBunnyStage == 1 && iBunnyDodge >= 2 && (iBunnyRun >= 8 || iBunnyDodge >= 5))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("The bunny is here on all fours. It sniffs at the ground as you approach.");
                    Console.WriteLine("It seems oblivious to your presence, but soon words fill your mind.");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("'With haste, you chased. Race-race. You kept the pace, and proved it now,");
                    Console.WriteLine("now-is-how, how it's valued -- to you, in you -- so I imbue, in you, this clue.'");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("The rabbit looks up at you, nose twitching, eyes slowly closing. As its eyes close,");
                    Console.WriteLine("the world fades away until there's nothing left at all. You float through the");
                    Console.WriteLine("darkness, adrift at sea, black velvet smothering the heavens, nothing but");
                    Console.WriteLine("the sounds of water lapping at your sides. Then you see something. You look");
                    Console.WriteLine("closely. You see a shadowy figure who " + NPC_Traits.TraitOneBunny + ".");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You try to look closer, but a hand grabs you by the scruff of the neck and pulls");
                    Console.WriteLine("you under the water. You flail and kick, but water fills your lungs until you are");
                    Console.WriteLine("one with the sea. You close your eyes, then open them again to find that");
                    Console.WriteLine("you're standing on land once more.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   You wrote in your notes that the shadowy figure " + NPC_Traits.TraitOneBunny + ".");
                    Program.PressAnyKey();
                }
            }
        }

        public static void BunnyCode()
        {
            // BUNNY CODE STARTS HERE
            // Fourth (and final?) Bunny Appearance
            if (Variables.iRemainingTurns < Variables.iTurn50 && iBunnyStage == 5)
            {
                iBunnyStage = 6;
            }
            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyGift == 2 && iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50)
            {
                NPC_Traits.bTraitThreeBunny = true; NPC_Traits.bTraitThree01Bunny = true; NPC_Traits.bTraitOneBunny = false; NPC_Traits.bTraitTwoBunny = false; LocationEncounters.bNothingHappening = false; // nothinghappening keeps random encounters from launching at the same time
                iBunnyLocation = 0;
                iBunnyStage = 5;
            } // If you found the bunny in time...
            if (iBunnyStage == 3 && Variables.iRemainingTurns <= Variables.iTurn40 && Variables.iRemainingTurns >= Variables.iTurn50) // Third Bunny Clue!
            {
                LocationEncounters.bNothingHappening = false;
                iBunnyStage = 4;
                iBunnyGift = 1;
            }
            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyStage == 4 && iGiftLocation == 2 && Variables.iRemainingTurns >= Variables.iTurn50)
            {
                NPC_Traits.bTraitThreeBunny = true; NPC_Traits.bTraitThree01Bunny = true; NPC_Traits.bTraitTwoBunny = false; NPC_Traits.bTraitOneBunny = false; LocationEncounters.bNothingHappening = false; // nothinghappening "helps" random encounters from launching at the same time, if the player is actively pursuing bunny
                iBunnyLocation = 0;
                iBunnyStage = 5;
                iBunnyGift = 3;
            } // If you found the bunny in time...
            // Second Bunny Appearance
            if (iBunnyDodge > 2 && iBunnyStage == 2 && Variables.iRemainingTurns >= Variables.iTurn50) { iBunnyDodge = 0; }
            if (iBunnyDodge <= 2 && iBunnyStage == 2 && Variables.iRemainingTurns <= Variables.iTurn35 && Variables.iRemainingTurns >= Variables.iTurn50) { iBunnyDodge++; }
            if (Variables.iRemainingTurns <= Variables.iTurn30 && iBunnyStage == 0 && Variables.iRemainingTurns >= Variables.iTurn50 && bBunnyFirstHop) // First Bunny Clue!
            {
                if (!LocationEncounters.bDontAuto23)
                {
                    LocationEncounters.bNothingHappening = false;
                    iBunnyDodge = 0;
                    iBunnyStage = 1;
                    iBunnyHop = Program.rand.Next(1, 26);
                    while (iBunnyHop == Variables.iCurrentLocation || iBunnyHop == 0)
                    { iBunnyHop = Program.rand.Next(1, 26); }
                    if (iBunnyHop == 1) { sBunnyLocation = LocationEncounters.location_001; iBunnyLocation = 1; }
                    if (iBunnyHop == 2) { sBunnyLocation = LocationEncounters.location_002; iBunnyLocation = 2; }
                    if (iBunnyHop == 3) { sBunnyLocation = LocationEncounters.location_003; iBunnyLocation = 3; }
                    if (iBunnyHop == 4) { sBunnyLocation = LocationEncounters.location_004; iBunnyLocation = 4; }
                    if (iBunnyHop == 5) { sBunnyLocation = LocationEncounters.location_005; iBunnyLocation = 5; }
                    if (iBunnyHop == 6) { sBunnyLocation = LocationEncounters.location_006; iBunnyLocation = 6; }
                    if (iBunnyHop == 7) { sBunnyLocation = LocationEncounters.location_007; iBunnyLocation = 7; }
                    if (iBunnyHop == 8) { sBunnyLocation = LocationEncounters.location_008; iBunnyLocation = 8; }
                    if (iBunnyHop == 9) { sBunnyLocation = LocationEncounters.location_009; iBunnyLocation = 9; }
                    if (iBunnyHop == 10) { sBunnyLocation = LocationEncounters.location_010; iBunnyLocation = 10; }
                    if (iBunnyHop == 11) { sBunnyLocation = LocationEncounters.location_011; iBunnyLocation = 11; }
                    if (iBunnyHop == 12) { sBunnyLocation = LocationEncounters.location_012; iBunnyLocation = 12; }
                    if (iBunnyHop == 13) { sBunnyLocation = LocationEncounters.location_013; iBunnyLocation = 13; }
                    if (iBunnyHop == 14) { sBunnyLocation = LocationEncounters.location_014; iBunnyLocation = 14; }
                    if (iBunnyHop == 15) { sBunnyLocation = LocationEncounters.location_015; iBunnyLocation = 15; }
                    if (iBunnyHop == 16) { sBunnyLocation = LocationEncounters.location_016; iBunnyLocation = 16; }
                    if (iBunnyHop == 17) { sBunnyLocation = LocationEncounters.location_017; iBunnyLocation = 17; }
                    if (iBunnyHop == 18) { sBunnyLocation = LocationEncounters.location_018; iBunnyLocation = 18; }
                    if (iBunnyHop == 19) { sBunnyLocation = LocationEncounters.location_019; iBunnyLocation = 19; }
                    if (iBunnyHop == 20) { sBunnyLocation = LocationEncounters.location_020; iBunnyLocation = 20; }
                    if (iBunnyHop == 21) { sBunnyLocation = LocationEncounters.location_021; iBunnyLocation = 21; }
                    if (iBunnyHop == 22) { sBunnyLocation = LocationEncounters.location_022; iBunnyLocation = 22; }
                    if (iBunnyHop == 23) { sBunnyLocation = LocationEncounters.location_023; iBunnyLocation = 23; }
                    if (iBunnyHop == 24) { sBunnyLocation = LocationEncounters.location_024; iBunnyLocation = 24; }
                    if (iBunnyHop == 25) { sBunnyLocation = LocationEncounters.location_025; iBunnyLocation = 25; }
                    if (!LocationEncounters.bDontAuto23)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("A bunny hops off to " + sBunnyLocation + " It seems to want you to follow it.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   Just in case, you write down where the bunny went.");
                        LocationEncounters.bNothingHappening = false;
                        iBunnyDodge = 0;
                        iBunnyStage = 1;
                    }
                }
            }
            if (Variables.iCurrentLocation == iBunnyLocation && iBunnyStage == 1 && Variables.iRemainingTurns >= Variables.iTurn50)
            {
                if (iBunnyStage == 1 && iBunnyDodge >= 2 && (iBunnyRun >= 8 || iBunnyDodge >= 5))
                {
                    NPC_Traits.bTraitOne01Bunny = true; NPC_Traits.bTraitOneBunny = true; /*NPC_Traits.bTraitOneBunny = false;*/ LocationEncounters.bNothingHappening = false; // nothinghappening keeps random encounters from launching at the same time
                    iBunnyLocation = 0;
                    iBunnyDodge = 999; // must be greater than 2 to catch the second bunny scene
                    iBunnyStage = 2;
                }
                if (bBunnyFirstHop && iBunnyStage == 1)
                {
                    iBunnyHop = Program.rand.Next(1, 26);
                    while (iBunnyHop == Variables.iCurrentLocation || iBunnyHop == 0)
                    { iBunnyHop = Program.rand.Next(1, 26); }
                    if (iBunnyHop == 1) { sBunnyLocation = LocationEncounters.location_001; iBunnyLocation = 1; }
                    if (iBunnyHop == 2) { sBunnyLocation = LocationEncounters.location_002; iBunnyLocation = 2; }
                    if (iBunnyHop == 3) { sBunnyLocation = LocationEncounters.location_003; iBunnyLocation = 3; }
                    if (iBunnyHop == 4) { sBunnyLocation = LocationEncounters.location_004; iBunnyLocation = 4; }
                    if (iBunnyHop == 5) { sBunnyLocation = LocationEncounters.location_005; iBunnyLocation = 5; }
                    if (iBunnyHop == 6) { sBunnyLocation = LocationEncounters.location_006; iBunnyLocation = 6; }
                    if (iBunnyHop == 7) { sBunnyLocation = LocationEncounters.location_007; iBunnyLocation = 7; }
                    if (iBunnyHop == 8) { sBunnyLocation = LocationEncounters.location_008; iBunnyLocation = 8; }
                    if (iBunnyHop == 9) { sBunnyLocation = LocationEncounters.location_009; iBunnyLocation = 9; }
                    if (iBunnyHop == 10) { sBunnyLocation = LocationEncounters.location_010; iBunnyLocation = 10; }
                    if (iBunnyHop == 11) { sBunnyLocation = LocationEncounters.location_011; iBunnyLocation = 11; }
                    if (iBunnyHop == 12) { sBunnyLocation = LocationEncounters.location_012; iBunnyLocation = 12; }
                    if (iBunnyHop == 13) { sBunnyLocation = LocationEncounters.location_013; iBunnyLocation = 13; }
                    if (iBunnyHop == 14) { sBunnyLocation = LocationEncounters.location_014; iBunnyLocation = 14; }
                    if (iBunnyHop == 15) { sBunnyLocation = LocationEncounters.location_015; iBunnyLocation = 15; }
                    if (iBunnyHop == 16) { sBunnyLocation = LocationEncounters.location_016; iBunnyLocation = 16; }
                    if (iBunnyHop == 17) { sBunnyLocation = LocationEncounters.location_017; iBunnyLocation = 17; }
                    if (iBunnyHop == 18) { sBunnyLocation = LocationEncounters.location_018; iBunnyLocation = 18; }
                    if (iBunnyHop == 19) { sBunnyLocation = LocationEncounters.location_019; iBunnyLocation = 19; }
                    if (iBunnyHop == 20) { sBunnyLocation = LocationEncounters.location_020; iBunnyLocation = 20; }
                    if (iBunnyHop == 21) { sBunnyLocation = LocationEncounters.location_021; iBunnyLocation = 21; }
                    if (iBunnyHop == 22) { sBunnyLocation = LocationEncounters.location_022; iBunnyLocation = 22; }
                    if (iBunnyHop == 23) { sBunnyLocation = LocationEncounters.location_023; iBunnyLocation = 23; }
                    if (iBunnyHop == 24) { sBunnyLocation = LocationEncounters.location_024; iBunnyLocation = 24; }
                    if (iBunnyHop == 25) { sBunnyLocation = LocationEncounters.location_025; iBunnyLocation = 25; }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("You notice a bunny hopping off toward " + sBunnyLocation);
                    LocationEncounters.bNothingHappening = false;
                    iBunnyDodge++;
                }
            }
            // BUNNY CODE ENDS HERE
        }

        //public static void HereToPickUpAGift()
        //{
        //    // if (!bSceneAlreadyPlayed && Variables.iCurrentLocation == iBunnyLocation && iBunnyGift == 2 && iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50)
        //    if (!bSceneAlreadyPlayed && iBunnyGift == 2 && iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50)
        //    {
        //        Console.Clear();
        //        RandomEncounters.bEncounter = true;
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine("As you approach " + sClueNPC + " with the token you found, you see the bunny");
        //        Console.WriteLine("peeking out from behind. It thumps its hind leg on the ground, quickly");
        //        Console.WriteLine("at first, then slower -- but rhythmically, hypnotically. As its eyes begin to ");
        //        Console.WriteLine("close, you brace for the feeling of floating in darkness.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("When its eyes close completely, you close your own -- then open them");
        //        Console.WriteLine("and look around. You're floating, but not in water. There's velvet");
        //        Console.WriteLine("stretched out all around you, but it's ripped and torn; light streams");
        //        Console.WriteLine("through at every opening.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("The spears of light are intense and sharp, jagged at the ends, and every");
        //        Console.WriteLine("one's directed at you. They pierce you, but cause no pain. You look");
        //        Console.WriteLine("down at yourself and see all that is within -- through muscles and organs ");
        //        Console.WriteLine("and bones to your very core.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("It is there you see a small, shadowy figure. It holds an arm up to cover");
        //        Console.WriteLine("its face from the light. Something wells up inside you, like sadness -- or");
        //        Console.WriteLine("perhaps injustice. The creature is a tiny thing, and as you");
        //        Console.WriteLine("watch it you know that it " + NPC_Traits.TraitThreeBunny + " --");
        //        Console.WriteLine("and the realization brings you joy; it's a life all its own.");
        //        Console.WriteLine("And that's just what's on the surface, not even all that's within.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("The sound of tearing fabric echoes around you, and velvet falls away to");
        //        Console.WriteLine("allow more light to expose the creature until there is only light and");
        //        Console.WriteLine("there can be no shadow. And so it disappears from sight. But you feel it");
        //        Console.WriteLine("within you still, as part of you. And that makes you proud for some");
        //        Console.WriteLine("reason. Perhaps connection brings understanding, and comfort.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("As you ponder, darkened, angry eyes open where the shadow had been.");
        //        Console.WriteLine("Their rage absorbs the light and restores shadowy substance with such");
        //        Console.WriteLine("intensity that the spears grow dim and fade away completely, their");
        //        Console.WriteLine("edges turning soft at first, and then to liquid. When you're floating in");
        //        Console.WriteLine("blackness once more, you feel the rage re-directed. It moves around");
        //        Console.WriteLine("within you and comfort is taken with fear, connection replaced by");
        //        Console.WriteLine("desperation to escape.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("You claw at your chest and open your mouth as pain erupts from within,");
        //        Console.WriteLine("and the sound of bones stretching and breaking fill your head. Soon");
        //        Console.WriteLine("consciousness gives away and you fall into even deeper blackness.");
        //        Console.WriteLine();
        //        Console.WriteLine();
        //        Console.WriteLine("When you open your eyes again, you're lying on the ground and soaked");
        //        Console.WriteLine("with sweat. Instinctively, you clutch at your chest -- and thankfully find");
        //        Console.WriteLine("it unscathed. Shaky, but otherwise feeling OK, you stand up and try to");
        //        Console.WriteLine("write down what you remember of the figure within.");
        //        Console.WriteLine();
        //        Console.ForegroundColor = ConsoleColor.Cyan;
        //        Console.WriteLine("   You wrote in your notes that the shadowy figure " + NPC_Traits.TraitThreeBunny + ".");
        //        Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5; // The "5" represents a short delay before a new cutscene may fire.
        //    }
        //}
    }
}
