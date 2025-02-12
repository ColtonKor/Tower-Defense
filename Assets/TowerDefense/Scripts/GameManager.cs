using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameIsOver = false;
    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    void Start(){
        gameIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameIsOver){
            return;
        }

        if(Input.GetKeyDown("e")){
            EndGame();
        }

        if(PlayerStats.Lives <= 0){
            EndGame();
        }
    }

    void EndGame(){
        gameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel(){
        gameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
