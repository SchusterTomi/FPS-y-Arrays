﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Agregar una variable que almacene el valor maximo de puntos
// cuando se llegue al valor maximo debe dejar de sumarse puntos
// y mostrar en txtScore en lugar del puntaje el mensaje "Ganaste"
public class ScoreCounter : MonoBehaviour
{
    public Text txtScore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        txtScore.text = score.ToString();
    }
}