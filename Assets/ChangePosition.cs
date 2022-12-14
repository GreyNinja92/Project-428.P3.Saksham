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
            transform.SetPositionAndRotation(isTarget1.transform.position, isTarget1.transform.rotation);
            // transform.SetPositionAndRotation(new Vector3(-26.5f, 17.4f, 33.5f), new Quaternion(0,0,0,1));
            isTarget1.SetActive(true);
        }
        else if(isTarget2.activeSelf == false) {
            transform.SetPositionAndRotation(isTarget2.transform.position, isTarget2.transform.rotation);
            // transform.position = new Vector3(-7.6f, 19.18f, 0.08f);
            isTarget2.SetActive(true);
        }
        else if(isTarget3.activeSelf == false) {
            transform.SetPositionAndRotation(isTarget3.transform.position, isTarget3.transform.rotation);
            // transform.position = new Vector3(-60.9f, 1.4f, -0.5f);
            isTarget3.SetActive(true);
        }
        else if(isTargetHome.activeSelf == false) {
            transform.SetPositionAndRotation(isTargetHome.transform.position, isTargetHome.transform.rotation);
            // transform.position = new Vector3(-7.42f, -0.957f, 4.42f);
            isTargetHome.SetActive(true);
        }
    }
}
