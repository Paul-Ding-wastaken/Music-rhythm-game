using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public GameObject tile;

    
    public float timer1 = 0;
    public float timer2 = 0;
    public Transform R;

    

    
    // Start is called before the first frame update
    void Start()
    {
        timer1 = 3f + Random.Range(1.0f,4.0f) + 4f;
        timer2 = 3f + Random.Range(1.0f,4.0f) + 4f;
    }

    // Update is called once per frame
    void Update()
    {

        if(timer1 <= 0){
            if(Random.Range(1.0f,10.0f) <= 9){
                GameObject a = Instantiate(tile,new Vector3(5f,0.4f,tile.transform.position.z),Quaternion.identity);
                a.transform.SetParent(R);
                timer1=Random.Range(1.0f,6.0f);
            }else{

            }
        }else{
            timer1 -= Time.deltaTime;
        }
        if(timer2 <= 0){
            if(Random.Range(1.0f,10.0f) <= 9){
                GameObject a = Instantiate(tile,new Vector3(5f,-0.4f,tile.transform.position.z),Quaternion.identity);
                a.transform.SetParent(R);
                timer2 = Random.Range(1.0f,6.0f);
            }else{

            }
        }else{
            timer2 -= Time.deltaTime;
        }

        
    }
}
