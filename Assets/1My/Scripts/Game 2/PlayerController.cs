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
        /// Получаем компонент CharacterController, который прикреплен к текущему GameObject
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) /// Проверяем или обьект на земле
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            /// Преобразование координат текущего обьекта из локальных в мировые координаты
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;
            if (Input.GetButton("Jump")) /// Проверка на нажатие кропки прыжка
            {
                /// Тут выставляется выста У вектора, не положение обьекта
                moveDirection.y = jumpValue;
            }

        }

        /// Отномаем гравитацию
        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
    }
}
