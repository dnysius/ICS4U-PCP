using UnityEngine;
using System.Collections;

public class DestroyCubes : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
			Destroy (this.gameObject);
		} else if (col.gameObject.tag == "Terrain" || col.gameObject.tag == "Untagged") {
			Destroy (this.gameObject);
		} 
		else if (col.gameObject.tag == "Light Object") {
					
		}
		
	}
}