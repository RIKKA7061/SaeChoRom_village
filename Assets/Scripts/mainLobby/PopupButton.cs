using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupButton : MonoBehaviour
{
    private DelFileButton delFileButton;
	public Button btn;

	void Start()
	{
		delFileButton = FindObjectOfType<DelFileButton>();
		btn.onClick.AddListener(OnYesClicked);
	}
	
	// ¿¹
	void OnYesClicked()
	{
		delFileButton.DelBtn(BtnIndexManager.btnIndex);
	}

}