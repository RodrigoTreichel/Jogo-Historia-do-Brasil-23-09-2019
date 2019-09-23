using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject venceu;
    public GameObject falta;
    Personagem personagem;

    void Start()
    {
        personagem = GameObject.Find("Personagem").GetComponent<Personagem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if(personagem != null)
        {
            if(personagem.objeto > 3 && other.tag == "Banana" && other.tag == "Coco" && other.tag == "Pinha")
             {
                venceu.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("pegou");
             }
             else
              {
                falta.SetActive(true);
                Time.timeScale = 1;
                Debug.Log("nao pegou");
              }
  
        }
    }

    public void ResumeGame()
    {
        falta.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
