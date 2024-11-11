using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PlayerControler playerControler;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerControler.zebranePunkty.ToString();
        if (playerControler.zebranePunkty == 6)
        {
            text.color = Color.red;
        }
    }
}
