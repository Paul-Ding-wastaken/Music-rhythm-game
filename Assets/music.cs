using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip m1;
    public AudioClip m2;
    public AudioClip m3;
    public AudioClip m4;

    public AudioClip[] list = new AudioClip[4];

    AudioSource audiosource;
    void Start()
    {
        int a = Random.Range(1,4);
        int b = Random.Range(1,4);
        while(a == b){
            b = Random.Range(1,4);
        }
        int c = 1;
        while(c == b || c == a){
            c += 1;
        }
        int d = 10 - c - b - a;
        
        list[a-1] = m1;
        list[b-1] = m2;
        list[c-1] = m3;
        list[d-1] = m4;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    int x = 1;
    void Update()
    {
        if(!audiosource.isPlaying){
            audiosource.clip = list[x];
            audiosource.Play();
            x += 1;
        }
        if(x == 4){
            x = 1;
        }
        
    }
}
