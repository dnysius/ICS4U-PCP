using UnityEngine;
using System.Collections;

public class GunAnimSound : MonoBehaviour {

	public float delayTime = 1f;
	private float counter = 0f;

	// Use this for initialization
	void Start () {

	}

	void Awake ()
	{
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown("Fire1") && counter > delayTime)
		{

			counter = 0;
		}
		counter += Time.deltaTime;
	}
}