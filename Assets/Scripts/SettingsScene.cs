using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void SettingsFunction ()
    {
	SceneManager.LoadScene("SettingsLevel");
    }
}
