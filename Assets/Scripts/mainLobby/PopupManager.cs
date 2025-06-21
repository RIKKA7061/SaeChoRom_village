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

	// �� ���� ����� â
	public void OnGameStart()
	{
		ShowPopup("NewGame", newGamePopupPrefab);
	}

	// �� �ƴϿ� â
	public void OnYesNoPopUp()
	{
		ShowPopup("YesNo", YesNoPopupPrefab);
	}

	// ���� â
	public void SettingPopUp()
	{
		ShowPopup("Setting", SingleWindowPrefab);
		//if (singleWindowManager == null)
		singleWindowManager = FindObjectOfType<SingleWindowManager>();
		singleWindowManager.TitleAndComponent("����", "�غ����Դϴ�.");
	}

	// ������ â
	public void DevPopUp()
	{
		ShowPopup("Dev", SingleWindowPrefab);
		//if (singleWindowManager == null)
		singleWindowManager = FindObjectOfType<SingleWindowManager>();
		singleWindowManager.TitleAndComponent("�� 24�� ����", "��ȹ : �����, ������\n���α׷��� : ��μ�");
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
