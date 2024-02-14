using OWML.Common;
using OWML.ModHelper;

namespace NoAchievements
{
    public class NoAchievements : ModBehaviour
    {
        private void Start()
        {
            ModHelper.HarmonyHelper.EmptyMethod<Achievements>(nameof(Achievements.Earn));
        }
    }

}
