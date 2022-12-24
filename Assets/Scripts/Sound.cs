using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sound : MonoBehaviour
{
    private Sprite soundonimage;
    public Sprite soundoffimage;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
        soundonimage = button.image.sprite;
    }

    

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundoffimage;
            isOn = false;
            audioSource.mute= true;

        }
        else
        {
            button.image.sprite = soundonimage;
            isOn = true;
            audioSource.mute = false;

        }
    }
}
