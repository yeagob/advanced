using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperCorrutine : MonoBehaviour
{
    //Attributes    
    public GameObject ballPrefab;
    public float minRange = 0;
    public float maxRange = 2;

    //Private
    private MyArray myArray;
    private Listas myListas;
    
    //Methods
    private void Awake()
    {
        myArray = GetComponent<MyArray>();
        myListas = GetComponent<Listas>();
    }

    // Start is called before the first frame update
    void Start()
    {
        float repeatRate = Random.Range(minRange, maxRange);
        StartCoroutine(Drop(repeatRate));
    }

    IEnumerator Drop(float rateTime)
	{
		//Espera de un frame
		//yield return null;
        
		while (true)
		{
            yield return new WaitForSeconds(rateTime);
            //Solo el 33% de las veces se instancian
            float probability = Random.Range(0, 3);
            if (probability == 0)
			{
                GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);
                //Si el componente existe
                if (myArray != null)
                    myArray.AddObject(ball);
                if (myListas != null)
                    myListas.AddObject(ball);
            }
        }
    }

}
