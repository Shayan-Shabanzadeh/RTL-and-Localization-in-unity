using System;
using System.Collections;
using System.Collections.Generic;
using RTLTMPro;
using UnityEngine;

public class SecondPageController : MonoBehaviour
{
    public RTLTextMeshPro numberText;

    public RTLTextMeshPro buttonText;
    public static bool isActive = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        IsActive();
    }

    // Update is called once per frame
    void Update()
    {
        IsActive();
        StartCoroutine(IncreasingNumber());
    }
    public IEnumerator IncreasingNumber()
    {
        int number = Convert.ToInt32(numberText.text); 
        while (isActive)
        {
            yield return new WaitForSecondsRealtime(1);
            number++;
            numberText.text = number.ToString();
        }
    }

    public void IsActive()
    {
        if (isActive)
        {
            buttonText.text = "توقف";
        }
        else
        {
            buttonText.text= "ادامه";
        }
    }
}
