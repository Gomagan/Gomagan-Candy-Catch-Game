using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static PlayerControls playerControls;
    public static void Initial(PlayerScript player)
    {
        playerControls = new PlayerControls();
        playerControls.InGame.Enable();
        playerControls.InGame.Movement.Enable();
        playerControls.InGame.Movement.performed += ctx =>
        {
            player.SetMovementDirection(ctx.ReadValue<Vector2>());
        };
    }


}
