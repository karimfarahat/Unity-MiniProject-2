using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public GameObject Wheel;
    public GameObject Needle;
    

    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;
    public bool doAction = false;
    bool move = true;


    public void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("isPressed", true);
        genSpeed = 2.0f; //Random.Range(5.000f, 10.000f);
        subSpeed = Random.Range(0.003f, 0.009f);
        isSpinning = true;
    }
    private void OnMouseUp()
    {
        GetComponent<Animator>().SetBool("isPressed", false);
    }


    // Update is called once per frame
    void Update()
    {
        //law beyspin
        if (isSpinning == true)
        {

            Wheel.transform.Rotate(0, 0, -genSpeed, Space.World);
            genSpeed -= subSpeed;
            if (genSpeed <= 0)
            {
                isSpinning = false;
                doAction = true;

            }

        }
        else
        {

            //law batal yespin w hanharak el needle lel wheel
            if (doAction == true && move == true)
            {
                Needle.transform.Translate(0, 0, 0.5f, Space.World);
                move = false;

            }

            //law wa2ef wel needle fel wheel
            else if (doAction == false && move == false)
            {
                Needle.transform.Translate(0, 0, -0.5f, Space.World);
                move = true;

            }

        }


    }
}


