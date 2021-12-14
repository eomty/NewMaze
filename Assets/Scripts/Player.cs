using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isGreenKey; //빠른 작업 및 리페터링. 오른족 마우스클릭. 하면 밑에  만들어짐
    public bool IsGreenKey { get => isGreenKey; set => isGreenKey = value; }
    void Start()
    {
        IsGreenKey = false;
    }

    void Update()
    {
        float moveZ = 0f;

        float moveX = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveZ += 1f;
        }


        if (Input.GetKey(KeyCode.S))
        {
            moveZ -= 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1f;
        }

        transform.Translate(new Vector3(moveX, 0f, moveZ) * 0.04f);
    }
}
