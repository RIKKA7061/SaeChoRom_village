using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DelFileButton : MonoBehaviour
{
	public int btnIndex;
	public Button delBtn;
	public TextMeshProUGUI newFileBtnTxt;
	private PopupManager popupManager;
	private ChangeBtnTxt changeBtnTxt;

	private void Start()
	{
		popupManager = FindObjectOfType<PopupManager>();
		changeBtnTxt = FindObjectOfType<ChangeBtnTxt>();
		delBtn.onClick.AddListener(YesNoPopup);
	}
	private void YesNoPopup()
	{
		BtnIndexManager.btnIndex = btnIndex;
		popupManager.OnYesNoPopUp();
	}

	// ��
	public void DelBtn(int btnIndex)
	{
		int questNum = PlayerPrefs.GetInt("questNum" + btnIndex, 0);
		if (questNum > 0)
		{
			PlayerPrefs.SetInt("questNum" + btnIndex, 0);
			int resettedQuest = PlayerPrefs.GetInt("questNum" + btnIndex);
			newFileBtnTxt.text = QuestDataManager.questData[resettedQuest];
		}

		// ��ư �ؽ�Ʈ ����
		changeBtnTxt.Update_BtnTxt();
	}
}