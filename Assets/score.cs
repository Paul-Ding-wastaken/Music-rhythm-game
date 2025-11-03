using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]public TextMeshProUGUI score2;

    public GameObject score1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score2.SetText("Score: "+ score1.transform.position.x);
    }
}
