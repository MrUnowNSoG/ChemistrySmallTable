using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 target;
    public float speed = 4f;
    public Vector3[] arrayTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
    }

    public void NewTarget(int id)
    {
        target = arrayTarget[id];
    }
}
