using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    [SerializeField] public float fadeTime = 2f;

    private Image fadePanel;
    private Color currentColor = Color.black;

	void Start ()
	{
        fadePanel = GetComponent<Image>();
	}
	
	void Update ()
	{
        DoFadeIn();
    }

    private void DoFadeIn()
    {
        if (Time.timeSinceLevelLoad < fadeTime)
        {
            float alphaChange = Time.deltaTime / fadeTime;

            currentColor.a -= alphaChange;
            fadePanel.color = currentColor;
        }

        else
        {
            gameObject.SetActive(false);
        }
    }
}
