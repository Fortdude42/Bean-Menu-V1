using System;
using System.Collections.Generic;
using System.Text;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class SteamLongArms
    {
        public static void steamLongArms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new UnityEngine.Vector3(1.2f, 1.2f, 1.2f);
        }
    }
}
