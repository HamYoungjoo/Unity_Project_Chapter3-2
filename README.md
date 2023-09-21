# 유니티 숙련 주차 개인 프로젝트

<br>

## 🖥 프로젝트 소개 
- Unity 버전 스파르타 던전 : 이전에 콘솔로 제작 해본 던전 게임을 유니티에 적용시켜 본다.
<br>


### 🐈‍⬛ **프로젝트명** : CAT HERO
- 고양이가 주인공이 되어 악당들을 물리치는 컨셉의 게임.
<br>

### 🕰 **프로젝트 기간** : 2023.09.18 ~ 2023.09.22


### ✅제작 과정
- 기획단계 와이어 프레임
<img width="960" alt="와이어프레임" src="https://github.com/HamYoungjoo/Unity_Project_Chapter3-2/assets/141566906/88aab54d-0988-49c6-aac8-f89869413c64">

<br>
<br>

- 실제 제작도 

![제작도](https://github.com/HamYoungjoo/Unity_Project_Chapter3-2/assets/141566906/7b6a3a54-1432-4dc9-ad7e-e66474171ae0)


<br>

### ✅ 구현 기능
- 이름 입력 기능 : UI-InputField를 이용해 이름을 입력받는 UI를 만들었다. (StartScene에서 사용자의 이름을 입력 받아야지만 다음 MainScene으로의 이동이 가능하게 구현.)
- 캐릭터 애니매이션 : 캐릭터 이미지 두장으로 애니매이션을 만들어 플레이어 캐릭터가 움직이는 것 처럼 만들었다.
- 캐릭터 이동 : InputAction을 설정해, 키보드의 방향키를 누르면 상하좌우로 이동하게 만들었고, 캐릭터의 얼굴 방향이 우측을 누르면 우측을 향하고 좌측을 누르면 좌측을 향하도록 설정하였다. 캐릭터의 움직임에 따라 카메라도 이동하도록 하였다. 
- 배경 : 타일맵 기능을 이용해 게터타운처럼 캐릭터가 자유롭게 움직일 수 있는 공간을 만들고 Collider를 설정해서 캐릭터와 벽이 만나면 충돌로 인식해 벽을 넘어갈 수 없도록 하였다.
- 시간 표시 : MainScene 좌측 상단에 현재 시간을 UI-Text를 통해 설정해두었다.

<br>

### ✅ 게임 화면 
Start Scene 

![스크린샷 2023-09-07 오전 11 08 35](https://github.com/HamYoungjoo/Unity_week1_project/assets/141566906/189bc0d9-68b0-40cc-9200-fadcfbfd0e2e)

Main Scene

![스크린샷 2023-09-07 오전 11 09 10](https://github.com/HamYoungjoo/Unity_week1_project/assets/141566906/a59ca638-b665-44aa-82fa-6d1671018198)
