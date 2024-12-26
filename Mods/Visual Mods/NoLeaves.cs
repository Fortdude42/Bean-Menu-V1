using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Visual_Mods
{
    internal class NoLeaves
    {
        public static List<GameObject> leaves = new List<GameObject> { };
        public static void EnableRemoveLeaves()
        {
            foreach (GameObject g in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (g.activeSelf && (g.name.Contains("leaves_green") || g.name.Contains("fallleaves")))
                {
                    g.SetActive(false);
                    leaves.Add(g);
                }
            }
        }

        public static void DisableRemoveLeaves()
        {
            foreach (GameObject l in leaves)
            {
                l.SetActive(true);
            }
            leaves.Clear();
        }
    }
}
