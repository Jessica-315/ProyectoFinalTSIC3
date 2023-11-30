using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSLPotosi : MonoBehaviour
{

    public MaterialSLPotosi materialChanges;
    //private int planeNum;
    private string planeName;

    public GameObject cacomixtle;
    public GameObject tigrillo;
    public GameObject aguila;
    public GameObject tortuga;
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
            tigrillo.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            aguila.SetActive(false);
        }

        else if (planeName.Contains("Matorral"))
        {
            cacomixtle.SetActive(false);
            tigrillo.SetActive(true);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            aguila.SetActive(false);
        }

        else if (planeName.Contains("Pastizal"))
        {
            cacomixtle.SetActive(false);
            tigrillo.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            aguila.SetActive(true);
        }

        else if (planeName.Contains("SelvaSeca"))
        {
            cacomixtle.SetActive(false);
            tigrillo.SetActive(false);
            tortuga.SetActive(true);
            vibora.SetActive(false);
            aguila.SetActive(false);
        }

        else if (planeName.Contains("SelvaHumeda"))
        {
            cacomixtle.SetActive(false);
            tigrillo.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(true);
            aguila.SetActive(false);
        }
    }
}
