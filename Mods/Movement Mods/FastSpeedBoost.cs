using System;
using System.Collections.Generic;
using System.Text;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class FastSpeedBoost
    {
        public static void fastSpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 15f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 15f;
        }
    }
}
