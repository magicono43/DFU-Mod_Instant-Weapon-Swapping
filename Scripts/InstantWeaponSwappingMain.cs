// Project:         InstantWeaponSwapping mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2022 Kirk.O
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          Kirk.O
// Created On: 	    8/3/2022, 11:00 PM
// Last Edit:		8/4/2022, 9:45 PM
// Version:			1.00
// Special Thanks:  Reconsile, JackyCrew, Hazelnut
// Modifier:

using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Game.Utility.ModSupport.ModSettings;
using UnityEngine;

namespace InstantWeaponSwapping
{
    public class InstantWeaponSwappingMain : MonoBehaviour
	{
        static InstantWeaponSwappingMain instance;

        public static InstantWeaponSwappingMain Instance
        {
            get { return instance ?? (instance = FindObjectOfType<InstantWeaponSwappingMain>()); }
        }

        static Mod mod;

        // Options
        public static int DaggerDelay { get; set; }
        public static int TantoDelay { get; set; }
        public static int StaffDelay { get; set; }
        public static int ShortswordDelay { get; set; }
        public static int WakazashiDelay { get; set; }
        public static int BroadswordDelay { get; set; }
        public static int SaberDelay { get; set; }
        public static int LongswordDelay { get; set; }
        public static int KatanaDelay { get; set; }
        public static int ClaymoreDelay { get; set; }
        public static int DaiKatanaDelay { get; set; }
        public static int MaceDelay { get; set; }
        public static int FlailDelay { get; set; }
        public static int WarhammerDelay { get; set; }
        public static int BattleAxeDelay { get; set; }
        public static int WarAxeDelay { get; set; }
        public static int ShortBowDelay { get; set; }
        public static int LongBowDelay { get; set; }

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            instance = new GameObject("InstantWeaponSwapping").AddComponent<InstantWeaponSwappingMain>(); // Add script to the scene.

            mod.LoadSettingsCallback = LoadSettings; // To enable use of the "live settings changes" feature in-game.

            mod.IsReady = true;
        }

        private void Start()
        {
            Debug.Log("Begin mod init: Instant Weapon Swapping");

            mod.LoadSettings();

            WeaponManager.EquipDelayTimes = new ushort[] { (ushort)DaggerDelay, (ushort)TantoDelay, (ushort)StaffDelay, (ushort)ShortswordDelay, (ushort)WakazashiDelay, (ushort)BroadswordDelay,
                (ushort)SaberDelay, (ushort)LongswordDelay, (ushort)KatanaDelay, (ushort)ClaymoreDelay, (ushort)DaiKatanaDelay, (ushort)MaceDelay, (ushort)FlailDelay, (ushort)WarhammerDelay,
                (ushort)BattleAxeDelay, (ushort)WarAxeDelay, (ushort)ShortBowDelay, (ushort)LongBowDelay };

            Debug.Log("Finished mod init: Instant Weapon Swapping");
        }

        #region Settings

        static void LoadSettings(ModSettings modSettings, ModSettingsChange change)
        {
            DaggerDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Dagger") * 100;
            TantoDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Tanto") * 100;
            StaffDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Staff") * 100;
            ShortswordDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Shortsword") * 100;
            WakazashiDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Wakazashi") * 100;
            BroadswordDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Broadsword") * 100;
            SaberDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Saber") * 100;
            LongswordDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Longsword") * 100;
            KatanaDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Katana") * 100;
            ClaymoreDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Claymore") * 100;
            DaiKatanaDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "DaiKatana") * 100;
            MaceDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Mace") * 100;
            FlailDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Flail") * 100;
            WarhammerDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "Warhammer") * 100;
            BattleAxeDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "BattleAxe") * 100;
            WarAxeDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "WarAxe") * 100;
            ShortBowDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "ShortBow") * 100;
            LongBowDelay = mod.GetSettings().GetValue<int>("EquipDelaySettings", "LongBow") * 100;

            WeaponManager.EquipDelayTimes = new ushort[] { (ushort)DaggerDelay, (ushort)TantoDelay, (ushort)StaffDelay, (ushort)ShortswordDelay, (ushort)WakazashiDelay, (ushort)BroadswordDelay,
                (ushort)SaberDelay, (ushort)LongswordDelay, (ushort)KatanaDelay, (ushort)ClaymoreDelay, (ushort)DaiKatanaDelay, (ushort)MaceDelay, (ushort)FlailDelay, (ushort)WarhammerDelay,
                (ushort)BattleAxeDelay, (ushort)WarAxeDelay, (ushort)ShortBowDelay, (ushort)LongBowDelay };
        }

        #endregion
    }
}