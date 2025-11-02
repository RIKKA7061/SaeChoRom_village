using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DelFileButton : MonoBehaviour
{
	public int slot;
	public Button delBtn;
	public TextMeshProUGUI newFileBtnTxt;
	private PopupManager popupManager;
	private ChangeBtnTxt changeBtnTxt;

	public SaveData saveData;

	private void Start()
	{
		popupManager = FindObjectOfType<PopupManager>();
		changeBtnTxt = FindObjectOfType<ChangeBtnTxt>();
		delBtn.onClick.AddListener(YesNoPopup);
	}
	private void YesNoPopup()
	{
		BtnIndexManager.slot = this.slot;
		popupManager.OnYesNoPopUp();
	}

	// ¿¹
	public void DelBtn(int slot)
	{
		SaveManager.ResetGame(slot);
		saveData = SaveManager.LoadGame();
		changeBtnTxt.Update_BtnTxt();
	}
}