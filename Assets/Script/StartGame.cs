using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

    FlowerProperties flowerProperties;
    Transform obj_flowerProperties;
    public string flowerType;
  
	void Start () {

	}
	
	void Update () {
        if (obj_flowerProperties == null)
        {
            obj_flowerProperties = GameObject.Find("properties" + gameObject.transform.parent.name).transform;
            flowerProperties = obj_flowerProperties.GetComponent<FlowerProperties>();
        }
        else
        {
            if (gameObject.guiText.HitTest(Input.mousePosition) && Input.GetMouseButtonDown(0))
            {
                flowerProperties.FlowerType = flowerType;
                flowerProperties.Stage = FlowerProperties.Stages.seed.ToString();
                flowerProperties.Status = FlowerProperties.CurrentStatus.alive.ToString();
                flowerProperties.Hunger = 5;
                flowerProperties.Sun_rating = 5;
                flowerProperties.Water_rating = 5;
                flowerProperties.FlowerPlanted = System.DateTime.Now.ToString();
                Destroy(gameObject);
            }
        }
        if(flowerProperties.FlowerPlanted != "")
           Destroy(gameObject);
	}
}
