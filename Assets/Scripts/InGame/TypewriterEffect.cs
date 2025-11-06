using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public TMP_Text tmpText;        // 출력할 TMP 텍스트
    [TextArea]
    public string fullText;         // 전체 문장
    public float delay = 0.05f;     // 한 글자당 딜레이 (초 단위)
    AudioSource audioSource;
    public AudioClip typeSound;

    private void Start()
    {
        tmpText.text = "";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            tmpText.text = fullText.Substring(0, i + 1);
            yield return new WaitForSeconds(delay);
        }
    }
}
