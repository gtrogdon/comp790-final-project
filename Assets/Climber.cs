using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{

    private CharacterController character;
    public XRController climbingHand;
    private ContinuousMovement continuousMovement;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        continuousMovement = GetComponent<continuousMovement>();
    }

    // Update is called once per frame
    void Fixedupdate()
    {
        
    }
}
