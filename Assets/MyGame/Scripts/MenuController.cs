using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{
    private const string SceneName = "MainScene";
    
    public void Play(){
        SceneManager.LoadScene("MainScene");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
