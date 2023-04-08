using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    //declara��o da vari�vel speed
    public float speed = 7f;

    void Update()
    {
        //achando o Axis Horizontal (A D)
        float horizontal = Input.GetAxis("Horizontal");
        //achando o Axis Vertical (W S)
        float vertical = Input.GetAxis("Vertical");

        //C�lculo da dire��o que meu objeto se move
        Vector3 direction = new Vector3(horizontal, 0f, vertical);

        //C�lculo da posi��o que meu objeto vai estar quando se mover
        transform.position += direction * speed * Time.deltaTime;

    }

    
}
