using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class NPC_Traits
    {
        public static Random rand = new Random();

        public static string
        TraitOne001, TraitOne002, TraitOne003, TraitOne004, TraitOne005,
        TraitOne006, TraitOne007, TraitOne008, TraitOne009, TraitOne010,
        TraitOne011, TraitOne012, TraitOne013, TraitOne014, TraitOne015,
        TraitOne016, TraitOne017, TraitOne018, TraitOne019, TraitOne020,
        TraitOne021, TraitOne022, TraitOne023, TraitOne024, TraitOne025,
        TraitOne026, TraitOne027, TraitOne028, TraitOne029, TraitOne030,
        TraitOne031, TraitOne032, TraitOne033, TraitOne034, TraitOne035,
        TraitOne036, TraitOne037, TraitOne038, TraitOne039, TraitOne040,
        TraitOne041, TraitOne042, TraitOne043, TraitOne044, TraitOne045,
        TraitOne046, TraitOne047, TraitOne048, TraitOne049, TraitOne050,
        TraitOne051, TraitOne052, TraitOne053, TraitOne054, TraitOne055,
        TraitOne056, TraitOne057, TraitOne058, TraitOne059, TraitOne060,
        TraitOne061, TraitOne062, TraitOne063, TraitOne064, TraitOne065,
        TraitOne066, TraitOne067, TraitOne068, TraitOne069, TraitOne070,
        TraitOne071, TraitOne072, TraitOne073, TraitOne074, TraitOne075,
        TraitOne076, TraitOne077, TraitOne078, TraitOne079, TraitOne080,
        TraitOne081, TraitOne082, TraitOne083, TraitOne084, TraitOne085,
        TraitOne086, TraitOne087, TraitOne088, TraitOne089, TraitOne090,
        TraitOne091, TraitOne092, TraitOne093, TraitOne094, TraitOne095,
        TraitOne096, TraitOne097, TraitOne098, TraitOne099, TraitOne100,
        TraitOneBunny;

        public static string sQueriedTrait;

        public static string
        TraitTwo001, TraitTwo002, TraitTwo003, TraitTwo004, TraitTwo005,
        TraitTwo006, TraitTwo007, TraitTwo008, TraitTwo009, TraitTwo010,
        TraitTwo011, TraitTwo012, TraitTwo013, TraitTwo014, TraitTwo015,
        TraitTwo016, TraitTwo017, TraitTwo018, TraitTwo019, TraitTwo020,
        TraitTwo021, TraitTwo022, TraitTwo023, TraitTwo024, TraitTwo025,
        TraitTwo026, TraitTwo027, TraitTwo028, TraitTwo029, TraitTwo030,
        TraitTwo031, TraitTwo032, TraitTwo033, TraitTwo034, TraitTwo035,
        TraitTwo036, TraitTwo037, TraitTwo038, TraitTwo039, TraitTwo040,
        TraitTwo041, TraitTwo042, TraitTwo043, TraitTwo044, TraitTwo045,
        TraitTwo046, TraitTwo047, TraitTwo048, TraitTwo049, TraitTwo050,
        TraitTwo051, TraitTwo052, TraitTwo053, TraitTwo054, TraitTwo055,
        TraitTwo056, TraitTwo057, TraitTwo058, TraitTwo059, TraitTwo060,
        TraitTwo061, TraitTwo062, TraitTwo063, TraitTwo064, TraitTwo065,
        TraitTwo066, TraitTwo067, TraitTwo068, TraitTwo069, TraitTwo070,
        TraitTwo071, TraitTwo072, TraitTwo073, TraitTwo074, TraitTwo075,
        TraitTwo076, TraitTwo077, TraitTwo078, TraitTwo079, TraitTwo080,
        TraitTwo081, TraitTwo082, TraitTwo083, TraitTwo084, TraitTwo085,
        TraitTwo086, TraitTwo087, TraitTwo088, TraitTwo089, TraitTwo090,
        TraitTwo091, TraitTwo092, TraitTwo093, TraitTwo094, TraitTwo095,
        TraitTwo096, TraitTwo097, TraitTwo098, TraitTwo099, TraitTwo100, TraitTwoBunny;

        public static string
        TraitThree001, TraitThree002, TraitThree003, TraitThree004, TraitThree005,
        TraitThree006, TraitThree007, TraitThree008, TraitThree009, TraitThree010,
        TraitThree011, TraitThree012, TraitThree013, TraitThree014, TraitThree015,
        TraitThree016, TraitThree017, TraitThree018, TraitThree019, TraitThree020,
        TraitThree021, TraitThree022, TraitThree023, TraitThree024, TraitThree025,
        TraitThree026, TraitThree027, TraitThree028, TraitThree029, TraitThree030,
        TraitThree031, TraitThree032, TraitThree033, TraitThree034, TraitThree035,
        TraitThree036, TraitThree037, TraitThree038, TraitThree039, TraitThree040,
        TraitThree041, TraitThree042, TraitThree043, TraitThree044, TraitThree045,
        TraitThree046, TraitThree047, TraitThree048, TraitThree049, TraitThree050,
        TraitThree051, TraitThree052, TraitThree053, TraitThree054, TraitThree055,
        TraitThree056, TraitThree057, TraitThree058, TraitThree059, TraitThree060,
        TraitThree061, TraitThree062, TraitThree063, TraitThree064, TraitThree065,
        TraitThree066, TraitThree067, TraitThree068, TraitThree069, TraitThree070,
        TraitThree071, TraitThree072, TraitThree073, TraitThree074, TraitThree075,
        TraitThree076, TraitThree077, TraitThree078, TraitThree079, TraitThree080,
        TraitThree081, TraitThree082, TraitThree083, TraitThree084, TraitThree085,
        TraitThree086, TraitThree087, TraitThree088, TraitThree089, TraitThree090,
        TraitThree091, TraitThree092, TraitThree093, TraitThree094, TraitThree095,
        TraitThree096, TraitThree097, TraitThree098, TraitThree099, TraitThree100,
        TraitThreeBunny;

        public static bool
        bTraitOneBunny, bTraitTwoBunny, bTraitThreeBunny;

        public static bool
        bTraitOne01Bunny, bTraitTwo01Bunny, bTraitThree01Bunny;

        public static string
        sTempCounterTrait, sTempTraitOne, sTempTraitTwo, sTempTraitThree;

        public static int
        BunnyOneIndex, BunnyTwoIndex, BunnyThreeIndex;

        // Tier One Descriptive Traits
        public static string
        sTrait001, sTrait002, sTrait003, sTrait004, sTrait005,
        sTrait006, sTrait007, sTrait008, sTrait009, sTrait010,
        sTrait011, sTrait012, sTrait013, sTrait014, sTrait015,
        sTrait016, sTrait017, sTrait018, sTrait019, sTrait020;

        // Tier Two Descriptive Traits
        public static string
        sTrait100, sTrait101, sTrait102, sTrait103, sTrait104,
        sTrait105, sTrait106, sTrait107, sTrait108, sTrait109,
        sTrait110, sTrait111, sTrait112, sTrait113, sTrait114;

        // Tier Three Descriptive Traits
        public static string
        sTrait200, sTrait201, sTrait202, sTrait203, sTrait204,
        sTrait205, sTrait206, sTrait207, sTrait208, sTrait209,
        sTrait210, sTrait211, sTrait212, sTrait213, sTrait214;
        
        public static void Initialize_Traits()
        {
            TraitOne001 = TraitOne002 = TraitOne003 = TraitOne004 = TraitOne005 =
            TraitOne006 = TraitOne007 = TraitOne008 = TraitOne009 = TraitOne010 =
            TraitOne011 = TraitOne012 = TraitOne013 = TraitOne014 = TraitOne015 =
            TraitOne016 = TraitOne017 = TraitOne018 = TraitOne019 = TraitOne020 =
            TraitOne021 = TraitOne022 = TraitOne023 = TraitOne024 = TraitOne025 =
            TraitOne026 = TraitOne027 = TraitOne028 = TraitOne029 = TraitOne030 =
            TraitOne031 = TraitOne032 = TraitOne033 = TraitOne034 = TraitOne035 =
            TraitOne036 = TraitOne037 = TraitOne038 = TraitOne039 = TraitOne040 =
            TraitOne041 = TraitOne042 = TraitOne043 = TraitOne044 = TraitOne045 =
            TraitOne046 = TraitOne047 = TraitOne048 = TraitOne049 = TraitOne050 =
            TraitOne051 = TraitOne052 = TraitOne053 = TraitOne054 = TraitOne055 =
            TraitOne056 = TraitOne057 = TraitOne058 = TraitOne059 = TraitOne060 =
            TraitOne061 = TraitOne062 = TraitOne063 = TraitOne064 = TraitOne065 =
            TraitOne066 = TraitOne067 = TraitOne068 = TraitOne069 = TraitOne070 =
            TraitOne071 = TraitOne072 = TraitOne073 = TraitOne074 = TraitOne075 =
            TraitOne076 = TraitOne077 = TraitOne078 = TraitOne079 = TraitOne080 =
            TraitOne081 = TraitOne082 = TraitOne083 = TraitOne084 = TraitOne085 =
            TraitOne086 = TraitOne087 = TraitOne088 = TraitOne089 = TraitOne090 =
            TraitOne091 = TraitOne092 = TraitOne093 = TraitOne094 = TraitOne095 =
            TraitOne096 = TraitOne097 = TraitOne098 = TraitOne099 = TraitOne100 =
            TraitOneBunny = string.Empty;

            TraitTwo001 = TraitTwo002 = TraitTwo003 = TraitTwo004 = TraitTwo005 =
            TraitTwo006 = TraitTwo007 = TraitTwo008 = TraitTwo009 = TraitTwo010 =
            TraitTwo011 = TraitTwo012 = TraitTwo013 = TraitTwo014 = TraitTwo015 =
            TraitTwo016 = TraitTwo017 = TraitTwo018 = TraitTwo019 = TraitTwo020 =
            TraitTwo021 = TraitTwo022 = TraitTwo023 = TraitTwo024 = TraitTwo025 =
            TraitTwo026 = TraitTwo027 = TraitTwo028 = TraitTwo029 = TraitTwo030 =
            TraitTwo031 = TraitTwo032 = TraitTwo033 = TraitTwo034 = TraitTwo035 =
            TraitTwo036 = TraitTwo037 = TraitTwo038 = TraitTwo039 = TraitTwo040 =
            TraitTwo041 = TraitTwo042 = TraitTwo043 = TraitTwo044 = TraitTwo045 =
            TraitTwo046 = TraitTwo047 = TraitTwo048 = TraitTwo049 = TraitTwo050 =
            TraitTwo051 = TraitTwo052 = TraitTwo053 = TraitTwo054 = TraitTwo055 =
            TraitTwo056 = TraitTwo057 = TraitTwo058 = TraitTwo059 = TraitTwo060 =
            TraitTwo061 = TraitTwo062 = TraitTwo063 = TraitTwo064 = TraitTwo065 =
            TraitTwo066 = TraitTwo067 = TraitTwo068 = TraitTwo069 = TraitTwo070 =
            TraitTwo071 = TraitTwo072 = TraitTwo073 = TraitTwo074 = TraitTwo075 =
            TraitTwo076 = TraitTwo077 = TraitTwo078 = TraitTwo079 = TraitTwo080 =
            TraitTwo081 = TraitTwo082 = TraitTwo083 = TraitTwo084 = TraitTwo085 =
            TraitTwo086 = TraitTwo087 = TraitTwo088 = TraitTwo089 = TraitTwo090 =
            TraitTwo091 = TraitTwo092 = TraitTwo093 = TraitTwo094 = TraitTwo095 =
            TraitTwo096 = TraitTwo097 = TraitTwo098 = TraitTwo099 = TraitTwo100 =
            TraitTwoBunny = string.Empty;

            TraitThree001 = TraitThree002 = TraitThree003 = TraitThree004 = TraitThree005 =
            TraitThree006 = TraitThree007 = TraitThree008 = TraitThree009 = TraitThree010 =
            TraitThree011 = TraitThree012 = TraitThree013 = TraitThree014 = TraitThree015 =
            TraitThree016 = TraitThree017 = TraitThree018 = TraitThree019 = TraitThree020 =
            TraitThree021 = TraitThree022 = TraitThree023 = TraitThree024 = TraitThree025 =
            TraitThree026 = TraitThree027 = TraitThree028 = TraitThree029 = TraitThree030 =
            TraitThree031 = TraitThree032 = TraitThree033 = TraitThree034 = TraitThree035 =
            TraitThree036 = TraitThree037 = TraitThree038 = TraitThree039 = TraitThree040 =
            TraitThree041 = TraitThree042 = TraitThree043 = TraitThree044 = TraitThree045 =
            TraitThree046 = TraitThree047 = TraitThree048 = TraitThree049 = TraitThree050 =
            TraitThree051 = TraitThree052 = TraitThree053 = TraitThree054 = TraitThree055 =
            TraitThree056 = TraitThree057 = TraitThree058 = TraitThree059 = TraitThree060 =
            TraitThree061 = TraitThree062 = TraitThree063 = TraitThree064 = TraitThree065 =
            TraitThree066 = TraitThree067 = TraitThree068 = TraitThree069 = TraitThree070 =
            TraitThree071 = TraitThree072 = TraitThree073 = TraitThree074 = TraitThree075 =
            TraitThree076 = TraitThree077 = TraitThree078 = TraitThree079 = TraitThree080 =
            TraitThree081 = TraitThree082 = TraitThree083 = TraitThree084 = TraitThree085 =
            TraitThree086 = TraitThree087 = TraitThree088 = TraitThree089 = TraitThree090 =
            TraitThree091 = TraitThree092 = TraitThree093 = TraitThree094 = TraitThree095 =
            TraitThree096 = TraitThree097 = TraitThree098 = TraitThree099 = TraitThree100 =
            TraitThreeBunny = string.Empty;
            
            sTempCounterTrait = sTempTraitOne = sTempTraitTwo = sTempTraitThree = string.Empty;

            bTraitOneBunny = bTraitTwoBunny = bTraitThreeBunny = false;
            bTraitOne01Bunny = bTraitTwo01Bunny = bTraitThree01Bunny = false;

            sQueriedTrait = "null";
            
            // Tier ONE represents quickly noticed traits.
            sTrait001 = "is younger";
            sTrait002 = "is older";
            sTrait003 = "is wearing a long jacket";
            sTrait004 = "is wearing a light coat";
            sTrait005 = "is tall";
            sTrait006 = "is short";
            sTrait007 = "is overweight";
            sTrait008 = "is slender";
            sTrait009 = "is frail";
            sTrait010 = "is well-built";
            sTrait011 = "has short hair";
            sTrait012 = "has long hair";
            sTrait013 = "has curly hair";
            sTrait014 = "has straight hair";
            sTrait015 = "has dark skin";
            sTrait016 = "has light skin";
            sTrait017 = "is casually dressed";
            sTrait018 = "is stylishly dressed";
            sTrait019 = "has small, squinty eyes";
            sTrait020 = "has large, round eyes";

            // Tier TWO represents traits observed after some time.
            sTrait100 = "is smoking a cigarette";
            sTrait101 = "is clumsy";
            sTrait102 = "is energetic";
            sTrait103 = "is wearing a gaudy ring";
            sTrait104 = "has a visible scar";
            sTrait105 = "has a small nose piercing";
            sTrait106 = "has a visible tattoo";
            sTrait107 = "has a twitchy eye";
            sTrait108 = "is missing a tooth";
            sTrait109 = "is missing a finger";
            sTrait110 = "has freckles";
            sTrait111 = "is hunched over from poor posture";
            sTrait112 = "has a slight limp";
            sTrait113 = "is wheezing, occasionally coughing";
            sTrait114 = "seems fairly distracted";

            // Potential options: fidgets with his nails, clothing, hair.

            // Tier THREE represents observations on personality, noted during conversations.
            // For example, "During the conversation, you note that Jane: "
            // And In your notebook: "You noted that Jane: "

            sTrait200 = "zones out for long stretches of time";
            sTrait201 = "sometimes talks to someone who isn't there";
            sTrait202 = "is passive and meek, avoiding any conflict";
            sTrait203 = "is excessively confident and harshly judgmental";
            sTrait204 = "is quite humble and surprisingly funny";
            sTrait205 = "is somewhat guarded and paranoid";
            sTrait206 = "comes across as a trusting, naive person";
            sTrait207 = "is dull and takes excessive time to respond or react";
            sTrait208 = "is gloomy, with an unchanging, blank expression";
            sTrait209 = "smiles frequently for no apparent reason";
            sTrait210 = "is a cheery, contented person";
            sTrait211 = "is an imaginative, thoughtful person";
            sTrait212 = "is a pleasant, friendly person";
            sTrait213 = "is a gruff, grumpy person";
            sTrait214 = "is aggressive and confrontational";
        }

        public static void Assign_Traits()
        {
            List<string> TraitOneList = new List<string>
            {
                sTrait001, sTrait002, sTrait003, sTrait004, sTrait005, sTrait006, sTrait007, sTrait008, sTrait009, sTrait010, 
                sTrait011, sTrait012, sTrait013, sTrait014, sTrait015, sTrait016, sTrait017, sTrait018, sTrait019, sTrait020
            };

            TraitOneList.Clear();
            TraitOneList.Add(sTrait001); TraitOneList.Add(sTrait002); TraitOneList.Add(sTrait003); TraitOneList.Add(sTrait004); TraitOneList.Add(sTrait005);
            TraitOneList.Add(sTrait006); TraitOneList.Add(sTrait007); TraitOneList.Add(sTrait008); TraitOneList.Add(sTrait009); TraitOneList.Add(sTrait010);
            TraitOneList.Add(sTrait011); TraitOneList.Add(sTrait012); TraitOneList.Add(sTrait013); TraitOneList.Add(sTrait014); TraitOneList.Add(sTrait015);
            TraitOneList.Add(sTrait016); TraitOneList.Add(sTrait017); TraitOneList.Add(sTrait018); TraitOneList.Add(sTrait019); TraitOneList.Add(sTrait020);

            List<string> TraitTwoList = new List<string>
            {
                sTrait100, sTrait101, sTrait102, sTrait103, sTrait104, sTrait105, sTrait106, sTrait107, sTrait108, sTrait109,
                sTrait110, sTrait111, sTrait112, sTrait113, sTrait114
            };

            TraitTwoList.Clear();
            TraitTwoList.Add(sTrait100); TraitTwoList.Add(sTrait101); TraitTwoList.Add(sTrait102); TraitTwoList.Add(sTrait103); TraitTwoList.Add(sTrait104);
            TraitTwoList.Add(sTrait105); TraitTwoList.Add(sTrait106); TraitTwoList.Add(sTrait107); TraitTwoList.Add(sTrait108); TraitTwoList.Add(sTrait109);
            TraitTwoList.Add(sTrait110); TraitTwoList.Add(sTrait111); TraitTwoList.Add(sTrait112); TraitTwoList.Add(sTrait113); TraitTwoList.Add(sTrait114);

            List<string> TraitThreeList = new List<string>
            {
                sTrait200, sTrait201, sTrait202, sTrait203, sTrait204, sTrait205, sTrait206, sTrait207, sTrait208, sTrait209,
                sTrait210, sTrait211, sTrait212, sTrait213, sTrait214
            };

            TraitThreeList.Clear();
            TraitThreeList.Add(sTrait200); TraitThreeList.Add(sTrait201); TraitThreeList.Add(sTrait202); TraitThreeList.Add(sTrait203); TraitThreeList.Add(sTrait204);
            TraitThreeList.Add(sTrait205); TraitThreeList.Add(sTrait206); TraitThreeList.Add(sTrait207); TraitThreeList.Add(sTrait208); TraitThreeList.Add(sTrait209);
            TraitThreeList.Add(sTrait210); TraitThreeList.Add(sTrait211); TraitThreeList.Add(sTrait212); TraitThreeList.Add(sTrait213); TraitThreeList.Add(sTrait214);

            BunnyOneIndex = BunnyTwoIndex = BunnyThreeIndex = 999;

            BunnyOneIndex = rand.Next(TraitOneList.Count);
            TraitOneBunny = TraitOneList[BunnyOneIndex];
            TraitOneList.RemoveAt(BunnyOneIndex);

            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne001 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne002 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne003 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne004 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne005 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne006 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne007 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne008 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne009 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne010 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne011 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne012 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne013 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne014 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne015 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne016 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne017 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne018 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne019 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne020 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne021 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne022 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne023 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne024 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne025 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne026 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne027 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne028 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne029 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne030 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne031 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne032 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne033 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne034 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne035 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne036 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne037 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne038 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne039 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne040 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne041 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne042 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne043 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne044 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne045 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne046 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne047 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne048 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne049 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne050 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne051 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne052 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne053 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne054 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne055 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne056 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne057 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne058 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne059 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne060 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne061 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne062 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne063 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne064 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne065 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne066 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne067 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne068 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne069 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne070 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne071 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne072 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne073 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne074 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne075 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne076 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne077 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne078 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne079 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne080 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne081 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne082 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne083 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne084 = TraitOneList[BunnyOneIndex];
            BunnyOneIndex = rand.Next(TraitOneList.Count); TraitOne085 = TraitOneList[BunnyOneIndex];

            BunnyTwoIndex = rand.Next(TraitTwoList.Count);
            TraitTwoBunny = TraitTwoList[BunnyTwoIndex];
            TraitTwoList.RemoveAt(BunnyTwoIndex); // Remove from index to keep the wrong people from getting the wrong trait

            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo001 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo002 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo003 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo004 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo005 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo006 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo007 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo008 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo009 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo010 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo011 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo012 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo013 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo014 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo015 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo016 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo017 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo018 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo019 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo020 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo021 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo022 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo023 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo024 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo025 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo026 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo027 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo028 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo029 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo030 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo031 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo032 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo033 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo034 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo035 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo036 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo037 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo038 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo039 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo040 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo041 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo042 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo043 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo044 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo045 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo046 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo047 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo048 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo049 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo050 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo051 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo052 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo053 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo054 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo055 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo056 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo057 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo058 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo059 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo060 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo061 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo062 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo063 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo064 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo065 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo066 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo067 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo068 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo069 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo070 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo071 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo072 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo073 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo074 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo075 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo076 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo077 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo078 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo079 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo080 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo081 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo082 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo083 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo084 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo085 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo086 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo087 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo088 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo089 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo090 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo091 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo092 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo093 = TraitTwoList[BunnyTwoIndex];
            BunnyTwoIndex = rand.Next(TraitTwoList.Count); TraitTwo094 = TraitTwoList[BunnyTwoIndex];

            BunnyThreeIndex = rand.Next(TraitThreeList.Count);
            TraitThreeBunny = TraitThreeList[BunnyThreeIndex];
            TraitThreeList.RemoveAt(BunnyThreeIndex); // Remove from index to keep the wrong people from getting the wrong trait

            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree001 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree002 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree003 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree004 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree005 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree006 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree007 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree008 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree009 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree010 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree011 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree012 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree013 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree014 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree015 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree016 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree017 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree018 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree019 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree020 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree021 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree022 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree023 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree024 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree025 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree026 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree027 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree028 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree029 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree030 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree031 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree032 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree033 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree034 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree035 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree036 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree037 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree038 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree039 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree040 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree041 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree042 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree043 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree044 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree045 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree046 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree047 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree048 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree049 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree050 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree051 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree052 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree053 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree054 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree055 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree056 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree057 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree058 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree059 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree060 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree061 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree062 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree063 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree064 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree065 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree066 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree067 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree068 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree069 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree070 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree071 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree072 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree073 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree074 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree075 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree076 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree077 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree078 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree079 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree080 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree081 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree082 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree083 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree084 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree085 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree086 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree087 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree088 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree089 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree090 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree091 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree092 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree093 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree094 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree095 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree096 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree097 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree098 = TraitThreeList[BunnyThreeIndex];
            BunnyThreeIndex = rand.Next(TraitThreeList.Count); TraitThree099 = TraitThreeList[BunnyThreeIndex];

            // Give 14 NPCs (4 norms, and all the Red Herrings) plus the killer the same trait
            TraitOne086 = TraitOne087 = TraitOne088 = TraitOne089 = TraitOne090 =
            TraitOne091 = TraitOne092 = TraitOne093 = TraitOne094 = TraitOne095 =
            TraitOne096 = TraitOne097 = TraitOne098 = TraitOne099 = TraitOne100 =
            TraitOneBunny;

            // Give half the Red Herrings and the killer the same trait
            TraitTwo092 = TraitTwo093 = TraitTwo094 = TraitTwo095 = TraitTwo096 =
            TraitTwo097 = TraitTwo098 = TraitTwo099 = TraitTwo100 = TraitTwoBunny;

            // Give the killer and two herrings the defining trait based off the Bunny's clue
            TraitThree098 = TraitThree099 = TraitThree100 = TraitThreeBunny;
        }

        public static void Populate_TraitTierLists()
        {
            // Scan through all the NPCs and look for matches.
                Lists.TierOneTraits.Clear();
                if (sQueriedTrait == TraitOne001) { Lists.TierOneTraits.Add(NPC_AI.NPC_001); } if (sQueriedTrait == TraitOne002) { Lists.TierOneTraits.Add(NPC_AI.NPC_002); } if (sQueriedTrait == TraitOne003) { Lists.TierOneTraits.Add(NPC_AI.NPC_003); } if (sQueriedTrait == TraitOne004) { Lists.TierOneTraits.Add(NPC_AI.NPC_004); }
                if (sQueriedTrait == TraitOne005) { Lists.TierOneTraits.Add(NPC_AI.NPC_005); } if (sQueriedTrait == TraitOne006) { Lists.TierOneTraits.Add(NPC_AI.NPC_006); } if (sQueriedTrait == TraitOne007) { Lists.TierOneTraits.Add(NPC_AI.NPC_007); } if (sQueriedTrait == TraitOne008) { Lists.TierOneTraits.Add(NPC_AI.NPC_008); }
                if (sQueriedTrait == TraitOne009) { Lists.TierOneTraits.Add(NPC_AI.NPC_009); } if (sQueriedTrait == TraitOne010) { Lists.TierOneTraits.Add(NPC_AI.NPC_010); } if (sQueriedTrait == TraitOne011) { Lists.TierOneTraits.Add(NPC_AI.NPC_011); } if (sQueriedTrait == TraitOne012) { Lists.TierOneTraits.Add(NPC_AI.NPC_012); }
                if (sQueriedTrait == TraitOne013) { Lists.TierOneTraits.Add(NPC_AI.NPC_013); } if (sQueriedTrait == TraitOne014) { Lists.TierOneTraits.Add(NPC_AI.NPC_014); } if (sQueriedTrait == TraitOne015) { Lists.TierOneTraits.Add(NPC_AI.NPC_015); } if (sQueriedTrait == TraitOne016) { Lists.TierOneTraits.Add(NPC_AI.NPC_016); }
                if (sQueriedTrait == TraitOne017) { Lists.TierOneTraits.Add(NPC_AI.NPC_017); } if (sQueriedTrait == TraitOne018) { Lists.TierOneTraits.Add(NPC_AI.NPC_018); } if (sQueriedTrait == TraitOne019) { Lists.TierOneTraits.Add(NPC_AI.NPC_019); } if (sQueriedTrait == TraitOne020) { Lists.TierOneTraits.Add(NPC_AI.NPC_020); }
                if (sQueriedTrait == TraitOne021) { Lists.TierOneTraits.Add(NPC_AI.NPC_021); } if (sQueriedTrait == TraitOne022) { Lists.TierOneTraits.Add(NPC_AI.NPC_022); } if (sQueriedTrait == TraitOne023) { Lists.TierOneTraits.Add(NPC_AI.NPC_023); } if (sQueriedTrait == TraitOne024) { Lists.TierOneTraits.Add(NPC_AI.NPC_024); }
                if (sQueriedTrait == TraitOne025) { Lists.TierOneTraits.Add(NPC_AI.NPC_025); } if (sQueriedTrait == TraitOne026) { Lists.TierOneTraits.Add(NPC_AI.NPC_026); } if (sQueriedTrait == TraitOne027) { Lists.TierOneTraits.Add(NPC_AI.NPC_027); } if (sQueriedTrait == TraitOne028) { Lists.TierOneTraits.Add(NPC_AI.NPC_028); }
                if (sQueriedTrait == TraitOne029) { Lists.TierOneTraits.Add(NPC_AI.NPC_029); } if (sQueriedTrait == TraitOne030) { Lists.TierOneTraits.Add(NPC_AI.NPC_030); } if (sQueriedTrait == TraitOne031) { Lists.TierOneTraits.Add(NPC_AI.NPC_031); } if (sQueriedTrait == TraitOne032) { Lists.TierOneTraits.Add(NPC_AI.NPC_032); }
                if (sQueriedTrait == TraitOne033) { Lists.TierOneTraits.Add(NPC_AI.NPC_033); } if (sQueriedTrait == TraitOne034) { Lists.TierOneTraits.Add(NPC_AI.NPC_034); } if (sQueriedTrait == TraitOne035) { Lists.TierOneTraits.Add(NPC_AI.NPC_035); } if (sQueriedTrait == TraitOne036) { Lists.TierOneTraits.Add(NPC_AI.NPC_036); }
                if (sQueriedTrait == TraitOne037) { Lists.TierOneTraits.Add(NPC_AI.NPC_037); } if (sQueriedTrait == TraitOne038) { Lists.TierOneTraits.Add(NPC_AI.NPC_038); } if (sQueriedTrait == TraitOne039) { Lists.TierOneTraits.Add(NPC_AI.NPC_039); } if (sQueriedTrait == TraitOne040) { Lists.TierOneTraits.Add(NPC_AI.NPC_040); }
                if (sQueriedTrait == TraitOne041) { Lists.TierOneTraits.Add(NPC_AI.NPC_041); } if (sQueriedTrait == TraitOne042) { Lists.TierOneTraits.Add(NPC_AI.NPC_042); } if (sQueriedTrait == TraitOne043) { Lists.TierOneTraits.Add(NPC_AI.NPC_043); } if (sQueriedTrait == TraitOne044) { Lists.TierOneTraits.Add(NPC_AI.NPC_044); }
                if (sQueriedTrait == TraitOne045) { Lists.TierOneTraits.Add(NPC_AI.NPC_045); } if (sQueriedTrait == TraitOne046) { Lists.TierOneTraits.Add(NPC_AI.NPC_046); } if (sQueriedTrait == TraitOne047) { Lists.TierOneTraits.Add(NPC_AI.NPC_047); } if (sQueriedTrait == TraitOne048) { Lists.TierOneTraits.Add(NPC_AI.NPC_048); }
                if (sQueriedTrait == TraitOne049) { Lists.TierOneTraits.Add(NPC_AI.NPC_049); } if (sQueriedTrait == TraitOne050) { Lists.TierOneTraits.Add(NPC_AI.NPC_050); } if (sQueriedTrait == TraitOne051) { Lists.TierOneTraits.Add(NPC_AI.NPC_051); } if (sQueriedTrait == TraitOne052) { Lists.TierOneTraits.Add(NPC_AI.NPC_052); }
                if (sQueriedTrait == TraitOne053) { Lists.TierOneTraits.Add(NPC_AI.NPC_053); } if (sQueriedTrait == TraitOne054) { Lists.TierOneTraits.Add(NPC_AI.NPC_054); } if (sQueriedTrait == TraitOne055) { Lists.TierOneTraits.Add(NPC_AI.NPC_055); } if (sQueriedTrait == TraitOne056) { Lists.TierOneTraits.Add(NPC_AI.NPC_056); }
                if (sQueriedTrait == TraitOne057) { Lists.TierOneTraits.Add(NPC_AI.NPC_057); } if (sQueriedTrait == TraitOne058) { Lists.TierOneTraits.Add(NPC_AI.NPC_058); } if (sQueriedTrait == TraitOne059) { Lists.TierOneTraits.Add(NPC_AI.NPC_059); } if (sQueriedTrait == TraitOne060) { Lists.TierOneTraits.Add(NPC_AI.NPC_060); }
                if (sQueriedTrait == TraitOne061) { Lists.TierOneTraits.Add(NPC_AI.NPC_061); } if (sQueriedTrait == TraitOne062) { Lists.TierOneTraits.Add(NPC_AI.NPC_062); } if (sQueriedTrait == TraitOne063) { Lists.TierOneTraits.Add(NPC_AI.NPC_063); } if (sQueriedTrait == TraitOne064) { Lists.TierOneTraits.Add(NPC_AI.NPC_064); }
                if (sQueriedTrait == TraitOne065) { Lists.TierOneTraits.Add(NPC_AI.NPC_065); } if (sQueriedTrait == TraitOne066) { Lists.TierOneTraits.Add(NPC_AI.NPC_066); } if (sQueriedTrait == TraitOne067) { Lists.TierOneTraits.Add(NPC_AI.NPC_067); } if (sQueriedTrait == TraitOne068) { Lists.TierOneTraits.Add(NPC_AI.NPC_068); }
                if (sQueriedTrait == TraitOne069) { Lists.TierOneTraits.Add(NPC_AI.NPC_069); } if (sQueriedTrait == TraitOne070) { Lists.TierOneTraits.Add(NPC_AI.NPC_070); } if (sQueriedTrait == TraitOne071) { Lists.TierOneTraits.Add(NPC_AI.NPC_071); } if (sQueriedTrait == TraitOne072) { Lists.TierOneTraits.Add(NPC_AI.NPC_072); }
                if (sQueriedTrait == TraitOne073) { Lists.TierOneTraits.Add(NPC_AI.NPC_073); } if (sQueriedTrait == TraitOne074) { Lists.TierOneTraits.Add(NPC_AI.NPC_074); } if (sQueriedTrait == TraitOne075) { Lists.TierOneTraits.Add(NPC_AI.NPC_075); } if (sQueriedTrait == TraitOne076) { Lists.TierOneTraits.Add(NPC_AI.NPC_076); }
                if (sQueriedTrait == TraitOne077) { Lists.TierOneTraits.Add(NPC_AI.NPC_077); } if (sQueriedTrait == TraitOne078) { Lists.TierOneTraits.Add(NPC_AI.NPC_078); } if (sQueriedTrait == TraitOne079) { Lists.TierOneTraits.Add(NPC_AI.NPC_079); } if (sQueriedTrait == TraitOne080) { Lists.TierOneTraits.Add(NPC_AI.NPC_080); }
                if (sQueriedTrait == TraitOne081) { Lists.TierOneTraits.Add(NPC_AI.NPC_081); } if (sQueriedTrait == TraitOne082) { Lists.TierOneTraits.Add(NPC_AI.NPC_082); } if (sQueriedTrait == TraitOne083) { Lists.TierOneTraits.Add(NPC_AI.NPC_083); } if (sQueriedTrait == TraitOne084) { Lists.TierOneTraits.Add(NPC_AI.NPC_084); }
                if (sQueriedTrait == TraitOne085) { Lists.TierOneTraits.Add(NPC_AI.NPC_085); } if (sQueriedTrait == TraitOne086) { Lists.TierOneTraits.Add(NPC_AI.NPC_086); } if (sQueriedTrait == TraitOne087) { Lists.TierOneTraits.Add(NPC_AI.NPC_087); } if (sQueriedTrait == TraitOne088) { Lists.TierOneTraits.Add(NPC_AI.NPC_088); }
                if (sQueriedTrait == TraitOne089) { Lists.TierOneTraits.Add(NPC_AI.NPC_089); } if (sQueriedTrait == TraitOne090) { Lists.TierOneTraits.Add(NPC_AI.NPC_090); } if (sQueriedTrait == TraitOne091) { Lists.TierOneTraits.Add(NPC_AI.NPC_091); } if (sQueriedTrait == TraitOne092) { Lists.TierOneTraits.Add(NPC_AI.NPC_092); }
                if (sQueriedTrait == TraitOne093) { Lists.TierOneTraits.Add(NPC_AI.NPC_093); } if (sQueriedTrait == TraitOne094) { Lists.TierOneTraits.Add(NPC_AI.NPC_094); } if (sQueriedTrait == TraitOne095) { Lists.TierOneTraits.Add(NPC_AI.NPC_095); } if (sQueriedTrait == TraitOne096) { Lists.TierOneTraits.Add(NPC_AI.NPC_096); }
                if (sQueriedTrait == TraitOne097) { Lists.TierOneTraits.Add(NPC_AI.NPC_097); } if (sQueriedTrait == TraitOne098) { Lists.TierOneTraits.Add(NPC_AI.NPC_098); } if (sQueriedTrait == TraitOne099) { Lists.TierOneTraits.Add(NPC_AI.NPC_099); } if (sQueriedTrait == TraitOne100) { Lists.TierOneTraits.Add(NPC_AI.NPC_100); }

                Lists.TierTwoTraits.Clear();
                if (sQueriedTrait == TraitTwo001) { Lists.TierTwoTraits.Add(NPC_AI.NPC_001); } if (sQueriedTrait == TraitTwo002) { Lists.TierTwoTraits.Add(NPC_AI.NPC_002); } if (sQueriedTrait == TraitTwo003) { Lists.TierTwoTraits.Add(NPC_AI.NPC_003); } if (sQueriedTrait == TraitTwo004) { Lists.TierTwoTraits.Add(NPC_AI.NPC_004); }
                if (sQueriedTrait == TraitTwo005) { Lists.TierTwoTraits.Add(NPC_AI.NPC_005); } if (sQueriedTrait == TraitTwo006) { Lists.TierTwoTraits.Add(NPC_AI.NPC_006); } if (sQueriedTrait == TraitTwo007) { Lists.TierTwoTraits.Add(NPC_AI.NPC_007); } if (sQueriedTrait == TraitTwo008) { Lists.TierTwoTraits.Add(NPC_AI.NPC_008); }
                if (sQueriedTrait == TraitTwo009) { Lists.TierTwoTraits.Add(NPC_AI.NPC_009); } if (sQueriedTrait == TraitTwo010) { Lists.TierTwoTraits.Add(NPC_AI.NPC_010); } if (sQueriedTrait == TraitTwo011) { Lists.TierTwoTraits.Add(NPC_AI.NPC_011); } if (sQueriedTrait == TraitTwo012) { Lists.TierTwoTraits.Add(NPC_AI.NPC_012); }
                if (sQueriedTrait == TraitTwo013) { Lists.TierTwoTraits.Add(NPC_AI.NPC_013); } if (sQueriedTrait == TraitTwo014) { Lists.TierTwoTraits.Add(NPC_AI.NPC_014); } if (sQueriedTrait == TraitTwo015) { Lists.TierTwoTraits.Add(NPC_AI.NPC_015); } if (sQueriedTrait == TraitTwo016) { Lists.TierTwoTraits.Add(NPC_AI.NPC_016); }
                if (sQueriedTrait == TraitTwo017) { Lists.TierTwoTraits.Add(NPC_AI.NPC_017); } if (sQueriedTrait == TraitTwo018) { Lists.TierTwoTraits.Add(NPC_AI.NPC_018); } if (sQueriedTrait == TraitTwo019) { Lists.TierTwoTraits.Add(NPC_AI.NPC_019); } if (sQueriedTrait == TraitTwo020) { Lists.TierTwoTraits.Add(NPC_AI.NPC_020); }
                if (sQueriedTrait == TraitTwo021) { Lists.TierTwoTraits.Add(NPC_AI.NPC_021); } if (sQueriedTrait == TraitTwo022) { Lists.TierTwoTraits.Add(NPC_AI.NPC_022); } if (sQueriedTrait == TraitTwo023) { Lists.TierTwoTraits.Add(NPC_AI.NPC_023); } if (sQueriedTrait == TraitTwo024) { Lists.TierTwoTraits.Add(NPC_AI.NPC_024); }
                if (sQueriedTrait == TraitTwo025) { Lists.TierTwoTraits.Add(NPC_AI.NPC_025); } if (sQueriedTrait == TraitTwo026) { Lists.TierTwoTraits.Add(NPC_AI.NPC_026); } if (sQueriedTrait == TraitTwo027) { Lists.TierTwoTraits.Add(NPC_AI.NPC_027); } if (sQueriedTrait == TraitTwo028) { Lists.TierTwoTraits.Add(NPC_AI.NPC_028); }
                if (sQueriedTrait == TraitTwo029) { Lists.TierTwoTraits.Add(NPC_AI.NPC_029); } if (sQueriedTrait == TraitTwo030) { Lists.TierTwoTraits.Add(NPC_AI.NPC_030); } if (sQueriedTrait == TraitTwo031) { Lists.TierTwoTraits.Add(NPC_AI.NPC_031); } if (sQueriedTrait == TraitTwo032) { Lists.TierTwoTraits.Add(NPC_AI.NPC_032); }
                if (sQueriedTrait == TraitTwo033) { Lists.TierTwoTraits.Add(NPC_AI.NPC_033); } if (sQueriedTrait == TraitTwo034) { Lists.TierTwoTraits.Add(NPC_AI.NPC_034); } if (sQueriedTrait == TraitTwo035) { Lists.TierTwoTraits.Add(NPC_AI.NPC_035); } if (sQueriedTrait == TraitTwo036) { Lists.TierTwoTraits.Add(NPC_AI.NPC_036); }
                if (sQueriedTrait == TraitTwo037) { Lists.TierTwoTraits.Add(NPC_AI.NPC_037); } if (sQueriedTrait == TraitTwo038) { Lists.TierTwoTraits.Add(NPC_AI.NPC_038); } if (sQueriedTrait == TraitTwo039) { Lists.TierTwoTraits.Add(NPC_AI.NPC_039); } if (sQueriedTrait == TraitTwo040) { Lists.TierTwoTraits.Add(NPC_AI.NPC_040); }
                if (sQueriedTrait == TraitTwo041) { Lists.TierTwoTraits.Add(NPC_AI.NPC_041); } if (sQueriedTrait == TraitTwo042) { Lists.TierTwoTraits.Add(NPC_AI.NPC_042); } if (sQueriedTrait == TraitTwo043) { Lists.TierTwoTraits.Add(NPC_AI.NPC_043); } if (sQueriedTrait == TraitTwo044) { Lists.TierTwoTraits.Add(NPC_AI.NPC_044); }
                if (sQueriedTrait == TraitTwo045) { Lists.TierTwoTraits.Add(NPC_AI.NPC_045); } if (sQueriedTrait == TraitTwo046) { Lists.TierTwoTraits.Add(NPC_AI.NPC_046); } if (sQueriedTrait == TraitTwo047) { Lists.TierTwoTraits.Add(NPC_AI.NPC_047); } if (sQueriedTrait == TraitTwo048) { Lists.TierTwoTraits.Add(NPC_AI.NPC_048); }
                if (sQueriedTrait == TraitTwo049) { Lists.TierTwoTraits.Add(NPC_AI.NPC_049); } if (sQueriedTrait == TraitTwo050) { Lists.TierTwoTraits.Add(NPC_AI.NPC_050); } if (sQueriedTrait == TraitTwo051) { Lists.TierTwoTraits.Add(NPC_AI.NPC_051); } if (sQueriedTrait == TraitTwo052) { Lists.TierTwoTraits.Add(NPC_AI.NPC_052); }
                if (sQueriedTrait == TraitTwo053) { Lists.TierTwoTraits.Add(NPC_AI.NPC_053); } if (sQueriedTrait == TraitTwo054) { Lists.TierTwoTraits.Add(NPC_AI.NPC_054); } if (sQueriedTrait == TraitTwo055) { Lists.TierTwoTraits.Add(NPC_AI.NPC_055); } if (sQueriedTrait == TraitTwo056) { Lists.TierTwoTraits.Add(NPC_AI.NPC_056); }
                if (sQueriedTrait == TraitTwo057) { Lists.TierTwoTraits.Add(NPC_AI.NPC_057); } if (sQueriedTrait == TraitTwo058) { Lists.TierTwoTraits.Add(NPC_AI.NPC_058); } if (sQueriedTrait == TraitTwo059) { Lists.TierTwoTraits.Add(NPC_AI.NPC_059); } if (sQueriedTrait == TraitTwo060) { Lists.TierTwoTraits.Add(NPC_AI.NPC_060); }
                if (sQueriedTrait == TraitTwo061) { Lists.TierTwoTraits.Add(NPC_AI.NPC_061); } if (sQueriedTrait == TraitTwo062) { Lists.TierTwoTraits.Add(NPC_AI.NPC_062); } if (sQueriedTrait == TraitTwo063) { Lists.TierTwoTraits.Add(NPC_AI.NPC_063); } if (sQueriedTrait == TraitTwo064) { Lists.TierTwoTraits.Add(NPC_AI.NPC_064); }
                if (sQueriedTrait == TraitTwo065) { Lists.TierTwoTraits.Add(NPC_AI.NPC_065); } if (sQueriedTrait == TraitTwo066) { Lists.TierTwoTraits.Add(NPC_AI.NPC_066); } if (sQueriedTrait == TraitTwo067) { Lists.TierTwoTraits.Add(NPC_AI.NPC_067); } if (sQueriedTrait == TraitTwo068) { Lists.TierTwoTraits.Add(NPC_AI.NPC_068); }
                if (sQueriedTrait == TraitTwo069) { Lists.TierTwoTraits.Add(NPC_AI.NPC_069); } if (sQueriedTrait == TraitTwo070) { Lists.TierTwoTraits.Add(NPC_AI.NPC_070); } if (sQueriedTrait == TraitTwo071) { Lists.TierTwoTraits.Add(NPC_AI.NPC_071); } if (sQueriedTrait == TraitTwo072) { Lists.TierTwoTraits.Add(NPC_AI.NPC_072); }
                if (sQueriedTrait == TraitTwo073) { Lists.TierTwoTraits.Add(NPC_AI.NPC_073); } if (sQueriedTrait == TraitTwo074) { Lists.TierTwoTraits.Add(NPC_AI.NPC_074); } if (sQueriedTrait == TraitTwo075) { Lists.TierTwoTraits.Add(NPC_AI.NPC_075); } if (sQueriedTrait == TraitTwo076) { Lists.TierTwoTraits.Add(NPC_AI.NPC_076); }
                if (sQueriedTrait == TraitTwo077) { Lists.TierTwoTraits.Add(NPC_AI.NPC_077); } if (sQueriedTrait == TraitTwo078) { Lists.TierTwoTraits.Add(NPC_AI.NPC_078); } if (sQueriedTrait == TraitTwo079) { Lists.TierTwoTraits.Add(NPC_AI.NPC_079); } if (sQueriedTrait == TraitTwo080) { Lists.TierTwoTraits.Add(NPC_AI.NPC_080); }
                if (sQueriedTrait == TraitTwo081) { Lists.TierTwoTraits.Add(NPC_AI.NPC_081); } if (sQueriedTrait == TraitTwo082) { Lists.TierTwoTraits.Add(NPC_AI.NPC_082); } if (sQueriedTrait == TraitTwo083) { Lists.TierTwoTraits.Add(NPC_AI.NPC_083); } if (sQueriedTrait == TraitTwo084) { Lists.TierTwoTraits.Add(NPC_AI.NPC_084); }
                if (sQueriedTrait == TraitTwo085) { Lists.TierTwoTraits.Add(NPC_AI.NPC_085); } if (sQueriedTrait == TraitTwo086) { Lists.TierTwoTraits.Add(NPC_AI.NPC_086); } if (sQueriedTrait == TraitTwo087) { Lists.TierTwoTraits.Add(NPC_AI.NPC_087); } if (sQueriedTrait == TraitTwo088) { Lists.TierTwoTraits.Add(NPC_AI.NPC_088); }
                if (sQueriedTrait == TraitTwo089) { Lists.TierTwoTraits.Add(NPC_AI.NPC_089); } if (sQueriedTrait == TraitTwo090) { Lists.TierTwoTraits.Add(NPC_AI.NPC_090); } if (sQueriedTrait == TraitTwo091) { Lists.TierTwoTraits.Add(NPC_AI.NPC_091); } if (sQueriedTrait == TraitTwo092) { Lists.TierTwoTraits.Add(NPC_AI.NPC_092); }
                if (sQueriedTrait == TraitTwo093) { Lists.TierTwoTraits.Add(NPC_AI.NPC_093); } if (sQueriedTrait == TraitTwo094) { Lists.TierTwoTraits.Add(NPC_AI.NPC_094); } if (sQueriedTrait == TraitTwo095) { Lists.TierTwoTraits.Add(NPC_AI.NPC_095); } if (sQueriedTrait == TraitTwo096) { Lists.TierTwoTraits.Add(NPC_AI.NPC_096); }
                if (sQueriedTrait == TraitTwo097) { Lists.TierTwoTraits.Add(NPC_AI.NPC_097); } if (sQueriedTrait == TraitTwo098) { Lists.TierTwoTraits.Add(NPC_AI.NPC_098); } if (sQueriedTrait == TraitTwo099) { Lists.TierTwoTraits.Add(NPC_AI.NPC_099); } if (sQueriedTrait == TraitTwo100) { Lists.TierTwoTraits.Add(NPC_AI.NPC_100); }

                Lists.TierThreeTraits.Clear();
                if (sQueriedTrait == TraitThree001) { Lists.TierThreeTraits.Add(NPC_AI.NPC_001); } if (sQueriedTrait == TraitThree002) { Lists.TierThreeTraits.Add(NPC_AI.NPC_002); } if (sQueriedTrait == TraitThree003) { Lists.TierThreeTraits.Add(NPC_AI.NPC_003); } if (sQueriedTrait == TraitThree004) { Lists.TierThreeTraits.Add(NPC_AI.NPC_004); }
                if (sQueriedTrait == TraitThree005) { Lists.TierThreeTraits.Add(NPC_AI.NPC_005); } if (sQueriedTrait == TraitThree006) { Lists.TierThreeTraits.Add(NPC_AI.NPC_006); } if (sQueriedTrait == TraitThree007) { Lists.TierThreeTraits.Add(NPC_AI.NPC_007); } if (sQueriedTrait == TraitThree008) { Lists.TierThreeTraits.Add(NPC_AI.NPC_008); }
                if (sQueriedTrait == TraitThree009) { Lists.TierThreeTraits.Add(NPC_AI.NPC_009); } if (sQueriedTrait == TraitThree010) { Lists.TierThreeTraits.Add(NPC_AI.NPC_010); } if (sQueriedTrait == TraitThree011) { Lists.TierThreeTraits.Add(NPC_AI.NPC_011); } if (sQueriedTrait == TraitThree012) { Lists.TierThreeTraits.Add(NPC_AI.NPC_012); }
                if (sQueriedTrait == TraitThree013) { Lists.TierThreeTraits.Add(NPC_AI.NPC_013); } if (sQueriedTrait == TraitThree014) { Lists.TierThreeTraits.Add(NPC_AI.NPC_014); } if (sQueriedTrait == TraitThree015) { Lists.TierThreeTraits.Add(NPC_AI.NPC_015); } if (sQueriedTrait == TraitThree016) { Lists.TierThreeTraits.Add(NPC_AI.NPC_016); }
                if (sQueriedTrait == TraitThree017) { Lists.TierThreeTraits.Add(NPC_AI.NPC_017); } if (sQueriedTrait == TraitThree018) { Lists.TierThreeTraits.Add(NPC_AI.NPC_018); } if (sQueriedTrait == TraitThree019) { Lists.TierThreeTraits.Add(NPC_AI.NPC_019); } if (sQueriedTrait == TraitThree020) { Lists.TierThreeTraits.Add(NPC_AI.NPC_020); }
                if (sQueriedTrait == TraitThree021) { Lists.TierThreeTraits.Add(NPC_AI.NPC_021); } if (sQueriedTrait == TraitThree022) { Lists.TierThreeTraits.Add(NPC_AI.NPC_022); } if (sQueriedTrait == TraitThree023) { Lists.TierThreeTraits.Add(NPC_AI.NPC_023); } if (sQueriedTrait == TraitThree024) { Lists.TierThreeTraits.Add(NPC_AI.NPC_024); }
                if (sQueriedTrait == TraitThree025) { Lists.TierThreeTraits.Add(NPC_AI.NPC_025); } if (sQueriedTrait == TraitThree026) { Lists.TierThreeTraits.Add(NPC_AI.NPC_026); } if (sQueriedTrait == TraitThree027) { Lists.TierThreeTraits.Add(NPC_AI.NPC_027); } if (sQueriedTrait == TraitThree028) { Lists.TierThreeTraits.Add(NPC_AI.NPC_028); }
                if (sQueriedTrait == TraitThree029) { Lists.TierThreeTraits.Add(NPC_AI.NPC_029); } if (sQueriedTrait == TraitThree030) { Lists.TierThreeTraits.Add(NPC_AI.NPC_030); } if (sQueriedTrait == TraitThree031) { Lists.TierThreeTraits.Add(NPC_AI.NPC_031); } if (sQueriedTrait == TraitThree032) { Lists.TierThreeTraits.Add(NPC_AI.NPC_032); }
                if (sQueriedTrait == TraitThree033) { Lists.TierThreeTraits.Add(NPC_AI.NPC_033); } if (sQueriedTrait == TraitThree034) { Lists.TierThreeTraits.Add(NPC_AI.NPC_034); } if (sQueriedTrait == TraitThree035) { Lists.TierThreeTraits.Add(NPC_AI.NPC_035); } if (sQueriedTrait == TraitThree036) { Lists.TierThreeTraits.Add(NPC_AI.NPC_036); }
                if (sQueriedTrait == TraitThree037) { Lists.TierThreeTraits.Add(NPC_AI.NPC_037); } if (sQueriedTrait == TraitThree038) { Lists.TierThreeTraits.Add(NPC_AI.NPC_038); } if (sQueriedTrait == TraitThree039) { Lists.TierThreeTraits.Add(NPC_AI.NPC_039); } if (sQueriedTrait == TraitThree040) { Lists.TierThreeTraits.Add(NPC_AI.NPC_040); }
                if (sQueriedTrait == TraitThree041) { Lists.TierThreeTraits.Add(NPC_AI.NPC_041); } if (sQueriedTrait == TraitThree042) { Lists.TierThreeTraits.Add(NPC_AI.NPC_042); } if (sQueriedTrait == TraitThree043) { Lists.TierThreeTraits.Add(NPC_AI.NPC_043); } if (sQueriedTrait == TraitThree044) { Lists.TierThreeTraits.Add(NPC_AI.NPC_044); }
                if (sQueriedTrait == TraitThree045) { Lists.TierThreeTraits.Add(NPC_AI.NPC_045); } if (sQueriedTrait == TraitThree046) { Lists.TierThreeTraits.Add(NPC_AI.NPC_046); } if (sQueriedTrait == TraitThree047) { Lists.TierThreeTraits.Add(NPC_AI.NPC_047); } if (sQueriedTrait == TraitThree048) { Lists.TierThreeTraits.Add(NPC_AI.NPC_048); }
                if (sQueriedTrait == TraitThree049) { Lists.TierThreeTraits.Add(NPC_AI.NPC_049); } if (sQueriedTrait == TraitThree050) { Lists.TierThreeTraits.Add(NPC_AI.NPC_050); } if (sQueriedTrait == TraitThree051) { Lists.TierThreeTraits.Add(NPC_AI.NPC_051); } if (sQueriedTrait == TraitThree052) { Lists.TierThreeTraits.Add(NPC_AI.NPC_052); }
                if (sQueriedTrait == TraitThree053) { Lists.TierThreeTraits.Add(NPC_AI.NPC_053); } if (sQueriedTrait == TraitThree054) { Lists.TierThreeTraits.Add(NPC_AI.NPC_054); } if (sQueriedTrait == TraitThree055) { Lists.TierThreeTraits.Add(NPC_AI.NPC_055); } if (sQueriedTrait == TraitThree056) { Lists.TierThreeTraits.Add(NPC_AI.NPC_056); }
                if (sQueriedTrait == TraitThree057) { Lists.TierThreeTraits.Add(NPC_AI.NPC_057); } if (sQueriedTrait == TraitThree058) { Lists.TierThreeTraits.Add(NPC_AI.NPC_058); } if (sQueriedTrait == TraitThree059) { Lists.TierThreeTraits.Add(NPC_AI.NPC_059); } if (sQueriedTrait == TraitThree060) { Lists.TierThreeTraits.Add(NPC_AI.NPC_060); }
                if (sQueriedTrait == TraitThree061) { Lists.TierThreeTraits.Add(NPC_AI.NPC_061); } if (sQueriedTrait == TraitThree062) { Lists.TierThreeTraits.Add(NPC_AI.NPC_062); } if (sQueriedTrait == TraitThree063) { Lists.TierThreeTraits.Add(NPC_AI.NPC_063); } if (sQueriedTrait == TraitThree064) { Lists.TierThreeTraits.Add(NPC_AI.NPC_064); }
                if (sQueriedTrait == TraitThree065) { Lists.TierThreeTraits.Add(NPC_AI.NPC_065); } if (sQueriedTrait == TraitThree066) { Lists.TierThreeTraits.Add(NPC_AI.NPC_066); } if (sQueriedTrait == TraitThree067) { Lists.TierThreeTraits.Add(NPC_AI.NPC_067); } if (sQueriedTrait == TraitThree068) { Lists.TierThreeTraits.Add(NPC_AI.NPC_068); }
                if (sQueriedTrait == TraitThree069) { Lists.TierThreeTraits.Add(NPC_AI.NPC_069); } if (sQueriedTrait == TraitThree070) { Lists.TierThreeTraits.Add(NPC_AI.NPC_070); } if (sQueriedTrait == TraitThree071) { Lists.TierThreeTraits.Add(NPC_AI.NPC_071); } if (sQueriedTrait == TraitThree072) { Lists.TierThreeTraits.Add(NPC_AI.NPC_072); }
                if (sQueriedTrait == TraitThree073) { Lists.TierThreeTraits.Add(NPC_AI.NPC_073); } if (sQueriedTrait == TraitThree074) { Lists.TierThreeTraits.Add(NPC_AI.NPC_074); } if (sQueriedTrait == TraitThree075) { Lists.TierThreeTraits.Add(NPC_AI.NPC_075); } if (sQueriedTrait == TraitThree076) { Lists.TierThreeTraits.Add(NPC_AI.NPC_076); }
                if (sQueriedTrait == TraitThree077) { Lists.TierThreeTraits.Add(NPC_AI.NPC_077); } if (sQueriedTrait == TraitThree078) { Lists.TierThreeTraits.Add(NPC_AI.NPC_078); } if (sQueriedTrait == TraitThree079) { Lists.TierThreeTraits.Add(NPC_AI.NPC_079); } if (sQueriedTrait == TraitThree080) { Lists.TierThreeTraits.Add(NPC_AI.NPC_080); }
                if (sQueriedTrait == TraitThree081) { Lists.TierThreeTraits.Add(NPC_AI.NPC_081); } if (sQueriedTrait == TraitThree082) { Lists.TierThreeTraits.Add(NPC_AI.NPC_082); } if (sQueriedTrait == TraitThree083) { Lists.TierThreeTraits.Add(NPC_AI.NPC_083); } if (sQueriedTrait == TraitThree084) { Lists.TierThreeTraits.Add(NPC_AI.NPC_084); }
                if (sQueriedTrait == TraitThree085) { Lists.TierThreeTraits.Add(NPC_AI.NPC_085); } if (sQueriedTrait == TraitThree086) { Lists.TierThreeTraits.Add(NPC_AI.NPC_086); } if (sQueriedTrait == TraitThree087) { Lists.TierThreeTraits.Add(NPC_AI.NPC_087); } if (sQueriedTrait == TraitThree088) { Lists.TierThreeTraits.Add(NPC_AI.NPC_088); }
                if (sQueriedTrait == TraitThree089) { Lists.TierThreeTraits.Add(NPC_AI.NPC_089); } if (sQueriedTrait == TraitThree090) { Lists.TierThreeTraits.Add(NPC_AI.NPC_090); } if (sQueriedTrait == TraitThree091) { Lists.TierThreeTraits.Add(NPC_AI.NPC_091); } if (sQueriedTrait == TraitThree092) { Lists.TierThreeTraits.Add(NPC_AI.NPC_092); }
                if (sQueriedTrait == TraitThree093) { Lists.TierThreeTraits.Add(NPC_AI.NPC_093); } if (sQueriedTrait == TraitThree094) { Lists.TierThreeTraits.Add(NPC_AI.NPC_094); } if (sQueriedTrait == TraitThree095) { Lists.TierThreeTraits.Add(NPC_AI.NPC_095); } if (sQueriedTrait == TraitThree096) { Lists.TierThreeTraits.Add(NPC_AI.NPC_096); }
                if (sQueriedTrait == TraitThree097) { Lists.TierThreeTraits.Add(NPC_AI.NPC_097); } if (sQueriedTrait == TraitThree098) { Lists.TierThreeTraits.Add(NPC_AI.NPC_098); } if (sQueriedTrait == TraitThree099) { Lists.TierThreeTraits.Add(NPC_AI.NPC_099); } if (sQueriedTrait == TraitThree100) { Lists.TierThreeTraits.Add(NPC_AI.NPC_100); }
        }

        public static void TalkOption_WhatTraitsYouLookingFor()
        {
            NPC_AI.GetAllNPCLocals_AskTrait();
            if (NPC_AI.iTempLoyalty <= 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("'I'd be happy to tell you what I know, but if I'm going to help you maybe");
                Console.WriteLine("you could find a way to make it worth my while.'");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: Only people who are 'Pleasant', 'Agreeable' or 'Friendly' will share");
                Console.WriteLine("this information with you.");
            }
            if (Conversation.iAskOncePerTurn == 1)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("TIP: You may only ask about a trait once per turn. End this turn if you");
                Console.WriteLine("want to ask again.");
            }
            if (NPC_AI.iTempLoyalty > 2 && Conversation.iAskOncePerTurn == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("'A particular trait? Like what?'");
                Console.WriteLine();

                int iTraitList = 0;
                int iTraitQuery = 0;
                int iGuess01 = 0;

                string sGuess1 = "null";
                string sGuess2 = "null";
                string sGuess3 = "null";

                // I asked about trait...
                int iAskTrait001 = 0; int iAskTrait002 = 0; int iAskTrait003 = 0; int iAskTrait004 = 0; int iAskTrait005 = 0;
                int iAskTrait006 = 0; int iAskTrait007 = 0; int iAskTrait008 = 0; int iAskTrait009 = 0; int iAskTrait010 = 0;
                int iAskTrait011 = 0; int iAskTrait012 = 0; int iAskTrait013 = 0; int iAskTrait014 = 0; int iAskTrait015 = 0;
                int iAskTrait016 = 0; int iAskTrait017 = 0; int iAskTrait018 = 0; int iAskTrait019 = 0; int iAskTrait020 = 0;
                int iAskTrait100 = 0; int iAskTrait101 = 0; int iAskTrait102 = 0; int iAskTrait103 = 0; int iAskTrait104 = 0;
                int iAskTrait105 = 0; int iAskTrait106 = 0; int iAskTrait107 = 0; int iAskTrait108 = 0; int iAskTrait109 = 0;
                int iAskTrait110 = 0; int iAskTrait111 = 0; int iAskTrait112 = 0; int iAskTrait113 = 0; int iAskTrait114 = 0;
                int iAskTrait200 = 0; int iAskTrait201 = 0; int iAskTrait202 = 0; int iAskTrait203 = 0; int iAskTrait204 = 0;
                int iAskTrait205 = 0; int iAskTrait206 = 0; int iAskTrait207 = 0; int iAskTrait208 = 0; int iAskTrait209 = 0;
                int iAskTrait210 = 0; int iAskTrait211 = 0; int iAskTrait212 = 0; int iAskTrait213 = 0; int iAskTrait214 = 0;

                int iAskTraitOneBunny = 0; int iAskTraitTwoBunny = 0; int iAskTraitThreeBunny = 0;

                // Tier 1 Traits Mixing with Bunny Trait Cleanup
                bool bAlreadyListed001 = false; bool bAlreadyListed002 = false; bool bAlreadyListed003 = false; bool bAlreadyListed004 = false; bool bAlreadyListed005 = false;
                bool bAlreadyListed006 = false; bool bAlreadyListed007 = false; bool bAlreadyListed008 = false; bool bAlreadyListed009 = false; bool bAlreadyListed010 = false;
                bool bAlreadyListed011 = false; bool bAlreadyListed012 = false; bool bAlreadyListed013 = false; bool bAlreadyListed014 = false; bool bAlreadyListed015 = false;
                bool bAlreadyListed016 = false; bool bAlreadyListed017 = false; bool bAlreadyListed018 = false; bool bAlreadyListed019 = false; bool bAlreadyListed020 = false;

                // Tier 2 Traits Mixing with Bunny Trait Cleanup
                bool bAlreadyListed100 = false; bool bAlreadyListed101 = false; bool bAlreadyListed102 = false; bool bAlreadyListed103 = false; bool bAlreadyListed104 = false;
                bool bAlreadyListed105 = false; bool bAlreadyListed106 = false; bool bAlreadyListed107 = false; bool bAlreadyListed108 = false; bool bAlreadyListed109 = false;
                bool bAlreadyListed110 = false; bool bAlreadyListed111 = false; bool bAlreadyListed112 = false; bool bAlreadyListed113 = false; bool bAlreadyListed114 = false;

                // Tier 3 Traits Mixing with Bunny Trait Cleanup
                bool bAlreadyListed200 = false; bool bAlreadyListed201 = false; bool bAlreadyListed202 = false; bool bAlreadyListed203 = false; bool bAlreadyListed204 = false;
                bool bAlreadyListed205 = false; bool bAlreadyListed206 = false; bool bAlreadyListed207 = false; bool bAlreadyListed208 = false; bool bAlreadyListed209 = false;
                bool bAlreadyListed210 = false; bool bAlreadyListed211 = false; bool bAlreadyListed212 = false; bool bAlreadyListed213 = false; bool bAlreadyListed214 = false;

                // Tier 1
                if (NPC_Traits.bTraitOne01Bunny && sTrait001 == TraitOneBunny) { bAlreadyListed001 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait002 == TraitOneBunny) { bAlreadyListed002 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait003 == TraitOneBunny) { bAlreadyListed003 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait004 == TraitOneBunny) { bAlreadyListed004 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait005 == TraitOneBunny) { bAlreadyListed005 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait006 == TraitOneBunny) { bAlreadyListed006 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait007 == TraitOneBunny) { bAlreadyListed007 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait008 == TraitOneBunny) { bAlreadyListed008 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait009 == TraitOneBunny) { bAlreadyListed009 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait010 == TraitOneBunny) { bAlreadyListed010 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait011 == TraitOneBunny) { bAlreadyListed011 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait012 == TraitOneBunny) { bAlreadyListed012 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait013 == TraitOneBunny) { bAlreadyListed013 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait014 == TraitOneBunny) { bAlreadyListed014 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait015 == TraitOneBunny) { bAlreadyListed015 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait016 == TraitOneBunny) { bAlreadyListed016 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait017 == TraitOneBunny) { bAlreadyListed017 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait018 == TraitOneBunny) { bAlreadyListed018 = true; }
                if (NPC_Traits.bTraitOne01Bunny && sTrait019 == TraitOneBunny) { bAlreadyListed019 = true; } 
                if (NPC_Traits.bTraitOne01Bunny && sTrait020 == TraitOneBunny) { bAlreadyListed020 = true; }

                // Tier 2
                if (NPC_Traits.bTraitTwo01Bunny && sTrait100 == TraitTwoBunny) { bAlreadyListed100 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait101 == TraitTwoBunny) { bAlreadyListed101 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait102 == TraitTwoBunny) { bAlreadyListed102 = true; }
                if (NPC_Traits.bTraitTwo01Bunny && sTrait103 == TraitTwoBunny) { bAlreadyListed103 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait104 == TraitTwoBunny) { bAlreadyListed104 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait105 == TraitTwoBunny) { bAlreadyListed105 = true; }
                if (NPC_Traits.bTraitTwo01Bunny && sTrait106 == TraitTwoBunny) { bAlreadyListed106 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait107 == TraitTwoBunny) { bAlreadyListed107 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait108 == TraitTwoBunny) { bAlreadyListed108 = true; }
                if (NPC_Traits.bTraitTwo01Bunny && sTrait109 == TraitTwoBunny) { bAlreadyListed109 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait110 == TraitTwoBunny) { bAlreadyListed110 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait111 == TraitTwoBunny) { bAlreadyListed111 = true; }
                if (NPC_Traits.bTraitTwo01Bunny && sTrait112 == TraitTwoBunny) { bAlreadyListed112 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait113 == TraitTwoBunny) { bAlreadyListed113 = true; } 
                if (NPC_Traits.bTraitTwo01Bunny && sTrait114 == TraitTwoBunny) { bAlreadyListed114 = true; }

                // Tier 3
                if (NPC_Traits.bTraitThree01Bunny && sTrait200 == TraitThreeBunny) { bAlreadyListed200 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait201 == TraitThreeBunny) { bAlreadyListed201 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait202 == TraitThreeBunny) { bAlreadyListed202 = true; }
                if (NPC_Traits.bTraitThree01Bunny && sTrait203 == TraitThreeBunny) { bAlreadyListed203 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait204 == TraitThreeBunny) { bAlreadyListed204 = true; }
                if (NPC_Traits.bTraitThree01Bunny && sTrait205 == TraitThreeBunny) { bAlreadyListed205 = true; }
                if (NPC_Traits.bTraitThree01Bunny && sTrait206 == TraitThreeBunny) { bAlreadyListed206 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait207 == TraitThreeBunny) { bAlreadyListed207 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait208 == TraitThreeBunny) { bAlreadyListed208 = true; }
                if (NPC_Traits.bTraitThree01Bunny && sTrait209 == TraitThreeBunny) { bAlreadyListed209 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait210 == TraitThreeBunny) { bAlreadyListed210 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait211 == TraitThreeBunny) { bAlreadyListed211 = true; }
                if (NPC_Traits.bTraitThree01Bunny && sTrait212 == TraitThreeBunny) { bAlreadyListed212 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait213 == TraitThreeBunny) { bAlreadyListed213 = true; } 
                if (NPC_Traits.bTraitThree01Bunny && sTrait214 == TraitThreeBunny) { bAlreadyListed214 = true; }

                Console.ForegroundColor = ConsoleColor.White;
                if (NPC_Traits.bTraitOne01Bunny == true)
                {
                    iTraitList++;
                    Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + TraitOneBunny + ".'"); 
                    iAskTraitOneBunny = iTraitList; 
                }
                if (NPC_Traits.bTraitTwo01Bunny == true) 
                { 
                    iTraitList++; 
                    Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + TraitTwoBunny + ".'"); 
                    iAskTraitTwoBunny = iTraitList; 
                }
                if (NPC_Traits.bTraitThree01Bunny == true)
                { 
                    iTraitList++; 
                    Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + TraitThreeBunny + ".'"); 
                    iAskTraitThreeBunny = iTraitList; 
                }

                if (Notebook.bTrait001 && !bAlreadyListed001) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait001 + ".'"); iAskTrait001 = iTraitList; }
                if (Notebook.bTrait002 && !bAlreadyListed002) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait002 + ".'"); iAskTrait002 = iTraitList; }
                if (Notebook.bTrait003 && !bAlreadyListed003) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait003 + ".'"); iAskTrait003 = iTraitList; }
                if (Notebook.bTrait004 && !bAlreadyListed004) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait004 + ".'"); iAskTrait004 = iTraitList; }
                if (Notebook.bTrait005 && !bAlreadyListed005) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait005 + ".'"); iAskTrait005 = iTraitList; }
                if (Notebook.bTrait006 && !bAlreadyListed006) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait006 + ".'"); iAskTrait006 = iTraitList; }
                if (Notebook.bTrait007 && !bAlreadyListed007) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait007 + ".'"); iAskTrait007 = iTraitList; }
                if (Notebook.bTrait008 && !bAlreadyListed008) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait008 + ".'"); iAskTrait008 = iTraitList; }
                if (Notebook.bTrait009 && !bAlreadyListed009) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait009 + ".'"); iAskTrait009 = iTraitList; }
                if (Notebook.bTrait010 && !bAlreadyListed010) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait010 + ".'"); iAskTrait010 = iTraitList; }
                if (Notebook.bTrait011 && !bAlreadyListed011) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait011 + ".'"); iAskTrait011 = iTraitList; }
                if (Notebook.bTrait012 && !bAlreadyListed012) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait012 + ".'"); iAskTrait012 = iTraitList; }
                if (Notebook.bTrait013 && !bAlreadyListed013) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait013 + ".'"); iAskTrait013 = iTraitList; }
                if (Notebook.bTrait014 && !bAlreadyListed014) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait014 + ".'"); iAskTrait014 = iTraitList; }
                if (Notebook.bTrait015 && !bAlreadyListed015) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait015 + ".'"); iAskTrait015 = iTraitList; }
                if (Notebook.bTrait016 && !bAlreadyListed016) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait016 + ".'"); iAskTrait016 = iTraitList; }
                if (Notebook.bTrait017 && !bAlreadyListed017) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait017 + ".'"); iAskTrait017 = iTraitList; }
                if (Notebook.bTrait018 && !bAlreadyListed018) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait018 + ".'"); iAskTrait018 = iTraitList; }
                if (Notebook.bTrait019 && !bAlreadyListed019) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait019 + ".'"); iAskTrait019 = iTraitList; }
                if (Notebook.bTrait020 && !bAlreadyListed020) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait020 + ".'"); iAskTrait020 = iTraitList; }
                if (Notebook.bTrait100 && !bAlreadyListed100) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait100 + ".'"); iAskTrait100 = iTraitList; }
                if (Notebook.bTrait101 && !bAlreadyListed101) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait101 + ".'"); iAskTrait101 = iTraitList; }
                if (Notebook.bTrait102 && !bAlreadyListed102) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait102 + ".'"); iAskTrait102 = iTraitList; }
                if (Notebook.bTrait103 && !bAlreadyListed103) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait103 + ".'"); iAskTrait103 = iTraitList; }
                if (Notebook.bTrait104 && !bAlreadyListed104) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait104 + ".'"); iAskTrait104 = iTraitList; }
                if (Notebook.bTrait105 && !bAlreadyListed105) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait105 + ".'"); iAskTrait105 = iTraitList; }
                if (Notebook.bTrait106 && !bAlreadyListed106) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait106 + ".'"); iAskTrait106 = iTraitList; }
                if (Notebook.bTrait107 && !bAlreadyListed107) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait107 + ".'"); iAskTrait107 = iTraitList; }
                if (Notebook.bTrait108 && !bAlreadyListed108) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait108 + ".'"); iAskTrait108 = iTraitList; }
                if (Notebook.bTrait109 && !bAlreadyListed109) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait109 + ".'"); iAskTrait109 = iTraitList; }
                if (Notebook.bTrait110 && !bAlreadyListed110) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait110 + ".'"); iAskTrait110 = iTraitList; }
                if (Notebook.bTrait111 && !bAlreadyListed111) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait111 + ".'"); iAskTrait111 = iTraitList; }
                if (Notebook.bTrait112 && !bAlreadyListed112) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait112 + ".'"); iAskTrait112 = iTraitList; }
                if (Notebook.bTrait113 && !bAlreadyListed113) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait113 + ".'"); iAskTrait113 = iTraitList; }
                if (Notebook.bTrait114 && !bAlreadyListed114) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait114 + ".'"); iAskTrait114 = iTraitList; }

                if (Notebook.bTrait200 && !bAlreadyListed200) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait200 + ".'"); iAskTrait200 = iTraitList; }
                if (Notebook.bTrait201 && !bAlreadyListed201) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait201 + ".'"); iAskTrait201 = iTraitList; }
                if (Notebook.bTrait202 && !bAlreadyListed202) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait202 + ".'"); iAskTrait202 = iTraitList; }
                if (Notebook.bTrait203 && !bAlreadyListed203) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait203 + ".'"); iAskTrait203 = iTraitList; }
                if (Notebook.bTrait204 && !bAlreadyListed204) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait204 + ".'"); iAskTrait204 = iTraitList; }
                if (Notebook.bTrait205 && !bAlreadyListed205) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait205 + ".'"); iAskTrait205 = iTraitList; }
                if (Notebook.bTrait206 && !bAlreadyListed206) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait206 + ".'"); iAskTrait206 = iTraitList; }
                if (Notebook.bTrait207 && !bAlreadyListed207) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait207 + ".'"); iAskTrait207 = iTraitList; }
                if (Notebook.bTrait208 && !bAlreadyListed208) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait208 + ".'"); iAskTrait208 = iTraitList; }
                if (Notebook.bTrait209 && !bAlreadyListed209) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait209 + ".'"); iAskTrait209 = iTraitList; }
                if (Notebook.bTrait210 && !bAlreadyListed210) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait210 + ".'"); iAskTrait210 = iTraitList; }
                if (Notebook.bTrait211 && !bAlreadyListed211) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait211 + ".'"); iAskTrait211 = iTraitList; }
                if (Notebook.bTrait212 && !bAlreadyListed212) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait212 + ".'"); iAskTrait212 = iTraitList; }
                if (Notebook.bTrait213 && !bAlreadyListed213) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait213 + ".'"); iAskTrait213 = iTraitList; }
                if (Notebook.bTrait214 && !bAlreadyListed214) { iTraitList++; Console.WriteLine(iTraitList + ": 'I'm looking for someone who " + sTrait214 + ".'"); iAskTrait214 = iTraitList; }

                if (Notebook.bTrait001 == false && Notebook.bTrait002 == false && Notebook.bTrait003 == false && Notebook.bTrait004 == false && Notebook.bTrait005 == false &&
                    Notebook.bTrait006 == false && Notebook.bTrait007 == false && Notebook.bTrait008 == false && Notebook.bTrait009 == false && Notebook.bTrait010 == false &&
                    Notebook.bTrait011 == false && Notebook.bTrait012 == false && Notebook.bTrait013 == false && Notebook.bTrait014 == false && Notebook.bTrait015 == false &&
                    Notebook.bTrait016 == false && Notebook.bTrait017 == false && Notebook.bTrait018 == false && Notebook.bTrait019 == false && Notebook.bTrait020 == false &&
                    Notebook.bTrait200 == false && Notebook.bTrait201 == false && Notebook.bTrait202 == false && Notebook.bTrait203 == false && Notebook.bTrait204 == false &&
                    Notebook.bTrait205 == false && Notebook.bTrait206 == false && Notebook.bTrait207 == false && Notebook.bTrait208 == false && Notebook.bTrait209 == false &&
                    Notebook.bTrait210 == false && Notebook.bTrait211 == false && Notebook.bTrait212 == false && Notebook.bTrait213 == false && Notebook.bTrait214 == false)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIP: You need to observe or hear about a trait, such as being clumsy,");
                    Console.WriteLine("before you can ask about it. Try watching some people first.");
                    return;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                int.TryParse(Console.ReadLine(), out iTraitQuery);

                while (iTraitQuery == 0 || iTraitQuery > iTraitList)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose from the list."); iTraitQuery = 999;
                    Console.WriteLine();
                    int.TryParse(Console.ReadLine(), out iTraitQuery);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                if (iTraitQuery == iAskTrait001) { Console.WriteLine("'You're looking for someone who " + sTrait001 + "?"); sQueriedTrait = sTrait001; }
                if (iTraitQuery == iAskTrait002) { Console.WriteLine("'You're looking for someone who " + sTrait002 + "?"); sQueriedTrait = sTrait002; }
                if (iTraitQuery == iAskTrait003) { Console.WriteLine("'You're looking for someone who " + sTrait003 + "?"); sQueriedTrait = sTrait003; }
                if (iTraitQuery == iAskTrait004) { Console.WriteLine("'You're looking for someone who " + sTrait004 + "?"); sQueriedTrait = sTrait004; }
                if (iTraitQuery == iAskTrait005) { Console.WriteLine("'You're looking for someone who " + sTrait005 + "?"); sQueriedTrait = sTrait005; }
                if (iTraitQuery == iAskTrait006) { Console.WriteLine("'You're looking for someone who " + sTrait006 + "?"); sQueriedTrait = sTrait006; }
                if (iTraitQuery == iAskTrait007) { Console.WriteLine("'You're looking for someone who " + sTrait007 + "?"); sQueriedTrait = sTrait007; }
                if (iTraitQuery == iAskTrait008) { Console.WriteLine("'You're looking for someone who " + sTrait008 + "?"); sQueriedTrait = sTrait008; }
                if (iTraitQuery == iAskTrait009) { Console.WriteLine("'You're looking for someone who " + sTrait009 + "?"); sQueriedTrait = sTrait009; }
                if (iTraitQuery == iAskTrait010) { Console.WriteLine("'You're looking for someone who " + sTrait010 + "?"); sQueriedTrait = sTrait010; }
                if (iTraitQuery == iAskTrait011) { Console.WriteLine("'You're looking for someone who " + sTrait011 + "?"); sQueriedTrait = sTrait011; }
                if (iTraitQuery == iAskTrait012) { Console.WriteLine("'You're looking for someone who " + sTrait012 + "?"); sQueriedTrait = sTrait012; }
                if (iTraitQuery == iAskTrait013) { Console.WriteLine("'You're looking for someone who " + sTrait013 + "?"); sQueriedTrait = sTrait013; }
                if (iTraitQuery == iAskTrait014) { Console.WriteLine("'You're looking for someone who " + sTrait014 + "?"); sQueriedTrait = sTrait014; }
                if (iTraitQuery == iAskTrait015) { Console.WriteLine("'You're looking for someone who " + sTrait015 + "?"); sQueriedTrait = sTrait015; }
                if (iTraitQuery == iAskTrait016) { Console.WriteLine("'You're looking for someone who " + sTrait016 + "?"); sQueriedTrait = sTrait016; }
                if (iTraitQuery == iAskTrait017) { Console.WriteLine("'You're looking for someone who " + sTrait017 + "?"); sQueriedTrait = sTrait017; }
                if (iTraitQuery == iAskTrait018) { Console.WriteLine("'You're looking for someone who " + sTrait018 + "?"); sQueriedTrait = sTrait018; }
                if (iTraitQuery == iAskTrait019) { Console.WriteLine("'You're looking for someone who " + sTrait019 + "?"); sQueriedTrait = sTrait019; }
                if (iTraitQuery == iAskTrait020) { Console.WriteLine("'You're looking for someone who " + sTrait020 + "?"); sQueriedTrait = sTrait020; }
                if (iTraitQuery == iAskTraitOneBunny) { Console.WriteLine("'You're looking for someone who " + TraitOneBunny + "?"); sQueriedTrait = TraitOneBunny; }
                if (iTraitQuery == iAskTrait100) { Console.WriteLine("'You're looking for someone who " + sTrait100 + "?"); sQueriedTrait = sTrait100; }
                if (iTraitQuery == iAskTrait101) { Console.WriteLine("'You're looking for someone who " + sTrait101 + "?"); sQueriedTrait = sTrait101; }
                if (iTraitQuery == iAskTrait102) { Console.WriteLine("'You're looking for someone who " + sTrait102 + "?"); sQueriedTrait = sTrait102; }
                if (iTraitQuery == iAskTrait103) { Console.WriteLine("'You're looking for someone who " + sTrait103 + "?"); sQueriedTrait = sTrait103; }
                if (iTraitQuery == iAskTrait104) { Console.WriteLine("'You're looking for someone who " + sTrait104 + "?"); sQueriedTrait = sTrait104; }
                if (iTraitQuery == iAskTrait105) { Console.WriteLine("'You're looking for someone who " + sTrait105 + "?"); sQueriedTrait = sTrait105; }
                if (iTraitQuery == iAskTrait106) { Console.WriteLine("'You're looking for someone who " + sTrait106 + "?"); sQueriedTrait = sTrait106; }
                if (iTraitQuery == iAskTrait107) { Console.WriteLine("'You're looking for someone who " + sTrait107 + "?"); sQueriedTrait = sTrait107; }
                if (iTraitQuery == iAskTrait108) { Console.WriteLine("'You're looking for someone who " + sTrait108 + "?"); sQueriedTrait = sTrait108; }
                if (iTraitQuery == iAskTrait109) { Console.WriteLine("'You're looking for someone who " + sTrait109 + "?"); sQueriedTrait = sTrait109; }
                if (iTraitQuery == iAskTrait110) { Console.WriteLine("'You're looking for someone who " + sTrait110 + "?"); sQueriedTrait = sTrait110; }
                if (iTraitQuery == iAskTrait111) { Console.WriteLine("'You're looking for someone who " + sTrait111 + "?"); sQueriedTrait = sTrait111; }
                if (iTraitQuery == iAskTrait112) { Console.WriteLine("'You're looking for someone who " + sTrait112 + "?"); sQueriedTrait = sTrait112; }
                if (iTraitQuery == iAskTrait113) { Console.WriteLine("'You're looking for someone who " + sTrait113 + "?"); sQueriedTrait = sTrait113; }
                if (iTraitQuery == iAskTrait114) { Console.WriteLine("'You're looking for someone who " + sTrait114 + "?"); sQueriedTrait = sTrait114; }
                if (iTraitQuery == iAskTraitTwoBunny) { Console.WriteLine("'You're looking for someone who " + TraitTwoBunny + "?"); sQueriedTrait = TraitTwoBunny; }
                if (iTraitQuery == iAskTrait200) { Console.WriteLine("'You're looking for someone who " + sTrait200 + "?"); sQueriedTrait = sTrait200; }
                if (iTraitQuery == iAskTrait201) { Console.WriteLine("'You're looking for someone who " + sTrait201 + "?"); sQueriedTrait = sTrait201; }
                if (iTraitQuery == iAskTrait202) { Console.WriteLine("'You're looking for someone who " + sTrait202 + "?"); sQueriedTrait = sTrait202; }
                if (iTraitQuery == iAskTrait203) { Console.WriteLine("'You're looking for someone who " + sTrait203 + "?"); sQueriedTrait = sTrait203; }
                if (iTraitQuery == iAskTrait204) { Console.WriteLine("'You're looking for someone who " + sTrait204 + "?"); sQueriedTrait = sTrait204; }
                if (iTraitQuery == iAskTrait205) { Console.WriteLine("'You're looking for someone who " + sTrait205 + "?"); sQueriedTrait = sTrait205; }
                if (iTraitQuery == iAskTrait206) { Console.WriteLine("'You're looking for someone who " + sTrait206 + "?"); sQueriedTrait = sTrait206; }
                if (iTraitQuery == iAskTrait207) { Console.WriteLine("'You're looking for someone who " + sTrait207 + "?"); sQueriedTrait = sTrait207; }
                if (iTraitQuery == iAskTrait208) { Console.WriteLine("'You're looking for someone who " + sTrait208 + "?"); sQueriedTrait = sTrait208; }
                if (iTraitQuery == iAskTrait209) { Console.WriteLine("'You're looking for someone who " + sTrait209 + "?"); sQueriedTrait = sTrait209; }
                if (iTraitQuery == iAskTrait210) { Console.WriteLine("'You're looking for someone who " + sTrait210 + "?"); sQueriedTrait = sTrait210; }
                if (iTraitQuery == iAskTrait211) { Console.WriteLine("'You're looking for someone who " + sTrait211 + "?"); sQueriedTrait = sTrait211; }
                if (iTraitQuery == iAskTrait212) { Console.WriteLine("'You're looking for someone who " + sTrait212 + "?"); sQueriedTrait = sTrait212; }
                if (iTraitQuery == iAskTrait213) { Console.WriteLine("'You're looking for someone who " + sTrait213 + "?"); sQueriedTrait = sTrait213; }
                if (iTraitQuery == iAskTrait214) { Console.WriteLine("'You're looking for someone who " + sTrait214 + "?"); sQueriedTrait = sTrait214; }
                if (iTraitQuery == iAskTraitThreeBunny) { Console.WriteLine("'You're looking for someone who " + TraitThreeBunny + "?"); sQueriedTrait = TraitThreeBunny; }

                Populate_TraitTierLists();

                if (sQueriedTrait == sTrait001 || sQueriedTrait == sTrait002 || sQueriedTrait == sTrait003 || sQueriedTrait == sTrait004 || sQueriedTrait == sTrait005 ||
                sQueriedTrait == sTrait006 || sQueriedTrait == sTrait007 || sQueriedTrait == sTrait008 || sQueriedTrait == sTrait009 || sQueriedTrait == sTrait010 ||
                sQueriedTrait == sTrait011 || sQueriedTrait == sTrait012 || sQueriedTrait == sTrait013 || sQueriedTrait == sTrait014 || sQueriedTrait == sTrait015 ||
                sQueriedTrait == sTrait016 || sQueriedTrait == sTrait017 || sQueriedTrait == sTrait018 || sQueriedTrait == sTrait019 || sQueriedTrait == sTrait020 ||
                sQueriedTrait == TraitOneBunny)
                {
                    sGuess1 = "null"; sGuess2 = "null"; sGuess3 = "null";
                    if (Lists.TierOneTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierOneTraits.Count);
                        sGuess1 = Lists.TierOneTraits[iGuess01];
                        Lists.TierOneTraits.RemoveAt(iGuess01);
                    }
                    if (Lists.TierOneTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierOneTraits.Count);
                        sGuess2 = Lists.TierOneTraits[iGuess01];
                        Lists.TierOneTraits.RemoveAt(iGuess01);
                    }
                    if (Lists.TierOneTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierOneTraits.Count);
                        sGuess3 = Lists.TierOneTraits[iGuess01];
                        Lists.TierOneTraits.RemoveAt(iGuess01);
                    }
                    int iKnowSomeone = rand.Next(1, 11);
                    if (iKnowSomeone == 10 /* && iNumberofSomeones == 3*/)
                    {
                        {
                            Console.WriteLine("Lots of people fit the bill, wouldn't you say? How about we start with a");
                            Console.WriteLine("few names, like " + sGuess1 + ", " + sGuess2 + ", and " + sGuess3 + "?'");
                        }
                    }
                    if ((iKnowSomeone >= 7 && iKnowSomeone <= 9) /*&& iNumberofSomeones > 2*/)
                    {
                        { Console.WriteLine("You could say that matches " + sGuess1 + " and " + sGuess2 + ", to name a couple.'"); }
                    }
                    if ((iKnowSomeone < 7) /*&& iNumberofSomeones > 1*/)
                    {
                        { Console.WriteLine("Off the top of my head? I'd say that's one way to describe " + sGuess1 + ".'"); }
                    }
                    if (sGuess1 == NPC_AI.NPC_001) { Notebook.bNoteOne001 = true; } if (sGuess1 == NPC_AI.NPC_002) { Notebook.bNoteOne002 = true; } if (sGuess1 == NPC_AI.NPC_003) { Notebook.bNoteOne003 = true; } if (sGuess1 == NPC_AI.NPC_004) { Notebook.bNoteOne004 = true; }
                    if (sGuess1 == NPC_AI.NPC_005) { Notebook.bNoteOne005 = true; } if (sGuess1 == NPC_AI.NPC_006) { Notebook.bNoteOne006 = true; } if (sGuess1 == NPC_AI.NPC_007) { Notebook.bNoteOne007 = true; } if (sGuess1 == NPC_AI.NPC_008) { Notebook.bNoteOne008 = true; }
                    if (sGuess1 == NPC_AI.NPC_009) { Notebook.bNoteOne009 = true; } if (sGuess1 == NPC_AI.NPC_010) { Notebook.bNoteOne010 = true; } if (sGuess1 == NPC_AI.NPC_011) { Notebook.bNoteOne011 = true; } if (sGuess1 == NPC_AI.NPC_012) { Notebook.bNoteOne012 = true; }
                    if (sGuess1 == NPC_AI.NPC_013) { Notebook.bNoteOne013 = true; } if (sGuess1 == NPC_AI.NPC_014) { Notebook.bNoteOne014 = true; } if (sGuess1 == NPC_AI.NPC_015) { Notebook.bNoteOne015 = true; } if (sGuess1 == NPC_AI.NPC_016) { Notebook.bNoteOne016 = true; }
                    if (sGuess1 == NPC_AI.NPC_017) { Notebook.bNoteOne017 = true; } if (sGuess1 == NPC_AI.NPC_018) { Notebook.bNoteOne018 = true; } if (sGuess1 == NPC_AI.NPC_019) { Notebook.bNoteOne019 = true; } if (sGuess1 == NPC_AI.NPC_020) { Notebook.bNoteOne020 = true; }
                    if (sGuess1 == NPC_AI.NPC_021) { Notebook.bNoteOne021 = true; } if (sGuess1 == NPC_AI.NPC_022) { Notebook.bNoteOne022 = true; } if (sGuess1 == NPC_AI.NPC_023) { Notebook.bNoteOne023 = true; } if (sGuess1 == NPC_AI.NPC_024) { Notebook.bNoteOne024 = true; }
                    if (sGuess1 == NPC_AI.NPC_025) { Notebook.bNoteOne025 = true; } if (sGuess1 == NPC_AI.NPC_026) { Notebook.bNoteOne026 = true; } if (sGuess1 == NPC_AI.NPC_027) { Notebook.bNoteOne027 = true; } if (sGuess1 == NPC_AI.NPC_028) { Notebook.bNoteOne028 = true; }
                    if (sGuess1 == NPC_AI.NPC_029) { Notebook.bNoteOne029 = true; } if (sGuess1 == NPC_AI.NPC_030) { Notebook.bNoteOne030 = true; } if (sGuess1 == NPC_AI.NPC_031) { Notebook.bNoteOne031 = true; } if (sGuess1 == NPC_AI.NPC_032) { Notebook.bNoteOne032 = true; }
                    if (sGuess1 == NPC_AI.NPC_033) { Notebook.bNoteOne033 = true; } if (sGuess1 == NPC_AI.NPC_034) { Notebook.bNoteOne034 = true; } if (sGuess1 == NPC_AI.NPC_035) { Notebook.bNoteOne035 = true; } if (sGuess1 == NPC_AI.NPC_036) { Notebook.bNoteOne036 = true; }
                    if (sGuess1 == NPC_AI.NPC_037) { Notebook.bNoteOne037 = true; } if (sGuess1 == NPC_AI.NPC_038) { Notebook.bNoteOne038 = true; } if (sGuess1 == NPC_AI.NPC_039) { Notebook.bNoteOne039 = true; } if (sGuess1 == NPC_AI.NPC_040) { Notebook.bNoteOne040 = true; }
                    if (sGuess1 == NPC_AI.NPC_041) { Notebook.bNoteOne041 = true; } if (sGuess1 == NPC_AI.NPC_042) { Notebook.bNoteOne042 = true; } if (sGuess1 == NPC_AI.NPC_043) { Notebook.bNoteOne043 = true; } if (sGuess1 == NPC_AI.NPC_044) { Notebook.bNoteOne044 = true; }
                    if (sGuess1 == NPC_AI.NPC_045) { Notebook.bNoteOne045 = true; } if (sGuess1 == NPC_AI.NPC_046) { Notebook.bNoteOne046 = true; } if (sGuess1 == NPC_AI.NPC_047) { Notebook.bNoteOne047 = true; } if (sGuess1 == NPC_AI.NPC_048) { Notebook.bNoteOne048 = true; }
                    if (sGuess1 == NPC_AI.NPC_049) { Notebook.bNoteOne049 = true; } if (sGuess1 == NPC_AI.NPC_050) { Notebook.bNoteOne050 = true; } if (sGuess1 == NPC_AI.NPC_051) { Notebook.bNoteOne051 = true; } if (sGuess1 == NPC_AI.NPC_052) { Notebook.bNoteOne052 = true; }
                    if (sGuess1 == NPC_AI.NPC_053) { Notebook.bNoteOne053 = true; } if (sGuess1 == NPC_AI.NPC_054) { Notebook.bNoteOne054 = true; } if (sGuess1 == NPC_AI.NPC_055) { Notebook.bNoteOne055 = true; } if (sGuess1 == NPC_AI.NPC_056) { Notebook.bNoteOne056 = true; }
                    if (sGuess1 == NPC_AI.NPC_057) { Notebook.bNoteOne057 = true; } if (sGuess1 == NPC_AI.NPC_058) { Notebook.bNoteOne058 = true; } if (sGuess1 == NPC_AI.NPC_059) { Notebook.bNoteOne059 = true; } if (sGuess1 == NPC_AI.NPC_060) { Notebook.bNoteOne060 = true; }
                    if (sGuess1 == NPC_AI.NPC_061) { Notebook.bNoteOne061 = true; } if (sGuess1 == NPC_AI.NPC_062) { Notebook.bNoteOne062 = true; } if (sGuess1 == NPC_AI.NPC_063) { Notebook.bNoteOne063 = true; } if (sGuess1 == NPC_AI.NPC_064) { Notebook.bNoteOne064 = true; }
                    if (sGuess1 == NPC_AI.NPC_065) { Notebook.bNoteOne065 = true; } if (sGuess1 == NPC_AI.NPC_066) { Notebook.bNoteOne066 = true; } if (sGuess1 == NPC_AI.NPC_067) { Notebook.bNoteOne067 = true; } if (sGuess1 == NPC_AI.NPC_068) { Notebook.bNoteOne068 = true; }
                    if (sGuess1 == NPC_AI.NPC_069) { Notebook.bNoteOne069 = true; } if (sGuess1 == NPC_AI.NPC_070) { Notebook.bNoteOne070 = true; } if (sGuess1 == NPC_AI.NPC_071) { Notebook.bNoteOne071 = true; } if (sGuess1 == NPC_AI.NPC_072) { Notebook.bNoteOne072 = true; }
                    if (sGuess1 == NPC_AI.NPC_073) { Notebook.bNoteOne073 = true; } if (sGuess1 == NPC_AI.NPC_074) { Notebook.bNoteOne074 = true; } if (sGuess1 == NPC_AI.NPC_075) { Notebook.bNoteOne075 = true; } if (sGuess1 == NPC_AI.NPC_076) { Notebook.bNoteOne076 = true; }
                    if (sGuess1 == NPC_AI.NPC_077) { Notebook.bNoteOne077 = true; } if (sGuess1 == NPC_AI.NPC_078) { Notebook.bNoteOne078 = true; } if (sGuess1 == NPC_AI.NPC_079) { Notebook.bNoteOne079 = true; } if (sGuess1 == NPC_AI.NPC_080) { Notebook.bNoteOne080 = true; }
                    if (sGuess1 == NPC_AI.NPC_081) { Notebook.bNoteOne081 = true; } if (sGuess1 == NPC_AI.NPC_082) { Notebook.bNoteOne082 = true; } if (sGuess1 == NPC_AI.NPC_083) { Notebook.bNoteOne083 = true; } if (sGuess1 == NPC_AI.NPC_084) { Notebook.bNoteOne084 = true; }
                    if (sGuess1 == NPC_AI.NPC_085) { Notebook.bNoteOne085 = true; } if (sGuess1 == NPC_AI.NPC_086) { Notebook.bNoteOne086 = true; } if (sGuess1 == NPC_AI.NPC_087) { Notebook.bNoteOne087 = true; } if (sGuess1 == NPC_AI.NPC_088) { Notebook.bNoteOne088 = true; }
                    if (sGuess1 == NPC_AI.NPC_089) { Notebook.bNoteOne089 = true; } if (sGuess1 == NPC_AI.NPC_090) { Notebook.bNoteOne090 = true; } if (sGuess1 == NPC_AI.NPC_091) { Notebook.bNoteOne091 = true; } if (sGuess1 == NPC_AI.NPC_092) { Notebook.bNoteOne092 = true; }
                    if (sGuess1 == NPC_AI.NPC_093) { Notebook.bNoteOne093 = true; } if (sGuess1 == NPC_AI.NPC_094) { Notebook.bNoteOne094 = true; } if (sGuess1 == NPC_AI.NPC_095) { Notebook.bNoteOne095 = true; } if (sGuess1 == NPC_AI.NPC_096) { Notebook.bNoteOne096 = true; }
                    if (sGuess1 == NPC_AI.NPC_097) { Notebook.bNoteOne097 = true; } if (sGuess1 == NPC_AI.NPC_098) { Notebook.bNoteOne098 = true; } if (sGuess1 == NPC_AI.NPC_099) { Notebook.bNoteOne099 = true; } if (sGuess1 == NPC_AI.NPC_100) { Notebook.bNoteOne100 = true; }

                    if (sGuess2 == NPC_AI.NPC_001) { Notebook.bNoteOne001 = true; } if (sGuess2 == NPC_AI.NPC_002) { Notebook.bNoteOne002 = true; } if (sGuess2 == NPC_AI.NPC_003) { Notebook.bNoteOne003 = true; } if (sGuess2 == NPC_AI.NPC_004) { Notebook.bNoteOne004 = true; }
                    if (sGuess2 == NPC_AI.NPC_005) { Notebook.bNoteOne005 = true; } if (sGuess2 == NPC_AI.NPC_006) { Notebook.bNoteOne006 = true; } if (sGuess2 == NPC_AI.NPC_007) { Notebook.bNoteOne007 = true; } if (sGuess2 == NPC_AI.NPC_008) { Notebook.bNoteOne008 = true; }
                    if (sGuess2 == NPC_AI.NPC_009) { Notebook.bNoteOne009 = true; } if (sGuess2 == NPC_AI.NPC_010) { Notebook.bNoteOne010 = true; } if (sGuess2 == NPC_AI.NPC_011) { Notebook.bNoteOne011 = true; } if (sGuess2 == NPC_AI.NPC_012) { Notebook.bNoteOne012 = true; }
                    if (sGuess2 == NPC_AI.NPC_013) { Notebook.bNoteOne013 = true; } if (sGuess2 == NPC_AI.NPC_014) { Notebook.bNoteOne014 = true; } if (sGuess2 == NPC_AI.NPC_015) { Notebook.bNoteOne015 = true; } if (sGuess2 == NPC_AI.NPC_016) { Notebook.bNoteOne016 = true; }
                    if (sGuess2 == NPC_AI.NPC_017) { Notebook.bNoteOne017 = true; } if (sGuess2 == NPC_AI.NPC_018) { Notebook.bNoteOne018 = true; } if (sGuess2 == NPC_AI.NPC_019) { Notebook.bNoteOne019 = true; } if (sGuess2 == NPC_AI.NPC_020) { Notebook.bNoteOne020 = true; }
                    if (sGuess2 == NPC_AI.NPC_021) { Notebook.bNoteOne021 = true; } if (sGuess2 == NPC_AI.NPC_022) { Notebook.bNoteOne022 = true; } if (sGuess2 == NPC_AI.NPC_023) { Notebook.bNoteOne023 = true; } if (sGuess2 == NPC_AI.NPC_024) { Notebook.bNoteOne024 = true; }
                    if (sGuess2 == NPC_AI.NPC_025) { Notebook.bNoteOne025 = true; } if (sGuess2 == NPC_AI.NPC_026) { Notebook.bNoteOne026 = true; } if (sGuess2 == NPC_AI.NPC_027) { Notebook.bNoteOne027 = true; } if (sGuess2 == NPC_AI.NPC_028) { Notebook.bNoteOne028 = true; }
                    if (sGuess2 == NPC_AI.NPC_029) { Notebook.bNoteOne029 = true; } if (sGuess2 == NPC_AI.NPC_030) { Notebook.bNoteOne030 = true; } if (sGuess2 == NPC_AI.NPC_031) { Notebook.bNoteOne031 = true; } if (sGuess2 == NPC_AI.NPC_032) { Notebook.bNoteOne032 = true; }
                    if (sGuess2 == NPC_AI.NPC_033) { Notebook.bNoteOne033 = true; } if (sGuess2 == NPC_AI.NPC_034) { Notebook.bNoteOne034 = true; } if (sGuess2 == NPC_AI.NPC_035) { Notebook.bNoteOne035 = true; } if (sGuess2 == NPC_AI.NPC_036) { Notebook.bNoteOne036 = true; }
                    if (sGuess2 == NPC_AI.NPC_037) { Notebook.bNoteOne037 = true; } if (sGuess2 == NPC_AI.NPC_038) { Notebook.bNoteOne038 = true; } if (sGuess2 == NPC_AI.NPC_039) { Notebook.bNoteOne039 = true; } if (sGuess2 == NPC_AI.NPC_040) { Notebook.bNoteOne040 = true; }
                    if (sGuess2 == NPC_AI.NPC_041) { Notebook.bNoteOne041 = true; } if (sGuess2 == NPC_AI.NPC_042) { Notebook.bNoteOne042 = true; } if (sGuess2 == NPC_AI.NPC_043) { Notebook.bNoteOne043 = true; } if (sGuess2 == NPC_AI.NPC_044) { Notebook.bNoteOne044 = true; }
                    if (sGuess2 == NPC_AI.NPC_045) { Notebook.bNoteOne045 = true; } if (sGuess2 == NPC_AI.NPC_046) { Notebook.bNoteOne046 = true; } if (sGuess2 == NPC_AI.NPC_047) { Notebook.bNoteOne047 = true; } if (sGuess2 == NPC_AI.NPC_048) { Notebook.bNoteOne048 = true; }
                    if (sGuess2 == NPC_AI.NPC_049) { Notebook.bNoteOne049 = true; } if (sGuess2 == NPC_AI.NPC_050) { Notebook.bNoteOne050 = true; } if (sGuess2 == NPC_AI.NPC_051) { Notebook.bNoteOne051 = true; } if (sGuess2 == NPC_AI.NPC_052) { Notebook.bNoteOne052 = true; }
                    if (sGuess2 == NPC_AI.NPC_053) { Notebook.bNoteOne053 = true; } if (sGuess2 == NPC_AI.NPC_054) { Notebook.bNoteOne054 = true; } if (sGuess2 == NPC_AI.NPC_055) { Notebook.bNoteOne055 = true; } if (sGuess2 == NPC_AI.NPC_056) { Notebook.bNoteOne056 = true; }
                    if (sGuess2 == NPC_AI.NPC_057) { Notebook.bNoteOne057 = true; } if (sGuess2 == NPC_AI.NPC_058) { Notebook.bNoteOne058 = true; } if (sGuess2 == NPC_AI.NPC_059) { Notebook.bNoteOne059 = true; } if (sGuess2 == NPC_AI.NPC_060) { Notebook.bNoteOne060 = true; }
                    if (sGuess2 == NPC_AI.NPC_061) { Notebook.bNoteOne061 = true; } if (sGuess2 == NPC_AI.NPC_062) { Notebook.bNoteOne062 = true; } if (sGuess2 == NPC_AI.NPC_063) { Notebook.bNoteOne063 = true; } if (sGuess2 == NPC_AI.NPC_064) { Notebook.bNoteOne064 = true; }
                    if (sGuess2 == NPC_AI.NPC_065) { Notebook.bNoteOne065 = true; } if (sGuess2 == NPC_AI.NPC_066) { Notebook.bNoteOne066 = true; } if (sGuess2 == NPC_AI.NPC_067) { Notebook.bNoteOne067 = true; } if (sGuess2 == NPC_AI.NPC_068) { Notebook.bNoteOne068 = true; }
                    if (sGuess2 == NPC_AI.NPC_069) { Notebook.bNoteOne069 = true; } if (sGuess2 == NPC_AI.NPC_070) { Notebook.bNoteOne070 = true; } if (sGuess2 == NPC_AI.NPC_071) { Notebook.bNoteOne071 = true; } if (sGuess2 == NPC_AI.NPC_072) { Notebook.bNoteOne072 = true; }
                    if (sGuess2 == NPC_AI.NPC_073) { Notebook.bNoteOne073 = true; } if (sGuess2 == NPC_AI.NPC_074) { Notebook.bNoteOne074 = true; } if (sGuess2 == NPC_AI.NPC_075) { Notebook.bNoteOne075 = true; } if (sGuess2 == NPC_AI.NPC_076) { Notebook.bNoteOne076 = true; }
                    if (sGuess2 == NPC_AI.NPC_077) { Notebook.bNoteOne077 = true; } if (sGuess2 == NPC_AI.NPC_078) { Notebook.bNoteOne078 = true; } if (sGuess2 == NPC_AI.NPC_079) { Notebook.bNoteOne079 = true; } if (sGuess2 == NPC_AI.NPC_080) { Notebook.bNoteOne080 = true; }
                    if (sGuess2 == NPC_AI.NPC_081) { Notebook.bNoteOne081 = true; } if (sGuess2 == NPC_AI.NPC_082) { Notebook.bNoteOne082 = true; } if (sGuess2 == NPC_AI.NPC_083) { Notebook.bNoteOne083 = true; } if (sGuess2 == NPC_AI.NPC_084) { Notebook.bNoteOne084 = true; }
                    if (sGuess2 == NPC_AI.NPC_085) { Notebook.bNoteOne085 = true; } if (sGuess2 == NPC_AI.NPC_086) { Notebook.bNoteOne086 = true; } if (sGuess2 == NPC_AI.NPC_087) { Notebook.bNoteOne087 = true; } if (sGuess2 == NPC_AI.NPC_088) { Notebook.bNoteOne088 = true; }
                    if (sGuess2 == NPC_AI.NPC_089) { Notebook.bNoteOne089 = true; } if (sGuess2 == NPC_AI.NPC_090) { Notebook.bNoteOne090 = true; } if (sGuess2 == NPC_AI.NPC_091) { Notebook.bNoteOne091 = true; } if (sGuess2 == NPC_AI.NPC_092) { Notebook.bNoteOne092 = true; }
                    if (sGuess2 == NPC_AI.NPC_093) { Notebook.bNoteOne093 = true; } if (sGuess2 == NPC_AI.NPC_094) { Notebook.bNoteOne094 = true; } if (sGuess2 == NPC_AI.NPC_095) { Notebook.bNoteOne095 = true; } if (sGuess2 == NPC_AI.NPC_096) { Notebook.bNoteOne096 = true; }
                    if (sGuess2 == NPC_AI.NPC_097) { Notebook.bNoteOne097 = true; } if (sGuess2 == NPC_AI.NPC_098) { Notebook.bNoteOne098 = true; } if (sGuess2 == NPC_AI.NPC_099) { Notebook.bNoteOne099 = true; } if (sGuess2 == NPC_AI.NPC_100) { Notebook.bNoteOne100 = true; }

                    if (sGuess3 == NPC_AI.NPC_001) { Notebook.bNoteOne001 = true; } if (sGuess3 == NPC_AI.NPC_002) { Notebook.bNoteOne002 = true; } if (sGuess3 == NPC_AI.NPC_003) { Notebook.bNoteOne003 = true; } if (sGuess3 == NPC_AI.NPC_004) { Notebook.bNoteOne004 = true; }
                    if (sGuess3 == NPC_AI.NPC_005) { Notebook.bNoteOne005 = true; } if (sGuess3 == NPC_AI.NPC_006) { Notebook.bNoteOne006 = true; } if (sGuess3 == NPC_AI.NPC_007) { Notebook.bNoteOne007 = true; } if (sGuess3 == NPC_AI.NPC_008) { Notebook.bNoteOne008 = true; }
                    if (sGuess3 == NPC_AI.NPC_009) { Notebook.bNoteOne009 = true; } if (sGuess3 == NPC_AI.NPC_010) { Notebook.bNoteOne010 = true; } if (sGuess3 == NPC_AI.NPC_011) { Notebook.bNoteOne011 = true; } if (sGuess3 == NPC_AI.NPC_012) { Notebook.bNoteOne012 = true; }
                    if (sGuess3 == NPC_AI.NPC_013) { Notebook.bNoteOne013 = true; } if (sGuess3 == NPC_AI.NPC_014) { Notebook.bNoteOne014 = true; } if (sGuess3 == NPC_AI.NPC_015) { Notebook.bNoteOne015 = true; } if (sGuess3 == NPC_AI.NPC_016) { Notebook.bNoteOne016 = true; }
                    if (sGuess3 == NPC_AI.NPC_017) { Notebook.bNoteOne017 = true; } if (sGuess3 == NPC_AI.NPC_018) { Notebook.bNoteOne018 = true; } if (sGuess3 == NPC_AI.NPC_019) { Notebook.bNoteOne019 = true; } if (sGuess3 == NPC_AI.NPC_020) { Notebook.bNoteOne020 = true; }
                    if (sGuess3 == NPC_AI.NPC_021) { Notebook.bNoteOne021 = true; } if (sGuess3 == NPC_AI.NPC_022) { Notebook.bNoteOne022 = true; } if (sGuess3 == NPC_AI.NPC_023) { Notebook.bNoteOne023 = true; } if (sGuess3 == NPC_AI.NPC_024) { Notebook.bNoteOne024 = true; }
                    if (sGuess3 == NPC_AI.NPC_025) { Notebook.bNoteOne025 = true; } if (sGuess3 == NPC_AI.NPC_026) { Notebook.bNoteOne026 = true; } if (sGuess3 == NPC_AI.NPC_027) { Notebook.bNoteOne027 = true; } if (sGuess3 == NPC_AI.NPC_028) { Notebook.bNoteOne028 = true; }
                    if (sGuess3 == NPC_AI.NPC_029) { Notebook.bNoteOne029 = true; } if (sGuess3 == NPC_AI.NPC_030) { Notebook.bNoteOne030 = true; } if (sGuess3 == NPC_AI.NPC_031) { Notebook.bNoteOne031 = true; } if (sGuess3 == NPC_AI.NPC_032) { Notebook.bNoteOne032 = true; }
                    if (sGuess3 == NPC_AI.NPC_033) { Notebook.bNoteOne033 = true; } if (sGuess3 == NPC_AI.NPC_034) { Notebook.bNoteOne034 = true; } if (sGuess3 == NPC_AI.NPC_035) { Notebook.bNoteOne035 = true; } if (sGuess3 == NPC_AI.NPC_036) { Notebook.bNoteOne036 = true; }
                    if (sGuess3 == NPC_AI.NPC_037) { Notebook.bNoteOne037 = true; } if (sGuess3 == NPC_AI.NPC_038) { Notebook.bNoteOne038 = true; } if (sGuess3 == NPC_AI.NPC_039) { Notebook.bNoteOne039 = true; } if (sGuess3 == NPC_AI.NPC_040) { Notebook.bNoteOne040 = true; }
                    if (sGuess3 == NPC_AI.NPC_041) { Notebook.bNoteOne041 = true; } if (sGuess3 == NPC_AI.NPC_042) { Notebook.bNoteOne042 = true; } if (sGuess3 == NPC_AI.NPC_043) { Notebook.bNoteOne043 = true; } if (sGuess3 == NPC_AI.NPC_044) { Notebook.bNoteOne044 = true; }
                    if (sGuess3 == NPC_AI.NPC_045) { Notebook.bNoteOne045 = true; } if (sGuess3 == NPC_AI.NPC_046) { Notebook.bNoteOne046 = true; } if (sGuess3 == NPC_AI.NPC_047) { Notebook.bNoteOne047 = true; } if (sGuess3 == NPC_AI.NPC_048) { Notebook.bNoteOne048 = true; }
                    if (sGuess3 == NPC_AI.NPC_049) { Notebook.bNoteOne049 = true; } if (sGuess3 == NPC_AI.NPC_050) { Notebook.bNoteOne050 = true; } if (sGuess3 == NPC_AI.NPC_051) { Notebook.bNoteOne051 = true; } if (sGuess3 == NPC_AI.NPC_052) { Notebook.bNoteOne052 = true; }
                    if (sGuess3 == NPC_AI.NPC_053) { Notebook.bNoteOne053 = true; } if (sGuess3 == NPC_AI.NPC_054) { Notebook.bNoteOne054 = true; } if (sGuess3 == NPC_AI.NPC_055) { Notebook.bNoteOne055 = true; } if (sGuess3 == NPC_AI.NPC_056) { Notebook.bNoteOne056 = true; }
                    if (sGuess3 == NPC_AI.NPC_057) { Notebook.bNoteOne057 = true; } if (sGuess3 == NPC_AI.NPC_058) { Notebook.bNoteOne058 = true; } if (sGuess3 == NPC_AI.NPC_059) { Notebook.bNoteOne059 = true; } if (sGuess3 == NPC_AI.NPC_060) { Notebook.bNoteOne060 = true; }
                    if (sGuess3 == NPC_AI.NPC_061) { Notebook.bNoteOne061 = true; } if (sGuess3 == NPC_AI.NPC_062) { Notebook.bNoteOne062 = true; } if (sGuess3 == NPC_AI.NPC_063) { Notebook.bNoteOne063 = true; } if (sGuess3 == NPC_AI.NPC_064) { Notebook.bNoteOne064 = true; }
                    if (sGuess3 == NPC_AI.NPC_065) { Notebook.bNoteOne065 = true; } if (sGuess3 == NPC_AI.NPC_066) { Notebook.bNoteOne066 = true; } if (sGuess3 == NPC_AI.NPC_067) { Notebook.bNoteOne067 = true; } if (sGuess3 == NPC_AI.NPC_068) { Notebook.bNoteOne068 = true; }
                    if (sGuess3 == NPC_AI.NPC_069) { Notebook.bNoteOne069 = true; } if (sGuess3 == NPC_AI.NPC_070) { Notebook.bNoteOne070 = true; } if (sGuess3 == NPC_AI.NPC_071) { Notebook.bNoteOne071 = true; } if (sGuess3 == NPC_AI.NPC_072) { Notebook.bNoteOne072 = true; }
                    if (sGuess3 == NPC_AI.NPC_073) { Notebook.bNoteOne073 = true; } if (sGuess3 == NPC_AI.NPC_074) { Notebook.bNoteOne074 = true; } if (sGuess3 == NPC_AI.NPC_075) { Notebook.bNoteOne075 = true; } if (sGuess3 == NPC_AI.NPC_076) { Notebook.bNoteOne076 = true; }
                    if (sGuess3 == NPC_AI.NPC_077) { Notebook.bNoteOne077 = true; } if (sGuess3 == NPC_AI.NPC_078) { Notebook.bNoteOne078 = true; } if (sGuess3 == NPC_AI.NPC_079) { Notebook.bNoteOne079 = true; } if (sGuess3 == NPC_AI.NPC_080) { Notebook.bNoteOne080 = true; }
                    if (sGuess3 == NPC_AI.NPC_081) { Notebook.bNoteOne081 = true; } if (sGuess3 == NPC_AI.NPC_082) { Notebook.bNoteOne082 = true; } if (sGuess3 == NPC_AI.NPC_083) { Notebook.bNoteOne083 = true; } if (sGuess3 == NPC_AI.NPC_084) { Notebook.bNoteOne084 = true; }
                    if (sGuess3 == NPC_AI.NPC_085) { Notebook.bNoteOne085 = true; } if (sGuess3 == NPC_AI.NPC_086) { Notebook.bNoteOne086 = true; } if (sGuess3 == NPC_AI.NPC_087) { Notebook.bNoteOne087 = true; } if (sGuess3 == NPC_AI.NPC_088) { Notebook.bNoteOne088 = true; }
                    if (sGuess3 == NPC_AI.NPC_089) { Notebook.bNoteOne089 = true; } if (sGuess3 == NPC_AI.NPC_090) { Notebook.bNoteOne090 = true; } if (sGuess3 == NPC_AI.NPC_091) { Notebook.bNoteOne091 = true; } if (sGuess3 == NPC_AI.NPC_092) { Notebook.bNoteOne092 = true; }
                    if (sGuess3 == NPC_AI.NPC_093) { Notebook.bNoteOne093 = true; } if (sGuess3 == NPC_AI.NPC_094) { Notebook.bNoteOne094 = true; } if (sGuess3 == NPC_AI.NPC_095) { Notebook.bNoteOne095 = true; } if (sGuess3 == NPC_AI.NPC_096) { Notebook.bNoteOne096 = true; }
                    if (sGuess3 == NPC_AI.NPC_097) { Notebook.bNoteOne097 = true; } if (sGuess3 == NPC_AI.NPC_098) { Notebook.bNoteOne098 = true; } if (sGuess3 == NPC_AI.NPC_099) { Notebook.bNoteOne099 = true; } if (sGuess3 == NPC_AI.NPC_100) { Notebook.bNoteOne100 = true; }
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIP: Any new information has been added to your notebook.");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                if (sQueriedTrait == sTrait100 || sQueriedTrait == sTrait101 || sQueriedTrait == sTrait102 || sQueriedTrait == sTrait103 || sQueriedTrait == sTrait104 ||
                sQueriedTrait == sTrait105 || sQueriedTrait == sTrait106 || sQueriedTrait == sTrait107 || sQueriedTrait == sTrait108 || sQueriedTrait == sTrait109 ||
                sQueriedTrait == sTrait110 || sQueriedTrait == sTrait111 || sQueriedTrait == sTrait112 || sQueriedTrait == sTrait113 || sQueriedTrait == sTrait114 ||
                sQueriedTrait == TraitTwoBunny)
                {
                    sGuess1 = "null"; sGuess2 = "null"; sGuess3 = "null";
                    if (Lists.TierTwoTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierTwoTraits.Count);
                        sGuess1 = Lists.TierTwoTraits[iGuess01];
                        Lists.TierTwoTraits.RemoveAt(iGuess01);
                        // iNumberofSomeones = 1;
                    }
                    if (Lists.TierTwoTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierTwoTraits.Count);
                        sGuess2 = Lists.TierTwoTraits[iGuess01];
                        Lists.TierTwoTraits.RemoveAt(iGuess01);
                        // iNumberofSomeones = 2;
                    }
                    int iKnowSomeone = Program.rand.Next(1, 11);
                    if ((iKnowSomeone >= 8) /*&& iNumberofSomeones > 2*/)
                    {
                        Console.WriteLine("You could say that matches " + sGuess1 + " and " + sGuess2 + ", to name a couple.'");
                    }
                    if ((iKnowSomeone >= 4) && (iKnowSomeone <= 7))
                    {
                        Console.WriteLine("Off the top of my head? I'd say that's one way to describe " + sGuess1 + ".'");
                    }
                    if ((iKnowSomeone < 4) /*&& iNumberofSomeones > 1*/)
                    {
                        Console.WriteLine("You've put me on the spot! Hm, I don't know. I can't think of anyone.'");
                    }
                    if (sGuess1 == NPC_AI.NPC_001) { Notebook.bNoteTwo001 = true; } if (sGuess1 == NPC_AI.NPC_002) { Notebook.bNoteTwo002 = true; } if (sGuess1 == NPC_AI.NPC_003) { Notebook.bNoteTwo003 = true; } if (sGuess1 == NPC_AI.NPC_004) { Notebook.bNoteTwo004 = true; }
                    if (sGuess1 == NPC_AI.NPC_005) { Notebook.bNoteTwo005 = true; } if (sGuess1 == NPC_AI.NPC_006) { Notebook.bNoteTwo006 = true; } if (sGuess1 == NPC_AI.NPC_007) { Notebook.bNoteTwo007 = true; } if (sGuess1 == NPC_AI.NPC_008) { Notebook.bNoteTwo008 = true; }
                    if (sGuess1 == NPC_AI.NPC_009) { Notebook.bNoteTwo009 = true; } if (sGuess1 == NPC_AI.NPC_010) { Notebook.bNoteTwo010 = true; } if (sGuess1 == NPC_AI.NPC_011) { Notebook.bNoteTwo011 = true; } if (sGuess1 == NPC_AI.NPC_012) { Notebook.bNoteTwo012 = true; }
                    if (sGuess1 == NPC_AI.NPC_013) { Notebook.bNoteTwo013 = true; } if (sGuess1 == NPC_AI.NPC_014) { Notebook.bNoteTwo014 = true; } if (sGuess1 == NPC_AI.NPC_015) { Notebook.bNoteTwo015 = true; } if (sGuess1 == NPC_AI.NPC_016) { Notebook.bNoteTwo016 = true; }
                    if (sGuess1 == NPC_AI.NPC_017) { Notebook.bNoteTwo017 = true; } if (sGuess1 == NPC_AI.NPC_018) { Notebook.bNoteTwo018 = true; } if (sGuess1 == NPC_AI.NPC_019) { Notebook.bNoteTwo019 = true; } if (sGuess1 == NPC_AI.NPC_020) { Notebook.bNoteTwo020 = true; }
                    if (sGuess1 == NPC_AI.NPC_021) { Notebook.bNoteTwo021 = true; } if (sGuess1 == NPC_AI.NPC_022) { Notebook.bNoteTwo022 = true; } if (sGuess1 == NPC_AI.NPC_023) { Notebook.bNoteTwo023 = true; } if (sGuess1 == NPC_AI.NPC_024) { Notebook.bNoteTwo024 = true; }
                    if (sGuess1 == NPC_AI.NPC_025) { Notebook.bNoteTwo025 = true; } if (sGuess1 == NPC_AI.NPC_026) { Notebook.bNoteTwo026 = true; } if (sGuess1 == NPC_AI.NPC_027) { Notebook.bNoteTwo027 = true; } if (sGuess1 == NPC_AI.NPC_028) { Notebook.bNoteTwo028 = true; }
                    if (sGuess1 == NPC_AI.NPC_029) { Notebook.bNoteTwo029 = true; } if (sGuess1 == NPC_AI.NPC_030) { Notebook.bNoteTwo030 = true; } if (sGuess1 == NPC_AI.NPC_031) { Notebook.bNoteTwo031 = true; } if (sGuess1 == NPC_AI.NPC_032) { Notebook.bNoteTwo032 = true; }
                    if (sGuess1 == NPC_AI.NPC_033) { Notebook.bNoteTwo033 = true; } if (sGuess1 == NPC_AI.NPC_034) { Notebook.bNoteTwo034 = true; } if (sGuess1 == NPC_AI.NPC_035) { Notebook.bNoteTwo035 = true; } if (sGuess1 == NPC_AI.NPC_036) { Notebook.bNoteTwo036 = true; }
                    if (sGuess1 == NPC_AI.NPC_037) { Notebook.bNoteTwo037 = true; } if (sGuess1 == NPC_AI.NPC_038) { Notebook.bNoteTwo038 = true; } if (sGuess1 == NPC_AI.NPC_039) { Notebook.bNoteTwo039 = true; } if (sGuess1 == NPC_AI.NPC_040) { Notebook.bNoteTwo040 = true; }
                    if (sGuess1 == NPC_AI.NPC_041) { Notebook.bNoteTwo041 = true; } if (sGuess1 == NPC_AI.NPC_042) { Notebook.bNoteTwo042 = true; } if (sGuess1 == NPC_AI.NPC_043) { Notebook.bNoteTwo043 = true; } if (sGuess1 == NPC_AI.NPC_044) { Notebook.bNoteTwo044 = true; }
                    if (sGuess1 == NPC_AI.NPC_045) { Notebook.bNoteTwo045 = true; } if (sGuess1 == NPC_AI.NPC_046) { Notebook.bNoteTwo046 = true; } if (sGuess1 == NPC_AI.NPC_047) { Notebook.bNoteTwo047 = true; } if (sGuess1 == NPC_AI.NPC_048) { Notebook.bNoteTwo048 = true; }
                    if (sGuess1 == NPC_AI.NPC_049) { Notebook.bNoteTwo049 = true; } if (sGuess1 == NPC_AI.NPC_050) { Notebook.bNoteTwo050 = true; } if (sGuess1 == NPC_AI.NPC_051) { Notebook.bNoteTwo051 = true; } if (sGuess1 == NPC_AI.NPC_052) { Notebook.bNoteTwo052 = true; }
                    if (sGuess1 == NPC_AI.NPC_053) { Notebook.bNoteTwo053 = true; } if (sGuess1 == NPC_AI.NPC_054) { Notebook.bNoteTwo054 = true; } if (sGuess1 == NPC_AI.NPC_055) { Notebook.bNoteTwo055 = true; } if (sGuess1 == NPC_AI.NPC_056) { Notebook.bNoteTwo056 = true; }
                    if (sGuess1 == NPC_AI.NPC_057) { Notebook.bNoteTwo057 = true; } if (sGuess1 == NPC_AI.NPC_058) { Notebook.bNoteTwo058 = true; } if (sGuess1 == NPC_AI.NPC_059) { Notebook.bNoteTwo059 = true; } if (sGuess1 == NPC_AI.NPC_060) { Notebook.bNoteTwo060 = true; }
                    if (sGuess1 == NPC_AI.NPC_061) { Notebook.bNoteTwo061 = true; } if (sGuess1 == NPC_AI.NPC_062) { Notebook.bNoteTwo062 = true; } if (sGuess1 == NPC_AI.NPC_063) { Notebook.bNoteTwo063 = true; } if (sGuess1 == NPC_AI.NPC_064) { Notebook.bNoteTwo064 = true; }
                    if (sGuess1 == NPC_AI.NPC_065) { Notebook.bNoteTwo065 = true; } if (sGuess1 == NPC_AI.NPC_066) { Notebook.bNoteTwo066 = true; } if (sGuess1 == NPC_AI.NPC_067) { Notebook.bNoteTwo067 = true; } if (sGuess1 == NPC_AI.NPC_068) { Notebook.bNoteTwo068 = true; }
                    if (sGuess1 == NPC_AI.NPC_069) { Notebook.bNoteTwo069 = true; } if (sGuess1 == NPC_AI.NPC_070) { Notebook.bNoteTwo070 = true; } if (sGuess1 == NPC_AI.NPC_071) { Notebook.bNoteTwo071 = true; } if (sGuess1 == NPC_AI.NPC_072) { Notebook.bNoteTwo072 = true; }
                    if (sGuess1 == NPC_AI.NPC_073) { Notebook.bNoteTwo073 = true; } if (sGuess1 == NPC_AI.NPC_074) { Notebook.bNoteTwo074 = true; } if (sGuess1 == NPC_AI.NPC_075) { Notebook.bNoteTwo075 = true; } if (sGuess1 == NPC_AI.NPC_076) { Notebook.bNoteTwo076 = true; }
                    if (sGuess1 == NPC_AI.NPC_077) { Notebook.bNoteTwo077 = true; } if (sGuess1 == NPC_AI.NPC_078) { Notebook.bNoteTwo078 = true; } if (sGuess1 == NPC_AI.NPC_079) { Notebook.bNoteTwo079 = true; } if (sGuess1 == NPC_AI.NPC_080) { Notebook.bNoteTwo080 = true; }
                    if (sGuess1 == NPC_AI.NPC_081) { Notebook.bNoteTwo081 = true; } if (sGuess1 == NPC_AI.NPC_082) { Notebook.bNoteTwo082 = true; } if (sGuess1 == NPC_AI.NPC_083) { Notebook.bNoteTwo083 = true; } if (sGuess1 == NPC_AI.NPC_084) { Notebook.bNoteTwo084 = true; }
                    if (sGuess1 == NPC_AI.NPC_085) { Notebook.bNoteTwo085 = true; } if (sGuess1 == NPC_AI.NPC_086) { Notebook.bNoteTwo086 = true; } if (sGuess1 == NPC_AI.NPC_087) { Notebook.bNoteTwo087 = true; } if (sGuess1 == NPC_AI.NPC_088) { Notebook.bNoteTwo088 = true; }
                    if (sGuess1 == NPC_AI.NPC_089) { Notebook.bNoteTwo089 = true; } if (sGuess1 == NPC_AI.NPC_090) { Notebook.bNoteTwo090 = true; } if (sGuess1 == NPC_AI.NPC_091) { Notebook.bNoteTwo091 = true; } if (sGuess1 == NPC_AI.NPC_092) { Notebook.bNoteTwo092 = true; }
                    if (sGuess1 == NPC_AI.NPC_093) { Notebook.bNoteTwo093 = true; } if (sGuess1 == NPC_AI.NPC_094) { Notebook.bNoteTwo094 = true; } if (sGuess1 == NPC_AI.NPC_095) { Notebook.bNoteTwo095 = true; } if (sGuess1 == NPC_AI.NPC_096) { Notebook.bNoteTwo096 = true; }
                    if (sGuess1 == NPC_AI.NPC_097) { Notebook.bNoteTwo097 = true; } if (sGuess1 == NPC_AI.NPC_098) { Notebook.bNoteTwo098 = true; } if (sGuess1 == NPC_AI.NPC_099) { Notebook.bNoteTwo099 = true; } if (sGuess1 == NPC_AI.NPC_100) { Notebook.bNoteTwo100 = true; }

                    if (sGuess2 == NPC_AI.NPC_001) { Notebook.bNoteTwo001 = true; } if (sGuess2 == NPC_AI.NPC_002) { Notebook.bNoteTwo002 = true; } if (sGuess2 == NPC_AI.NPC_003) { Notebook.bNoteTwo003 = true; } if (sGuess2 == NPC_AI.NPC_004) { Notebook.bNoteTwo004 = true; }
                    if (sGuess2 == NPC_AI.NPC_005) { Notebook.bNoteTwo005 = true; } if (sGuess2 == NPC_AI.NPC_006) { Notebook.bNoteTwo006 = true; } if (sGuess2 == NPC_AI.NPC_007) { Notebook.bNoteTwo007 = true; } if (sGuess2 == NPC_AI.NPC_008) { Notebook.bNoteTwo008 = true; }
                    if (sGuess2 == NPC_AI.NPC_009) { Notebook.bNoteTwo009 = true; } if (sGuess2 == NPC_AI.NPC_010) { Notebook.bNoteTwo010 = true; } if (sGuess2 == NPC_AI.NPC_011) { Notebook.bNoteTwo011 = true; } if (sGuess2 == NPC_AI.NPC_012) { Notebook.bNoteTwo012 = true; }
                    if (sGuess2 == NPC_AI.NPC_013) { Notebook.bNoteTwo013 = true; } if (sGuess2 == NPC_AI.NPC_014) { Notebook.bNoteTwo014 = true; } if (sGuess2 == NPC_AI.NPC_015) { Notebook.bNoteTwo015 = true; } if (sGuess2 == NPC_AI.NPC_016) { Notebook.bNoteTwo016 = true; }
                    if (sGuess2 == NPC_AI.NPC_017) { Notebook.bNoteTwo017 = true; } if (sGuess2 == NPC_AI.NPC_018) { Notebook.bNoteTwo018 = true; } if (sGuess2 == NPC_AI.NPC_019) { Notebook.bNoteTwo019 = true; } if (sGuess2 == NPC_AI.NPC_020) { Notebook.bNoteTwo020 = true; }
                    if (sGuess2 == NPC_AI.NPC_021) { Notebook.bNoteTwo021 = true; } if (sGuess2 == NPC_AI.NPC_022) { Notebook.bNoteTwo022 = true; } if (sGuess2 == NPC_AI.NPC_023) { Notebook.bNoteTwo023 = true; } if (sGuess2 == NPC_AI.NPC_024) { Notebook.bNoteTwo024 = true; }
                    if (sGuess2 == NPC_AI.NPC_025) { Notebook.bNoteTwo025 = true; } if (sGuess2 == NPC_AI.NPC_026) { Notebook.bNoteTwo026 = true; } if (sGuess2 == NPC_AI.NPC_027) { Notebook.bNoteTwo027 = true; } if (sGuess2 == NPC_AI.NPC_028) { Notebook.bNoteTwo028 = true; }
                    if (sGuess2 == NPC_AI.NPC_029) { Notebook.bNoteTwo029 = true; } if (sGuess2 == NPC_AI.NPC_030) { Notebook.bNoteTwo030 = true; } if (sGuess2 == NPC_AI.NPC_031) { Notebook.bNoteTwo031 = true; } if (sGuess2 == NPC_AI.NPC_032) { Notebook.bNoteTwo032 = true; }
                    if (sGuess2 == NPC_AI.NPC_033) { Notebook.bNoteTwo033 = true; } if (sGuess2 == NPC_AI.NPC_034) { Notebook.bNoteTwo034 = true; } if (sGuess2 == NPC_AI.NPC_035) { Notebook.bNoteTwo035 = true; } if (sGuess2 == NPC_AI.NPC_036) { Notebook.bNoteTwo036 = true; }
                    if (sGuess2 == NPC_AI.NPC_037) { Notebook.bNoteTwo037 = true; } if (sGuess2 == NPC_AI.NPC_038) { Notebook.bNoteTwo038 = true; } if (sGuess2 == NPC_AI.NPC_039) { Notebook.bNoteTwo039 = true; } if (sGuess2 == NPC_AI.NPC_040) { Notebook.bNoteTwo040 = true; }
                    if (sGuess2 == NPC_AI.NPC_041) { Notebook.bNoteTwo041 = true; } if (sGuess2 == NPC_AI.NPC_042) { Notebook.bNoteTwo042 = true; } if (sGuess2 == NPC_AI.NPC_043) { Notebook.bNoteTwo043 = true; } if (sGuess2 == NPC_AI.NPC_044) { Notebook.bNoteTwo044 = true; }
                    if (sGuess2 == NPC_AI.NPC_045) { Notebook.bNoteTwo045 = true; } if (sGuess2 == NPC_AI.NPC_046) { Notebook.bNoteTwo046 = true; } if (sGuess2 == NPC_AI.NPC_047) { Notebook.bNoteTwo047 = true; } if (sGuess2 == NPC_AI.NPC_048) { Notebook.bNoteTwo048 = true; }
                    if (sGuess2 == NPC_AI.NPC_049) { Notebook.bNoteTwo049 = true; } if (sGuess2 == NPC_AI.NPC_050) { Notebook.bNoteTwo050 = true; } if (sGuess2 == NPC_AI.NPC_051) { Notebook.bNoteTwo051 = true; } if (sGuess2 == NPC_AI.NPC_052) { Notebook.bNoteTwo052 = true; }
                    if (sGuess2 == NPC_AI.NPC_053) { Notebook.bNoteTwo053 = true; } if (sGuess2 == NPC_AI.NPC_054) { Notebook.bNoteTwo054 = true; } if (sGuess2 == NPC_AI.NPC_055) { Notebook.bNoteTwo055 = true; } if (sGuess2 == NPC_AI.NPC_056) { Notebook.bNoteTwo056 = true; }
                    if (sGuess2 == NPC_AI.NPC_057) { Notebook.bNoteTwo057 = true; } if (sGuess2 == NPC_AI.NPC_058) { Notebook.bNoteTwo058 = true; } if (sGuess2 == NPC_AI.NPC_059) { Notebook.bNoteTwo059 = true; } if (sGuess2 == NPC_AI.NPC_060) { Notebook.bNoteTwo060 = true; }
                    if (sGuess2 == NPC_AI.NPC_061) { Notebook.bNoteTwo061 = true; } if (sGuess2 == NPC_AI.NPC_062) { Notebook.bNoteTwo062 = true; } if (sGuess2 == NPC_AI.NPC_063) { Notebook.bNoteTwo063 = true; } if (sGuess2 == NPC_AI.NPC_064) { Notebook.bNoteTwo064 = true; }
                    if (sGuess2 == NPC_AI.NPC_065) { Notebook.bNoteTwo065 = true; } if (sGuess2 == NPC_AI.NPC_066) { Notebook.bNoteTwo066 = true; } if (sGuess2 == NPC_AI.NPC_067) { Notebook.bNoteTwo067 = true; } if (sGuess2 == NPC_AI.NPC_068) { Notebook.bNoteTwo068 = true; }
                    if (sGuess2 == NPC_AI.NPC_069) { Notebook.bNoteTwo069 = true; } if (sGuess2 == NPC_AI.NPC_070) { Notebook.bNoteTwo070 = true; } if (sGuess2 == NPC_AI.NPC_071) { Notebook.bNoteTwo071 = true; } if (sGuess2 == NPC_AI.NPC_072) { Notebook.bNoteTwo072 = true; }
                    if (sGuess2 == NPC_AI.NPC_073) { Notebook.bNoteTwo073 = true; } if (sGuess2 == NPC_AI.NPC_074) { Notebook.bNoteTwo074 = true; } if (sGuess2 == NPC_AI.NPC_075) { Notebook.bNoteTwo075 = true; } if (sGuess2 == NPC_AI.NPC_076) { Notebook.bNoteTwo076 = true; }
                    if (sGuess2 == NPC_AI.NPC_077) { Notebook.bNoteTwo077 = true; } if (sGuess2 == NPC_AI.NPC_078) { Notebook.bNoteTwo078 = true; } if (sGuess2 == NPC_AI.NPC_079) { Notebook.bNoteTwo079 = true; } if (sGuess2 == NPC_AI.NPC_080) { Notebook.bNoteTwo080 = true; }
                    if (sGuess2 == NPC_AI.NPC_081) { Notebook.bNoteTwo081 = true; } if (sGuess2 == NPC_AI.NPC_082) { Notebook.bNoteTwo082 = true; } if (sGuess2 == NPC_AI.NPC_083) { Notebook.bNoteTwo083 = true; } if (sGuess2 == NPC_AI.NPC_084) { Notebook.bNoteTwo084 = true; }
                    if (sGuess2 == NPC_AI.NPC_085) { Notebook.bNoteTwo085 = true; } if (sGuess2 == NPC_AI.NPC_086) { Notebook.bNoteTwo086 = true; } if (sGuess2 == NPC_AI.NPC_087) { Notebook.bNoteTwo087 = true; } if (sGuess2 == NPC_AI.NPC_088) { Notebook.bNoteTwo088 = true; }
                    if (sGuess2 == NPC_AI.NPC_089) { Notebook.bNoteTwo089 = true; } if (sGuess2 == NPC_AI.NPC_090) { Notebook.bNoteTwo090 = true; } if (sGuess2 == NPC_AI.NPC_091) { Notebook.bNoteTwo091 = true; } if (sGuess2 == NPC_AI.NPC_092) { Notebook.bNoteTwo092 = true; }
                    if (sGuess2 == NPC_AI.NPC_093) { Notebook.bNoteTwo093 = true; } if (sGuess2 == NPC_AI.NPC_094) { Notebook.bNoteTwo094 = true; } if (sGuess2 == NPC_AI.NPC_095) { Notebook.bNoteTwo095 = true; } if (sGuess2 == NPC_AI.NPC_096) { Notebook.bNoteTwo096 = true; }
                    if (sGuess2 == NPC_AI.NPC_097) { Notebook.bNoteTwo097 = true; } if (sGuess2 == NPC_AI.NPC_098) { Notebook.bNoteTwo098 = true; } if (sGuess2 == NPC_AI.NPC_099) { Notebook.bNoteTwo099 = true; } if (sGuess2 == NPC_AI.NPC_100) { Notebook.bNoteTwo100 = true; }

                    if (sGuess3 == NPC_AI.NPC_001) { Notebook.bNoteTwo001 = true; } if (sGuess3 == NPC_AI.NPC_002) { Notebook.bNoteTwo002 = true; } if (sGuess3 == NPC_AI.NPC_003) { Notebook.bNoteTwo003 = true; } if (sGuess3 == NPC_AI.NPC_004) { Notebook.bNoteTwo004 = true; }
                    if (sGuess3 == NPC_AI.NPC_005) { Notebook.bNoteTwo005 = true; } if (sGuess3 == NPC_AI.NPC_006) { Notebook.bNoteTwo006 = true; } if (sGuess3 == NPC_AI.NPC_007) { Notebook.bNoteTwo007 = true; } if (sGuess3 == NPC_AI.NPC_008) { Notebook.bNoteTwo008 = true; }
                    if (sGuess3 == NPC_AI.NPC_009) { Notebook.bNoteTwo009 = true; } if (sGuess3 == NPC_AI.NPC_010) { Notebook.bNoteTwo010 = true; } if (sGuess3 == NPC_AI.NPC_011) { Notebook.bNoteTwo011 = true; } if (sGuess3 == NPC_AI.NPC_012) { Notebook.bNoteTwo012 = true; }
                    if (sGuess3 == NPC_AI.NPC_013) { Notebook.bNoteTwo013 = true; } if (sGuess3 == NPC_AI.NPC_014) { Notebook.bNoteTwo014 = true; } if (sGuess3 == NPC_AI.NPC_015) { Notebook.bNoteTwo015 = true; } if (sGuess3 == NPC_AI.NPC_016) { Notebook.bNoteTwo016 = true; }
                    if (sGuess3 == NPC_AI.NPC_017) { Notebook.bNoteTwo017 = true; } if (sGuess3 == NPC_AI.NPC_018) { Notebook.bNoteTwo018 = true; } if (sGuess3 == NPC_AI.NPC_019) { Notebook.bNoteTwo019 = true; } if (sGuess3 == NPC_AI.NPC_020) { Notebook.bNoteTwo020 = true; }
                    if (sGuess3 == NPC_AI.NPC_021) { Notebook.bNoteTwo021 = true; } if (sGuess3 == NPC_AI.NPC_022) { Notebook.bNoteTwo022 = true; } if (sGuess3 == NPC_AI.NPC_023) { Notebook.bNoteTwo023 = true; } if (sGuess3 == NPC_AI.NPC_024) { Notebook.bNoteTwo024 = true; }
                    if (sGuess3 == NPC_AI.NPC_025) { Notebook.bNoteTwo025 = true; } if (sGuess3 == NPC_AI.NPC_026) { Notebook.bNoteTwo026 = true; } if (sGuess3 == NPC_AI.NPC_027) { Notebook.bNoteTwo027 = true; } if (sGuess3 == NPC_AI.NPC_028) { Notebook.bNoteTwo028 = true; }
                    if (sGuess3 == NPC_AI.NPC_029) { Notebook.bNoteTwo029 = true; } if (sGuess3 == NPC_AI.NPC_030) { Notebook.bNoteTwo030 = true; } if (sGuess3 == NPC_AI.NPC_031) { Notebook.bNoteTwo031 = true; } if (sGuess3 == NPC_AI.NPC_032) { Notebook.bNoteTwo032 = true; }
                    if (sGuess3 == NPC_AI.NPC_033) { Notebook.bNoteTwo033 = true; } if (sGuess3 == NPC_AI.NPC_034) { Notebook.bNoteTwo034 = true; } if (sGuess3 == NPC_AI.NPC_035) { Notebook.bNoteTwo035 = true; } if (sGuess3 == NPC_AI.NPC_036) { Notebook.bNoteTwo036 = true; }
                    if (sGuess3 == NPC_AI.NPC_037) { Notebook.bNoteTwo037 = true; } if (sGuess3 == NPC_AI.NPC_038) { Notebook.bNoteTwo038 = true; } if (sGuess3 == NPC_AI.NPC_039) { Notebook.bNoteTwo039 = true; } if (sGuess3 == NPC_AI.NPC_040) { Notebook.bNoteTwo040 = true; }
                    if (sGuess3 == NPC_AI.NPC_041) { Notebook.bNoteTwo041 = true; } if (sGuess3 == NPC_AI.NPC_042) { Notebook.bNoteTwo042 = true; } if (sGuess3 == NPC_AI.NPC_043) { Notebook.bNoteTwo043 = true; } if (sGuess3 == NPC_AI.NPC_044) { Notebook.bNoteTwo044 = true; }
                    if (sGuess3 == NPC_AI.NPC_045) { Notebook.bNoteTwo045 = true; } if (sGuess3 == NPC_AI.NPC_046) { Notebook.bNoteTwo046 = true; } if (sGuess3 == NPC_AI.NPC_047) { Notebook.bNoteTwo047 = true; } if (sGuess3 == NPC_AI.NPC_048) { Notebook.bNoteTwo048 = true; }
                    if (sGuess3 == NPC_AI.NPC_049) { Notebook.bNoteTwo049 = true; } if (sGuess3 == NPC_AI.NPC_050) { Notebook.bNoteTwo050 = true; } if (sGuess3 == NPC_AI.NPC_051) { Notebook.bNoteTwo051 = true; } if (sGuess3 == NPC_AI.NPC_052) { Notebook.bNoteTwo052 = true; }
                    if (sGuess3 == NPC_AI.NPC_053) { Notebook.bNoteTwo053 = true; } if (sGuess3 == NPC_AI.NPC_054) { Notebook.bNoteTwo054 = true; } if (sGuess3 == NPC_AI.NPC_055) { Notebook.bNoteTwo055 = true; } if (sGuess3 == NPC_AI.NPC_056) { Notebook.bNoteTwo056 = true; }
                    if (sGuess3 == NPC_AI.NPC_057) { Notebook.bNoteTwo057 = true; } if (sGuess3 == NPC_AI.NPC_058) { Notebook.bNoteTwo058 = true; } if (sGuess3 == NPC_AI.NPC_059) { Notebook.bNoteTwo059 = true; } if (sGuess3 == NPC_AI.NPC_060) { Notebook.bNoteTwo060 = true; }
                    if (sGuess3 == NPC_AI.NPC_061) { Notebook.bNoteTwo061 = true; } if (sGuess3 == NPC_AI.NPC_062) { Notebook.bNoteTwo062 = true; } if (sGuess3 == NPC_AI.NPC_063) { Notebook.bNoteTwo063 = true; } if (sGuess3 == NPC_AI.NPC_064) { Notebook.bNoteTwo064 = true; }
                    if (sGuess3 == NPC_AI.NPC_065) { Notebook.bNoteTwo065 = true; } if (sGuess3 == NPC_AI.NPC_066) { Notebook.bNoteTwo066 = true; } if (sGuess3 == NPC_AI.NPC_067) { Notebook.bNoteTwo067 = true; } if (sGuess3 == NPC_AI.NPC_068) { Notebook.bNoteTwo068 = true; }
                    if (sGuess3 == NPC_AI.NPC_069) { Notebook.bNoteTwo069 = true; } if (sGuess3 == NPC_AI.NPC_070) { Notebook.bNoteTwo070 = true; } if (sGuess3 == NPC_AI.NPC_071) { Notebook.bNoteTwo071 = true; } if (sGuess3 == NPC_AI.NPC_072) { Notebook.bNoteTwo072 = true; }
                    if (sGuess3 == NPC_AI.NPC_073) { Notebook.bNoteTwo073 = true; } if (sGuess3 == NPC_AI.NPC_074) { Notebook.bNoteTwo074 = true; } if (sGuess3 == NPC_AI.NPC_075) { Notebook.bNoteTwo075 = true; } if (sGuess3 == NPC_AI.NPC_076) { Notebook.bNoteTwo076 = true; }
                    if (sGuess3 == NPC_AI.NPC_077) { Notebook.bNoteTwo077 = true; } if (sGuess3 == NPC_AI.NPC_078) { Notebook.bNoteTwo078 = true; } if (sGuess3 == NPC_AI.NPC_079) { Notebook.bNoteTwo079 = true; } if (sGuess3 == NPC_AI.NPC_080) { Notebook.bNoteTwo080 = true; }
                    if (sGuess3 == NPC_AI.NPC_081) { Notebook.bNoteTwo081 = true; } if (sGuess3 == NPC_AI.NPC_082) { Notebook.bNoteTwo082 = true; } if (sGuess3 == NPC_AI.NPC_083) { Notebook.bNoteTwo083 = true; } if (sGuess3 == NPC_AI.NPC_084) { Notebook.bNoteTwo084 = true; }
                    if (sGuess3 == NPC_AI.NPC_085) { Notebook.bNoteTwo085 = true; } if (sGuess3 == NPC_AI.NPC_086) { Notebook.bNoteTwo086 = true; } if (sGuess3 == NPC_AI.NPC_087) { Notebook.bNoteTwo087 = true; } if (sGuess3 == NPC_AI.NPC_088) { Notebook.bNoteTwo088 = true; }
                    if (sGuess3 == NPC_AI.NPC_089) { Notebook.bNoteTwo089 = true; } if (sGuess3 == NPC_AI.NPC_090) { Notebook.bNoteTwo090 = true; } if (sGuess3 == NPC_AI.NPC_091) { Notebook.bNoteTwo091 = true; } if (sGuess3 == NPC_AI.NPC_092) { Notebook.bNoteTwo092 = true; }
                    if (sGuess3 == NPC_AI.NPC_093) { Notebook.bNoteTwo093 = true; } if (sGuess3 == NPC_AI.NPC_094) { Notebook.bNoteTwo094 = true; } if (sGuess3 == NPC_AI.NPC_095) { Notebook.bNoteTwo095 = true; } if (sGuess3 == NPC_AI.NPC_096) { Notebook.bNoteTwo096 = true; }
                    if (sGuess3 == NPC_AI.NPC_097) { Notebook.bNoteTwo097 = true; } if (sGuess3 == NPC_AI.NPC_098) { Notebook.bNoteTwo098 = true; } if (sGuess3 == NPC_AI.NPC_099) { Notebook.bNoteTwo099 = true; } if (sGuess3 == NPC_AI.NPC_100) { Notebook.bNoteTwo100 = true; }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIP: Any new information has been added to your notebook.");
                }

                if (sQueriedTrait == sTrait200 || sQueriedTrait == sTrait201 || sQueriedTrait == sTrait202 || sQueriedTrait == sTrait203 || sQueriedTrait == sTrait204 ||
                sQueriedTrait == sTrait205 || sQueriedTrait == sTrait206 || sQueriedTrait == sTrait207 || sQueriedTrait == sTrait208 || sQueriedTrait == sTrait209 ||
                sQueriedTrait == sTrait210 || sQueriedTrait == sTrait211 || sQueriedTrait == sTrait212 || sQueriedTrait == sTrait213 || sQueriedTrait == sTrait214 ||
                sQueriedTrait == TraitThreeBunny)
                {
                    sGuess1 = "null"; sGuess2 = "null"; sGuess3 = "null";
                    if (Lists.TierThreeTraits.Count > 0)
                    {
                        iGuess01 = rand.Next(Lists.TierThreeTraits.Count);
                        sGuess1 = Lists.TierThreeTraits[iGuess01];
                        Lists.TierThreeTraits.RemoveAt(iGuess01);
                        // iNumberofSomeones = 1;
                    }
                    int iKnowSomeone = Program.rand.Next(1, 11);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (iKnowSomeone >= 8)
                    {
                        { Console.WriteLine("I can think of one person who I'd say that about. That would be " + sGuess1 + ".'"); }
                    }
                    if (iKnowSomeone <= 7)
                    {
                        Console.WriteLine("Well, isn't that a strange question to ask. Aren't we all like that at one");
                        Console.WriteLine("time or another? What do you want me to say? I don't have an answer.'");
                    }
                    if (sGuess1 == NPC_AI.NPC_001) { Notebook.bNoteThree001 = true; } if (sGuess1 == NPC_AI.NPC_002) { Notebook.bNoteThree002 = true; } if (sGuess1 == NPC_AI.NPC_003) { Notebook.bNoteThree003 = true; } if (sGuess1 == NPC_AI.NPC_004) { Notebook.bNoteThree004 = true; }
                    if (sGuess1 == NPC_AI.NPC_005) { Notebook.bNoteThree005 = true; } if (sGuess1 == NPC_AI.NPC_006) { Notebook.bNoteThree006 = true; } if (sGuess1 == NPC_AI.NPC_007) { Notebook.bNoteThree007 = true; } if (sGuess1 == NPC_AI.NPC_008) { Notebook.bNoteThree008 = true; }
                    if (sGuess1 == NPC_AI.NPC_009) { Notebook.bNoteThree009 = true; } if (sGuess1 == NPC_AI.NPC_010) { Notebook.bNoteThree010 = true; } if (sGuess1 == NPC_AI.NPC_011) { Notebook.bNoteThree011 = true; } if (sGuess1 == NPC_AI.NPC_012) { Notebook.bNoteThree012 = true; }
                    if (sGuess1 == NPC_AI.NPC_013) { Notebook.bNoteThree013 = true; } if (sGuess1 == NPC_AI.NPC_014) { Notebook.bNoteThree014 = true; } if (sGuess1 == NPC_AI.NPC_015) { Notebook.bNoteThree015 = true; } if (sGuess1 == NPC_AI.NPC_016) { Notebook.bNoteThree016 = true; }
                    if (sGuess1 == NPC_AI.NPC_017) { Notebook.bNoteThree017 = true; } if (sGuess1 == NPC_AI.NPC_018) { Notebook.bNoteThree018 = true; } if (sGuess1 == NPC_AI.NPC_019) { Notebook.bNoteThree019 = true; } if (sGuess1 == NPC_AI.NPC_020) { Notebook.bNoteThree020 = true; }
                    if (sGuess1 == NPC_AI.NPC_021) { Notebook.bNoteThree021 = true; } if (sGuess1 == NPC_AI.NPC_022) { Notebook.bNoteThree022 = true; } if (sGuess1 == NPC_AI.NPC_023) { Notebook.bNoteThree023 = true; } if (sGuess1 == NPC_AI.NPC_024) { Notebook.bNoteThree024 = true; }
                    if (sGuess1 == NPC_AI.NPC_025) { Notebook.bNoteThree025 = true; } if (sGuess1 == NPC_AI.NPC_026) { Notebook.bNoteThree026 = true; } if (sGuess1 == NPC_AI.NPC_027) { Notebook.bNoteThree027 = true; } if (sGuess1 == NPC_AI.NPC_028) { Notebook.bNoteThree028 = true; }
                    if (sGuess1 == NPC_AI.NPC_029) { Notebook.bNoteThree029 = true; } if (sGuess1 == NPC_AI.NPC_030) { Notebook.bNoteThree030 = true; } if (sGuess1 == NPC_AI.NPC_031) { Notebook.bNoteThree031 = true; } if (sGuess1 == NPC_AI.NPC_032) { Notebook.bNoteThree032 = true; }
                    if (sGuess1 == NPC_AI.NPC_033) { Notebook.bNoteThree033 = true; } if (sGuess1 == NPC_AI.NPC_034) { Notebook.bNoteThree034 = true; } if (sGuess1 == NPC_AI.NPC_035) { Notebook.bNoteThree035 = true; } if (sGuess1 == NPC_AI.NPC_036) { Notebook.bNoteThree036 = true; }
                    if (sGuess1 == NPC_AI.NPC_037) { Notebook.bNoteThree037 = true; } if (sGuess1 == NPC_AI.NPC_038) { Notebook.bNoteThree038 = true; } if (sGuess1 == NPC_AI.NPC_039) { Notebook.bNoteThree039 = true; } if (sGuess1 == NPC_AI.NPC_040) { Notebook.bNoteThree040 = true; }
                    if (sGuess1 == NPC_AI.NPC_041) { Notebook.bNoteThree041 = true; } if (sGuess1 == NPC_AI.NPC_042) { Notebook.bNoteThree042 = true; } if (sGuess1 == NPC_AI.NPC_043) { Notebook.bNoteThree043 = true; } if (sGuess1 == NPC_AI.NPC_044) { Notebook.bNoteThree044 = true; }
                    if (sGuess1 == NPC_AI.NPC_045) { Notebook.bNoteThree045 = true; } if (sGuess1 == NPC_AI.NPC_046) { Notebook.bNoteThree046 = true; } if (sGuess1 == NPC_AI.NPC_047) { Notebook.bNoteThree047 = true; } if (sGuess1 == NPC_AI.NPC_048) { Notebook.bNoteThree048 = true; }
                    if (sGuess1 == NPC_AI.NPC_049) { Notebook.bNoteThree049 = true; } if (sGuess1 == NPC_AI.NPC_050) { Notebook.bNoteThree050 = true; } if (sGuess1 == NPC_AI.NPC_051) { Notebook.bNoteThree051 = true; } if (sGuess1 == NPC_AI.NPC_052) { Notebook.bNoteThree052 = true; }
                    if (sGuess1 == NPC_AI.NPC_053) { Notebook.bNoteThree053 = true; } if (sGuess1 == NPC_AI.NPC_054) { Notebook.bNoteThree054 = true; } if (sGuess1 == NPC_AI.NPC_055) { Notebook.bNoteThree055 = true; } if (sGuess1 == NPC_AI.NPC_056) { Notebook.bNoteThree056 = true; }
                    if (sGuess1 == NPC_AI.NPC_057) { Notebook.bNoteThree057 = true; } if (sGuess1 == NPC_AI.NPC_058) { Notebook.bNoteThree058 = true; } if (sGuess1 == NPC_AI.NPC_059) { Notebook.bNoteThree059 = true; } if (sGuess1 == NPC_AI.NPC_060) { Notebook.bNoteThree060 = true; }
                    if (sGuess1 == NPC_AI.NPC_061) { Notebook.bNoteThree061 = true; } if (sGuess1 == NPC_AI.NPC_062) { Notebook.bNoteThree062 = true; } if (sGuess1 == NPC_AI.NPC_063) { Notebook.bNoteThree063 = true; } if (sGuess1 == NPC_AI.NPC_064) { Notebook.bNoteThree064 = true; }
                    if (sGuess1 == NPC_AI.NPC_065) { Notebook.bNoteThree065 = true; } if (sGuess1 == NPC_AI.NPC_066) { Notebook.bNoteThree066 = true; } if (sGuess1 == NPC_AI.NPC_067) { Notebook.bNoteThree067 = true; } if (sGuess1 == NPC_AI.NPC_068) { Notebook.bNoteThree068 = true; }
                    if (sGuess1 == NPC_AI.NPC_069) { Notebook.bNoteThree069 = true; } if (sGuess1 == NPC_AI.NPC_070) { Notebook.bNoteThree070 = true; } if (sGuess1 == NPC_AI.NPC_071) { Notebook.bNoteThree071 = true; } if (sGuess1 == NPC_AI.NPC_072) { Notebook.bNoteThree072 = true; }
                    if (sGuess1 == NPC_AI.NPC_073) { Notebook.bNoteThree073 = true; } if (sGuess1 == NPC_AI.NPC_074) { Notebook.bNoteThree074 = true; } if (sGuess1 == NPC_AI.NPC_075) { Notebook.bNoteThree075 = true; } if (sGuess1 == NPC_AI.NPC_076) { Notebook.bNoteThree076 = true; }
                    if (sGuess1 == NPC_AI.NPC_077) { Notebook.bNoteThree077 = true; } if (sGuess1 == NPC_AI.NPC_078) { Notebook.bNoteThree078 = true; } if (sGuess1 == NPC_AI.NPC_079) { Notebook.bNoteThree079 = true; } if (sGuess1 == NPC_AI.NPC_080) { Notebook.bNoteThree080 = true; }
                    if (sGuess1 == NPC_AI.NPC_081) { Notebook.bNoteThree081 = true; } if (sGuess1 == NPC_AI.NPC_082) { Notebook.bNoteThree082 = true; } if (sGuess1 == NPC_AI.NPC_083) { Notebook.bNoteThree083 = true; } if (sGuess1 == NPC_AI.NPC_084) { Notebook.bNoteThree084 = true; }
                    if (sGuess1 == NPC_AI.NPC_085) { Notebook.bNoteThree085 = true; } if (sGuess1 == NPC_AI.NPC_086) { Notebook.bNoteThree086 = true; } if (sGuess1 == NPC_AI.NPC_087) { Notebook.bNoteThree087 = true; } if (sGuess1 == NPC_AI.NPC_088) { Notebook.bNoteThree088 = true; }
                    if (sGuess1 == NPC_AI.NPC_089) { Notebook.bNoteThree089 = true; } if (sGuess1 == NPC_AI.NPC_090) { Notebook.bNoteThree090 = true; } if (sGuess1 == NPC_AI.NPC_091) { Notebook.bNoteThree091 = true; } if (sGuess1 == NPC_AI.NPC_092) { Notebook.bNoteThree092 = true; }
                    if (sGuess1 == NPC_AI.NPC_093) { Notebook.bNoteThree093 = true; } if (sGuess1 == NPC_AI.NPC_094) { Notebook.bNoteThree094 = true; } if (sGuess1 == NPC_AI.NPC_095) { Notebook.bNoteThree095 = true; } if (sGuess1 == NPC_AI.NPC_096) { Notebook.bNoteThree096 = true; }
                    if (sGuess1 == NPC_AI.NPC_097) { Notebook.bNoteThree097 = true; } if (sGuess1 == NPC_AI.NPC_098) { Notebook.bNoteThree098 = true; } if (sGuess1 == NPC_AI.NPC_099) { Notebook.bNoteThree099 = true; } if (sGuess1 == NPC_AI.NPC_100) { Notebook.bNoteThree100 = true; }

                    if (sGuess2 == NPC_AI.NPC_001) { Notebook.bNoteThree001 = true; } if (sGuess2 == NPC_AI.NPC_002) { Notebook.bNoteThree002 = true; } if (sGuess2 == NPC_AI.NPC_003) { Notebook.bNoteThree003 = true; } if (sGuess2 == NPC_AI.NPC_004) { Notebook.bNoteThree004 = true; }
                    if (sGuess2 == NPC_AI.NPC_005) { Notebook.bNoteThree005 = true; } if (sGuess2 == NPC_AI.NPC_006) { Notebook.bNoteThree006 = true; } if (sGuess2 == NPC_AI.NPC_007) { Notebook.bNoteThree007 = true; } if (sGuess2 == NPC_AI.NPC_008) { Notebook.bNoteThree008 = true; }
                    if (sGuess2 == NPC_AI.NPC_009) { Notebook.bNoteThree009 = true; } if (sGuess2 == NPC_AI.NPC_010) { Notebook.bNoteThree010 = true; } if (sGuess2 == NPC_AI.NPC_011) { Notebook.bNoteThree011 = true; } if (sGuess2 == NPC_AI.NPC_012) { Notebook.bNoteThree012 = true; }
                    if (sGuess2 == NPC_AI.NPC_013) { Notebook.bNoteThree013 = true; } if (sGuess2 == NPC_AI.NPC_014) { Notebook.bNoteThree014 = true; } if (sGuess2 == NPC_AI.NPC_015) { Notebook.bNoteThree015 = true; } if (sGuess2 == NPC_AI.NPC_016) { Notebook.bNoteThree016 = true; }
                    if (sGuess2 == NPC_AI.NPC_017) { Notebook.bNoteThree017 = true; } if (sGuess2 == NPC_AI.NPC_018) { Notebook.bNoteThree018 = true; } if (sGuess2 == NPC_AI.NPC_019) { Notebook.bNoteThree019 = true; } if (sGuess2 == NPC_AI.NPC_020) { Notebook.bNoteThree020 = true; }
                    if (sGuess2 == NPC_AI.NPC_021) { Notebook.bNoteThree021 = true; } if (sGuess2 == NPC_AI.NPC_022) { Notebook.bNoteThree022 = true; } if (sGuess2 == NPC_AI.NPC_023) { Notebook.bNoteThree023 = true; } if (sGuess2 == NPC_AI.NPC_024) { Notebook.bNoteThree024 = true; }
                    if (sGuess2 == NPC_AI.NPC_025) { Notebook.bNoteThree025 = true; } if (sGuess2 == NPC_AI.NPC_026) { Notebook.bNoteThree026 = true; } if (sGuess2 == NPC_AI.NPC_027) { Notebook.bNoteThree027 = true; } if (sGuess2 == NPC_AI.NPC_028) { Notebook.bNoteThree028 = true; }
                    if (sGuess2 == NPC_AI.NPC_029) { Notebook.bNoteThree029 = true; } if (sGuess2 == NPC_AI.NPC_030) { Notebook.bNoteThree030 = true; } if (sGuess2 == NPC_AI.NPC_031) { Notebook.bNoteThree031 = true; } if (sGuess2 == NPC_AI.NPC_032) { Notebook.bNoteThree032 = true; }
                    if (sGuess2 == NPC_AI.NPC_033) { Notebook.bNoteThree033 = true; } if (sGuess2 == NPC_AI.NPC_034) { Notebook.bNoteThree034 = true; } if (sGuess2 == NPC_AI.NPC_035) { Notebook.bNoteThree035 = true; } if (sGuess2 == NPC_AI.NPC_036) { Notebook.bNoteThree036 = true; }
                    if (sGuess2 == NPC_AI.NPC_037) { Notebook.bNoteThree037 = true; } if (sGuess2 == NPC_AI.NPC_038) { Notebook.bNoteThree038 = true; } if (sGuess2 == NPC_AI.NPC_039) { Notebook.bNoteThree039 = true; } if (sGuess2 == NPC_AI.NPC_040) { Notebook.bNoteThree040 = true; }
                    if (sGuess2 == NPC_AI.NPC_041) { Notebook.bNoteThree041 = true; } if (sGuess2 == NPC_AI.NPC_042) { Notebook.bNoteThree042 = true; } if (sGuess2 == NPC_AI.NPC_043) { Notebook.bNoteThree043 = true; } if (sGuess2 == NPC_AI.NPC_044) { Notebook.bNoteThree044 = true; }
                    if (sGuess2 == NPC_AI.NPC_045) { Notebook.bNoteThree045 = true; } if (sGuess2 == NPC_AI.NPC_046) { Notebook.bNoteThree046 = true; } if (sGuess2 == NPC_AI.NPC_047) { Notebook.bNoteThree047 = true; } if (sGuess2 == NPC_AI.NPC_048) { Notebook.bNoteThree048 = true; }
                    if (sGuess2 == NPC_AI.NPC_049) { Notebook.bNoteThree049 = true; } if (sGuess2 == NPC_AI.NPC_050) { Notebook.bNoteThree050 = true; } if (sGuess2 == NPC_AI.NPC_051) { Notebook.bNoteThree051 = true; } if (sGuess2 == NPC_AI.NPC_052) { Notebook.bNoteThree052 = true; }
                    if (sGuess2 == NPC_AI.NPC_053) { Notebook.bNoteThree053 = true; } if (sGuess2 == NPC_AI.NPC_054) { Notebook.bNoteThree054 = true; } if (sGuess2 == NPC_AI.NPC_055) { Notebook.bNoteThree055 = true; } if (sGuess2 == NPC_AI.NPC_056) { Notebook.bNoteThree056 = true; }
                    if (sGuess2 == NPC_AI.NPC_057) { Notebook.bNoteThree057 = true; } if (sGuess2 == NPC_AI.NPC_058) { Notebook.bNoteThree058 = true; } if (sGuess2 == NPC_AI.NPC_059) { Notebook.bNoteThree059 = true; } if (sGuess2 == NPC_AI.NPC_060) { Notebook.bNoteThree060 = true; }
                    if (sGuess2 == NPC_AI.NPC_061) { Notebook.bNoteThree061 = true; } if (sGuess2 == NPC_AI.NPC_062) { Notebook.bNoteThree062 = true; } if (sGuess2 == NPC_AI.NPC_063) { Notebook.bNoteThree063 = true; } if (sGuess2 == NPC_AI.NPC_064) { Notebook.bNoteThree064 = true; }
                    if (sGuess2 == NPC_AI.NPC_065) { Notebook.bNoteThree065 = true; } if (sGuess2 == NPC_AI.NPC_066) { Notebook.bNoteThree066 = true; } if (sGuess2 == NPC_AI.NPC_067) { Notebook.bNoteThree067 = true; } if (sGuess2 == NPC_AI.NPC_068) { Notebook.bNoteThree068 = true; }
                    if (sGuess2 == NPC_AI.NPC_069) { Notebook.bNoteThree069 = true; } if (sGuess2 == NPC_AI.NPC_070) { Notebook.bNoteThree070 = true; } if (sGuess2 == NPC_AI.NPC_071) { Notebook.bNoteThree071 = true; } if (sGuess2 == NPC_AI.NPC_072) { Notebook.bNoteThree072 = true; }
                    if (sGuess2 == NPC_AI.NPC_073) { Notebook.bNoteThree073 = true; } if (sGuess2 == NPC_AI.NPC_074) { Notebook.bNoteThree074 = true; } if (sGuess2 == NPC_AI.NPC_075) { Notebook.bNoteThree075 = true; } if (sGuess2 == NPC_AI.NPC_076) { Notebook.bNoteThree076 = true; }
                    if (sGuess2 == NPC_AI.NPC_077) { Notebook.bNoteThree077 = true; } if (sGuess2 == NPC_AI.NPC_078) { Notebook.bNoteThree078 = true; } if (sGuess2 == NPC_AI.NPC_079) { Notebook.bNoteThree079 = true; } if (sGuess2 == NPC_AI.NPC_080) { Notebook.bNoteThree080 = true; }
                    if (sGuess2 == NPC_AI.NPC_081) { Notebook.bNoteThree081 = true; } if (sGuess2 == NPC_AI.NPC_082) { Notebook.bNoteThree082 = true; } if (sGuess2 == NPC_AI.NPC_083) { Notebook.bNoteThree083 = true; } if (sGuess2 == NPC_AI.NPC_084) { Notebook.bNoteThree084 = true; }
                    if (sGuess2 == NPC_AI.NPC_085) { Notebook.bNoteThree085 = true; } if (sGuess2 == NPC_AI.NPC_086) { Notebook.bNoteThree086 = true; } if (sGuess2 == NPC_AI.NPC_087) { Notebook.bNoteThree087 = true; } if (sGuess2 == NPC_AI.NPC_088) { Notebook.bNoteThree088 = true; }
                    if (sGuess2 == NPC_AI.NPC_089) { Notebook.bNoteThree089 = true; } if (sGuess2 == NPC_AI.NPC_090) { Notebook.bNoteThree090 = true; } if (sGuess2 == NPC_AI.NPC_091) { Notebook.bNoteThree091 = true; } if (sGuess2 == NPC_AI.NPC_092) { Notebook.bNoteThree092 = true; }
                    if (sGuess2 == NPC_AI.NPC_093) { Notebook.bNoteThree093 = true; } if (sGuess2 == NPC_AI.NPC_094) { Notebook.bNoteThree094 = true; } if (sGuess2 == NPC_AI.NPC_095) { Notebook.bNoteThree095 = true; } if (sGuess2 == NPC_AI.NPC_096) { Notebook.bNoteThree096 = true; }
                    if (sGuess2 == NPC_AI.NPC_097) { Notebook.bNoteThree097 = true; } if (sGuess2 == NPC_AI.NPC_098) { Notebook.bNoteThree098 = true; } if (sGuess2 == NPC_AI.NPC_099) { Notebook.bNoteThree099 = true; } if (sGuess2 == NPC_AI.NPC_100) { Notebook.bNoteThree100 = true; }

                    if (sGuess3 == NPC_AI.NPC_001) { Notebook.bNoteThree001 = true; } if (sGuess3 == NPC_AI.NPC_002) { Notebook.bNoteThree002 = true; } if (sGuess3 == NPC_AI.NPC_003) { Notebook.bNoteThree003 = true; } if (sGuess3 == NPC_AI.NPC_004) { Notebook.bNoteThree004 = true; }
                    if (sGuess3 == NPC_AI.NPC_005) { Notebook.bNoteThree005 = true; } if (sGuess3 == NPC_AI.NPC_006) { Notebook.bNoteThree006 = true; } if (sGuess3 == NPC_AI.NPC_007) { Notebook.bNoteThree007 = true; } if (sGuess3 == NPC_AI.NPC_008) { Notebook.bNoteThree008 = true; }
                    if (sGuess3 == NPC_AI.NPC_009) { Notebook.bNoteThree009 = true; } if (sGuess3 == NPC_AI.NPC_010) { Notebook.bNoteThree010 = true; } if (sGuess3 == NPC_AI.NPC_011) { Notebook.bNoteThree011 = true; } if (sGuess3 == NPC_AI.NPC_012) { Notebook.bNoteThree012 = true; }
                    if (sGuess3 == NPC_AI.NPC_013) { Notebook.bNoteThree013 = true; } if (sGuess3 == NPC_AI.NPC_014) { Notebook.bNoteThree014 = true; } if (sGuess3 == NPC_AI.NPC_015) { Notebook.bNoteThree015 = true; } if (sGuess3 == NPC_AI.NPC_016) { Notebook.bNoteThree016 = true; }
                    if (sGuess3 == NPC_AI.NPC_017) { Notebook.bNoteThree017 = true; } if (sGuess3 == NPC_AI.NPC_018) { Notebook.bNoteThree018 = true; } if (sGuess3 == NPC_AI.NPC_019) { Notebook.bNoteThree019 = true; } if (sGuess3 == NPC_AI.NPC_020) { Notebook.bNoteThree020 = true; }
                    if (sGuess3 == NPC_AI.NPC_021) { Notebook.bNoteThree021 = true; } if (sGuess3 == NPC_AI.NPC_022) { Notebook.bNoteThree022 = true; } if (sGuess3 == NPC_AI.NPC_023) { Notebook.bNoteThree023 = true; } if (sGuess3 == NPC_AI.NPC_024) { Notebook.bNoteThree024 = true; }
                    if (sGuess3 == NPC_AI.NPC_025) { Notebook.bNoteThree025 = true; } if (sGuess3 == NPC_AI.NPC_026) { Notebook.bNoteThree026 = true; } if (sGuess3 == NPC_AI.NPC_027) { Notebook.bNoteThree027 = true; } if (sGuess3 == NPC_AI.NPC_028) { Notebook.bNoteThree028 = true; }
                    if (sGuess3 == NPC_AI.NPC_029) { Notebook.bNoteThree029 = true; } if (sGuess3 == NPC_AI.NPC_030) { Notebook.bNoteThree030 = true; } if (sGuess3 == NPC_AI.NPC_031) { Notebook.bNoteThree031 = true; } if (sGuess3 == NPC_AI.NPC_032) { Notebook.bNoteThree032 = true; }
                    if (sGuess3 == NPC_AI.NPC_033) { Notebook.bNoteThree033 = true; } if (sGuess3 == NPC_AI.NPC_034) { Notebook.bNoteThree034 = true; } if (sGuess3 == NPC_AI.NPC_035) { Notebook.bNoteThree035 = true; } if (sGuess3 == NPC_AI.NPC_036) { Notebook.bNoteThree036 = true; }
                    if (sGuess3 == NPC_AI.NPC_037) { Notebook.bNoteThree037 = true; } if (sGuess3 == NPC_AI.NPC_038) { Notebook.bNoteThree038 = true; } if (sGuess3 == NPC_AI.NPC_039) { Notebook.bNoteThree039 = true; } if (sGuess3 == NPC_AI.NPC_040) { Notebook.bNoteThree040 = true; }
                    if (sGuess3 == NPC_AI.NPC_041) { Notebook.bNoteThree041 = true; } if (sGuess3 == NPC_AI.NPC_042) { Notebook.bNoteThree042 = true; } if (sGuess3 == NPC_AI.NPC_043) { Notebook.bNoteThree043 = true; } if (sGuess3 == NPC_AI.NPC_044) { Notebook.bNoteThree044 = true; }
                    if (sGuess3 == NPC_AI.NPC_045) { Notebook.bNoteThree045 = true; } if (sGuess3 == NPC_AI.NPC_046) { Notebook.bNoteThree046 = true; } if (sGuess3 == NPC_AI.NPC_047) { Notebook.bNoteThree047 = true; } if (sGuess3 == NPC_AI.NPC_048) { Notebook.bNoteThree048 = true; }
                    if (sGuess3 == NPC_AI.NPC_049) { Notebook.bNoteThree049 = true; } if (sGuess3 == NPC_AI.NPC_050) { Notebook.bNoteThree050 = true; } if (sGuess3 == NPC_AI.NPC_051) { Notebook.bNoteThree051 = true; } if (sGuess3 == NPC_AI.NPC_052) { Notebook.bNoteThree052 = true; }
                    if (sGuess3 == NPC_AI.NPC_053) { Notebook.bNoteThree053 = true; } if (sGuess3 == NPC_AI.NPC_054) { Notebook.bNoteThree054 = true; } if (sGuess3 == NPC_AI.NPC_055) { Notebook.bNoteThree055 = true; } if (sGuess3 == NPC_AI.NPC_056) { Notebook.bNoteThree056 = true; }
                    if (sGuess3 == NPC_AI.NPC_057) { Notebook.bNoteThree057 = true; } if (sGuess3 == NPC_AI.NPC_058) { Notebook.bNoteThree058 = true; } if (sGuess3 == NPC_AI.NPC_059) { Notebook.bNoteThree059 = true; } if (sGuess3 == NPC_AI.NPC_060) { Notebook.bNoteThree060 = true; }
                    if (sGuess3 == NPC_AI.NPC_061) { Notebook.bNoteThree061 = true; } if (sGuess3 == NPC_AI.NPC_062) { Notebook.bNoteThree062 = true; } if (sGuess3 == NPC_AI.NPC_063) { Notebook.bNoteThree063 = true; } if (sGuess3 == NPC_AI.NPC_064) { Notebook.bNoteThree064 = true; }
                    if (sGuess3 == NPC_AI.NPC_065) { Notebook.bNoteThree065 = true; } if (sGuess3 == NPC_AI.NPC_066) { Notebook.bNoteThree066 = true; } if (sGuess3 == NPC_AI.NPC_067) { Notebook.bNoteThree067 = true; } if (sGuess3 == NPC_AI.NPC_068) { Notebook.bNoteThree068 = true; }
                    if (sGuess3 == NPC_AI.NPC_069) { Notebook.bNoteThree069 = true; } if (sGuess3 == NPC_AI.NPC_070) { Notebook.bNoteThree070 = true; } if (sGuess3 == NPC_AI.NPC_071) { Notebook.bNoteThree071 = true; } if (sGuess3 == NPC_AI.NPC_072) { Notebook.bNoteThree072 = true; }
                    if (sGuess3 == NPC_AI.NPC_073) { Notebook.bNoteThree073 = true; } if (sGuess3 == NPC_AI.NPC_074) { Notebook.bNoteThree074 = true; } if (sGuess3 == NPC_AI.NPC_075) { Notebook.bNoteThree075 = true; } if (sGuess3 == NPC_AI.NPC_076) { Notebook.bNoteThree076 = true; }
                    if (sGuess3 == NPC_AI.NPC_077) { Notebook.bNoteThree077 = true; } if (sGuess3 == NPC_AI.NPC_078) { Notebook.bNoteThree078 = true; } if (sGuess3 == NPC_AI.NPC_079) { Notebook.bNoteThree079 = true; } if (sGuess3 == NPC_AI.NPC_080) { Notebook.bNoteThree080 = true; }
                    if (sGuess3 == NPC_AI.NPC_081) { Notebook.bNoteThree081 = true; } if (sGuess3 == NPC_AI.NPC_082) { Notebook.bNoteThree082 = true; } if (sGuess3 == NPC_AI.NPC_083) { Notebook.bNoteThree083 = true; } if (sGuess3 == NPC_AI.NPC_084) { Notebook.bNoteThree084 = true; }
                    if (sGuess3 == NPC_AI.NPC_085) { Notebook.bNoteThree085 = true; } if (sGuess3 == NPC_AI.NPC_086) { Notebook.bNoteThree086 = true; } if (sGuess3 == NPC_AI.NPC_087) { Notebook.bNoteThree087 = true; } if (sGuess3 == NPC_AI.NPC_088) { Notebook.bNoteThree088 = true; }
                    if (sGuess3 == NPC_AI.NPC_089) { Notebook.bNoteThree089 = true; } if (sGuess3 == NPC_AI.NPC_090) { Notebook.bNoteThree090 = true; } if (sGuess3 == NPC_AI.NPC_091) { Notebook.bNoteThree091 = true; } if (sGuess3 == NPC_AI.NPC_092) { Notebook.bNoteThree092 = true; }
                    if (sGuess3 == NPC_AI.NPC_093) { Notebook.bNoteThree093 = true; } if (sGuess3 == NPC_AI.NPC_094) { Notebook.bNoteThree094 = true; } if (sGuess3 == NPC_AI.NPC_095) { Notebook.bNoteThree095 = true; } if (sGuess3 == NPC_AI.NPC_096) { Notebook.bNoteThree096 = true; }
                    if (sGuess3 == NPC_AI.NPC_097) { Notebook.bNoteThree097 = true; } if (sGuess3 == NPC_AI.NPC_098) { Notebook.bNoteThree098 = true; } if (sGuess3 == NPC_AI.NPC_099) { Notebook.bNoteThree099 = true; } if (sGuess3 == NPC_AI.NPC_100) { Notebook.bNoteThree100 = true; }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("TIP: Any new information has been added to your notebook.");
                }
                Conversation.iAskOncePerTurn = 1;
            }
            NPC_AI.GetAllNPCLocals_AskTrait();
            Conversation.ResetAllTempConversationVariables();
        }
        
    }
}