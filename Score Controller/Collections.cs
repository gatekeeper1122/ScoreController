﻿using System.Collections.Generic;

namespace Score_Controller
{
    public class Collections
    {
        public static ScoreCollection Lowriders = new ScoreCollection("Lowriders", "Lowriders", "LOWRIDER");
        public static ScoreCollection Executive = new ScoreCollection("Power Play", "Executive", "EXECUTIVE");
        public static ScoreCollection Assault = new ScoreCollection("Southern San Andreas Super Sport Series", "Assault", "ASSAULT");
        public static ScoreCollection Doomsday = new ScoreCollection("The Doomsday Heist", "Doomsday", "HEIST2");
        public static ScoreCollection CasinoHeist = new ScoreCollection("Diamond Casino Heist", "Diamond Casino Heist", "HEIST3");
        public static ScoreCollection Smuggler = new ScoreCollection("Smuggler's Run", "Smuggler's Run", "SMUGGLER");
        public static ScoreCollection Gunrunning = new ScoreCollection("Gunrunning", "Gunrunning", "GUNRUNNING");
        public static ScoreCollection ArenaWar = new ScoreCollection("Arena War", "Arena War", "MC_AW_MUSIC");
        public static ScoreCollection Biker = new ScoreCollection("Bikers", "Bikers", "BIKER");
        public static ScoreCollection WoodyJackson = new ScoreCollection("Woody Jackson's Tracks", "Woody Jackson", null);
        public static ScoreCollection ArsenyTomilov = new ScoreCollection("Arseny Tomilov's Tracks", "Arseny Tomilov", null);

        public static List<ScoreCollection> CollectionsList = new List<ScoreCollection>() // A #NEWCOLLECTION must be added to this list
        {
            Lowriders,
            Executive,
            Assault,
            Doomsday,
            CasinoHeist,
            Smuggler,
            Gunrunning,
            ArenaWar,
            Biker,
            WoodyJackson,
            // ArsenyTomilov #BETA
        };

        public static void AddCollections() // Adding collections
        {
            // int count = 0; // #DEBUG
            foreach (ScoreCollection collection in CollectionsList)
            {
                // count++; // #DEBUG
                scoreCollections.Add(collection.Title);
                // UI.Notify("Added " + count + " collections."); // #DEBUG
            }
        }

        public static List<object> scoreCollections = new List<object>(); // List of all the Collections for Controller.mainScoreCollection
    }
}
