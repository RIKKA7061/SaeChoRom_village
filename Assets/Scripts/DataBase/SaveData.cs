/*
새 파일 만들기
현재 위치
현 퀘스트 단계
찾은 단서수, 만난 사람 수(용의자), 용의자 증거 나옴

*/


[System.Serializable]
public class SaveSlotData
{
    public int currentMapIndex;       // 현 위치
    public int unlockedMapCount;      // 현 퀘스트 단계 
    public bool[] unlockedClues;      // 찾은 단서 수
    public bool[] susMeetCount;       // 만난 용의자 수
    public bool[] unlockedEvidence;        // 혐의 수

    public SaveSlotData()
    {
        unlockedClues = new bool[10];      // 필드 단서 총 10개
        unlockedEvidence = new bool[10];        // 혐의 총 9개
    }
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