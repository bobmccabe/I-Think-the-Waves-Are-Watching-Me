using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class AccusationEncounters
    {
        public static bool bSkipNode01;
        public static bool bJumpToAccusation;
        public static bool bTempQueried;

        public static int iParticipant1, iParticipant2, iParticipant3, iParticipant4;

        public static int iAccuse, iPosse;

        public static string
            sTempTraitOne01, sTempTraitOne02, sTempTraitOne03, sTempTraitOne04,
            sTempTraitTwo01, sTempTraitTwo02, sTempTraitTwo03, sTempTraitTwo04,
            sTempTraitThree01, sTempTraitThree02, sTempTraitThree03, sTempTraitThree04;

        public static bool
            bNoteOne01, bNoteOne02, bNoteOne03, bNoteOne04,
            bNoteTwo01, bNoteTwo02, bNoteTwo03, bNoteTwo04,
            bNoteThree01, bNoteThree02, bNoteThree03, bNoteThree04;

        public static bool
            bQueried001, bQueried002, bQueried003, bQueried004, bQueried005,
            bQueried006, bQueried007, bQueried008, bQueried009, bQueried010,
            bQueried011, bQueried012, bQueried013, bQueried014, bQueried015,
            bQueried016, bQueried017, bQueried018, bQueried019, bQueried020,
            bQueried021, bQueried022, bQueried023, bQueried024, bQueried025,
            bQueried026, bQueried027, bQueried028, bQueried029, bQueried030,
            bQueried031, bQueried032, bQueried033, bQueried034, bQueried035,
            bQueried036, bQueried037, bQueried038, bQueried039, bQueried040,
            bQueried041, bQueried042, bQueried043, bQueried044, bQueried045,
            bQueried046, bQueried047, bQueried048, bQueried049, bQueried050,
            bQueried051, bQueried052, bQueried053, bQueried054, bQueried055,
            bQueried056, bQueried057, bQueried058, bQueried059, bQueried060,
            bQueried061, bQueried062, bQueried063, bQueried064, bQueried065,
            bQueried066, bQueried067, bQueried068, bQueried069, bQueried070,
            bQueried071, bQueried072, bQueried073, bQueried074, bQueried075,
            bQueried076, bQueried077, bQueried078, bQueried079, bQueried080,
            bQueried081, bQueried082, bQueried083, bQueried084, bQueried085,
            bQueried086, bQueried087, bQueried088, bQueried089, bQueried090,
            bQueried091, bQueried092, bQueried093, bQueried094, bQueried095,
            bQueried096, bQueried097, bQueried098, bQueried099, bQueried100;

        public static string sTempTraitOne05, sTempTraitTwo05, sTempTraitThree05;

        public static bool bNoteOne05, bNoteTwo05, bNoteThree05;

        public static void Initialize_Accusation()
        {
            bSkipNode01 = bJumpToAccusation = bTempQueried = false;
            iParticipant1 = iParticipant2 = iParticipant3 = iParticipant4 = 0;
            iAccuse = iPosse = 0;

            sTempTraitOne01 = sTempTraitOne02 = sTempTraitOne03 = sTempTraitOne04 =
            sTempTraitTwo01 = sTempTraitTwo02 = sTempTraitTwo03 = sTempTraitTwo04 =
            sTempTraitThree01 = sTempTraitThree02 = sTempTraitThree03 = sTempTraitThree04 = 
            "null";

            bNoteOne01 = bNoteOne02 = bNoteOne03 = bNoteOne04 =
            bNoteTwo01 = bNoteTwo02 = bNoteTwo03 = bNoteTwo04 =
            bNoteThree01 = bNoteThree02 = bNoteThree03 = bNoteThree04 = 
            false;

            sTempTraitOne05 = sTempTraitTwo05 = sTempTraitThree05 = "null";
            bNoteOne05 = bNoteTwo05 = bNoteThree05 = false;
        }

        public static void Reset_bQueried()
        {
            bQueried001 = bQueried002 = bQueried003 = bQueried004 = bQueried005 =
            bQueried006 = bQueried007 = bQueried008 = bQueried009 = bQueried010 =
            bQueried011 = bQueried012 = bQueried013 = bQueried014 = bQueried015 =
            bQueried016 = bQueried017 = bQueried018 = bQueried019 = bQueried020 =
            bQueried021 = bQueried022 = bQueried023 = bQueried024 = bQueried025 =
            bQueried026 = bQueried027 = bQueried028 = bQueried029 = bQueried030 =
            bQueried031 = bQueried032 = bQueried033 = bQueried034 = bQueried035 =
            bQueried036 = bQueried037 = bQueried038 = bQueried039 = bQueried040 =
            bQueried041 = bQueried042 = bQueried043 = bQueried044 = bQueried045 =
            bQueried046 = bQueried047 = bQueried048 = bQueried049 = bQueried050 =
            bQueried051 = bQueried052 = bQueried053 = bQueried054 = bQueried055 =
            bQueried056 = bQueried057 = bQueried058 = bQueried059 = bQueried060 =
            bQueried061 = bQueried062 = bQueried063 = bQueried064 = bQueried065 =
            bQueried066 = bQueried067 = bQueried068 = bQueried069 = bQueried070 =
            bQueried071 = bQueried072 = bQueried073 = bQueried074 = bQueried075 =
            bQueried076 = bQueried077 = bQueried078 = bQueried079 = bQueried080 =
            bQueried081 = bQueried082 = bQueried083 = bQueried084 = bQueried085 =
            bQueried086 = bQueried087 = bQueried088 = bQueried089 = bQueried090 =
            bQueried091 = bQueried092 = bQueried093 = bQueried094 = bQueried095 =
            bQueried096 = bQueried097 = bQueried098 = bQueried099 = bQueried100 =
            false;
        }

        public static void SetAccusationEncounterParticipants()
        {
            //Set the participants for any given random encounter.
            if (Lists.MyPosse.Contains(NPC_AI.tempNPC)) { Lists.MyPosse.Remove(NPC_AI.tempNPC); } // If you accuse someone, they shouldn't help you accuse them. :p

            if (Lists.MyPosse.Count > 2)
            {
                iPosse = 3;
                RandomEncounters.Actor01 = NPC_AI.tempNPC;
                iParticipant2 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor02 = Lists.MyPosse[iParticipant2];
                Lists.MyPosse.RemoveAt(iParticipant2);
                iParticipant3 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor03 = Lists.MyPosse[iParticipant3];
                Lists.MyPosse.RemoveAt(iParticipant3);
                iParticipant4 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor04 = Lists.MyPosse[iParticipant4];
                Lists.MyPosse.RemoveAt(iParticipant4);
            }
            else if (Lists.MyPosse.Count == 2)
            {
                iPosse = 2;
                RandomEncounters.Actor01 = NPC_AI.tempNPC;
                iParticipant2 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor02 = Lists.MyPosse[iParticipant2];
                Lists.MyPosse.RemoveAt(iParticipant2);
                iParticipant3 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor03 = Lists.MyPosse[iParticipant3];
                Lists.MyPosse.RemoveAt(iParticipant3);
            }
            else if (Lists.MyPosse.Count == 1)
            {
                iPosse = 1;
                RandomEncounters.Actor01 = NPC_AI.tempNPC;
                iParticipant2 = Program.rand.Next(Lists.MyPosse.Count);
                RandomEncounters.Actor02 = Lists.MyPosse[iParticipant2];
                Lists.MyPosse.RemoveAt(iParticipant2);
            }
            else if (Lists.MyPosse.Count == 0)
            {
                iPosse = 0;
                RandomEncounters.Actor01 = NPC_AI.tempNPC;
            }
        }

        public static void Reset_ActorTraits()
        {
            sTempTraitOne01 = sTempTraitOne02 = sTempTraitOne03 = sTempTraitOne04 =
            sTempTraitTwo01 = sTempTraitTwo02 = sTempTraitTwo03 = sTempTraitTwo04 =
            sTempTraitThree01 = sTempTraitThree02 = sTempTraitThree03 = sTempTraitThree04 =
            "null";

            bNoteOne01 = bNoteOne02 = bNoteOne03 = bNoteOne04 =
            bNoteTwo01 = bNoteTwo02 = bNoteTwo03 = bNoteTwo04 =
            bNoteThree01 = bNoteThree02 = bNoteThree03 = bNoteThree04 =
            false;
        }

        public static void SetActor05AsTheKiller()
        {
            RandomEncounters.Actor05 = NPC_AI.NPC_100;
            
            if (RandomEncounters.Actor05 == NPC_AI.NPC_100) 
            {
                RandomEncounters.iTempDesireToMove05 = NPC_AI.DesireToMove100;
                RandomEncounters.bTempCorpse05 = NPC_AI.bCorpse100;
                RandomEncounters.iTempLoyalty05 = NPC_AI.iLoyalty100;
                RandomEncounters.iTempMacGuffins05 = NPC_AI.iAvailableMacGuffins100;
                RandomEncounters.sTempWeapons05 = NPC_AI.sAvailableWeapons100;
                sTempTraitOne05 = NPC_Traits.TraitOne100;
                sTempTraitTwo05 = NPC_Traits.TraitTwo100;
                sTempTraitThree05 = NPC_Traits.TraitThree100;
                bNoteOne05 = Notebook.bNoteOne100;
                bNoteTwo05 = Notebook.bNoteTwo100;
                bNoteThree05 = Notebook.bNoteThree100;
            }
        }

        public static void TalkOption_VoiceSuspicions()
        {
            RandomEncounters.Initialize_Actors();

            if (Conversation.bVoiced == true)
            {
                Console.WriteLine("You've already voiced your suspicions this turn. You must end you turn\n\rbefore you may voice your suspicions again.");
                Program.PressAnyKey();
                return;
            }

            Conversation.bVoiced = true;

            NPC_AI.GetAllNPCLocals();
            SetAccusationEncounterParticipants();
            Reset_ActorTraits();
            RandomEncounters.GetAllActorLocals();

            SetActor05AsTheKiller();
            NPC_AI.Actors_PantsDownGenderCheck();

            if (Variables.sGetLocation == LocationEncounters.location_001) { Variables.sStoryLocation = LocationEncounters.sLocation001; }
            if (Variables.sGetLocation == LocationEncounters.location_002) { Variables.sStoryLocation = LocationEncounters.sLocation002; }
            if (Variables.sGetLocation == LocationEncounters.location_003) { Variables.sStoryLocation = LocationEncounters.sLocation003; }
            if (Variables.sGetLocation == LocationEncounters.location_004) { Variables.sStoryLocation = LocationEncounters.sLocation004; }
            if (Variables.sGetLocation == LocationEncounters.location_005) { Variables.sStoryLocation = LocationEncounters.sLocation005; }
            if (Variables.sGetLocation == LocationEncounters.location_006) { Variables.sStoryLocation = LocationEncounters.sLocation006; }
            if (Variables.sGetLocation == LocationEncounters.location_007) { Variables.sStoryLocation = LocationEncounters.sLocation007; }
            if (Variables.sGetLocation == LocationEncounters.location_008) { Variables.sStoryLocation = LocationEncounters.sLocation008; }
            if (Variables.sGetLocation == LocationEncounters.location_009) { Variables.sStoryLocation = LocationEncounters.sLocation009; }
            if (Variables.sGetLocation == LocationEncounters.location_010) { Variables.sStoryLocation = LocationEncounters.sLocation010; }
            if (Variables.sGetLocation == LocationEncounters.location_011) { Variables.sStoryLocation = LocationEncounters.sLocation011; }
            if (Variables.sGetLocation == LocationEncounters.location_012) { Variables.sStoryLocation = LocationEncounters.sLocation012; }
            if (Variables.sGetLocation == LocationEncounters.location_013) { Variables.sStoryLocation = LocationEncounters.sLocation013; }
            if (Variables.sGetLocation == LocationEncounters.location_014) { Variables.sStoryLocation = LocationEncounters.sLocation014; }
            if (Variables.sGetLocation == LocationEncounters.location_015) { Variables.sStoryLocation = LocationEncounters.sLocation015; }
            if (Variables.sGetLocation == LocationEncounters.location_016) { Variables.sStoryLocation = LocationEncounters.sLocation016; }
            if (Variables.sGetLocation == LocationEncounters.location_017) { Variables.sStoryLocation = LocationEncounters.sLocation017; }
            if (Variables.sGetLocation == LocationEncounters.location_018) { Variables.sStoryLocation = LocationEncounters.sLocation018; }
            if (Variables.sGetLocation == LocationEncounters.location_019) { Variables.sStoryLocation = LocationEncounters.sLocation019; }
            if (Variables.sGetLocation == LocationEncounters.location_020) { Variables.sStoryLocation = LocationEncounters.sLocation020; }
            if (Variables.sGetLocation == LocationEncounters.location_021) { Variables.sStoryLocation = LocationEncounters.sLocation021; }
            if (Variables.sGetLocation == LocationEncounters.location_022) { Variables.sStoryLocation = LocationEncounters.sLocation022; }
            if (Variables.sGetLocation == LocationEncounters.location_023) { Variables.sStoryLocation = LocationEncounters.sLocation023; }
            if (Variables.sGetLocation == LocationEncounters.location_024) { Variables.sStoryLocation = LocationEncounters.sLocation024; }
            if (Variables.sGetLocation == LocationEncounters.location_025) { Variables.sStoryLocation = LocationEncounters.sLocation025; }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            // Encounter set-up text:
            if (iPosse == 0)
            {
                if (NPC_AI.iCloseEncounters >= 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I've been watching you. And I've");
                    Console.WriteLine("seen you enough times to know something about you isn't right. In fact,");
                    Console.WriteLine("I think we know that someone's walking around this island, pointing out");
                    Console.WriteLine("who should live and who should die.'");
                    Console.WriteLine();
                }
                else if (NPC_AI.iCloseEncounters < 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I may not have seen you around");
                    Console.WriteLine("much, but my gut says something's not right about you. In fact, I think");
                    Console.WriteLine("we know that someone's walking around this island, pointing out who");
                    Console.WriteLine("should live and who should die.'");
                    Console.WriteLine();
                }
            }
            if (iPosse == 1)
            {
                if (NPC_AI.iCloseEncounters >= 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I've been watching you. And I've");
                    Console.WriteLine("seen you enough times to know something about you isn't right. In fact,");
                    Console.WriteLine("I think we know that someone's walking around this island, pointing out");
                    Console.WriteLine("who should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("As you talk, you notice " + RandomEncounters.Actor02 + " walk over to you. When you stop, " + NPC_AI.sGenderHeShe02 + " says,");
                    Console.WriteLine("'I think I owe you my help on this one, especially if you've got reason to");
                    Console.WriteLine("believe that stopping " + RandomEncounters.Actor01 + " could stop what's happening to us.'");
                    Console.WriteLine();
                }
                else if (NPC_AI.iCloseEncounters < 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I may not have seen you around");
                    Console.WriteLine("much, but my gut says something's not right about you. In fact, I think");
                    Console.WriteLine("we know that someone's walking around this island, pointing out who");
                    Console.WriteLine("should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("As you talk, you notice " + RandomEncounters.Actor02 + " walk over to you. When you stop, " + NPC_AI.sGenderHeShe02 + " says,");
                    Console.WriteLine("'I think I owe you my help on this one, especially if you've got reason to");
                    Console.WriteLine("believe that stopping " + RandomEncounters.Actor01 + " could stop what's happening to us.'");
                    Console.WriteLine();
                }
            }
            if (iPosse == 2)
            {
                if (NPC_AI.iCloseEncounters >= 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I've been watching you. And I've");
                    Console.WriteLine("seen you enough times to know something about you isn't right. In fact,");
                    Console.WriteLine("I think we know that someone's walking around this island, pointing out");
                    Console.WriteLine("who should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("As you talk, " + RandomEncounters.Actor02 + " loudly tells " + RandomEncounters.Actor03 + ", 'Right on. Now there's the kind of");
                    Console.WriteLine("survival-first action we can use.' The duo walk over to you and say, 'We");
                    Console.WriteLine("couldn't help but overhear you. Seems like you've got things figured");
                    Console.WriteLine("out, and if that's the case you can count on us.'");
                    Console.WriteLine();
                }
                else if (NPC_AI.iCloseEncounters < 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I may not have seen you around");
                    Console.WriteLine("much, but my gut says something's not right about you. In fact, I think");
                    Console.WriteLine("we know that someone's walking around this island, pointing out who");
                    Console.WriteLine("should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("As you talk, " + RandomEncounters.Actor02 + " loudly tells " + RandomEncounters.Actor03 + ", 'Right on. Now there's the kind of");
                    Console.WriteLine("survival-first action we can use.' The duo walk over to you and say, 'We");
                    Console.WriteLine("couldn't help but overhear you. Seems like you've got things figured");
                    Console.WriteLine("out, and if that's the case you can count on us.'");
                    Console.WriteLine();
                }
            }
            if (iPosse >= 3)
            {
                if (NPC_AI.iCloseEncounters >= 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I've been watching you. And I've");
                    Console.WriteLine("seen you enough times to know something about you isn't right. In fact,");
                    Console.WriteLine("I think we know that someone's walking around this island, pointing out");
                    Console.WriteLine("who should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("'Well, what do we have here?' Both you and " + RandomEncounters.Actor01 + " turn to spot a few");
                    Console.WriteLine("people walking over. " + RandomEncounters.Actor02 + ", " + RandomEncounters.Actor03 + ", and " + RandomEncounters.Actor04 + " walk over to");
                    Console.WriteLine("you. " + RandomEncounters.Actor04 + " says, 'Did I overhear you say that you have reason to");
                    Console.WriteLine("believe " + RandomEncounters.Actor01 + " is causing all this death around us? Because if that's the");
                    Console.WriteLine("case, we would sure love to help you put " + NPC_AI.sGenderHimHer01 + " down.'");
                    Console.WriteLine();
                }
                else if (NPC_AI.iCloseEncounters < 8)
                {
                    Console.WriteLine("You approach " + RandomEncounters.Actor01 + " and say, 'I may not have seen you around");
                    Console.WriteLine("much, but my gut says something's not right about you. In fact, I think");
                    Console.WriteLine("we know that someone's walking around this island, pointing out who");
                    Console.WriteLine("should live and who should die.'");
                    Console.WriteLine();
                    Console.WriteLine("'Well, what do we have here?' Both you and " + RandomEncounters.Actor01 + " turn to spot a few");
                    Console.WriteLine("people walking over. " + RandomEncounters.Actor02 + ", " + RandomEncounters.Actor03 + ", and " + RandomEncounters.Actor04 + " walk over to");
                    Console.WriteLine("you. " + RandomEncounters.Actor04 + " says, 'Did I overhear you say that you have reason to");
                    Console.WriteLine("believe " + RandomEncounters.Actor01 + " is causing all this death around us? Because if that's the");
                    Console.WriteLine("case, we would sure love to help you put " + NPC_AI.sGenderHimHer01 + " down.'");
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TIP: People who are either 'agreeable' or 'friendly' may get involved");
            Console.WriteLine("and help you out when the going gets tough.");
            Console.WriteLine();

            // start encounter

            Conversation.sMoreTrading = "n"; // (Voicing suspicions will always end turn)

            int iTalkListDisplay = 0;
            int iTalkList01 = 0;
            int iTalkList02 = 0;
            int iTalkList03 = 0;
            int iTalkList04 = 0;
            int iTalkList05 = 0;
            int iTalkList06 = 0;
            int iTalkList07 = 0;
            // int iTalkList08 = 0;
            int iChoseLine = 0;

            Console.ForegroundColor = ConsoleColor.Gray;
            if (RandomEncounters.iTempLoyalty01 != -1) 
            { 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'Be careful where you're going with this. Things can get\n\rreally ugly, really quickly. People could die. Innocent people.'"); 
            }
            if (RandomEncounters.iTempLoyalty01 == -1) 
            { 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'Hey, we've been through this once already. Just leave me\n\ralone. I'm not who you think I am! Please, don't hurt me!'"); 
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (!NPC_Traits.bTraitOne01Bunny && !NPC_Traits.bTraitTwo01Bunny && !NPC_Traits.bTraitThree01Bunny) 
            {
                Console.WriteLine("TIP: You do not currently know anything about the killer. Try to learn");
                Console.WriteLine("the traits that identity who the killer is, and then see which people");
                Console.WriteLine("those traits match to figure out who the killer is."); 
            }
            if (NPC_Traits.bTraitOne01Bunny || NPC_Traits.bTraitTwo01Bunny || NPC_Traits.bTraitThree01Bunny) 
            {
                Console.WriteLine("Reminder: You know that..."); 
            }
            if (NPC_Traits.bTraitOne01Bunny && !NPC_Traits.bTraitTwo01Bunny && !NPC_Traits.bTraitThree01Bunny) 
            { 
                Console.WriteLine(" ... the killer " + NPC_Traits.TraitOneBunny + ".");
            }
            if (!NPC_Traits.bTraitOne01Bunny && !NPC_Traits.bTraitTwo01Bunny && NPC_Traits.bTraitThree01Bunny)
            { 
                Console.WriteLine(" ... the killer " + NPC_Traits.TraitThreeBunny + ".");
            }
            if (NPC_Traits.bTraitOne01Bunny && NPC_Traits.bTraitTwo01Bunny && !NPC_Traits.bTraitThree01Bunny) 
            { 
                Console.WriteLine(" ... the killer " + NPC_Traits.TraitOneBunny + " and " + NPC_Traits.TraitTwoBunny + "."); 
            }
            if (NPC_Traits.bTraitOne01Bunny && !NPC_Traits.bTraitTwo01Bunny && NPC_Traits.bTraitThree01Bunny) 
            { 
                Console.WriteLine(" ... the killer " + NPC_Traits.TraitOneBunny + " and " + NPC_Traits.TraitThreeBunny + ".");
            }
            if (NPC_Traits.bTraitOne01Bunny && NPC_Traits.bTraitTwo01Bunny && NPC_Traits.bTraitThree01Bunny) 
            { 
                Console.WriteLine(" ... the killer " + NPC_Traits.TraitOneBunny + ", " + NPC_Traits.TraitTwoBunny + ", and\n\r" + NPC_Traits.TraitThreeBunny + "."); 
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Choose your option.");
            Console.WriteLine();
            iTalkListDisplay++; iTalkList01 = iTalkListDisplay; Console.WriteLine(iTalkListDisplay + ". You're right. This doesn't need to go any further.");
            // if ((sTempTraitOne01 != sTempTraitOne05) && (sTempTraitThree01 != sTempTraitThree05)) { iTalkListDisplay++; iTalkList02 = iTalkListDisplay; Console.WriteLine(iTalkListDisplay + ". I may not have any evidence against you, but I know you're the killer."); }
            if (RandomEncounters.Actor01 == NPC_AI.NPC_090 || RandomEncounters.Actor01 == NPC_AI.NPC_091 || RandomEncounters.Actor01 == NPC_AI.NPC_092 || 
                RandomEncounters.Actor01 == NPC_AI.NPC_093 || RandomEncounters.Actor01 == NPC_AI.NPC_094 || RandomEncounters.Actor01 == NPC_AI.NPC_095 ||
                RandomEncounters.Actor01 == NPC_AI.NPC_096 || RandomEncounters.Actor01 == NPC_AI.NPC_097 || RandomEncounters.Actor01 == NPC_AI.NPC_098 ||
                RandomEncounters.Actor01 == NPC_AI.NPC_099 || RandomEncounters.Actor01 == NPC_AI.NPC_100)
            { 
                iTalkListDisplay++; iTalkList02 = iTalkListDisplay; Console.WriteLine(iTalkListDisplay + ". I know you've been acting strangely, like you're hiding something.");
            }

            // Start Revised Accusation Code

            // Bunny Clue 3 is active.
            // If BunnyClue3 is known. If NPCTrait1/2/3 is known. And if 1 & 2 & 3 match.
            if (NPC_Traits.bTraitThreeBunny &&
                AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList07 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ", " + sTempTraitTwo01 +
                    ",\n\r   and " + sTempTraitThree01 + ". I've got you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue3 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
            if (NPC_Traits.bTraitThreeBunny &&
                AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList06 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ", and " + sTempTraitTwo01 + ". Just like you.");
                Conversation.sMoreTrading = "n";
            }

            // If BunnyClue3 is known. If NPCTrait1/3 is known. And if 1 & 3 match. Add: AND 2 is UNKNOWN.
            if (NPC_Traits.bTraitThreeBunny &&
                AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList05 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ", and " + sTempTraitThree01 +
                ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue3 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
            if (NPC_Traits.bTraitThreeBunny &&
                AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList03 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitThree01 + ". Same as you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue3 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
            if (NPC_Traits.bTraitThreeBunny &&
                AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // Bunny Clue 2 is active.
            // If BunnyClue2 is known. If NPCTrait1/2/3 is known. And if 1 & 2 match.
            if (NPC_Traits.bTraitTwoBunny &&
                AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList06 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ", and " + sTempTraitTwo01 + ". Just like you.");
                Conversation.sMoreTrading = "n";
            }

            // If BunnyClue2 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
            if (NPC_Traits.bTraitTwoBunny &&
                AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList06 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ", and " + sTempTraitTwo01 + ". Just like you.");
                Conversation.sMoreTrading = "n";
            }

            // If BunnyClue2 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
            if (NPC_Traits.bTraitTwoBunny &&
                AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }


            // If BunnyClue2 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
            if (NPC_Traits.bTraitTwoBunny &&
                AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList03 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitThree01 + ". Same as you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue2 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
            if (NPC_Traits.bTraitTwoBunny &&
                AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // Bunny Clue 1 is active.
            // If BunnyClue1 is known. If NPCTrait1/2/3 is known. And if 1 matches.
            if (NPC_Traits.bTraitOneBunny &&
                AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue1 is known. If NPCTrait1/2 is known. And if 1 matches. Add: AND 3 is UNKNOWN.
            if (NPC_Traits.bTraitOneBunny &&
                AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue1 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
            if (NPC_Traits.bTraitOneBunny &&
                AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue1 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
            if (NPC_Traits.bTraitOneBunny &&
                AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList03 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitThree01 + ". Same as you.");
                Conversation.sMoreTrading = "n"; 
            }

            // If BunnyClue1 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
            if (NPC_Traits.bTraitOneBunny &&
                AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                !Notebook.bCorpseSpotted)
            {
                iTalkListDisplay++;
                iTalkList04 = iTalkListDisplay;
                Console.WriteLine(iTalkListDisplay + ". I know the killer " + sTempTraitOne01 + ". That's you.");
                Conversation.sMoreTrading = "n"; 
            }   

            // End Revised Accusation Code

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out iChoseLine);
            while (/* iChoseLine > iTalkListDisplay || */ iChoseLine <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Please choose from the list.");
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out iChoseLine);
            }
            Console.Clear();
            if (iChoseLine == iTalkList01 && iPosse == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine("Now doesn't seem like the best time to push this. You decide to wait.");
            }
            if (iChoseLine == iTalkList01 && iPosse >= 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Now doesn't seem like the best time to push this. 'Maybe it'd be better");
                Console.WriteLine("if we watched and learned for a while.'");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            // if (iChoseLine == iTalkList02) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(Actor01 + " says, 'Do you hear yourself? You can admit that nothing about me says I'm the\n\rkiller -- and you still want blood?'"); }
            if (iChoseLine == iTalkList02)
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'I look suspicious? What did I do to set you off? Did I look\n\rup-to-the-left instead of up-to-the-right when someone asked if I knew\n\rwhy the lightning's red or why the tidal waves stopped moving? Get the\n\rhell away from me. Now.'"); 
            }
            if (iChoseLine == iTalkList03)
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'And how would you know that? Just because you talk to\n\rme for a minute you think you know who I am enough to decide life or\n\rdeath?'"); 
            }
            if (iChoseLine == iTalkList04)
            {
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'That could describe anyone!'"); 
            }
            if (iChoseLine == iTalkList05)
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " asks, 'And you want to kill me based off that? Did you even take more than a\n\rfew minutes to come to that conclusion?'"); 
            }
            if (iChoseLine == iTalkList06)
            {
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " says, 'You know what I think? I think you've been following me\n\raround, just looking for an excuse to come after me. You've already\n\rmade your decision.'"); 
            }
            if (iChoseLine == iTalkList07)
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(RandomEncounters.Actor01 + " smiles. 'Now the question on everyone's mind is: how do you\n\rknow those three specific traits make me responsible?'"); 
            }

            int iEncounterResolve = 0; // 1 = aborted, 2 = roll, 3 = auto-success
            Console.ForegroundColor = ConsoleColor.Gray;

            if (iPosse == 0) // && iChoseLine != iTalkList01)
            {
                Console.WriteLine();
                Console.WriteLine("Regardless of whether " + RandomEncounters.Actor01 + " is the right person, you're not going to");
                Console.WriteLine("be able to do anything on your own. You'll need at least one person who ");
                Console.WriteLine("is 'agreeable' or 'friendly' to help you stop the killer.");
                Program.PressAnyKey();
            }
            // if (iPosse == 0 && iChoseLine == iTalkList01)
            // {}

            if (iChoseLine == iTalkList01 && iPosse == 1) 
            { 
                iPosse = 0; 
                Console.WriteLine(); Console.WriteLine("'No. It doesn't need to go any further. In fact,' " +
                    RandomEncounters.Actor01 + " says, 'it should never have\n\rstarted. Now leave me alone.'"); 
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased by 1."); 
                RandomEncounters.iTempLoyalty01 = RandomEncounters.iTempLoyalty01 - 1;
                Program.PressAnyKey();
            }
            if (iChoseLine == iTalkList02 && iPosse == 1) 
            { 
                iPosse = 0; 
                Console.WriteLine(); Console.WriteLine(RandomEncounters.Actor02 + " winces, then looks at you. 'That could have gone better.");
                Console.WriteLine("Maybe next time, think things through a little. We start acting without");
                Console.WriteLine("thinking and we're nothing more than animals.'"); 
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 2. "); 
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition set to 0. "); 
                RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 2; 
                RandomEncounters.iTempLoyalty01 = 0;
                Program.PressAnyKey();
            }
            if (iChoseLine == iTalkList03 && iPosse == 1)
            { 
                iPosse = 0; 
                Console.WriteLine(); Console.WriteLine("'Let's pretend, for a moment, that you're right. There's someone causing\n\rthis death. And that person, the supposed killer,' " + RandomEncounters.Actor01 + " sneers,\n\r'" + sTempTraitThree01 + ".'\n\rSo what? Are these traits of extreme rarity? You sound like a fool.'\n\r\n\r" + RandomEncounters.Actor02 + " looks perturbed, but puts " + NPC_AI.sGenderHisHer02 + " hand on your shoulder. 'Hey,\n\rshake it off. Sure, you can do better. And maybe you should have known\n\rbetter. But you're on the right track. And if you can get there, we're all\n\rbetter off. Don't give up. All right?'"); 
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); 
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased to minimum."); 
                RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 1;
                RandomEncounters.iTempLoyalty01 = 0;
                Program.PressAnyKey();
            }
            if (iChoseLine == iTalkList04 && iPosse == 1) 
            { 
                iPosse = 0;
                Console.WriteLine();
                Console.WriteLine("'Let's pretend, for a moment, that you're right. There's someone causing\n\rthis death. And that person, the supposed killer,' " + RandomEncounters.Actor01 + " sneers,\n\r'" + sTempTraitOne01 + ".'\n\r\n\r'So what? Are these traits of extreme rarity? You sound like a fool.'\n\r\n\r" + RandomEncounters.Actor02 + " looks perturbed, but puts " + NPC_AI.sGenderHisHer02 + " hand on your shoulder. 'Hey,\n\rshake it off. Sure, you can do better. And maybe you should have known\n\rbetter. But you're on the right track. And if you can get there, we're all\n\rbetter off. Don't give up. All right?'"); 
                Console.ForegroundColor = ConsoleColor.Cyan; 
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); 
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased to minimum."); 
                RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 1; 
                RandomEncounters.iTempLoyalty01 = 0;
                Program.PressAnyKey();
            }
            if (iChoseLine == iTalkList05 && iPosse == 1) 
            {
                iEncounterResolve = 2; 
            }
            if (iChoseLine == iTalkList06 && iPosse == 1) 
            { 
                iEncounterResolve = 2; 
            }
            if (iChoseLine == iTalkList07 && iPosse == 1) 
            { 
                iEncounterResolve = 3; 
                Console.WriteLine(); 
                Console.WriteLine("'And, more importantly, with 'evidence' like that, why are you");
                Console.WriteLine("so confident? Are you deluding yourself? Did you think I would fall to");
                Console.WriteLine("my knees and beg for mercy because you made an accusation?'"); 
            }
            if (RandomEncounters.iTempLoyalty01 < 0) 
            { 
                RandomEncounters.iTempLoyalty01 = 0;
            }
            if (iChoseLine == iTalkList01 && iPosse == 2) 
            { 
                iEncounterResolve = 1; iAccuse = 6;
            }
            if (iChoseLine == iTalkList02 && iPosse == 2) 
            { 
                iEncounterResolve = 1; iAccuse = 7; 
            }
            if (iChoseLine == iTalkList03 && iPosse == 2) 
            { 
                iEncounterResolve = 1; iAccuse = 8; 
            }
            if ((iChoseLine == iTalkList04 || iChoseLine == iTalkList05) && iPosse == 2)
            {
                iEncounterResolve = 2; iPosse = 1; RandomEncounters.iTempLoyalty03 = 0;
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " holds " + NPC_AI.sGenderHisHer03 + " hand up and the conversation stops, each of you");
                Console.WriteLine("looking at " + NPC_AI.sGenderHimHer03 + " as " + NPC_AI.sGenderHeShe03 + " scrunches up " + NPC_AI.sGenderHisHer03 + " nose like " + NPC_AI.sGenderHeShe03 + " just smelled");
                Console.WriteLine("something funny.");
                Console.WriteLine();
                Console.WriteLine("'No one,' " + NPC_AI.sGenderHeShe03 + " finally says, 'is going to push me to do the wrong thing.'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " opens " + NPC_AI.sGenderHisHer02 + " mouth but " + RandomEncounters.Actor03 + " re-raises " + NPC_AI.sGenderHisHer03 + " arm to shut " + NPC_AI.sGenderHimHer02);
                Console.WriteLine("up. 'No one's going to push me into doing the wrong thing -- and that's");
                Console.WriteLine("what this is. Wrong. You can count me out. I am not a part of this.'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " stops and looks curiously at " + RandomEncounters.Actor02 + ", perhaps wondering if " + NPC_AI.sGenderHeShe02);
                Console.WriteLine("intends to give up as well. But " + RandomEncounters.Actor02 + " shoots a look back at " + RandomEncounters.Actor01);
                Console.WriteLine("that lets " + NPC_AI.sGenderHimHer01 + " know " + NPC_AI.sGenderHeShe02 + "'s not going anywhere.");
            }
            if (iChoseLine == iTalkList06 && iPosse == 2) { iEncounterResolve = 2; }
            if (iChoseLine == iTalkList07 && iPosse == 2) { iEncounterResolve = 3; }
            if (iChoseLine == iTalkList01 && iPosse == 3)
            {
                iPosse = 0;
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + ", " + RandomEncounters.Actor03 + ", and " + RandomEncounters.Actor04 + " look to one another. Then " + RandomEncounters.Actor04);
                Console.WriteLine("nods and turns toward you while " + RandomEncounters.Actor02 + " and " + RandomEncounters.Actor03 + " approach");
                Console.WriteLine(RandomEncounters.Actor01 + ".");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor04 + " puts " + NPC_AI.sGenderHisHer04 + " arm on your shoulder and turns you away from the");
                Console.WriteLine("scene, walking you in the other direction. You resist, but " + RandomEncounters.Actor04 + " stops");
                Console.WriteLine("and looks at you.");
                Console.WriteLine();
                Console.WriteLine("'These are dark times,' " + NPC_AI.sGenderHeShe04 + " begins. 'And dark times call for a certain level");
                Console.WriteLine("of --' " + RandomEncounters.Actor01 + " screams out in pain, but " + RandomEncounters.Actor04 + " is blocking your view.");
                Console.WriteLine(RandomEncounters.Actor04 + " smiles, understandingly. 'Violence,' " + NPC_AI.sGenderHeShe04 + " says. 'And if you're not up for ");
                Console.WriteLine("that, it's fine.' " + RandomEncounters.Actor04 + " pauses for a moment, listening. You hear " + RandomEncounters.Actor01);
                Console.WriteLine("moaning in pain, hear the grunts of " + RandomEncounters.Actor03 + " and " + RandomEncounters.Actor02 + " as they beat");
                Console.WriteLine(NPC_AI.sGenderHimHer01 + ". 'But if we lie back and take it, the fight's already over.'");
                Console.WriteLine();
                Console.WriteLine("'I don't know if " + NPC_AI.sGenderHeShe01 + " was --' you say, but " + RandomEncounters.Actor04 + " hushes you. 'Shh-shh-");
                Console.WriteLine("shh.' You notice that you don't hear " + RandomEncounters.Actor01 + " anymore. 'Don't even say it.");
                Console.WriteLine("Doubt? Remorse? Uncertainty?' " + RandomEncounters.Actor03 + " and " + RandomEncounters.Actor02 + " approach, and");
                Console.WriteLine(RandomEncounters.Actor04 + " turns to them. 'What good are those things?'");
                Console.WriteLine();
                Console.WriteLine("'No good,' they say, one after the other. 'No good,' repeats " + RandomEncounters.Actor04 + ".");
                Console.WriteLine("'No good at all. They're words for fools like you.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased to minimum.");
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased to minimum.");
                Console.WriteLine("   " + RandomEncounters.Actor04 + "'s disposition decreased to minimum.");
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                RandomEncounters.iTempLoyalty02 = 0; RandomEncounters.iTempLoyalty03 = 0; RandomEncounters.iTempLoyalty04 = 0;
                Program.PressAnyKey();
            }
            if (iChoseLine == iTalkList02 && iPosse == 3)
            {
                iEncounterResolve = 2; iPosse = 1; RandomEncounters.iTempLoyalty03 = 0; RandomEncounters.iTempLoyalty04 = 0;
                RandomEncounters.iTempLoyalty03 = 0;
                RandomEncounters.iTempLoyalty04 = 0;
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " and " + RandomEncounters.Actor04 + " look to one another and nod.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " looks at them. 'What's wrong?'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor04 + " says, '" + RandomEncounters.Actor03 + " and I aren't doing this. You're on your own.'");
                Console.WriteLine("The two of them walk away.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " laughs, but " + RandomEncounters.Actor02 + " gives " + NPC_AI.sGenderHimHer01 + " a look of pure malice.");
            }
            if (iChoseLine == iTalkList03 && iPosse == 3)
            {
                iEncounterResolve = 2; iPosse = 2;
                Console.WriteLine();
                Console.WriteLine("'Whoa, hey, stop, let me off. I can't do this.' " + RandomEncounters.Actor04 + " looks at each of");
                Console.WriteLine("you. 'And seriously, what's wrong with you people? This craziness, this -- ");
                Console.WriteLine("I don't know what to call it. But something's messing with us, and us");
                Console.WriteLine("doing this isn't -- it's nothing we'd ever do. Not in a million years.'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " says,'" + RandomEncounters.Actor04 + ", we're not doing this because we want to,");
                Console.WriteLine("we're doing it to, hopefully, saves lives.' " + RandomEncounters.Actor04 + " looks to " + RandomEncounters.Actor02 + ",");
                Console.WriteLine("who simply nods in agreement with " + RandomEncounters.Actor03 + "'s sentiment. " + RandomEncounters.Actor04);
                Console.WriteLine("stands uncertain for a moment but finally paces off, unable to look.");
                Console.WriteLine();
                Console.WriteLine("All attention returns to " + RandomEncounters.Actor01 + ", who holds " + NPC_AI.sGenderHisHer01 + " arms up. 'Wait -- " + NPC_AI.sGenderHeShe04 + " has ");
                Console.WriteLine("a point. Would you kill someone because of their appearance? Would ");
                Console.WriteLine("you?' " + RandomEncounters.Actor01 + " looks at each of you. 'We can figure this out. We can talk. ");
                Console.WriteLine("We can --'");
                bSkipNode01 = true;
            }
            if (iChoseLine == iTalkList04 && iPosse == 3)
            {
                iEncounterResolve = 2; iPosse = 2;
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor04 + " shakes " + NPC_AI.sGenderHisHer04 + " head. 'Excuse me for interrupting this little lynching");
                Console.WriteLine("you have going on, but I guess I thought that there was a little more");
                Console.WriteLine("substance behind the placement of guilt. I'm going to stand over there");
                Console.WriteLine("while you all resolve whatever issues you have.'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " looks to " + RandomEncounters.Actor04 + " and asks, 'Are you serious?' " + RandomEncounters.Actor04 + " doesn't ");
                Console.WriteLine("respond. 'Doesn't matter. We've got three of us. And right there");
                Console.WriteLine("we've got " + RandomEncounters.Actor01 + ", the " + NPC_AI.sGenderGuyGirl01 + " who's the spitting image.' The words trail off.");
                Console.WriteLine("The spitting image of who, you wonder. Who could make the world feel");
                Console.WriteLine("like a dream? Like a nightmare?");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " breaks your revelry. 'Look, we can work this out. Talk it through.");
                Console.WriteLine(RandomEncounters.Actor04 + " is using common sense. Right? We can all use it. Let's talk.'");
                RandomEncounters.iTempLoyalty04 = 0;
                bSkipNode01 = true;
            }
            if (iChoseLine == iTalkList05 && iPosse == 3) { iEncounterResolve = 3; }
            if (iChoseLine == iTalkList06 && iPosse == 3) { iEncounterResolve = 3; }
            if (iChoseLine == iTalkList07 && iPosse == 3) { iEncounterResolve = 3; }

            // conclude encounter
            if (iPosse == 1 && iEncounterResolve == 2)
            {
                int iLynch = Program.rand.Next(1, 4);
                if (iLynch == 1) { iAccuse = 1; } // player +1, NPC runs away
                if (iLynch == 2) { iAccuse = 2; } // player +1, NPC is killed, helper dies (accikill)
                if (iLynch == 3) { iAccuse = 3; } // player +1, NPC is killed
            }
            if (iPosse == 1 && iEncounterResolve == 3)
            {
                int iLynch = Program.rand.Next(1, 3);
                if (iLynch == 1) { iAccuse = 4; } // player +1, Auto-success, helper dies (accikill)
                if (iLynch == 2) { iAccuse = 5; } // player +1, Auto-success, helper lives, +1 disposition
            }
            if (iPosse == 2 && iEncounterResolve == 1 && (iAccuse != 6 && iAccuse != 7 && iAccuse != 8))
            {
                int iLynch = Program.rand.Next(1, 3);
                if (iLynch == 1) { iAccuse = 6; } // player +2, encounter aborted, option A (- disposition)
                if (iLynch == 2) { iAccuse = 7; } // player +2, encounter aborted, option B
            }
            if (iPosse == 2 && iEncounterResolve == 2)
            {
                int iLynch = Program.rand.Next(1, 3);
                if (iLynch == 1) { iAccuse = 9; } // player +2, the NPC is killed
                if (iLynch == 2) { iAccuse = 10; } // player +2, the NPC is killed, 1 helper dies (accikill)
            }
            if (iPosse == 2 && iEncounterResolve == 3)
            {
                iAccuse = 11; // player +2, Auto-success, only option
            }
            if (iPosse == 3 && iEncounterResolve == 3)
            {
                int iLynch = Program.rand.Next(1, 3);
                if (iLynch == 1) { iAccuse = 12; } // player +3, Auto-success, option A
                if (iLynch == 2) { iAccuse = 13; } // player +3, Auto-success, option B
            }

            if (iAccuse == 1 || iAccuse == 2 || iAccuse == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Something flashes across " + RandomEncounters.Actor01 + "'s face. An expression of -- fear?");
                Console.WriteLine("Treachery? Anger? ... Guilt? Each seems equally likely.");
            }

            if (iAccuse == 1)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " fixes " + NPC_AI.sGenderHisHer01 + " gaze on you, watching you as closely as you're");
                Console.WriteLine("watching " + NPC_AI.sGenderHimHer01 + ". That's when you realize " + NPC_AI.sGenderHeShe01 + "'s trying to distract you from");
                Console.WriteLine("seeing that " + NPC_AI.sGenderHeShe01 + "'s slowly backing away.");
                Console.WriteLine();
                Console.WriteLine("You look to " + RandomEncounters.Actor02 + " to see if " + NPC_AI.sGenderHeShe02 + " sees what's happening. And in the");
                Console.WriteLine("space of that slight shift in your attention, " + RandomEncounters.Actor01 + " turns and runs.");
                Console.WriteLine();
                Console.WriteLine("Before you can take a step, " + RandomEncounters.Actor02 + " says, 'Let " + NPC_AI.sGenderHimHer01 + " go. " + RandomEncounters.Actor01 + "'s guard is");
                Console.WriteLine("up and it's only going to make things more difficult. But I don't think " + NPC_AI.sGenderHeShe01);
                Console.WriteLine("runs if " + NPC_AI.sGenderHeShe02 + "'s innocent. I call fleeing an acknowledgement of guilt.'");
                Console.WriteLine();
                Console.WriteLine("Is it? You think about that as you plan your next action.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " disposition set to 'Afraid'.");
                RandomEncounters.iTempLoyalty01 = -1; RandomEncounters.iTempDesireToMove01 = 100;
                Program.PressAnyKey();
            }
            if (iAccuse == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You look to " + RandomEncounters.Actor02 + ", and " + NPC_AI.sGenderHeShe02 + " returns your look with a subtle shrug of");
                Console.WriteLine("the shoulders.");
                Console.WriteLine();
                Console.WriteLine("That's when you notice a blur of movement out of the corner of your");
                Console.WriteLine("eye. You turn to see " + RandomEncounters.Actor01 + " leap at " + RandomEncounters.Actor02 + ", catching " + NPC_AI.sGenderHimHer02 + " completely");
                Console.WriteLine("unaware with a brick to the side of " + NPC_AI.sGenderHisHer02 + " head. The makeshift weapon hits ");
                Console.WriteLine(NPC_AI.sGenderHimHer02 + " solidly in the side of the head, and " + RandomEncounters.Actor02 + "'s body goes limp, eyes ");
                Console.WriteLine("rolling back as " + NPC_AI.sGenderHeShe02 + " crumples heavily to the ground.");
                Console.WriteLine();
                Console.WriteLine("As you rush to " + RandomEncounters.Actor02 + "'s side, " + RandomEncounters.Actor01 + " leaves -- and you're left to ");
                Console.WriteLine("wonder if such an extreme action was about preservation or malice.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor02 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor01 + " disposition set to 'Afraid'.");
                RandomEncounters.iTempLoyalty01 = -1; RandomEncounters.iTempDesireToMove01 = 100; RandomEncounters. bTempCorpse02 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor02);
                Program.PressAnyKey();
            }
            if (iAccuse == 3)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " says 'Not one more step,' interrupting your internal debate. ");
                Console.WriteLine("That's when you notice that " + RandomEncounters.Actor01 + " is a bit further back than " + NPC_AI.sGenderHeShe01 + " had ");
                Console.WriteLine("been.");
                Console.WriteLine();
                Console.WriteLine("'Look, it's not me!' " + RandomEncounters.Actor01 + " protests, a hint of panic in " + NPC_AI.sGenderHisHer01 + " voice. 'Please, ");
                Console.WriteLine("you don't know' -- but before " + NPC_AI.sGenderHeShe01 + " can finish, " + RandomEncounters.Actor02 + " hits " + NPC_AI.sGenderHimHer01 + " hard ");
                Console.WriteLine("enough to drop " + NPC_AI.sGenderHimHer01 + " to " + NPC_AI.sGenderHisHer01 + " knees.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " faces you but is lost in the moment and doesn't seem to ");
                Console.WriteLine("actually see you. 'You started this,' " + NPC_AI.sGenderHeShe02 + " says while taking a step away ");
                Console.WriteLine("from " + RandomEncounters.Actor01 + ".");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " is swaying on " + NPC_AI.sGenderHisHer01 + " knees and lost in a stupor. You force the");
                Console.WriteLine("image back and hit " + NPC_AI.sGenderHimHer01 + " in the face, then hit " + NPC_AI.sGenderHimHer01 + " again. " + RandomEncounters.Actor02 + " rejoins");
                Console.WriteLine("you, and the two of you do your best to make it quick.");
                Console.WriteLine();
                Console.WriteLine("When it's done, " + RandomEncounters.Actor02 + " says, 'Desperate times' without completing ");
                Console.WriteLine("the proverb. The words echo in your head.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                if (Variables.weaponName != NPC_AI.sWeaponType0) { Console.WriteLine("   Lost your " + Variables.weaponName + "."); Variables.weaponName = NPC_AI.sWeaponType0; }
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Program.PressAnyKey();
            }
            if (iAccuse == 4)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " looks incredulous. 'To the end with the denials. I have to admit");
                Console.WriteLine("this is pretty boring. We've got you and you can't squirm your way out");
                Console.WriteLine("of this. I may not know a thing about how or why this is happening, but");
                Console.WriteLine("I'm convinced you're responsible.'");
                Console.WriteLine();
                if (RandomEncounters.sTempWeapons02 == NPC_AI.sWeaponType0)
                { Console.WriteLine(RandomEncounters.Actor01 + " spits at " + RandomEncounters.Actor02 + ", and " + NPC_AI.sGenderHeShe02 + " responds with a jab to " + NPC_AI.sGenderHisHer01 + " face."); }
                if (RandomEncounters.sTempWeapons02 != NPC_AI.sWeaponType0)
                { Console.WriteLine(RandomEncounters.Actor01 + " spits at " + RandomEncounters.Actor02 + ", and " + NPC_AI.sGenderHeShe02 + " responds with a " + RandomEncounters.sTempWeapons02 + " to " + NPC_AI.sGenderHisHer01 + " head."); }
                Console.WriteLine(RandomEncounters.Actor01 + " absorbs the attack and responds with one of " + NPC_AI.sGenderHisHer01 + " own,");
                Console.WriteLine("catching " + RandomEncounters.Actor02 + " in the neck. " + RandomEncounters.Actor02 + " stumbles awkwardly to the");
                Console.WriteLine("ground, then looks up at you with a look of surprise on " + NPC_AI.sGenderHisHer02 + " face. Blood is");
                Console.WriteLine("pouring out from a wound in " + NPC_AI.sGenderHisHer02 + " neck, and " + NPC_AI.sGenderHeShe02 + " is making gurgling noises.");
                Console.WriteLine();
                Console.WriteLine("Motion at the edge of your vision brings you back to reality, and you");
                Console.WriteLine("narrowly avoid another strike from " + RandomEncounters.Actor01 + ". Taking no chances, you dive");
                Console.WriteLine("at " + NPC_AI.sGenderHisHer01 + " mid-section and throw " + NPC_AI.sGenderHimHer01 + " to the ground. The hit from " + RandomEncounters.Actor02 + "");
                Console.WriteLine("and being slammed to the ground take the fight out of " + NPC_AI.sGenderHimHer01 + ". A few more");
                Console.WriteLine("hits take " + NPC_AI.sGenderHisHer01 + " life as well.");
                Console.WriteLine();
                Console.WriteLine("You stand and look over at " + RandomEncounters.Actor02 + "'s body, then down to " + RandomEncounters.Actor01 + " at");
                Console.WriteLine("your feet. Two deaths. Were they worth it? Will they change anything?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + " is dead.");
                RandomEncounters. bTempCorpse01 = true; RandomEncounters. bTempCorpse02 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor02);
                Program.PressAnyKey();
            }
            if (iAccuse == 5)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " laughs. 'You've got me? It sounds like you've watched too many");
                Console.WriteLine("bad cop shows.'");
                Console.WriteLine();
                Console.WriteLine("There's a haughty look in " + NPC_AI.sGenderHisHer01 + " expression, a blend of confidence");
                Console.WriteLine("regarding " + NPC_AI.sGenderHisHer01 + " innocence, or maybe confidence in " + NPC_AI.sGenderHisHer01 + " cleverness. But that");
                Console.WriteLine("look is quickly replaced by one of shock as " + NPC_AI.sGenderHeShe01 + " falls over backward trying");
                Console.WriteLine("to avoid a wild swing from " + RandomEncounters.Actor02 + ", and then another. " + RandomEncounters.Actor02);
                Console.WriteLine("presses the attack, finally closing the distance and connecting with");
                Console.WriteLine(RandomEncounters.Actor01 + " once, twice, and a third time.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor02 + " over-extends " + NPC_AI.sGenderHimHer02 + "self and falls forward, bringing " + RandomEncounters.Actor01 + " down");
                Console.WriteLine("with " + NPC_AI.sGenderHimHer02 + ". The two grapple on the ground for a moment before " + RandomEncounters.Actor02);
                Console.WriteLine("manages to get " + NPC_AI.sGenderHisHer02 + " arms wrapped around " + NPC_AI.sGenderHisHer01 + " neck. The two of them");
                Console.WriteLine("gaze blankly in your general direction as they struggle, " + RandomEncounters.Actor01 + "'s life");
                Console.WriteLine("slowly fading away -- but at the moment of " + NPC_AI.sGenderHisHer01 + " death, " + RandomEncounters.Actor01 + "'s blank");
                Console.WriteLine("expression focuses intently on you. The look " + NPC_AI.sGenderHeShe01 + " gives you  -- you're not");
                Console.WriteLine("certain what it means. But it leaves you with feelings of doubt rushing");
                Console.WriteLine("through you. Though " + RandomEncounters.Actor01 + " passes, the doubt lingers.");
                Console.WriteLine();
                Console.WriteLine("You hear " + RandomEncounters.Actor02 + "'s labored breathing afterward, and you help " + NPC_AI.sGenderHimHer02 + " to");
                Console.WriteLine(NPC_AI.sGenderHisHer02 + " feet while wondering if this changes anything.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition increased by 1.");
                RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 + 1;
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Program.PressAnyKey();
            }
            if (iAccuse == 6)
            {
                Console.WriteLine();
                Console.WriteLine("'What is this?' " + RandomEncounters.Actor02 + " asks. 'Why are you wasting our time?' " + RandomEncounters.Actor03);
                Console.WriteLine("shoves you and echoes " + RandomEncounters.Actor02 + ". 'I'm ready to do something. We're");
                Console.WriteLine("down to the wire here. And you've got us here bothering people that");
                Console.WriteLine("don't need to be bothered?' The two of them walk away. As they do,");
                Console.WriteLine(RandomEncounters.Actor01 + " makes no effort to hide the smile on " + NPC_AI.sGenderHisHer01 + " face.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty01 = RandomEncounters.iTempLoyalty01 - 1;
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 - 1;
                if (RandomEncounters.iTempLoyalty01 < 0) { RandomEncounters.iTempLoyalty01 = 0; }
                Program.PressAnyKey();
            }
            if (iAccuse == 7)
            {
                Console.WriteLine();
                Console.WriteLine("'Wait, wait, wait,' says " + RandomEncounters.Actor02 + ". " + RandomEncounters.Actor03 + " turns and walks up to you");
                Console.WriteLine("and looks you directly in the face. " + RandomEncounters.Actor02 + " lets loose an exasperated");
                Console.WriteLine("sigh. " + RandomEncounters.Actor03 + " says, while poking you in the chest every few words,");
                Console.WriteLine("'You're saying, right here in front of us all, that " + RandomEncounters.Actor01 + " is acting");
                Console.WriteLine("strangely, and that's it? That's everything you've got?'");
                Console.WriteLine();
                Console.WriteLine("There's a pause, and then " + RandomEncounters.Actor02 + " says, 'Come on. We're leaving");
                Console.WriteLine(RandomEncounters.Actor01 + " alone. Sorry about all this, but someone around here is a");
                Console.WriteLine("nimrod. I wonder who that would be,' " + NPC_AI.sGenderHeShe02 + " says with a look in your");
                Console.WriteLine("direction.");
                RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 2;
                RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 - 2;
                RandomEncounters.iTempLoyalty01 = 0;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased to minimum.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 2.");
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 2.");
                Program.PressAnyKey();
            }
            if (iAccuse == 8)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " appears quite calm. After a pause, " + NPC_AI.sGenderHeShe01 + " says, 'What? Nothing else?");
                Console.WriteLine("That's everything? I suppose it's at least enough for you to round up a");
                Console.WriteLine("couple of thugs and try to get someone killed, right?'");
                Console.WriteLine();
                Console.WriteLine("'Hey,' " + RandomEncounters.Actor03 + " objects. 'We're not thugs. And we didn't get rounded up.'");
                Console.WriteLine();
                Console.WriteLine("'Actually, yeah,' " + RandomEncounters.Actor02 + " says with a sigh. 'That's exactly what");
                Console.WriteLine("happened.' " + RandomEncounters.Actor02 + " and " + RandomEncounters.Actor03 + " both give you a pointed look. As the");
                Console.WriteLine("intensity of their gaze wilts you, you can almost feel " + RandomEncounters.Actor01 + " tap dancing");
                Console.WriteLine("behind them. 'If we're going to get anything done,' " + RandomEncounters.Actor02 + " continues.");
                Console.WriteLine("'it's not going to be by listening to someone who only goes half of the");
                Console.WriteLine("way.'");
                Console.WriteLine();
                Console.WriteLine("'I have to admit,' " + RandomEncounters.Actor03 + " says. 'I'm definitely disappointed in how this");
                Console.WriteLine("played out.'");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty01 = RandomEncounters.iTempLoyalty01 - 1;
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 - 1;
                RandomEncounters.iTempLoyalty01 = 0;
                if (RandomEncounters.iTempLoyalty01 < 0) { RandomEncounters.iTempLoyalty01 = 0; }
                Program.PressAnyKey();
            }
            if (iAccuse == 9 && !bSkipNode01)
            {
                Console.WriteLine();
                Console.WriteLine("'And now you're telling me that I fit some profile that you more than");
                Console.WriteLine("likely fabricated? If it smells like a witch hunt, it just might be one.'");
                Console.WriteLine();
                Console.WriteLine("'More than likely?' asks " + RandomEncounters.Actor03 + ". " + RandomEncounters.Actor02 + " says, 'Yeah, I caught that,");
                Console.WriteLine("too. Doesn't seem like the way you phrase something when you know");
                Console.WriteLine("you're innocent.'");
                Console.WriteLine();
                Console.WriteLine("'What? I don't -- you've got me flustered,' " + RandomEncounters.Actor01 + " says. 'We can talk");
                Console.WriteLine("about this. Can't we?'");
            }
            if (iAccuse == 9) { bSkipNode01 = false; }
            if (iAccuse == 9 && !bSkipNode01)
            {
                Console.WriteLine();
                Console.WriteLine("There's a sickening thud as " + RandomEncounters.Actor03 + " hits " + RandomEncounters.Actor01 + " hard in the face. 'No,'");
                Console.WriteLine(NPC_AI.sGenderHeShe03 + " says, 'we're done talking.'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " holds " + NPC_AI.sGenderHisHer01 + " hands to " + NPC_AI.sGenderHisHer01 + " face, then looks at them to see them");
                Console.WriteLine("dripping with " + NPC_AI.sGenderHisHer01 + " blood. " + RandomEncounters.Actor01 + " turns to run but " + RandomEncounters.Actor03 + " grabs " + NPC_AI.sGenderHimHer01 + " from");
                Console.WriteLine("behind, dragging " + NPC_AI.sGenderHimHer01 + " down to the ground and holding " + NPC_AI.sGenderHimHer01 + " while");
                Console.WriteLine(RandomEncounters.Actor02 + " stomps and kicks at " + NPC_AI.sGenderHimHer01 + ". You join in and help them end it");
                Console.WriteLine("quickly, and as mercifully as possible given the circumstances.");
                Console.WriteLine();
                Console.WriteLine("With " + RandomEncounters.Actor01 + "'s death, the three of you look to one another, though");
                Console.WriteLine("none of you say a word. A moment later, " + RandomEncounters.Actor03 + " looks to the night");
                Console.WriteLine("sky, and you feel your gaze follow. You wonder if there will be more");
                Console.WriteLine("lightning -- if anything else will change.");
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 + 1;
                Program.PressAnyKey();
            }
            if (iAccuse == 10 && !bSkipNode01)
            {
                Console.WriteLine();
                Console.WriteLine("'And now you're telling me that I fit some profile that you more than");
                Console.WriteLine("likely fabricated? If it smells like a witch hunt, it just might be one.'");
                Console.WriteLine();
                Console.WriteLine("'More than likely?' asks " + RandomEncounters.Actor03 + ". " + RandomEncounters.Actor02 + " says, 'Yeah, I caught that,");
                Console.WriteLine("too. Doesn't seem like the way you phrase something when you know");
                Console.WriteLine("you're innocent.'");
                Console.WriteLine();
                Console.WriteLine("'What? I don't -- you've got me flustered,' " + RandomEncounters.Actor01 + " says. 'We can talk");
                Console.WriteLine("about this. Can't we?' " + RandomEncounters.Actor01 + " takes a step backward but trips and falls");
                Console.WriteLine("to the ground.");
            }
            if (iAccuse == 10) { bSkipNode01 = false; }
            if (iAccuse == 10 && !bSkipNode01)
            {
                Console.WriteLine();
                Console.WriteLine("From your position, you see " + RandomEncounters.Actor01 + " is using " + NPC_AI.sGenderHisHer01 + " body to conceal a large");
                Console.WriteLine("nearby rock from " + RandomEncounters.Actor03 + ". As " + NPC_AI.sGenderHeShe03 + " leans down toward " + NPC_AI.sGenderHimHer01 + ",");
                Console.WriteLine(RandomEncounters.Actor01 + "'s hand wraps around the rock. '" + RandomEncounters.Actor03 + "!' you shout -- too late.");
                Console.WriteLine("The rock strikes " + NPC_AI.sGenderHimHer03 + " in the side of the head with a sickening sound, and");
                Console.WriteLine(RandomEncounters.Actor03 + " goes completely limp and sprawls out next to her, dead.");
                Console.WriteLine();
                Console.WriteLine("You pin " + NPC_AI.sGenderHimHer01 + " down before " + NPC_AI.sGenderHeShe01 + " can reload for a second swing, then ");
                Console.WriteLine("wrestle the rock away from " + NPC_AI.sGenderHimHer01 + " while " + RandomEncounters.Actor02 + " hits " + NPC_AI.sGenderHimHer01 + " a few times in ");
                Console.WriteLine("the face. There's a brief opening when " + RandomEncounters.Actor02 + " stops swinging, and you ");
                Console.WriteLine("strike with the rock, then again to make certain.");
                Console.WriteLine();
                Console.WriteLine("You and " + RandomEncounters.Actor02 + " look to one another, then to " + RandomEncounters.Actor03 + "'s dead body -- ");
                Console.WriteLine("then to " + RandomEncounters.Actor01 + "'s.");
                RandomEncounters. bTempCorpse01 = true; RandomEncounters. bTempCorpse03 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor03);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor03 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 - 1;
                RandomEncounters.iTempLoyalty01 = 0;
                Program.PressAnyKey();
            }
            if (iAccuse == 11)
            {
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " and " + RandomEncounters.Actor02 + " look to one another, and then to " + RandomEncounters.Actor01 + ".");
                Console.WriteLine(RandomEncounters.Actor02 + " says, 'It's true, isn't it? But why? I don't understand.' As");
                Console.WriteLine(RandomEncounters.Actor02 + " speaks, you catch " + RandomEncounters.Actor01 + " turn " + NPC_AI.sGenderHisHer01 + " head slightly, using " + NPC_AI.sGenderHisHer01);
                Console.WriteLine("peripheral vision. You spot a brick lying nearby. " + RandomEncounters.Actor01 + " takes a half-step");
                Console.WriteLine("toward it, then another. " + RandomEncounters.Actor03 + " looks over to you and sees where");
                Console.WriteLine("you're looking. You take a cautious step forward.");
                Console.WriteLine();
                Console.WriteLine("'Don't you have anything to say for yourself? Aren't you going to cry");
                Console.WriteLine("about how you're innocent?'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " takes another half-step. 'Innocence,' " + NPC_AI.sGenderHeShe01 + " snorts. 'And what");
                Console.WriteLine("would be the point? You want blood. And you made up some rules to");
                Console.WriteLine("justify your lust. Oh, we can kill people -- but only if they're tall. Or short.");
                Console.WriteLine("You want blood, and you don't care what I have to say about it.'");
                Console.WriteLine();
                Console.WriteLine("At that moment, " + NPC_AI.sGenderHeShe01 + " spins and lunges for the ground, but the three of");
                Console.WriteLine("you were all anticipating this. As the closest, you shove " + NPC_AI.sGenderHimHer01 + " in the back as");
                Console.WriteLine("" + NPC_AI.sGenderHeShe01 + " bends, causing " + NPC_AI.sGenderHimHer01 + " to stumble and fall over. " + RandomEncounters.Actor03 + " and " + RandomEncounters.Actor02);
                Console.WriteLine("pin " + NPC_AI.sGenderHimHer01 + " down, and then the three of you work to end " + NPC_AI.sGenderHisHer01 + " life quickly.");
                Console.WriteLine();
                Console.WriteLine("'Was " + NPC_AI.sGenderHeShe01 + " right?' You take a moment to catch your breath, the strange");
                Console.WriteLine("realization of murder creeping in. " + RandomEncounters.Actor02 + " responds, 'Maybe one day");
                Console.WriteLine("we'll look back on this moment and know, with certainty, whether what");
                Console.WriteLine("we did here was right. But I'll take that chance every time. We did what");
                Console.WriteLine("we had to.' The quiet gives you a moment to ponder over " + NPC_AI.sGenderHisHer02 + " words, and");
                Console.WriteLine("wait to see if this death is different from the others.");
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 + 1;
                Program.PressAnyKey();
            }
            if (iAccuse == 12)
            {
                Console.WriteLine();
                Console.WriteLine("Your group cautiously forms a circle around " + RandomEncounters.Actor01 + " as " + NPC_AI.sGenderHeShe01 + " turns left and ");
                Console.WriteLine("right, shuffling this way or that to maintain some distance. Wordlessly, ");
                Console.WriteLine("and in unison, you pounce on " + NPC_AI.sGenderHimHer01 + " -- hitting " + NPC_AI.sGenderHimHer01 + " wherever there's an ");
                Console.WriteLine("opening. " + RandomEncounters.Actor01 + " struggles, but not for long. Soon, " + NPC_AI.sGenderHeShe01 + "'s lying on the ");
                Console.WriteLine("ground dead, though " + RandomEncounters.Actor04 + " hits " + NPC_AI.sGenderHimHer01 + " a couple more times for ");
                Console.WriteLine("certainty. Afterward, the group looks satisfied, but you have already ");
                Console.WriteLine("moved on -- wondering: what happens now?");
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition increased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition increased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor04 + "'s disposition increased by 1."); RandomEncounters.iTempLoyalty04 = RandomEncounters.iTempLoyalty04 + 1;
                Program.PressAnyKey();
            }
            if (iAccuse == 13)
            {
                Console.WriteLine();
                Console.WriteLine("Behind you, " + RandomEncounters.Actor04 + " says, 'You know what would give me so much");
                Console.WriteLine("satisfaction?' You turn to look at " + NPC_AI.sGenderHimHer04 + ". 'Hearing you admit it. Come on.");
                Console.WriteLine("It's so boring to deny it all. Why not embrace it?'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor01 + " stares at each of you in turn, but says nothing. " + RandomEncounters.Actor03);
                Console.WriteLine("interrupts the silence. 'So be it. Let's get this over with.'");
                Console.WriteLine();
                Console.WriteLine("At that, " + RandomEncounters.Actor01 + " throws " + NPC_AI.sGenderHimHer01 + "self into your midst. You catch " + NPC_AI.sGenderHimHer01 + " and force");
                Console.WriteLine(NPC_AI.sGenderHimHer01 + " to the ground. It's a flurry of punches and kicks that force " + RandomEncounters.Actor01);
                Console.WriteLine("into submission. When " + NPC_AI.sGenderHeShe01 + " relents, you stop to catch your breath.");
                Console.WriteLine(RandomEncounters.Actor01 + " reaches up, then drags " + NPC_AI.sGenderHimHer01 + "self forward a few inches.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor04 + " laughs. " + RandomEncounters.Actor03 + " and " + RandomEncounters.Actor02 + " look at " + NPC_AI.sGenderHimHer04 + " with sickened");
                Console.WriteLine("expressions.");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor03 + " asks, 'What's wrong with you? Don't you get what's going on?'");
                Console.WriteLine();
                Console.WriteLine(RandomEncounters.Actor04 + " snaps back testily, 'Do you? Because I don't think you do.' As");
                Console.WriteLine(NPC_AI.sGenderHeShe04 + " speaks, " + NPC_AI.sGenderHeShe04 + " stands over " + RandomEncounters.Actor01 + ", reaches down, grabs " + NPC_AI.sGenderHisHer01 + " head and");
                Console.WriteLine("pulls it up, then kicks down hard on the back of " + NPC_AI.sGenderHisHer01 + " neck, exhaling");
                Console.WriteLine("loudly with the effort. Afterward, " + NPC_AI.sGenderHeShe04 + " repeats it a few more times.");
                Console.WriteLine();
                Console.WriteLine("'And trust me,' " + NPC_AI.sGenderHeShe04 + " says when " + NPC_AI.sGenderHeShe04 + "'s done. 'I get it. Kill or be killed. That's");
                Console.WriteLine("what's happening right here. And I know what end I want to be on.'");
                Console.WriteLine();
                Console.WriteLine("You think about what " + NPC_AI.sGenderHeShe04 + " said: 'I know what end I want to be on.'");
                Console.WriteLine("And then you look down to " + RandomEncounters.Actor01 + "'s corpse. To what ends will we go to");
                Console.WriteLine("save ourselves? Will we go so far as to lose ourselves?");
                RandomEncounters. bTempCorpse01 = true;
                Lists.RemainingNPCs.Remove(RandomEncounters.Actor01);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   " + RandomEncounters.Actor01 + " is dead.");
                Console.WriteLine("   " + RandomEncounters.Actor02 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty02 = RandomEncounters.iTempLoyalty02 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor03 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty03 = RandomEncounters.iTempLoyalty03 + 1;
                Console.WriteLine("   " + RandomEncounters.Actor04 + "'s disposition decreased by 1."); RandomEncounters.iTempLoyalty04 = RandomEncounters.iTempLoyalty04 + 1;
                Program.PressAnyKey();
            }
            if (RandomEncounters.iTempLoyalty02 < 0) { RandomEncounters.iTempLoyalty02 = 0; }
            if (RandomEncounters.iTempLoyalty03 < 0) { RandomEncounters.iTempLoyalty03 = 0; }
            if (RandomEncounters.iTempLoyalty04 < 0) { RandomEncounters.iTempLoyalty04 = 0; }
            if (RandomEncounters.iTempLoyalty01 > 5) { RandomEncounters.iTempLoyalty01 = 5; }
            if (RandomEncounters.iTempLoyalty02 > 5) { RandomEncounters.iTempLoyalty02 = 5; }
            if (RandomEncounters.iTempLoyalty03 > 5) { RandomEncounters.iTempLoyalty03 = 5; }
            if (RandomEncounters.iTempLoyalty04 > 5) { RandomEncounters.iTempLoyalty04 = 5; }

            Console.ForegroundColor = ConsoleColor.White;

            // check if NPC100 is killed (this is temp. Later, do this as a random encounter at the start of the next turn.
            if (RandomEncounters.bTempCorpse01 && RandomEncounters.Actor01 == NPC_AI.NPC_100)
            {
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: You stopped the killer. Good on you.");
                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
            }
            else if (RandomEncounters.bTempCorpse01 && RandomEncounters.Actor01 != NPC_AI.NPC_100)
            {
                Variables.iAcciKilled = Variables.iAcciKilled + 1;
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: Just between me and you, an innocent died. Oops!");
                //Console.WriteLine("A wrongful death has been attributed to your score. Them's the breaks.");
                //Console.WriteLine("If this is not accurate, file a bug!");
            }
            if (RandomEncounters.bTempCorpse02 && RandomEncounters.Actor02 == NPC_AI.NPC_100)
            {
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: You stopped the killer. Good on you.");
                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
            }
            else if (RandomEncounters.bTempCorpse02 && RandomEncounters.Actor02 != NPC_AI.NPC_100)
            {
                Variables.iAcciKilled = Variables.iAcciKilled + 1;
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: Just between me and you, an innocent died. Oops!");
                //Console.WriteLine("A wrongful death has been attributed to your score. Them's the breaks.");
                //Console.WriteLine("If this is not accurate, file a bug!");
            }
            if (RandomEncounters.bTempCorpse03 && RandomEncounters.Actor03 == NPC_AI.NPC_100)
            {
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: You stopped the killer. Good on you.");
                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
            }
            else if (RandomEncounters.bTempCorpse03 && RandomEncounters.Actor03 != NPC_AI.NPC_100)
            {
                Variables.iAcciKilled = Variables.iAcciKilled + 1;
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: Just between me and you, an innocent died. Oops!");
                //Console.WriteLine("A wrongful death has been attributed to your score. Them's the breaks.");
                //Console.WriteLine("If this is not accurate, file a bug!");
            }
            if (RandomEncounters.bTempCorpse04 && RandomEncounters.Actor04 == NPC_AI.NPC_100)
            {
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: You stopped the killer. Good on you.");
                Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
            }
            else if (RandomEncounters.bTempCorpse04 && RandomEncounters.Actor04 != NPC_AI.NPC_100)
            {
                Variables.iAcciKilled = Variables.iAcciKilled + 1;
                //Console.WriteLine();
                //Console.WriteLine("TEMP TEXT: Just between me and you, an innocent died. Oops!");
                //Console.WriteLine("A wrongful death has been attributed to your score. Them's the breaks.");
                //Console.WriteLine("If this is not accurate, file a bug!");
            }
            NPC_AI.tempNPC = "null";

            Variables.iTurnsSinceEncounter = Variables.iTurnsSinceEncounter - 3;
            if (Variables.iTurnsSinceEncounter < 0) { Variables.iTurnsSinceEncounter = 0; }

            RandomEncounters.SetAllActorLocals();

            Console.WriteLine();

            if (NPC_AI.bCorpse100)
            {
                NPC_AI.NPC100_PantsDownGenderCheck();
                AccusationEncounters.GameOver_AccusationWin();
                Program.PressAnyKey();
            }
        }

        public static void GameOver_AccusationWin()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("For several minutes, nothing happens. Then you notice people");
            Console.WriteLine("approaching, as if called to this spot. But no one speaks in anything");
            Console.WriteLine("louder than a whisper. And people move slowly, when they move at all.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("When all eyes are on " + NPC_AI.NPC_100 + "'s corpse, a strange hum comes from");
            Console.WriteLine("within it. And then neon-red lightning arcs out from within, dancing ");
            Console.WriteLine("across the surface of " + NPC_AI.sGenderHisHer + " body.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The lightning quickly intensifies, then stops abruptly for a long beat");
            Console.WriteLine("before exploding out from within. You cover your eyes and turn away,");
            Console.WriteLine("but feel nothing more than comforting heat on your back. Carefully, you");
            Console.WriteLine("turn back and look.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The world has taken on a rosy glow that makes the clouds and tidal");
            Console.WriteLine("waves look black in contrast. Even some of the red light that pours out");
            Console.WriteLine("from within " + NPC_AI.NPC_100 + "'s corpse is accented with dark lines.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And then a disturbing feeling invades you -- a suspicion that something");
            Console.WriteLine("isn't right, that this is not how things were meant to go. You turn and");
            Console.WriteLine("look at the gathered faces, each person rubbing their eyes or yawning");
            Console.WriteLine("as if they had just awoken. It seems like this is right, but you can't shake");
            Console.WriteLine("the worry at the base of your skull.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("As you try to repress the uncertainty, a beacon of red erupts from the");
            Console.WriteLine("jetty's end. And, as it does, the waves begin their march anew, quickly");
            Console.WriteLine("pushing across the island. You and the remaining survivors move quickly");
            Console.WriteLine("for the beacon.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The beacon illuminates a large opening in the nearby tidal wave, an");
            Console.WriteLine("arched, tall, wide opening like that of an entrance to some medieval");
            Console.WriteLine("castle. Wind blows harshly around you, and there is a sound like giant");
            Console.WriteLine("beams of metal groaning as they are bent against their will.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You stop to take a breath, then turn to help the people behind you");
            Console.WriteLine("step through the portal. When each has finished passing through into");
            Console.WriteLine("the wave's darkness, you turn to survey the island one last time -- only");
            Console.WriteLine("to note that there's nothing left to see.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Your heart sinks and your stomach turns as you look away and walk");
            Console.WriteLine("through the beacon's light and into the darkness within the tidal wave,");
            Console.WriteLine("wondering where it leads.");
            if (!Title.bAchievement04)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Title.bAchievement04 = true;
                Console.WriteLine("   Secret Discovered: " + Title.sAchievement04);
            }
            Console.WriteLine();
            Console.WriteLine();
            Variables.playerSurvived = Variables.sPlayerState5;
        }
    }
}