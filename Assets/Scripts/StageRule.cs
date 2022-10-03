using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageRule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
#if UNITY_EDITOR
        if(SceneManager.sceneCount==1)
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Additive);
        }
#endif

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
