using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Haven.Classes
{
    internal class GunLibary
    {
        // Important Gun Stuff
        public static GameObject Pointer;
        public static bool GunTriggered = false;
        public static Color GunColorOn = Color.yellow;// change the "Color.blue" to any color u like (ex: red, yellow, green, blue ect)
        public static Color GunColorOff = Color.white;

        public static void GunLib()
        {
            Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var Pos);
            {
                GunLibary.Pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GunLibary.Pointer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                GunLibary.Pointer.transform.position = Pos.point;
                {
                    GunLibary.GunColorOff.a = 0.5f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOff;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                }
                GameObject Line = new GameObject("Line");
                LineRenderer GunLine = Line.AddComponent<LineRenderer>();
                GunLine.material.shader = Shader.Find("GUI/Text Shader");
                GunLine.startColor = GunLibary.GunColorOff;
                GunLine.endColor = GunLibary.GunColorOff;
                GunLine.startWidth = 0.011f;
                GunLine.endWidth = 0.011f;
                GunLine.positionCount = 2;
                GunLine.useWorldSpace = true;
                GunLine.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                GunLine.SetPosition(1, Pos.point);
                {
                    UnityEngine.Object.Destroy(GunLine, Time.deltaTime);
                    UnityEngine.Object.Destroy(GunLibary.Pointer, Time.deltaTime);
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<Collider>());
                }
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
                {
                    GunLibary.GunTriggered = true;
                }
                else
                {
                    GunLibary.GunTriggered = false;
                }
                if (GunTriggered)
                {
                    GunLibary.GunColorOn.a = 0.3f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOn;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    GunLine.startColor = GunLibary.GunColorOn;
                    GunLine.endColor = GunLibary.GunColorOn;
                    GunLibary.GunTriggered = true;
                }
                else
                {
                    GunLibary.GunColorOff.a = 0.5f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOff;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    GunLine.startColor = GunLibary.GunColorOff;
                    GunLine.endColor = GunLibary.GunColorOff;
                    GunLibary.GunTriggered = false;
                }
            }
        }
        public static void GunLibleft()
        {
            Physics.Raycast(GorillaLocomotion.Player.Instance.leftControllerTransform.position, -GorillaLocomotion.Player.Instance.leftControllerTransform.up, out var Pos);
            {
                GunLibary.Pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GunLibary.Pointer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                GunLibary.Pointer.transform.position = Pos.point;
                {
                    GunLibary.GunColorOff.a = 0.5f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOff;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                }
                GameObject Line = new GameObject("Line");
                LineRenderer GunLine = Line.AddComponent<LineRenderer>();
                GunLine.material.shader = Shader.Find("GUI/Text Shader");
                GunLine.startColor = GunLibary.GunColorOff;
                GunLine.endColor = GunLibary.GunColorOff;
                GunLine.startWidth = 0.011f;
                GunLine.endWidth = 0.011f;
                GunLine.positionCount = 2;
                GunLine.useWorldSpace = true;
                GunLine.SetPosition(0, GorillaTagger.Instance.leftHandTransform.position);
                GunLine.SetPosition(1, Pos.point);
                {
                    UnityEngine.Object.Destroy(GunLine, Time.deltaTime);
                    UnityEngine.Object.Destroy(GunLibary.Pointer, Time.deltaTime);
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(GunLibary.Pointer.GetComponent<Collider>());
                }
                if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f)
                {
                    GunLibary.GunTriggered = true;
                }
                else
                {
                    GunLibary.GunTriggered = false;
                }
                if (GunTriggered)
                {
                    GunLibary.GunColorOn.a = 0.3f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOn;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    GunLine.startColor = GunLibary.GunColorOn;
                    GunLine.endColor = GunLibary.GunColorOn;
                    GunLibary.GunTriggered = true;
                }
                else
                {
                    GunLibary.GunColorOff.a = 0.5f;
                    GunLibary.Pointer.GetComponent<Renderer>().material.color = GunLibary.GunColorOff;
                    GunLibary.Pointer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    GunLine.startColor = GunLibary.GunColorOff;
                    GunLine.endColor = GunLibary.GunColorOff;
                    GunLibary.GunTriggered = false;
                }
            }
        }
    }
}