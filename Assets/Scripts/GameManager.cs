using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public static string userName;
    public static int score;
    public static int highScore;

    public static float rSpeed;
    public static float pSpeed;

    public static int colorValue;


    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public Dropdown ColorDropdown;

    public void EndGame ()
    {
	if (gameHasEnded)
	    return;

	gameHasEnded = true;
    rotator.enabled = false;
	spawner.enabled = false;

        animator.SetTrigger("EndGame");
    }

    public void RestartLevel ()
    {
	SceneManager.LoadScene("OutroScene");
    }

    public void ChooseColor()
    {
        switch (ColorDropdown.value)
        {
            case 1:
                colorValue = ColorDropdown.value;
                break;
            case 2:
                colorValue = ColorDropdown.value;
                break;
            case 3:
                colorValue = ColorDropdown.value;
                break;
            default:
                colorValue = ColorDropdown.value;
                break;
        }
    }

}
