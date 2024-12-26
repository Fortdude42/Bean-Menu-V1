using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BeanMenuV1.Mods
{
    internal class RightGripFly
    {
        public static void GripFly()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.Player.Instance.transform.position += (GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime) * 15;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
