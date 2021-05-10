using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPorta : MonoBehaviour
{
    public GameObject PortaAberta;
    public GameObject PortaFechada;

    public GameObject PegaPintinhos;
    public float andar;
    public int abriu;//se estiver em 1 a movimentação

    void Start(){
        PortaAberta.SetActive(true);
        PortaFechada.SetActive(true);
        abriu = 1;
    }

    void Update(){
        //Debug.Log(andar);
        andar = PegaPintinhos.GetComponent<PegandoPintinho>().floor;
    }

    public void Abrir(){
        if(andar == 2){
            PortaFechada.SetActive(false);
            abriu = 2;
            Debug.Log("abriu");
        }
    }
}
