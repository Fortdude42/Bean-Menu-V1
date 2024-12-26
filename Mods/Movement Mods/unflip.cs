using System;
using System.Collections.Generic;
using System.Text;
using Unity.Mathematics;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class unflip
    {
        public static void UnflipCharacter()
        {
            GorillaLocomotion.Player.Instance.rightControllerTransform.parent.rotation = Quaternion.identity;
        }

    }
}
