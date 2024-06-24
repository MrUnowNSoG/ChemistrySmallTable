using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoRotation : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40f;
    public int id = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch(id){
            case 1:
                transform.Rotate(0, speed * Time.deltaTime, 0);
                break;
            case 2:
                transform.Rotate(0, -speed * Time.deltaTime , 0);
                break;
            case 3:
                transform.Rotate(0, -speed * Time.deltaTime, 0);
                break;
            case 4:
                transform.Rotate(0, speed * Time.deltaTime, 0);
                break;
        }
    }
}
