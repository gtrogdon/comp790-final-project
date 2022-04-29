using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CypherDoor : MonoBehaviour
{
    public CypherState stateTracker;
    public AudioSource doorVoice;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (stateTracker.solved)
            {
                GetComponent<AudioSource>().Stop();
                SceneManager.LoadScene(GameState.getNextScene());
            }
            else
            {
                if (!doorVoice.isPlaying)
                {
                    doorVoice.Play();
                }
            }
        }
    }
}

