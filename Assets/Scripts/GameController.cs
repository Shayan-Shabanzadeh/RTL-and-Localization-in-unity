using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject mainPage;

    public GameObject firstPage;

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
        mainPage.SetActive(false);
        firstPage.SetActive(true);
    }
    
    public void ReturnToMainMenu()
    {
        firstPage.SetActive(false);
        mainPage.SetActive(true);
    }

    public void Print()
    {
        string s = "Your text is : "+inputField.text;
        resultText.GetComponent<TextMeshProUGUI>().text = s;
        //inputField.text = "";
    }
}
