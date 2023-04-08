using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //declaração da váriavel Transform que serve para teletransportar o player
    private Transform playerTransform;
    //declaração da variável Transform que serve como o destino do player
    public Transform TP;

    private void Start()
    {
        //achando o transform do player para o método playerTransform
        playerTransform = GameObject.Find("Player").transform;

    }

    //Método para quando algo "entrar" no seu colisor
    private void OnTriggerEnter()
    {
        //teletransportando o player para a posição definida
        playerTransform.position = TP.position;
    }

    
}
