using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 변수 선언
    private string myName = "허재영";
    private int age = 28;
    private float height = 171f;
    private string mbti = "INFP or ENFP";
    private string hobby = "보드게임";
    private string interest = "다이어트";
    private string exercise = "복싱";
    private string favoriteSinger = "윤하";
    private string favoriteSong = "윤하의 Parade";
    private string favoriteSeason = "초여름";
    private string favoriteFood = "두부 관련 음식";

    
    void Start()
    {
        SelfIntroduction(); 
    }

    void SelfIntroduction()
    {
        Debug.Log($"제 이름은 {myName}입니다.");
        Debug.Log($"나이는 {age}살이고, 키는 {height}cm입니다.");
        Debug.Log($"MBTI는 {mbti}입니다.");
        Debug.Log($"취미는 {hobby}이고, 관심사는 {interest}입니다.");
        Debug.Log($"요즘 하는 운동은 {exercise}입니다.");
        Debug.Log($"좋아하는 가수는 {favoriteSinger}, 노래는 '{favoriteSong}'입니다.");
        Debug.Log($"가장 좋아하는 계절은 {favoriteSeason}이고, 음식은 {favoriteFood}입니다.");
    }
}
