using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    //declaração da variável material
    public Material materialC;

    //Método para quando algo "entrar" no seu colisor
    private void OnTriggerEnter(Collider collision)
    {
        //condicional para caso o onjeto colidido for o Player
        if (collision.gameObject.tag == "Player")
        {
            //pegando o componente material para alterar a cor do cubo (todos os materiais são definidos via Unity)
            GetComponent<Renderer>().material = materialC;
        }
    }
}
