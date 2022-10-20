using UnityEngine;
using UnityEngine.UI;
using System;


public class ButtonUI : MonoBehaviour
{

    public InputField speed, time, distance;
    [HideInInspector] public static float speedSpeed,  distanceDistance;
    [HideInInspector] public static int timeTime;

    public void GetVariable()
    {


       

       speedSpeed = float.Parse(speed.text );
       timeTime = int.Parse(time.text);
       distanceDistance = float.Parse(distance.text);
        
    


            
       // CreateCubs.time = timeTime;
    }
  
}
