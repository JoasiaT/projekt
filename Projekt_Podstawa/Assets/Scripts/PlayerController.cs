using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Wywo³aj zapisane zmiany
        Debug.Log("Tutaj jest testowa informacja");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //jezeli wcisniento przycisk "D"
        {
            //To wykonuje to
            transform.position = new Vector3(1,1,1);
            Debug.Log("wicsnento przycisk D");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("wicsnento przycisk A");
        }
    }
}
