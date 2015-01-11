using UnityEngine;
using System.Collections;
using System;

public class HungerEventManager : MonoBehaviour {

    FlowerProperties flowerProperties;
    Transform obj_flowerProperties;
    public int day, month, year, hour, minute;
    int monthStart, yearStart, hourStart, minuteStart;
	void Start () {
	
	}
	
	void Update () {
        if (obj_flowerProperties == null)
        {
            obj_flowerProperties = GameObject.Find("properties" + gameObject.transform.parent.name).transform;
            flowerProperties = obj_flowerProperties.GetComponent<FlowerProperties>();
            if (flowerProperties.HungerTime == null || flowerProperties.HungerTime == "")
            {
                flowerProperties.HungerTime = System.DateTime.Now.ToString();
                Debug.Log(flowerProperties.HungerTime);

                flowerProperties.HungerTime = "1/4/2015 22:00:00 PM";               
            }
        }
              
        DateTime time1 = new DateTime(2015, 5, 1, 21, 19, 00);
        DateTime time2 = new DateTime(2015, 5, 1, 21, 21, 00);
        TimeSpan durationTest = time1.Subtract(time2);
        Debug.Log(durationTest.TotalHours);
        TimeSpliter();
        System.DateTime dateTime = new System.DateTime(year, day, month, hour, minute, 0);
        TimeSpan duration = System.DateTime.Now.Subtract(dateTime);
        HungerEvent(duration);
        
	}
    void HungerEvent(TimeSpan duration)
    {
        if (duration.TotalMinutes > 0)
        {
            Debug.Log("hiit");
            flowerProperties.Hunger = flowerProperties.Hunger + 5000;
            if (hour == 23)
            {
                flowerProperties.HungerTime = new DateTime(year, day + 1, month, 0, minute, 0).ToString();
            }
            else
            {
                Debug.Log(hour);
                flowerProperties.HungerTime = new DateTime(year, day, month, hour + 1, minute, 0).ToString();
            }
            Debug.Log(flowerProperties.HungerTime);
        }
    }
    void TimeSpliter()
    {
        bool dayResult = int.TryParse(flowerProperties.HungerTime.Substring(0, 2), out day);
        if (dayResult) {            
            int.TryParse(flowerProperties.HungerTime.Substring(0, 2), out day);
            monthStart = 3;
        }
        if (!dayResult) { 
            int.TryParse(flowerProperties.HungerTime.Substring(0, 1), out day);
            monthStart = 2;
        }

        bool monthResult = int.TryParse(flowerProperties.HungerTime.Substring(monthStart, 2), out month);
        if (monthResult) { 
            int.TryParse(flowerProperties.HungerTime.Substring(monthStart, 2), out month);
            if (monthStart == 3)
                yearStart = 6;
            else
            yearStart = 5;
        }
        if (!monthResult) { 
            int.TryParse(flowerProperties.HungerTime.Substring(monthStart, 1), out month);
            if (monthStart == 3)
                yearStart = 5;
            else
            yearStart = 4;
        }

        int.TryParse(flowerProperties.HungerTime.Substring(yearStart, 4), out year);
        if (year != null)
            hourStart = yearStart + 5;

        bool hourResult = int.TryParse(flowerProperties.HungerTime.Substring(hourStart, 2), out hour);
        if (hourResult) { 
            int.TryParse(flowerProperties.HungerTime.Substring(hourStart, 2), out hour);
            minuteStart = hourStart + 3;
        }
        if (!hourResult) { 
            int.TryParse(flowerProperties.HungerTime.Substring(hourStart, 1), out hour);
            minuteStart = hourStart + 2;
        }

        bool minuteResult = int.TryParse(flowerProperties.HungerTime.Substring(minuteStart, 2), out minute);
        if (minuteResult)
            int.TryParse(flowerProperties.HungerTime.Substring(minuteStart, 2), out minute);
        if (!minuteResult)
            int.TryParse(flowerProperties.HungerTime.Substring(minuteStart, 1), out minute);

        Debug.Log(flowerProperties.HungerTime);
        
        
    }
}
