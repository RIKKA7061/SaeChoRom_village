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
	private SaveManager saveManager;

	public SaveData saveData;

	private void Start()
	{
		popupManager = FindObjectOfType<PopupManager>();
		changeBtnTxt = FindObjectOfType<ChangeBtnTxt>();
		saveManager = FindObjectOfType<SaveManager>();
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
		saveManager.ResetGame(slot);
		saveData = saveManager.LoadGame();
		changeBtnTxt.Update_BtnTxt();
	}
}