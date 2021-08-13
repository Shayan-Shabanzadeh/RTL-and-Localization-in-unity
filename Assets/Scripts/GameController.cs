using System;
using System.Collections;
using RTLTMPro;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject firstPage;
    public GameObject secondPage;

    public TMP_InputField inputField;
    public TextMeshProUGUI resultText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FirstPage()
    {
        firstPage.SetActive(true);
        secondPage.SetActive(false);
        mainPage.SetActive(false);
    }

    public void SecondPage()
    {
        firstPage.SetActive(false);
        secondPage.SetActive(true);
        mainPage.SetActive(false);
    }
    
    public void ReturnToMainMenu()
    {
        firstPage.SetActive(false);
        secondPage.SetActive(false);
        mainPage.SetActive(true);
    }

    public void Print()
    {
        string s = "Your text is : "+inputField.text;
        resultText.GetComponent<TextMeshProUGUI>().text = s;
        //inputField.text = "";
    }

    public void SetButtonActiveOrDeActive()
    {
        if (SecondPageController.isActive)
        {
            SecondPageController.isActive = false;
        }
        else
        {
            SecondPageController.isActive = true;
        }
    }
    
    
}
