using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NewFileButton : MonoBehaviour
{
	public int slot; // 0 1 2
    public Button btn;
    public TextMeshProUGUI btnTxt;
	private ChangeBtnTxt changeBtnTxt;
	private SaveManager saveManager;
	public SaveData saveData;

	void Start()
	{
		changeBtnTxt = FindObjectOfType<ChangeBtnTxt>();
		saveManager = FindObjectOfType<SaveManager>();

		saveData = saveManager.LoadGame();
		int questNum = saveData.slots[slot].currentMapIndex;

		changeBtnTxt.Update_BtnTxt();

		btn.onClick.AddListener(OnClick_NewFileBtn);
	}

	public void OnClick_NewFileBtn()
	{
		saveData = saveManager.LoadGame();
		int currentMapIndex = saveData.slots[slot].currentMapIndex;
		if (currentMapIndex > 0)
		{
			string SceneName = MapDataManager.MapSceneName[currentMapIndex];
			SceneManager.LoadScene(SceneName); // ex. 01-ShipLand
		}
		else if (currentMapIndex == 0)
		{
			saveData.slots[slot].currentMapIndex = 1;
			saveManager.SaveGame(saveData);
		}
		currentMapIndex = saveData.slots[slot].currentMapIndex;
		Debug.Log($"슬롯 {slot}, 현재 맵 번호{currentMapIndex} ");

		// 버튼 내용 업뎃
		if (QuestDataManager.questData.ContainsKey(currentMapIndex))
		{
			changeBtnTxt.Update_BtnTxt();
		}
		else
		{
			btnTxt.text = "알 수 없는 퀘스트";
		}
	}

	public void ResetBtnTxt()
	{
		for (int i = 0; i < 3; i++)
		{
			saveManager.ResetGame(slot);
			saveManager.SaveGame(saveData);
			int questNum = saveData.slots[slot].currentMapIndex;
			Debug.Log(questNum);
			if (QuestDataManager.questData.ContainsKey(questNum))
			{
				// 버튼 내용 업뎃
				changeBtnTxt.Update_BtnTxt();
			}
			else
			{
				btnTxt.text = "알 수 없는 퀘스트";
			}
		}
	}

}
