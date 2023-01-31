using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float roationSpeed;
    private Vector2 direction;

    public float moveSpeedBase;
    public float moveSpeed;
    public float staminaBase;
    public float stamina;
    private bool boosting;

    public StaminaBar StaminaBar;

    private void Start()
    {
        stamina = staminaBase;
        moveSpeed = moveSpeedBase;
    }

    // Update is called once per frame
    void Update()
    {
        direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; // Calculates vector of mouseposition to object
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // converts vector into an angle 
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward); // converts angle into quaternion
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, roationSpeed * Time.deltaTime); //Interpolates object's direction for smoothness

        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, cursorPos, moveSpeed * Time.deltaTime);

        //boosting and stamina

        if (Input.GetMouseButtonDown(0))
        {
            boosting = true;
        }

        if (boosting)
        {
            moveSpeed = moveSpeedBase * 2.5f;
            stamina -= Time.deltaTime;

            if (stamina <= 0)
            {
                boosting = false;
            }

        }

        else if (!boosting)
        {
            moveSpeed = moveSpeedBase;

            if (stamina < staminaBase)
            {
                stamina += Time.deltaTime;
            }
        }

        StaminaBar.UpdateStaminaBar();

    }


}
