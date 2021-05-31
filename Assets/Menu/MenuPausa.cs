using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
   public static bool GamePause = false;
   
   public GameObject pauseMenu;

    public static bool dashPause = false;
    

     public GameObject dashMenu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("AAA");
            if(GamePause==true)
            {
                Resume();
            }else{
                Pause();
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(GamePause=true)
            {
                Resume1();
            }
        }
    }





    public void Resume ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    public void Resume1 ()
    {
        dashMenu.SetActive(false);
        Time.timeScale = 1f;
        dashPause = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MAIN MENU");
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
