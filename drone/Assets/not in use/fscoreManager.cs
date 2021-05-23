using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fscoreManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        flag_count.score_f += 1;
        Destroy(gameObject);
    }
}