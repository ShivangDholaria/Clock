using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    //Initial GameObject defination
    [SerializeField]
    Transform hourPivot, minutePivot, secondPivot;

    const float HOURSTODEGREES = -30f, MINUTESTODEGREES= -6f, SECONDTODEGREES= -6f;
    TimeSpan time;
    DateTime date;

    // Update is called once per frame
    void Update()
    {
        //For smooth animation

        time = DateTime.Now.TimeOfDay;
        hourPivot.localRotation = Quaternion.Euler(0, 0, HOURSTODEGREES * (float) time.TotalHours);
        minutePivot.localRotation = Quaternion.Euler(0, 0, MINUTESTODEGREES * (float) time.TotalMinutes);
        secondPivot.localRotation = Quaternion.Euler(0, 0, SECONDTODEGREES * (float)time.TotalSeconds);

        //For ticking type animation

        //date = DateTime.Now;
        //hourPivot.localRotation = Quaternion.Euler(0, 0, HOURSTODEGREES * date.Hour);
        //minutePivot.localRotation = Quaternion.Euler(0, 0, MINUTESTODEGREES * date.Minute);
        //secondPivot.localRotation = Quaternion.Euler(0, 0, SECONDTODEGREES * date.Second);
    }
}
