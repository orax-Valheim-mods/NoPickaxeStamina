using HarmonyLib;

namespace NoPickaxeStamina;

internal class Patch
{
    /// <summary>
    /// Alters stamina of weapons
    /// </summary>
    [HarmonyPatch(typeof(Attack), nameof(Attack.GetAttackStamina))]
    public static class Attack_GetAttackStamina_Patch
    {
        private static void Postfix(ref Attack __instance, ref float __result)
        {
            if (__instance.m_character?.GetCurrentWeapon()?.m_shared?.m_skillType == Skills.SkillType.Pickaxes)
            {
                __result = 0f;
            }
        }
    }
}
