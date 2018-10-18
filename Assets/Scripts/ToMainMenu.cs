using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    [SerializeField] private float waitFor = 8f;

    void Start ()
	{
	    StartCoroutine(GoToMainMenu());
    }

    IEnumerator GoToMainMenu()
    {
        yield return new WaitForSeconds(waitFor);
        SceneManager.LoadScene("MainMenu");
    }
}
