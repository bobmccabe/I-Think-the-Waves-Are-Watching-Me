using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class RandomEncounters
    {
        // Random Encounter Minimum MacGuffin Rewards
        public static int iTinyRewardMin;
        public static int iSmallRewardMin;
        public static int iMediumRewardMin;
        public static int iLargeRewardMin;
        public static int iHugeRewardMin;

        // Random Encounter Maximum MacGuffin Rewards
        public static int iTinyRewardCap;
        public static int iSmallRewardCap;
        public static int iMediumRewardCap;
        public static int iLargeRewardCap;
        public static int iHugeRewardCap;

        public static bool bNewEncounterRandom;

        public static bool bRandEncounter2;
        public static bool bRandEncounter3;
        public static bool bRandEncounter4;
        public static bool bRandEncounter5;
        public static bool bRandEncounter6;
        public static bool bRandEncounter7;
        public static bool bRandEncounter8;
        public static bool bRandEncounter9;
        public static bool bRandEncounter10;

        public static int iRandEncounter;
        public static bool bEncounter;

        public static bool bBestFriendsReportsOnce;
        public static bool bMyBestFriend;
        public static bool bBestFriend_Corpse;
        public static string sBestFriend_Name;
        public static string sBestieSibling;
        public static int iBestFriend_MacGuffins;
        public static int iBestFriend_DesireToMove;
        public static int iBestFriend_Disposition;
        public static int iBestFriend_CurrentNumLocation;

        // "Actors" are radnomly slotted into the various encounters.
        public static string Actor01;
        public static string Actor02;
        public static string Actor03;
        public static string Actor04;
        public static string Actor05;
        public static string Actor06;

        // Actors 01-06 variables
        public static int iTempDesireToMove01;
        public static bool bTempCorpse01;
        public static int iTempLoyalty01;
        public static int iTempMacGuffins01;
        public static string sTempWeapons01;

        public static int iTempDesireToMove02;
        public static bool bTempCorpse02;
        public static int iTempLoyalty02;
        public static int iTempMacGuffins02;
        public static string sTempWeapons02;

        public static int iTempDesireToMove03;
        public static bool bTempCorpse03;
        public static int iTempLoyalty03;
        public static int iTempMacGuffins03;
        public static string sTempWeapons03;

        public static int iTempDesireToMove04;
        public static bool bTempCorpse04;
        public static int iTempLoyalty04;
        public static int iTempMacGuffins04;
        public static string sTempWeapons04;

        public static int iTempDesireToMove05;
        public static bool bTempCorpse05;
        public static int iTempLoyalty05;
        public static int iTempMacGuffins05;
        public static string sTempWeapons05;

        public static int iTempDesireToMove06;
        public static bool bTempCorpse06;
        public static int iTempLoyalty06;
        public static int iTempMacGuffins06;
        public static string sTempWeapons06;

        public static bool bFloodProof, bMetalDetector;

        public static void Initialize_RandomEncounters()
        {
            iTinyRewardMin = 1;
            iSmallRewardMin = 2;
            iMediumRewardMin = 3;
            iLargeRewardMin = 4;
            iHugeRewardMin = 5;

            iTinyRewardCap = 3;
            iSmallRewardCap = 5;
            iMediumRewardCap = 7;
            iLargeRewardCap = 9;
            iHugeRewardCap = 11;

            bNewEncounterRandom = bRandEncounter2 = bRandEncounter3 = bRandEncounter4 = bRandEncounter5 =
            bRandEncounter6 = bRandEncounter7 = bRandEncounter8 = bRandEncounter9 = bRandEncounter10 = false;

            iRandEncounter = 0;
            bEncounter = false;

            bBestFriendsReportsOnce = false;
            bMyBestFriend = false;
            bBestFriend_Corpse = false;
            sBestFriend_Name = "null";
            sBestieSibling = "null";
            iBestFriend_MacGuffins = 0;
            iBestFriend_DesireToMove = 0;
            iBestFriend_Disposition = 0;
            iBestFriend_CurrentNumLocation = 0;

            bFloodProof = bMetalDetector = false;
        }

        public static void Initialize_Actors()
        {
            Actor01 = "not_yet_named";
            Actor02 = "not_yet_named";
            Actor03 = "not_yet_named";
            Actor04 = "not_yet_named";
            Actor05 = "not_yet_named";
            Actor06 = "not_yet_named";

            AccusationEncounters.iParticipant1 = 0;
            AccusationEncounters.iParticipant2 = 0;
            AccusationEncounters.iParticipant3 = 0;
            AccusationEncounters.iParticipant4 = 0;

            AccusationEncounters.bJumpToAccusation = false; // otherwise, all subsequent dialogues will be accusations.

            // iAccuse, iEncounterResolve, iChoseLine, iPosse
            AccusationEncounters.iAccuse = 0;
            AccusationEncounters.iPosse = 0;

            iTempDesireToMove01 = 0;
            bTempCorpse01 = false;
            iTempLoyalty01 = 0;
            iTempMacGuffins01 = 0;
            sTempWeapons01 = NPC_AI.sWeaponType0;

            iTempDesireToMove02 = 0;
            bTempCorpse02 = false;
            iTempLoyalty02 = 0;
            iTempMacGuffins02 = 0;
            sTempWeapons02 = NPC_AI.sWeaponType0;

            iTempDesireToMove03 = 0;
            bTempCorpse03 = false;
            iTempLoyalty03 = 0;
            iTempMacGuffins03 = 0;
            sTempWeapons03 = NPC_AI.sWeaponType0;

            iTempDesireToMove04 = 0;
            bTempCorpse04 = false;
            iTempLoyalty04 = 0;
            iTempMacGuffins04 = 0;
            sTempWeapons04 = NPC_AI.sWeaponType0;

            iTempDesireToMove05 = 0;
            bTempCorpse05 = false;
            iTempLoyalty05 = 0;
            iTempMacGuffins05 = 0;
            sTempWeapons05 = NPC_AI.sWeaponType0;

            iTempDesireToMove06 = 0;
            bTempCorpse06 = false;
            iTempLoyalty06 = 0;
            iTempMacGuffins06 = 0;
            sTempWeapons06 = NPC_AI.sWeaponType0;
        }

        public static void PickAnyRandomEncounter()
        {
            Initialize_Actors();
            bEncounter = false;

            if (Variables.iRemainingTurns == Variables.iTurn20)
            {
                iRandEncounter = 1;
            }
            if (bNewEncounterRandom == true)
            {
                iRandEncounter = Program.rand.Next(2, 9); // 2, 3, 4, 5, 6, 7, 8
            }
            if (Variables.iRemainingTurns > 41 && Variables.iRemainingTurns < Variables.iTurn10 && LocationEncounters.bNothingHappening && Variables.iTurnsSinceEncounter > 9)
            {
                // Set the participants for any given random encounter. 
                if (iRandEncounter == 1) // Random Encounter #1
                {
                    int iEncounter1Actor1 = Program.rand.Next(Lists.RemainingNPCs.Count);
                    Actor01 = Lists.RemainingNPCs[iEncounter1Actor1];
                    Lists.RemainingNPCs.RemoveAt(iEncounter1Actor1);
                    int iEncounter1Actor2 = Program.rand.Next(Lists.RemainingNPCs.Count);
                    Actor02 = Lists.RemainingNPCs[iEncounter1Actor2];
                    Lists.RemainingNPCs.RemoveAt(iEncounter1Actor2);
                    int iEncounter1Actor3 = Program.rand.Next(Lists.RemainingNPCs.Count);
                    Actor03 = Lists.RemainingNPCs[iEncounter1Actor3];
                    Lists.RemainingNPCs.RemoveAt(iEncounter1Actor3);
                    int iEncounter1Actor4 = Program.rand.Next(Lists.RemainingNPCs.Count);
                    Actor04 = Lists.RemainingNPCs[iEncounter1Actor4];
                    Lists.RemainingNPCs.RemoveAt(iEncounter1Actor4);
                    int iEncounter1Actor5 = Program.rand.Next(Lists.RemainingNPCs.Count);
                    Actor06 = Lists.RemainingNPCs[iEncounter1Actor5];
                    while (
                    Actor06 == NPC_AI.NPC_090 || Actor06 == NPC_AI.NPC_091 || Actor06 == NPC_AI.NPC_092 || Actor06 == NPC_AI.NPC_093 || Actor06 == NPC_AI.NPC_094 ||
                    Actor06 == NPC_AI.NPC_095 || Actor06 == NPC_AI.NPC_096 || Actor06 == NPC_AI.NPC_097 || Actor06 == NPC_AI.NPC_098 || Actor06 == NPC_AI.NPC_099 ||
                    Actor06 == NPC_AI.NPC_100)
                    {
                        iEncounter1Actor5 = Program.rand.Next(Lists.RemainingNPCs.Count);
                        Actor06 = Lists.RemainingNPCs[iEncounter1Actor5];
                    }

                    Lists.RemainingNPCs.RemoveAt(iEncounter1Actor5);
                    // Using the remainingNPCs list to insure that we're selecting from everyone, and then properly removing the
                    // dead people. Of course, the names have to be added back to the list (for the other, non-dead participants)
                    // because the number of remainingNPCs affects the player's score.
                    Lists.RemainingNPCs.Add(Actor01);
                    Lists.RemainingNPCs.Add(Actor02);
                    Lists.RemainingNPCs.Add(Actor03);
                    Lists.RemainingNPCs.Add(Actor04);
                    Lists.RemainingNPCs.Add(Actor05);

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();

                    Run_RandomEncounter01();
                }
                if (!bRandEncounter2 && iRandEncounter == 2 && Lists.TalkingNPCs.Count > 0 && Lists.TheLocalDead.Count > 0) // Random Encounter #2
                {
                    // For this encounter, Actor01 should be anyone BUT the killer OR bestie; while using the killer, and accidentally
                    // killing the killer, would be fine in play, it might be too jarring of a game over screen for the player.
                    int iEncounter2Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter2Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter2Actor1);
                    while (Actor01 == NPC_AI.NPC_100 && Lists.TalkingNPCs.Count > 0 && Actor01 == sBestFriend_Name)
                    {
                        iEncounter2Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                        Actor01 = Lists.TalkingNPCs[iEncounter2Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter2Actor1);
                    }

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter02();
                }
                if (!bRandEncounter3 && iRandEncounter == 3 && Lists.TalkingNPCs.Count >= 4) // Random Encounter #3, The Play with the Censored Person
                {
                    int iEncounter3Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter3Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter3Actor1);
                    while (Actor01 == sBestFriend_Name)
                    {
                        Actor01 = Lists.TalkingNPCs[iEncounter3Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter3Actor1);
                    }

                    int iEncounter3Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter3Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter3Actor2);
                    while (Actor02 == sBestFriend_Name)
                    {
                        Actor02 = Lists.TalkingNPCs[iEncounter3Actor2];
                        Lists.TalkingNPCs.RemoveAt(iEncounter3Actor2);
                    }
                    
                    int iEncounter3Actor3 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor03 = Lists.TalkingNPCs[iEncounter3Actor3];
                    Lists.TalkingNPCs.RemoveAt(iEncounter3Actor3);
                    while (Actor03 == sBestFriend_Name)
                    {
                        Actor03 = Lists.TalkingNPCs[iEncounter3Actor3];
                        Lists.TalkingNPCs.RemoveAt(iEncounter3Actor3);
                    }
                    
                    int iEncounter3Actor4 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor04 = Lists.TalkingNPCs[iEncounter3Actor4];
                    Lists.TalkingNPCs.RemoveAt(iEncounter3Actor4);
                    while (Actor04 == sBestFriend_Name)
                    {
                        Actor04 = Lists.TalkingNPCs[iEncounter3Actor4];
                        Lists.TalkingNPCs.RemoveAt(iEncounter3Actor4);
                    }

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter03();
                }
                if (!bRandEncounter4 && iRandEncounter == 4 && Lists.TalkingNPCs.Count >= 2) // Random Encounter #4, Radio Interview
                {
                    int iEncounter4Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter4Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter4Actor1);
                    while (Actor01 == sBestFriend_Name)
                    {
                        Actor01 = Lists.TalkingNPCs[iEncounter4Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter4Actor1);
                    }

                    int iEncounter4Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter4Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter4Actor2);
                    while (Actor02 == sBestFriend_Name)
                    {
                        Actor02 = Lists.TalkingNPCs[iEncounter4Actor2];
                        Lists.TalkingNPCs.RemoveAt(iEncounter4Actor2);
                    }

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter04();
                }
                if (!bRandEncounter5 && iRandEncounter == 5 && (Lists.TalkingNPCs.Count == 0) || Lists.TalkingNPCs.Count == 1 && sBestFriend_Name != "null") // Random Encounter #5, The Fox
                {
                    // No actors need to be set. Encounter requires an empty location.

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter05();
                }
                if (!bRandEncounter6 && (iRandEncounter == 6 && Lists.TalkingNPCs.Count >= 2) && (Variables.sGetLocation == LocationEncounters.location_001 || 
                Variables.sGetLocation == LocationEncounters.location_003 || Variables.sGetLocation == LocationEncounters.location_013 || 
                Variables.sGetLocation == LocationEncounters.location_022 || Variables.sGetLocation == LocationEncounters.location_023 || 
                Variables.sGetLocation == LocationEncounters.location_024 || Variables.sGetLocation == LocationEncounters.location_025)) // Random Encounter #6, Lovers on the Beach
                {
                    int iEncounter6Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter6Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter6Actor1);
                    while (Actor01 == sBestFriend_Name)
                    {
                        Actor01 = Lists.TalkingNPCs[iEncounter6Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter6Actor1);
                    }
                    int iEncounter6Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter6Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter6Actor2);
                    while (Actor02 == sBestFriend_Name)
                    {
                        Actor02 = Lists.TalkingNPCs[iEncounter6Actor2];
                        Lists.TalkingNPCs.RemoveAt(iEncounter6Actor2);
                    }

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter06();
                }
                if (!bRandEncounter7 && iRandEncounter == 7 && Lists.TalkingNPCs.Count >= 2) // Random Encounter #7, Settling a Dispute
                {
                    int iEncounter7Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter7Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor1);
                    while (Actor01 == sBestFriend_Name)
                    {
                        Actor01 = Lists.TalkingNPCs[iEncounter7Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter7Actor1);
                    }
                    int iEncounter7Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter7Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor2);
                    while (Actor02 == sBestFriend_Name)
                    {
                        Actor02 = Lists.TalkingNPCs[iEncounter7Actor2];
                        Lists.TalkingNPCs.RemoveAt(iEncounter7Actor2);
                    }

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter07();
                }
                if (!bRandEncounter8 && iRandEncounter == 8) // Random Encounter #8, Getting a Best Friend
                {
                    BestieSiblingCheck();
                    if (sBestieSibling != "null")
                    {
                        int iEncounter7Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                        Actor01 = Lists.TalkingNPCs[iEncounter7Actor1];
                        Lists.TalkingNPCs.RemoveAt(iEncounter7Actor1);
                        int iEncounter7Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                        // Actor2 should be a corpse with a disposition of 4 or 5.
                        Actor02 = sBestieSibling;
                        NPC_AI.Actors_PantsDownGenderCheck();
                        LocationEncounters.WhatIsTheStoryLocationMan();
                        Run_RandomEncounter08();
                    }
                    if (sBestieSibling == "null")
                    {
                        Lists.MyBestiesDeadSibling.Clear();
                    }
                }
                if (!bRandEncounter9 && iRandEncounter == 9) // Random Encounter #9
                {
                    int iEncounter7Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter7Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor1);
                    int iEncounter7Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter7Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor2);

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter09();
                }
                if (!bRandEncounter10 && iRandEncounter == 10) // Random Encounter #10
                {
                    int iEncounter7Actor1 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor01 = Lists.TalkingNPCs[iEncounter7Actor1];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor1);
                    int iEncounter7Actor2 = Program.rand.Next(Lists.TalkingNPCs.Count);
                    Actor02 = Lists.TalkingNPCs[iEncounter7Actor2];
                    Lists.TalkingNPCs.RemoveAt(iEncounter7Actor2);

                    NPC_AI.Actors_PantsDownGenderCheck();
                    LocationEncounters.WhatIsTheStoryLocationMan();
                    Run_RandomEncounter10();
                }
            }
        }

        public static void GetAllActorLocals()
        {
            // Now that we know who is in the scene, set their variable before proceeding to the encounter.


            iTempDesireToMove01 = 0; bTempCorpse01 = false;
            iTempLoyalty01 = 0;
            iTempMacGuffins01 = 0; 
            sTempWeapons01 = "null"; 
            AccusationEncounters.sTempTraitOne01 = "null"; 
            AccusationEncounters.sTempTraitTwo01 = "null"; 
            AccusationEncounters.sTempTraitThree01 = "null"; 
            AccusationEncounters.bNoteOne01 = false; 
            AccusationEncounters.bNoteTwo01 = false; 
            AccusationEncounters.bNoteThree01 = false;

            if (Actor01 == NPC_AI.NPC_001) { iTempDesireToMove01 = NPC_AI.DesireToMove001; bTempCorpse01 = NPC_AI.bCorpse001; iTempLoyalty01 = NPC_AI.iLoyalty001; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins001; sTempWeapons01 = NPC_AI.sAvailableWeapons001; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne001; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo001; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree001; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne001; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo001; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree001; }
            if (Actor01 == NPC_AI.NPC_002) { iTempDesireToMove01 = NPC_AI.DesireToMove002; bTempCorpse01 = NPC_AI.bCorpse002; iTempLoyalty01 = NPC_AI.iLoyalty002; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins002; sTempWeapons01 = NPC_AI.sAvailableWeapons002; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne002; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo002; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree002; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne002; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo002; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree002; }
            if (Actor01 == NPC_AI.NPC_003) { iTempDesireToMove01 = NPC_AI.DesireToMove003; bTempCorpse01 = NPC_AI.bCorpse003; iTempLoyalty01 = NPC_AI.iLoyalty003; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins003; sTempWeapons01 = NPC_AI.sAvailableWeapons003; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne003; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo003; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree003; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne003; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo003; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree003; }
            if (Actor01 == NPC_AI.NPC_004) { iTempDesireToMove01 = NPC_AI.DesireToMove004; bTempCorpse01 = NPC_AI.bCorpse004; iTempLoyalty01 = NPC_AI.iLoyalty004; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins004; sTempWeapons01 = NPC_AI.sAvailableWeapons004; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne004; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo004; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree004; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne004; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo004; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree004; }
            if (Actor01 == NPC_AI.NPC_005) { iTempDesireToMove01 = NPC_AI.DesireToMove005; bTempCorpse01 = NPC_AI.bCorpse005; iTempLoyalty01 = NPC_AI.iLoyalty005; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins005; sTempWeapons01 = NPC_AI.sAvailableWeapons005; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne005; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo005; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree005; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne005; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo005; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree005; }
            if (Actor01 == NPC_AI.NPC_006) { iTempDesireToMove01 = NPC_AI.DesireToMove006; bTempCorpse01 = NPC_AI.bCorpse006; iTempLoyalty01 = NPC_AI.iLoyalty006; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins006; sTempWeapons01 = NPC_AI.sAvailableWeapons006; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne006; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo006; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree006; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne006; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo006; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree006; }
            if (Actor01 == NPC_AI.NPC_007) { iTempDesireToMove01 = NPC_AI.DesireToMove007; bTempCorpse01 = NPC_AI.bCorpse007; iTempLoyalty01 = NPC_AI.iLoyalty007; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins007; sTempWeapons01 = NPC_AI.sAvailableWeapons007; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne007; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo007; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree007; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne007; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo007; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree007; }
            if (Actor01 == NPC_AI.NPC_008) { iTempDesireToMove01 = NPC_AI.DesireToMove008; bTempCorpse01 = NPC_AI.bCorpse008; iTempLoyalty01 = NPC_AI.iLoyalty008; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins008; sTempWeapons01 = NPC_AI.sAvailableWeapons008; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne008; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo008; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree008; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne008; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo008; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree008; }
            if (Actor01 == NPC_AI.NPC_009) { iTempDesireToMove01 = NPC_AI.DesireToMove009; bTempCorpse01 = NPC_AI.bCorpse009; iTempLoyalty01 = NPC_AI.iLoyalty009; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins009; sTempWeapons01 = NPC_AI.sAvailableWeapons009; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne009; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo009; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree009; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne009; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo009; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree009; }
            if (Actor01 == NPC_AI.NPC_010) { iTempDesireToMove01 = NPC_AI.DesireToMove010; bTempCorpse01 = NPC_AI.bCorpse010; iTempLoyalty01 = NPC_AI.iLoyalty010; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins010; sTempWeapons01 = NPC_AI.sAvailableWeapons010; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne010; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo010; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree010; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne010; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo010; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree010; }
            if (Actor01 == NPC_AI.NPC_011) { iTempDesireToMove01 = NPC_AI.DesireToMove011; bTempCorpse01 = NPC_AI.bCorpse011; iTempLoyalty01 = NPC_AI.iLoyalty011; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins011; sTempWeapons01 = NPC_AI.sAvailableWeapons011; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne011; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo011; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree011; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne011; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo011; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree011; }
            if (Actor01 == NPC_AI.NPC_012) { iTempDesireToMove01 = NPC_AI.DesireToMove012; bTempCorpse01 = NPC_AI.bCorpse012; iTempLoyalty01 = NPC_AI.iLoyalty012; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins012; sTempWeapons01 = NPC_AI.sAvailableWeapons012; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne012; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo012; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree012; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne012; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo012; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree012; }
            if (Actor01 == NPC_AI.NPC_013) { iTempDesireToMove01 = NPC_AI.DesireToMove013; bTempCorpse01 = NPC_AI.bCorpse013; iTempLoyalty01 = NPC_AI.iLoyalty013; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins013; sTempWeapons01 = NPC_AI.sAvailableWeapons013; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne013; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo013; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree013; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne013; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo013; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree013; }
            if (Actor01 == NPC_AI.NPC_014) { iTempDesireToMove01 = NPC_AI.DesireToMove014; bTempCorpse01 = NPC_AI.bCorpse014; iTempLoyalty01 = NPC_AI.iLoyalty014; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins014; sTempWeapons01 = NPC_AI.sAvailableWeapons014; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne014; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo014; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree014; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne014; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo014; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree014; }
            if (Actor01 == NPC_AI.NPC_015) { iTempDesireToMove01 = NPC_AI.DesireToMove015; bTempCorpse01 = NPC_AI.bCorpse015; iTempLoyalty01 = NPC_AI.iLoyalty015; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins015; sTempWeapons01 = NPC_AI.sAvailableWeapons015; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne015; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo015; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree015; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne015; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo015; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree015; }
            if (Actor01 == NPC_AI.NPC_016) { iTempDesireToMove01 = NPC_AI.DesireToMove016; bTempCorpse01 = NPC_AI.bCorpse016; iTempLoyalty01 = NPC_AI.iLoyalty016; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins016; sTempWeapons01 = NPC_AI.sAvailableWeapons016; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne016; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo016; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree016; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne016; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo016; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree016; }
            if (Actor01 == NPC_AI.NPC_017) { iTempDesireToMove01 = NPC_AI.DesireToMove017; bTempCorpse01 = NPC_AI.bCorpse017; iTempLoyalty01 = NPC_AI.iLoyalty017; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins017; sTempWeapons01 = NPC_AI.sAvailableWeapons017; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne017; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo017; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree017; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne017; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo017; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree017; }
            if (Actor01 == NPC_AI.NPC_018) { iTempDesireToMove01 = NPC_AI.DesireToMove018; bTempCorpse01 = NPC_AI.bCorpse018; iTempLoyalty01 = NPC_AI.iLoyalty018; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins018; sTempWeapons01 = NPC_AI.sAvailableWeapons018; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne018; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo018; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree018; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne018; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo018; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree018; }
            if (Actor01 == NPC_AI.NPC_019) { iTempDesireToMove01 = NPC_AI.DesireToMove019; bTempCorpse01 = NPC_AI.bCorpse019; iTempLoyalty01 = NPC_AI.iLoyalty019; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins019; sTempWeapons01 = NPC_AI.sAvailableWeapons019; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne019; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo019; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree019; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne019; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo019; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree019; }
            if (Actor01 == NPC_AI.NPC_020) { iTempDesireToMove01 = NPC_AI.DesireToMove020; bTempCorpse01 = NPC_AI.bCorpse020; iTempLoyalty01 = NPC_AI.iLoyalty020; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins020; sTempWeapons01 = NPC_AI.sAvailableWeapons020; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne020; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo020; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree020; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne020; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo020; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree020; }
            if (Actor01 == NPC_AI.NPC_021) { iTempDesireToMove01 = NPC_AI.DesireToMove021; bTempCorpse01 = NPC_AI.bCorpse021; iTempLoyalty01 = NPC_AI.iLoyalty021; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins021; sTempWeapons01 = NPC_AI.sAvailableWeapons021; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne021; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo021; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree021; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne021; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo021; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree021; }
            if (Actor01 == NPC_AI.NPC_022) { iTempDesireToMove01 = NPC_AI.DesireToMove022; bTempCorpse01 = NPC_AI.bCorpse022; iTempLoyalty01 = NPC_AI.iLoyalty022; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins022; sTempWeapons01 = NPC_AI.sAvailableWeapons022; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne022; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo022; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree022; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne022; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo022; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree022; }
            if (Actor01 == NPC_AI.NPC_023) { iTempDesireToMove01 = NPC_AI.DesireToMove023; bTempCorpse01 = NPC_AI.bCorpse023; iTempLoyalty01 = NPC_AI.iLoyalty023; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins023; sTempWeapons01 = NPC_AI.sAvailableWeapons023; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne023; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo023; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree023; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne023; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo023; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree023; }
            if (Actor01 == NPC_AI.NPC_024) { iTempDesireToMove01 = NPC_AI.DesireToMove024; bTempCorpse01 = NPC_AI.bCorpse024; iTempLoyalty01 = NPC_AI.iLoyalty024; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins024; sTempWeapons01 = NPC_AI.sAvailableWeapons024; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne024; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo024; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree024; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne024; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo024; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree024; }
            if (Actor01 == NPC_AI.NPC_025) { iTempDesireToMove01 = NPC_AI.DesireToMove025; bTempCorpse01 = NPC_AI.bCorpse025; iTempLoyalty01 = NPC_AI.iLoyalty025; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins025; sTempWeapons01 = NPC_AI.sAvailableWeapons025; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne025; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo025; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree025; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne025; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo025; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree025; }
            if (Actor01 == NPC_AI.NPC_026) { iTempDesireToMove01 = NPC_AI.DesireToMove026; bTempCorpse01 = NPC_AI.bCorpse026; iTempLoyalty01 = NPC_AI.iLoyalty026; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins026; sTempWeapons01 = NPC_AI.sAvailableWeapons026; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne026; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo026; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree026; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne026; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo026; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree026; }
            if (Actor01 == NPC_AI.NPC_027) { iTempDesireToMove01 = NPC_AI.DesireToMove027; bTempCorpse01 = NPC_AI.bCorpse027; iTempLoyalty01 = NPC_AI.iLoyalty027; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins027; sTempWeapons01 = NPC_AI.sAvailableWeapons027; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne027; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo027; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree027; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne027; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo027; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree027; }
            if (Actor01 == NPC_AI.NPC_028) { iTempDesireToMove01 = NPC_AI.DesireToMove028; bTempCorpse01 = NPC_AI.bCorpse028; iTempLoyalty01 = NPC_AI.iLoyalty028; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins028; sTempWeapons01 = NPC_AI.sAvailableWeapons028; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne028; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo028; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree028; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne028; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo028; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree028; }
            if (Actor01 == NPC_AI.NPC_029) { iTempDesireToMove01 = NPC_AI.DesireToMove029; bTempCorpse01 = NPC_AI.bCorpse029; iTempLoyalty01 = NPC_AI.iLoyalty029; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins029; sTempWeapons01 = NPC_AI.sAvailableWeapons029; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne029; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo029; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree029; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne029; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo029; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree029; }
            if (Actor01 == NPC_AI.NPC_030) { iTempDesireToMove01 = NPC_AI.DesireToMove030; bTempCorpse01 = NPC_AI.bCorpse030; iTempLoyalty01 = NPC_AI.iLoyalty030; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins030; sTempWeapons01 = NPC_AI.sAvailableWeapons030; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne030; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo030; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree030; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne030; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo030; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree030; }
            if (Actor01 == NPC_AI.NPC_031) { iTempDesireToMove01 = NPC_AI.DesireToMove031; bTempCorpse01 = NPC_AI.bCorpse031; iTempLoyalty01 = NPC_AI.iLoyalty031; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins031; sTempWeapons01 = NPC_AI.sAvailableWeapons031; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne031; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo031; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree031; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne031; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo031; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree031; }
            if (Actor01 == NPC_AI.NPC_032) { iTempDesireToMove01 = NPC_AI.DesireToMove032; bTempCorpse01 = NPC_AI.bCorpse032; iTempLoyalty01 = NPC_AI.iLoyalty032; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins032; sTempWeapons01 = NPC_AI.sAvailableWeapons032; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne032; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo032; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree032; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne032; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo032; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree032; }
            if (Actor01 == NPC_AI.NPC_033) { iTempDesireToMove01 = NPC_AI.DesireToMove033; bTempCorpse01 = NPC_AI.bCorpse033; iTempLoyalty01 = NPC_AI.iLoyalty033; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins033; sTempWeapons01 = NPC_AI.sAvailableWeapons033; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne033; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo033; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree033; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne033; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo033; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree033; }
            if (Actor01 == NPC_AI.NPC_034) { iTempDesireToMove01 = NPC_AI.DesireToMove034; bTempCorpse01 = NPC_AI.bCorpse034; iTempLoyalty01 = NPC_AI.iLoyalty034; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins034; sTempWeapons01 = NPC_AI.sAvailableWeapons034; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne034; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo034; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree034; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne034; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo034; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree034; }
            if (Actor01 == NPC_AI.NPC_035) { iTempDesireToMove01 = NPC_AI.DesireToMove035; bTempCorpse01 = NPC_AI.bCorpse035; iTempLoyalty01 = NPC_AI.iLoyalty035; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins035; sTempWeapons01 = NPC_AI.sAvailableWeapons035; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne035; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo035; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree035; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne035; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo035; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree035; }
            if (Actor01 == NPC_AI.NPC_036) { iTempDesireToMove01 = NPC_AI.DesireToMove036; bTempCorpse01 = NPC_AI.bCorpse036; iTempLoyalty01 = NPC_AI.iLoyalty036; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins036; sTempWeapons01 = NPC_AI.sAvailableWeapons036; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne036; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo036; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree036; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne036; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo036; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree036; }
            if (Actor01 == NPC_AI.NPC_037) { iTempDesireToMove01 = NPC_AI.DesireToMove037; bTempCorpse01 = NPC_AI.bCorpse037; iTempLoyalty01 = NPC_AI.iLoyalty037; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins037; sTempWeapons01 = NPC_AI.sAvailableWeapons037; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne037; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo037; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree037; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne037; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo037; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree037; }
            if (Actor01 == NPC_AI.NPC_038) { iTempDesireToMove01 = NPC_AI.DesireToMove038; bTempCorpse01 = NPC_AI.bCorpse038; iTempLoyalty01 = NPC_AI.iLoyalty038; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins038; sTempWeapons01 = NPC_AI.sAvailableWeapons038; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne038; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo038; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree038; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne038; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo038; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree038; }
            if (Actor01 == NPC_AI.NPC_039) { iTempDesireToMove01 = NPC_AI.DesireToMove039; bTempCorpse01 = NPC_AI.bCorpse039; iTempLoyalty01 = NPC_AI.iLoyalty039; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins039; sTempWeapons01 = NPC_AI.sAvailableWeapons039; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne039; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo039; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree039; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne039; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo039; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree039; }
            if (Actor01 == NPC_AI.NPC_040) { iTempDesireToMove01 = NPC_AI.DesireToMove040; bTempCorpse01 = NPC_AI.bCorpse040; iTempLoyalty01 = NPC_AI.iLoyalty040; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins040; sTempWeapons01 = NPC_AI.sAvailableWeapons040; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne040; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo040; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree040; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne040; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo040; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree040; }
            if (Actor01 == NPC_AI.NPC_041) { iTempDesireToMove01 = NPC_AI.DesireToMove041; bTempCorpse01 = NPC_AI.bCorpse041; iTempLoyalty01 = NPC_AI.iLoyalty041; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins041; sTempWeapons01 = NPC_AI.sAvailableWeapons041; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne041; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo041; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree041; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne041; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo041; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree041; }
            if (Actor01 == NPC_AI.NPC_042) { iTempDesireToMove01 = NPC_AI.DesireToMove042; bTempCorpse01 = NPC_AI.bCorpse042; iTempLoyalty01 = NPC_AI.iLoyalty042; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins042; sTempWeapons01 = NPC_AI.sAvailableWeapons042; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne042; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo042; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree042; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne042; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo042; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree042; }
            if (Actor01 == NPC_AI.NPC_043) { iTempDesireToMove01 = NPC_AI.DesireToMove043; bTempCorpse01 = NPC_AI.bCorpse043; iTempLoyalty01 = NPC_AI.iLoyalty043; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins043; sTempWeapons01 = NPC_AI.sAvailableWeapons043; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne043; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo043; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree043; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne043; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo043; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree043; }
            if (Actor01 == NPC_AI.NPC_044) { iTempDesireToMove01 = NPC_AI.DesireToMove044; bTempCorpse01 = NPC_AI.bCorpse044; iTempLoyalty01 = NPC_AI.iLoyalty044; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins044; sTempWeapons01 = NPC_AI.sAvailableWeapons044; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne044; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo044; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree044; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne044; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo044; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree044; }
            if (Actor01 == NPC_AI.NPC_045) { iTempDesireToMove01 = NPC_AI.DesireToMove045; bTempCorpse01 = NPC_AI.bCorpse045; iTempLoyalty01 = NPC_AI.iLoyalty045; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins045; sTempWeapons01 = NPC_AI.sAvailableWeapons045; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne045; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo045; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree045; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne045; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo045; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree045; }
            if (Actor01 == NPC_AI.NPC_046) { iTempDesireToMove01 = NPC_AI.DesireToMove046; bTempCorpse01 = NPC_AI.bCorpse046; iTempLoyalty01 = NPC_AI.iLoyalty046; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins046; sTempWeapons01 = NPC_AI.sAvailableWeapons046; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne046; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo046; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree046; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne046; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo046; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree046; }
            if (Actor01 == NPC_AI.NPC_047) { iTempDesireToMove01 = NPC_AI.DesireToMove047; bTempCorpse01 = NPC_AI.bCorpse047; iTempLoyalty01 = NPC_AI.iLoyalty047; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins047; sTempWeapons01 = NPC_AI.sAvailableWeapons047; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne047; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo047; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree047; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne047; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo047; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree047; }
            if (Actor01 == NPC_AI.NPC_048) { iTempDesireToMove01 = NPC_AI.DesireToMove048; bTempCorpse01 = NPC_AI.bCorpse048; iTempLoyalty01 = NPC_AI.iLoyalty048; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins048; sTempWeapons01 = NPC_AI.sAvailableWeapons048; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne048; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo048; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree048; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne048; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo048; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree048; }
            if (Actor01 == NPC_AI.NPC_049) { iTempDesireToMove01 = NPC_AI.DesireToMove049; bTempCorpse01 = NPC_AI.bCorpse049; iTempLoyalty01 = NPC_AI.iLoyalty049; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins049; sTempWeapons01 = NPC_AI.sAvailableWeapons049; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne049; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo049; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree049; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne049; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo049; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree049; }
            if (Actor01 == NPC_AI.NPC_050) { iTempDesireToMove01 = NPC_AI.DesireToMove050; bTempCorpse01 = NPC_AI.bCorpse050; iTempLoyalty01 = NPC_AI.iLoyalty050; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins050; sTempWeapons01 = NPC_AI.sAvailableWeapons050; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne050; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo050; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree050; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne050; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo050; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree050; }
            if (Actor01 == NPC_AI.NPC_051) { iTempDesireToMove01 = NPC_AI.DesireToMove051; bTempCorpse01 = NPC_AI.bCorpse051; iTempLoyalty01 = NPC_AI.iLoyalty051; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins051; sTempWeapons01 = NPC_AI.sAvailableWeapons051; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne051; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo051; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree051; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne051; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo051; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree051; }
            if (Actor01 == NPC_AI.NPC_052) { iTempDesireToMove01 = NPC_AI.DesireToMove052; bTempCorpse01 = NPC_AI.bCorpse052; iTempLoyalty01 = NPC_AI.iLoyalty052; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins052; sTempWeapons01 = NPC_AI.sAvailableWeapons052; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne052; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo052; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree052; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne052; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo052; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree052; }
            if (Actor01 == NPC_AI.NPC_053) { iTempDesireToMove01 = NPC_AI.DesireToMove053; bTempCorpse01 = NPC_AI.bCorpse053; iTempLoyalty01 = NPC_AI.iLoyalty053; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins053; sTempWeapons01 = NPC_AI.sAvailableWeapons053; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne053; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo053; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree053; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne053; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo053; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree053; }
            if (Actor01 == NPC_AI.NPC_054) { iTempDesireToMove01 = NPC_AI.DesireToMove054; bTempCorpse01 = NPC_AI.bCorpse054; iTempLoyalty01 = NPC_AI.iLoyalty054; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins054; sTempWeapons01 = NPC_AI.sAvailableWeapons054; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne054; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo054; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree054; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne054; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo054; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree054; }
            if (Actor01 == NPC_AI.NPC_055) { iTempDesireToMove01 = NPC_AI.DesireToMove055; bTempCorpse01 = NPC_AI.bCorpse055; iTempLoyalty01 = NPC_AI.iLoyalty055; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins055; sTempWeapons01 = NPC_AI.sAvailableWeapons055; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne055; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo055; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree055; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne055; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo055; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree055; }
            if (Actor01 == NPC_AI.NPC_056) { iTempDesireToMove01 = NPC_AI.DesireToMove056; bTempCorpse01 = NPC_AI.bCorpse056; iTempLoyalty01 = NPC_AI.iLoyalty056; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins056; sTempWeapons01 = NPC_AI.sAvailableWeapons056; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne056; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo056; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree056; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne056; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo056; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree056; }
            if (Actor01 == NPC_AI.NPC_057) { iTempDesireToMove01 = NPC_AI.DesireToMove057; bTempCorpse01 = NPC_AI.bCorpse057; iTempLoyalty01 = NPC_AI.iLoyalty057; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins057; sTempWeapons01 = NPC_AI.sAvailableWeapons057; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne057; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo057; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree057; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne057; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo057; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree057; }
            if (Actor01 == NPC_AI.NPC_058) { iTempDesireToMove01 = NPC_AI.DesireToMove058; bTempCorpse01 = NPC_AI.bCorpse058; iTempLoyalty01 = NPC_AI.iLoyalty058; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins058; sTempWeapons01 = NPC_AI.sAvailableWeapons058; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne058; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo058; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree058; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne058; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo058; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree058; }
            if (Actor01 == NPC_AI.NPC_059) { iTempDesireToMove01 = NPC_AI.DesireToMove059; bTempCorpse01 = NPC_AI.bCorpse059; iTempLoyalty01 = NPC_AI.iLoyalty059; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins059; sTempWeapons01 = NPC_AI.sAvailableWeapons059; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne059; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo059; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree059; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne059; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo059; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree059; }
            if (Actor01 == NPC_AI.NPC_060) { iTempDesireToMove01 = NPC_AI.DesireToMove060; bTempCorpse01 = NPC_AI.bCorpse060; iTempLoyalty01 = NPC_AI.iLoyalty060; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins060; sTempWeapons01 = NPC_AI.sAvailableWeapons060; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne060; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo060; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree060; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne060; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo060; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree060; }
            if (Actor01 == NPC_AI.NPC_061) { iTempDesireToMove01 = NPC_AI.DesireToMove061; bTempCorpse01 = NPC_AI.bCorpse061; iTempLoyalty01 = NPC_AI.iLoyalty061; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins061; sTempWeapons01 = NPC_AI.sAvailableWeapons061; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne061; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo061; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree061; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne061; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo061; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree061; }
            if (Actor01 == NPC_AI.NPC_062) { iTempDesireToMove01 = NPC_AI.DesireToMove062; bTempCorpse01 = NPC_AI.bCorpse062; iTempLoyalty01 = NPC_AI.iLoyalty062; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins062; sTempWeapons01 = NPC_AI.sAvailableWeapons062; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne062; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo062; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree062; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne062; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo062; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree062; }
            if (Actor01 == NPC_AI.NPC_063) { iTempDesireToMove01 = NPC_AI.DesireToMove063; bTempCorpse01 = NPC_AI.bCorpse063; iTempLoyalty01 = NPC_AI.iLoyalty063; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins063; sTempWeapons01 = NPC_AI.sAvailableWeapons063; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne063; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo063; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree063; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne063; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo063; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree063; }
            if (Actor01 == NPC_AI.NPC_064) { iTempDesireToMove01 = NPC_AI.DesireToMove064; bTempCorpse01 = NPC_AI.bCorpse064; iTempLoyalty01 = NPC_AI.iLoyalty054; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins064; sTempWeapons01 = NPC_AI.sAvailableWeapons064; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne064; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo064; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree064; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne064; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo064; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree064; }
            if (Actor01 == NPC_AI.NPC_065) { iTempDesireToMove01 = NPC_AI.DesireToMove065; bTempCorpse01 = NPC_AI.bCorpse065; iTempLoyalty01 = NPC_AI.iLoyalty065; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins065; sTempWeapons01 = NPC_AI.sAvailableWeapons065; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne065; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo065; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree065; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne065; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo065; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree065; }
            if (Actor01 == NPC_AI.NPC_066) { iTempDesireToMove01 = NPC_AI.DesireToMove066; bTempCorpse01 = NPC_AI.bCorpse066; iTempLoyalty01 = NPC_AI.iLoyalty066; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins066; sTempWeapons01 = NPC_AI.sAvailableWeapons066; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne066; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo066; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree066; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne066; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo066; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree066; }
            if (Actor01 == NPC_AI.NPC_067) { iTempDesireToMove01 = NPC_AI.DesireToMove067; bTempCorpse01 = NPC_AI.bCorpse067; iTempLoyalty01 = NPC_AI.iLoyalty067; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins067; sTempWeapons01 = NPC_AI.sAvailableWeapons067; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne067; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo067; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree067; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne067; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo067; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree067; }
            if (Actor01 == NPC_AI.NPC_068) { iTempDesireToMove01 = NPC_AI.DesireToMove068; bTempCorpse01 = NPC_AI.bCorpse068; iTempLoyalty01 = NPC_AI.iLoyalty068; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins068; sTempWeapons01 = NPC_AI.sAvailableWeapons068; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne068; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo068; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree068; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne068; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo068; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree068; }
            if (Actor01 == NPC_AI.NPC_069) { iTempDesireToMove01 = NPC_AI.DesireToMove069; bTempCorpse01 = NPC_AI.bCorpse069; iTempLoyalty01 = NPC_AI.iLoyalty069; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins069; sTempWeapons01 = NPC_AI.sAvailableWeapons069; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne069; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo069; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree069; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne069; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo069; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree069; }
            if (Actor01 == NPC_AI.NPC_070) { iTempDesireToMove01 = NPC_AI.DesireToMove070; bTempCorpse01 = NPC_AI.bCorpse070; iTempLoyalty01 = NPC_AI.iLoyalty070; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins070; sTempWeapons01 = NPC_AI.sAvailableWeapons070; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne070; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo070; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree070; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne070; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo070; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree070; }
            if (Actor01 == NPC_AI.NPC_071) { iTempDesireToMove01 = NPC_AI.DesireToMove071; bTempCorpse01 = NPC_AI.bCorpse071; iTempLoyalty01 = NPC_AI.iLoyalty071; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins071; sTempWeapons01 = NPC_AI.sAvailableWeapons071; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne071; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo071; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree071; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne071; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo071; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree071; }
            if (Actor01 == NPC_AI.NPC_072) { iTempDesireToMove01 = NPC_AI.DesireToMove072; bTempCorpse01 = NPC_AI.bCorpse072; iTempLoyalty01 = NPC_AI.iLoyalty072; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins072; sTempWeapons01 = NPC_AI.sAvailableWeapons072; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne072; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo072; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree072; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne072; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo072; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree072; }
            if (Actor01 == NPC_AI.NPC_073) { iTempDesireToMove01 = NPC_AI.DesireToMove073; bTempCorpse01 = NPC_AI.bCorpse073; iTempLoyalty01 = NPC_AI.iLoyalty073; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins073; sTempWeapons01 = NPC_AI.sAvailableWeapons073; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne073; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo073; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree073; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne073; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo073; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree073; }
            if (Actor01 == NPC_AI.NPC_074) { iTempDesireToMove01 = NPC_AI.DesireToMove074; bTempCorpse01 = NPC_AI.bCorpse074; iTempLoyalty01 = NPC_AI.iLoyalty074; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins074; sTempWeapons01 = NPC_AI.sAvailableWeapons074; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne074; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo074; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree074; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne074; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo074; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree074; }
            if (Actor01 == NPC_AI.NPC_075) { iTempDesireToMove01 = NPC_AI.DesireToMove075; bTempCorpse01 = NPC_AI.bCorpse075; iTempLoyalty01 = NPC_AI.iLoyalty075; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins075; sTempWeapons01 = NPC_AI.sAvailableWeapons075; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne075; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo075; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree075; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne075; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo075; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree075; }
            if (Actor01 == NPC_AI.NPC_076) { iTempDesireToMove01 = NPC_AI.DesireToMove076; bTempCorpse01 = NPC_AI.bCorpse076; iTempLoyalty01 = NPC_AI.iLoyalty076; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins076; sTempWeapons01 = NPC_AI.sAvailableWeapons076; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne076; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo076; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree076; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne076; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo076; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree076; }
            if (Actor01 == NPC_AI.NPC_077) { iTempDesireToMove01 = NPC_AI.DesireToMove077; bTempCorpse01 = NPC_AI.bCorpse077; iTempLoyalty01 = NPC_AI.iLoyalty077; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins077; sTempWeapons01 = NPC_AI.sAvailableWeapons077; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne077; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo077; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree077; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne077; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo077; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree077; }
            if (Actor01 == NPC_AI.NPC_078) { iTempDesireToMove01 = NPC_AI.DesireToMove078; bTempCorpse01 = NPC_AI.bCorpse078; iTempLoyalty01 = NPC_AI.iLoyalty078; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins078; sTempWeapons01 = NPC_AI.sAvailableWeapons078; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne078; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo078; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree078; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne078; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo078; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree078; }
            if (Actor01 == NPC_AI.NPC_079) { iTempDesireToMove01 = NPC_AI.DesireToMove079; bTempCorpse01 = NPC_AI.bCorpse079; iTempLoyalty01 = NPC_AI.iLoyalty079; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins079; sTempWeapons01 = NPC_AI.sAvailableWeapons079; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne079; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo079; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree079; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne079; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo079; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree079; }
            if (Actor01 == NPC_AI.NPC_080) { iTempDesireToMove01 = NPC_AI.DesireToMove080; bTempCorpse01 = NPC_AI.bCorpse080; iTempLoyalty01 = NPC_AI.iLoyalty080; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins080; sTempWeapons01 = NPC_AI.sAvailableWeapons080; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne080; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo080; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree080; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne080; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo080; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree080; }
            if (Actor01 == NPC_AI.NPC_081) { iTempDesireToMove01 = NPC_AI.DesireToMove081; bTempCorpse01 = NPC_AI.bCorpse081; iTempLoyalty01 = NPC_AI.iLoyalty081; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins081; sTempWeapons01 = NPC_AI.sAvailableWeapons081; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne081; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo081; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree081; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne081; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo081; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree081; }
            if (Actor01 == NPC_AI.NPC_082) { iTempDesireToMove01 = NPC_AI.DesireToMove082; bTempCorpse01 = NPC_AI.bCorpse082; iTempLoyalty01 = NPC_AI.iLoyalty082; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins082; sTempWeapons01 = NPC_AI.sAvailableWeapons082; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne082; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo082; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree082; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne082; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo082; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree082; }
            if (Actor01 == NPC_AI.NPC_083) { iTempDesireToMove01 = NPC_AI.DesireToMove083; bTempCorpse01 = NPC_AI.bCorpse083; iTempLoyalty01 = NPC_AI.iLoyalty083; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins083; sTempWeapons01 = NPC_AI.sAvailableWeapons083; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne083; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo083; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree083; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne083; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo083; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree083; }
            if (Actor01 == NPC_AI.NPC_084) { iTempDesireToMove01 = NPC_AI.DesireToMove084; bTempCorpse01 = NPC_AI.bCorpse084; iTempLoyalty01 = NPC_AI.iLoyalty084; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins084; sTempWeapons01 = NPC_AI.sAvailableWeapons084; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne084; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo084; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree084; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne084; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo084; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree084; }
            if (Actor01 == NPC_AI.NPC_085) { iTempDesireToMove01 = NPC_AI.DesireToMove085; bTempCorpse01 = NPC_AI.bCorpse085; iTempLoyalty01 = NPC_AI.iLoyalty085; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins085; sTempWeapons01 = NPC_AI.sAvailableWeapons085; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne085; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo085; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree085; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne085; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo085; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree085; }
            if (Actor01 == NPC_AI.NPC_086) { iTempDesireToMove01 = NPC_AI.DesireToMove086; bTempCorpse01 = NPC_AI.bCorpse086; iTempLoyalty01 = NPC_AI.iLoyalty086; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins086; sTempWeapons01 = NPC_AI.sAvailableWeapons086; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne086; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo086; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree086; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne086; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo086; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree086; }
            if (Actor01 == NPC_AI.NPC_087) { iTempDesireToMove01 = NPC_AI.DesireToMove087; bTempCorpse01 = NPC_AI.bCorpse087; iTempLoyalty01 = NPC_AI.iLoyalty087; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins087; sTempWeapons01 = NPC_AI.sAvailableWeapons087; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne087; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo087; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree087; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne087; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo087; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree087; }
            if (Actor01 == NPC_AI.NPC_088) { iTempDesireToMove01 = NPC_AI.DesireToMove088; bTempCorpse01 = NPC_AI.bCorpse088; iTempLoyalty01 = NPC_AI.iLoyalty088; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins088; sTempWeapons01 = NPC_AI.sAvailableWeapons088; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne088; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo088; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree088; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne088; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo088; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree088; }
            if (Actor01 == NPC_AI.NPC_089) { iTempDesireToMove01 = NPC_AI.DesireToMove089; bTempCorpse01 = NPC_AI.bCorpse089; iTempLoyalty01 = NPC_AI.iLoyalty089; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins089; sTempWeapons01 = NPC_AI.sAvailableWeapons089; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne089; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo089; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree089; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne089; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo089; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree089; }
            if (Actor01 == NPC_AI.NPC_090) { iTempDesireToMove01 = NPC_AI.DesireToMove090; bTempCorpse01 = NPC_AI.bCorpse090; iTempLoyalty01 = NPC_AI.iLoyalty090; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins090; sTempWeapons01 = NPC_AI.sAvailableWeapons090; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne090; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo090; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree090; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne090; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo090; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree090; }
            if (Actor01 == NPC_AI.NPC_091) { iTempDesireToMove01 = NPC_AI.DesireToMove091; bTempCorpse01 = NPC_AI.bCorpse091; iTempLoyalty01 = NPC_AI.iLoyalty091; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins091; sTempWeapons01 = NPC_AI.sAvailableWeapons091; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne091; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo091; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree091; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne091; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo091; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree091; }
            if (Actor01 == NPC_AI.NPC_092) { iTempDesireToMove01 = NPC_AI.DesireToMove092; bTempCorpse01 = NPC_AI.bCorpse092; iTempLoyalty01 = NPC_AI.iLoyalty092; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins092; sTempWeapons01 = NPC_AI.sAvailableWeapons092; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne092; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo092; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree092; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne092; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo092; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree092; }
            if (Actor01 == NPC_AI.NPC_093) { iTempDesireToMove01 = NPC_AI.DesireToMove093; bTempCorpse01 = NPC_AI.bCorpse093; iTempLoyalty01 = NPC_AI.iLoyalty093; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins093; sTempWeapons01 = NPC_AI.sAvailableWeapons093; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne093; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo093; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree093; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne093; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo093; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree093; }
            if (Actor01 == NPC_AI.NPC_094) { iTempDesireToMove01 = NPC_AI.DesireToMove094; bTempCorpse01 = NPC_AI.bCorpse094; iTempLoyalty01 = NPC_AI.iLoyalty094; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins094; sTempWeapons01 = NPC_AI.sAvailableWeapons094; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne094; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo094; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree094; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne094; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo094; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree094; }
            if (Actor01 == NPC_AI.NPC_095) { iTempDesireToMove01 = NPC_AI.DesireToMove095; bTempCorpse01 = NPC_AI.bCorpse095; iTempLoyalty01 = NPC_AI.iLoyalty095; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins095; sTempWeapons01 = NPC_AI.sAvailableWeapons095; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne095; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo095; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree095; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne095; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo095; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree095; }
            if (Actor01 == NPC_AI.NPC_096) { iTempDesireToMove01 = NPC_AI.DesireToMove096; bTempCorpse01 = NPC_AI.bCorpse096; iTempLoyalty01 = NPC_AI.iLoyalty096; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins096; sTempWeapons01 = NPC_AI.sAvailableWeapons096; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne096; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo096; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree096; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne096; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo096; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree096; }
            if (Actor01 == NPC_AI.NPC_097) { iTempDesireToMove01 = NPC_AI.DesireToMove097; bTempCorpse01 = NPC_AI.bCorpse097; iTempLoyalty01 = NPC_AI.iLoyalty097; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins097; sTempWeapons01 = NPC_AI.sAvailableWeapons097; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne097; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo097; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree097; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne097; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo097; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree097; }
            if (Actor01 == NPC_AI.NPC_098) { iTempDesireToMove01 = NPC_AI.DesireToMove098; bTempCorpse01 = NPC_AI.bCorpse098; iTempLoyalty01 = NPC_AI.iLoyalty098; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins098; sTempWeapons01 = NPC_AI.sAvailableWeapons098; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne098; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo098; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree098; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne098; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo098; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree098; }
            if (Actor01 == NPC_AI.NPC_099) { iTempDesireToMove01 = NPC_AI.DesireToMove099; bTempCorpse01 = NPC_AI.bCorpse099; iTempLoyalty01 = NPC_AI.iLoyalty099; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins099; sTempWeapons01 = NPC_AI.sAvailableWeapons099; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne099; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo099; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree099; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne099; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo099; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree099; }
            if (Actor01 == NPC_AI.NPC_100) { iTempDesireToMove01 = NPC_AI.DesireToMove100; bTempCorpse01 = NPC_AI.bCorpse100; iTempLoyalty01 = NPC_AI.iLoyalty100; iTempMacGuffins01 = NPC_AI.iAvailableMacGuffins100; sTempWeapons01 = NPC_AI.sAvailableWeapons100; AccusationEncounters.sTempTraitOne01 = NPC_Traits.TraitOne100; AccusationEncounters.sTempTraitTwo01 = NPC_Traits.TraitTwo100; AccusationEncounters.sTempTraitThree01 = NPC_Traits.TraitThree100; AccusationEncounters.bNoteOne01 = Notebook.bNoteOne100; AccusationEncounters.bNoteTwo01 = Notebook.bNoteTwo100; AccusationEncounters.bNoteThree01 = Notebook.bNoteThree100; }

            if (Actor02 == NPC_AI.NPC_001) { iTempDesireToMove02 = NPC_AI.DesireToMove001; bTempCorpse02 = NPC_AI.bCorpse001; iTempLoyalty02 = NPC_AI.iLoyalty001; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins001; sTempWeapons02 = NPC_AI.sAvailableWeapons001;  }
            if (Actor02 == NPC_AI.NPC_002) { iTempDesireToMove02 = NPC_AI.DesireToMove002; bTempCorpse02 = NPC_AI.bCorpse002; iTempLoyalty02 = NPC_AI.iLoyalty002; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins002; sTempWeapons02 = NPC_AI.sAvailableWeapons002;  }
            if (Actor02 == NPC_AI.NPC_003) { iTempDesireToMove02 = NPC_AI.DesireToMove003; bTempCorpse02 = NPC_AI.bCorpse003; iTempLoyalty02 = NPC_AI.iLoyalty003; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins003; sTempWeapons02 = NPC_AI.sAvailableWeapons003;  }
            if (Actor02 == NPC_AI.NPC_004) { iTempDesireToMove02 = NPC_AI.DesireToMove004; bTempCorpse02 = NPC_AI.bCorpse004; iTempLoyalty02 = NPC_AI.iLoyalty004; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins004; sTempWeapons02 = NPC_AI.sAvailableWeapons004;  }
            if (Actor02 == NPC_AI.NPC_005) { iTempDesireToMove02 = NPC_AI.DesireToMove005; bTempCorpse02 = NPC_AI.bCorpse005; iTempLoyalty02 = NPC_AI.iLoyalty005; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins005; sTempWeapons02 = NPC_AI.sAvailableWeapons005;  }
            if (Actor02 == NPC_AI.NPC_006) { iTempDesireToMove02 = NPC_AI.DesireToMove006; bTempCorpse02 = NPC_AI.bCorpse006; iTempLoyalty02 = NPC_AI.iLoyalty006; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins006; sTempWeapons02 = NPC_AI.sAvailableWeapons006;  }
            if (Actor02 == NPC_AI.NPC_007) { iTempDesireToMove02 = NPC_AI.DesireToMove007; bTempCorpse02 = NPC_AI.bCorpse007; iTempLoyalty02 = NPC_AI.iLoyalty007; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins007; sTempWeapons02 = NPC_AI.sAvailableWeapons007;  }
            if (Actor02 == NPC_AI.NPC_008) { iTempDesireToMove02 = NPC_AI.DesireToMove008; bTempCorpse02 = NPC_AI.bCorpse008; iTempLoyalty02 = NPC_AI.iLoyalty008; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins008; sTempWeapons02 = NPC_AI.sAvailableWeapons008;  }
            if (Actor02 == NPC_AI.NPC_009) { iTempDesireToMove02 = NPC_AI.DesireToMove009; bTempCorpse02 = NPC_AI.bCorpse009; iTempLoyalty02 = NPC_AI.iLoyalty009; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins009; sTempWeapons02 = NPC_AI.sAvailableWeapons009;  }
            if (Actor02 == NPC_AI.NPC_010) { iTempDesireToMove02 = NPC_AI.DesireToMove010; bTempCorpse02 = NPC_AI.bCorpse010; iTempLoyalty02 = NPC_AI.iLoyalty010; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins010; sTempWeapons02 = NPC_AI.sAvailableWeapons010;  }
            if (Actor02 == NPC_AI.NPC_011) { iTempDesireToMove02 = NPC_AI.DesireToMove011; bTempCorpse02 = NPC_AI.bCorpse011; iTempLoyalty02 = NPC_AI.iLoyalty011; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins011; sTempWeapons02 = NPC_AI.sAvailableWeapons011;  }
            if (Actor02 == NPC_AI.NPC_012) { iTempDesireToMove02 = NPC_AI.DesireToMove012; bTempCorpse02 = NPC_AI.bCorpse012; iTempLoyalty02 = NPC_AI.iLoyalty012; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins012; sTempWeapons02 = NPC_AI.sAvailableWeapons012;  }
            if (Actor02 == NPC_AI.NPC_013) { iTempDesireToMove02 = NPC_AI.DesireToMove013; bTempCorpse02 = NPC_AI.bCorpse013; iTempLoyalty02 = NPC_AI.iLoyalty013; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins013; sTempWeapons02 = NPC_AI.sAvailableWeapons013;  }
            if (Actor02 == NPC_AI.NPC_014) { iTempDesireToMove02 = NPC_AI.DesireToMove014; bTempCorpse02 = NPC_AI.bCorpse014; iTempLoyalty02 = NPC_AI.iLoyalty014; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins014; sTempWeapons02 = NPC_AI.sAvailableWeapons014;  }
            if (Actor02 == NPC_AI.NPC_015) { iTempDesireToMove02 = NPC_AI.DesireToMove015; bTempCorpse02 = NPC_AI.bCorpse015; iTempLoyalty02 = NPC_AI.iLoyalty015; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins015; sTempWeapons02 = NPC_AI.sAvailableWeapons015;  }
            if (Actor02 == NPC_AI.NPC_016) { iTempDesireToMove02 = NPC_AI.DesireToMove016; bTempCorpse02 = NPC_AI.bCorpse016; iTempLoyalty02 = NPC_AI.iLoyalty016; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins016; sTempWeapons02 = NPC_AI.sAvailableWeapons016;  }
            if (Actor02 == NPC_AI.NPC_017) { iTempDesireToMove02 = NPC_AI.DesireToMove017; bTempCorpse02 = NPC_AI.bCorpse017; iTempLoyalty02 = NPC_AI.iLoyalty017; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins017; sTempWeapons02 = NPC_AI.sAvailableWeapons017;  }
            if (Actor02 == NPC_AI.NPC_018) { iTempDesireToMove02 = NPC_AI.DesireToMove018; bTempCorpse02 = NPC_AI.bCorpse018; iTempLoyalty02 = NPC_AI.iLoyalty018; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins018; sTempWeapons02 = NPC_AI.sAvailableWeapons018;  }
            if (Actor02 == NPC_AI.NPC_019) { iTempDesireToMove02 = NPC_AI.DesireToMove019; bTempCorpse02 = NPC_AI.bCorpse019; iTempLoyalty02 = NPC_AI.iLoyalty019; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins019; sTempWeapons02 = NPC_AI.sAvailableWeapons019;  }
            if (Actor02 == NPC_AI.NPC_020) { iTempDesireToMove02 = NPC_AI.DesireToMove020; bTempCorpse02 = NPC_AI.bCorpse020; iTempLoyalty02 = NPC_AI.iLoyalty020; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins020; sTempWeapons02 = NPC_AI.sAvailableWeapons020;  }
            if (Actor02 == NPC_AI.NPC_021) { iTempDesireToMove02 = NPC_AI.DesireToMove021; bTempCorpse02 = NPC_AI.bCorpse021; iTempLoyalty02 = NPC_AI.iLoyalty021; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins021; sTempWeapons02 = NPC_AI.sAvailableWeapons021;  }
            if (Actor02 == NPC_AI.NPC_022) { iTempDesireToMove02 = NPC_AI.DesireToMove022; bTempCorpse02 = NPC_AI.bCorpse022; iTempLoyalty02 = NPC_AI.iLoyalty022; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins022; sTempWeapons02 = NPC_AI.sAvailableWeapons022;  }
            if (Actor02 == NPC_AI.NPC_023) { iTempDesireToMove02 = NPC_AI.DesireToMove023; bTempCorpse02 = NPC_AI.bCorpse023; iTempLoyalty02 = NPC_AI.iLoyalty023; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins023; sTempWeapons02 = NPC_AI.sAvailableWeapons023;  }
            if (Actor02 == NPC_AI.NPC_024) { iTempDesireToMove02 = NPC_AI.DesireToMove024; bTempCorpse02 = NPC_AI.bCorpse024; iTempLoyalty02 = NPC_AI.iLoyalty024; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins024; sTempWeapons02 = NPC_AI.sAvailableWeapons024;  }
            if (Actor02 == NPC_AI.NPC_025) { iTempDesireToMove02 = NPC_AI.DesireToMove025; bTempCorpse02 = NPC_AI.bCorpse025; iTempLoyalty02 = NPC_AI.iLoyalty025; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins025; sTempWeapons02 = NPC_AI.sAvailableWeapons025;  }
            if (Actor02 == NPC_AI.NPC_026) { iTempDesireToMove02 = NPC_AI.DesireToMove026; bTempCorpse02 = NPC_AI.bCorpse026; iTempLoyalty02 = NPC_AI.iLoyalty026; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins026; sTempWeapons02 = NPC_AI.sAvailableWeapons026;  }
            if (Actor02 == NPC_AI.NPC_027) { iTempDesireToMove02 = NPC_AI.DesireToMove027; bTempCorpse02 = NPC_AI.bCorpse027; iTempLoyalty02 = NPC_AI.iLoyalty027; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins027; sTempWeapons02 = NPC_AI.sAvailableWeapons027;  }
            if (Actor02 == NPC_AI.NPC_028) { iTempDesireToMove02 = NPC_AI.DesireToMove028; bTempCorpse02 = NPC_AI.bCorpse028; iTempLoyalty02 = NPC_AI.iLoyalty028; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins028; sTempWeapons02 = NPC_AI.sAvailableWeapons028;  }
            if (Actor02 == NPC_AI.NPC_029) { iTempDesireToMove02 = NPC_AI.DesireToMove029; bTempCorpse02 = NPC_AI.bCorpse029; iTempLoyalty02 = NPC_AI.iLoyalty029; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins029; sTempWeapons02 = NPC_AI.sAvailableWeapons029;  }
            if (Actor02 == NPC_AI.NPC_030) { iTempDesireToMove02 = NPC_AI.DesireToMove030; bTempCorpse02 = NPC_AI.bCorpse030; iTempLoyalty02 = NPC_AI.iLoyalty030; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins030; sTempWeapons02 = NPC_AI.sAvailableWeapons030;  }
            if (Actor02 == NPC_AI.NPC_031) { iTempDesireToMove02 = NPC_AI.DesireToMove031; bTempCorpse02 = NPC_AI.bCorpse031; iTempLoyalty02 = NPC_AI.iLoyalty031; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins031; sTempWeapons02 = NPC_AI.sAvailableWeapons031;  }
            if (Actor02 == NPC_AI.NPC_032) { iTempDesireToMove02 = NPC_AI.DesireToMove032; bTempCorpse02 = NPC_AI.bCorpse032; iTempLoyalty02 = NPC_AI.iLoyalty032; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins032; sTempWeapons02 = NPC_AI.sAvailableWeapons032;  }
            if (Actor02 == NPC_AI.NPC_033) { iTempDesireToMove02 = NPC_AI.DesireToMove033; bTempCorpse02 = NPC_AI.bCorpse033; iTempLoyalty02 = NPC_AI.iLoyalty033; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins033; sTempWeapons02 = NPC_AI.sAvailableWeapons033;  }
            if (Actor02 == NPC_AI.NPC_034) { iTempDesireToMove02 = NPC_AI.DesireToMove034; bTempCorpse02 = NPC_AI.bCorpse034; iTempLoyalty02 = NPC_AI.iLoyalty034; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins034; sTempWeapons02 = NPC_AI.sAvailableWeapons034;  }
            if (Actor02 == NPC_AI.NPC_035) { iTempDesireToMove02 = NPC_AI.DesireToMove035; bTempCorpse02 = NPC_AI.bCorpse035; iTempLoyalty02 = NPC_AI.iLoyalty035; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins035; sTempWeapons02 = NPC_AI.sAvailableWeapons035;  }
            if (Actor02 == NPC_AI.NPC_036) { iTempDesireToMove02 = NPC_AI.DesireToMove036; bTempCorpse02 = NPC_AI.bCorpse036; iTempLoyalty02 = NPC_AI.iLoyalty036; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins036; sTempWeapons02 = NPC_AI.sAvailableWeapons036;  }
            if (Actor02 == NPC_AI.NPC_037) { iTempDesireToMove02 = NPC_AI.DesireToMove037; bTempCorpse02 = NPC_AI.bCorpse037; iTempLoyalty02 = NPC_AI.iLoyalty037; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins037; sTempWeapons02 = NPC_AI.sAvailableWeapons037;  }
            if (Actor02 == NPC_AI.NPC_038) { iTempDesireToMove02 = NPC_AI.DesireToMove038; bTempCorpse02 = NPC_AI.bCorpse038; iTempLoyalty02 = NPC_AI.iLoyalty038; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins038; sTempWeapons02 = NPC_AI.sAvailableWeapons038;  }
            if (Actor02 == NPC_AI.NPC_039) { iTempDesireToMove02 = NPC_AI.DesireToMove039; bTempCorpse02 = NPC_AI.bCorpse039; iTempLoyalty02 = NPC_AI.iLoyalty039; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins039; sTempWeapons02 = NPC_AI.sAvailableWeapons039;  }
            if (Actor02 == NPC_AI.NPC_040) { iTempDesireToMove02 = NPC_AI.DesireToMove040; bTempCorpse02 = NPC_AI.bCorpse040; iTempLoyalty02 = NPC_AI.iLoyalty040; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins040; sTempWeapons02 = NPC_AI.sAvailableWeapons040;  }
            if (Actor02 == NPC_AI.NPC_041) { iTempDesireToMove02 = NPC_AI.DesireToMove041; bTempCorpse02 = NPC_AI.bCorpse041; iTempLoyalty02 = NPC_AI.iLoyalty041; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins041; sTempWeapons02 = NPC_AI.sAvailableWeapons041;  }
            if (Actor02 == NPC_AI.NPC_042) { iTempDesireToMove02 = NPC_AI.DesireToMove042; bTempCorpse02 = NPC_AI.bCorpse042; iTempLoyalty02 = NPC_AI.iLoyalty042; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins042; sTempWeapons02 = NPC_AI.sAvailableWeapons042;  }
            if (Actor02 == NPC_AI.NPC_043) { iTempDesireToMove02 = NPC_AI.DesireToMove043; bTempCorpse02 = NPC_AI.bCorpse043; iTempLoyalty02 = NPC_AI.iLoyalty043; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins043; sTempWeapons02 = NPC_AI.sAvailableWeapons043;  }
            if (Actor02 == NPC_AI.NPC_044) { iTempDesireToMove02 = NPC_AI.DesireToMove044; bTempCorpse02 = NPC_AI.bCorpse044; iTempLoyalty02 = NPC_AI.iLoyalty044; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins044; sTempWeapons02 = NPC_AI.sAvailableWeapons044;  }
            if (Actor02 == NPC_AI.NPC_045) { iTempDesireToMove02 = NPC_AI.DesireToMove045; bTempCorpse02 = NPC_AI.bCorpse045; iTempLoyalty02 = NPC_AI.iLoyalty045; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins045; sTempWeapons02 = NPC_AI.sAvailableWeapons045;  }
            if (Actor02 == NPC_AI.NPC_046) { iTempDesireToMove02 = NPC_AI.DesireToMove046; bTempCorpse02 = NPC_AI.bCorpse046; iTempLoyalty02 = NPC_AI.iLoyalty046; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins046; sTempWeapons02 = NPC_AI.sAvailableWeapons046;  }
            if (Actor02 == NPC_AI.NPC_047) { iTempDesireToMove02 = NPC_AI.DesireToMove047; bTempCorpse02 = NPC_AI.bCorpse047; iTempLoyalty02 = NPC_AI.iLoyalty047; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins047; sTempWeapons02 = NPC_AI.sAvailableWeapons047;  }
            if (Actor02 == NPC_AI.NPC_048) { iTempDesireToMove02 = NPC_AI.DesireToMove048; bTempCorpse02 = NPC_AI.bCorpse048; iTempLoyalty02 = NPC_AI.iLoyalty048; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins048; sTempWeapons02 = NPC_AI.sAvailableWeapons048;  }
            if (Actor02 == NPC_AI.NPC_049) { iTempDesireToMove02 = NPC_AI.DesireToMove049; bTempCorpse02 = NPC_AI.bCorpse049; iTempLoyalty02 = NPC_AI.iLoyalty049; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins049; sTempWeapons02 = NPC_AI.sAvailableWeapons049;  }
            if (Actor02 == NPC_AI.NPC_050) { iTempDesireToMove02 = NPC_AI.DesireToMove050; bTempCorpse02 = NPC_AI.bCorpse050; iTempLoyalty02 = NPC_AI.iLoyalty050; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins050; sTempWeapons02 = NPC_AI.sAvailableWeapons050;  }
            if (Actor02 == NPC_AI.NPC_051) { iTempDesireToMove02 = NPC_AI.DesireToMove051; bTempCorpse02 = NPC_AI.bCorpse051; iTempLoyalty02 = NPC_AI.iLoyalty051; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins051; sTempWeapons02 = NPC_AI.sAvailableWeapons051;  }
            if (Actor02 == NPC_AI.NPC_052) { iTempDesireToMove02 = NPC_AI.DesireToMove052; bTempCorpse02 = NPC_AI.bCorpse052; iTempLoyalty02 = NPC_AI.iLoyalty052; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins052; sTempWeapons02 = NPC_AI.sAvailableWeapons052;  }
            if (Actor02 == NPC_AI.NPC_053) { iTempDesireToMove02 = NPC_AI.DesireToMove053; bTempCorpse02 = NPC_AI.bCorpse053; iTempLoyalty02 = NPC_AI.iLoyalty053; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins053; sTempWeapons02 = NPC_AI.sAvailableWeapons053;  }
            if (Actor02 == NPC_AI.NPC_054) { iTempDesireToMove02 = NPC_AI.DesireToMove054; bTempCorpse02 = NPC_AI.bCorpse054; iTempLoyalty02 = NPC_AI.iLoyalty054; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins054; sTempWeapons02 = NPC_AI.sAvailableWeapons054;  }
            if (Actor02 == NPC_AI.NPC_055) { iTempDesireToMove02 = NPC_AI.DesireToMove055; bTempCorpse02 = NPC_AI.bCorpse055; iTempLoyalty02 = NPC_AI.iLoyalty055; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins055; sTempWeapons02 = NPC_AI.sAvailableWeapons055;  }
            if (Actor02 == NPC_AI.NPC_056) { iTempDesireToMove02 = NPC_AI.DesireToMove056; bTempCorpse02 = NPC_AI.bCorpse056; iTempLoyalty02 = NPC_AI.iLoyalty056; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins056; sTempWeapons02 = NPC_AI.sAvailableWeapons056;  }
            if (Actor02 == NPC_AI.NPC_057) { iTempDesireToMove02 = NPC_AI.DesireToMove057; bTempCorpse02 = NPC_AI.bCorpse057; iTempLoyalty02 = NPC_AI.iLoyalty057; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins057; sTempWeapons02 = NPC_AI.sAvailableWeapons057;  }
            if (Actor02 == NPC_AI.NPC_058) { iTempDesireToMove02 = NPC_AI.DesireToMove058; bTempCorpse02 = NPC_AI.bCorpse058; iTempLoyalty02 = NPC_AI.iLoyalty058; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins058; sTempWeapons02 = NPC_AI.sAvailableWeapons058;  }
            if (Actor02 == NPC_AI.NPC_059) { iTempDesireToMove02 = NPC_AI.DesireToMove059; bTempCorpse02 = NPC_AI.bCorpse059; iTempLoyalty02 = NPC_AI.iLoyalty059; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins059; sTempWeapons02 = NPC_AI.sAvailableWeapons059;  }
            if (Actor02 == NPC_AI.NPC_060) { iTempDesireToMove02 = NPC_AI.DesireToMove060; bTempCorpse02 = NPC_AI.bCorpse060; iTempLoyalty02 = NPC_AI.iLoyalty060; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins060; sTempWeapons02 = NPC_AI.sAvailableWeapons060;  }
            if (Actor02 == NPC_AI.NPC_061) { iTempDesireToMove02 = NPC_AI.DesireToMove061; bTempCorpse02 = NPC_AI.bCorpse061; iTempLoyalty02 = NPC_AI.iLoyalty061; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins061; sTempWeapons02 = NPC_AI.sAvailableWeapons061;  }
            if (Actor02 == NPC_AI.NPC_062) { iTempDesireToMove02 = NPC_AI.DesireToMove062; bTempCorpse02 = NPC_AI.bCorpse062; iTempLoyalty02 = NPC_AI.iLoyalty062; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins062; sTempWeapons02 = NPC_AI.sAvailableWeapons062;  }
            if (Actor02 == NPC_AI.NPC_063) { iTempDesireToMove02 = NPC_AI.DesireToMove063; bTempCorpse02 = NPC_AI.bCorpse063; iTempLoyalty02 = NPC_AI.iLoyalty063; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins063; sTempWeapons02 = NPC_AI.sAvailableWeapons063;  }
            if (Actor02 == NPC_AI.NPC_064) { iTempDesireToMove02 = NPC_AI.DesireToMove064; bTempCorpse02 = NPC_AI.bCorpse064; iTempLoyalty02 = NPC_AI.iLoyalty054; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins064; sTempWeapons02 = NPC_AI.sAvailableWeapons064;  }
            if (Actor02 == NPC_AI.NPC_065) { iTempDesireToMove02 = NPC_AI.DesireToMove065; bTempCorpse02 = NPC_AI.bCorpse065; iTempLoyalty02 = NPC_AI.iLoyalty065; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins065; sTempWeapons02 = NPC_AI.sAvailableWeapons065;  }
            if (Actor02 == NPC_AI.NPC_066) { iTempDesireToMove02 = NPC_AI.DesireToMove066; bTempCorpse02 = NPC_AI.bCorpse066; iTempLoyalty02 = NPC_AI.iLoyalty066; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins066; sTempWeapons02 = NPC_AI.sAvailableWeapons066;  }
            if (Actor02 == NPC_AI.NPC_067) { iTempDesireToMove02 = NPC_AI.DesireToMove067; bTempCorpse02 = NPC_AI.bCorpse067; iTempLoyalty02 = NPC_AI.iLoyalty067; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins067; sTempWeapons02 = NPC_AI.sAvailableWeapons067;  }
            if (Actor02 == NPC_AI.NPC_068) { iTempDesireToMove02 = NPC_AI.DesireToMove068; bTempCorpse02 = NPC_AI.bCorpse068; iTempLoyalty02 = NPC_AI.iLoyalty068; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins068; sTempWeapons02 = NPC_AI.sAvailableWeapons068;  }
            if (Actor02 == NPC_AI.NPC_069) { iTempDesireToMove02 = NPC_AI.DesireToMove069; bTempCorpse02 = NPC_AI.bCorpse069; iTempLoyalty02 = NPC_AI.iLoyalty069; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins069; sTempWeapons02 = NPC_AI.sAvailableWeapons069;  }
            if (Actor02 == NPC_AI.NPC_070) { iTempDesireToMove02 = NPC_AI.DesireToMove070; bTempCorpse02 = NPC_AI.bCorpse070; iTempLoyalty02 = NPC_AI.iLoyalty070; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins070; sTempWeapons02 = NPC_AI.sAvailableWeapons070;  }
            if (Actor02 == NPC_AI.NPC_071) { iTempDesireToMove02 = NPC_AI.DesireToMove071; bTempCorpse02 = NPC_AI.bCorpse071; iTempLoyalty02 = NPC_AI.iLoyalty071; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins071; sTempWeapons02 = NPC_AI.sAvailableWeapons071;  }
            if (Actor02 == NPC_AI.NPC_072) { iTempDesireToMove02 = NPC_AI.DesireToMove072; bTempCorpse02 = NPC_AI.bCorpse072; iTempLoyalty02 = NPC_AI.iLoyalty072; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins072; sTempWeapons02 = NPC_AI.sAvailableWeapons072;  }
            if (Actor02 == NPC_AI.NPC_073) { iTempDesireToMove02 = NPC_AI.DesireToMove073; bTempCorpse02 = NPC_AI.bCorpse073; iTempLoyalty02 = NPC_AI.iLoyalty073; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins073; sTempWeapons02 = NPC_AI.sAvailableWeapons073;  }
            if (Actor02 == NPC_AI.NPC_074) { iTempDesireToMove02 = NPC_AI.DesireToMove074; bTempCorpse02 = NPC_AI.bCorpse074; iTempLoyalty02 = NPC_AI.iLoyalty074; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins074; sTempWeapons02 = NPC_AI.sAvailableWeapons074;  }
            if (Actor02 == NPC_AI.NPC_075) { iTempDesireToMove02 = NPC_AI.DesireToMove075; bTempCorpse02 = NPC_AI.bCorpse075; iTempLoyalty02 = NPC_AI.iLoyalty075; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins075; sTempWeapons02 = NPC_AI.sAvailableWeapons075;  }
            if (Actor02 == NPC_AI.NPC_076) { iTempDesireToMove02 = NPC_AI.DesireToMove076; bTempCorpse02 = NPC_AI.bCorpse076; iTempLoyalty02 = NPC_AI.iLoyalty076; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins076; sTempWeapons02 = NPC_AI.sAvailableWeapons076;  }
            if (Actor02 == NPC_AI.NPC_077) { iTempDesireToMove02 = NPC_AI.DesireToMove077; bTempCorpse02 = NPC_AI.bCorpse077; iTempLoyalty02 = NPC_AI.iLoyalty077; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins077; sTempWeapons02 = NPC_AI.sAvailableWeapons077;  }
            if (Actor02 == NPC_AI.NPC_078) { iTempDesireToMove02 = NPC_AI.DesireToMove078; bTempCorpse02 = NPC_AI.bCorpse078; iTempLoyalty02 = NPC_AI.iLoyalty078; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins078; sTempWeapons02 = NPC_AI.sAvailableWeapons078;  }
            if (Actor02 == NPC_AI.NPC_079) { iTempDesireToMove02 = NPC_AI.DesireToMove079; bTempCorpse02 = NPC_AI.bCorpse079; iTempLoyalty02 = NPC_AI.iLoyalty079; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins079; sTempWeapons02 = NPC_AI.sAvailableWeapons079;  }
            if (Actor02 == NPC_AI.NPC_080) { iTempDesireToMove02 = NPC_AI.DesireToMove080; bTempCorpse02 = NPC_AI.bCorpse080; iTempLoyalty02 = NPC_AI.iLoyalty080; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins080; sTempWeapons02 = NPC_AI.sAvailableWeapons080;  }
            if (Actor02 == NPC_AI.NPC_081) { iTempDesireToMove02 = NPC_AI.DesireToMove081; bTempCorpse02 = NPC_AI.bCorpse081; iTempLoyalty02 = NPC_AI.iLoyalty081; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins081; sTempWeapons02 = NPC_AI.sAvailableWeapons081;  }
            if (Actor02 == NPC_AI.NPC_082) { iTempDesireToMove02 = NPC_AI.DesireToMove082; bTempCorpse02 = NPC_AI.bCorpse082; iTempLoyalty02 = NPC_AI.iLoyalty082; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins082; sTempWeapons02 = NPC_AI.sAvailableWeapons082;  }
            if (Actor02 == NPC_AI.NPC_083) { iTempDesireToMove02 = NPC_AI.DesireToMove083; bTempCorpse02 = NPC_AI.bCorpse083; iTempLoyalty02 = NPC_AI.iLoyalty083; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins083; sTempWeapons02 = NPC_AI.sAvailableWeapons083;  }
            if (Actor02 == NPC_AI.NPC_084) { iTempDesireToMove02 = NPC_AI.DesireToMove084; bTempCorpse02 = NPC_AI.bCorpse084; iTempLoyalty02 = NPC_AI.iLoyalty084; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins084; sTempWeapons02 = NPC_AI.sAvailableWeapons084;  }
            if (Actor02 == NPC_AI.NPC_085) { iTempDesireToMove02 = NPC_AI.DesireToMove085; bTempCorpse02 = NPC_AI.bCorpse085; iTempLoyalty02 = NPC_AI.iLoyalty085; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins085; sTempWeapons02 = NPC_AI.sAvailableWeapons085;  }
            if (Actor02 == NPC_AI.NPC_086) { iTempDesireToMove02 = NPC_AI.DesireToMove086; bTempCorpse02 = NPC_AI.bCorpse086; iTempLoyalty02 = NPC_AI.iLoyalty086; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins086; sTempWeapons02 = NPC_AI.sAvailableWeapons086;  }
            if (Actor02 == NPC_AI.NPC_087) { iTempDesireToMove02 = NPC_AI.DesireToMove087; bTempCorpse02 = NPC_AI.bCorpse087; iTempLoyalty02 = NPC_AI.iLoyalty087; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins087; sTempWeapons02 = NPC_AI.sAvailableWeapons087;  }
            if (Actor02 == NPC_AI.NPC_088) { iTempDesireToMove02 = NPC_AI.DesireToMove088; bTempCorpse02 = NPC_AI.bCorpse088; iTempLoyalty02 = NPC_AI.iLoyalty088; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins088; sTempWeapons02 = NPC_AI.sAvailableWeapons088;  }
            if (Actor02 == NPC_AI.NPC_089) { iTempDesireToMove02 = NPC_AI.DesireToMove089; bTempCorpse02 = NPC_AI.bCorpse089; iTempLoyalty02 = NPC_AI.iLoyalty089; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins089; sTempWeapons02 = NPC_AI.sAvailableWeapons089;  }
            if (Actor02 == NPC_AI.NPC_090) { iTempDesireToMove02 = NPC_AI.DesireToMove090; bTempCorpse02 = NPC_AI.bCorpse090; iTempLoyalty02 = NPC_AI.iLoyalty090; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins090; sTempWeapons02 = NPC_AI.sAvailableWeapons090;  }
            if (Actor02 == NPC_AI.NPC_091) { iTempDesireToMove02 = NPC_AI.DesireToMove091; bTempCorpse02 = NPC_AI.bCorpse091; iTempLoyalty02 = NPC_AI.iLoyalty091; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins091; sTempWeapons02 = NPC_AI.sAvailableWeapons091;  }
            if (Actor02 == NPC_AI.NPC_092) { iTempDesireToMove02 = NPC_AI.DesireToMove092; bTempCorpse02 = NPC_AI.bCorpse092; iTempLoyalty02 = NPC_AI.iLoyalty092; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins092; sTempWeapons02 = NPC_AI.sAvailableWeapons092;  }
            if (Actor02 == NPC_AI.NPC_093) { iTempDesireToMove02 = NPC_AI.DesireToMove093; bTempCorpse02 = NPC_AI.bCorpse093; iTempLoyalty02 = NPC_AI.iLoyalty093; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins093; sTempWeapons02 = NPC_AI.sAvailableWeapons093;  }
            if (Actor02 == NPC_AI.NPC_094) { iTempDesireToMove02 = NPC_AI.DesireToMove094; bTempCorpse02 = NPC_AI.bCorpse094; iTempLoyalty02 = NPC_AI.iLoyalty094; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins094; sTempWeapons02 = NPC_AI.sAvailableWeapons094;  }
            if (Actor02 == NPC_AI.NPC_095) { iTempDesireToMove02 = NPC_AI.DesireToMove095; bTempCorpse02 = NPC_AI.bCorpse095; iTempLoyalty02 = NPC_AI.iLoyalty095; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins095; sTempWeapons02 = NPC_AI.sAvailableWeapons095;  }
            if (Actor02 == NPC_AI.NPC_096) { iTempDesireToMove02 = NPC_AI.DesireToMove096; bTempCorpse02 = NPC_AI.bCorpse096; iTempLoyalty02 = NPC_AI.iLoyalty096; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins096; sTempWeapons02 = NPC_AI.sAvailableWeapons096;  }
            if (Actor02 == NPC_AI.NPC_097) { iTempDesireToMove02 = NPC_AI.DesireToMove097; bTempCorpse02 = NPC_AI.bCorpse097; iTempLoyalty02 = NPC_AI.iLoyalty097; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins097; sTempWeapons02 = NPC_AI.sAvailableWeapons097;  }
            if (Actor02 == NPC_AI.NPC_098) { iTempDesireToMove02 = NPC_AI.DesireToMove098; bTempCorpse02 = NPC_AI.bCorpse098; iTempLoyalty02 = NPC_AI.iLoyalty098; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins098; sTempWeapons02 = NPC_AI.sAvailableWeapons098;  }
            if (Actor02 == NPC_AI.NPC_099) { iTempDesireToMove02 = NPC_AI.DesireToMove099; bTempCorpse02 = NPC_AI.bCorpse099; iTempLoyalty02 = NPC_AI.iLoyalty099; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins099; sTempWeapons02 = NPC_AI.sAvailableWeapons099;  }
            if (Actor02 == NPC_AI.NPC_100) { iTempDesireToMove02 = NPC_AI.DesireToMove100; bTempCorpse02 = NPC_AI.bCorpse100; iTempLoyalty02 = NPC_AI.iLoyalty100; iTempMacGuffins02 = NPC_AI.iAvailableMacGuffins100; sTempWeapons02 = NPC_AI.sAvailableWeapons100;  }

            if (Actor03 == NPC_AI.NPC_001) { iTempDesireToMove03 = NPC_AI.DesireToMove001; bTempCorpse03 = NPC_AI.bCorpse001; iTempLoyalty03 = NPC_AI.iLoyalty001; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins001; sTempWeapons03 = NPC_AI.sAvailableWeapons001; }
            if (Actor03 == NPC_AI.NPC_002) { iTempDesireToMove03 = NPC_AI.DesireToMove002; bTempCorpse03 = NPC_AI.bCorpse002; iTempLoyalty03 = NPC_AI.iLoyalty002; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins002; sTempWeapons03 = NPC_AI.sAvailableWeapons002; }
            if (Actor03 == NPC_AI.NPC_003) { iTempDesireToMove03 = NPC_AI.DesireToMove003; bTempCorpse03 = NPC_AI.bCorpse003; iTempLoyalty03 = NPC_AI.iLoyalty003; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins003; sTempWeapons03 = NPC_AI.sAvailableWeapons003; }
            if (Actor03 == NPC_AI.NPC_004) { iTempDesireToMove03 = NPC_AI.DesireToMove004; bTempCorpse03 = NPC_AI.bCorpse004; iTempLoyalty03 = NPC_AI.iLoyalty004; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins004; sTempWeapons03 = NPC_AI.sAvailableWeapons004; }
            if (Actor03 == NPC_AI.NPC_005) { iTempDesireToMove03 = NPC_AI.DesireToMove005; bTempCorpse03 = NPC_AI.bCorpse005; iTempLoyalty03 = NPC_AI.iLoyalty005; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins005; sTempWeapons03 = NPC_AI.sAvailableWeapons005; }
            if (Actor03 == NPC_AI.NPC_006) { iTempDesireToMove03 = NPC_AI.DesireToMove006; bTempCorpse03 = NPC_AI.bCorpse006; iTempLoyalty03 = NPC_AI.iLoyalty006; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins006; sTempWeapons03 = NPC_AI.sAvailableWeapons006; }
            if (Actor03 == NPC_AI.NPC_007) { iTempDesireToMove03 = NPC_AI.DesireToMove007; bTempCorpse03 = NPC_AI.bCorpse007; iTempLoyalty03 = NPC_AI.iLoyalty007; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins007; sTempWeapons03 = NPC_AI.sAvailableWeapons007; }
            if (Actor03 == NPC_AI.NPC_008) { iTempDesireToMove03 = NPC_AI.DesireToMove008; bTempCorpse03 = NPC_AI.bCorpse008; iTempLoyalty03 = NPC_AI.iLoyalty008; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins008; sTempWeapons03 = NPC_AI.sAvailableWeapons008; }
            if (Actor03 == NPC_AI.NPC_009) { iTempDesireToMove03 = NPC_AI.DesireToMove009; bTempCorpse03 = NPC_AI.bCorpse009; iTempLoyalty03 = NPC_AI.iLoyalty009; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins009; sTempWeapons03 = NPC_AI.sAvailableWeapons009; }
            if (Actor03 == NPC_AI.NPC_010) { iTempDesireToMove03 = NPC_AI.DesireToMove010; bTempCorpse03 = NPC_AI.bCorpse010; iTempLoyalty03 = NPC_AI.iLoyalty010; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins010; sTempWeapons03 = NPC_AI.sAvailableWeapons010; }
            if (Actor03 == NPC_AI.NPC_011) { iTempDesireToMove03 = NPC_AI.DesireToMove011; bTempCorpse03 = NPC_AI.bCorpse011; iTempLoyalty03 = NPC_AI.iLoyalty011; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins011; sTempWeapons03 = NPC_AI.sAvailableWeapons011; }
            if (Actor03 == NPC_AI.NPC_012) { iTempDesireToMove03 = NPC_AI.DesireToMove012; bTempCorpse03 = NPC_AI.bCorpse012; iTempLoyalty03 = NPC_AI.iLoyalty012; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins012; sTempWeapons03 = NPC_AI.sAvailableWeapons012; }
            if (Actor03 == NPC_AI.NPC_013) { iTempDesireToMove03 = NPC_AI.DesireToMove013; bTempCorpse03 = NPC_AI.bCorpse013; iTempLoyalty03 = NPC_AI.iLoyalty013; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins013; sTempWeapons03 = NPC_AI.sAvailableWeapons013; }
            if (Actor03 == NPC_AI.NPC_014) { iTempDesireToMove03 = NPC_AI.DesireToMove014; bTempCorpse03 = NPC_AI.bCorpse014; iTempLoyalty03 = NPC_AI.iLoyalty014; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins014; sTempWeapons03 = NPC_AI.sAvailableWeapons014; }
            if (Actor03 == NPC_AI.NPC_015) { iTempDesireToMove03 = NPC_AI.DesireToMove015; bTempCorpse03 = NPC_AI.bCorpse015; iTempLoyalty03 = NPC_AI.iLoyalty015; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins015; sTempWeapons03 = NPC_AI.sAvailableWeapons015; }
            if (Actor03 == NPC_AI.NPC_016) { iTempDesireToMove03 = NPC_AI.DesireToMove016; bTempCorpse03 = NPC_AI.bCorpse016; iTempLoyalty03 = NPC_AI.iLoyalty016; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins016; sTempWeapons03 = NPC_AI.sAvailableWeapons016; }
            if (Actor03 == NPC_AI.NPC_017) { iTempDesireToMove03 = NPC_AI.DesireToMove017; bTempCorpse03 = NPC_AI.bCorpse017; iTempLoyalty03 = NPC_AI.iLoyalty017; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins017; sTempWeapons03 = NPC_AI.sAvailableWeapons017; }
            if (Actor03 == NPC_AI.NPC_018) { iTempDesireToMove03 = NPC_AI.DesireToMove018; bTempCorpse03 = NPC_AI.bCorpse018; iTempLoyalty03 = NPC_AI.iLoyalty018; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins018; sTempWeapons03 = NPC_AI.sAvailableWeapons018; }
            if (Actor03 == NPC_AI.NPC_019) { iTempDesireToMove03 = NPC_AI.DesireToMove019; bTempCorpse03 = NPC_AI.bCorpse019; iTempLoyalty03 = NPC_AI.iLoyalty019; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins019; sTempWeapons03 = NPC_AI.sAvailableWeapons019; }
            if (Actor03 == NPC_AI.NPC_020) { iTempDesireToMove03 = NPC_AI.DesireToMove020; bTempCorpse03 = NPC_AI.bCorpse020; iTempLoyalty03 = NPC_AI.iLoyalty020; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins020; sTempWeapons03 = NPC_AI.sAvailableWeapons020; }
            if (Actor03 == NPC_AI.NPC_021) { iTempDesireToMove03 = NPC_AI.DesireToMove021; bTempCorpse03 = NPC_AI.bCorpse021; iTempLoyalty03 = NPC_AI.iLoyalty021; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins021; sTempWeapons03 = NPC_AI.sAvailableWeapons021; }
            if (Actor03 == NPC_AI.NPC_022) { iTempDesireToMove03 = NPC_AI.DesireToMove022; bTempCorpse03 = NPC_AI.bCorpse022; iTempLoyalty03 = NPC_AI.iLoyalty022; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins022; sTempWeapons03 = NPC_AI.sAvailableWeapons022; }
            if (Actor03 == NPC_AI.NPC_023) { iTempDesireToMove03 = NPC_AI.DesireToMove023; bTempCorpse03 = NPC_AI.bCorpse023; iTempLoyalty03 = NPC_AI.iLoyalty023; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins023; sTempWeapons03 = NPC_AI.sAvailableWeapons023; }
            if (Actor03 == NPC_AI.NPC_024) { iTempDesireToMove03 = NPC_AI.DesireToMove024; bTempCorpse03 = NPC_AI.bCorpse024; iTempLoyalty03 = NPC_AI.iLoyalty024; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins024; sTempWeapons03 = NPC_AI.sAvailableWeapons024; }
            if (Actor03 == NPC_AI.NPC_025) { iTempDesireToMove03 = NPC_AI.DesireToMove025; bTempCorpse03 = NPC_AI.bCorpse025; iTempLoyalty03 = NPC_AI.iLoyalty025; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins025; sTempWeapons03 = NPC_AI.sAvailableWeapons025; }
            if (Actor03 == NPC_AI.NPC_026) { iTempDesireToMove03 = NPC_AI.DesireToMove026; bTempCorpse03 = NPC_AI.bCorpse026; iTempLoyalty03 = NPC_AI.iLoyalty026; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins026; sTempWeapons03 = NPC_AI.sAvailableWeapons026; }
            if (Actor03 == NPC_AI.NPC_027) { iTempDesireToMove03 = NPC_AI.DesireToMove027; bTempCorpse03 = NPC_AI.bCorpse027; iTempLoyalty03 = NPC_AI.iLoyalty027; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins027; sTempWeapons03 = NPC_AI.sAvailableWeapons027; }
            if (Actor03 == NPC_AI.NPC_028) { iTempDesireToMove03 = NPC_AI.DesireToMove028; bTempCorpse03 = NPC_AI.bCorpse028; iTempLoyalty03 = NPC_AI.iLoyalty028; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins028; sTempWeapons03 = NPC_AI.sAvailableWeapons028; }
            if (Actor03 == NPC_AI.NPC_029) { iTempDesireToMove03 = NPC_AI.DesireToMove029; bTempCorpse03 = NPC_AI.bCorpse029; iTempLoyalty03 = NPC_AI.iLoyalty029; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins029; sTempWeapons03 = NPC_AI.sAvailableWeapons029; }
            if (Actor03 == NPC_AI.NPC_030) { iTempDesireToMove03 = NPC_AI.DesireToMove030; bTempCorpse03 = NPC_AI.bCorpse030; iTempLoyalty03 = NPC_AI.iLoyalty030; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins030; sTempWeapons03 = NPC_AI.sAvailableWeapons030; }
            if (Actor03 == NPC_AI.NPC_031) { iTempDesireToMove03 = NPC_AI.DesireToMove031; bTempCorpse03 = NPC_AI.bCorpse031; iTempLoyalty03 = NPC_AI.iLoyalty031; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins031; sTempWeapons03 = NPC_AI.sAvailableWeapons031; }
            if (Actor03 == NPC_AI.NPC_032) { iTempDesireToMove03 = NPC_AI.DesireToMove032; bTempCorpse03 = NPC_AI.bCorpse032; iTempLoyalty03 = NPC_AI.iLoyalty032; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins032; sTempWeapons03 = NPC_AI.sAvailableWeapons032; }
            if (Actor03 == NPC_AI.NPC_033) { iTempDesireToMove03 = NPC_AI.DesireToMove033; bTempCorpse03 = NPC_AI.bCorpse033; iTempLoyalty03 = NPC_AI.iLoyalty033; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins033; sTempWeapons03 = NPC_AI.sAvailableWeapons033; }
            if (Actor03 == NPC_AI.NPC_034) { iTempDesireToMove03 = NPC_AI.DesireToMove034; bTempCorpse03 = NPC_AI.bCorpse034; iTempLoyalty03 = NPC_AI.iLoyalty034; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins034; sTempWeapons03 = NPC_AI.sAvailableWeapons034; }
            if (Actor03 == NPC_AI.NPC_035) { iTempDesireToMove03 = NPC_AI.DesireToMove035; bTempCorpse03 = NPC_AI.bCorpse035; iTempLoyalty03 = NPC_AI.iLoyalty035; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins035; sTempWeapons03 = NPC_AI.sAvailableWeapons035; }
            if (Actor03 == NPC_AI.NPC_036) { iTempDesireToMove03 = NPC_AI.DesireToMove036; bTempCorpse03 = NPC_AI.bCorpse036; iTempLoyalty03 = NPC_AI.iLoyalty036; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins036; sTempWeapons03 = NPC_AI.sAvailableWeapons036; }
            if (Actor03 == NPC_AI.NPC_037) { iTempDesireToMove03 = NPC_AI.DesireToMove037; bTempCorpse03 = NPC_AI.bCorpse037; iTempLoyalty03 = NPC_AI.iLoyalty037; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins037; sTempWeapons03 = NPC_AI.sAvailableWeapons037; }
            if (Actor03 == NPC_AI.NPC_038) { iTempDesireToMove03 = NPC_AI.DesireToMove038; bTempCorpse03 = NPC_AI.bCorpse038; iTempLoyalty03 = NPC_AI.iLoyalty038; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins038; sTempWeapons03 = NPC_AI.sAvailableWeapons038; }
            if (Actor03 == NPC_AI.NPC_039) { iTempDesireToMove03 = NPC_AI.DesireToMove039; bTempCorpse03 = NPC_AI.bCorpse039; iTempLoyalty03 = NPC_AI.iLoyalty039; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins039; sTempWeapons03 = NPC_AI.sAvailableWeapons039; }
            if (Actor03 == NPC_AI.NPC_040) { iTempDesireToMove03 = NPC_AI.DesireToMove040; bTempCorpse03 = NPC_AI.bCorpse040; iTempLoyalty03 = NPC_AI.iLoyalty040; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins040; sTempWeapons03 = NPC_AI.sAvailableWeapons040; }
            if (Actor03 == NPC_AI.NPC_041) { iTempDesireToMove03 = NPC_AI.DesireToMove041; bTempCorpse03 = NPC_AI.bCorpse041; iTempLoyalty03 = NPC_AI.iLoyalty041; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins041; sTempWeapons03 = NPC_AI.sAvailableWeapons041; }
            if (Actor03 == NPC_AI.NPC_042) { iTempDesireToMove03 = NPC_AI.DesireToMove042; bTempCorpse03 = NPC_AI.bCorpse042; iTempLoyalty03 = NPC_AI.iLoyalty042; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins042; sTempWeapons03 = NPC_AI.sAvailableWeapons042; }
            if (Actor03 == NPC_AI.NPC_043) { iTempDesireToMove03 = NPC_AI.DesireToMove043; bTempCorpse03 = NPC_AI.bCorpse043; iTempLoyalty03 = NPC_AI.iLoyalty043; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins043; sTempWeapons03 = NPC_AI.sAvailableWeapons043; }
            if (Actor03 == NPC_AI.NPC_044) { iTempDesireToMove03 = NPC_AI.DesireToMove044; bTempCorpse03 = NPC_AI.bCorpse044; iTempLoyalty03 = NPC_AI.iLoyalty044; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins044; sTempWeapons03 = NPC_AI.sAvailableWeapons044; }
            if (Actor03 == NPC_AI.NPC_045) { iTempDesireToMove03 = NPC_AI.DesireToMove045; bTempCorpse03 = NPC_AI.bCorpse045; iTempLoyalty03 = NPC_AI.iLoyalty045; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins045; sTempWeapons03 = NPC_AI.sAvailableWeapons045; }
            if (Actor03 == NPC_AI.NPC_046) { iTempDesireToMove03 = NPC_AI.DesireToMove046; bTempCorpse03 = NPC_AI.bCorpse046; iTempLoyalty03 = NPC_AI.iLoyalty046; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins046; sTempWeapons03 = NPC_AI.sAvailableWeapons046; }
            if (Actor03 == NPC_AI.NPC_047) { iTempDesireToMove03 = NPC_AI.DesireToMove047; bTempCorpse03 = NPC_AI.bCorpse047; iTempLoyalty03 = NPC_AI.iLoyalty047; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins047; sTempWeapons03 = NPC_AI.sAvailableWeapons047; }
            if (Actor03 == NPC_AI.NPC_048) { iTempDesireToMove03 = NPC_AI.DesireToMove048; bTempCorpse03 = NPC_AI.bCorpse048; iTempLoyalty03 = NPC_AI.iLoyalty048; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins048; sTempWeapons03 = NPC_AI.sAvailableWeapons048; }
            if (Actor03 == NPC_AI.NPC_049) { iTempDesireToMove03 = NPC_AI.DesireToMove049; bTempCorpse03 = NPC_AI.bCorpse049; iTempLoyalty03 = NPC_AI.iLoyalty049; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins049; sTempWeapons03 = NPC_AI.sAvailableWeapons049; }
            if (Actor03 == NPC_AI.NPC_050) { iTempDesireToMove03 = NPC_AI.DesireToMove050; bTempCorpse03 = NPC_AI.bCorpse050; iTempLoyalty03 = NPC_AI.iLoyalty050; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins050; sTempWeapons03 = NPC_AI.sAvailableWeapons050; }
            if (Actor03 == NPC_AI.NPC_051) { iTempDesireToMove03 = NPC_AI.DesireToMove051; bTempCorpse03 = NPC_AI.bCorpse051; iTempLoyalty03 = NPC_AI.iLoyalty051; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins051; sTempWeapons03 = NPC_AI.sAvailableWeapons051; }
            if (Actor03 == NPC_AI.NPC_052) { iTempDesireToMove03 = NPC_AI.DesireToMove052; bTempCorpse03 = NPC_AI.bCorpse052; iTempLoyalty03 = NPC_AI.iLoyalty052; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins052; sTempWeapons03 = NPC_AI.sAvailableWeapons052; }
            if (Actor03 == NPC_AI.NPC_053) { iTempDesireToMove03 = NPC_AI.DesireToMove053; bTempCorpse03 = NPC_AI.bCorpse053; iTempLoyalty03 = NPC_AI.iLoyalty053; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins053; sTempWeapons03 = NPC_AI.sAvailableWeapons053; }
            if (Actor03 == NPC_AI.NPC_054) { iTempDesireToMove03 = NPC_AI.DesireToMove054; bTempCorpse03 = NPC_AI.bCorpse054; iTempLoyalty03 = NPC_AI.iLoyalty054; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins054; sTempWeapons03 = NPC_AI.sAvailableWeapons054; }
            if (Actor03 == NPC_AI.NPC_055) { iTempDesireToMove03 = NPC_AI.DesireToMove055; bTempCorpse03 = NPC_AI.bCorpse055; iTempLoyalty03 = NPC_AI.iLoyalty055; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins055; sTempWeapons03 = NPC_AI.sAvailableWeapons055; }
            if (Actor03 == NPC_AI.NPC_056) { iTempDesireToMove03 = NPC_AI.DesireToMove056; bTempCorpse03 = NPC_AI.bCorpse056; iTempLoyalty03 = NPC_AI.iLoyalty056; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins056; sTempWeapons03 = NPC_AI.sAvailableWeapons056; }
            if (Actor03 == NPC_AI.NPC_057) { iTempDesireToMove03 = NPC_AI.DesireToMove057; bTempCorpse03 = NPC_AI.bCorpse057; iTempLoyalty03 = NPC_AI.iLoyalty057; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins057; sTempWeapons03 = NPC_AI.sAvailableWeapons057; }
            if (Actor03 == NPC_AI.NPC_058) { iTempDesireToMove03 = NPC_AI.DesireToMove058; bTempCorpse03 = NPC_AI.bCorpse058; iTempLoyalty03 = NPC_AI.iLoyalty058; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins058; sTempWeapons03 = NPC_AI.sAvailableWeapons058; }
            if (Actor03 == NPC_AI.NPC_059) { iTempDesireToMove03 = NPC_AI.DesireToMove059; bTempCorpse03 = NPC_AI.bCorpse059; iTempLoyalty03 = NPC_AI.iLoyalty059; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins059; sTempWeapons03 = NPC_AI.sAvailableWeapons059; }
            if (Actor03 == NPC_AI.NPC_060) { iTempDesireToMove03 = NPC_AI.DesireToMove060; bTempCorpse03 = NPC_AI.bCorpse060; iTempLoyalty03 = NPC_AI.iLoyalty060; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins060; sTempWeapons03 = NPC_AI.sAvailableWeapons060; }
            if (Actor03 == NPC_AI.NPC_061) { iTempDesireToMove03 = NPC_AI.DesireToMove061; bTempCorpse03 = NPC_AI.bCorpse061; iTempLoyalty03 = NPC_AI.iLoyalty061; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins061; sTempWeapons03 = NPC_AI.sAvailableWeapons061; }
            if (Actor03 == NPC_AI.NPC_062) { iTempDesireToMove03 = NPC_AI.DesireToMove062; bTempCorpse03 = NPC_AI.bCorpse062; iTempLoyalty03 = NPC_AI.iLoyalty062; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins062; sTempWeapons03 = NPC_AI.sAvailableWeapons062; }
            if (Actor03 == NPC_AI.NPC_063) { iTempDesireToMove03 = NPC_AI.DesireToMove063; bTempCorpse03 = NPC_AI.bCorpse063; iTempLoyalty03 = NPC_AI.iLoyalty063; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins063; sTempWeapons03 = NPC_AI.sAvailableWeapons063; }
            if (Actor03 == NPC_AI.NPC_064) { iTempDesireToMove03 = NPC_AI.DesireToMove064; bTempCorpse03 = NPC_AI.bCorpse064; iTempLoyalty03 = NPC_AI.iLoyalty054; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins064; sTempWeapons03 = NPC_AI.sAvailableWeapons064; }
            if (Actor03 == NPC_AI.NPC_065) { iTempDesireToMove03 = NPC_AI.DesireToMove065; bTempCorpse03 = NPC_AI.bCorpse065; iTempLoyalty03 = NPC_AI.iLoyalty065; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins065; sTempWeapons03 = NPC_AI.sAvailableWeapons065; }
            if (Actor03 == NPC_AI.NPC_066) { iTempDesireToMove03 = NPC_AI.DesireToMove066; bTempCorpse03 = NPC_AI.bCorpse066; iTempLoyalty03 = NPC_AI.iLoyalty066; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins066; sTempWeapons03 = NPC_AI.sAvailableWeapons066; }
            if (Actor03 == NPC_AI.NPC_067) { iTempDesireToMove03 = NPC_AI.DesireToMove067; bTempCorpse03 = NPC_AI.bCorpse067; iTempLoyalty03 = NPC_AI.iLoyalty067; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins067; sTempWeapons03 = NPC_AI.sAvailableWeapons067; }
            if (Actor03 == NPC_AI.NPC_068) { iTempDesireToMove03 = NPC_AI.DesireToMove068; bTempCorpse03 = NPC_AI.bCorpse068; iTempLoyalty03 = NPC_AI.iLoyalty068; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins068; sTempWeapons03 = NPC_AI.sAvailableWeapons068; }
            if (Actor03 == NPC_AI.NPC_069) { iTempDesireToMove03 = NPC_AI.DesireToMove069; bTempCorpse03 = NPC_AI.bCorpse069; iTempLoyalty03 = NPC_AI.iLoyalty069; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins069; sTempWeapons03 = NPC_AI.sAvailableWeapons069; }
            if (Actor03 == NPC_AI.NPC_070) { iTempDesireToMove03 = NPC_AI.DesireToMove070; bTempCorpse03 = NPC_AI.bCorpse070; iTempLoyalty03 = NPC_AI.iLoyalty070; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins070; sTempWeapons03 = NPC_AI.sAvailableWeapons070; }
            if (Actor03 == NPC_AI.NPC_071) { iTempDesireToMove03 = NPC_AI.DesireToMove071; bTempCorpse03 = NPC_AI.bCorpse071; iTempLoyalty03 = NPC_AI.iLoyalty071; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins071; sTempWeapons03 = NPC_AI.sAvailableWeapons071; }
            if (Actor03 == NPC_AI.NPC_072) { iTempDesireToMove03 = NPC_AI.DesireToMove072; bTempCorpse03 = NPC_AI.bCorpse072; iTempLoyalty03 = NPC_AI.iLoyalty072; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins072; sTempWeapons03 = NPC_AI.sAvailableWeapons072; }
            if (Actor03 == NPC_AI.NPC_073) { iTempDesireToMove03 = NPC_AI.DesireToMove073; bTempCorpse03 = NPC_AI.bCorpse073; iTempLoyalty03 = NPC_AI.iLoyalty073; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins073; sTempWeapons03 = NPC_AI.sAvailableWeapons073; }
            if (Actor03 == NPC_AI.NPC_074) { iTempDesireToMove03 = NPC_AI.DesireToMove074; bTempCorpse03 = NPC_AI.bCorpse074; iTempLoyalty03 = NPC_AI.iLoyalty074; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins074; sTempWeapons03 = NPC_AI.sAvailableWeapons074; }
            if (Actor03 == NPC_AI.NPC_075) { iTempDesireToMove03 = NPC_AI.DesireToMove075; bTempCorpse03 = NPC_AI.bCorpse075; iTempLoyalty03 = NPC_AI.iLoyalty075; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins075; sTempWeapons03 = NPC_AI.sAvailableWeapons075; }
            if (Actor03 == NPC_AI.NPC_076) { iTempDesireToMove03 = NPC_AI.DesireToMove076; bTempCorpse03 = NPC_AI.bCorpse076; iTempLoyalty03 = NPC_AI.iLoyalty076; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins076; sTempWeapons03 = NPC_AI.sAvailableWeapons076; }
            if (Actor03 == NPC_AI.NPC_077) { iTempDesireToMove03 = NPC_AI.DesireToMove077; bTempCorpse03 = NPC_AI.bCorpse077; iTempLoyalty03 = NPC_AI.iLoyalty077; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins077; sTempWeapons03 = NPC_AI.sAvailableWeapons077; }
            if (Actor03 == NPC_AI.NPC_078) { iTempDesireToMove03 = NPC_AI.DesireToMove078; bTempCorpse03 = NPC_AI.bCorpse078; iTempLoyalty03 = NPC_AI.iLoyalty078; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins078; sTempWeapons03 = NPC_AI.sAvailableWeapons078; }
            if (Actor03 == NPC_AI.NPC_079) { iTempDesireToMove03 = NPC_AI.DesireToMove079; bTempCorpse03 = NPC_AI.bCorpse079; iTempLoyalty03 = NPC_AI.iLoyalty079; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins079; sTempWeapons03 = NPC_AI.sAvailableWeapons079; }
            if (Actor03 == NPC_AI.NPC_080) { iTempDesireToMove03 = NPC_AI.DesireToMove080; bTempCorpse03 = NPC_AI.bCorpse080; iTempLoyalty03 = NPC_AI.iLoyalty080; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins080; sTempWeapons03 = NPC_AI.sAvailableWeapons080; }
            if (Actor03 == NPC_AI.NPC_081) { iTempDesireToMove03 = NPC_AI.DesireToMove081; bTempCorpse03 = NPC_AI.bCorpse081; iTempLoyalty03 = NPC_AI.iLoyalty081; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins081; sTempWeapons03 = NPC_AI.sAvailableWeapons081; }
            if (Actor03 == NPC_AI.NPC_082) { iTempDesireToMove03 = NPC_AI.DesireToMove082; bTempCorpse03 = NPC_AI.bCorpse082; iTempLoyalty03 = NPC_AI.iLoyalty082; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins082; sTempWeapons03 = NPC_AI.sAvailableWeapons082; }
            if (Actor03 == NPC_AI.NPC_083) { iTempDesireToMove03 = NPC_AI.DesireToMove083; bTempCorpse03 = NPC_AI.bCorpse083; iTempLoyalty03 = NPC_AI.iLoyalty083; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins083; sTempWeapons03 = NPC_AI.sAvailableWeapons083; }
            if (Actor03 == NPC_AI.NPC_084) { iTempDesireToMove03 = NPC_AI.DesireToMove084; bTempCorpse03 = NPC_AI.bCorpse084; iTempLoyalty03 = NPC_AI.iLoyalty084; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins084; sTempWeapons03 = NPC_AI.sAvailableWeapons084; }
            if (Actor03 == NPC_AI.NPC_085) { iTempDesireToMove03 = NPC_AI.DesireToMove085; bTempCorpse03 = NPC_AI.bCorpse085; iTempLoyalty03 = NPC_AI.iLoyalty085; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins085; sTempWeapons03 = NPC_AI.sAvailableWeapons085; }
            if (Actor03 == NPC_AI.NPC_086) { iTempDesireToMove03 = NPC_AI.DesireToMove086; bTempCorpse03 = NPC_AI.bCorpse086; iTempLoyalty03 = NPC_AI.iLoyalty086; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins086; sTempWeapons03 = NPC_AI.sAvailableWeapons086; }
            if (Actor03 == NPC_AI.NPC_087) { iTempDesireToMove03 = NPC_AI.DesireToMove087; bTempCorpse03 = NPC_AI.bCorpse087; iTempLoyalty03 = NPC_AI.iLoyalty087; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins087; sTempWeapons03 = NPC_AI.sAvailableWeapons087; }
            if (Actor03 == NPC_AI.NPC_088) { iTempDesireToMove03 = NPC_AI.DesireToMove088; bTempCorpse03 = NPC_AI.bCorpse088; iTempLoyalty03 = NPC_AI.iLoyalty088; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins088; sTempWeapons03 = NPC_AI.sAvailableWeapons088; }
            if (Actor03 == NPC_AI.NPC_089) { iTempDesireToMove03 = NPC_AI.DesireToMove089; bTempCorpse03 = NPC_AI.bCorpse089; iTempLoyalty03 = NPC_AI.iLoyalty089; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins089; sTempWeapons03 = NPC_AI.sAvailableWeapons089; }
            if (Actor03 == NPC_AI.NPC_090) { iTempDesireToMove03 = NPC_AI.DesireToMove090; bTempCorpse03 = NPC_AI.bCorpse090; iTempLoyalty03 = NPC_AI.iLoyalty090; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins090; sTempWeapons03 = NPC_AI.sAvailableWeapons090; }
            if (Actor03 == NPC_AI.NPC_091) { iTempDesireToMove03 = NPC_AI.DesireToMove091; bTempCorpse03 = NPC_AI.bCorpse091; iTempLoyalty03 = NPC_AI.iLoyalty091; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins091; sTempWeapons03 = NPC_AI.sAvailableWeapons091; }
            if (Actor03 == NPC_AI.NPC_092) { iTempDesireToMove03 = NPC_AI.DesireToMove092; bTempCorpse03 = NPC_AI.bCorpse092; iTempLoyalty03 = NPC_AI.iLoyalty092; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins092; sTempWeapons03 = NPC_AI.sAvailableWeapons092; }
            if (Actor03 == NPC_AI.NPC_093) { iTempDesireToMove03 = NPC_AI.DesireToMove093; bTempCorpse03 = NPC_AI.bCorpse093; iTempLoyalty03 = NPC_AI.iLoyalty093; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins093; sTempWeapons03 = NPC_AI.sAvailableWeapons093; }
            if (Actor03 == NPC_AI.NPC_094) { iTempDesireToMove03 = NPC_AI.DesireToMove094; bTempCorpse03 = NPC_AI.bCorpse094; iTempLoyalty03 = NPC_AI.iLoyalty094; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins094; sTempWeapons03 = NPC_AI.sAvailableWeapons094; }
            if (Actor03 == NPC_AI.NPC_095) { iTempDesireToMove03 = NPC_AI.DesireToMove095; bTempCorpse03 = NPC_AI.bCorpse095; iTempLoyalty03 = NPC_AI.iLoyalty095; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins095; sTempWeapons03 = NPC_AI.sAvailableWeapons095; }
            if (Actor03 == NPC_AI.NPC_096) { iTempDesireToMove03 = NPC_AI.DesireToMove096; bTempCorpse03 = NPC_AI.bCorpse096; iTempLoyalty03 = NPC_AI.iLoyalty096; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins096; sTempWeapons03 = NPC_AI.sAvailableWeapons096; }
            if (Actor03 == NPC_AI.NPC_097) { iTempDesireToMove03 = NPC_AI.DesireToMove097; bTempCorpse03 = NPC_AI.bCorpse097; iTempLoyalty03 = NPC_AI.iLoyalty097; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins097; sTempWeapons03 = NPC_AI.sAvailableWeapons097; }
            if (Actor03 == NPC_AI.NPC_098) { iTempDesireToMove03 = NPC_AI.DesireToMove098; bTempCorpse03 = NPC_AI.bCorpse098; iTempLoyalty03 = NPC_AI.iLoyalty098; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins098; sTempWeapons03 = NPC_AI.sAvailableWeapons098; }
            if (Actor03 == NPC_AI.NPC_099) { iTempDesireToMove03 = NPC_AI.DesireToMove099; bTempCorpse03 = NPC_AI.bCorpse099; iTempLoyalty03 = NPC_AI.iLoyalty099; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins099; sTempWeapons03 = NPC_AI.sAvailableWeapons099; }
            if (Actor03 == NPC_AI.NPC_100) { iTempDesireToMove03 = NPC_AI.DesireToMove100; bTempCorpse03 = NPC_AI.bCorpse100; iTempLoyalty03 = NPC_AI.iLoyalty100; iTempMacGuffins03 = NPC_AI.iAvailableMacGuffins100; sTempWeapons03 = NPC_AI.sAvailableWeapons100; }

            if (Actor04 == NPC_AI.NPC_001) { iTempDesireToMove04 = NPC_AI.DesireToMove001; bTempCorpse04 = NPC_AI.bCorpse001; iTempLoyalty04 = NPC_AI.iLoyalty001; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins001; sTempWeapons04 = NPC_AI.sAvailableWeapons001; }
            if (Actor04 == NPC_AI.NPC_002) { iTempDesireToMove04 = NPC_AI.DesireToMove002; bTempCorpse04 = NPC_AI.bCorpse002; iTempLoyalty04 = NPC_AI.iLoyalty002; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins002; sTempWeapons04 = NPC_AI.sAvailableWeapons002; }
            if (Actor04 == NPC_AI.NPC_003) { iTempDesireToMove04 = NPC_AI.DesireToMove003; bTempCorpse04 = NPC_AI.bCorpse003; iTempLoyalty04 = NPC_AI.iLoyalty003; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins003; sTempWeapons04 = NPC_AI.sAvailableWeapons003; }
            if (Actor04 == NPC_AI.NPC_004) { iTempDesireToMove04 = NPC_AI.DesireToMove004; bTempCorpse04 = NPC_AI.bCorpse004; iTempLoyalty04 = NPC_AI.iLoyalty004; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins004; sTempWeapons04 = NPC_AI.sAvailableWeapons004; }
            if (Actor04 == NPC_AI.NPC_005) { iTempDesireToMove04 = NPC_AI.DesireToMove005; bTempCorpse04 = NPC_AI.bCorpse005; iTempLoyalty04 = NPC_AI.iLoyalty005; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins005; sTempWeapons04 = NPC_AI.sAvailableWeapons005; }
            if (Actor04 == NPC_AI.NPC_006) { iTempDesireToMove04 = NPC_AI.DesireToMove006; bTempCorpse04 = NPC_AI.bCorpse006; iTempLoyalty04 = NPC_AI.iLoyalty006; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins006; sTempWeapons04 = NPC_AI.sAvailableWeapons006; }
            if (Actor04 == NPC_AI.NPC_007) { iTempDesireToMove04 = NPC_AI.DesireToMove007; bTempCorpse04 = NPC_AI.bCorpse007; iTempLoyalty04 = NPC_AI.iLoyalty007; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins007; sTempWeapons04 = NPC_AI.sAvailableWeapons007; }
            if (Actor04 == NPC_AI.NPC_008) { iTempDesireToMove04 = NPC_AI.DesireToMove008; bTempCorpse04 = NPC_AI.bCorpse008; iTempLoyalty04 = NPC_AI.iLoyalty008; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins008; sTempWeapons04 = NPC_AI.sAvailableWeapons008; }
            if (Actor04 == NPC_AI.NPC_009) { iTempDesireToMove04 = NPC_AI.DesireToMove009; bTempCorpse04 = NPC_AI.bCorpse009; iTempLoyalty04 = NPC_AI.iLoyalty009; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins009; sTempWeapons04 = NPC_AI.sAvailableWeapons009; }
            if (Actor04 == NPC_AI.NPC_010) { iTempDesireToMove04 = NPC_AI.DesireToMove010; bTempCorpse04 = NPC_AI.bCorpse010; iTempLoyalty04 = NPC_AI.iLoyalty010; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins010; sTempWeapons04 = NPC_AI.sAvailableWeapons010; }
            if (Actor04 == NPC_AI.NPC_011) { iTempDesireToMove04 = NPC_AI.DesireToMove011; bTempCorpse04 = NPC_AI.bCorpse011; iTempLoyalty04 = NPC_AI.iLoyalty011; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins011; sTempWeapons04 = NPC_AI.sAvailableWeapons011; }
            if (Actor04 == NPC_AI.NPC_012) { iTempDesireToMove04 = NPC_AI.DesireToMove012; bTempCorpse04 = NPC_AI.bCorpse012; iTempLoyalty04 = NPC_AI.iLoyalty012; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins012; sTempWeapons04 = NPC_AI.sAvailableWeapons012; }
            if (Actor04 == NPC_AI.NPC_013) { iTempDesireToMove04 = NPC_AI.DesireToMove013; bTempCorpse04 = NPC_AI.bCorpse013; iTempLoyalty04 = NPC_AI.iLoyalty013; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins013; sTempWeapons04 = NPC_AI.sAvailableWeapons013; }
            if (Actor04 == NPC_AI.NPC_014) { iTempDesireToMove04 = NPC_AI.DesireToMove014; bTempCorpse04 = NPC_AI.bCorpse014; iTempLoyalty04 = NPC_AI.iLoyalty014; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins014; sTempWeapons04 = NPC_AI.sAvailableWeapons014; }
            if (Actor04 == NPC_AI.NPC_015) { iTempDesireToMove04 = NPC_AI.DesireToMove015; bTempCorpse04 = NPC_AI.bCorpse015; iTempLoyalty04 = NPC_AI.iLoyalty015; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins015; sTempWeapons04 = NPC_AI.sAvailableWeapons015; }
            if (Actor04 == NPC_AI.NPC_016) { iTempDesireToMove04 = NPC_AI.DesireToMove016; bTempCorpse04 = NPC_AI.bCorpse016; iTempLoyalty04 = NPC_AI.iLoyalty016; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins016; sTempWeapons04 = NPC_AI.sAvailableWeapons016; }
            if (Actor04 == NPC_AI.NPC_017) { iTempDesireToMove04 = NPC_AI.DesireToMove017; bTempCorpse04 = NPC_AI.bCorpse017; iTempLoyalty04 = NPC_AI.iLoyalty017; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins017; sTempWeapons04 = NPC_AI.sAvailableWeapons017; }
            if (Actor04 == NPC_AI.NPC_018) { iTempDesireToMove04 = NPC_AI.DesireToMove018; bTempCorpse04 = NPC_AI.bCorpse018; iTempLoyalty04 = NPC_AI.iLoyalty018; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins018; sTempWeapons04 = NPC_AI.sAvailableWeapons018; }
            if (Actor04 == NPC_AI.NPC_019) { iTempDesireToMove04 = NPC_AI.DesireToMove019; bTempCorpse04 = NPC_AI.bCorpse019; iTempLoyalty04 = NPC_AI.iLoyalty019; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins019; sTempWeapons04 = NPC_AI.sAvailableWeapons019; }
            if (Actor04 == NPC_AI.NPC_020) { iTempDesireToMove04 = NPC_AI.DesireToMove020; bTempCorpse04 = NPC_AI.bCorpse020; iTempLoyalty04 = NPC_AI.iLoyalty020; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins020; sTempWeapons04 = NPC_AI.sAvailableWeapons020; }
            if (Actor04 == NPC_AI.NPC_021) { iTempDesireToMove04 = NPC_AI.DesireToMove021; bTempCorpse04 = NPC_AI.bCorpse021; iTempLoyalty04 = NPC_AI.iLoyalty021; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins021; sTempWeapons04 = NPC_AI.sAvailableWeapons021; }
            if (Actor04 == NPC_AI.NPC_022) { iTempDesireToMove04 = NPC_AI.DesireToMove022; bTempCorpse04 = NPC_AI.bCorpse022; iTempLoyalty04 = NPC_AI.iLoyalty022; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins022; sTempWeapons04 = NPC_AI.sAvailableWeapons022; }
            if (Actor04 == NPC_AI.NPC_023) { iTempDesireToMove04 = NPC_AI.DesireToMove023; bTempCorpse04 = NPC_AI.bCorpse023; iTempLoyalty04 = NPC_AI.iLoyalty023; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins023; sTempWeapons04 = NPC_AI.sAvailableWeapons023; }
            if (Actor04 == NPC_AI.NPC_024) { iTempDesireToMove04 = NPC_AI.DesireToMove024; bTempCorpse04 = NPC_AI.bCorpse024; iTempLoyalty04 = NPC_AI.iLoyalty024; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins024; sTempWeapons04 = NPC_AI.sAvailableWeapons024; }
            if (Actor04 == NPC_AI.NPC_025) { iTempDesireToMove04 = NPC_AI.DesireToMove025; bTempCorpse04 = NPC_AI.bCorpse025; iTempLoyalty04 = NPC_AI.iLoyalty025; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins025; sTempWeapons04 = NPC_AI.sAvailableWeapons025; }
            if (Actor04 == NPC_AI.NPC_026) { iTempDesireToMove04 = NPC_AI.DesireToMove026; bTempCorpse04 = NPC_AI.bCorpse026; iTempLoyalty04 = NPC_AI.iLoyalty026; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins026; sTempWeapons04 = NPC_AI.sAvailableWeapons026; }
            if (Actor04 == NPC_AI.NPC_027) { iTempDesireToMove04 = NPC_AI.DesireToMove027; bTempCorpse04 = NPC_AI.bCorpse027; iTempLoyalty04 = NPC_AI.iLoyalty027; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins027; sTempWeapons04 = NPC_AI.sAvailableWeapons027; }
            if (Actor04 == NPC_AI.NPC_028) { iTempDesireToMove04 = NPC_AI.DesireToMove028; bTempCorpse04 = NPC_AI.bCorpse028; iTempLoyalty04 = NPC_AI.iLoyalty028; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins028; sTempWeapons04 = NPC_AI.sAvailableWeapons028; }
            if (Actor04 == NPC_AI.NPC_029) { iTempDesireToMove04 = NPC_AI.DesireToMove029; bTempCorpse04 = NPC_AI.bCorpse029; iTempLoyalty04 = NPC_AI.iLoyalty029; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins029; sTempWeapons04 = NPC_AI.sAvailableWeapons029; }
            if (Actor04 == NPC_AI.NPC_030) { iTempDesireToMove04 = NPC_AI.DesireToMove030; bTempCorpse04 = NPC_AI.bCorpse030; iTempLoyalty04 = NPC_AI.iLoyalty030; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins030; sTempWeapons04 = NPC_AI.sAvailableWeapons030; }
            if (Actor04 == NPC_AI.NPC_031) { iTempDesireToMove04 = NPC_AI.DesireToMove031; bTempCorpse04 = NPC_AI.bCorpse031; iTempLoyalty04 = NPC_AI.iLoyalty031; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins031; sTempWeapons04 = NPC_AI.sAvailableWeapons031; }
            if (Actor04 == NPC_AI.NPC_032) { iTempDesireToMove04 = NPC_AI.DesireToMove032; bTempCorpse04 = NPC_AI.bCorpse032; iTempLoyalty04 = NPC_AI.iLoyalty032; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins032; sTempWeapons04 = NPC_AI.sAvailableWeapons032; }
            if (Actor04 == NPC_AI.NPC_033) { iTempDesireToMove04 = NPC_AI.DesireToMove033; bTempCorpse04 = NPC_AI.bCorpse033; iTempLoyalty04 = NPC_AI.iLoyalty033; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins033; sTempWeapons04 = NPC_AI.sAvailableWeapons033; }
            if (Actor04 == NPC_AI.NPC_034) { iTempDesireToMove04 = NPC_AI.DesireToMove034; bTempCorpse04 = NPC_AI.bCorpse034; iTempLoyalty04 = NPC_AI.iLoyalty034; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins034; sTempWeapons04 = NPC_AI.sAvailableWeapons034; }
            if (Actor04 == NPC_AI.NPC_035) { iTempDesireToMove04 = NPC_AI.DesireToMove035; bTempCorpse04 = NPC_AI.bCorpse035; iTempLoyalty04 = NPC_AI.iLoyalty035; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins035; sTempWeapons04 = NPC_AI.sAvailableWeapons035; }
            if (Actor04 == NPC_AI.NPC_036) { iTempDesireToMove04 = NPC_AI.DesireToMove036; bTempCorpse04 = NPC_AI.bCorpse036; iTempLoyalty04 = NPC_AI.iLoyalty036; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins036; sTempWeapons04 = NPC_AI.sAvailableWeapons036; }
            if (Actor04 == NPC_AI.NPC_037) { iTempDesireToMove04 = NPC_AI.DesireToMove037; bTempCorpse04 = NPC_AI.bCorpse037; iTempLoyalty04 = NPC_AI.iLoyalty037; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins037; sTempWeapons04 = NPC_AI.sAvailableWeapons037; }
            if (Actor04 == NPC_AI.NPC_038) { iTempDesireToMove04 = NPC_AI.DesireToMove038; bTempCorpse04 = NPC_AI.bCorpse038; iTempLoyalty04 = NPC_AI.iLoyalty038; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins038; sTempWeapons04 = NPC_AI.sAvailableWeapons038; }
            if (Actor04 == NPC_AI.NPC_039) { iTempDesireToMove04 = NPC_AI.DesireToMove039; bTempCorpse04 = NPC_AI.bCorpse039; iTempLoyalty04 = NPC_AI.iLoyalty039; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins039; sTempWeapons04 = NPC_AI.sAvailableWeapons039; }
            if (Actor04 == NPC_AI.NPC_040) { iTempDesireToMove04 = NPC_AI.DesireToMove040; bTempCorpse04 = NPC_AI.bCorpse040; iTempLoyalty04 = NPC_AI.iLoyalty040; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins040; sTempWeapons04 = NPC_AI.sAvailableWeapons040; }
            if (Actor04 == NPC_AI.NPC_041) { iTempDesireToMove04 = NPC_AI.DesireToMove041; bTempCorpse04 = NPC_AI.bCorpse041; iTempLoyalty04 = NPC_AI.iLoyalty041; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins041; sTempWeapons04 = NPC_AI.sAvailableWeapons041; }
            if (Actor04 == NPC_AI.NPC_042) { iTempDesireToMove04 = NPC_AI.DesireToMove042; bTempCorpse04 = NPC_AI.bCorpse042; iTempLoyalty04 = NPC_AI.iLoyalty042; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins042; sTempWeapons04 = NPC_AI.sAvailableWeapons042; }
            if (Actor04 == NPC_AI.NPC_043) { iTempDesireToMove04 = NPC_AI.DesireToMove043; bTempCorpse04 = NPC_AI.bCorpse043; iTempLoyalty04 = NPC_AI.iLoyalty043; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins043; sTempWeapons04 = NPC_AI.sAvailableWeapons043; }
            if (Actor04 == NPC_AI.NPC_044) { iTempDesireToMove04 = NPC_AI.DesireToMove044; bTempCorpse04 = NPC_AI.bCorpse044; iTempLoyalty04 = NPC_AI.iLoyalty044; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins044; sTempWeapons04 = NPC_AI.sAvailableWeapons044; }
            if (Actor04 == NPC_AI.NPC_045) { iTempDesireToMove04 = NPC_AI.DesireToMove045; bTempCorpse04 = NPC_AI.bCorpse045; iTempLoyalty04 = NPC_AI.iLoyalty045; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins045; sTempWeapons04 = NPC_AI.sAvailableWeapons045; }
            if (Actor04 == NPC_AI.NPC_046) { iTempDesireToMove04 = NPC_AI.DesireToMove046; bTempCorpse04 = NPC_AI.bCorpse046; iTempLoyalty04 = NPC_AI.iLoyalty046; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins046; sTempWeapons04 = NPC_AI.sAvailableWeapons046; }
            if (Actor04 == NPC_AI.NPC_047) { iTempDesireToMove04 = NPC_AI.DesireToMove047; bTempCorpse04 = NPC_AI.bCorpse047; iTempLoyalty04 = NPC_AI.iLoyalty047; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins047; sTempWeapons04 = NPC_AI.sAvailableWeapons047; }
            if (Actor04 == NPC_AI.NPC_048) { iTempDesireToMove04 = NPC_AI.DesireToMove048; bTempCorpse04 = NPC_AI.bCorpse048; iTempLoyalty04 = NPC_AI.iLoyalty048; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins048; sTempWeapons04 = NPC_AI.sAvailableWeapons048; }
            if (Actor04 == NPC_AI.NPC_049) { iTempDesireToMove04 = NPC_AI.DesireToMove049; bTempCorpse04 = NPC_AI.bCorpse049; iTempLoyalty04 = NPC_AI.iLoyalty049; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins049; sTempWeapons04 = NPC_AI.sAvailableWeapons049; }
            if (Actor04 == NPC_AI.NPC_050) { iTempDesireToMove04 = NPC_AI.DesireToMove050; bTempCorpse04 = NPC_AI.bCorpse050; iTempLoyalty04 = NPC_AI.iLoyalty050; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins050; sTempWeapons04 = NPC_AI.sAvailableWeapons050; }
            if (Actor04 == NPC_AI.NPC_051) { iTempDesireToMove04 = NPC_AI.DesireToMove051; bTempCorpse04 = NPC_AI.bCorpse051; iTempLoyalty04 = NPC_AI.iLoyalty051; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins051; sTempWeapons04 = NPC_AI.sAvailableWeapons051; }
            if (Actor04 == NPC_AI.NPC_052) { iTempDesireToMove04 = NPC_AI.DesireToMove052; bTempCorpse04 = NPC_AI.bCorpse052; iTempLoyalty04 = NPC_AI.iLoyalty052; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins052; sTempWeapons04 = NPC_AI.sAvailableWeapons052; }
            if (Actor04 == NPC_AI.NPC_053) { iTempDesireToMove04 = NPC_AI.DesireToMove053; bTempCorpse04 = NPC_AI.bCorpse053; iTempLoyalty04 = NPC_AI.iLoyalty053; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins053; sTempWeapons04 = NPC_AI.sAvailableWeapons053; }
            if (Actor04 == NPC_AI.NPC_054) { iTempDesireToMove04 = NPC_AI.DesireToMove054; bTempCorpse04 = NPC_AI.bCorpse054; iTempLoyalty04 = NPC_AI.iLoyalty054; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins054; sTempWeapons04 = NPC_AI.sAvailableWeapons054; }
            if (Actor04 == NPC_AI.NPC_055) { iTempDesireToMove04 = NPC_AI.DesireToMove055; bTempCorpse04 = NPC_AI.bCorpse055; iTempLoyalty04 = NPC_AI.iLoyalty055; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins055; sTempWeapons04 = NPC_AI.sAvailableWeapons055; }
            if (Actor04 == NPC_AI.NPC_056) { iTempDesireToMove04 = NPC_AI.DesireToMove056; bTempCorpse04 = NPC_AI.bCorpse056; iTempLoyalty04 = NPC_AI.iLoyalty056; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins056; sTempWeapons04 = NPC_AI.sAvailableWeapons056; }
            if (Actor04 == NPC_AI.NPC_057) { iTempDesireToMove04 = NPC_AI.DesireToMove057; bTempCorpse04 = NPC_AI.bCorpse057; iTempLoyalty04 = NPC_AI.iLoyalty057; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins057; sTempWeapons04 = NPC_AI.sAvailableWeapons057; }
            if (Actor04 == NPC_AI.NPC_058) { iTempDesireToMove04 = NPC_AI.DesireToMove058; bTempCorpse04 = NPC_AI.bCorpse058; iTempLoyalty04 = NPC_AI.iLoyalty058; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins058; sTempWeapons04 = NPC_AI.sAvailableWeapons058; }
            if (Actor04 == NPC_AI.NPC_059) { iTempDesireToMove04 = NPC_AI.DesireToMove059; bTempCorpse04 = NPC_AI.bCorpse059; iTempLoyalty04 = NPC_AI.iLoyalty059; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins059; sTempWeapons04 = NPC_AI.sAvailableWeapons059; }
            if (Actor04 == NPC_AI.NPC_060) { iTempDesireToMove04 = NPC_AI.DesireToMove060; bTempCorpse04 = NPC_AI.bCorpse060; iTempLoyalty04 = NPC_AI.iLoyalty060; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins060; sTempWeapons04 = NPC_AI.sAvailableWeapons060; }
            if (Actor04 == NPC_AI.NPC_061) { iTempDesireToMove04 = NPC_AI.DesireToMove061; bTempCorpse04 = NPC_AI.bCorpse061; iTempLoyalty04 = NPC_AI.iLoyalty061; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins061; sTempWeapons04 = NPC_AI.sAvailableWeapons061; }
            if (Actor04 == NPC_AI.NPC_062) { iTempDesireToMove04 = NPC_AI.DesireToMove062; bTempCorpse04 = NPC_AI.bCorpse062; iTempLoyalty04 = NPC_AI.iLoyalty062; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins062; sTempWeapons04 = NPC_AI.sAvailableWeapons062; }
            if (Actor04 == NPC_AI.NPC_063) { iTempDesireToMove04 = NPC_AI.DesireToMove063; bTempCorpse04 = NPC_AI.bCorpse063; iTempLoyalty04 = NPC_AI.iLoyalty063; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins063; sTempWeapons04 = NPC_AI.sAvailableWeapons063; }
            if (Actor04 == NPC_AI.NPC_064) { iTempDesireToMove04 = NPC_AI.DesireToMove064; bTempCorpse04 = NPC_AI.bCorpse064; iTempLoyalty04 = NPC_AI.iLoyalty054; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins064; sTempWeapons04 = NPC_AI.sAvailableWeapons064; }
            if (Actor04 == NPC_AI.NPC_065) { iTempDesireToMove04 = NPC_AI.DesireToMove065; bTempCorpse04 = NPC_AI.bCorpse065; iTempLoyalty04 = NPC_AI.iLoyalty065; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins065; sTempWeapons04 = NPC_AI.sAvailableWeapons065; }
            if (Actor04 == NPC_AI.NPC_066) { iTempDesireToMove04 = NPC_AI.DesireToMove066; bTempCorpse04 = NPC_AI.bCorpse066; iTempLoyalty04 = NPC_AI.iLoyalty066; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins066; sTempWeapons04 = NPC_AI.sAvailableWeapons066; }
            if (Actor04 == NPC_AI.NPC_067) { iTempDesireToMove04 = NPC_AI.DesireToMove067; bTempCorpse04 = NPC_AI.bCorpse067; iTempLoyalty04 = NPC_AI.iLoyalty067; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins067; sTempWeapons04 = NPC_AI.sAvailableWeapons067; }
            if (Actor04 == NPC_AI.NPC_068) { iTempDesireToMove04 = NPC_AI.DesireToMove068; bTempCorpse04 = NPC_AI.bCorpse068; iTempLoyalty04 = NPC_AI.iLoyalty068; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins068; sTempWeapons04 = NPC_AI.sAvailableWeapons068; }
            if (Actor04 == NPC_AI.NPC_069) { iTempDesireToMove04 = NPC_AI.DesireToMove069; bTempCorpse04 = NPC_AI.bCorpse069; iTempLoyalty04 = NPC_AI.iLoyalty069; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins069; sTempWeapons04 = NPC_AI.sAvailableWeapons069; }
            if (Actor04 == NPC_AI.NPC_070) { iTempDesireToMove04 = NPC_AI.DesireToMove070; bTempCorpse04 = NPC_AI.bCorpse070; iTempLoyalty04 = NPC_AI.iLoyalty070; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins070; sTempWeapons04 = NPC_AI.sAvailableWeapons070; }
            if (Actor04 == NPC_AI.NPC_071) { iTempDesireToMove04 = NPC_AI.DesireToMove071; bTempCorpse04 = NPC_AI.bCorpse071; iTempLoyalty04 = NPC_AI.iLoyalty071; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins071; sTempWeapons04 = NPC_AI.sAvailableWeapons071; }
            if (Actor04 == NPC_AI.NPC_072) { iTempDesireToMove04 = NPC_AI.DesireToMove072; bTempCorpse04 = NPC_AI.bCorpse072; iTempLoyalty04 = NPC_AI.iLoyalty072; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins072; sTempWeapons04 = NPC_AI.sAvailableWeapons072; }
            if (Actor04 == NPC_AI.NPC_073) { iTempDesireToMove04 = NPC_AI.DesireToMove073; bTempCorpse04 = NPC_AI.bCorpse073; iTempLoyalty04 = NPC_AI.iLoyalty073; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins073; sTempWeapons04 = NPC_AI.sAvailableWeapons073; }
            if (Actor04 == NPC_AI.NPC_074) { iTempDesireToMove04 = NPC_AI.DesireToMove074; bTempCorpse04 = NPC_AI.bCorpse074; iTempLoyalty04 = NPC_AI.iLoyalty074; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins074; sTempWeapons04 = NPC_AI.sAvailableWeapons074; }
            if (Actor04 == NPC_AI.NPC_075) { iTempDesireToMove04 = NPC_AI.DesireToMove075; bTempCorpse04 = NPC_AI.bCorpse075; iTempLoyalty04 = NPC_AI.iLoyalty075; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins075; sTempWeapons04 = NPC_AI.sAvailableWeapons075; }
            if (Actor04 == NPC_AI.NPC_076) { iTempDesireToMove04 = NPC_AI.DesireToMove076; bTempCorpse04 = NPC_AI.bCorpse076; iTempLoyalty04 = NPC_AI.iLoyalty076; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins076; sTempWeapons04 = NPC_AI.sAvailableWeapons076; }
            if (Actor04 == NPC_AI.NPC_077) { iTempDesireToMove04 = NPC_AI.DesireToMove077; bTempCorpse04 = NPC_AI.bCorpse077; iTempLoyalty04 = NPC_AI.iLoyalty077; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins077; sTempWeapons04 = NPC_AI.sAvailableWeapons077; }
            if (Actor04 == NPC_AI.NPC_078) { iTempDesireToMove04 = NPC_AI.DesireToMove078; bTempCorpse04 = NPC_AI.bCorpse078; iTempLoyalty04 = NPC_AI.iLoyalty078; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins078; sTempWeapons04 = NPC_AI.sAvailableWeapons078; }
            if (Actor04 == NPC_AI.NPC_079) { iTempDesireToMove04 = NPC_AI.DesireToMove079; bTempCorpse04 = NPC_AI.bCorpse079; iTempLoyalty04 = NPC_AI.iLoyalty079; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins079; sTempWeapons04 = NPC_AI.sAvailableWeapons079; }
            if (Actor04 == NPC_AI.NPC_080) { iTempDesireToMove04 = NPC_AI.DesireToMove080; bTempCorpse04 = NPC_AI.bCorpse080; iTempLoyalty04 = NPC_AI.iLoyalty080; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins080; sTempWeapons04 = NPC_AI.sAvailableWeapons080; }
            if (Actor04 == NPC_AI.NPC_081) { iTempDesireToMove04 = NPC_AI.DesireToMove081; bTempCorpse04 = NPC_AI.bCorpse081; iTempLoyalty04 = NPC_AI.iLoyalty081; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins081; sTempWeapons04 = NPC_AI.sAvailableWeapons081; }
            if (Actor04 == NPC_AI.NPC_082) { iTempDesireToMove04 = NPC_AI.DesireToMove082; bTempCorpse04 = NPC_AI.bCorpse082; iTempLoyalty04 = NPC_AI.iLoyalty082; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins082; sTempWeapons04 = NPC_AI.sAvailableWeapons082; }
            if (Actor04 == NPC_AI.NPC_083) { iTempDesireToMove04 = NPC_AI.DesireToMove083; bTempCorpse04 = NPC_AI.bCorpse083; iTempLoyalty04 = NPC_AI.iLoyalty083; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins083; sTempWeapons04 = NPC_AI.sAvailableWeapons083; }
            if (Actor04 == NPC_AI.NPC_084) { iTempDesireToMove04 = NPC_AI.DesireToMove084; bTempCorpse04 = NPC_AI.bCorpse084; iTempLoyalty04 = NPC_AI.iLoyalty084; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins084; sTempWeapons04 = NPC_AI.sAvailableWeapons084; }
            if (Actor04 == NPC_AI.NPC_085) { iTempDesireToMove04 = NPC_AI.DesireToMove085; bTempCorpse04 = NPC_AI.bCorpse085; iTempLoyalty04 = NPC_AI.iLoyalty085; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins085; sTempWeapons04 = NPC_AI.sAvailableWeapons085; }
            if (Actor04 == NPC_AI.NPC_086) { iTempDesireToMove04 = NPC_AI.DesireToMove086; bTempCorpse04 = NPC_AI.bCorpse086; iTempLoyalty04 = NPC_AI.iLoyalty086; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins086; sTempWeapons04 = NPC_AI.sAvailableWeapons086; }
            if (Actor04 == NPC_AI.NPC_087) { iTempDesireToMove04 = NPC_AI.DesireToMove087; bTempCorpse04 = NPC_AI.bCorpse087; iTempLoyalty04 = NPC_AI.iLoyalty087; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins087; sTempWeapons04 = NPC_AI.sAvailableWeapons087; }
            if (Actor04 == NPC_AI.NPC_088) { iTempDesireToMove04 = NPC_AI.DesireToMove088; bTempCorpse04 = NPC_AI.bCorpse088; iTempLoyalty04 = NPC_AI.iLoyalty088; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins088; sTempWeapons04 = NPC_AI.sAvailableWeapons088; }
            if (Actor04 == NPC_AI.NPC_089) { iTempDesireToMove04 = NPC_AI.DesireToMove089; bTempCorpse04 = NPC_AI.bCorpse089; iTempLoyalty04 = NPC_AI.iLoyalty089; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins089; sTempWeapons04 = NPC_AI.sAvailableWeapons089; }
            if (Actor04 == NPC_AI.NPC_090) { iTempDesireToMove04 = NPC_AI.DesireToMove090; bTempCorpse04 = NPC_AI.bCorpse090; iTempLoyalty04 = NPC_AI.iLoyalty090; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins090; sTempWeapons04 = NPC_AI.sAvailableWeapons090; }
            if (Actor04 == NPC_AI.NPC_091) { iTempDesireToMove04 = NPC_AI.DesireToMove091; bTempCorpse04 = NPC_AI.bCorpse091; iTempLoyalty04 = NPC_AI.iLoyalty091; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins091; sTempWeapons04 = NPC_AI.sAvailableWeapons091; }
            if (Actor04 == NPC_AI.NPC_092) { iTempDesireToMove04 = NPC_AI.DesireToMove092; bTempCorpse04 = NPC_AI.bCorpse092; iTempLoyalty04 = NPC_AI.iLoyalty092; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins092; sTempWeapons04 = NPC_AI.sAvailableWeapons092; }
            if (Actor04 == NPC_AI.NPC_093) { iTempDesireToMove04 = NPC_AI.DesireToMove093; bTempCorpse04 = NPC_AI.bCorpse093; iTempLoyalty04 = NPC_AI.iLoyalty093; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins093; sTempWeapons04 = NPC_AI.sAvailableWeapons093; }
            if (Actor04 == NPC_AI.NPC_094) { iTempDesireToMove04 = NPC_AI.DesireToMove094; bTempCorpse04 = NPC_AI.bCorpse094; iTempLoyalty04 = NPC_AI.iLoyalty094; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins094; sTempWeapons04 = NPC_AI.sAvailableWeapons094; }
            if (Actor04 == NPC_AI.NPC_095) { iTempDesireToMove04 = NPC_AI.DesireToMove095; bTempCorpse04 = NPC_AI.bCorpse095; iTempLoyalty04 = NPC_AI.iLoyalty095; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins095; sTempWeapons04 = NPC_AI.sAvailableWeapons095; }
            if (Actor04 == NPC_AI.NPC_096) { iTempDesireToMove04 = NPC_AI.DesireToMove096; bTempCorpse04 = NPC_AI.bCorpse096; iTempLoyalty04 = NPC_AI.iLoyalty096; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins096; sTempWeapons04 = NPC_AI.sAvailableWeapons096; }
            if (Actor04 == NPC_AI.NPC_097) { iTempDesireToMove04 = NPC_AI.DesireToMove097; bTempCorpse04 = NPC_AI.bCorpse097; iTempLoyalty04 = NPC_AI.iLoyalty097; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins097; sTempWeapons04 = NPC_AI.sAvailableWeapons097; }
            if (Actor04 == NPC_AI.NPC_098) { iTempDesireToMove04 = NPC_AI.DesireToMove098; bTempCorpse04 = NPC_AI.bCorpse098; iTempLoyalty04 = NPC_AI.iLoyalty098; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins098; sTempWeapons04 = NPC_AI.sAvailableWeapons098; }
            if (Actor04 == NPC_AI.NPC_099) { iTempDesireToMove04 = NPC_AI.DesireToMove099; bTempCorpse04 = NPC_AI.bCorpse099; iTempLoyalty04 = NPC_AI.iLoyalty099; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins099; sTempWeapons04 = NPC_AI.sAvailableWeapons099; }
            if (Actor04 == NPC_AI.NPC_100) { iTempDesireToMove04 = NPC_AI.DesireToMove100; bTempCorpse04 = NPC_AI.bCorpse100; iTempLoyalty04 = NPC_AI.iLoyalty100; iTempMacGuffins04 = NPC_AI.iAvailableMacGuffins100; sTempWeapons04 = NPC_AI.sAvailableWeapons100; }
            
            if (Actor05 == NPC_AI.NPC_001) { iTempDesireToMove05 = NPC_AI.DesireToMove001; bTempCorpse05 = NPC_AI.bCorpse001; iTempLoyalty05 = NPC_AI.iLoyalty001; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins001; sTempWeapons05 = NPC_AI.sAvailableWeapons001; }
            if (Actor05 == NPC_AI.NPC_002) { iTempDesireToMove05 = NPC_AI.DesireToMove002; bTempCorpse05 = NPC_AI.bCorpse002; iTempLoyalty05 = NPC_AI.iLoyalty002; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins002; sTempWeapons05 = NPC_AI.sAvailableWeapons002; }
            if (Actor05 == NPC_AI.NPC_003) { iTempDesireToMove05 = NPC_AI.DesireToMove003; bTempCorpse05 = NPC_AI.bCorpse003; iTempLoyalty05 = NPC_AI.iLoyalty003; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins003; sTempWeapons05 = NPC_AI.sAvailableWeapons003; }
            if (Actor05 == NPC_AI.NPC_004) { iTempDesireToMove05 = NPC_AI.DesireToMove004; bTempCorpse05 = NPC_AI.bCorpse004; iTempLoyalty05 = NPC_AI.iLoyalty004; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins004; sTempWeapons05 = NPC_AI.sAvailableWeapons004; }
            if (Actor05 == NPC_AI.NPC_005) { iTempDesireToMove05 = NPC_AI.DesireToMove005; bTempCorpse05 = NPC_AI.bCorpse005; iTempLoyalty05 = NPC_AI.iLoyalty005; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins005; sTempWeapons05 = NPC_AI.sAvailableWeapons005; }
            if (Actor05 == NPC_AI.NPC_006) { iTempDesireToMove05 = NPC_AI.DesireToMove006; bTempCorpse05 = NPC_AI.bCorpse006; iTempLoyalty05 = NPC_AI.iLoyalty006; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins006; sTempWeapons05 = NPC_AI.sAvailableWeapons006; }
            if (Actor05 == NPC_AI.NPC_007) { iTempDesireToMove05 = NPC_AI.DesireToMove007; bTempCorpse05 = NPC_AI.bCorpse007; iTempLoyalty05 = NPC_AI.iLoyalty007; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins007; sTempWeapons05 = NPC_AI.sAvailableWeapons007; }
            if (Actor05 == NPC_AI.NPC_008) { iTempDesireToMove05 = NPC_AI.DesireToMove008; bTempCorpse05 = NPC_AI.bCorpse008; iTempLoyalty05 = NPC_AI.iLoyalty008; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins008; sTempWeapons05 = NPC_AI.sAvailableWeapons008; }
            if (Actor05 == NPC_AI.NPC_009) { iTempDesireToMove05 = NPC_AI.DesireToMove009; bTempCorpse05 = NPC_AI.bCorpse009; iTempLoyalty05 = NPC_AI.iLoyalty009; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins009; sTempWeapons05 = NPC_AI.sAvailableWeapons009; }
            if (Actor05 == NPC_AI.NPC_010) { iTempDesireToMove05 = NPC_AI.DesireToMove010; bTempCorpse05 = NPC_AI.bCorpse010; iTempLoyalty05 = NPC_AI.iLoyalty010; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins010; sTempWeapons05 = NPC_AI.sAvailableWeapons010; }
            if (Actor05 == NPC_AI.NPC_011) { iTempDesireToMove05 = NPC_AI.DesireToMove011; bTempCorpse05 = NPC_AI.bCorpse011; iTempLoyalty05 = NPC_AI.iLoyalty011; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins011; sTempWeapons05 = NPC_AI.sAvailableWeapons011; }
            if (Actor05 == NPC_AI.NPC_012) { iTempDesireToMove05 = NPC_AI.DesireToMove012; bTempCorpse05 = NPC_AI.bCorpse012; iTempLoyalty05 = NPC_AI.iLoyalty012; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins012; sTempWeapons05 = NPC_AI.sAvailableWeapons012; }
            if (Actor05 == NPC_AI.NPC_013) { iTempDesireToMove05 = NPC_AI.DesireToMove013; bTempCorpse05 = NPC_AI.bCorpse013; iTempLoyalty05 = NPC_AI.iLoyalty013; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins013; sTempWeapons05 = NPC_AI.sAvailableWeapons013; }
            if (Actor05 == NPC_AI.NPC_014) { iTempDesireToMove05 = NPC_AI.DesireToMove014; bTempCorpse05 = NPC_AI.bCorpse014; iTempLoyalty05 = NPC_AI.iLoyalty014; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins014; sTempWeapons05 = NPC_AI.sAvailableWeapons014; }
            if (Actor05 == NPC_AI.NPC_015) { iTempDesireToMove05 = NPC_AI.DesireToMove015; bTempCorpse05 = NPC_AI.bCorpse015; iTempLoyalty05 = NPC_AI.iLoyalty015; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins015; sTempWeapons05 = NPC_AI.sAvailableWeapons015; }
            if (Actor05 == NPC_AI.NPC_016) { iTempDesireToMove05 = NPC_AI.DesireToMove016; bTempCorpse05 = NPC_AI.bCorpse016; iTempLoyalty05 = NPC_AI.iLoyalty016; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins016; sTempWeapons05 = NPC_AI.sAvailableWeapons016; }
            if (Actor05 == NPC_AI.NPC_017) { iTempDesireToMove05 = NPC_AI.DesireToMove017; bTempCorpse05 = NPC_AI.bCorpse017; iTempLoyalty05 = NPC_AI.iLoyalty017; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins017; sTempWeapons05 = NPC_AI.sAvailableWeapons017; }
            if (Actor05 == NPC_AI.NPC_018) { iTempDesireToMove05 = NPC_AI.DesireToMove018; bTempCorpse05 = NPC_AI.bCorpse018; iTempLoyalty05 = NPC_AI.iLoyalty018; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins018; sTempWeapons05 = NPC_AI.sAvailableWeapons018; }
            if (Actor05 == NPC_AI.NPC_019) { iTempDesireToMove05 = NPC_AI.DesireToMove019; bTempCorpse05 = NPC_AI.bCorpse019; iTempLoyalty05 = NPC_AI.iLoyalty019; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins019; sTempWeapons05 = NPC_AI.sAvailableWeapons019; }
            if (Actor05 == NPC_AI.NPC_020) { iTempDesireToMove05 = NPC_AI.DesireToMove020; bTempCorpse05 = NPC_AI.bCorpse020; iTempLoyalty05 = NPC_AI.iLoyalty020; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins020; sTempWeapons05 = NPC_AI.sAvailableWeapons020; }
            if (Actor05 == NPC_AI.NPC_021) { iTempDesireToMove05 = NPC_AI.DesireToMove021; bTempCorpse05 = NPC_AI.bCorpse021; iTempLoyalty05 = NPC_AI.iLoyalty021; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins021; sTempWeapons05 = NPC_AI.sAvailableWeapons021; }
            if (Actor05 == NPC_AI.NPC_022) { iTempDesireToMove05 = NPC_AI.DesireToMove022; bTempCorpse05 = NPC_AI.bCorpse022; iTempLoyalty05 = NPC_AI.iLoyalty022; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins022; sTempWeapons05 = NPC_AI.sAvailableWeapons022; }
            if (Actor05 == NPC_AI.NPC_023) { iTempDesireToMove05 = NPC_AI.DesireToMove023; bTempCorpse05 = NPC_AI.bCorpse023; iTempLoyalty05 = NPC_AI.iLoyalty023; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins023; sTempWeapons05 = NPC_AI.sAvailableWeapons023; }
            if (Actor05 == NPC_AI.NPC_024) { iTempDesireToMove05 = NPC_AI.DesireToMove024; bTempCorpse05 = NPC_AI.bCorpse024; iTempLoyalty05 = NPC_AI.iLoyalty024; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins024; sTempWeapons05 = NPC_AI.sAvailableWeapons024; }
            if (Actor05 == NPC_AI.NPC_025) { iTempDesireToMove05 = NPC_AI.DesireToMove025; bTempCorpse05 = NPC_AI.bCorpse025; iTempLoyalty05 = NPC_AI.iLoyalty025; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins025; sTempWeapons05 = NPC_AI.sAvailableWeapons025; }
            if (Actor05 == NPC_AI.NPC_026) { iTempDesireToMove05 = NPC_AI.DesireToMove026; bTempCorpse05 = NPC_AI.bCorpse026; iTempLoyalty05 = NPC_AI.iLoyalty026; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins026; sTempWeapons05 = NPC_AI.sAvailableWeapons026; }
            if (Actor05 == NPC_AI.NPC_027) { iTempDesireToMove05 = NPC_AI.DesireToMove027; bTempCorpse05 = NPC_AI.bCorpse027; iTempLoyalty05 = NPC_AI.iLoyalty027; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins027; sTempWeapons05 = NPC_AI.sAvailableWeapons027; }
            if (Actor05 == NPC_AI.NPC_028) { iTempDesireToMove05 = NPC_AI.DesireToMove028; bTempCorpse05 = NPC_AI.bCorpse028; iTempLoyalty05 = NPC_AI.iLoyalty028; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins028; sTempWeapons05 = NPC_AI.sAvailableWeapons028; }
            if (Actor05 == NPC_AI.NPC_029) { iTempDesireToMove05 = NPC_AI.DesireToMove029; bTempCorpse05 = NPC_AI.bCorpse029; iTempLoyalty05 = NPC_AI.iLoyalty029; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins029; sTempWeapons05 = NPC_AI.sAvailableWeapons029; }
            if (Actor05 == NPC_AI.NPC_030) { iTempDesireToMove05 = NPC_AI.DesireToMove030; bTempCorpse05 = NPC_AI.bCorpse030; iTempLoyalty05 = NPC_AI.iLoyalty030; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins030; sTempWeapons05 = NPC_AI.sAvailableWeapons030; }
            if (Actor05 == NPC_AI.NPC_031) { iTempDesireToMove05 = NPC_AI.DesireToMove031; bTempCorpse05 = NPC_AI.bCorpse031; iTempLoyalty05 = NPC_AI.iLoyalty031; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins031; sTempWeapons05 = NPC_AI.sAvailableWeapons031; }
            if (Actor05 == NPC_AI.NPC_032) { iTempDesireToMove05 = NPC_AI.DesireToMove032; bTempCorpse05 = NPC_AI.bCorpse032; iTempLoyalty05 = NPC_AI.iLoyalty032; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins032; sTempWeapons05 = NPC_AI.sAvailableWeapons032; }
            if (Actor05 == NPC_AI.NPC_033) { iTempDesireToMove05 = NPC_AI.DesireToMove033; bTempCorpse05 = NPC_AI.bCorpse033; iTempLoyalty05 = NPC_AI.iLoyalty033; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins033; sTempWeapons05 = NPC_AI.sAvailableWeapons033; }
            if (Actor05 == NPC_AI.NPC_034) { iTempDesireToMove05 = NPC_AI.DesireToMove034; bTempCorpse05 = NPC_AI.bCorpse034; iTempLoyalty05 = NPC_AI.iLoyalty034; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins034; sTempWeapons05 = NPC_AI.sAvailableWeapons034; }
            if (Actor05 == NPC_AI.NPC_035) { iTempDesireToMove05 = NPC_AI.DesireToMove035; bTempCorpse05 = NPC_AI.bCorpse035; iTempLoyalty05 = NPC_AI.iLoyalty035; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins035; sTempWeapons05 = NPC_AI.sAvailableWeapons035; }
            if (Actor05 == NPC_AI.NPC_036) { iTempDesireToMove05 = NPC_AI.DesireToMove036; bTempCorpse05 = NPC_AI.bCorpse036; iTempLoyalty05 = NPC_AI.iLoyalty036; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins036; sTempWeapons05 = NPC_AI.sAvailableWeapons036; }
            if (Actor05 == NPC_AI.NPC_037) { iTempDesireToMove05 = NPC_AI.DesireToMove037; bTempCorpse05 = NPC_AI.bCorpse037; iTempLoyalty05 = NPC_AI.iLoyalty037; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins037; sTempWeapons05 = NPC_AI.sAvailableWeapons037; }
            if (Actor05 == NPC_AI.NPC_038) { iTempDesireToMove05 = NPC_AI.DesireToMove038; bTempCorpse05 = NPC_AI.bCorpse038; iTempLoyalty05 = NPC_AI.iLoyalty038; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins038; sTempWeapons05 = NPC_AI.sAvailableWeapons038; }
            if (Actor05 == NPC_AI.NPC_039) { iTempDesireToMove05 = NPC_AI.DesireToMove039; bTempCorpse05 = NPC_AI.bCorpse039; iTempLoyalty05 = NPC_AI.iLoyalty039; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins039; sTempWeapons05 = NPC_AI.sAvailableWeapons039; }
            if (Actor05 == NPC_AI.NPC_040) { iTempDesireToMove05 = NPC_AI.DesireToMove040; bTempCorpse05 = NPC_AI.bCorpse040; iTempLoyalty05 = NPC_AI.iLoyalty040; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins040; sTempWeapons05 = NPC_AI.sAvailableWeapons040; }
            if (Actor05 == NPC_AI.NPC_041) { iTempDesireToMove05 = NPC_AI.DesireToMove041; bTempCorpse05 = NPC_AI.bCorpse041; iTempLoyalty05 = NPC_AI.iLoyalty041; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins041; sTempWeapons05 = NPC_AI.sAvailableWeapons041; }
            if (Actor05 == NPC_AI.NPC_042) { iTempDesireToMove05 = NPC_AI.DesireToMove042; bTempCorpse05 = NPC_AI.bCorpse042; iTempLoyalty05 = NPC_AI.iLoyalty042; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins042; sTempWeapons05 = NPC_AI.sAvailableWeapons042; }
            if (Actor05 == NPC_AI.NPC_043) { iTempDesireToMove05 = NPC_AI.DesireToMove043; bTempCorpse05 = NPC_AI.bCorpse043; iTempLoyalty05 = NPC_AI.iLoyalty043; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins043; sTempWeapons05 = NPC_AI.sAvailableWeapons043; }
            if (Actor05 == NPC_AI.NPC_044) { iTempDesireToMove05 = NPC_AI.DesireToMove044; bTempCorpse05 = NPC_AI.bCorpse044; iTempLoyalty05 = NPC_AI.iLoyalty044; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins044; sTempWeapons05 = NPC_AI.sAvailableWeapons044; }
            if (Actor05 == NPC_AI.NPC_045) { iTempDesireToMove05 = NPC_AI.DesireToMove045; bTempCorpse05 = NPC_AI.bCorpse045; iTempLoyalty05 = NPC_AI.iLoyalty045; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins045; sTempWeapons05 = NPC_AI.sAvailableWeapons045; }
            if (Actor05 == NPC_AI.NPC_046) { iTempDesireToMove05 = NPC_AI.DesireToMove046; bTempCorpse05 = NPC_AI.bCorpse046; iTempLoyalty05 = NPC_AI.iLoyalty046; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins046; sTempWeapons05 = NPC_AI.sAvailableWeapons046; }
            if (Actor05 == NPC_AI.NPC_047) { iTempDesireToMove05 = NPC_AI.DesireToMove047; bTempCorpse05 = NPC_AI.bCorpse047; iTempLoyalty05 = NPC_AI.iLoyalty047; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins047; sTempWeapons05 = NPC_AI.sAvailableWeapons047; }
            if (Actor05 == NPC_AI.NPC_048) { iTempDesireToMove05 = NPC_AI.DesireToMove048; bTempCorpse05 = NPC_AI.bCorpse048; iTempLoyalty05 = NPC_AI.iLoyalty048; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins048; sTempWeapons05 = NPC_AI.sAvailableWeapons048; }
            if (Actor05 == NPC_AI.NPC_049) { iTempDesireToMove05 = NPC_AI.DesireToMove049; bTempCorpse05 = NPC_AI.bCorpse049; iTempLoyalty05 = NPC_AI.iLoyalty049; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins049; sTempWeapons05 = NPC_AI.sAvailableWeapons049; }
            if (Actor05 == NPC_AI.NPC_050) { iTempDesireToMove05 = NPC_AI.DesireToMove050; bTempCorpse05 = NPC_AI.bCorpse050; iTempLoyalty05 = NPC_AI.iLoyalty050; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins050; sTempWeapons05 = NPC_AI.sAvailableWeapons050; }
            if (Actor05 == NPC_AI.NPC_051) { iTempDesireToMove05 = NPC_AI.DesireToMove051; bTempCorpse05 = NPC_AI.bCorpse051; iTempLoyalty05 = NPC_AI.iLoyalty051; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins051; sTempWeapons05 = NPC_AI.sAvailableWeapons051; }
            if (Actor05 == NPC_AI.NPC_052) { iTempDesireToMove05 = NPC_AI.DesireToMove052; bTempCorpse05 = NPC_AI.bCorpse052; iTempLoyalty05 = NPC_AI.iLoyalty052; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins052; sTempWeapons05 = NPC_AI.sAvailableWeapons052; }
            if (Actor05 == NPC_AI.NPC_053) { iTempDesireToMove05 = NPC_AI.DesireToMove053; bTempCorpse05 = NPC_AI.bCorpse053; iTempLoyalty05 = NPC_AI.iLoyalty053; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins053; sTempWeapons05 = NPC_AI.sAvailableWeapons053; }
            if (Actor05 == NPC_AI.NPC_054) { iTempDesireToMove05 = NPC_AI.DesireToMove054; bTempCorpse05 = NPC_AI.bCorpse054; iTempLoyalty05 = NPC_AI.iLoyalty054; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins054; sTempWeapons05 = NPC_AI.sAvailableWeapons054; }
            if (Actor05 == NPC_AI.NPC_055) { iTempDesireToMove05 = NPC_AI.DesireToMove055; bTempCorpse05 = NPC_AI.bCorpse055; iTempLoyalty05 = NPC_AI.iLoyalty055; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins055; sTempWeapons05 = NPC_AI.sAvailableWeapons055; }
            if (Actor05 == NPC_AI.NPC_056) { iTempDesireToMove05 = NPC_AI.DesireToMove056; bTempCorpse05 = NPC_AI.bCorpse056; iTempLoyalty05 = NPC_AI.iLoyalty056; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins056; sTempWeapons05 = NPC_AI.sAvailableWeapons056; }
            if (Actor05 == NPC_AI.NPC_057) { iTempDesireToMove05 = NPC_AI.DesireToMove057; bTempCorpse05 = NPC_AI.bCorpse057; iTempLoyalty05 = NPC_AI.iLoyalty057; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins057; sTempWeapons05 = NPC_AI.sAvailableWeapons057; }
            if (Actor05 == NPC_AI.NPC_058) { iTempDesireToMove05 = NPC_AI.DesireToMove058; bTempCorpse05 = NPC_AI.bCorpse058; iTempLoyalty05 = NPC_AI.iLoyalty058; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins058; sTempWeapons05 = NPC_AI.sAvailableWeapons058; }
            if (Actor05 == NPC_AI.NPC_059) { iTempDesireToMove05 = NPC_AI.DesireToMove059; bTempCorpse05 = NPC_AI.bCorpse059; iTempLoyalty05 = NPC_AI.iLoyalty059; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins059; sTempWeapons05 = NPC_AI.sAvailableWeapons059; }
            if (Actor05 == NPC_AI.NPC_060) { iTempDesireToMove05 = NPC_AI.DesireToMove060; bTempCorpse05 = NPC_AI.bCorpse060; iTempLoyalty05 = NPC_AI.iLoyalty060; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins060; sTempWeapons05 = NPC_AI.sAvailableWeapons060; }
            if (Actor05 == NPC_AI.NPC_061) { iTempDesireToMove05 = NPC_AI.DesireToMove061; bTempCorpse05 = NPC_AI.bCorpse061; iTempLoyalty05 = NPC_AI.iLoyalty061; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins061; sTempWeapons05 = NPC_AI.sAvailableWeapons061; }
            if (Actor05 == NPC_AI.NPC_062) { iTempDesireToMove05 = NPC_AI.DesireToMove062; bTempCorpse05 = NPC_AI.bCorpse062; iTempLoyalty05 = NPC_AI.iLoyalty062; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins062; sTempWeapons05 = NPC_AI.sAvailableWeapons062; }
            if (Actor05 == NPC_AI.NPC_063) { iTempDesireToMove05 = NPC_AI.DesireToMove063; bTempCorpse05 = NPC_AI.bCorpse063; iTempLoyalty05 = NPC_AI.iLoyalty063; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins063; sTempWeapons05 = NPC_AI.sAvailableWeapons063; }
            if (Actor05 == NPC_AI.NPC_064) { iTempDesireToMove05 = NPC_AI.DesireToMove064; bTempCorpse05 = NPC_AI.bCorpse064; iTempLoyalty05 = NPC_AI.iLoyalty054; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins064; sTempWeapons05 = NPC_AI.sAvailableWeapons064; }
            if (Actor05 == NPC_AI.NPC_065) { iTempDesireToMove05 = NPC_AI.DesireToMove065; bTempCorpse05 = NPC_AI.bCorpse065; iTempLoyalty05 = NPC_AI.iLoyalty065; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins065; sTempWeapons05 = NPC_AI.sAvailableWeapons065; }
            if (Actor05 == NPC_AI.NPC_066) { iTempDesireToMove05 = NPC_AI.DesireToMove066; bTempCorpse05 = NPC_AI.bCorpse066; iTempLoyalty05 = NPC_AI.iLoyalty066; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins066; sTempWeapons05 = NPC_AI.sAvailableWeapons066; }
            if (Actor05 == NPC_AI.NPC_067) { iTempDesireToMove05 = NPC_AI.DesireToMove067; bTempCorpse05 = NPC_AI.bCorpse067; iTempLoyalty05 = NPC_AI.iLoyalty067; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins067; sTempWeapons05 = NPC_AI.sAvailableWeapons067; }
            if (Actor05 == NPC_AI.NPC_068) { iTempDesireToMove05 = NPC_AI.DesireToMove068; bTempCorpse05 = NPC_AI.bCorpse068; iTempLoyalty05 = NPC_AI.iLoyalty068; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins068; sTempWeapons05 = NPC_AI.sAvailableWeapons068; }
            if (Actor05 == NPC_AI.NPC_069) { iTempDesireToMove05 = NPC_AI.DesireToMove069; bTempCorpse05 = NPC_AI.bCorpse069; iTempLoyalty05 = NPC_AI.iLoyalty069; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins069; sTempWeapons05 = NPC_AI.sAvailableWeapons069; }
            if (Actor05 == NPC_AI.NPC_070) { iTempDesireToMove05 = NPC_AI.DesireToMove070; bTempCorpse05 = NPC_AI.bCorpse070; iTempLoyalty05 = NPC_AI.iLoyalty070; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins070; sTempWeapons05 = NPC_AI.sAvailableWeapons070; }
            if (Actor05 == NPC_AI.NPC_071) { iTempDesireToMove05 = NPC_AI.DesireToMove071; bTempCorpse05 = NPC_AI.bCorpse071; iTempLoyalty05 = NPC_AI.iLoyalty071; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins071; sTempWeapons05 = NPC_AI.sAvailableWeapons071; }
            if (Actor05 == NPC_AI.NPC_072) { iTempDesireToMove05 = NPC_AI.DesireToMove072; bTempCorpse05 = NPC_AI.bCorpse072; iTempLoyalty05 = NPC_AI.iLoyalty072; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins072; sTempWeapons05 = NPC_AI.sAvailableWeapons072; }
            if (Actor05 == NPC_AI.NPC_073) { iTempDesireToMove05 = NPC_AI.DesireToMove073; bTempCorpse05 = NPC_AI.bCorpse073; iTempLoyalty05 = NPC_AI.iLoyalty073; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins073; sTempWeapons05 = NPC_AI.sAvailableWeapons073; }
            if (Actor05 == NPC_AI.NPC_074) { iTempDesireToMove05 = NPC_AI.DesireToMove074; bTempCorpse05 = NPC_AI.bCorpse074; iTempLoyalty05 = NPC_AI.iLoyalty074; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins074; sTempWeapons05 = NPC_AI.sAvailableWeapons074; }
            if (Actor05 == NPC_AI.NPC_075) { iTempDesireToMove05 = NPC_AI.DesireToMove075; bTempCorpse05 = NPC_AI.bCorpse075; iTempLoyalty05 = NPC_AI.iLoyalty075; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins075; sTempWeapons05 = NPC_AI.sAvailableWeapons075; }
            if (Actor05 == NPC_AI.NPC_076) { iTempDesireToMove05 = NPC_AI.DesireToMove076; bTempCorpse05 = NPC_AI.bCorpse076; iTempLoyalty05 = NPC_AI.iLoyalty076; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins076; sTempWeapons05 = NPC_AI.sAvailableWeapons076; }
            if (Actor05 == NPC_AI.NPC_077) { iTempDesireToMove05 = NPC_AI.DesireToMove077; bTempCorpse05 = NPC_AI.bCorpse077; iTempLoyalty05 = NPC_AI.iLoyalty077; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins077; sTempWeapons05 = NPC_AI.sAvailableWeapons077; }
            if (Actor05 == NPC_AI.NPC_078) { iTempDesireToMove05 = NPC_AI.DesireToMove078; bTempCorpse05 = NPC_AI.bCorpse078; iTempLoyalty05 = NPC_AI.iLoyalty078; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins078; sTempWeapons05 = NPC_AI.sAvailableWeapons078; }
            if (Actor05 == NPC_AI.NPC_079) { iTempDesireToMove05 = NPC_AI.DesireToMove079; bTempCorpse05 = NPC_AI.bCorpse079; iTempLoyalty05 = NPC_AI.iLoyalty079; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins079; sTempWeapons05 = NPC_AI.sAvailableWeapons079; }
            if (Actor05 == NPC_AI.NPC_080) { iTempDesireToMove05 = NPC_AI.DesireToMove080; bTempCorpse05 = NPC_AI.bCorpse080; iTempLoyalty05 = NPC_AI.iLoyalty080; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins080; sTempWeapons05 = NPC_AI.sAvailableWeapons080; }
            if (Actor05 == NPC_AI.NPC_081) { iTempDesireToMove05 = NPC_AI.DesireToMove081; bTempCorpse05 = NPC_AI.bCorpse081; iTempLoyalty05 = NPC_AI.iLoyalty081; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins081; sTempWeapons05 = NPC_AI.sAvailableWeapons081; }
            if (Actor05 == NPC_AI.NPC_082) { iTempDesireToMove05 = NPC_AI.DesireToMove082; bTempCorpse05 = NPC_AI.bCorpse082; iTempLoyalty05 = NPC_AI.iLoyalty082; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins082; sTempWeapons05 = NPC_AI.sAvailableWeapons082; }
            if (Actor05 == NPC_AI.NPC_083) { iTempDesireToMove05 = NPC_AI.DesireToMove083; bTempCorpse05 = NPC_AI.bCorpse083; iTempLoyalty05 = NPC_AI.iLoyalty083; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins083; sTempWeapons05 = NPC_AI.sAvailableWeapons083; }
            if (Actor05 == NPC_AI.NPC_084) { iTempDesireToMove05 = NPC_AI.DesireToMove084; bTempCorpse05 = NPC_AI.bCorpse084; iTempLoyalty05 = NPC_AI.iLoyalty084; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins084; sTempWeapons05 = NPC_AI.sAvailableWeapons084; }
            if (Actor05 == NPC_AI.NPC_085) { iTempDesireToMove05 = NPC_AI.DesireToMove085; bTempCorpse05 = NPC_AI.bCorpse085; iTempLoyalty05 = NPC_AI.iLoyalty085; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins085; sTempWeapons05 = NPC_AI.sAvailableWeapons085; }
            if (Actor05 == NPC_AI.NPC_086) { iTempDesireToMove05 = NPC_AI.DesireToMove086; bTempCorpse05 = NPC_AI.bCorpse086; iTempLoyalty05 = NPC_AI.iLoyalty086; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins086; sTempWeapons05 = NPC_AI.sAvailableWeapons086; }
            if (Actor05 == NPC_AI.NPC_087) { iTempDesireToMove05 = NPC_AI.DesireToMove087; bTempCorpse05 = NPC_AI.bCorpse087; iTempLoyalty05 = NPC_AI.iLoyalty087; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins087; sTempWeapons05 = NPC_AI.sAvailableWeapons087; }
            if (Actor05 == NPC_AI.NPC_088) { iTempDesireToMove05 = NPC_AI.DesireToMove088; bTempCorpse05 = NPC_AI.bCorpse088; iTempLoyalty05 = NPC_AI.iLoyalty088; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins088; sTempWeapons05 = NPC_AI.sAvailableWeapons088; }
            if (Actor05 == NPC_AI.NPC_089) { iTempDesireToMove05 = NPC_AI.DesireToMove089; bTempCorpse05 = NPC_AI.bCorpse089; iTempLoyalty05 = NPC_AI.iLoyalty089; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins089; sTempWeapons05 = NPC_AI.sAvailableWeapons089; }
            if (Actor05 == NPC_AI.NPC_090) { iTempDesireToMove05 = NPC_AI.DesireToMove090; bTempCorpse05 = NPC_AI.bCorpse090; iTempLoyalty05 = NPC_AI.iLoyalty090; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins090; sTempWeapons05 = NPC_AI.sAvailableWeapons090; }
            if (Actor05 == NPC_AI.NPC_091) { iTempDesireToMove05 = NPC_AI.DesireToMove091; bTempCorpse05 = NPC_AI.bCorpse091; iTempLoyalty05 = NPC_AI.iLoyalty091; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins091; sTempWeapons05 = NPC_AI.sAvailableWeapons091; }
            if (Actor05 == NPC_AI.NPC_092) { iTempDesireToMove05 = NPC_AI.DesireToMove092; bTempCorpse05 = NPC_AI.bCorpse092; iTempLoyalty05 = NPC_AI.iLoyalty092; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins092; sTempWeapons05 = NPC_AI.sAvailableWeapons092; }
            if (Actor05 == NPC_AI.NPC_093) { iTempDesireToMove05 = NPC_AI.DesireToMove093; bTempCorpse05 = NPC_AI.bCorpse093; iTempLoyalty05 = NPC_AI.iLoyalty093; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins093; sTempWeapons05 = NPC_AI.sAvailableWeapons093; }
            if (Actor05 == NPC_AI.NPC_094) { iTempDesireToMove05 = NPC_AI.DesireToMove094; bTempCorpse05 = NPC_AI.bCorpse094; iTempLoyalty05 = NPC_AI.iLoyalty094; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins094; sTempWeapons05 = NPC_AI.sAvailableWeapons094; }
            if (Actor05 == NPC_AI.NPC_095) { iTempDesireToMove05 = NPC_AI.DesireToMove095; bTempCorpse05 = NPC_AI.bCorpse095; iTempLoyalty05 = NPC_AI.iLoyalty095; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins095; sTempWeapons05 = NPC_AI.sAvailableWeapons095; }
            if (Actor05 == NPC_AI.NPC_096) { iTempDesireToMove05 = NPC_AI.DesireToMove096; bTempCorpse05 = NPC_AI.bCorpse096; iTempLoyalty05 = NPC_AI.iLoyalty096; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins096; sTempWeapons05 = NPC_AI.sAvailableWeapons096; }
            if (Actor05 == NPC_AI.NPC_097) { iTempDesireToMove05 = NPC_AI.DesireToMove097; bTempCorpse05 = NPC_AI.bCorpse097; iTempLoyalty05 = NPC_AI.iLoyalty097; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins097; sTempWeapons05 = NPC_AI.sAvailableWeapons097; }
            if (Actor05 == NPC_AI.NPC_098) { iTempDesireToMove05 = NPC_AI.DesireToMove098; bTempCorpse05 = NPC_AI.bCorpse098; iTempLoyalty05 = NPC_AI.iLoyalty098; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins098; sTempWeapons05 = NPC_AI.sAvailableWeapons098; }
            if (Actor05 == NPC_AI.NPC_099) { iTempDesireToMove05 = NPC_AI.DesireToMove099; bTempCorpse05 = NPC_AI.bCorpse099; iTempLoyalty05 = NPC_AI.iLoyalty099; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins099; sTempWeapons05 = NPC_AI.sAvailableWeapons099; }
            if (Actor05 == NPC_AI.NPC_100) { iTempDesireToMove05 = NPC_AI.DesireToMove100; bTempCorpse05 = NPC_AI.bCorpse100; iTempLoyalty05 = NPC_AI.iLoyalty100; iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins100; sTempWeapons05 = NPC_AI.sAvailableWeapons100; }

            if (Actor06 == NPC_AI.NPC_001) { iTempDesireToMove06 = NPC_AI.DesireToMove001; bTempCorpse06 = NPC_AI.bCorpse001; iTempLoyalty06 = NPC_AI.iLoyalty001; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins001; sTempWeapons06 = NPC_AI.sAvailableWeapons001; }
            if (Actor06 == NPC_AI.NPC_002) { iTempDesireToMove06 = NPC_AI.DesireToMove002; bTempCorpse06 = NPC_AI.bCorpse002; iTempLoyalty06 = NPC_AI.iLoyalty002; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins002; sTempWeapons06 = NPC_AI.sAvailableWeapons002; }
            if (Actor06 == NPC_AI.NPC_003) { iTempDesireToMove06 = NPC_AI.DesireToMove003; bTempCorpse06 = NPC_AI.bCorpse003; iTempLoyalty06 = NPC_AI.iLoyalty003; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins003; sTempWeapons06 = NPC_AI.sAvailableWeapons003; }
            if (Actor06 == NPC_AI.NPC_004) { iTempDesireToMove06 = NPC_AI.DesireToMove004; bTempCorpse06 = NPC_AI.bCorpse004; iTempLoyalty06 = NPC_AI.iLoyalty004; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins004; sTempWeapons06 = NPC_AI.sAvailableWeapons004; }
            if (Actor06 == NPC_AI.NPC_005) { iTempDesireToMove06 = NPC_AI.DesireToMove005; bTempCorpse06 = NPC_AI.bCorpse005; iTempLoyalty06 = NPC_AI.iLoyalty005; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins005; sTempWeapons06 = NPC_AI.sAvailableWeapons005; }
            if (Actor06 == NPC_AI.NPC_006) { iTempDesireToMove06 = NPC_AI.DesireToMove006; bTempCorpse06 = NPC_AI.bCorpse006; iTempLoyalty06 = NPC_AI.iLoyalty006; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins006; sTempWeapons06 = NPC_AI.sAvailableWeapons006; }
            if (Actor06 == NPC_AI.NPC_007) { iTempDesireToMove06 = NPC_AI.DesireToMove007; bTempCorpse06 = NPC_AI.bCorpse007; iTempLoyalty06 = NPC_AI.iLoyalty007; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins007; sTempWeapons06 = NPC_AI.sAvailableWeapons007; }
            if (Actor06 == NPC_AI.NPC_008) { iTempDesireToMove06 = NPC_AI.DesireToMove008; bTempCorpse06 = NPC_AI.bCorpse008; iTempLoyalty06 = NPC_AI.iLoyalty008; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins008; sTempWeapons06 = NPC_AI.sAvailableWeapons008; }
            if (Actor06 == NPC_AI.NPC_009) { iTempDesireToMove06 = NPC_AI.DesireToMove009; bTempCorpse06 = NPC_AI.bCorpse009; iTempLoyalty06 = NPC_AI.iLoyalty009; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins009; sTempWeapons06 = NPC_AI.sAvailableWeapons009; }
            if (Actor06 == NPC_AI.NPC_010) { iTempDesireToMove06 = NPC_AI.DesireToMove010; bTempCorpse06 = NPC_AI.bCorpse010; iTempLoyalty06 = NPC_AI.iLoyalty010; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins010; sTempWeapons06 = NPC_AI.sAvailableWeapons010; }
            if (Actor06 == NPC_AI.NPC_011) { iTempDesireToMove06 = NPC_AI.DesireToMove011; bTempCorpse06 = NPC_AI.bCorpse011; iTempLoyalty06 = NPC_AI.iLoyalty011; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins011; sTempWeapons06 = NPC_AI.sAvailableWeapons011; }
            if (Actor06 == NPC_AI.NPC_012) { iTempDesireToMove06 = NPC_AI.DesireToMove012; bTempCorpse06 = NPC_AI.bCorpse012; iTempLoyalty06 = NPC_AI.iLoyalty012; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins012; sTempWeapons06 = NPC_AI.sAvailableWeapons012; }
            if (Actor06 == NPC_AI.NPC_013) { iTempDesireToMove06 = NPC_AI.DesireToMove013; bTempCorpse06 = NPC_AI.bCorpse013; iTempLoyalty06 = NPC_AI.iLoyalty013; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins013; sTempWeapons06 = NPC_AI.sAvailableWeapons013; }
            if (Actor06 == NPC_AI.NPC_014) { iTempDesireToMove06 = NPC_AI.DesireToMove014; bTempCorpse06 = NPC_AI.bCorpse014; iTempLoyalty06 = NPC_AI.iLoyalty014; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins014; sTempWeapons06 = NPC_AI.sAvailableWeapons014; }
            if (Actor06 == NPC_AI.NPC_015) { iTempDesireToMove06 = NPC_AI.DesireToMove015; bTempCorpse06 = NPC_AI.bCorpse015; iTempLoyalty06 = NPC_AI.iLoyalty015; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins015; sTempWeapons06 = NPC_AI.sAvailableWeapons015; }
            if (Actor06 == NPC_AI.NPC_016) { iTempDesireToMove06 = NPC_AI.DesireToMove016; bTempCorpse06 = NPC_AI.bCorpse016; iTempLoyalty06 = NPC_AI.iLoyalty016; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins016; sTempWeapons06 = NPC_AI.sAvailableWeapons016; }
            if (Actor06 == NPC_AI.NPC_017) { iTempDesireToMove06 = NPC_AI.DesireToMove017; bTempCorpse06 = NPC_AI.bCorpse017; iTempLoyalty06 = NPC_AI.iLoyalty017; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins017; sTempWeapons06 = NPC_AI.sAvailableWeapons017; }
            if (Actor06 == NPC_AI.NPC_018) { iTempDesireToMove06 = NPC_AI.DesireToMove018; bTempCorpse06 = NPC_AI.bCorpse018; iTempLoyalty06 = NPC_AI.iLoyalty018; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins018; sTempWeapons06 = NPC_AI.sAvailableWeapons018; }
            if (Actor06 == NPC_AI.NPC_019) { iTempDesireToMove06 = NPC_AI.DesireToMove019; bTempCorpse06 = NPC_AI.bCorpse019; iTempLoyalty06 = NPC_AI.iLoyalty019; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins019; sTempWeapons06 = NPC_AI.sAvailableWeapons019; }
            if (Actor06 == NPC_AI.NPC_020) { iTempDesireToMove06 = NPC_AI.DesireToMove020; bTempCorpse06 = NPC_AI.bCorpse020; iTempLoyalty06 = NPC_AI.iLoyalty020; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins020; sTempWeapons06 = NPC_AI.sAvailableWeapons020; }
            if (Actor06 == NPC_AI.NPC_021) { iTempDesireToMove06 = NPC_AI.DesireToMove021; bTempCorpse06 = NPC_AI.bCorpse021; iTempLoyalty06 = NPC_AI.iLoyalty021; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins021; sTempWeapons06 = NPC_AI.sAvailableWeapons021; }
            if (Actor06 == NPC_AI.NPC_022) { iTempDesireToMove06 = NPC_AI.DesireToMove022; bTempCorpse06 = NPC_AI.bCorpse022; iTempLoyalty06 = NPC_AI.iLoyalty022; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins022; sTempWeapons06 = NPC_AI.sAvailableWeapons022; }
            if (Actor06 == NPC_AI.NPC_023) { iTempDesireToMove06 = NPC_AI.DesireToMove023; bTempCorpse06 = NPC_AI.bCorpse023; iTempLoyalty06 = NPC_AI.iLoyalty023; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins023; sTempWeapons06 = NPC_AI.sAvailableWeapons023; }
            if (Actor06 == NPC_AI.NPC_024) { iTempDesireToMove06 = NPC_AI.DesireToMove024; bTempCorpse06 = NPC_AI.bCorpse024; iTempLoyalty06 = NPC_AI.iLoyalty024; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins024; sTempWeapons06 = NPC_AI.sAvailableWeapons024; }
            if (Actor06 == NPC_AI.NPC_025) { iTempDesireToMove06 = NPC_AI.DesireToMove025; bTempCorpse06 = NPC_AI.bCorpse025; iTempLoyalty06 = NPC_AI.iLoyalty025; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins025; sTempWeapons06 = NPC_AI.sAvailableWeapons025; }
            if (Actor06 == NPC_AI.NPC_026) { iTempDesireToMove06 = NPC_AI.DesireToMove026; bTempCorpse06 = NPC_AI.bCorpse026; iTempLoyalty06 = NPC_AI.iLoyalty026; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins026; sTempWeapons06 = NPC_AI.sAvailableWeapons026; }
            if (Actor06 == NPC_AI.NPC_027) { iTempDesireToMove06 = NPC_AI.DesireToMove027; bTempCorpse06 = NPC_AI.bCorpse027; iTempLoyalty06 = NPC_AI.iLoyalty027; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins027; sTempWeapons06 = NPC_AI.sAvailableWeapons027; }
            if (Actor06 == NPC_AI.NPC_028) { iTempDesireToMove06 = NPC_AI.DesireToMove028; bTempCorpse06 = NPC_AI.bCorpse028; iTempLoyalty06 = NPC_AI.iLoyalty028; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins028; sTempWeapons06 = NPC_AI.sAvailableWeapons028; }
            if (Actor06 == NPC_AI.NPC_029) { iTempDesireToMove06 = NPC_AI.DesireToMove029; bTempCorpse06 = NPC_AI.bCorpse029; iTempLoyalty06 = NPC_AI.iLoyalty029; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins029; sTempWeapons06 = NPC_AI.sAvailableWeapons029; }
            if (Actor06 == NPC_AI.NPC_030) { iTempDesireToMove06 = NPC_AI.DesireToMove030; bTempCorpse06 = NPC_AI.bCorpse030; iTempLoyalty06 = NPC_AI.iLoyalty030; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins030; sTempWeapons06 = NPC_AI.sAvailableWeapons030; }
            if (Actor06 == NPC_AI.NPC_031) { iTempDesireToMove06 = NPC_AI.DesireToMove031; bTempCorpse06 = NPC_AI.bCorpse031; iTempLoyalty06 = NPC_AI.iLoyalty031; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins031; sTempWeapons06 = NPC_AI.sAvailableWeapons031; }
            if (Actor06 == NPC_AI.NPC_032) { iTempDesireToMove06 = NPC_AI.DesireToMove032; bTempCorpse06 = NPC_AI.bCorpse032; iTempLoyalty06 = NPC_AI.iLoyalty032; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins032; sTempWeapons06 = NPC_AI.sAvailableWeapons032; }
            if (Actor06 == NPC_AI.NPC_033) { iTempDesireToMove06 = NPC_AI.DesireToMove033; bTempCorpse06 = NPC_AI.bCorpse033; iTempLoyalty06 = NPC_AI.iLoyalty033; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins033; sTempWeapons06 = NPC_AI.sAvailableWeapons033; }
            if (Actor06 == NPC_AI.NPC_034) { iTempDesireToMove06 = NPC_AI.DesireToMove034; bTempCorpse06 = NPC_AI.bCorpse034; iTempLoyalty06 = NPC_AI.iLoyalty034; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins034; sTempWeapons06 = NPC_AI.sAvailableWeapons034; }
            if (Actor06 == NPC_AI.NPC_035) { iTempDesireToMove06 = NPC_AI.DesireToMove035; bTempCorpse06 = NPC_AI.bCorpse035; iTempLoyalty06 = NPC_AI.iLoyalty035; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins035; sTempWeapons06 = NPC_AI.sAvailableWeapons035; }
            if (Actor06 == NPC_AI.NPC_036) { iTempDesireToMove06 = NPC_AI.DesireToMove036; bTempCorpse06 = NPC_AI.bCorpse036; iTempLoyalty06 = NPC_AI.iLoyalty036; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins036; sTempWeapons06 = NPC_AI.sAvailableWeapons036; }
            if (Actor06 == NPC_AI.NPC_037) { iTempDesireToMove06 = NPC_AI.DesireToMove037; bTempCorpse06 = NPC_AI.bCorpse037; iTempLoyalty06 = NPC_AI.iLoyalty037; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins037; sTempWeapons06 = NPC_AI.sAvailableWeapons037; }
            if (Actor06 == NPC_AI.NPC_038) { iTempDesireToMove06 = NPC_AI.DesireToMove038; bTempCorpse06 = NPC_AI.bCorpse038; iTempLoyalty06 = NPC_AI.iLoyalty038; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins038; sTempWeapons06 = NPC_AI.sAvailableWeapons038; }
            if (Actor06 == NPC_AI.NPC_039) { iTempDesireToMove06 = NPC_AI.DesireToMove039; bTempCorpse06 = NPC_AI.bCorpse039; iTempLoyalty06 = NPC_AI.iLoyalty039; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins039; sTempWeapons06 = NPC_AI.sAvailableWeapons039; }
            if (Actor06 == NPC_AI.NPC_040) { iTempDesireToMove06 = NPC_AI.DesireToMove040; bTempCorpse06 = NPC_AI.bCorpse040; iTempLoyalty06 = NPC_AI.iLoyalty040; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins040; sTempWeapons06 = NPC_AI.sAvailableWeapons040; }
            if (Actor06 == NPC_AI.NPC_041) { iTempDesireToMove06 = NPC_AI.DesireToMove041; bTempCorpse06 = NPC_AI.bCorpse041; iTempLoyalty06 = NPC_AI.iLoyalty041; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins041; sTempWeapons06 = NPC_AI.sAvailableWeapons041; }
            if (Actor06 == NPC_AI.NPC_042) { iTempDesireToMove06 = NPC_AI.DesireToMove042; bTempCorpse06 = NPC_AI.bCorpse042; iTempLoyalty06 = NPC_AI.iLoyalty042; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins042; sTempWeapons06 = NPC_AI.sAvailableWeapons042; }
            if (Actor06 == NPC_AI.NPC_043) { iTempDesireToMove06 = NPC_AI.DesireToMove043; bTempCorpse06 = NPC_AI.bCorpse043; iTempLoyalty06 = NPC_AI.iLoyalty043; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins043; sTempWeapons06 = NPC_AI.sAvailableWeapons043; }
            if (Actor06 == NPC_AI.NPC_044) { iTempDesireToMove06 = NPC_AI.DesireToMove044; bTempCorpse06 = NPC_AI.bCorpse044; iTempLoyalty06 = NPC_AI.iLoyalty044; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins044; sTempWeapons06 = NPC_AI.sAvailableWeapons044; }
            if (Actor06 == NPC_AI.NPC_045) { iTempDesireToMove06 = NPC_AI.DesireToMove045; bTempCorpse06 = NPC_AI.bCorpse045; iTempLoyalty06 = NPC_AI.iLoyalty045; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins045; sTempWeapons06 = NPC_AI.sAvailableWeapons045; }
            if (Actor06 == NPC_AI.NPC_046) { iTempDesireToMove06 = NPC_AI.DesireToMove046; bTempCorpse06 = NPC_AI.bCorpse046; iTempLoyalty06 = NPC_AI.iLoyalty046; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins046; sTempWeapons06 = NPC_AI.sAvailableWeapons046; }
            if (Actor06 == NPC_AI.NPC_047) { iTempDesireToMove06 = NPC_AI.DesireToMove047; bTempCorpse06 = NPC_AI.bCorpse047; iTempLoyalty06 = NPC_AI.iLoyalty047; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins047; sTempWeapons06 = NPC_AI.sAvailableWeapons047; }
            if (Actor06 == NPC_AI.NPC_048) { iTempDesireToMove06 = NPC_AI.DesireToMove048; bTempCorpse06 = NPC_AI.bCorpse048; iTempLoyalty06 = NPC_AI.iLoyalty048; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins048; sTempWeapons06 = NPC_AI.sAvailableWeapons048; }
            if (Actor06 == NPC_AI.NPC_049) { iTempDesireToMove06 = NPC_AI.DesireToMove049; bTempCorpse06 = NPC_AI.bCorpse049; iTempLoyalty06 = NPC_AI.iLoyalty049; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins049; sTempWeapons06 = NPC_AI.sAvailableWeapons049; }
            if (Actor06 == NPC_AI.NPC_050) { iTempDesireToMove06 = NPC_AI.DesireToMove050; bTempCorpse06 = NPC_AI.bCorpse050; iTempLoyalty06 = NPC_AI.iLoyalty050; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins050; sTempWeapons06 = NPC_AI.sAvailableWeapons050; }
            if (Actor06 == NPC_AI.NPC_051) { iTempDesireToMove06 = NPC_AI.DesireToMove051; bTempCorpse06 = NPC_AI.bCorpse051; iTempLoyalty06 = NPC_AI.iLoyalty051; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins051; sTempWeapons06 = NPC_AI.sAvailableWeapons051; }
            if (Actor06 == NPC_AI.NPC_052) { iTempDesireToMove06 = NPC_AI.DesireToMove052; bTempCorpse06 = NPC_AI.bCorpse052; iTempLoyalty06 = NPC_AI.iLoyalty052; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins052; sTempWeapons06 = NPC_AI.sAvailableWeapons052; }
            if (Actor06 == NPC_AI.NPC_053) { iTempDesireToMove06 = NPC_AI.DesireToMove053; bTempCorpse06 = NPC_AI.bCorpse053; iTempLoyalty06 = NPC_AI.iLoyalty053; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins053; sTempWeapons06 = NPC_AI.sAvailableWeapons053; }
            if (Actor06 == NPC_AI.NPC_054) { iTempDesireToMove06 = NPC_AI.DesireToMove054; bTempCorpse06 = NPC_AI.bCorpse054; iTempLoyalty06 = NPC_AI.iLoyalty054; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins054; sTempWeapons06 = NPC_AI.sAvailableWeapons054; }
            if (Actor06 == NPC_AI.NPC_055) { iTempDesireToMove06 = NPC_AI.DesireToMove055; bTempCorpse06 = NPC_AI.bCorpse055; iTempLoyalty06 = NPC_AI.iLoyalty055; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins055; sTempWeapons06 = NPC_AI.sAvailableWeapons055; }
            if (Actor06 == NPC_AI.NPC_056) { iTempDesireToMove06 = NPC_AI.DesireToMove056; bTempCorpse06 = NPC_AI.bCorpse056; iTempLoyalty06 = NPC_AI.iLoyalty056; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins056; sTempWeapons06 = NPC_AI.sAvailableWeapons056; }
            if (Actor06 == NPC_AI.NPC_057) { iTempDesireToMove06 = NPC_AI.DesireToMove057; bTempCorpse06 = NPC_AI.bCorpse057; iTempLoyalty06 = NPC_AI.iLoyalty057; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins057; sTempWeapons06 = NPC_AI.sAvailableWeapons057; }
            if (Actor06 == NPC_AI.NPC_058) { iTempDesireToMove06 = NPC_AI.DesireToMove058; bTempCorpse06 = NPC_AI.bCorpse058; iTempLoyalty06 = NPC_AI.iLoyalty058; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins058; sTempWeapons06 = NPC_AI.sAvailableWeapons058; }
            if (Actor06 == NPC_AI.NPC_059) { iTempDesireToMove06 = NPC_AI.DesireToMove059; bTempCorpse06 = NPC_AI.bCorpse059; iTempLoyalty06 = NPC_AI.iLoyalty059; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins059; sTempWeapons06 = NPC_AI.sAvailableWeapons059; }
            if (Actor06 == NPC_AI.NPC_060) { iTempDesireToMove06 = NPC_AI.DesireToMove060; bTempCorpse06 = NPC_AI.bCorpse060; iTempLoyalty06 = NPC_AI.iLoyalty060; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins060; sTempWeapons06 = NPC_AI.sAvailableWeapons060; }
            if (Actor06 == NPC_AI.NPC_061) { iTempDesireToMove06 = NPC_AI.DesireToMove061; bTempCorpse06 = NPC_AI.bCorpse061; iTempLoyalty06 = NPC_AI.iLoyalty061; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins061; sTempWeapons06 = NPC_AI.sAvailableWeapons061; }
            if (Actor06 == NPC_AI.NPC_062) { iTempDesireToMove06 = NPC_AI.DesireToMove062; bTempCorpse06 = NPC_AI.bCorpse062; iTempLoyalty06 = NPC_AI.iLoyalty062; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins062; sTempWeapons06 = NPC_AI.sAvailableWeapons062; }
            if (Actor06 == NPC_AI.NPC_063) { iTempDesireToMove06 = NPC_AI.DesireToMove063; bTempCorpse06 = NPC_AI.bCorpse063; iTempLoyalty06 = NPC_AI.iLoyalty063; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins063; sTempWeapons06 = NPC_AI.sAvailableWeapons063; }
            if (Actor06 == NPC_AI.NPC_064) { iTempDesireToMove06 = NPC_AI.DesireToMove064; bTempCorpse06 = NPC_AI.bCorpse064; iTempLoyalty06 = NPC_AI.iLoyalty054; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins064; sTempWeapons06 = NPC_AI.sAvailableWeapons064; }
            if (Actor06 == NPC_AI.NPC_065) { iTempDesireToMove06 = NPC_AI.DesireToMove065; bTempCorpse06 = NPC_AI.bCorpse065; iTempLoyalty06 = NPC_AI.iLoyalty065; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins065; sTempWeapons06 = NPC_AI.sAvailableWeapons065; }
            if (Actor06 == NPC_AI.NPC_066) { iTempDesireToMove06 = NPC_AI.DesireToMove066; bTempCorpse06 = NPC_AI.bCorpse066; iTempLoyalty06 = NPC_AI.iLoyalty066; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins066; sTempWeapons06 = NPC_AI.sAvailableWeapons066; }
            if (Actor06 == NPC_AI.NPC_067) { iTempDesireToMove06 = NPC_AI.DesireToMove067; bTempCorpse06 = NPC_AI.bCorpse067; iTempLoyalty06 = NPC_AI.iLoyalty067; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins067; sTempWeapons06 = NPC_AI.sAvailableWeapons067; }
            if (Actor06 == NPC_AI.NPC_068) { iTempDesireToMove06 = NPC_AI.DesireToMove068; bTempCorpse06 = NPC_AI.bCorpse068; iTempLoyalty06 = NPC_AI.iLoyalty068; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins068; sTempWeapons06 = NPC_AI.sAvailableWeapons068; }
            if (Actor06 == NPC_AI.NPC_069) { iTempDesireToMove06 = NPC_AI.DesireToMove069; bTempCorpse06 = NPC_AI.bCorpse069; iTempLoyalty06 = NPC_AI.iLoyalty069; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins069; sTempWeapons06 = NPC_AI.sAvailableWeapons069; }
            if (Actor06 == NPC_AI.NPC_070) { iTempDesireToMove06 = NPC_AI.DesireToMove070; bTempCorpse06 = NPC_AI.bCorpse070; iTempLoyalty06 = NPC_AI.iLoyalty070; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins070; sTempWeapons06 = NPC_AI.sAvailableWeapons070; }
            if (Actor06 == NPC_AI.NPC_071) { iTempDesireToMove06 = NPC_AI.DesireToMove071; bTempCorpse06 = NPC_AI.bCorpse071; iTempLoyalty06 = NPC_AI.iLoyalty071; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins071; sTempWeapons06 = NPC_AI.sAvailableWeapons071; }
            if (Actor06 == NPC_AI.NPC_072) { iTempDesireToMove06 = NPC_AI.DesireToMove072; bTempCorpse06 = NPC_AI.bCorpse072; iTempLoyalty06 = NPC_AI.iLoyalty072; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins072; sTempWeapons06 = NPC_AI.sAvailableWeapons072; }
            if (Actor06 == NPC_AI.NPC_073) { iTempDesireToMove06 = NPC_AI.DesireToMove073; bTempCorpse06 = NPC_AI.bCorpse073; iTempLoyalty06 = NPC_AI.iLoyalty073; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins073; sTempWeapons06 = NPC_AI.sAvailableWeapons073; }
            if (Actor06 == NPC_AI.NPC_074) { iTempDesireToMove06 = NPC_AI.DesireToMove074; bTempCorpse06 = NPC_AI.bCorpse074; iTempLoyalty06 = NPC_AI.iLoyalty074; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins074; sTempWeapons06 = NPC_AI.sAvailableWeapons074; }
            if (Actor06 == NPC_AI.NPC_075) { iTempDesireToMove06 = NPC_AI.DesireToMove075; bTempCorpse06 = NPC_AI.bCorpse075; iTempLoyalty06 = NPC_AI.iLoyalty075; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins075; sTempWeapons06 = NPC_AI.sAvailableWeapons075; }
            if (Actor06 == NPC_AI.NPC_076) { iTempDesireToMove06 = NPC_AI.DesireToMove076; bTempCorpse06 = NPC_AI.bCorpse076; iTempLoyalty06 = NPC_AI.iLoyalty076; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins076; sTempWeapons06 = NPC_AI.sAvailableWeapons076; }
            if (Actor06 == NPC_AI.NPC_077) { iTempDesireToMove06 = NPC_AI.DesireToMove077; bTempCorpse06 = NPC_AI.bCorpse077; iTempLoyalty06 = NPC_AI.iLoyalty077; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins077; sTempWeapons06 = NPC_AI.sAvailableWeapons077; }
            if (Actor06 == NPC_AI.NPC_078) { iTempDesireToMove06 = NPC_AI.DesireToMove078; bTempCorpse06 = NPC_AI.bCorpse078; iTempLoyalty06 = NPC_AI.iLoyalty078; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins078; sTempWeapons06 = NPC_AI.sAvailableWeapons078; }
            if (Actor06 == NPC_AI.NPC_079) { iTempDesireToMove06 = NPC_AI.DesireToMove079; bTempCorpse06 = NPC_AI.bCorpse079; iTempLoyalty06 = NPC_AI.iLoyalty079; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins079; sTempWeapons06 = NPC_AI.sAvailableWeapons079; }
            if (Actor06 == NPC_AI.NPC_080) { iTempDesireToMove06 = NPC_AI.DesireToMove080; bTempCorpse06 = NPC_AI.bCorpse080; iTempLoyalty06 = NPC_AI.iLoyalty080; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins080; sTempWeapons06 = NPC_AI.sAvailableWeapons080; }
            if (Actor06 == NPC_AI.NPC_081) { iTempDesireToMove06 = NPC_AI.DesireToMove081; bTempCorpse06 = NPC_AI.bCorpse081; iTempLoyalty06 = NPC_AI.iLoyalty081; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins081; sTempWeapons06 = NPC_AI.sAvailableWeapons081; }
            if (Actor06 == NPC_AI.NPC_082) { iTempDesireToMove06 = NPC_AI.DesireToMove082; bTempCorpse06 = NPC_AI.bCorpse082; iTempLoyalty06 = NPC_AI.iLoyalty082; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins082; sTempWeapons06 = NPC_AI.sAvailableWeapons082; }
            if (Actor06 == NPC_AI.NPC_083) { iTempDesireToMove06 = NPC_AI.DesireToMove083; bTempCorpse06 = NPC_AI.bCorpse083; iTempLoyalty06 = NPC_AI.iLoyalty083; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins083; sTempWeapons06 = NPC_AI.sAvailableWeapons083; }
            if (Actor06 == NPC_AI.NPC_084) { iTempDesireToMove06 = NPC_AI.DesireToMove084; bTempCorpse06 = NPC_AI.bCorpse084; iTempLoyalty06 = NPC_AI.iLoyalty084; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins084; sTempWeapons06 = NPC_AI.sAvailableWeapons084; }
            if (Actor06 == NPC_AI.NPC_085) { iTempDesireToMove06 = NPC_AI.DesireToMove085; bTempCorpse06 = NPC_AI.bCorpse085; iTempLoyalty06 = NPC_AI.iLoyalty085; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins085; sTempWeapons06 = NPC_AI.sAvailableWeapons085; }
            if (Actor06 == NPC_AI.NPC_086) { iTempDesireToMove06 = NPC_AI.DesireToMove086; bTempCorpse06 = NPC_AI.bCorpse086; iTempLoyalty06 = NPC_AI.iLoyalty086; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins086; sTempWeapons06 = NPC_AI.sAvailableWeapons086; }
            if (Actor06 == NPC_AI.NPC_087) { iTempDesireToMove06 = NPC_AI.DesireToMove087; bTempCorpse06 = NPC_AI.bCorpse087; iTempLoyalty06 = NPC_AI.iLoyalty087; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins087; sTempWeapons06 = NPC_AI.sAvailableWeapons087; }
            if (Actor06 == NPC_AI.NPC_088) { iTempDesireToMove06 = NPC_AI.DesireToMove088; bTempCorpse06 = NPC_AI.bCorpse088; iTempLoyalty06 = NPC_AI.iLoyalty088; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins088; sTempWeapons06 = NPC_AI.sAvailableWeapons088; }
            if (Actor06 == NPC_AI.NPC_089) { iTempDesireToMove06 = NPC_AI.DesireToMove089; bTempCorpse06 = NPC_AI.bCorpse089; iTempLoyalty06 = NPC_AI.iLoyalty089; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins089; sTempWeapons06 = NPC_AI.sAvailableWeapons089; }
            if (Actor06 == NPC_AI.NPC_090) { iTempDesireToMove06 = NPC_AI.DesireToMove090; bTempCorpse06 = NPC_AI.bCorpse090; iTempLoyalty06 = NPC_AI.iLoyalty090; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins090; sTempWeapons06 = NPC_AI.sAvailableWeapons090; }
            if (Actor06 == NPC_AI.NPC_091) { iTempDesireToMove06 = NPC_AI.DesireToMove091; bTempCorpse06 = NPC_AI.bCorpse091; iTempLoyalty06 = NPC_AI.iLoyalty091; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins091; sTempWeapons06 = NPC_AI.sAvailableWeapons091; }
            if (Actor06 == NPC_AI.NPC_092) { iTempDesireToMove06 = NPC_AI.DesireToMove092; bTempCorpse06 = NPC_AI.bCorpse092; iTempLoyalty06 = NPC_AI.iLoyalty092; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins092; sTempWeapons06 = NPC_AI.sAvailableWeapons092; }
            if (Actor06 == NPC_AI.NPC_093) { iTempDesireToMove06 = NPC_AI.DesireToMove093; bTempCorpse06 = NPC_AI.bCorpse093; iTempLoyalty06 = NPC_AI.iLoyalty093; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins093; sTempWeapons06 = NPC_AI.sAvailableWeapons093; }
            if (Actor06 == NPC_AI.NPC_094) { iTempDesireToMove06 = NPC_AI.DesireToMove094; bTempCorpse06 = NPC_AI.bCorpse094; iTempLoyalty06 = NPC_AI.iLoyalty094; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins094; sTempWeapons06 = NPC_AI.sAvailableWeapons094; }
            if (Actor06 == NPC_AI.NPC_095) { iTempDesireToMove06 = NPC_AI.DesireToMove095; bTempCorpse06 = NPC_AI.bCorpse095; iTempLoyalty06 = NPC_AI.iLoyalty095; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins095; sTempWeapons06 = NPC_AI.sAvailableWeapons095; }
            if (Actor06 == NPC_AI.NPC_096) { iTempDesireToMove06 = NPC_AI.DesireToMove096; bTempCorpse06 = NPC_AI.bCorpse096; iTempLoyalty06 = NPC_AI.iLoyalty096; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins096; sTempWeapons06 = NPC_AI.sAvailableWeapons096; }
            if (Actor06 == NPC_AI.NPC_097) { iTempDesireToMove06 = NPC_AI.DesireToMove097; bTempCorpse06 = NPC_AI.bCorpse097; iTempLoyalty06 = NPC_AI.iLoyalty097; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins097; sTempWeapons06 = NPC_AI.sAvailableWeapons097; }
            if (Actor06 == NPC_AI.NPC_098) { iTempDesireToMove06 = NPC_AI.DesireToMove098; bTempCorpse06 = NPC_AI.bCorpse098; iTempLoyalty06 = NPC_AI.iLoyalty098; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins098; sTempWeapons06 = NPC_AI.sAvailableWeapons098; }
            if (Actor06 == NPC_AI.NPC_099) { iTempDesireToMove06 = NPC_AI.DesireToMove099; bTempCorpse06 = NPC_AI.bCorpse099; iTempLoyalty06 = NPC_AI.iLoyalty099; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins099; sTempWeapons06 = NPC_AI.sAvailableWeapons099; }
            if (Actor06 == NPC_AI.NPC_100) { iTempDesireToMove06 = NPC_AI.DesireToMove100; bTempCorpse06 = NPC_AI.bCorpse100; iTempLoyalty06 = NPC_AI.iLoyalty100; iTempMacGuffins06 = NPC_AI.iAvailableMacGuffins100; sTempWeapons06 = NPC_AI.sAvailableWeapons100; }
        }

        public static void SetAllActorLocals()
        {
            if (Actor01 == NPC_AI.NPC_001) { NPC_AI.DesireToMove001 = iTempDesireToMove01;  NPC_AI.bCorpse001 = bTempCorpse01; NPC_AI.iLoyalty001 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins001 = iTempMacGuffins01; NPC_AI.sAvailableWeapons001 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_002) { NPC_AI.DesireToMove002 = iTempDesireToMove01;  NPC_AI.bCorpse002 = bTempCorpse01; NPC_AI.iLoyalty002 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins002 = iTempMacGuffins01; NPC_AI.sAvailableWeapons002 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_003) { NPC_AI.DesireToMove003 = iTempDesireToMove01;  NPC_AI.bCorpse003 = bTempCorpse01; NPC_AI.iLoyalty003 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins003 = iTempMacGuffins01; NPC_AI.sAvailableWeapons003 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_004) { NPC_AI.DesireToMove004 = iTempDesireToMove01;  NPC_AI.bCorpse004 = bTempCorpse01; NPC_AI.iLoyalty004 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins004 = iTempMacGuffins01; NPC_AI.sAvailableWeapons004 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_005) { NPC_AI.DesireToMove005 = iTempDesireToMove01;  NPC_AI.bCorpse005 = bTempCorpse01; NPC_AI.iLoyalty005 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins005 = iTempMacGuffins01; NPC_AI.sAvailableWeapons005 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_006) { NPC_AI.DesireToMove006 = iTempDesireToMove01;  NPC_AI.bCorpse006 = bTempCorpse01; NPC_AI.iLoyalty006 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins006 = iTempMacGuffins01; NPC_AI.sAvailableWeapons006 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_007) { NPC_AI.DesireToMove007 = iTempDesireToMove01;  NPC_AI.bCorpse007 = bTempCorpse01; NPC_AI.iLoyalty007 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins007 = iTempMacGuffins01; NPC_AI.sAvailableWeapons007 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_008) { NPC_AI.DesireToMove008 = iTempDesireToMove01;  NPC_AI.bCorpse008 = bTempCorpse01; NPC_AI.iLoyalty008 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins008 = iTempMacGuffins01; NPC_AI.sAvailableWeapons008 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_009) { NPC_AI.DesireToMove009 = iTempDesireToMove01;  NPC_AI.bCorpse009 = bTempCorpse01; NPC_AI.iLoyalty009 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins009 = iTempMacGuffins01; NPC_AI.sAvailableWeapons009 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_010) { NPC_AI.DesireToMove010 = iTempDesireToMove01;  NPC_AI.bCorpse010 = bTempCorpse01; NPC_AI.iLoyalty010 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins010 = iTempMacGuffins01; NPC_AI.sAvailableWeapons010 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_011) { NPC_AI.DesireToMove011 = iTempDesireToMove01;  NPC_AI.bCorpse011 = bTempCorpse01; NPC_AI.iLoyalty011 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins011 = iTempMacGuffins01; NPC_AI.sAvailableWeapons011 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_012) { NPC_AI.DesireToMove012 = iTempDesireToMove01;  NPC_AI.bCorpse012 = bTempCorpse01; NPC_AI.iLoyalty012 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins012 = iTempMacGuffins01; NPC_AI.sAvailableWeapons012 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_013) { NPC_AI.DesireToMove013 = iTempDesireToMove01;  NPC_AI.bCorpse013 = bTempCorpse01; NPC_AI.iLoyalty013 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins013 = iTempMacGuffins01; NPC_AI.sAvailableWeapons013 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_014) { NPC_AI.DesireToMove014 = iTempDesireToMove01;  NPC_AI.bCorpse014 = bTempCorpse01; NPC_AI.iLoyalty014 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins014 = iTempMacGuffins01; NPC_AI.sAvailableWeapons014 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_015) { NPC_AI.DesireToMove015 = iTempDesireToMove01;  NPC_AI.bCorpse015 = bTempCorpse01; NPC_AI.iLoyalty015 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins015 = iTempMacGuffins01; NPC_AI.sAvailableWeapons015 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_016) { NPC_AI.DesireToMove016 = iTempDesireToMove01;  NPC_AI.bCorpse016 = bTempCorpse01; NPC_AI.iLoyalty016 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins016 = iTempMacGuffins01; NPC_AI.sAvailableWeapons016 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_017) { NPC_AI.DesireToMove017 = iTempDesireToMove01;  NPC_AI.bCorpse017 = bTempCorpse01; NPC_AI.iLoyalty017 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins017 = iTempMacGuffins01; NPC_AI.sAvailableWeapons017 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_018) { NPC_AI.DesireToMove018 = iTempDesireToMove01;  NPC_AI.bCorpse018 = bTempCorpse01; NPC_AI.iLoyalty018 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins018 = iTempMacGuffins01; NPC_AI.sAvailableWeapons018 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_019) { NPC_AI.DesireToMove019 = iTempDesireToMove01;  NPC_AI.bCorpse019 = bTempCorpse01; NPC_AI.iLoyalty019 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins019 = iTempMacGuffins01; NPC_AI.sAvailableWeapons019 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_020) { NPC_AI.DesireToMove020 = iTempDesireToMove01;  NPC_AI.bCorpse020 = bTempCorpse01; NPC_AI.iLoyalty020 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins020 = iTempMacGuffins01; NPC_AI.sAvailableWeapons020 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_021) { NPC_AI.DesireToMove021 = iTempDesireToMove01;  NPC_AI.bCorpse021 = bTempCorpse01; NPC_AI.iLoyalty021 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins021 = iTempMacGuffins01; NPC_AI.sAvailableWeapons021 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_022) { NPC_AI.DesireToMove022 = iTempDesireToMove01;  NPC_AI.bCorpse022 = bTempCorpse01; NPC_AI.iLoyalty022 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins022 = iTempMacGuffins01; NPC_AI.sAvailableWeapons022 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_023) { NPC_AI.DesireToMove023 = iTempDesireToMove01;  NPC_AI.bCorpse023 = bTempCorpse01; NPC_AI.iLoyalty023 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins023 = iTempMacGuffins01; NPC_AI.sAvailableWeapons023 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_024) { NPC_AI.DesireToMove024 = iTempDesireToMove01;  NPC_AI.bCorpse024 = bTempCorpse01; NPC_AI.iLoyalty024 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins024 = iTempMacGuffins01; NPC_AI.sAvailableWeapons024 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_025) { NPC_AI.DesireToMove025 = iTempDesireToMove01;  NPC_AI.bCorpse025 = bTempCorpse01; NPC_AI.iLoyalty025 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins025 = iTempMacGuffins01; NPC_AI.sAvailableWeapons025 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_026) { NPC_AI.DesireToMove026 = iTempDesireToMove01;  NPC_AI.bCorpse026 = bTempCorpse01; NPC_AI.iLoyalty026 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins026 = iTempMacGuffins01; NPC_AI.sAvailableWeapons026 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_027) { NPC_AI.DesireToMove027 = iTempDesireToMove01;  NPC_AI.bCorpse027 = bTempCorpse01; NPC_AI.iLoyalty027 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins027 = iTempMacGuffins01; NPC_AI.sAvailableWeapons027 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_028) { NPC_AI.DesireToMove028 = iTempDesireToMove01;  NPC_AI.bCorpse028 = bTempCorpse01; NPC_AI.iLoyalty028 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins028 = iTempMacGuffins01; NPC_AI.sAvailableWeapons028 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_029) { NPC_AI.DesireToMove029 = iTempDesireToMove01;  NPC_AI.bCorpse029 = bTempCorpse01; NPC_AI.iLoyalty029 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins029 = iTempMacGuffins01; NPC_AI.sAvailableWeapons029 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_030) { NPC_AI.DesireToMove030 = iTempDesireToMove01;  NPC_AI.bCorpse030 = bTempCorpse01; NPC_AI.iLoyalty030 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins030 = iTempMacGuffins01; NPC_AI.sAvailableWeapons030 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_031) { NPC_AI.DesireToMove031 = iTempDesireToMove01;  NPC_AI.bCorpse031 = bTempCorpse01; NPC_AI.iLoyalty031 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins031 = iTempMacGuffins01; NPC_AI.sAvailableWeapons031 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_032) { NPC_AI.DesireToMove032 = iTempDesireToMove01;  NPC_AI.bCorpse032 = bTempCorpse01; NPC_AI.iLoyalty032 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins032 = iTempMacGuffins01; NPC_AI.sAvailableWeapons032 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_033) { NPC_AI.DesireToMove033 = iTempDesireToMove01;  NPC_AI.bCorpse033 = bTempCorpse01; NPC_AI.iLoyalty033 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins033 = iTempMacGuffins01; NPC_AI.sAvailableWeapons033 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_034) { NPC_AI.DesireToMove034 = iTempDesireToMove01;  NPC_AI.bCorpse034 = bTempCorpse01; NPC_AI.iLoyalty034 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins034 = iTempMacGuffins01; NPC_AI.sAvailableWeapons034 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_035) { NPC_AI.DesireToMove035 = iTempDesireToMove01;  NPC_AI.bCorpse035 = bTempCorpse01; NPC_AI.iLoyalty035 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins035 = iTempMacGuffins01; NPC_AI.sAvailableWeapons035 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_036) { NPC_AI.DesireToMove036 = iTempDesireToMove01;  NPC_AI.bCorpse036 = bTempCorpse01; NPC_AI.iLoyalty036 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins036 = iTempMacGuffins01; NPC_AI.sAvailableWeapons036 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_037) { NPC_AI.DesireToMove037 = iTempDesireToMove01;  NPC_AI.bCorpse037 = bTempCorpse01; NPC_AI.iLoyalty037 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins037 = iTempMacGuffins01; NPC_AI.sAvailableWeapons037 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_038) { NPC_AI.DesireToMove038 = iTempDesireToMove01;  NPC_AI.bCorpse038 = bTempCorpse01; NPC_AI.iLoyalty038 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins038 = iTempMacGuffins01; NPC_AI.sAvailableWeapons038 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_039) { NPC_AI.DesireToMove039 = iTempDesireToMove01;  NPC_AI.bCorpse039 = bTempCorpse01; NPC_AI.iLoyalty039 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins039 = iTempMacGuffins01; NPC_AI.sAvailableWeapons039 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_040) { NPC_AI.DesireToMove040 = iTempDesireToMove01;  NPC_AI.bCorpse040 = bTempCorpse01; NPC_AI.iLoyalty040 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins040 = iTempMacGuffins01; NPC_AI.sAvailableWeapons040 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_041) { NPC_AI.DesireToMove041 = iTempDesireToMove01;  NPC_AI.bCorpse041 = bTempCorpse01; NPC_AI.iLoyalty041 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins041 = iTempMacGuffins01; NPC_AI.sAvailableWeapons041 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_042) { NPC_AI.DesireToMove042 = iTempDesireToMove01;  NPC_AI.bCorpse042 = bTempCorpse01; NPC_AI.iLoyalty042 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins042 = iTempMacGuffins01; NPC_AI.sAvailableWeapons042 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_043) { NPC_AI.DesireToMove043 = iTempDesireToMove01;  NPC_AI.bCorpse043 = bTempCorpse01; NPC_AI.iLoyalty043 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins043 = iTempMacGuffins01; NPC_AI.sAvailableWeapons043 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_044) { NPC_AI.DesireToMove044 = iTempDesireToMove01;  NPC_AI.bCorpse044 = bTempCorpse01; NPC_AI.iLoyalty044 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins044 = iTempMacGuffins01; NPC_AI.sAvailableWeapons044 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_045) { NPC_AI.DesireToMove045 = iTempDesireToMove01;  NPC_AI.bCorpse045 = bTempCorpse01; NPC_AI.iLoyalty045 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins045 = iTempMacGuffins01; NPC_AI.sAvailableWeapons045 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_046) { NPC_AI.DesireToMove046 = iTempDesireToMove01;  NPC_AI.bCorpse046 = bTempCorpse01; NPC_AI.iLoyalty046 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins046 = iTempMacGuffins01; NPC_AI.sAvailableWeapons046 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_047) { NPC_AI.DesireToMove047 = iTempDesireToMove01;  NPC_AI.bCorpse047 = bTempCorpse01; NPC_AI.iLoyalty047 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins047 = iTempMacGuffins01; NPC_AI.sAvailableWeapons047 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_048) { NPC_AI.DesireToMove048 = iTempDesireToMove01;  NPC_AI.bCorpse048 = bTempCorpse01; NPC_AI.iLoyalty048 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins048 = iTempMacGuffins01; NPC_AI.sAvailableWeapons048 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_049) { NPC_AI.DesireToMove049 = iTempDesireToMove01;  NPC_AI.bCorpse049 = bTempCorpse01; NPC_AI.iLoyalty049 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins049 = iTempMacGuffins01; NPC_AI.sAvailableWeapons049 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_050) { NPC_AI.DesireToMove050 = iTempDesireToMove01;  NPC_AI.bCorpse050 = bTempCorpse01; NPC_AI.iLoyalty050 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins050 = iTempMacGuffins01; NPC_AI.sAvailableWeapons050 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_051) { NPC_AI.DesireToMove051 = iTempDesireToMove01;  NPC_AI.bCorpse051 = bTempCorpse01; NPC_AI.iLoyalty051 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins051 = iTempMacGuffins01; NPC_AI.sAvailableWeapons051 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_052) { NPC_AI.DesireToMove052 = iTempDesireToMove01;  NPC_AI.bCorpse052 = bTempCorpse01; NPC_AI.iLoyalty052 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins052 = iTempMacGuffins01; NPC_AI.sAvailableWeapons052 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_053) { NPC_AI.DesireToMove053 = iTempDesireToMove01;  NPC_AI.bCorpse053 = bTempCorpse01; NPC_AI.iLoyalty053 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins053 = iTempMacGuffins01; NPC_AI.sAvailableWeapons053 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_054) { NPC_AI.DesireToMove054 = iTempDesireToMove01;  NPC_AI.bCorpse054 = bTempCorpse01; NPC_AI.iLoyalty054 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins054 = iTempMacGuffins01; NPC_AI.sAvailableWeapons054 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_055) { NPC_AI.DesireToMove055 = iTempDesireToMove01;  NPC_AI.bCorpse055 = bTempCorpse01; NPC_AI.iLoyalty055 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins055 = iTempMacGuffins01; NPC_AI.sAvailableWeapons055 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_056) { NPC_AI.DesireToMove056 = iTempDesireToMove01;  NPC_AI.bCorpse056 = bTempCorpse01; NPC_AI.iLoyalty056 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins056 = iTempMacGuffins01; NPC_AI.sAvailableWeapons056 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_057) { NPC_AI.DesireToMove057 = iTempDesireToMove01;  NPC_AI.bCorpse057 = bTempCorpse01; NPC_AI.iLoyalty057 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins057 = iTempMacGuffins01; NPC_AI.sAvailableWeapons057 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_058) { NPC_AI.DesireToMove058 = iTempDesireToMove01;  NPC_AI.bCorpse058 = bTempCorpse01; NPC_AI.iLoyalty058 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins058 = iTempMacGuffins01; NPC_AI.sAvailableWeapons058 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_059) { NPC_AI.DesireToMove059 = iTempDesireToMove01;  NPC_AI.bCorpse059 = bTempCorpse01; NPC_AI.iLoyalty059 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins059 = iTempMacGuffins01; NPC_AI.sAvailableWeapons059 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_060) { NPC_AI.DesireToMove060 = iTempDesireToMove01;  NPC_AI.bCorpse060 = bTempCorpse01; NPC_AI.iLoyalty060 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins060 = iTempMacGuffins01; NPC_AI.sAvailableWeapons060 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_061) { NPC_AI.DesireToMove061 = iTempDesireToMove01;  NPC_AI.bCorpse061 = bTempCorpse01; NPC_AI.iLoyalty061 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins061 = iTempMacGuffins01; NPC_AI.sAvailableWeapons061 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_062) { NPC_AI.DesireToMove062 = iTempDesireToMove01;  NPC_AI.bCorpse062 = bTempCorpse01; NPC_AI.iLoyalty062 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins062 = iTempMacGuffins01; NPC_AI.sAvailableWeapons062 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_063) { NPC_AI.DesireToMove063 = iTempDesireToMove01;  NPC_AI.bCorpse063 = bTempCorpse01; NPC_AI.iLoyalty063 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins063 = iTempMacGuffins01; NPC_AI.sAvailableWeapons063 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_064) { NPC_AI.DesireToMove064 = iTempDesireToMove01;  NPC_AI.bCorpse064 = bTempCorpse01; NPC_AI.iLoyalty054 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins064 = iTempMacGuffins01; NPC_AI.sAvailableWeapons064 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_065) { NPC_AI.DesireToMove065 = iTempDesireToMove01;  NPC_AI.bCorpse065 = bTempCorpse01; NPC_AI.iLoyalty065 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins065 = iTempMacGuffins01; NPC_AI.sAvailableWeapons065 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_066) { NPC_AI.DesireToMove066 = iTempDesireToMove01;  NPC_AI.bCorpse066 = bTempCorpse01; NPC_AI.iLoyalty066 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins066 = iTempMacGuffins01; NPC_AI.sAvailableWeapons066 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_067) { NPC_AI.DesireToMove067 = iTempDesireToMove01;  NPC_AI.bCorpse067 = bTempCorpse01; NPC_AI.iLoyalty067 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins067 = iTempMacGuffins01; NPC_AI.sAvailableWeapons067 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_068) { NPC_AI.DesireToMove068 = iTempDesireToMove01;  NPC_AI.bCorpse068 = bTempCorpse01; NPC_AI.iLoyalty068 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins068 = iTempMacGuffins01; NPC_AI.sAvailableWeapons068 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_069) { NPC_AI.DesireToMove069 = iTempDesireToMove01;  NPC_AI.bCorpse069 = bTempCorpse01; NPC_AI.iLoyalty069 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins069 = iTempMacGuffins01; NPC_AI.sAvailableWeapons069 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_070) { NPC_AI.DesireToMove070 = iTempDesireToMove01;  NPC_AI.bCorpse070 = bTempCorpse01; NPC_AI.iLoyalty070 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins070 = iTempMacGuffins01; NPC_AI.sAvailableWeapons070 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_071) { NPC_AI.DesireToMove071 = iTempDesireToMove01;  NPC_AI.bCorpse071 = bTempCorpse01; NPC_AI.iLoyalty071 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins071 = iTempMacGuffins01; NPC_AI.sAvailableWeapons071 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_072) { NPC_AI.DesireToMove072 = iTempDesireToMove01;  NPC_AI.bCorpse072 = bTempCorpse01; NPC_AI.iLoyalty072 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins072 = iTempMacGuffins01; NPC_AI.sAvailableWeapons072 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_073) { NPC_AI.DesireToMove073 = iTempDesireToMove01;  NPC_AI.bCorpse073 = bTempCorpse01; NPC_AI.iLoyalty073 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins073 = iTempMacGuffins01; NPC_AI.sAvailableWeapons073 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_074) { NPC_AI.DesireToMove074 = iTempDesireToMove01;  NPC_AI.bCorpse074 = bTempCorpse01; NPC_AI.iLoyalty074 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins074 = iTempMacGuffins01; NPC_AI.sAvailableWeapons074 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_075) { NPC_AI.DesireToMove075 = iTempDesireToMove01;  NPC_AI.bCorpse075 = bTempCorpse01; NPC_AI.iLoyalty075 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins075 = iTempMacGuffins01; NPC_AI.sAvailableWeapons075 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_076) { NPC_AI.DesireToMove076 = iTempDesireToMove01;  NPC_AI.bCorpse076 = bTempCorpse01; NPC_AI.iLoyalty076 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins076 = iTempMacGuffins01; NPC_AI.sAvailableWeapons076 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_077) { NPC_AI.DesireToMove077 = iTempDesireToMove01;  NPC_AI.bCorpse077 = bTempCorpse01; NPC_AI.iLoyalty077 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins077 = iTempMacGuffins01; NPC_AI.sAvailableWeapons077 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_078) { NPC_AI.DesireToMove078 = iTempDesireToMove01;  NPC_AI.bCorpse078 = bTempCorpse01; NPC_AI.iLoyalty078 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins078 = iTempMacGuffins01; NPC_AI.sAvailableWeapons078 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_079) { NPC_AI.DesireToMove079 = iTempDesireToMove01;  NPC_AI.bCorpse079 = bTempCorpse01; NPC_AI.iLoyalty079 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins079 = iTempMacGuffins01; NPC_AI.sAvailableWeapons079 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_080) { NPC_AI.DesireToMove080 = iTempDesireToMove01;  NPC_AI.bCorpse080 = bTempCorpse01; NPC_AI.iLoyalty080 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins080 = iTempMacGuffins01; NPC_AI.sAvailableWeapons080 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_081) { NPC_AI.DesireToMove081 = iTempDesireToMove01;  NPC_AI.bCorpse081 = bTempCorpse01; NPC_AI.iLoyalty081 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins081 = iTempMacGuffins01; NPC_AI.sAvailableWeapons081 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_082) { NPC_AI.DesireToMove082 = iTempDesireToMove01;  NPC_AI.bCorpse082 = bTempCorpse01; NPC_AI.iLoyalty082 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins082 = iTempMacGuffins01; NPC_AI.sAvailableWeapons082 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_083) { NPC_AI.DesireToMove083 = iTempDesireToMove01;  NPC_AI.bCorpse083 = bTempCorpse01; NPC_AI.iLoyalty083 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins083 = iTempMacGuffins01; NPC_AI.sAvailableWeapons083 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_084) { NPC_AI.DesireToMove084 = iTempDesireToMove01;  NPC_AI.bCorpse084 = bTempCorpse01; NPC_AI.iLoyalty084 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins084 = iTempMacGuffins01; NPC_AI.sAvailableWeapons084 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_085) { NPC_AI.DesireToMove085 = iTempDesireToMove01;  NPC_AI.bCorpse085 = bTempCorpse01; NPC_AI.iLoyalty085 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins085 = iTempMacGuffins01; NPC_AI.sAvailableWeapons085 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_086) { NPC_AI.DesireToMove086 = iTempDesireToMove01;  NPC_AI.bCorpse086 = bTempCorpse01; NPC_AI.iLoyalty086 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins086 = iTempMacGuffins01; NPC_AI.sAvailableWeapons086 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_087) { NPC_AI.DesireToMove087 = iTempDesireToMove01;  NPC_AI.bCorpse087 = bTempCorpse01; NPC_AI.iLoyalty087 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins087 = iTempMacGuffins01; NPC_AI.sAvailableWeapons087 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_088) { NPC_AI.DesireToMove088 = iTempDesireToMove01;  NPC_AI.bCorpse088 = bTempCorpse01; NPC_AI.iLoyalty088 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins088 = iTempMacGuffins01; NPC_AI.sAvailableWeapons088 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_089) { NPC_AI.DesireToMove089 = iTempDesireToMove01;  NPC_AI.bCorpse089 = bTempCorpse01; NPC_AI.iLoyalty089 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins089 = iTempMacGuffins01; NPC_AI.sAvailableWeapons089 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_090) { NPC_AI.DesireToMove090 = iTempDesireToMove01;  NPC_AI.bCorpse090 = bTempCorpse01; NPC_AI.iLoyalty090 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins090 = iTempMacGuffins01; NPC_AI.sAvailableWeapons090 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_091) { NPC_AI.DesireToMove091 = iTempDesireToMove01;  NPC_AI.bCorpse091 = bTempCorpse01; NPC_AI.iLoyalty091 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins091 = iTempMacGuffins01; NPC_AI.sAvailableWeapons091 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_092) { NPC_AI.DesireToMove092 = iTempDesireToMove01;  NPC_AI.bCorpse092 = bTempCorpse01; NPC_AI.iLoyalty092 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins092 = iTempMacGuffins01; NPC_AI.sAvailableWeapons092 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_093) { NPC_AI.DesireToMove093 = iTempDesireToMove01;  NPC_AI.bCorpse093 = bTempCorpse01; NPC_AI.iLoyalty093 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins093 = iTempMacGuffins01; NPC_AI.sAvailableWeapons093 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_094) { NPC_AI.DesireToMove094 = iTempDesireToMove01;  NPC_AI.bCorpse094 = bTempCorpse01; NPC_AI.iLoyalty094 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins094 = iTempMacGuffins01; NPC_AI.sAvailableWeapons094 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_095) { NPC_AI.DesireToMove095 = iTempDesireToMove01;  NPC_AI.bCorpse095 = bTempCorpse01; NPC_AI.iLoyalty095 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins095 = iTempMacGuffins01; NPC_AI.sAvailableWeapons095 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_096) { NPC_AI.DesireToMove096 = iTempDesireToMove01;  NPC_AI.bCorpse096 = bTempCorpse01; NPC_AI.iLoyalty096 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins096 = iTempMacGuffins01; NPC_AI.sAvailableWeapons096 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_097) { NPC_AI.DesireToMove097 = iTempDesireToMove01;  NPC_AI.bCorpse097 = bTempCorpse01; NPC_AI.iLoyalty097 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins097 = iTempMacGuffins01; NPC_AI.sAvailableWeapons097 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_098) { NPC_AI.DesireToMove098 = iTempDesireToMove01;  NPC_AI.bCorpse098 = bTempCorpse01; NPC_AI.iLoyalty098 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins098 = iTempMacGuffins01; NPC_AI.sAvailableWeapons098 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_099) { NPC_AI.DesireToMove099 = iTempDesireToMove01;  NPC_AI.bCorpse099 = bTempCorpse01; NPC_AI.iLoyalty099 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins099 = iTempMacGuffins01; NPC_AI.sAvailableWeapons099 = sTempWeapons01; }
            if (Actor01 == NPC_AI.NPC_100) { NPC_AI.DesireToMove100 = iTempDesireToMove01;  NPC_AI.bCorpse100 = bTempCorpse01; NPC_AI.iLoyalty100 = iTempLoyalty01; NPC_AI.iAvailableMacGuffins100 = iTempMacGuffins01; NPC_AI.sAvailableWeapons100 = sTempWeapons01; }

            if (Actor02 == NPC_AI.NPC_001) { NPC_AI.DesireToMove001 = iTempDesireToMove02;  NPC_AI.bCorpse001 = bTempCorpse02; NPC_AI.iLoyalty001 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins001 = iTempMacGuffins02; NPC_AI.sAvailableWeapons001 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_002) { NPC_AI.DesireToMove002 = iTempDesireToMove02;  NPC_AI.bCorpse002 = bTempCorpse02; NPC_AI.iLoyalty002 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins002 = iTempMacGuffins02; NPC_AI.sAvailableWeapons002 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_003) { NPC_AI.DesireToMove003 = iTempDesireToMove02;  NPC_AI.bCorpse003 = bTempCorpse02; NPC_AI.iLoyalty003 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins003 = iTempMacGuffins02; NPC_AI.sAvailableWeapons003 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_004) { NPC_AI.DesireToMove004 = iTempDesireToMove02;  NPC_AI.bCorpse004 = bTempCorpse02; NPC_AI.iLoyalty004 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins004 = iTempMacGuffins02; NPC_AI.sAvailableWeapons004 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_005) { NPC_AI.DesireToMove005 = iTempDesireToMove02;  NPC_AI.bCorpse005 = bTempCorpse02; NPC_AI.iLoyalty005 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins005 = iTempMacGuffins02; NPC_AI.sAvailableWeapons005 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_006) { NPC_AI.DesireToMove006 = iTempDesireToMove02;  NPC_AI.bCorpse006 = bTempCorpse02; NPC_AI.iLoyalty006 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins006 = iTempMacGuffins02; NPC_AI.sAvailableWeapons006 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_007) { NPC_AI.DesireToMove007 = iTempDesireToMove02;  NPC_AI.bCorpse007 = bTempCorpse02; NPC_AI.iLoyalty007 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins007 = iTempMacGuffins02; NPC_AI.sAvailableWeapons007 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_008) { NPC_AI.DesireToMove008 = iTempDesireToMove02;  NPC_AI.bCorpse008 = bTempCorpse02; NPC_AI.iLoyalty008 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins008 = iTempMacGuffins02; NPC_AI.sAvailableWeapons008 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_009) { NPC_AI.DesireToMove009 = iTempDesireToMove02;  NPC_AI.bCorpse009 = bTempCorpse02; NPC_AI.iLoyalty009 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins009 = iTempMacGuffins02; NPC_AI.sAvailableWeapons009 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_010) { NPC_AI.DesireToMove010 = iTempDesireToMove02;  NPC_AI.bCorpse010 = bTempCorpse02; NPC_AI.iLoyalty010 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins010 = iTempMacGuffins02; NPC_AI.sAvailableWeapons010 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_011) { NPC_AI.DesireToMove011 = iTempDesireToMove02;  NPC_AI.bCorpse011 = bTempCorpse02; NPC_AI.iLoyalty011 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins011 = iTempMacGuffins02; NPC_AI.sAvailableWeapons011 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_012) { NPC_AI.DesireToMove012 = iTempDesireToMove02;  NPC_AI.bCorpse012 = bTempCorpse02; NPC_AI.iLoyalty012 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins012 = iTempMacGuffins02; NPC_AI.sAvailableWeapons012 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_013) { NPC_AI.DesireToMove013 = iTempDesireToMove02;  NPC_AI.bCorpse013 = bTempCorpse02; NPC_AI.iLoyalty013 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins013 = iTempMacGuffins02; NPC_AI.sAvailableWeapons013 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_014) { NPC_AI.DesireToMove014 = iTempDesireToMove02;  NPC_AI.bCorpse014 = bTempCorpse02; NPC_AI.iLoyalty014 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins014 = iTempMacGuffins02; NPC_AI.sAvailableWeapons014 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_015) { NPC_AI.DesireToMove015 = iTempDesireToMove02;  NPC_AI.bCorpse015 = bTempCorpse02; NPC_AI.iLoyalty015 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins015 = iTempMacGuffins02; NPC_AI.sAvailableWeapons015 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_016) { NPC_AI.DesireToMove016 = iTempDesireToMove02;  NPC_AI.bCorpse016 = bTempCorpse02; NPC_AI.iLoyalty016 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins016 = iTempMacGuffins02; NPC_AI.sAvailableWeapons016 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_017) { NPC_AI.DesireToMove017 = iTempDesireToMove02;  NPC_AI.bCorpse017 = bTempCorpse02; NPC_AI.iLoyalty017 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins017 = iTempMacGuffins02; NPC_AI.sAvailableWeapons017 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_018) { NPC_AI.DesireToMove018 = iTempDesireToMove02;  NPC_AI.bCorpse018 = bTempCorpse02; NPC_AI.iLoyalty018 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins018 = iTempMacGuffins02; NPC_AI.sAvailableWeapons018 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_019) { NPC_AI.DesireToMove019 = iTempDesireToMove02;  NPC_AI.bCorpse019 = bTempCorpse02; NPC_AI.iLoyalty019 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins019 = iTempMacGuffins02; NPC_AI.sAvailableWeapons019 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_020) { NPC_AI.DesireToMove020 = iTempDesireToMove02;  NPC_AI.bCorpse020 = bTempCorpse02; NPC_AI.iLoyalty020 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins020 = iTempMacGuffins02; NPC_AI.sAvailableWeapons020 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_021) { NPC_AI.DesireToMove021 = iTempDesireToMove02;  NPC_AI.bCorpse021 = bTempCorpse02; NPC_AI.iLoyalty021 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins021 = iTempMacGuffins02; NPC_AI.sAvailableWeapons021 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_022) { NPC_AI.DesireToMove022 = iTempDesireToMove02;  NPC_AI.bCorpse022 = bTempCorpse02; NPC_AI.iLoyalty022 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins022 = iTempMacGuffins02; NPC_AI.sAvailableWeapons022 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_023) { NPC_AI.DesireToMove023 = iTempDesireToMove02;  NPC_AI.bCorpse023 = bTempCorpse02; NPC_AI.iLoyalty023 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins023 = iTempMacGuffins02; NPC_AI.sAvailableWeapons023 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_024) { NPC_AI.DesireToMove024 = iTempDesireToMove02;  NPC_AI.bCorpse024 = bTempCorpse02; NPC_AI.iLoyalty024 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins024 = iTempMacGuffins02; NPC_AI.sAvailableWeapons024 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_025) { NPC_AI.DesireToMove025 = iTempDesireToMove02;  NPC_AI.bCorpse025 = bTempCorpse02; NPC_AI.iLoyalty025 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins025 = iTempMacGuffins02; NPC_AI.sAvailableWeapons025 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_026) { NPC_AI.DesireToMove026 = iTempDesireToMove02;  NPC_AI.bCorpse026 = bTempCorpse02; NPC_AI.iLoyalty026 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins026 = iTempMacGuffins02; NPC_AI.sAvailableWeapons026 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_027) { NPC_AI.DesireToMove027 = iTempDesireToMove02;  NPC_AI.bCorpse027 = bTempCorpse02; NPC_AI.iLoyalty027 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins027 = iTempMacGuffins02; NPC_AI.sAvailableWeapons027 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_028) { NPC_AI.DesireToMove028 = iTempDesireToMove02;  NPC_AI.bCorpse028 = bTempCorpse02; NPC_AI.iLoyalty028 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins028 = iTempMacGuffins02; NPC_AI.sAvailableWeapons028 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_029) { NPC_AI.DesireToMove029 = iTempDesireToMove02;  NPC_AI.bCorpse029 = bTempCorpse02; NPC_AI.iLoyalty029 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins029 = iTempMacGuffins02; NPC_AI.sAvailableWeapons029 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_030) { NPC_AI.DesireToMove030 = iTempDesireToMove02;  NPC_AI.bCorpse030 = bTempCorpse02; NPC_AI.iLoyalty030 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins030 = iTempMacGuffins02; NPC_AI.sAvailableWeapons030 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_031) { NPC_AI.DesireToMove031 = iTempDesireToMove02;  NPC_AI.bCorpse031 = bTempCorpse02; NPC_AI.iLoyalty031 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins031 = iTempMacGuffins02; NPC_AI.sAvailableWeapons031 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_032) { NPC_AI.DesireToMove032 = iTempDesireToMove02;  NPC_AI.bCorpse032 = bTempCorpse02; NPC_AI.iLoyalty032 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins032 = iTempMacGuffins02; NPC_AI.sAvailableWeapons032 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_033) { NPC_AI.DesireToMove033 = iTempDesireToMove02;  NPC_AI.bCorpse033 = bTempCorpse02; NPC_AI.iLoyalty033 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins033 = iTempMacGuffins02; NPC_AI.sAvailableWeapons033 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_034) { NPC_AI.DesireToMove034 = iTempDesireToMove02;  NPC_AI.bCorpse034 = bTempCorpse02; NPC_AI.iLoyalty034 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins034 = iTempMacGuffins02; NPC_AI.sAvailableWeapons034 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_035) { NPC_AI.DesireToMove035 = iTempDesireToMove02;  NPC_AI.bCorpse035 = bTempCorpse02; NPC_AI.iLoyalty035 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins035 = iTempMacGuffins02; NPC_AI.sAvailableWeapons035 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_036) { NPC_AI.DesireToMove036 = iTempDesireToMove02;  NPC_AI.bCorpse036 = bTempCorpse02; NPC_AI.iLoyalty036 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins036 = iTempMacGuffins02; NPC_AI.sAvailableWeapons036 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_037) { NPC_AI.DesireToMove037 = iTempDesireToMove02;  NPC_AI.bCorpse037 = bTempCorpse02; NPC_AI.iLoyalty037 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins037 = iTempMacGuffins02; NPC_AI.sAvailableWeapons037 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_038) { NPC_AI.DesireToMove038 = iTempDesireToMove02;  NPC_AI.bCorpse038 = bTempCorpse02; NPC_AI.iLoyalty038 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins038 = iTempMacGuffins02; NPC_AI.sAvailableWeapons038 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_039) { NPC_AI.DesireToMove039 = iTempDesireToMove02;  NPC_AI.bCorpse039 = bTempCorpse02; NPC_AI.iLoyalty039 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins039 = iTempMacGuffins02; NPC_AI.sAvailableWeapons039 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_040) { NPC_AI.DesireToMove040 = iTempDesireToMove02;  NPC_AI.bCorpse040 = bTempCorpse02; NPC_AI.iLoyalty040 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins040 = iTempMacGuffins02; NPC_AI.sAvailableWeapons040 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_041) { NPC_AI.DesireToMove041 = iTempDesireToMove02;  NPC_AI.bCorpse041 = bTempCorpse02; NPC_AI.iLoyalty041 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins041 = iTempMacGuffins02; NPC_AI.sAvailableWeapons041 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_042) { NPC_AI.DesireToMove042 = iTempDesireToMove02;  NPC_AI.bCorpse042 = bTempCorpse02; NPC_AI.iLoyalty042 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins042 = iTempMacGuffins02; NPC_AI.sAvailableWeapons042 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_043) { NPC_AI.DesireToMove043 = iTempDesireToMove02;  NPC_AI.bCorpse043 = bTempCorpse02; NPC_AI.iLoyalty043 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins043 = iTempMacGuffins02; NPC_AI.sAvailableWeapons043 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_044) { NPC_AI.DesireToMove044 = iTempDesireToMove02;  NPC_AI.bCorpse044 = bTempCorpse02; NPC_AI.iLoyalty044 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins044 = iTempMacGuffins02; NPC_AI.sAvailableWeapons044 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_045) { NPC_AI.DesireToMove045 = iTempDesireToMove02;  NPC_AI.bCorpse045 = bTempCorpse02; NPC_AI.iLoyalty045 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins045 = iTempMacGuffins02; NPC_AI.sAvailableWeapons045 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_046) { NPC_AI.DesireToMove046 = iTempDesireToMove02;  NPC_AI.bCorpse046 = bTempCorpse02; NPC_AI.iLoyalty046 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins046 = iTempMacGuffins02; NPC_AI.sAvailableWeapons046 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_047) { NPC_AI.DesireToMove047 = iTempDesireToMove02;  NPC_AI.bCorpse047 = bTempCorpse02; NPC_AI.iLoyalty047 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins047 = iTempMacGuffins02; NPC_AI.sAvailableWeapons047 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_048) { NPC_AI.DesireToMove048 = iTempDesireToMove02;  NPC_AI.bCorpse048 = bTempCorpse02; NPC_AI.iLoyalty048 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins048 = iTempMacGuffins02; NPC_AI.sAvailableWeapons048 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_049) { NPC_AI.DesireToMove049 = iTempDesireToMove02;  NPC_AI.bCorpse049 = bTempCorpse02; NPC_AI.iLoyalty049 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins049 = iTempMacGuffins02; NPC_AI.sAvailableWeapons049 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_050) { NPC_AI.DesireToMove050 = iTempDesireToMove02;  NPC_AI.bCorpse050 = bTempCorpse02; NPC_AI.iLoyalty050 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins050 = iTempMacGuffins02; NPC_AI.sAvailableWeapons050 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_051) { NPC_AI.DesireToMove051 = iTempDesireToMove02;  NPC_AI.bCorpse051 = bTempCorpse02; NPC_AI.iLoyalty051 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins051 = iTempMacGuffins02; NPC_AI.sAvailableWeapons051 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_052) { NPC_AI.DesireToMove052 = iTempDesireToMove02;  NPC_AI.bCorpse052 = bTempCorpse02; NPC_AI.iLoyalty052 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins052 = iTempMacGuffins02; NPC_AI.sAvailableWeapons052 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_053) { NPC_AI.DesireToMove053 = iTempDesireToMove02;  NPC_AI.bCorpse053 = bTempCorpse02; NPC_AI.iLoyalty053 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins053 = iTempMacGuffins02; NPC_AI.sAvailableWeapons053 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_054) { NPC_AI.DesireToMove054 = iTempDesireToMove02;  NPC_AI.bCorpse054 = bTempCorpse02; NPC_AI.iLoyalty054 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins054 = iTempMacGuffins02; NPC_AI.sAvailableWeapons054 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_055) { NPC_AI.DesireToMove055 = iTempDesireToMove02;  NPC_AI.bCorpse055 = bTempCorpse02; NPC_AI.iLoyalty055 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins055 = iTempMacGuffins02; NPC_AI.sAvailableWeapons055 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_056) { NPC_AI.DesireToMove056 = iTempDesireToMove02;  NPC_AI.bCorpse056 = bTempCorpse02; NPC_AI.iLoyalty056 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins056 = iTempMacGuffins02; NPC_AI.sAvailableWeapons056 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_057) { NPC_AI.DesireToMove057 = iTempDesireToMove02;  NPC_AI.bCorpse057 = bTempCorpse02; NPC_AI.iLoyalty057 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins057 = iTempMacGuffins02; NPC_AI.sAvailableWeapons057 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_058) { NPC_AI.DesireToMove058 = iTempDesireToMove02;  NPC_AI.bCorpse058 = bTempCorpse02; NPC_AI.iLoyalty058 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins058 = iTempMacGuffins02; NPC_AI.sAvailableWeapons058 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_059) { NPC_AI.DesireToMove059 = iTempDesireToMove02;  NPC_AI.bCorpse059 = bTempCorpse02; NPC_AI.iLoyalty059 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins059 = iTempMacGuffins02; NPC_AI.sAvailableWeapons059 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_060) { NPC_AI.DesireToMove060 = iTempDesireToMove02;  NPC_AI.bCorpse060 = bTempCorpse02; NPC_AI.iLoyalty060 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins060 = iTempMacGuffins02; NPC_AI.sAvailableWeapons060 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_061) { NPC_AI.DesireToMove061 = iTempDesireToMove02;  NPC_AI.bCorpse061 = bTempCorpse02; NPC_AI.iLoyalty061 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins061 = iTempMacGuffins02; NPC_AI.sAvailableWeapons061 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_062) { NPC_AI.DesireToMove062 = iTempDesireToMove02;  NPC_AI.bCorpse062 = bTempCorpse02; NPC_AI.iLoyalty062 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins062 = iTempMacGuffins02; NPC_AI.sAvailableWeapons062 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_063) { NPC_AI.DesireToMove063 = iTempDesireToMove02;  NPC_AI.bCorpse063 = bTempCorpse02; NPC_AI.iLoyalty063 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins063 = iTempMacGuffins02; NPC_AI.sAvailableWeapons063 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_064) { NPC_AI.DesireToMove064 = iTempDesireToMove02;  NPC_AI.bCorpse064 = bTempCorpse02; NPC_AI.iLoyalty054 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins064 = iTempMacGuffins02; NPC_AI.sAvailableWeapons064 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_065) { NPC_AI.DesireToMove065 = iTempDesireToMove02;  NPC_AI.bCorpse065 = bTempCorpse02; NPC_AI.iLoyalty065 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins065 = iTempMacGuffins02; NPC_AI.sAvailableWeapons065 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_066) { NPC_AI.DesireToMove066 = iTempDesireToMove02;  NPC_AI.bCorpse066 = bTempCorpse02; NPC_AI.iLoyalty066 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins066 = iTempMacGuffins02; NPC_AI.sAvailableWeapons066 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_067) { NPC_AI.DesireToMove067 = iTempDesireToMove02;  NPC_AI.bCorpse067 = bTempCorpse02; NPC_AI.iLoyalty067 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins067 = iTempMacGuffins02; NPC_AI.sAvailableWeapons067 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_068) { NPC_AI.DesireToMove068 = iTempDesireToMove02;  NPC_AI.bCorpse068 = bTempCorpse02; NPC_AI.iLoyalty068 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins068 = iTempMacGuffins02; NPC_AI.sAvailableWeapons068 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_069) { NPC_AI.DesireToMove069 = iTempDesireToMove02;  NPC_AI.bCorpse069 = bTempCorpse02; NPC_AI.iLoyalty069 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins069 = iTempMacGuffins02; NPC_AI.sAvailableWeapons069 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_070) { NPC_AI.DesireToMove070 = iTempDesireToMove02;  NPC_AI.bCorpse070 = bTempCorpse02; NPC_AI.iLoyalty070 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins070 = iTempMacGuffins02; NPC_AI.sAvailableWeapons070 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_071) { NPC_AI.DesireToMove071 = iTempDesireToMove02;  NPC_AI.bCorpse071 = bTempCorpse02; NPC_AI.iLoyalty071 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins071 = iTempMacGuffins02; NPC_AI.sAvailableWeapons071 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_072) { NPC_AI.DesireToMove072 = iTempDesireToMove02;  NPC_AI.bCorpse072 = bTempCorpse02; NPC_AI.iLoyalty072 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins072 = iTempMacGuffins02; NPC_AI.sAvailableWeapons072 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_073) { NPC_AI.DesireToMove073 = iTempDesireToMove02;  NPC_AI.bCorpse073 = bTempCorpse02; NPC_AI.iLoyalty073 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins073 = iTempMacGuffins02; NPC_AI.sAvailableWeapons073 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_074) { NPC_AI.DesireToMove074 = iTempDesireToMove02;  NPC_AI.bCorpse074 = bTempCorpse02; NPC_AI.iLoyalty074 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins074 = iTempMacGuffins02; NPC_AI.sAvailableWeapons074 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_075) { NPC_AI.DesireToMove075 = iTempDesireToMove02;  NPC_AI.bCorpse075 = bTempCorpse02; NPC_AI.iLoyalty075 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins075 = iTempMacGuffins02; NPC_AI.sAvailableWeapons075 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_076) { NPC_AI.DesireToMove076 = iTempDesireToMove02;  NPC_AI.bCorpse076 = bTempCorpse02; NPC_AI.iLoyalty076 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins076 = iTempMacGuffins02; NPC_AI.sAvailableWeapons076 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_077) { NPC_AI.DesireToMove077 = iTempDesireToMove02;  NPC_AI.bCorpse077 = bTempCorpse02; NPC_AI.iLoyalty077 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins077 = iTempMacGuffins02; NPC_AI.sAvailableWeapons077 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_078) { NPC_AI.DesireToMove078 = iTempDesireToMove02;  NPC_AI.bCorpse078 = bTempCorpse02; NPC_AI.iLoyalty078 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins078 = iTempMacGuffins02; NPC_AI.sAvailableWeapons078 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_079) { NPC_AI.DesireToMove079 = iTempDesireToMove02;  NPC_AI.bCorpse079 = bTempCorpse02; NPC_AI.iLoyalty079 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins079 = iTempMacGuffins02; NPC_AI.sAvailableWeapons079 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_080) { NPC_AI.DesireToMove080 = iTempDesireToMove02;  NPC_AI.bCorpse080 = bTempCorpse02; NPC_AI.iLoyalty080 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins080 = iTempMacGuffins02; NPC_AI.sAvailableWeapons080 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_081) { NPC_AI.DesireToMove081 = iTempDesireToMove02;  NPC_AI.bCorpse081 = bTempCorpse02; NPC_AI.iLoyalty081 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins081 = iTempMacGuffins02; NPC_AI.sAvailableWeapons081 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_082) { NPC_AI.DesireToMove082 = iTempDesireToMove02;  NPC_AI.bCorpse082 = bTempCorpse02; NPC_AI.iLoyalty082 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins082 = iTempMacGuffins02; NPC_AI.sAvailableWeapons082 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_083) { NPC_AI.DesireToMove083 = iTempDesireToMove02;  NPC_AI.bCorpse083 = bTempCorpse02; NPC_AI.iLoyalty083 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins083 = iTempMacGuffins02; NPC_AI.sAvailableWeapons083 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_084) { NPC_AI.DesireToMove084 = iTempDesireToMove02;  NPC_AI.bCorpse084 = bTempCorpse02; NPC_AI.iLoyalty084 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins084 = iTempMacGuffins02; NPC_AI.sAvailableWeapons084 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_085) { NPC_AI.DesireToMove085 = iTempDesireToMove02;  NPC_AI.bCorpse085 = bTempCorpse02; NPC_AI.iLoyalty085 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins085 = iTempMacGuffins02; NPC_AI.sAvailableWeapons085 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_086) { NPC_AI.DesireToMove086 = iTempDesireToMove02;  NPC_AI.bCorpse086 = bTempCorpse02; NPC_AI.iLoyalty086 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins086 = iTempMacGuffins02; NPC_AI.sAvailableWeapons086 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_087) { NPC_AI.DesireToMove087 = iTempDesireToMove02;  NPC_AI.bCorpse087 = bTempCorpse02; NPC_AI.iLoyalty087 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins087 = iTempMacGuffins02; NPC_AI.sAvailableWeapons087 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_088) { NPC_AI.DesireToMove088 = iTempDesireToMove02;  NPC_AI.bCorpse088 = bTempCorpse02; NPC_AI.iLoyalty088 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins088 = iTempMacGuffins02; NPC_AI.sAvailableWeapons088 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_089) { NPC_AI.DesireToMove089 = iTempDesireToMove02;  NPC_AI.bCorpse089 = bTempCorpse02; NPC_AI.iLoyalty089 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins089 = iTempMacGuffins02; NPC_AI.sAvailableWeapons089 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_090) { NPC_AI.DesireToMove090 = iTempDesireToMove02;  NPC_AI.bCorpse090 = bTempCorpse02; NPC_AI.iLoyalty090 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins090 = iTempMacGuffins02; NPC_AI.sAvailableWeapons090 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_091) { NPC_AI.DesireToMove091 = iTempDesireToMove02;  NPC_AI.bCorpse091 = bTempCorpse02; NPC_AI.iLoyalty091 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins091 = iTempMacGuffins02; NPC_AI.sAvailableWeapons091 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_092) { NPC_AI.DesireToMove092 = iTempDesireToMove02;  NPC_AI.bCorpse092 = bTempCorpse02; NPC_AI.iLoyalty092 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins092 = iTempMacGuffins02; NPC_AI.sAvailableWeapons092 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_093) { NPC_AI.DesireToMove093 = iTempDesireToMove02;  NPC_AI.bCorpse093 = bTempCorpse02; NPC_AI.iLoyalty093 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins093 = iTempMacGuffins02; NPC_AI.sAvailableWeapons093 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_094) { NPC_AI.DesireToMove094 = iTempDesireToMove02;  NPC_AI.bCorpse094 = bTempCorpse02; NPC_AI.iLoyalty094 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins094 = iTempMacGuffins02; NPC_AI.sAvailableWeapons094 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_095) { NPC_AI.DesireToMove095 = iTempDesireToMove02;  NPC_AI.bCorpse095 = bTempCorpse02; NPC_AI.iLoyalty095 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins095 = iTempMacGuffins02; NPC_AI.sAvailableWeapons095 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_096) { NPC_AI.DesireToMove096 = iTempDesireToMove02;  NPC_AI.bCorpse096 = bTempCorpse02; NPC_AI.iLoyalty096 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins096 = iTempMacGuffins02; NPC_AI.sAvailableWeapons096 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_097) { NPC_AI.DesireToMove097 = iTempDesireToMove02;  NPC_AI.bCorpse097 = bTempCorpse02; NPC_AI.iLoyalty097 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins097 = iTempMacGuffins02; NPC_AI.sAvailableWeapons097 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_098) { NPC_AI.DesireToMove098 = iTempDesireToMove02;  NPC_AI.bCorpse098 = bTempCorpse02; NPC_AI.iLoyalty098 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins098 = iTempMacGuffins02; NPC_AI.sAvailableWeapons098 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_099) { NPC_AI.DesireToMove099 = iTempDesireToMove02;  NPC_AI.bCorpse099 = bTempCorpse02; NPC_AI.iLoyalty099 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins099 = iTempMacGuffins02; NPC_AI.sAvailableWeapons099 = sTempWeapons02; }
            if (Actor02 == NPC_AI.NPC_100) { NPC_AI.DesireToMove100 = iTempDesireToMove02;  NPC_AI.bCorpse100 = bTempCorpse02; NPC_AI.iLoyalty100 = iTempLoyalty02; NPC_AI.iAvailableMacGuffins100 = iTempMacGuffins02; NPC_AI.sAvailableWeapons100 = sTempWeapons02; }

            if (Actor03 == NPC_AI.NPC_001) { NPC_AI.DesireToMove001 = iTempDesireToMove03;  NPC_AI.bCorpse001 = bTempCorpse03; NPC_AI.iLoyalty001 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins001 = iTempMacGuffins03; NPC_AI.sAvailableWeapons001 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_002) { NPC_AI.DesireToMove002 = iTempDesireToMove03;  NPC_AI.bCorpse002 = bTempCorpse03; NPC_AI.iLoyalty002 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins002 = iTempMacGuffins03; NPC_AI.sAvailableWeapons002 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_003) { NPC_AI.DesireToMove003 = iTempDesireToMove03;  NPC_AI.bCorpse003 = bTempCorpse03; NPC_AI.iLoyalty003 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins003 = iTempMacGuffins03; NPC_AI.sAvailableWeapons003 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_004) { NPC_AI.DesireToMove004 = iTempDesireToMove03;  NPC_AI.bCorpse004 = bTempCorpse03; NPC_AI.iLoyalty004 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins004 = iTempMacGuffins03; NPC_AI.sAvailableWeapons004 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_005) { NPC_AI.DesireToMove005 = iTempDesireToMove03;  NPC_AI.bCorpse005 = bTempCorpse03; NPC_AI.iLoyalty005 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins005 = iTempMacGuffins03; NPC_AI.sAvailableWeapons005 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_006) { NPC_AI.DesireToMove006 = iTempDesireToMove03;  NPC_AI.bCorpse006 = bTempCorpse03; NPC_AI.iLoyalty006 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins006 = iTempMacGuffins03; NPC_AI.sAvailableWeapons006 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_007) { NPC_AI.DesireToMove007 = iTempDesireToMove03;  NPC_AI.bCorpse007 = bTempCorpse03; NPC_AI.iLoyalty007 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins007 = iTempMacGuffins03; NPC_AI.sAvailableWeapons007 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_008) { NPC_AI.DesireToMove008 = iTempDesireToMove03;  NPC_AI.bCorpse008 = bTempCorpse03; NPC_AI.iLoyalty008 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins008 = iTempMacGuffins03; NPC_AI.sAvailableWeapons008 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_009) { NPC_AI.DesireToMove009 = iTempDesireToMove03;  NPC_AI.bCorpse009 = bTempCorpse03; NPC_AI.iLoyalty009 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins009 = iTempMacGuffins03; NPC_AI.sAvailableWeapons009 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_010) { NPC_AI.DesireToMove010 = iTempDesireToMove03;  NPC_AI.bCorpse010 = bTempCorpse03; NPC_AI.iLoyalty010 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins010 = iTempMacGuffins03; NPC_AI.sAvailableWeapons010 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_011) { NPC_AI.DesireToMove011 = iTempDesireToMove03;  NPC_AI.bCorpse011 = bTempCorpse03; NPC_AI.iLoyalty011 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins011 = iTempMacGuffins03; NPC_AI.sAvailableWeapons011 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_012) { NPC_AI.DesireToMove012 = iTempDesireToMove03;  NPC_AI.bCorpse012 = bTempCorpse03; NPC_AI.iLoyalty012 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins012 = iTempMacGuffins03; NPC_AI.sAvailableWeapons012 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_013) { NPC_AI.DesireToMove013 = iTempDesireToMove03;  NPC_AI.bCorpse013 = bTempCorpse03; NPC_AI.iLoyalty013 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins013 = iTempMacGuffins03; NPC_AI.sAvailableWeapons013 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_014) { NPC_AI.DesireToMove014 = iTempDesireToMove03;  NPC_AI.bCorpse014 = bTempCorpse03; NPC_AI.iLoyalty014 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins014 = iTempMacGuffins03; NPC_AI.sAvailableWeapons014 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_015) { NPC_AI.DesireToMove015 = iTempDesireToMove03;  NPC_AI.bCorpse015 = bTempCorpse03; NPC_AI.iLoyalty015 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins015 = iTempMacGuffins03; NPC_AI.sAvailableWeapons015 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_016) { NPC_AI.DesireToMove016 = iTempDesireToMove03;  NPC_AI.bCorpse016 = bTempCorpse03; NPC_AI.iLoyalty016 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins016 = iTempMacGuffins03; NPC_AI.sAvailableWeapons016 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_017) { NPC_AI.DesireToMove017 = iTempDesireToMove03;  NPC_AI.bCorpse017 = bTempCorpse03; NPC_AI.iLoyalty017 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins017 = iTempMacGuffins03; NPC_AI.sAvailableWeapons017 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_018) { NPC_AI.DesireToMove018 = iTempDesireToMove03;  NPC_AI.bCorpse018 = bTempCorpse03; NPC_AI.iLoyalty018 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins018 = iTempMacGuffins03; NPC_AI.sAvailableWeapons018 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_019) { NPC_AI.DesireToMove019 = iTempDesireToMove03;  NPC_AI.bCorpse019 = bTempCorpse03; NPC_AI.iLoyalty019 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins019 = iTempMacGuffins03; NPC_AI.sAvailableWeapons019 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_020) { NPC_AI.DesireToMove020 = iTempDesireToMove03;  NPC_AI.bCorpse020 = bTempCorpse03; NPC_AI.iLoyalty020 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins020 = iTempMacGuffins03; NPC_AI.sAvailableWeapons020 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_021) { NPC_AI.DesireToMove021 = iTempDesireToMove03;  NPC_AI.bCorpse021 = bTempCorpse03; NPC_AI.iLoyalty021 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins021 = iTempMacGuffins03; NPC_AI.sAvailableWeapons021 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_022) { NPC_AI.DesireToMove022 = iTempDesireToMove03;  NPC_AI.bCorpse022 = bTempCorpse03; NPC_AI.iLoyalty022 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins022 = iTempMacGuffins03; NPC_AI.sAvailableWeapons022 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_023) { NPC_AI.DesireToMove023 = iTempDesireToMove03;  NPC_AI.bCorpse023 = bTempCorpse03; NPC_AI.iLoyalty023 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins023 = iTempMacGuffins03; NPC_AI.sAvailableWeapons023 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_024) { NPC_AI.DesireToMove024 = iTempDesireToMove03;  NPC_AI.bCorpse024 = bTempCorpse03; NPC_AI.iLoyalty024 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins024 = iTempMacGuffins03; NPC_AI.sAvailableWeapons024 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_025) { NPC_AI.DesireToMove025 = iTempDesireToMove03;  NPC_AI.bCorpse025 = bTempCorpse03; NPC_AI.iLoyalty025 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins025 = iTempMacGuffins03; NPC_AI.sAvailableWeapons025 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_026) { NPC_AI.DesireToMove026 = iTempDesireToMove03;  NPC_AI.bCorpse026 = bTempCorpse03; NPC_AI.iLoyalty026 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins026 = iTempMacGuffins03; NPC_AI.sAvailableWeapons026 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_027) { NPC_AI.DesireToMove027 = iTempDesireToMove03;  NPC_AI.bCorpse027 = bTempCorpse03; NPC_AI.iLoyalty027 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins027 = iTempMacGuffins03; NPC_AI.sAvailableWeapons027 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_028) { NPC_AI.DesireToMove028 = iTempDesireToMove03;  NPC_AI.bCorpse028 = bTempCorpse03; NPC_AI.iLoyalty028 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins028 = iTempMacGuffins03; NPC_AI.sAvailableWeapons028 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_029) { NPC_AI.DesireToMove029 = iTempDesireToMove03;  NPC_AI.bCorpse029 = bTempCorpse03; NPC_AI.iLoyalty029 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins029 = iTempMacGuffins03; NPC_AI.sAvailableWeapons029 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_030) { NPC_AI.DesireToMove030 = iTempDesireToMove03;  NPC_AI.bCorpse030 = bTempCorpse03; NPC_AI.iLoyalty030 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins030 = iTempMacGuffins03; NPC_AI.sAvailableWeapons030 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_031) { NPC_AI.DesireToMove031 = iTempDesireToMove03;  NPC_AI.bCorpse031 = bTempCorpse03; NPC_AI.iLoyalty031 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins031 = iTempMacGuffins03; NPC_AI.sAvailableWeapons031 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_032) { NPC_AI.DesireToMove032 = iTempDesireToMove03;  NPC_AI.bCorpse032 = bTempCorpse03; NPC_AI.iLoyalty032 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins032 = iTempMacGuffins03; NPC_AI.sAvailableWeapons032 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_033) { NPC_AI.DesireToMove033 = iTempDesireToMove03;  NPC_AI.bCorpse033 = bTempCorpse03; NPC_AI.iLoyalty033 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins033 = iTempMacGuffins03; NPC_AI.sAvailableWeapons033 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_034) { NPC_AI.DesireToMove034 = iTempDesireToMove03;  NPC_AI.bCorpse034 = bTempCorpse03; NPC_AI.iLoyalty034 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins034 = iTempMacGuffins03; NPC_AI.sAvailableWeapons034 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_035) { NPC_AI.DesireToMove035 = iTempDesireToMove03;  NPC_AI.bCorpse035 = bTempCorpse03; NPC_AI.iLoyalty035 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins035 = iTempMacGuffins03; NPC_AI.sAvailableWeapons035 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_036) { NPC_AI.DesireToMove036 = iTempDesireToMove03;  NPC_AI.bCorpse036 = bTempCorpse03; NPC_AI.iLoyalty036 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins036 = iTempMacGuffins03; NPC_AI.sAvailableWeapons036 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_037) { NPC_AI.DesireToMove037 = iTempDesireToMove03;  NPC_AI.bCorpse037 = bTempCorpse03; NPC_AI.iLoyalty037 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins037 = iTempMacGuffins03; NPC_AI.sAvailableWeapons037 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_038) { NPC_AI.DesireToMove038 = iTempDesireToMove03;  NPC_AI.bCorpse038 = bTempCorpse03; NPC_AI.iLoyalty038 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins038 = iTempMacGuffins03; NPC_AI.sAvailableWeapons038 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_039) { NPC_AI.DesireToMove039 = iTempDesireToMove03;  NPC_AI.bCorpse039 = bTempCorpse03; NPC_AI.iLoyalty039 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins039 = iTempMacGuffins03; NPC_AI.sAvailableWeapons039 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_040) { NPC_AI.DesireToMove040 = iTempDesireToMove03;  NPC_AI.bCorpse040 = bTempCorpse03; NPC_AI.iLoyalty040 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins040 = iTempMacGuffins03; NPC_AI.sAvailableWeapons040 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_041) { NPC_AI.DesireToMove041 = iTempDesireToMove03;  NPC_AI.bCorpse041 = bTempCorpse03; NPC_AI.iLoyalty041 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins041 = iTempMacGuffins03; NPC_AI.sAvailableWeapons041 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_042) { NPC_AI.DesireToMove042 = iTempDesireToMove03;  NPC_AI.bCorpse042 = bTempCorpse03; NPC_AI.iLoyalty042 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins042 = iTempMacGuffins03; NPC_AI.sAvailableWeapons042 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_043) { NPC_AI.DesireToMove043 = iTempDesireToMove03;  NPC_AI.bCorpse043 = bTempCorpse03; NPC_AI.iLoyalty043 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins043 = iTempMacGuffins03; NPC_AI.sAvailableWeapons043 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_044) { NPC_AI.DesireToMove044 = iTempDesireToMove03;  NPC_AI.bCorpse044 = bTempCorpse03; NPC_AI.iLoyalty044 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins044 = iTempMacGuffins03; NPC_AI.sAvailableWeapons044 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_045) { NPC_AI.DesireToMove045 = iTempDesireToMove03;  NPC_AI.bCorpse045 = bTempCorpse03; NPC_AI.iLoyalty045 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins045 = iTempMacGuffins03; NPC_AI.sAvailableWeapons045 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_046) { NPC_AI.DesireToMove046 = iTempDesireToMove03;  NPC_AI.bCorpse046 = bTempCorpse03; NPC_AI.iLoyalty046 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins046 = iTempMacGuffins03; NPC_AI.sAvailableWeapons046 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_047) { NPC_AI.DesireToMove047 = iTempDesireToMove03;  NPC_AI.bCorpse047 = bTempCorpse03; NPC_AI.iLoyalty047 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins047 = iTempMacGuffins03; NPC_AI.sAvailableWeapons047 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_048) { NPC_AI.DesireToMove048 = iTempDesireToMove03;  NPC_AI.bCorpse048 = bTempCorpse03; NPC_AI.iLoyalty048 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins048 = iTempMacGuffins03; NPC_AI.sAvailableWeapons048 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_049) { NPC_AI.DesireToMove049 = iTempDesireToMove03;  NPC_AI.bCorpse049 = bTempCorpse03; NPC_AI.iLoyalty049 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins049 = iTempMacGuffins03; NPC_AI.sAvailableWeapons049 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_050) { NPC_AI.DesireToMove050 = iTempDesireToMove03;  NPC_AI.bCorpse050 = bTempCorpse03; NPC_AI.iLoyalty050 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins050 = iTempMacGuffins03; NPC_AI.sAvailableWeapons050 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_051) { NPC_AI.DesireToMove051 = iTempDesireToMove03;  NPC_AI.bCorpse051 = bTempCorpse03; NPC_AI.iLoyalty051 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins051 = iTempMacGuffins03; NPC_AI.sAvailableWeapons051 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_052) { NPC_AI.DesireToMove052 = iTempDesireToMove03;  NPC_AI.bCorpse052 = bTempCorpse03; NPC_AI.iLoyalty052 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins052 = iTempMacGuffins03; NPC_AI.sAvailableWeapons052 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_053) { NPC_AI.DesireToMove053 = iTempDesireToMove03;  NPC_AI.bCorpse053 = bTempCorpse03; NPC_AI.iLoyalty053 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins053 = iTempMacGuffins03; NPC_AI.sAvailableWeapons053 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_054) { NPC_AI.DesireToMove054 = iTempDesireToMove03;  NPC_AI.bCorpse054 = bTempCorpse03; NPC_AI.iLoyalty054 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins054 = iTempMacGuffins03; NPC_AI.sAvailableWeapons054 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_055) { NPC_AI.DesireToMove055 = iTempDesireToMove03;  NPC_AI.bCorpse055 = bTempCorpse03; NPC_AI.iLoyalty055 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins055 = iTempMacGuffins03; NPC_AI.sAvailableWeapons055 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_056) { NPC_AI.DesireToMove056 = iTempDesireToMove03;  NPC_AI.bCorpse056 = bTempCorpse03; NPC_AI.iLoyalty056 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins056 = iTempMacGuffins03; NPC_AI.sAvailableWeapons056 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_057) { NPC_AI.DesireToMove057 = iTempDesireToMove03;  NPC_AI.bCorpse057 = bTempCorpse03; NPC_AI.iLoyalty057 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins057 = iTempMacGuffins03; NPC_AI.sAvailableWeapons057 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_058) { NPC_AI.DesireToMove058 = iTempDesireToMove03;  NPC_AI.bCorpse058 = bTempCorpse03; NPC_AI.iLoyalty058 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins058 = iTempMacGuffins03; NPC_AI.sAvailableWeapons058 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_059) { NPC_AI.DesireToMove059 = iTempDesireToMove03;  NPC_AI.bCorpse059 = bTempCorpse03; NPC_AI.iLoyalty059 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins059 = iTempMacGuffins03; NPC_AI.sAvailableWeapons059 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_060) { NPC_AI.DesireToMove060 = iTempDesireToMove03;  NPC_AI.bCorpse060 = bTempCorpse03; NPC_AI.iLoyalty060 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins060 = iTempMacGuffins03; NPC_AI.sAvailableWeapons060 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_061) { NPC_AI.DesireToMove061 = iTempDesireToMove03;  NPC_AI.bCorpse061 = bTempCorpse03; NPC_AI.iLoyalty061 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins061 = iTempMacGuffins03; NPC_AI.sAvailableWeapons061 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_062) { NPC_AI.DesireToMove062 = iTempDesireToMove03;  NPC_AI.bCorpse062 = bTempCorpse03; NPC_AI.iLoyalty062 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins062 = iTempMacGuffins03; NPC_AI.sAvailableWeapons062 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_063) { NPC_AI.DesireToMove063 = iTempDesireToMove03;  NPC_AI.bCorpse063 = bTempCorpse03; NPC_AI.iLoyalty063 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins063 = iTempMacGuffins03; NPC_AI.sAvailableWeapons063 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_064) { NPC_AI.DesireToMove064 = iTempDesireToMove03;  NPC_AI.bCorpse064 = bTempCorpse03; NPC_AI.iLoyalty054 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins064 = iTempMacGuffins03; NPC_AI.sAvailableWeapons064 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_065) { NPC_AI.DesireToMove065 = iTempDesireToMove03;  NPC_AI.bCorpse065 = bTempCorpse03; NPC_AI.iLoyalty065 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins065 = iTempMacGuffins03; NPC_AI.sAvailableWeapons065 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_066) { NPC_AI.DesireToMove066 = iTempDesireToMove03;  NPC_AI.bCorpse066 = bTempCorpse03; NPC_AI.iLoyalty066 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins066 = iTempMacGuffins03; NPC_AI.sAvailableWeapons066 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_067) { NPC_AI.DesireToMove067 = iTempDesireToMove03;  NPC_AI.bCorpse067 = bTempCorpse03; NPC_AI.iLoyalty067 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins067 = iTempMacGuffins03; NPC_AI.sAvailableWeapons067 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_068) { NPC_AI.DesireToMove068 = iTempDesireToMove03;  NPC_AI.bCorpse068 = bTempCorpse03; NPC_AI.iLoyalty068 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins068 = iTempMacGuffins03; NPC_AI.sAvailableWeapons068 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_069) { NPC_AI.DesireToMove069 = iTempDesireToMove03;  NPC_AI.bCorpse069 = bTempCorpse03; NPC_AI.iLoyalty069 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins069 = iTempMacGuffins03; NPC_AI.sAvailableWeapons069 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_070) { NPC_AI.DesireToMove070 = iTempDesireToMove03;  NPC_AI.bCorpse070 = bTempCorpse03; NPC_AI.iLoyalty070 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins070 = iTempMacGuffins03; NPC_AI.sAvailableWeapons070 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_071) { NPC_AI.DesireToMove071 = iTempDesireToMove03;  NPC_AI.bCorpse071 = bTempCorpse03; NPC_AI.iLoyalty071 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins071 = iTempMacGuffins03; NPC_AI.sAvailableWeapons071 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_072) { NPC_AI.DesireToMove072 = iTempDesireToMove03;  NPC_AI.bCorpse072 = bTempCorpse03; NPC_AI.iLoyalty072 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins072 = iTempMacGuffins03; NPC_AI.sAvailableWeapons072 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_073) { NPC_AI.DesireToMove073 = iTempDesireToMove03;  NPC_AI.bCorpse073 = bTempCorpse03; NPC_AI.iLoyalty073 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins073 = iTempMacGuffins03; NPC_AI.sAvailableWeapons073 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_074) { NPC_AI.DesireToMove074 = iTempDesireToMove03;  NPC_AI.bCorpse074 = bTempCorpse03; NPC_AI.iLoyalty074 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins074 = iTempMacGuffins03; NPC_AI.sAvailableWeapons074 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_075) { NPC_AI.DesireToMove075 = iTempDesireToMove03;  NPC_AI.bCorpse075 = bTempCorpse03; NPC_AI.iLoyalty075 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins075 = iTempMacGuffins03; NPC_AI.sAvailableWeapons075 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_076) { NPC_AI.DesireToMove076 = iTempDesireToMove03;  NPC_AI.bCorpse076 = bTempCorpse03; NPC_AI.iLoyalty076 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins076 = iTempMacGuffins03; NPC_AI.sAvailableWeapons076 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_077) { NPC_AI.DesireToMove077 = iTempDesireToMove03;  NPC_AI.bCorpse077 = bTempCorpse03; NPC_AI.iLoyalty077 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins077 = iTempMacGuffins03; NPC_AI.sAvailableWeapons077 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_078) { NPC_AI.DesireToMove078 = iTempDesireToMove03;  NPC_AI.bCorpse078 = bTempCorpse03; NPC_AI.iLoyalty078 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins078 = iTempMacGuffins03; NPC_AI.sAvailableWeapons078 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_079) { NPC_AI.DesireToMove079 = iTempDesireToMove03;  NPC_AI.bCorpse079 = bTempCorpse03; NPC_AI.iLoyalty079 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins079 = iTempMacGuffins03; NPC_AI.sAvailableWeapons079 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_080) { NPC_AI.DesireToMove080 = iTempDesireToMove03;  NPC_AI.bCorpse080 = bTempCorpse03; NPC_AI.iLoyalty080 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins080 = iTempMacGuffins03; NPC_AI.sAvailableWeapons080 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_081) { NPC_AI.DesireToMove081 = iTempDesireToMove03;  NPC_AI.bCorpse081 = bTempCorpse03; NPC_AI.iLoyalty081 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins081 = iTempMacGuffins03; NPC_AI.sAvailableWeapons081 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_082) { NPC_AI.DesireToMove082 = iTempDesireToMove03;  NPC_AI.bCorpse082 = bTempCorpse03; NPC_AI.iLoyalty082 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins082 = iTempMacGuffins03; NPC_AI.sAvailableWeapons082 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_083) { NPC_AI.DesireToMove083 = iTempDesireToMove03;  NPC_AI.bCorpse083 = bTempCorpse03; NPC_AI.iLoyalty083 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins083 = iTempMacGuffins03; NPC_AI.sAvailableWeapons083 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_084) { NPC_AI.DesireToMove084 = iTempDesireToMove03;  NPC_AI.bCorpse084 = bTempCorpse03; NPC_AI.iLoyalty084 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins084 = iTempMacGuffins03; NPC_AI.sAvailableWeapons084 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_085) { NPC_AI.DesireToMove085 = iTempDesireToMove03;  NPC_AI.bCorpse085 = bTempCorpse03; NPC_AI.iLoyalty085 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins085 = iTempMacGuffins03; NPC_AI.sAvailableWeapons085 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_086) { NPC_AI.DesireToMove086 = iTempDesireToMove03;  NPC_AI.bCorpse086 = bTempCorpse03; NPC_AI.iLoyalty086 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins086 = iTempMacGuffins03; NPC_AI.sAvailableWeapons086 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_087) { NPC_AI.DesireToMove087 = iTempDesireToMove03;  NPC_AI.bCorpse087 = bTempCorpse03; NPC_AI.iLoyalty087 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins087 = iTempMacGuffins03; NPC_AI.sAvailableWeapons087 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_088) { NPC_AI.DesireToMove088 = iTempDesireToMove03;  NPC_AI.bCorpse088 = bTempCorpse03; NPC_AI.iLoyalty088 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins088 = iTempMacGuffins03; NPC_AI.sAvailableWeapons088 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_089) { NPC_AI.DesireToMove089 = iTempDesireToMove03;  NPC_AI.bCorpse089 = bTempCorpse03; NPC_AI.iLoyalty089 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins089 = iTempMacGuffins03; NPC_AI.sAvailableWeapons089 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_090) { NPC_AI.DesireToMove090 = iTempDesireToMove03;  NPC_AI.bCorpse090 = bTempCorpse03; NPC_AI.iLoyalty090 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins090 = iTempMacGuffins03; NPC_AI.sAvailableWeapons090 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_091) { NPC_AI.DesireToMove091 = iTempDesireToMove03;  NPC_AI.bCorpse091 = bTempCorpse03; NPC_AI.iLoyalty091 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins091 = iTempMacGuffins03; NPC_AI.sAvailableWeapons091 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_092) { NPC_AI.DesireToMove092 = iTempDesireToMove03;  NPC_AI.bCorpse092 = bTempCorpse03; NPC_AI.iLoyalty092 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins092 = iTempMacGuffins03; NPC_AI.sAvailableWeapons092 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_093) { NPC_AI.DesireToMove093 = iTempDesireToMove03;  NPC_AI.bCorpse093 = bTempCorpse03; NPC_AI.iLoyalty093 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins093 = iTempMacGuffins03; NPC_AI.sAvailableWeapons093 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_094) { NPC_AI.DesireToMove094 = iTempDesireToMove03;  NPC_AI.bCorpse094 = bTempCorpse03; NPC_AI.iLoyalty094 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins094 = iTempMacGuffins03; NPC_AI.sAvailableWeapons094 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_095) { NPC_AI.DesireToMove095 = iTempDesireToMove03;  NPC_AI.bCorpse095 = bTempCorpse03; NPC_AI.iLoyalty095 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins095 = iTempMacGuffins03; NPC_AI.sAvailableWeapons095 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_096) { NPC_AI.DesireToMove096 = iTempDesireToMove03;  NPC_AI.bCorpse096 = bTempCorpse03; NPC_AI.iLoyalty096 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins096 = iTempMacGuffins03; NPC_AI.sAvailableWeapons096 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_097) { NPC_AI.DesireToMove097 = iTempDesireToMove03;  NPC_AI.bCorpse097 = bTempCorpse03; NPC_AI.iLoyalty097 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins097 = iTempMacGuffins03; NPC_AI.sAvailableWeapons097 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_098) { NPC_AI.DesireToMove098 = iTempDesireToMove03;  NPC_AI.bCorpse098 = bTempCorpse03; NPC_AI.iLoyalty098 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins098 = iTempMacGuffins03; NPC_AI.sAvailableWeapons098 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_099) { NPC_AI.DesireToMove099 = iTempDesireToMove03;  NPC_AI.bCorpse099 = bTempCorpse03; NPC_AI.iLoyalty099 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins099 = iTempMacGuffins03; NPC_AI.sAvailableWeapons099 = sTempWeapons03; }
            if (Actor03 == NPC_AI.NPC_100) { NPC_AI.DesireToMove100 = iTempDesireToMove03;  NPC_AI.bCorpse100 = bTempCorpse03; NPC_AI.iLoyalty100 = iTempLoyalty03; NPC_AI.iAvailableMacGuffins100 = iTempMacGuffins03; NPC_AI.sAvailableWeapons100 = sTempWeapons03; }

            if (Actor04 == NPC_AI.NPC_001) { NPC_AI.DesireToMove001 = iTempDesireToMove04;  NPC_AI.bCorpse001 = bTempCorpse04; NPC_AI.iLoyalty001 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins001 = iTempMacGuffins04; NPC_AI.sAvailableWeapons001 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_002) { NPC_AI.DesireToMove002 = iTempDesireToMove04;  NPC_AI.bCorpse002 = bTempCorpse04; NPC_AI.iLoyalty002 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins002 = iTempMacGuffins04; NPC_AI.sAvailableWeapons002 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_003) { NPC_AI.DesireToMove003 = iTempDesireToMove04;  NPC_AI.bCorpse003 = bTempCorpse04; NPC_AI.iLoyalty003 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins003 = iTempMacGuffins04; NPC_AI.sAvailableWeapons003 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_004) { NPC_AI.DesireToMove004 = iTempDesireToMove04;  NPC_AI.bCorpse004 = bTempCorpse04; NPC_AI.iLoyalty004 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins004 = iTempMacGuffins04; NPC_AI.sAvailableWeapons004 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_005) { NPC_AI.DesireToMove005 = iTempDesireToMove04;  NPC_AI.bCorpse005 = bTempCorpse04; NPC_AI.iLoyalty005 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins005 = iTempMacGuffins04; NPC_AI.sAvailableWeapons005 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_006) { NPC_AI.DesireToMove006 = iTempDesireToMove04;  NPC_AI.bCorpse006 = bTempCorpse04; NPC_AI.iLoyalty006 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins006 = iTempMacGuffins04; NPC_AI.sAvailableWeapons006 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_007) { NPC_AI.DesireToMove007 = iTempDesireToMove04;  NPC_AI.bCorpse007 = bTempCorpse04; NPC_AI.iLoyalty007 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins007 = iTempMacGuffins04; NPC_AI.sAvailableWeapons007 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_008) { NPC_AI.DesireToMove008 = iTempDesireToMove04;  NPC_AI.bCorpse008 = bTempCorpse04; NPC_AI.iLoyalty008 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins008 = iTempMacGuffins04; NPC_AI.sAvailableWeapons008 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_009) { NPC_AI.DesireToMove009 = iTempDesireToMove04;  NPC_AI.bCorpse009 = bTempCorpse04; NPC_AI.iLoyalty009 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins009 = iTempMacGuffins04; NPC_AI.sAvailableWeapons009 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_010) { NPC_AI.DesireToMove010 = iTempDesireToMove04;  NPC_AI.bCorpse010 = bTempCorpse04; NPC_AI.iLoyalty010 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins010 = iTempMacGuffins04; NPC_AI.sAvailableWeapons010 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_011) { NPC_AI.DesireToMove011 = iTempDesireToMove04;  NPC_AI.bCorpse011 = bTempCorpse04; NPC_AI.iLoyalty011 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins011 = iTempMacGuffins04; NPC_AI.sAvailableWeapons011 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_012) { NPC_AI.DesireToMove012 = iTempDesireToMove04;  NPC_AI.bCorpse012 = bTempCorpse04; NPC_AI.iLoyalty012 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins012 = iTempMacGuffins04; NPC_AI.sAvailableWeapons012 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_013) { NPC_AI.DesireToMove013 = iTempDesireToMove04;  NPC_AI.bCorpse013 = bTempCorpse04; NPC_AI.iLoyalty013 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins013 = iTempMacGuffins04; NPC_AI.sAvailableWeapons013 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_014) { NPC_AI.DesireToMove014 = iTempDesireToMove04;  NPC_AI.bCorpse014 = bTempCorpse04; NPC_AI.iLoyalty014 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins014 = iTempMacGuffins04; NPC_AI.sAvailableWeapons014 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_015) { NPC_AI.DesireToMove015 = iTempDesireToMove04;  NPC_AI.bCorpse015 = bTempCorpse04; NPC_AI.iLoyalty015 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins015 = iTempMacGuffins04; NPC_AI.sAvailableWeapons015 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_016) { NPC_AI.DesireToMove016 = iTempDesireToMove04;  NPC_AI.bCorpse016 = bTempCorpse04; NPC_AI.iLoyalty016 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins016 = iTempMacGuffins04; NPC_AI.sAvailableWeapons016 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_017) { NPC_AI.DesireToMove017 = iTempDesireToMove04;  NPC_AI.bCorpse017 = bTempCorpse04; NPC_AI.iLoyalty017 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins017 = iTempMacGuffins04; NPC_AI.sAvailableWeapons017 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_018) { NPC_AI.DesireToMove018 = iTempDesireToMove04;  NPC_AI.bCorpse018 = bTempCorpse04; NPC_AI.iLoyalty018 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins018 = iTempMacGuffins04; NPC_AI.sAvailableWeapons018 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_019) { NPC_AI.DesireToMove019 = iTempDesireToMove04;  NPC_AI.bCorpse019 = bTempCorpse04; NPC_AI.iLoyalty019 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins019 = iTempMacGuffins04; NPC_AI.sAvailableWeapons019 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_020) { NPC_AI.DesireToMove020 = iTempDesireToMove04;  NPC_AI.bCorpse020 = bTempCorpse04; NPC_AI.iLoyalty020 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins020 = iTempMacGuffins04; NPC_AI.sAvailableWeapons020 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_021) { NPC_AI.DesireToMove021 = iTempDesireToMove04;  NPC_AI.bCorpse021 = bTempCorpse04; NPC_AI.iLoyalty021 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins021 = iTempMacGuffins04; NPC_AI.sAvailableWeapons021 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_022) { NPC_AI.DesireToMove022 = iTempDesireToMove04;  NPC_AI.bCorpse022 = bTempCorpse04; NPC_AI.iLoyalty022 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins022 = iTempMacGuffins04; NPC_AI.sAvailableWeapons022 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_023) { NPC_AI.DesireToMove023 = iTempDesireToMove04;  NPC_AI.bCorpse023 = bTempCorpse04; NPC_AI.iLoyalty023 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins023 = iTempMacGuffins04; NPC_AI.sAvailableWeapons023 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_024) { NPC_AI.DesireToMove024 = iTempDesireToMove04;  NPC_AI.bCorpse024 = bTempCorpse04; NPC_AI.iLoyalty024 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins024 = iTempMacGuffins04; NPC_AI.sAvailableWeapons024 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_025) { NPC_AI.DesireToMove025 = iTempDesireToMove04;  NPC_AI.bCorpse025 = bTempCorpse04; NPC_AI.iLoyalty025 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins025 = iTempMacGuffins04; NPC_AI.sAvailableWeapons025 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_026) { NPC_AI.DesireToMove026 = iTempDesireToMove04;  NPC_AI.bCorpse026 = bTempCorpse04; NPC_AI.iLoyalty026 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins026 = iTempMacGuffins04; NPC_AI.sAvailableWeapons026 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_027) { NPC_AI.DesireToMove027 = iTempDesireToMove04;  NPC_AI.bCorpse027 = bTempCorpse04; NPC_AI.iLoyalty027 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins027 = iTempMacGuffins04; NPC_AI.sAvailableWeapons027 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_028) { NPC_AI.DesireToMove028 = iTempDesireToMove04;  NPC_AI.bCorpse028 = bTempCorpse04; NPC_AI.iLoyalty028 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins028 = iTempMacGuffins04; NPC_AI.sAvailableWeapons028 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_029) { NPC_AI.DesireToMove029 = iTempDesireToMove04;  NPC_AI.bCorpse029 = bTempCorpse04; NPC_AI.iLoyalty029 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins029 = iTempMacGuffins04; NPC_AI.sAvailableWeapons029 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_030) { NPC_AI.DesireToMove030 = iTempDesireToMove04;  NPC_AI.bCorpse030 = bTempCorpse04; NPC_AI.iLoyalty030 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins030 = iTempMacGuffins04; NPC_AI.sAvailableWeapons030 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_031) { NPC_AI.DesireToMove031 = iTempDesireToMove04;  NPC_AI.bCorpse031 = bTempCorpse04; NPC_AI.iLoyalty031 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins031 = iTempMacGuffins04; NPC_AI.sAvailableWeapons031 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_032) { NPC_AI.DesireToMove032 = iTempDesireToMove04;  NPC_AI.bCorpse032 = bTempCorpse04; NPC_AI.iLoyalty032 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins032 = iTempMacGuffins04; NPC_AI.sAvailableWeapons032 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_033) { NPC_AI.DesireToMove033 = iTempDesireToMove04;  NPC_AI.bCorpse033 = bTempCorpse04; NPC_AI.iLoyalty033 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins033 = iTempMacGuffins04; NPC_AI.sAvailableWeapons033 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_034) { NPC_AI.DesireToMove034 = iTempDesireToMove04;  NPC_AI.bCorpse034 = bTempCorpse04; NPC_AI.iLoyalty034 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins034 = iTempMacGuffins04; NPC_AI.sAvailableWeapons034 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_035) { NPC_AI.DesireToMove035 = iTempDesireToMove04;  NPC_AI.bCorpse035 = bTempCorpse04; NPC_AI.iLoyalty035 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins035 = iTempMacGuffins04; NPC_AI.sAvailableWeapons035 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_036) { NPC_AI.DesireToMove036 = iTempDesireToMove04;  NPC_AI.bCorpse036 = bTempCorpse04; NPC_AI.iLoyalty036 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins036 = iTempMacGuffins04; NPC_AI.sAvailableWeapons036 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_037) { NPC_AI.DesireToMove037 = iTempDesireToMove04;  NPC_AI.bCorpse037 = bTempCorpse04; NPC_AI.iLoyalty037 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins037 = iTempMacGuffins04; NPC_AI.sAvailableWeapons037 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_038) { NPC_AI.DesireToMove038 = iTempDesireToMove04;  NPC_AI.bCorpse038 = bTempCorpse04; NPC_AI.iLoyalty038 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins038 = iTempMacGuffins04; NPC_AI.sAvailableWeapons038 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_039) { NPC_AI.DesireToMove039 = iTempDesireToMove04;  NPC_AI.bCorpse039 = bTempCorpse04; NPC_AI.iLoyalty039 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins039 = iTempMacGuffins04; NPC_AI.sAvailableWeapons039 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_040) { NPC_AI.DesireToMove040 = iTempDesireToMove04;  NPC_AI.bCorpse040 = bTempCorpse04; NPC_AI.iLoyalty040 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins040 = iTempMacGuffins04; NPC_AI.sAvailableWeapons040 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_041) { NPC_AI.DesireToMove041 = iTempDesireToMove04;  NPC_AI.bCorpse041 = bTempCorpse04; NPC_AI.iLoyalty041 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins041 = iTempMacGuffins04; NPC_AI.sAvailableWeapons041 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_042) { NPC_AI.DesireToMove042 = iTempDesireToMove04;  NPC_AI.bCorpse042 = bTempCorpse04; NPC_AI.iLoyalty042 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins042 = iTempMacGuffins04; NPC_AI.sAvailableWeapons042 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_043) { NPC_AI.DesireToMove043 = iTempDesireToMove04;  NPC_AI.bCorpse043 = bTempCorpse04; NPC_AI.iLoyalty043 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins043 = iTempMacGuffins04; NPC_AI.sAvailableWeapons043 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_044) { NPC_AI.DesireToMove044 = iTempDesireToMove04;  NPC_AI.bCorpse044 = bTempCorpse04; NPC_AI.iLoyalty044 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins044 = iTempMacGuffins04; NPC_AI.sAvailableWeapons044 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_045) { NPC_AI.DesireToMove045 = iTempDesireToMove04;  NPC_AI.bCorpse045 = bTempCorpse04; NPC_AI.iLoyalty045 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins045 = iTempMacGuffins04; NPC_AI.sAvailableWeapons045 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_046) { NPC_AI.DesireToMove046 = iTempDesireToMove04;  NPC_AI.bCorpse046 = bTempCorpse04; NPC_AI.iLoyalty046 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins046 = iTempMacGuffins04; NPC_AI.sAvailableWeapons046 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_047) { NPC_AI.DesireToMove047 = iTempDesireToMove04;  NPC_AI.bCorpse047 = bTempCorpse04; NPC_AI.iLoyalty047 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins047 = iTempMacGuffins04; NPC_AI.sAvailableWeapons047 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_048) { NPC_AI.DesireToMove048 = iTempDesireToMove04;  NPC_AI.bCorpse048 = bTempCorpse04; NPC_AI.iLoyalty048 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins048 = iTempMacGuffins04; NPC_AI.sAvailableWeapons048 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_049) { NPC_AI.DesireToMove049 = iTempDesireToMove04;  NPC_AI.bCorpse049 = bTempCorpse04; NPC_AI.iLoyalty049 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins049 = iTempMacGuffins04; NPC_AI.sAvailableWeapons049 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_050) { NPC_AI.DesireToMove050 = iTempDesireToMove04;  NPC_AI.bCorpse050 = bTempCorpse04; NPC_AI.iLoyalty050 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins050 = iTempMacGuffins04; NPC_AI.sAvailableWeapons050 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_051) { NPC_AI.DesireToMove051 = iTempDesireToMove04;  NPC_AI.bCorpse051 = bTempCorpse04; NPC_AI.iLoyalty051 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins051 = iTempMacGuffins04; NPC_AI.sAvailableWeapons051 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_052) { NPC_AI.DesireToMove052 = iTempDesireToMove04;  NPC_AI.bCorpse052 = bTempCorpse04; NPC_AI.iLoyalty052 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins052 = iTempMacGuffins04; NPC_AI.sAvailableWeapons052 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_053) { NPC_AI.DesireToMove053 = iTempDesireToMove04;  NPC_AI.bCorpse053 = bTempCorpse04; NPC_AI.iLoyalty053 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins053 = iTempMacGuffins04; NPC_AI.sAvailableWeapons053 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_054) { NPC_AI.DesireToMove054 = iTempDesireToMove04;  NPC_AI.bCorpse054 = bTempCorpse04; NPC_AI.iLoyalty054 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins054 = iTempMacGuffins04; NPC_AI.sAvailableWeapons054 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_055) { NPC_AI.DesireToMove055 = iTempDesireToMove04;  NPC_AI.bCorpse055 = bTempCorpse04; NPC_AI.iLoyalty055 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins055 = iTempMacGuffins04; NPC_AI.sAvailableWeapons055 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_056) { NPC_AI.DesireToMove056 = iTempDesireToMove04;  NPC_AI.bCorpse056 = bTempCorpse04; NPC_AI.iLoyalty056 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins056 = iTempMacGuffins04; NPC_AI.sAvailableWeapons056 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_057) { NPC_AI.DesireToMove057 = iTempDesireToMove04;  NPC_AI.bCorpse057 = bTempCorpse04; NPC_AI.iLoyalty057 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins057 = iTempMacGuffins04; NPC_AI.sAvailableWeapons057 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_058) { NPC_AI.DesireToMove058 = iTempDesireToMove04;  NPC_AI.bCorpse058 = bTempCorpse04; NPC_AI.iLoyalty058 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins058 = iTempMacGuffins04; NPC_AI.sAvailableWeapons058 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_059) { NPC_AI.DesireToMove059 = iTempDesireToMove04;  NPC_AI.bCorpse059 = bTempCorpse04; NPC_AI.iLoyalty059 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins059 = iTempMacGuffins04; NPC_AI.sAvailableWeapons059 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_060) { NPC_AI.DesireToMove060 = iTempDesireToMove04;  NPC_AI.bCorpse060 = bTempCorpse04; NPC_AI.iLoyalty060 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins060 = iTempMacGuffins04; NPC_AI.sAvailableWeapons060 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_061) { NPC_AI.DesireToMove061 = iTempDesireToMove04;  NPC_AI.bCorpse061 = bTempCorpse04; NPC_AI.iLoyalty061 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins061 = iTempMacGuffins04; NPC_AI.sAvailableWeapons061 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_062) { NPC_AI.DesireToMove062 = iTempDesireToMove04;  NPC_AI.bCorpse062 = bTempCorpse04; NPC_AI.iLoyalty062 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins062 = iTempMacGuffins04; NPC_AI.sAvailableWeapons062 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_063) { NPC_AI.DesireToMove063 = iTempDesireToMove04;  NPC_AI.bCorpse063 = bTempCorpse04; NPC_AI.iLoyalty063 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins063 = iTempMacGuffins04; NPC_AI.sAvailableWeapons063 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_064) { NPC_AI.DesireToMove064 = iTempDesireToMove04;  NPC_AI.bCorpse064 = bTempCorpse04; NPC_AI.iLoyalty054 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins064 = iTempMacGuffins04; NPC_AI.sAvailableWeapons064 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_065) { NPC_AI.DesireToMove065 = iTempDesireToMove04;  NPC_AI.bCorpse065 = bTempCorpse04; NPC_AI.iLoyalty065 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins065 = iTempMacGuffins04; NPC_AI.sAvailableWeapons065 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_066) { NPC_AI.DesireToMove066 = iTempDesireToMove04;  NPC_AI.bCorpse066 = bTempCorpse04; NPC_AI.iLoyalty066 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins066 = iTempMacGuffins04; NPC_AI.sAvailableWeapons066 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_067) { NPC_AI.DesireToMove067 = iTempDesireToMove04;  NPC_AI.bCorpse067 = bTempCorpse04; NPC_AI.iLoyalty067 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins067 = iTempMacGuffins04; NPC_AI.sAvailableWeapons067 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_068) { NPC_AI.DesireToMove068 = iTempDesireToMove04;  NPC_AI.bCorpse068 = bTempCorpse04; NPC_AI.iLoyalty068 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins068 = iTempMacGuffins04; NPC_AI.sAvailableWeapons068 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_069) { NPC_AI.DesireToMove069 = iTempDesireToMove04;  NPC_AI.bCorpse069 = bTempCorpse04; NPC_AI.iLoyalty069 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins069 = iTempMacGuffins04; NPC_AI.sAvailableWeapons069 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_070) { NPC_AI.DesireToMove070 = iTempDesireToMove04;  NPC_AI.bCorpse070 = bTempCorpse04; NPC_AI.iLoyalty070 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins070 = iTempMacGuffins04; NPC_AI.sAvailableWeapons070 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_071) { NPC_AI.DesireToMove071 = iTempDesireToMove04;  NPC_AI.bCorpse071 = bTempCorpse04; NPC_AI.iLoyalty071 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins071 = iTempMacGuffins04; NPC_AI.sAvailableWeapons071 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_072) { NPC_AI.DesireToMove072 = iTempDesireToMove04;  NPC_AI.bCorpse072 = bTempCorpse04; NPC_AI.iLoyalty072 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins072 = iTempMacGuffins04; NPC_AI.sAvailableWeapons072 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_073) { NPC_AI.DesireToMove073 = iTempDesireToMove04;  NPC_AI.bCorpse073 = bTempCorpse04; NPC_AI.iLoyalty073 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins073 = iTempMacGuffins04; NPC_AI.sAvailableWeapons073 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_074) { NPC_AI.DesireToMove074 = iTempDesireToMove04;  NPC_AI.bCorpse074 = bTempCorpse04; NPC_AI.iLoyalty074 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins074 = iTempMacGuffins04; NPC_AI.sAvailableWeapons074 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_075) { NPC_AI.DesireToMove075 = iTempDesireToMove04;  NPC_AI.bCorpse075 = bTempCorpse04; NPC_AI.iLoyalty075 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins075 = iTempMacGuffins04; NPC_AI.sAvailableWeapons075 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_076) { NPC_AI.DesireToMove076 = iTempDesireToMove04;  NPC_AI.bCorpse076 = bTempCorpse04; NPC_AI.iLoyalty076 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins076 = iTempMacGuffins04; NPC_AI.sAvailableWeapons076 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_077) { NPC_AI.DesireToMove077 = iTempDesireToMove04;  NPC_AI.bCorpse077 = bTempCorpse04; NPC_AI.iLoyalty077 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins077 = iTempMacGuffins04; NPC_AI.sAvailableWeapons077 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_078) { NPC_AI.DesireToMove078 = iTempDesireToMove04;  NPC_AI.bCorpse078 = bTempCorpse04; NPC_AI.iLoyalty078 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins078 = iTempMacGuffins04; NPC_AI.sAvailableWeapons078 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_079) { NPC_AI.DesireToMove079 = iTempDesireToMove04;  NPC_AI.bCorpse079 = bTempCorpse04; NPC_AI.iLoyalty079 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins079 = iTempMacGuffins04; NPC_AI.sAvailableWeapons079 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_080) { NPC_AI.DesireToMove080 = iTempDesireToMove04;  NPC_AI.bCorpse080 = bTempCorpse04; NPC_AI.iLoyalty080 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins080 = iTempMacGuffins04; NPC_AI.sAvailableWeapons080 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_081) { NPC_AI.DesireToMove081 = iTempDesireToMove04;  NPC_AI.bCorpse081 = bTempCorpse04; NPC_AI.iLoyalty081 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins081 = iTempMacGuffins04; NPC_AI.sAvailableWeapons081 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_082) { NPC_AI.DesireToMove082 = iTempDesireToMove04;  NPC_AI.bCorpse082 = bTempCorpse04; NPC_AI.iLoyalty082 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins082 = iTempMacGuffins04; NPC_AI.sAvailableWeapons082 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_083) { NPC_AI.DesireToMove083 = iTempDesireToMove04;  NPC_AI.bCorpse083 = bTempCorpse04; NPC_AI.iLoyalty083 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins083 = iTempMacGuffins04; NPC_AI.sAvailableWeapons083 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_084) { NPC_AI.DesireToMove084 = iTempDesireToMove04;  NPC_AI.bCorpse084 = bTempCorpse04; NPC_AI.iLoyalty084 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins084 = iTempMacGuffins04; NPC_AI.sAvailableWeapons084 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_085) { NPC_AI.DesireToMove085 = iTempDesireToMove04;  NPC_AI.bCorpse085 = bTempCorpse04; NPC_AI.iLoyalty085 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins085 = iTempMacGuffins04; NPC_AI.sAvailableWeapons085 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_086) { NPC_AI.DesireToMove086 = iTempDesireToMove04;  NPC_AI.bCorpse086 = bTempCorpse04; NPC_AI.iLoyalty086 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins086 = iTempMacGuffins04; NPC_AI.sAvailableWeapons086 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_087) { NPC_AI.DesireToMove087 = iTempDesireToMove04;  NPC_AI.bCorpse087 = bTempCorpse04; NPC_AI.iLoyalty087 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins087 = iTempMacGuffins04; NPC_AI.sAvailableWeapons087 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_088) { NPC_AI.DesireToMove088 = iTempDesireToMove04;  NPC_AI.bCorpse088 = bTempCorpse04; NPC_AI.iLoyalty088 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins088 = iTempMacGuffins04; NPC_AI.sAvailableWeapons088 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_089) { NPC_AI.DesireToMove089 = iTempDesireToMove04;  NPC_AI.bCorpse089 = bTempCorpse04; NPC_AI.iLoyalty089 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins089 = iTempMacGuffins04; NPC_AI.sAvailableWeapons089 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_090) { NPC_AI.DesireToMove090 = iTempDesireToMove04;  NPC_AI.bCorpse090 = bTempCorpse04; NPC_AI.iLoyalty090 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins090 = iTempMacGuffins04; NPC_AI.sAvailableWeapons090 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_091) { NPC_AI.DesireToMove091 = iTempDesireToMove04;  NPC_AI.bCorpse091 = bTempCorpse04; NPC_AI.iLoyalty091 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins091 = iTempMacGuffins04; NPC_AI.sAvailableWeapons091 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_092) { NPC_AI.DesireToMove092 = iTempDesireToMove04;  NPC_AI.bCorpse092 = bTempCorpse04; NPC_AI.iLoyalty092 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins092 = iTempMacGuffins04; NPC_AI.sAvailableWeapons092 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_093) { NPC_AI.DesireToMove093 = iTempDesireToMove04;  NPC_AI.bCorpse093 = bTempCorpse04; NPC_AI.iLoyalty093 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins093 = iTempMacGuffins04; NPC_AI.sAvailableWeapons093 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_094) { NPC_AI.DesireToMove094 = iTempDesireToMove04;  NPC_AI.bCorpse094 = bTempCorpse04; NPC_AI.iLoyalty094 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins094 = iTempMacGuffins04; NPC_AI.sAvailableWeapons094 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_095) { NPC_AI.DesireToMove095 = iTempDesireToMove04;  NPC_AI.bCorpse095 = bTempCorpse04; NPC_AI.iLoyalty095 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins095 = iTempMacGuffins04; NPC_AI.sAvailableWeapons095 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_096) { NPC_AI.DesireToMove096 = iTempDesireToMove04;  NPC_AI.bCorpse096 = bTempCorpse04; NPC_AI.iLoyalty096 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins096 = iTempMacGuffins04; NPC_AI.sAvailableWeapons096 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_097) { NPC_AI.DesireToMove097 = iTempDesireToMove04;  NPC_AI.bCorpse097 = bTempCorpse04; NPC_AI.iLoyalty097 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins097 = iTempMacGuffins04; NPC_AI.sAvailableWeapons097 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_098) { NPC_AI.DesireToMove098 = iTempDesireToMove04;  NPC_AI.bCorpse098 = bTempCorpse04; NPC_AI.iLoyalty098 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins098 = iTempMacGuffins04; NPC_AI.sAvailableWeapons098 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_099) { NPC_AI.DesireToMove099 = iTempDesireToMove04;  NPC_AI.bCorpse099 = bTempCorpse04; NPC_AI.iLoyalty099 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins099 = iTempMacGuffins04; NPC_AI.sAvailableWeapons099 = sTempWeapons04; }
            if (Actor04 == NPC_AI.NPC_100) { NPC_AI.DesireToMove100 = iTempDesireToMove04;  NPC_AI.bCorpse100 = bTempCorpse04; NPC_AI.iLoyalty100 = iTempLoyalty04; NPC_AI.iAvailableMacGuffins100 = iTempMacGuffins04; NPC_AI.sAvailableWeapons100 = sTempWeapons04; }

            // be careful here, Actor06 is hacking an NPC's location (duz to my laziness); if Actor06 existed elsewhere in the game, this would overwrite his location. Don't use Actor06 elsewhere!
            if (Actor06 == NPC_AI.NPC_001) { NPC_AI.NPC001_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse001 = bTempCorpse06; NPC_AI.NPC001_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins001 = iTempMacGuffins06; NPC_AI.sAvailableWeapons001 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_002) { NPC_AI.NPC002_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse002 = bTempCorpse06; NPC_AI.NPC002_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins002 = iTempMacGuffins06; NPC_AI.sAvailableWeapons002 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_003) { NPC_AI.NPC003_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse003 = bTempCorpse06; NPC_AI.NPC003_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins003 = iTempMacGuffins06; NPC_AI.sAvailableWeapons003 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_004) { NPC_AI.NPC004_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse004 = bTempCorpse06; NPC_AI.NPC004_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins004 = iTempMacGuffins06; NPC_AI.sAvailableWeapons004 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_005) { NPC_AI.NPC005_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse005 = bTempCorpse06; NPC_AI.NPC005_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins005 = iTempMacGuffins06; NPC_AI.sAvailableWeapons005 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_006) { NPC_AI.NPC006_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse006 = bTempCorpse06; NPC_AI.NPC006_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins006 = iTempMacGuffins06; NPC_AI.sAvailableWeapons006 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_007) { NPC_AI.NPC007_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse007 = bTempCorpse06; NPC_AI.NPC007_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins007 = iTempMacGuffins06; NPC_AI.sAvailableWeapons007 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_008) { NPC_AI.NPC008_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse008 = bTempCorpse06; NPC_AI.NPC008_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins008 = iTempMacGuffins06; NPC_AI.sAvailableWeapons008 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_009) { NPC_AI.NPC009_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse009 = bTempCorpse06; NPC_AI.NPC009_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins009 = iTempMacGuffins06; NPC_AI.sAvailableWeapons009 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_010) { NPC_AI.NPC010_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse010 = bTempCorpse06; NPC_AI.NPC010_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins010 = iTempMacGuffins06; NPC_AI.sAvailableWeapons010 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_011) { NPC_AI.NPC011_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse011 = bTempCorpse06; NPC_AI.NPC011_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins011 = iTempMacGuffins06; NPC_AI.sAvailableWeapons011 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_012) { NPC_AI.NPC012_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse012 = bTempCorpse06; NPC_AI.NPC012_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins012 = iTempMacGuffins06; NPC_AI.sAvailableWeapons012 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_013) { NPC_AI.NPC013_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse013 = bTempCorpse06; NPC_AI.NPC013_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins013 = iTempMacGuffins06; NPC_AI.sAvailableWeapons013 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_014) { NPC_AI.NPC014_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse014 = bTempCorpse06; NPC_AI.NPC014_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins014 = iTempMacGuffins06; NPC_AI.sAvailableWeapons014 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_015) { NPC_AI.NPC015_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse015 = bTempCorpse06; NPC_AI.NPC015_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins015 = iTempMacGuffins06; NPC_AI.sAvailableWeapons015 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_016) { NPC_AI.NPC016_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse016 = bTempCorpse06; NPC_AI.NPC016_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins016 = iTempMacGuffins06; NPC_AI.sAvailableWeapons016 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_017) { NPC_AI.NPC017_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse017 = bTempCorpse06; NPC_AI.NPC017_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins017 = iTempMacGuffins06; NPC_AI.sAvailableWeapons017 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_018) { NPC_AI.NPC018_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse018 = bTempCorpse06; NPC_AI.NPC018_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins018 = iTempMacGuffins06; NPC_AI.sAvailableWeapons018 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_019) { NPC_AI.NPC019_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse019 = bTempCorpse06; NPC_AI.NPC019_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins019 = iTempMacGuffins06; NPC_AI.sAvailableWeapons019 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_020) { NPC_AI.NPC020_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse020 = bTempCorpse06; NPC_AI.NPC020_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins020 = iTempMacGuffins06; NPC_AI.sAvailableWeapons020 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_021) { NPC_AI.NPC021_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse021 = bTempCorpse06; NPC_AI.NPC021_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins021 = iTempMacGuffins06; NPC_AI.sAvailableWeapons021 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_022) { NPC_AI.NPC022_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse022 = bTempCorpse06; NPC_AI.NPC022_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins022 = iTempMacGuffins06; NPC_AI.sAvailableWeapons022 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_023) { NPC_AI.NPC023_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse023 = bTempCorpse06; NPC_AI.NPC023_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins023 = iTempMacGuffins06; NPC_AI.sAvailableWeapons023 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_024) { NPC_AI.NPC024_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse024 = bTempCorpse06; NPC_AI.NPC024_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins024 = iTempMacGuffins06; NPC_AI.sAvailableWeapons024 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_025) { NPC_AI.NPC025_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse025 = bTempCorpse06; NPC_AI.NPC025_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins025 = iTempMacGuffins06; NPC_AI.sAvailableWeapons025 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_026) { NPC_AI.NPC026_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse026 = bTempCorpse06; NPC_AI.NPC026_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins026 = iTempMacGuffins06; NPC_AI.sAvailableWeapons026 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_027) { NPC_AI.NPC027_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse027 = bTempCorpse06; NPC_AI.NPC027_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins027 = iTempMacGuffins06; NPC_AI.sAvailableWeapons027 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_028) { NPC_AI.NPC028_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse028 = bTempCorpse06; NPC_AI.NPC028_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins028 = iTempMacGuffins06; NPC_AI.sAvailableWeapons028 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_029) { NPC_AI.NPC029_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse029 = bTempCorpse06; NPC_AI.NPC029_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins029 = iTempMacGuffins06; NPC_AI.sAvailableWeapons029 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_030) { NPC_AI.NPC030_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse030 = bTempCorpse06; NPC_AI.NPC030_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins030 = iTempMacGuffins06; NPC_AI.sAvailableWeapons030 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_031) { NPC_AI.NPC031_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse031 = bTempCorpse06; NPC_AI.NPC031_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins031 = iTempMacGuffins06; NPC_AI.sAvailableWeapons031 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_032) { NPC_AI.NPC032_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse032 = bTempCorpse06; NPC_AI.NPC032_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins032 = iTempMacGuffins06; NPC_AI.sAvailableWeapons032 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_033) { NPC_AI.NPC033_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse033 = bTempCorpse06; NPC_AI.NPC033_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins033 = iTempMacGuffins06; NPC_AI.sAvailableWeapons033 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_034) { NPC_AI.NPC034_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse034 = bTempCorpse06; NPC_AI.NPC034_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins034 = iTempMacGuffins06; NPC_AI.sAvailableWeapons034 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_035) { NPC_AI.NPC035_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse035 = bTempCorpse06; NPC_AI.NPC035_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins035 = iTempMacGuffins06; NPC_AI.sAvailableWeapons035 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_036) { NPC_AI.NPC036_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse036 = bTempCorpse06; NPC_AI.NPC036_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins036 = iTempMacGuffins06; NPC_AI.sAvailableWeapons036 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_037) { NPC_AI.NPC037_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse037 = bTempCorpse06; NPC_AI.NPC037_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins037 = iTempMacGuffins06; NPC_AI.sAvailableWeapons037 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_038) { NPC_AI.NPC038_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse038 = bTempCorpse06; NPC_AI.NPC038_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins038 = iTempMacGuffins06; NPC_AI.sAvailableWeapons038 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_039) { NPC_AI.NPC039_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse039 = bTempCorpse06; NPC_AI.NPC039_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins039 = iTempMacGuffins06; NPC_AI.sAvailableWeapons039 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_040) { NPC_AI.NPC040_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse040 = bTempCorpse06; NPC_AI.NPC040_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins040 = iTempMacGuffins06; NPC_AI.sAvailableWeapons040 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_041) { NPC_AI.NPC041_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse041 = bTempCorpse06; NPC_AI.NPC041_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins041 = iTempMacGuffins06; NPC_AI.sAvailableWeapons041 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_042) { NPC_AI.NPC042_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse042 = bTempCorpse06; NPC_AI.NPC042_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins042 = iTempMacGuffins06; NPC_AI.sAvailableWeapons042 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_043) { NPC_AI.NPC043_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse043 = bTempCorpse06; NPC_AI.NPC043_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins043 = iTempMacGuffins06; NPC_AI.sAvailableWeapons043 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_044) { NPC_AI.NPC044_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse044 = bTempCorpse06; NPC_AI.NPC044_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins044 = iTempMacGuffins06; NPC_AI.sAvailableWeapons044 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_045) { NPC_AI.NPC045_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse045 = bTempCorpse06; NPC_AI.NPC045_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins045 = iTempMacGuffins06; NPC_AI.sAvailableWeapons045 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_046) { NPC_AI.NPC046_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse046 = bTempCorpse06; NPC_AI.NPC046_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins046 = iTempMacGuffins06; NPC_AI.sAvailableWeapons046 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_047) { NPC_AI.NPC047_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse047 = bTempCorpse06; NPC_AI.NPC047_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins047 = iTempMacGuffins06; NPC_AI.sAvailableWeapons047 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_048) { NPC_AI.NPC048_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse048 = bTempCorpse06; NPC_AI.NPC048_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins048 = iTempMacGuffins06; NPC_AI.sAvailableWeapons048 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_049) { NPC_AI.NPC049_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse049 = bTempCorpse06; NPC_AI.NPC049_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins049 = iTempMacGuffins06; NPC_AI.sAvailableWeapons049 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_050) { NPC_AI.NPC050_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse050 = bTempCorpse06; NPC_AI.NPC050_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins050 = iTempMacGuffins06; NPC_AI.sAvailableWeapons050 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_051) { NPC_AI.NPC051_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse051 = bTempCorpse06; NPC_AI.NPC051_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins051 = iTempMacGuffins06; NPC_AI.sAvailableWeapons051 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_052) { NPC_AI.NPC052_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse052 = bTempCorpse06; NPC_AI.NPC052_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins052 = iTempMacGuffins06; NPC_AI.sAvailableWeapons052 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_053) { NPC_AI.NPC053_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse053 = bTempCorpse06; NPC_AI.NPC053_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins053 = iTempMacGuffins06; NPC_AI.sAvailableWeapons053 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_054) { NPC_AI.NPC054_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse054 = bTempCorpse06; NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins054 = iTempMacGuffins06; NPC_AI.sAvailableWeapons054 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_055) { NPC_AI.NPC055_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse055 = bTempCorpse06; NPC_AI.NPC055_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins055 = iTempMacGuffins06; NPC_AI.sAvailableWeapons055 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_056) { NPC_AI.NPC056_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse056 = bTempCorpse06; NPC_AI.NPC056_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins056 = iTempMacGuffins06; NPC_AI.sAvailableWeapons056 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_057) { NPC_AI.NPC057_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse057 = bTempCorpse06; NPC_AI.NPC057_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins057 = iTempMacGuffins06; NPC_AI.sAvailableWeapons057 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_058) { NPC_AI.NPC058_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse058 = bTempCorpse06; NPC_AI.NPC058_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins058 = iTempMacGuffins06; NPC_AI.sAvailableWeapons058 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_059) { NPC_AI.NPC059_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse059 = bTempCorpse06; NPC_AI.NPC059_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins059 = iTempMacGuffins06; NPC_AI.sAvailableWeapons059 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_060) { NPC_AI.NPC060_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse060 = bTempCorpse06; NPC_AI.NPC060_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins060 = iTempMacGuffins06; NPC_AI.sAvailableWeapons060 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_061) { NPC_AI.NPC061_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse061 = bTempCorpse06; NPC_AI.NPC061_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins061 = iTempMacGuffins06; NPC_AI.sAvailableWeapons061 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_062) { NPC_AI.NPC062_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse062 = bTempCorpse06; NPC_AI.NPC062_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins062 = iTempMacGuffins06; NPC_AI.sAvailableWeapons062 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_063) { NPC_AI.NPC063_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse063 = bTempCorpse06; NPC_AI.NPC063_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins063 = iTempMacGuffins06; NPC_AI.sAvailableWeapons063 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_064) { NPC_AI.NPC064_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse064 = bTempCorpse06; NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins064 = iTempMacGuffins06; NPC_AI.sAvailableWeapons064 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_065) { NPC_AI.NPC065_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse065 = bTempCorpse06; NPC_AI.NPC065_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins065 = iTempMacGuffins06; NPC_AI.sAvailableWeapons065 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_066) { NPC_AI.NPC066_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse066 = bTempCorpse06; NPC_AI.NPC066_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins066 = iTempMacGuffins06; NPC_AI.sAvailableWeapons066 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_067) { NPC_AI.NPC067_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse067 = bTempCorpse06; NPC_AI.NPC067_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins067 = iTempMacGuffins06; NPC_AI.sAvailableWeapons067 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_068) { NPC_AI.NPC068_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse068 = bTempCorpse06; NPC_AI.NPC068_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins068 = iTempMacGuffins06; NPC_AI.sAvailableWeapons068 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_069) { NPC_AI.NPC069_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse069 = bTempCorpse06; NPC_AI.NPC069_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins069 = iTempMacGuffins06; NPC_AI.sAvailableWeapons069 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_070) { NPC_AI.NPC070_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse070 = bTempCorpse06; NPC_AI.NPC070_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins070 = iTempMacGuffins06; NPC_AI.sAvailableWeapons070 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_071) { NPC_AI.NPC071_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse071 = bTempCorpse06; NPC_AI.NPC071_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins071 = iTempMacGuffins06; NPC_AI.sAvailableWeapons071 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_072) { NPC_AI.NPC072_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse072 = bTempCorpse06; NPC_AI.NPC072_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins072 = iTempMacGuffins06; NPC_AI.sAvailableWeapons072 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_073) { NPC_AI.NPC073_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse073 = bTempCorpse06; NPC_AI.NPC073_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins073 = iTempMacGuffins06; NPC_AI.sAvailableWeapons073 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_074) { NPC_AI.NPC074_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse074 = bTempCorpse06; NPC_AI.NPC074_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins074 = iTempMacGuffins06; NPC_AI.sAvailableWeapons074 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_075) { NPC_AI.NPC075_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse075 = bTempCorpse06; NPC_AI.NPC075_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins075 = iTempMacGuffins06; NPC_AI.sAvailableWeapons075 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_076) { NPC_AI.NPC076_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse076 = bTempCorpse06; NPC_AI.NPC076_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins076 = iTempMacGuffins06; NPC_AI.sAvailableWeapons076 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_077) { NPC_AI.NPC077_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse077 = bTempCorpse06; NPC_AI.NPC077_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins077 = iTempMacGuffins06; NPC_AI.sAvailableWeapons077 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_078) { NPC_AI.NPC078_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse078 = bTempCorpse06; NPC_AI.NPC078_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins078 = iTempMacGuffins06; NPC_AI.sAvailableWeapons078 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_079) { NPC_AI.NPC079_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse079 = bTempCorpse06; NPC_AI.NPC079_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins079 = iTempMacGuffins06; NPC_AI.sAvailableWeapons079 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_080) { NPC_AI.NPC080_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse080 = bTempCorpse06; NPC_AI.NPC080_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins080 = iTempMacGuffins06; NPC_AI.sAvailableWeapons080 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_081) { NPC_AI.NPC081_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse081 = bTempCorpse06; NPC_AI.NPC081_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins081 = iTempMacGuffins06; NPC_AI.sAvailableWeapons081 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_082) { NPC_AI.NPC082_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse082 = bTempCorpse06; NPC_AI.NPC082_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins082 = iTempMacGuffins06; NPC_AI.sAvailableWeapons082 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_083) { NPC_AI.NPC083_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse083 = bTempCorpse06; NPC_AI.NPC083_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins083 = iTempMacGuffins06; NPC_AI.sAvailableWeapons083 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_084) { NPC_AI.NPC084_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse084 = bTempCorpse06; NPC_AI.NPC084_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins084 = iTempMacGuffins06; NPC_AI.sAvailableWeapons084 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_085) { NPC_AI.NPC085_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse085 = bTempCorpse06; NPC_AI.NPC085_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins085 = iTempMacGuffins06; NPC_AI.sAvailableWeapons085 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_086) { NPC_AI.NPC086_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse086 = bTempCorpse06; NPC_AI.NPC086_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins086 = iTempMacGuffins06; NPC_AI.sAvailableWeapons086 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_087) { NPC_AI.NPC087_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse087 = bTempCorpse06; NPC_AI.NPC087_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins087 = iTempMacGuffins06; NPC_AI.sAvailableWeapons087 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_088) { NPC_AI.NPC088_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse088 = bTempCorpse06; NPC_AI.NPC088_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins088 = iTempMacGuffins06; NPC_AI.sAvailableWeapons088 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_089) { NPC_AI.NPC089_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse089 = bTempCorpse06; NPC_AI.NPC089_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins089 = iTempMacGuffins06; NPC_AI.sAvailableWeapons089 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_090) { NPC_AI.NPC090_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse090 = bTempCorpse06; NPC_AI.NPC090_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins090 = iTempMacGuffins06; NPC_AI.sAvailableWeapons090 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_091) { NPC_AI.NPC091_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse091 = bTempCorpse06; NPC_AI.NPC091_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins091 = iTempMacGuffins06; NPC_AI.sAvailableWeapons091 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_092) { NPC_AI.NPC092_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse092 = bTempCorpse06; NPC_AI.NPC092_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins092 = iTempMacGuffins06; NPC_AI.sAvailableWeapons092 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_093) { NPC_AI.NPC093_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse093 = bTempCorpse06; NPC_AI.NPC093_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins093 = iTempMacGuffins06; NPC_AI.sAvailableWeapons093 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_094) { NPC_AI.NPC094_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse094 = bTempCorpse06; NPC_AI.NPC094_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins094 = iTempMacGuffins06; NPC_AI.sAvailableWeapons094 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_095) { NPC_AI.NPC095_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse095 = bTempCorpse06; NPC_AI.NPC095_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins095 = iTempMacGuffins06; NPC_AI.sAvailableWeapons095 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_096) { NPC_AI.NPC096_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse096 = bTempCorpse06; NPC_AI.NPC096_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins096 = iTempMacGuffins06; NPC_AI.sAvailableWeapons096 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_097) { NPC_AI.NPC097_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse097 = bTempCorpse06; NPC_AI.NPC097_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins097 = iTempMacGuffins06; NPC_AI.sAvailableWeapons097 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_098) { NPC_AI.NPC098_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse098 = bTempCorpse06; NPC_AI.NPC098_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins098 = iTempMacGuffins06; NPC_AI.sAvailableWeapons098 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_099) { NPC_AI.NPC099_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse099 = bTempCorpse06; NPC_AI.NPC099_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins099 = iTempMacGuffins06; NPC_AI.sAvailableWeapons099 = sTempWeapons06; }
            if (Actor06 == NPC_AI.NPC_100) { NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010;  NPC_AI.bCorpse100 = bTempCorpse06; NPC_AI.NPC100_CurrentNumLocation = 10; NPC_AI.iAvailableMacGuffins100 = iTempMacGuffins06; NPC_AI.sAvailableWeapons100 = sTempWeapons06; }
        }

        public static void Run_RandomEncounter01()
        {
            if (iRandEncounter == 1) // Random Encounter #1
            {
                if (Actor01 == NPC_AI.NPC_001) { NPC_AI.NPC001_CurrentNumLocation = 10; NPC_AI.NPC001_LastLocation = 10; NPC_AI.NPC001_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC001_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_002) { NPC_AI.NPC002_CurrentNumLocation = 10; NPC_AI.NPC002_LastLocation = 10; NPC_AI.NPC002_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC002_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_003) { NPC_AI.NPC003_CurrentNumLocation = 10; NPC_AI.NPC003_LastLocation = 10; NPC_AI.NPC003_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC003_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_004) { NPC_AI.NPC004_CurrentNumLocation = 10; NPC_AI.NPC004_LastLocation = 10; NPC_AI.NPC004_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC004_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_005) { NPC_AI.NPC005_CurrentNumLocation = 10; NPC_AI.NPC005_LastLocation = 10; NPC_AI.NPC005_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC005_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_006) { NPC_AI.NPC006_CurrentNumLocation = 10; NPC_AI.NPC006_LastLocation = 10; NPC_AI.NPC006_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC006_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_007) { NPC_AI.NPC007_CurrentNumLocation = 10; NPC_AI.NPC007_LastLocation = 10; NPC_AI.NPC007_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC007_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_008) { NPC_AI.NPC008_CurrentNumLocation = 10; NPC_AI.NPC008_LastLocation = 10; NPC_AI.NPC008_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC008_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_009) { NPC_AI.NPC009_CurrentNumLocation = 10; NPC_AI.NPC009_LastLocation = 10; NPC_AI.NPC009_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC009_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_010) { NPC_AI.NPC010_CurrentNumLocation = 10; NPC_AI.NPC010_LastLocation = 10; NPC_AI.NPC010_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC010_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_011) { NPC_AI.NPC011_CurrentNumLocation = 10; NPC_AI.NPC011_LastLocation = 10; NPC_AI.NPC011_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC011_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_012) { NPC_AI.NPC012_CurrentNumLocation = 10; NPC_AI.NPC012_LastLocation = 10; NPC_AI.NPC012_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC012_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_013) { NPC_AI.NPC013_CurrentNumLocation = 10; NPC_AI.NPC013_LastLocation = 10; NPC_AI.NPC013_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC013_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_014) { NPC_AI.NPC014_CurrentNumLocation = 10; NPC_AI.NPC014_LastLocation = 10; NPC_AI.NPC014_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC014_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_015) { NPC_AI.NPC015_CurrentNumLocation = 10; NPC_AI.NPC015_LastLocation = 10; NPC_AI.NPC015_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC015_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_016) { NPC_AI.NPC016_CurrentNumLocation = 10; NPC_AI.NPC016_LastLocation = 10; NPC_AI.NPC016_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC016_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_017) { NPC_AI.NPC017_CurrentNumLocation = 10; NPC_AI.NPC017_LastLocation = 10; NPC_AI.NPC017_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC017_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_018) { NPC_AI.NPC018_CurrentNumLocation = 10; NPC_AI.NPC018_LastLocation = 10; NPC_AI.NPC018_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC018_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_019) { NPC_AI.NPC019_CurrentNumLocation = 10; NPC_AI.NPC019_LastLocation = 10; NPC_AI.NPC019_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC019_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_020) { NPC_AI.NPC020_CurrentNumLocation = 10; NPC_AI.NPC020_LastLocation = 10; NPC_AI.NPC020_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC020_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_021) { NPC_AI.NPC021_CurrentNumLocation = 10; NPC_AI.NPC021_LastLocation = 10; NPC_AI.NPC021_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC021_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_022) { NPC_AI.NPC022_CurrentNumLocation = 10; NPC_AI.NPC022_LastLocation = 10; NPC_AI.NPC022_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC022_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_023) { NPC_AI.NPC023_CurrentNumLocation = 10; NPC_AI.NPC023_LastLocation = 10; NPC_AI.NPC023_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC023_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_024) { NPC_AI.NPC024_CurrentNumLocation = 10; NPC_AI.NPC024_LastLocation = 10; NPC_AI.NPC024_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC024_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_025) { NPC_AI.NPC025_CurrentNumLocation = 10; NPC_AI.NPC025_LastLocation = 10; NPC_AI.NPC025_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC025_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_026) { NPC_AI.NPC026_CurrentNumLocation = 10; NPC_AI.NPC026_LastLocation = 10; NPC_AI.NPC026_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC026_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_027) { NPC_AI.NPC027_CurrentNumLocation = 10; NPC_AI.NPC027_LastLocation = 10; NPC_AI.NPC027_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC027_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_028) { NPC_AI.NPC028_CurrentNumLocation = 10; NPC_AI.NPC028_LastLocation = 10; NPC_AI.NPC028_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC028_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_029) { NPC_AI.NPC029_CurrentNumLocation = 10; NPC_AI.NPC029_LastLocation = 10; NPC_AI.NPC029_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC029_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_030) { NPC_AI.NPC030_CurrentNumLocation = 10; NPC_AI.NPC030_LastLocation = 10; NPC_AI.NPC030_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC030_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_031) { NPC_AI.NPC031_CurrentNumLocation = 10; NPC_AI.NPC031_LastLocation = 10; NPC_AI.NPC031_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC031_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_032) { NPC_AI.NPC032_CurrentNumLocation = 10; NPC_AI.NPC032_LastLocation = 10; NPC_AI.NPC032_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC032_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_033) { NPC_AI.NPC033_CurrentNumLocation = 10; NPC_AI.NPC033_LastLocation = 10; NPC_AI.NPC033_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC033_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_034) { NPC_AI.NPC034_CurrentNumLocation = 10; NPC_AI.NPC034_LastLocation = 10; NPC_AI.NPC034_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC034_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_035) { NPC_AI.NPC035_CurrentNumLocation = 10; NPC_AI.NPC035_LastLocation = 10; NPC_AI.NPC035_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC035_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_036) { NPC_AI.NPC036_CurrentNumLocation = 10; NPC_AI.NPC036_LastLocation = 10; NPC_AI.NPC036_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC036_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_037) { NPC_AI.NPC037_CurrentNumLocation = 10; NPC_AI.NPC037_LastLocation = 10; NPC_AI.NPC037_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC037_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_038) { NPC_AI.NPC038_CurrentNumLocation = 10; NPC_AI.NPC038_LastLocation = 10; NPC_AI.NPC038_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC038_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_039) { NPC_AI.NPC039_CurrentNumLocation = 10; NPC_AI.NPC039_LastLocation = 10; NPC_AI.NPC039_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC039_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_040) { NPC_AI.NPC040_CurrentNumLocation = 10; NPC_AI.NPC040_LastLocation = 10; NPC_AI.NPC040_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC040_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_041) { NPC_AI.NPC041_CurrentNumLocation = 10; NPC_AI.NPC041_LastLocation = 10; NPC_AI.NPC041_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC041_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_042) { NPC_AI.NPC042_CurrentNumLocation = 10; NPC_AI.NPC042_LastLocation = 10; NPC_AI.NPC042_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC042_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_043) { NPC_AI.NPC043_CurrentNumLocation = 10; NPC_AI.NPC043_LastLocation = 10; NPC_AI.NPC043_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC043_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_044) { NPC_AI.NPC044_CurrentNumLocation = 10; NPC_AI.NPC044_LastLocation = 10; NPC_AI.NPC044_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC044_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_045) { NPC_AI.NPC045_CurrentNumLocation = 10; NPC_AI.NPC045_LastLocation = 10; NPC_AI.NPC045_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC045_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_046) { NPC_AI.NPC046_CurrentNumLocation = 10; NPC_AI.NPC046_LastLocation = 10; NPC_AI.NPC046_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC046_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_047) { NPC_AI.NPC047_CurrentNumLocation = 10; NPC_AI.NPC047_LastLocation = 10; NPC_AI.NPC047_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC047_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_048) { NPC_AI.NPC048_CurrentNumLocation = 10; NPC_AI.NPC048_LastLocation = 10; NPC_AI.NPC048_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC048_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_049) { NPC_AI.NPC049_CurrentNumLocation = 10; NPC_AI.NPC049_LastLocation = 10; NPC_AI.NPC049_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC049_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_050) { NPC_AI.NPC050_CurrentNumLocation = 10; NPC_AI.NPC050_LastLocation = 10; NPC_AI.NPC050_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC050_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_051) { NPC_AI.NPC051_CurrentNumLocation = 10; NPC_AI.NPC051_LastLocation = 10; NPC_AI.NPC051_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC051_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_052) { NPC_AI.NPC052_CurrentNumLocation = 10; NPC_AI.NPC052_LastLocation = 10; NPC_AI.NPC052_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC052_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_053) { NPC_AI.NPC053_CurrentNumLocation = 10; NPC_AI.NPC053_LastLocation = 10; NPC_AI.NPC053_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC053_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_054) { NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.NPC054_LastLocation = 10; NPC_AI.NPC054_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC054_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_055) { NPC_AI.NPC055_CurrentNumLocation = 10; NPC_AI.NPC055_LastLocation = 10; NPC_AI.NPC055_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC055_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_056) { NPC_AI.NPC056_CurrentNumLocation = 10; NPC_AI.NPC056_LastLocation = 10; NPC_AI.NPC056_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC056_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_057) { NPC_AI.NPC057_CurrentNumLocation = 10; NPC_AI.NPC057_LastLocation = 10; NPC_AI.NPC057_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC057_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_058) { NPC_AI.NPC058_CurrentNumLocation = 10; NPC_AI.NPC058_LastLocation = 10; NPC_AI.NPC058_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC058_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_059) { NPC_AI.NPC059_CurrentNumLocation = 10; NPC_AI.NPC059_LastLocation = 10; NPC_AI.NPC059_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC059_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_060) { NPC_AI.NPC060_CurrentNumLocation = 10; NPC_AI.NPC060_LastLocation = 10; NPC_AI.NPC060_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC060_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_061) { NPC_AI.NPC061_CurrentNumLocation = 10; NPC_AI.NPC061_LastLocation = 10; NPC_AI.NPC061_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC061_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_062) { NPC_AI.NPC062_CurrentNumLocation = 10; NPC_AI.NPC062_LastLocation = 10; NPC_AI.NPC062_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC062_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_063) { NPC_AI.NPC063_CurrentNumLocation = 10; NPC_AI.NPC063_LastLocation = 10; NPC_AI.NPC063_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC063_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_064) { NPC_AI.NPC064_CurrentNumLocation = 10; NPC_AI.NPC064_LastLocation = 10; NPC_AI.NPC064_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC064_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_065) { NPC_AI.NPC065_CurrentNumLocation = 10; NPC_AI.NPC065_LastLocation = 10; NPC_AI.NPC065_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC065_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_066) { NPC_AI.NPC066_CurrentNumLocation = 10; NPC_AI.NPC066_LastLocation = 10; NPC_AI.NPC066_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC066_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_067) { NPC_AI.NPC067_CurrentNumLocation = 10; NPC_AI.NPC067_LastLocation = 10; NPC_AI.NPC067_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC067_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_068) { NPC_AI.NPC068_CurrentNumLocation = 10; NPC_AI.NPC068_LastLocation = 10; NPC_AI.NPC068_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC068_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_069) { NPC_AI.NPC069_CurrentNumLocation = 10; NPC_AI.NPC069_LastLocation = 10; NPC_AI.NPC069_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC069_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_070) { NPC_AI.NPC070_CurrentNumLocation = 10; NPC_AI.NPC070_LastLocation = 10; NPC_AI.NPC070_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC070_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_071) { NPC_AI.NPC071_CurrentNumLocation = 10; NPC_AI.NPC071_LastLocation = 10; NPC_AI.NPC071_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC071_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_072) { NPC_AI.NPC072_CurrentNumLocation = 10; NPC_AI.NPC072_LastLocation = 10; NPC_AI.NPC072_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC072_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_073) { NPC_AI.NPC073_CurrentNumLocation = 10; NPC_AI.NPC073_LastLocation = 10; NPC_AI.NPC073_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC073_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_074) { NPC_AI.NPC074_CurrentNumLocation = 10; NPC_AI.NPC074_LastLocation = 10; NPC_AI.NPC074_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC074_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_075) { NPC_AI.NPC075_CurrentNumLocation = 10; NPC_AI.NPC075_LastLocation = 10; NPC_AI.NPC075_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC075_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_076) { NPC_AI.NPC076_CurrentNumLocation = 10; NPC_AI.NPC076_LastLocation = 10; NPC_AI.NPC076_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC076_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_077) { NPC_AI.NPC077_CurrentNumLocation = 10; NPC_AI.NPC077_LastLocation = 10; NPC_AI.NPC077_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC077_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_078) { NPC_AI.NPC078_CurrentNumLocation = 10; NPC_AI.NPC078_LastLocation = 10; NPC_AI.NPC078_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC078_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_079) { NPC_AI.NPC079_CurrentNumLocation = 10; NPC_AI.NPC079_LastLocation = 10; NPC_AI.NPC079_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC079_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_080) { NPC_AI.NPC080_CurrentNumLocation = 10; NPC_AI.NPC080_LastLocation = 10; NPC_AI.NPC080_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC080_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_081) { NPC_AI.NPC081_CurrentNumLocation = 10; NPC_AI.NPC081_LastLocation = 10; NPC_AI.NPC081_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC081_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_082) { NPC_AI.NPC082_CurrentNumLocation = 10; NPC_AI.NPC082_LastLocation = 10; NPC_AI.NPC082_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC082_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_083) { NPC_AI.NPC083_CurrentNumLocation = 10; NPC_AI.NPC083_LastLocation = 10; NPC_AI.NPC083_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC083_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_084) { NPC_AI.NPC084_CurrentNumLocation = 10; NPC_AI.NPC084_LastLocation = 10; NPC_AI.NPC084_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC084_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_085) { NPC_AI.NPC085_CurrentNumLocation = 10; NPC_AI.NPC085_LastLocation = 10; NPC_AI.NPC085_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC085_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_086) { NPC_AI.NPC086_CurrentNumLocation = 10; NPC_AI.NPC086_LastLocation = 10; NPC_AI.NPC086_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC086_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_087) { NPC_AI.NPC087_CurrentNumLocation = 10; NPC_AI.NPC087_LastLocation = 10; NPC_AI.NPC087_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC087_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_088) { NPC_AI.NPC088_CurrentNumLocation = 10; NPC_AI.NPC088_LastLocation = 10; NPC_AI.NPC088_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC088_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_089) { NPC_AI.NPC089_CurrentNumLocation = 10; NPC_AI.NPC089_LastLocation = 10; NPC_AI.NPC089_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC089_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_090) { NPC_AI.NPC090_CurrentNumLocation = 10; NPC_AI.NPC090_LastLocation = 10; NPC_AI.NPC090_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC090_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_091) { NPC_AI.NPC091_CurrentNumLocation = 10; NPC_AI.NPC091_LastLocation = 10; NPC_AI.NPC091_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC091_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_092) { NPC_AI.NPC092_CurrentNumLocation = 10; NPC_AI.NPC092_LastLocation = 10; NPC_AI.NPC092_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC092_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_093) { NPC_AI.NPC093_CurrentNumLocation = 10; NPC_AI.NPC093_LastLocation = 10; NPC_AI.NPC093_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC093_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_094) { NPC_AI.NPC094_CurrentNumLocation = 10; NPC_AI.NPC094_LastLocation = 10; NPC_AI.NPC094_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC094_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_095) { NPC_AI.NPC095_CurrentNumLocation = 10; NPC_AI.NPC095_LastLocation = 10; NPC_AI.NPC095_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC095_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_096) { NPC_AI.NPC096_CurrentNumLocation = 10; NPC_AI.NPC096_LastLocation = 10; NPC_AI.NPC096_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC096_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_097) { NPC_AI.NPC097_CurrentNumLocation = 10; NPC_AI.NPC097_LastLocation = 10; NPC_AI.NPC097_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC097_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_098) { NPC_AI.NPC098_CurrentNumLocation = 10; NPC_AI.NPC098_LastLocation = 10; NPC_AI.NPC098_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC098_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_099) { NPC_AI.NPC099_CurrentNumLocation = 10; NPC_AI.NPC099_LastLocation = 10; NPC_AI.NPC099_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC099_LastStrLocation = LocationEncounters.location_010; }
                if (Actor01 == NPC_AI.NPC_100) { NPC_AI.NPC100_CurrentNumLocation = 10; NPC_AI.NPC100_LastLocation = 10; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC100_LastStrLocation = LocationEncounters.location_010; }

                if (Actor02 == NPC_AI.NPC_001) { NPC_AI.NPC001_CurrentNumLocation = 10; NPC_AI.NPC001_LastLocation = 10; NPC_AI.NPC001_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC001_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_002) { NPC_AI.NPC002_CurrentNumLocation = 10; NPC_AI.NPC002_LastLocation = 10; NPC_AI.NPC002_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC002_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_003) { NPC_AI.NPC003_CurrentNumLocation = 10; NPC_AI.NPC003_LastLocation = 10; NPC_AI.NPC003_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC003_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_004) { NPC_AI.NPC004_CurrentNumLocation = 10; NPC_AI.NPC004_LastLocation = 10; NPC_AI.NPC004_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC004_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_005) { NPC_AI.NPC005_CurrentNumLocation = 10; NPC_AI.NPC005_LastLocation = 10; NPC_AI.NPC005_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC005_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_006) { NPC_AI.NPC006_CurrentNumLocation = 10; NPC_AI.NPC006_LastLocation = 10; NPC_AI.NPC006_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC006_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_007) { NPC_AI.NPC007_CurrentNumLocation = 10; NPC_AI.NPC007_LastLocation = 10; NPC_AI.NPC007_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC007_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_008) { NPC_AI.NPC008_CurrentNumLocation = 10; NPC_AI.NPC008_LastLocation = 10; NPC_AI.NPC008_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC008_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_009) { NPC_AI.NPC009_CurrentNumLocation = 10; NPC_AI.NPC009_LastLocation = 10; NPC_AI.NPC009_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC009_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_010) { NPC_AI.NPC010_CurrentNumLocation = 10; NPC_AI.NPC010_LastLocation = 10; NPC_AI.NPC010_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC010_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_011) { NPC_AI.NPC011_CurrentNumLocation = 10; NPC_AI.NPC011_LastLocation = 10; NPC_AI.NPC011_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC011_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_012) { NPC_AI.NPC012_CurrentNumLocation = 10; NPC_AI.NPC012_LastLocation = 10; NPC_AI.NPC012_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC012_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_013) { NPC_AI.NPC013_CurrentNumLocation = 10; NPC_AI.NPC013_LastLocation = 10; NPC_AI.NPC013_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC013_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_014) { NPC_AI.NPC014_CurrentNumLocation = 10; NPC_AI.NPC014_LastLocation = 10; NPC_AI.NPC014_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC014_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_015) { NPC_AI.NPC015_CurrentNumLocation = 10; NPC_AI.NPC015_LastLocation = 10; NPC_AI.NPC015_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC015_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_016) { NPC_AI.NPC016_CurrentNumLocation = 10; NPC_AI.NPC016_LastLocation = 10; NPC_AI.NPC016_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC016_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_017) { NPC_AI.NPC017_CurrentNumLocation = 10; NPC_AI.NPC017_LastLocation = 10; NPC_AI.NPC017_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC017_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_018) { NPC_AI.NPC018_CurrentNumLocation = 10; NPC_AI.NPC018_LastLocation = 10; NPC_AI.NPC018_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC018_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_019) { NPC_AI.NPC019_CurrentNumLocation = 10; NPC_AI.NPC019_LastLocation = 10; NPC_AI.NPC019_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC019_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_020) { NPC_AI.NPC020_CurrentNumLocation = 10; NPC_AI.NPC020_LastLocation = 10; NPC_AI.NPC020_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC020_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_021) { NPC_AI.NPC021_CurrentNumLocation = 10; NPC_AI.NPC021_LastLocation = 10; NPC_AI.NPC021_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC021_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_022) { NPC_AI.NPC022_CurrentNumLocation = 10; NPC_AI.NPC022_LastLocation = 10; NPC_AI.NPC022_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC022_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_023) { NPC_AI.NPC023_CurrentNumLocation = 10; NPC_AI.NPC023_LastLocation = 10; NPC_AI.NPC023_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC023_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_024) { NPC_AI.NPC024_CurrentNumLocation = 10; NPC_AI.NPC024_LastLocation = 10; NPC_AI.NPC024_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC024_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_025) { NPC_AI.NPC025_CurrentNumLocation = 10; NPC_AI.NPC025_LastLocation = 10; NPC_AI.NPC025_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC025_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_026) { NPC_AI.NPC026_CurrentNumLocation = 10; NPC_AI.NPC026_LastLocation = 10; NPC_AI.NPC026_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC026_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_027) { NPC_AI.NPC027_CurrentNumLocation = 10; NPC_AI.NPC027_LastLocation = 10; NPC_AI.NPC027_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC027_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_028) { NPC_AI.NPC028_CurrentNumLocation = 10; NPC_AI.NPC028_LastLocation = 10; NPC_AI.NPC028_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC028_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_029) { NPC_AI.NPC029_CurrentNumLocation = 10; NPC_AI.NPC029_LastLocation = 10; NPC_AI.NPC029_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC029_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_030) { NPC_AI.NPC030_CurrentNumLocation = 10; NPC_AI.NPC030_LastLocation = 10; NPC_AI.NPC030_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC030_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_031) { NPC_AI.NPC031_CurrentNumLocation = 10; NPC_AI.NPC031_LastLocation = 10; NPC_AI.NPC031_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC031_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_032) { NPC_AI.NPC032_CurrentNumLocation = 10; NPC_AI.NPC032_LastLocation = 10; NPC_AI.NPC032_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC032_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_033) { NPC_AI.NPC033_CurrentNumLocation = 10; NPC_AI.NPC033_LastLocation = 10; NPC_AI.NPC033_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC033_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_034) { NPC_AI.NPC034_CurrentNumLocation = 10; NPC_AI.NPC034_LastLocation = 10; NPC_AI.NPC034_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC034_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_035) { NPC_AI.NPC035_CurrentNumLocation = 10; NPC_AI.NPC035_LastLocation = 10; NPC_AI.NPC035_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC035_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_036) { NPC_AI.NPC036_CurrentNumLocation = 10; NPC_AI.NPC036_LastLocation = 10; NPC_AI.NPC036_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC036_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_037) { NPC_AI.NPC037_CurrentNumLocation = 10; NPC_AI.NPC037_LastLocation = 10; NPC_AI.NPC037_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC037_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_038) { NPC_AI.NPC038_CurrentNumLocation = 10; NPC_AI.NPC038_LastLocation = 10; NPC_AI.NPC038_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC038_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_039) { NPC_AI.NPC039_CurrentNumLocation = 10; NPC_AI.NPC039_LastLocation = 10; NPC_AI.NPC039_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC039_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_040) { NPC_AI.NPC040_CurrentNumLocation = 10; NPC_AI.NPC040_LastLocation = 10; NPC_AI.NPC040_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC040_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_041) { NPC_AI.NPC041_CurrentNumLocation = 10; NPC_AI.NPC041_LastLocation = 10; NPC_AI.NPC041_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC041_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_042) { NPC_AI.NPC042_CurrentNumLocation = 10; NPC_AI.NPC042_LastLocation = 10; NPC_AI.NPC042_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC042_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_043) { NPC_AI.NPC043_CurrentNumLocation = 10; NPC_AI.NPC043_LastLocation = 10; NPC_AI.NPC043_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC043_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_044) { NPC_AI.NPC044_CurrentNumLocation = 10; NPC_AI.NPC044_LastLocation = 10; NPC_AI.NPC044_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC044_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_045) { NPC_AI.NPC045_CurrentNumLocation = 10; NPC_AI.NPC045_LastLocation = 10; NPC_AI.NPC045_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC045_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_046) { NPC_AI.NPC046_CurrentNumLocation = 10; NPC_AI.NPC046_LastLocation = 10; NPC_AI.NPC046_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC046_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_047) { NPC_AI.NPC047_CurrentNumLocation = 10; NPC_AI.NPC047_LastLocation = 10; NPC_AI.NPC047_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC047_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_048) { NPC_AI.NPC048_CurrentNumLocation = 10; NPC_AI.NPC048_LastLocation = 10; NPC_AI.NPC048_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC048_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_049) { NPC_AI.NPC049_CurrentNumLocation = 10; NPC_AI.NPC049_LastLocation = 10; NPC_AI.NPC049_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC049_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_050) { NPC_AI.NPC050_CurrentNumLocation = 10; NPC_AI.NPC050_LastLocation = 10; NPC_AI.NPC050_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC050_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_051) { NPC_AI.NPC051_CurrentNumLocation = 10; NPC_AI.NPC051_LastLocation = 10; NPC_AI.NPC051_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC051_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_052) { NPC_AI.NPC052_CurrentNumLocation = 10; NPC_AI.NPC052_LastLocation = 10; NPC_AI.NPC052_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC052_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_053) { NPC_AI.NPC053_CurrentNumLocation = 10; NPC_AI.NPC053_LastLocation = 10; NPC_AI.NPC053_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC053_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_054) { NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.NPC054_LastLocation = 10; NPC_AI.NPC054_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC054_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_055) { NPC_AI.NPC055_CurrentNumLocation = 10; NPC_AI.NPC055_LastLocation = 10; NPC_AI.NPC055_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC055_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_056) { NPC_AI.NPC056_CurrentNumLocation = 10; NPC_AI.NPC056_LastLocation = 10; NPC_AI.NPC056_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC056_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_057) { NPC_AI.NPC057_CurrentNumLocation = 10; NPC_AI.NPC057_LastLocation = 10; NPC_AI.NPC057_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC057_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_058) { NPC_AI.NPC058_CurrentNumLocation = 10; NPC_AI.NPC058_LastLocation = 10; NPC_AI.NPC058_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC058_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_059) { NPC_AI.NPC059_CurrentNumLocation = 10; NPC_AI.NPC059_LastLocation = 10; NPC_AI.NPC059_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC059_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_060) { NPC_AI.NPC060_CurrentNumLocation = 10; NPC_AI.NPC060_LastLocation = 10; NPC_AI.NPC060_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC060_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_061) { NPC_AI.NPC061_CurrentNumLocation = 10; NPC_AI.NPC061_LastLocation = 10; NPC_AI.NPC061_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC061_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_062) { NPC_AI.NPC062_CurrentNumLocation = 10; NPC_AI.NPC062_LastLocation = 10; NPC_AI.NPC062_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC062_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_063) { NPC_AI.NPC063_CurrentNumLocation = 10; NPC_AI.NPC063_LastLocation = 10; NPC_AI.NPC063_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC063_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_064) { NPC_AI.NPC064_CurrentNumLocation = 10; NPC_AI.NPC064_LastLocation = 10; NPC_AI.NPC064_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC064_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_065) { NPC_AI.NPC065_CurrentNumLocation = 10; NPC_AI.NPC065_LastLocation = 10; NPC_AI.NPC065_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC065_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_066) { NPC_AI.NPC066_CurrentNumLocation = 10; NPC_AI.NPC066_LastLocation = 10; NPC_AI.NPC066_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC066_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_067) { NPC_AI.NPC067_CurrentNumLocation = 10; NPC_AI.NPC067_LastLocation = 10; NPC_AI.NPC067_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC067_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_068) { NPC_AI.NPC068_CurrentNumLocation = 10; NPC_AI.NPC068_LastLocation = 10; NPC_AI.NPC068_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC068_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_069) { NPC_AI.NPC069_CurrentNumLocation = 10; NPC_AI.NPC069_LastLocation = 10; NPC_AI.NPC069_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC069_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_070) { NPC_AI.NPC070_CurrentNumLocation = 10; NPC_AI.NPC070_LastLocation = 10; NPC_AI.NPC070_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC070_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_071) { NPC_AI.NPC071_CurrentNumLocation = 10; NPC_AI.NPC071_LastLocation = 10; NPC_AI.NPC071_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC071_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_072) { NPC_AI.NPC072_CurrentNumLocation = 10; NPC_AI.NPC072_LastLocation = 10; NPC_AI.NPC072_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC072_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_073) { NPC_AI.NPC073_CurrentNumLocation = 10; NPC_AI.NPC073_LastLocation = 10; NPC_AI.NPC073_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC073_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_074) { NPC_AI.NPC074_CurrentNumLocation = 10; NPC_AI.NPC074_LastLocation = 10; NPC_AI.NPC074_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC074_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_075) { NPC_AI.NPC075_CurrentNumLocation = 10; NPC_AI.NPC075_LastLocation = 10; NPC_AI.NPC075_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC075_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_076) { NPC_AI.NPC076_CurrentNumLocation = 10; NPC_AI.NPC076_LastLocation = 10; NPC_AI.NPC076_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC076_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_077) { NPC_AI.NPC077_CurrentNumLocation = 10; NPC_AI.NPC077_LastLocation = 10; NPC_AI.NPC077_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC077_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_078) { NPC_AI.NPC078_CurrentNumLocation = 10; NPC_AI.NPC078_LastLocation = 10; NPC_AI.NPC078_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC078_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_079) { NPC_AI.NPC079_CurrentNumLocation = 10; NPC_AI.NPC079_LastLocation = 10; NPC_AI.NPC079_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC079_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_080) { NPC_AI.NPC080_CurrentNumLocation = 10; NPC_AI.NPC080_LastLocation = 10; NPC_AI.NPC080_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC080_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_081) { NPC_AI.NPC081_CurrentNumLocation = 10; NPC_AI.NPC081_LastLocation = 10; NPC_AI.NPC081_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC081_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_082) { NPC_AI.NPC082_CurrentNumLocation = 10; NPC_AI.NPC082_LastLocation = 10; NPC_AI.NPC082_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC082_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_083) { NPC_AI.NPC083_CurrentNumLocation = 10; NPC_AI.NPC083_LastLocation = 10; NPC_AI.NPC083_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC083_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_084) { NPC_AI.NPC084_CurrentNumLocation = 10; NPC_AI.NPC084_LastLocation = 10; NPC_AI.NPC084_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC084_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_085) { NPC_AI.NPC085_CurrentNumLocation = 10; NPC_AI.NPC085_LastLocation = 10; NPC_AI.NPC085_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC085_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_086) { NPC_AI.NPC086_CurrentNumLocation = 10; NPC_AI.NPC086_LastLocation = 10; NPC_AI.NPC086_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC086_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_087) { NPC_AI.NPC087_CurrentNumLocation = 10; NPC_AI.NPC087_LastLocation = 10; NPC_AI.NPC087_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC087_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_088) { NPC_AI.NPC088_CurrentNumLocation = 10; NPC_AI.NPC088_LastLocation = 10; NPC_AI.NPC088_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC088_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_089) { NPC_AI.NPC089_CurrentNumLocation = 10; NPC_AI.NPC089_LastLocation = 10; NPC_AI.NPC089_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC089_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_090) { NPC_AI.NPC090_CurrentNumLocation = 10; NPC_AI.NPC090_LastLocation = 10; NPC_AI.NPC090_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC090_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_091) { NPC_AI.NPC091_CurrentNumLocation = 10; NPC_AI.NPC091_LastLocation = 10; NPC_AI.NPC091_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC091_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_092) { NPC_AI.NPC092_CurrentNumLocation = 10; NPC_AI.NPC092_LastLocation = 10; NPC_AI.NPC092_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC092_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_093) { NPC_AI.NPC093_CurrentNumLocation = 10; NPC_AI.NPC093_LastLocation = 10; NPC_AI.NPC093_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC093_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_094) { NPC_AI.NPC094_CurrentNumLocation = 10; NPC_AI.NPC094_LastLocation = 10; NPC_AI.NPC094_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC094_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_095) { NPC_AI.NPC095_CurrentNumLocation = 10; NPC_AI.NPC095_LastLocation = 10; NPC_AI.NPC095_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC095_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_096) { NPC_AI.NPC096_CurrentNumLocation = 10; NPC_AI.NPC096_LastLocation = 10; NPC_AI.NPC096_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC096_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_097) { NPC_AI.NPC097_CurrentNumLocation = 10; NPC_AI.NPC097_LastLocation = 10; NPC_AI.NPC097_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC097_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_098) { NPC_AI.NPC098_CurrentNumLocation = 10; NPC_AI.NPC098_LastLocation = 10; NPC_AI.NPC098_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC098_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_099) { NPC_AI.NPC099_CurrentNumLocation = 10; NPC_AI.NPC099_LastLocation = 10; NPC_AI.NPC099_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC099_LastStrLocation = LocationEncounters.location_010; }
                if (Actor02 == NPC_AI.NPC_100) { NPC_AI.NPC100_CurrentNumLocation = 10; NPC_AI.NPC100_LastLocation = 10; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC100_LastStrLocation = LocationEncounters.location_010; }

                if (Actor03 == NPC_AI.NPC_001) { NPC_AI.NPC001_CurrentNumLocation = 10; NPC_AI.NPC001_LastLocation = 10; NPC_AI.NPC001_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC001_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_002) { NPC_AI.NPC002_CurrentNumLocation = 10; NPC_AI.NPC002_LastLocation = 10; NPC_AI.NPC002_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC002_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_003) { NPC_AI.NPC003_CurrentNumLocation = 10; NPC_AI.NPC003_LastLocation = 10; NPC_AI.NPC003_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC003_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_004) { NPC_AI.NPC004_CurrentNumLocation = 10; NPC_AI.NPC004_LastLocation = 10; NPC_AI.NPC004_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC004_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_005) { NPC_AI.NPC005_CurrentNumLocation = 10; NPC_AI.NPC005_LastLocation = 10; NPC_AI.NPC005_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC005_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_006) { NPC_AI.NPC006_CurrentNumLocation = 10; NPC_AI.NPC006_LastLocation = 10; NPC_AI.NPC006_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC006_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_007) { NPC_AI.NPC007_CurrentNumLocation = 10; NPC_AI.NPC007_LastLocation = 10; NPC_AI.NPC007_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC007_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_008) { NPC_AI.NPC008_CurrentNumLocation = 10; NPC_AI.NPC008_LastLocation = 10; NPC_AI.NPC008_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC008_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_009) { NPC_AI.NPC009_CurrentNumLocation = 10; NPC_AI.NPC009_LastLocation = 10; NPC_AI.NPC009_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC009_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_010) { NPC_AI.NPC010_CurrentNumLocation = 10; NPC_AI.NPC010_LastLocation = 10; NPC_AI.NPC010_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC010_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_011) { NPC_AI.NPC011_CurrentNumLocation = 10; NPC_AI.NPC011_LastLocation = 10; NPC_AI.NPC011_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC011_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_012) { NPC_AI.NPC012_CurrentNumLocation = 10; NPC_AI.NPC012_LastLocation = 10; NPC_AI.NPC012_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC012_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_013) { NPC_AI.NPC013_CurrentNumLocation = 10; NPC_AI.NPC013_LastLocation = 10; NPC_AI.NPC013_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC013_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_014) { NPC_AI.NPC014_CurrentNumLocation = 10; NPC_AI.NPC014_LastLocation = 10; NPC_AI.NPC014_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC014_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_015) { NPC_AI.NPC015_CurrentNumLocation = 10; NPC_AI.NPC015_LastLocation = 10; NPC_AI.NPC015_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC015_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_016) { NPC_AI.NPC016_CurrentNumLocation = 10; NPC_AI.NPC016_LastLocation = 10; NPC_AI.NPC016_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC016_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_017) { NPC_AI.NPC017_CurrentNumLocation = 10; NPC_AI.NPC017_LastLocation = 10; NPC_AI.NPC017_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC017_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_018) { NPC_AI.NPC018_CurrentNumLocation = 10; NPC_AI.NPC018_LastLocation = 10; NPC_AI.NPC018_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC018_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_019) { NPC_AI.NPC019_CurrentNumLocation = 10; NPC_AI.NPC019_LastLocation = 10; NPC_AI.NPC019_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC019_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_020) { NPC_AI.NPC020_CurrentNumLocation = 10; NPC_AI.NPC020_LastLocation = 10; NPC_AI.NPC020_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC020_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_021) { NPC_AI.NPC021_CurrentNumLocation = 10; NPC_AI.NPC021_LastLocation = 10; NPC_AI.NPC021_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC021_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_022) { NPC_AI.NPC022_CurrentNumLocation = 10; NPC_AI.NPC022_LastLocation = 10; NPC_AI.NPC022_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC022_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_023) { NPC_AI.NPC023_CurrentNumLocation = 10; NPC_AI.NPC023_LastLocation = 10; NPC_AI.NPC023_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC023_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_024) { NPC_AI.NPC024_CurrentNumLocation = 10; NPC_AI.NPC024_LastLocation = 10; NPC_AI.NPC024_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC024_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_025) { NPC_AI.NPC025_CurrentNumLocation = 10; NPC_AI.NPC025_LastLocation = 10; NPC_AI.NPC025_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC025_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_026) { NPC_AI.NPC026_CurrentNumLocation = 10; NPC_AI.NPC026_LastLocation = 10; NPC_AI.NPC026_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC026_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_027) { NPC_AI.NPC027_CurrentNumLocation = 10; NPC_AI.NPC027_LastLocation = 10; NPC_AI.NPC027_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC027_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_028) { NPC_AI.NPC028_CurrentNumLocation = 10; NPC_AI.NPC028_LastLocation = 10; NPC_AI.NPC028_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC028_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_029) { NPC_AI.NPC029_CurrentNumLocation = 10; NPC_AI.NPC029_LastLocation = 10; NPC_AI.NPC029_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC029_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_030) { NPC_AI.NPC030_CurrentNumLocation = 10; NPC_AI.NPC030_LastLocation = 10; NPC_AI.NPC030_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC030_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_031) { NPC_AI.NPC031_CurrentNumLocation = 10; NPC_AI.NPC031_LastLocation = 10; NPC_AI.NPC031_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC031_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_032) { NPC_AI.NPC032_CurrentNumLocation = 10; NPC_AI.NPC032_LastLocation = 10; NPC_AI.NPC032_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC032_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_033) { NPC_AI.NPC033_CurrentNumLocation = 10; NPC_AI.NPC033_LastLocation = 10; NPC_AI.NPC033_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC033_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_034) { NPC_AI.NPC034_CurrentNumLocation = 10; NPC_AI.NPC034_LastLocation = 10; NPC_AI.NPC034_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC034_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_035) { NPC_AI.NPC035_CurrentNumLocation = 10; NPC_AI.NPC035_LastLocation = 10; NPC_AI.NPC035_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC035_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_036) { NPC_AI.NPC036_CurrentNumLocation = 10; NPC_AI.NPC036_LastLocation = 10; NPC_AI.NPC036_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC036_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_037) { NPC_AI.NPC037_CurrentNumLocation = 10; NPC_AI.NPC037_LastLocation = 10; NPC_AI.NPC037_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC037_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_038) { NPC_AI.NPC038_CurrentNumLocation = 10; NPC_AI.NPC038_LastLocation = 10; NPC_AI.NPC038_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC038_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_039) { NPC_AI.NPC039_CurrentNumLocation = 10; NPC_AI.NPC039_LastLocation = 10; NPC_AI.NPC039_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC039_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_040) { NPC_AI.NPC040_CurrentNumLocation = 10; NPC_AI.NPC040_LastLocation = 10; NPC_AI.NPC040_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC040_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_041) { NPC_AI.NPC041_CurrentNumLocation = 10; NPC_AI.NPC041_LastLocation = 10; NPC_AI.NPC041_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC041_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_042) { NPC_AI.NPC042_CurrentNumLocation = 10; NPC_AI.NPC042_LastLocation = 10; NPC_AI.NPC042_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC042_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_043) { NPC_AI.NPC043_CurrentNumLocation = 10; NPC_AI.NPC043_LastLocation = 10; NPC_AI.NPC043_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC043_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_044) { NPC_AI.NPC044_CurrentNumLocation = 10; NPC_AI.NPC044_LastLocation = 10; NPC_AI.NPC044_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC044_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_045) { NPC_AI.NPC045_CurrentNumLocation = 10; NPC_AI.NPC045_LastLocation = 10; NPC_AI.NPC045_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC045_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_046) { NPC_AI.NPC046_CurrentNumLocation = 10; NPC_AI.NPC046_LastLocation = 10; NPC_AI.NPC046_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC046_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_047) { NPC_AI.NPC047_CurrentNumLocation = 10; NPC_AI.NPC047_LastLocation = 10; NPC_AI.NPC047_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC047_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_048) { NPC_AI.NPC048_CurrentNumLocation = 10; NPC_AI.NPC048_LastLocation = 10; NPC_AI.NPC048_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC048_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_049) { NPC_AI.NPC049_CurrentNumLocation = 10; NPC_AI.NPC049_LastLocation = 10; NPC_AI.NPC049_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC049_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_050) { NPC_AI.NPC050_CurrentNumLocation = 10; NPC_AI.NPC050_LastLocation = 10; NPC_AI.NPC050_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC050_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_051) { NPC_AI.NPC051_CurrentNumLocation = 10; NPC_AI.NPC051_LastLocation = 10; NPC_AI.NPC051_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC051_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_052) { NPC_AI.NPC052_CurrentNumLocation = 10; NPC_AI.NPC052_LastLocation = 10; NPC_AI.NPC052_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC052_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_053) { NPC_AI.NPC053_CurrentNumLocation = 10; NPC_AI.NPC053_LastLocation = 10; NPC_AI.NPC053_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC053_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_054) { NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.NPC054_LastLocation = 10; NPC_AI.NPC054_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC054_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_055) { NPC_AI.NPC055_CurrentNumLocation = 10; NPC_AI.NPC055_LastLocation = 10; NPC_AI.NPC055_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC055_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_056) { NPC_AI.NPC056_CurrentNumLocation = 10; NPC_AI.NPC056_LastLocation = 10; NPC_AI.NPC056_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC056_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_057) { NPC_AI.NPC057_CurrentNumLocation = 10; NPC_AI.NPC057_LastLocation = 10; NPC_AI.NPC057_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC057_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_058) { NPC_AI.NPC058_CurrentNumLocation = 10; NPC_AI.NPC058_LastLocation = 10; NPC_AI.NPC058_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC058_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_059) { NPC_AI.NPC059_CurrentNumLocation = 10; NPC_AI.NPC059_LastLocation = 10; NPC_AI.NPC059_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC059_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_060) { NPC_AI.NPC060_CurrentNumLocation = 10; NPC_AI.NPC060_LastLocation = 10; NPC_AI.NPC060_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC060_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_061) { NPC_AI.NPC061_CurrentNumLocation = 10; NPC_AI.NPC061_LastLocation = 10; NPC_AI.NPC061_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC061_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_062) { NPC_AI.NPC062_CurrentNumLocation = 10; NPC_AI.NPC062_LastLocation = 10; NPC_AI.NPC062_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC062_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_063) { NPC_AI.NPC063_CurrentNumLocation = 10; NPC_AI.NPC063_LastLocation = 10; NPC_AI.NPC063_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC063_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_064) { NPC_AI.NPC064_CurrentNumLocation = 10; NPC_AI.NPC064_LastLocation = 10; NPC_AI.NPC064_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC064_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_065) { NPC_AI.NPC065_CurrentNumLocation = 10; NPC_AI.NPC065_LastLocation = 10; NPC_AI.NPC065_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC065_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_066) { NPC_AI.NPC066_CurrentNumLocation = 10; NPC_AI.NPC066_LastLocation = 10; NPC_AI.NPC066_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC066_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_067) { NPC_AI.NPC067_CurrentNumLocation = 10; NPC_AI.NPC067_LastLocation = 10; NPC_AI.NPC067_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC067_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_068) { NPC_AI.NPC068_CurrentNumLocation = 10; NPC_AI.NPC068_LastLocation = 10; NPC_AI.NPC068_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC068_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_069) { NPC_AI.NPC069_CurrentNumLocation = 10; NPC_AI.NPC069_LastLocation = 10; NPC_AI.NPC069_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC069_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_070) { NPC_AI.NPC070_CurrentNumLocation = 10; NPC_AI.NPC070_LastLocation = 10; NPC_AI.NPC070_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC070_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_071) { NPC_AI.NPC071_CurrentNumLocation = 10; NPC_AI.NPC071_LastLocation = 10; NPC_AI.NPC071_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC071_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_072) { NPC_AI.NPC072_CurrentNumLocation = 10; NPC_AI.NPC072_LastLocation = 10; NPC_AI.NPC072_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC072_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_073) { NPC_AI.NPC073_CurrentNumLocation = 10; NPC_AI.NPC073_LastLocation = 10; NPC_AI.NPC073_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC073_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_074) { NPC_AI.NPC074_CurrentNumLocation = 10; NPC_AI.NPC074_LastLocation = 10; NPC_AI.NPC074_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC074_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_075) { NPC_AI.NPC075_CurrentNumLocation = 10; NPC_AI.NPC075_LastLocation = 10; NPC_AI.NPC075_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC075_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_076) { NPC_AI.NPC076_CurrentNumLocation = 10; NPC_AI.NPC076_LastLocation = 10; NPC_AI.NPC076_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC076_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_077) { NPC_AI.NPC077_CurrentNumLocation = 10; NPC_AI.NPC077_LastLocation = 10; NPC_AI.NPC077_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC077_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_078) { NPC_AI.NPC078_CurrentNumLocation = 10; NPC_AI.NPC078_LastLocation = 10; NPC_AI.NPC078_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC078_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_079) { NPC_AI.NPC079_CurrentNumLocation = 10; NPC_AI.NPC079_LastLocation = 10; NPC_AI.NPC079_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC079_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_080) { NPC_AI.NPC080_CurrentNumLocation = 10; NPC_AI.NPC080_LastLocation = 10; NPC_AI.NPC080_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC080_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_081) { NPC_AI.NPC081_CurrentNumLocation = 10; NPC_AI.NPC081_LastLocation = 10; NPC_AI.NPC081_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC081_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_082) { NPC_AI.NPC082_CurrentNumLocation = 10; NPC_AI.NPC082_LastLocation = 10; NPC_AI.NPC082_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC082_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_083) { NPC_AI.NPC083_CurrentNumLocation = 10; NPC_AI.NPC083_LastLocation = 10; NPC_AI.NPC083_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC083_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_084) { NPC_AI.NPC084_CurrentNumLocation = 10; NPC_AI.NPC084_LastLocation = 10; NPC_AI.NPC084_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC084_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_085) { NPC_AI.NPC085_CurrentNumLocation = 10; NPC_AI.NPC085_LastLocation = 10; NPC_AI.NPC085_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC085_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_086) { NPC_AI.NPC086_CurrentNumLocation = 10; NPC_AI.NPC086_LastLocation = 10; NPC_AI.NPC086_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC086_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_087) { NPC_AI.NPC087_CurrentNumLocation = 10; NPC_AI.NPC087_LastLocation = 10; NPC_AI.NPC087_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC087_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_088) { NPC_AI.NPC088_CurrentNumLocation = 10; NPC_AI.NPC088_LastLocation = 10; NPC_AI.NPC088_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC088_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_089) { NPC_AI.NPC089_CurrentNumLocation = 10; NPC_AI.NPC089_LastLocation = 10; NPC_AI.NPC089_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC089_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_090) { NPC_AI.NPC090_CurrentNumLocation = 10; NPC_AI.NPC090_LastLocation = 10; NPC_AI.NPC090_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC090_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_091) { NPC_AI.NPC091_CurrentNumLocation = 10; NPC_AI.NPC091_LastLocation = 10; NPC_AI.NPC091_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC091_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_092) { NPC_AI.NPC092_CurrentNumLocation = 10; NPC_AI.NPC092_LastLocation = 10; NPC_AI.NPC092_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC092_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_093) { NPC_AI.NPC093_CurrentNumLocation = 10; NPC_AI.NPC093_LastLocation = 10; NPC_AI.NPC093_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC093_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_094) { NPC_AI.NPC094_CurrentNumLocation = 10; NPC_AI.NPC094_LastLocation = 10; NPC_AI.NPC094_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC094_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_095) { NPC_AI.NPC095_CurrentNumLocation = 10; NPC_AI.NPC095_LastLocation = 10; NPC_AI.NPC095_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC095_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_096) { NPC_AI.NPC096_CurrentNumLocation = 10; NPC_AI.NPC096_LastLocation = 10; NPC_AI.NPC096_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC096_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_097) { NPC_AI.NPC097_CurrentNumLocation = 10; NPC_AI.NPC097_LastLocation = 10; NPC_AI.NPC097_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC097_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_098) { NPC_AI.NPC098_CurrentNumLocation = 10; NPC_AI.NPC098_LastLocation = 10; NPC_AI.NPC098_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC098_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_099) { NPC_AI.NPC099_CurrentNumLocation = 10; NPC_AI.NPC099_LastLocation = 10; NPC_AI.NPC099_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC099_LastStrLocation = LocationEncounters.location_010; }
                if (Actor03 == NPC_AI.NPC_100) { NPC_AI.NPC100_CurrentNumLocation = 10; NPC_AI.NPC100_LastLocation = 10; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC100_LastStrLocation = LocationEncounters.location_010; }

                if (Actor04 == NPC_AI.NPC_001) { NPC_AI.NPC001_CurrentNumLocation = 10; NPC_AI.NPC001_LastLocation = 10; NPC_AI.NPC001_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC001_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_002) { NPC_AI.NPC002_CurrentNumLocation = 10; NPC_AI.NPC002_LastLocation = 10; NPC_AI.NPC002_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC002_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_003) { NPC_AI.NPC003_CurrentNumLocation = 10; NPC_AI.NPC003_LastLocation = 10; NPC_AI.NPC003_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC003_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_004) { NPC_AI.NPC004_CurrentNumLocation = 10; NPC_AI.NPC004_LastLocation = 10; NPC_AI.NPC004_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC004_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_005) { NPC_AI.NPC005_CurrentNumLocation = 10; NPC_AI.NPC005_LastLocation = 10; NPC_AI.NPC005_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC005_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_006) { NPC_AI.NPC006_CurrentNumLocation = 10; NPC_AI.NPC006_LastLocation = 10; NPC_AI.NPC006_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC006_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_007) { NPC_AI.NPC007_CurrentNumLocation = 10; NPC_AI.NPC007_LastLocation = 10; NPC_AI.NPC007_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC007_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_008) { NPC_AI.NPC008_CurrentNumLocation = 10; NPC_AI.NPC008_LastLocation = 10; NPC_AI.NPC008_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC008_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_009) { NPC_AI.NPC009_CurrentNumLocation = 10; NPC_AI.NPC009_LastLocation = 10; NPC_AI.NPC009_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC009_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_010) { NPC_AI.NPC010_CurrentNumLocation = 10; NPC_AI.NPC010_LastLocation = 10; NPC_AI.NPC010_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC010_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_011) { NPC_AI.NPC011_CurrentNumLocation = 10; NPC_AI.NPC011_LastLocation = 10; NPC_AI.NPC011_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC011_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_012) { NPC_AI.NPC012_CurrentNumLocation = 10; NPC_AI.NPC012_LastLocation = 10; NPC_AI.NPC012_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC012_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_013) { NPC_AI.NPC013_CurrentNumLocation = 10; NPC_AI.NPC013_LastLocation = 10; NPC_AI.NPC013_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC013_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_014) { NPC_AI.NPC014_CurrentNumLocation = 10; NPC_AI.NPC014_LastLocation = 10; NPC_AI.NPC014_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC014_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_015) { NPC_AI.NPC015_CurrentNumLocation = 10; NPC_AI.NPC015_LastLocation = 10; NPC_AI.NPC015_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC015_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_016) { NPC_AI.NPC016_CurrentNumLocation = 10; NPC_AI.NPC016_LastLocation = 10; NPC_AI.NPC016_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC016_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_017) { NPC_AI.NPC017_CurrentNumLocation = 10; NPC_AI.NPC017_LastLocation = 10; NPC_AI.NPC017_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC017_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_018) { NPC_AI.NPC018_CurrentNumLocation = 10; NPC_AI.NPC018_LastLocation = 10; NPC_AI.NPC018_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC018_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_019) { NPC_AI.NPC019_CurrentNumLocation = 10; NPC_AI.NPC019_LastLocation = 10; NPC_AI.NPC019_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC019_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_020) { NPC_AI.NPC020_CurrentNumLocation = 10; NPC_AI.NPC020_LastLocation = 10; NPC_AI.NPC020_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC020_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_021) { NPC_AI.NPC021_CurrentNumLocation = 10; NPC_AI.NPC021_LastLocation = 10; NPC_AI.NPC021_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC021_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_022) { NPC_AI.NPC022_CurrentNumLocation = 10; NPC_AI.NPC022_LastLocation = 10; NPC_AI.NPC022_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC022_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_023) { NPC_AI.NPC023_CurrentNumLocation = 10; NPC_AI.NPC023_LastLocation = 10; NPC_AI.NPC023_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC023_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_024) { NPC_AI.NPC024_CurrentNumLocation = 10; NPC_AI.NPC024_LastLocation = 10; NPC_AI.NPC024_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC024_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_025) { NPC_AI.NPC025_CurrentNumLocation = 10; NPC_AI.NPC025_LastLocation = 10; NPC_AI.NPC025_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC025_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_026) { NPC_AI.NPC026_CurrentNumLocation = 10; NPC_AI.NPC026_LastLocation = 10; NPC_AI.NPC026_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC026_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_027) { NPC_AI.NPC027_CurrentNumLocation = 10; NPC_AI.NPC027_LastLocation = 10; NPC_AI.NPC027_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC027_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_028) { NPC_AI.NPC028_CurrentNumLocation = 10; NPC_AI.NPC028_LastLocation = 10; NPC_AI.NPC028_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC028_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_029) { NPC_AI.NPC029_CurrentNumLocation = 10; NPC_AI.NPC029_LastLocation = 10; NPC_AI.NPC029_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC029_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_030) { NPC_AI.NPC030_CurrentNumLocation = 10; NPC_AI.NPC030_LastLocation = 10; NPC_AI.NPC030_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC030_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_031) { NPC_AI.NPC031_CurrentNumLocation = 10; NPC_AI.NPC031_LastLocation = 10; NPC_AI.NPC031_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC031_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_032) { NPC_AI.NPC032_CurrentNumLocation = 10; NPC_AI.NPC032_LastLocation = 10; NPC_AI.NPC032_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC032_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_033) { NPC_AI.NPC033_CurrentNumLocation = 10; NPC_AI.NPC033_LastLocation = 10; NPC_AI.NPC033_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC033_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_034) { NPC_AI.NPC034_CurrentNumLocation = 10; NPC_AI.NPC034_LastLocation = 10; NPC_AI.NPC034_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC034_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_035) { NPC_AI.NPC035_CurrentNumLocation = 10; NPC_AI.NPC035_LastLocation = 10; NPC_AI.NPC035_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC035_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_036) { NPC_AI.NPC036_CurrentNumLocation = 10; NPC_AI.NPC036_LastLocation = 10; NPC_AI.NPC036_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC036_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_037) { NPC_AI.NPC037_CurrentNumLocation = 10; NPC_AI.NPC037_LastLocation = 10; NPC_AI.NPC037_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC037_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_038) { NPC_AI.NPC038_CurrentNumLocation = 10; NPC_AI.NPC038_LastLocation = 10; NPC_AI.NPC038_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC038_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_039) { NPC_AI.NPC039_CurrentNumLocation = 10; NPC_AI.NPC039_LastLocation = 10; NPC_AI.NPC039_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC039_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_040) { NPC_AI.NPC040_CurrentNumLocation = 10; NPC_AI.NPC040_LastLocation = 10; NPC_AI.NPC040_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC040_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_041) { NPC_AI.NPC041_CurrentNumLocation = 10; NPC_AI.NPC041_LastLocation = 10; NPC_AI.NPC041_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC041_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_042) { NPC_AI.NPC042_CurrentNumLocation = 10; NPC_AI.NPC042_LastLocation = 10; NPC_AI.NPC042_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC042_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_043) { NPC_AI.NPC043_CurrentNumLocation = 10; NPC_AI.NPC043_LastLocation = 10; NPC_AI.NPC043_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC043_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_044) { NPC_AI.NPC044_CurrentNumLocation = 10; NPC_AI.NPC044_LastLocation = 10; NPC_AI.NPC044_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC044_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_045) { NPC_AI.NPC045_CurrentNumLocation = 10; NPC_AI.NPC045_LastLocation = 10; NPC_AI.NPC045_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC045_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_046) { NPC_AI.NPC046_CurrentNumLocation = 10; NPC_AI.NPC046_LastLocation = 10; NPC_AI.NPC046_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC046_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_047) { NPC_AI.NPC047_CurrentNumLocation = 10; NPC_AI.NPC047_LastLocation = 10; NPC_AI.NPC047_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC047_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_048) { NPC_AI.NPC048_CurrentNumLocation = 10; NPC_AI.NPC048_LastLocation = 10; NPC_AI.NPC048_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC048_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_049) { NPC_AI.NPC049_CurrentNumLocation = 10; NPC_AI.NPC049_LastLocation = 10; NPC_AI.NPC049_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC049_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_050) { NPC_AI.NPC050_CurrentNumLocation = 10; NPC_AI.NPC050_LastLocation = 10; NPC_AI.NPC050_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC050_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_051) { NPC_AI.NPC051_CurrentNumLocation = 10; NPC_AI.NPC051_LastLocation = 10; NPC_AI.NPC051_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC051_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_052) { NPC_AI.NPC052_CurrentNumLocation = 10; NPC_AI.NPC052_LastLocation = 10; NPC_AI.NPC052_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC052_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_053) { NPC_AI.NPC053_CurrentNumLocation = 10; NPC_AI.NPC053_LastLocation = 10; NPC_AI.NPC053_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC053_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_054) { NPC_AI.NPC054_CurrentNumLocation = 10; NPC_AI.NPC054_LastLocation = 10; NPC_AI.NPC054_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC054_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_055) { NPC_AI.NPC055_CurrentNumLocation = 10; NPC_AI.NPC055_LastLocation = 10; NPC_AI.NPC055_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC055_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_056) { NPC_AI.NPC056_CurrentNumLocation = 10; NPC_AI.NPC056_LastLocation = 10; NPC_AI.NPC056_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC056_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_057) { NPC_AI.NPC057_CurrentNumLocation = 10; NPC_AI.NPC057_LastLocation = 10; NPC_AI.NPC057_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC057_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_058) { NPC_AI.NPC058_CurrentNumLocation = 10; NPC_AI.NPC058_LastLocation = 10; NPC_AI.NPC058_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC058_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_059) { NPC_AI.NPC059_CurrentNumLocation = 10; NPC_AI.NPC059_LastLocation = 10; NPC_AI.NPC059_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC059_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_060) { NPC_AI.NPC060_CurrentNumLocation = 10; NPC_AI.NPC060_LastLocation = 10; NPC_AI.NPC060_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC060_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_061) { NPC_AI.NPC061_CurrentNumLocation = 10; NPC_AI.NPC061_LastLocation = 10; NPC_AI.NPC061_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC061_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_062) { NPC_AI.NPC062_CurrentNumLocation = 10; NPC_AI.NPC062_LastLocation = 10; NPC_AI.NPC062_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC062_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_063) { NPC_AI.NPC063_CurrentNumLocation = 10; NPC_AI.NPC063_LastLocation = 10; NPC_AI.NPC063_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC063_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_064) { NPC_AI.NPC064_CurrentNumLocation = 10; NPC_AI.NPC064_LastLocation = 10; NPC_AI.NPC064_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC064_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_065) { NPC_AI.NPC065_CurrentNumLocation = 10; NPC_AI.NPC065_LastLocation = 10; NPC_AI.NPC065_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC065_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_066) { NPC_AI.NPC066_CurrentNumLocation = 10; NPC_AI.NPC066_LastLocation = 10; NPC_AI.NPC066_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC066_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_067) { NPC_AI.NPC067_CurrentNumLocation = 10; NPC_AI.NPC067_LastLocation = 10; NPC_AI.NPC067_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC067_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_068) { NPC_AI.NPC068_CurrentNumLocation = 10; NPC_AI.NPC068_LastLocation = 10; NPC_AI.NPC068_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC068_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_069) { NPC_AI.NPC069_CurrentNumLocation = 10; NPC_AI.NPC069_LastLocation = 10; NPC_AI.NPC069_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC069_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_070) { NPC_AI.NPC070_CurrentNumLocation = 10; NPC_AI.NPC070_LastLocation = 10; NPC_AI.NPC070_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC070_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_071) { NPC_AI.NPC071_CurrentNumLocation = 10; NPC_AI.NPC071_LastLocation = 10; NPC_AI.NPC071_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC071_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_072) { NPC_AI.NPC072_CurrentNumLocation = 10; NPC_AI.NPC072_LastLocation = 10; NPC_AI.NPC072_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC072_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_073) { NPC_AI.NPC073_CurrentNumLocation = 10; NPC_AI.NPC073_LastLocation = 10; NPC_AI.NPC073_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC073_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_074) { NPC_AI.NPC074_CurrentNumLocation = 10; NPC_AI.NPC074_LastLocation = 10; NPC_AI.NPC074_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC074_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_075) { NPC_AI.NPC075_CurrentNumLocation = 10; NPC_AI.NPC075_LastLocation = 10; NPC_AI.NPC075_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC075_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_076) { NPC_AI.NPC076_CurrentNumLocation = 10; NPC_AI.NPC076_LastLocation = 10; NPC_AI.NPC076_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC076_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_077) { NPC_AI.NPC077_CurrentNumLocation = 10; NPC_AI.NPC077_LastLocation = 10; NPC_AI.NPC077_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC077_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_078) { NPC_AI.NPC078_CurrentNumLocation = 10; NPC_AI.NPC078_LastLocation = 10; NPC_AI.NPC078_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC078_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_079) { NPC_AI.NPC079_CurrentNumLocation = 10; NPC_AI.NPC079_LastLocation = 10; NPC_AI.NPC079_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC079_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_080) { NPC_AI.NPC080_CurrentNumLocation = 10; NPC_AI.NPC080_LastLocation = 10; NPC_AI.NPC080_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC080_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_081) { NPC_AI.NPC081_CurrentNumLocation = 10; NPC_AI.NPC081_LastLocation = 10; NPC_AI.NPC081_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC081_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_082) { NPC_AI.NPC082_CurrentNumLocation = 10; NPC_AI.NPC082_LastLocation = 10; NPC_AI.NPC082_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC082_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_083) { NPC_AI.NPC083_CurrentNumLocation = 10; NPC_AI.NPC083_LastLocation = 10; NPC_AI.NPC083_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC083_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_084) { NPC_AI.NPC084_CurrentNumLocation = 10; NPC_AI.NPC084_LastLocation = 10; NPC_AI.NPC084_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC084_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_085) { NPC_AI.NPC085_CurrentNumLocation = 10; NPC_AI.NPC085_LastLocation = 10; NPC_AI.NPC085_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC085_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_086) { NPC_AI.NPC086_CurrentNumLocation = 10; NPC_AI.NPC086_LastLocation = 10; NPC_AI.NPC086_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC086_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_087) { NPC_AI.NPC087_CurrentNumLocation = 10; NPC_AI.NPC087_LastLocation = 10; NPC_AI.NPC087_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC087_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_088) { NPC_AI.NPC088_CurrentNumLocation = 10; NPC_AI.NPC088_LastLocation = 10; NPC_AI.NPC088_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC088_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_089) { NPC_AI.NPC089_CurrentNumLocation = 10; NPC_AI.NPC089_LastLocation = 10; NPC_AI.NPC089_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC089_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_090) { NPC_AI.NPC090_CurrentNumLocation = 10; NPC_AI.NPC090_LastLocation = 10; NPC_AI.NPC090_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC090_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_091) { NPC_AI.NPC091_CurrentNumLocation = 10; NPC_AI.NPC091_LastLocation = 10; NPC_AI.NPC091_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC091_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_092) { NPC_AI.NPC092_CurrentNumLocation = 10; NPC_AI.NPC092_LastLocation = 10; NPC_AI.NPC092_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC092_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_093) { NPC_AI.NPC093_CurrentNumLocation = 10; NPC_AI.NPC093_LastLocation = 10; NPC_AI.NPC093_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC093_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_094) { NPC_AI.NPC094_CurrentNumLocation = 10; NPC_AI.NPC094_LastLocation = 10; NPC_AI.NPC094_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC094_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_095) { NPC_AI.NPC095_CurrentNumLocation = 10; NPC_AI.NPC095_LastLocation = 10; NPC_AI.NPC095_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC095_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_096) { NPC_AI.NPC096_CurrentNumLocation = 10; NPC_AI.NPC096_LastLocation = 10; NPC_AI.NPC096_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC096_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_097) { NPC_AI.NPC097_CurrentNumLocation = 10; NPC_AI.NPC097_LastLocation = 10; NPC_AI.NPC097_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC097_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_098) { NPC_AI.NPC098_CurrentNumLocation = 10; NPC_AI.NPC098_LastLocation = 10; NPC_AI.NPC098_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC098_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_099) { NPC_AI.NPC099_CurrentNumLocation = 10; NPC_AI.NPC099_LastLocation = 10; NPC_AI.NPC099_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC099_LastStrLocation = LocationEncounters.location_010; }
                if (Actor04 == NPC_AI.NPC_100) { NPC_AI.NPC100_CurrentNumLocation = 10; NPC_AI.NPC100_LastLocation = 10; NPC_AI.NPC100_CurrentStrLocation = LocationEncounters.location_010; NPC_AI.NPC100_LastStrLocation = LocationEncounters.location_010; }

                Console.Clear();
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Console.ForegroundColor = ConsoleColor.Gray;
                bTempCorpse02 = true;
                bTempCorpse06 = true;
                Lists.RemainingNPCs.Remove(Actor02);
                Lists.RemainingNPCs.Remove(Actor06);
                Variables.sGetLocation = LocationEncounters.location_010; Variables.iCurrentLocation = 10; // move the player

                Console.WriteLine("A scream for help pierces the night's calm. It's close by, and draws you -- and");
                Console.WriteLine("others. At the lighthouse, " + Actor01 + ", swaying precariously, points a");
                Console.WriteLine("shaking finger at " + Actor02 + ". When " + NPC_AI.sGenderHeShe02 + " takes a step toward " + NPC_AI.sGenderHimHer01 + ", " + NPC_AI.sGenderHeShe01);
                Console.WriteLine("yells again. As people arrive, they look to one another, uncertain.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("'I saw! I saw you talking with " + Actor06 + ",' " + NPC_AI.sGenderHeShe01 + " says, pointing down to " + NPC_AI.sGenderHisHer06);
                Console.WriteLine("corpse. 'I saw you touch your hand to " + NPC_AI.sGenderHisHer06 + " back. You looked around to");
                Console.WriteLine("see if anyone saw. You thought no one did. But I saw! I saw you! I saw");
                Console.WriteLine("the devil's lightning take " + NPC_AI.sGenderHimHer06 + " away at your behest.'");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("'I know " + Actor02 + ",' says " + Actor04 + " as " + NPC_AI.sGenderHeShe04 + " steps toward " + Actor01 + ". 'And this");
                Console.WriteLine("isn't the first time " + NPC_AI.sGenderHeShe02 + "'s killed.' " + Actor02 + " responds with a look of sadness.");
                Console.WriteLine("'I was a kid then. And it was a mistake. I'm not that person anymore.'");
                Console.WriteLine("'What about your brother Tommy?' asks " + Actor03 + ". 'He needed your help.");
                Console.WriteLine("And when you turned him aside, he killed himself.' " + Actor02 + " looks");
                Console.WriteLine("flustered. And angry. 'Don't talk to me about my brother. You know --'");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("'Stop,' yells " + Actor01 + ". 'Stop talking. I see your guilt, and you can't escape");
                Console.WriteLine("it. We won't let you.' At that, " + Actor03 + " and " + Actor04 + ", along with " + Actor01 + ",");
                Console.WriteLine("rush toward " + Actor02 + ".");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You want to look away but you can't, even when " + Actor02 + " is begging for");
                Console.WriteLine("mercy. When they're sure " + Actor02 + " is dead, one at a time they stand up");
                Console.WriteLine("and back away from " + NPC_AI.sGenderHimHer02 + ". 'You'll see,' " + Actor01 + " says to the onlookers.");
                Console.WriteLine("'You'll see. I saved you all. Show some gratitude.'");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("The words are punctuated by a red flash so dark that it seems to absorb ");
                Console.WriteLine("what little light there is. A tendril of neon-red lightning arcs to the");
                Console.WriteLine("ground, perhaps a half-dozen blocks away, and is immediately after");
                Console.WriteLine("followed by the low booming sound of thunder. As the sound slowly");
                Console.WriteLine("fades away, " + Actor01 + " drops to " + NPC_AI.sGenderHisHer01 + " knees and begins sobbing.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("If this murder didn't stop the lightning, is it because the idea of marking");
                Console.WriteLine("people for death is ridiculous? Or is it because the wrong person died?");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                bNewEncounterRandom = true;
            }
        }

        public static void Run_RandomEncounter02()
        {
            if (!bRandEncounter2 && iRandEncounter == 2 && Lists.TalkingNPCs.Count > 0 && Lists.TheLocalDead.Count > 0) // Random Encounter #2
            {
                bRandEncounter2 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("As you are walking around the " + Variables.sStoryLocation + " area, you come across " + Actor01 + " going");
                Console.WriteLine("through the pockets of a corpse. " + Actor01 + " shrugs as you notice and " + NPC_AI.sGenderHeShe01 + " asks");
                Console.WriteLine("'Can you blame me? It's not like they need them anymore -- but we do.'");
                Console.WriteLine();
                Console.WriteLine(Actor01 + " continues. 'I have a proposition for you. Why don't you help me?");
                Console.WriteLine("I've found plenty of dead bodies. If we worked together, why, I bet we could");
                Console.WriteLine("find plenty of these MacGuffins. What do you say?'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. (Decline.) 'I'm not interested in helping you.'");
                Console.WriteLine("2. (Agree to help for 2 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine("3. (Agree to help for 4 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine("4. (Agree to help for 6 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine("5. (Ask for more information before deciding.) 'What are they for?'");
                Console.WriteLine();
                int GraveDiggerQ1 = 1;
                int GraveDiggerQ2 = 1;
                int.TryParse(Console.ReadLine(), out GraveDiggerQ1);
                if (GraveDiggerQ1 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " says, 'Maybe nothing. But these MacGuffins have to mean something.");
                    Console.WriteLine("Right? I think they must have to do with the strange happenings. The");
                    Console.WriteLine("MacGuffins weren't here before this started. Maybe they're the key. I aim");
                    Console.WriteLine("to get as many as I can, and then maybe I'll live to talk about it.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. (Decline.) 'I'm not interested in helping you.'");
                    Console.WriteLine("2. (Agree to help for 2 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                    Console.WriteLine("3. (Agree to help for 4 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                    Console.WriteLine("4. (Agree to help for 6 minutes.) 'Let's do it.'"); Variables.iRandEncounters = Variables.iRandEncounters + 1;
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine(), out GraveDiggerQ1);
                }
                if (GraveDiggerQ1 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " starts to say something, then stops. After a moment, " + NPC_AI.sGenderHeShe01 + " continues.");
                    Console.WriteLine("'Look, I know I'm in the wrong here. And I don't want to cause any trouble. I");
                    Console.WriteLine("don't. If you and me can be square, I'll go my own way and stay out of your hair.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. 'That sounds fine to me.'");
                    Console.WriteLine("2. 'I don't think so. People like you need to be put down.' (This option requires 2 minutes.)");
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine(), out GraveDiggerQ2);
                    if (GraveDiggerQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("'Thank you, pal. Like I said, I don't want any trouble. Live and let live.'");
                        iTempDesireToMove01 = iTempDesireToMove01 + 75;
                    }
                    if (GraveDiggerQ2 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("'I didn't ask for trouble, but I'm not going to lie down for you. I'm not yellow.'");
                        Console.WriteLine();
                        if (sTempWeapons01 != NPC_AI.sWeaponType0 && Variables.weaponName != NPC_AI.sWeaponType0) // Player and Actor have a weapon.
                        {
                            Console.WriteLine("Each of you ready your make-shift weapons and circle one another, looking");
                            Console.WriteLine("for an opening. A tense moment flashes by, then another. " + Actor01);
                            Console.WriteLine("says, quickly, 'We don't have to do this!' But before " + NPC_AI.sGenderHeShe01 + " can say anything more,");
                            Console.WriteLine("you spot your opening. You strike quickly, righteously, and lethally.");
                            Console.WriteLine();
                            Console.WriteLine("There's one less grave robber in the world.");
                            Variables.iRemainingTurns = Variables.iRemainingTurns - 2;
                            bTempCorpse01 = true; Variables.iAcciKilled++;
                            Lists.RemainingNPCs.Remove(Actor01);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   " + Actor01 + " is dead.");
                            Console.WriteLine("   Two minutes have passed.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (sTempWeapons01 == NPC_AI.sWeaponType0 && Variables.weaponName == NPC_AI.sWeaponType0) // Neither Player nor Actor have a weapon.
                        {
                            Console.WriteLine("The fight starts measured, relatively calm -- a jab here, a hook there.");
                            Console.WriteLine("But as " + Actor01 + " takes more hits, " + NPC_AI.sGenderHeShe01 + " panics, " + NPC_AI.sGenderHeShe01 + " kicks, " + NPC_AI.sGenderHeShe01 + " tries to bite.");
                            Console.WriteLine("Soon, the two of you are rolling around on the ground. Not long after,");
                            Console.WriteLine("your arms are wrapped firmly around " + NPC_AI.sGenderHisHer01 + " neck. " + Actor01 + " kicks and flails,");
                            Console.WriteLine("but not for long.");
                            Console.WriteLine();
                            Console.WriteLine("There's one less grave robber in the world.");
                            bTempCorpse01 = true; Variables.iAcciKilled++;
                            Lists.RemainingNPCs.Remove(Actor01);
                            Variables.iRemainingTurns = Variables.iRemainingTurns - 2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   " + Actor01 + " is dead.");
                            Console.WriteLine("   Two minutes have passed.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (sTempWeapons01 != NPC_AI.sWeaponType0 && Variables.weaponName == NPC_AI.sWeaponType0) // Only Actor has a weapon.
                        {
                            Console.WriteLine(Actor01 + " has a " + sTempWeapons01 + ", and you don't -- but that doesn't stop you from");
                            Console.WriteLine("feeling righteous anger course through your veins, from knowing that you");
                            Console.WriteLine("will put " + NPC_AI.sGenderHimHer01 + " down. " + Actor01 + " swings at you once, and then again. The words");
                            Console.WriteLine("'You disgust me' erupt from deep within you. " + Actor01 + " looks genuinely worried,");
                            Console.WriteLine("and throws down " + NPC_AI.sGenderHisHer01 + " " + sTempWeapons01 + " as " + NPC_AI.sGenderHeShe01 + " turns to run. Before " + NPC_AI.sGenderHeShe01 + " takes a step, you're");
                            Console.WriteLine("all over " + NPC_AI.sGenderHimHer01 + ". You slam " + NPC_AI.sGenderHimHer01 + " to the ground, and use " + NPC_AI.sGenderHisHer01 + " own " + sTempWeapons01 + " against " + NPC_AI.sGenderHimHer01 + ".");
                            Console.WriteLine();
                            Console.WriteLine("You don't stop until there's nothing remaining of the " + sTempWeapons01 + ", or " + Actor01 + ".");
                            bTempCorpse01 = true; Variables.iAcciKilled++;
                            Lists.RemainingNPCs.Remove(Actor01);
                            Variables.iRemainingTurns = Variables.iRemainingTurns - 2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   " + Actor01 + " is dead.");
                            Console.WriteLine("   Two minutes have passed.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        if (sTempWeapons01 == NPC_AI.sWeaponType0 && Variables.weaponName != NPC_AI.sWeaponType0) // Only Player has a weapon.
                        {
                            Console.WriteLine("You pull out your " + Variables.weaponName + ", and notice " + Actor01 + " tense. 'Hey, this is getting");
                            Console.WriteLine("a little too real, don't you think? Look, let's just say I'm wrong, and --");
                            Console.WriteLine("Oh, I know! I have some MacGuffins. You want them. Right? They're yours.");
                            Console.WriteLine("Just let me go. Let me walk away.' " + Actor01 + " looks like a thieving weasel to you");
                            Console.WriteLine("right now, but before you consider the merits of letting " + NPC_AI.sGenderHimHer01 + " go, you");
                            Console.WriteLine("remember how this situation started -- and realize there is only one way");
                            Console.WriteLine("to end it. " + Actor01 + " steps in closely, eyes looking down at the small pile of");
                            Console.WriteLine("MacGuffins in " + NPC_AI.sGenderHisHer01 + " hand. You hit " + Actor01 + " in the head as hard as you can,");
                            Console.WriteLine("and watch as " + NPC_AI.sGenderHeShe01 + " crumbles, arms thrown out, MacGuffins soaring through the night.");
                            Console.WriteLine();
                            Console.WriteLine("Defiling the dead? Bribery? Cowardice? Good riddance.");
                            bTempCorpse01 = true; Variables.iAcciKilled++;
                            Lists.RemainingNPCs.Remove(Actor01);
                            Variables.iRemainingTurns = Variables.iRemainingTurns - 2;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   " + Actor01 + " is dead.");
                            Console.WriteLine("   Two minutes have passed.");
                            Console.WriteLine("   Lost your " + Variables.weaponName + ".");
                            Variables.weaponName = NPC_AI.sWeaponType0;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }
                if (GraveDiggerQ1 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int lootedMacGuffins = Program.rand.Next(2, 4);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'I suppose I can spare a couple minutes to help,' you offer");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(Actor01 + " perks up. 'What a pal. Two minutes? Trust me, we'll find some.'");
                    Console.WriteLine("And while " + Actor01 + " is true to " + NPC_AI.sGenderHisHer01 + " word, you're not quite sure if the");
                    Console.WriteLine(lootedMacGuffins + " MacGuffins you found were worth it. " + Actor01 + " notices your disappointment");
                    Console.WriteLine("and says, 'That's " + lootedMacGuffins + " more than you had a couple minutes ago. Am I right?");
                    Console.WriteLine("Of course I am.' " + Actor01 + " is smiling. 'Some other time, pal?'");
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + lootedMacGuffins;
                    Variables.iRemainingTurns = Variables.iRemainingTurns - 2;
                    iTempLoyalty01 = iTempLoyalty01 + 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition increased by 1.");
                    Console.WriteLine("   Gained " + lootedMacGuffins + " MacGuffins.");
                    Console.WriteLine("   Two minutes have passed.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (GraveDiggerQ1 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int lootedMacGuffins = Program.rand.Next(6, 10);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You say, 'We can probably get most of the nearby corpses.'");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " perks up. 'What a pal. Trust me, just around here -- we'll find plenty.");
                    Console.WriteLine("And " + Actor01 + " is true to " + NPC_AI.sGenderHisHer01 + " word. Digging through the pockets of corpses isn't");
                    Console.WriteLine("the most pleasant experience, but the " + lootedMacGuffins + " MacGuffins you each found make it feel");
                    Console.WriteLine("worthwhile. 'Not a bad haul, if I do say so myself. And I do say,' " + NPC_AI.sGenderHeShe01 + " says,");
                    Console.WriteLine("with a wink. " + Actor01 + " is smiling. 'Some other time, pal. I mean it. You're a good one.'");
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + lootedMacGuffins;
                    iTempLoyalty01 = iTempLoyalty01 + 2;
                    Variables.iRemainingTurns = Variables.iRemainingTurns - 4;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition increased by 2.");
                    Console.WriteLine("   Gained " + lootedMacGuffins + " MacGuffins.");
                    Console.WriteLine("   Four minutes have passed.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (GraveDiggerQ1 == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    int lootedMacGuffins = Program.rand.Next(12, 17);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'Let's grab as much as we can,' you say.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " smiles. 'You have your head on straight, I'll tell you.");
                    Console.WriteLine("You really have me feeling excited, buddy. Let's make some MacGuffins.'");
                    Console.WriteLine("It isn't glamorous, but you find every nearby corpse and dig into every");
                    Console.WriteLine("pocket until there's nothing left to find. You and " + Actor01 + " split the findings");
                    Console.WriteLine("and you each walk away with " + lootedMacGuffins + " MacGuffins. We really hit the big time,");
                    Console.WriteLine("didn't we, pal? We really did.'" + Actor01 + " smiles at you.");
                    Console.WriteLine();
                    Console.WriteLine("'Maybe they don't matter much, these MacGuffins. What do I know? But you");
                    Console.WriteLine("took the time to help a stranger when you could have -- '" + Actor01 + " pauses.");
                    Console.WriteLine("'Considering how most folk look on this kind of activity, you could have done");
                    Console.WriteLine("about anything and no one would have said 'boo' about it. Is it weird to say");
                    Console.WriteLine("you put a little hope in my soul? You ever need help, you come find me.'");
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + lootedMacGuffins;
                    iTempLoyalty01 = 5;
                    Variables.iRemainingTurns = Variables.iRemainingTurns - 6;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition increased to maximum.");
                    Console.WriteLine("   Gained " + lootedMacGuffins + " MacGuffins.");
                    Console.WriteLine("   Six minutes have passed.");
                }
            }
        }

        public static void Run_RandomEncounter03()
        {
            if (!bRandEncounter3 && iRandEncounter == 3 && Lists.TalkingNPCs.Count >= 4) // Random Encounter #3
            {
                bRandEncounter3 = true;
                int iTooManyQ = 1;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                Console.WriteLine("You come across a small gathering of people. One person is dressed in");
                Console.WriteLine("an all-black outfit with a black ski-mask on. In white text on the shirt's");
                Console.WriteLine("front, it reads 'censored'. The person is holding a toy knife and stabbing");
                Console.WriteLine(Actor01 + ". The 'victim' is giving an overly-dramatic performance, a death");
                Console.WriteLine("scene to rival any of the greats. The others are laughing at the spectacle.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Watch the performance.");
                Console.WriteLine("2. Ask who the killer is.");
                Console.WriteLine("3. Ask why the killer's shirt has the word 'censored' on it.");
                Console.WriteLine("4. Ask about the victim.");
                Console.WriteLine("5. Ask why no one is stopping the killer.");
                Console.WriteLine("6. Ask why the killer is using a knife.");
                Console.WriteLine("7. Tell the people that this is morbid.");
                Console.WriteLine("8. Leave. (does not require a turn)");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                int iMurderPerformance = int.TryParse(Console.ReadLine(), out iMurderPerformance) ? iMurderPerformance : 10;
                while (iMurderPerformance != 8)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    if (iMurderPerformance == 1)
                    {
                        Console.WriteLine("You watch as " + Actor01 + ", the current victim, throws some red silk into the");
                        Console.WriteLine("air to represent blood before succumbing to death. There's a");
                        Console.WriteLine("round of applause -- quickly interrupted by the 'killer's' bloodlust;");
                        Console.WriteLine(Actor04 + " is grabbed, thrown to the ground, and mercilessly stabbed.");
                    }
                    if (iMurderPerformance == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Who is that playing the killer?' you ask.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'That's the point,' " + Actor02 + " says. 'Not to know. No one knows who the");
                        Console.WriteLine("actual killer is, so why should this recreation be any different?'");
                    }
                    if (iMurderPerformance == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Why does it say 'censored' on the shirt?");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine(Actor03 + " says, 'It's not just the word you're supposed to be looking at. It's");
                        Console.WriteLine("the whole outfit. It's like a giant censored bar -- the killer completely");
                        Console.WriteLine("covered in black. No one knows who the killer is. It's symbolic. But it");
                        Console.WriteLine("also expresses an artistic statement. It makes you think.");
                    }
                    if (iMurderPerformance == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Who plays the victims?' you ask.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("In unison, the assembled group says, 'We all do.' They laugh at how");
                        Console.WriteLine("well that came out. When the laughter slows, " + Actor03 + " says, 'the killer");
                        Console.WriteLine("picks one of us at random. When that victim dies, a new victim is picked");
                        Console.WriteLine("and the old victim goes back into the audience. We'll loop until... the end.'");
                    }
                    if (iMurderPerformance == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Why isn't anyone trying to stop the killer? Maybe you could create a");
                        Console.WriteLine("new story. Maybe it writes a new story in reality,' you suggest.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("There's silence for a moment, and it starts to feel awkward. Finally,");
                        Console.WriteLine(Actor04 + " says, 'We're trying to watch something here. It's its own thing.");
                        Console.WriteLine("We're not trying to re-write it. Anyway, this story speaks true to me,");
                        Console.WriteLine("and I like it just how it is.'");
                        Console.WriteLine();
                        Console.WriteLine(Actor01 + " pipes in with a 'well said' before everyone turns back to");
                        Console.WriteLine("watch another stretched out, hammed-up death.");
                    }
                    if (iMurderPerformance == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'The real killer doesn't use a knife -- if there even is a specific killer.");
                        Console.WriteLine("Seems like everyone who dies is hit by lightning.'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'You're a real buzz kill,' " + Actor02 + " says. The rest laugh. 'Use your");
                        Console.WriteLine("imagination, buddy. Pretend it's lightning, if you can handle that.'");
                    }
                    if (iMurderPerformance == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'This is morbid,' you say. 'Real people are dying, and you're doing this.'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'We're all going to die,' says " + Actor03 + ". 'And I don't mean that in the");
                        Console.WriteLine("casual sense. I mean it in the immediate. We've probably got a few");
                        Console.WriteLine("hours left. Maybe not even that much. This is how we're coming to grips");
                        Console.WriteLine("with that reality. Make light. Have fun. Be with friends.'");
                        Console.WriteLine();
                        Console.WriteLine("This elicits cheers from the others.");
                    }
                    if (iMurderPerformance > 8 || iMurderPerformance < 0)
                    {
                        Console.WriteLine("Please choose from 1 through 8.");
                    }
                    if (iTooManyQ == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Actor02 + " admonishes " + Actor01 + ". 'Oh, stop being rude. They're just");
                        Console.WriteLine("questions.' " + Actor01 + " says, 'yeah, you're right. I'm sorry. Go ahead.'");
                    }
                    Console.WriteLine();
                    Console.WriteLine("You are in the midst of a small gathering of performers.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("1. Watch the performance. (does not require a turn)");
                    Console.WriteLine("2. Ask who the killer is. (does not require a turn)");
                    Console.WriteLine("3. Ask what the killer's shirt has the word 'censored' on it. (does not require a turn)");
                    Console.WriteLine("4. Ask about the victim. (does not require a turn)");
                    Console.WriteLine("5. Ask why no one is stopping the killer. (does not require a turn)");
                    Console.WriteLine("6. Ask why the killer is using a knife. (does not require a turn)");
                    Console.WriteLine("7. Tell the people that this is morbid. (does not require a turn)");
                    Console.WriteLine("8. Leave. (does not require a turn)");
                    Console.WriteLine();
                    iTooManyQ++;
                    iMurderPerformance = int.TryParse(Console.ReadLine(), out iMurderPerformance) ? iMurderPerformance : 10;
                    if (iTooManyQ == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("The 'censored' figure stops mid-stab and walks over to you. The two of");
                        Console.WriteLine("you stand there for a moment. Then something like a voice -- a feeling");
                        Console.WriteLine("without words -- rises in your head");
                        Console.WriteLine();
                        Console.WriteLine("'Perhaps you see this performance as a reflection, and you ask");
                        Console.WriteLine("questions to understand things better. Tell me: what is it you seek to");
                        Console.WriteLine("learn? But before you answer, think things over carefully. What you say");
                        Console.WriteLine("could change everything. Then again, it might change nothing. What");
                        Console.WriteLine("happens next depends only on you.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1. 'I want to know why people are dying.' (does not require a turn)");
                        Console.WriteLine("2. 'I want to know how people are dying.' (does not require a turn)");
                        Console.WriteLine("3. 'I want to know what's behind the death.' (does not require a turn)");
                        Console.WriteLine("4. 'I want to know how to save people.' (does not require a turn)");
                        Console.WriteLine("5. 'I want to know how to save myself.' (does not require a turn)");
                        Console.WriteLine("6. 'I want to know who you are.' (does not require a turn)");
                        Console.WriteLine("7. 'I want to know why the waves are here.' (does not require a turn)");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        int iMurderPerformanceQ2 = int.TryParse(Console.ReadLine(), out iMurderPerformanceQ2) ? iMurderPerformanceQ2 : 1;
                        while (iMurderPerformanceQ2 > 7 || iMurderPerformanceQ2 < 1)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please choose from 1 through 7.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            iMurderPerformanceQ2 = int.TryParse(Console.ReadLine(), out iMurderPerformanceQ2) ? iMurderPerformanceQ2 : 1;
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (iMurderPerformanceQ2 == 1)
                        {
                            Console.WriteLine("'People are dying because they are being killed. They have been killed to");
                            Console.WriteLine("allow us to move this island from existence, to erase it from time. Were");
                            Console.WriteLine("those people still alive when the island was moved, those people would");
                            Console.WriteLine("be trapped in a place they do not belong.'");
                        }
                        if (iMurderPerformanceQ2 == 2)
                        {
                            Console.WriteLine("'One person on this island is not the same today as they were yesterday.");
                            Console.WriteLine("One person now touches a shoulder or whispers a word or sings a");
                            Console.WriteLine("lullaby to mark one for death. But if they are seen, they might be");
                            Console.WriteLine("stopped. And so this one must walk with great care.'");
                        }
                        if (iMurderPerformanceQ2 == 3)
                        {
                            Console.WriteLine("'What's behind anything is a matter of perspective. Where do you stand,");
                            Console.WriteLine("and where do they? From where you stand, I see mercy stands boldly");
                            Console.WriteLine("behind death. Mercy is never easy. It is never painless. But it saves one");
                            Console.WriteLine("from something worse. On its own it may mean little to you, but in full");
                            Console.WriteLine("context it answers your question completely.'");
                        }
                        if (iMurderPerformanceQ2 == 4)
                        {
                            Console.WriteLine("'To save people is to stand aside and allow things to play out according");
                            Console.WriteLine("to the plan. But what you mean is something different. What you want");
                            Console.WriteLine("requires quick, decisive action -- to stop the one who marks others for");
                            Console.WriteLine("death. But know that your success changes nothing meaningfully, and");
                            Console.WriteLine("risks eternity for those whose fates you choose to alter.'");
                        }
                        if (iMurderPerformanceQ2 == 5)
                        {
                            Console.WriteLine("'To save yourself is to leave this all behind. The warnings were given and");
                            Console.WriteLine("ignored, yet still they're given and will be until the end. Your concept of");
                            Console.WriteLine("time is running out, but in each moment there is eternity and");
                            Console.WriteLine("opportunity. Step through the walls that bind you, and you will be");
                            Console.WriteLine("allowed to pass -- provided the time is right and the price is met.'");
                        }
                        if (iMurderPerformanceQ2 == 6)
                        {
                            Console.WriteLine("'Me? I'm one of you, no different than " + Actor01 + " or " + Actor02 + ". My identity");
                            Console.WriteLine("is obscured only for the show. But you would know who I represent, and");
                            Console.WriteLine("I will answer that you ask for the one who walks amongst you and");
                            Console.WriteLine("marks you all for release. There is no other purpose than mercy at play.'");
                        }
                        if (iMurderPerformanceQ2 == 7)
                        {
                            Console.WriteLine("'The waves are here to hide what happens from a world which will not");
                            Console.WriteLine("understand. Soon they will be gone, and forgotten, as will this island.");
                            Console.WriteLine("But if the waves reach a person before the one who marks them, then");
                            Console.WriteLine("they will drown for all eternity -- trapped where they should not be.'");
                        }
                        Console.WriteLine("'And now your answer given, I return to my role.'");
                        Console.WriteLine();
                        Console.WriteLine("You lift your head with a jerk, as if you've been asleep all this time. The");
                        Console.WriteLine("censored being is still stabbing away, and it looks as though they may have");
                        Console.WriteLine("been stabbing all this time, not talking with you. The rest cheer at");
                        Console.WriteLine(Actor03 + "'s exaggerated death throes.");
                        if (!Title.bAchievement03)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Title.bAchievement03 = true;
                            Console.WriteLine("   Secret Discovered: " + Title.sAchievement03);
                        }
                        iMurderPerformance = 8;
                    }
                }
                if (iMurderPerformance == 8)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You decide to move on.");
                }
            }
        }

        public static void Run_RandomEncounter04()
        {
            if (!bRandEncounter4 && iRandEncounter == 4 && Lists.TalkingNPCs.Count >= 2) // Random Encounter #4
            {
                bRandEncounter4 = true;
                Variables.iTurnsSinceEncounter = 0;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                bEncounter = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                // Q1
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                Console.WriteLine("'Hello? Excuse me? " + Actor01 + ", KRBT TV News: the local news that");
                Console.WriteLine("matters. I was hoping you had time for a few questions? Do you mind?");
                Console.WriteLine("Thanks, we really appreciate this. It won't take a minute.'");
                Console.WriteLine();
                Console.WriteLine(Actor01 + " approaches you with a microphone in " + NPC_AI.sGenderHisHer01 + " hand. Standing");
                Console.WriteLine("slightly behind and to the side is " + Actor02 + ", who is pantomiming holding");
                Console.WriteLine("a video camera. Apparently, this imaginary camera is older. It seems to");
                Console.WriteLine("have a crank on its side that must slowly-but-continuously be turned.");
                Console.WriteLine();
                Console.WriteLine(Actor01 + " says, 'Our viewers are interested in finding out how people are");
                Console.WriteLine("handling things? What would you say the vibe on the street is?'");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. 'Cautious.'");
                Console.WriteLine("2. 'Optimistic.'");
                Console.WriteLine("3. 'Frightened.'");
                Console.WriteLine("4. 'Defiant.'");
                Console.WriteLine("5. 'Next question.'");
                Console.WriteLine();
                int iInterviewQ1 = int.TryParse(Console.ReadLine(), out iInterviewQ1) ? iInterviewQ1 : 5;
                while (iInterviewQ1 < 1 || iInterviewQ1 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("'I'm sorry, can you repeat that?");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iInterviewQ1 = int.TryParse(Console.ReadLine(), out iInterviewQ1) ? iInterviewQ1 : 5;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (iInterviewQ1 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " looks unaffected when you opt to pass on " + NPC_AI.sGenderHisHer01 + " first question.");
                    iTempLoyalty01 = iTempLoyalty01 - 1;
                    iTempLoyalty02 = iTempLoyalty02 - 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition reduced by 1.");
                    Console.WriteLine("   " + Actor02 + "'s disposition reduced by 1.");
                }
                if (iInterviewQ1 > 0 && iInterviewQ1 < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Hmm. Hmm. ... Hmm.'");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press any key when you're ready.)");
                Console.ReadKey();
                // Q2
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(Actor01 + " says, 'OK, great. You're doing great. Oh -- don't worry, we'll edit");
                Console.WriteLine("this little exchange out.' " + Actor02 + " shakes " + NPC_AI.sGenderHisHer02 + " head and mouths the");
                Console.WriteLine("words, 'We're live.' 'Oh dear,' " + Actor01 + " says. 'No one knows why the tidal");
                Console.WriteLine("waves have stopped moving. But surely they must, at some point,");
                Console.WriteLine("resume moving. When do you think that happens?'");
                Console.ForegroundColor = ConsoleColor.White;
                int InterviewGuess1 = Variables.iRemainingTurns - Variables.iTurn45;
                Console.WriteLine();
                Console.WriteLine("1. 'In " + InterviewGuess1 + " minutes.'");
                Console.WriteLine("2. 'In " + Variables.iRemainingTurns + " minutes.'");
                Console.WriteLine("3. 'Never.'");
                Console.WriteLine("4. 'But they're already moving.'");
                Console.WriteLine("5. 'Next question.'");
                Console.WriteLine();
                int iInterviewQ2 = int.TryParse(Console.ReadLine(), out iInterviewQ2) ? iInterviewQ2 : 5;
                while (iInterviewQ2 < 1 || iInterviewQ2 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("'I'm sorry, can you repeat that?'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iInterviewQ2 = int.TryParse(Console.ReadLine(), out iInterviewQ2) ? iInterviewQ2 : 5;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (iInterviewQ2 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " is momentarily flustered when you refuse " + NPC_AI.sGenderHisHer01 + " question, but");
                    Console.WriteLine("quickly collects " + NPC_AI.sGenderHimHer01 + "self.");
                    iTempLoyalty01 = iTempLoyalty01 - 1;
                    iTempLoyalty02 = iTempLoyalty02 - 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased by 1.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased by 1.");
                }
                if (iInterviewQ2 > 0 && iInterviewQ2 < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'That's quite interesting, and I'm sure our viewers will");
                    Console.WriteLine("agree that your predictions are sobering.'");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press any key when you're ready.)");
                Console.ReadKey();
                // Q3
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("'Now, we're receiving reports of bizarre weather patterns. Some have");
                Console.WriteLine("even spotted red r-e-d red lightning. That's not normal. Is it?'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. 'Two words: military. Experiments.'");
                Console.WriteLine("2. 'I don't think red-colored lightning existed prior to now.'");
                Console.WriteLine("3. 'The Japanese recently converted all their lightning to red.'");
                Console.WriteLine("4. 'No, it's not normal. But what is?'");
                Console.WriteLine("5. 'Next question.'");
                Console.WriteLine();
                int iInterviewQ3 = int.TryParse(Console.ReadLine(), out iInterviewQ3) ? iInterviewQ3 : 5;
                while (iInterviewQ3 < 1 || iInterviewQ3 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("'I'm sorry, can you repeat that?'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iInterviewQ3 = int.TryParse(Console.ReadLine(), out iInterviewQ3) ? iInterviewQ3 : 5;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (iInterviewQ3 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " says, 'I'm not letting you off the hook so easily next time.'");
                    iTempLoyalty01 = iTempLoyalty01 - 1;
                    iTempLoyalty02 = iTempLoyalty02 - 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased by 1.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased by 1.");
                }
                if (iInterviewQ3 > 0 && iInterviewQ3 < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Powerful. Quite thoughtful.'");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press any key when you're ready.)");
                Console.ReadKey();
                // Q4
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("'OK, great. You're doing grea -- sorry.' " + Actor02 + " grimaces. " + Actor01);
                Console.WriteLine("continues. 'We're hearing reports of casualties and strange behavior");
                Console.WriteLine("from people. Do you think the two are in any way related?'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. 'In my professional opinion, I offer a hesitant-but-forceful yes.'");
                Console.WriteLine("2. 'It's impossible to say without further study on the topic.'");
                Console.WriteLine("3. 'You noticed it, too? Whew, I was worried I was hallucinating.'");
                Console.WriteLine("4. 'Yes, people are dying. And acting strangely. These might be related.'");
                Console.WriteLine("5. 'Next question.'");
                Console.WriteLine();
                int iInterviewQ4 = int.TryParse(Console.ReadLine(), out iInterviewQ4) ? iInterviewQ4 : 5;
                while (iInterviewQ4 < 1 || iInterviewQ4 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("'I'm sorry, can you repeat that?'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iInterviewQ4 = int.TryParse(Console.ReadLine(), out iInterviewQ4) ? iInterviewQ4 : 5;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (iInterviewQ4 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'You're a slippery fish,' " + Actor01 + " says. 'Maybe you've got something to");
                    Console.WriteLine("hide? Maybe people should be suspicious of you. I'm not saying you're");
                    Console.WriteLine("a killer -- but a headline contemplating such a question isn't out of the");
                    Console.WriteLine("realm of possibility.'");
                    iTempLoyalty01 = iTempLoyalty01 - 1;
                    iTempLoyalty02 = iTempLoyalty02 - 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased by 1.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased by 1.");
                }
                if (iInterviewQ4 > 0 && iInterviewQ4 < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Mmm-hmm. Mmm.'");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Press any key when you're ready.)");
                Console.ReadKey();
                // Q5
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("'Our last question for you: What are these things that people call");
                Console.WriteLine("McMuffins? MacGuffins? Oh! Did I say McMuffin? I must be hungry.'");
                Console.WriteLine(Actor01 + " laughs. 'What are these things people call MacGuffins?'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. 'I'm not sure, but people use them as money now.'");
                Console.WriteLine("2. 'They look like antique wedges. I think they're magic.'");
                Console.WriteLine("3. 'People trade the strangest things.'");
                Console.WriteLine("4. 'Does the word 'cuneus' mean anything to you?'");
                Console.WriteLine("5. 'Next question.'");
                Console.WriteLine();
                int iInterviewQ5 = int.TryParse(Console.ReadLine(), out iInterviewQ5) ? iInterviewQ5 : 5;
                while (iInterviewQ5 < 1 || iInterviewQ5 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("'I'm sorry, can you repeat that?'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iInterviewQ5 = int.TryParse(Console.ReadLine(), out iInterviewQ5) ? iInterviewQ5 : 5;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                if (iInterviewQ5 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Well, aren't you a dud?' " + Actor01 + " looks perturbed, as does " + Actor02 + ".");
                    Console.WriteLine("'Guess what,' " + Actor01 + " says. 'There is no next question.'");
                    iTempLoyalty01 = iTempLoyalty01 - 1;
                    iTempLoyalty02 = iTempLoyalty02 - 1;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased by 1.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased by 1.");
                }
                if (iInterviewQ5 > 0 && iInterviewQ5 < 5)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Yes.'");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                Console.WriteLine("'We've been speaking with -- we never did catch your name -- but we've");
                Console.WriteLine("been speaking about what's on your mind, viewers, and we're going");
                Console.WriteLine("to the people to get the tough answers to your tough questions. Thanks");
                Console.WriteLine("for watching KRBT TV News: the local news that matters. " + Actor02 + " nods");
                Console.WriteLine("when " + Actor01 + " finishes speaking.");
                Console.WriteLine();
                Console.WriteLine("The duo walk off without saying goodbye.");
                if (iTempLoyalty01 < 0) { iTempLoyalty01 = 0; }
                if (iTempLoyalty02 < 0) { iTempLoyalty02 = 0; }
            }
        }

        public static void Run_RandomEncounter05()
        {
            if (!bRandEncounter5 && iRandEncounter == 5 && Lists.TalkingNPCs.Count == 0) // Random Encounter #5
            {
                bRandEncounter5 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                Console.WriteLine("Peering at you from a sheltered nook is a fox, its eyes glowing with");
                Console.WriteLine("reflected light. The fox's mouth is open, and it appears to be panting. As");
                Console.WriteLine("you watch, the fox calls out. 'Hey, if I come over there -- you won't hit");
                Console.WriteLine("me or anything, will you?'");
                Console.WriteLine();
                Console.WriteLine("Without waiting for an answer, the fox trots toward you. 'Sorry, times");
                Console.WriteLine("are tough right now and I'm a bit on edge. I didn't mean to be rude.'");
                Console.WriteLine();
                Console.WriteLine("The fox sits down a few feet away from you and yawns before focusing");
                Console.WriteLine("on you again. 'Hey, you mind if I ask you a question? See, I started up a");
                Console.WriteLine("church and attendance hasn't been very good yet. I'm trying to get the");
                Console.WriteLine("word out, but nothing seems to be sticking.'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Tell the fox to be persistent.");
                Console.WriteLine("2. Suggest word-of-mouth advertising.");
                Console.WriteLine("3. Suggest enticing followers.");
                Console.WriteLine("4. Suggest stealing followers.");
                Console.WriteLine("5. First ask about his beliefs.");
                Console.WriteLine("6. First ask about the church's desired demographic.");
                Console.WriteLine("7. First ask about the needs of his potential flock.");
                Console.WriteLine("8. First ask why he wants to grow.");
                Console.WriteLine("9. Ignore the fox.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                int iFoxConvo = int.TryParse(Console.ReadLine(), out iFoxConvo) ? iFoxConvo : 9;
                while (iFoxConvo != 1 && iFoxConvo != 2 && iFoxConvo != 3 && iFoxConvo != 4 && iFoxConvo != 9)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    if (iFoxConvo == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Maybe I could answer better if I knew something of your beliefs.'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'Oh, good question. Good question. I've learned that I'm really good at");
                        Console.WriteLine("climbing trees, and I want to pass this knowledge on. I think it's a good");
                        Console.WriteLine("idea to have a place where we can work together to share lots of food.");
                        Console.WriteLine("And my kind aren't long for this world, so I'd like to expand lifespans.");
                        Console.WriteLine("I've got a couple ideas for that last one.'");
                        Console.WriteLine();
                        Console.WriteLine("He looks at you expectantly. That must be the entirety of this fox's faith.");
                        Console.WriteLine();
                        Console.WriteLine("'Oh, sorry! There's one another thing that's important to me. It's the");
                        Console.WriteLine("most important thing actually. Funny that I'd forget it. Everyone looks");
                        Console.WriteLine("down on us as this cunning race out to manipulate and deceive others.");
                        Console.WriteLine("I'd like to get away from anything involving such trappings. Why can't");
                        Console.WriteLine("we be straightforward and honest in our aims and intentions?'");
                    }
                    if (iFoxConvo == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Are you only looking to attract other foxes?'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'No, no. I'd like to have something more inclusive. Being around others");
                        Console.WriteLine("who aren't just like us may let them see that we're not the swindlers");
                        Console.WriteLine("everyone thinks we are. And if we could attract, say, birds into our");
                        Console.WriteLine("following -- that would give us a rare treat to eat.'");
                    }
                    if (iFoxConvo == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Sometimes it helps to understand your targets. If you want to persuade");
                        Console.WriteLine("someone to help you, it's useful to figure out what they want.'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'Hm. Now that's something indeed. We're looking for food primarily.");
                        Console.WriteLine("And safety. And opportunities for mating. I think that's it. So you're");
                        Console.WriteLine("saying that if I can promise to offer those things, others might be more");
                        Console.WriteLine("willing to join? Hm. I'm OK with that to an extent. I wouldn't want to");
                        Console.WriteLine("make false promises. I don't want to bilk anyone into thinking this is");
                        Console.WriteLine("something it isn't. We're not con men.'");
                    }
                    if (iFoxConvo == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("'Why are you looking to grow the size of your church?'");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("'Right now our church is small. There are four of us. But I'm confident");
                        Console.WriteLine("that if we found others to join our cause then there would be more of");
                        Console.WriteLine("us. For a long time I've had this dream of being at the head of a large");
                        Console.WriteLine("gathering -- and everyone hanging on my every word. I think it was a");
                        Console.WriteLine("vision. And I want to see it to fruition.'");
                    }
                    if (iFoxConvo > 9 || iFoxConvo < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Please choose from 1 through 9.");
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You are speaking with a fox.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Tell the fox to be persistent.");
                    Console.WriteLine("2. Suggest word-of-mouth advertising.");
                    Console.WriteLine("3. Suggest enticing followers.");
                    Console.WriteLine("4. Suggest stealing followers.");
                    Console.WriteLine("5. First ask about his beliefs.");
                    Console.WriteLine("6. First ask about the church's desired demographic.");
                    Console.WriteLine("7. First ask about the needs of his potential flock.");
                    Console.WriteLine("8. First ask why he wants to grow.");
                    Console.WriteLine("9. Ignore the fox.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iFoxConvo = int.TryParse(Console.ReadLine(), out iFoxConvo) ? iFoxConvo : 9;
                    Console.WriteLine();
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                if (iFoxConvo == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'You can't doubt yourself. You're doing the right thing now. You're");
                    Console.WriteLine("following your heart. Keep at it and things will turn out right.'");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Hm. I can't say that's very helpful. I've been following my heart and it's");
                    Console.WriteLine("not working. I'm asking you for other ideas. New ideas. Something to");
                    Console.WriteLine("get me going. I thought you humans were supposed to be creative and");
                    Console.WriteLine("adaptable.' He pauses. 'I'm sorry. That's the frustration speaking. I");
                    Console.WriteLine("should leave you alone.' And, with that, he wanders back into the night.");
                }
                if (iFoxConvo == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'Have you considered the power of word-of-mouth advertising?'");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'Word-of-what?'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'The idea is that you tell three people about your church. Those three");
                    Console.WriteLine("people each tell three people. So you've only told three people, but now");
                    Console.WriteLine("twelve people know about your church. And it doesn't stop there");
                    Console.WriteLine("because those people tell other people, too.'");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("The fox lowers its front half to the ground and covers its head with its");
                    Console.WriteLine("paws, then stands back up. 'You're blowing my mind. I don't know what");
                    Console.WriteLine("to say. I can't thank you enough. Word. Of. Mouth. This is going to be");
                    Console.WriteLine("amazing. Thank you. You changed my life. I'll never forget this.' He trots");
                    Console.WriteLine("back off into the night.");
                    Console.WriteLine();
                    Console.WriteLine("You notice a small pile of MacGuffins where he had been sitting.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int iFoxTreasure = Program.rand.Next(3, 7);
                    Console.WriteLine("   Gained " + iFoxTreasure + " MacGuffins.");
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iFoxTreasure;
                }
                if (iFoxConvo == 3)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'It may not engender the most sincere reasons for attendance, but");
                    Console.WriteLine("maybe if you entice them they'll attend out of habit.'");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("'I'm not quite sure I like where this is going.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'If I want animals around my house, I can I leave food out.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Animals? Is that what you call us? Never mind. I'm sorry for");
                    Console.WriteLine("interrupting. Please, continue. I'm so anxious to see where this goes.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Is he being sarcastic, you wonder? You put the thought aside and");
                    Console.WriteLine("continue. 'At first, I have to leave the food out every day. But once they");
                    Console.WriteLine("get into habit of visiting, I don't need to leave the food out anymore.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'You want to trick 'animals' into starvation? You're sick.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'What? No. That's now how I meant it.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'I don't need to know and I don't want to know. Thanks for the tips on");
                    Console.WriteLine("tricks and genocide. They were really enlightening. You know what? You");
                    Console.WriteLine("'people' -- there, I said it -- deserve whatever you get. You're sick.' The");
                    Console.WriteLine("fox trots off into the night.");
                }
                if (iFoxConvo == 4)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("'I don't know how things work, but have you considering luring");
                    Console.WriteLine("followers away from other churches? For example, you can go to");
                    Console.WriteLine("another church and tell them all why your church is better.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Hm. I can't say that's an awful idea. But there are two problems.");
                    Console.WriteLine();
                    Console.WriteLine("'First, your kind sees my kind as some sort of tricksters. What did we");
                    Console.WriteLine("ever do to warrant that kind of label? Sure, we're clever -- but I feel like");
                    Console.WriteLine("stealing a bunch of followers feeds into the negative stereotypes.'");
                    Console.WriteLine();
                    Console.WriteLine("'More importantly, my kind don't go to church so there's no church");
                    Console.WriteLine("from which to steal followers. But I guess you wouldn't know anything");
                    Console.WriteLine("about any of that, so I don't know why I'm bothering to come to you for");
                    Console.WriteLine("advice in the first place.'");
                    Console.WriteLine();
                    Console.WriteLine("The fox sighs. 'I'm sorry. That's the stress talking. You're trying. And I'm");
                    Console.WriteLine("grateful. This is just a tough assignment. I guess I should leave and think");
                    Console.WriteLine("on this some more.' The fox trots back into the shadows.");
                }
                if (iFoxConvo == 9)
                {
                    Console.WriteLine("'Hello? Excuse me?' The fox persists, but you go deep within yourself");
                    Console.WriteLine("and continue to ignore the fox. Finally, the fox says, 'Hey, I'm sorry for");
                    Console.WriteLine("bothering you,' before trotting back into the night. You breathe a sigh");
                    Console.WriteLine("of relief.");
                }
            }
        }

        public static void Run_RandomEncounter06()
        {
            if (!bRandEncounter6 && (iRandEncounter == 6 && Lists.TalkingNPCs.Count >= 2) && (Variables.sGetLocation == LocationEncounters.location_001 || Variables.sGetLocation == LocationEncounters.location_003 ||
                        Variables.sGetLocation == LocationEncounters.location_013 || Variables.sGetLocation == LocationEncounters.location_022 || Variables.sGetLocation == LocationEncounters.location_023 || Variables.sGetLocation == LocationEncounters.location_024 ||
                        Variables.sGetLocation == LocationEncounters.location_025)) // Random Encounter #6
            {
                bRandEncounter6 = true;
                Variables.iTurnsSinceEncounter = 0;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                bEncounter = true;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                // Q1
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("As you walk along the sand, a flash of movement catches your");
                Console.WriteLine("attention. The movement is dark and shadowy, so you're forced to stare");
                Console.WriteLine("into the gloom for a moment to figure out what is happening.");
                Console.WriteLine();
                Console.WriteLine("It looks like a longer, thicker object, parallel to the ground, with");
                Console.WriteLine("something perpendicularly attached to it, sticking up from the ground.");
                Console.WriteLine("You can't be certain if it's two pieces or one, but it is moving in a");
                Console.WriteLine("rhythmic pattern.");
                Console.WriteLine();
                Console.WriteLine("Then, with some embarrassment, you realize you've been staring at a");
                Console.WriteLine("couple having sex. As you turn away, you notice, at some distance from");
                Console.WriteLine("them, a pile of what you assume to be their clothing.");
                Console.WriteLine();
                Console.WriteLine("A few options spring to mind. These options require no additional time.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("1. Put an end to their act by interrupting them.");
                Console.WriteLine("2. Search through their clothes and see what you can find.");
                Console.WriteLine("3. Spend some time watching. Who knows where this might lead?");
                Console.WriteLine("4. Leave them alone.");
                Console.WriteLine();
                int iTripBallsQ1 = int.TryParse(Console.ReadLine(), out iTripBallsQ1) ? iTripBallsQ1 : 4;
                Console.WriteLine();
                while (iTripBallsQ1 < 1 || iTripBallsQ1 > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("Please choose from 1 through 4.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iTripBallsQ1 = int.TryParse(Console.ReadLine(), out iTripBallsQ1) ? iTripBallsQ1 : 4;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                if (iTripBallsQ1 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("You start walking toward the couple.");
                    Console.WriteLine();
                    Console.WriteLine("'Hi. How are you doing tonight? It's nice out, isn't it?' ");
                    Console.WriteLine();
                    Console.WriteLine("As you get closer, you can't help but feel like that guy who stomps on");
                    Console.WriteLine("little kids sandcastles, but simple actions can lead in many possible");
                    Console.WriteLine("directions. Maybe this will lead to some interesting conversation.");
                    Console.WriteLine("Maybe they'll invite you to join them. That could be exciting. Or maybe");
                    Console.WriteLine("this will be the beginning of a story that starts 'remember that one time");
                    Console.WriteLine("when you found us on the beach' and ends with everyone laughing and");
                    Console.WriteLine("having a good time. Wouldn't that be fun?");
                    Console.WriteLine();
                    Console.WriteLine("When the couple spots you, they quickly stop what they're doing, run");
                    Console.WriteLine("for their clothing, and quickly dress. They're more-or-less dressed by the");
                    Console.WriteLine("time you reach them and realize who the frisky couple are.");
                    Console.WriteLine();
                    Console.WriteLine("'Hello, " + Actor01 + ". Hello, " + Actor02 + ". How are you?'");
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " says, 'Hey, jerk! How about you stop being creepy!' " + Actor02);
                    Console.WriteLine("says to " + NPC_AI.sGenderHimHer01 + ", 'Come on, let's just get out of here.'");
                    Console.WriteLine();
                    Console.WriteLine("Creepy, you think. How was this creepy? It's not like you were leering");
                    Console.WriteLine("from the bushes, spying into their bedroom!");
                    Console.WriteLine();
                    Console.WriteLine("'Hey,' you respond. 'You're out in public. I was just saying hi. That's not");
                    Console.WriteLine("creepy!");
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " and " + Actor02 + " do not seem impressed by your argument. They");
                    Console.WriteLine("move away, making sure to keep their distance from you.");
                    iTempLoyalty01 = 0;
                    iTempLoyalty02 = 0;
                    iTempDesireToMove01 = 100;
                    iTempDesireToMove02 = 100;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased to minimum.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased to minimum.");
                }
                if (iTripBallsQ1 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("While they are otherwise occupied, you sneak over toward their");
                    Console.WriteLine("clothes. In their pockets you find some MacGuffins.");
                    Console.WriteLine();
                    Console.WriteLine("'What are you doing by our clothes? Get away from them!' It sounds like");
                    Console.WriteLine(Actor01 + ".");
                    Console.WriteLine();
                    Console.WriteLine("You look over and see the couple standing, covering themselves --");
                    Console.WriteLine("though at this distance and with this lighting all you can see are");
                    Console.WriteLine("shadows. You guess that they won't get any closer -- naked as they are.");
                    Console.WriteLine("You take advantage of the opportunity to pocket the MacGuffins before");
                    Console.WriteLine("moving on.");
                    Console.WriteLine();
                    Console.WriteLine("As you walk away, you hear what sounds like " + Actor02 + "'s voice call out");
                    Console.WriteLine("'Jerk.'");
                    int iCoupleCoins = Program.rand.Next(8, 21);
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iCoupleCoins;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased to minimum.");
                    Console.WriteLine("   " + Actor02 + "'s disposition decreased to minimum.");
                    Console.WriteLine("   Gained " + iCoupleCoins + " MacGuffins.");
                    iTempLoyalty01 = 0;
                    iTempLoyalty02 = 0;
                    iTempDesireToMove01 = 100;
                    iTempDesireToMove02 = 100;
                }
                if (iTripBallsQ1 == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("You leave them to their fun.");
                }
                if (iTripBallsQ1 == 3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You look for a shadowy spot and slip into it, settling down to watch");
                    Console.WriteLine("l'amour. After a while, your eyes have adjusted enough that you can");
                    Console.WriteLine("almost tell shadows from shadowed body parts. While it's still hard to");
                    Console.WriteLine("tell where one starts and the other ends, or even differentiate an arm");
                    Console.WriteLine("from a torso, you can hear enough, and imagine enough, to make this a");
                    Console.WriteLine("satisfyingly erotic experience.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                    Console.WriteLine("2. Leave them alone.");
                    Console.WriteLine();
                    int iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("You don't stop a song when it's in the middle of a guitar solo. You don't");
                        Console.WriteLine("walk out on a movie just as the second act is building. At this point, you");
                        Console.WriteLine("think it'd almost be rude to move on when this couple is so clearly");
                        Console.WriteLine("enjoying themselves in the creation of their bodily art. Even wind and");
                        Console.WriteLine("water work to ensure they complement the piece.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        Console.WriteLine();
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("OK, you think to yourself. Yes, this is hot. Yes, this is nice to watch. But");
                        Console.WriteLine("there's this nagging voice saying, 'Yes, we get it. We understand it. Now");
                        Console.WriteLine("move on to the next phase.' It's not that it's dragging, it's that you can't");
                        Console.WriteLine("expect an award-winning performance to completely neglect such");
                        Console.WriteLine("critical elements as proper pacing. But as soon as the thought passes");
                        Console.WriteLine("through your head, you think of all the award-winning movies that");
                        Console.WriteLine("stretch way past two hours. OK, this is dragging. There. It's been said.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        Console.WriteLine();
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("You've invested this much time into the experience. What's a few more");
                        Console.WriteLine("minutes? And then, almost as if on queue, you hear one of them make a");
                        Console.WriteLine("more audible moan, quickly followed by the same from the other.");
                        Console.WriteLine("'Ooh!' 'Ohhh...' You're feeling pretty tingly as their passion nears climax.");
                        Console.WriteLine("This could be it!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        Console.WriteLine();
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("'Oh! Oh! Oh!' 'Oooooh!' It's odd, you think, how similar sex sounds to");
                        Console.WriteLine("something hurtful. Then you remember the expression about pleasure");
                        Console.WriteLine("and pain. Aren't they supposed to be two sides of the same coin? It");
                        Console.WriteLine("makes you wonder what a coin would look like if pleasure were on one");
                        Console.WriteLine("side and pain on the other. Would each side feature those specific");
                        Console.WriteLine("words, or would an image be used to encapsulate those feelings?");
                        Console.WriteLine();
                        Console.WriteLine("'OHHH!!!' they say, in unison. How romantic, you think -- the");
                        Console.WriteLine("'simultaneous orgasm' on what might be our last night. What a way to");
                        Console.WriteLine("end it. OK, that ended up pretty well after all.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        Console.WriteLine();
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("'-- OHHH --' they continue. There's no rise nor decline to their orgasmic");
                        Console.WriteLine("gasp. It's as if they've gotten stuck. The sound is hitting you in a way");
                        Console.WriteLine("that you're starting to find irritating.");
                        Console.WriteLine();
                        Console.WriteLine("'-- OHHH --' it goes on. Why won't they stop, you wonder. Did they");
                        Console.WriteLine("break? Are they broken? What's happening? Why won't they stop?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Keep watching. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Variables.iRemainingTurns = Variables.iRemainingTurns - 1;
                        Console.WriteLine("'-- OHHH --' The irritation turns to humor for you. It's too ridiculous. No");
                        Console.WriteLine("one moans like that. You almost want it to continue without stopping,");
                        Console.WriteLine("just for the sake of it. Maybe they'll survive the island's demise, and");
                        Console.WriteLine("people will come for ages on to look at the two lovers stuck in orgasm.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Check them out up close to see what's wrong. (This option requires 1 minute.)");
                        Console.WriteLine("2. Leave them alone.");
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    while (iTripBallsQ2 < 1 || iTripBallsQ2 > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose either 1 or 2.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iTripBallsQ2 = int.TryParse(Console.ReadLine(), out iTripBallsQ2) ? iTripBallsQ2 : 2;
                    }
                    if (iTripBallsQ2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You walk over to the couple, cautiously, but they make no notice of your");
                        Console.WriteLine("approach. When you get close enough to them you can see that it's");
                        Console.WriteLine(Actor01 + " and " + Actor02 + ". They are stuck in the very same way that a");
                        Console.WriteLine("computer might crash and become stuck; they are ceaselessly looping a");
                        Console.WriteLine("second-long sequence.");
                        Console.WriteLine();
                        Console.WriteLine("'-- OHHH --'");
                        Console.WriteLine();
                        Console.WriteLine("You think that a good bop on the head may get things going again.");
                        Console.WriteLine("That's what you'd do to a broken TV to fix it. 'They' always say that it's a");
                        Console.WriteLine("bad idea to hit your electronics, but it always works. Is that a");
                        Console.WriteLine("conspiracy?");
                        Console.WriteLine();
                        Console.WriteLine("'-- OHHH --'");
                        Console.WriteLine();
                        Console.WriteLine("You give the couple a closer look before proceeding with your plan.");
                        Console.WriteLine("They're not quite as attractive as you imagined from a distance, but");
                        Console.WriteLine("it doesn't ruin the scene in any way for you. " + Actor01 + " is making an");
                        Console.WriteLine("amusing face. A picture of this would be perfect. You take another look");
                        Console.WriteLine("around, then make a few inappropriate touches before stopping, taking");
                        Console.WriteLine("a breath, and giving " + Actor02 + " a nice smack in the back of the head.");
                        Console.WriteLine();
                        Console.WriteLine("And then you're deep, deep underwater, floating in stillness and peace.");
                        Program.PressAnyKey();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You know you're deep underwater because of the feeling of intense");
                        Console.WriteLine("pressure, though it's more like a tight hug than anything scary. You also");
                        Console.WriteLine("realize that even when you open your mouth, water doesn't rush in and");
                        Console.WriteLine("you're able to breathe in air without any issue. This isn't what you");
                        Console.WriteLine("expected. Not at all.");
                        Console.WriteLine();
                        Console.WriteLine("As you float there in the murk, a school of colorful fish swim up to you");
                        Console.WriteLine("and surround you. The most colorful of the fish gets close to your face");
                        Console.WriteLine("and seem to be trying to figure you out. How do you act?");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1. Polite and respectful. ");
                        Console.WriteLine("2. Rude and aggressive.");
                        Console.WriteLine("3. Happy and friendly.");
                        Console.WriteLine();
                        int iTripBallsQ3 = int.TryParse(Console.ReadLine(), out iTripBallsQ3) ? iTripBallsQ3 : 1;
                        while (iTripBallsQ3 < 1 || iTripBallsQ3 > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("Please choose from 1 through 3.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            iTripBallsQ3 = int.TryParse(Console.ReadLine(), out iTripBallsQ3) ? iTripBallsQ3 : 4;
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("'You're not from here,' says the most colorful fish.");
                        Console.WriteLine();
                        if (iTripBallsQ3 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("'No, I'm not,' you say.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("'Of course not. I'd know. Besides, that wasn't a question.'");
                        }
                        if (iTripBallsQ3 == 2)
                        {
                            Console.WriteLine("You use your hands like fake gills, and make fish lips.");
                            Console.WriteLine();
                            Console.WriteLine("'How droll.'");
                        }
                        if (iTripBallsQ3 == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Well, I sure am pleased to meet you. This is amazing!");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("The most colorful fish arches an... eyebrow (?) in response.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("'It is our custom to reward visitors in some way -- based entirely upon");
                        Console.WriteLine("their attitude in this first encounter. Your response has been duly noted,");
                        Console.WriteLine("and you will be rewarded accordingly; when you're back in your dry");
                        Console.WriteLine("place, you will know your reward. Now, to the matter of your return.'");
                        Console.WriteLine();
                        Console.WriteLine("The fish press themselves against you and start pushing against you. As");
                        Console.WriteLine("they push, you notice they are pushing you toward a pair of draw strings");
                        Console.WriteLine("that are floating in front of you.");
                        Console.WriteLine();
                        Console.WriteLine("The most colorful fish says, 'Soon after you pull the blue draw string,");
                        Console.WriteLine("you will awake in your dry place with your reward. However, if you want");
                        Console.WriteLine("to take a chance, pull the red draw string. Maybe you'll get a better");
                        Console.WriteLine("reward. Or worse. Maybe you'll get nothing at all.'");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("1. Pull the blue draw string.");
                        Console.WriteLine("2. Pull the red draw string.");
                        Console.WriteLine();
                        int iTripBallsQ4 = int.TryParse(Console.ReadLine(), out iTripBallsQ4) ? iTripBallsQ4 : 1;
                        while (iTripBallsQ4 < 1 || iTripBallsQ4 > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("Please choose either 1 or 2.");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            iTripBallsQ4 = int.TryParse(Console.ReadLine(), out iTripBallsQ4) ? iTripBallsQ4 : 1;
                        }
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You grab the string and feel tension; it's attached to something in the");
                        Console.WriteLine("murk. As you hold the string, the fish swim off in terror, trailing bubbles.");
                        Console.WriteLine("There's an audible, but muffled, click when you pull it.");
                        Console.WriteLine();
                        Console.WriteLine("A moment later something large smacks into you from behind, pushing");
                        Console.WriteLine("you upward with so much force that you feel pinned against it. Faster");
                        Console.WriteLine("and faster you go, until you're moving so quickly that you can see the");
                        Console.WriteLine("spaces between every drop of water in the sea. And then the murky");
                        Console.WriteLine("darkness below solidifies into solid ground, there's another click, and");
                        Console.WriteLine("the water drops fall as rain. You're back on land.");
                        Console.WriteLine();
                        if (iTripBallsQ4 == 1) // Take the safe reward.
                        {
                            if (iTripBallsQ3 == 1) // Acted Polite and Respectful, receive a gift of MacGuffins.
                            {
                                int iFishMacGuffins = Program.rand.Next(10, 21);
                                Console.WriteLine("You see a pile of MacGuffins on the ground in front of you. Written in");
                                Console.WriteLine("the sand is a note: 'Perhaps these wedges can be used to pry some");
                                Console.WriteLine("clams open. You're rather big, so we've sent many wedges so that you");
                                Console.WriteLine("can open many clams at once. No, we don't think you're fat.'");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained " + iFishMacGuffins + " MacGuffins.");
                                Console.WriteLine("   Seven minutes have passed.");
                                Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iFishMacGuffins;
                            }
                            if (iTripBallsQ3 == 2) // Acted Rude and Aggresive, receive a gift of a Weapon.
                            {
                                Console.WriteLine("You see a fried fish on the ground in front of you. It's colorful in nature,");
                                Console.WriteLine("and flops once or twice, puckering, before becoming quite rigid. Written");
                                Console.WriteLine("in the sand is a note: 'We have sent one of our bravest warriors to");
                                Console.WriteLine("travel at your side. He can be a bit annoying, but is useful in a fight.'");
                                Console.WriteLine();
                                Console.WriteLine("The fish is serrated on the edges, but smooth by the tail. You grab it and");
                                Console.WriteLine("discover it's quite rigid. This fried fish may work well as a weapon.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained a " + NPC_AI.sWeaponType5 + ".");
                                Console.WriteLine("   Seven minutes have passed.");
                                Variables.weaponName = NPC_AI.sWeaponType5;
                            }
                            if (iTripBallsQ3 == 3) // Acted Happy and Friendly, receive a gift of Friendship (all herrings friendly).
                            {
                                Console.WriteLine("You see a note written into the sand. It says, 'You seemed friendly when");
                                Console.WriteLine("we met you, and so we assume you make friends easily. But wouldn't it");
                                Console.WriteLine("be nice if you didn't have to work for it? We've had a chat with " + NPC_AI.NPC_090 + ",");
                                Console.WriteLine(NPC_AI.NPC_091 + ", " + NPC_AI.NPC_092 + ", " + NPC_AI.NPC_093 + ", " + NPC_AI.NPC_094 + ", " + 
                                NPC_AI.NPC_095 + ", " + NPC_AI.NPC_096 + ", " + NPC_AI.NPC_097 + ", " + NPC_AI.NPC_098 + ", " + NPC_AI.NPC_099 + ",");
                                Console.WriteLine("and " + NPC_AI.NPC_100 + " and they've all agreed to be your friend.");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine();
                                Console.WriteLine(NPC_AI.NPC_090 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_091 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_092 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_093 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_094 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_095 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_096 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_097 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_098 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_099 + "'s disposition set to maximum.");
                                Console.WriteLine(NPC_AI.NPC_100 + "'s disposition set to maximum.");
                                NPC_AI.iLoyalty090 = NPC_AI.iLoyalty091 = NPC_AI.iLoyalty092 = NPC_AI.iLoyalty093 = NPC_AI.iLoyalty094 =
                                NPC_AI.iLoyalty095 = NPC_AI.iLoyalty096 = NPC_AI.iLoyalty097 = NPC_AI.iLoyalty098 = NPC_AI.iLoyalty099 =
                                NPC_AI.iLoyalty100 = 5;
                                Console.WriteLine("   Seven minutes have passed.");
                            }
                        }
                        if (iTripBallsQ4 == 2) // Gamble on a unique reward.
                        {
                            // Roll a percentile chance.
                            int iSpecialFishReward = Program.rand.Next(1, 101);
                            // If tier one (1-35), player receives nothing but a note saying sorry, thanks for playing, consolation single macguffin.
                            if (iSpecialFishReward <=35)
                            {
                                Console.WriteLine("You see a note written into the sand. It says, 'Unfortunately, you did not");
                                Console.WriteLine("win a prize. That's the way the seaweed shakes, as we are fond to say.");
                                Console.WriteLine("However, we felt badly and decided to leave you with a wedge. These");
                                Console.WriteLine("wedges are quite handy, and great for opening clams.'");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained 1 MacGuffin.");
                                Console.WriteLine("   Seven minutes have passed.");
                                Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 1;
                            }

                            // If tier two (36-70), player will never die by the tidal wave.
                            if (iSpecialFishReward >= 36 && iSpecialFishReward <= 70)
                            {
                                Console.WriteLine("You see a note written into the sand. It says, 'We've noticed that your");
                                Console.WriteLine("dry place is surrounded by water, and perhaps that might be a problem");
                                Console.WriteLine("for one like you. However, we thought that if you were more like us,");
                                Console.WriteLine("maybe all that water would not be seen as a bad thing. And so that's");
                                Console.WriteLine("what we did: we made you more like us!'");
                                Console.WriteLine();
                                Console.WriteLine("You can't be completely certain as to what that means. More like the");
                                Console.WriteLine("colorful fish? Safe from water? Does that mean you can't drown? You");
                                Console.WriteLine("consider that it may be best to never find out.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained 'Water Breathing'.");
                                Console.WriteLine("   Seven minutes have passed.");
                                bFloodProof = true;
                            }
                            // If tier three (71-100), player automatically receives metal detector sense, MAX MacGuffins on any search.
                            if (iSpecialFishReward >= 71)
                            {
                                Console.WriteLine("You see a note written into the sand. It says, 'We can't help but notice");
                                Console.WriteLine("how big you are -- but in a completely healthy way, of course -- and can");
                                Console.WriteLine("only assume that you would make great use of a plentiful supply of");
                                Console.WriteLine("wedges to help you open great amounts of food like clams. When you");
                                Console.WriteLine("look for wedges, you'll always find every last one. Plus, here's one to get");
                                Console.WriteLine("you started, so you don't starve while looking for more.'");
                                Console.WriteLine();
                                Console.WriteLine("How hungry do they think I am to make fat jokes? You read the note a");
                                Console.WriteLine("second time and try to make sense of it. So they call these MacGuffins");
                                Console.WriteLine("'wedges'. Hm. And every time I go looking, I'll always find them all? How");
                                Console.WriteLine("can that work? But... if it does... that's not be a bad thing.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("   Gained 1 MacGuffin.");
                                Console.WriteLine("   Gained 'MacGuffin Detection'.");
                                Console.WriteLine("   Seven minutes have passed.");
                                Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 1;
                                bMetalDetector = true;
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iTripBallsQ2 == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Clear();
                        Console.WriteLine("You walk away from the couple.");
                    }
                }
            }
        }

        public static void Run_RandomEncounter07()
        {
            if (!bRandEncounter7 && iRandEncounter == 7 && Lists.TalkingNPCs.Count >= 2) // Random Encounter #7
            {
                bRandEncounter7 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You hear the sound of two people arguing. You follow the noise to find");
                Console.WriteLine(Actor01 + " and " + Actor02 + " in a heated discussion. When they see you");
                Console.WriteLine("approaching, they look to you -- perhaps in the hopes that you'll help");
                Console.WriteLine("resolve whatever their argument is over.");
                Console.WriteLine();
                Console.WriteLine("1. 'No way am I getting involved.' Walk away from their argument.");
                Console.WriteLine("2. Ask what they're arguing about. (This option requires 4 minutes).");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                int iEncounter7Q1 = int.TryParse(Console.ReadLine(), out iEncounter7Q1) ? iEncounter7Q1 : 1;
                while (iEncounter7Q1 < 1 || iEncounter7Q1 > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("Please choose either 1 or 2.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iEncounter7Q1 = int.TryParse(Console.ReadLine(), out iEncounter7Q1) ? iEncounter7Q1 : 1;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                if (iEncounter7Q1 == 2)
                {
                    Variables.iRemainingTurns = Variables.iRemainingTurns - 4;
                    Console.Clear();
                    Console.WriteLine("'It's about some MacGuffins,' says " + Actor01 + ".");
                    Console.WriteLine();
                    Console.WriteLine("'Give me the disputed MacGuffins,' you say, 'and I'll hear your");
                    Console.WriteLine("argument.'");
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " and " + Actor02 + " look to one another and nod in agreement. " + Actor02);
                    Console.WriteLine("hands you 20 MacGuffins.");
                    Console.WriteLine();
                    Console.WriteLine(Actor01 + " says, 'I didn't know what they were, those MacGuffins, but when");
                    Console.WriteLine("I saw one I'd grab it. Had a good collection going before not too long.");
                    Console.WriteLine("Then my quote-unquote friend here said they were worthless. I felt");
                    Console.WriteLine("stupid so I tossed them.'");
                    Console.WriteLine();
                    Console.WriteLine(Actor02 + " says, 'See! You admit to throwing them away. You gave them up!'");
                    Console.WriteLine();
                    Console.WriteLine("'Because you lied to me! I trusted you!'");
                    Console.WriteLine();
                    Console.WriteLine("'One person's trash is another's treasure! You didn't have to throw them");
                    Console.WriteLine("away. But you did. Why can't I take them?'");
                    Console.WriteLine();
                    Console.WriteLine("'What? You lied! You manipulated me to steal them!'");
                    Console.WriteLine();
                    Console.WriteLine("'Fine. How about this? How about we split them?'");
                    Console.WriteLine();
                    Console.WriteLine("'No! They're mine! All of them! I'm not giving you half because you");
                    Console.WriteLine("tricked me to steal them!'");
                    Console.WriteLine();
                    Console.WriteLine("'You don't even have half to give! I'd be giving you half to stop your");
                    Console.WriteLine("crying. But if you don't want half, fine. I'll keep them all.'");
                    Console.WriteLine();
                    Console.WriteLine("'That's not your decision anymore.' At that, " + Actor01 + " and " + Actor02 + " turn to");
                    Console.WriteLine("look at you, awaiting your response.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. " + Actor01 + ", these were originally yours. Let me return them.");
                    Console.WriteLine("2. " + Actor02 + ", you should keep them. " + Actor01 + " threw them away.");
                    Console.WriteLine("3. I'm giving you each half, but remember what's important: friendship.");
                    Console.WriteLine("4. You both claim to have found them. Now I have. I'm keeping them.");
                    Console.WriteLine();
                    int iEncounter7Q2 = int.TryParse(Console.ReadLine(), out iEncounter7Q2) ? iEncounter7Q2 : 1;
                    while (iEncounter7Q2 < 1 || iEncounter7Q2 > 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Please choose from 1 through 4.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        iEncounter7Q2 = int.TryParse(Console.ReadLine(), out iEncounter7Q2) ? iEncounter7Q2 : 1;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iEncounter7Q2 == 1) 
                    {
                        Console.WriteLine(Actor02 + " does not look happy about it, but " + NPC_AI.sGenderHeShe02 + " knows there's nothing " + NPC_AI.sGenderHeShe02);
                        Console.WriteLine("can do about it. You hand the 20 MacGuffins to a smiling " + Actor01 + " and");
                        Console.WriteLine("walk away.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   " + Actor01 + "'s disposition increased to maximum.");
                        Console.WriteLine("   " + Actor02 + "'s disposition decreased to minimum.");
                        iTempLoyalty01 = 5;
                        iTempLoyalty02 = 0;
                        Console.WriteLine("   Four minutes have passed."); // Handled at start of encounter.  
                    }
                    if (iEncounter7Q2 == 2) 
                    {
                        Console.WriteLine(Actor01 + " does not look happy about it, but " + NPC_AI.sGenderHeShe01 + " knows there's nothing " + NPC_AI.sGenderHeShe01);
                        Console.WriteLine("can do about it. You hand the 20 MacGuffins to a smiling " + Actor02 + " and");
                        Console.WriteLine("walk away.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   " + Actor02 + "'s disposition increased to maximum.");
                        Console.WriteLine("   " + Actor01 + "'s disposition decreased to minimum.");
                        iTempLoyalty02 = 5;
                        iTempLoyalty01 = 0;
                        Console.WriteLine("   Four minutes have passed."); // Handled at start of encounter.  
                    }
                    if (iEncounter7Q2 == 3) 
                    {
                        Console.WriteLine(Actor01 + " and " + Actor02 + " look at one another, thinking on what you've said.");
                        Console.WriteLine();
                        Console.WriteLine("'That's true,' says " + Actor01 + ". 'Friendship is what's important. We're");
                        Console.WriteLine("friends. Why are we fighting over money?'");
                        Console.WriteLine();
                        Console.WriteLine(Actor02 + " says, 'Well, I did offer to split the money earlier.'");
                        Console.WriteLine();
                        Console.WriteLine("'Hey, don't be rude.'");
                        Console.WriteLine();
                        Console.WriteLine("'I'm not being rude! I did offer!'");
                        Console.WriteLine();
                        Console.WriteLine("'And I would have given you half if you'd just asked, but you'd rather try");
                        Console.WriteLine("to trick a friend and leave me with nothing.'");
                        Console.WriteLine();
                        Console.WriteLine("You cut off this new argument by handing them each 10 MacGuffins.");
                        Console.WriteLine();
                        Console.WriteLine("There's a long pause before " + Actor02 + " finally sighs and says, 'I'm sorry.");
                        Console.WriteLine("You're right. I was rude. And selfish. And manipulative.'");
                        Console.WriteLine();
                        Console.WriteLine(Actor02 + " hugs " + Actor01 + ", who smiles back in return. After a moment, and");
                        Console.WriteLine("following a brief, inaudible exchange, they turn back to you.");
                        Console.WriteLine();
                        Console.WriteLine("'Thank you for helping us. Take this as our thanks.' They hand you 6");
                        Console.WriteLine("MacGuffins.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   " + Actor01 + "'s disposition increased to maximum.");
                        Console.WriteLine("   " + Actor02 + "'s disposition increased to maximum.");
                        iTempLoyalty01 = iTempLoyalty02 = 5;
                        Console.WriteLine("   Gained 6 MacGuffins.");
                        Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 6;
                        Console.WriteLine("   Four minutes have passed."); // Handled at start of encounter.  
                    }
                    if (iEncounter7Q2 == 4) 
                    {
                        Console.WriteLine(Actor02 + " looks quite angry. 'Are you kidding me?'");
                        Console.WriteLine();
                        Console.WriteLine(Actor01 + " seems more amused than anything. 'Doesn't feel good, does it?");
                        Console.WriteLine("Trusting someone to do the right thing, and then they take advantage.'");
                        Console.WriteLine();
                        Console.WriteLine("'If you accuse me of taking advantage, you're basically admitting your");
                        Console.WriteLine("own stupidity and inability to take care of yourself.'");
                        Console.WriteLine();
                        Console.WriteLine("The duo launch into an all-new argument, forgetting you completely as");
                        Console.WriteLine("you walk away with 20 new MacGuffins in hand.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("   " + Actor01 + "'s disposition decreased to minimum.");
                        Console.WriteLine("   " + Actor02 + "'s disposition decreased to minimum.");
                        iTempLoyalty01 = iTempLoyalty02 = 0;
                        Console.WriteLine("   Gained 20 MacGuffins.");
                        Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + 20;
                        Console.WriteLine("   Four minutes have passed."); // Handled at start of encounter.                        
                    }
                }
                if (iEncounter7Q1 == 1)
                {
                    Console.WriteLine("Let these two idiots argue, you think to yourself. There are far more");
                    Console.WriteLine("important things to worry about.");
                }
            }
        }

        public static void Run_RandomEncounter08()
        {
            if (!bRandEncounter8 && iRandEncounter == 8) // Random Encounter #5
            {
                bRandEncounter8 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
                Console.WriteLine();
                Console.WriteLine("You notice that " + Actor01 + " is looking at you in a way that might be");
                Console.WriteLine("described as shy or uncertain. Once " + NPC_AI.sGenderHeShe01 + " realizes you see " + NPC_AI.sGenderHimHer01);
                Console.WriteLine("looking, " + Actor01 + " walks over to you.");
                Console.WriteLine();
                Console.WriteLine("'I'm sorry. I don't mean to... I -- it's just. You know my " + NPC_AI.sGenderBrotherSister02 + ". " + sBestieSibling + "?");
                Console.WriteLine("Well, maybe 'know' is too strong of a word. You helped " + NPC_AI.sGenderHimHer02 + ", though. You");
                Console.WriteLine("were nice to " + NPC_AI.sGenderHimHer02 + ".'");
                Console.WriteLine();
                Console.WriteLine("'My " + NPC_AI.sGenderBrotherSister02 + " is dead now, but before " + NPC_AI.sGenderHeShe02 + " died, " + NPC_AI.sGenderHeShe02 + " and I were talking and");
                Console.WriteLine(NPC_AI.sGenderHeShe02 + " said that if something should happen... that I should go to you, that");
                Console.WriteLine("maybe you would be nice to me, too. I don't know what else to say.'");
                Console.WriteLine();
                Console.WriteLine("'I don't want to be a burden, but maybe you won't mind if I stay around");
                Console.WriteLine("you? I won't get in the way. I think there's something about you that");
                Console.WriteLine("feels... safe. And I want to feel safe. But if you want me to leave, I will.'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. 'It's OK. You can stay around me.'");
                Console.WriteLine("2. 'I don't want you around me. Leave.'");
                Console.WriteLine();
                int iEncounter8Q1 = int.TryParse(Console.ReadLine(), out iEncounter8Q1) ? iEncounter8Q1 : 2;
                while (iEncounter8Q1 < 1 || iEncounter8Q1 > 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("Please choose either 1 or 2.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    iEncounter8Q1 = int.TryParse(Console.ReadLine(), out iEncounter8Q1) ? iEncounter8Q1 : 2;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                if (iEncounter8Q1 == 1)
                {
                    Console.WriteLine("'Thank you, thank you. I promise I won't get in the way. I won't bother");
                    Console.WriteLine("you at all. You won't even know I'm here. Thank you! Here, you can");
                    Console.WriteLine("have my MacGuffins. If I find any more, I'll give them to you, too.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition increased to maximum.");
                    iTempLoyalty01 = 5;
                    Console.WriteLine("   Gained " + iTempMacGuffins01 + " MacGuffins.");
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iTempMacGuffins01;
                    iTempMacGuffins01 = 0;
                    bMyBestFriend = true;
                    sBestFriend_Name = Actor01;
                }
                if (iEncounter8Q1 == 2)
                {
                    Console.WriteLine("'I understand. And I'm sorry for getting in your way. I'll leave now.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   " + Actor01 + "'s disposition decreased by 2.");
                    iTempLoyalty01 = iTempLoyalty01 - 2;
                }
            }
        }

        public static void Run_RandomEncounter09()
        {
            if (!bRandEncounter9 && iRandEncounter == 9) // Random Encounter #5
            {
                bRandEncounter9 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
            }
        }

        public static void Run_RandomEncounter10()
        {
            if (!bRandEncounter10 && iRandEncounter == 10) // Random Encounter #5
            {
                bRandEncounter10 = true;
                Variables.iTurnsSinceEncounter = 0;
                bEncounter = true;
                Variables.iRandEncounters = Variables.iRandEncounters + 1;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Before you can choose your next action... (Press any key when you're ready.)");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("(Resolving this encounter requires no additional time.)");
            }
        }

        public static void Resolve_RandomEncounters()
        {
            if (bEncounter)
            {
                Program.PressAnyKey();
                SetAllActorLocals();
            }
            Variables.iTurnsSinceEncounter++;
            Initialize_Actors();
        }

        public static void YourVeryOwnBestie()
        {
            if (bMyBestFriend)
            {
                NPC_AI.GetNPCLocals_MyBestFriend();

                if (!bBestFriend_Corpse && !bBestFriendsReportsOnce)
                {
                    bBestFriendsReportsOnce = true;

                    if (iBestFriend_MacGuffins <= 0)
                    {
                        if (iBestFriend_CurrentNumLocation == Variables.iCurrentLocation)
                        {
                            Console.WriteLine(sBestFriend_Name + " is here.");
                        }
                        if (iBestFriend_CurrentNumLocation != Variables.iCurrentLocation)
                        {
                            Console.WriteLine(sBestFriend_Name + " has followed you here.");
                            iBestFriend_CurrentNumLocation = Variables.iCurrentLocation;
                        }
                    }
                    if (iBestFriend_MacGuffins == 1)
                    {
                        if (iBestFriend_CurrentNumLocation == Variables.iCurrentLocation)
                        {
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iBestFriend_MacGuffins;
                            Console.WriteLine(sBestFriend_Name + " gives you a MacGuffin.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            iBestFriend_MacGuffins = 0;
                        }
                        if (iBestFriend_CurrentNumLocation != Variables.iCurrentLocation)
                        {
                            Console.WriteLine(sBestFriend_Name + " has followed you here, and gives you a MacGuffin.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            iBestFriend_CurrentNumLocation = Variables.iCurrentLocation;
                        }
                    }
                    if (iBestFriend_MacGuffins > 1)
                    {
                        if (iBestFriend_CurrentNumLocation == Variables.iCurrentLocation)
                        {
                            Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iBestFriend_MacGuffins;
                            Console.WriteLine(sBestFriend_Name + " gives you " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            iBestFriend_MacGuffins = 0;
                        }
                        if (iBestFriend_CurrentNumLocation != Variables.iCurrentLocation)
                        {
                            Console.WriteLine(sBestFriend_Name + " has followed you here, and gives you " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("   Gained " + iBestFriend_MacGuffins + " MacGuffins.");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            iBestFriend_CurrentNumLocation = Variables.iCurrentLocation;
                        }
                    }
                    if (iBestFriend_Disposition < 5)
                    {
                        iBestFriend_Disposition = 5; // Ensure the NPC is always max friendly toward player.
                    }
                    if (iBestFriend_DesireToMove > 0)
                    {
                        iBestFriend_DesireToMove = -100; // Moverride the NPC's desire to move.
                    }
                    NPC_AI.SetNPCLocals_MyBestFriend();
                }
            }
        }

        public static void DitchTheBestie()
        {
            // the following makes the end game a little less weird by getting rid of the best friend.
            iBestFriend_CurrentNumLocation = 1; // go to where the player cannot follow, i.e. lost in the commotion of the player being attacked.
            bBestFriend_Corpse = true;
            bMyBestFriend = false;
        }

        public static void BestieSiblingCheck()
        {
            // List: Lists.MyBestiesDeadSibling
            if (NPC_AI.bCorpse001 && NPC_AI.iLoyalty001 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_001); }
            if (NPC_AI.bCorpse002 && NPC_AI.iLoyalty002 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_002); }
            if (NPC_AI.bCorpse003 && NPC_AI.iLoyalty003 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_003); }
            if (NPC_AI.bCorpse004 && NPC_AI.iLoyalty004 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_004); }
            if (NPC_AI.bCorpse005 && NPC_AI.iLoyalty005 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_005); }
            if (NPC_AI.bCorpse006 && NPC_AI.iLoyalty006 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_006); }
            if (NPC_AI.bCorpse007 && NPC_AI.iLoyalty007 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_007); }
            if (NPC_AI.bCorpse008 && NPC_AI.iLoyalty008 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_008); }
            if (NPC_AI.bCorpse009 && NPC_AI.iLoyalty009 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_009); }
            if (NPC_AI.bCorpse010 && NPC_AI.iLoyalty010 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_010); }
            if (NPC_AI.bCorpse011 && NPC_AI.iLoyalty011 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_011); }
            if (NPC_AI.bCorpse012 && NPC_AI.iLoyalty012 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_012); }
            if (NPC_AI.bCorpse013 && NPC_AI.iLoyalty013 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_013); }
            if (NPC_AI.bCorpse014 && NPC_AI.iLoyalty014 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_014); }
            if (NPC_AI.bCorpse015 && NPC_AI.iLoyalty015 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_015); }
            if (NPC_AI.bCorpse016 && NPC_AI.iLoyalty016 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_016); }
            if (NPC_AI.bCorpse017 && NPC_AI.iLoyalty017 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_017); }
            if (NPC_AI.bCorpse018 && NPC_AI.iLoyalty018 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_018); }
            if (NPC_AI.bCorpse019 && NPC_AI.iLoyalty019 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_019); }
            if (NPC_AI.bCorpse020 && NPC_AI.iLoyalty020 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_020); }
            if (NPC_AI.bCorpse021 && NPC_AI.iLoyalty021 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_021); }
            if (NPC_AI.bCorpse022 && NPC_AI.iLoyalty022 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_022); }
            if (NPC_AI.bCorpse023 && NPC_AI.iLoyalty023 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_023); }
            if (NPC_AI.bCorpse024 && NPC_AI.iLoyalty024 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_024); }
            if (NPC_AI.bCorpse025 && NPC_AI.iLoyalty025 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_025); }
            if (NPC_AI.bCorpse026 && NPC_AI.iLoyalty026 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_026); }
            if (NPC_AI.bCorpse027 && NPC_AI.iLoyalty027 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_027); }
            if (NPC_AI.bCorpse028 && NPC_AI.iLoyalty028 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_028); }
            if (NPC_AI.bCorpse029 && NPC_AI.iLoyalty029 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_029); }
            if (NPC_AI.bCorpse030 && NPC_AI.iLoyalty030 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_030); }
            if (NPC_AI.bCorpse031 && NPC_AI.iLoyalty031 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_031); }
            if (NPC_AI.bCorpse032 && NPC_AI.iLoyalty032 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_032); }
            if (NPC_AI.bCorpse033 && NPC_AI.iLoyalty033 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_033); }
            if (NPC_AI.bCorpse034 && NPC_AI.iLoyalty034 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_034); }
            if (NPC_AI.bCorpse035 && NPC_AI.iLoyalty035 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_035); }
            if (NPC_AI.bCorpse036 && NPC_AI.iLoyalty036 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_036); }
            if (NPC_AI.bCorpse037 && NPC_AI.iLoyalty037 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_037); }
            if (NPC_AI.bCorpse038 && NPC_AI.iLoyalty038 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_038); }
            if (NPC_AI.bCorpse039 && NPC_AI.iLoyalty039 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_039); }
            if (NPC_AI.bCorpse040 && NPC_AI.iLoyalty040 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_040); }
            if (NPC_AI.bCorpse041 && NPC_AI.iLoyalty041 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_041); }
            if (NPC_AI.bCorpse042 && NPC_AI.iLoyalty042 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_042); }
            if (NPC_AI.bCorpse043 && NPC_AI.iLoyalty043 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_043); }
            if (NPC_AI.bCorpse044 && NPC_AI.iLoyalty044 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_044); }
            if (NPC_AI.bCorpse045 && NPC_AI.iLoyalty045 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_045); }
            if (NPC_AI.bCorpse046 && NPC_AI.iLoyalty046 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_046); }
            if (NPC_AI.bCorpse047 && NPC_AI.iLoyalty047 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_047); }
            if (NPC_AI.bCorpse048 && NPC_AI.iLoyalty048 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_048); }
            if (NPC_AI.bCorpse049 && NPC_AI.iLoyalty049 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_049); }
            if (NPC_AI.bCorpse050 && NPC_AI.iLoyalty050 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_050); }
            if (NPC_AI.bCorpse051 && NPC_AI.iLoyalty051 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_051); }
            if (NPC_AI.bCorpse052 && NPC_AI.iLoyalty052 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_052); }
            if (NPC_AI.bCorpse053 && NPC_AI.iLoyalty053 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_053); }
            if (NPC_AI.bCorpse054 && NPC_AI.iLoyalty054 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_054); }
            if (NPC_AI.bCorpse055 && NPC_AI.iLoyalty055 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_055); }
            if (NPC_AI.bCorpse056 && NPC_AI.iLoyalty056 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_056); }
            if (NPC_AI.bCorpse057 && NPC_AI.iLoyalty057 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_057); }
            if (NPC_AI.bCorpse058 && NPC_AI.iLoyalty058 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_058); }
            if (NPC_AI.bCorpse059 && NPC_AI.iLoyalty059 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_059); }
            if (NPC_AI.bCorpse060 && NPC_AI.iLoyalty060 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_060); }
            if (NPC_AI.bCorpse061 && NPC_AI.iLoyalty061 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_061); }
            if (NPC_AI.bCorpse062 && NPC_AI.iLoyalty062 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_062); }
            if (NPC_AI.bCorpse063 && NPC_AI.iLoyalty063 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_063); }
            if (NPC_AI.bCorpse064 && NPC_AI.iLoyalty064 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_064); }
            if (NPC_AI.bCorpse065 && NPC_AI.iLoyalty065 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_065); }
            if (NPC_AI.bCorpse066 && NPC_AI.iLoyalty066 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_066); }
            if (NPC_AI.bCorpse067 && NPC_AI.iLoyalty067 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_067); }
            if (NPC_AI.bCorpse068 && NPC_AI.iLoyalty068 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_068); }
            if (NPC_AI.bCorpse069 && NPC_AI.iLoyalty069 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_069); }
            if (NPC_AI.bCorpse070 && NPC_AI.iLoyalty070 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_070); }
            if (NPC_AI.bCorpse071 && NPC_AI.iLoyalty071 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_071); }
            if (NPC_AI.bCorpse072 && NPC_AI.iLoyalty072 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_072); }
            if (NPC_AI.bCorpse073 && NPC_AI.iLoyalty073 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_073); }
            if (NPC_AI.bCorpse074 && NPC_AI.iLoyalty074 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_074); }
            if (NPC_AI.bCorpse075 && NPC_AI.iLoyalty075 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_075); }
            if (NPC_AI.bCorpse076 && NPC_AI.iLoyalty076 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_076); }
            if (NPC_AI.bCorpse077 && NPC_AI.iLoyalty077 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_077); }
            if (NPC_AI.bCorpse078 && NPC_AI.iLoyalty078 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_078); }
            if (NPC_AI.bCorpse079 && NPC_AI.iLoyalty079 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_079); }
            if (NPC_AI.bCorpse080 && NPC_AI.iLoyalty080 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_080); }
            if (NPC_AI.bCorpse081 && NPC_AI.iLoyalty081 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_081); }
            if (NPC_AI.bCorpse082 && NPC_AI.iLoyalty082 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_082); }
            if (NPC_AI.bCorpse083 && NPC_AI.iLoyalty083 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_083); }
            if (NPC_AI.bCorpse084 && NPC_AI.iLoyalty084 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_084); }
            if (NPC_AI.bCorpse085 && NPC_AI.iLoyalty085 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_085); }
            if (NPC_AI.bCorpse086 && NPC_AI.iLoyalty086 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_086); }
            if (NPC_AI.bCorpse087 && NPC_AI.iLoyalty087 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_087); }
            if (NPC_AI.bCorpse088 && NPC_AI.iLoyalty088 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_088); }
            if (NPC_AI.bCorpse089 && NPC_AI.iLoyalty089 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_089); }
            if (NPC_AI.bCorpse090 && NPC_AI.iLoyalty090 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_090); }
            if (NPC_AI.bCorpse091 && NPC_AI.iLoyalty091 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_091); }
            if (NPC_AI.bCorpse092 && NPC_AI.iLoyalty092 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_092); }
            if (NPC_AI.bCorpse093 && NPC_AI.iLoyalty092 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_093); }
            if (NPC_AI.bCorpse094 && NPC_AI.iLoyalty094 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_094); }
            if (NPC_AI.bCorpse095 && NPC_AI.iLoyalty095 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_095); }
            if (NPC_AI.bCorpse096 && NPC_AI.iLoyalty096 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_096); }
            if (NPC_AI.bCorpse097 && NPC_AI.iLoyalty097 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_097); }
            if (NPC_AI.bCorpse098 && NPC_AI.iLoyalty098 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_098); }
            if (NPC_AI.bCorpse099 && NPC_AI.iLoyalty099 > 3) { Lists.MyBestiesDeadSibling.Add(NPC_AI.NPC_099); }

            if (Lists.MyBestiesDeadSibling.Count > 0)
            {
                int iRandomSibling = Program.rand.Next(Lists.MyBestiesDeadSibling.Count);
                sBestieSibling = Lists.MyBestiesDeadSibling[iRandomSibling];
                Lists.MyBestiesDeadSibling.RemoveAt(iRandomSibling);
            }
        }
    }
}
