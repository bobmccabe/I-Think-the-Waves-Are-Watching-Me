using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class LocationEncounters
    {
        // Random Encounter Min/Max MacGuffin Rewards
        public static int
        iTinyRewardMin, iSmallRewardMin, iMediumRewardMin, iLargeRewardMin, iHugeRewardMin,
        iTinyRewardCap, iSmallRewardCap, iMediumRewardCap, iLargeRewardCap, iHugeRewardCap;

        public static int iComboA; // player's guess
        public static int iComboB; // player's guess
        public static int iComboC; // player's guess
        public static int iCombo1; // actual solution
        public static int iCombo2; // actual solution
        public static int iCombo3; // actual solution

        // Location Stuff
        public static bool bClockUsed;
        public static bool bNumber1Found;
        public static bool bNumber2Found;
        public static bool bNumber3Found;
        public static int iNumberFoundFirst;
        public static bool bBusDriverUsed;
        public static bool bDrunk;
        public static bool bDrunkWaffler;
        public static bool BarQ8to9Jump;
        public static bool bDontAuto23;
        public static bool bLightHouseUsed;
        public static bool bLightHouseFuse;
        public static bool bLightHouseKey;
        public static bool bCourtHouseKey;
        public static bool bGolfCourseKey;
        public static bool bPrayed;
        public static int iTithe;
        public static string sPrayFor;
        public static bool bOpenedSafe;

        public static bool bLocation10EncounterBlocker;
        public static bool bLocation11EncounterBlocker;
        public static bool bLocation13EncounterBlocker;
        public static bool bLocation14EncounterBlocker;
        public static bool bLocation16EncounterBlocker;
        public static bool bLocation17EncounterBlocker;

        public static string
        location_001, location_002, location_003, location_004, location_005,
        location_006, location_007, location_008, location_009, location_010,
        location_011, location_012, location_013, location_014, location_015,
        location_016, location_017, location_018, location_019, location_020,
        location_021, location_022, location_023, location_024, location_025;

        public static string
        sLocation001, sLocation002, sLocation003, sLocation004, sLocation005,
        sLocation006, sLocation007, sLocation008, sLocation009, sLocation010,
        sLocation011, sLocation012, sLocation013, sLocation014, sLocation015,
        sLocation016, sLocation017, sLocation018, sLocation019, sLocation020,
        sLocation021, sLocation022, sLocation023, sLocation024, sLocation025;

        public static bool
        bNothingHappening, bUsableLocation025;


        public static void Initialize_Locations()
        {
            // Random Encounter Min MacGuffin Rewards
            iTinyRewardMin = 1;
            iSmallRewardMin = 2;
            iMediumRewardMin = 3;
            iLargeRewardMin = 4;
            iHugeRewardMin = 5;

            // Random Encounter Max MacGuffin Rewards
            iTinyRewardCap = 3;
            iSmallRewardCap = 5;
            iMediumRewardCap = 7;
            iLargeRewardCap = 9;
            iHugeRewardCap = 11;

            // combo to safe
            iComboA = iComboB = iComboC = 0;
            iCombo1 = Program.rand.Next(0, 99);
            iCombo2 = Program.rand.Next(0, 99);
            iCombo3 = Program.rand.Next(0, 99);

            bNothingHappening = true;
            bUsableLocation025 = false;

            // Location Stuff
            bClockUsed = bNumber1Found = bNumber2Found = bNumber3Found = bBusDriverUsed =
            bDrunk = bDrunkWaffler = BarQ8to9Jump = bDontAuto23 = bLightHouseUsed =
            bLightHouseFuse = bLightHouseKey = bCourtHouseKey = bGolfCourseKey = bPrayed =
            bOpenedSafe = false;
        
            iTithe = 0;
            iNumberFoundFirst = 0;
        
            sPrayFor = "null";
        
            bLocation10EncounterBlocker = bLocation11EncounterBlocker = bLocation13EncounterBlocker = 
            bLocation14EncounterBlocker = bLocation16EncounterBlocker = bLocation17EncounterBlocker =
            false;

            location_001 = "the bridge.";
            location_002 = "the strip mall and local boutiques.";
            location_003 = "the northwest beach.";
            location_004 = "the clock tower.";
            location_005 = "Main Street.";
            location_006 = "the bus terminal.";
            location_007 = "downtown and the office district.";
            location_008 = "the bar district.";
            location_009 = "the apartments.";
            location_010 = "the lighthouse.";
            location_011 = "church.";
            location_012 = "Bay Street.";
            location_013 = "the docks.";
            location_014 = "the police station.";
            location_015 = "the abandoned factory.";
            location_016 = "the post office.";
            location_017 = "the courthouse.";
            location_018 = "the water tower.";
            location_019 = "the golf course.";
            location_020 = "the hiking trails.";
            location_021 = "Ocean Street.";
            location_022 = "the boardwalk.";
            location_023 = "the dunes.";
            location_024 = "the southeast beach.";
            location_025 = "the jetty.";

            sLocation001 = "bridge";
            sLocation002 = "local shops";
            sLocation003 = "northwest beach";
            sLocation004 = "clock tower";
            sLocation005 = "Main Street";
            sLocation006 = "bus terminal";
            sLocation007 = "downtown";
            sLocation008 = "bars";
            sLocation009 = "apartments";
            sLocation010 = "lighthouse";
            sLocation011 = "church";
            sLocation012 = "Bay Street";
            sLocation013 = "docks";
            sLocation014 = "police station";
            sLocation015 = "abandoned factory";
            sLocation016 = "post office";
            sLocation017 = "courthouse";
            sLocation018 = "water tower";
            sLocation019 = "golf course";
            sLocation020 = "hiking trails";
            sLocation021 = "Ocean Street";
            sLocation022 = "boardwalk";
            sLocation023 = "dunes";
            sLocation024 = "southeast beach";
            sLocation025 = "jetty";
        }

        public static void WhatIsTheStoryLocationMan()
        {
            if (Variables.sGetLocation == location_001) { Variables.sStoryLocation = sLocation001; }
            if (Variables.sGetLocation == location_002) { Variables.sStoryLocation = sLocation002; }
            if (Variables.sGetLocation == location_003) { Variables.sStoryLocation = sLocation003; }
            if (Variables.sGetLocation == location_004) { Variables.sStoryLocation = sLocation004; }
            if (Variables.sGetLocation == location_005) { Variables.sStoryLocation = sLocation005; }
            if (Variables.sGetLocation == location_006) { Variables.sStoryLocation = sLocation006; }
            if (Variables.sGetLocation == location_007) { Variables.sStoryLocation = sLocation007; }
            if (Variables.sGetLocation == location_008) { Variables.sStoryLocation = sLocation008; }
            if (Variables.sGetLocation == location_009) { Variables.sStoryLocation = sLocation009; }
            if (Variables.sGetLocation == location_010) { Variables.sStoryLocation = sLocation010; }
            if (Variables.sGetLocation == location_011) { Variables.sStoryLocation = sLocation011; }
            if (Variables.sGetLocation == location_012) { Variables.sStoryLocation = sLocation012; }
            if (Variables.sGetLocation == location_013) { Variables.sStoryLocation = sLocation013; }
            if (Variables.sGetLocation == location_014) { Variables.sStoryLocation = sLocation014; }
            if (Variables.sGetLocation == location_015) { Variables.sStoryLocation = sLocation015; }
            if (Variables.sGetLocation == location_016) { Variables.sStoryLocation = sLocation016; }
            if (Variables.sGetLocation == location_017) { Variables.sStoryLocation = sLocation017; }
            if (Variables.sGetLocation == location_018) { Variables.sStoryLocation = sLocation018; }
            if (Variables.sGetLocation == location_019) { Variables.sStoryLocation = sLocation019; }
            if (Variables.sGetLocation == location_020) { Variables.sStoryLocation = sLocation020; }
            if (Variables.sGetLocation == location_021) { Variables.sStoryLocation = sLocation021; }
            if (Variables.sGetLocation == location_022) { Variables.sStoryLocation = sLocation022; }
            if (Variables.sGetLocation == location_023) { Variables.sStoryLocation = sLocation023; }
            if (Variables.sGetLocation == location_024) { Variables.sStoryLocation = sLocation024; }
            if (Variables.sGetLocation == location_025) { Variables.sStoryLocation = sLocation025; }
        }

        public static void StoryAtTheBridge() // 1
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The bridge leading on-and-off the island is older, but by no means");
            Console.WriteLine("decrepit or a relic. It was built in the 1970s, is heavy duty and made");
            Console.WriteLine("from concrete. It's flat, has metal side-railing, and stands perhaps forty");
            Console.WriteLine("feet above sea level -- crossing the quarter-mile gap that separates the");
            Console.WriteLine("island from the mainland. It features two lanes in each direction. The");
            Console.WriteLine("bridge has taken damage from stormy weather in the past, but, to this");
            Console.WriteLine("day, it stands resolute.");
        }
        
        public static void StoryAtTheShops() // 2
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("These shops all sprung up at the island's economic high point in the");
            Console.WriteLine("mid- to late-1960s. When the island's factory finally shut down in 1977,");
            Console.WriteLine("perhaps surprisingly the majority of the shops continued to thrive --");
            Console.WriteLine("thanks to those who saw the shops as high-end and were willing to");
            Console.WriteLine("travel up to an hour or two for their goods. In recent times, due to");
            Console.WriteLine("economic depression and the rise of Internet shopping, the shops no");
            Console.WriteLine("longer evoke the same grandeur and most of them have closed.");
            // If player has option to do something
            Console.WriteLine();
            Console.WriteLine("As you walk down an alley way between several shops, the sound of a");
            Console.WriteLine("door closing catches your attention. After a few seconds, there is a gust");
            Console.WriteLine("of wind and you hear another bang. The sound leads you to a shop whose rear");
            Console.WriteLine("door hangs open. When the wind blows, it sometimes swings shut.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you want to go inside the store? (y)es or (n)o?");
            Console.WriteLine("(Resolving this encounter requires no additional time.)");
            Console.WriteLine();
            string OpenStore = Console.ReadLine();
            Console.WriteLine();
            OpenStore.ToLower();
            while (OpenStore != "y" && OpenStore != "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                OpenStore = Console.ReadLine();
                Console.WriteLine();
                OpenStore.ToLower();
            }
            if (OpenStore == "n")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You decide not to go into the store.");
            }
            if (OpenStore == "y")
            {
                if (bOpenedSafe)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You hold the door open and peek inside, giving your eyes a moment to");
                    Console.WriteLine("adjust to the dark interior. It appears to be the kitchen for a fast food");
                    Console.WriteLine("restaurant. No one is inside, and all of the food supplies have been put");
                    Console.WriteLine("away. You notice a large framed picture has fallen to the floor. Above it,");
                    Console.WriteLine("a safe rests in the wall, hanging open. It's empty.");
                }
                else if (!bOpenedSafe)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You hold the door open and peek inside, giving your eyes a moment to");
                    Console.WriteLine("adjust to the dark interior. It appears to be the kitchen for a fast food");
                    Console.WriteLine("restaurant. No one is inside, and all of the food supplies have been put");
                    Console.WriteLine("away. You notice a large framed picture has fallen to the floor. Above it,");
                    Console.WriteLine("a safe rests in the wall, sealed shut. It looks like a typical safe lock.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want to try to open it? (y)es or (n)o?");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    string OpenSafe = Console.ReadLine();
                    Console.WriteLine();
                    OpenSafe.ToLower();
                    while (OpenSafe != "y" && OpenSafe != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        OpenSafe = Console.ReadLine();
                        Console.WriteLine();
                        OpenSafe.ToLower();
                    }
                    if (OpenSafe == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You decide not to try to open the safe.");
                    }
                    if (OpenSafe == "y")
                    {
                        bool bValidComboA = false;
                        bool bValidComboB = false;
                        bool bValidComboC = false;
                        bool bValidComboFull = false;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("TIP: You need to enter THREE digits in the proper order to open the safe.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("What is the FIRST number you will enter? Choose from '0' through '99'.");
                        while (!bValidComboA)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            bValidComboA = int.TryParse(Console.ReadLine(), out iComboA) && (iComboA <= 99) && (iComboA >= 0);
                            if (!bValidComboA) { Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You need to choose a number between 0 and 99."); }
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("What is the SECOND number you will enter? Choose from '0' through '99'.");
                        while (!bValidComboB)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            bValidComboB = int.TryParse(Console.ReadLine(), out iComboB) && (iComboB <= 99) && (iComboB >= 0);
                            if (!bValidComboB) { Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You need to choose a number between 0 and 99."); }
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("What is the THIRD number you will enter? Choose from '0' through '99'.");
                        while (!bValidComboC)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            bValidComboC = int.TryParse(Console.ReadLine(), out iComboC) && (iComboC <= 99) && (iComboC >= 0);
                            if (!bValidComboC) { Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You need to choose a number between 0 and 99."); }
                        }
                        if (iComboA == iCombo1 && iComboB == iCombo2 && iComboC == iCombo3) { bValidComboFull = true; }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (bValidComboFull)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You pull the handle and the safe opens. Inside you see a handful of");
                            Console.WriteLine("MacGuffins -- twenty-eight in number. You take them and stash them away in");
                            Console.WriteLine("your pocket while wondering who put them in there -- and when.");
                            if (!Title.bAchievement10)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Title.bAchievement10 = true;
                                Console.WriteLine("   Secret Discovered: " + Title.sAchievement10);
                            }
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 28;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained 28 MacGuffins.");
                            bOpenedSafe = true;
                        }
                        if (!bValidComboFull) { Console.WriteLine(); Console.WriteLine("You pull the handle, but the safe is locked."); }
                    }
                }
            }
        }
        
        public static void StoryAtTheNWBeach() // 3
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The northwest beach is disparagingly referred to by locals as the pretty");
            Console.WriteLine("beach -- a derisive nickname directed more at the upper-class tourists");
            Console.WriteLine("who frequent it. While the beach itself is like any other, albeit with");
            Console.WriteLine("plenty of small shops and tourism stands, it's over-crowded in the");
            Console.WriteLine("summers and ignored by locals year 'round.");
        }
        
        public static void StoryAtTheClockTower() // 4
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("In an effort to add a bit of sophistication while capitalizing on the");
            Console.WriteLine("island's mid-1960s financial optimism, this 30-foot tall clock tower was");
            Console.WriteLine("built by the bus terminal, along Main Street at the eastern end of the");
            Console.WriteLine("shopping district. Despite serving no real purpose, the locals have");
            Console.WriteLine("always taken great pride in ensuring the clock is maintained and its time");
            Console.WriteLine("accurate. Local business still wait for the tower's bell to ring before");
            Console.WriteLine("declaring the start to a new business day.");
            // If player has option to do something
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It appears that the door to the clock tower is unlocked. You could enter,");
            Console.WriteLine("if you wanted. (y)es or (n)o?");
            Console.WriteLine("(Resolving this encounter requires no additional time.)");
            Console.WriteLine();
            string OpenClockTower = Console.ReadLine();
            Console.WriteLine();
            OpenClockTower.ToLower();
            while (OpenClockTower != "y" && OpenClockTower != "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                OpenClockTower = Console.ReadLine();
                Console.WriteLine();
                OpenClockTower.ToLower();
            }
            if (OpenClockTower == "n")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You walk away from the clock tower's door.");
            }
            if (OpenClockTower == "y")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                if (Variables.iRemainingTurns >= 27 && Variables.iRemainingTurns <= 42 && !bClockUsed)
                {
                    Console.WriteLine("The inside of the clock tower is square and tall. It's too dark to see to");
                    Console.WriteLine("the height of the clock tower's interior. However, in the middle of the");
                    Console.WriteLine("room is a wooden object about the size of a tall cabinet. The cabinet's");
                    Console.WriteLine("doors are wide open. In the heart of the cabinet is a wall clock, ticking");
                    Console.WriteLine("loudly. The minute hand is glowing, and you feel an urge to touch it.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want to touch the clock's minute hand? (y)es or (n)o?");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    string UseClock = Console.ReadLine();
                    Console.WriteLine();
                    UseClock.ToLower();
                    while (UseClock != "y" && UseClock != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        UseClock = Console.ReadLine();
                        UseClock.ToLower();
                        Console.WriteLine();
                    }
                    if (UseClock == "y")
                    {
                        bClockUsed = true;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("The minute hand looks delicate enough to break from an exhale, and so");
                        Console.WriteLine("you find yourself holding your breath as you near it. As you raise your");
                        Console.WriteLine("finger, the minute hand shifts to the left to avoid your touch -- until the");
                        Console.WriteLine("time is 20 minutes earlier than it should be.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Do you want to set it to the right time? (y)es or (n)o?");
                        Console.WriteLine();
                        string ChangeTime = Console.ReadLine();
                        Console.WriteLine();
                        ChangeTime.ToLower();
                        while (ChangeTime != "y" && ChangeTime != "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            ChangeTime = Console.ReadLine();
                            ChangeTime.ToLower();
                            Console.WriteLine();
                        }
                        if (ChangeTime == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You decide to leave it how it is. A moment later, the cabinet");
                            Console.WriteLine("door shuts itself.");
                            Variables.iRemainingTurns = Variables.iRemainingTurns + 20;
                            Flood.HereComesTheFlood(); // This makes sure to set the map to the right configuration.
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   It is 20 minutes earlier.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (!Title.bAchievement09)
                            {
                                Title.bAchievement09 = true;
                                Console.WriteLine("   Secret Discovered: " + Title.sAchievement09);
                            }
                        }
                        else if (ChangeTime == "y")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("You push the minute hand lightly to the right. When it reaches the");
                            Console.WriteLine("current time, it locks into place -- as if the clock itself knew the correct");
                            Console.WriteLine("time. The cabinet then shuts itself.");
                        }
                    }
                    else if (UseClock == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You decide to leave the cabinet alone.");
                    }
                }
                else if (Variables.iRemainingTurns <= 27 || Variables.iRemainingTurns >= 42 || bClockUsed)
                {
                    Console.WriteLine("The inside of the clock tower is square and tall. It's too dark to see to");
                    Console.WriteLine("the height of the clock tower's interior. However, in the middle of the");
                    Console.WriteLine("room is a wooden object about the size of a tall cabinet. The cabinet has");
                    Console.WriteLine("doors, but at the moment there does not appear to be a way to open");
                    Console.WriteLine("them. Inside, you hear soft, slow ticking. Surely there's a way to open");
                    Console.WriteLine("the cabinet. Perhaps a solution will present itself in time, you think.");
                }
                else if (bClockUsed)
                {
                    Console.WriteLine("The inside of the clock tower is square and tall. It's too dark to see to");
                    Console.WriteLine("the height of the clock tower's interior. However, in the middle of the");
                    Console.WriteLine("room is the strange cabinet that was previously open. The doors are ");
                    Console.WriteLine("now sealed shut. The sound of ticking remains, soft and slow.");
                }
            }
        }
        
        public static void StoryAtMainStreet() // 5
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Main Street runs from the bridge straight east to the lighthouse, where");
            Console.WriteLine("it splits into the narrower Ocean and Bay Streets. While Main Street is");
            Console.WriteLine("three-lanes wide in each direction, it's rare that more than one lane");
            Console.WriteLine("each way is ever open. The others are kept closed, with the lanes");
            Console.WriteLine("frequently cycled to reduce wear-and-tear on them.");
            // If player has option to do something
            if (!bNumber2Found)
            {
                Console.WriteLine();
                Console.WriteLine("As you walk down the street, you notice a scrap of paper stuck to the");
                Console.WriteLine("ground.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to look at the scrap of paper? (y)es or (n)o?");
                Console.WriteLine();
                string Paper2 = Console.ReadLine();
                Console.WriteLine();
                Paper2.ToLower();
                while (Paper2 != "y" && Paper2 != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Paper2 = Console.ReadLine();
                    Console.WriteLine();
                    Paper2.ToLower();
                }
                if (Paper2 == "y")
                {
                    bNumber2Found = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("It's a crumpled up piece of paper with the number " + iCombo2 + " written on it in");
                    Console.WriteLine("permanent ink. You throw the note away after recording the number in");
                    Console.WriteLine("your notebook.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   You record the number in your notebook.");
                    if (!bNumber3Found) { iNumberFoundFirst = 2; }
                    Notebook.iNotebookHasInfo++;
                }
                else if (Paper2 == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You ignore the scrap of paper.");
                }
            }
        }
        
        public static void StoryAtTheBusTerminal() // 6
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Once upon a time, one would refer to this terminal as fancy. Now, it");
            Console.WriteLine("looks like a relic to another time thanks to its distinct late 1950s");
            Console.WriteLine("aesthetic. The terminal itself is capable of housing a half-dozen buses,");
            Console.WriteLine("and at one time managed more than twice that. Now, all-but-one bus");
            Console.WriteLine("has since been sold off by the city -- the sole survivor being a 1947");
            Console.WriteLine("White 798. The bus is dark yellow with green trim on the windows and a ");
            Console.WriteLine("white rooftop and seats 44. The elderly bus takes the 45 minute up-and-");
            Console.WriteLine("back trip as many as three times per day, per demand. In the summer,");
            Console.WriteLine("it's common to see two or three modern tour buses from other");
            Console.WriteLine("locations parked next to it.");
            if (bBusDriverUsed)
            {
                Console.WriteLine("The door to the bus has a large padlock on it. The padlock looks rusted");
                Console.WriteLine("over, and does not appear to have been used any time recently.");
            }
            else if (!bBusDriverUsed)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("It looks like the door to the bus is open.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You could look inside if you wanted. (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string BusDoor = Console.ReadLine();
                Console.WriteLine();
                BusDoor.ToLower();
                while (BusDoor != "y" && BusDoor != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    BusDoor = Console.ReadLine();
                    Console.WriteLine();
                    BusDoor.ToLower();
                }
                if (BusDoor == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You walk away from the bus.");
                }
                else if (BusDoor == "y")
                {
                    bBusDriverUsed = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You step up into the bus and peer inside. To your surprise, three rows");
                    Console.WriteLine("back, you see an elderly woman who appears to be asleep. Her eyes open");
                    Console.WriteLine("when she hears you approach.");
                    Console.WriteLine();
                    Console.WriteLine("'Oh, bet you weren't expecting to see me here,' she says. 'Well, don't");
                    Console.WriteLine("worry, you won't see me again. Fact, it may be,' she says, with a gruff");
                    Console.WriteLine("laugh, 'none of us ever see one another again. But you didn't climb in");
                    Console.WriteLine("here to listen to that.'");
                    Console.WriteLine();
                    Console.WriteLine("'Here, I'll tell you what. I'm sure things are pretty crazy out there. Fact,");
                    Console.WriteLine("it's why I'm in here right now. But for someone out there in it, a little");
                    Console.WriteLine("knowledge would probably do you good. And that's about all I got now,'");
                    Console.WriteLine("she says. There's a long pause before she finishes with her punch line: 'A");
                    Console.WriteLine("little knowledge.' She lets loose with another gruff laugh.");
                    Console.WriteLine();
                    Console.WriteLine("'Come on, come on,' she says. There's another pause. 'Give me a name,");
                    Console.WriteLine("and I'll tell you what I know about them.'");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine();
                    Console.WriteLine("TIP: You may write a name like 'Bruce', 'bruce', or 'BRUCE'.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter a name:");
                    Console.WriteLine();
                    string ForInfo = Console.ReadLine();
                    string sTempKnowledge1 = "null";
                    string sTempKnowledge2 = "null";
                    string sTempKnowledge3 = "null";
                    bool bNameForInfo = false;
                    string sNameForInfo = "null";
                    while (!bNameForInfo)
                    {
                        if (ForInfo.ToLower() == NPC_AI.NPC_001.ToLower()) { sNameForInfo = NPC_AI.NPC_001; sTempKnowledge1 = NPC_Traits.TraitOne001; sTempKnowledge2 = NPC_Traits.TraitTwo001; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree001; Notebook.bNoteTwo001 = true; Notebook.bNoteThree001 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_002.ToLower()) { sNameForInfo = NPC_AI.NPC_002; sTempKnowledge1 = NPC_Traits.TraitOne002; sTempKnowledge2 = NPC_Traits.TraitTwo002; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree002; Notebook.bNoteTwo002 = true; Notebook.bNoteThree002 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_003.ToLower()) { sNameForInfo = NPC_AI.NPC_003; sTempKnowledge1 = NPC_Traits.TraitOne003; sTempKnowledge2 = NPC_Traits.TraitTwo003; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree003; Notebook.bNoteTwo003 = true; Notebook.bNoteThree003 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_004.ToLower()) { sNameForInfo = NPC_AI.NPC_004; sTempKnowledge1 = NPC_Traits.TraitOne004; sTempKnowledge2 = NPC_Traits.TraitTwo004; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree004; Notebook.bNoteTwo004 = true; Notebook.bNoteThree004 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_005.ToLower()) { sNameForInfo = NPC_AI.NPC_005; sTempKnowledge1 = NPC_Traits.TraitOne005; sTempKnowledge2 = NPC_Traits.TraitTwo005; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree005; Notebook.bNoteTwo005 = true; Notebook.bNoteThree005 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_006.ToLower()) { sNameForInfo = NPC_AI.NPC_006; sTempKnowledge1 = NPC_Traits.TraitOne006; sTempKnowledge2 = NPC_Traits.TraitTwo006; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree006; Notebook.bNoteTwo006 = true; Notebook.bNoteThree006 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_007.ToLower()) { sNameForInfo = NPC_AI.NPC_007; sTempKnowledge1 = NPC_Traits.TraitOne007; sTempKnowledge2 = NPC_Traits.TraitTwo007; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree007; Notebook.bNoteTwo007 = true; Notebook.bNoteThree007 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_008.ToLower()) { sNameForInfo = NPC_AI.NPC_008; sTempKnowledge1 = NPC_Traits.TraitOne008; sTempKnowledge2 = NPC_Traits.TraitTwo008; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree008; Notebook.bNoteTwo008 = true; Notebook.bNoteThree008 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_009.ToLower()) { sNameForInfo = NPC_AI.NPC_009; sTempKnowledge1 = NPC_Traits.TraitOne009; sTempKnowledge2 = NPC_Traits.TraitTwo009; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree009; Notebook.bNoteTwo009 = true; Notebook.bNoteThree009 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_010.ToLower()) { sNameForInfo = NPC_AI.NPC_010; sTempKnowledge1 = NPC_Traits.TraitOne010; sTempKnowledge2 = NPC_Traits.TraitTwo010; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree010; Notebook.bNoteTwo010 = true; Notebook.bNoteThree010 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_011.ToLower()) { sNameForInfo = NPC_AI.NPC_011; sTempKnowledge1 = NPC_Traits.TraitOne011; sTempKnowledge2 = NPC_Traits.TraitTwo011; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree011; Notebook.bNoteTwo011 = true; Notebook.bNoteThree011 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_012.ToLower()) { sNameForInfo = NPC_AI.NPC_012; sTempKnowledge1 = NPC_Traits.TraitOne012; sTempKnowledge2 = NPC_Traits.TraitTwo012; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree012; Notebook.bNoteTwo012 = true; Notebook.bNoteThree012 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_013.ToLower()) { sNameForInfo = NPC_AI.NPC_013; sTempKnowledge1 = NPC_Traits.TraitOne013; sTempKnowledge2 = NPC_Traits.TraitTwo013; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree013; Notebook.bNoteTwo013 = true; Notebook.bNoteThree013 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_014.ToLower()) { sNameForInfo = NPC_AI.NPC_014; sTempKnowledge1 = NPC_Traits.TraitOne014; sTempKnowledge2 = NPC_Traits.TraitTwo014; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree014; Notebook.bNoteTwo014 = true; Notebook.bNoteThree014 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_015.ToLower()) { sNameForInfo = NPC_AI.NPC_015; sTempKnowledge1 = NPC_Traits.TraitOne015; sTempKnowledge2 = NPC_Traits.TraitTwo015; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree015; Notebook.bNoteTwo015 = true; Notebook.bNoteThree015 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_016.ToLower()) { sNameForInfo = NPC_AI.NPC_016; sTempKnowledge1 = NPC_Traits.TraitOne016; sTempKnowledge2 = NPC_Traits.TraitTwo016; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree016; Notebook.bNoteTwo016 = true; Notebook.bNoteThree016 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_017.ToLower()) { sNameForInfo = NPC_AI.NPC_017; sTempKnowledge1 = NPC_Traits.TraitOne017; sTempKnowledge2 = NPC_Traits.TraitTwo017; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree017; Notebook.bNoteTwo017 = true; Notebook.bNoteThree017 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_018.ToLower()) { sNameForInfo = NPC_AI.NPC_018; sTempKnowledge1 = NPC_Traits.TraitOne018; sTempKnowledge2 = NPC_Traits.TraitTwo018; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree018; Notebook.bNoteTwo018 = true; Notebook.bNoteThree018 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_019.ToLower()) { sNameForInfo = NPC_AI.NPC_019; sTempKnowledge1 = NPC_Traits.TraitOne019; sTempKnowledge2 = NPC_Traits.TraitTwo019; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree019; Notebook.bNoteTwo019 = true; Notebook.bNoteThree019 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_020.ToLower()) { sNameForInfo = NPC_AI.NPC_020; sTempKnowledge1 = NPC_Traits.TraitOne020; sTempKnowledge2 = NPC_Traits.TraitTwo020; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree020; Notebook.bNoteTwo020 = true; Notebook.bNoteThree020 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_021.ToLower()) { sNameForInfo = NPC_AI.NPC_021; sTempKnowledge1 = NPC_Traits.TraitOne021; sTempKnowledge2 = NPC_Traits.TraitTwo021; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree021; Notebook.bNoteTwo021 = true; Notebook.bNoteThree021 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_022.ToLower()) { sNameForInfo = NPC_AI.NPC_022; sTempKnowledge1 = NPC_Traits.TraitOne022; sTempKnowledge2 = NPC_Traits.TraitTwo022; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree022; Notebook.bNoteTwo022 = true; Notebook.bNoteThree022 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_023.ToLower()) { sNameForInfo = NPC_AI.NPC_023; sTempKnowledge1 = NPC_Traits.TraitOne023; sTempKnowledge2 = NPC_Traits.TraitTwo023; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree023; Notebook.bNoteTwo023 = true; Notebook.bNoteThree023 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_024.ToLower()) { sNameForInfo = NPC_AI.NPC_024; sTempKnowledge1 = NPC_Traits.TraitOne024; sTempKnowledge2 = NPC_Traits.TraitTwo024; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree024; Notebook.bNoteTwo024 = true; Notebook.bNoteThree024 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_025.ToLower()) { sNameForInfo = NPC_AI.NPC_025; sTempKnowledge1 = NPC_Traits.TraitOne025; sTempKnowledge2 = NPC_Traits.TraitTwo025; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree025; Notebook.bNoteTwo025 = true; Notebook.bNoteThree025 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_026.ToLower()) { sNameForInfo = NPC_AI.NPC_026; sTempKnowledge1 = NPC_Traits.TraitOne026; sTempKnowledge2 = NPC_Traits.TraitTwo026; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree026; Notebook.bNoteTwo026 = true; Notebook.bNoteThree026 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_027.ToLower()) { sNameForInfo = NPC_AI.NPC_027; sTempKnowledge1 = NPC_Traits.TraitOne027; sTempKnowledge2 = NPC_Traits.TraitTwo027; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree027; Notebook.bNoteTwo027 = true; Notebook.bNoteThree027 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_028.ToLower()) { sNameForInfo = NPC_AI.NPC_028; sTempKnowledge1 = NPC_Traits.TraitOne028; sTempKnowledge2 = NPC_Traits.TraitTwo028; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree028; Notebook.bNoteTwo028 = true; Notebook.bNoteThree028 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_029.ToLower()) { sNameForInfo = NPC_AI.NPC_029; sTempKnowledge1 = NPC_Traits.TraitOne029; sTempKnowledge2 = NPC_Traits.TraitTwo029; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree029; Notebook.bNoteTwo029 = true; Notebook.bNoteThree029 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_030.ToLower()) { sNameForInfo = NPC_AI.NPC_030; sTempKnowledge1 = NPC_Traits.TraitOne030; sTempKnowledge2 = NPC_Traits.TraitTwo030; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree030; Notebook.bNoteTwo030 = true; Notebook.bNoteThree030 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_031.ToLower()) { sNameForInfo = NPC_AI.NPC_031; sTempKnowledge1 = NPC_Traits.TraitOne031; sTempKnowledge2 = NPC_Traits.TraitTwo031; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree031; Notebook.bNoteTwo031 = true; Notebook.bNoteThree031 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_032.ToLower()) { sNameForInfo = NPC_AI.NPC_032; sTempKnowledge1 = NPC_Traits.TraitOne032; sTempKnowledge2 = NPC_Traits.TraitTwo032; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree032; Notebook.bNoteTwo032 = true; Notebook.bNoteThree032 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_033.ToLower()) { sNameForInfo = NPC_AI.NPC_033; sTempKnowledge1 = NPC_Traits.TraitOne033; sTempKnowledge2 = NPC_Traits.TraitTwo033; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree033; Notebook.bNoteTwo033 = true; Notebook.bNoteThree033 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_034.ToLower()) { sNameForInfo = NPC_AI.NPC_034; sTempKnowledge1 = NPC_Traits.TraitOne034; sTempKnowledge2 = NPC_Traits.TraitTwo034; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree034; Notebook.bNoteTwo034 = true; Notebook.bNoteThree034 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_035.ToLower()) { sNameForInfo = NPC_AI.NPC_035; sTempKnowledge1 = NPC_Traits.TraitOne035; sTempKnowledge2 = NPC_Traits.TraitTwo035; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree035; Notebook.bNoteTwo035 = true; Notebook.bNoteThree035 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_036.ToLower()) { sNameForInfo = NPC_AI.NPC_036; sTempKnowledge1 = NPC_Traits.TraitOne036; sTempKnowledge2 = NPC_Traits.TraitTwo036; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree036; Notebook.bNoteTwo036 = true; Notebook.bNoteThree036 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_037.ToLower()) { sNameForInfo = NPC_AI.NPC_037; sTempKnowledge1 = NPC_Traits.TraitOne037; sTempKnowledge2 = NPC_Traits.TraitTwo037; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree037; Notebook.bNoteTwo037 = true; Notebook.bNoteThree037 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_038.ToLower()) { sNameForInfo = NPC_AI.NPC_038; sTempKnowledge1 = NPC_Traits.TraitOne038; sTempKnowledge2 = NPC_Traits.TraitTwo038; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree038; Notebook.bNoteTwo038 = true; Notebook.bNoteThree038 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_039.ToLower()) { sNameForInfo = NPC_AI.NPC_039; sTempKnowledge1 = NPC_Traits.TraitOne039; sTempKnowledge2 = NPC_Traits.TraitTwo039; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree039; Notebook.bNoteTwo039 = true; Notebook.bNoteThree039 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_040.ToLower()) { sNameForInfo = NPC_AI.NPC_040; sTempKnowledge1 = NPC_Traits.TraitOne040; sTempKnowledge2 = NPC_Traits.TraitTwo040; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree040; Notebook.bNoteTwo040 = true; Notebook.bNoteThree040 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_041.ToLower()) { sNameForInfo = NPC_AI.NPC_041; sTempKnowledge1 = NPC_Traits.TraitOne041; sTempKnowledge2 = NPC_Traits.TraitTwo041; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree041; Notebook.bNoteTwo041 = true; Notebook.bNoteThree041 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_042.ToLower()) { sNameForInfo = NPC_AI.NPC_042; sTempKnowledge1 = NPC_Traits.TraitOne042; sTempKnowledge2 = NPC_Traits.TraitTwo042; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree042; Notebook.bNoteTwo042 = true; Notebook.bNoteThree042 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_043.ToLower()) { sNameForInfo = NPC_AI.NPC_043; sTempKnowledge1 = NPC_Traits.TraitOne043; sTempKnowledge2 = NPC_Traits.TraitTwo043; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree043; Notebook.bNoteTwo043 = true; Notebook.bNoteThree043 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_044.ToLower()) { sNameForInfo = NPC_AI.NPC_044; sTempKnowledge1 = NPC_Traits.TraitOne044; sTempKnowledge2 = NPC_Traits.TraitTwo044; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree044; Notebook.bNoteTwo044 = true; Notebook.bNoteThree044 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_045.ToLower()) { sNameForInfo = NPC_AI.NPC_045; sTempKnowledge1 = NPC_Traits.TraitOne045; sTempKnowledge2 = NPC_Traits.TraitTwo045; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree045; Notebook.bNoteTwo045 = true; Notebook.bNoteThree045 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_046.ToLower()) { sNameForInfo = NPC_AI.NPC_046; sTempKnowledge1 = NPC_Traits.TraitOne046; sTempKnowledge2 = NPC_Traits.TraitTwo046; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree046; Notebook.bNoteTwo046 = true; Notebook.bNoteThree046 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_047.ToLower()) { sNameForInfo = NPC_AI.NPC_047; sTempKnowledge1 = NPC_Traits.TraitOne047; sTempKnowledge2 = NPC_Traits.TraitTwo047; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree047; Notebook.bNoteTwo047 = true; Notebook.bNoteThree047 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_048.ToLower()) { sNameForInfo = NPC_AI.NPC_048; sTempKnowledge1 = NPC_Traits.TraitOne048; sTempKnowledge2 = NPC_Traits.TraitTwo048; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree048; Notebook.bNoteTwo048 = true; Notebook.bNoteThree048 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_049.ToLower()) { sNameForInfo = NPC_AI.NPC_049; sTempKnowledge1 = NPC_Traits.TraitOne049; sTempKnowledge2 = NPC_Traits.TraitTwo049; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree049; Notebook.bNoteTwo049 = true; Notebook.bNoteThree049 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_050.ToLower()) { sNameForInfo = NPC_AI.NPC_050; sTempKnowledge1 = NPC_Traits.TraitOne050; sTempKnowledge2 = NPC_Traits.TraitTwo050; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree050; Notebook.bNoteTwo050 = true; Notebook.bNoteThree050 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_051.ToLower()) { sNameForInfo = NPC_AI.NPC_051; sTempKnowledge1 = NPC_Traits.TraitOne051; sTempKnowledge2 = NPC_Traits.TraitTwo051; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree051; Notebook.bNoteTwo051 = true; Notebook.bNoteThree051 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_052.ToLower()) { sNameForInfo = NPC_AI.NPC_052; sTempKnowledge1 = NPC_Traits.TraitOne052; sTempKnowledge2 = NPC_Traits.TraitTwo052; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree052; Notebook.bNoteTwo052 = true; Notebook.bNoteThree052 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_053.ToLower()) { sNameForInfo = NPC_AI.NPC_053; sTempKnowledge1 = NPC_Traits.TraitOne053; sTempKnowledge2 = NPC_Traits.TraitTwo053; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree053; Notebook.bNoteTwo053 = true; Notebook.bNoteThree053 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_054.ToLower()) { sNameForInfo = NPC_AI.NPC_054; sTempKnowledge1 = NPC_Traits.TraitOne054; sTempKnowledge2 = NPC_Traits.TraitTwo054; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree054; Notebook.bNoteTwo054 = true; Notebook.bNoteThree054 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_055.ToLower()) { sNameForInfo = NPC_AI.NPC_055; sTempKnowledge1 = NPC_Traits.TraitOne055; sTempKnowledge2 = NPC_Traits.TraitTwo055; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree055; Notebook.bNoteTwo055 = true; Notebook.bNoteThree055 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_056.ToLower()) { sNameForInfo = NPC_AI.NPC_056; sTempKnowledge1 = NPC_Traits.TraitOne056; sTempKnowledge2 = NPC_Traits.TraitTwo056; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree056; Notebook.bNoteTwo056 = true; Notebook.bNoteThree056 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_057.ToLower()) { sNameForInfo = NPC_AI.NPC_057; sTempKnowledge1 = NPC_Traits.TraitOne057; sTempKnowledge2 = NPC_Traits.TraitTwo057; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree057; Notebook.bNoteTwo057 = true; Notebook.bNoteThree057 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_058.ToLower()) { sNameForInfo = NPC_AI.NPC_058; sTempKnowledge1 = NPC_Traits.TraitOne058; sTempKnowledge2 = NPC_Traits.TraitTwo058; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree058; Notebook.bNoteTwo058 = true; Notebook.bNoteThree058 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_059.ToLower()) { sNameForInfo = NPC_AI.NPC_059; sTempKnowledge1 = NPC_Traits.TraitOne059; sTempKnowledge2 = NPC_Traits.TraitTwo059; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree059; Notebook.bNoteTwo059 = true; Notebook.bNoteThree059 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_060.ToLower()) { sNameForInfo = NPC_AI.NPC_060; sTempKnowledge1 = NPC_Traits.TraitOne060; sTempKnowledge2 = NPC_Traits.TraitTwo060; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree060; Notebook.bNoteTwo060 = true; Notebook.bNoteThree060 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_061.ToLower()) { sNameForInfo = NPC_AI.NPC_061; sTempKnowledge1 = NPC_Traits.TraitOne061; sTempKnowledge2 = NPC_Traits.TraitTwo061; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree061; Notebook.bNoteTwo061 = true; Notebook.bNoteThree061 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_062.ToLower()) { sNameForInfo = NPC_AI.NPC_062; sTempKnowledge1 = NPC_Traits.TraitOne062; sTempKnowledge2 = NPC_Traits.TraitTwo062; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree062; Notebook.bNoteTwo062 = true; Notebook.bNoteThree062 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_063.ToLower()) { sNameForInfo = NPC_AI.NPC_063; sTempKnowledge1 = NPC_Traits.TraitOne063; sTempKnowledge2 = NPC_Traits.TraitTwo063; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree063; Notebook.bNoteTwo063 = true; Notebook.bNoteThree063 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_064.ToLower()) { sNameForInfo = NPC_AI.NPC_064; sTempKnowledge1 = NPC_Traits.TraitOne064; sTempKnowledge2 = NPC_Traits.TraitTwo064; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree064; Notebook.bNoteTwo064 = true; Notebook.bNoteThree064 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_065.ToLower()) { sNameForInfo = NPC_AI.NPC_065; sTempKnowledge1 = NPC_Traits.TraitOne065; sTempKnowledge2 = NPC_Traits.TraitTwo065; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree065; Notebook.bNoteTwo065 = true; Notebook.bNoteThree065 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_066.ToLower()) { sNameForInfo = NPC_AI.NPC_066; sTempKnowledge1 = NPC_Traits.TraitOne066; sTempKnowledge2 = NPC_Traits.TraitTwo066; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree066; Notebook.bNoteTwo066 = true; Notebook.bNoteThree066 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_067.ToLower()) { sNameForInfo = NPC_AI.NPC_067; sTempKnowledge1 = NPC_Traits.TraitOne067; sTempKnowledge2 = NPC_Traits.TraitTwo067; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree067; Notebook.bNoteTwo067 = true; Notebook.bNoteThree067 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_068.ToLower()) { sNameForInfo = NPC_AI.NPC_068; sTempKnowledge1 = NPC_Traits.TraitOne068; sTempKnowledge2 = NPC_Traits.TraitTwo068; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree068; Notebook.bNoteTwo068 = true; Notebook.bNoteThree068 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_069.ToLower()) { sNameForInfo = NPC_AI.NPC_069; sTempKnowledge1 = NPC_Traits.TraitOne069; sTempKnowledge2 = NPC_Traits.TraitTwo069; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree069; Notebook.bNoteTwo069 = true; Notebook.bNoteThree069 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_070.ToLower()) { sNameForInfo = NPC_AI.NPC_070; sTempKnowledge1 = NPC_Traits.TraitOne070; sTempKnowledge2 = NPC_Traits.TraitTwo070; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree070; Notebook.bNoteTwo070 = true; Notebook.bNoteThree070 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_071.ToLower()) { sNameForInfo = NPC_AI.NPC_071; sTempKnowledge1 = NPC_Traits.TraitOne071; sTempKnowledge2 = NPC_Traits.TraitTwo071; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree071; Notebook.bNoteTwo071 = true; Notebook.bNoteThree071 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_072.ToLower()) { sNameForInfo = NPC_AI.NPC_072; sTempKnowledge1 = NPC_Traits.TraitOne072; sTempKnowledge2 = NPC_Traits.TraitTwo072; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree072; Notebook.bNoteTwo072 = true; Notebook.bNoteThree072 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_073.ToLower()) { sNameForInfo = NPC_AI.NPC_073; sTempKnowledge1 = NPC_Traits.TraitOne073; sTempKnowledge2 = NPC_Traits.TraitTwo073; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree073; Notebook.bNoteTwo073 = true; Notebook.bNoteThree073 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_074.ToLower()) { sNameForInfo = NPC_AI.NPC_074; sTempKnowledge1 = NPC_Traits.TraitOne074; sTempKnowledge2 = NPC_Traits.TraitTwo074; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree074; Notebook.bNoteTwo074 = true; Notebook.bNoteThree074 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_075.ToLower()) { sNameForInfo = NPC_AI.NPC_075; sTempKnowledge1 = NPC_Traits.TraitOne075; sTempKnowledge2 = NPC_Traits.TraitTwo075; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree075; Notebook.bNoteTwo075 = true; Notebook.bNoteThree075 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_076.ToLower()) { sNameForInfo = NPC_AI.NPC_076; sTempKnowledge1 = NPC_Traits.TraitOne076; sTempKnowledge2 = NPC_Traits.TraitTwo076; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree076; Notebook.bNoteTwo076 = true; Notebook.bNoteThree076 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_077.ToLower()) { sNameForInfo = NPC_AI.NPC_077; sTempKnowledge1 = NPC_Traits.TraitOne077; sTempKnowledge2 = NPC_Traits.TraitTwo077; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree077; Notebook.bNoteTwo077 = true; Notebook.bNoteThree077 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_078.ToLower()) { sNameForInfo = NPC_AI.NPC_078; sTempKnowledge1 = NPC_Traits.TraitOne078; sTempKnowledge2 = NPC_Traits.TraitTwo078; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree078; Notebook.bNoteTwo078 = true; Notebook.bNoteThree078 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_079.ToLower()) { sNameForInfo = NPC_AI.NPC_079; sTempKnowledge1 = NPC_Traits.TraitOne079; sTempKnowledge2 = NPC_Traits.TraitTwo079; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree079; Notebook.bNoteTwo079 = true; Notebook.bNoteThree079 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_080.ToLower()) { sNameForInfo = NPC_AI.NPC_080; sTempKnowledge1 = NPC_Traits.TraitOne080; sTempKnowledge2 = NPC_Traits.TraitTwo080; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree080; Notebook.bNoteTwo080 = true; Notebook.bNoteThree080 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_081.ToLower()) { sNameForInfo = NPC_AI.NPC_081; sTempKnowledge1 = NPC_Traits.TraitOne081; sTempKnowledge2 = NPC_Traits.TraitTwo081; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree081; Notebook.bNoteTwo081 = true; Notebook.bNoteThree081 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_082.ToLower()) { sNameForInfo = NPC_AI.NPC_082; sTempKnowledge1 = NPC_Traits.TraitOne082; sTempKnowledge2 = NPC_Traits.TraitTwo082; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree082; Notebook.bNoteTwo082 = true; Notebook.bNoteThree082 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_083.ToLower()) { sNameForInfo = NPC_AI.NPC_083; sTempKnowledge1 = NPC_Traits.TraitOne083; sTempKnowledge2 = NPC_Traits.TraitTwo083; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree082; Notebook.bNoteTwo083 = true; Notebook.bNoteThree083 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_084.ToLower()) { sNameForInfo = NPC_AI.NPC_084; sTempKnowledge1 = NPC_Traits.TraitOne084; sTempKnowledge2 = NPC_Traits.TraitTwo084; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree084; Notebook.bNoteTwo084 = true; Notebook.bNoteThree084 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_085.ToLower()) { sNameForInfo = NPC_AI.NPC_085; sTempKnowledge1 = NPC_Traits.TraitOne085; sTempKnowledge2 = NPC_Traits.TraitTwo085; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree085; Notebook.bNoteTwo085 = true; Notebook.bNoteThree085 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_086.ToLower()) { sNameForInfo = NPC_AI.NPC_086; sTempKnowledge1 = NPC_Traits.TraitOne086; sTempKnowledge2 = NPC_Traits.TraitTwo086; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree086; Notebook.bNoteTwo086 = true; Notebook.bNoteThree086 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_087.ToLower()) { sNameForInfo = NPC_AI.NPC_087; sTempKnowledge1 = NPC_Traits.TraitOne087; sTempKnowledge2 = NPC_Traits.TraitTwo087; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree087; Notebook.bNoteTwo087 = true; Notebook.bNoteThree087 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_088.ToLower()) { sNameForInfo = NPC_AI.NPC_088; sTempKnowledge1 = NPC_Traits.TraitOne088; sTempKnowledge2 = NPC_Traits.TraitTwo088; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree088; Notebook.bNoteTwo088 = true; Notebook.bNoteThree088 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_089.ToLower()) { sNameForInfo = NPC_AI.NPC_089; sTempKnowledge1 = NPC_Traits.TraitOne089; sTempKnowledge2 = NPC_Traits.TraitTwo089; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree089; Notebook.bNoteTwo089 = true; Notebook.bNoteThree089 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_090.ToLower()) { sNameForInfo = NPC_AI.NPC_090; sTempKnowledge1 = NPC_Traits.TraitOne090; sTempKnowledge2 = NPC_Traits.TraitTwo090; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree090; Notebook.bNoteTwo090 = true; Notebook.bNoteThree090 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_091.ToLower()) { sNameForInfo = NPC_AI.NPC_091; sTempKnowledge1 = NPC_Traits.TraitOne091; sTempKnowledge2 = NPC_Traits.TraitTwo091; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree091; Notebook.bNoteTwo091 = true; Notebook.bNoteThree091 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_092.ToLower()) { sNameForInfo = NPC_AI.NPC_092; sTempKnowledge1 = NPC_Traits.TraitOne092; sTempKnowledge2 = NPC_Traits.TraitTwo092; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree092; Notebook.bNoteTwo092 = true; Notebook.bNoteThree092 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_093.ToLower()) { sNameForInfo = NPC_AI.NPC_093; sTempKnowledge1 = NPC_Traits.TraitOne093; sTempKnowledge2 = NPC_Traits.TraitTwo093; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree093; Notebook.bNoteTwo093 = true; Notebook.bNoteThree093 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_094.ToLower()) { sNameForInfo = NPC_AI.NPC_094; sTempKnowledge1 = NPC_Traits.TraitOne094; sTempKnowledge2 = NPC_Traits.TraitTwo094; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree094; Notebook.bNoteTwo094 = true; Notebook.bNoteThree094 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_095.ToLower()) { sNameForInfo = NPC_AI.NPC_095; sTempKnowledge1 = NPC_Traits.TraitOne095; sTempKnowledge2 = NPC_Traits.TraitTwo095; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree095; Notebook.bNoteTwo095 = true; Notebook.bNoteThree095 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_096.ToLower()) { sNameForInfo = NPC_AI.NPC_096; sTempKnowledge1 = NPC_Traits.TraitOne096; sTempKnowledge2 = NPC_Traits.TraitTwo096; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree096; Notebook.bNoteTwo096 = true; Notebook.bNoteThree096 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_097.ToLower()) { sNameForInfo = NPC_AI.NPC_097; sTempKnowledge1 = NPC_Traits.TraitOne097; sTempKnowledge2 = NPC_Traits.TraitTwo097; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree097; Notebook.bNoteTwo097 = true; Notebook.bNoteThree097 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_098.ToLower()) { sNameForInfo = NPC_AI.NPC_098; sTempKnowledge1 = NPC_Traits.TraitOne098; sTempKnowledge2 = NPC_Traits.TraitTwo098; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree098; Notebook.bNoteTwo098 = true; Notebook.bNoteThree098 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_099.ToLower()) { sNameForInfo = NPC_AI.NPC_099; sTempKnowledge1 = NPC_Traits.TraitOne099; sTempKnowledge2 = NPC_Traits.TraitTwo099; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree099; Notebook.bNoteTwo099 = true; Notebook.bNoteThree099 = true; }
                        if (ForInfo.ToLower() == NPC_AI.NPC_100.ToLower()) { sNameForInfo = NPC_AI.NPC_100; sTempKnowledge1 = NPC_Traits.TraitOne100; sTempKnowledge2 = NPC_Traits.TraitTwo100; bNameForInfo = true; sTempKnowledge3 = NPC_Traits.TraitThree100; Notebook.bNoteTwo100 = true; Notebook.bNoteThree100 = true; }
                        if (!bNameForInfo)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("'Who are you asking about? Say it again, and enunciate this time.'");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            ForInfo = Console.ReadLine();
                        }
                        else if (bNameForInfo)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine("She looks at you curiously, but for a long while says nothing. Finally,");
                            Console.WriteLine("she breaks the silence.");
                            Console.WriteLine();
                            Console.WriteLine("'I'm just wondering why you want to know about " + sNameForInfo + ". I'm");
                            Console.WriteLine("wondering what you know and what there is to know. But, fact is, it's not");
                            Console.WriteLine("my place to say why. I'm only here to answer your question.");
                            Console.WriteLine();
                            Console.WriteLine(sNameForInfo + " " + sTempKnowledge1 + ", " + sTempKnowledge2 + ", ");
                            Console.WriteLine("and " + sTempKnowledge3 + ".");
                            Console.WriteLine();
                            Console.WriteLine("Now, that may not sound like much, but around about now, that's all");
                            Console.WriteLine("you need to know. So you take what I told you and you use it wisely.'");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   You write down what she says in your notebook.");
                            Notebook.iNotebookHasInfo++;
                        }
                    }
                }
            }
        }
        
        public static void StoryAtTheOfficeDistrict() // 7
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("At its economic high point, with more available workers than jobs and");
            Console.WriteLine("plenty of money to go around, several businesses set up and settled in.");
            Console.WriteLine("The factory's closing had very little impact on them. Time, on the other");
            Console.WriteLine("hand, saw most of them eventually move on to destinations that were");
            Console.WriteLine("more likely to attract young, talented workers. The few that remain");
            Console.WriteLine("have become fully integrated into the local ecosystem and rarely hire");
            Console.WriteLine("non-locals.");
        }
        
        public static void StoryAtTheBarDistrict() // 8
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("There are four prominent bars in this neighborhood, each catering to a");
            Console.WriteLine("slightly different clientele. The Jade Mariposa -- a don't-ask-don't-tell");
            Console.WriteLine("gay bar -- closed its doors in the mid-1990s. Then there is Pete");
            Console.WriteLine("Ganaden's, known to the locals as Pea Gun's. It was once a popular");
            Console.WriteLine("blues bar routinely packed with the 20-, 30-, and 40-something year old");
            Console.WriteLine("local office workers. Despite being older, many of them continue to hit");
            Console.WriteLine("Pea Gun's out of loyalty -- even though 'Pea' died in 1989. The Sea");
            Console.WriteLine("Turtle is the most popular, and continues to maintain decent business.");
            Console.WriteLine("It's a higher-end bar, especially popular with tourists in the summers");
            Console.WriteLine("and local couples looking for a fancy night out. Finally, there's a cheap");
            Console.WriteLine("bar/liquor store known as the Fox's Den. The bar is usually empty, but");
            Console.WriteLine("the liquor store is the only one on the island and keeps the bar in");
            Console.WriteLine("business.");
            Console.WriteLine();
            if ((Lists.TalkingNPCs.Count <= 3) && Variables.iRemainingTurns >= 50 && !bDrunk)
            {
                Console.WriteLine("It doesn't seem like there is much activity happening inside the bars.");
                Console.WriteLine("Maybe another time?");
            }
            else if (Variables.iRemainingTurns < 50 || bDrunk)
            {
                Console.WriteLine("It looks like all of the bars are closed. Large, heavy chains are wrapped");
                Console.WriteLine("around the door handles.");
            }
            else if (Lists.TalkingNPCs.Count > 3 && !bDrunk && Variables.iRemainingTurns >= 50)
            {
                int iNoDrinkers = Lists.TalkingNPCs.Count + 1;
                Console.WriteLine("It catches you off guard to see that, even now, Pea Gun's is open and");
                Console.WriteLine("serving. But, then again, if not now -- when?");
                Console.WriteLine();
                Console.WriteLine("The bartender has both hands on the bar, slightly wider than shoulder");
                Console.WriteLine("width apart. He's pushing forward -- supporting his weight on his locked");
                Console.WriteLine("arms. He looks young, and his dark hair is slicked back. He smiles and");
                Console.WriteLine("motions you over with a quick nod.");
                Console.WriteLine();
                Console.WriteLine("'Why don't you buy everyone here a round. Guaranteed to make people");
                Console.WriteLine("like you -- or at least not hate you. You give me just one MacGuffin per");
                Console.WriteLine("person, and I make everyone a little bit friendlier.'");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine("TIP: A round will cost " + iNoDrinkers + " MacGuffins.");
                Console.WriteLine("TIP: You have " + Variables.iFoundMacGuffins + " MacGuffins.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to buy a round? (y)es or (n)o?");
                Console.WriteLine("(This option requires no additional time.)");
                Console.WriteLine();
                string BarQ1 = Console.ReadLine();
                Console.WriteLine();
                BarQ1.ToLower();
                while (BarQ1 != "y" && BarQ1 != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    BarQ1 = Console.ReadLine();
                    Console.WriteLine();
                    BarQ1.ToLower();
                }
                if (Variables.iFoundMacGuffins < (Lists.TalkingNPCs.Count + 1))
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Hey, that's OK if you don't have the money right now. You come back");
                    Console.WriteLine("when you do and we'll have a go at it. I'm sure the locals will love you");
                    Console.WriteLine("for it just as much then as they would have loved you now.'");
                }
                if (BarQ1 == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'No rounds for you then? Well, you let me know when you want to turn");
                    Console.WriteLine("the suspicious looks aimed in your direction to blissful, trusting smiles.'");
                }
                if (BarQ1 == "y" && Variables.iFoundMacGuffins >= (Lists.TalkingNPCs.Count + 1))
                {
                    foreach (string sDrinkers in Lists.TalkingNPCs)
                    {
                        if (sDrinkers == NPC_AI.NPC_001) { NPC_AI.iLoyalty001 = NPC_AI.iLoyalty001 + 2; } if (sDrinkers == NPC_AI.NPC_002) { NPC_AI.iLoyalty002 = NPC_AI.iLoyalty002 + 2; } if (sDrinkers == NPC_AI.NPC_003) { NPC_AI.iLoyalty003 = NPC_AI.iLoyalty003 + 2; } if (sDrinkers == NPC_AI.NPC_004) { NPC_AI.iLoyalty004 = NPC_AI.iLoyalty004 + 2; }
                        if (sDrinkers == NPC_AI.NPC_005) { NPC_AI.iLoyalty005 = NPC_AI.iLoyalty005 + 2; } if (sDrinkers == NPC_AI.NPC_006) { NPC_AI.iLoyalty006 = NPC_AI.iLoyalty006 + 2; } if (sDrinkers == NPC_AI.NPC_007) { NPC_AI.iLoyalty007 = NPC_AI.iLoyalty007 + 2; } if (sDrinkers == NPC_AI.NPC_008) { NPC_AI.iLoyalty008 = NPC_AI.iLoyalty008 + 2; }
                        if (sDrinkers == NPC_AI.NPC_009) { NPC_AI.iLoyalty009 = NPC_AI.iLoyalty009 + 2; } if (sDrinkers == NPC_AI.NPC_010) { NPC_AI.iLoyalty010 = NPC_AI.iLoyalty010 + 2; } if (sDrinkers == NPC_AI.NPC_011) { NPC_AI.iLoyalty011 = NPC_AI.iLoyalty011 + 2; } if (sDrinkers == NPC_AI.NPC_012) { NPC_AI.iLoyalty012 = NPC_AI.iLoyalty012 + 2; }
                        if (sDrinkers == NPC_AI.NPC_013) { NPC_AI.iLoyalty013 = NPC_AI.iLoyalty013 + 2; } if (sDrinkers == NPC_AI.NPC_014) { NPC_AI.iLoyalty014 = NPC_AI.iLoyalty014 + 2; } if (sDrinkers == NPC_AI.NPC_015) { NPC_AI.iLoyalty015 = NPC_AI.iLoyalty015 + 2; } if (sDrinkers == NPC_AI.NPC_016) { NPC_AI.iLoyalty016 = NPC_AI.iLoyalty016 + 2; }
                        if (sDrinkers == NPC_AI.NPC_017) { NPC_AI.iLoyalty017 = NPC_AI.iLoyalty017 + 2; } if (sDrinkers == NPC_AI.NPC_018) { NPC_AI.iLoyalty018 = NPC_AI.iLoyalty018 + 2; } if (sDrinkers == NPC_AI.NPC_019) { NPC_AI.iLoyalty019 = NPC_AI.iLoyalty019 + 2; } if (sDrinkers == NPC_AI.NPC_020) { NPC_AI.iLoyalty020 = NPC_AI.iLoyalty020 + 2; }
                        if (sDrinkers == NPC_AI.NPC_021) { NPC_AI.iLoyalty021 = NPC_AI.iLoyalty021 + 2; } if (sDrinkers == NPC_AI.NPC_022) { NPC_AI.iLoyalty022 = NPC_AI.iLoyalty022 + 2; } if (sDrinkers == NPC_AI.NPC_023) { NPC_AI.iLoyalty023 = NPC_AI.iLoyalty023 + 2; } if (sDrinkers == NPC_AI.NPC_024) { NPC_AI.iLoyalty024 = NPC_AI.iLoyalty024 + 2; }
                        if (sDrinkers == NPC_AI.NPC_025) { NPC_AI.iLoyalty025 = NPC_AI.iLoyalty025 + 2; } if (sDrinkers == NPC_AI.NPC_026) { NPC_AI.iLoyalty026 = NPC_AI.iLoyalty026 + 2; } if (sDrinkers == NPC_AI.NPC_027) { NPC_AI.iLoyalty027 = NPC_AI.iLoyalty027 + 2; } if (sDrinkers == NPC_AI.NPC_028) { NPC_AI.iLoyalty028 = NPC_AI.iLoyalty028 + 2; }
                        if (sDrinkers == NPC_AI.NPC_029) { NPC_AI.iLoyalty029 = NPC_AI.iLoyalty029 + 2; } if (sDrinkers == NPC_AI.NPC_030) { NPC_AI.iLoyalty030 = NPC_AI.iLoyalty030 + 2; } if (sDrinkers == NPC_AI.NPC_031) { NPC_AI.iLoyalty031 = NPC_AI.iLoyalty031 + 2; } if (sDrinkers == NPC_AI.NPC_032) { NPC_AI.iLoyalty032 = NPC_AI.iLoyalty032 + 2; }
                        if (sDrinkers == NPC_AI.NPC_033) { NPC_AI.iLoyalty033 = NPC_AI.iLoyalty033 + 2; } if (sDrinkers == NPC_AI.NPC_034) { NPC_AI.iLoyalty034 = NPC_AI.iLoyalty034 + 2; } if (sDrinkers == NPC_AI.NPC_035) { NPC_AI.iLoyalty035 = NPC_AI.iLoyalty035 + 2; } if (sDrinkers == NPC_AI.NPC_036) { NPC_AI.iLoyalty036 = NPC_AI.iLoyalty036 + 2; }
                        if (sDrinkers == NPC_AI.NPC_037) { NPC_AI.iLoyalty037 = NPC_AI.iLoyalty037 + 2; } if (sDrinkers == NPC_AI.NPC_038) { NPC_AI.iLoyalty038 = NPC_AI.iLoyalty038 + 2; } if (sDrinkers == NPC_AI.NPC_039) { NPC_AI.iLoyalty039 = NPC_AI.iLoyalty039 + 2; } if (sDrinkers == NPC_AI.NPC_040) { NPC_AI.iLoyalty040 = NPC_AI.iLoyalty040 + 2; }
                        if (sDrinkers == NPC_AI.NPC_041) { NPC_AI.iLoyalty041 = NPC_AI.iLoyalty041 + 2; } if (sDrinkers == NPC_AI.NPC_042) { NPC_AI.iLoyalty042 = NPC_AI.iLoyalty042 + 2; } if (sDrinkers == NPC_AI.NPC_043) { NPC_AI.iLoyalty043 = NPC_AI.iLoyalty043 + 2; } if (sDrinkers == NPC_AI.NPC_044) { NPC_AI.iLoyalty044 = NPC_AI.iLoyalty044 + 2; }
                        if (sDrinkers == NPC_AI.NPC_045) { NPC_AI.iLoyalty045 = NPC_AI.iLoyalty045 + 2; } if (sDrinkers == NPC_AI.NPC_046) { NPC_AI.iLoyalty046 = NPC_AI.iLoyalty046 + 2; } if (sDrinkers == NPC_AI.NPC_047) { NPC_AI.iLoyalty047 = NPC_AI.iLoyalty047 + 2; } if (sDrinkers == NPC_AI.NPC_048) { NPC_AI.iLoyalty048 = NPC_AI.iLoyalty048 + 2; }
                        if (sDrinkers == NPC_AI.NPC_049) { NPC_AI.iLoyalty049 = NPC_AI.iLoyalty049 + 2; } if (sDrinkers == NPC_AI.NPC_050) { NPC_AI.iLoyalty050 = NPC_AI.iLoyalty050 + 2; } if (sDrinkers == NPC_AI.NPC_051) { NPC_AI.iLoyalty051 = NPC_AI.iLoyalty051 + 2; } if (sDrinkers == NPC_AI.NPC_052) { NPC_AI.iLoyalty052 = NPC_AI.iLoyalty052 + 2; }
                        if (sDrinkers == NPC_AI.NPC_053) { NPC_AI.iLoyalty053 = NPC_AI.iLoyalty053 + 2; } if (sDrinkers == NPC_AI.NPC_054) { NPC_AI.iLoyalty054 = NPC_AI.iLoyalty054 + 2; } if (sDrinkers == NPC_AI.NPC_055) { NPC_AI.iLoyalty055 = NPC_AI.iLoyalty055 + 2; } if (sDrinkers == NPC_AI.NPC_056) { NPC_AI.iLoyalty056 = NPC_AI.iLoyalty056 + 2; }
                        if (sDrinkers == NPC_AI.NPC_057) { NPC_AI.iLoyalty057 = NPC_AI.iLoyalty057 + 2; } if (sDrinkers == NPC_AI.NPC_058) { NPC_AI.iLoyalty058 = NPC_AI.iLoyalty058 + 2; } if (sDrinkers == NPC_AI.NPC_059) { NPC_AI.iLoyalty059 = NPC_AI.iLoyalty059 + 2; } if (sDrinkers == NPC_AI.NPC_060) { NPC_AI.iLoyalty060 = NPC_AI.iLoyalty060 + 2; }
                        if (sDrinkers == NPC_AI.NPC_061) { NPC_AI.iLoyalty061 = NPC_AI.iLoyalty061 + 2; } if (sDrinkers == NPC_AI.NPC_062) { NPC_AI.iLoyalty062 = NPC_AI.iLoyalty062 + 2; } if (sDrinkers == NPC_AI.NPC_063) { NPC_AI.iLoyalty063 = NPC_AI.iLoyalty063 + 2; } if (sDrinkers == NPC_AI.NPC_064) { NPC_AI.iLoyalty064 = NPC_AI.iLoyalty064 + 2; }
                        if (sDrinkers == NPC_AI.NPC_065) { NPC_AI.iLoyalty065 = NPC_AI.iLoyalty065 + 2; } if (sDrinkers == NPC_AI.NPC_066) { NPC_AI.iLoyalty066 = NPC_AI.iLoyalty066 + 2; } if (sDrinkers == NPC_AI.NPC_067) { NPC_AI.iLoyalty067 = NPC_AI.iLoyalty067 + 2; } if (sDrinkers == NPC_AI.NPC_068) { NPC_AI.iLoyalty068 = NPC_AI.iLoyalty068 + 2; }
                        if (sDrinkers == NPC_AI.NPC_069) { NPC_AI.iLoyalty069 = NPC_AI.iLoyalty069 + 2; } if (sDrinkers == NPC_AI.NPC_070) { NPC_AI.iLoyalty070 = NPC_AI.iLoyalty070 + 2; } if (sDrinkers == NPC_AI.NPC_071) { NPC_AI.iLoyalty071 = NPC_AI.iLoyalty071 + 2; } if (sDrinkers == NPC_AI.NPC_072) { NPC_AI.iLoyalty072 = NPC_AI.iLoyalty072 + 2; }
                        if (sDrinkers == NPC_AI.NPC_073) { NPC_AI.iLoyalty073 = NPC_AI.iLoyalty073 + 2; } if (sDrinkers == NPC_AI.NPC_074) { NPC_AI.iLoyalty074 = NPC_AI.iLoyalty074 + 2; } if (sDrinkers == NPC_AI.NPC_075) { NPC_AI.iLoyalty075 = NPC_AI.iLoyalty075 + 2; } if (sDrinkers == NPC_AI.NPC_076) { NPC_AI.iLoyalty076 = NPC_AI.iLoyalty076 + 2; }
                        if (sDrinkers == NPC_AI.NPC_077) { NPC_AI.iLoyalty077 = NPC_AI.iLoyalty077 + 2; } if (sDrinkers == NPC_AI.NPC_078) { NPC_AI.iLoyalty078 = NPC_AI.iLoyalty078 + 2; } if (sDrinkers == NPC_AI.NPC_079) { NPC_AI.iLoyalty079 = NPC_AI.iLoyalty079 + 2; } if (sDrinkers == NPC_AI.NPC_080) { NPC_AI.iLoyalty080 = NPC_AI.iLoyalty080 + 2; }
                        if (sDrinkers == NPC_AI.NPC_081) { NPC_AI.iLoyalty081 = NPC_AI.iLoyalty081 + 2; } if (sDrinkers == NPC_AI.NPC_082) { NPC_AI.iLoyalty082 = NPC_AI.iLoyalty082 + 2; } if (sDrinkers == NPC_AI.NPC_083) { NPC_AI.iLoyalty083 = NPC_AI.iLoyalty083 + 2; } if (sDrinkers == NPC_AI.NPC_084) { NPC_AI.iLoyalty084 = NPC_AI.iLoyalty084 + 2; }
                        if (sDrinkers == NPC_AI.NPC_085) { NPC_AI.iLoyalty085 = NPC_AI.iLoyalty085 + 2; } if (sDrinkers == NPC_AI.NPC_086) { NPC_AI.iLoyalty086 = NPC_AI.iLoyalty086 + 2; } if (sDrinkers == NPC_AI.NPC_087) { NPC_AI.iLoyalty087 = NPC_AI.iLoyalty087 + 2; } if (sDrinkers == NPC_AI.NPC_088) { NPC_AI.iLoyalty088 = NPC_AI.iLoyalty088 + 2; }
                        if (sDrinkers == NPC_AI.NPC_089) { NPC_AI.iLoyalty089 = NPC_AI.iLoyalty089 + 2; } if (sDrinkers == NPC_AI.NPC_090) { NPC_AI.iLoyalty090 = NPC_AI.iLoyalty090 + 2; } if (sDrinkers == NPC_AI.NPC_091) { NPC_AI.iLoyalty091 = NPC_AI.iLoyalty091 + 2; } if (sDrinkers == NPC_AI.NPC_092) { NPC_AI.iLoyalty092 = NPC_AI.iLoyalty092 + 2; }
                        if (sDrinkers == NPC_AI.NPC_093) { NPC_AI.iLoyalty093 = NPC_AI.iLoyalty093 + 2; } if (sDrinkers == NPC_AI.NPC_094) { NPC_AI.iLoyalty094 = NPC_AI.iLoyalty094 + 2; } if (sDrinkers == NPC_AI.NPC_095) { NPC_AI.iLoyalty095 = NPC_AI.iLoyalty095 + 2; } if (sDrinkers == NPC_AI.NPC_096) { NPC_AI.iLoyalty096 = NPC_AI.iLoyalty096 + 2; }
                        if (sDrinkers == NPC_AI.NPC_097) { NPC_AI.iLoyalty097 = NPC_AI.iLoyalty097 + 2; } if (sDrinkers == NPC_AI.NPC_098) { NPC_AI.iLoyalty098 = NPC_AI.iLoyalty098 + 2; } if (sDrinkers == NPC_AI.NPC_099) { NPC_AI.iLoyalty099 = NPC_AI.iLoyalty099 + 2; } if (sDrinkers == NPC_AI.NPC_100) { NPC_AI.iLoyalty100 = NPC_AI.iLoyalty100 + 2; }
                    }
                    iNoDrinkers = Lists.TalkingNPCs.Count + 1;
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins - iNoDrinkers;
                    bDrunk = true;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'That's what I like to hear. Everybody! Due to extravagant kindness");
                    Console.WriteLine("and fortuitous circumstances, you are officially in the right place at the");
                    Console.WriteLine("right time. The owner of a few MacGuffins over here,' -- he points at");
                    Console.WriteLine("you with flair -- 'has decided to let a few of them go in order to ensure ");
                    Console.WriteLine("everyone a top quality imbibe.'");
                    Console.WriteLine();
                    Console.WriteLine("A light cheer goes up around the room. It's hard to tell if it's sincere-but-");
                    Console.WriteLine("restrained, or, perhaps, mocking. You, and the rest of the patrons,");
                    Console.WriteLine("receive a drink. In addition, you also receive a shot. As you finish your");
                    Console.WriteLine("drinks, the bartender looks to you again.");
                    Console.WriteLine();
                    Console.WriteLine("'Now we're seeing with both eyes open. And from what I hear in my");
                    Console.WriteLine("journey around the liquor-fueled wasteland, sentiments are warming.");
                    Console.WriteLine("So if you'll excuse me the congratulatory pat on the back, you'll have to");
                    Console.WriteLine("agree we made the right call to open up the coffers and perform a little");
                    Console.WriteLine("distribution to the masses. Go on, give yourself a pat. Oh, but you're");
                    Console.WriteLine("about the next-level hit parade of life's most grandiose encounters, I");
                    Console.WriteLine("can tell. So here's what I say -- and hear me out before you slam that");
                    Console.WriteLine("imaginary green-lit button of approval. My promise? Everyone loves");
                    Console.WriteLine("you. No exceptions. If a single person refuses to write at least one");
                    Console.WriteLine("sonnet of appreciation to you, I'll personally take them out back, as it");
                    Console.WriteLine("were, and paddle them righteously. The cost to you, of course: the");
                    Console.WriteLine("addition of a mere MacGuffin -- per patron. What say you?'");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Each patron's disposition increased by 2.");
                    Console.WriteLine("   Lost " + iNoDrinkers + " MacGuffins.");
                    Console.WriteLine();
                    Console.WriteLine("TIP: Another round will cost another " + iNoDrinkers + " MacGuffins.");
                    Console.WriteLine("TIP: You have " + Variables.iFoundMacGuffins + " MacGuffins.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want to buy a round? (y)es or (n)o?");
                    Console.WriteLine("(This option requires 4 minutes.)");
                    Console.WriteLine();
                    string BarQ2 = Console.ReadLine();
                    Console.WriteLine();
                    BarQ2.ToLower();
                    while (BarQ2 != "y" && BarQ2 != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        BarQ2 = Console.ReadLine();
                        Console.WriteLine();
                        BarQ2.ToLower();
                    }
                    if (Variables.iFoundMacGuffins < (Lists.TalkingNPCs.Count + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("'Hey, that's OK if you don't have the money right now. You come back");
                        Console.WriteLine("when you do and we'll have a go at it. I'm sure the locals will love you");
                        Console.WriteLine("for it just as much then as they would have loved you now.'");
                    }
                    else if (BarQ2 == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("'One is enough, is it? Well, looks at you. A master of moderation if I ever");
                        Console.WriteLine("saw one. And isn't that a smart way to go about it facing the end of the");
                        Console.WriteLine("world. Take care out there not to get any dirt on your shoes.'");
                    }
                    else if (BarQ2 == "y" && Variables.iFoundMacGuffins >= (Lists.TalkingNPCs.Count + 1))
                    {
                        foreach (string sDrinkers in Lists.TalkingNPCs)
                        {
                            if (sDrinkers == NPC_AI.NPC_001) { NPC_AI.iLoyalty001 = 5; } if (sDrinkers == NPC_AI.NPC_002) { NPC_AI.iLoyalty002 = 5; } if (sDrinkers == NPC_AI.NPC_003) { NPC_AI.iLoyalty003 = 5; } if (sDrinkers == NPC_AI.NPC_004) { NPC_AI.iLoyalty004 = 5; }
                            if (sDrinkers == NPC_AI.NPC_005) { NPC_AI.iLoyalty005 = 5; } if (sDrinkers == NPC_AI.NPC_006) { NPC_AI.iLoyalty006 = 5; } if (sDrinkers == NPC_AI.NPC_007) { NPC_AI.iLoyalty007 = 5; } if (sDrinkers == NPC_AI.NPC_008) { NPC_AI.iLoyalty008 = 5; }
                            if (sDrinkers == NPC_AI.NPC_009) { NPC_AI.iLoyalty009 = 5; } if (sDrinkers == NPC_AI.NPC_010) { NPC_AI.iLoyalty010 = 5; } if (sDrinkers == NPC_AI.NPC_011) { NPC_AI.iLoyalty011 = 5; } if (sDrinkers == NPC_AI.NPC_012) { NPC_AI.iLoyalty012 = 5; }
                            if (sDrinkers == NPC_AI.NPC_013) { NPC_AI.iLoyalty013 = 5; } if (sDrinkers == NPC_AI.NPC_014) { NPC_AI.iLoyalty014 = 5; } if (sDrinkers == NPC_AI.NPC_015) { NPC_AI.iLoyalty015 = 5; } if (sDrinkers == NPC_AI.NPC_016) { NPC_AI.iLoyalty016 = 5; }
                            if (sDrinkers == NPC_AI.NPC_017) { NPC_AI.iLoyalty017 = 5; } if (sDrinkers == NPC_AI.NPC_018) { NPC_AI.iLoyalty018 = 5; } if (sDrinkers == NPC_AI.NPC_019) { NPC_AI.iLoyalty019 = 5; } if (sDrinkers == NPC_AI.NPC_020) { NPC_AI.iLoyalty020 = 5; }
                            if (sDrinkers == NPC_AI.NPC_021) { NPC_AI.iLoyalty021 = 5; } if (sDrinkers == NPC_AI.NPC_022) { NPC_AI.iLoyalty022 = 5; } if (sDrinkers == NPC_AI.NPC_023) { NPC_AI.iLoyalty023 = 5; } if (sDrinkers == NPC_AI.NPC_024) { NPC_AI.iLoyalty024 = 5; }
                            if (sDrinkers == NPC_AI.NPC_025) { NPC_AI.iLoyalty025 = 5; } if (sDrinkers == NPC_AI.NPC_026) { NPC_AI.iLoyalty026 = 5; } if (sDrinkers == NPC_AI.NPC_027) { NPC_AI.iLoyalty027 = 5; } if (sDrinkers == NPC_AI.NPC_028) { NPC_AI.iLoyalty028 = 5; }
                            if (sDrinkers == NPC_AI.NPC_029) { NPC_AI.iLoyalty029 = 5; } if (sDrinkers == NPC_AI.NPC_030) { NPC_AI.iLoyalty030 = 5; } if (sDrinkers == NPC_AI.NPC_031) { NPC_AI.iLoyalty031 = 5; } if (sDrinkers == NPC_AI.NPC_032) { NPC_AI.iLoyalty032 = 5; }
                            if (sDrinkers == NPC_AI.NPC_033) { NPC_AI.iLoyalty033 = 5; } if (sDrinkers == NPC_AI.NPC_034) { NPC_AI.iLoyalty034 = 5; } if (sDrinkers == NPC_AI.NPC_035) { NPC_AI.iLoyalty035 = 5; } if (sDrinkers == NPC_AI.NPC_036) { NPC_AI.iLoyalty036 = 5; }
                            if (sDrinkers == NPC_AI.NPC_037) { NPC_AI.iLoyalty037 = 5; } if (sDrinkers == NPC_AI.NPC_038) { NPC_AI.iLoyalty038 = 5; } if (sDrinkers == NPC_AI.NPC_039) { NPC_AI.iLoyalty039 = 5; } if (sDrinkers == NPC_AI.NPC_040) { NPC_AI.iLoyalty040 = 5; }
                            if (sDrinkers == NPC_AI.NPC_041) { NPC_AI.iLoyalty041 = 5; } if (sDrinkers == NPC_AI.NPC_042) { NPC_AI.iLoyalty042 = 5; } if (sDrinkers == NPC_AI.NPC_043) { NPC_AI.iLoyalty043 = 5; } if (sDrinkers == NPC_AI.NPC_044) { NPC_AI.iLoyalty044 = 5; }
                            if (sDrinkers == NPC_AI.NPC_045) { NPC_AI.iLoyalty045 = 5; } if (sDrinkers == NPC_AI.NPC_046) { NPC_AI.iLoyalty046 = 5; } if (sDrinkers == NPC_AI.NPC_047) { NPC_AI.iLoyalty047 = 5; } if (sDrinkers == NPC_AI.NPC_048) { NPC_AI.iLoyalty048 = 5; }
                            if (sDrinkers == NPC_AI.NPC_049) { NPC_AI.iLoyalty049 = 5; } if (sDrinkers == NPC_AI.NPC_050) { NPC_AI.iLoyalty050 = 5; } if (sDrinkers == NPC_AI.NPC_051) { NPC_AI.iLoyalty051 = 5; } if (sDrinkers == NPC_AI.NPC_052) { NPC_AI.iLoyalty052 = 5; }
                            if (sDrinkers == NPC_AI.NPC_053) { NPC_AI.iLoyalty053 = 5; } if (sDrinkers == NPC_AI.NPC_054) { NPC_AI.iLoyalty054 = 5; } if (sDrinkers == NPC_AI.NPC_055) { NPC_AI.iLoyalty055 = 5; } if (sDrinkers == NPC_AI.NPC_056) { NPC_AI.iLoyalty056 = 5; }
                            if (sDrinkers == NPC_AI.NPC_057) { NPC_AI.iLoyalty057 = 5; } if (sDrinkers == NPC_AI.NPC_058) { NPC_AI.iLoyalty058 = 5; } if (sDrinkers == NPC_AI.NPC_059) { NPC_AI.iLoyalty059 = 5; } if (sDrinkers == NPC_AI.NPC_060) { NPC_AI.iLoyalty060 = 5; }
                            if (sDrinkers == NPC_AI.NPC_061) { NPC_AI.iLoyalty061 = 5; } if (sDrinkers == NPC_AI.NPC_062) { NPC_AI.iLoyalty062 = 5; } if (sDrinkers == NPC_AI.NPC_063) { NPC_AI.iLoyalty063 = 5; } if (sDrinkers == NPC_AI.NPC_064) { NPC_AI.iLoyalty064 = 5; }
                            if (sDrinkers == NPC_AI.NPC_065) { NPC_AI.iLoyalty065 = 5; } if (sDrinkers == NPC_AI.NPC_066) { NPC_AI.iLoyalty066 = 5; } if (sDrinkers == NPC_AI.NPC_067) { NPC_AI.iLoyalty067 = 5; } if (sDrinkers == NPC_AI.NPC_068) { NPC_AI.iLoyalty068 = 5; }
                            if (sDrinkers == NPC_AI.NPC_069) { NPC_AI.iLoyalty069 = 5; } if (sDrinkers == NPC_AI.NPC_070) { NPC_AI.iLoyalty070 = 5; } if (sDrinkers == NPC_AI.NPC_071) { NPC_AI.iLoyalty071 = 5; } if (sDrinkers == NPC_AI.NPC_072) { NPC_AI.iLoyalty072 = 5; }
                            if (sDrinkers == NPC_AI.NPC_073) { NPC_AI.iLoyalty073 = 5; } if (sDrinkers == NPC_AI.NPC_074) { NPC_AI.iLoyalty074 = 5; } if (sDrinkers == NPC_AI.NPC_075) { NPC_AI.iLoyalty075 = 5; } if (sDrinkers == NPC_AI.NPC_076) { NPC_AI.iLoyalty076 = 5; }
                            if (sDrinkers == NPC_AI.NPC_077) { NPC_AI.iLoyalty077 = 5; } if (sDrinkers == NPC_AI.NPC_078) { NPC_AI.iLoyalty078 = 5; } if (sDrinkers == NPC_AI.NPC_079) { NPC_AI.iLoyalty079 = 5; } if (sDrinkers == NPC_AI.NPC_080) { NPC_AI.iLoyalty080 = 5; }
                            if (sDrinkers == NPC_AI.NPC_081) { NPC_AI.iLoyalty081 = 5; } if (sDrinkers == NPC_AI.NPC_082) { NPC_AI.iLoyalty082 = 5; } if (sDrinkers == NPC_AI.NPC_083) { NPC_AI.iLoyalty083 = 5; } if (sDrinkers == NPC_AI.NPC_084) { NPC_AI.iLoyalty084 = 5; }
                            if (sDrinkers == NPC_AI.NPC_085) { NPC_AI.iLoyalty085 = 5; } if (sDrinkers == NPC_AI.NPC_086) { NPC_AI.iLoyalty086 = 5; } if (sDrinkers == NPC_AI.NPC_087) { NPC_AI.iLoyalty087 = 5; } if (sDrinkers == NPC_AI.NPC_088) { NPC_AI.iLoyalty088 = 5; }
                            if (sDrinkers == NPC_AI.NPC_089) { NPC_AI.iLoyalty089 = 5; } if (sDrinkers == NPC_AI.NPC_090) { NPC_AI.iLoyalty090 = 5; } if (sDrinkers == NPC_AI.NPC_091) { NPC_AI.iLoyalty091 = 5; } if (sDrinkers == NPC_AI.NPC_092) { NPC_AI.iLoyalty092 = 5; }
                            if (sDrinkers == NPC_AI.NPC_093) { NPC_AI.iLoyalty093 = 5; } if (sDrinkers == NPC_AI.NPC_094) { NPC_AI.iLoyalty094 = 5; } if (sDrinkers == NPC_AI.NPC_095) { NPC_AI.iLoyalty095 = 5; } if (sDrinkers == NPC_AI.NPC_096) { NPC_AI.iLoyalty096 = 5; }
                            if (sDrinkers == NPC_AI.NPC_097) { NPC_AI.iLoyalty097 = 5; } if (sDrinkers == NPC_AI.NPC_098) { NPC_AI.iLoyalty098 = 5; } if (sDrinkers == NPC_AI.NPC_099) { NPC_AI.iLoyalty099 = 5; } if (sDrinkers == NPC_AI.NPC_100) { NPC_AI.iLoyalty100 = 5; }
                        }
                        iNoDrinkers = Lists.TalkingNPCs.Count + 1; // technically, this would never be re-defined at this stage, but whatevs.
                        Variables.iFoundMacGuffins = Variables.iFoundMacGuffins - iNoDrinkers;
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 4;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("'Never was there a more hackneyed word, but, with apologies, 'epic'");
                        Console.WriteLine("this night has become thanks solely to your presence. Well, yours and");
                        Console.WriteLine("the MacGuffins. They are making the world go 'round, aren't they?'");
                        Console.WriteLine();
                        Console.WriteLine("There's a brief-but-enthusiastic round of applause as the bartender");
                        Console.WriteLine("informs everyone of another round. Once again, a drink and a shot is");
                        Console.WriteLine("handed to you. The room begins to sway as you finish your drinks.");
                        Console.WriteLine();
                        Console.WriteLine("The bartender leans in and whispers something to you. You're not sure");
                        Console.WriteLine("what he's saying, but he's smiling and you can't help but smile, either.");
                        Console.WriteLine("Once or twice, you stumble around the room to go to the bathroom.");
                        Console.WriteLine("People smile and say things to you, but you're having trouble matching");
                        Console.WriteLine("their words with the sounds they make. At one point, you find yourself");
                        Console.WriteLine("out back looking in the dumpster behind the bar -- but the bartender");
                        Console.WriteLine("collects you and brings you back to your seat.");
                        Console.WriteLine();
                        Console.WriteLine("It might be a good idea to call it quits, you tell yourself. On the other");
                        Console.WriteLine("hand: one more round. One last stab at immortality before... before...");
                        Console.WriteLine("the night gathers rosebuds. And... never mind. Leave the fancy phrasing");
                        Console.WriteLine("to the bartender, you think. We don't want to steal his gimmick. One more?");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   Each patron's disposition increased to maximum.");
                        Console.WriteLine("   Lost " + iNoDrinkers + " MacGuffins.");
                        Console.WriteLine();
                        Console.WriteLine("TIP: Another round will cost another " + iNoDrinkers + " MacGuffins.");
                        Console.WriteLine("TIP: You have " + Variables.iFoundMacGuffins + " MacGuffins.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Do you want to buy a round? (y)es or (n)o?");
                        Console.WriteLine("Focusing on time is becoming very difficult. If you buy another round,");
                        Console.WriteLine("you're not sure how much time might pass.");
                        Console.WriteLine();
                        string BarQ3 = Console.ReadLine();
                        Console.WriteLine();
                        BarQ3.ToLower();
                        while (BarQ3 != "y" && BarQ3 != "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            BarQ3 = Console.ReadLine();
                            Console.WriteLine();
                            BarQ3.ToLower();
                        }
                        if (Variables.iFoundMacGuffins < (Lists.TalkingNPCs.Count + 1))
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("'Ah, so close to hitting the trifecta; it would have been you, you, and you");
                            Console.WriteLine("winning rounds one, three, and two. But I feel it safe to say that you and");
                            Console.WriteLine("your coin brought some happiness to our night, a gentle sunset for our");
                            Console.WriteLine("last hoorah, and I'm sure I speak for all when I say that I'm glad you");
                            Console.WriteLine("happened by sweet old Pea's.'");
                        }
                        else if (BarQ3 == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("'Ah, so close to hitting the trifecta; it would have been you, you, and you");
                            Console.WriteLine("winning rounds one, three, and two. But I feel it safe to say that you and");
                            Console.WriteLine("your coin brought some happiness to our night, a gentle sunset for our");
                            Console.WriteLine("last hoorah, and I'm sure I speak for all when I say that I'm glad you");
                            Console.WriteLine("happened by sweet old Pea's.'");
                        }
                        else if (BarQ3 == "y" && Variables.iFoundMacGuffins >= (Lists.TalkingNPCs.Count + 1))
                        {
                            iNoDrinkers = Lists.TalkingNPCs.Count + 1; // technically, this would never be re-defined at this stage, but whatevs.
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins - iNoDrinkers;
                            Variables.iRemainingTurns = 7;
                            NPC_AI.bCorpse001 = NPC_AI.bCorpse002 = NPC_AI.bCorpse003 = NPC_AI.bCorpse004 = NPC_AI.bCorpse005 = NPC_AI.bCorpse006 = NPC_AI.bCorpse007 = NPC_AI.bCorpse008 = NPC_AI.bCorpse009 = NPC_AI.bCorpse010 = true;
                            NPC_AI.bCorpse011 = NPC_AI.bCorpse012 = NPC_AI.bCorpse013 = NPC_AI.bCorpse014 = NPC_AI.bCorpse015 = NPC_AI.bCorpse016 = NPC_AI.bCorpse017 = NPC_AI.bCorpse018 = NPC_AI.bCorpse019 = NPC_AI.bCorpse020 = true;
                            NPC_AI.bCorpse021 = NPC_AI.bCorpse022 = NPC_AI.bCorpse023 = NPC_AI.bCorpse024 = NPC_AI.bCorpse025 = NPC_AI.bCorpse026 = NPC_AI.bCorpse027 = NPC_AI.bCorpse028 = NPC_AI.bCorpse029 = NPC_AI.bCorpse030 = true;
                            NPC_AI.bCorpse031 = NPC_AI.bCorpse032 = NPC_AI.bCorpse033 = NPC_AI.bCorpse034 = NPC_AI.bCorpse035 = NPC_AI.bCorpse036 = NPC_AI.bCorpse037 = NPC_AI.bCorpse038 = NPC_AI.bCorpse039 = NPC_AI.bCorpse040 = true;
                            NPC_AI.bCorpse041 = NPC_AI.bCorpse042 = NPC_AI.bCorpse043 = NPC_AI.bCorpse044 = NPC_AI.bCorpse045 = NPC_AI.bCorpse046 = NPC_AI.bCorpse047 = NPC_AI.bCorpse048 = NPC_AI.bCorpse049 = NPC_AI.bCorpse050 = true;
                            NPC_AI.bCorpse051 = NPC_AI.bCorpse052 = NPC_AI.bCorpse053 = NPC_AI.bCorpse054 = NPC_AI.bCorpse055 = NPC_AI.bCorpse056 = NPC_AI.bCorpse057 = NPC_AI.bCorpse058 = NPC_AI.bCorpse059 = NPC_AI.bCorpse060 = true;
                            NPC_AI.bCorpse061 = NPC_AI.bCorpse062 = NPC_AI.bCorpse063 = NPC_AI.bCorpse064 = NPC_AI.bCorpse065 = NPC_AI.bCorpse066 = NPC_AI.bCorpse067 = NPC_AI.bCorpse068 = NPC_AI.bCorpse069 = NPC_AI.bCorpse070 = true;
                            NPC_AI.bCorpse071 = NPC_AI.bCorpse072 = NPC_AI.bCorpse073 = NPC_AI.bCorpse074 = NPC_AI.bCorpse075 = NPC_AI.bCorpse076 = NPC_AI.bCorpse077 = NPC_AI.bCorpse078 = NPC_AI.bCorpse079 = NPC_AI.bCorpse080 = true;
                            NPC_AI.bCorpse081 = NPC_AI.bCorpse082 = NPC_AI.bCorpse083 = NPC_AI.bCorpse084 = NPC_AI.bCorpse085 = NPC_AI.bCorpse086 = NPC_AI.bCorpse087 = NPC_AI.bCorpse088 = NPC_AI.bCorpse089 = NPC_AI.bCorpse090 = true;
                            NPC_AI.bCorpse091 = NPC_AI.bCorpse092 = NPC_AI.bCorpse093 = NPC_AI.bCorpse094 = NPC_AI.bCorpse095 = NPC_AI.bCorpse096 = NPC_AI.bCorpse097 = NPC_AI.bCorpse098 = NPC_AI.bCorpse099 = NPC_AI.bCorpse100 = true;
                            Variables.sGetLocation = location_023; Variables.iCurrentLocation = 23; // move the player
                            bDontAuto23 = true;
                            NPC_AI.NPC100_CurrentNumLocation = 1;
                            NPC_AI.NPC100_CurrentStrLocation = location_001;
                            Lists.RemainingNPCs.Clear();
                            TheBunny.bBunnyIntro = true;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("'One more round!' you say. The bartender looks at you confused. Is he");
                            Console.WriteLine("waiting for something? 'I have a MacGuffin. They are here.' You point at");
                            Console.WriteLine("them with your other hand. 'In my hand.' He doesn't seem to");
                            Console.WriteLine("understand. 'You can make them into drinks that make people, uh. It's");
                            Console.WriteLine("so slow. Does that? No, seriously. Did that ever think it can be so talking");
                            Console.WriteLine("but sometimes -- oh my! A tidal wave. It's not even moving. I never.");
                            Console.WriteLine();
                            Console.WriteLine("The words pour out of you, each one feeling more meaningful than the");
                            Console.WriteLine("last, each one making you happier, more content, and, admittedly, a");
                            Console.WriteLine("little more nauseous, too. You consider your options.");
                            if (!Title.bAchievement01)
                            {
                                Title.bAchievement01 = true;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("   Secret Discovered: " + Title.sAchievement01);
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Lost " + iNoDrinkers + " MacGuffins.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("(G)o Outside, (T)ake off your clothes, or (B)e Social.");
                            Console.WriteLine();
                            string BarQ4 = Console.ReadLine();
                            Console.WriteLine();
                            BarQ4.ToLower();
                            while (BarQ4 != "g" && BarQ4 != "t" && BarQ4 != "b")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                Console.WriteLine("these choices and move forward.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("(G)o Outside, (T)ake off your clothes, or (B)e Social.");
                                Console.WriteLine();
                                BarQ4 = Console.ReadLine();
                                Console.WriteLine();
                            }
                            if (BarQ4 == "b")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You worked diligently, and to great expense, to satisfy everyone, but the");
                                Console.WriteLine("relationship is empty. It hasn't been fostered by personal attention, only");
                                Console.WriteLine("indirect-indirect manifestations induced by loneliness: money given to a");
                                Console.WriteLine("bartender who made drinks, who delivered them to people you don't");
                                Console.WriteLine("know. Where is your prize? Six degrees of bartending friendships.");
                                Console.WriteLine();
                                Console.WriteLine("You decide to correct that. You go from person-to-person, asking about");
                                Console.WriteLine("wives or husbands, subjecting yourself to pictures of kids, dancing on");
                                Console.WriteLine("the pool table in the back of the bar and smashing a bottle or two over");
                                Console.WriteLine("your head -- all to show your appreciation for each person, for who they");
                                Console.WriteLine("are, for the deep relationships you hope to foster... despite how");
                                Console.WriteLine("unattractive some of them are.");
                                Console.WriteLine();
                                Console.WriteLine("But time never ceases. No, it marches on. Inexorably. Wait. What is");
                                Console.WriteLine("inexorable? It's as if the word was part of a phrase. But what is it? And");
                                Console.WriteLine("can you say time marches on without also saying it's doing so");
                                Console.WriteLine("inexorably? While time apparently must march inexorably, it also");
                                Console.WriteLine("marches on with you in tow. And soon you find yourself outside --");
                                Console.WriteLine("wondering how you got here, wondering why you feel so sore. You");
                                Console.WriteLine("wonder if you were in a fight. And, if so, why didn't the good friends you");
                                Console.WriteLine("make help you by coming to your rescue? No matter, you think. I can");
                                Console.WriteLine("find my own way. But -- to where? What now? Two thoughts come to mind.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Go (H)ome or visit the (B)ridge.");
                            }
                            if (BarQ4 == "t")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You take your shirt off, then your pants. But the pants get stuck at your");
                                Console.WriteLine("feet since your shoes are still on. You sit down on the ground to take");
                                Console.WriteLine("your shoes off, but the knots are so tight and -- this is ending up as way");
                                Console.WriteLine("more work than you thought.");
                                Console.WriteLine();
                                Console.WriteLine("Thankfully, a few people seem to understand the trouble you're having.");
                                Console.WriteLine("They stand you up and help you put your clothes back on. 'Thank you, I");
                                Console.WriteLine("really appreciate that. Taking them off was so difficult, but putting them");
                                Console.WriteLine("on was so easy,' you say. They nod supportively. Such quality friends.");
                                Console.WriteLine();
                                Console.WriteLine("Soon, you're floating along toward the door and outside, carried along");
                                Console.WriteLine("on their backs like a hero leaving for war. You tilt your head back");
                                Console.WriteLine("and enjoy the gratitude. It feels good to be loved, you think. But now it's");
                                Console.WriteLine("time for that promised war. Two thoughts come to mind.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Go (H)ome or visit the (B)ridge.");
                            }
                            if (BarQ4 == "g")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("You tell the bartender that 'It's hot. I think I'll get some fresh air.' The");
                                Console.WriteLine("bartender looks at you curiously. 'I guess it's OK,' he says, 'but it's not");
                                Console.WriteLine("my favorite.' 'No, I think I'll walk,' you say. 'I don't need a cab.' He");
                                Console.WriteLine("laughs. 'No, we don't have that around here. But there's always Rome.'");
                                Console.WriteLine("You wander outside as the room tips left and right. Once outside, you");
                                Console.WriteLine("consider the possibilities. So many options, of course -- but two spring ");
                                Console.WriteLine("immediately to mind.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Go (H)ome or visit the (B)ridge.");
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            string BarQ5 = Console.ReadLine();
                            Console.WriteLine();
                            while (BarQ5 != "h" && BarQ5 != "b")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                Console.WriteLine("these choices and move forward.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Go (H)ome or visit the (B)ridge.");
                                Console.WriteLine();
                                BarQ5 = Console.ReadLine();
                                Console.WriteLine();
                            }
                            if (BarQ5 == "h")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Walking in the cool night air, you feel more stable -- though it's hard to");
                                Console.WriteLine("keep your eyes open, and every once in a while you need to stop to lean");
                                Console.WriteLine("against something. Street lights extend into long, blurred streaks that");
                                Console.WriteLine("stretch into infinity. The stars are like lights ripping their way through");
                                Console.WriteLine("the thick, velvety black fabric of the sky -- and then suddenly blocked by");
                                Console.WriteLine("a building. You lower your gaze. You're standing in front of a door.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("You can try the (D)oor, or (C)hange your mind and walk to the bridge.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                string BarQ6 = Console.ReadLine();
                                Console.WriteLine();
                                while (BarQ6 != "d" && BarQ6 != "c")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                    Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                    Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                    Console.WriteLine("these choices and move forward.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("You can try the (D)oor, or (C)hange your mind and walk to the bridge.");
                                    Console.WriteLine();
                                    BarQ6 = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                if (BarQ6 == "c")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("Doors are so dramatic, you think to yourself. Opening, closing.");
                                    Console.WriteLine("Opportunities. Knocking. Three doors, and what's behind them?");
                                    Console.WriteLine("Jennifer Connelly? No. And what if you open the wrong one? And wait a");
                                    Console.WriteLine("minute: it's always the wrong one. They make sure of that -- except for");
                                    Console.WriteLine("once in a while so no one gets suspicious. You make a note to yourself");
                                    Console.WriteLine("to look into the number of times someone chooses what's behind");
                                    Console.WriteLine("three doors and loses.");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("   You add a reminder in your notebook.");
                                    Notebook.iNotebookHasInfo++;
                                    bDrunkWaffler = true;
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("(Press any key when you're ready.)");
                                    BarQ6 = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                if (BarQ6 == "d")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("The door is unlocked, and you step through into a long white hallway. At");
                                    Console.WriteLine("the end of the hallway you see a heavyset man holding a corded rotary");
                                    Console.WriteLine("phone against his belly, the handset near his neck. He's wearing a soft");
                                    Console.WriteLine("white robe. He puts the phone down when he sees you and says, 'Oh,");
                                    Console.WriteLine("thanks heavens. I tried to call, but you didn't answer. I was so worried.");
                                    Console.WriteLine("Is everything OK?'");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("(A)sk who he is. (L)ook through your pockets. (T)ell him everything is OK.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string BarQ7 = Console.ReadLine();
                                    Console.WriteLine();
                                    while (BarQ7 != "l" && BarQ7 != "t" && BarQ7 != "a")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                        Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                        Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                        Console.WriteLine("these choices and move forward.");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("(A)sk who he is. (L)ook through your pockets. (T)ell him everything is OK.");
                                        Console.WriteLine();
                                        BarQ7 = Console.ReadLine();
                                        Console.WriteLine();
                                    }
                                    if (BarQ7 == "a")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("You look at him for a while and let your mind wonder who he is. Do I");
                                        Console.WriteLine("know him? Have I always known him? You decide it's better not to ask");
                                        Console.WriteLine("such a question. You're certain that, in one life or another, you two have");
                                        Console.WriteLine("shared countless years together. Besides, it could hurt his feelings, and");
                                        Console.WriteLine("he already looks upset. Oh, you remember. He was worried.");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("(L)ook through your pockets. (T)ell him everything is OK.");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        BarQ7 = Console.ReadLine();
                                        Console.WriteLine();
                                        while (BarQ7 != "l" && BarQ7 != "t")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                            Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                            Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                            Console.WriteLine("these choices and move forward.");
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("(L)ook through your pockets. (T)ell him everything is OK.");
                                            Console.WriteLine();
                                            BarQ7 = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                    }
                                    if (BarQ7 == "l")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("You dig into your pockets to look for something, without quite knowing");
                                        Console.WriteLine("why. Your efforts turn up only the rest of your MacGuffins. You pull");
                                        Console.WriteLine("them out and hold them out between the two of you. 'You've been such");
                                        Console.WriteLine("a good friend to me,' you tell him. 'And this is the only thing I have of");
                                        Console.WriteLine("value. What's mine is ours now. I love you.'");
                                        Console.WriteLine();
                                        Console.WriteLine("He lunges toward you to hug you, but the world tips over and both of");
                                        Console.WriteLine("you end up on the floor. MacGuffins fly everywhere. They dance");
                                        Console.WriteLine("majestically through the air, light twinkling off their golden surfaces.");
                                        Console.WriteLine("You were just trying to show him know that everything would be OK. Maybe");
                                        Console.WriteLine("words would work better.");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("   Lost " + Variables.iFoundMacGuffins + " MacGuffins.");
                                        Variables.iFinishingMac = Variables.iFoundMacGuffins;
                                        Variables.iFoundMacGuffins = 0;
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("(T)ell him everything is OK.");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        BarQ7 = Console.ReadLine();
                                        Console.WriteLine();
                                        while (BarQ7 != "t")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Maybe it's not the most honest thing in the world to tell him that");
                                            Console.WriteLine("everything is OK, but sometimes it's better to say something uplifting");
                                            Console.WriteLine("than to cause someone excessive worry. Go ahead, it's OK. See how that");
                                            Console.WriteLine("made you feel? Now tell him it's OK, too.");
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("(T)ell him everything is OK.");
                                            Console.WriteLine();
                                            BarQ7 = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                    }
                                    if (BarQ7 == "t")
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.WriteLine("'I guess I don't have a phone,' you say. 'That's why I didn't answer. But");
                                        Console.WriteLine("everything is OK, so don't worry. And it's important for you to know --");
                                        Console.WriteLine("are you listening? I said this is important: if you were to ever call me,");
                                        Console.WriteLine("And, I mean, ever, I would get out of the shower if I was in the shower");
                                        Console.WriteLine("and you called, and I would answer the phone if it was you. And I");
                                        Console.WriteLine("wouldn't do that for anyone else.'");
                                        Console.WriteLine();
                                        Console.WriteLine("'But how would you know it was me?' he asks you. Then he smiles,");
                                        Console.WriteLine("putting his finger to your lips before saying, 'You're the only person I");
                                        Console.WriteLine("would ever want to call, and you're right here.'");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("(H)ug him. (K)iss him. (R)est your eyes.");
                                        Console.WriteLine();
                                        string BarQ8 = Console.ReadLine();
                                        Console.WriteLine();
                                        while (BarQ8 != "h" && BarQ8 != "k" && BarQ8 != "r")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                            Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                            Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                            Console.WriteLine("these choices and move forward.");
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("(H)ug him. (K)iss him. (R)est your eyes.");
                                            Console.WriteLine();
                                            BarQ8 = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        if (BarQ8 == "r")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("You feel so safe in his arms, so at peace -- like there's nothing wrong in");
                                            Console.WriteLine("the world, like you're well-and-truly loved, like there's meaning to life.");
                                            Console.WriteLine("You find yourself dozing off as you continue to hold him. 'You're so");
                                            Console.WriteLine("comfortable,' you say. 'You're turning this moment into eternity. I want");
                                            Console.WriteLine("to be lost in it.'");
                                            Console.WriteLine();
                                            Console.WriteLine("But eternity comes to an end too quickly. Strong hands grab you from");
                                            Console.WriteLine("behind and stand you up.");
                                            BarQ8to9Jump = true;
                                        }
                                        if (BarQ8 == "k")
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.WriteLine("To let the romantic tension build, you look him deeply in one eye for a");
                                            Console.WriteLine("thousand years, then a thousand again for the other. Maybe just five");
                                            Console.WriteLine("hundred years on his nose, you think, but for a certain ten thousand");
                                            Console.WriteLine("years you admire his lips. That's when you know you both can no longer");
                                            Console.WriteLine("fight it, and you kiss him firmly on those lips, your tongue feeling its way");
                                            Console.WriteLine("along their shape.");
                                            Console.WriteLine();
                                            Console.WriteLine("He pushes you away, but he looks conflicted. 'We shouldn't! We can't! I");
                                            Console.WriteLine("won't fall in love with you, only to lose you. I couldn't take it.'");
                                            Console.WriteLine();
                                            Console.WriteLine("You touch your finger to his lips and shush him. 'Let's live in this");
                                            Console.WriteLine("moment,' you say. 'Let all the tomorrows come or not, but let us today");
                                            Console.WriteLine("while we can.' You wonder if it would be rude to write that down in");
                                            Console.WriteLine("your notebook during such a special moment. You decide it would be,");
                                            Console.WriteLine("so you do your best to remember the phrasing.");
                                            Console.WriteLine();
                                            Console.WriteLine("He looks sad. How could he not? Your words touched him. 'Oh, how I");
                                            Console.WriteLine("wish I could,' he says. 'I would do anything to be with you!' He buries his");
                                            Console.WriteLine("head against your chest, sobbing. But then strong hands grab you from");
                                            Console.WriteLine("behind, interrupting the moment and standing you up.");
                                            BarQ8to9Jump = true;
                                        }
                                        if (BarQ8to9Jump || BarQ8 == "h")
                                        {
                                            if (BarQ8 == "h")
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                Console.WriteLine("You wrap your arms tightly around him and playfully press your nose");
                                                Console.WriteLine("against his. You feel the emotion welling up in him. He loves you so");
                                                Console.WriteLine("much, but by you showing him love, as well, you can tell it's a bit");
                                                Console.WriteLine("overwhelming for him. 'Hey. You are so important to me. And I could be");
                                                Console.WriteLine("anywhere, but I'm here with you. And it's not even about sex. I would");
                                                Console.WriteLine("be happy to only hold you and feel you against me all night long.");
                                                Console.WriteLine();
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("(S)uggest sex. (C)ontinue to hold him. (R)est your eyes.");
                                                Console.WriteLine();
                                                string BarQ9 = Console.ReadLine();
                                                Console.WriteLine();
                                                while (BarQ9 != "s" && BarQ9 != "c" && BarQ9 != "r")
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                                    Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                                    Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                                    Console.WriteLine("these choices and move forward.");
                                                    Console.WriteLine();
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("(S)uggest sex. (C)ontinue to hold him. (R)est your eyes.");
                                                    Console.WriteLine();
                                                    BarQ9 = Console.ReadLine();
                                                    Console.WriteLine();
                                                }
                                                if (BarQ9 == "s")
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine("'But, I mean... if you wanted to have sex, there's no reason we couldn't.");
                                                    Console.WriteLine("Especially now. The world is ending -- or, at least, it's the end of our");
                                                    Console.WriteLine("world, of us. If you wanted to, we could -- no, we should.'");
                                                    Console.WriteLine();
                                                    Console.WriteLine("You reach your hands down the front of his pants, but before you can");
                                                    Console.WriteLine("get far strong hands grab you from behind and stand you up.");
                                                }
                                                if (BarQ9 == "c" || BarQ9 == "r")
                                                {
                                                    Console.Clear();
                                                    Console.ForegroundColor = ConsoleColor.Gray;
                                                    Console.WriteLine("You feel so safe in his arms, so at peace -- like there's nothing wrong in");
                                                    Console.WriteLine("the world, like you're well-and-truly loved, like there's meaning to life.");
                                                    Console.WriteLine("You find yourself dozing off as you continue to hold him. 'You're so");
                                                    Console.WriteLine("comfortable,' you say. 'You're turning this moment into eternity. I want");
                                                    Console.WriteLine("to be lost in it.'");
                                                    Console.WriteLine();
                                                    Console.WriteLine("But eternity comes to an end too quickly. Strong hands grab you from");
                                                    Console.WriteLine("behind and stand you up.");
                                                }
                                            }
                                            Console.WriteLine();
                                            Console.WriteLine("You turn to look to see who lifted you, but they're too close behind you");
                                            Console.WriteLine("to see. It's like shadows dancing at the edge of your vision, shadows");
                                            Console.WriteLine("that take the lead and dance you to the door. When you reach it, a foot");
                                            Console.WriteLine("presses against your back and gracefully twirls you out into the night.");
                                            Console.WriteLine();
                                            Console.WriteLine("You're back outside, and take a moment to breathe in some fresh air.");
                                            Console.WriteLine("You turn around but don't see the house that you just left. In fact, there");
                                            Console.WriteLine("are no houses nearby.");
                                            Console.WriteLine();
                                            Console.WriteLine("You're standing in the soft, grassy sand of the dunes. Now, you think,");
                                            Console.WriteLine("how did I get here? You look around and try to regain your bearings.");
                                        }
                                    }
                                }
                            }
                            if (BarQ5 == "b" || bDrunkWaffler)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("It takes some time, but you eventually reach the broken bridge. You");
                                Console.WriteLine("walk as far up the bridge as you can, until you reach the destroyed end.");
                                Console.WriteLine("The wind blows fiercely here. Someone has set up orange barrels with");
                                Console.WriteLine("reflector lights on them to keep people from wandering over the edge.");
                                Console.WriteLine("But it would be so easy to walk right past them and into the dark.");
                                Console.WriteLine();
                                Console.WriteLine("You try to remember why you came here. Did someone tell you to come");
                                Console.WriteLine("here? And then you see it: a massive tidal wave churning in place, mist");
                                Console.WriteLine("soaking through your clothes. But no, not that. The tidal wave is last");
                                Console.WriteLine("week's news, you say -- amused by your clever absurdity. What's");
                                Console.WriteLine("different is that the tidal wave is looking at you quite intently.");
                                Console.WriteLine();
                                Console.WriteLine("You can see its beady eyes hiding behind a thin layer of darkened water");
                                Console.WriteLine("-- mocking you. Suddenly you realize that it's alive. Are all tidal waves ");
                                Console.WriteLine("alive? Is all water alive? You reel from the implications.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Say, 'It's not (f)air of you to look at me like that. What did I do?'");
                                Console.WriteLine("Say, 'You think you're so (s)uperior, but one day you'll evaporate.'");
                                Console.WriteLine();
                                string BarQ10 = Console.ReadLine();
                                Console.WriteLine();
                                while (BarQ10 != "s" && BarQ10 != "f")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                    Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                    Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                    Console.WriteLine("these choices and move forward.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Say, 'It's not (F)air of you to look at me like that. What did I do?'");
                                    Console.WriteLine("Say, 'You think you're so (S)uperior, but one day you'll evaporate.'");
                                    Console.WriteLine();
                                    BarQ10 = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                if (BarQ10 == "f")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("The wave doesn't respond, but it does churn more loudly, and there's a");
                                    Console.WriteLine("bit more spray against your face. You wipe it away and think that the");
                                    Console.WriteLine("wave must have its own language. If only there were a way you two");
                                    Console.WriteLine("could understand one another. But how ridiculous is that? Man and");
                                    Console.WriteLine("water will never be able to communicate. Will they? If there is a God,");
                                    Console.WriteLine("why would He put two beings side-by-side but not let them speak? But");
                                    Console.WriteLine("then a thought overtakes you: what if it's sobbing? What if it had been");
                                    Console.WriteLine("trying to speak, and I couldn't understand it, and now it's sad?");
                                }
                                if (BarQ10 == "s")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("The wave ripples. Is it sobbing? It is! How sad that when a wave cries no");
                                    Console.WriteLine("one can tell. Most people probably can't even tell one wave from");
                                    Console.WriteLine("another. You pause for a moment and wonder if that's racist to");
                                    Console.WriteLine("consider. It's not like every wake looks the same. Then you wonder how");
                                    Console.WriteLine("many times a wave cried in your presence and you ignored it -- or,");
                                    Console.WriteLine("worse, yet -- maybe dove into it and swam around and had a good time");
                                    Console.WriteLine("at its expense. You wonder if that's along the same lines as rape. But");
                                    Console.WriteLine("you know the difference now. Enlightenment. There's still time to be a");
                                    Console.WriteLine("good person. And maybe that's enough.");
                                }
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("(C)onsole the wave.");
                                Console.WriteLine("(W)ords will only take away from this experience. Walk away.");
                                Console.WriteLine();
                                string BarQ11 = Console.ReadLine();
                                Console.WriteLine();
                                while (BarQ11 != "c" && BarQ11 != "w")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You think about other possibilities, but worry that if you take too much");
                                    Console.WriteLine("time to consider them that you may come across -- to someone else, or");
                                    Console.WriteLine("yourself, perhaps -- as indecisive. No, you think, better to stick to one of");
                                    Console.WriteLine("these choices and move forward.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("(C)onsole the wave.");
                                    Console.WriteLine("(W)ords will only take away from this experience. Walk away.");
                                    Console.WriteLine();
                                    BarQ11 = Console.ReadLine();
                                    Console.WriteLine();
                                }
                                if (BarQ11 == "c")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("'There's something you need to understand. It's OK to be sad. You know");
                                    Console.WriteLine("that. Right? Besides, you can understand us. We can't understand you,");
                                    Console.WriteLine("and maybe it's sad to always have one-way communications, but one");
                                    Console.WriteLine("day we'll figure it out and one day we'll be able to share our");
                                    Console.WriteLine("experiences. I'll tell you what. Until that day, assuming I survive, one day");
                                    Console.WriteLine("a week I'll go out to the water's edge and read to you. How does that");
                                    Console.WriteLine("sound?'");
                                    Console.WriteLine();
                                    Console.WriteLine("You feel good about yourself. It puffs your chest up. Who else");
                                    Console.WriteLine("would make such an effort? Of course, that is a lot of effort. Sure, I only");
                                    Console.WriteLine("said once per week, but there could be a lot of weeks left. You wonder");
                                    Console.WriteLine("what you have gotten yourself into.");
                                }
                                if (BarQ11 == "w")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.WriteLine("You leave the wave and reflect on the exchange the two of you had, and");
                                    Console.WriteLine("consider what you'll do with this new discovery if you survive.");
                                    Console.WriteLine();
                                    Console.WriteLine("But then a feeling of tragic sadness wells up within you. Chances are,");
                                    Console.WriteLine("you think, you won't survive. And this knowledge, this discovery, will be");
                                    Console.WriteLine("lost to the world. It makes you think of when you found out about the");
                                    Console.WriteLine("Library of Alexandria. Sure, maybe the world's knowledge at that time");
                                    Console.WriteLine("amounted to a hill of beans -- but people now will never be able to look");
                                    Console.WriteLine("back and see how much smarter they are. That's so sad.");
                                    Console.WriteLine();
                                    Console.WriteLine("Then you wonder if the only reason you learned something about the");
                                    Console.WriteLine("wave is because it knew you would die. Maybe it's OK for you to know,");
                                    Console.WriteLine("now, because you can't share the information. It seems tragic, of");
                                    Console.WriteLine("course, but at least that makes sense.");
                                }
                                Console.WriteLine();
                                Console.WriteLine("You take a moment to breathe in some of the night's cool, fresh air.");
                                Console.WriteLine("You turn around but don't see the house that you just left. In fact, there");
                                Console.WriteLine("are no houses nearby.");
                                Console.WriteLine();
                                Console.WriteLine("You're standing in the soft, grassy sand of the dunes. Now, you think,");
                                Console.WriteLine("how did I get here? You look around and try to regain your bearings.");
                            }
                        }
                    }
                }
            }
        }
        
        public static void StoryAtTheApartments() // 9
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The Apartments is a strangely generic name given to this section of the");
            Console.WriteLine("neighborhood, and not the name of any specific complex or units. In");
            Console.WriteLine("fact, many of the residences in the Apartments are actually stand-alone");
            Console.WriteLine("houses. During the economic boom of the late 1960s, this area really");
            Console.WriteLine("filled out -- and, despite that, housing was tight. Now, most of this");
            Console.WriteLine("neighborhood is vacant, and entire blocks have since been leveled and");
            Console.WriteLine("converted into businesses, rinks, simple grass parks, or parking lots.");
        }
        
        public static void StoryAtTheLighthouse() // 10
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This no-longer-functional lighthouse stands 55-foot tall. It's white with a");
            Console.WriteLine("red top, and has a small, enclosed walk that circles its upper-tier --");
            Console.WriteLine("allowing tourists to get a good view of the city. Attached to its base is a");
            Console.WriteLine("gift shop/small museum dedicated to the island's history.");
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 10)
            {
                Console.WriteLine();
                Console.WriteLine("Standing lonely in front of the door to the lighthouse's gift shop is a");
                Console.WriteLine("small replica lighthouse, perhaps four or five inches tall. This must be");
                Console.WriteLine("the gift that the bunny placed for you to recover.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the replica? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sLightHouseGift = Console.ReadLine();
                Console.WriteLine();
                sLightHouseGift.ToLower();
                while (sLightHouseGift != "y" && sLightHouseGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sLightHouseGift = Console.ReadLine();
                    Console.WriteLine();
                    sLightHouseGift.ToLower();
                }
                if (sLightHouseGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the replica and place it in your pocket. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation10EncounterBlocker = true;
                }
                if (sLightHouseGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the replica where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this replica to " + TheBunny.sClueNPC + ".");
                }
            }
            else if (!bLightHouseUsed && !bLocation10EncounterBlocker)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("You notice that the door to the lighthouse is open slightly.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Would you like to go into the lighthouse? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string LightHouseQ1 = Console.ReadLine();
                Console.WriteLine();
                LightHouseQ1.ToLower();
                while (LightHouseQ1 != "y" && LightHouseQ1 != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    LightHouseQ1 = Console.ReadLine();
                    Console.WriteLine();
                    LightHouseQ1.ToLower();
                }
                if (LightHouseQ1 == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("You try to think of compelling reasons to go snooping through a non-");
                    Console.WriteLine("functioning lighthouse, but can only come up with reasons not to. And");
                    Console.WriteLine("so, with that, you decide to leave that creepily-opened door to its own");
                    Console.WriteLine("devices. Let someone else go wandering around in there.");
                }
                if (LightHouseQ1 == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("The inside of the lighthouse is slender and round, tapering slightly as it");
                    Console.WriteLine("climbs. The paint is off-white, weather worn and cracked. A spiral");
                    Console.WriteLine("staircase takes up the majority of the interior.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("You could climb the stairs, if you liked. (y)es or (n)o?");
                    Console.WriteLine();
                    string LightHouseQ2 = Console.ReadLine();
                    Console.WriteLine();
                    LightHouseQ2.ToLower();
                    while (LightHouseQ2 != "y" && LightHouseQ2 != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        LightHouseQ2 = Console.ReadLine();
                        Console.WriteLine();
                        LightHouseQ2.ToLower();
                    }
                    if (LightHouseQ2 == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You decide it's probably better not to go sticking your head where it");
                        Console.WriteLine("doesn't belong. What if the stairs break? What if someone locks you");
                        Console.WriteLine("inside? What if you fall? What if there's someone inside just waiting for");
                        Console.WriteLine("stupid people to go wandering around a darkened lighthouse? You");
                        Console.WriteLine("could probably sit here for hours coming up with all of the bad things");
                        Console.WriteLine("that could happen, but decide you're better off getting back outside.");
                    }
                    if (LightHouseQ2 == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You have to bend your body in a slightly awkward manner to keep from");
                        Console.WriteLine("bumping into the metal railing or hitting your head, but otherwise the");
                        Console.WriteLine("climb isn't too difficult. The stairs stop at the ceiling. A trapdoor allows");
                        Console.WriteLine("access to the ceiling.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Would you like to open it? (y)es or (n)o?");
                        Console.WriteLine();
                        string LightHouseQ3 = Console.ReadLine();
                        Console.WriteLine();
                        LightHouseQ3.ToLower();
                        while (LightHouseQ3 != "y" && LightHouseQ3 != "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            LightHouseQ3 = Console.ReadLine();
                            Console.WriteLine();
                            LightHouseQ3.ToLower();
                        }
                        if (LightHouseQ3 == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine("While it was a fun little adventure to come this far, you feel like it's been");
                            Console.WriteLine("enough of one without continuing on through the trap door. Besides,");
                            Console.WriteLine("you never know what could be on the other side. Better safe than sorry.");
                        }
                        if (LightHouseQ3 == "y" && !bGolfCourseKey)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine("While it was a fun little adventure to come this far, unfortunately the");
                            Console.WriteLine("trap door is locked. Unless you can find a suitable key, you may never");
                            Console.WriteLine("have the opportunity to find out what's on the other side.");
                        }
                        if (LightHouseQ3 == "y" && bGolfCourseKey)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            Console.WriteLine("Unfortunately, the door is locked. However, when you try the key you");
                            Console.WriteLine("found at the golf course, you are surprised to see that it fits. One half-");
                            Console.WriteLine("turn later, and you hear a click. You push the trap door open.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Would you like to climb up through the trap door? (y)es or (n)o?");
                            Console.WriteLine();
                            string LightHouseQ4 = Console.ReadLine();
                            Console.WriteLine();
                            LightHouseQ4.ToLower();
                            while (LightHouseQ4 != "y" && LightHouseQ4 != "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                LightHouseQ4 = Console.ReadLine();
                                LightHouseQ4.ToLower();
                                Console.WriteLine();
                            }
                            if (LightHouseQ4 == "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Clear();
                                Console.WriteLine("While it was a fun little adventure to come this far, you feel like it's been");
                                Console.WriteLine("enough of one without continuing on through the trap door. Besides,");
                                Console.WriteLine("you never know what could be on the other side. Better safe than sorry.");
                            }
                            if (LightHouseQ4 == "y")
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Clear();
                                Console.WriteLine("You climb up to the top of the lighthouse and look out into the night. It's");
                                Console.WriteLine("dark but beautiful from up here. Despite the height, however, the tidal");
                                Console.WriteLine("waves are still far too tall for you to see beyond them.");
                                Console.WriteLine();
                                Console.WriteLine("As you enjoy the view, you notice that there's a fuse box in the optical");
                                Console.WriteLine("system. You look into the fuse box and notice that a fuse is missing.");
                                if (!bLightHouseFuse)
                                {
                                    Console.WriteLine("Perhaps if you had a fuse, you could turn on the lighthouse's light.");
                                }
                                if (bLightHouseFuse)
                                {
                                    Console.WriteLine("It looks like the fuse you found at the post office would fit here.");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Would you like to try to insert it? (y)es or (n)o?");
                                    Console.WriteLine();
                                    string LightHouseQ5 = Console.ReadLine();
                                    Console.WriteLine();
                                    LightHouseQ5.ToLower();
                                    while (LightHouseQ5 != "y" && LightHouseQ5 != "n")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                                        Console.WriteLine();
                                        Console.ForegroundColor = ConsoleColor.White;
                                        LightHouseQ5 = Console.ReadLine();
                                        Console.WriteLine();
                                        LightHouseQ5.ToLower();
                                    }
                                    if (LightHouseQ5 == "n")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Clear();
                                        Console.WriteLine("You leave the fuse in your pocket and decide to worry about it some");
                                        Console.WriteLine("other time. You take one last look out into the night, and then head");
                                        Console.WriteLine("back down to street level.");
                                    }
                                    if (LightHouseQ5 == "y")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.Clear();
                                        Console.WriteLine("You insert the fuse into the fuse box and are nearly blinded as the light");
                                        Console.WriteLine("from the lighthouse turns on. After your eyes adjust, you take another");
                                        Console.WriteLine("look around the island -- walking a circle around the tower to follow the");
                                        Console.WriteLine("beam of light.");
                                        Console.WriteLine();
                                        Console.WriteLine("The light seems to be drawn to specific spots scattered about the island,");
                                        Console.WriteLine("spots you didn't notice previously from ground level. You're certain that");
                                        Console.WriteLine("if you were to search these places again, you might find some more");
                                        Console.WriteLine("MacGuffins scattered about.");
                                        if (!Title.bAchievement11)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Title.bAchievement11 = true;
                                            Console.WriteLine("   Secret Discovered: " + Title.sAchievement11);
                                        }
                                        bLightHouseUsed = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
        }
        
        public static void StoryAtTheChurch() // 11
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The island's lone church, dedicated to the catholic faith, is largely");
            Console.WriteLine("unused, even on Sundays. Locals of the catholic faith, and other");
            Console.WriteLine("religions, commonly drive inland for their faith-based services.");
            Console.WriteLine("However, come Christmas or Easter, locals pack into the church as if");
            Console.WriteLine("they were regulars. The church sits at the center of a large parking lot,");
            Console.WriteLine("nestled in between Ocean Street and the southeast beach.");
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 11)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("Just inside the church's main door is a table. On it is an opened visitor's");
                Console.WriteLine("guest book. Between the opened pages of the sign-in book is a pocket-");
                Console.WriteLine("sized bible. You look around but don't see any other similar bibles. This");
                Console.WriteLine("must be the one the bunny placed.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the bible? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sChurchGift = Console.ReadLine();
                Console.WriteLine();
                sChurchGift.ToLower();
                while (sChurchGift != "y" && sChurchGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sChurchGift = Console.ReadLine();
                    Console.WriteLine();
                    sChurchGift.ToLower();
                }
                if (sChurchGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the bible and place it in your pocket. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation11EncounterBlocker = true;
                }
                if (sChurchGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the bible where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this bible to " + TheBunny.sClueNPC + ".");
                }
            }
            if (!bPrayed && !bLocation11EncounterBlocker)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("You walk into the church but find it deserted -- perhaps surprising");
                Console.WriteLine("considering the events currently plaguing the island. Along the back");
                Console.WriteLine("wall, you notice a flicker of light coming from a display of votive candles.");
                Console.WriteLine("You walk down the center aisle past the pews and approach the prayer");
                Console.WriteLine("candles. You notice a stylishly hand-written sign next to the display.");
                Console.WriteLine();
                Console.WriteLine("It reads: 'To those who would light a candle, please tithe generously.");
                Console.WriteLine("We exist solely by the grace of your support.'");
                Console.WriteLine();
                Console.WriteLine("Below that, in smaller print, it reads: 'All donations welcomed, but 10%");
                Console.WriteLine("of what you make is a great place to start!'");
                Console.WriteLine();
                Console.WriteLine("Finally, hastily scrawled, diagonally on the right side, there's a newer");
                Console.WriteLine("addition: 'For ten MacGuffins, we pray for those who have been lost.");
                Console.WriteLine("Our results are guaranteed to be miraculous!'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You currently have " + Variables.iFoundMacGuffins + " MacGuffins.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to donate any MacGuffins? (Enter a number, or '0' to decline.)");
                Console.WriteLine("Resolving this encounter requires no additional time.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out iTithe);
                while (iTithe > Variables.iFoundMacGuffins)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("That's very generous of you. However, it's also more than you have.");
                    Console.WriteLine("Please enter a new number of MacGuffins to tithe.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("(Enter a number, or '0' to decline.)");
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine(), out iTithe);
                }
                if (iTithe > 0)
                {
                    bPrayed = true;
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins - iTithe;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("You opt to donate " + iTithe + " MacGuffins. You see that there's a tin box with a");
                    Console.WriteLine("small opening at the top, where the wedge-shaped coins can clink through into the");
                    Console.WriteLine("drop box. You then grab one of the provided sticks and use it to light a");
                    Console.WriteLine("candle. After it's lit, you think about who to pray for.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Lost " + iTithe + " MacGuffins.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter a name:");
                    Console.WriteLine();
                    sPrayFor = Console.ReadLine();

                    // No error correcting here! People could pray for "the return to life of Ronald Reagan" if they wanted. :p
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("You spend a moment praying for that person while watching the candle");
                    Console.WriteLine("burn. The flame is small, but comforting to watch. You wonder if there");
                    Console.WriteLine("is any truth to the idea that there will be a miracle involving " + sPrayFor + ".");
                    if (iTithe > 10)
                    {
                        if (sPrayFor.ToLower() == NPC_AI.NPC_001.ToLower()) { NPC_AI.bCorpse001 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_002.ToLower()) { NPC_AI.bCorpse002 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_003.ToLower()) { NPC_AI.bCorpse003 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_004.ToLower()) { NPC_AI.bCorpse004 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_005.ToLower()) { NPC_AI.bCorpse005 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_006.ToLower()) { NPC_AI.bCorpse006 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_007.ToLower()) { NPC_AI.bCorpse007 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_008.ToLower()) { NPC_AI.bCorpse008 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_009.ToLower()) { NPC_AI.bCorpse009 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_010.ToLower()) { NPC_AI.bCorpse010 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_011.ToLower()) { NPC_AI.bCorpse011 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_012.ToLower()) { NPC_AI.bCorpse012 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_013.ToLower()) { NPC_AI.bCorpse013 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_014.ToLower()) { NPC_AI.bCorpse014 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_015.ToLower()) { NPC_AI.bCorpse015 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_016.ToLower()) { NPC_AI.bCorpse016 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_017.ToLower()) { NPC_AI.bCorpse017 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_018.ToLower()) { NPC_AI.bCorpse018 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_019.ToLower()) { NPC_AI.bCorpse019 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_020.ToLower()) { NPC_AI.bCorpse020 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_021.ToLower()) { NPC_AI.bCorpse021 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_022.ToLower()) { NPC_AI.bCorpse022 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_023.ToLower()) { NPC_AI.bCorpse023 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_024.ToLower()) { NPC_AI.bCorpse024 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_025.ToLower()) { NPC_AI.bCorpse025 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_026.ToLower()) { NPC_AI.bCorpse026 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_027.ToLower()) { NPC_AI.bCorpse027 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_028.ToLower()) { NPC_AI.bCorpse028 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_029.ToLower()) { NPC_AI.bCorpse029 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_030.ToLower()) { NPC_AI.bCorpse030 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_031.ToLower()) { NPC_AI.bCorpse031 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_032.ToLower()) { NPC_AI.bCorpse032 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_033.ToLower()) { NPC_AI.bCorpse033 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_034.ToLower()) { NPC_AI.bCorpse034 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_035.ToLower()) { NPC_AI.bCorpse035 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_036.ToLower()) { NPC_AI.bCorpse036 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_037.ToLower()) { NPC_AI.bCorpse037 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_038.ToLower()) { NPC_AI.bCorpse038 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_039.ToLower()) { NPC_AI.bCorpse039 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_040.ToLower()) { NPC_AI.bCorpse046 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_041.ToLower()) { NPC_AI.bCorpse041 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_042.ToLower()) { NPC_AI.bCorpse042 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_043.ToLower()) { NPC_AI.bCorpse043 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_044.ToLower()) { NPC_AI.bCorpse044 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_045.ToLower()) { NPC_AI.bCorpse045 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_046.ToLower()) { NPC_AI.bCorpse046 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_047.ToLower()) { NPC_AI.bCorpse047 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_048.ToLower()) { NPC_AI.bCorpse048 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_049.ToLower()) { NPC_AI.bCorpse049 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_050.ToLower()) { NPC_AI.bCorpse050 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_051.ToLower()) { NPC_AI.bCorpse051 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_052.ToLower()) { NPC_AI.bCorpse052 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_053.ToLower()) { NPC_AI.bCorpse053 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_054.ToLower()) { NPC_AI.bCorpse054 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_055.ToLower()) { NPC_AI.bCorpse055 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_056.ToLower()) { NPC_AI.bCorpse056 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_057.ToLower()) { NPC_AI.bCorpse057 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_058.ToLower()) { NPC_AI.bCorpse058 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_059.ToLower()) { NPC_AI.bCorpse059 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_060.ToLower()) { NPC_AI.bCorpse060 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_061.ToLower()) { NPC_AI.bCorpse061 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_062.ToLower()) { NPC_AI.bCorpse062 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_063.ToLower()) { NPC_AI.bCorpse063 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_064.ToLower()) { NPC_AI.bCorpse064 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_065.ToLower()) { NPC_AI.bCorpse065 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_066.ToLower()) { NPC_AI.bCorpse066 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_067.ToLower()) { NPC_AI.bCorpse067 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_068.ToLower()) { NPC_AI.bCorpse068 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_069.ToLower()) { NPC_AI.bCorpse069 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_070.ToLower()) { NPC_AI.bCorpse070 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_071.ToLower()) { NPC_AI.bCorpse071 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_072.ToLower()) { NPC_AI.bCorpse072 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_073.ToLower()) { NPC_AI.bCorpse073 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_074.ToLower()) { NPC_AI.bCorpse074 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_075.ToLower()) { NPC_AI.bCorpse075 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_076.ToLower()) { NPC_AI.bCorpse076 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_077.ToLower()) { NPC_AI.bCorpse077 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_078.ToLower()) { NPC_AI.bCorpse078 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_079.ToLower()) { NPC_AI.bCorpse079 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_080.ToLower()) { NPC_AI.bCorpse080 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_081.ToLower()) { NPC_AI.bCorpse081 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_082.ToLower()) { NPC_AI.bCorpse082 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_083.ToLower()) { NPC_AI.bCorpse083 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_084.ToLower()) { NPC_AI.bCorpse084 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_085.ToLower()) { NPC_AI.bCorpse085 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_086.ToLower()) { NPC_AI.bCorpse086 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_087.ToLower()) { NPC_AI.bCorpse087 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_088.ToLower()) { NPC_AI.bCorpse088 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_089.ToLower()) { NPC_AI.bCorpse089 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_090.ToLower()) { NPC_AI.bCorpse090 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_091.ToLower()) { NPC_AI.bCorpse091 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_092.ToLower()) { NPC_AI.bCorpse092 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_093.ToLower()) { NPC_AI.bCorpse093 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_094.ToLower()) { NPC_AI.bCorpse094 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_095.ToLower()) { NPC_AI.bCorpse095 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_096.ToLower()) { NPC_AI.bCorpse096 = false; }
                        if (sPrayFor.ToLower() == NPC_AI.NPC_097.ToLower()) { NPC_AI.bCorpse097 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_098.ToLower()) { NPC_AI.bCorpse098 = false; } if (sPrayFor.ToLower() == NPC_AI.NPC_099.ToLower()) { NPC_AI.bCorpse099 = false; }
                        Lists.RemainingNPCs.Add(sPrayFor);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("You decide to head back outside.");
            }
        }
        
        public static void StoryAtBayStreet() // 12
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Bay Street runs the length of the island from Main Street to the island's");
            Console.WriteLine("eastern end, and parallel to Ocean Street. As the name implies, Bay");
            Console.WriteLine("Street is nestled between the island and the bay, along the island's");
            Console.WriteLine("northern face -- and is the primary route to the abandoned factory and");
            Console.WriteLine("the golf course.");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 10)
            {
                Console.WriteLine();
                Console.WriteLine("You found the thing that " + TheBunny.sClueNPC + " wanted. Find the person to get the final clue.");
                TheBunny.iBunnyGift = 2;
            }
        }
        
        public static void StoryAtTheDocks() // 13
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The docks are very popular amongst locals in the summer, despite the");
            Console.WriteLine("two prominent beaches, and where people often meet up for picnics");
            Console.WriteLine("and barbecues, along with water skiing and tubing. Despite the name,");
            Console.WriteLine("there are no actual docks. There's a medium-sized storage facility, a");
            Console.WriteLine("small lodge, and a ramp that leads into the water to allow trucks to back");
            Console.WriteLine("boats into the water.");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 13)
            {
                Console.WriteLine();
                Console.WriteLine("You walk around the docks are looking for the gift that the bunny may");
                Console.WriteLine("have left here. In the middle of the boat ramp that leads down into the");
                Console.WriteLine("water is a keychain. There are no keys, but there is a tiny pair of skis.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the keychain? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sDocksGift = Console.ReadLine();
                Console.WriteLine();
                sDocksGift.ToLower();
                while (sDocksGift != "y" && sDocksGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sDocksGift = Console.ReadLine();
                    Console.WriteLine();
                    sDocksGift.ToLower();
                }
                if (sDocksGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the keychain and place it in your pocket. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation13EncounterBlocker = true;
                }
                if (sDocksGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the keychain where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this keychain to " + TheBunny.sClueNPC + ".");
                }
            }
            // If player has option to do something                                    
            if (!bNumber1Found && !bLocation13EncounterBlocker)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("Stapled to the storage facility's exterior is a full-sized poster. It's white in");
                Console.WriteLine("color, and appears to be blank.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to look more closely? (y)es or (n)o?");
                Console.WriteLine();
                string Paper1 = Console.ReadLine();
                Console.WriteLine();
                Paper1.ToLower();
                while (Paper1 != "y" && Paper1 != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Paper1 = Console.ReadLine();
                    Paper1.ToLower();
                    Console.WriteLine();
                }
                if (Paper1 == "y")
                {
                    bNumber1Found = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("At the very center of the poster in small print is the number " + iCombo1 + ".");
                    Console.WriteLine("Underneath the number is the word 'first' -- repeatedly underlined.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   You record the number in your notebook.");
                    Notebook.iNotebookHasInfo++;
                }
                else if (Paper1 == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You wonder why someone would staple a blank poster to a wall.");
                }
            }
        }
        
        public static void StoryAtThePoliceStation() // 14
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Crime was never a pressing concern for the tourists or the locals alike,");
            Console.WriteLine("so this tiny police station looks like the kind you might see in a movie --");
            Console.WriteLine("a large, open interior with the few cells against the rear wall set-up to");
            Console.WriteLine("allow the occasional bothersome drunks to sleep off a rough night.");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 14)
            {
                Console.WriteLine();
                Console.WriteLine("You walk up to the police station, wondering if this is the right place to");
                Console.WriteLine("find the gift that the bunny left behind, when you see it: a kid's police");
                Console.WriteLine("badge with a small bow stuck to its front. This has to be it.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the badge? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sPoliceGift = Console.ReadLine();
                Console.WriteLine();
                sPoliceGift.ToLower();
                while (sPoliceGift != "y" && sPoliceGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sPoliceGift = Console.ReadLine();
                    Console.WriteLine();
                    sPoliceGift.ToLower();
                }
                if (sPoliceGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the badge and place it in your pocket. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation14EncounterBlocker = true;
                }
                if (sPoliceGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the badge where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this badge to " + TheBunny.sClueNPC + ".");
                }
            }
            if (Variables.iRemainingTurns < Variables.iTurn35 && !bLocation14EncounterBlocker)
            {
                Console.WriteLine();
                Console.WriteLine("There is a thick chain wrapped around the doors. There appears to be");
                Console.WriteLine("no way to get inside the police station.");
            }
            if (Variables.weaponName == NPC_AI.sWeaponType0 && Variables.iRemainingTurns <= Variables.iTurn20 && Variables.iRemainingTurns >= Variables.iTurn35 && Lists.TalkingNPCs.Count >= 1 && !bLocation10EncounterBlocker)
            {
                int iCopper = Program.rand.Next(Lists.TalkingNPCs.Count);
                string sCopper = Lists.TalkingNPCs[iCopper];
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine(sCopper + " motions you over and says, 'Hey, what are you looking for? You");
                Console.WriteLine("looking for something to protect yourself with?'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to ask what " + sCopper + " has to offer? (y)es or (n)o?");
                Console.WriteLine("Resolving this encounter requires no additional time.");
                Console.WriteLine();
                string FreeGuns = Console.ReadLine();
                Console.WriteLine();
                FreeGuns.ToLower();
                while (FreeGuns != "y" && FreeGuns != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    FreeGuns = Console.ReadLine();
                    Console.WriteLine();
                    FreeGuns.ToLower();
                }
                if (FreeGuns == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'There's not much. The guns and ammo are all locked away, I guess. I");
                    Console.WriteLine("can't find anything to get into those lockers. But there were a few");
                    Console.WriteLine("unlocked cabinets with these truncheons in them. Here, take this.");
                    Console.WriteLine("It's like a billy club or something. Right? A person could do worse.'");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Gained a " + NPC_AI.sWeaponType4 + ".");
                    Variables.weaponName = NPC_AI.sWeaponType4;
                    Variables.foundWeapon = true;
                }
                if (FreeGuns == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Just checking the place out then? Well, have at it. But if you decide");
                    Console.WriteLine("you're looking for a weapon, there's plenty here to grab. Nothing fancy,");
                    Console.WriteLine("unfortunately, but decent enough to protect yourself.'");
                }
            }
        }
        
        public static void StoryAtTheAbandonedFactory() // 15
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This factory was completed in 1963, part of an effort to make good on");
            Console.WriteLine("the promise of a mineral-rich ocean floor along the coast. The");
            Console.WriteLine("investment in the plant brought in thousands of workers and powered");
            Console.WriteLine("the island to economic success. However, the cost of operation against");
            Console.WriteLine("minimal returns led to the shutdown of this factory, and many like it");
            Console.WriteLine("elsewhere, just ten years later. While much of the equipment inside was");
            Console.WriteLine("sold off, the building itself has been largely undisturbed.");
        }
        
        public static void StoryAtThePostOffice() // 16
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This post office is large, although most of it is roped off and closed");
            Console.WriteLine("thanks to the island's reduced population. During the day, one, or two");
            Console.WriteLine("during peak hours, clerks manage the customers. A half-dozen mail");
            Console.WriteLine("trucks manage delivery to the island's residents.");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 16)
            {
                Console.WriteLine();
                Console.WriteLine("There's a table in the middle of the lobby with various pamphlets and");
                Console.WriteLine("forms. There's also an adjustable time/date stamp that looks to have");
                Console.WriteLine("never been used. This has to be the gift the bunny left for you to find.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the stamper? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sPostOfficeGift = Console.ReadLine();
                Console.WriteLine();
                sPostOfficeGift.ToLower();
                while (sPostOfficeGift != "y" && sPostOfficeGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sPostOfficeGift = Console.ReadLine();
                    Console.WriteLine();
                    sPostOfficeGift.ToLower();
                }
                if (sPostOfficeGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the stamper and place it in your pocket. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation16EncounterBlocker = true;
                }
                if (sPostOfficeGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the stamper where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this stamper to " + TheBunny.sClueNPC + ".");
                }
            }
            if (!bLightHouseFuse && !bLocation16EncounterBlocker)
            {
                Console.WriteLine();
                Console.WriteLine("The post office is curiously unlocked considering that no one is around");
                Console.WriteLine("within. You walk into the lobby area and see the clerks' desk, as well as");
                Console.WriteLine("several PO Boxes, stamp machines, and packing supplies. The back");
                Console.WriteLine("rooms are all locked. It does not appear that there's anything else you");
                Console.WriteLine("can do in here.");
                if (bCourtHouseKey)
                {
                    Console.WriteLine();
                    Console.WriteLine("And then you remember the key that you found at the golf course. You");
                    Console.WriteLine("take another look at the key and see that it, thankfully, has a number");
                    Console.WriteLine("written on it -- #306 -- that matches with one of the PO Boxes.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Would you like to open it? (y)es or (n)o?");
                    Console.WriteLine("Resolving this encounter requires no additional time.");
                    Console.WriteLine();
                    string POBox = Console.ReadLine();
                    Console.WriteLine();
                    POBox.ToLower();
                    while (POBox != "y" && POBox != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        POBox = Console.ReadLine();
                        POBox.ToLower();
                        Console.WriteLine();
                    }
                    if (POBox == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You open PO Box #306 and find a fuse within. You hold the fuse in your");
                        Console.WriteLine("hand and look at it thoughtfully for a moment. Why would someone");
                        Console.WriteLine("leave a fuse in here? The fuse is black with steel caps on either end. Flat");
                        Console.WriteLine("copper protrusions stick out from the steel caps.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   Gained a fuse.");
                        bLightHouseFuse = true;
                    }
                    if (POBox == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("That doesn't belong to me, you think. Further, this key doesn't belong to");
                        Console.WriteLine("me. But you can't just leave the key here for anyone to find. If I live to");
                        Console.WriteLine("see tomorrow, you promise, I'll try to track down the owner. Maybe I");
                        Console.WriteLine("can place an ad in the local paper. 'I have your PO Box key,' you'd write.");
                        Console.WriteLine("u'If you can describe it, it's yours.' Yeah, that sounds like a good plan.");
                    }
                }
            }
            
        }
        
        public static void StoryAtTheCourthouse() // 17
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The courthouse operates Tuesday and Wednesday nights from 4pm to");
            Console.WriteLine("8pm, and handles small claims disputes, traffic violations, and other");
            Console.WriteLine("minor affairs. The court's -- and the judge who still presides to this day --");
            Console.WriteLine("claim to fame came in 1986 when it tried a local citizen accused of ");
            Console.WriteLine("murdering three young women who were vacationing at the island.");
            Console.WriteLine("However, the trial was moved to a more established court four days ");
            Console.WriteLine("after the trial began. While it's generally assumed the man was guilty, ");
            Console.WriteLine("that he was declared guilty by another court created the impression");
            Console.WriteLine("amongst the locals that justice was not served, a grudge still brought up");
            Console.WriteLine("on occasion by the elder locals.");
            Console.ForegroundColor = ConsoleColor.Gray;
            if (TheBunny.iBunnyGift == 1 && Variables.iRemainingTurns > Variables.iTurn50 && TheBunny.iGiftLocation == 17)
            {
                Console.WriteLine();
                Console.WriteLine("In the waiting area, on a seat, you see an over-sized blow-up gavel. On");
                Console.WriteLine("the side of the gavel is written 'Overruled!' in large, colorful, blocky");
                Console.WriteLine("letters. This has to be the gift the bunny left behind for you to find.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Would you like to take the blow-up gavel? (y)es or (n)o?");
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                string sCourtHouseGift = Console.ReadLine();
                Console.WriteLine();
                sCourtHouseGift.ToLower();
                while (sCourtHouseGift != "y" && sCourtHouseGift != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    sCourtHouseGift = Console.ReadLine();
                    Console.WriteLine();
                    sCourtHouseGift.ToLower();
                }
                if (sCourtHouseGift == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You grab the blow-up gavel. Now, where to find");
                    Console.WriteLine(TheBunny.sClueNPC + ".");
                    TheBunny.iBunnyGift = 2;
                    bLocation17EncounterBlocker = true;
                }
                if (sCourtHouseGift == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You leave the blow-up gavel where it is. However, if you want the bunny's third");
                    Console.WriteLine("clue you know that you'll need to take this blow-up gavel to " + TheBunny.sClueNPC + ".");
                }
            }
            if (!bCourtHouseKey && !bLocation17EncounterBlocker)
            {
                Console.WriteLine();
                Console.WriteLine("The courtroom is locked off, but the lobby is open and accessible.");
                Console.WriteLine("Unfortunately, there really isn't too much here to look at. You see a");
                Console.WriteLine("clerk's window with a paper clock on it that reads 'We'll be back at,' and");
                Console.WriteLine("'8:45 PM!' is hand-written in.");
                Console.WriteLine();
                Console.WriteLine("There's a clipboard in front of the window, tied to the window with");
                Console.WriteLine("string. You notice a key on the clipboard. The key looks like a normal");
                Console.WriteLine("key, but on its head is written the number 306.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Gained a key.");
                bCourtHouseKey = true;
            }
        }
        
        public static void StoryAtTheWaterTower() // 18
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This large, blue water tower features a prominent yellow smiley-face on");
            Console.WriteLine("its side, facing westward. Generally speaking, its placement marks the");
            Console.WriteLine("end of civilization on the island. Only the golf course stands out");
            Console.WriteLine("amongst the dunes, sprawling southeast beach, hiking trails, and the");
            Console.WriteLine("boardwalk when going east from here.");
        }
        
        public static void StoryAtTheGolfCourse() // 19
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The golf course is shut down nearly all year around, but draws huge");
            Console.WriteLine("crowds, from locals and tourists alike, when it's open through July and");
            Console.WriteLine("August -- even on rainy days. During the off-season, local teens");
            Console.WriteLine("occasionally come to drink or mingle.");
            if (!bGolfCourseKey)
            {
                Console.WriteLine();
                Console.WriteLine("As you walk up to the door to the club house, you notice a key jammed");
                Console.WriteLine("into the door. You try to turn the key in the lock, but it doesn't work; it");
                Console.WriteLine("seems like this isn't the right key for this door. You wonder why");
                Console.WriteLine("someone would have put the key here.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Gained a key.");
                bGolfCourseKey = true;
            }
        }
        
        public static void StoryAtTheHikingTrails() // 20
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The hiking trails, as a name, may sound more impressive than it actually");
            Console.WriteLine("is. This small network of paths can be navigated in a short afternoon,");
            Console.WriteLine("and the thinly-positioned trees afford easy viewing through to the");
            Console.WriteLine("nearby golf course or southeast beach. The hiking trails are most");
            Console.WriteLine("commonly frequented in the early morning hours by older folk looking");
            Console.WriteLine("to keep in shape with a good walk.");
        }
        
        public static void StoryAtOceanStreet() // 21
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The twin streets Ocean and Bay run from the end of Main Street at the ");
            Console.WriteLine("lighthouse eastward to the island's end, and run a mere three blocks");
            Console.WriteLine("apart at most spots. Bay Street sits on the island's north face, while");
            Console.WriteLine("Ocean runs along the southern side. While Bay Street leads to popular");
            Console.WriteLine("destinations like the golf course, the docks, and the civic center (the");
            Console.WriteLine("courthouse, post office, and police station) Ocean Street leads to the");
            Console.WriteLine("lesser-frequented church, the southeastern beach, and its boardwalk.");
            Console.WriteLine("That said, many of the island's nicer homes are built along the beach,");
            Console.WriteLine("just off Ocean Street -- and, unlike Bay Street, Ocean Street rarely");
            Console.WriteLine("floods.");
            // If player has option to do something
            if (!bNumber3Found)
            {
                Console.WriteLine();
                Console.WriteLine("The breeze coming in off the ocean is cool and calming. As you take a");
                Console.WriteLine("moment to enjoy it, you see a piece of paper being held by the wind");
                Console.WriteLine("against a braided trash can.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to look at the paper? (y)es or (n)o?");
                Console.WriteLine();
                string Paper3 = Console.ReadLine();
                Console.WriteLine();
                Paper3.ToLower();
                while (Paper3 != "y" && Paper3 != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Paper3 = Console.ReadLine();
                    Console.WriteLine();
                    Paper3.ToLower();
                }
                if (Paper3 == "y")
                {
                    bNumber3Found = true;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("The paper makes a desperate flapping sound as you pry it away from");
                    Console.WriteLine("the wind and the trash can. The number " + iCombo3 + " is written on it with crayon");
                    Console.WriteLine("and thick, wobbly, colored-in lines. You throw the paper away after first");
                    Console.WriteLine("recording it into your notebook.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   You record the number in your notebook.");
                    if (!bNumber2Found) { iNumberFoundFirst = 3; }
                    Notebook.iNotebookHasInfo++;
                }
                else if (Paper3 == "n")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You ignore the piece of paper.");
                }
            }
        }
        
        public static void StoryAtTheBoardwalk() // 22
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dubbed the Ocean Overlook when it was built, the name never caught");
            Console.WriteLine("on and locals always referred to it the boardwalk. Unlike traditional");
            Console.WriteLine("boardwalks, this walk is concrete and features no efforts at tourism. The");
            Console.WriteLine("boardwalk stands about seven feet above sea level. It runs parallel to");
            Console.WriteLine("Ocean Street for four blocks, then turns southward to sea, stopping");
            Console.WriteLine("after about 30 feet at the water's edge. Its bend is a short walk west");
            Console.WriteLine("from the jetty.");
        }
        
        public static void StoryAtTheDunes() // 23
        {
            if (!bDontAuto23)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("The dunes are labyrinthine and difficult to traverse due to their steep");
                Console.WriteLine("slopes and soft sand. The dunes are covered in weeds and tall grass, and");
                Console.WriteLine("broken up by small trees. Because of the maze-like layout, the dunes are");
                Console.WriteLine("one of the more popular areas for teens to engage in illegal activities.");
                Console.WriteLine("It's also where the island's wildlife hides out; it's not uncommon to see");
                Console.WriteLine("foxes and other similar critters. A dirt path has been made through the");
                Console.WriteLine("dunes, barely wide enough for four-wheel drive vehicles to get through.");
            }
        }
        
        public static void StoryAtTheSEBeach() // 24
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The southeast beach is sprawling, and protected from any kind of");
            Console.WriteLine("development by wildlife conservationists. Because of the hike through");
            Console.WriteLine("the dunes required to get here, the southeast beach is largely ignored");
            Console.WriteLine("by all but the locals -- making it somewhat of a hidden treasure. During");
            Console.WriteLine("the summer, the city sells licenses to allow four-wheel drive vehicles to");
            Console.WriteLine("cruise the beach. Licenses are not advertised and carry the pre-requisite");
            Console.WriteLine("of owning a property on the island -- though established renters (read:");
            Console.WriteLine("locals only) are given exceptions.");
        }
        
        public static void StoryAtTheJetty() // 25
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The jetty is made up of huge rocks that walk out into the ocean to a");
            Console.WriteLine("distance of about a hundred yards. The path is rugged and relatively");
            Console.WriteLine("thin. Crashing waves keep it slippery, but it's not overly difficult to");
            Console.WriteLine("traverse. On normal days, locals hike out to the jetty's end to set crab");
            Console.WriteLine("traps or fish.");
            if (Variables.iCurrentLocation == 25 && Variables.iRemainingTurns <= Variables.iTurn50) { bUsableLocation025 = true; }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("It looks like you could walk out to the end of jetty. (y)es or (n)o?");
            Console.WriteLine("Resolving this encounter requires no additional time.");
            Console.WriteLine();
            string Response = Console.ReadLine();
            Console.WriteLine();
            Response.ToLower();
            while (Response != "y" && Response != "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Response = Console.ReadLine();
                Console.WriteLine();
                Response.ToLower();
            }
            if (Response == "n")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You decide not to walk out on the jetty.");
            }
            if (Response == "y")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You wander down the jetty's length, doing your best to watch your");
                Console.WriteLine("footing and not get caught up by the impressiveness of the tidal waves");
                Console.WriteLine("looming mere feet from the jetty's end. By the time you reach the");
                Console.WriteLine("walk's end, your ears are numb from the extreme volume and you've");
                Console.WriteLine("accidentally swallowed salty water from more than a couple crashing");
                Console.WriteLine("waves. The wind is rougher out here, and reinforces the feeling that you");
                Console.WriteLine("are standing at the edge of nature's fury; at any moment the waves");
                Console.WriteLine("could resume their forward momentum, and their rage would leave");
                Console.WriteLine("nothing behind.");
                Console.WriteLine();
                if (bUsableLocation025 && Variables.iFoundMacGuffins >= 5)
                {
                    Console.WriteLine("You reach the end of the jetty. Mist and wind dashes against your face");
                    Console.WriteLine("from the ocean wave standing tall before you. The noise is deafening");
                    Console.WriteLine("but under it you hear a clink-clink-clink sound, then notice agitation");
                    Console.WriteLine("within your pocket. You reach in and pull out a single MacGuffin. Held");
                    Console.WriteLine("up toward the nearby tidal wave, the coin vibrates so aggressively it");
                    Console.WriteLine("nearly flies from between your fingers.");
                    Console.WriteLine();
                    Console.WriteLine("You reach back into your pocket and hold all the coins in your hand,");
                    Console.WriteLine("then hold your hand out toward the wave. A surge of energy courses");
                    Console.WriteLine("through your hand, numbing your upper-arm, shoulder, and neck. The");
                    Console.WriteLine("coins are bursting within your hand, and every instinct screams at you");
                    Console.WriteLine("to release them. If you ever wanted to escape the island, it appears");
                    Console.WriteLine("now might be the time.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Open your hand and release your MacGuffins? (y)es or (n)o?");
                    Console.WriteLine();
                    string QuitGame = Console.ReadLine();
                    Console.WriteLine();
                    QuitGame.ToLower();
                    while (QuitGame != "y" && QuitGame != "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        QuitGame = Console.ReadLine();
                        QuitGame.ToLower();
                        Console.WriteLine();
                    }
                    if (QuitGame == "y")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You take a steadying breath, close your eyes, and then open them. As");
                        Console.WriteLine("you do, the coins fly out of your hands and into the tidal wave.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("A moment passes, then another. You look back over your shoulder and");
                        Console.WriteLine("see " + NPC_AI.NPC_100 + " standing at the foot of the jetty -- watching with apparent");
                        Console.WriteLine("curiosity, but not following. As you make distant eye contact, there's a");
                        Console.WriteLine("sound like a giant slab of concrete splitting in half. The sound pushes its");
                        Console.WriteLine("way through you, knocking you down against the wet, slippery rocks.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("You turn back and look at the wave. A faint golden light suddenly");
                        Console.WriteLine("shimmers within, then slowly fades away. As it does, you notice that the");
                        Console.WriteLine("sound from the tidal wave grows faint, and then is gone completely.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("A watery ramp falls out from the wave, solidifying at your feet. It leads");
                        Console.WriteLine("up toward an opening in the wave itself -- a tall, wide, arched opening");
                        Console.WriteLine("that makes you think of the entranceway to some medieval castle.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("You carefully step up onto the watery ramp, then take another step.");
                        Console.WriteLine("Part of you wants to look back, but instead you push forward. A few");
                        Console.WriteLine("more steps and you're under the arch and staring into blackness.");
                        Console.WriteLine("Another step, and the opening falls closed behind you, and you're left to");
                        Console.WriteLine("push through the darkness to where it may lead.");
                        if (!Title.bAchievement05)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Title.bAchievement05 = true;
                            Console.WriteLine("   Secret Discovered: " + Title.sAchievement05);
                        }
                        Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                    }
                    else if (QuitGame == "n")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("With some effort, you force your hand, and the MacGuffins, back into");
                        Console.WriteLine("your pocket. You decide that now is not the time to leave the island.");
                    }
                }
            }
        }
    }
}