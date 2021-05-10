using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade;
    public Transform Player;
    public Transform Camera;

    public GameObject AbrirPorta;
    public GameObject SegundoAndar;

    public int floor;
    private int andar;
    private Vector3 posantes;

    void Start(){
        floor = 1;
        andar = 1;
        SegundoAndar.SetActive(false);
    }

    void Update()
    {
        floor = AbrirPorta.GetComponent<AbrirPorta>().abriu;

        Vector3 pos = Camera.transform.position;
        posantes = pos;
        pos.z += velocidade * Time.deltaTime;

        Quaternion altura = Camera.transform.rotation;


        //gambiarra para não passar das paredes
       // if(((pos.x >-6)&&(pos.x<4))&&((pos.z>-3)&&(pos.z<7))){
           Debug.Log(floor);
        if(andar == 1){//movimentação no primeiro andar
            if((((pos.x >-6)&&(pos.x<1))&&((pos.z>-3)&&(pos.z<7)))||(((pos.x >-6)&&(pos.x<4))&&((pos.z>-3)&&(pos.z<3)))){//excluindo a salinha
                if(altura.x < -0){
                    pos.y = 1;//para nao sair voando e ficar no piso certo
                    if((floor == 2)&&((pos.x >2)&&(pos.x<4))&&((pos.z>2)&&(pos.z<4))){//se pode ir pro proximo nivel e ta na frente da porta sobe
                        pos.y = 4;//para nao sair voando e ficar no piso certo 
                        Debug.Log("Segundo andar");
                        SegundoAndar.SetActive(true);  
                        andar = 2;
                    }
                    Player.transform.position = pos;
                }
            }
        }

        if(andar == 2){//movimentação no segundo andar
            if((((pos.x >-6)&&(pos.x<1))&&((pos.z>-3)&&(pos.z<7)))||(((pos.x >-6)&&(pos.x<4))&&((pos.z>-3)&&(pos.z<3)))){//excluindo a salinha
                if(altura.x < -0){
                    pos.y = 4;//para nao sair voando e ficar no piso certo
                    Player.transform.position = pos;
                }
            }
        }
    }

    /*void OnCollisionEnter(Collision Colider){
        if(Colider.gameObject.tag == "ColisaoParede"){
            //velocidade = 0;
            Player.transform.position = posantes;
            Debug.Log("Pego tag");
        }
        Debug.Log("Colidiu script camera");
    }*/
}
