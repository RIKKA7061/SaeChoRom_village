/*
새 파일 만들기
현재 위치

*/


[System.Serializable]
public class SaveSlotData
{
    public int sceneNum;       // 현 위치
}

[System.Serializable]
public class SaveData
{
    public SaveSlotData[] slots; // No default array size here, initialize in constructor or elsewhere

    // Constructor to ensure the slots array is always initialized
    public SaveData()
    {
        slots = new SaveSlotData[3]; // Fixed 3 slots
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i] = new SaveSlotData(); // Initialize each SaveSlotData within the array
        }
    }
}