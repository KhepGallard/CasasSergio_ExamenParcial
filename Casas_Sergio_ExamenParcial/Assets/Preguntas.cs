using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Preguntas : MonoBehaviour
{
    public int cifra1;
    public int cifra2;
    public int cifra3;
    public int cifra4;
    public int cifra5;
    public TMP_InputField respuestas;
    public TMP_Text Resultado;
    public TMP_Text Pregunta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cuestionario()
    {
        
        if (cifra1 == 23)
        {
            Pregunta.text = "15+8";
            Resultado.text = "Correcto";
            
        }
        else if (cifra2 != 23)
        {
            Resultado.text = "... que mal";
        }

        if (cifra2 == 122)
        {
            Pregunta.text = "90+32";
            Resultado.text = "Perfecto";

        }
        else if (cifra2 != 122)
        {
            Resultado.text = "... incorrecto";
        }
        if (cifra3 == 360)
        {
            Pregunta.text = "240+120";
            Resultado.text = "Increible";

        }
        else if (cifra3 != 360)
        {
            Resultado.text = "¿Pero qué haces...?";
        }
        if (cifra4 == 100)
        {
            Pregunta.text = "80+20";
            Resultado.text = "Muy bien";

        }
        else if (cifra4 != 100)
        {
            Resultado.text = "¿Me quieres ver la cara?";
        }
        if (cifra5 == 69)
        {
            Pregunta.text = "35+34";
            Resultado.text = "Excelente";

        }
        else if (cifra5 != 69)
        {
            Resultado.text = "... no";
        }
    }
}
