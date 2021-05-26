using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{
    public float cfuel = 100f;
    public Text ftext;
    public float decreaseRate = 1f;
    public bool isMoving = false;
    public movement isMovingForward;
    void Start()
    {
        isMoving = false;
    }

    void Update()
    {
        decrease();
    }
    void decrease()
    {
        if (isMovingForward == true)
        {
            decreaseRate = 2f;
            cfuel -= decreaseRate * Time.deltaTime;
        }
        else
        {
            cfuel -= decreaseRate * Time.deltaTime;
        }
        ftext.text = "Battery : " + cfuel.ToString("00") + "%";
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("fuel"))
        {
            cfuel += 10f;
            if(cfuel>=100)
            {
                cfuel = 100f;
                Destroy(other.gameObject);
            }
            Destroy(other.gameObject);
        }
    }
}