using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    //declaração da variável speed
    public float speed = 2.0f;
    //declaração da variável accuracy
    public float accuracy = 0.00f;
    //declaração da variável Transform
    public Transform goal;

  
    // Update is called once per frame
    void Update()
    {
        //fazer o cubo olhar para a direção que ele está indo
        this.transform.LookAt(goal.position);
        //delaração da variável direction e a operação matemática que a define
        Vector3 direction = goal.position - this.transform.position;
        //condicional para mover o cubo
        if(direction.magnitude > accuracy)
        {
            //operação matemática para mover o cubo
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
