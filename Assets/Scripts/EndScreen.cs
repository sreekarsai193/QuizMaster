using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Awake()
    {
        scoreKeeper=FindObjectOfType<ScoreKeeper>();
    }
    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\n you got a score "
            +scoreKeeper.CalculateScore()+"%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
