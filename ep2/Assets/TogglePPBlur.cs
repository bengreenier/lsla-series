using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(PostProcessVolume))]
public class TogglePPBlur : MonoBehaviour
{
    private bool toggleState = false;

    private void Awake()
    {
        this.toggleState = this.GetComponent<DepthOfField>().enabled;
    }

    public void Toggle()
    {
        if (this.toggleState)
        {
            this.Hide();
        }
        else
        {
            this.Show();
        }

        this.toggleState = !this.toggleState; 
    }

    public void Show()
    {
        this.GetComponent<DepthOfField>().enabled.value = true;
    }

    public void Hide()
    {
        this.GetComponent<DepthOfField>().enabled.value = false;
    }
}
