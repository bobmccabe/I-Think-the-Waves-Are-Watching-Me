using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Movement
    {
        public static int iNPCMove;
        public static bool ValidMove;

        public static void Initialize_Movement()
        {
            iNPCMove = 0;
            ValidMove = true;
        }

        public static void Option_LetsGetMoving()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            while (Variables.waitMove)
            {
                Program.Display_UIHeader();

                Flood.HereComesTheFlood();

                Console.ForegroundColor = ConsoleColor.White;
                if (Variables.bAboutToDie == true)
                {
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("As fast as you can, you run to a new location.");
                    TheBunny.bHurry = true;
                }

                AvailableMapByStage();

                int moveLocation = 1;


                //do{
                //  Console.WriteLine("Please enter a integer value:");
                //  string input = Console.ReadLine();
                //  if(Int.TryParse(input, out parsedValue))
                //    If try parse returned true, this was a proper value
                //    validEntry = true;
                //  else
                //    try parse returend false. The user entered garbage
                //    Console.WriteLine("The text '" + input + "' is not a valid integer. Please try again");
                //}while(!validEntry)


                if (int.TryParse(Console.ReadLine(), out moveLocation))
                {
                    if (moveLocation == Variables.iCurrentLocation)
                    {
                        if (Variables.bAboutToDie == true)
                        {
                            if (Variables.weaponName == NPC_AI.sWeaponType0)
                            {
                                Console.Clear();
                                Console.WriteLine("You run-and-run, and do not stop running for some time. If you can just");
                                Console.WriteLine("keep running, you think, you'll get there and things will be OK. But then");
                                Console.WriteLine("a nagging thought creeps in your head: where is there? Did you ever");
                                Console.WriteLine("decide? You force your eyes to open a sliver and find that you're lying");
                                Console.WriteLine("down on the ground. It doesn't seem like it should be, but it's so");
                                Console.WriteLine("comfortable. You close your eyes again, comfort flowing through you.");
                                Variables.playerSurvived = Variables.sPlayerState1;
                                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                                break;
                            }
                            else if (Variables.weaponName != NPC_AI.sWeaponType0)
                            {
                                Console.Clear();
                                Console.WriteLine("You run-and-run, and do not stop running for some time. If you can just");
                                Console.WriteLine("keep running, you think, you'll get there and things will be OK. But then");
                                Console.WriteLine("a nagging thought creeps in your head: where is there? Did you ever");
                                Console.WriteLine("decide? You force your eyes to open a sliver and find that you're lying");
                                Console.WriteLine("down on the ground. The texture of the " + Variables.weaponName + " in your hand reminds you");
                                Console.WriteLine("of what is happening. You sit up and toss it at " + NPC_AI.NPC_100 + ". It connects and");
                                Console.WriteLine("you feel a small wave of energy surge through you. You have a second");
                                Console.WriteLine("chance to run, if you would take it.");
                                Variables.weaponName = NPC_AI.sWeaponType0;
                            }
                        }
                        else if (Variables.bAboutToDie == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You are already at " + Variables.sGetLocation);
                            Variables.waitMove = false;
                        }
                    }
                    else if (
                    moveLocation != 0 && moveLocation != 1 && moveLocation != 2 && moveLocation != 3 && moveLocation != 4 &&
                    moveLocation != 5 && moveLocation != 6 && moveLocation != 7 && moveLocation != 8 && moveLocation != 9 &&
                    moveLocation != 10 && moveLocation != 11 && moveLocation != 12 && moveLocation != 13 && moveLocation != 14 &&
                    moveLocation != 15 && moveLocation != 16 && moveLocation != 17 && moveLocation != 18 && moveLocation != 19 &&
                    moveLocation != 20 && moveLocation != 21 && moveLocation != 22 && moveLocation != 23 && moveLocation != 24 &&
                    moveLocation != 25)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid Input. Please choose a number from the list.");
                        Program.PressAnyKey();
                        Console.Clear();
                    }
                    else if (moveLocation == 0)
                    {
                        if (Variables.bAboutToDie == true)
                        {
                            if (Variables.weaponName == NPC_AI.sWeaponType0)
                            {
                                Console.Clear();
                                Console.WriteLine("You run-and-run, and do not stop running for some time. If you can just");
                                Console.WriteLine("keep running, you think, you'll get there and things will be OK. But then");
                                Console.WriteLine("a nagging thought creeps in your head: where is there? Did you ever");
                                Console.WriteLine("decide? You force your eyes to open a sliver and find that you're lying");
                                Console.WriteLine("down on the ground. It doesn't seem like it should be, but it's so");
                                Console.WriteLine("comfortable. You close your eyes again, comfort flowing through you.");
                                Variables.playerSurvived = Variables.sPlayerState1;
                                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                                break;
                            }
                            else if (Variables.weaponName != NPC_AI.sWeaponType0)
                            {
                                Console.Clear();
                                Console.WriteLine("You run-and-run, and do not stop running for some time. If you can just");
                                Console.WriteLine("keep running, you think, you'll get there and things will be OK. But then");
                                Console.WriteLine("a nagging thought creeps in your head: where is there? Did you ever");
                                Console.WriteLine("decide? You force your eyes to open a sliver and find that you're lying");
                                Console.WriteLine("down on the ground. The texture of the " + Variables.weaponName + " in your hand reminds you");
                                Console.WriteLine("of what is happening. You sit up and toss it at " + NPC_AI.NPC_100 + ". It connects and");
                                Console.WriteLine("you feel a small wave of energy surge through you. You have a second");
                                Console.WriteLine("chance to run, if you would take it.");
                                Variables.weaponName = NPC_AI.sWeaponType0;
                            }
                        }
                        else if (Variables.bAboutToDie == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You decide to stick around a while.");
                            Variables.waitMove = false;
                        }
                    }
                    else if (moveLocation == 1 && Variables.iStage >= 1)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 1 && Variables.iStage < 1)
                    {
                        Variables.sGetLocation = LocationEncounters.location_001;
                        Variables.iCurrentLocation = 1;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_001);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_001);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 2 && Variables.iStage >= 2)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 2 && Variables.iStage < 2)
                    {
                        Variables.sGetLocation = LocationEncounters.location_002;
                        Variables.iCurrentLocation = 2; Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_002);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_002);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 3 && Variables.iStage >= 3)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 3 && Variables.iStage < 3)
                    {
                        Variables.sGetLocation = LocationEncounters.location_003;
                        Variables.iCurrentLocation = 3;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_003);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_003);
                            TheBunny.bHurry = false;
                        } Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 4 && Variables.iStage >= 4)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 4 && Variables.iStage < 4)
                    {
                        Variables.sGetLocation = LocationEncounters.location_004;
                        Variables.iCurrentLocation = 4;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_004);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_004);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 5 && Variables.iStage >= 5)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 5 && Variables.iStage < 5)
                    {
                        Variables.sGetLocation = LocationEncounters.location_005;
                        Variables.iCurrentLocation = 5;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_005);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_005);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 6 && Variables.iStage >= 6)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 6 && Variables.iStage < 6)
                    {
                        Variables.sGetLocation = LocationEncounters.location_006;
                        Variables.iCurrentLocation = 6;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_006);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_006);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 7 && Variables.iStage >= 7)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 7 && Variables.iStage < 7)
                    {
                        Variables.sGetLocation = LocationEncounters.location_007;
                        Variables.iCurrentLocation = 7;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_007);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_007);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 8 && Variables.iStage >= 8)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 8 && Variables.iStage < 8)
                    {
                        Variables.sGetLocation = LocationEncounters.location_008;
                        Variables.iCurrentLocation = 8;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_008);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_008);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 9 && Variables.iStage >= 9)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 9 && Variables.iStage < 9)
                    {
                        Variables.sGetLocation = LocationEncounters.location_009;
                        Variables.iCurrentLocation = 9;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_009);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_009);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 10 && Variables.iStage >= 10)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 10 && Variables.iStage < 10)
                    {
                        Variables.sGetLocation = LocationEncounters.location_010;
                        Variables.iCurrentLocation = 10;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_010);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_010);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 11 && Variables.iStage >= 11)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 11 && Variables.iStage < 11)
                    {
                        Variables.sGetLocation = LocationEncounters.location_011;
                        Variables.iCurrentLocation = 11;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_011);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_011);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 12 && Variables.iStage >= 12)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 12 && Variables.iStage < 12)
                    {
                        Variables.sGetLocation = LocationEncounters.location_012;
                        Variables.iCurrentLocation = 12;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_012);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_012);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 13 && Variables.iStage >= 13)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 13 && Variables.iStage < 13)
                    {
                        Variables.sGetLocation = LocationEncounters.location_013;
                        Variables.iCurrentLocation = 13;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_013);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_013);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 14 && Variables.iStage >= 14)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 14 && Variables.iStage < 14)
                    {
                        Variables.sGetLocation = LocationEncounters.location_014;
                        Variables.iCurrentLocation = 14;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_014);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_014);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 15 && Variables.iStage >= 15)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 15 && Variables.iStage < 15)
                    {
                        Variables.sGetLocation = LocationEncounters.location_015;
                        Variables.iCurrentLocation = 15;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_015);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_015);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 16 && Variables.iStage >= 16)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 16 && Variables.iStage < 16)
                    {
                        Variables.sGetLocation = LocationEncounters.location_016;
                        Variables.iCurrentLocation = 16;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_016);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_016);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 17 && Variables.iStage >= 17)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 17 && Variables.iStage < 17)
                    {
                        Variables.sGetLocation = LocationEncounters.location_017;
                        Variables.iCurrentLocation = 17;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_017);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_017);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 18 && Variables.iStage >= 18)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 18 && Variables.iStage < 18)
                    {
                        Variables.sGetLocation = LocationEncounters.location_018;
                        Variables.iCurrentLocation = 18;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_018);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_018);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 19 && Variables.iStage >= 19)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 19 && Variables.iStage < 19)
                    {
                        Variables.sGetLocation = LocationEncounters.location_019;
                        Variables.iCurrentLocation = 19;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_019);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_019);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 20 && Variables.iStage >= 20)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 20 && Variables.iStage < 20)
                    {
                        Variables.sGetLocation = LocationEncounters.location_020;
                        Variables.iCurrentLocation = 20;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_020);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_020);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 21 && Variables.iStage >= 21)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 21 && Variables.iStage < 21)
                    {
                        Variables.sGetLocation = LocationEncounters.location_021;
                        Variables.iCurrentLocation = 21;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_021);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_021);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 22 && Variables.iStage >= 22)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 22 && Variables.iStage < 22)
                    {
                        Variables.sGetLocation = LocationEncounters.location_022;
                        Variables.iCurrentLocation = 22;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_022);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_022);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 23 && Variables.iStage >= 23)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 23 && Variables.iStage < 23)
                    {
                        Variables.sGetLocation = LocationEncounters.location_023;
                        Variables.iCurrentLocation = 23;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_023);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_023);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 24 && Variables.iStage >= 24)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Conversation.sLine800);
                        Program.PressAnyKey();
                    }
                    else if (moveLocation == 24 && Variables.iStage < 24)
                    {
                        Variables.sGetLocation = LocationEncounters.location_024;
                        Variables.iCurrentLocation = 24;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_024);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_024);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                    else if (moveLocation == 25) // area can always be accessed, area never floods.
                    {
                        Variables.sGetLocation = LocationEncounters.location_025;
                        Variables.iCurrentLocation = 25;
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (!TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine801 + LocationEncounters.location_025);
                        }
                        if (TheBunny.bHurry)
                        {
                            Console.WriteLine(Conversation.sLine802 + LocationEncounters.location_025);
                            TheBunny.bHurry = false;
                        }
                        Console.WriteLine();
                        Variables.waitMove = false;
                        Variables.bAboutToDie = false;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input. Please choose a number from the list.");
                    Program.PressAnyKey();
                    Console.Clear();
                }
            }
            Program.PressAnyKey();
        }

        public static void AvailableMapByStage()
        {
            if (Variables.iStage == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("1. The Bridge, 2. Strip Mall/Shops, 3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("2. Strip Mall/Shops, 3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 3)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 4)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 5)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 6)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 7)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 8)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 9)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 10)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 11)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 12)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 13)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 14)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 15)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 16)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 17)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 18)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 19)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 20)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 21)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 22)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 23)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage >= 24 && Variables.iCurrentLocation != 25)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind, and stay where you are.");
                Console.WriteLine();
                Console.WriteLine("25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage >= 24 && Variables.iCurrentLocation == 25)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: There's no where else to go. Everything else is submerged. Stay here.");
                Console.WriteLine();
            }
        }

        public static void AvailableMapByStageForNPCs()
        {
            if (Variables.iStage == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Enter " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("1. Bridge, 2. Strip Mall/Shops, 3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("1. Bridge, 2. Strip Mall/Shops, 3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("2. Strip Mall/Shops, 3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 3)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("3. NW Beach, 4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 4)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("4. Clock Tower, 5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 5)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose your destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("5. Main Street");
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 6)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("6. Bus Terminal, 7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 7)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("7. Downtown/Office District, 8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 8)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("8. Bar, 9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 9)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("9. Apartments, 10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 10)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("10. Lighthouse");
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 11)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("11. Church, 12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 12)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("12. Bay Street, 13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 13)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("13. Docks, 14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 14)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("14. Police Station, 15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 15)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("15. Abandoned Factory");
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 16)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("16. Post Office, 17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 17)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("17. Courthouse, 18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 18)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("18. Water Tower, 19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 19)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("19. Golf Course, 20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 20)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("20. Hiking Trails");
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 21)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("21. Ocean Street, 22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 22)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("22. Boardwalk, 23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 23)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("23. Dunes, 24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 24)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: Change your mind. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
                Console.WriteLine("24. SE Beach, 25. Jetty");
                Console.WriteLine();
            }
            if (Variables.iStage == 25)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Choose " + NPC_AI.tempNPC + "'s destination:"); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("0: There's no where else to go. Tell " + NPC_AI.tempNPC + " to 'Stay where you are.'");
                Console.WriteLine();
            }
        }

        public static void TalkOption_WaitForMeSomewhere()
        {
            NPC_AI.GetAllNPCLocals_WaitSomewhere();

            iNPCMove = 0;
            ValidMove = true;

            Console.WriteLine();
            // if friendly
            if (NPC_AI.iTempLoyalty >= 4)
            {
                while (ValidMove) // Check to make sure the player is offering no more than what they have, and that it's a number. Otherwise, deliver error message.
                {
                    Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'You want me to wait for you somewhere?");

                    Movement.AvailableMapByStageForNPCs();

                    int.TryParse(Console.ReadLine(), out iNPCMove);
                    Console.WriteLine();
                    while (iNPCMove < 0 || iNPCMove > 25)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(NPC_AI.tempNPC + " says, 'Wait, what? Can you say that again?'");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        int.TryParse(Console.ReadLine(), out iNPCMove);
                        Console.WriteLine();
                    }
                    if (iNPCMove == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'I'll go back to doing what I was doing.'");
                        ValidMove = false;
                    }
                    if (NPC_AI.iTempLocation == iNPCMove && ValidMove)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'But we're already there.'");
                        ValidMove = false;
                    }
                    if (iNPCMove <= Variables.iStage && ValidMove)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'That's past the tidal waves! Well, I can try.'");
                        Flood.bPutInDanger = true;
                        Console.WriteLine();
                        if (iNPCMove == 1) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_001; }
                        if (iNPCMove == 2) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_002; }
                        if (iNPCMove == 3) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_003; }
                        if (iNPCMove == 4) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_004; }
                        if (iNPCMove == 5) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_005; }
                        if (iNPCMove == 6) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_006; }
                        if (iNPCMove == 7) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_007; }
                        if (iNPCMove == 8) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_008; }
                        if (iNPCMove == 9) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_009; }
                        if (iNPCMove == 10) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_010; }
                        if (iNPCMove == 11) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_011; }
                        if (iNPCMove == 12) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_012; }
                        if (iNPCMove == 13) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_013; }
                        if (iNPCMove == 14) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_014; }
                        if (iNPCMove == 15) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_015; }
                        if (iNPCMove == 16) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_016; }
                        if (iNPCMove == 17) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_017; }
                        if (iNPCMove == 18) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_018; }
                        if (iNPCMove == 19) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_019; }
                        if (iNPCMove == 20) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_020; }
                        if (iNPCMove == 21) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_021; }
                        if (iNPCMove == 22) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_022; }
                        if (iNPCMove == 23) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_023; }
                        if (iNPCMove == 24) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_024; }
                        if (iNPCMove == 25) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_025; }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(NPC_AI.tempNPC + " just left, and is walking in the direction of " + NPC_AI.sTempCurrentLocation);
                        NPC_AI.iTempLastLocation = NPC_AI.iTempLocation;
                        NPC_AI.iTempLocation = iNPCMove; // Put us where we said we were moving to!
                        // Console.WriteLine("Someone has been put in danger!");
                        ValidMove = false;
                        NPC_AI.iTempDesireToMove = NPC_AI.iTempDesireToMove - (NPC_AI.iDesireRegen * 2);
                    }
                    if (iNPCMove > Variables.iStage && NPC_AI.iTempLocation != iNPCMove && ValidMove)
                    {
                        Flood.bPutInDanger = true;
                        if (iNPCMove == 1) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_001; }
                        if (iNPCMove == 2) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_002; }
                        if (iNPCMove == 3) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_003; }
                        if (iNPCMove == 4) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_004; }
                        if (iNPCMove == 5) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_005; }
                        if (iNPCMove == 6) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_006; }
                        if (iNPCMove == 7) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_007; }
                        if (iNPCMove == 8) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_008; }
                        if (iNPCMove == 9) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_009; }
                        if (iNPCMove == 10) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_010; }
                        if (iNPCMove == 11) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_011; }
                        if (iNPCMove == 12) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_012; }
                        if (iNPCMove == 13) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_013; }
                        if (iNPCMove == 14) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_014; }
                        if (iNPCMove == 15) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_015; }
                        if (iNPCMove == 16) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_016; }
                        if (iNPCMove == 17) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_017; }
                        if (iNPCMove == 18) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_018; }
                        if (iNPCMove == 19) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_019; }
                        if (iNPCMove == 20) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_020; }
                        if (iNPCMove == 21) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_021; }
                        if (iNPCMove == 22) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_022; }
                        if (iNPCMove == 23) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_023; }
                        if (iNPCMove == 24) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_024; }
                        if (iNPCMove == 25) { NPC_AI.sTempCurrentLocation = LocationEncounters.location_025; }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(NPC_AI.tempNPC + " just left, and is walking in the direction of " + NPC_AI.sTempCurrentLocation);
                        NPC_AI.iTempLastLocation = NPC_AI.iTempLocation;
                        NPC_AI.iTempLocation = iNPCMove; // Put us where we said we were moving to!
                        // Console.WriteLine("Someone has been put in danger!");
                        ValidMove = false;
                        NPC_AI.iTempDesireToMove = NPC_AI.iTempDesireToMove - (NPC_AI.iDesireRegen * 2);
                    }
                }
            }
            if (NPC_AI.iTempLoyalty < 4 && ValidMove)
            {
                Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " asks, 'You want me to leave? Why would I do that for you?'");
            }
        }
    }
}