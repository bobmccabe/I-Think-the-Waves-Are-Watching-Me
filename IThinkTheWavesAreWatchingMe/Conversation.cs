using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Conversation
    {
        public static bool
        bAlreadyTalked001, bAlreadyTalked002, bAlreadyTalked003, bAlreadyTalked004, bAlreadyTalked005,
        bAlreadyTalked006, bAlreadyTalked007, bAlreadyTalked008, bAlreadyTalked009, bAlreadyTalked010,
        bAlreadyTalked011, bAlreadyTalked012, bAlreadyTalked013, bAlreadyTalked014, bAlreadyTalked015,
        bAlreadyTalked016, bAlreadyTalked017, bAlreadyTalked018, bAlreadyTalked019, bAlreadyTalked020,
        bAlreadyTalked021, bAlreadyTalked022, bAlreadyTalked023, bAlreadyTalked024, bAlreadyTalked025,
        bAlreadyTalked026, bAlreadyTalked027, bAlreadyTalked028, bAlreadyTalked029, bAlreadyTalked030,
        bAlreadyTalked031, bAlreadyTalked032, bAlreadyTalked033, bAlreadyTalked034, bAlreadyTalked035,
        bAlreadyTalked036, bAlreadyTalked037, bAlreadyTalked038, bAlreadyTalked039, bAlreadyTalked040,
        bAlreadyTalked041, bAlreadyTalked042, bAlreadyTalked043, bAlreadyTalked044, bAlreadyTalked045,
        bAlreadyTalked046, bAlreadyTalked047, bAlreadyTalked048, bAlreadyTalked049, bAlreadyTalked050,
        bAlreadyTalked051, bAlreadyTalked052, bAlreadyTalked053, bAlreadyTalked054, bAlreadyTalked055,
        bAlreadyTalked056, bAlreadyTalked057, bAlreadyTalked058, bAlreadyTalked059, bAlreadyTalked060,
        bAlreadyTalked061, bAlreadyTalked062, bAlreadyTalked063, bAlreadyTalked064, bAlreadyTalked065,
        bAlreadyTalked066, bAlreadyTalked067, bAlreadyTalked068, bAlreadyTalked069, bAlreadyTalked070,
        bAlreadyTalked071, bAlreadyTalked072, bAlreadyTalked073, bAlreadyTalked074, bAlreadyTalked075,
        bAlreadyTalked076, bAlreadyTalked077, bAlreadyTalked078, bAlreadyTalked079, bAlreadyTalked080,
        bAlreadyTalked081, bAlreadyTalked082, bAlreadyTalked083, bAlreadyTalked084, bAlreadyTalked085,
        bAlreadyTalked086, bAlreadyTalked087, bAlreadyTalked088, bAlreadyTalked089, bAlreadyTalked090,
        bAlreadyTalked091, bAlreadyTalked092, bAlreadyTalked093, bAlreadyTalked094, bAlreadyTalked095,
        bAlreadyTalked096, bAlreadyTalked097, bAlreadyTalked098, bAlreadyTalked099, bAlreadyTalked100;

        public static int iSpeaker, iAskOncePerTurn, iFakeOut, iAskedMacGuffins, iOfferedMacGuffins, iSkipToBottom;

        public static bool bTempTalked, bOneTalk, bVoiced;

        public static string query, sLookedForNPC, sMoreTrading, tempSwapVar;

        public static bool bValidName;

        public static int
        iSpeaker001, iSpeaker002, iSpeaker003, iSpeaker004, iSpeaker005,
        iSpeaker006, iSpeaker007, iSpeaker008, iSpeaker009, iSpeaker010,
        iSpeaker011, iSpeaker012, iSpeaker013, iSpeaker014, iSpeaker015,
        iSpeaker016, iSpeaker017, iSpeaker018, iSpeaker019, iSpeaker020,
        iSpeaker021, iSpeaker022, iSpeaker023, iSpeaker024, iSpeaker025,
        iSpeaker026, iSpeaker027, iSpeaker028, iSpeaker029, iSpeaker030,
        iSpeaker031, iSpeaker032, iSpeaker033, iSpeaker034, iSpeaker035,
        iSpeaker036, iSpeaker037, iSpeaker038, iSpeaker039, iSpeaker040,
        iSpeaker041, iSpeaker042, iSpeaker043, iSpeaker044, iSpeaker045,
        iSpeaker046, iSpeaker047, iSpeaker048, iSpeaker049, iSpeaker050,
        iSpeaker051, iSpeaker052, iSpeaker053, iSpeaker054, iSpeaker055,
        iSpeaker056, iSpeaker057, iSpeaker058, iSpeaker059, iSpeaker060,
        iSpeaker061, iSpeaker062, iSpeaker063, iSpeaker064, iSpeaker065,
        iSpeaker066, iSpeaker067, iSpeaker068, iSpeaker069, iSpeaker070,
        iSpeaker071, iSpeaker072, iSpeaker073, iSpeaker074, iSpeaker075,
        iSpeaker076, iSpeaker077, iSpeaker078, iSpeaker079, iSpeaker080,
        iSpeaker081, iSpeaker082, iSpeaker083, iSpeaker084, iSpeaker085,
        iSpeaker086, iSpeaker087, iSpeaker088, iSpeaker089, iSpeaker090,
        iSpeaker091, iSpeaker092, iSpeaker093, iSpeaker094, iSpeaker095,
        iSpeaker096, iSpeaker097, iSpeaker098, iSpeaker099, iSpeaker100;

        // Lines of "Dialogue"!
        // "Action lines" that fire between minutes remaining 120-109.

        public static string
        sLine001, sLine002, sLine003, sLine004, sLine005,
        sLine006, sLine007, sLine008, sLine009, sLine010,
        sLine011, sLine012, sLine013, sLine014, sLine015,
        sLine016, sLine017, sLine018;

        // "Action lines" that fire between minutes remaining 108-98.
        
        public static string
        sLine100, sLine101, sLine102, sLine103, sLine104,
        sLine105, sLine106, sLine107, sLine108, sLine109,
        sLine110, sLine111, sLine112, sLine113, sLine114,
        sLine115;

        // "Spoken lines" that fire between minutes remaining 97-35.

        public static string
        sLine200, sLine201, sLine202, sLine203, sLine204,
        sLine205, sLine206, sLine207, sLine208, sLine209,
        sLine210, sLine211, sLine212, sLine213, sLine214,
        sLine215, sLine216, sLine217, sLine218, sLine219,
        sLine220;

        // "Action lines" that fire after the tidal waves begin to move again, minutes remaining 34-1.
        public static string
        sLine300, sLine301, sLine302, sLine303, sLine304,
        sLine305, sLine306, sLine307, sLine308, sLine309,
        sLine310, sLine311, sLine312, sLine313, sLine314,
        sLine315, sLine316, sLine317, sLine318, sLine319,
        sLine320, sLine321, sLine322, sLine323, sLine324;

        // "Action lines" for the red herrings/killer that fire between minutes remaining 108-1.

        public static string
        sLine400, sLine401, sLine402, sLine403, sLine404,
        sLine405, sLine406, sLine407, sLine408, sLine409,
        sLine410, sLine411, sLine412, sLine413, sLine414,
        sLine415, sLine416;

        // "Spoken lines" for the red herrings/killer that fire between minutes remaining 108-1.
        public static string
        sLine417, sLine418, sLine419;

        // Lines that fire during the final 16 turns when everyone is dying.
        public static string
        sLine600, sLine601, sLine602, sLine603, sLine604,
        sLine605, sLine606;

        // Other Miscellaneous Messages
        public static string
        sLine800, sLine801, sLine802;

        // Death messages.
        public static string
        sLine900, sLine901, sLine902;

        public static void Initialize_Conversation()
        {
            bAlreadyTalked001 = bAlreadyTalked002 = bAlreadyTalked003 = bAlreadyTalked004 = bAlreadyTalked005 =
            bAlreadyTalked006 = bAlreadyTalked007 = bAlreadyTalked008 = bAlreadyTalked009 = bAlreadyTalked010 =
            bAlreadyTalked011 = bAlreadyTalked012 = bAlreadyTalked013 = bAlreadyTalked014 = bAlreadyTalked015 =
            bAlreadyTalked016 = bAlreadyTalked017 = bAlreadyTalked018 = bAlreadyTalked019 = bAlreadyTalked020 =
            bAlreadyTalked021 = bAlreadyTalked022 = bAlreadyTalked023 = bAlreadyTalked024 = bAlreadyTalked025 =
            bAlreadyTalked026 = bAlreadyTalked027 = bAlreadyTalked028 = bAlreadyTalked029 = bAlreadyTalked030 =
            bAlreadyTalked031 = bAlreadyTalked032 = bAlreadyTalked033 = bAlreadyTalked034 = bAlreadyTalked035 =
            bAlreadyTalked036 = bAlreadyTalked037 = bAlreadyTalked038 = bAlreadyTalked039 = bAlreadyTalked040 =
            bAlreadyTalked041 = bAlreadyTalked042 = bAlreadyTalked043 = bAlreadyTalked044 = bAlreadyTalked045 =
            bAlreadyTalked046 = bAlreadyTalked047 = bAlreadyTalked048 = bAlreadyTalked049 = bAlreadyTalked050 =
            bAlreadyTalked051 = bAlreadyTalked052 = bAlreadyTalked053 = bAlreadyTalked054 = bAlreadyTalked055 =
            bAlreadyTalked056 = bAlreadyTalked057 = bAlreadyTalked058 = bAlreadyTalked059 = bAlreadyTalked060 =
            bAlreadyTalked061 = bAlreadyTalked062 = bAlreadyTalked063 = bAlreadyTalked064 = bAlreadyTalked065 =
            bAlreadyTalked066 = bAlreadyTalked067 = bAlreadyTalked068 = bAlreadyTalked069 = bAlreadyTalked070 =
            bAlreadyTalked071 = bAlreadyTalked072 = bAlreadyTalked073 = bAlreadyTalked074 = bAlreadyTalked075 =
            bAlreadyTalked076 = bAlreadyTalked077 = bAlreadyTalked078 = bAlreadyTalked079 = bAlreadyTalked080 =
            bAlreadyTalked081 = bAlreadyTalked082 = bAlreadyTalked083 = bAlreadyTalked084 = bAlreadyTalked085 =
            bAlreadyTalked086 = bAlreadyTalked087 = bAlreadyTalked088 = bAlreadyTalked089 = bAlreadyTalked090 =
            bAlreadyTalked091 = bAlreadyTalked092 = bAlreadyTalked093 = bAlreadyTalked094 = bAlreadyTalked095 =
            bAlreadyTalked096 = bAlreadyTalked097 = bAlreadyTalked098 = bAlreadyTalked099 = bAlreadyTalked100 = false;

            query = "null_query";
            sLookedForNPC = "null_sLookedForNPC";

            iSpeaker001 = iSpeaker002 = iSpeaker003 = iSpeaker004 = iSpeaker005 =
            iSpeaker006 = iSpeaker007 = iSpeaker008 = iSpeaker009 = iSpeaker010 =
            iSpeaker011 = iSpeaker012 = iSpeaker013 = iSpeaker014 = iSpeaker015 =
            iSpeaker016 = iSpeaker017 = iSpeaker018 = iSpeaker019 = iSpeaker020 =
            iSpeaker021 = iSpeaker022 = iSpeaker023 = iSpeaker024 = iSpeaker025 =
            iSpeaker026 = iSpeaker027 = iSpeaker028 = iSpeaker029 = iSpeaker030 =
            iSpeaker031 = iSpeaker032 = iSpeaker033 = iSpeaker034 = iSpeaker035 =
            iSpeaker036 = iSpeaker037 = iSpeaker038 = iSpeaker039 = iSpeaker040 =
            iSpeaker041 = iSpeaker042 = iSpeaker043 = iSpeaker044 = iSpeaker045 =
            iSpeaker046 = iSpeaker047 = iSpeaker048 = iSpeaker049 = iSpeaker050 =
            iSpeaker051 = iSpeaker052 = iSpeaker053 = iSpeaker054 = iSpeaker055 =
            iSpeaker056 = iSpeaker057 = iSpeaker058 = iSpeaker059 = iSpeaker060 =
            iSpeaker061 = iSpeaker062 = iSpeaker063 = iSpeaker064 = iSpeaker065 =
            iSpeaker066 = iSpeaker067 = iSpeaker068 = iSpeaker069 = iSpeaker070 =
            iSpeaker071 = iSpeaker072 = iSpeaker073 = iSpeaker074 = iSpeaker075 =
            iSpeaker076 = iSpeaker077 = iSpeaker078 = iSpeaker079 = iSpeaker080 =
            iSpeaker081 = iSpeaker082 = iSpeaker083 = iSpeaker084 = iSpeaker085 =
            iSpeaker086 = iSpeaker087 = iSpeaker088 = iSpeaker089 = iSpeaker090 =
            iSpeaker091 = iSpeaker092 = iSpeaker093 = iSpeaker094 = iSpeaker095 =
            iSpeaker096 = iSpeaker097 = iSpeaker098 = iSpeaker099 = iSpeaker100 =
            999;

            iFakeOut = 0;

            iOfferedMacGuffins = 0;

            iSpeaker = 1;

            iAskOncePerTurn = 0;

            bOneTalk = bVoiced = false;

            bTempTalked = false;

            sMoreTrading = "null";

            tempSwapVar = "null";

            iAskedMacGuffins = 0;

            iSkipToBottom = 0;

            // Lines of Dialogue!

            // Action lines that fire between minutes remaining 120-109.
            sLine001 = ("{0} is quietly humming a tune.");
            sLine002 = ("{0} is straightening {1} clothes.");
            sLine003 = ("{0} is rubbing {1} eyes.");
            sLine004 = ("{0} is cleaning {1} glasses.");
            sLine005 = ("{0} looks to be deep in thought.");
            sLine006 = ("{0} is concentrating on something.");
            sLine007 = ("{0} is asking if anyone has a spare MacGuffin or two.");
            sLine008 = ("{0} is tying {1} shoes.");
            sLine009 = ("{0} is digging through {1} pockets.");
            sLine010 = ("{0} is scratching {1} head.");
            
            // Spoken lines that fire between minutes remaining 120-109.
            sLine011 = ("{0} says, 'Those walls of water are just beautiful at night.'");
            sLine012 = ("{0} says, 'Do you think the waves will stand like that forever?'");
            sLine013 = ("{0} says, 'I love this time of year, when summer breaks to fall.'");
            sLine014 = ("{0} says, 'I'm so glad the tourists are gone for the year.'");
            sLine015 = ("{0} says, 'I think I found a MacGuffin. Is that what this is?'");
            sLine016 = ("{0} says, 'What are these wedge things for? Are these MacGuffins?'");
            sLine017 = ("{0} says, 'What a beautiful night. Isn't it?'");
            sLine018 = ("{0} says, 'I wonder if waves like these walled off other places.'");

            // Action lines that fire between minutes remaining 108-98 
            sLine100 = ("{0} is talking to no one in particular.");
            sLine101 = ("{0} is praying quietly.");
            sLine102 = ("{0} is calling out for someone named Mark.");
            sLine103 = ("{0} is calling out for someone named Gina.");
            sLine104 = ("{0} is crouched on the ground, hugging {1}self and crying.");
            sLine105 = ("{0} is biting {1} finger nails; {2} looks scared.");
            sLine106 = ("{0} is fidgeting.");
            sLine107 = ("{0} is crouched on the ground, covering {1} ears and shaking {1} head.");
            
            // Spoken lines that fire between minutes remaining 108-98
            sLine108 = ("{0} asks, 'Did anyone else hear that? It's like a dam cracked.'");
            sLine109 = ("{0} asks, 'What was that sound? I don't like this.'");
            sLine110 = ("{0} says, 'I just heard this strange voice. But I couldn't understand it.'");
            sLine111 = ("{0} asks, 'Did you hear that? What were those voices saying?'");
            sLine112 = ("{0} is talking to {1}self, saying 'It's all in your head. It's OK. It's not real.'");
            sLine113 = ("{0} says, 'I have this odd feeling of hope and optimism. I don't....'");
            sLine114 = ("{0} says, 'Cleansing? Is that -- what? A cleansing? I don't understand.'");
            sLine115 = ("{0} says, 'Release? Whose release? Wait, I think it means us. I... oh no.'");

            // Spoken lines that fire between minutes remaining 97-35
            sLine200 = ("{0} says, 'One-by-one-by-one, lighting strikes and someone else dies.");
            sLine201 = ("{0} is taking deep breaths. 'I'm really worried,' {1} says.");
            sLine202 = ("{0} sits down and says, 'I don't know how to deal with this... this....'");
            sLine203 = ("{0} says aloud, 'Do you think we're all going to die? I do.'");
            sLine204 = ("{0} says, 'The killer is one of us. He, or she, touches us and we die.'");
            sLine205 = ("{0} says, 'I saw two people alone, and then lightning hit one of them.'");
            sLine206 = ("{0} says, 'I don't understand. Is someone making that lightning happen?'");
            sLine207 = ("{0} says, 'I don't want to die. I'm not ready.'");
            sLine208 = ("{0} says, 'I don't think the killer is one of us. I think it's the Devil.'");
            sLine209 = ("{0} says, 'I think this is a Biblical flood. It has to be.'");
            sLine210 = ("{0} says, 'I think I saw -- no, never mind. I can't even say it.'");
            sLine211 = ("{0} says, 'The animals are spooked. I just saw a bunny hop down the street.'");
            sLine212 = ("{0} says, 'People keep dying from lightning, but no one ever sees it happen.'");
            sLine213 = ("{0} says, 'Did you see that? It was like a deep-red bolt of lightning.'");
            sLine214 = ("{0} says, 'I heard this voice tell me I'm going to die. I don't want to die.'");
            sLine215 = ("{0} says, 'Tidal waves that don't move? Red lightning? What is this?'");
            sLine216 = ("{0} is mumbling, '... cleansed. Filthy, dirty. We must be cleansed. Filthy.'");
            sLine217 = ("{0} says, 'This isn't something from the Bible. This is too... different.'");
            sLine218 = ("{0} says, 'We're the lucky chosen few. We are blessed.'");
            sLine219 = ("{0} says, 'I feel like I'm dreaming. Is this real? It can't be. It makes no sense.'");
            sLine220 = ("{0} says, 'He said we could escape. But why? This is amazing. So beautiful.'");

            // Action lines that fire after the tidal waves begin to move again, minutes remaining 34-1.
            sLine300 = ("{0} is running around popping rain bubbles and getting wet.");
            sLine301 = ("{0} is splashing in the water. {1} is smiling, and playing like a little kid.");
            sLine302 = ("{0} sits down on the wet ground, beaming a big smile and looking content.");
            sLine303 = ("{0} is looking to the west at the slowly approaching tidal waves.");
            sLine304 = ("{0} takes off {1} clothes and spins around in the rain.");
            sLine305 = ("{0} cries for a moment, then stops to start laughing.");
            sLine306 = ("{0} brushes water and hair back from {1} face.");
            sLine307 = ("{0} is popping rain bubbles with {1} mouth with a loud 'chomp' sound.");
            sLine308 = ("{0} is giggling.");
            sLine309 = ("{0} is kicking water up into the air and watching it fall.");
            sLine310 = ("{0} is standing still, smiling, eye closed, face looking heavenward.");
            
            // Spoken lines that fire after the tidal waves begin to move again, minutes remaining 34-1.
            sLine311 = ("{0} says, 'I feel like a kid again. This is the best day I've ever had.'");
            sLine312 = ("{0} says, 'This rain is so warm and relaxing. I love it.'");
            sLine313 = ("{0} says, 'I feel so happy. I think I feel like dancing!'");
            sLine314 = ("{0} says, 'How is this possible? These rain drops are so huge!'");
            sLine315 = ("{0} says, 'I saw a bunny and I think he winked at me. It was so cute.'");
            sLine316 = ("{0} points to the tidal waves. 'They're so close.' {1} claps in anticipation.");
            sLine317 = ("{0} keeps saying, 'I knew it'; {1} looks satisfied about something.");
            sLine318 = ("{0} says, 'I hope everyone is experiencing this, and not just our island.'");
            sLine319 = ("{0} says, 'It's so beautiful. It's all just so... beautiful.'");
            sLine320 = ("{0} keeps saying, 'Clean. It's all so squeaky clean now. Clean. It's all...'");
            sLine321 = ("{0} says, 'Part of me wants to dive into the tidal wave. Should I?'");
            sLine322 = ("{0} says, 'Are the waves telling us to go east? I'd rather just stay right here.'");
            sLine323 = ("{0} says, 'My cheeks hurt from smiling so much, but I can't help it.'");
            sLine324 = ("{0} says, 'All my stress is gone. Vanished. I feel so light and free.'");

            // Action lines for the red herrings/killer that fire between minutes remaining 108-1.
            sLine400 = ("{0} is looking around, as if for something in particular.");
            sLine401 = ("{0} nods {1} head in your direction.");
            sLine402 = ("{0} is looking around for something, but stops when {1} notices you.");
            sLine403 = ("{0} suddenly stops what {1} was doing.");
            sLine404 = ("{0} is wiping dirt from {1} hands and feet.");
            sLine405 = ("{0} is wiping dirt from {1} clothes.");
            sLine406 = ("{0} is cleaning something off {1} shoes.");
            sLine407 = ("{0} is watching you intently.");
            sLine408 = ("{0} is watching you curiously.");
            sLine409 = ("{0} looks away when {1} notices you looking at {2}.");
            sLine410 = ("{0} looks around for a moment before writing something into a notepad.");
            sLine411 = ("{0} is looking around, seemingly nervous about something.");
            sLine412 = ("{0} seems to be waiting for something, and looks irritated about it.");
            sLine413 = ("{0} is pacing back and forth.");
            sLine414 = ("{0} looks at you for a moment, then writes something into a notepad.");
            sLine415 = ("{0} is looking off to the west, and seems anxious or impatient.");
            sLine416 = ("{0} is biting {1} finger nails and seems anxious.");

            // Spoken lines for the red herrings/killer that fire between minutes remaining 108-1.
            sLine417 = ("{0} asks 'What are you looking at?'");
            sLine418 = ("{0} holds eye contact with you for a long moment before saying 'Hello.'");
            sLine419 = ("{0} says, 'This all seems familiar, somehow -- like it's happened before.'");

            // Lines that fire during the final 16 turns when everyone is dying.
            sLine600 = ("{0} says, 'I don't know what's come over me. I'm so sleepy.'");
            sLine601 = ("{0} says, 'It's such a struggle to keep my eyes open anymore.'");
            sLine602 = ("{0} says, 'Oh my, I can't stop yawning. I'm so sleepy.'");
            sLine603 = ("{0} says, 'I just want to lie down and rest my eyes for a while.'");
            sLine604 = ("{0} says, 'The water's so warm. I think I might just lie down in it.'");
            sLine605 = ("{0} says, 'I feel about ready for the best sleep ever.'");
            sLine606 = ("{0} says, ''");

            // Other Miscellaneous Messages
            sLine800 = "The tidal waves have made that area too dangerous. Choose some place safer.";
            sLine801 = "You walk toward ";
            sLine802 = "You run toward ";

            // Death Messages
            sLine900 = "You look over your shoulder and realize that the tidal waves are far\r\ncloser than you had originally thought.\r\n\r\n\r\nYou turn slowly to face them, stumbling slightly as you tilt your head\r\nback to lift your gaze to their full height. As close as they had been, as\r\nlong as you'd been able to watch them -- this feels wholly different. It's\r\nmagical.\r\n\r\n\r\nInstinctively, you reach your hand out. They're so close, almost close\r\nenough to touch. You reach your hand out further still, and then take a\r\nstep, hypnotized by the ripples of water which flow across its surface.";
            sLine901 = "\r\n\r\nAnd then you're pulled away - lifted faster and faster, moving so fast\r\nthat the churning wave seems to have stopped completely, the two of\r\nyou moving in perfect harmony.\r\n\r\n\r\nYou look down and see the island far below you, surrounded by the\r\nbehemoths. For a moment there is sadness; the story of the island is\r\nalmost complete, but you will never know it. And then there is nothing.";
            sLine902 = "\r\n\r\nBut then a shadow flits across that surface, counter to the ripples -- and\r\nyou instinctively back away from the wave. You're not sure what you\r\nsaw, but the realization of it sends a chill through you. Suddenly the\r\nwater around you feels quite cold, and you want nothing more than to\r\nbe far away from here. You turn and run.";
        }

        public static void ResetAllTempConversationVariables()
        {
            iSpeaker001 = iSpeaker002 = iSpeaker003 = iSpeaker004 = iSpeaker005 = iSpeaker006 = iSpeaker007 = iSpeaker008 = iSpeaker009 = iSpeaker010 =
            iSpeaker011 = iSpeaker012 = iSpeaker013 = iSpeaker014 = iSpeaker015 = iSpeaker016 = iSpeaker017 = iSpeaker018 = iSpeaker019 = iSpeaker020 =
            iSpeaker021 = iSpeaker022 = iSpeaker023 = iSpeaker024 = iSpeaker025 = iSpeaker026 = iSpeaker027 = iSpeaker028 = iSpeaker029 = iSpeaker030 =
            iSpeaker031 = iSpeaker032 = iSpeaker033 = iSpeaker034 = iSpeaker035 = iSpeaker036 = iSpeaker037 = iSpeaker038 = iSpeaker039 = iSpeaker040 =
            iSpeaker041 = iSpeaker042 = iSpeaker043 = iSpeaker044 = iSpeaker045 = iSpeaker046 = iSpeaker047 = iSpeaker048 = iSpeaker049 = iSpeaker050 =
            iSpeaker051 = iSpeaker052 = iSpeaker053 = iSpeaker054 = iSpeaker055 = iSpeaker056 = iSpeaker057 = iSpeaker058 = iSpeaker059 = iSpeaker060 =
            iSpeaker061 = iSpeaker062 = iSpeaker063 = iSpeaker064 = iSpeaker065 = iSpeaker066 = iSpeaker067 = iSpeaker068 = iSpeaker069 = iSpeaker070 =
            iSpeaker071 = iSpeaker072 = iSpeaker073 = iSpeaker074 = iSpeaker075 = iSpeaker076 = iSpeaker077 = iSpeaker078 = iSpeaker079 = iSpeaker080 =
            iSpeaker081 = iSpeaker082 = iSpeaker083 = iSpeaker084 = iSpeaker085 = iSpeaker086 = iSpeaker087 = iSpeaker088 = iSpeaker089 = iSpeaker090 =
            iSpeaker091 = iSpeaker092 = iSpeaker093 = iSpeaker094 = iSpeaker095 = iSpeaker096 = iSpeaker097 = iSpeaker098 = iSpeaker099 = iSpeaker100 =
            0;

            // Additional INTs
            // iAskOncePerTurn = 0;
            iFakeOut = 0;
            iSpeaker = 0;
            Variables.iKnowRoll = 0;
            NPC_AI.iSetSpeaker = 0;
            NPC_AI.iTempDesireToMove = 0;
            NPC_AI.iTempLocation = 0;
            NPC_AI.iTempLastLocation = 0;
            NPC_AI.iTempLoyalty = 0;
            NPC_AI.iTempMacGuffins = 0;
            NPC_AI.tempNPC = "null";

            // STRINGs
            NPC_AI.sTempCurrentLocation = "null";
            NPC_AI.sTempLastLocation = "null";
            NPC_AI.sTempWeapons = "null";
            NPC_Traits.sTempTraitOne = "null";
            NPC_Traits.sTempTraitTwo = "null";
            NPC_Traits.sTempTraitThree = "null";
            query = "null_query";
            sLookedForNPC = "null_sLookedForNPC";
            sMoreTrading = "y";
            
            // BOOLs
            // bOneTalk = false;
            bValidName = false;
            bVoiced = false;
            // AccusationEncounters.bJumpToAccusation = false; Resetting this at the start of every conversation breaks the accusation loop with afraid NPCs.
            AccusationEncounters.bSkipNode01 = false;
            AccusationEncounters.bTempQueried = false;
            Conversation.bTempTalked = false;
            Notebook.bNoteOne = false;
            Notebook.bNoteTwo = false;
            Notebook.bNoteThree = false;
            NPC_AI.bTempCorpse = false;
        }

        public static void SetISetSpeaker()
        {
            if (iSpeaker001 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_001; } 
            if (iSpeaker002 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_002; } 
            if (iSpeaker003 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_003; } 
            if (iSpeaker004 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_004; }
            if (iSpeaker005 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_005; } 
            if (iSpeaker006 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_006; } 
            if (iSpeaker007 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_007; } 
            if (iSpeaker008 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_008; }
            if (iSpeaker009 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_009; }
            if (iSpeaker010 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_010; }
            if (iSpeaker011 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_011; } 
            if (iSpeaker012 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_012; }
            if (iSpeaker013 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_013; } 
            if (iSpeaker014 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_014; }
            if (iSpeaker015 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_015; }
            if (iSpeaker016 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_016; }
            if (iSpeaker017 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_017; } 
            if (iSpeaker018 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_018; } 
            if (iSpeaker019 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_019; } 
            if (iSpeaker020 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_020; }
            if (iSpeaker021 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_021; }
            if (iSpeaker022 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_022; }
            if (iSpeaker023 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_023; } 
            if (iSpeaker024 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_024; }
            if (iSpeaker025 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_025; }
            if (iSpeaker026 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_026; } 
            if (iSpeaker027 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_027; }
            if (iSpeaker028 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_028; }
            if (iSpeaker029 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_029; }
            if (iSpeaker030 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_030; } 
            if (iSpeaker031 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_031; } 
            if (iSpeaker032 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_032; }
            if (iSpeaker033 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_033; }
            if (iSpeaker034 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_034; }
            if (iSpeaker035 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_035; }
            if (iSpeaker036 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_036; }
            if (iSpeaker037 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_037; } 
            if (iSpeaker038 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_038; }
            if (iSpeaker039 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_039; } 
            if (iSpeaker040 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_040; }
            if (iSpeaker041 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_041; } 
            if (iSpeaker042 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_042; }
            if (iSpeaker043 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_043; }
            if (iSpeaker044 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_044; }
            if (iSpeaker045 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_045; }
            if (iSpeaker046 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_046; } 
            if (iSpeaker047 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_047; } 
            if (iSpeaker048 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_048; }
            if (iSpeaker049 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_049; } 
            if (iSpeaker050 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_050; }
            if (iSpeaker051 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_051; } 
            if (iSpeaker052 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_052; }
            if (iSpeaker053 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_053; }
            if (iSpeaker054 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_054; }
            if (iSpeaker055 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_055; } 
            if (iSpeaker056 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_056; }
            if (iSpeaker057 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_057; }
            if (iSpeaker058 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_058; }
            if (iSpeaker059 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_059; }
            if (iSpeaker060 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_060; }
            if (iSpeaker061 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_061; }
            if (iSpeaker062 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_062; } 
            if (iSpeaker063 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_063; } 
            if (iSpeaker064 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_064; }
            if (iSpeaker065 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_065; }
            if (iSpeaker066 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_066; }
            if (iSpeaker067 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_067; } 
            if (iSpeaker068 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_068; }
            if (iSpeaker069 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_069; }
            if (iSpeaker070 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_070; }
            if (iSpeaker071 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_071; } 
            if (iSpeaker072 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_072; }
            if (iSpeaker073 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_073; }
            if (iSpeaker074 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_074; }
            if (iSpeaker075 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_075; }
            if (iSpeaker076 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_076; }
            if (iSpeaker077 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_077; }
            if (iSpeaker078 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_078; } 
            if (iSpeaker079 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_079; }
            if (iSpeaker080 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_080; }
            if (iSpeaker081 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_081; } 
            if (iSpeaker082 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_082; }
            if (iSpeaker083 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_083; } 
            if (iSpeaker084 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_084; }
            if (iSpeaker085 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_085; }
            if (iSpeaker086 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_086; }
            if (iSpeaker087 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_087; }
            if (iSpeaker088 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_088; }
            if (iSpeaker089 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_089; } 
            if (iSpeaker090 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_090; }
            if (iSpeaker091 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_091; } 
            if (iSpeaker092 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_092; }
            if (iSpeaker093 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_093; }
            if (iSpeaker094 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_094; }
            if (iSpeaker095 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_095; } 
            if (iSpeaker096 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_096; }
            if (iSpeaker097 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_097; }
            if (iSpeaker098 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_098; }
            if (iSpeaker099 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_099; } 
            if (iSpeaker100 == NPC_AI.iSetSpeaker) { NPC_AI.tempNPC = NPC_AI.NPC_100; }
        }

        public static void iLoyaltyNumberEqualsiTempLoyalty()
        {
            if (NPC_AI.tempNPC == NPC_AI.NPC_001) { NPC_AI.iLoyalty001 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_002) { NPC_AI.iLoyalty002 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_003) { NPC_AI.iLoyalty003 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_004) { NPC_AI.iLoyalty004 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_005) { NPC_AI.iLoyalty005 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_006) { NPC_AI.iLoyalty006 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_007) { NPC_AI.iLoyalty007 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_008) { NPC_AI.iLoyalty008 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_009) { NPC_AI.iLoyalty009 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_010) { NPC_AI.iLoyalty010 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_011) { NPC_AI.iLoyalty011 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_012) { NPC_AI.iLoyalty012 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_013) { NPC_AI.iLoyalty013 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_014) { NPC_AI.iLoyalty014 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_015) { NPC_AI.iLoyalty015 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_016) { NPC_AI.iLoyalty016 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_017) { NPC_AI.iLoyalty017 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_018) { NPC_AI.iLoyalty018 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_019) { NPC_AI.iLoyalty019 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_020) { NPC_AI.iLoyalty020 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_021) { NPC_AI.iLoyalty021 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_022) { NPC_AI.iLoyalty022 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_023) { NPC_AI.iLoyalty023 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_024) { NPC_AI.iLoyalty024 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_025) { NPC_AI.iLoyalty025 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_026) { NPC_AI.iLoyalty026 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_027) { NPC_AI.iLoyalty027 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_028) { NPC_AI.iLoyalty028 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_029) { NPC_AI.iLoyalty029 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_030) { NPC_AI.iLoyalty030 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_031) { NPC_AI.iLoyalty031 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_032) { NPC_AI.iLoyalty032 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_033) { NPC_AI.iLoyalty033 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_034) { NPC_AI.iLoyalty034 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_035) { NPC_AI.iLoyalty035 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_036) { NPC_AI.iLoyalty036 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_037) { NPC_AI.iLoyalty037 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_038) { NPC_AI.iLoyalty038 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_039) { NPC_AI.iLoyalty039 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_040) { NPC_AI.iLoyalty040 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_041) { NPC_AI.iLoyalty041 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_042) { NPC_AI.iLoyalty042 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_043) { NPC_AI.iLoyalty043 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_044) { NPC_AI.iLoyalty044 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_045) { NPC_AI.iLoyalty045 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_046) { NPC_AI.iLoyalty046 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_047) { NPC_AI.iLoyalty047 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_048) { NPC_AI.iLoyalty048 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_049) { NPC_AI.iLoyalty049 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_050) { NPC_AI.iLoyalty050 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_051) { NPC_AI.iLoyalty051 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_052) { NPC_AI.iLoyalty052 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_053) { NPC_AI.iLoyalty053 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_054) { NPC_AI.iLoyalty054 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_055) { NPC_AI.iLoyalty055 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_056) { NPC_AI.iLoyalty056 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_057) { NPC_AI.iLoyalty057 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_058) { NPC_AI.iLoyalty058 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_059) { NPC_AI.iLoyalty059 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_060) { NPC_AI.iLoyalty060 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_061) { NPC_AI.iLoyalty061 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_062) { NPC_AI.iLoyalty062 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_063) { NPC_AI.iLoyalty063 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_064) { NPC_AI.iLoyalty064 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_065) { NPC_AI.iLoyalty065 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_066) { NPC_AI.iLoyalty066 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_067) { NPC_AI.iLoyalty067 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_068) { NPC_AI.iLoyalty068 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_069) { NPC_AI.iLoyalty069 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_070) { NPC_AI.iLoyalty070 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_071) { NPC_AI.iLoyalty071 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_072) { NPC_AI.iLoyalty072 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_073) { NPC_AI.iLoyalty073 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_074) { NPC_AI.iLoyalty074 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_075) { NPC_AI.iLoyalty075 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_076) { NPC_AI.iLoyalty076 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_077) { NPC_AI.iLoyalty077 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_078) { NPC_AI.iLoyalty078 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_079) { NPC_AI.iLoyalty079 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_080) { NPC_AI.iLoyalty080 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_081) { NPC_AI.iLoyalty081 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_082) { NPC_AI.iLoyalty082 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_083) { NPC_AI.iLoyalty083 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_084) { NPC_AI.iLoyalty084 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_085) { NPC_AI.iLoyalty085 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_086) { NPC_AI.iLoyalty086 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_087) { NPC_AI.iLoyalty087 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_088) { NPC_AI.iLoyalty088 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_089) { NPC_AI.iLoyalty089 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_090) { NPC_AI.iLoyalty090 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_091) { NPC_AI.iLoyalty091 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_092) { NPC_AI.iLoyalty092 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_093) { NPC_AI.iLoyalty093 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_094) { NPC_AI.iLoyalty094 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_095) { NPC_AI.iLoyalty095 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_096) { NPC_AI.iLoyalty096 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_097) { NPC_AI.iLoyalty097 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_098) { NPC_AI.iLoyalty098 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_099) { NPC_AI.iLoyalty099 = NPC_AI.iTempLoyalty; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_100) { NPC_AI.iLoyalty100 = NPC_AI.iTempLoyalty; }
        }

        public static void Option_LetsGetTalking()
        {
            Conversation.ResetAllTempConversationVariables();
            AccusationEncounters.Reset_bQueried();
            Console.ForegroundColor = ConsoleColor.Gray;

            while (sMoreTrading == "y") // This var in use so that you can trade multiple times without advancing time.
            {
                if (Variables.bAnyoneHere == false)
                {
                    Console.WriteLine("There is no one around to speak with -- unless you were looking to");
                    Console.WriteLine("speak to yourself. And, hey, if that's the case, don't let me stop you.");
                    Program.PressAnyKey();
                    break;
                }
                if (Variables.bAboutToDie == true)
                {
                    if (Variables.weaponName == NPC_AI.sWeaponType0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You open your mouth to speak, but yawn instead. " + NPC_AI.NPC_100 + " says,");
                        Console.WriteLine("'Shhh. It's OK. Rest your eyes. You've been awake for so long. It's time to");
                        Console.WriteLine("sleep now.' You close your eyes and feel warmth wrap around you.");
                        Variables.playerSurvived = Variables.sPlayerState1;
                        Variables.iFinishingTurn = Variables.iRemainingTurns; Variables.iRemainingTurns = 0;
                        sMoreTrading = "n";
                        Program.PressAnyKey();
                    }
                    else if (Variables.weaponName != NPC_AI.sWeaponType0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You open your mouth to speak, but yawn instead. " + NPC_AI.NPC_100 + " says,");
                        Console.WriteLine("'Shhh. It's OK. Rest your eyes. You've been awake for so long. It's time to");
                        Console.WriteLine("sleep now.' You want to close your eyes, but seeing the " + Variables.weaponName + " in your");
                        Console.WriteLine("hand sparks something within you. You throw it at " + NPC_AI.NPC_100 + " and");
                        Console.WriteLine("feel some energy return. You have a second chance to run away, if you");
                        Console.WriteLine("would take it.");
                        Variables.weaponName = NPC_AI.sWeaponType0;
                        sMoreTrading = "n";
                        Program.PressAnyKey();
                    }
                }
                else if (Variables.bAboutToDie == false)
                {
                    Console.Clear();
                    Program.Display_UIHeader();
                    Console.WriteLine("MacGuffins: " + Variables.iFoundMacGuffins + "; Weapon: " + Variables.weaponName);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Choose someone with whom you would like to speak by entering their number.");
                    Console.WriteLine();
                    Console.WriteLine("Change your mind by entering the number 0.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIP: People become more friendly/less suspicious if you give them MacGuffins/weapons.");
                    Console.WriteLine("When you ask them for MacGuffins/weapons, they become less friendly/more suspicious.");
                    Console.WriteLine("Additionally, some actions require a person to hold a minimum disposition toward you.");
                    Console.WriteLine("If you need someone's help and they're refusing, try giving them a gift.");
                    Console.WriteLine();
                    Console.WriteLine("TIP: Suspicious --> Wary --> Indifferent --> Pleasant --> Agreeable --> Friendly");
                    Console.WriteLine();

                    // making sure that nothing exceeds maximum values, even if a player temporarily set it above "iLoyaltyCap"
                    NPC_AI.Reset_iLoyalty();

                    // Anyone who is available to talk (present, and not a corpse) is added to the TalkingNPCs list.
                    Lists.MyPosse.Clear();
                    Lists.TalkingNPCs.Clear();

                    iSpeaker = 0; // do this to reset the value when you are choosing who to talk with.
                    // The system always increments upward, and the first person should always be "1".

                    Lists.PopulateTalkingNPCs();
                    Lists.TalkingNPCs.Sort();

                    NPC_AI.tempNPC = "null";

                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (string value in Lists.TalkingNPCs)
                    {
                        // NPC_AI.tempNPC = value;
                        if (value == NPC_AI.NPC_001)
                        { 
                            iSpeaker++; 
                            NPC_AI.tempNPC = NPC_AI.NPC_001; 
                            NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins001; 
                            iSpeaker001 = iSpeaker; 
                            NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons001; 
                            NPC_AI.iTempLoyalty = NPC_AI.iLoyalty001; 
                            // NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove001; 
                            // NPC_AI.iTempLocation = NPC_AI.NPC001_CurrentNumLocation; 
                            // NPC_AI.sTempCurrentLocation = NPC_AI.NPC001_CurrentStrLocation; 
                            // NPC_AI.iTempLastLocation = NPC_AI.NPC001_LastLocation; 
                        }
                        if (value == NPC_AI.NPC_002)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_002; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins002; iSpeaker002 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons002; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty002; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove002; NPC_AI.iTempLocation = NPC_AI.NPC002_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC002_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC002_LastLocation; */ }
                        if (value == NPC_AI.NPC_003)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_003; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins003; iSpeaker003 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons003; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty003; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove003; NPC_AI.iTempLocation = NPC_AI.NPC003_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC003_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC003_LastLocation; */ }
                        if (value == NPC_AI.NPC_004)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_004; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins004; iSpeaker004 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons004; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty004; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove004; NPC_AI.iTempLocation = NPC_AI.NPC004_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC004_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC004_LastLocation; */ }
                        if (value == NPC_AI.NPC_005)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_005; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins005; iSpeaker005 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons005; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty005; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove005; NPC_AI.iTempLocation = NPC_AI.NPC005_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC005_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC005_LastLocation; */ }
                        if (value == NPC_AI.NPC_006)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_006; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins006; iSpeaker006 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons006; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty006; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove006; NPC_AI.iTempLocation = NPC_AI.NPC006_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC006_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC006_LastLocation; */ }
                        if (value == NPC_AI.NPC_007)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_007; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins007; iSpeaker007 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons007; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty007; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove007; NPC_AI.iTempLocation = NPC_AI.NPC007_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC007_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC007_LastLocation; */ }
                        if (value == NPC_AI.NPC_008)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_008; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins008; iSpeaker008 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons008; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty008; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove008; NPC_AI.iTempLocation = NPC_AI.NPC008_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC008_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC008_LastLocation; */ }
                        if (value == NPC_AI.NPC_009)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_009; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins009; iSpeaker009 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons009; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty009; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove009; NPC_AI.iTempLocation = NPC_AI.NPC009_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC009_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC009_LastLocation; */ }
                        if (value == NPC_AI.NPC_010)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_010; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins010; iSpeaker010 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons010; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty020; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove010; NPC_AI.iTempLocation = NPC_AI.NPC010_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC010_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC010_LastLocation; */ }
                        if (value == NPC_AI.NPC_011)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_011; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins011; iSpeaker011 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons011; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty011; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove011; NPC_AI.iTempLocation = NPC_AI.NPC011_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC011_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC011_LastLocation; */ }
                        if (value == NPC_AI.NPC_012)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_012; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins012; iSpeaker012 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons012; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty012; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove012; NPC_AI.iTempLocation = NPC_AI.NPC012_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC012_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC012_LastLocation; */ }
                        if (value == NPC_AI.NPC_013)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_013; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins013; iSpeaker013 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons013; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty013; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove013; NPC_AI.iTempLocation = NPC_AI.NPC013_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC013_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC013_LastLocation; */ }
                        if (value == NPC_AI.NPC_014)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_014; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins014; iSpeaker014 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons014; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty014; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove014; NPC_AI.iTempLocation = NPC_AI.NPC014_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC014_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC014_LastLocation; */ }
                        if (value == NPC_AI.NPC_015)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_015; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins015; iSpeaker015 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons015; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty015; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove015; NPC_AI.iTempLocation = NPC_AI.NPC015_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC015_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC015_LastLocation; */ }
                        if (value == NPC_AI.NPC_016)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_016; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins016; iSpeaker016 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons016; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty016; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove016; NPC_AI.iTempLocation = NPC_AI.NPC016_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC016_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC016_LastLocation; */ }
                        if (value == NPC_AI.NPC_017)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_017; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins017; iSpeaker017 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons017; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty017; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove017; NPC_AI.iTempLocation = NPC_AI.NPC017_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC017_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC017_LastLocation; */ }
                        if (value == NPC_AI.NPC_018)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_018; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins018; iSpeaker018 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons018; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty018; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove018; NPC_AI.iTempLocation = NPC_AI.NPC018_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC018_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC018_LastLocation; */ }
                        if (value == NPC_AI.NPC_019)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_019; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins019; iSpeaker019 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons019; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty019; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove019; NPC_AI.iTempLocation = NPC_AI.NPC019_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC019_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC019_LastLocation; */ }
                        if (value == NPC_AI.NPC_020)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_020; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins020; iSpeaker020 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons020; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty020; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove020; NPC_AI.iTempLocation = NPC_AI.NPC020_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC020_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC020_LastLocation; */ }
                        if (value == NPC_AI.NPC_021)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_021; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins021; iSpeaker021 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons021; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty021; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove021; NPC_AI.iTempLocation = NPC_AI.NPC021_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC021_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC021_LastLocation; */ }
                        if (value == NPC_AI.NPC_022)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_022; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins022; iSpeaker022 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons022; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty022; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove022; NPC_AI.iTempLocation = NPC_AI.NPC022_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC022_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC022_LastLocation; */ }
                        if (value == NPC_AI.NPC_023)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_023; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins023; iSpeaker023 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons023; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty023; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove023; NPC_AI.iTempLocation = NPC_AI.NPC023_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC023_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC023_LastLocation; */ }
                        if (value == NPC_AI.NPC_024)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_024; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins024; iSpeaker024 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons024; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty024; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove024; NPC_AI.iTempLocation = NPC_AI.NPC024_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC024_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC024_LastLocation; */ }
                        if (value == NPC_AI.NPC_025)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_025; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins025; iSpeaker025 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons025; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty025; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove025; NPC_AI.iTempLocation = NPC_AI.NPC025_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC025_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC025_LastLocation; */ }
                        if (value == NPC_AI.NPC_026)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_026; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins026; iSpeaker026 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons026; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty026; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove026; NPC_AI.iTempLocation = NPC_AI.NPC026_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC026_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC026_LastLocation; */ }
                        if (value == NPC_AI.NPC_027)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_027; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins027; iSpeaker027 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons027; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty027; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove027; NPC_AI.iTempLocation = NPC_AI.NPC027_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC027_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC027_LastLocation; */ }
                        if (value == NPC_AI.NPC_028)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_028; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins028; iSpeaker028 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons028; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty028; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove028; NPC_AI.iTempLocation = NPC_AI.NPC028_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC028_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC028_LastLocation; */ }
                        if (value == NPC_AI.NPC_029)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_029; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins029; iSpeaker029 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons029; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty029; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove029; NPC_AI.iTempLocation = NPC_AI.NPC029_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC029_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC029_LastLocation; */ }
                        if (value == NPC_AI.NPC_030)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_030; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins030; iSpeaker030 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons030; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty030; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove030; NPC_AI.iTempLocation = NPC_AI.NPC030_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC030_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC030_LastLocation; */ }
                        if (value == NPC_AI.NPC_031)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_031; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins031; iSpeaker031 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons031; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty031; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove031; NPC_AI.iTempLocation = NPC_AI.NPC031_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC031_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC031_LastLocation; */ }
                        if (value == NPC_AI.NPC_032)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_032; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins032; iSpeaker032 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons032; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty032; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove032; NPC_AI.iTempLocation = NPC_AI.NPC032_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC032_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC032_LastLocation; */ }
                        if (value == NPC_AI.NPC_033)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_033; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins033; iSpeaker033 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons033; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty033; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove033; NPC_AI.iTempLocation = NPC_AI.NPC033_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC033_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC033_LastLocation; */ }
                        if (value == NPC_AI.NPC_034)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_034; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins034; iSpeaker034 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons034; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty034; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove034; NPC_AI.iTempLocation = NPC_AI.NPC034_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC034_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC034_LastLocation; */ }
                        if (value == NPC_AI.NPC_035)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_035; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins035; iSpeaker035 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons035; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty035; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove035; NPC_AI.iTempLocation = NPC_AI.NPC035_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC035_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC035_LastLocation; */ }
                        if (value == NPC_AI.NPC_036)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_036; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins036; iSpeaker036 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons036; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty036; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove036; NPC_AI.iTempLocation = NPC_AI.NPC036_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC036_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC036_LastLocation; */ }
                        if (value == NPC_AI.NPC_037)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_037; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins037; iSpeaker037 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons037; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty037; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove037; NPC_AI.iTempLocation = NPC_AI.NPC037_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC037_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC037_LastLocation; */ }
                        if (value == NPC_AI.NPC_038)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_038; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins038; iSpeaker038 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons038; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty038; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove038; NPC_AI.iTempLocation = NPC_AI.NPC038_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC038_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC038_LastLocation; */ }
                        if (value == NPC_AI.NPC_039)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_039; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins039; iSpeaker039 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons039; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty039; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove039; NPC_AI.iTempLocation = NPC_AI.NPC039_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC039_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC039_LastLocation; */ }
                        if (value == NPC_AI.NPC_040)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_040; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins040; iSpeaker040 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons040; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty040; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove040; NPC_AI.iTempLocation = NPC_AI.NPC040_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC040_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC040_LastLocation; */ }
                        if (value == NPC_AI.NPC_041)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_041; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins041; iSpeaker041 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons041; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty041; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove041; NPC_AI.iTempLocation = NPC_AI.NPC041_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC041_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC041_LastLocation; */ }
                        if (value == NPC_AI.NPC_042)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_042; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins042; iSpeaker042 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons042; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty042; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove042; NPC_AI.iTempLocation = NPC_AI.NPC042_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC042_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC042_LastLocation; */ }
                        if (value == NPC_AI.NPC_043)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_043; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins043; iSpeaker043 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons043; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty043; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove043; NPC_AI.iTempLocation = NPC_AI.NPC043_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC043_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC043_LastLocation; */ }
                        if (value == NPC_AI.NPC_044)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_044; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins044; iSpeaker044 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons044; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty044; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove044; NPC_AI.iTempLocation = NPC_AI.NPC044_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC044_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC044_LastLocation; */ }
                        if (value == NPC_AI.NPC_045)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_045; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins045; iSpeaker045 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons045; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty045; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove045; NPC_AI.iTempLocation = NPC_AI.NPC045_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC045_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC045_LastLocation; */ }
                        if (value == NPC_AI.NPC_046)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_046; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins046; iSpeaker046 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons046; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty046; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove046; NPC_AI.iTempLocation = NPC_AI.NPC046_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC046_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC046_LastLocation; */ }
                        if (value == NPC_AI.NPC_047)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_047; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins047; iSpeaker047 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons047; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty047; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove047; NPC_AI.iTempLocation = NPC_AI.NPC047_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC047_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC047_LastLocation; */ }
                        if (value == NPC_AI.NPC_048)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_048; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins048; iSpeaker048 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons048; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty048; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove048; NPC_AI.iTempLocation = NPC_AI.NPC048_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC048_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC048_LastLocation; */ }
                        if (value == NPC_AI.NPC_049)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_049; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins049; iSpeaker049 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons049; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty049; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove049; NPC_AI.iTempLocation = NPC_AI.NPC049_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC049_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC049_LastLocation; */ }
                        if (value == NPC_AI.NPC_050)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_050; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins050; iSpeaker050 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons050; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty050; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove050; NPC_AI.iTempLocation = NPC_AI.NPC050_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC050_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC050_LastLocation; */ }
                        if (value == NPC_AI.NPC_051)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_051; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins051; iSpeaker051 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons051; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty051; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove051; NPC_AI.iTempLocation = NPC_AI.NPC051_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC051_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC051_LastLocation; */ }
                        if (value == NPC_AI.NPC_052)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_052; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins052; iSpeaker052 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons052; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty052; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove052; NPC_AI.iTempLocation = NPC_AI.NPC052_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC052_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC052_LastLocation; */ }
                        if (value == NPC_AI.NPC_053)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_053; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins053; iSpeaker053 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons053; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty053; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove053; NPC_AI.iTempLocation = NPC_AI.NPC053_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC053_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC053_LastLocation; */ }
                        if (value == NPC_AI.NPC_054)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_054; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins054; iSpeaker054 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons054; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty054; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove054; NPC_AI.iTempLocation = NPC_AI.NPC054_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC054_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC054_LastLocation; */ }
                        if (value == NPC_AI.NPC_055)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_055; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins055; iSpeaker055 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons055; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty055; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove055; NPC_AI.iTempLocation = NPC_AI.NPC055_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC055_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC055_LastLocation; */ }
                        if (value == NPC_AI.NPC_056)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_056; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins056; iSpeaker056 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons056; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty056; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove056; NPC_AI.iTempLocation = NPC_AI.NPC056_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC056_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC056_LastLocation; */ }
                        if (value == NPC_AI.NPC_057)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_057; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins057; iSpeaker057 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons057; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty057; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove057; NPC_AI.iTempLocation = NPC_AI.NPC057_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC057_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC057_LastLocation; */ }
                        if (value == NPC_AI.NPC_058)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_058; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins058; iSpeaker058 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons058; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty058; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove058; NPC_AI.iTempLocation = NPC_AI.NPC058_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC058_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC058_LastLocation; */ }
                        if (value == NPC_AI.NPC_059)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_059; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins059; iSpeaker059 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons059; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty059; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove059; NPC_AI.iTempLocation = NPC_AI.NPC059_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC059_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC059_LastLocation; */ }
                        if (value == NPC_AI.NPC_060)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_060; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins060; iSpeaker060 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons060; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty060; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove060; NPC_AI.iTempLocation = NPC_AI.NPC060_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC060_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC060_LastLocation; */ }
                        if (value == NPC_AI.NPC_061)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_061; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins061; iSpeaker061 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons061; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty061; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove061; NPC_AI.iTempLocation = NPC_AI.NPC061_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC061_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC061_LastLocation; */ }
                        if (value == NPC_AI.NPC_062)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_062; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins062; iSpeaker062 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons062; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty062; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove062; NPC_AI.iTempLocation = NPC_AI.NPC062_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC062_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC062_LastLocation; */ }
                        if (value == NPC_AI.NPC_063)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_063; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins063; iSpeaker063 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons063; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty063; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove063; NPC_AI.iTempLocation = NPC_AI.NPC063_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC063_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC063_LastLocation; */ }
                        if (value == NPC_AI.NPC_064)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_064; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins064; iSpeaker064 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons064; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty064; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove064; NPC_AI.iTempLocation = NPC_AI.NPC064_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC064_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC064_LastLocation; */ }
                        if (value == NPC_AI.NPC_065)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_065; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins065; iSpeaker065 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons065; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty065; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove065; NPC_AI.iTempLocation = NPC_AI.NPC065_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC065_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC065_LastLocation; */ }
                        if (value == NPC_AI.NPC_066)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_066; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins066; iSpeaker066 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons066; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty066; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove066; NPC_AI.iTempLocation = NPC_AI.NPC066_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC066_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC066_LastLocation; */ }
                        if (value == NPC_AI.NPC_067)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_067; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins067; iSpeaker067 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons067; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty067; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove067; NPC_AI.iTempLocation = NPC_AI.NPC067_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC067_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC067_LastLocation; */ }
                        if (value == NPC_AI.NPC_068)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_068; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins068; iSpeaker068 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons068; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty068; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove068; NPC_AI.iTempLocation = NPC_AI.NPC068_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC068_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC068_LastLocation; */ }
                        if (value == NPC_AI.NPC_069)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_069; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins069; iSpeaker069 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons069; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty069; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove069; NPC_AI.iTempLocation = NPC_AI.NPC069_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC069_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC069_LastLocation; */ }
                        if (value == NPC_AI.NPC_070)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_070; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins070; iSpeaker070 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons070; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty070; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove070; NPC_AI.iTempLocation = NPC_AI.NPC070_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC070_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC070_LastLocation; */ }
                        if (value == NPC_AI.NPC_071)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_071; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins071; iSpeaker071 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons071; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty071; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove071; NPC_AI.iTempLocation = NPC_AI.NPC071_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC071_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC071_LastLocation; */ }
                        if (value == NPC_AI.NPC_072)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_072; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins072; iSpeaker072 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons072; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty072; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove072; NPC_AI.iTempLocation = NPC_AI.NPC072_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC072_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC072_LastLocation; */ }
                        if (value == NPC_AI.NPC_073)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_073; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins073; iSpeaker073 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons073; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty073; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove073; NPC_AI.iTempLocation = NPC_AI.NPC073_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC073_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC073_LastLocation; */ }
                        if (value == NPC_AI.NPC_074)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_074; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins074; iSpeaker074 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons074; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty074; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove074; NPC_AI.iTempLocation = NPC_AI.NPC074_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC074_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC074_LastLocation; */ }
                        if (value == NPC_AI.NPC_075)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_075; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins075; iSpeaker075 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons075; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty075; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove075; NPC_AI.iTempLocation = NPC_AI.NPC075_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC075_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC075_LastLocation; */ }
                        if (value == NPC_AI.NPC_076)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_076; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins076; iSpeaker076 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons076; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty076; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove076; NPC_AI.iTempLocation = NPC_AI.NPC076_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC076_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC076_LastLocation; */ }
                        if (value == NPC_AI.NPC_077)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_077; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins077; iSpeaker077 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons077; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty077; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove077; NPC_AI.iTempLocation = NPC_AI.NPC077_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC077_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC077_LastLocation; */ }
                        if (value == NPC_AI.NPC_078)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_078; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins078; iSpeaker078 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons078; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty078; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove078; NPC_AI.iTempLocation = NPC_AI.NPC078_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC078_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC078_LastLocation; */ }
                        if (value == NPC_AI.NPC_079)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_079; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins079; iSpeaker079 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons079; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty079; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove079; NPC_AI.iTempLocation = NPC_AI.NPC079_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC079_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC079_LastLocation; */ }
                        if (value == NPC_AI.NPC_080)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_080; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins080; iSpeaker080 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons080; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty080; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove080; NPC_AI.iTempLocation = NPC_AI.NPC080_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC080_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC080_LastLocation; */ }
                        if (value == NPC_AI.NPC_081)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_081; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins081; iSpeaker081 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons081; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty081; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove081; NPC_AI.iTempLocation = NPC_AI.NPC081_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC081_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC081_LastLocation; */ }
                        if (value == NPC_AI.NPC_082)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_082; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins082; iSpeaker082 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons082; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty082; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove082; NPC_AI.iTempLocation = NPC_AI.NPC082_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC082_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC082_LastLocation; */ }
                        if (value == NPC_AI.NPC_083)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_083; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins083; iSpeaker083 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons083; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty083; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove083; NPC_AI.iTempLocation = NPC_AI.NPC083_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC083_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC083_LastLocation; */ }
                        if (value == NPC_AI.NPC_084)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_084; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins084; iSpeaker084 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons084; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty084; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove084; NPC_AI.iTempLocation = NPC_AI.NPC084_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC084_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC084_LastLocation; */ }
                        if (value == NPC_AI.NPC_085)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_085; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins085; iSpeaker085 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons085; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty085; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove085; NPC_AI.iTempLocation = NPC_AI.NPC085_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC085_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC085_LastLocation; */ }
                        if (value == NPC_AI.NPC_086)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_086; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins086; iSpeaker086 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons086; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty086; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove086; NPC_AI.iTempLocation = NPC_AI.NPC086_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC086_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC086_LastLocation; */ }
                        if (value == NPC_AI.NPC_087)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_087; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins087; iSpeaker087 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons087; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty087; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove087; NPC_AI.iTempLocation = NPC_AI.NPC087_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC087_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC087_LastLocation; */ }
                        if (value == NPC_AI.NPC_088)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_088; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins088; iSpeaker088 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons088; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty088; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove088; NPC_AI.iTempLocation = NPC_AI.NPC088_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC088_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC088_LastLocation; */ }
                        if (value == NPC_AI.NPC_089)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_089; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins089; iSpeaker089 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons089; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty089; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove089; NPC_AI.iTempLocation = NPC_AI.NPC089_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC089_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC089_LastLocation; */ }
                        if (value == NPC_AI.NPC_090)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_090; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins090; iSpeaker090 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons090; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty090; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove090; NPC_AI.iTempLocation = NPC_AI.NPC090_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC090_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC090_LastLocation; */ }
                        if (value == NPC_AI.NPC_091)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_091; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins091; iSpeaker091 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons091; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty091; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove091; NPC_AI.iTempLocation = NPC_AI.NPC091_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC091_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC091_LastLocation; */ }
                        if (value == NPC_AI.NPC_092)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_092; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins092; iSpeaker092 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons092; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty092; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove092; NPC_AI.iTempLocation = NPC_AI.NPC092_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC092_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC092_LastLocation; */ }
                        if (value == NPC_AI.NPC_093)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_093; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins093; iSpeaker093 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons093; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty093; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove093; NPC_AI.iTempLocation = NPC_AI.NPC093_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC093_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC093_LastLocation; */ }
                        if (value == NPC_AI.NPC_094)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_094; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins094; iSpeaker094 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons094; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty094; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove094; NPC_AI.iTempLocation = NPC_AI.NPC094_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC094_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC094_LastLocation; */ }
                        if (value == NPC_AI.NPC_095)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_095; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins095; iSpeaker095 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons095; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty095; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove095; NPC_AI.iTempLocation = NPC_AI.NPC095_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC095_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC095_LastLocation; */ }
                        if (value == NPC_AI.NPC_096)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_096; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins096; iSpeaker096 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons096; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty096; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove096; NPC_AI.iTempLocation = NPC_AI.NPC096_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC096_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC096_LastLocation; */ }
                        if (value == NPC_AI.NPC_097)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_097; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins097; iSpeaker097 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons097; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty097; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove097; NPC_AI.iTempLocation = NPC_AI.NPC097_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC097_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC097_LastLocation; */ }
                        if (value == NPC_AI.NPC_098)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_098; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins098; iSpeaker098 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons098; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty098; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove098; NPC_AI.iTempLocation = NPC_AI.NPC098_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC098_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC098_LastLocation; */ }
                        if (value == NPC_AI.NPC_099)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_099; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins099; iSpeaker099 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons099; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty099; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove099; NPC_AI.iTempLocation = NPC_AI.NPC099_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC099_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC099_LastLocation; */ }
                        if (value == NPC_AI.NPC_100)
                        { iSpeaker++; NPC_AI.tempNPC = NPC_AI.NPC_100; NPC_AI.iTempMacGuffins = NPC_AI.iAvailableMacGuffins100; iSpeaker100 = iSpeaker; NPC_AI.sTempWeapons = NPC_AI.sAvailableWeapons100; NPC_AI.iTempLoyalty = NPC_AI.iLoyalty100; /* NPC_AI.iTempDesireToMove = NPC_AI.DesireToMove100; NPC_AI.iTempLocation = NPC_AI.NPC100_CurrentNumLocation; NPC_AI.sTempCurrentLocation = NPC_AI.NPC100_CurrentStrLocation; NPC_AI.iTempLastLocation = NPC_AI.NPC100_LastLocation; */ }

                        if (NPC_AI.iTempLoyalty > 3)
                        {
                            // Anyone who is friendly to the player is added to the MyPosse list and is invoked during an accusation.
                            Lists.MyPosse.Add(NPC_AI.tempNPC);
                        }
                        NPC_AI.tempNPC_PantsDownGenderCheck();
                        NPC_AI.GetDisposition();

                        Console.WriteLine("Enter " + iSpeaker + " to speak with " + value + " ... (Disposition: " + NPC_AI.sTempLoyalty + ", MacGuffins: " + NPC_AI.iTempMacGuffins + ", Weapon: " + NPC_AI.sTempWeapons + ")");
                    }

                    // End Conversation Window/Listing of Talking Partners/ End previous IF statement

                    // Start Conversation Code

                    Console.WriteLine();
                    if (int.TryParse(Console.ReadLine(), out NPC_AI.iSetSpeaker))
                    {
                        Console.WriteLine();
                        while (NPC_AI.iSetSpeaker > iSpeaker)
                        {
                            Console.WriteLine("Please choose from the list.");
                            Console.WriteLine();
                            int.TryParse(Console.ReadLine(), out NPC_AI.iSetSpeaker);
                            Console.WriteLine();
                        }
                        if (NPC_AI.iSetSpeaker == 0)
                        {
                            Console.WriteLine("It's OK if you don't want to talk with someone; talking is overrated.");
                            Program.PressAnyKey();
                            break;
                        }

                        Conversation.SetISetSpeaker();
                        // Reset the temp variables to match who we are speaking with since the above code is cycling through people and over-writing values.
                        NPC_AI.GetAllSetSpeakerLocals();
                        NPC_AI.tempNPC_PantsDownGenderCheck();

                        // IF the person you initiate with has -1 loyalty (afraid), cut off the usual conversation menu.
                        // In other words, if someone is afraid of you and loyal people are with you, auto attack to the death.

                        iSkipToBottom = 0;

                        if (NPC_AI.iTempLoyalty == -1 && Lists.MyPosse.Count >= 2)
                        {
                            AccusationEncounters.bJumpToAccusation = true;
                        }

                        if (NPC_AI.iTempLoyalty == -1 && Lists.MyPosse.Count <= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(NPC_AI.tempNPC + " says, 'I'm keeping my distance from you after what almost");
                            Console.WriteLine("happened. You stay away from me.'");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("TIP: You need two-or-more 'Agreeable' or 'Friendly' people to try to");
                            Console.WriteLine("catch a person who is 'Afraid'.");
                            iSkipToBottom = 1;
                        }

                        if (iSkipToBottom == 0)
                        {
                            if (Variables.iRemainingTurns > Variables.iTurn10 && !AccusationEncounters.bJumpToAccusation)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("(C)hat with " + NPC_AI.tempNPC + " to gauge their personality.");
                                Console.WriteLine("Offer (M)acGuffins");
                                Console.WriteLine("Ask for m(A)cGuffins");
                                Console.WriteLine("I'm (L)ooking for someone. Can you help?");
                                Console.WriteLine("Do you know someone with a particular (T)rait.");
                                Console.WriteLine();
                                Console.WriteLine("Press any other key to change your mind.");
                                Console.WriteLine();
                            }
                            else if (Variables.iRemainingTurns <= Variables.iTurn10 && !AccusationEncounters.bJumpToAccusation)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("(C)hat with " + NPC_AI.tempNPC + " to gauge their personality.");
                                Console.WriteLine("Offer (M)acGuffins or a (W)eapon");
                                Console.WriteLine("Ask for m(A)cGuffins or a wea(P)on");
                                Console.WriteLine(NPC_AI.tempNPC + " I want you to wait for me (S)omewhere.");
                                Console.WriteLine("I'm (L)ooking for someone. Can you help?");
                                Console.WriteLine("Do you know someone with a particular (T)rait.");
                                Console.WriteLine("(V)oice your suspicions toward " + NPC_AI.tempNPC + ".");
                                Console.WriteLine();
                                Console.WriteLine("Press any other key to change your mind.");
                                Console.WriteLine();
                            }
                            if (!AccusationEncounters.bJumpToAccusation)
                            {
                                NPC_AI.sPlayerTalk = Console.ReadLine();
                            }
                            if (AccusationEncounters.bJumpToAccusation) { NPC_AI.sPlayerTalk = "v"; }

                            switch (NPC_AI.sPlayerTalk.ToLower())
                            {
                                case "c":
                                    TalkOption_Conversation();
                                    break;

                                case "v":
                                    AccusationEncounters.TalkOption_VoiceSuspicions();
                                    break;

                                case "m":
                                    TalkOption_MacGuffinGiving();
                                    break;

                                case "w":
                                    TalkOption_WeaponGiving();
                                    break;

                                case "a":
                                    TalkOption_MacGuffinTaking();
                                    break;

                                case "p":
                                    TalkOption_WeaponTaking();
                                    break;

                                case "s":
                                    Movement.TalkOption_WaitForMeSomewhere();
                                    break;

                                case "l":
                                    TalkOption_ForWhomAreYouLooking();
                                    break;

                                case "t":
                                    NPC_Traits.TalkOption_WhatTraitsYouLookingFor();
                                    break;

                                default:
                                    break;
                            }
                        }

                        // save the results for everything we've done
                        // Console.WriteLine("DEBUG: SAVING RESULTS OF INTERACTIONS!");
                        //  NPC_AI.SetAllNPCLocals_TalkingSystem(); -- this didn't work, so I created new SetLocals at the tail end of each method.

                        Lists.MyPosse.Clear();

                        if (sMoreTrading == "y")
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Would you like to end this turn? (y)es or (n)o?");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            sMoreTrading = Console.ReadLine();
                            sMoreTrading.ToLower();
                            Console.WriteLine();
                            while (sMoreTrading != "y" && sMoreTrading != "n")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Please choose either 'y' for yes, or 'n' for no.");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                sMoreTrading = Console.ReadLine();
                                sMoreTrading.ToLower();
                                Console.WriteLine();
                            }
                            switch (sMoreTrading.ToLower())
                            {
                                case "y":
                                    sMoreTrading = "n";
                                    break;
                                case "n":
                                    sMoreTrading = "y";
                                    break;
                                default:
                                    break;
                            }
                        }
                        NPC_AI.tempNPC = "null";
                        RandomEncounters.Actor01 = "null";
                        RandomEncounters.Actor02 = "null";
                        RandomEncounters.Actor03 = "null";
                        RandomEncounters.Actor04 = "null";
                        RandomEncounters.Actor05 = "null";
                        RandomEncounters.Actor06 = "null";
                        // RandomEncounters.Initialize_Actors(); IS THIS BREAKING? (Apparently not.)
                    }
                    else
                    {
                        Console.WriteLine("An error happened! This means that iSetSpeaker and iSpeaker did not have a valid match?");
                    }
                }
                Variables.turnEnded = true;
            }
            bOneTalk = false; // this allows the player to chat with an NPC again, after ending dialogue/before starting a new DLG.
        }

        public static void TalkOption_Conversation()
        {
            NPC_AI.GetAllNPCLocals_Conversation();
            NPC_AI.tempNPC_PantsDownGenderCheck();

            if (bOneTalk)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You may only chat with one person per turn. End this turn if you");
                Console.WriteLine("want to chat with another person.");
            }
            if (!bOneTalk)
            {
                if (bTempTalked)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(NPC_AI.tempNPC + " waves at you and says, 'Hello again.'");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (!bTempTalked)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("You say 'hello' to " + NPC_AI.tempNPC + " and it leads to a quick conversation.");
                    Console.WriteLine("While the two of you talk, you realize that " + NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitThree + ".");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (Notebook.bNoteThree) { Console.WriteLine("   You've previously written that in your notebook."); }
                    if (!Notebook.bNoteThree) { Console.WriteLine("   You make a note of it in your notebook."); }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Notebook.bNoteThree = true;
                    Notebook.iNotebookHasInfo++;
                    bTempTalked = true;
                    bOneTalk = true;
                }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait200) { Notebook.bTrait200 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait201) { Notebook.bTrait201 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait202) { Notebook.bTrait202 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait203) { Notebook.bTrait203 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait204) { Notebook.bTrait204 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait205) { Notebook.bTrait205 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait206) { Notebook.bTrait206 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait207) { Notebook.bTrait207 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait208) { Notebook.bTrait208 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait209) { Notebook.bTrait209 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait210) { Notebook.bTrait210 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait211) { Notebook.bTrait211 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait212) { Notebook.bTrait212 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait213) { Notebook.bTrait213 = true; }
                if (NPC_Traits.sTempTraitThree == NPC_Traits.sTrait214) { Notebook.bTrait214 = true; }
            }
            NPC_AI.SetAllNPCLocals_Conversation();
            ResetAllTempConversationVariables();
        }

        public static void TalkOption_MacGuffinGiving()
        {
            NPC_AI.GetAllNPCLocals_AskMacGuffins();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (Variables.iFoundMacGuffins == 0)
            { 
                Console.WriteLine("You do not have any MacGuffins to give away."); 
            }

            else if (Variables.iFoundMacGuffins > 0)
            {
                iOfferedMacGuffins = 0;
                Console.WriteLine("You may offer up to " + Variables.iFoundMacGuffins + " MacGuffins.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: Be careful with your offer. A person's disposition cannot exceed 'friendly'.");
                Console.WriteLine("However, people who receive MacGuffins may be more inclined to stay around longer.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                while (!Variables.valid) // Check to make sure the player is offering no more than what they have, and that it's a number. Otherwise, deliver error message.
                {
                    Variables.valid = int.TryParse(Console.ReadLine(), out iOfferedMacGuffins) && (iOfferedMacGuffins <= Variables.iFoundMacGuffins);
                    if (!Variables.valid)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You are attempting to offer more MacGuffins than you have. Please try again.");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Variables.valid = false; // if the offer is Variables.valid, then proceed -- but first reset the "Variables.valid" variable
                Console.WriteLine();

                if (iOfferedMacGuffins == 0) // if the offer is Variables.valid, but zero -- denotes the player has changed their mind.
                {
                    Console.WriteLine("You change your mind and decide not to give away any of your MacGuffins at this time.");
                }

                else if (iOfferedMacGuffins >= 1) // if the offer is Variables.valid, and a positive value, then add loyalty, subtract MacGuffins from player, add MacGuffins to NPC, and slow NPC's roll.
                {
                    Console.WriteLine("You offer " + NPC_AI.tempNPC + " " + iOfferedMacGuffins + " MacGuffins.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'That's really nice of you. Thank you.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (NPC_AI.iTempLoyalty < 5)
                    { 
                        Console.WriteLine("   " + NPC_AI.tempNPC + "'s disposition increased."); 
                    }
                    if (NPC_AI.iTempLoyalty == 5) 
                    {
                        Console.WriteLine("   " + NPC_AI.tempNPC + "'s disposition already at maximum."); 
                    }
                    Console.WriteLine("   Lost " + iOfferedMacGuffins + " MacGuffins.");
                    NPC_AI.iTempLoyalty = NPC_AI.iTempLoyalty + iOfferedMacGuffins;
                    NPC_AI.iTempMacGuffins = NPC_AI.iTempMacGuffins + iOfferedMacGuffins;
                    NPC_AI.iTempDesireToMove = NPC_AI.iTempDesireToMove - (NPC_AI.iDesireRegen * (iOfferedMacGuffins / 2));
                    Variables.iFoundMacGuffins = Variables.iFoundMacGuffins - iOfferedMacGuffins;
                    if (iOfferedMacGuffins > 5) 
                    {
                        iOfferedMacGuffins = 5; 
                    }
                    if (NPC_AI.iTempLoyalty > 5) 
                    {
                        NPC_AI.iTempLoyalty = 5;
                    }
                }
                iLoyaltyNumberEqualsiTempLoyalty();
                NPC_AI.SetAllNPCLocals_AskMacGuffins();
                ResetAllTempConversationVariables();
            }
        }

        public static void TalkOption_MacGuffinTaking()
        {
            NPC_AI.GetAllNPCLocals_AskMacGuffins();

            iAskedMacGuffins = 0;
            Console.WriteLine();
            if ((NPC_AI.iTempMacGuffins < 1) && (NPC_AI.iTempLoyalty >= 1))
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(NPC_AI.tempNPC + " says, 'Sorry. I don't have any MacGuffins. But I'd share if I did.'"); 
            }
            else if ((NPC_AI.iTempMacGuffins < 1) && (NPC_AI.iTempLoyalty < 1)) 
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(NPC_AI.tempNPC + " says, 'I don't have anything for you.'"); 
            }
            else if (NPC_AI.iTempLoyalty < 1) 
            { 
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(NPC_AI.tempNPC + " says, 'I don't want to give you anything right now.'"); 
            }
            else if ((NPC_AI.iTempMacGuffins > 0) && (NPC_AI.iTempLoyalty > 0))
            {
                Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'I suppose I'm willing to share. How many MacGuffins are you looking for?'"); Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                while (!Variables.valid) // Check to make sure the player is offering no more than what they have, and that it's a number. Otherwise, deliver error message.
                {
                    Console.ForegroundColor = ConsoleColor.White; Variables.valid = int.TryParse(Console.ReadLine(), out iAskedMacGuffins) && (iAskedMacGuffins <= NPC_AI.iTempMacGuffins) && (iAskedMacGuffins <= NPC_AI.iTempLoyalty);
                    if (!Variables.valid) { Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " responds, 'No, that's too much. Ask for less.'"); Console.WriteLine(); }
                }
                NPC_AI.iTempLoyalty = NPC_AI.iTempLoyalty - iAskedMacGuffins; NPC_AI.iTempMacGuffins = NPC_AI.iTempMacGuffins - iAskedMacGuffins; Variables.iFoundMacGuffins = Variables.iFoundMacGuffins + iAskedMacGuffins;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(NPC_AI.tempNPC + " responds, 'I'm OK with giving you that.'"); Variables.valid = false;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   Gained " + iAskedMacGuffins + " MacGuffins.");
            }
            NPC_AI.SetAllNPCLocals_AskMacGuffins();
            ResetAllTempConversationVariables();
        }

        public static void TalkOption_WeaponGiving()
        {
            NPC_AI.GetAllNPCLocals_AskWeapon();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            if (Variables.weaponName == NPC_AI.sWeaponType0) // if the player has no weapons, stop.
            { Console.WriteLine("You do not have a weapon to give away."); }
            else if (Variables.weaponName != NPC_AI.sWeaponType0) // if the player has weapons, do all this...
            {
                if (NPC_AI.sTempWeapons == NPC_AI.sWeaponType0)
                {
                    Console.WriteLine("You give your " + Variables.weaponName + " away.");
                    NPC_AI.iTempLoyalty = NPC_AI.iTempLoyalty + NPC_AI.iOfferedWeapon;
                    NPC_AI.sTempWeapons = Variables.weaponName;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(NPC_AI.tempNPC + " thanks you for it and says, 'It's nice to have something, just in case.'");
                    Variables.weaponName = NPC_AI.sWeaponType0;
                }
                if (NPC_AI.sTempWeapons != NPC_AI.sWeaponType0 && Variables.weaponName != NPC_AI.sWeaponType0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("You offer your " + Variables.weaponName + ", but " + NPC_AI.tempNPC + " already has something. 'We could swap, but I");
                    Console.WriteLine("don't see the point. Thanks anyway.'");
                }
                NPC_AI.SetAllNPCLocals_AskWeapon();
                ResetAllTempConversationVariables();
            }
        }

        public static void TalkOption_WeaponTaking()
        {
            NPC_AI.GetAllNPCLocals_AskWeapon();
            Console.WriteLine();
            if (NPC_AI.sTempWeapons == NPC_AI.sWeaponType0) 
            { 
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(NPC_AI.tempNPC + " says, 'I don't have a weapon to give you.'"); 
                return; 
            }
            else if (NPC_AI.iTempLoyalty < 3) 
            { 
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(NPC_AI.tempNPC + " asks, 'You want my " + NPC_AI.sTempWeapons + "? If you want it, you can buy it from me.'"); 
                return; 
            }
            else if (NPC_AI.sTempWeapons != NPC_AI.sWeaponType0 && NPC_AI.iTempLoyalty >= 3) // if the NPC has a weapon and trusts you, go.
            {
                if (Variables.weaponName == NPC_AI.sWeaponType0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray; 
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'You can have my " + NPC_AI.sTempWeapons + ", but you better do some good with it.'");
                    Console.WriteLine(); 
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("With some relief, you take the " + NPC_AI.sTempWeapons + ". This should keep you protected for a while.");
                    Variables.weaponName = NPC_AI.sTempWeapons; NPC_AI.sTempWeapons = "nothing";
                    NPC_AI.iTempLoyalty = NPC_AI.iTempLoyalty - NPC_AI.iOfferedWeapon;
                }
                else if (Variables.weaponName != NPC_AI.sWeaponType0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(NPC_AI.tempNPC + " says, 'Wait, you already have something? How about we swap?'");
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'I'll give you my " + NPC_AI.sTempWeapons + " and you give me your " + Variables.weaponName + ".'");
                    tempSwapVar = Variables.weaponName;
                    Variables.weaponName = NPC_AI.sTempWeapons;
                    NPC_AI.sTempWeapons = tempSwapVar;
                }
            }
            NPC_AI.SetAllNPCLocals_AskWeapon();
            ResetAllTempConversationVariables();
        }

        public static void SavebCorpseSpotted_sLookedForNPC()
        {
            if (sLookedForNPC == NPC_AI.NPC_001) { Notebook.bCorpseSpotted001 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_002) { Notebook.bCorpseSpotted002 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_003) { Notebook.bCorpseSpotted003 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_004) { Notebook.bCorpseSpotted004 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_005) { Notebook.bCorpseSpotted005 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_006) { Notebook.bCorpseSpotted006 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_007) { Notebook.bCorpseSpotted007 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_008) { Notebook.bCorpseSpotted008 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_009) { Notebook.bCorpseSpotted009 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_010) { Notebook.bCorpseSpotted010 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_011) { Notebook.bCorpseSpotted011 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_012) { Notebook.bCorpseSpotted012 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_013) { Notebook.bCorpseSpotted013 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_014) { Notebook.bCorpseSpotted014 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_015) { Notebook.bCorpseSpotted015 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_016) { Notebook.bCorpseSpotted016 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_017) { Notebook.bCorpseSpotted017 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_018) { Notebook.bCorpseSpotted018 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_019) { Notebook.bCorpseSpotted019 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_020) { Notebook.bCorpseSpotted020 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_021) { Notebook.bCorpseSpotted021 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_022) { Notebook.bCorpseSpotted022 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_023) { Notebook.bCorpseSpotted023 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_024) { Notebook.bCorpseSpotted024 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_025) { Notebook.bCorpseSpotted025 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_026) { Notebook.bCorpseSpotted026 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_027) { Notebook.bCorpseSpotted027 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_028) { Notebook.bCorpseSpotted028 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_029) { Notebook.bCorpseSpotted029 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_030) { Notebook.bCorpseSpotted030 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_031) { Notebook.bCorpseSpotted031 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_032) { Notebook.bCorpseSpotted032 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_033) { Notebook.bCorpseSpotted033 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_034) { Notebook.bCorpseSpotted034 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_035) { Notebook.bCorpseSpotted035 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_036) { Notebook.bCorpseSpotted036 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_037) { Notebook.bCorpseSpotted037 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_038) { Notebook.bCorpseSpotted038 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_039) { Notebook.bCorpseSpotted039 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_040) { Notebook.bCorpseSpotted040 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_041) { Notebook.bCorpseSpotted041 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_042) { Notebook.bCorpseSpotted042 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_043) { Notebook.bCorpseSpotted043 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_044) { Notebook.bCorpseSpotted044 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_045) { Notebook.bCorpseSpotted045 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_046) { Notebook.bCorpseSpotted046 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_047) { Notebook.bCorpseSpotted047 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_048) { Notebook.bCorpseSpotted048 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_049) { Notebook.bCorpseSpotted049 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_050) { Notebook.bCorpseSpotted050 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_051) { Notebook.bCorpseSpotted051 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_052) { Notebook.bCorpseSpotted052 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_053) { Notebook.bCorpseSpotted053 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_054) { Notebook.bCorpseSpotted054 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_055) { Notebook.bCorpseSpotted055 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_056) { Notebook.bCorpseSpotted056 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_057) { Notebook.bCorpseSpotted057 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_058) { Notebook.bCorpseSpotted058 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_059) { Notebook.bCorpseSpotted059 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_060) { Notebook.bCorpseSpotted060 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_061) { Notebook.bCorpseSpotted061 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_062) { Notebook.bCorpseSpotted062 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_063) { Notebook.bCorpseSpotted063 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_064) { Notebook.bCorpseSpotted064 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_065) { Notebook.bCorpseSpotted065 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_066) { Notebook.bCorpseSpotted066 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_067) { Notebook.bCorpseSpotted067 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_068) { Notebook.bCorpseSpotted068 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_069) { Notebook.bCorpseSpotted069 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_070) { Notebook.bCorpseSpotted070 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_071) { Notebook.bCorpseSpotted071 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_072) { Notebook.bCorpseSpotted072 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_073) { Notebook.bCorpseSpotted073 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_074) { Notebook.bCorpseSpotted074 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_075) { Notebook.bCorpseSpotted075 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_076) { Notebook.bCorpseSpotted076 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_077) { Notebook.bCorpseSpotted077 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_078) { Notebook.bCorpseSpotted078 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_079) { Notebook.bCorpseSpotted079 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_080) { Notebook.bCorpseSpotted080 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_081) { Notebook.bCorpseSpotted081 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_082) { Notebook.bCorpseSpotted082 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_083) { Notebook.bCorpseSpotted083 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_084) { Notebook.bCorpseSpotted084 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_085) { Notebook.bCorpseSpotted085 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_086) { Notebook.bCorpseSpotted086 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_087) { Notebook.bCorpseSpotted087 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_088) { Notebook.bCorpseSpotted088 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_089) { Notebook.bCorpseSpotted089 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_090) { Notebook.bCorpseSpotted090 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_091) { Notebook.bCorpseSpotted091 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_092) { Notebook.bCorpseSpotted092 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_093) { Notebook.bCorpseSpotted093 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_094) { Notebook.bCorpseSpotted094 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_095) { Notebook.bCorpseSpotted095 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_096) { Notebook.bCorpseSpotted096 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_097) { Notebook.bCorpseSpotted097 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_098) { Notebook.bCorpseSpotted098 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_099) { Notebook.bCorpseSpotted099 = Notebook.bCorpseSpotted; }
            if (sLookedForNPC == NPC_AI.NPC_100) { Notebook.bCorpseSpotted100 = Notebook.bCorpseSpotted; }
        }

        public static void SavebCorpseSpotted_tempNPC()
        {
            if (NPC_AI.tempNPC == NPC_AI.NPC_001) { Notebook.bCorpseSpotted001 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_002) { Notebook.bCorpseSpotted002 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_003) { Notebook.bCorpseSpotted003 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_004) { Notebook.bCorpseSpotted004 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_005) { Notebook.bCorpseSpotted005 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_006) { Notebook.bCorpseSpotted006 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_007) { Notebook.bCorpseSpotted007 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_008) { Notebook.bCorpseSpotted008 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_009) { Notebook.bCorpseSpotted009 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_010) { Notebook.bCorpseSpotted010 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_011) { Notebook.bCorpseSpotted011 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_012) { Notebook.bCorpseSpotted012 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_013) { Notebook.bCorpseSpotted013 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_014) { Notebook.bCorpseSpotted014 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_015) { Notebook.bCorpseSpotted015 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_016) { Notebook.bCorpseSpotted016 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_017) { Notebook.bCorpseSpotted017 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_018) { Notebook.bCorpseSpotted018 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_019) { Notebook.bCorpseSpotted019 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_020) { Notebook.bCorpseSpotted020 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_021) { Notebook.bCorpseSpotted021 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_022) { Notebook.bCorpseSpotted022 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_023) { Notebook.bCorpseSpotted023 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_024) { Notebook.bCorpseSpotted024 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_025) { Notebook.bCorpseSpotted025 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_026) { Notebook.bCorpseSpotted026 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_027) { Notebook.bCorpseSpotted027 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_028) { Notebook.bCorpseSpotted028 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_029) { Notebook.bCorpseSpotted029 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_030) { Notebook.bCorpseSpotted030 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_031) { Notebook.bCorpseSpotted031 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_032) { Notebook.bCorpseSpotted032 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_033) { Notebook.bCorpseSpotted033 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_034) { Notebook.bCorpseSpotted034 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_035) { Notebook.bCorpseSpotted035 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_036) { Notebook.bCorpseSpotted036 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_037) { Notebook.bCorpseSpotted037 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_038) { Notebook.bCorpseSpotted038 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_039) { Notebook.bCorpseSpotted039 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_040) { Notebook.bCorpseSpotted040 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_041) { Notebook.bCorpseSpotted041 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_042) { Notebook.bCorpseSpotted042 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_043) { Notebook.bCorpseSpotted043 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_044) { Notebook.bCorpseSpotted044 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_045) { Notebook.bCorpseSpotted045 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_046) { Notebook.bCorpseSpotted046 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_047) { Notebook.bCorpseSpotted047 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_048) { Notebook.bCorpseSpotted048 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_049) { Notebook.bCorpseSpotted049 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_050) { Notebook.bCorpseSpotted050 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_051) { Notebook.bCorpseSpotted051 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_052) { Notebook.bCorpseSpotted052 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_053) { Notebook.bCorpseSpotted053 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_054) { Notebook.bCorpseSpotted054 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_055) { Notebook.bCorpseSpotted055 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_056) { Notebook.bCorpseSpotted056 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_057) { Notebook.bCorpseSpotted057 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_058) { Notebook.bCorpseSpotted058 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_059) { Notebook.bCorpseSpotted059 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_060) { Notebook.bCorpseSpotted060 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_061) { Notebook.bCorpseSpotted061 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_062) { Notebook.bCorpseSpotted062 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_063) { Notebook.bCorpseSpotted063 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_064) { Notebook.bCorpseSpotted064 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_065) { Notebook.bCorpseSpotted065 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_066) { Notebook.bCorpseSpotted066 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_067) { Notebook.bCorpseSpotted067 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_068) { Notebook.bCorpseSpotted068 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_069) { Notebook.bCorpseSpotted069 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_070) { Notebook.bCorpseSpotted070 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_071) { Notebook.bCorpseSpotted071 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_072) { Notebook.bCorpseSpotted072 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_073) { Notebook.bCorpseSpotted073 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_074) { Notebook.bCorpseSpotted074 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_075) { Notebook.bCorpseSpotted075 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_076) { Notebook.bCorpseSpotted076 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_077) { Notebook.bCorpseSpotted077 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_078) { Notebook.bCorpseSpotted078 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_079) { Notebook.bCorpseSpotted079 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_080) { Notebook.bCorpseSpotted080 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_081) { Notebook.bCorpseSpotted081 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_082) { Notebook.bCorpseSpotted082 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_083) { Notebook.bCorpseSpotted083 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_084) { Notebook.bCorpseSpotted084 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_085) { Notebook.bCorpseSpotted085 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_086) { Notebook.bCorpseSpotted086 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_087) { Notebook.bCorpseSpotted087 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_088) { Notebook.bCorpseSpotted088 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_089) { Notebook.bCorpseSpotted089 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_090) { Notebook.bCorpseSpotted090 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_091) { Notebook.bCorpseSpotted091 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_092) { Notebook.bCorpseSpotted092 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_093) { Notebook.bCorpseSpotted093 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_094) { Notebook.bCorpseSpotted094 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_095) { Notebook.bCorpseSpotted095 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_096) { Notebook.bCorpseSpotted096 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_097) { Notebook.bCorpseSpotted097 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_098) { Notebook.bCorpseSpotted098 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_099) { Notebook.bCorpseSpotted099 = Notebook.bCorpseSpotted; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_100) { Notebook.bCorpseSpotted100 = Notebook.bCorpseSpotted; }

        }

        public static void GetbCorpseSpotted_tempNPC()
        {
            if (NPC_AI.tempNPC == NPC_AI.NPC_001) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted001; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_002) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted002; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_003) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted003; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_004) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted004; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_005) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted005; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_006) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted006; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_007) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted007; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_008) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted008; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_009) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted009; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_010) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted010; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_011) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted011; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_012) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted012; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_013) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted013; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_014) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted014; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_015) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted015; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_016) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted016; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_017) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted017; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_018) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted018; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_019) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted019; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_020) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted020; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_021) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted021; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_022) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted022; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_023) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted023; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_024) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted024; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_025) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted025; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_026) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted026; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_027) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted027; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_028) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted028; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_029) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted029; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_030) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted030; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_031) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted031; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_032) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted032; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_033) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted033; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_034) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted034; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_035) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted035; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_036) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted036; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_037) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted037; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_038) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted038; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_039) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted039; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_040) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted040; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_041) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted041; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_042) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted042; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_043) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted043; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_044) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted044; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_045) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted045; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_046) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted046; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_047) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted047; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_048) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted048; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_049) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted049; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_050) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted050; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_051) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted051; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_052) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted052; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_053) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted053; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_054) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted054; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_055) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted055; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_056) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted056; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_057) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted057; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_058) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted058; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_059) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted059; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_060) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted060; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_061) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted061; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_062) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted062; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_063) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted063; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_064) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted064; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_065) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted065; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_066) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted066; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_067) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted067; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_068) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted068; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_069) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted069; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_070) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted070; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_071) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted071; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_072) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted072; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_073) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted073; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_074) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted074; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_075) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted075; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_076) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted076; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_077) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted077; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_078) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted078; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_079) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted079; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_080) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted080; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_081) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted081; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_082) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted082; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_083) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted083; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_084) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted084; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_085) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted085; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_086) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted086; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_087) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted087; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_088) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted088; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_089) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted089; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_090) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted090; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_091) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted091; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_092) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted092; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_093) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted093; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_094) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted094; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_095) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted095; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_096) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted096; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_097) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted097; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_098) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted098; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_099) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted099; }
            if (NPC_AI.tempNPC == NPC_AI.NPC_100) { Notebook.bCorpseSpotted = Notebook.bCorpseSpotted100; }
        }

        public static void SavebCorpseSpotted_query()
        {
            if (query.ToLower() == NPC_AI.NPC_001.ToLower()) { Notebook.bCorpseSpotted001 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_002.ToLower()) { Notebook.bCorpseSpotted002 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_003.ToLower()) { Notebook.bCorpseSpotted003 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_004.ToLower()) { Notebook.bCorpseSpotted004 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_005.ToLower()) { Notebook.bCorpseSpotted005 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_006.ToLower()) { Notebook.bCorpseSpotted006 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_007.ToLower()) { Notebook.bCorpseSpotted007 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_008.ToLower()) { Notebook.bCorpseSpotted008 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_009.ToLower()) { Notebook.bCorpseSpotted009 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_010.ToLower()) { Notebook.bCorpseSpotted010 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_011.ToLower()) { Notebook.bCorpseSpotted011 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_012.ToLower()) { Notebook.bCorpseSpotted012 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_013.ToLower()) { Notebook.bCorpseSpotted013 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_014.ToLower()) { Notebook.bCorpseSpotted014 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_015.ToLower()) { Notebook.bCorpseSpotted015 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_016.ToLower()) { Notebook.bCorpseSpotted016 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_017.ToLower()) { Notebook.bCorpseSpotted017 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_018.ToLower()) { Notebook.bCorpseSpotted018 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_019.ToLower()) { Notebook.bCorpseSpotted019 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_020.ToLower()) { Notebook.bCorpseSpotted020 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_021.ToLower()) { Notebook.bCorpseSpotted021 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_022.ToLower()) { Notebook.bCorpseSpotted022 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_023.ToLower()) { Notebook.bCorpseSpotted023 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_024.ToLower()) { Notebook.bCorpseSpotted024 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_025.ToLower()) { Notebook.bCorpseSpotted025 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_026.ToLower()) { Notebook.bCorpseSpotted026 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_027.ToLower()) { Notebook.bCorpseSpotted027 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_028.ToLower()) { Notebook.bCorpseSpotted028 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_029.ToLower()) { Notebook.bCorpseSpotted029 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_030.ToLower()) { Notebook.bCorpseSpotted030 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_031.ToLower()) { Notebook.bCorpseSpotted031 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_032.ToLower()) { Notebook.bCorpseSpotted032 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_033.ToLower()) { Notebook.bCorpseSpotted033 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_034.ToLower()) { Notebook.bCorpseSpotted034 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_035.ToLower()) { Notebook.bCorpseSpotted035 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_036.ToLower()) { Notebook.bCorpseSpotted036 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_037.ToLower()) { Notebook.bCorpseSpotted037 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_038.ToLower()) { Notebook.bCorpseSpotted038 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_039.ToLower()) { Notebook.bCorpseSpotted039 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_040.ToLower()) { Notebook.bCorpseSpotted040 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_041.ToLower()) { Notebook.bCorpseSpotted041 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_042.ToLower()) { Notebook.bCorpseSpotted042 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_043.ToLower()) { Notebook.bCorpseSpotted043 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_044.ToLower()) { Notebook.bCorpseSpotted044 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_045.ToLower()) { Notebook.bCorpseSpotted045 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_046.ToLower()) { Notebook.bCorpseSpotted046 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_047.ToLower()) { Notebook.bCorpseSpotted047 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_048.ToLower()) { Notebook.bCorpseSpotted048 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_049.ToLower()) { Notebook.bCorpseSpotted049 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_050.ToLower()) { Notebook.bCorpseSpotted050 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_051.ToLower()) { Notebook.bCorpseSpotted051 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_052.ToLower()) { Notebook.bCorpseSpotted052 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_053.ToLower()) { Notebook.bCorpseSpotted053 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_054.ToLower()) { Notebook.bCorpseSpotted054 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_055.ToLower()) { Notebook.bCorpseSpotted055 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_056.ToLower()) { Notebook.bCorpseSpotted056 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_057.ToLower()) { Notebook.bCorpseSpotted057 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_058.ToLower()) { Notebook.bCorpseSpotted058 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_059.ToLower()) { Notebook.bCorpseSpotted059 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_060.ToLower()) { Notebook.bCorpseSpotted060 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_061.ToLower()) { Notebook.bCorpseSpotted061 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_062.ToLower()) { Notebook.bCorpseSpotted062 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_063.ToLower()) { Notebook.bCorpseSpotted063 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_064.ToLower()) { Notebook.bCorpseSpotted064 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_065.ToLower()) { Notebook.bCorpseSpotted065 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_066.ToLower()) { Notebook.bCorpseSpotted066 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_067.ToLower()) { Notebook.bCorpseSpotted067 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_068.ToLower()) { Notebook.bCorpseSpotted068 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_069.ToLower()) { Notebook.bCorpseSpotted069 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_070.ToLower()) { Notebook.bCorpseSpotted070 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_071.ToLower()) { Notebook.bCorpseSpotted071 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_072.ToLower()) { Notebook.bCorpseSpotted072 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_073.ToLower()) { Notebook.bCorpseSpotted073 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_074.ToLower()) { Notebook.bCorpseSpotted074 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_075.ToLower()) { Notebook.bCorpseSpotted075 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_076.ToLower()) { Notebook.bCorpseSpotted076 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_077.ToLower()) { Notebook.bCorpseSpotted077 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_078.ToLower()) { Notebook.bCorpseSpotted078 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_079.ToLower()) { Notebook.bCorpseSpotted079 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_080.ToLower()) { Notebook.bCorpseSpotted080 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_081.ToLower()) { Notebook.bCorpseSpotted081 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_082.ToLower()) { Notebook.bCorpseSpotted082 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_083.ToLower()) { Notebook.bCorpseSpotted083 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_084.ToLower()) { Notebook.bCorpseSpotted084 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_085.ToLower()) { Notebook.bCorpseSpotted085 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_086.ToLower()) { Notebook.bCorpseSpotted086 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_087.ToLower()) { Notebook.bCorpseSpotted087 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_088.ToLower()) { Notebook.bCorpseSpotted088 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_089.ToLower()) { Notebook.bCorpseSpotted089 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_090.ToLower()) { Notebook.bCorpseSpotted090 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_091.ToLower()) { Notebook.bCorpseSpotted091 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_092.ToLower()) { Notebook.bCorpseSpotted092 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_093.ToLower()) { Notebook.bCorpseSpotted093 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_094.ToLower()) { Notebook.bCorpseSpotted094 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_095.ToLower()) { Notebook.bCorpseSpotted095 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_096.ToLower()) { Notebook.bCorpseSpotted096 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_097.ToLower()) { Notebook.bCorpseSpotted097 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_098.ToLower()) { Notebook.bCorpseSpotted098 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_099.ToLower()) { Notebook.bCorpseSpotted099 = Notebook.bCorpseSpotted; }
            if (query.ToLower() == NPC_AI.NPC_100.ToLower()) { Notebook.bCorpseSpotted100 = Notebook.bCorpseSpotted; }
                
        }

        public static void TalkOption_ForWhomAreYouLooking()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.WriteLine(NPC_AI.tempNPC + " says, 'I'm not sure. Maybe. Who are you looking for?'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("TIP: You may write a name like 'Bruce', 'bruce', or 'BRUCE'.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            query = "null_query";
            sLookedForNPC = "null_sLookedForNPC";
            bValidName = false;

            query = Console.ReadLine();
            Console.WriteLine();
            // if (query.ToLower() == NPC_001.ToLower()) // 30%/30% chance to give correct location authoritatively/doubtfully, 30% chance to say they don't know, and 10% chance to give wrong location
            // { Console.WriteLine(NPC_001 + ", eh? I think you can find " + sGenderHimHer + " at " + NPC001_CurrentStrLocation); }
            
            while (!bValidName)
            {
                if (query.ToLower() == NPC_AI.NPC_001.ToLower()) 
                { 
                    sLookedForNPC = NPC_AI.NPC_001; 
                    NPC_AI.sTempCurrentLocation = NPC_AI.NPC001_CurrentStrLocation; 
                    AccusationEncounters.bTempQueried = AccusationEncounters.bQueried001; 
                    bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne001;
                    NPC_AI.bTempCorpse = NPC_AI.bCorpse001;
                    Notebook.bCorpseSpotted = Notebook.bCorpseSpotted001; 
                }
                if (query.ToLower() == NPC_AI.NPC_002.ToLower()) { sLookedForNPC = NPC_AI.NPC_002; NPC_AI.sTempCurrentLocation = NPC_AI.NPC002_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried002; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne002; NPC_AI.bTempCorpse = NPC_AI.bCorpse002; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted002; }
                if (query.ToLower() == NPC_AI.NPC_003.ToLower()) { sLookedForNPC = NPC_AI.NPC_003; NPC_AI.sTempCurrentLocation = NPC_AI.NPC003_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried003; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne003; NPC_AI.bTempCorpse = NPC_AI.bCorpse003; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted003; }
                if (query.ToLower() == NPC_AI.NPC_004.ToLower()) { sLookedForNPC = NPC_AI.NPC_004; NPC_AI.sTempCurrentLocation = NPC_AI.NPC004_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried004; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne004; NPC_AI.bTempCorpse = NPC_AI.bCorpse004; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted004; }
                if (query.ToLower() == NPC_AI.NPC_005.ToLower()) { sLookedForNPC = NPC_AI.NPC_005; NPC_AI.sTempCurrentLocation = NPC_AI.NPC005_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried005; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne005; NPC_AI.bTempCorpse = NPC_AI.bCorpse005; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted005; }
                if (query.ToLower() == NPC_AI.NPC_006.ToLower()) { sLookedForNPC = NPC_AI.NPC_006; NPC_AI.sTempCurrentLocation = NPC_AI.NPC006_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried006; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne006; NPC_AI.bTempCorpse = NPC_AI.bCorpse006; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted006; }
                if (query.ToLower() == NPC_AI.NPC_007.ToLower()) { sLookedForNPC = NPC_AI.NPC_007; NPC_AI.sTempCurrentLocation = NPC_AI.NPC007_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried007; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne007; NPC_AI.bTempCorpse = NPC_AI.bCorpse007; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted007; }
                if (query.ToLower() == NPC_AI.NPC_008.ToLower()) { sLookedForNPC = NPC_AI.NPC_008; NPC_AI.sTempCurrentLocation = NPC_AI.NPC008_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried008; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne008; NPC_AI.bTempCorpse = NPC_AI.bCorpse008; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted008; }
                if (query.ToLower() == NPC_AI.NPC_009.ToLower()) { sLookedForNPC = NPC_AI.NPC_009; NPC_AI.sTempCurrentLocation = NPC_AI.NPC009_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried009; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne009; NPC_AI.bTempCorpse = NPC_AI.bCorpse009; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted009; }
                if (query.ToLower() == NPC_AI.NPC_010.ToLower()) { sLookedForNPC = NPC_AI.NPC_010; NPC_AI.sTempCurrentLocation = NPC_AI.NPC010_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried010; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne010; NPC_AI.bTempCorpse = NPC_AI.bCorpse010; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted010; }
                if (query.ToLower() == NPC_AI.NPC_011.ToLower()) { sLookedForNPC = NPC_AI.NPC_011; NPC_AI.sTempCurrentLocation = NPC_AI.NPC011_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried011; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne011; NPC_AI.bTempCorpse = NPC_AI.bCorpse011; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted011; }
                if (query.ToLower() == NPC_AI.NPC_012.ToLower()) { sLookedForNPC = NPC_AI.NPC_012; NPC_AI.sTempCurrentLocation = NPC_AI.NPC012_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried012; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne012; NPC_AI.bTempCorpse = NPC_AI.bCorpse012; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted012; }
                if (query.ToLower() == NPC_AI.NPC_013.ToLower()) { sLookedForNPC = NPC_AI.NPC_013; NPC_AI.sTempCurrentLocation = NPC_AI.NPC013_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried013; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne013; NPC_AI.bTempCorpse = NPC_AI.bCorpse013; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted013; }
                if (query.ToLower() == NPC_AI.NPC_014.ToLower()) { sLookedForNPC = NPC_AI.NPC_014; NPC_AI.sTempCurrentLocation = NPC_AI.NPC014_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried014; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne014; NPC_AI.bTempCorpse = NPC_AI.bCorpse014; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted014; }
                if (query.ToLower() == NPC_AI.NPC_015.ToLower()) { sLookedForNPC = NPC_AI.NPC_015; NPC_AI.sTempCurrentLocation = NPC_AI.NPC015_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried015; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne015; NPC_AI.bTempCorpse = NPC_AI.bCorpse015; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted015; }
                if (query.ToLower() == NPC_AI.NPC_016.ToLower()) { sLookedForNPC = NPC_AI.NPC_016; NPC_AI.sTempCurrentLocation = NPC_AI.NPC016_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried016; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne016; NPC_AI.bTempCorpse = NPC_AI.bCorpse016; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted016; }
                if (query.ToLower() == NPC_AI.NPC_017.ToLower()) { sLookedForNPC = NPC_AI.NPC_017; NPC_AI.sTempCurrentLocation = NPC_AI.NPC017_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried017; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne017; NPC_AI.bTempCorpse = NPC_AI.bCorpse017; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted017; }
                if (query.ToLower() == NPC_AI.NPC_018.ToLower()) { sLookedForNPC = NPC_AI.NPC_018; NPC_AI.sTempCurrentLocation = NPC_AI.NPC018_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried018; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne018; NPC_AI.bTempCorpse = NPC_AI.bCorpse018; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted018; }
                if (query.ToLower() == NPC_AI.NPC_019.ToLower()) { sLookedForNPC = NPC_AI.NPC_019; NPC_AI.sTempCurrentLocation = NPC_AI.NPC019_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried019; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne019; NPC_AI.bTempCorpse = NPC_AI.bCorpse019; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted019; }
                if (query.ToLower() == NPC_AI.NPC_020.ToLower()) { sLookedForNPC = NPC_AI.NPC_020; NPC_AI.sTempCurrentLocation = NPC_AI.NPC020_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried020; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne020; NPC_AI.bTempCorpse = NPC_AI.bCorpse020; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted020; }
                if (query.ToLower() == NPC_AI.NPC_021.ToLower()) { sLookedForNPC = NPC_AI.NPC_021; NPC_AI.sTempCurrentLocation = NPC_AI.NPC021_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried021; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne021; NPC_AI.bTempCorpse = NPC_AI.bCorpse021; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted021; }
                if (query.ToLower() == NPC_AI.NPC_022.ToLower()) { sLookedForNPC = NPC_AI.NPC_022; NPC_AI.sTempCurrentLocation = NPC_AI.NPC022_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried022; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne022; NPC_AI.bTempCorpse = NPC_AI.bCorpse022; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted022; }
                if (query.ToLower() == NPC_AI.NPC_023.ToLower()) { sLookedForNPC = NPC_AI.NPC_023; NPC_AI.sTempCurrentLocation = NPC_AI.NPC023_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried023; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne023; NPC_AI.bTempCorpse = NPC_AI.bCorpse023; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted023; }
                if (query.ToLower() == NPC_AI.NPC_024.ToLower()) { sLookedForNPC = NPC_AI.NPC_024; NPC_AI.sTempCurrentLocation = NPC_AI.NPC024_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried024; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne024; NPC_AI.bTempCorpse = NPC_AI.bCorpse024; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted024; }
                if (query.ToLower() == NPC_AI.NPC_025.ToLower()) { sLookedForNPC = NPC_AI.NPC_025; NPC_AI.sTempCurrentLocation = NPC_AI.NPC025_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried025; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne025; NPC_AI.bTempCorpse = NPC_AI.bCorpse025; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted025; }
                if (query.ToLower() == NPC_AI.NPC_026.ToLower()) { sLookedForNPC = NPC_AI.NPC_026; NPC_AI.sTempCurrentLocation = NPC_AI.NPC026_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried026; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne026; NPC_AI.bTempCorpse = NPC_AI.bCorpse026; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted026; }
                if (query.ToLower() == NPC_AI.NPC_027.ToLower()) { sLookedForNPC = NPC_AI.NPC_027; NPC_AI.sTempCurrentLocation = NPC_AI.NPC027_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried027; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne027; NPC_AI.bTempCorpse = NPC_AI.bCorpse027; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted027; }
                if (query.ToLower() == NPC_AI.NPC_028.ToLower()) { sLookedForNPC = NPC_AI.NPC_028; NPC_AI.sTempCurrentLocation = NPC_AI.NPC028_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried028; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne028; NPC_AI.bTempCorpse = NPC_AI.bCorpse028; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted028; }
                if (query.ToLower() == NPC_AI.NPC_029.ToLower()) { sLookedForNPC = NPC_AI.NPC_029; NPC_AI.sTempCurrentLocation = NPC_AI.NPC029_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried029; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne029; NPC_AI.bTempCorpse = NPC_AI.bCorpse029; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted029; }
                if (query.ToLower() == NPC_AI.NPC_030.ToLower()) { sLookedForNPC = NPC_AI.NPC_030; NPC_AI.sTempCurrentLocation = NPC_AI.NPC030_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried030; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne030; NPC_AI.bTempCorpse = NPC_AI.bCorpse030; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted030; }
                if (query.ToLower() == NPC_AI.NPC_031.ToLower()) { sLookedForNPC = NPC_AI.NPC_031; NPC_AI.sTempCurrentLocation = NPC_AI.NPC031_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried031; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne031; NPC_AI.bTempCorpse = NPC_AI.bCorpse031; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted031; }
                if (query.ToLower() == NPC_AI.NPC_032.ToLower()) { sLookedForNPC = NPC_AI.NPC_032; NPC_AI.sTempCurrentLocation = NPC_AI.NPC032_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried032; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne032; NPC_AI.bTempCorpse = NPC_AI.bCorpse032; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted032; }
                if (query.ToLower() == NPC_AI.NPC_033.ToLower()) { sLookedForNPC = NPC_AI.NPC_033; NPC_AI.sTempCurrentLocation = NPC_AI.NPC033_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried033; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne033; NPC_AI.bTempCorpse = NPC_AI.bCorpse033; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted033; }
                if (query.ToLower() == NPC_AI.NPC_034.ToLower()) { sLookedForNPC = NPC_AI.NPC_034; NPC_AI.sTempCurrentLocation = NPC_AI.NPC034_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried034; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne034; NPC_AI.bTempCorpse = NPC_AI.bCorpse034; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted034; }
                if (query.ToLower() == NPC_AI.NPC_035.ToLower()) { sLookedForNPC = NPC_AI.NPC_035; NPC_AI.sTempCurrentLocation = NPC_AI.NPC035_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried035; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne035; NPC_AI.bTempCorpse = NPC_AI.bCorpse035; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted035; }
                if (query.ToLower() == NPC_AI.NPC_036.ToLower()) { sLookedForNPC = NPC_AI.NPC_036; NPC_AI.sTempCurrentLocation = NPC_AI.NPC036_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried036; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne036; NPC_AI.bTempCorpse = NPC_AI.bCorpse036; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted036; }
                if (query.ToLower() == NPC_AI.NPC_037.ToLower()) { sLookedForNPC = NPC_AI.NPC_037; NPC_AI.sTempCurrentLocation = NPC_AI.NPC037_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried037; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne037; NPC_AI.bTempCorpse = NPC_AI.bCorpse037; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted037; }
                if (query.ToLower() == NPC_AI.NPC_038.ToLower()) { sLookedForNPC = NPC_AI.NPC_038; NPC_AI.sTempCurrentLocation = NPC_AI.NPC038_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried038; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne038; NPC_AI.bTempCorpse = NPC_AI.bCorpse038; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted038; }
                if (query.ToLower() == NPC_AI.NPC_039.ToLower()) { sLookedForNPC = NPC_AI.NPC_039; NPC_AI.sTempCurrentLocation = NPC_AI.NPC039_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried039; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne039; NPC_AI.bTempCorpse = NPC_AI.bCorpse039; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted039; }
                if (query.ToLower() == NPC_AI.NPC_040.ToLower()) { sLookedForNPC = NPC_AI.NPC_040; NPC_AI.sTempCurrentLocation = NPC_AI.NPC040_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried040; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne040; NPC_AI.bTempCorpse = NPC_AI.bCorpse040; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted040; }
                if (query.ToLower() == NPC_AI.NPC_041.ToLower()) { sLookedForNPC = NPC_AI.NPC_041; NPC_AI.sTempCurrentLocation = NPC_AI.NPC041_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried041; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne041; NPC_AI.bTempCorpse = NPC_AI.bCorpse041; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted041; }
                if (query.ToLower() == NPC_AI.NPC_042.ToLower()) { sLookedForNPC = NPC_AI.NPC_042; NPC_AI.sTempCurrentLocation = NPC_AI.NPC042_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried042; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne042; NPC_AI.bTempCorpse = NPC_AI.bCorpse042; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted042; }
                if (query.ToLower() == NPC_AI.NPC_043.ToLower()) { sLookedForNPC = NPC_AI.NPC_043; NPC_AI.sTempCurrentLocation = NPC_AI.NPC043_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried043; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne043; NPC_AI.bTempCorpse = NPC_AI.bCorpse043; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted043; }
                if (query.ToLower() == NPC_AI.NPC_044.ToLower()) { sLookedForNPC = NPC_AI.NPC_044; NPC_AI.sTempCurrentLocation = NPC_AI.NPC044_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried044; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne044; NPC_AI.bTempCorpse = NPC_AI.bCorpse044; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted044; }
                if (query.ToLower() == NPC_AI.NPC_045.ToLower()) { sLookedForNPC = NPC_AI.NPC_045; NPC_AI.sTempCurrentLocation = NPC_AI.NPC045_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried045; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne045; NPC_AI.bTempCorpse = NPC_AI.bCorpse045; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted045; }
                if (query.ToLower() == NPC_AI.NPC_046.ToLower()) { sLookedForNPC = NPC_AI.NPC_046; NPC_AI.sTempCurrentLocation = NPC_AI.NPC046_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried046; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne046; NPC_AI.bTempCorpse = NPC_AI.bCorpse046; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted046; }
                if (query.ToLower() == NPC_AI.NPC_047.ToLower()) { sLookedForNPC = NPC_AI.NPC_047; NPC_AI.sTempCurrentLocation = NPC_AI.NPC047_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried047; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne047; NPC_AI.bTempCorpse = NPC_AI.bCorpse047; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted047; }
                if (query.ToLower() == NPC_AI.NPC_048.ToLower()) { sLookedForNPC = NPC_AI.NPC_048; NPC_AI.sTempCurrentLocation = NPC_AI.NPC048_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried048; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne048; NPC_AI.bTempCorpse = NPC_AI.bCorpse048; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted048; }
                if (query.ToLower() == NPC_AI.NPC_049.ToLower()) { sLookedForNPC = NPC_AI.NPC_049; NPC_AI.sTempCurrentLocation = NPC_AI.NPC049_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried049; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne049; NPC_AI.bTempCorpse = NPC_AI.bCorpse049; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted049; }
                if (query.ToLower() == NPC_AI.NPC_050.ToLower()) { sLookedForNPC = NPC_AI.NPC_050; NPC_AI.sTempCurrentLocation = NPC_AI.NPC050_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried050; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne050; NPC_AI.bTempCorpse = NPC_AI.bCorpse050; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted050; }
                if (query.ToLower() == NPC_AI.NPC_051.ToLower()) { sLookedForNPC = NPC_AI.NPC_051; NPC_AI.sTempCurrentLocation = NPC_AI.NPC051_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried051; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne051; NPC_AI.bTempCorpse = NPC_AI.bCorpse051; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted051; }
                if (query.ToLower() == NPC_AI.NPC_052.ToLower()) { sLookedForNPC = NPC_AI.NPC_052; NPC_AI.sTempCurrentLocation = NPC_AI.NPC052_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried052; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne052; NPC_AI.bTempCorpse = NPC_AI.bCorpse052; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted052; }
                if (query.ToLower() == NPC_AI.NPC_053.ToLower()) { sLookedForNPC = NPC_AI.NPC_053; NPC_AI.sTempCurrentLocation = NPC_AI.NPC053_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried053; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne053; NPC_AI.bTempCorpse = NPC_AI.bCorpse053; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted053; }
                if (query.ToLower() == NPC_AI.NPC_054.ToLower()) { sLookedForNPC = NPC_AI.NPC_054; NPC_AI.sTempCurrentLocation = NPC_AI.NPC054_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried054; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne054; NPC_AI.bTempCorpse = NPC_AI.bCorpse054; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted054; }
                if (query.ToLower() == NPC_AI.NPC_055.ToLower()) { sLookedForNPC = NPC_AI.NPC_055; NPC_AI.sTempCurrentLocation = NPC_AI.NPC055_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried055; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne055; NPC_AI.bTempCorpse = NPC_AI.bCorpse055; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted055; }
                if (query.ToLower() == NPC_AI.NPC_056.ToLower()) { sLookedForNPC = NPC_AI.NPC_056; NPC_AI.sTempCurrentLocation = NPC_AI.NPC056_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried056; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne056; NPC_AI.bTempCorpse = NPC_AI.bCorpse056; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted056; }
                if (query.ToLower() == NPC_AI.NPC_057.ToLower()) { sLookedForNPC = NPC_AI.NPC_057; NPC_AI.sTempCurrentLocation = NPC_AI.NPC057_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried057; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne057; NPC_AI.bTempCorpse = NPC_AI.bCorpse057; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted057; }
                if (query.ToLower() == NPC_AI.NPC_058.ToLower()) { sLookedForNPC = NPC_AI.NPC_058; NPC_AI.sTempCurrentLocation = NPC_AI.NPC058_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried058; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne058; NPC_AI.bTempCorpse = NPC_AI.bCorpse058; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted058; }
                if (query.ToLower() == NPC_AI.NPC_059.ToLower()) { sLookedForNPC = NPC_AI.NPC_059; NPC_AI.sTempCurrentLocation = NPC_AI.NPC059_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried059; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne059; NPC_AI.bTempCorpse = NPC_AI.bCorpse059; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted059; }
                if (query.ToLower() == NPC_AI.NPC_060.ToLower()) { sLookedForNPC = NPC_AI.NPC_060; NPC_AI.sTempCurrentLocation = NPC_AI.NPC060_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried060; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne060; NPC_AI.bTempCorpse = NPC_AI.bCorpse060; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted060; }
                if (query.ToLower() == NPC_AI.NPC_061.ToLower()) { sLookedForNPC = NPC_AI.NPC_061; NPC_AI.sTempCurrentLocation = NPC_AI.NPC061_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried061; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne061; NPC_AI.bTempCorpse = NPC_AI.bCorpse061; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted061; }
                if (query.ToLower() == NPC_AI.NPC_062.ToLower()) { sLookedForNPC = NPC_AI.NPC_062; NPC_AI.sTempCurrentLocation = NPC_AI.NPC062_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried062; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne062; NPC_AI.bTempCorpse = NPC_AI.bCorpse062; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted062; }
                if (query.ToLower() == NPC_AI.NPC_063.ToLower()) { sLookedForNPC = NPC_AI.NPC_063; NPC_AI.sTempCurrentLocation = NPC_AI.NPC063_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried063; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne063; NPC_AI.bTempCorpse = NPC_AI.bCorpse063; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted063; }
                if (query.ToLower() == NPC_AI.NPC_064.ToLower()) { sLookedForNPC = NPC_AI.NPC_064; NPC_AI.sTempCurrentLocation = NPC_AI.NPC064_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried064; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne064; NPC_AI.bTempCorpse = NPC_AI.bCorpse064; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted064; }
                if (query.ToLower() == NPC_AI.NPC_065.ToLower()) { sLookedForNPC = NPC_AI.NPC_065; NPC_AI.sTempCurrentLocation = NPC_AI.NPC065_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried065; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne065; NPC_AI.bTempCorpse = NPC_AI.bCorpse065; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted065; }
                if (query.ToLower() == NPC_AI.NPC_066.ToLower()) { sLookedForNPC = NPC_AI.NPC_066; NPC_AI.sTempCurrentLocation = NPC_AI.NPC066_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried066; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne066; NPC_AI.bTempCorpse = NPC_AI.bCorpse066; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted066; }
                if (query.ToLower() == NPC_AI.NPC_067.ToLower()) { sLookedForNPC = NPC_AI.NPC_067; NPC_AI.sTempCurrentLocation = NPC_AI.NPC067_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried067; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne067; NPC_AI.bTempCorpse = NPC_AI.bCorpse067; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted067; }
                if (query.ToLower() == NPC_AI.NPC_068.ToLower()) { sLookedForNPC = NPC_AI.NPC_068; NPC_AI.sTempCurrentLocation = NPC_AI.NPC068_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried068; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne068; NPC_AI.bTempCorpse = NPC_AI.bCorpse068; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted068; }
                if (query.ToLower() == NPC_AI.NPC_069.ToLower()) { sLookedForNPC = NPC_AI.NPC_069; NPC_AI.sTempCurrentLocation = NPC_AI.NPC069_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried069; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne069; NPC_AI.bTempCorpse = NPC_AI.bCorpse069; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted069; }
                if (query.ToLower() == NPC_AI.NPC_070.ToLower()) { sLookedForNPC = NPC_AI.NPC_070; NPC_AI.sTempCurrentLocation = NPC_AI.NPC070_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried070; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne070; NPC_AI.bTempCorpse = NPC_AI.bCorpse070; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted070; }
                if (query.ToLower() == NPC_AI.NPC_071.ToLower()) { sLookedForNPC = NPC_AI.NPC_071; NPC_AI.sTempCurrentLocation = NPC_AI.NPC071_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried071; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne071; NPC_AI.bTempCorpse = NPC_AI.bCorpse071; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted071; }
                if (query.ToLower() == NPC_AI.NPC_072.ToLower()) { sLookedForNPC = NPC_AI.NPC_072; NPC_AI.sTempCurrentLocation = NPC_AI.NPC072_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried072; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne072; NPC_AI.bTempCorpse = NPC_AI.bCorpse072; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted072; }
                if (query.ToLower() == NPC_AI.NPC_073.ToLower()) { sLookedForNPC = NPC_AI.NPC_073; NPC_AI.sTempCurrentLocation = NPC_AI.NPC073_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried073; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne073; NPC_AI.bTempCorpse = NPC_AI.bCorpse073; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted073; }
                if (query.ToLower() == NPC_AI.NPC_074.ToLower()) { sLookedForNPC = NPC_AI.NPC_074; NPC_AI.sTempCurrentLocation = NPC_AI.NPC074_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried074; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne074; NPC_AI.bTempCorpse = NPC_AI.bCorpse074; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted074; }
                if (query.ToLower() == NPC_AI.NPC_075.ToLower()) { sLookedForNPC = NPC_AI.NPC_075; NPC_AI.sTempCurrentLocation = NPC_AI.NPC075_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried075; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne075; NPC_AI.bTempCorpse = NPC_AI.bCorpse075; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted075; }
                if (query.ToLower() == NPC_AI.NPC_076.ToLower()) { sLookedForNPC = NPC_AI.NPC_076; NPC_AI.sTempCurrentLocation = NPC_AI.NPC076_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried076; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne076; NPC_AI.bTempCorpse = NPC_AI.bCorpse076; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted076; }
                if (query.ToLower() == NPC_AI.NPC_077.ToLower()) { sLookedForNPC = NPC_AI.NPC_077; NPC_AI.sTempCurrentLocation = NPC_AI.NPC077_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried077; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne077; NPC_AI.bTempCorpse = NPC_AI.bCorpse077; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted077; }
                if (query.ToLower() == NPC_AI.NPC_078.ToLower()) { sLookedForNPC = NPC_AI.NPC_078; NPC_AI.sTempCurrentLocation = NPC_AI.NPC078_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried078; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne078; NPC_AI.bTempCorpse = NPC_AI.bCorpse078; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted078; }
                if (query.ToLower() == NPC_AI.NPC_079.ToLower()) { sLookedForNPC = NPC_AI.NPC_079; NPC_AI.sTempCurrentLocation = NPC_AI.NPC079_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried079; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne079; NPC_AI.bTempCorpse = NPC_AI.bCorpse079; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted079; }
                if (query.ToLower() == NPC_AI.NPC_080.ToLower()) { sLookedForNPC = NPC_AI.NPC_080; NPC_AI.sTempCurrentLocation = NPC_AI.NPC080_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried080; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne080; NPC_AI.bTempCorpse = NPC_AI.bCorpse080; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted080; }
                if (query.ToLower() == NPC_AI.NPC_081.ToLower()) { sLookedForNPC = NPC_AI.NPC_081; NPC_AI.sTempCurrentLocation = NPC_AI.NPC081_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried081; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne081; NPC_AI.bTempCorpse = NPC_AI.bCorpse081; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted081; }
                if (query.ToLower() == NPC_AI.NPC_082.ToLower()) { sLookedForNPC = NPC_AI.NPC_082; NPC_AI.sTempCurrentLocation = NPC_AI.NPC082_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried082; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne082; NPC_AI.bTempCorpse = NPC_AI.bCorpse082; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted082; }
                if (query.ToLower() == NPC_AI.NPC_083.ToLower()) { sLookedForNPC = NPC_AI.NPC_083; NPC_AI.sTempCurrentLocation = NPC_AI.NPC083_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried083; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne083; NPC_AI.bTempCorpse = NPC_AI.bCorpse083; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted083; }
                if (query.ToLower() == NPC_AI.NPC_084.ToLower()) { sLookedForNPC = NPC_AI.NPC_084; NPC_AI.sTempCurrentLocation = NPC_AI.NPC084_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried084; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne084; NPC_AI.bTempCorpse = NPC_AI.bCorpse084; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted084; }
                if (query.ToLower() == NPC_AI.NPC_085.ToLower()) { sLookedForNPC = NPC_AI.NPC_085; NPC_AI.sTempCurrentLocation = NPC_AI.NPC085_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried085; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne085; NPC_AI.bTempCorpse = NPC_AI.bCorpse085; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted085; }
                if (query.ToLower() == NPC_AI.NPC_086.ToLower()) { sLookedForNPC = NPC_AI.NPC_086; NPC_AI.sTempCurrentLocation = NPC_AI.NPC086_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried086; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne086; NPC_AI.bTempCorpse = NPC_AI.bCorpse086; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted086; }
                if (query.ToLower() == NPC_AI.NPC_087.ToLower()) { sLookedForNPC = NPC_AI.NPC_087; NPC_AI.sTempCurrentLocation = NPC_AI.NPC087_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried087; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne087; NPC_AI.bTempCorpse = NPC_AI.bCorpse087; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted087; }
                if (query.ToLower() == NPC_AI.NPC_088.ToLower()) { sLookedForNPC = NPC_AI.NPC_088; NPC_AI.sTempCurrentLocation = NPC_AI.NPC088_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried088; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne088; NPC_AI.bTempCorpse = NPC_AI.bCorpse088; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted088; }
                if (query.ToLower() == NPC_AI.NPC_089.ToLower()) { sLookedForNPC = NPC_AI.NPC_089; NPC_AI.sTempCurrentLocation = NPC_AI.NPC089_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried089; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne089; NPC_AI.bTempCorpse = NPC_AI.bCorpse089; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted089; }
                if (query.ToLower() == NPC_AI.NPC_090.ToLower()) { sLookedForNPC = NPC_AI.NPC_090; NPC_AI.sTempCurrentLocation = NPC_AI.NPC090_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried090; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne090; NPC_AI.bTempCorpse = NPC_AI.bCorpse090; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted090; }
                if (query.ToLower() == NPC_AI.NPC_091.ToLower()) { sLookedForNPC = NPC_AI.NPC_091; NPC_AI.sTempCurrentLocation = NPC_AI.NPC091_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried091; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne091; NPC_AI.bTempCorpse = NPC_AI.bCorpse091; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted091; }
                if (query.ToLower() == NPC_AI.NPC_092.ToLower()) { sLookedForNPC = NPC_AI.NPC_092; NPC_AI.sTempCurrentLocation = NPC_AI.NPC092_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried092; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne092; NPC_AI.bTempCorpse = NPC_AI.bCorpse092; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted092; }
                if (query.ToLower() == NPC_AI.NPC_093.ToLower()) { sLookedForNPC = NPC_AI.NPC_093; NPC_AI.sTempCurrentLocation = NPC_AI.NPC093_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried093; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne093; NPC_AI.bTempCorpse = NPC_AI.bCorpse093; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted093; }
                if (query.ToLower() == NPC_AI.NPC_094.ToLower()) { sLookedForNPC = NPC_AI.NPC_094; NPC_AI.sTempCurrentLocation = NPC_AI.NPC094_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried094; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne094; NPC_AI.bTempCorpse = NPC_AI.bCorpse094; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted094; }
                if (query.ToLower() == NPC_AI.NPC_095.ToLower()) { sLookedForNPC = NPC_AI.NPC_095; NPC_AI.sTempCurrentLocation = NPC_AI.NPC095_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried095; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne095; NPC_AI.bTempCorpse = NPC_AI.bCorpse095; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted095; }
                if (query.ToLower() == NPC_AI.NPC_096.ToLower()) { sLookedForNPC = NPC_AI.NPC_096; NPC_AI.sTempCurrentLocation = NPC_AI.NPC096_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried096; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne096; NPC_AI.bTempCorpse = NPC_AI.bCorpse096; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted096; }
                if (query.ToLower() == NPC_AI.NPC_097.ToLower()) { sLookedForNPC = NPC_AI.NPC_097; NPC_AI.sTempCurrentLocation = NPC_AI.NPC097_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried097; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne097; NPC_AI.bTempCorpse = NPC_AI.bCorpse097; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted097; }
                if (query.ToLower() == NPC_AI.NPC_098.ToLower()) { sLookedForNPC = NPC_AI.NPC_098; NPC_AI.sTempCurrentLocation = NPC_AI.NPC098_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried098; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne098; NPC_AI.bTempCorpse = NPC_AI.bCorpse098; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted098; }
                if (query.ToLower() == NPC_AI.NPC_099.ToLower()) { sLookedForNPC = NPC_AI.NPC_099; NPC_AI.sTempCurrentLocation = NPC_AI.NPC099_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried099; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne099; NPC_AI.bTempCorpse = NPC_AI.bCorpse099; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted099; }
                if (query.ToLower() == NPC_AI.NPC_100.ToLower()) { sLookedForNPC = NPC_AI.NPC_100; NPC_AI.sTempCurrentLocation = NPC_AI.NPC100_CurrentStrLocation; AccusationEncounters.bTempQueried = AccusationEncounters.bQueried100; bValidName = true; NPC_Traits.sTempTraitOne = NPC_Traits.TraitOne100; NPC_AI.bTempCorpse = NPC_AI.bCorpse100; Notebook.bCorpseSpotted = Notebook.bCorpseSpotted100; }
                
                if (!bValidName)
                { 
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine(NPC_AI.tempNPC + " asks, 'Who? Say that again, I didn't understand you.'"); 
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine(); 
                    query = Console.ReadLine(); 
                    Console.WriteLine(); 
                }
            }
            if (NPC_AI.bTempCorpse && query.ToLower() == sLookedForNPC.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(NPC_AI.tempNPC + " says, 'Oh, I'm sorry. Haven't you heard? " + sLookedForNPC + " is dead.'");
                if (!Notebook.bCorpseSpotted && Variables.iRemainingTurns >= Variables.iTurn50)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   Any references to " + sLookedForNPC + " are now removed from your notebook.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Notebook.bCorpseSpotted = true;
                }
                SavebCorpseSpotted_sLookedForNPC(); // If someone told you that the person you are looking for is a corpse, this check will update your notebook.
                return; 
            }
            if (NPC_AI.tempNPC.ToLower() == sLookedForNPC.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine(NPC_AI.tempNPC + " asks, 'You want to know where I am? OK. I'm right here. Where are you?'"); 
                return; 
            }
            if (!AccusationEncounters.bTempQueried)
            {
                AccusationEncounters.bTempQueried = true;
                Variables.iKnowRoll = Program.rand.Next(1, 11);
                NPC_AI.sLookedFor_PantsDownGenderCheck();
                Console.ForegroundColor = ConsoleColor.Gray;
                if (NPC_AI.sTempCurrentLocation == Variables.sGetLocation) 
                { 
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'Didn't I just see " + sLookedForNPC + "? Oh, " + NPC_AI.sGenderHeShe + "'s standing right there. Haha.'"); 
                    Variables.iKnowRoll = 0; 
                }
                if (Variables.iKnowRoll >= 1 && Variables.iKnowRoll <= 3) 
                { 
                    Console.WriteLine(NPC_AI.tempNPC + " says, '" + sLookedForNPC + "? The " + NPC_AI.sGenderGuyGirl + " " + NPC_Traits.sTempTraitOne + ", right? I'm not sure. I would try looking at " + NPC_AI.sTempCurrentLocation + "'"); 
                }
                if (Variables.iKnowRoll >= 4 && Variables.iKnowRoll <= 6) 
                { 
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'Yeah, I've seen " + sLookedForNPC + ". I saw " + NPC_AI.sGenderHimHer + " at " + NPC_AI.sTempCurrentLocation + "'");
                }
                if (Variables.iKnowRoll >= 7 && Variables.iKnowRoll <= 9)
                {
                    Console.WriteLine(NPC_AI.tempNPC + " says, 'To be honest with you, I don't know. Sorry.'"); 
                }
                if (Variables.iKnowRoll == 10)
                {
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait001) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait002; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait002) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait001; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait003) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait004; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait004) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait003; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait005) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait006; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait006) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait005; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait007) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait008; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait008) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait007; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait009) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait010; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait010) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait009; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait011) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait012; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait012) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait011; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait013) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait014; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait014) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait013; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait015) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait016; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait016) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait015; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait017) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait018; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait018) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait017; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait019) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait020; }
                    if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait020) { NPC_Traits.sTempCounterTrait = NPC_Traits.sTrait019; }

                    iFakeOut = Program.rand.Next(1, 26);
                    if (iFakeOut == 1) { NPC_AI.iTempLocation = 1; NPC_AI.sTempCurrentLocation = LocationEncounters.location_001; }
                    if (iFakeOut == 2) { NPC_AI.iTempLocation = 2; NPC_AI.sTempCurrentLocation = LocationEncounters.location_002; }
                    if (iFakeOut == 3) { NPC_AI.iTempLocation = 3; NPC_AI.sTempCurrentLocation = LocationEncounters.location_003; }
                    if (iFakeOut == 4) { NPC_AI.iTempLocation = 4; NPC_AI.sTempCurrentLocation = LocationEncounters.location_004; }
                    if (iFakeOut == 5) { NPC_AI.iTempLocation = 5; NPC_AI.sTempCurrentLocation = LocationEncounters.location_005; }
                    if (iFakeOut == 6) { NPC_AI.iTempLocation = 6; NPC_AI.sTempCurrentLocation = LocationEncounters.location_006; }
                    if (iFakeOut == 7) { NPC_AI.iTempLocation = 7; NPC_AI.sTempCurrentLocation = LocationEncounters.location_007; }
                    if (iFakeOut == 8) { NPC_AI.iTempLocation = 8; NPC_AI.sTempCurrentLocation = LocationEncounters.location_008; }
                    if (iFakeOut == 9) { NPC_AI.iTempLocation = 9; NPC_AI.sTempCurrentLocation = LocationEncounters.location_009; }
                    if (iFakeOut == 10) { NPC_AI.iTempLocation = 10; NPC_AI.sTempCurrentLocation = LocationEncounters.location_010; }
                    if (iFakeOut == 11) { NPC_AI.iTempLocation = 11; NPC_AI.sTempCurrentLocation = LocationEncounters.location_011; }
                    if (iFakeOut == 12) { NPC_AI.iTempLocation = 12; NPC_AI.sTempCurrentLocation = LocationEncounters.location_012; }
                    if (iFakeOut == 13) { NPC_AI.iTempLocation = 13; NPC_AI.sTempCurrentLocation = LocationEncounters.location_013; }
                    if (iFakeOut == 14) { NPC_AI.iTempLocation = 14; NPC_AI.sTempCurrentLocation = LocationEncounters.location_014; }
                    if (iFakeOut == 15) { NPC_AI.iTempLocation = 15; NPC_AI.sTempCurrentLocation = LocationEncounters.location_015; }
                    if (iFakeOut == 16) { NPC_AI.iTempLocation = 16; NPC_AI.sTempCurrentLocation = LocationEncounters.location_016; }
                    if (iFakeOut == 17) { NPC_AI.iTempLocation = 17; NPC_AI.sTempCurrentLocation = LocationEncounters.location_017; }
                    if (iFakeOut == 18) { NPC_AI.iTempLocation = 18; NPC_AI.sTempCurrentLocation = LocationEncounters.location_018; }
                    if (iFakeOut == 19) { NPC_AI.iTempLocation = 19; NPC_AI.sTempCurrentLocation = LocationEncounters.location_019; }
                    if (iFakeOut == 20) { NPC_AI.iTempLocation = 20; NPC_AI.sTempCurrentLocation = LocationEncounters.location_020; }
                    if (iFakeOut == 21) { NPC_AI.iTempLocation = 21; NPC_AI.sTempCurrentLocation = LocationEncounters.location_021; }
                    if (iFakeOut == 22) { NPC_AI.iTempLocation = 22; NPC_AI.sTempCurrentLocation = LocationEncounters.location_022; }
                    if (iFakeOut == 23) { NPC_AI.iTempLocation = 23; NPC_AI.sTempCurrentLocation = LocationEncounters.location_023; }
                    if (iFakeOut == 24) { NPC_AI.iTempLocation = 24; NPC_AI.sTempCurrentLocation = LocationEncounters.location_024; }
                    if (iFakeOut == 25) { NPC_AI.iTempLocation = 25; NPC_AI.sTempCurrentLocation = LocationEncounters.location_025; }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(NPC_AI.tempNPC + " says, '" + sLookedForNPC + "? The " + NPC_AI.sGenderGuyGirl + " " + NPC_Traits.sTempCounterTrait + ", right? I'm not sure. I would");
                    Console.WriteLine("try looking at " + NPC_AI.sTempCurrentLocation + "'"/*+ "\n\r (DEBUG: BAD TRAIT IS A HINT THAT THIS IS WRONG INFO)"*/);
                }
            }
            else if (AccusationEncounters.bTempQueried)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You may only ask about " + sLookedForNPC + "'s location once per turn. End this");
                Console.WriteLine("turn if you want to ask about " + sLookedForNPC + "'s location again.");
            }

            if (sLookedForNPC == NPC_AI.NPC_001) { AccusationEncounters.bQueried001 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_002) { AccusationEncounters.bQueried002 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_003) { AccusationEncounters.bQueried003 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_004) { AccusationEncounters.bQueried004 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_005) { AccusationEncounters.bQueried005 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_006) { AccusationEncounters.bQueried006 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_007) { AccusationEncounters.bQueried007 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_008) { AccusationEncounters.bQueried008 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_009) { AccusationEncounters.bQueried009 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_010) { AccusationEncounters.bQueried010 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_011) { AccusationEncounters.bQueried011 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_012) { AccusationEncounters.bQueried012 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_013) { AccusationEncounters.bQueried013 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_014) { AccusationEncounters.bQueried014 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_015) { AccusationEncounters.bQueried015 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_016) { AccusationEncounters.bQueried016 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_017) { AccusationEncounters.bQueried017 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_018) { AccusationEncounters.bQueried018 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_019) { AccusationEncounters.bQueried019 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_020) { AccusationEncounters.bQueried020 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_021) { AccusationEncounters.bQueried021 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_022) { AccusationEncounters.bQueried022 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_023) { AccusationEncounters.bQueried023 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_024) { AccusationEncounters.bQueried024 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_025) { AccusationEncounters.bQueried025 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_026) { AccusationEncounters.bQueried026 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_027) { AccusationEncounters.bQueried027 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_028) { AccusationEncounters.bQueried028 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_029) { AccusationEncounters.bQueried029 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_030) { AccusationEncounters.bQueried030 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_031) { AccusationEncounters.bQueried031 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_032) { AccusationEncounters.bQueried032 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_033) { AccusationEncounters.bQueried033 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_034) { AccusationEncounters.bQueried034 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_035) { AccusationEncounters.bQueried035 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_036) { AccusationEncounters.bQueried036 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_037) { AccusationEncounters.bQueried037 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_038) { AccusationEncounters.bQueried038 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_039) { AccusationEncounters.bQueried039 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_040) { AccusationEncounters.bQueried040 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_041) { AccusationEncounters.bQueried041 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_042) { AccusationEncounters.bQueried042 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_043) { AccusationEncounters.bQueried043 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_044) { AccusationEncounters.bQueried044 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_045) { AccusationEncounters.bQueried045 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_046) { AccusationEncounters.bQueried046 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_047) { AccusationEncounters.bQueried047 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_048) { AccusationEncounters.bQueried048 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_049) { AccusationEncounters.bQueried049 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_050) { AccusationEncounters.bQueried050 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_051) { AccusationEncounters.bQueried051 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_052) { AccusationEncounters.bQueried052 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_053) { AccusationEncounters.bQueried053 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_054) { AccusationEncounters.bQueried054 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_055) { AccusationEncounters.bQueried055 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_056) { AccusationEncounters.bQueried056 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_057) { AccusationEncounters.bQueried057 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_058) { AccusationEncounters.bQueried058 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_059) { AccusationEncounters.bQueried059 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_060) { AccusationEncounters.bQueried060 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_061) { AccusationEncounters.bQueried061 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_062) { AccusationEncounters.bQueried062 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_063) { AccusationEncounters.bQueried063 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_064) { AccusationEncounters.bQueried064 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_065) { AccusationEncounters.bQueried065 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_066) { AccusationEncounters.bQueried066 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_067) { AccusationEncounters.bQueried067 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_068) { AccusationEncounters.bQueried068 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_069) { AccusationEncounters.bQueried069 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_070) { AccusationEncounters.bQueried070 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_071) { AccusationEncounters.bQueried071 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_072) { AccusationEncounters.bQueried072 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_073) { AccusationEncounters.bQueried073 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_074) { AccusationEncounters.bQueried074 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_075) { AccusationEncounters.bQueried075 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_076) { AccusationEncounters.bQueried076 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_077) { AccusationEncounters.bQueried077 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_078) { AccusationEncounters.bQueried078 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_079) { AccusationEncounters.bQueried079 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_080) { AccusationEncounters.bQueried080 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_081) { AccusationEncounters.bQueried081 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_082) { AccusationEncounters.bQueried082 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_083) { AccusationEncounters.bQueried083 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_084) { AccusationEncounters.bQueried084 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_085) { AccusationEncounters.bQueried085 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_086) { AccusationEncounters.bQueried086 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_087) { AccusationEncounters.bQueried087 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_088) { AccusationEncounters.bQueried088 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_089) { AccusationEncounters.bQueried089 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_090) { AccusationEncounters.bQueried090 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_091) { AccusationEncounters.bQueried091 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_092) { AccusationEncounters.bQueried092 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_093) { AccusationEncounters.bQueried093 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_094) { AccusationEncounters.bQueried094 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_095) { AccusationEncounters.bQueried095 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_096) { AccusationEncounters.bQueried096 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_097) { AccusationEncounters.bQueried097 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_098) { AccusationEncounters.bQueried098 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_099) { AccusationEncounters.bQueried099 = AccusationEncounters.bTempQueried; }
            if (sLookedForNPC == NPC_AI.NPC_100) { AccusationEncounters.bQueried100 = AccusationEncounters.bTempQueried; }

            ResetAllTempConversationVariables();
        }
    }
}