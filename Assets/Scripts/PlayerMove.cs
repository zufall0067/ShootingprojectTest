﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}

//    [2차 수행평가 안내]
//1) 배경이 요구하는 종스크롤 방향으로 잘 움직이는가? (2중 모두)
//2) Player는 마우스 클릭 위치로 정확하게 이동하는가?
//3) 마우스 클릭 위치를 World 좌표계로 변환하여 이동했는가?
//4) Player 이동에 경계 영역을 지정해 주었는가?
//5) Player가 경계 영역을 벗어날 경우 이동에 제한을 주었는가?
//6) Player가 총알을 잘 발사하는가?
//7) 총알이 경계 영역을 벗어날 경우 사라지는가?
//8) 코드 가독성이 좋은가?
//9) 코드 복잡도(Big-O)가 낮도록 최적화가 되어있는가?
//    ░░░░░░░░░▄░░░░░░░░░░░░░░▄░░░░
//    ░░░░░░░░▌▒█░░░░░░░░░░░▄▀▒▌░░░
//    ░░░░░░░░▌▒▒█░░░░░░░░▄▀▒▒▒▐░░░
//    ░░░░░░░▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐░░░
//    ░░░░░▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐░░░
//    ░░░▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌░░░ 
//    ░░▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌░░
//    ░░▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐░░
//    ░▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌░
//    ░▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌░
//    ▀▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐░
//    ▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌
//    ▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐░
//    ░▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌░
//    ░▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐░░
//    ░░▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌░░
//    ░░░░▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀░░░
//    ░░░░░░▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀░░░░░
//    ░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▀▀░░░░░░░░