using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.IO;
using UnityEngine;

namespace StageSelect
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("LLBlaze.exe")]
    public class Plugin : BaseUnityPlugin
    {
        internal static new ManualLogSource Logger;
        Harmony harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            harmony.PatchAll();
        }
    }
}
