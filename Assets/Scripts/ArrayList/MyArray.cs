using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{
	//Attributes
	public string[] daysArray = 
	{
		"lunes",
		"martes",
		"miercoles",
		"etc",
	};
	public GameObject[] objectArray = new GameObject[5];
	public GameObject[] objectArrayInspector;

	//Private
	private int index = 0;
	private int indexInspector = 0;

	//Method
   public void AddObject(GameObject newObject)
	{
		//Control de errores, para evitar insertar un elemento fuera del tamaño del array
		if (index < objectArray.Length)
		{
			objectArray[index] = newObject;
			index++;
		}

		//Control de errores, para evitar insertar un elemento fuera del tamaño del array
		if (indexInspector < objectArrayInspector.Length)
		{
			objectArrayInspector[indexInspector] = newObject;
			indexInspector++;
		}
	}
}
