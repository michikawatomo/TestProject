using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Stage1-1",LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}