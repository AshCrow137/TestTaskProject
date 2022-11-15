using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private PlayerMovement movement;

    private void Start()
    {
        movement = PlayerMovement.Instance;
    }
    private void FixedUpdate()

    {
        if (movement)
        {


            //����������� �������� ������ � �������������� �������� ������������� ���������, ����� ��� ��������� ��� ��������, �������� � �������� ������
            transform.position = new Vector3(movement.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            movement = PlayerMovement.Instance;
        }
    }
}
