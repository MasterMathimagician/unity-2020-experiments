using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void JumpToMainScene()
    {
        SceneManager.LoadScene("_MainScene", LoadSceneMode.Single);
    }

    public static void JumpToScene1()
    {
        SceneManager.LoadScene("TransferScene1", LoadSceneMode.Single);
    }

    public static void JumpToScene2()
    {
        SceneManager.LoadScene("TransferScene2", LoadSceneMode.Single);
    }

    public static void JumpToButtonGame()
    {
        SceneManager.LoadScene("ButtonGame", LoadSceneMode.Single);
    }
}
