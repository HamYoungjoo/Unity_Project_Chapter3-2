# 유니티 숙련 주차 개인 프로젝트

<br>

## 🖥 프로젝트 소개 
- Unity 버전 스파르타 던전 : 이전에 콘솔로 제작 해본 던전 게임을 유니티에 적용시켜 본다.
<br>


### 🐈‍⬛ **프로젝트명** : CAT HERO
- 고양이가 주인공이 되어 악당들을 물리치는 컨셉의 게임.
<br>

### 🕰 **프로젝트 기간** : 2023.09.18 ~ 2023.09.22

### ✅ 개발 환경 
**Unity 2022.3.2f** 
-해상도 :  1280 *720 (스마트폰 가로 사이즈 기준)
<br>

### ✅제작 과정
- 기획단계 와이어 프레임
<img width="960" alt="와이어프레임" src="https://github.com/HamYoungjoo/Unity_Project_Chapter3-2/assets/141566906/88aab54d-0988-49c6-aac8-f89869413c64">

<br>
<br>

- 실제 제작도 

![제작도](https://github.com/HamYoungjoo/Unity_Project_Chapter3-2/assets/141566906/7b6a3a54-1432-4dc9-ad7e-e66474171ae0)


<br>

### ✅ 구현 기능
- **status, inventory 버튼** : UI-Button을 이용해 만들고 각각 함수를 만들어 누르면 패널이 뜨고 패널이 뜰 때는 버튼이 작동하지 않도록 했다.
- **뒤로가기 버튼** : 패널이 떴을 때 같이 나타나는 버튼으로 누르면 다시 status,inventory 버튼이 활성화된 상태로 돌아간다. 
- **Inventory** : 아이템이 담길 슬롯을 prefab화 해준 뒤 부모 오브젝트의 Grid Layout Group으로 위치를 잡아준 뒤 instantiate로 생성된다. 아이템은 함께 prefab화 해준 슬롯의 하위 오브젝트의 이미지로 들어가고 inspector 창에서 이미지 배열에 추가 할 수 있다. 
- **배경** : 특별한 기능 없이 단순히 보이는 화면 (배경, 골드 , 캐릭터, 캐릭터 정보 등)은 UI로 처리 하였다. 


<br>

### ✅ 게임 화면 

![게임화면](https://github.com/HamYoungjoo/Unity_Project_Chapter3-2/assets/141566906/7a8b9b9a-a5b0-4571-804a-3c1a5bc75261)
