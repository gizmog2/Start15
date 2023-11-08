using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 6.0f;
    [SerializeField] float jumpValue = 8.0f;
    [SerializeField] float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
       

    // Update is called once per frame
    void Update()
    {
        /// �������� ��������� CharacterController, ������� ���������� � �������� GameObject
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) /// ��������� ��� ������ �� �����
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            /// �������������� ��������� �������� ������� �� ��������� � ������� ����������
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;
            if (Input.GetButton("Jump")) /// �������� �� ������� ������ ������
            {
                /// ��� ������������ ����� � �������, �� ��������� �������
                moveDirection.y = jumpValue;
            }

        }

        /// �������� ����������
        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
