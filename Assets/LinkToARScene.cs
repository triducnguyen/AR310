using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LinkToARScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LinkToAR()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
