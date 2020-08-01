using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Surface : MonoBehaviour
{
    public void Dive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
    
    public void QuitGame()
    {
        Debug.Log("Bye-bye!");
        Application.Quit();
    }
}
