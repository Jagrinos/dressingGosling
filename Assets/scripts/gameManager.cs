using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> hats;
    [SerializeField] List<GameObject> clothes;
    [SerializeField] List<GameObject> pants;
    [SerializeField] List<GameObject> shoes;
    [SerializeField] List<GameObject> windows;
    [SerializeField] GameObject choise;
    [SerializeField] GameObject back;

    [SerializeField] GameObject goslingFull;
    [SerializeField] AudioSource putOn;
    public void Skip()
    {
        goslingFull.transform.parent = null;
        DontDestroyOnLoad(goslingFull);
        SceneManager.LoadScene("score");
    }
    public void Back()
    {
        foreach (var window in windows)
        {
            window.SetActive(false);
        }
        choise.SetActive(true);
        back.SetActive(false);
    }
    public void HatChoise()
    {
        choise.SetActive(false);
        foreach (var window in windows)
        {
            if (window.name == "hats")
            {
                window.SetActive(true);
            }
            else
                window.SetActive(false);
        }
        back.SetActive(true);
    }

    public void CloseChoise()
    {
        choise.SetActive(false);
        foreach (var window in windows)
        {
            if (window.name == "clothes")
            {
                window.SetActive(true);
            }
            else
                window.SetActive(false);
        }
        back.SetActive(true);

    }

    public void PantsChoise()
    {
        choise.SetActive(false);
        foreach (var window in windows)
        {
            if (window.name == "pants")
            {
                window.SetActive(true);
            }
            else
                window.SetActive(false);
        }
        back.SetActive(true);

    }

    public void ShoesChoise()
    {
        choise.SetActive(false);
        foreach (var window in windows)
        {
            if (window.name == "shoes")
            {
                window.SetActive(true);
            }
            else
                window.SetActive(false);
        }
        back.SetActive(true);

    }


    public void Hat(string title)
    {
        foreach (var hat in hats)
        {
            if (hat.name == title)
            {
                if (hat.activeSelf == true)
                    hat.SetActive(false);
                else
                    hat.SetActive(true);
            }
            else
                hat.SetActive(false);
        }
        putOn.Play();
    }

    public void Clothes(string title)
    {
        foreach (var clothe in clothes)
        {
            if (clothe.name == title)
            {
                if (clothe.activeSelf == true)
                    clothe.SetActive(false);
                else
                    clothe.SetActive(true);
            }
            else
                clothe.SetActive(false);
        }
        putOn.Play();
    }

    public void Pants(string title)
    {
        foreach (var pant in pants)
        {
            if (pant.name == title)
            {
                if (pant.activeSelf == true)
                    pant.SetActive(false);
                else
                    pant.SetActive(true);
            }
            else
                pant.SetActive(false);
        }
        putOn.Play();
    }

    public void Shoes(string title)
    {
        foreach (var shoe in shoes)
        {
            if (shoe.name == title)
            {
                if (shoe.activeSelf == true)
                    shoe.SetActive(false);
                else
                    shoe.SetActive(true);
            }
            else
                shoe.SetActive(false);
        }
        putOn.Play();
    }
}
