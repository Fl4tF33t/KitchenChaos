using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //Seperate the visuals from the logic
    //The visual scripts are set on the visual components of the object
    //uses the animator, and depends of the state machine of the player code to determine it's state

    private Player player;
    private Animator animator;
    private const string IS_WALKING = "IsWalking";

    // separated animation system that is decoupled from the logic
    private void Awake()
    {
        animator = GetComponent<Animator>();
        player = GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
