using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    [SerializeField] GameObject elevator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        for(int i = 0;i<10000;i++)
        { 
        
        }
        if(elevator.transform.position.y < 114.23f)
        elevator.transform.position = new Vector3(elevator.transform.position.x, elevator.transform.position.y + 0.1f, elevator.transform.position.z);
    }
}
