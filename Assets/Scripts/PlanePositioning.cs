using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePositioning : MonoBehaviour {


    public GameObject corner1, corner2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 distance = (corner1.transform.position - corner2.transform.position);
        Vector3 new_pos = corner2.transform.position + distance * 0.5f;

        distance.x = Mathf.Abs(distance.x);
        distance.z = Mathf.Abs(distance.z);
        distance = distance / 8;
        distance.y = 1;
        transform.position = new_pos;
        transform.localScale = distance;
        Debug.Log(new_pos.ToString() + " \\ " + corner1.transform.position.ToString() + " \\ " + corner2.transform.position.ToString());
    }
}
