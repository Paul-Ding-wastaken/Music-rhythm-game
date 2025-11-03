using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

    
public class test : MonoBehaviour
{

    [SerializeField]public TextMeshProUGUI perfecttxt;

    [SerializeField]public TextMeshProUGUI greattxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI b = Instantiate(perfecttxt,new Vector3(perfecttxt.transform.position.x-1,perfecttxt.transform.position.y,perfecttxt.transform.position.z),Quaternion.identity);
    }
}
