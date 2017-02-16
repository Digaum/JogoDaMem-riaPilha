using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptQuadrado : MonoBehaviour {

	public string[] quadradoVetor = new string[6];
	public int contador = 0;

    public KeyCode btnZ;
    public KeyCode btnX;
    public KeyCode btnC;
    public KeyCode btnA;
    public KeyCode btnS;
    public KeyCode btnD;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(btnZ))
        {
            quadradoVetor[contador] = "Marrom";
            contador = contador + 1;
        }

        if (Input.GetKeyDown(btnX))
        {
            quadradoVetor[contador] = "Rosa";
            contador = contador + 1;
        }

        if (Input.GetKeyDown(btnC))
        {
            quadradoVetor[contador] = "Amarelo";
            contador = contador + 1;
        }

        if (Input.GetKeyDown(btnA))
        {
            quadradoVetor[contador] = "Laranja";
            contador = contador + 1;
        }

        if (Input.GetKeyDown(btnS))
        {
            quadradoVetor[contador] = "Verde";
            contador = contador + 1;
        }

        if (Input.GetKeyDown(btnD))
        {
            quadradoVetor[contador] = "Roxo";
            contador = contador + 1;
        }

        /* if (Input.GetKey(btnZ))
         {
             verificaZ = true;
             quadradoVetor[contador] = "Marrom";
             contador = contador + 1;
         }
         else
         {
             verificaZ = false;
         }
         if (Input.GetKey(btnX))
         {
             verificaX = true;
         }else
         {
             verificaX = false;
         }
         if (Input.GetKey(btnC))
         {
             verificaC = true;
         }else
         {
             verificaC = false;
         }*/

        /* if (Input.GetKey(btnZ))
         {
             verificaZ = true;
             quadradoVetor[contador] = "Marrom";
             contador = contador + 1;
         }
         if (Input.GetKey(btnX))
         {
             verificaX = true;
             quadradoVetor[contador] = "Rosa";
             contador = contador + 1;
         }
         if (Input.GetKey(btnC))
         {
             verificaZ = true;
             quadradoVetor[contador] = "Amarelo";
             contador = contador + 1;
         }*/

    }

    /*void OnMouseDown(){

		quadradoVetor [contador] = gameObject.tag;

        Debug.Log(quadradoVetor[contador]);

        contador = contador + 1;
		//Debug.Log (gameObject.tag);
        //Debug.Log(contador);
		//Destroy (gameObject);
		//this.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
		}*/
}
