using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Underwater : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Bye-bye!");
        Application.Quit();
    }
}
