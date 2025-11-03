using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class pop : MonoBehaviour
{
    public GameObject tile;

    public GameObject perfect;

    public GameObject great;

    public GameObject center;

    public GameObject canvas;

    [SerializeField]public TextMeshProUGUI perfecttxt;
    [SerializeField]public TextMeshProUGUI perfecttxt1;
    [SerializeField]public TextMeshProUGUI perfecttxt2;
    [SerializeField]public TextMeshProUGUI perfecttxt3;

    [SerializeField]public TextMeshProUGUI greattxt;
    [SerializeField]public TextMeshProUGUI greattxt1;
    [SerializeField]public TextMeshProUGUI greattxt2;
    [SerializeField]public TextMeshProUGUI greattxt3;

    public GameObject tick1;
    public GameObject tick2;

    public GameObject tick3;
    public GameObject tick4;

    public GameObject score;

    public SpriteRenderer colorcircle;

    
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer c = colorcircle.GetComponent<SpriteRenderer>();
        c.color = new Color(UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f),UnityEngine.Random.Range(0f,1f),1);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -6){
            transform.position = new Vector3(transform.position.x - (Time.deltaTime),transform.position.y,transform.position.z);
        }
        if(transform.position.x > -6 && transform.position.x < -5){
            Destroy(tile);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y == 0.4f){
            if(perfect.transform.position.x < center.transform.position.x+0.05 && perfect.transform.position.x > center.transform.position.x-0.05 ){
                if(tick1.transform.position.x == 0f){
                    tick1.transform.position = new Vector3(1f,0f,0f);
                    perfecttxt.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(60f,145f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }else{
                    
                    tick1.transform.position = new Vector3(0f,0f,0f);
                    perfecttxt1.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(60f,145f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }
                score.transform.position += new Vector3(300f,0,0);
                Destroy(tile);
            }else if(great.transform.position.x < center.transform.position.x+0.15 && great.transform.position.x > center.transform.position.x-0.15){
                if(tick2.transform.position.x == 0f){
                    tick2.transform.position = new Vector3(1f,0f,0f);
                    greattxt.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(60f,145f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }else{
                    tick2.transform.position = new Vector3(0f,0f,0f);
                    greattxt1.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(60f,145f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }
                score.transform.position += new Vector3(100f,0,0);
                Destroy(tile);
            }
        }

        if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y == -0.4f){
            if(perfect.transform.position.x < center.transform.position.x+0.05 && perfect.transform.position.x > center.transform.position.x-0.05){
                if(tick3.transform.position.x == 0f){
                    tick3.transform.position = new Vector3(1f,0f,0f);
                    perfecttxt2.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(-34f,-118f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }else{
                    tick3.transform.position = new Vector3(0f,0f,0f);
                    perfecttxt3.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(-24f,-118f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }
                score.transform.position += new Vector3(300f,0,0);
                Destroy(tile);
            }else if(great.transform.position.x < center.transform.position.x+0.15 && great.transform.position.x > center.transform.position.x-0.15){
                if(tick4.transform.position.x == 0f){
                    tick4.transform.position = new Vector3(1f,0f,0f);
                    greattxt.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(-24f,-118f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }else{
                    tick4.transform.position = new Vector3(0f,0f,0f);
                    greattxt1.transform.position = new Vector3(UnityEngine.Random.Range(-226f,226f)+canvas.transform.position.x,UnityEngine.Random.Range(-24f,-118f)+canvas.transform.position.y,perfecttxt.transform.position.z);
                    
                }
                score.transform.position += new Vector3(100f,0,0);
                Destroy(tile);
            }
        }

    }
    
}
