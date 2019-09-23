using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void LinhaDoTempo()
    {
        SceneManager.LoadScene("Linha_do_Tempo");
    }

    public void Jogo()
    {
        SceneManager.LoadScene("Fase_1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
