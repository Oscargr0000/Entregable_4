using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{

    //INCIO DE DECLARACIONES 
    private Color ColorObject;

    private Vector3 VectorScale;

    private Vector3 VectorPosition;
    //FIN DE DE DECLARACIONES


    public Color RandomColor() //FUNCION DE CAMBIO DE COLOR ALEATORIO
    {

       ColorObject = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
       return ColorObject;

    }

    public Vector3 RandomScale() //FUNCION DE CAMBIO DE ESCALADO ALEATORIO
    {

        VectorScale = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        return VectorScale;

    }

    public Vector3 RandomPosition() // FUNCION DE CAMBIO DE POSICION 
    {
        VectorPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
        return VectorPosition ;
    }

    void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = RandomColor();
        GetComponent<Transform>().position = RandomPosition();
        GetComponent<Transform>().localScale = RandomScale();
    }

    

}
