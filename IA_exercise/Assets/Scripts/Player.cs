using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    //declaração da variável speed
    public float speed = 7f;

    void Update()
    {
        //achando o Axis Horizontal (A D)
        float horizontal = Input.GetAxis("Horizontal");
        //achando o Axis Vertical (W S)
        float vertical = Input.GetAxis("Vertical");

        //Cálculo da direção que meu objeto se move
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        //Cálculo da posição que meu objeto vai estar quando se mover
        transform.position += direction * speed * Time.deltaTime;

    }

    
}
