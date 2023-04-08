using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    //declaração da variável speed e seu valor padrão que pode ser alterado por ser público
    public float speed = 4.0f;
    //declaração do array do Transform com todos os "goals" para fazer o cubo ir para várias direções
    public Transform[] Allgoals;
    //goal inicial (onde o cubo começar a sua rota)
    private int goal = 0;

    // Update is called once per frame
    void Update()
    {
        //operação matemática para mover o cubo até o ponto
        transform.position = Vector3.MoveTowards(transform.position, Allgoals[goal].position, speed * Time.deltaTime);

        //condicional para passar para o próximo ponto
        if (transform.position == Allgoals[goal].position)
        {
            //adicionando o próximo ponto na rota do cubo
            goal++;

            //condicional que caso o "goal" atual seja maior que o array total
            if(goal >= Allgoals.Length)
            {
                //define o "goal" atual como o quarto do array (penúltimo)
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
