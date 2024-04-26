using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    void Update()
    {
        if ( Mouse.current.leftButton.isPressed)
        {
            _gun.Fire();
        }
    }
}
