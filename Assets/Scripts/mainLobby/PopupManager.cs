using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
	public GameObject newGamePopupPrefab;
	public GameObject YesNoPopupPrefab;
	public Transform popupParent;
	private List<GameObject> PopupList = new List<GameObject>();

	public void OnGameStart()
	{
		if (PopupList.Count == 0)
		{
			GameObject popup = Instantiate(newGamePopupPrefab, popupParent);
			PopupList.Add(popup);
		}
		else if (PopupList[0].activeSelf == false)
		{
			PopupList[0].SetActive(true);
		}
	}

	public void OnYesNoPopUp()
	{
		if (PopupList.Count == 1)
		{
			GameObject popup = Instantiate(YesNoPopupPrefab, popupParent);
			PopupList.Add(popup);
		}
		else if (PopupList[1].activeSelf == false)
		{
			PopupList[1].SetActive(true);
		}
	}
}
