using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class AirSwim
    {
        public static GameObject airSwimPart = null;
        public static void airSwim()
        {
            if (airSwimPart == null)
            {
                airSwimPart = UnityEngine.Object.Instantiate<GameObject>(GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToBeach/ForestToBeach_Prefab_V4/CaveWaterVolume"));
                airSwimPart.transform.localScale = new Vector3(5f, 5f, 5f);
                airSwimPart.GetComponent<Renderer>().enabled = false;
            }
            else
            {
                GorillaLocomotion.Player.Instance.audioManager.UnsetMixerSnapshot(0.1f);
                airSwimPart.transform.position = GorillaTagger.Instance.headCollider.transform.position + new Vector3(0f, 2.5f, 0f);
            }
        }

        public static void DisableAirSwim()
        {
            if (airSwimPart != null)
            {
                UnityEngine.Object.Destroy(airSwimPart);
            }
        }
    }
}
