using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class MaterialManager : MonoBehaviour
{
    public List<Material> pbrMat = new List<Material>();
    float intensity;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            pbrMat[0].SetColor("_Outline_Color", Color.red);
        }
    }
}
