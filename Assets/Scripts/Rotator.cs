using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    public GameObject objRotator;

    void Update ()
    {
	transform.Rotate(0f, 0f, GameManager.rSpeed * Time.deltaTime);
    }

    void Start ()
    {
	if (GameManager.colorValue == 1)
	{
	    objRotator.GetComponent<SpriteRenderer>().color = Color.red;
	}
	else if (GameManager.colorValue == 2)
	{
	    objRotator.GetComponent<SpriteRenderer>().color = Color.blue;
	}
	else if (GameManager.colorValue == 3)
	{
	    objRotator.GetComponent<SpriteRenderer>().color = Color.black;
	}
    }

}
