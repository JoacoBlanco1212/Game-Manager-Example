using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChanceScenes("Game");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChanceScenes("Menu");
        }
    }

    public void ChanceScenes(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
