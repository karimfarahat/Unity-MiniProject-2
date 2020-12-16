using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionNeedle : MonoBehaviour
{
    public WheelController WheelController;
    public GameObject panel;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI textText;
    public TextMeshProUGUI buttonText;
    private string SpinA = "Spin Again";
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    public void SpinAgain()
    {

        panel.SetActive(false);
    }

    public void openPanel(string title, string desc)
    {
            panel.SetActive(true);
            //titleText = GetComponent<TMP_Text>();
            titleText.text = title;
            //textText = GetComponent<TMP_Text>();
            textText.text =desc;
           // buttonText = GetComponent<TMP_Text>();
            buttonText.text =  SpinA;
            
        
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

                    openPanel(title, Descrip);
                    
                }
                if (other.tag == "red")
                {
                    Debug.Log("red hit");

                    string title = "Apple";
                    string Descrip = "Apple juice can do more than hydrate. It's also rich in vitamin C — and if you pick a brand that's added an extra vitamin boost to its juice, one serving could help you meet more than 100 percent of your recommended daily intake of vitamin C.";
                    openPanel(title, Descrip);
                }
                if (other.tag == "green")
                {
                    Debug.Log("green hit");

                    string title = "Pineapple";
                    string Descrip = "Pineapple health juice benefits include immune booster and inflammation fighter, helps to detoxify the body and mind, incredibly great for vision, regulates blood pressure, cancer protective, strengthens gums, promotes healthy digestion, treats ulcerative colitis, good for arthritic patients, reduces menstrual cramps, supports healthy skin, cures Asthma.";
                    openPanel(title, Descrip);
                }
                if (other.tag == "blue")
                {
                    Debug.Log("blue hit");

                    string title = "Milk";
                    string Descrip = "Milk is an excellent source of vitamins and minerals.It provides potassium, B12, calcium and vitamin D, which are lacking in many diets(4Trusted Source).Milk is also a good source of vitamin A, magnesium, zinc and thiamine(B1).Additionally, it’s an excellent source of protein and contains hundreds of different fatty acids, including conjugated linoleic acid(CLA) and omega-3s(5Trusted Source).";
                    openPanel(title, Descrip);
                }
                if (other.tag == "pink")
                {
                    Debug.Log("pink hit");

                    string title = "Mango";
                    string Descrip = "It’s a drupe, or stone fruit, which means that it has a large seed in the middle.This fruit is not only delicious but also boasts an impressive nutritional profile.In fact, studies link mango and its nutrients to health benefits, such as improved immunity, digestive health and eyesight, as well as a lower risk of certain cancers.";
                    openPanel(title, Descrip);
                }
                if (other.tag == "purple")
                {
                    Debug.Log("purple hit");

                    string title = "Black Berries";
                    string Descrip = "Blackberries offer many health benefits, including: Full of vitamins and minerals like C, K, and manganese. High in fiber. May boost brain health.";
                    openPanel(title, Descrip);
                }
                if (other.tag == "orange")
                {
                    Debug.Log("orange hit");

                    string title = "Orange";
                    string Descrip = "Orange juice is enjoyed around the world.It’s naturally high in vital nutrients, such as vitamin C and potassium.Plus, commercial varieties are often enriched with calcium and vitamin D.Nonetheless.Here are 5 health benefits of orange juice.";
                    openPanel(title, Descrip);
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
