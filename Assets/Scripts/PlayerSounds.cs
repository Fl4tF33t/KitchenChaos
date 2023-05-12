using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private Player player;
    private float footsteptimer;
    private float footsteptimerMax =.1f;
    private float volume = 1f;

    private void Awake()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        footsteptimer -= Time.deltaTime;
        if(footsteptimer < 0)
        {
            footsteptimer = footsteptimerMax;

            if (player.IsWalking())
            {
                SoundManager.Instance.PlayFootstepSound(player.transform.position, volume);
            }
        }
    }
}
