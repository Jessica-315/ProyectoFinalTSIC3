using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int cScene;
    private Touch tap;
    // Start is called before the first frame update
    void Start()
    {
        cScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            cScene++;
            if (cScene > 3)
            {
                cScene = 0;
            }
            SceneManager.LoadScene(cScene);
        }
    }
}
