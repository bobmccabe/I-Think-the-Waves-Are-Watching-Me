using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Notebook
    {
        public static int iNotebookHasInfo;

        // bool to flag if a TIER ONE trait has been observed or not.
        public static bool
        bTrait001, bTrait002, bTrait003, bTrait004, bTrait005,
        bTrait006, bTrait007, bTrait008, bTrait009, bTrait010,
        bTrait011, bTrait012, bTrait013, bTrait014, bTrait015,
        bTrait016, bTrait017, bTrait018, bTrait019, bTrait020;

        // bool to flag if a TIER TWO trait has been observed or not.
        public static bool
        bTrait100, bTrait101, bTrait102, bTrait103, bTrait104,
        bTrait105, bTrait106, bTrait107, bTrait108, bTrait109,
        bTrait110, bTrait111, bTrait112, bTrait113, bTrait114;

        // bool to flag if a TIER THREE trait has been observed or not
        public static bool
        bTrait200, bTrait201, bTrait202, bTrait203, bTrait204,
        bTrait205, bTrait206, bTrait207, bTrait208, bTrait209,
        bTrait210, bTrait211, bTrait212, bTrait213, bTrait214;

        public static bool bTempNoted, bCorpseSpotted;

        public static bool
        bNoteOne001, bNoteOne002, bNoteOne003, bNoteOne004, bNoteOne005,
        bNoteOne006, bNoteOne007, bNoteOne008, bNoteOne009, bNoteOne010,
        bNoteOne011, bNoteOne012, bNoteOne013, bNoteOne014, bNoteOne015,
        bNoteOne016, bNoteOne017, bNoteOne018, bNoteOne019, bNoteOne020,
        bNoteOne021, bNoteOne022, bNoteOne023, bNoteOne024, bNoteOne025,
        bNoteOne026, bNoteOne027, bNoteOne028, bNoteOne029, bNoteOne030,
        bNoteOne031, bNoteOne032, bNoteOne033, bNoteOne034, bNoteOne035,
        bNoteOne036, bNoteOne037, bNoteOne038, bNoteOne039, bNoteOne040,
        bNoteOne041, bNoteOne042, bNoteOne043, bNoteOne044, bNoteOne045,
        bNoteOne046, bNoteOne047, bNoteOne048, bNoteOne049, bNoteOne050,
        bNoteOne051, bNoteOne052, bNoteOne053, bNoteOne054, bNoteOne055,
        bNoteOne056, bNoteOne057, bNoteOne058, bNoteOne059, bNoteOne060,
        bNoteOne061, bNoteOne062, bNoteOne063, bNoteOne064, bNoteOne065,
        bNoteOne066, bNoteOne067, bNoteOne068, bNoteOne069, bNoteOne070,
        bNoteOne071, bNoteOne072, bNoteOne073, bNoteOne074, bNoteOne075,
        bNoteOne076, bNoteOne077, bNoteOne078, bNoteOne079, bNoteOne080,
        bNoteOne081, bNoteOne082, bNoteOne083, bNoteOne084, bNoteOne085,
        bNoteOne086, bNoteOne087, bNoteOne088, bNoteOne089, bNoteOne090,
        bNoteOne091, bNoteOne092, bNoteOne093, bNoteOne094, bNoteOne095,
        bNoteOne096, bNoteOne097, bNoteOne098, bNoteOne099, bNoteOne100,
        bNoteOne, bNoteOneBunny;

        public static bool
        bNoteTwo001, bNoteTwo002, bNoteTwo003, bNoteTwo004, bNoteTwo005,
        bNoteTwo006, bNoteTwo007, bNoteTwo008, bNoteTwo009, bNoteTwo010,
        bNoteTwo011, bNoteTwo012, bNoteTwo013, bNoteTwo014, bNoteTwo015,
        bNoteTwo016, bNoteTwo017, bNoteTwo018, bNoteTwo019, bNoteTwo020,
        bNoteTwo021, bNoteTwo022, bNoteTwo023, bNoteTwo024, bNoteTwo025,
        bNoteTwo026, bNoteTwo027, bNoteTwo028, bNoteTwo029, bNoteTwo030,
        bNoteTwo031, bNoteTwo032, bNoteTwo033, bNoteTwo034, bNoteTwo035,
        bNoteTwo036, bNoteTwo037, bNoteTwo038, bNoteTwo039, bNoteTwo040,
        bNoteTwo041, bNoteTwo042, bNoteTwo043, bNoteTwo044, bNoteTwo045,
        bNoteTwo046, bNoteTwo047, bNoteTwo048, bNoteTwo049, bNoteTwo050,
        bNoteTwo051, bNoteTwo052, bNoteTwo053, bNoteTwo054, bNoteTwo055,
        bNoteTwo056, bNoteTwo057, bNoteTwo058, bNoteTwo059, bNoteTwo060,
        bNoteTwo061, bNoteTwo062, bNoteTwo063, bNoteTwo064, bNoteTwo065,
        bNoteTwo066, bNoteTwo067, bNoteTwo068, bNoteTwo069, bNoteTwo070,
        bNoteTwo071, bNoteTwo072, bNoteTwo073, bNoteTwo074, bNoteTwo075,
        bNoteTwo076, bNoteTwo077, bNoteTwo078, bNoteTwo079, bNoteTwo080,
        bNoteTwo081, bNoteTwo082, bNoteTwo083, bNoteTwo084, bNoteTwo085,
        bNoteTwo086, bNoteTwo087, bNoteTwo088, bNoteTwo089, bNoteTwo090,
        bNoteTwo091, bNoteTwo092, bNoteTwo093, bNoteTwo094, bNoteTwo095,
        bNoteTwo096, bNoteTwo097, bNoteTwo098, bNoteTwo099, bNoteTwo100,
        bNoteTwo, bNoteTwoBunny;

        public static bool
        bNoteThree001, bNoteThree002, bNoteThree003, bNoteThree004, bNoteThree005,
        bNoteThree006, bNoteThree007, bNoteThree008, bNoteThree009, bNoteThree010,
        bNoteThree011, bNoteThree012, bNoteThree013, bNoteThree014, bNoteThree015,
        bNoteThree016, bNoteThree017, bNoteThree018, bNoteThree019, bNoteThree020,
        bNoteThree021, bNoteThree022, bNoteThree023, bNoteThree024, bNoteThree025,
        bNoteThree026, bNoteThree027, bNoteThree028, bNoteThree029, bNoteThree030,
        bNoteThree031, bNoteThree032, bNoteThree033, bNoteThree034, bNoteThree035,
        bNoteThree036, bNoteThree037, bNoteThree038, bNoteThree039, bNoteThree040,
        bNoteThree041, bNoteThree042, bNoteThree043, bNoteThree044, bNoteThree045,
        bNoteThree046, bNoteThree047, bNoteThree048, bNoteThree049, bNoteThree050,
        bNoteThree051, bNoteThree052, bNoteThree053, bNoteThree054, bNoteThree055,
        bNoteThree056, bNoteThree057, bNoteThree058, bNoteThree059, bNoteThree060,
        bNoteThree061, bNoteThree062, bNoteThree063, bNoteThree064, bNoteThree065,
        bNoteThree066, bNoteThree067, bNoteThree068, bNoteThree069, bNoteThree070,
        bNoteThree071, bNoteThree072, bNoteThree073, bNoteThree074, bNoteThree075,
        bNoteThree076, bNoteThree077, bNoteThree078, bNoteThree079, bNoteThree080,
        bNoteThree081, bNoteThree082, bNoteThree083, bNoteThree084, bNoteThree085,
        bNoteThree086, bNoteThree087, bNoteThree088, bNoteThree089, bNoteThree090,
        bNoteThree091, bNoteThree092, bNoteThree093, bNoteThree094, bNoteThree095,
        bNoteThree096, bNoteThree097, bNoteThree098, bNoteThree099, bNoteThree100,
        bNoteThree, bNoteThreeBunny;

        // used for tracking whether you've noted someone's suspicious behavior already
        public static bool
        bNoted001, bNoted002, bNoted003, bNoted004, bNoted005,
        bNoted006, bNoted007, bNoted008, bNoted009, bNoted010,
        bNoted011, bNoted012, bNoted013, bNoted014, bNoted015,
        bNoted016, bNoted017, bNoted018, bNoted019, bNoted020,
        bNoted021, bNoted022, bNoted023, bNoted024, bNoted025,
        bNoted026, bNoted027, bNoted028, bNoted029, bNoted030,
        bNoted031, bNoted032, bNoted033, bNoted034, bNoted035,
        bNoted036, bNoted037, bNoted038, bNoted039, bNoted040,
        bNoted041, bNoted042, bNoted043, bNoted044, bNoted045,
        bNoted046, bNoted047, bNoted048, bNoted049, bNoted050,
        bNoted051, bNoted052, bNoted053, bNoted054, bNoted055,
        bNoted056, bNoted057, bNoted058, bNoted059, bNoted060,
        bNoted061, bNoted062, bNoted063, bNoted064, bNoted065,
        bNoted066, bNoted067, bNoted068, bNoted069, bNoted070,
        bNoted071, bNoted072, bNoted073, bNoted074, bNoted075,
        bNoted076, bNoted077, bNoted078, bNoted079, bNoted080,
        bNoted081, bNoted082, bNoted083, bNoted084, bNoted085,
        bNoted086, bNoted087, bNoted088, bNoted089, bNoted090,
        bNoted091, bNoted092, bNoted093, bNoted094, bNoted095,
        bNoted096, bNoted097, bNoted098, bNoted099, bNoted100;

        public static int iTempObserved;

        public static int
        iObserved001, iObserved002, iObserved003, iObserved004, iObserved005,
        iObserved006, iObserved007, iObserved008, iObserved009, iObserved010,
        iObserved011, iObserved012, iObserved013, iObserved014, iObserved015,
        iObserved016, iObserved017, iObserved018, iObserved019, iObserved020,
        iObserved021, iObserved022, iObserved023, iObserved024, iObserved025,
        iObserved026, iObserved027, iObserved028, iObserved029, iObserved030,
        iObserved031, iObserved032, iObserved033, iObserved034, iObserved035,
        iObserved036, iObserved037, iObserved038, iObserved039, iObserved040,
        iObserved041, iObserved042, iObserved043, iObserved044, iObserved045,
        iObserved046, iObserved047, iObserved048, iObserved049, iObserved050,
        iObserved051, iObserved052, iObserved053, iObserved054, iObserved055,
        iObserved056, iObserved057, iObserved058, iObserved059, iObserved060,
        iObserved061, iObserved062, iObserved063, iObserved064, iObserved065,
        iObserved066, iObserved067, iObserved068, iObserved069, iObserved070,
        iObserved071, iObserved072, iObserved073, iObserved074, iObserved075,
        iObserved076, iObserved077, iObserved078, iObserved079, iObserved080,
        iObserved081, iObserved082, iObserved083, iObserved084, iObserved085,
        iObserved086, iObserved087, iObserved088, iObserved089, iObserved090,
        iObserved091, iObserved092, iObserved093, iObserved094, iObserved095,
        iObserved096, iObserved097, iObserved098, iObserved099, iObserved100;

        public static bool
        bCorpseSpotted001, bCorpseSpotted002, bCorpseSpotted003, bCorpseSpotted004, bCorpseSpotted005,
        bCorpseSpotted006, bCorpseSpotted007, bCorpseSpotted008, bCorpseSpotted009, bCorpseSpotted010,
        bCorpseSpotted011, bCorpseSpotted012, bCorpseSpotted013, bCorpseSpotted014, bCorpseSpotted015,
        bCorpseSpotted016, bCorpseSpotted017, bCorpseSpotted018, bCorpseSpotted019, bCorpseSpotted020,
        bCorpseSpotted021, bCorpseSpotted022, bCorpseSpotted023, bCorpseSpotted024, bCorpseSpotted025,
        bCorpseSpotted026, bCorpseSpotted027, bCorpseSpotted028, bCorpseSpotted029, bCorpseSpotted030,
        bCorpseSpotted031, bCorpseSpotted032, bCorpseSpotted033, bCorpseSpotted034, bCorpseSpotted035,
        bCorpseSpotted036, bCorpseSpotted037, bCorpseSpotted038, bCorpseSpotted039, bCorpseSpotted040,
        bCorpseSpotted041, bCorpseSpotted042, bCorpseSpotted043, bCorpseSpotted044, bCorpseSpotted045,
        bCorpseSpotted046, bCorpseSpotted047, bCorpseSpotted048, bCorpseSpotted049, bCorpseSpotted050,
        bCorpseSpotted051, bCorpseSpotted052, bCorpseSpotted053, bCorpseSpotted054, bCorpseSpotted055,
        bCorpseSpotted056, bCorpseSpotted057, bCorpseSpotted058, bCorpseSpotted059, bCorpseSpotted060,
        bCorpseSpotted061, bCorpseSpotted062, bCorpseSpotted063, bCorpseSpotted064, bCorpseSpotted065,
        bCorpseSpotted066, bCorpseSpotted067, bCorpseSpotted068, bCorpseSpotted069, bCorpseSpotted070,
        bCorpseSpotted071, bCorpseSpotted072, bCorpseSpotted073, bCorpseSpotted074, bCorpseSpotted075,
        bCorpseSpotted076, bCorpseSpotted077, bCorpseSpotted078, bCorpseSpotted079, bCorpseSpotted080,
        bCorpseSpotted081, bCorpseSpotted082, bCorpseSpotted083, bCorpseSpotted084, bCorpseSpotted085,
        bCorpseSpotted086, bCorpseSpotted087, bCorpseSpotted088, bCorpseSpotted089, bCorpseSpotted090,
        bCorpseSpotted091, bCorpseSpotted092, bCorpseSpotted093, bCorpseSpotted094, bCorpseSpotted095,
        bCorpseSpotted096, bCorpseSpotted097, bCorpseSpotted098, bCorpseSpotted099, bCorpseSpotted100;

        public static void Initialize_Notebook()
        {
            iNotebookHasInfo = 0;
            bTempNoted = false;

            bNoteOne001 = bNoteOne002 = bNoteOne003 = bNoteOne004 = bNoteOne005 =
            bNoteOne006 = bNoteOne007 = bNoteOne008 = bNoteOne009 = bNoteOne010 =
            bNoteOne011 = bNoteOne012 = bNoteOne013 = bNoteOne014 = bNoteOne015 =
            bNoteOne016 = bNoteOne017 = bNoteOne018 = bNoteOne019 = bNoteOne020 =
            bNoteOne021 = bNoteOne022 = bNoteOne023 = bNoteOne024 = bNoteOne025 =
            bNoteOne026 = bNoteOne027 = bNoteOne028 = bNoteOne029 = bNoteOne030 =
            bNoteOne031 = bNoteOne032 = bNoteOne033 = bNoteOne034 = bNoteOne035 =
            bNoteOne036 = bNoteOne037 = bNoteOne038 = bNoteOne039 = bNoteOne040 =
            bNoteOne041 = bNoteOne042 = bNoteOne043 = bNoteOne044 = bNoteOne045 =
            bNoteOne046 = bNoteOne047 = bNoteOne048 = bNoteOne049 = bNoteOne050 =
            bNoteOne051 = bNoteOne052 = bNoteOne053 = bNoteOne054 = bNoteOne055 =
            bNoteOne056 = bNoteOne057 = bNoteOne058 = bNoteOne059 = bNoteOne060 =
            bNoteOne061 = bNoteOne062 = bNoteOne063 = bNoteOne064 = bNoteOne065 =
            bNoteOne066 = bNoteOne067 = bNoteOne068 = bNoteOne069 = bNoteOne070 =
            bNoteOne071 = bNoteOne072 = bNoteOne073 = bNoteOne074 = bNoteOne075 =
            bNoteOne076 = bNoteOne077 = bNoteOne078 = bNoteOne079 = bNoteOne080 =
            bNoteOne081 = bNoteOne082 = bNoteOne083 = bNoteOne084 = bNoteOne085 =
            bNoteOne086 = bNoteOne087 = bNoteOne088 = bNoteOne089 = bNoteOne090 =
            bNoteOne091 = bNoteOne092 = bNoteOne093 = bNoteOne094 = bNoteOne095 =
            bNoteOne096 = bNoteOne097 = bNoteOne098 = bNoteOne099 = bNoteOne100 =
            bNoteOne = bNoteOneBunny = false;

            bNoteTwo001 = bNoteTwo002 = bNoteTwo003 = bNoteTwo004 = bNoteTwo005 =
            bNoteTwo006 = bNoteTwo007 = bNoteTwo008 = bNoteTwo009 = bNoteTwo010 =
            bNoteTwo011 = bNoteTwo012 = bNoteTwo013 = bNoteTwo014 = bNoteTwo015 =
            bNoteTwo016 = bNoteTwo017 = bNoteTwo018 = bNoteTwo019 = bNoteTwo020 =
            bNoteTwo021 = bNoteTwo022 = bNoteTwo023 = bNoteTwo024 = bNoteTwo025 =
            bNoteTwo026 = bNoteTwo027 = bNoteTwo028 = bNoteTwo029 = bNoteTwo030 =
            bNoteTwo031 = bNoteTwo032 = bNoteTwo033 = bNoteTwo034 = bNoteTwo035 =
            bNoteTwo036 = bNoteTwo037 = bNoteTwo038 = bNoteTwo039 = bNoteTwo040 =
            bNoteTwo041 = bNoteTwo042 = bNoteTwo043 = bNoteTwo044 = bNoteTwo045 =
            bNoteTwo046 = bNoteTwo047 = bNoteTwo048 = bNoteTwo049 = bNoteTwo050 =
            bNoteTwo051 = bNoteTwo052 = bNoteTwo053 = bNoteTwo054 = bNoteTwo055 =
            bNoteTwo056 = bNoteTwo057 = bNoteTwo058 = bNoteTwo059 = bNoteTwo060 =
            bNoteTwo061 = bNoteTwo062 = bNoteTwo063 = bNoteTwo064 = bNoteTwo065 =
            bNoteTwo066 = bNoteTwo067 = bNoteTwo068 = bNoteTwo069 = bNoteTwo070 =
            bNoteTwo071 = bNoteTwo072 = bNoteTwo073 = bNoteTwo074 = bNoteTwo075 =
            bNoteTwo076 = bNoteTwo077 = bNoteTwo078 = bNoteTwo079 = bNoteTwo080 =
            bNoteTwo081 = bNoteTwo082 = bNoteTwo083 = bNoteTwo084 = bNoteTwo085 =
            bNoteTwo086 = bNoteTwo087 = bNoteTwo088 = bNoteTwo089 = bNoteTwo090 =
            bNoteTwo091 = bNoteTwo092 = bNoteTwo093 = bNoteTwo094 = bNoteTwo095 =
            bNoteTwo096 = bNoteTwo097 = bNoteTwo098 = bNoteTwo099 = bNoteTwo100 =
            bNoteTwo = bNoteTwoBunny = false;

            bNoteThree001 = bNoteThree002 = bNoteThree003 = bNoteThree004 = bNoteThree005 =
            bNoteThree006 = bNoteThree007 = bNoteThree008 = bNoteThree009 = bNoteThree010 =
            bNoteThree011 = bNoteThree012 = bNoteThree013 = bNoteThree014 = bNoteThree015 =
            bNoteThree016 = bNoteThree017 = bNoteThree018 = bNoteThree019 = bNoteThree020 =
            bNoteThree021 = bNoteThree022 = bNoteThree023 = bNoteThree024 = bNoteThree025 =
            bNoteThree026 = bNoteThree027 = bNoteThree028 = bNoteThree029 = bNoteThree030 =
            bNoteThree031 = bNoteThree032 = bNoteThree033 = bNoteThree034 = bNoteThree035 =
            bNoteThree036 = bNoteThree037 = bNoteThree038 = bNoteThree039 = bNoteThree040 =
            bNoteThree041 = bNoteThree042 = bNoteThree043 = bNoteThree044 = bNoteThree045 =
            bNoteThree046 = bNoteThree047 = bNoteThree048 = bNoteThree049 = bNoteThree050 =
            bNoteThree051 = bNoteThree052 = bNoteThree053 = bNoteThree054 = bNoteThree055 =
            bNoteThree056 = bNoteThree057 = bNoteThree058 = bNoteThree059 = bNoteThree060 =
            bNoteThree061 = bNoteThree062 = bNoteThree063 = bNoteThree064 = bNoteThree065 =
            bNoteThree066 = bNoteThree067 = bNoteThree068 = bNoteThree069 = bNoteThree070 =
            bNoteThree071 = bNoteThree072 = bNoteThree073 = bNoteThree074 = bNoteThree075 =
            bNoteThree076 = bNoteThree077 = bNoteThree078 = bNoteThree079 = bNoteThree080 =
            bNoteThree081 = bNoteThree082 = bNoteThree083 = bNoteThree084 = bNoteThree085 =
            bNoteThree086 = bNoteThree087 = bNoteThree088 = bNoteThree089 = bNoteThree090 =
            bNoteThree091 = bNoteThree092 = bNoteThree093 = bNoteThree094 = bNoteThree095 =
            bNoteThree096 = bNoteThree097 = bNoteThree098 = bNoteThree099 = bNoteThree100 =
            bNoteThree = bNoteThreeBunny = false;

            bNoted001 = bNoted002 = bNoted003 = bNoted004 = bNoted005 =
            bNoted006 = bNoted007 = bNoted008 = bNoted009 = bNoted010 =
            bNoted011 = bNoted012 = bNoted013 = bNoted014 = bNoted015 =
            bNoted016 = bNoted017 = bNoted018 = bNoted019 = bNoted020 =
            bNoted021 = bNoted022 = bNoted023 = bNoted024 = bNoted025 =
            bNoted026 = bNoted027 = bNoted028 = bNoted029 = bNoted030 =
            bNoted031 = bNoted032 = bNoted033 = bNoted034 = bNoted035 =
            bNoted036 = bNoted037 = bNoted038 = bNoted039 = bNoted040 =
            bNoted041 = bNoted042 = bNoted043 = bNoted044 = bNoted045 =
            bNoted046 = bNoted047 = bNoted048 = bNoted049 = bNoted050 =
            bNoted051 = bNoted052 = bNoted053 = bNoted054 = bNoted055 =
            bNoted056 = bNoted057 = bNoted058 = bNoted059 = bNoted060 =
            bNoted061 = bNoted062 = bNoted063 = bNoted064 = bNoted065 =
            bNoted066 = bNoted067 = bNoted068 = bNoted069 = bNoted070 =
            bNoted071 = bNoted072 = bNoted073 = bNoted074 = bNoted075 =
            bNoted076 = bNoted077 = bNoted078 = bNoted079 = bNoted080 =
            bNoted081 = bNoted082 = bNoted083 = bNoted084 = bNoted085 =
            bNoted086 = bNoted087 = bNoted088 = bNoted089 = bNoted090 =
            bNoted091 = bNoted092 = bNoted093 = bNoted094 = bNoted095 =
            bNoted096 = bNoted097 = bNoted098 = bNoted099 = bNoted100 = true;

            iTempObserved = 0;
            
            iObserved001 = iObserved002 = iObserved003 = iObserved004 = iObserved005 =
            iObserved006 = iObserved007 = iObserved008 = iObserved009 = iObserved010 =
            iObserved011 = iObserved012 = iObserved013 = iObserved014 = iObserved015 =
            iObserved016 = iObserved017 = iObserved018 = iObserved019 = iObserved020 =
            iObserved021 = iObserved022 = iObserved023 = iObserved024 = iObserved025 =
            iObserved026 = iObserved027 = iObserved028 = iObserved029 = iObserved030 =
            iObserved031 = iObserved032 = iObserved033 = iObserved034 = iObserved035 =
            iObserved036 = iObserved037 = iObserved038 = iObserved039 = iObserved040 =
            iObserved041 = iObserved042 = iObserved043 = iObserved044 = iObserved045 =
            iObserved046 = iObserved047 = iObserved048 = iObserved049 = iObserved050 =
            iObserved051 = iObserved052 = iObserved053 = iObserved054 = iObserved055 =
            iObserved056 = iObserved057 = iObserved058 = iObserved059 = iObserved060 =
            iObserved061 = iObserved062 = iObserved063 = iObserved064 = iObserved065 =
            iObserved066 = iObserved067 = iObserved068 = iObserved069 = iObserved070 =
            iObserved071 = iObserved072 = iObserved073 = iObserved074 = iObserved075 =
            iObserved076 = iObserved077 = iObserved078 = iObserved079 = iObserved080 =
            iObserved081 = iObserved082 = iObserved083 = iObserved084 = iObserved085 =
            iObserved086 = iObserved087 = iObserved088 = iObserved089 = iObserved090 =
            iObserved091 = iObserved092 = iObserved093 = iObserved094 = iObserved095 =
            iObserved096 = iObserved097 = iObserved098 = iObserved099 = iObserved100 = 0;

            // bool to flag if a TIER ONE trait has been observed or not
            bTrait001 = bTrait002 = bTrait003 = bTrait004 = bTrait005 =
            bTrait006 = bTrait007 = bTrait008 = bTrait009 = bTrait010 =
            bTrait011 = bTrait012 = bTrait013 = bTrait014 = bTrait015 =
            bTrait016 = bTrait017 = bTrait018 = bTrait019 = bTrait020 = false;

            // bool to flag if a TIER TWO trait has been observed or not.
            bTrait100 = bTrait101 = bTrait102 = bTrait103 = bTrait104 =
            bTrait105 = bTrait106 = bTrait107 = bTrait108 = bTrait109 =
            bTrait110 = bTrait111 = bTrait112 = bTrait113 = bTrait114 = false;

            // to flag if a TIER THREE trait has been observed or not
            bTrait200 = bTrait201 = bTrait202 = bTrait203 = bTrait204 =
            bTrait205 = bTrait206 = bTrait207 = bTrait208 = bTrait209 =
            bTrait210 = bTrait211 = bTrait212 = bTrait213 = bTrait214 = false;

            bCorpseSpotted001 = bCorpseSpotted002 = bCorpseSpotted003 = bCorpseSpotted004 = bCorpseSpotted005 =
            bCorpseSpotted006 = bCorpseSpotted007 = bCorpseSpotted008 = bCorpseSpotted009 = bCorpseSpotted010 =
            bCorpseSpotted011 = bCorpseSpotted012 = bCorpseSpotted013 = bCorpseSpotted014 = bCorpseSpotted015 =
            bCorpseSpotted016 = bCorpseSpotted017 = bCorpseSpotted018 = bCorpseSpotted019 = bCorpseSpotted020 =
            bCorpseSpotted021 = bCorpseSpotted022 = bCorpseSpotted023 = bCorpseSpotted024 = bCorpseSpotted025 =
            bCorpseSpotted026 = bCorpseSpotted027 = bCorpseSpotted028 = bCorpseSpotted029 = bCorpseSpotted030 =
            bCorpseSpotted031 = bCorpseSpotted032 = bCorpseSpotted033 = bCorpseSpotted034 = bCorpseSpotted035 =
            bCorpseSpotted036 = bCorpseSpotted037 = bCorpseSpotted038 = bCorpseSpotted039 = bCorpseSpotted040 =
            bCorpseSpotted041 = bCorpseSpotted042 = bCorpseSpotted043 = bCorpseSpotted044 = bCorpseSpotted045 =
            bCorpseSpotted046 = bCorpseSpotted047 = bCorpseSpotted048 = bCorpseSpotted049 = bCorpseSpotted050 =
            bCorpseSpotted051 = bCorpseSpotted052 = bCorpseSpotted053 = bCorpseSpotted054 = bCorpseSpotted055 =
            bCorpseSpotted056 = bCorpseSpotted057 = bCorpseSpotted058 = bCorpseSpotted059 = bCorpseSpotted060 =
            bCorpseSpotted061 = bCorpseSpotted062 = bCorpseSpotted063 = bCorpseSpotted064 = bCorpseSpotted065 =
            bCorpseSpotted066 = bCorpseSpotted067 = bCorpseSpotted068 = bCorpseSpotted069 = bCorpseSpotted070 =
            bCorpseSpotted071 = bCorpseSpotted072 = bCorpseSpotted073 = bCorpseSpotted074 = bCorpseSpotted075 =
            bCorpseSpotted076 = bCorpseSpotted077 = bCorpseSpotted078 = bCorpseSpotted079 = bCorpseSpotted080 =
            bCorpseSpotted081 = bCorpseSpotted082 = bCorpseSpotted083 = bCorpseSpotted084 = bCorpseSpotted085 =
            bCorpseSpotted086 = bCorpseSpotted087 = bCorpseSpotted088 = bCorpseSpotted089 = bCorpseSpotted090 =
            bCorpseSpotted091 = bCorpseSpotted092 = bCorpseSpotted093 = bCorpseSpotted094 = bCorpseSpotted095 =
            bCorpseSpotted096 = bCorpseSpotted097 = bCorpseSpotted098 = bCorpseSpotted099 = bCorpseSpotted100 =
            false;

        }

        public static void DoYouComeHereOftenYouLookFamiliar()
        {
            // Add noted people if the killer's identity is not yet known.
            if (Variables.iRemainingTurns >= Variables.iTurn50)
            {
                if (NPC_AI.iCloseEncounters == 3 && !bTempNoted) { Lists.TheSuspiciousBunch.Add(NPC_AI.tempNPC); } // if you have been around me # turns, and you have not noted this yet.
                if (NPC_AI.iCloseEncounters == 8 && !bTempNoted) { Lists.TheSuspiciousBunch.Add(NPC_AI.tempNPC); } // etc.
                if (NPC_AI.iCloseEncounters == 13 && !bTempNoted) { Lists.TheSuspiciousBunch.Add(NPC_AI.tempNPC); } // etc.
                if (NPC_AI.iCloseEncounters == 18 && !bTempNoted) { Lists.TheSuspiciousBunch.Add(NPC_AI.tempNPC); } // etc.
                // if (NPC_AI.iCloseEncounters == 23 && !bTempNoted) { Lists.TheSuspiciousBunch.Add(NPC_AI.tempNPC); } // etc.
                // Print results
                if (Lists.TheSuspiciousBunch.Count > 0) // ... Check to see if there is anyone in the suspicious list.
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (iTempObserved == 3)
                    {
                        // Console.WriteLine("   " + NPC_AI.tempNPC + " smiles at you. 'Now I know you're following me.'");
                        iTempObserved = 4;
                    }
                    else if (iTempObserved == 2)
                    {
                        // Console.WriteLine("   " + NPC_AI.tempNPC + " says to you, 'Seems like we keep bumping into one another.'");
                        iTempObserved = 3;
                    }
                    else if (iTempObserved == 1)
                    {
                        if (bNoteTwo) { Console.WriteLine("   You've previously written that " + NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitTwo + "."); }
                        else if (!bNoteTwo) { Console.WriteLine("   You write down that " + NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitTwo + "."); }
                        iNotebookHasInfo++;
                        iTempObserved = 2;
                        bNoteTwo = true;
                        bNoteOne = false;
                        if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait100) { bTrait100 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait101) { bTrait101 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait102) { bTrait102 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait103) { bTrait103 = true; }
                        if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait104) { bTrait104 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait105) { bTrait105 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait106) { bTrait106 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait107) { bTrait107 = true; }
                        if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait108) { bTrait108 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait109) { bTrait109 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait110) { bTrait110 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait111) { bTrait111 = true; }
                        if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait112) { bTrait112 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait113) { bTrait113 = true; } if (NPC_Traits.sTempTraitTwo == NPC_Traits.sTrait114) { bTrait114 = true; }
                    }
                    else if (iTempObserved == 0)
                    {
                        if (bNoteTwo || bNoteOne) { Console.WriteLine("   You've previously written that " + NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + "."); }
                        else if (!bNoteOne) { Console.WriteLine("   You write down that " + NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + "."); }
                        iTempObserved = 1;
                        bNoteOne = true;
                        iNotebookHasInfo++;
                        if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait001) { bTrait001 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait002) { bTrait002 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait003) { bTrait003 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait004) { bTrait004 = true; }
                        if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait005) { bTrait005 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait006) { bTrait006 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait007) { bTrait007 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait008) { bTrait008 = true; }
                        if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait009) { bTrait009 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait010) { bTrait010 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait011) { bTrait011 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait012) { bTrait012 = true; }
                        if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait013) { bTrait013 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait014) { bTrait014 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait015) { bTrait015 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait016) { bTrait016 = true; }
                        if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait017) { bTrait017 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait018) { bTrait018 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait019) { bTrait019 = true; } if (NPC_Traits.sTempTraitOne == NPC_Traits.sTrait020) { bTrait020 = true; }
                    }
                    bTempNoted = true; // reset that NPC to true... won't be changed to false unless they're seen again
                    // Re-write above as Console.WriteLine("You noticed NPC_AI.tempNPC's behavior trait. You ALSO make note of it.");
                    Console.ForegroundColor = ConsoleColor.Gray; // resets color back to yellow after highlighting that you noted something
                    Lists.TheSuspiciousBunch.Clear(); // ... And then remove that person from the suspicious list.
                }
            }
        }

        public static void CheckForNotebookMatches()
        {
            int iListingTheBadMatchesSpacing = 0;            

            foreach (string sClueFiltering in Lists.NPCRoster)
            {
                RandomEncounters.Actor01 = sClueFiltering;
                RandomEncounters.Actor02 = "null";
                RandomEncounters.Actor03 = "null";
                RandomEncounters.Actor04 = "null";
                RandomEncounters.Actor05 = "null";
                RandomEncounters.Actor06 = "null";

                AccusationEncounters.Reset_ActorTraits();
                RandomEncounters.GetAllActorLocals();
                AccusationEncounters.SetActor05AsTheKiller();

                bCorpseSpotted = false;
                NPC_AI.tempNPC = "null";
                NPC_AI.tempNPC = sClueFiltering;
                Conversation.GetbCorpseSpotted_tempNPC();
                
                // Notes to self:

                // When you get the first clue:
                // NPC_Traits.bTraitOne01Bunny = true; NPC_Traits.bTraitOneBunny = true; 

                // When you get the second clue: 
                // NPC_Traits.bTraitTwo01Bunny = true; NPC_Traits.bTraitOneBunny = false; NPC_Traits.bTraitTwoBunny = true; 

                // When you get the third clue:
                // NPC_Traits.bTraitThree01Bunny = true; NPC_Traits.bTraitOneBunny = false; NPC_Traits.bTraitTwoBunny = false; NPC_Traits.bTraitThreeBunny = true;

                // string NPC_Traits.TraitOneBunny = the text that the player reads describing the killer, the first clue.
                // string NPC_Traits.TraitTwoBunny = the text that the player reads describing the killer, the second clue.
                // string NPC_Traits.TraitThreeBunny = the text that the player reads describing the killer, the third clue.

                // Each of the following should return positive, a viable suspect, if the conditions are met.

                // Bunny Clue 3 is active.
                // If BunnyClue3 is known. If NPCTrait1/2/3 is known. And if 1 & 2 & 3 match.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1/3 is known. And if 1 & 3 match. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // Bunny Clue 2 is active.
                // If BunnyClue2 is known. If NPCTrait1/2/3 is known. And if 1 & 2 match.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // Bunny Clue 1 is active.
                // If BunnyClue1 is known. If NPCTrait1/2/3 is known. And if 1 matches.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1/2 is known. And if 1 matches. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { iListingTheBadMatchesSpacing++; }        
        
                // So that this only appears once.
                if (iListingTheBadMatchesSpacing == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("On the topic of suspects:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("If your vision can be trusted, then the following people may be worth");
                    Console.WriteLine("keeping an eye on...");
                    Console.WriteLine();
                }

                // Bunny Clue 3 is active.
                // If BunnyClue3 is known. If NPCTrait1/2/3 is known. And if 1 & 2 & 3 match.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1/3 is known. And if 1 & 3 match. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue3 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitThreeBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // Bunny Clue 2 is active.
                // If BunnyClue2 is known. If NPCTrait1/2/3 is known. And if 1 & 2 match.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1/2 is known. And if 1 & 2 match. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 && NPC_Traits.TraitTwoBunny == AccusationEncounters.sTempTraitTwo01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue2 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitTwoBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // Bunny Clue 1 is active.
                // If BunnyClue1 is known. If NPCTrait1/2/3 is known. And if 1 matches.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteTwo01 && AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1/2 is known. And if 1 matches. Add: AND 3 is UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1/3 is known. And if 1 matches. Add: AND 2 is UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteOne01 && AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait3 is known. And if 3 matches. Add: AND 1 & 2 are UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteThree01 && !AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 &&
                    NPC_Traits.TraitThreeBunny == AccusationEncounters.sTempTraitThree01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }

                // If BunnyClue1 is known. If NPCTrait1 is known. And if 1 matches. Add: AND 2 & 3 are UNKNOWN.
                if (NPC_Traits.bTraitOneBunny &&
                    AccusationEncounters.bNoteOne01 && !AccusationEncounters.bNoteTwo01 && !AccusationEncounters.bNoteThree01 &&
                    NPC_Traits.TraitOneBunny == AccusationEncounters.sTempTraitOne01 &&
                    !bCorpseSpotted)
                { Console.WriteLine(sClueFiltering + " is a viable suspect."); iListingTheBadMatchesSpacing++; }
                bCorpseSpotted = false;
            }
        }

        public static void Option_CompulsivelyWritingEverythingDown()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            if (Variables.bAboutToDie)
            {
                Console.WriteLine("You open your notebook to look at something, but the words are");
                Console.WriteLine("blurring across the page. It's such a struggle to keep your eyes open.");
                Console.WriteLine("You think that maybe if you shut them for a moment, it'll be easier to");
                Console.WriteLine("read everything when you open them again. But once you close your");
                Console.WriteLine("eyes, you can feel yourself floating away into comfortable bliss.");
                Console.WriteLine();
            }

            Lists.PopulateNPCRoster();

            if (iNotebookHasInfo == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("You occasionally write down things about the people you come across,");
                Console.WriteLine("or perhaps other notes of interest. You never know when these details");
                Console.WriteLine("may come in handy.");
                Console.WriteLine();
                Console.WriteLine("At the moment, the notebook doesn't have anything useful in it. Try");
                Console.WriteLine("hanging around people and maybe you'll see something worth writing");
                Console.WriteLine("down.");
            }
            if (iNotebookHasInfo > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You open your notebook and read through your recent notes.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
                Lists.NPCRoster.Sort();
                if (Variables.iRemainingTurns < Variables.iTurn50 && LocationEncounters.bDontAuto23)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("On the topic of confusion:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Here is what you know: there were people all around. Then you had a");
                    Console.WriteLine("few drinks with some of those people. Then there's some missing spots");
                    Console.WriteLine("in your memory.");
                    Console.WriteLine();
                    Console.WriteLine("Yes, you may have had a few too many, but what difference does that");
                    Console.WriteLine("make? It's OK to have a few now-and-then. Don't judge!");
                    Console.WriteLine();
                    Console.WriteLine("The point is that the next thing you know is that you're now alone, and");
                    Console.WriteLine("everyone else is dead. And it doesn't matter if it's redundant to say that");
                    Console.WriteLine("you're alone and that everyone is dead because this is pretty serious.");
                    Console.WriteLine();
                    Console.WriteLine("You're not sure what happened. How could you be? Is it possible that");
                    Console.WriteLine("you're a violent drunk and that you killed everyone? And why are the");
                    Console.WriteLine("waves moving now? They're getting closer. And you're running out of");
                    Console.WriteLine("places to stay dry. This isn't good. It can't be.");
                }
                if (Variables.iRemainingTurns < Variables.iTurn50 && !LocationEncounters.bDontAuto23)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("On the topic of observations and suspects:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("You had been trying to puzzle out the killer's identity. Now you know");
                    Console.WriteLine("that " + NPC_AI.NPC_100 + " was the one causing the lightning that's been killing");
                    Console.WriteLine("everyone.");
                    Console.WriteLine();
                    Console.WriteLine("But why bother to kill everyone when the tidal waves seem poised to do");
                    Console.WriteLine("just that?");
                    Console.WriteLine();
                    Console.WriteLine("You also know that if you stay around " + NPC_AI.NPC_100 + " for too long, you're");
                    Console.WriteLine("going to fall asleep -- for good. Just being around " + NPC_AI.NPC_100 + " overwhelms");
                    Console.WriteLine("you with fatigue.");
                    Console.WriteLine();
                    Console.WriteLine("But the bunny told you that if you can gather up the necessary");
                    Console.WriteLine("MacGuffins and bring them to the jetty... it just might be a chance to");
                    Console.WriteLine("escape and survive.");
                }

                if (Variables.iRemainingTurns >= Variables.iTurn50)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("On the topic of observations:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    foreach (string sTempNPC in Lists.NPCRoster)
                    {
                        NPC_AI.tempNPC = "null";
                        NPC_AI.tempNPC = sTempNPC;
                        NPC_AI.GetAllNPCLocals();
                        Conversation.GetbCorpseSpotted_tempNPC();

                        if ((!bCorpseSpotted) && (bNoteThree && !bNoteOne && !bNoteTwo)) { Console.WriteLine(NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitThree + "."); }
                        else if ((!bCorpseSpotted) && (bNoteThree && bNoteOne)) { Console.WriteLine(NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + ", and " + NPC_Traits.sTempTraitThree + "."); }
                        else if ((!bCorpseSpotted) && (bNoteThree && bNoteTwo)) { Console.WriteLine(NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + ", " + NPC_Traits.sTempTraitTwo + ",\n\r   and " + NPC_Traits.sTempTraitThree + "."); }
                        else if ((!bCorpseSpotted) && (!bNoteThree && bNoteTwo)) { Console.WriteLine(NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + ", and " + NPC_Traits.sTempTraitTwo + "."); }
                        else if ((!bCorpseSpotted) && (!bNoteThree && bNoteOne)) { Console.WriteLine(NPC_AI.tempNPC + " " + NPC_Traits.sTempTraitOne + "."); }

                        // NPC_AI.SetAllNPCLocals(); ? Why did I put this here? Does not seem necessary. Temporarily removing to see if it breaks anything.
                    }
                    if (
                    (TheBunny.iBunnyStage == 1 && Variables.iRemainingTurns >= Variables.iTurn50) ||
                    (TheBunny.iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50) ||
                    (TheBunny.iBunnyStage == 2 && Variables.iRemainingTurns <= Variables.iTurn35 && Variables.iRemainingTurns >= Variables.iTurn50)
                    )
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of a curious bunny:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        
                        if (TheBunny.iBunnyStage == 1 && Variables.iRemainingTurns >= Variables.iTurn50) { Console.WriteLine(); Console.WriteLine("You wrote down that there is a talking bunny at " + TheBunny.sBunnyLocation); }
                        if (TheBunny.iBunnyStage == 4 && Variables.iRemainingTurns >= Variables.iTurn50) { Console.WriteLine(); Console.WriteLine("A talking bunny said, " + TheBunny.sBunnyRiddleTwo, TheBunny.sClueNPC + "."); }
                        if (TheBunny.iBunnyStage == 2 && Variables.iRemainingTurns <= Variables.iTurn35 && Variables.iRemainingTurns >= Variables.iTurn50) { Console.WriteLine(); Console.WriteLine("A talking bunny said, " + TheBunny.sBunnyRiddleOne + "."); }
                    }


                    //int iListingTheDeadSpacing = 0;

                    //foreach (string sDeadNPC in Lists.NPCRoster)
                    //{
                    //    NPC_AI.tempNPC = sDeadNPC;
                    //    NPC_AI.GetAllNPCLocals();

                    //    if ((NPC_AI.bTempCorpse) && (bNoteThree && !bNoteOne && !bNoteTwo) && bCorpseSpotted) { iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (bNoteThree && bNoteOne) && bCorpseSpotted) { iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (bNoteThree && bNoteTwo) && bCorpseSpotted) { iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (!bNoteThree && bNoteTwo) && bCorpseSpotted) { iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (!bNoteThree && bNoteOne) && bCorpseSpotted) { iListingTheDeadSpacing++; }

                    //    if (iListingTheDeadSpacing == 1) 
                    //    {
                    //        Console.WriteLine();
                    //        Console.WriteLine("You scratched out the following names from your notebook since you");
                    //        Console.WriteLine("know that these people are now dead:");
                    //        Console.WriteLine();
                    //    }

                    //    if ((NPC_AI.bTempCorpse) && (bNoteThree && !bNoteOne && !bNoteTwo) && bCorpseSpotted) { Console.WriteLine(sDeadNPC); iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (bNoteThree && bNoteOne) && bCorpseSpotted) { Console.WriteLine(sDeadNPC); iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (bNoteThree && bNoteTwo) && bCorpseSpotted) { Console.WriteLine(sDeadNPC); iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (!bNoteThree && bNoteTwo) && bCorpseSpotted) { Console.WriteLine(sDeadNPC); iListingTheDeadSpacing++; }
                    //    else if ((NPC_AI.bTempCorpse) && (!bNoteThree && bNoteOne) && bCorpseSpotted) { Console.WriteLine(sDeadNPC); iListingTheDeadSpacing++; }
                    //}

                    // A few potential, custom additions to the notebook.
                    if (NPC_Traits.bTraitOneBunny || NPC_Traits.bTraitTwoBunny || NPC_Traits.bTraitThreeBunny)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of visions:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (NPC_Traits.bTraitOneBunny) { Console.WriteLine(); Console.WriteLine("You had a vision of a killer, and saw someone who " + NPC_Traits.TraitOneBunny + "."); }
                        if (NPC_Traits.bTraitTwoBunny) { Console.WriteLine(); Console.WriteLine("You had a vision of a killer, and saw someone who " + NPC_Traits.TraitOneBunny + "\n\rand " + NPC_Traits.TraitTwoBunny + "."); }
                        if (NPC_Traits.bTraitThreeBunny) { Console.WriteLine(); Console.WriteLine("You had a vision of a killer, and saw someone who " + NPC_Traits.TraitOneBunny + ",\n\r" + NPC_Traits.TraitTwoBunny + ", and " + NPC_Traits.TraitThreeBunny + "."); }
                    }

                    CheckForNotebookMatches();
                }
                if (LocationEncounters.bOpenedSafe)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("On the topic of found numbers:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("You found three numbers scattered about the island. You used them to");
                    Console.WriteLine("open a combination safe hidden away at one of the shops. Inside the");
                    Console.WriteLine("safe you found 28 MacGuffins.");
                }

                if (!LocationEncounters.bOpenedSafe)
                {
                    int iComboTwoThreeOrder = Program.rand.Next(1, 3);
                    
                    if (LocationEncounters.bNumber1Found && LocationEncounters.bNumber2Found && LocationEncounters.bNumber3Found && iComboTwoThreeOrder == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of found numbers:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("You wrote down the numbers '" + LocationEncounters.iCombo1 + "', '" + LocationEncounters.iCombo2 + "', and '" + LocationEncounters.iCombo3 + "'. While '" + LocationEncounters.iCombo1 + "' had the word ");
                        Console.WriteLine("'first' written next to it, you're not sure if the other two numbers");
                        Console.WriteLine("represent second and third -- nor the proper order if this is the case.");
                        Console.WriteLine("There's also the question of where you can use the numbers.");
                        LocationEncounters.iNumberFoundFirst = 4; // override, so below entries won't print
                    }
                    if (LocationEncounters.bNumber1Found && LocationEncounters.bNumber2Found && LocationEncounters.bNumber3Found && iComboTwoThreeOrder == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of found numbers:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("You wrote down the numbers '" + LocationEncounters.iCombo1 + "', '" + LocationEncounters.iCombo3 + "', and '" + LocationEncounters.iCombo2 + "'. While '" + LocationEncounters.iCombo1 + "' had the word ");
                        Console.WriteLine("'first' written next to it, you're not sure if the other two numbers");
                        Console.WriteLine("represent second and third -- nor the proper order if this is the case.");
                        Console.WriteLine("There's also the question of where you can use the numbers.");
                        LocationEncounters.iNumberFoundFirst = 4; // override, so below entries won't print
                    }
                    if (LocationEncounters.bNumber1Found && LocationEncounters.iNumberFoundFirst != 4)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of found numbers:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine("You wrote down the number '" + LocationEncounters.iCombo1 + "' and the word 'first'.");
                    }
                    if (
                        (LocationEncounters.bNumber2Found && LocationEncounters.iNumberFoundFirst == 2) ||
                        (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 3) ||
                        (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 2) ||
                        (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 2)
                        )
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine("On the topic of found numbers:");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        if (LocationEncounters.bNumber2Found && LocationEncounters.iNumberFoundFirst == 2) { Console.WriteLine("You wrote down the number '" + LocationEncounters.iCombo2 + "'."); } // Found #2 first
                        if (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 3) { Console.WriteLine("You wrote down the number '" + LocationEncounters.iCombo3 + "'."); } // Found #3 first
                        if (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 2) { Console.WriteLine("You wrote down the number '" + LocationEncounters.iCombo3 + "'."); } // Found #2 first, but also found #3
                        if (LocationEncounters.bNumber3Found && LocationEncounters.iNumberFoundFirst == 2) { Console.WriteLine("You wrote down the number '" + LocationEncounters.iCombo2 + "'."); } // Found #3 first, but also found #2
                    }

                }
                
                if (LocationEncounters.bDrunkWaffler)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("On the topic of drunken musings:");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("There's a strange note scribbled in your notebook. It looks like you");
                    Console.WriteLine("wrote it down when you were feeling a bit more tipsy. It says:");
                    Console.WriteLine();
                    Console.WriteLine("I have can opportunity andwant toI can in order to appeal that make");
                    Console.WriteLine("prize and -- don't forget open doors -- and also if you lose are they");
                    Console.WriteLine("make it have opportunity why there is a house here. How mnay times?");
                    Console.WriteLine();
                    Console.WriteLine("Next to the note, you have drawn a pair of breasts with a penis between");
                    Console.WriteLine("them.");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("That's everything you have written.");
            }

            // After we've removed everyone, add them back to keep things kosher.
            Lists.PopulateNPCRoster();
            Program.PressAnyKey();
        }
    }
}