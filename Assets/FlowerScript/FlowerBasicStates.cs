using UnityEngine;
using System.Collections;


public class FlowerBasicStates : MonoBehaviour {

    FlowerProperties flowerProperties;
    public Transform obj_flowerProperties;
	void Start () {
	}
	void Update () {
        if (obj_flowerProperties == null)
        {
            obj_flowerProperties = GameObject.Find("properties" + gameObject.transform.name).transform;
            flowerProperties = obj_flowerProperties.GetComponent<FlowerProperties>();
            Debug.Log(flowerProperties.LastPlayed + flowerProperties.FlowerType);
        }
	}
    void OnDestroy()
    {
        flowerProperties.LastPlayed = System.DateTime.Now.ToString();
    }
}
