using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionNeedle : MonoBehaviour
{
    public WheelController WheelController;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (WheelController.isSpinning == false)
        {

            if (WheelController.doAction == true)
            {

                if (other.tag == "yellow")
                {
                    Debug.Log("yellow hit");
                }
                if (other.tag == "red")
                {
                    Debug.Log("red hit");
                }
                if (other.tag == "green")
                {
                    Debug.Log("green hit");
                }
                if (other.tag == "blue")
                {
                    Debug.Log("blue hit");
                }
                if (other.tag == "pink")
                {
                    Debug.Log("pink hit");
                }
                if (other.tag == "purple")
                {
                    Debug.Log("purple hit");
                }
                if (other.tag == "orange")
                {
                    Debug.Log("orange hit");
                }
            }
            WheelController.doAction = false;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
