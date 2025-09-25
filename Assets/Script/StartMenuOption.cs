using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuOption : MonoBehaviour
{

    public int IsWarning;
    public AudioSource audioSource;
    [SerializeField]private GameObject Warnings;


    void Start()
    {
        IsWarning = 0;
        IsWarning = PlayerPrefs.GetInt("IsWarning");
        Debug.Log(IsWarning);
        if(IsWarning>0)
        {
            Warnings.SetActive(false);
        }
        audioSource.Play();
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exit();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.DeleteAll();
        }
    
    }



    

//Scene Manage
    public void Exit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("kjhjh");
    }
//Scene manage


    void SaveGame()//Save Function
    {
        PlayerPrefs.SetInt("IsWarning", 1);
    }


//Warning
    public void Warning()
    {
        Warnings.SetActive(false);
        SaveGame();

    }
//Warning
    
  
}
