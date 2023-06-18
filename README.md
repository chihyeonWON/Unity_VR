# Unity_Project
Unity_Project on 2023 Summer Vacation.

## Unity 설치하기

[Unity Korea](https://unity.com/kr/download)
```
Windows 운영체제에 맞는 Unity를 다운
Personal(무료) 버전 2019.1.10f1, Unity Hub 2.0.4
```
## 씬에 물체 배치하기

![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/90c85383-7bb4-4a70-bfc5-c79773422621)
```
GameObject -> 3D Object -> Plane(평면), Cube(정육면체) 작성
```
## 시점 기본 조작
```
이동 : Ctrl + Alt 누르고 마우스 클릭&드래그
회전 : Alt 누르고 클릭&드래그
확대 및 축소 : 마우스 휠 스크롤 조작
```
## 컴포넌트 추가하기
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b3c8982e-62fb-4981-9de9-2c8fa991c38a)
```
3D Object의 Capsule을 생성, 선택하고 compononent 탭에서 add를 누른다음
rigidbody 컴포넌트를 선택합니다.

재생 버튼을 누르면 캡슐이 중력을 받아 떨어지면서 지면과 충돌합니다.

rigidbody 컴포넌트 외에도 대표적인 컴포넌트들을 학습하였습니다.

Transform 컴포넌트 : 씬에서의 위치, 회전 스케일의 상태
Collider 컴포넌트, Mesh Filter 컴포넌트, Renderer/Mesh Renderer 컴포넌트, Camera컴포넌트
Light 컴포넌트, Audio Listener 컴포넌트, Audio Source 컴포넌트, Script 컴포넌트 등
다양한 컴포넌트가 있습니다.
```
## 프로젝트에 필요한 에셋 추가하기
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/c279690c-2e94-4914-bcfc-2fa7c4093058)
```
에셋스토어에서 다양한 에셋들을 선택 및 다운로드 하고 프로젝트에 import 하는 방법을 알아보았습니다.

VR Shooting 파일 밑으로 음성 관련한 에셋 Audio와 게임 오브젝트의 템플릿에 해당하는 Prefabs 파일
오브젝트의 표면 색상이나 요철 등의 외관의 표현을 목적으로 한 Textures 파일
오브젝트를 그릴 때의 렌더링 방법을 표현하는 Material 파일
캐릭터나 배경의 모델 데이터 Models 파일

크게 총 5종류의 에셋 파일을 프로젝트에 추가하였습니다.
```
## 지면 에셋을 프로젝트에 배치하기
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/562a8ea1-a9f2-4925-a681-af815639832c)
```
에셋 스토어에서 임포트한 에셋은 씬 뷰 또는 하이어라키 창에 드래그 앤 드롭하여 씬에 배치할 수 있습니다.

씬에 배치하고 Position을 수정(0, 25, 0)하였습니다.
```
## 카메라의 이동
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/3e2bc9e9-989d-485e-b5f3-ade1e9b1c7b4)
```
FPS 게임에서는 플레이어 캐릭터에서 본 시야가 화면에 비춰집니다. 따라서 카메라의 위치를 변경해
플레이어가 가지고 있는 무기가 보이도록 설정합니다.

Main Camera의 위치를 수정(0, 1.6, 0)합니다.
```
## PlayerGun 오브젝트 배치
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/cfb1c68b-6a38-43cb-a866-e79262b3e20a)
```
PlayerGun asset을 Main Camera의 자식 요소로 추가합니다.
PlayerGun asset의 position이 부모(Main Camera)의 position(0, 1.6, 0)을 상속받습니다. 
```
## 오브젝트 비활성화
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9d1b48d5-7c2f-4d1d-bae7-b1c43e4006a5)
```
PlayerGun의 자식 요소인 Player를 선택하고 inspector 창에서 비활성화(오브젝트 명 옆 체크 해제)하면 총만 표시됩니다. 
```
