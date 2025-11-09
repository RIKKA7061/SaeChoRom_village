using System.Collections;
using UnityEngine;
using TMPro;

public class TitleManager : MonoBehaviour
{
    public TMP_Text titleText;
    public GameObject loadingPannel;

    void Start()
    {
        StartCoroutine(WaitAndShowTitle());
    }

    IEnumerator WaitAndShowTitle()
    {
        // 데이터 준비될 때까지 대기
        while (!DataTableManager.isReady)
        {
            titleText.text = "준비중입니다...";
            loadingPannel.SetActive(true);
            yield return new WaitForSeconds(0.5f); // 0.5초마다 다시 확인
        }

        // 준비 완료 후 제목 표시
        string[] row1 = DataTableManager.col[1].Split('\t');
        titleText.text = row1[1];
        loadingPannel.SetActive(false); 
    }
}
