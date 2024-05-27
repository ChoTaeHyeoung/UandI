using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneReturn : MonoBehaviour
{
    Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn = this.transform.GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(Scene_Return);
        }
    }

    
    void Scene_Return()
    {
        SceneManager.LoadScene("Robin");
    }
}
