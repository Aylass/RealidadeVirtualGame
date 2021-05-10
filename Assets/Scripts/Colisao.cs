using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    //public GameObject movimentacao;
    public float velocidademov;

    void OnTriggerEnter(Collision Colider){
        if(Colider.gameObject.tag == "ColisaoParede"){
           // movimentacao.GetComponent<Movimentacao>().velocidade = 0;
            Debug.Log("Colidiu");
        }
        Debug.Log("Colidiuanivia");
    }
}
