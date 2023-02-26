using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    public Camera cam;

    void Update ()
    {
	if (Input.GetButtonDown("Fire1"))
	{
	    SpawnPin();
	    cam.GetComponent<AudioSource>().Play();
	}
    }

    void SpawnPin()
    {
	Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
