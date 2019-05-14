using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace IThinkTheWavesAreWatchingMe
{
    class Variables
    {
        public static int iBuild;
        // Tracking if something should block a random encounter, tracking if end-game is available.
        public static bool bUsableLocation025;

        public static string sStoryLocation;
        
        public static int iTotalTurns;

        public static int
        iTurn05, iTurn10, iTurn15, iTurn20, iTurn25,
        iTurn30, iTurn35, iTurn40, iTurn45, iTurn50, 
        iTurn55, iTurn60;

        public static int
        iRemainingTurns, iTurnsSinceEncounter, iFinishingTurn, iFinishingMac, iStage,
        iAcciKilled, iKnowRoll, iRandEncounters, iFoundMacGuffins,
        iCurrentLocation;

        public static bool
        turnEnded, foundWeapon, waitMove, bAnyoneHere, bAllDead,
        bAboutToDie, valid, bGameActive;

        public static string
        sPlayerState1, sPlayerState2, sPlayerState3, sPlayerState4, sPlayerState5;

        public static string playerAction, playerSurvived, weaponName, sGetLocation;

        public static void Initialize_MainVars()
        { 
            iBuild = 106;

            //iTurn05 = 120; // Start of the game (previously iturn1)
            //iTurn10 = 110; // First encounter, violence starts (previously iturn2)
            //iTurn15 = 108; // Next tier of DLG from NPCs (previously iturn8)
            //iTurn20 = 103; // When the accusation encounter plays (previously iturn11)
            //iTurn25 = 098; // ? (previously iturn9)
            //iTurn30 = 095; // Bunny's first clue (previously iturn3)
            //iTurn35 = 075; // Bunny's second clue (previously iturn4)
            //iTurn40 = 040; // Bunny's thid clue (previously iturn12)
            //iTurn45 = 035; // The flood starts, third-and-final bunny clue (previously iturn5)
            //iTurn50 = 020; // Meeting the killer (previously iturn6)
            //iTurn55 = 016; // End-game sequence, next DLG tier. (previously iturn10)
            //iTurn60 = 000; // Game Over. (previously iturn7)

            // Revise to:
            iTurn05 = 140; // Start of the game (previously iturn1)
            iTurn10 = 130; // First encounter, violence starts (previously iturn2)
            iTurn15 = 128; // Next tier of DLG from NPCs (previously iturn8)
            iTurn20 = 125; // When the accusation encounter plays (previously iturn11)
            iTurn25 = 120; // ? (previously iturn9)
            iTurn30 = 115; // Bunny's first clue (previously iturn3)
            iTurn35 = 080; // Bunny's second clue (previously iturn4)
            iTurn40 = 045; // Bunny's thid clue (previously iturn12)
            iTurn45 = 035; // The flood starts, third-and-final bunny clue (previously iturn5), when killer spree stops
            iTurn50 = 020; // Meeting the killer (previously iturn6)
            iTurn55 = 016; // End-game sequence, next DLG tier. (previously iturn10)
            iTurn60 = 000; // Game Over. (previously iturn7)

            iRemainingTurns = iTurn05;
            iTotalTurns = 120;

            bUsableLocation025 = false;

            sStoryLocation = "null";
        
            iRemainingTurns = iTurn05; // "iRemainingTurns" was "remainingTurns", be careful.
            iTurnsSinceEncounter = 0;
            iFinishingTurn = 0;
            iFinishingMac = 0;
            iStage = 0;
            iAcciKilled = 0;
            
            iKnowRoll = 0;
            iRandEncounters = 0;

            turnEnded = true;
            foundWeapon = false;
            waitMove = true;
            bAnyoneHere = false;
            bAllDead = false; // NPCs 1-89 are toast.
            bAboutToDie = false;
            valid = false;

            // Death States
            sPlayerState1 = "have gone to sleep. (x0.75)";
            sPlayerState2 = "have been swept away by the tidal waves. (0.5)";
            sPlayerState3 = "have journeyed into the tidal waves. (x1.25)";
            sPlayerState4 = "have abandoned all hope. (x0)";
            sPlayerState5 = "stopped that which was fated. (x1.25)";

            sGetLocation = LocationEncounters.location_017;
            playerAction = "DEBUG_null";
            playerSurvived = sPlayerState3;
            weaponName = NPC_AI.sWeaponType0;
            bGameActive = true;

            iFoundMacGuffins = 0; // How much money the player has.
            iCurrentLocation = 17; // What "room" the player is in, 1-25.
         } 
    }
}



