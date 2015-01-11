using UnityEngine;
using System.Collections;

public class FlowerProperties : MonoBehaviour {

    public enum Stages
    {
        seed,
        baby,
        normal
    }
    public enum CurrentStatus
    {
        alive,
        sick,
        dead
    }

    string lastPlayed;
    string flowerType;
    int level;
    int experiance;
    string stage;
    string status;
    int hunger;
    string hungerTime;
    int sun_rating;
    string sun_ratingTime;
    int water_rating;
    string water_ratingTime;
    string flowerPlanted;

	void Start () {
        gameObject.name = "properties" + gameObject.transform.parent.name;
	}
    public Stages stages;
    public CurrentStatus currentStatus;
    public string LastPlayed
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "lastPlayed");
        }
        set 
        {
            lastPlayed = value;
            PlayerPrefs.SetString(gameObject.name + "lastPlayed", lastPlayed);
        }
    }
    public string FlowerType
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "flowerType");
        }
        set
        {
            flowerType = value;
            PlayerPrefs.SetString(gameObject.name + "flowerType", flowerType);
        }
    }
    public int Experiance
    {
        get
        {
            return PlayerPrefs.GetInt(gameObject.name + "experiance"); 
        }
        set
        {
            experiance = value;
            PlayerPrefs.SetInt(gameObject.name + "experiance", experiance);
        }
    }
    public int Level
    {
        get
        {
            return PlayerPrefs.GetInt(gameObject.name + "level"); 
        }
        set
        {
            level = value;
            PlayerPrefs.SetInt(gameObject.name + "level", level);
        }
    }
    public string Stage
    {
        get 
        {
            return PlayerPrefs.GetString(gameObject.name + "stage");
        }
        set
        {
            stage = value;
            PlayerPrefs.SetString(gameObject.name + "stage", stage);
        }
    }
    public string Status
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "status");
        }
        set
        {
            status = value;
            PlayerPrefs.SetString(gameObject.name + "status", status);
        }
    }
    public int Hunger
    {
        get
        {
            return PlayerPrefs.GetInt(gameObject.name + "hunger"); 
        }
        set
        {
            hunger = value;
            PlayerPrefs.SetInt(gameObject.name + "hunger", hunger);
        }
    }
    public string HungerTime
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "hungerTime");
        }
        set
        {
            hungerTime = value;
            PlayerPrefs.SetString(gameObject.name + "hungerTime", hungerTime);
        }
    }
    public int Sun_rating
    {
        get
        {
            return PlayerPrefs.GetInt(gameObject.name + "sun_rating"); 
        }
        set
        {
            sun_rating = value;
            PlayerPrefs.SetInt(gameObject.name + "sun_rating", sun_rating);
        }
    }
    public string Sun_ratingTime
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "sun_ratingTime");
        }
        set
        {
            sun_ratingTime = value;
            PlayerPrefs.SetString(gameObject.name + "sun_ratingTime", sun_ratingTime);
        }
    }
    public int Water_rating
    {
        get
        {
            return PlayerPrefs.GetInt(gameObject.name + "water_rating"); 
        }
        set
        {
            water_rating = value;
            PlayerPrefs.SetInt(gameObject.name + "water_rating", water_rating);
        }
    }

    public string Water_ratingTime
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "water_ratingTime");
        }
        set
        {
            water_ratingTime = value;
            PlayerPrefs.SetString(gameObject.name + "water_ratingTime", water_ratingTime);
        }
    }
    public string FlowerPlanted
    {
        get
        {
            return PlayerPrefs.GetString(gameObject.name + "flowePlanted");
        }
        set
        {
            flowerPlanted = value;
            PlayerPrefs.SetString(gameObject.name + "flowePlanted", flowerPlanted);
        }
    }
}
