using UnityEngine;
using System.Collections;

public class StatsText : MonoBehaviour {

    FlowerProperties flowerProperties;
    public Transform obj_flowerProperties;
	void Start () {
	}
	void Update () {
        if (obj_flowerProperties == null) 
        { 
        obj_flowerProperties = GameObject.Find("properties" + gameObject.transform.parent.name).transform;
        flowerProperties = obj_flowerProperties.GetComponent<FlowerProperties>();
        }
        ChooseText();
	}
    void ChooseText()
    {
        string objectName = gameObject.name;
        if (gameObject.name == "flowerType")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.FlowerType;
        if (gameObject.name == "experience")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Experiance;
        if(gameObject.name == "level")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Level;
        if (gameObject.name == "stage")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Stage;
        if (gameObject.name == "status")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Status;
        if (gameObject.name == "hunger")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Hunger;
        if (gameObject.name == "sun_rating")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Sun_rating;
        if (gameObject.name == "water_rating")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.Water_rating;
        if (gameObject.name == "flowerPlanted")
            gameObject.guiText.text = gameObject.name + ": " + flowerProperties.FlowerPlanted;

    }
}
