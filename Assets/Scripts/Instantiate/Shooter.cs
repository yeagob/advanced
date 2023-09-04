using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

	[Header("Movement")]
	public float speedRotation = 100;

	[Header("Shoot")]
	public Transform spawnPoint;
	public Ball ballPrefab;
	public float shootForce = 1000;

	//Private
	private Quaternion initialRotation;

	private void Awake()
	{
		initialRotation = transform.rotation;
	}
	private void Start()
	{
		Invoke(nameof(InitialConfiguration), 0.1f);
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update()
	{
		//Movement
		transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * speedRotation * Vector3.left);
		transform.Rotate(Input.GetAxis("Mouse X") * Time.deltaTime * speedRotation * Vector3.up);
		transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, 0);//Clamp Rotation

		//Spawn & Addforce
		if (Input.GetMouseButtonUp(0))
		{
			Ball ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
			ball.myRigidbody.AddForce(transform.forward * shootForce);
		}
	}

	void InitialConfiguration()
	{
		transform.rotation = initialRotation;
	}
}
