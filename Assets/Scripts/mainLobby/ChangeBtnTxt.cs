using UnityEngine;
using TMPro;

public class ChangeBtnTxt : MonoBehaviour
{
	private SaveManager saveManager;
	public SaveData saveData;
	public TextMeshProUGUI[] newFile_BtnTxts;

	void Awake()
	{
		saveManager = FindObjectOfType<SaveManager>();

		saveData = saveManager.LoadGame();
	}

	// 버튼 내용 바꾸기
	public void Update_BtnTxt()
	{
		saveData = saveManager.LoadGame();
		for (int slot = 0; slot < 3; slot++)
		{
			int questNum = saveData.slots[slot].currentMapIndex;
			newFile_BtnTxts[slot].text = QuestDataManager.questData[questNum];
		}
	}
}
