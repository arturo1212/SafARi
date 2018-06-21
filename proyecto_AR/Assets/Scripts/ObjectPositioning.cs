using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPositioning : MonoBehaviour {

    public GameObject plane;
    public Vector3 start_scale;
	// Use this for initialization
	void Start () {
        start_scale = transform.localScale;

    }
	
	// Update is called once per frame
	void Update () {
        transform.localScale = Vector3.Scale(start_scale,plane.transform.localScale);
        Vector3 aux = transform.localScale;
        aux.y = start_scale.y + Vector3.SqrMagnitude(transform.localScale)/2;
        transform.localScale = aux;
	}
}
