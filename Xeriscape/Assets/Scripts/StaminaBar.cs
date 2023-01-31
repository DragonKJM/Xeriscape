using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Image staminabar;

    public PlayerMovement PlayerMovement;

public void UpdateStaminaBar()
    {
        staminabar.fillAmount = PlayerMovement.stamina / PlayerMovement.staminaBase;
    }
}
