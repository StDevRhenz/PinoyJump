using UnityEngine;
using UnityEngine.SceneManagement;

public class HomepageController : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Script is Gumagana");
    }

    void Update()
    {
        
    }

    public void gotoGameView()
    {
        //to open new Scene
       SceneManager.LoadScene(SceneData.gameview);
    }
}
