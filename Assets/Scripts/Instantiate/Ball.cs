using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Attributes
    [System.NonSerialized]
    public Rigidbody myRigidbody;

	private void Awake()
	{
        myRigidbody = GetComponent<Rigidbody>();
    }
	
}
