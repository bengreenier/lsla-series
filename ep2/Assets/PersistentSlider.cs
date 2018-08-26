using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class PersistentSlider : MonoBehaviour
{
    private string SettingsKey
    {
        get
        {
            return "PersistentSlider." + this.GetInstanceID();
        }
    }

    private void Start()
    {
        this.GetComponent<Slider>().value = PlayerPrefs.GetFloat(this.SettingsKey);
        this.GetComponent<Slider>().onValueChanged.AddListener(this.OnValueChanged);
    }

    private void OnDestroy()
    {
        this.GetComponent<Slider>().onValueChanged.RemoveListener(this.OnValueChanged);
    }

    private void OnValueChanged(float value)
    {
        PlayerPrefs.SetFloat(this.SettingsKey, value);
    }
}
