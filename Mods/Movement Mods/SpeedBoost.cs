using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoost
    {

        public static void SpeedBoostmod()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 8f;
        }
    }
}
