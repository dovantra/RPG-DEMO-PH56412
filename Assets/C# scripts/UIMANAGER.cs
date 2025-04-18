using UnityEngine;

public class UIMANAGER : MonoBehaviour
{
    public GameObject canvasStartGame;
    bool pauseGame= false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartGame()
    {
         canvasStartGame.SetActive(false);

    }

  public void PauseGame()
    {
       pauseGame = !pauseGame;
        if (pauseGame)
        {

            Time.timeScale = 0f;
        }
        else {

            Time.timeScale = 1f;
        
        }


    }
    // Update is called once per frame
    void Update()
    {
        

    }
}
