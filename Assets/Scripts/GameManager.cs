using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score = 0;

    [SerializeField] GameObject gameOverPanel;

    public Text scoreText;
    public Text scoreTextPanel;
    private void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        gameOver = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
        scoreTextPanel.text = "Score: "+score;
        gameOverPanel.SetActive(true);
    }

    public void IncrementScore(){
        if(!gameOver){
              score++;
        print(score);
        scoreText.text = score.ToString();
        }
      
    }

    public void MainMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void Restart(){
        SceneManager.LoadScene("Game");
    }
}
