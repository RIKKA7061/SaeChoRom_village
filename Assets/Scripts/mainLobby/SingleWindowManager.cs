using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SingleWindowManager : MonoBehaviour
{
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Component;

    public void TitleAndComponent(string title, string component)
	{
        Title.text = title;
        Component.text = component;
	}
}
