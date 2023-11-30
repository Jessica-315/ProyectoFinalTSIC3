using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;
//using UnityEngine.InputSystem;

public class MaterialOaxaca : MonoBehaviour
{
    //public static SwipeDetection instance;
    //public delegate void Swipe(Vector2 direction);
    //public event Swipe swipePerfomance;

    //[SerializeField] private InputAction position, press;
    //[SerializeField] private float swipeResistance = 100;
    //private Vector2 initialPos;
    //private Vector2 currentPos => position.ReadValue<Vector2>();

    public Material[] materiales = new Material[5];
    public int materialTotal = 5;
    public int materialCount = 0;
    public Renderer planeSkin;

    // Start is called before the first frame update
    void Start()
    {
        //planeSkin = GetComponent<Renderer>();
        //materiales = new Material[materialTotal];
        planeSkin.material = materiales[0];
    }

    //Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Ended)
        {
            materialCount++;
            if (materialCount == materialTotal) { materialCount = 0; }
            planeSkin.material = materiales[materialCount];
        }
        //if (Input.GetTouch(0).phase != TouchPhase.Began)
        //{
        //    materialCount++;
        //    if (materialCount == materialTotal) { materialCount = 0; }
        //    planeSkin.material = materiales[materialCount];
        //}
    }

    public void cambiaEcosistema()
    {
        materialCount++;
        if (materialCount == materialTotal) { materialCount = 0; }
        planeSkin.material = materiales[materialCount];
    }

    //private void Awake()
    //{
    //    position.Enable();
    //    press.Enable();
    //    press.performed += _ => { initialPos = currentPos; };
    //    press.canceled += _ => DetectSwipe();
    //    instance = this;
    //}

    //private void DetectSwipe() { }
}
