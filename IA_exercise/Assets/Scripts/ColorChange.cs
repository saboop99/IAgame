using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    //declara��o da vari�vel material
    public Material materialC;

    //M�todo para quando algo "entrar" no seu colisor
    private void OnTriggerEnter(Collider collision)
    {
        //condicional para caso o onjeto colidido for o Player
        if (collision.gameObject.tag == "Player")
        {
            //pegando o componente material para alterar a cor do cubo (todos os materiais s�o definidos via Unity)
            GetComponent<Renderer>().material = materialC;
        }
    }
}
