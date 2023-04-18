using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class TestScript : MonoBehaviour
{
    public TMP_Text wordText;
    public TMP_Text wordMeanText;
    public TMP_Text congText;

    public List<string> firstList;
    public List<string> tirthList;

    public GameObject wordCanvas;
    public GameObject bgCanvas;

    public string metin;

    public int index;
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }    
    }

    public void OnButton1Click()
    {
        // Birinci listeden rastgele bir eleman seç ve sil
        int index = Random.Range(0, firstList.Count);
        
        wordText.text = firstList[index];
        wordMeanText.text = tirthList[index];

        firstList.RemoveAt(index);
        tirthList.RemoveAt(index);

        if (firstList.Count <= 0)
        {
            congText.text = "Tebrikler! Tüm kelimeleri kendi seviyende öğrendin! Şimdi seviye atlama zamanı. Başa dönün ve yeni seviyenizde devam edin!";
        }
    }

    public void exitButton()
    {
        SceneManager.LoadScene(0);
    }

    public void a1Button()
    {
        SceneManager.LoadScene(1);
    }
    
    public void a2Button()
    {
        SceneManager.LoadScene(2);
    }

    public void b1Button()
    {
        SceneManager.LoadScene(3);
    }
    
    public void b2Button()
    {
        SceneManager.LoadScene(4);
    }

    public void exitApp()
    {
        Application.Quit();
    }
}