using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame_Popup_Manager : MonoBehaviour
{
    public GameObject Setting_Popup_Prefab;
    public Transform Pannel;

    private Dictionary<string, GameObject> popupDict = new Dictionary<string, GameObject>();

	// setting popup
	public void OnClick_SettingPopup()
	{
		ShowPopup("Setting_Popup", Setting_Popup_Prefab);
	}

	private void ShowPopup(string key, GameObject prefab)
	{
		if (popupDict.ContainsKey(key) && popupDict[key] != null)
		{
			popupDict[key].SetActive(true);
		}
		else
		{
			GameObject popup = Instantiate(prefab, Pannel);
			popupDict[key] = popup;
		}
	}
}
