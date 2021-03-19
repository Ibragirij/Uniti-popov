using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
    string teksts, vecums;
    public GameObject ievadesLauks,ievadesLauks2;
    public GameObject tekstaAttelosana;

    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        vecums = ievadesLauks2.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = teksts + " ir " + vecums + " gadu vecs";
    }
}