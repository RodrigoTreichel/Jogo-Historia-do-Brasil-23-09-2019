using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    Pause p;
    Historia h;
    Banana b;
    Coco c;
    Pinha pi;
    Portal po;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Pause").GetComponent<Pause>();
        h = GameObject.Find("Historia").GetComponent<Historia>();
        b = GameObject.Find("Banana").GetComponent<Banana>();
        c = GameObject.Find("Coco").GetComponent<Coco>();
        pi = GameObject.Find("Pinha").GetComponent<Pinha>();
        po = GameObject.Find("Portal").GetComponent<Portal>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumePlay()
    {
        p.ResumeGame();
        h.ResumeGame();
        b.ResumeGame();
        c.ResumeGame();
        pi.ResumeGame();
        po.ResumeGame();
    }

    public void ResumePause()
    {
        p.PauseAtivo();
    }

    public void ResumeHistoria()
    {
        h.HistoriaAtivo();
    }

    public void VoltarLinhaTempo()
    {
        SceneManager.LoadScene("Linha_do_Tempo");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
