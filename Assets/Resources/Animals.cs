using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{

    public MaterialChanges materialChanges;
    //private int planeNum;
    private string planeName;

    public GameObject cacomixtle;
    public GameObject aguila;
    public GameObject caiman;
    public GameObject vibora;
    public GameObject tortuga;
    public GameObject mono;
    public GameObject ajolote;
    public GameObject tigrillo;

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
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("Pastizal"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(true);
            caiman.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("Manglar"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(true);
            vibora.SetActive(false);
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("SelvaHumeda"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(true);
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }
        if (planeName.Contains("Matorral"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(true);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("SelvaSeca"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
            tortuga.SetActive(true);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("Humedales"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(true);
        }

        else if (planeName.Contains("BosqueNublado"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            caiman.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(true);
            tortuga.SetActive(false);
            tigrillo.SetActive(false);
            ajolote.SetActive(false);
        }
    }
}
