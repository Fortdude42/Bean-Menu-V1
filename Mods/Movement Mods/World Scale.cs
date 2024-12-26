using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BeanMenuV1.Mods
{
    internal class World_Scale // iidks code
    {
        public static void WorldScale(GameObject obj, Vector3 targetWorldScale)
        {
            Vector3 parentScale = obj.transform.parent.lossyScale;
            obj.transform.localScale = new Vector3(
                targetWorldScale.x / parentScale.x,
                targetWorldScale.y / parentScale.y,
                targetWorldScale.z / parentScale.z
            );
        }
    }
}
