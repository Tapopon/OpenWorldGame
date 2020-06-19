using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hako;

    public void OneClick(){
        Debug.Log("ButtonClick");
        GameObject obj = (GameObject)Resources.Load ("tekitousugirutapioca (1)");
        Instantiate (obj,hako.GetComponent<Transform>().position, Quaternion.identity);
    
    }
    void Start()
    {
        hako = GameObject.Find("Character1_LeftHandMiddle4");
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
