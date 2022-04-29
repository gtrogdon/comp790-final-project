using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text uiElement;
    void Start()
    {
        uiElement.text = "Timer: " + GameState.getClock();
    }

    // Update is called once per frame
    void Update()
    {
        long time = GameState.decrementClock(Time.deltaTime);

        if (time<0)
        {
            SceneManager.LoadScene("GameOverScenes/GameOver");
        }

        uiElement.text = "Timer: " + time;

    }
}
