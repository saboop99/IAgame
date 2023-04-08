using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    //declara��o da vari�vel speed e seu valor padr�o que pode ser alterado por ser p�blico
    public float speed = 4.0f;
    //declara��o do array do Transform com todos os "goals" para fazer o cubo ir para v�rias dire��es
    public Transform[] Allgoals;
    //goal inicial (onde o cubo come�ar a sua rota)
    private int goal = 0;

    // Update is called once per frame
    void Update()
    {
        //opera��o matem�tica para mover o cubo at� o ponto
        transform.position = Vector3.MoveTowards(transform.position, Allgoals[goal].position, speed * Time.deltaTime);

        //condicional para passar para o pr�ximo ponto
        if (transform.position == Allgoals[goal].position)
        {
            //adicionando o pr�ximo ponto na rota do cubo
            goal++;

            //condicional que caso o "goal" atual seja maior que o array total
            if(goal >= Allgoals.Length)
            {
                //define o "goal" atual como o quarto do array (pen�ltimo)
                goal = 3;

                //condicional para caso o objeto chegue em determinado ponto, ele para de se mover
                if (goal >= 3)
                {
                    enabled = false;
                }

            }
        }
    }
}
