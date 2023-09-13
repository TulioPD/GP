using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rb;
    StatChart statChart;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        statChart = GetComponent<Character>().Stats;
        // debug stats
        Debug.Log("Character stats:");
        Debug.Log(statChart.movementSpeed);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveTest();
    }


    void MoveTest()
    {

        // if movement input is not zero, move the character
        if (movementInput != null)
        {
            if (movementInput != Vector2.zero)
            {
                Debug.Log("Moving");
                Debug.Log(movementInput);
                Debug.Log(movementInput.normalized);
                Debug.Log(movementInput.normalized * Time.deltaTime);
                // move character depending on movement input and movement speed from StatChart
                rb.MovePosition(rb.position + movementInput.normalized * statChart.movementSpeed * Time.fixedDeltaTime);
            }
        }
    }

    private void OnMove(InputValue movementValue)
    {
        movementInput= movementValue.Get<Vector2>();
    }
}
