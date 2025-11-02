using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPageManager : MonoBehaviour
{
    public void NextPage()
	{
		SaveData saveData = SaveManager.LoadGame();
		int sceneNum = saveData.slots[0].sceneNum;
		Debug.Log(sceneNum);

		int maxSceneNum = MapDataManager.MapSceneName.Count; // ex.13

		if (sceneNum >= maxSceneNum)
		{
			SceneManager.LoadScene("mainLobby");
		}
		else
		{
			saveData.slots[0].sceneNum += 1;
			SaveManager.SaveGame(saveData);

			string SceneName = MapDataManager.MapSceneName[sceneNum + 1];
			SceneManager.LoadScene(SceneName);
		}
	}
}
