using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_controller : MonoBehaviour
{

    [SerializeField]
    private GameObject menu;

    public void hide()
    {
        menu.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
