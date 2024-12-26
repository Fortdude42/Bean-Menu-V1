using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class Triggerplatforms
    {
        private static void CreatePlatform(Transform hand)
        {
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            if (hand == GorillaTagger.Instance.rightHandTransform)
                obj.name = "Right_PLATFORM";
            else if (hand == GorillaTagger.Instance.leftHandTransform)
                obj.name = "Left_PLATFORM";
            obj.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
            obj.GetComponent<Renderer>().material.color = Color.blue; // color of platforms
            obj.transform.position = hand.position;
            obj.transform.rotation = hand.rotation;
        }

        private static bool on_right;
        public static bool on_left;
        private static bool on_right_false;
        public static bool on_left_false;
        public static void Plats()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > .5f)
            {
                if (!on_right)
                {
                    CreatePlatform(GorillaTagger.Instance.rightHandTransform);
                    on_right = true;
                    on_right_false = false;
                }
            }
            else if (!on_right_false)
            {
                GameObject.Destroy(GameObject.Find("Right_PLATFORM"));
                on_right = false;
                on_right_false = true;
            }
            if (ControllerInputPoller.instance.leftControllerIndexFloat > .5f)
            {
                if (!on_left)
                {
                    CreatePlatform(GorillaTagger.Instance.leftHandTransform);
                    on_left = true;
                    on_left_false = false;
                }

            }
            else if (!on_left_false)
            {
                GameObject.Destroy(GameObject.Find("Left_PLATFORM"));
                on_left = false;
                on_left_false = true;
            }
        }
    }
}
