using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int playLif;
    public int PlayScore;
    public TextMeshProUGUI PlayLifDisplay;
    public TextMeshProUGUI PlayScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Updatelife()
    {
        PlayLifDisplay.text = playLif.ToString();
    }
}
