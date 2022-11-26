using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    public GameObject isTarget1;
    public GameObject isTarget2;
    public GameObject isTarget3;
    public GameObject isTargetHome;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isTarget1.activeSelf == false) {
            transform.position = new Vector3(-26.5f, 17.4f, 33.5f);
            isTarget1.SetActive(true);
        }
        else if(isTarget2.activeSelf == false) {
            // UnityEditor.TransformWorldPlacementJSON:{"position":{"x":-7.690000057220459,"y":13.90999984741211,"z":3.0899999141693117},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":3.0,"y":-0.03999999910593033,"z":3.0}}
            transform.position = new Vector3(-7.6f, 19.18f, 0.08f);
            isTarget2.SetActive(true);
        }
        else if(isTarget3.activeSelf == false) {
            // UnityEditor.TransformWorldPlacementJSON:{"position":{"x":-60.900001525878909,"y":1.2999999523162842,"z":-0.5},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":1.0,"y":1.0,"z":1.0}}
            transform.position = new Vector3(-60.9f, 1.4f, -0.5f);
            isTarget3.SetActive(true);
        }
        else if(isTargetHome.activeSelf == false) {
            // UnityEditor.TransformWorldPlacementJSON:{"position":{"x":-7.429999828338623,"y":-0.9574999809265137,"z":4.420000076293945},"rotation":{"x":0.0,"y":0.0,"z":0.0,"w":1.0},"scale":{"x":1.0,"y":1.0,"z":1.0}}
            transform.position = new Vector3(-7.42f, -0.957f, 4.42f);
            isTargetHome.SetActive(true);
        }
    }
}
