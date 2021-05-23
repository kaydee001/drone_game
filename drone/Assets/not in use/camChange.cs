using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camChange : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public int mode;
    void Update()
    {
        if(Input.GetButtonDown("Camera"))
        {
            if(mode==1)
            {
                mode = 0;
            }
            else
            {
                mode += 1;
            }
            StartCoroutine(Change());
        }
    }
    IEnumerator Change()
    {
        yield return new WaitForSeconds(0.01f);
        if(mode==0)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if(mode==1)
        {
            cam2.SetActive(true);
            cam1.SetActive(false);
        }
    }
}
