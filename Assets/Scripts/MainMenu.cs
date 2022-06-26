using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    [SerializeField] PlayerState playerState;

    readonly Dictionary<int, int> sceneLevel = new Dictionary<int, int>
    {
        {2, 11},
        {3, 27},
        {4, 66},
    };

    public void LoadLevel(int sceneIndex) {
        PlayerPrefs.SetInt("level", sceneLevel[sceneIndex]);
        playerState.Load();
        SceneManager.LoadScene(sceneIndex);
    }
}
