using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalChiapas : MonoBehaviour
{

    public MaterialChiapas materialChanges;
    //private int planeNum;
    private string planeName;

    public GameObject cacomixtle;
    public GameObject aguila;
    public GameObject caiman;
    public GameObject vibora;

    // Start is called before the first frame update
    void Start()
    {
        //planeNum = materialChanges.materialCount;
    }

    // Update is called once per frame
    void Update()
    {
        planeName = materialChanges.planeSkin.material.name;

        Debug.Log("----------------------------------------"+planeName);
        if (planeName.Contains("BosqueTemplado")) {
            cacomixtle.SetActive(true);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(false);
        }

        else if (planeName.Contains("Pastizal"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(true);
            caiman.SetActive(false);
            vibora.SetActive(false);
        }

        else if (planeName.Contains("Manglar"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(true);
            vibora.SetActive(false);
        }

        else if (planeName.Contains("SelvaHumeda"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(true);
        }
    }
}
