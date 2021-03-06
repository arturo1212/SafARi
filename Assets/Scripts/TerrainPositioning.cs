﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainPositioning : MonoBehaviour {

    public GameObject corner1, corner2;
    Terrain terrain, aux_terrain;
    Vector3 start_size;
	// Use this for initialization
	void Start () {
        terrain = GetComponent<Terrain>();
        start_size = terrain.terrainData.size;
    }

    // Update is called once per frame
    void Update () {
        Vector3 distance = (corner1.transform.position - corner2.transform.position);   // Distancia entre los dos cubitos (x,y,z)
        transform.position = corner1.transform.position;    // Ubicar la esquina junto al cubito.
        corner2.transform.position = new Vector3(73, 0, 73);
        distance.x = Mathf.Abs(distance.x);
        distance.z = Mathf.Abs(distance.z);
        distance.y = 1;
        terrain.terrainData.size = distance;
       // Debug.Log(distance);
    }
    void OnApplicationQuit()
    {
        terrain.terrainData.size = start_size;
    }
}
