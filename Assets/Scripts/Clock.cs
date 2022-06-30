using System;
using UnityEngine;
public class Clock: MonoBehaviour
{
    [SerializeField]
    public Transform hourAngle,minutrAngle,secondAngle;
    void Update()
    {
        Debug.Log(DateTime.Now);
        Debug.Log(DateTime.Now.Hour);
        int h = DateTime.Now.Hour;
        int m = DateTime.Now.Minute;
        int s = DateTime.Now.Second;
        hourAngle.localRotation=Quaternion.Euler(0, 0, -30*h);
        minutrAngle.localRotation = Quaternion.Euler(0, 0, -6*m);
        secondAngle.localRotation = Quaternion.Euler(0, 0, -6 * s);
    }
}