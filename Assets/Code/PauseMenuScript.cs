using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{

    void Start()
    {
        MenuOpened();
    }
    
    public void MenuOpened()
    {
       StartCoroutine(DoFadeIn());
    }
    
    public void MenuClosed()
    {
        StartCoroutine(DoFadeOut());
    }

    private float elapsedTime = 0;
    
    IEnumerator DoFadeOut()
    {
        elapsedTime = 0.5f;
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while(elapsedTime > 0.0f)
        {
            elapsedTime -= Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01(elapsedTime / 0.5f);
            print(canvasGroup.alpha);
            yield return null;
        }
        //Destroy(gameObject);
        yield return null;
    }
    
    IEnumerator DoFadeIn()
    {
        elapsedTime = 0;
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while(elapsedTime <= 0.5f)
        {
            elapsedTime += Time.deltaTime;
            canvasGroup.alpha = Mathf.Clamp01((elapsedTime / 0.5f));
            print(canvasGroup.alpha);
            yield return null;
        }

        yield return null;
    }
}
