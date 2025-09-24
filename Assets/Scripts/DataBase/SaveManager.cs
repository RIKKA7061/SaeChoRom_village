using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; private set; }
    public SaveData saveData;
    public int slot;

    void Awake()
    {
		if (Instance == null)
		{
            Instance = this;
            DontDestroyOnLoad(gameObject);
		}

        saveData = LoadGame();
    }

    public void SaveGame(SaveData saveData)
    {
        if (saveData == null || saveData.slots == null || saveData.slots[0] == null)
        {
            ResetGame(slot);
            if (saveData == null || saveData.slots == null || saveData.slots[0] == null) return;
        }

        // 2. SaveData 객체를 JSON 형태의 문자열로 직렬화합니다. (가독성을 위해 true)
        string json = JsonUtility.ToJson(saveData, true);

        // 3. 저장 경로를 설정하고 JSON 데이터를 파일에 저장합니다.
        string filePath = Path.Combine(Application.persistentDataPath, "save.json");
        try
        {
            File.WriteAllText(filePath, json);
        }
        catch (System.Exception e)
        {
            Debug.LogError($"게임 저장 실패: {e.Message}");
        }
    }

    public SaveData LoadGame()
    {
        // 저장된 경로에서 json파일 가져오기
        string filePath = Path.Combine(Application.persistentDataPath, "save.json");

        // json파일에 값이 존재한다면
        if (File.Exists(filePath))
        {
            try
            {
                // json 파일을 가져오기
                string json = File.ReadAllText(filePath);

                // json 파일을 SaveData형 변수로 저장
                SaveData loadedData = JsonUtility.FromJson<SaveData>(json);

                // 값이 비어있지 않다면
                if (loadedData != null)
                {
                    saveData = loadedData; // 값을 복사
                    //Debug.Log("게임 불러오기 성공!");

                    // 값이 비어있지 않을시
                    if (saveData.slots.Length > 0 && saveData.slots[0] != null)
                    {
                        return saveData;
                    }
                    else
                    {
                        Debug.LogWarning("불러온 SaveData 객체 또는 슬롯이 비어 있거나 손상되었습니다. 초기화합니다.");
                        ResetGame(slot);
                        return saveData;
                    }
                }
                else
                {
                    Debug.LogWarning("JSON을 SaveData 객체로 역직렬화하는 데 실패했습니다. 데이터가 손상되었을 수 있습니다. 초기화합니다.");
                    ResetGame(slot);
                    return saveData;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError($"게임 불러오기 실패 (역직렬화 오류): {e.Message}. 데이터를 초기화합니다.");
                ResetGame(slot);
                return saveData;
            }
        }
        else
        {
            Debug.LogWarning("저장된 파일이 없습니다. 새로운 게임 데이터를 초기화합니다.");
            ResetGame(slot);
            return saveData;
        }
    }

    public void ResetGame(int slot)
    {
        saveData.slots[slot].currentMapIndex = 0;
        saveData.slots[slot].unlockedMapCount = 0;
        saveData.slots[slot].unlockedClues = new bool[10];
        saveData.slots[slot].unlockedEvidence = new bool[10];
        SaveGame(saveData);
    }
}
