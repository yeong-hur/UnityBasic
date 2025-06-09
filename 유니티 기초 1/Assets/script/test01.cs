using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test01 : MonoBehaviour
{
    List<string> Character = new List<string>();

    void Start()
    {
        // 캐릭터 등록
        Character.Add("경일이");
        Character.Add("일경이");
        Character.Add("KY");
        Character.Add("NADA");
        Character.Add("나강림");
        Character.Add("현성이");
        Character.Add("석철이");
        Character.Add("옥점례");
        Character.Add("계윤수");
        Character.Add("퇴근이");

        // 10연차 뽑기
        Debug.Log("==== 10연차 뽑기 결과 ====");

        for (int i = 1; i <= 10; i++)
        {
            int randomIndex = Random.Range(0, Character.Count);
            string selectedCharacter = Character[randomIndex];
            Debug.Log($"[{i}번째] {selectedCharacter}를 뽑았다!");
        }
    }
}


