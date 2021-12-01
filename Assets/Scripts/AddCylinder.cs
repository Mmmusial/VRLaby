using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCylinder : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cylinder;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateCylinder()
    {
        Instantiate(cylinder);
    }
}