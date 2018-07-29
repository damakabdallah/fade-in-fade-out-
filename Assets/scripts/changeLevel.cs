using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour {

    public Animator animator;
    static bool onlyOnce=false;
    void Awake()
    {
        //working only once when launching the game
        if (onlyOnce == false)
            onlyOnce = true;
        //working all the rest of time
        else
            animator.SetTrigger("fadeIn");
    }
    public void changeScene (string sceneName)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(waitUntilFadeEnded(sceneName));
    }
    IEnumerator waitUntilFadeEnded(string sceneName)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneName);
    }
}
