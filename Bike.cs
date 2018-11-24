using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour {

    public GameObject bikeItem;

	void Update ()
    {
        if (Input.GetKeyDown("e"))
        {
            GameObject.FindGameObjectsWithTag("Player");
            transform.Translate(5f, 0f, 0f);
            //transform.position = FindGameObject("bikeItem");
        }
	}
}       
