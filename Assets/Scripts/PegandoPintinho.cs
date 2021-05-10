using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegandoPintinho : MonoBehaviour
{
    public GameObject Pintinho1;
    public GameObject Pintinho2;
    public GameObject Pintinho3;
    public GameObject PintinhonaMao;
    public GameObject Pintinho1Solto;
    public GameObject Pintinho2Solto;
    public GameObject Pintinho3Solto;

    public Transform Camera;

    public int podepegar;//fica 0 se pode pegara algum pintinho, fica 1 se ja tem um na mão
    public int pegopitinho1;//se ja pegou pintinho1
    public int pegopitinho2;//se ja pegou pintinho2
    public int pegopitinho3;//se ja pegou pintinho3
    private float pos;
    public float floor;

    void Start (){
        Pintinho1.SetActive(true);
        Pintinho2.SetActive(true);
        Pintinho3.SetActive(true);

        floor = 1;

        PintinhonaMao.SetActive(false);

        Pintinho1Solto.SetActive(false);
        Pintinho2Solto.SetActive(false);
        Pintinho3Solto.SetActive(false);

        podepegar = 0;
        pegopitinho1 = 0;
        pegopitinho2 = 0;
        pegopitinho3 = 0;
    }

    void Update(){
        Vector3 pos = Camera.transform.position;


        if(podepegar == 0){//pode pegar algum pintinho
            //Pintinho 1
            if(pegopitinho1 == 0){
            if(((pos.x<1)&&(pos.x>0))&&((pos.z<7)&&(pos.z>6))){//pego pintinho 1
                //Debug.Log("Pego Pintinho 1");
                Pintinho1.SetActive(false);
                podepegar = 1;
                pegopitinho1 = 1;
            }
            }

            //Pintinho 2
            if(pegopitinho2 == 0){
            if(((pos.x<4)&&(pos.x>2))&&((pos.z<-1)&&(pos.z>-2))){//pego pintinho 1
               // Debug.Log("Pego Pintinho 2");
                Pintinho2.SetActive(false);
                podepegar = 1;
                pegopitinho2 = 1;
            }
            }

            //Pintinho 3
            if(pegopitinho3 == 0){
            if(((pos.x<-4)&&(pos.x>-5))&&((pos.z<-2)&&(pos.z>-3))){//pego pintinho 1
               // Debug.Log("Pego Pintinho 3");
                Pintinho3.SetActive(false);
                podepegar = 1;
                pegopitinho3 = 1;
            }
            }
        }

        if(podepegar == 1){//leva o pintinho na galinha
            PintinhonaMao.SetActive(true);//pintinho aparece na mão
             //Debug.Log("Pode Solta");
            if(((pos.x<-3)&&(pos.x>-4))&&((pos.z<5)&&(pos.z>3))){//leva o pintinho pra galinha
                //Debug.Log("Soltou Pintinho");
                PintinhonaMao.SetActive(false);//solta o pintinho
                podepegar = 0;//pode pegar mais pintinhos

                //aparecem os pintinhos soltos
                if(pegopitinho1 == 1){
                    Pintinho1Solto.SetActive(true);
                }
                if(pegopitinho2 == 1){
                    Pintinho2Solto.SetActive(true);
                }
                if(pegopitinho3 == 1){
                    Pintinho3Solto.SetActive(true);
                }
            }
        }

        if((pegopitinho1 == 1)&&(pegopitinho2 == 1)&&(pegopitinho3 == 1)&&(podepegar == 0)){
            //passo pro proximo nivel
            //Debug.Log("Proximo Nível");
            floor = 2;
        }

    }
    
    /*private void OnCollisionEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Pintinho.SetActive(false);
            Debug.Log("Pega Pintinho");
        }
         Debug.Log("Pega Pintinho colidiu");
    }*/
}
