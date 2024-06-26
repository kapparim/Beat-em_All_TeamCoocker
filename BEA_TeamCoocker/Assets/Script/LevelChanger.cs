using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public int levelToLoad;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            FadeToNextLevel();
        }
    }

    public void FadeToNextLevel()
    {
        Debug.Log("je suis dans le GameOver");
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel (int levelIndex)
    {
        levelToLoad = levelIndex;   
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
