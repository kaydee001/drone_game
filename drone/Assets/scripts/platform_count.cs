using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platform_count : MonoBehaviour
{
    public Material c;
    public Collider cd;
    public GameObject ps_text;
    public static int score_p;
    void Start()
    {
        cd = GetComponent<Collider>();
        cd.isTrigger = true;
    }
    void Update()
    {
        ps_text.GetComponent<Text>().text = "Loops crossed : " + score_p;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            transform.GetComponent<Renderer>().material = c;
            cd.isTrigger = false;
            cd.enabled = false;
        }        
    }
}
