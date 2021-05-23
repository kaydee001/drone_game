using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{
    public float cfuel = 100f;
    public Text ftext;
    public float d;
    public float b = 1f ;
    bool isMoving;
    void Start()
    {
        d = b;
        isMoving = true;
    }

    void Update()
    {
        decrease();
    }
    void decrease()
    {
        if (isMoving == true)
        {
            if (d > 0)
            {
                d -= Time.deltaTime;
            }
            else
            {
                d = b;
                cfuel -= 1f;
            }
        }
        ftext.text = "Battery : " + cfuel + "%";
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(cfuel==100f)
            {
                cfuel = 100f;
                Destroy(gameObject);
            }
            else
            {
                cfuel += 10f;
                Destroy(gameObject);
            }
        }
    }
}