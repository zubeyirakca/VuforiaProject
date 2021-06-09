using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sahne_Degistir : MonoBehaviour
{
    public void MainToAtommodels()
    {
        SceneManager.LoadScene("AtomModels");
    }

    public void AtommodelsToMain()
    {

        SceneManager.LoadScene("Main");
    }

    public void Dalton()
    {
        SceneManager.LoadScene("Dalton");
    }

    public void Thompson()
    {
        SceneManager.LoadScene("Thompson");
    }

    public void Rutherford()
    {
        SceneManager.LoadScene("Rutherford");
    }

    public void Bohr()
    {
        SceneManager.LoadScene("Bohr");
    }

    public void ToAtommodels()
    {
        SceneManager.LoadScene("AtomModels");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
