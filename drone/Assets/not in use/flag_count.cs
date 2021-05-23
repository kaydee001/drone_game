using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flag_count : MonoBehaviour
{
    public GameObject fs_text;
    public static int score_f;
    void Update()
    {
        fs_text.GetComponent<Text>().text = "Flags collected : " + score_f;
    }
}
