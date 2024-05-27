using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option_Window : MonoBehaviour
{
    public GameObject option;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenOption(bool active)
    {
        option.SetActive(active);
    }
    
}
