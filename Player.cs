using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 5;
    public GameObject fire;
    public GameObject FirePos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shootFire();
        }
    }

    void shootFire()
    {
        //Vamos a detectar el click izquierdo y con el disparar una bola de fuego
        Instantiate(fire, FirePos.transform.position, FirePos.transform.rotation);
    }
}
