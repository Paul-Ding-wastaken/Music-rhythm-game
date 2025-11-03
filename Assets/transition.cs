using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public GameObject x;
    public GameObject y;

    public GameObject z;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void click(){
        x.transform.position = new Vector3(1,0,1);
        y.SetActive(true);
        z.SetActive(false);
    }
}
