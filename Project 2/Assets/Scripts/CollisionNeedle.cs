using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionNeedle : MonoBehaviour
{
    public WheelController WheelController;
    public GameObject panel;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI textText;
    public TextMeshProUGUI buttonText;
    private string SpinA = "Spin Again";

    public GameObject guava;
    public GameObject orange;
    public GameObject apple;
    public GameObject blackberry;
    public GameObject milk;
    public GameObject mango;
    public GameObject pineapple;
    public GameObject fruitPos;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
      
    }

    public void openPanel(string title, string desc, GameObject fruit)
    {
        if (panel != null)
        {
            panel.SetActive(true);

            titleText.text = title;
            textText.text =desc;
            buttonText.text =  SpinA;
        fruit.transform.position = fruitPos.transform.position;
        fruit.GetComponent<Animator>().SetBool("animate", true);
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

                    string title = "Guava";
                    string Descrip = "Guava Juice is a quick source of nutrition to refresh you in this sweltering summer heat . Guava Juice keeps you hydrated and is a delicious source of Vitamin C.";

                    openPanel(title, Descrip, guava );
                    
                }
                if (other.tag == "red")
                {
                    Debug.Log("red hit");

                    string title = "Apple";
                    string Descrip = "Apple juice can do more than hydrate. It's also rich in vitamin C — and if you pick a brand that's added an extra vitamin boost to its juice, one serving could help you meet more than 100 percent of your recommended daily intake of vitamin C.";
                    openPanel(title, Descrip, apple);
                }
                if (other.tag == "green")
                {
                    Debug.Log("green hit");

                    string title = "Pineapple";
                    string Descrip = "Pineapple health juice benefits include immune booster and inflammation fighter, helps to detoxify the body and mind, incredibly great for vision, regulates blood pressure, cancer protective, strengthens gums, promotes digestion, treats ulcerative colitis, good for arthritic patients, reduces menstrual cramps, supports healthy skin, cures asthma.";
                    openPanel(title, Descrip, pineapple);
                }
                if (other.tag == "blue")
                {
                    Debug.Log("blue hit");

                    string title = "Milk";
                    string Descrip = "Milk is an excellent source of vitamins and minerals.It provides potassium, B12, calcium and vitamin D, which are lacking in many diets(4Trusted Source).Milk is also a good source of vitamin A, magnesium, zinc and thiamine(B1).Additionally, it’s an excellent source of protein and contains hundreds of different fatty acids, including conjugated linoleic acid(CLA) and omega-3s(5Trusted Source).";
                    openPanel(title, Descrip, milk);
                }
                if (other.tag == "pink")
                {
                    Debug.Log("pink hit");
                    string title = "Mango";
                    string Descrip = "It’s a drupe, or stone fruit, which means that it has a large seed in the middle.This fruit is not only delicious but also boasts an impressive nutritional profile.In fact, studies link mango and its nutrients to health benefits, such as improved immunity, digestive health and eyesight, as well as a lower risk of certain cancers.";
                    openPanel(title, Descrip, mango);
                }
                if (other.tag == "purple")
                {
                    Debug.Log("purple hit");
                    string title = "Black Berries";
                    string Descrip = "Blackberries offer many health benefits, including: Full of vitamins and minerals like C, K, and manganese. High in fiber. May boost brain health.";
                    openPanel(title, Descrip, blackberry);
                }
                if (other.tag == "orange")
                {
                    Debug.Log("orange hit");
                    string title = "Orange";
                    string Descrip = "Orange juice is enjoyed around the world.It’s naturally high in vital nutrients, such as vitamin C and potassium.Plus, commercial varieties are often enriched with calcium and vitamin D.";
                    openPanel(title, Descrip, orange);

                }
            }
            WheelController.doAction = false;
/*            guava.GetComponent<Animator>().SetBool("animate", false);
            orange.GetComponent<Animator>().SetBool("animate", false);
            apple.GetComponent<Animator>().SetBool("animate", false);
            milk.GetComponent<Animator>().SetBool("animate", false);
            blackberry.GetComponent<Animator>().SetBool("animate", false);
            mango.GetComponent<Animator>().SetBool("animate", false);
            pineapple.GetComponent<Animator>().SetBool("animate", false);*/
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
