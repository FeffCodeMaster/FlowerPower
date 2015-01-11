using UnityEngine;
using System.Collections;

public class Hose : MonoBehaviour {
    Water water;
    FlowerProperties flowerProperties;
    Transform obj_flowerProperties, obj_water;
	void Start () {
        obj_water = GameObject.FindGameObjectWithTag("water").transform;
        water = obj_water.GetComponent<Water>();
	}
	
	// Update is called once per frame
	void Update () {
        if (obj_flowerProperties == null)
        {
            obj_flowerProperties = GameObject.Find("properties" + gameObject.transform.parent.name).transform;
            flowerProperties = obj_flowerProperties.GetComponent<FlowerProperties>();
        }
        if (gameObject.guiText.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0) && water.stages == Water.Stages.ready)
        {
            userHosingFlower();    
        }
	}
    void userHosingFlower()
    {
        flowerProperties.Water_rating++;
        water.AmountOfWater = water.AmountOfWater - 2;
        water.stages = Water.Stages.loading;
    }
}
