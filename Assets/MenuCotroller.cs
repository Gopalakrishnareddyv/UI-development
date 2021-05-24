using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCotroller : MonoBehaviour
{
    public GameObject optionspanel;
    public GameObject toppanel, middlepanel,helppanel;
    public void OptionsMenu()
    {
        optionspanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
    public void Back()
    {
        optionspanel.SetActive(false);
        helppanel.SetActive(false);
        toppanel.SetActive(true);
        middlepanel.SetActive(true);

    }
    public void Help()
    {
        helppanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
}
