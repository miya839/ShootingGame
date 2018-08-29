using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Timers;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    
    //[SerializeField]
    //private GameObject timer;
    //[SerializeField]
    //private GameObject master;
    [SerializeField]
    private GameObject resultPanel;
    [SerializeField]
    private GameObject startTime;
    [SerializeField] 
    private GameObject configPanel;

    [SerializeField] private GameObject gameAudio;

    private float seconds;
    private float oldSeconds;

    public void OnClick()
    {
        gameAudio.GetComponent<AudioScript>().CountDown();
        //this.gameObject.SetActive(false);
        startTime.SetActive(true);
        configPanel.SetActive(false);
    }

    public void Restart()
    {
        gameAudio.GetComponent<AudioScript>().CountDown();
        resultPanel.SetActive(false);
        startTime.SetActive(true);
        
    }

    public void Config()
    {
        gameAudio.GetComponent<AudioScript>().ButtonClick();
        resultPanel.SetActive(false);
        configPanel.SetActive(true);
    }
    
}
