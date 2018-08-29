using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using System.Timers;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ClickEvent : MonoBehaviour
{
    
    [SerializeField]
    private GameObject timer;
    [SerializeField]
    private GameObject master;
    [SerializeField]
    private GameObject resultPanel;
    [SerializeField]
    private GameObject startTime;
    [SerializeField] 
    private GameObject configPanel; 

    private float seconds;
    private float oldSeconds;
    

    public void OnClick()
    {
        this.gameObject.SetActive(false);
        startTime.SetActive(true);
        configPanel.SetActive(false);
    }

    public void Restart()
    {
        resultPanel.SetActive(false);
        startTime.SetActive(true);
        
        
    }
}
