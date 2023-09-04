using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Head : MonoBehaviour
{
	[System.NonSerialized]
    public Rigidbody myRigidbody;

	private void Awake()
	{
		myRigidbody = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start()
    {
        print("hello " + name);
    }
	
	public void AddForce(float force)
	{
        GetComponent<Rigidbody>().AddForce(0, force, 0);
	}
}
