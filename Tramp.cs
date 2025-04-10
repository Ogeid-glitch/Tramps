using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp : MonoBehaviour
{
    public void OnTriggerStay(Collider other)
    {
        other.GetComponent<Player>().health--;
    }

}
