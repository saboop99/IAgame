using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //declara��o da v�riavel Transform que serve para teletransportar o player
    private Transform playerTransform;
    //declara��o da vari�vel Transform que serve como o destino do player
    public Transform TP;

    private void Start()
    {
        //achando o transform do player para o m�todo playerTransform
        playerTransform = GameObject.Find("Player").transform;

    }

    //M�todo para quando algo "entrar" no seu colisor
    private void OnTriggerEnter()
    {
        //teletransportando o player para a posi��o definida
        playerTransform.position = TP.position;
    }

    
}
