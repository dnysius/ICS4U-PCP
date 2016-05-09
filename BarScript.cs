using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {
	
	public RigidbodyFPSWalker rfps;

	[SerializeField]
	private float fillAmount = 1;

	[SerializeField]
	private Image content;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		HandleBar ();
	}

	private void HandleBar(){
		
		content.fillAmount = (rfps.chaseLimit / rfps.limit);
	}
}
