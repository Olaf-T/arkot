using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            text.text = "Zmieniony tekst";
            text.color = Color.green;
            text.fontSize = 120;
            text.fontStyle = FontStyles.Underline;
        }
    }




}