using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    TextMeshProUGUI gt;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        gt.text = score.ToString("#,0");
    }
}
