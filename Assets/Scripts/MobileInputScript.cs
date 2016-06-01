using UnityEngine;
using System.Collections;

public class MobileInputScript : MonoBehaviour 
{

	public float speed = 15;
	public float jump = 3;

	CharacterController control;

	// Use this for initialization
	void Start () 
	{
		control = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = Input.acceleration.x * Time.deltaTime * speed;
		float z = -Input.acceleration.z * Time.deltaTime * speed;

		transform.Translate (x, 0f, z);

		foreach (Touch touch in Input.touches) 
		{

			//turning
			if (touch.position.x > Screen.width / 2) 
			{
				transform.Rotate (0f, touch.deltaPosition.x, 0f);
			}
		}
	}
}
