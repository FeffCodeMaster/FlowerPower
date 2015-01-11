using UnityEngine;
using System.Collections;


public class Water : MonoBehaviour {
    public enum Stages
    {
        ready,
        loading
    }
    
    int amountOfWater;
    
    int lastAmountOfWater;
    int count = 0;
    int restetCount = 10;
    float time = 5;
    float resetTime = 5;
    
    string waterMark;

    bool first = true;
    bool loadingFirst = true;
	void Start () {
        lastAmountOfWater = amountOfWater;
        stages = Stages.ready;
        for (int i = 0; i < AmountOfWater; i++)
        {
            if (i == 0 )
            {
                waterMark = "[]";
            }
            if (i != 0)
            {
                waterMark = waterMark + "[]";
            }
            gameObject.guiText.text = "water: " + "( x" + amountOfWater + " ) " + waterMark;
        }
	}
    public Stages stages;
	void Update () {
        if (lastAmountOfWater != amountOfWater || first || stages == Stages.ready)
        {
            for (int i = 0; i < amountOfWater; i++)
            {
                lastAmountOfWater = amountOfWater;
                if (i == 0 && amountOfWater > 0)
                {
                    waterMark = "[]";
                }
                if (i != 0 && amountOfWater > 0)
                {
                    waterMark = waterMark + "[]";
                }
               
            }
            first = false;
        }
        if(stages == Stages.loading)
        {
            loadingAnimation();
            
        }
        gameObject.guiText.text = "water: "+"( x" +AmountOfWater+" ) " + waterMark;
	}
    void loadingAnimation()
    {
        time -= Time.deltaTime;
        if (loadingFirst)
        {
            waterMark = ".";
            loadingFirst = false;
        }
        if (count < 0 && waterMark == ".")
        { 
            waterMark = "..";
            count = restetCount;
        }
        if (count < 0 && waterMark == "..")
        { 
            waterMark = "...";
            count = restetCount;
        }
        if (count < 0 && waterMark == "...")
        { 
            waterMark = ".";
            count = restetCount;
        }
        if (time < 0)
        {
            stages = Stages.ready;
            loadingFirst = true;
            time = resetTime;
        }
        count--;
    }
    public int AmountOfWater 
    {
        get
        {
            return PlayerPrefs.GetInt("amountOfWater");
        }
        set
        {
            amountOfWater = value;
            PlayerPrefs.SetInt("amountOfWater", amountOfWater);
        }
    }
}
