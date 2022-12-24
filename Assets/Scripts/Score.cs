using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score Instance;
    public TextMeshProUGUI txt;
    int score=0;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) { Instance = this; }
    }

    public void changescore(int coinsval)
    {
        score=score+ coinsval;
        txt.text="Score: "+score.ToString();
    }
    
}
