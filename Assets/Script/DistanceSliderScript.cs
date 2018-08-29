using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceSliderScript : MonoBehaviour
{

    private Slider _slider;
    public Text distance;

    void Start()
    {
        _slider = this.gameObject.GetComponent<Slider>();
        MasterScript.targetDist = _slider.value;
        distance.text = "Distance:" + _slider.value.ToString("0") + "m";
    }
    

    public void onValueChange()
    {
        MasterScript.targetDist = _slider.value;
        distance.text = "Distance:" + _slider.value.ToString("0") + "m";
        Debug.Log(_slider.value);
    }
}
