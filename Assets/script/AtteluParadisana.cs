using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject shtani,bot,skin;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;

    public void shtaniAttelosana(bool vertiba)
    {
        shtani.SetActive(vertiba);
    }

    public void skinAttelosana(bool vertiba)
    {
        skin.SetActive(vertiba);
    }

    public void botAttelosana(bool vertiba)
    {
        bot.SetActive(vertiba);
    }
    public void izkritosais(int skaitlis){
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        }
    }
    public void mainitLielumu()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }
}
