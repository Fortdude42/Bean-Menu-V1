using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Bean_Menu_V1.Mods.Movement_Mods
{
    internal class TriggerFLy
    {
        public static void triggerFly()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
