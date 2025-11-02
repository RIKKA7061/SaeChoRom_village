using UnityEngine;
using TMPro;

public class ChangeBtnTxt : MonoBehaviour
{
	public SaveData saveData;
	public TextMeshProUGUI[] newFile_BtnTxts;

	void Awake()
	{
		saveData = SaveManager.LoadGame();
	}

	// 버튼 내용 바꾸기
	public void Update_BtnTxt()
	{
		saveData = SaveManager.LoadGame();
		for (int slot = 0; slot < 3; slot++)
		{
			int questNum = saveData.slots[slot].sceneNum;
			newFile_BtnTxts[slot].text = QuestDataManager.questData[questNum];
		}
	}
}
