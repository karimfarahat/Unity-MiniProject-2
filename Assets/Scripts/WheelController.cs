using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public GameObject Wheel;
    //public Animator buttonAnimator;
    //public Animation buttonAnimation;
    public float genSpeed;
    public float subSpeed;
    public bool isSpinning = false;
    

    public void OnMouseDown()
    {
        GetComponent<Animator>().SetBool("isPressed", true);
        genSpeed = Random.Range(5.000f, 10.000f);
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
        if (isSpinning == true)
        {
            
            Wheel.transform.Rotate(0, 0, -genSpeed, Space.World);
            genSpeed -= subSpeed;
            if (genSpeed <= 0)
            {
                isSpinning = false;
                
            }

        }

    }
}


