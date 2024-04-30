using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGColorChanger : MonoBehaviour
{
    [SerializeField] private Color[] Colors;
    Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
        SetColor(Colors[Random.Range(0, Colors.Length)]);
    }

    void SetColor(Color color){
        cam.backgroundColor = color;
    }
}