using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupButton : MonoBehaviour
{
    private DelFileButton delFileButton;
	private NewFileButton newFileButton;
	public Button btn;

	void Start()
	{
		delFileButton = FindObjectOfType<DelFileButton>();
		newFileButton = FindObjectOfType<NewFileButton>();
		btn.onClick.AddListener(OnYesClicked);
	}
	
	// ¿¹
	void OnYesClicked()
	{
		delFileButton.DelBtn(BtnIndexManager.btnIndex);
	}

}