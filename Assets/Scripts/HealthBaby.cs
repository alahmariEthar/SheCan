using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBaby : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMinHealth(int health){
        slider.minValue = health;
        slider.value = health;
      fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health){
          slider.value = health;
          fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
