using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tran : MonoBehaviour
{
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat.SetColor("_Color", new Color(0.373487f,0.4199562f,0.7264151f,1));
    }
    
    // Update is called once per frame
    float x = 1;
    void Update()
    {
        if(transform.position.x != 0){
            mat.SetColor("_Color", new Color(0.373487f,0.4199562f,0.7264151f,x));
            x -= 0.1f * Time.deltaTime;
        }
        if(x < 0){
            transform.position = new Vector3(0,0,0);
        }
    }
}
