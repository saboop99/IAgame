using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    //variável GameObject com a tela de Win
    public GameObject youWin;

    


    //Método para quando algo "entrar" no seu colisor
    private void OnTriggerEnter(Collider other)
    {
        //condicional que compara as tags para caso o objeto colidido for o Player
        if (other.CompareTag("Player"))
        {

            //ativandp a tela de Win
            youWin.SetActive(true);
            //Destruindo o Player
            Destroy(GameObject.FindWithTag("Player"));




            //carrega a cena atual
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        
    }


}
