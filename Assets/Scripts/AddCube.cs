using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCube : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateCube()
    {
        Instantiate(cube);
    }
}