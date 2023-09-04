using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class GetComponents : MonoBehaviour
{
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            GetComponent<MeshRenderer>().material.color = color;

        if (Input.GetKeyUp(KeyCode.Space))
		{
            GetComponentInChildren<Head>().transform.Translate(1, 0, 0);
            GetComponent<Rigidbody>().AddForce(0, 500, 0);
            GetComponentInChildren<Head>().AddForce(500);
            //GetComponentInChildren<MeshRenderer>().enabled = false;
            Camera.main.fieldOfView *= 2;
            Camera.main.transform.Translate(0, 0, 5);
        }

    }
}
