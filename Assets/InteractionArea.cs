using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactioArea : MonoBehaviour
{
    public int score;
    public Text txtScore;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if (score < maxScore)
        {
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);
        }
        
        else
        {
            txtScore.text = "Ganaste!";
        }
    }

}