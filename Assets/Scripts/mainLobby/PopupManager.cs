using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
	public GameObject newGamePopupPrefab;
	public GameObject YesNoPopupPrefab;
	public GameObject SingleWindowPrefab;
	public Transform popupParent;

	private Dictionary<string, GameObject> popupDict = new Dictionary<string, GameObject>();
	private SingleWindowManager singleWindowManager;

	private void Start()
	{
	}

	// 새 파일 만들기 창
	public void OnGameStart()
	{
		ShowPopup("NewGame", newGamePopupPrefab);
	}

	// 예 아니오 창
	public void OnYesNoPopUp()
	{
		ShowPopup("YesNo", YesNoPopupPrefab);
	}

	// 설정 창
	public void SettingPopUp()
	{
		ShowPopup("Setting", SingleWindowPrefab);
		//if (singleWindowManager == null)
		singleWindowManager = FindObjectOfType<SingleWindowManager>();
		singleWindowManager.TitleAndComponent("설정", "준비중입니다.");
	}

	// 제작진 창
	public void DevPopUp()
	{
		ShowPopup("Dev", SingleWindowPrefab);
		//if (singleWindowManager == null)
		singleWindowManager = FindObjectOfType<SingleWindowManager>();
		singleWindowManager.TitleAndComponent("팀 24시 연등", "기획 : 정재욱, 정재훈\n프로그래머 : 김민수");
	}

	private void ShowPopup(string key, GameObject prefab)
	{
		if (popupDict.ContainsKey(key) && popupDict[key] != null)
		{
			popupDict[key].SetActive(true);
		}
		else
		{
			GameObject popup = Instantiate(prefab, popupParent);
			popupDict[key] = popup;
		}
	}
}
