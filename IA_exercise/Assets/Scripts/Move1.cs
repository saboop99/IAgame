using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    //declara��o da vari�vel speed
    public float speed = 2.0f;
    //declara��o da vari�vel accuracy
    public float accuracy = 0.00f;
    //declara��o da vari�vel Transform
    public Transform goal;

  
    // Update is called once per frame
    void Update()
    {
        //fazer o cubo olhar para a dire��o que ele est� indo
        this.transform.LookAt(goal.position);
        //delara��o da vari�vel direction e a opera��o matem�tica que a define
        Vector3 direction = goal.position - this.transform.position;
        //condicional para mover o cubo
        if(direction.magnitude > accuracy)
        {
            //opera��o matem�tica para mover o cubo
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
