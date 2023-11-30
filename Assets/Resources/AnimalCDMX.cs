using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalCDMX : MonoBehaviour
{

    public MaterialCDMX materialChanges;
    //private int planeNum;
    private string planeName;

    public GameObject cacomixtle;
    public GameObject aguila;
    public GameObject ajolote;

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
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("Pastizal"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(true);
            ajolote.SetActive(false);
        }

        else if (planeName.Contains("Humedal"))
        {
            cacomixtle.SetActive(false);
            aguila.SetActive(false);
            ajolote.SetActive(true);
        }
    }
}
