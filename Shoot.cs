using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
[RequireComponent (typeof (Animation))]


public class Shoot : MonoBehaviour
{

	public GameObject bullet;
	public float delayTime = 1f;
	private float counter = 0f; 

	// Use this for initialization
	void Start()
	{

	}
		
	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetButtonDown("Fire1") && counter > delayTime)
		{
			Instantiate(bullet, transform.position, transform.rotation);
			GetComponent<AudioSource>().Play();
			GetComponent<Animation>().Play();
			counter = 0;
		}
		counter += Time.deltaTime;
	}
}