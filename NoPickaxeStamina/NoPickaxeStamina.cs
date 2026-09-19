using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace NoPickaxeStamina;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
internal class NoPickaxeStamina : BaseUnityPlugin
{
    public const string PluginGUID = "orax.NoPickaxeStamina";
    public const string PluginName = "NoPickaxeStamina";
    public const string PluginVersion = "0.1.0";

    private Harmony _harmony;

    private void Awake()
    {
        // Initialize and apply all Harmony patches declared in this assembly.
        _harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGUID);
    }

    private void OnDestroy()
    {
        // Unpatch all modifications when the plugin is destroyed.
        _harmony?.UnpatchSelf();
    }
}

