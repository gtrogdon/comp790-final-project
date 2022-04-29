using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{

    private int counter = 0;
    private int updater = 1;

    private void start()
    {

    }

    private void update()
    {
        if(counter == 300)
        {
            counter = 0;
            updater = updater * -1;
        }
        transform.position += new Vector3(3 * updater, 0, 0);
        counter += 1;
    }
}
