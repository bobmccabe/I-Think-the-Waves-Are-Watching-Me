using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Cutscenes
    {
        public static void GameStart_Cutscene()
        {
            if (Variables.iRemainingTurns == Variables.iTurn05)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Cutscene01_Introduction();
                Program.PressAnyKey();
            }
        }

        public static void ShouldSomethingBePlaying()
        {
            if (Variables.iRemainingTurns == Variables.iTurn10)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Cutscene02_TheCleansing();
                Program.PressAnyKey();
            }
            else if (Variables.iRemainingTurns <= Variables.iTurn30 && !TheBunny.bBunnyIntro)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Cutscene03_BunnyIntro();
                Program.PressAnyKey();
            }
            else if (Variables.iRemainingTurns == Variables.iTurn45)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Cutscene04_TheRain();
                Program.PressAnyKey();
            }
            else if (Variables.iRemainingTurns == Variables.iTurn50)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Cutscene05_MetByTheKiller();
                Program.PressAnyKey();
            }

        }

        public static void Cutscene01_Introduction()
        {
            Console.Clear();
            Console.WriteLine("First came the fog. It floated up like curtains around the island --");
            Console.WriteLine("though to call it an island implies something... luxurious, tropical. This");
            Console.WriteLine("was only a barrier island off the north-eastern coast of the United States.");
            Console.WriteLine("But when the fog came, it felt like we'd floated away to who knows");
            Console.WriteLine("where. We'd become magical.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Days later the fog thinned, and on the horizon we saw the tidal waves,");
            Console.WriteLine("salty giants of the sea lurching toward the island, impossibly, from every");
            Console.WriteLine("direction. A few days later, they reached the island and ceased their");
            Console.WriteLine("march, instead standing sentry, churning upward. Somehow, in the span");
            Console.WriteLine("of a few days, they had become a part of normalcy for us -- despite all");
            Console.WriteLine("they represented.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As I stood at the foot of our island's wave-obliterated bridge, looking at");
            Console.WriteLine("what struck me as a reverse waterfall, he spoke. 'She touched the tidal");
            Console.WriteLine("wave, and now she's gone.' He'd said it hesitantly. I turned to look.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Everyone knows that,' I said, perhaps too harshly considering how");
            Console.WriteLine("briefly things had been the way they'd been. 'You touch the wave, the");
            Console.WriteLine("current rips you up to the Heavens.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'No, this was different. She had these... MacGuffins. I don't know what");
            Console.WriteLine("you'd call them.' He pulls one out of his pocket and hands it to me. It's");
            Console.WriteLine("small, like a coin -- weighted, wedge-like... old.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Her pockets were loaded up with them. Said she had dreamt about");
            Console.WriteLine("them -- that she found them just from looking, that they're hidden");
            Console.WriteLine("everywhere. She said she'd had enough of them coins, and enough of...");
            Console.WriteLine("this,' he says, gesturing all around him. There's a long pause. 'And that it");
            Console.WriteLine("won't work unless you've had the same. Touched the wave and it");
            Console.WriteLine("parted. To the other side or lost within?'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Could it be true? Might there be a way to escape?");
        }

        public static void Cutscene02_TheCleansing()
        {
            Console.WriteLine("Boom. The sound is like the cracking of massive stone, and cuts through");
            Console.WriteLine("the ever-present background hum of the tidal waves like a tear in the");
            Console.WriteLine("fabric of a dream.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Now is the time of the cleansing. This place is to be forgotten.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The words lodge in your head, but it takes time to understand -- as if it's");
            Console.WriteLine("a foreign language you barely remember. The words are spoken by");
            Console.WriteLine("many voices, competing and complementary at the same time. They");
            Console.WriteLine("warble and blend as you recover from the message's, and messenger's,");
            Console.WriteLine("arrival.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Another boom thunders. 'Release.' This time the voice is singular. Clear.");
            Console.WriteLine("Loud. It drips with promise. And hope.");
        }

        public static void Cutscene03_BunnyIntro()
        {
            Console.WriteLine("'Death is certain. Later. Or sooner. One, not both. Maybe neither, true-");
            Console.WriteLine("true. Where time, why time?'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You look around to find the voice. Hopping toward you is a bunny, long-");
            Console.WriteLine("haired and stately. Is it the bunny who's talking? The world wobbles");
            Console.WriteLine("slightly, and fades away for a moment. You close your eyes, then open");
            Console.WriteLine("them again. You're sitting on the ground and the bunny is sniffing at");
            Console.WriteLine("something a few feet away.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("It stands up on hinds when you look, cheeks twitching, foot patting. As");
            Console.WriteLine("its foot pats the ground, a puddle springs up, then a moment later a jet");
            Console.WriteLine("of water lifts the bunny several feet high.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The bunny's leg splashes rhythmically against the water as it maintains");
            Console.WriteLine("an easy balance on the surge.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'A cleansing! Washed by waves and rain. Squeaky clean, squeak-squeak.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You look closely at the bunny's face, but it remains impassive. The voice");
            Console.WriteLine("continues, and now you're certain it's coming from within your head.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'But messy. And the dead. Already, oh yes. Many more, too. True-true.");
            Console.WriteLine("The island sinks. Cannot change. No-no. Can't change, wouldn't. But-");
            Console.WriteLine("but-but 'X' marks an island, the rest are free to go-go, to follow those");
            Console.WriteLine("who know to listen. Will they? Not sure, no-no. Maybe yes, maybe.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Am I you-not-me or I-not-you? You wonder that, true. But I say hop-a-");
            Console.WriteLine("do-who to both and neither.' The bunny's nose twitches for a moment.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Right-right, or left. Need some help? Yes-yes, that's where we are, but");
            Console.WriteLine("where must you be? Can't figure it all out, no chance for you. Oh no, no-");
            Console.WriteLine("no. But trust you must, for you to know, to follow-follow-follow, don't");
            Console.WriteLine("be slow. Hop-hop, now and ever.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The bunny's nose twitches once more as it settles onto fours, its watery");
            Console.WriteLine("pedestal melted into the ground. 'Follow-answers/answers-follow.'");
            TheBunny.bBunnyIntro = true;
            TheBunny.bBunnyFirstHop = true;
            Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 5;
        }

        public static void Cutscene04_TheRain()
        {
            Console.WriteLine("A red flash lights up the dark for the briefest of moments, then fades");
            Console.WriteLine("away -- leaving only a red accent on the night sky's black clouds. It's");
            Console.WriteLine("followed by a deep tone, like that from the strike of a lone piano key.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As the note hits your ears, you drop to your knees like a puppet whose");
            Console.WriteLine("strings have been severed. Your bones vibrate, dislodge and reconnect,");
            Console.WriteLine("the muscled fibers beneath your skin shred, then blend back together.");
            Console.WriteLine("Your stomach heaves, and blood sprays from your mouth, coloring the");
            Console.WriteLine("ground in beautiful patterns. The feeling moves through with such");
            Console.WriteLine("intensity that there's no room left for anything but bliss.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As thought and bodily control returns, the rain begins -- fist-sized, ");
            Console.WriteLine("delicate globes of water, like the playful bubbles that children blow, fall");
            Console.WriteLine("and gently burst each time they touch a surface. And as the rain drops");
            Console.WriteLine("down, euphoria rises. It wells up in your being as a smile you can't hide.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'All is as it is.' The words play in your mind and reassure you, and you");
            Console.WriteLine("find yourself nodding in agreement. You say that 'everything is OK.' And ");
            Console.WriteLine("then you laugh for having said it.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You stand up to stomp-and-splash the water at your feet, feeling");
            Console.WriteLine("connected to everyone, living and dead -- as if there is no difference");
            Console.WriteLine("between the two. And then you laugh some more.");
        }

        public static void Cutscene05_MetByTheKiller()
        {
            NPC_AI.NPC100_PantsDownGenderCheck();

            NPC_AI.NPC100_CurrentNumLocation = Variables.iCurrentLocation;
            NPC_AI.NPC100_CurrentStrLocation = Variables.sGetLocation;
            NPC_AI.NPC100_LastStrLocation = NPC_AI.NPC100_CurrentStrLocation;
            NPC_AI.DesireToMove100 = 0;
            TheBunny.iBunnyLocation = 0;

            Console.WriteLine("'There you are.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You turn around to see " + NPC_AI.NPC_100 + ", a slight smile on " + NPC_AI.sGenderHisHer + " face.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'Wondered when it would be our turn, whether it'd be later. Or sooner. ");
            Console.WriteLine("And there's always not-at-all, though those times make me sad.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As " + NPC_AI.sGenderHeShe + " speaks, the falling rain grows warmer, as does the deep, soft");
            Console.WriteLine("puddles hugging your ankles. You imagine how nice it would be to");
            Console.WriteLine("spread out your arms and fall backward, to fall asleep and float away.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(NPC_AI.NPC_100 + " looks down, then raises " + NPC_AI.sGenderHisHer + " gaze to meet yours. 'A little bunny");
            Console.WriteLine("tells me you've been busy, but not at what. Busy at nothing or");
            Console.WriteLine("something? The right or the wrong things -- whatever those might be?'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(NPC_AI.NPC_100 + " offers up a playful wink, and the world fades away into a furry");
            Console.WriteLine("embrace. You catch yourself holding your breath and tell yourself that");
            Console.WriteLine("it's OK to rest your eyes, but just until it's time to breathe again.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The ground rotates to rest against your back, and you curl up into a ball");
            Console.WriteLine("so small that nothing can get to you. Warmth and safety hold you tight,");
            Console.WriteLine("and everything falls impossibly still. Even the rain stops in place.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("'... we know better than to believe that fluffy animals are talking.'");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The words slip through the tranquility with care, but still knock the");
            Console.WriteLine("occasional thought astray. " + NPC_AI.NPC_100 + "? Is " + NPC_AI.sGenderHeShe + " talking about the bunny? You");
            Console.WriteLine("want to look, to see. Was it all in my head? Why does it matter to " + NPC_AI.sGenderHimHer + "?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The world falls back and stands you up. Your eyes open and you breathe");
            Console.WriteLine("in cool, fresh air. Sensations dance across your face as you take a step,");
            Console.WriteLine("then another. You breathe again, and smell the rain, the ocean. You feel");
            Console.WriteLine("the hunger in your belly. You break into a run, bubbles of rain popping");
            Console.WriteLine("all around you, a hint of deepest blue clawing up on the horizon.");
            
            NPC_AI.bHunting = true;

            // the following is to allow the player to reclaim some of his lost MacGuffins in order to escape.
            // this ensures that areas 9-25 can be searched even if they were already searched.
            Search.bSearchedLocation_A09 = false;
            Search.bSearchedLocation_A10 = false;
            Search.bSearchedLocation_A11 = false;
            Search.bSearchedLocation_A12 = false;
            Search.bSearchedLocation_A13 = false;
            Search.bSearchedLocation_A14 = false;
            Search.bSearchedLocation_A15 = false;
            Search.bSearchedLocation_A16 = false;
            Search.bSearchedLocation_A17 = false;
            Search.bSearchedLocation_A18 = false;
            Search.bSearchedLocation_A19 = false;
            Search.bSearchedLocation_A20 = false;
            Search.bSearchedLocation_A21 = false;
            Search.bSearchedLocation_A22 = false;
            Search.bSearchedLocation_A23 = false;
            Search.bSearchedLocation_A24 = false;
            Search.bSearchedLocation_A25 = false;

            // If the player previously used the lighthouse, they can still search again.
            Search.bSearchedLocation_B09 = false;
            Search.bSearchedLocation_B10 = false;
            Search.bSearchedLocation_B11 = false;
            Search.bSearchedLocation_B12 = false;
            Search.bSearchedLocation_B13 = false;
            Search.bSearchedLocation_B14 = false;
            Search.bSearchedLocation_B15 = false;
            Search.bSearchedLocation_B16 = false;
            Search.bSearchedLocation_B17 = false;
            Search.bSearchedLocation_B18 = false;
            Search.bSearchedLocation_B19 = false;
            Search.bSearchedLocation_B20 = false;
            Search.bSearchedLocation_B21 = false;
            Search.bSearchedLocation_B22 = false;
            Search.bSearchedLocation_B23 = false;
            Search.bSearchedLocation_B24 = false;
            Search.bSearchedLocation_B25 = false;

            int iRunFromKiller = Program.rand.Next(9, 26);
            while (iRunFromKiller == Variables.iCurrentLocation)
            {
                iRunFromKiller = Program.rand.Next(9, 26); // areas 1-8 are now flooded.
            }
            if (iRunFromKiller == 9) 
            {
                Variables.sGetLocation = LocationEncounters.location_009; NPC_AI.NPC100_CurrentNumLocation = 9;
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_009;
            }
            if (iRunFromKiller == 10) 
            {
                Variables.sGetLocation = LocationEncounters.location_010; NPC_AI.NPC100_CurrentNumLocation = 10;
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010;
            }
            if (iRunFromKiller == 11) 
            {
                Variables.sGetLocation = LocationEncounters.location_011; NPC_AI.NPC100_CurrentNumLocation = 11;
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_011;
            }
            if (iRunFromKiller == 12) 
            {
                Variables.sGetLocation = LocationEncounters.location_012; NPC_AI.NPC100_CurrentNumLocation = 12;
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_012; 
            }
            if (iRunFromKiller == 13)
            {
                Variables.sGetLocation = LocationEncounters.location_013; NPC_AI.NPC100_CurrentNumLocation = 13;
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_013;
            }
            if (iRunFromKiller == 14)
            { 
                Variables.sGetLocation = LocationEncounters.location_014; NPC_AI.NPC100_CurrentNumLocation = 14; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_014;
            }
            if (iRunFromKiller == 15)
            { 
                Variables.sGetLocation = LocationEncounters.location_015; NPC_AI.NPC100_CurrentNumLocation = 15; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_015;
            }
            if (iRunFromKiller == 16)
            { 
                Variables.sGetLocation = LocationEncounters.location_016; NPC_AI.NPC100_CurrentNumLocation = 16; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_016;
            }
            if (iRunFromKiller == 17)
            { 
                Variables.sGetLocation = LocationEncounters.location_017; NPC_AI.NPC100_CurrentNumLocation = 17; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_017;
            }
            if (iRunFromKiller == 18)
            { 
                Variables.sGetLocation = LocationEncounters.location_018; NPC_AI.NPC100_CurrentNumLocation = 18; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_018;
            }
            if (iRunFromKiller == 19)
            { 
                Variables.sGetLocation = LocationEncounters.location_019; NPC_AI.NPC100_CurrentNumLocation = 19; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_019;
            }
            if (iRunFromKiller == 20)
            { 
                Variables.sGetLocation = LocationEncounters.location_020; NPC_AI.NPC100_CurrentNumLocation = 20; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_020;
            }
            if (iRunFromKiller == 21)
            { 
                Variables.sGetLocation = LocationEncounters.location_021; NPC_AI.NPC100_CurrentNumLocation = 21; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_021;
            }
            if (iRunFromKiller == 22)
            { 
                Variables.sGetLocation = LocationEncounters.location_022; NPC_AI.NPC100_CurrentNumLocation = 22; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_022;
            }
            if (iRunFromKiller == 23)
            { 
                Variables.sGetLocation = LocationEncounters.location_023; NPC_AI.NPC100_CurrentNumLocation = 23; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_023; 
            }
            if (iRunFromKiller == 24)
            { 
                Variables.sGetLocation = LocationEncounters.location_024; NPC_AI.NPC100_CurrentNumLocation = 24; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_024; 
            }
            if (iRunFromKiller == 25)
            { 
                Variables.sGetLocation = LocationEncounters.location_025; NPC_AI.NPC100_CurrentNumLocation = 25; 
                Variables.iCurrentLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_025; 
            }
        }

        public static void GameOver_OutOfTurns()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("There is nowhere left.");
            Console.WriteLine();
            Console.WriteLine("You're completely surrounded, standing in a bubble of air surrounded");
            Console.WriteLine("by all of the water in the world. This is something that no other person");
            Console.WriteLine("will ever see -- although, as you think that, you wonder if it's true.");
            Console.WriteLine();
            Console.WriteLine("And then the bubble bursts.");
            Console.WriteLine();
            Console.WriteLine("In the seconds or eternity that follows, it's quiet. And calm. There's a");
            Console.WriteLine("stillness, a true stillness -- somehow different. Pure. A sense of ending.");
            Console.WriteLine("A story written. The book closed.");
            Console.WriteLine();
            Console.WriteLine("They say your life flashes before your eyes at the end, but what you see");
            Console.WriteLine("isn't a flash at all, nor is it of your past, nor is it a chaotic jumble of");
            Console.WriteLine("images. It's a single image, and it depicts all of the things that may come");
            Console.WriteLine("next, and all of the things that may never come at all. And though");
            Console.WriteLine("there's no certainty as to which is which, somehow you know.");
            Console.WriteLine();
            Console.WriteLine("And then it all fades away.");
            Variables.playerSurvived = Variables.sPlayerState2;
            Program.PressAnyKey();
        }
    }
}