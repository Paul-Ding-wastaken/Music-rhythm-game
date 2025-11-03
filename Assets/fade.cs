using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class fade : MonoBehaviour
{
    [SerializeField]public TextMeshProUGUI self;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float x = 1;
    // Update is called once per frame
    void Update()
    {
        if(self.transform.position.x != 365f &&  x > 0f){
            self.color = new Color(0.3130562f,0.9772978f,0.990566f,x);
            x -= 0.5f * Time.deltaTime;
        }else{
            transform.position = new Vector3(365f,1000f,0);
            self.color = new Color(0.3130562f,0.9772978f,0.990566f,1f);
            x = 1f;
        }
    }
}
