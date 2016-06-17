using UnityEngine;
using System.Collections;

public class WoodDestruction : MonoBehaviour
{
    public static bool initialHit = false;
    public static bool woodDestroy = false;
    public static bool hitWoodAbove = false;
    public GameObject debrisPrefab;
    [SerializeField]private int destructionStage = 0;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        if (initialHit == true)
        {
            destructionStage += 1;
            Debug.Log(destructionStage);
            initialHit = false;
        }

        if (destructionStage == 3 && hitWoodAbove == false)
        {   
            // setting up position of debris such that it doesnt spawn in the air, rather on the ground
            transform.position = new Vector3(transform.position.x, -0.5f, transform.position.z);
            Instantiate(debrisPrefab, transform.position, transform.rotation);

            // switching woodDestroy true which effects BulletHole script, destroying bulletholes on the wall at the same time the wall breaks
            woodDestroy = true;
            Destroy(this.gameObject);
        }
        if (destructionStage == 3 && hitWoodAbove == true)
        {
            Instantiate(debrisPrefab, transform.position, transform.rotation);
            woodDestroy = true;
            Destroy(this.gameObject);
        }
        else
        {
            woodDestroy = false;
        }
    }
}
