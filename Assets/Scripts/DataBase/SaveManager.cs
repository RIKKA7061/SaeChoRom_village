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
        Instance = this;
        DontDestroyOnLoad(gameObject);

        saveData = LoadGame();
    }

    public static void SaveGame(SaveData saveData)
    {
        if (saveData == null || saveData.slots == null || saveData.slots[0] == null)
        {
            ResetGame(Instance.slot);
            if (saveData == null || saveData.slots == null || saveData.slots[0] == null) return;
        }

        // 2. SaveData 객체를 JSON 형태의 문자열로 직렬화합니다. (가독성을 위해 true)
        string json = JsonUtility.ToJson(saveData, true);

        // 3. 저장 경로를 설정하고 JSON 데이터를 파일에 저장합니다.
        string filePath = Path.Combine(Application.persistentDataPath, "save.json");
        try
        {
            File.WriteAllText(filePath, json);
            Debug.Log(filePath);
            Debug.Log(json);
        }
        catch (System.Exception e)
        {
            Debug.LogError($"게임 저장 실패: {e.Message}");
        }
    }

    public static SaveData LoadGame()
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
                    Instance.saveData = loadedData; // 값을 복사
                    //Debug.Log("게임 불러오기 성공!");

                    // 값이 비어있지 않을시
                    if (Instance.saveData.slots.Length > 0 && Instance.saveData.slots[0] != null)
                    {
                        return Instance.saveData;
                    }
                    else
                    {
                        Debug.LogWarning("불러온 SaveData 객체 또는 슬롯이 비어 있거나 손상되었습니다. 초기화합니다.");
                        ResetGame(Instance.slot);
                        return Instance.saveData;
                    }
                }
                else
                {
                    Debug.LogWarning("JSON을 SaveData 객체로 역직렬화하는 데 실패했습니다. 데이터가 손상되었을 수 있습니다. 초기화합니다.");
                    ResetGame(Instance.slot);
                    return Instance.saveData;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError($"게임 불러오기 실패 (역직렬화 오류): {e.Message}. 데이터를 초기화합니다.");
                ResetGame(Instance.slot);
                return Instance.saveData;
            }
        }
        else
        {
            Debug.LogWarning("저장된 파일이 없습니다. 새로운 게임 데이터를 초기화합니다.");
            ResetGame(Instance.slot);
            return Instance.saveData;
        }
    }

    public static void ResetGame(int slot)
    {
        Instance.saveData.slots[slot].sceneNum = 0;
        SaveGame(Instance.saveData);
    }
}
