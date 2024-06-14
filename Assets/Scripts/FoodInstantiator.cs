﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Agregar una variable que establezca la cantidad de veces 
// que se instanciara un alimento
// cuando se instancien esa cantidad de alimentos
// no debe instanciarse más
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement posicionAleatoriaDeClonePoint;
    public int maxClones;
    public int cloneCount;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (cloneCount < maxClones)
        {
            cloneCount++;
            posicionAleatoriaDeClonePoint.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }

        
        
    }
}
