using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pscoreManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        platform_count.score_p += 1;
    }
}