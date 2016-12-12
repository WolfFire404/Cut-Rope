using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {


	void Start ()
    {
	
	}
	

	void Update ()
    {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Star")
        {
            Destroy(other.gameObject);
        }
    }

}

