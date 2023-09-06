using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
	public int limitObjects = 20;
	public List<GameObject> objectList = new List<GameObject>();
	public GameObject explosionPrefab;
	// Start is called before the first frame update

	public void AddObject(GameObject ball)
	{
		objectList.Add(ball);
		if (objectList.Count > limitObjects)
			ExplosionAll();
	}
	
	private void ExplosionAll()
	{
		//For generico para recorrer listas
		for (int i = 0; i < objectList.Count; i++)
		{
			Destroy(objectList[i]);
			Instantiate(explosionPrefab, objectList[i].transform.position, Quaternion.identity);
		}
		objectList.Clear();
	}
}
