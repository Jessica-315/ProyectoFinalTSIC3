using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalOaxaca : MonoBehaviour
{

    public MaterialOaxaca materialChanges;
    //private int planeNum;
    private string planeName;

    public GameObject cacomixtle;
    public GameObject caiman;
    public GameObject tortuga;
    public GameObject vibora;
    public GameObject mono;

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
            caiman.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
        }

        else if (planeName.Contains("Manglar"))
        {
            cacomixtle.SetActive(false);
            caiman.SetActive(true);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(false);
        }

        else if (planeName.Contains("SelvaSeca"))
        {
            cacomixtle.SetActive(false);
            caiman.SetActive(false);
            tortuga.SetActive(true);
            vibora.SetActive(false);
            mono.SetActive(false);
        }

        else if (planeName.Contains("SelvaHumeda"))
        {
            cacomixtle.SetActive(false);
            caiman.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(true);
            mono.SetActive(false);
        }

        else if (planeName.Contains("BosqueNublado"))
        {
            cacomixtle.SetActive(false);
            caiman.SetActive(false);
            tortuga.SetActive(false);
            vibora.SetActive(false);
            mono.SetActive(true);
        }
    }
}
