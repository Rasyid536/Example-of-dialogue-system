using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{

    public Dialogue dialogue;
    public int gameEnd;
    public GameObject Exit;
    void Update()
    {
        if (dialogue.index > gameEnd)
        {
            SceneManager.LoadScene("StartingScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("1");
            if (!Exit.activeInHierarchy)
            {
                Exit.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene("StartingScene");
            }
        }

        if (Exit.activeInHierarchy && Input.GetKeyDown(KeyCode.Space))
        {
            Exit.SetActive(false);
        }
    }
}
