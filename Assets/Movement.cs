using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 startPos;
    public float speed = 2.0f;
    public float delta = 1.5f;
    private float randomizerX, randomizerZ;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        InvokeRepeating("randomize", 0f, 10f);
    }

    void randomize() 
    {
        StartCoroutine(Randomize());
    }

    public IEnumerator Randomize() {
        randomizerX = Random.Range(-0.01f, 0.01f);
        randomizerZ = Random.Range(-0.01f, 0.01f);
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;
        v.x += (delta + randomizerX) * Mathf.Sin(Time.time * speed);
        v.z += (delta + randomizerZ) * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
    
}
