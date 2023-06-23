![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/0f295697-a20d-460b-be82-3cc9b64dea5d)# Unity_Project
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
## PlayGun의 이동
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/1c07e98d-5c6d-4118-8202-c40c05179694)
```
Game 뷰에서 총의 끝이 조금 보이는 듯한 시야로 설정하기 위해 PlayGun 오브젝트의 위치를 수정(-0.25, -0.7, 0.6)합니다.

게임 뷰에서 오브젝트의 위치를 봐가면서 수정함 
```
## 카메라를 회전시키는 C# 스크립트(CameraRotator.cs)의 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/2c6f268f-344d-473e-a847-82608beeb887)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/846af699-1537-4a0b-8ce7-6201096b201b)
```
오브젝트의 동작은 오브젝트에 적용된 컴포넌트에 의해 제어됩니다.
유니티는 다양한 컴포넌트를 제공하지만 이것만으로는 오브젝트를 생각한대로 제어할 수 없습니다.

따라서 유니티에서는 C# 스크립트를 기술하여 자체 기능을 가진 컴포넌트를 작성할 수 있습니다.
작성한 컴포넌트를 오브젝트에 추가하기만 하면 C# 스크립트에 기술된 대로 오브젝트가 동작되게 할 수 있습니다.

여기서는 Main Camera를 회전하는 C# 스크립트를 작성한 후 생성된 컴포넌트(CameraRotator.cs)를 Main Camera에 추가하였습니다.
```
## [C#] CameraRotator 스크립트 분석
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/482b3bbf-b35d-4d11-a517-2458f99867f8)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/dc14059c-55bd-42dd-8df8-53cbf0e25cd4)
```
CameraRotator 클래스는 유니티가 제공하는 클래스인 MonoBehaviour 클래스를 상속받고 있으며 
MonoBehaviour 클래스의 멤버 변수인 이벤트 함수들을 구현하여 컴포넌트의 기능을 구현할 수 있게 되었습니다.

public 또는 [SerializeField] 속성이 붙은 멤버 변수(angularVelocity)는 유니티의 인스펙터 창에서 설정을 변경할 수 있습니다.
여기에서 정의한 angularVelocity가 인스펙터 창에서 [Angular Velocity]라는 이름의 프로퍼티로 표시되고 그 초깃값은 30f라는 
것을 알 수 있습니다. horizontalAngle과 verticalAngle은 회전량을 저장하기 위한 변수로 사용합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/8fb9b7d2-13f3-4e7e-8d24-6301c1618fff)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/1a14da0b-e07d-436f-9fe1-7b285fceea23)
```
# if UNITY_EDITOR #endif 블록은 C#의 프리프로세스라는 것을 이용한 기술로, 이렇게 적어두면 둘러싸인 범위가 유니티 에디터에서만 유효
즉 휴대 단말에서 확인 시에는 무효되게 됩니다. 이는 휴대 단말에서 확인할 때 카메라의 제어를 VR 기능이 맡게 되기 때문에 
처리가 충돌되지 않게 한다는 의미가 있습니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9f311228-a92d-4ac3-9cbd-b3be55e05371)
```
Update 함수의 내부 로직의 첫 부분에서 키보드 입력을 통해 회전 속도와 프레임의 시간으로부터 회전량을 계산합니다.

horizontal (수평), vertical (수직) 두 축이 있으며 Input.GetAxis("horizontal or vertical")을 사용하여
화살표의 키 입력에 응해 -1부터 1의 값을 얻을 수 있습니다.

수평 : 왼쪽이 -1 오른쪽이 1 , 수직 : 아래쪽이 -1 위쪽이 1

Time.deltaTime은 앞 프레임으로부터의 경과 시간을 반환합니다. 이것을 회전 속도와 곱해서 회전량을 얻을 수 있습니다.

수직방향의 회전값 veritcal을 마이너스로 하는 것은 입력과 회전 방향을 맞추기 위함입니다.
(x축으로의 회전은 아래로 향하는 것이 정방향이기 때문에 입력을 반전시키기 위해 마이너스 값으로 변환)
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/c55c88fa-83e3-434c-a4cf-7e157c82438f)
```
입력에 따른 각 방향의 회전량을 얻은 다음 지금까지의 회전값에 그 값을 더합니다.

수직 방향으로 90도를 넘으면 좋지 않기 때문에 80도 이상이 되지 않도록 처리합니다.
Matf.Clamp는 값을 범위 내로 넣는 처리입니다.

마지막으로 회전량을 게임 오브젝트에 반영하고 있습니다.

MonoBehaviour의 transform 프로퍼티에서 'Transform' 컴포넌트를 취득하고 rotation에 회전 각도에 해당하는 쿼터니언을 설정합니다.
여기서는 Quaternion.Euler에 의한 오일러 각을 사용합니다. 
Transform 컴포넌트를 이용하여 스크립트로부터 게임 오브젝트의 위치나 회전을 갱신해서 움직일 수 있습니다.
```
## 총알 생성하기
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/bbc1b682-a5fa-479a-9c9d-825720e05c02)
```
3d object의 Sphere로 구를 생성한 후 이름을 Bullet으로 변경합니다.

오브젝트의 크기(scale)을 0.05, 0.05, 0.05로 수정합니다.
```
## 총알 Object를 프리팹화하기 (Prefab)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9c471bac-4eaa-4e29-a249-2b824b61ae1d)
```
프리팹은 게임 오프젝트의 템플릿에 해당하는 에셋입니다. 게임 중에 몇 번 나올 것 같은 게임 오브젝트를 
프리팹화해 두면 프리팹을 바탕으로 간단하게 게임 오브젝트를 씬상에 여러 개 계속 생성할 수 있습니다.

하이어라키 창의 Bullet을 프로젝트 창의 'Assets/VRShooting/Prefabs' 경로에 드래그 앤 드롭하여 
프리팹화 합니다.
```
## 총알을 발사하는 Shooter C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/63926e6a-8864-4801-aead-93ac954f1f36)
```
총알의 프리팹(GameObject형)와 총구의 Transform을 변수로 정의합니다.
게임 오브젝트와 컴포넌트의 형도 [SerializeField]로 지정하여 인스펙터 창에서 설정하게 할 수 있습니다.

Update 함수에서는 입력에 따라 Shoot 함수를 호출합니다. Input.GetButtonDown은 지정된 버튼이
눌린 순간에 true를 돌려주는 함수입니다. 또한 "Fire1"이라는 버튼명은 기본값으로 정의된 것으로,
마우스 왼쪽 버튼이나 왼쪽 I키의 입력을 받을 수 있습니다.

총알을 발사하는 Shoot함수안의 Instantiate 함수는 게임 오브젝트를 복사하는 함수로 첫 번째 인자로는 
복제할 프리팹을 두 번째 인자로는 총구의 위치(gunBarrelEnd.position)와 총구의 방향(gunBarrelEnd.rotation)을 지정해
총알을 생성하게끔 지정하였습니다.
```
## Shooter 컴포넌트 적용
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/794ece71-020f-42e1-ae07-8ec5c4706506)
```
PlayerGun 오브젝트에 작성한 Shooter 컴포넌트를 추가하고 Bullet Prefab 프로퍼티에 Bullet asset을 넣고
Gun Barrel End 프로퍼티에 PlayerGun의 자식 요소인 GunBarrelEnd(총구) 오브젝트를 추가합니다.
```
## Shooter 스크립트의 동작 확인
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/37ef319b-e091-4b98-ab4a-e6e699152010)
```
씬을 실행 시키고 마우스 클릭을 하면 총알이 생성되는 것을 확인할 수 있습니다.
하이어라키 창에는 클릭할 때마다 Bullet(Clone)의 이름의 게임 오브젝트가 증가합니다.

하지만 총알은 멈춰 있기만 할 뿐 날아가지 않습니다.
```
## 총알에 물리 엔진 적용하기
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/13a69880-2825-4293-adb6-9157a9a4297f)
```
프로젝트 창의 Bullet asset에 Rigidbody 컴포넌트를 추가하였습니다.

또 Rigidbody 컴포넌트의 Use Gravity 프로퍼티의 체크를 해제하여 
총알이 중력의 영향을 받지 않게 설정하였습니다.
```
## 총알의 동작을 담당할 Bullet C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/0d734caa-2abf-4c97-8899-79a04032c914)
```
RequireComponent(typeof(Rigidbody))] 설정으로 Rigidbody 컴포넌트가 필요하게 되고

Start함수 안에서 먼저 총알에 주는 속도를 계산합니다.
transform.forward는 총알의 앞쪽 방향(z방향)을 나타내는 단위 벡터로 
speed * transform.forward에 의해 앞쪽 방향으로 지정한 속도의 크기와 방향을 가진 벡터를 얻습니다.

또한 Rigidbody 컴포넌트의 AddForce 함수에 의해 계산한 속도에 상당하는 힘을 줍니다.
AddForce 함수의 두 번째 인수로 힘을 주는 방법을 지정하는 데 이때 ForceMode.VelocityChange를 
지정하여 지정한 속도 변화에 상당하는 힘을 가할 수 있습니다.
```
## 불필요한 게임 오브젝트를 제거하는 AutoDestroy 컴포넌트 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/327151a8-40f3-4399-8527-bd2b866ed059)
```
총에서 마우스 입력에 따라 총알을 발사하는 시스템까지는 생겼지만 이대로는 계속해서
Bullet(Clone) 게임 오브젝트가 발사할 때마다 계속 늘어납니다.
이렇게 되면 그만큼 처리의 부하가 늘어나기 때문에 불필요한 게임 오브젝트는 제거해야 합니다.

게임 오브젝트의 수명 lifetime 변수를 5f로 설정하고
Destroy 함수를 사용하여 gameObject를 lifetime = 5f 가 경과한 이후에 제거하도록 하였습니다.

그 후 이 AutoDestroy 컴포넌트를 Bullet prefabs에 추가합니다.

발사한 총알이 하이어라키 창에서 일정 시간이 지나면 사라지는 것을 확인할 수 있습니다.
```
## 씬에 적을 배치
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/7b3ae0a5-b699-40e5-b3a7-9bd75deec911)`
```
ZomBear 게임 오브젝트를 하이어라키에 추가한 후 다시 Prefabs에 드래그 앤 드롭해서 프리팹화 합니다.
이렇게 생성한 프리팹을 드래그 앤 드롭으로 씬 상에 2개를 추가하여 3개를 생성합니다.
```
## ZomBear Prefab에 Rigidbody, Capsule Collider 컴포넌트 적용
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/6f0a98dd-1e70-4cc3-be14-43ca4655a568)
```
ZomBear prefab 하나에 rigidbody, capsule collider 컴포넌트를 적용합니다.
각각 is kinematic , is Trigger 프로퍼티에 체크합니다.

capsule collider의 edit collider 버튼을 클릭하여 콜라이더를 편집 상태로 만든 후
콜라이더를 ZomBear와 비슷한 위치와 크기로 변경합니다.

그 후 인스펙터 창 윗부분의 Overrides 버튼을 클릭한 후 Apply All을 클릭합니다.

한 오브젝트에 적용한 컴포넌트들의 설정이 다른 프리팹에도 똑같이 적용됩니다.
```
## Bullet, Enemy Layer 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/1e7afab1-369b-4044-9ad8-daba1f379eea)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/5895ca6e-91f4-4f72-a497-a267200befe4)
```
총알(Bullet)과 적(ZomBear)이 충돌하는 듯한 레이어 설정을 합니다.
레이어를 제대로 설정해 둠으로써 의도하지 않은 오브젝트 간의 충돌을 방지할 수 있습니다.

8번 레이어 Bullet 과 9번 레이어 Enemy 를 Edit Layer 창에서 추가한 뒤

Bullet 프리팹에서 8번 레이어(Bullet)를 적용합니다.
ZomBear 프리팹에서 9번 레이어(Enemy)를 적용합니다.(자식 요소 모두의 레이어를 변경합니다)

또한 Edit - ProjectSettings의 Physics 창에서 Bullet 과 Enemy의 Layer Collision Matrix를 설정합니다.
```
## Bullet C# Script에 충돌 시의 이벤트 구현
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/acd4635a-7153-4653-95fa-b5796fb95062)
```
Bullect C# Script 파일에 충돌 시의 이벤트를 구현하였습니다.

onTriggerEnter 함수에서는 충돌한 상대의 Collider가 인수로서 전달되고 충돌 상대방에게 
OnHitBullet이라는 메시지를 보내고 자신의 게임 오브젝트를 제거(Destroy)합니다.

SendMessage 함수에 의해 OnHitBullet 메시지를 받은 게임 오브젝트는 적용된 컴포넌트 전체에 대해서
OnHitBullet 이라는 이름의 함수가 있으면 그 함수를 실행합니다.
```
## ZomBear 프리팹에 적용할 Enemy C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/5cfea17e-c4e9-4c5f-8428-84928172dd5c)
```
총알과 충돌 시 적의 처리를 구현할 Enemy C# Script를 작성하였습니다.

총알과 적이 충돌하면 Bullet 클래스의 OnTriggerEnter가 호출되며 그 중에 충돌 상대방 즉 적의 게임 오브젝트에
OnHitMessage를 보내게 됩니다.

적에게 적용된 'Enemy' 컴포넌트는 OnHitMessage 함수를 갖고 있기 때문에 이것이 호출되고
그 결과로 적이 소멸(Destroy(gameObject))하게 됩니다.

작성한 컴포넌트(Enemy)를 ZomBear 프리팹에 적용하고 실행하여 ZomBear를 총알로 맞췄을 때 총알과 적이 사라지게 됩니다.
```
## 적의 출현 지점을 나타내는 EnemySpawner C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/0a57265b-0cda-4df8-86a0-78d954346edf)
```
적의 프리팹을 에디터에서 설정할 수 있도록 enemyPrefab 프로퍼티를 정의합니다.
enemy 라는 변수는 spawner 에서 출현한 적을 보유해 두기 위한 것입니다.
Spawn 함수는 다른 클래스로부터 호출하는 것을 가정한 함수로, Spawner에 적이 출현 중이 아니면 그 위치에 적을 생성합니다.
```
## EnemySpawner 프리팹의 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/4ce6f25c-472a-41e5-aa7a-5e7553029397)
```
씬에 위치한 ZomBear 3개를 모두 삭제하고 Create Empty로 빈 오브젝트를 생성하고
이름을 EnemySpawner로 변경한 후 EnemySpawner 컴포넌트를 적용합니다.

그 후 Enemy Prefab 프로퍼티에 ZomBear 프리팹을 드래그 앤 드롭으로 설정합니다.

EnemySpawner 오브젝트를 Prefabs로 드래그 앤 드롭해서 프리팹화하고 하이어라키 창의 EnemySpawner는 삭제합니다.
```
## 적의 출현을 제어하는 SpawnController C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/84457911-f8e3-4597-a62a-a69b3bccf832)
```
EnemySpawner 프리팹을 일정 간격으로 여러 개 배치하여
그 중 어느 하나에서 적을 출현시키는 시스템인 SpawnController 컴포넌트를 작성합니다.

spawnInterval을 정의해 적 출현 시간을 설정할 수 있게 합니다.

start함수에서 GetComponentsInChildren이라는 함수로 Spawner의 리스트를 구현합니다.
update함수에서 타이머의 경과 시간을 갱신하고, 출현 시간 이상 경과하는 경우에는 랜덤으로 선택한 Spawner로부터
적을 출현시킨 다음 타이머를 리셋합니다.
```

## Spawner의 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b91d7072-a51d-4ec1-be7c-bf0c138f0288)
```
Create Empty로 빈 오브젝트를 작성하고 Spawners라는 이름을 붙인 뒤 SpawnController 컴포넌트를 적용합니다.
```

## EnemySpawner의 배치
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/52240a5b-3e98-4dfa-ac5a-271977754368)
```
Spawners 오브젝트의 자식 요소로 EnemySpawner 프리팹을 5개를 배치합니다.

프리팹 5개 각각의 위치를 수정한 후 실행합니다.
적을 아무리 잡고 잡아도 5개의 Spawner에서 무한으로 계속해서 적이 출현하는 걸 알 수 있습니다.
```
## Shooter 스크립트로 연출 재생
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b0d410d1-e90e-44de-a69d-9936bba3dbd2)
```
총알을 발사할 때 파티클 연출을 재생하도록 Shooter 스크립트를 수정하였습니다.

gunParticle 프로퍼티를 추가하고 재생하는 파티클 연출을 설정할 수 있게 했으며 Shoot 함수에서 이 연출을 재생합니다.

프리팹의 GunParticles를 GunBarrelEnd의 자식 요소로 합니다.

그 후 PlayerGun의 GunParticle 프로퍼티에 GunParticles를 드래그 앤 드롭으로 설정한 후

실행하여 총알이 발사될 때 파티클 연출이 재생되는 것을 확인할 수 있습니다.
```

## Bullet 스크립트로 연출 재생 
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/bcddf0ae-4a58-49f1-8d36-f74b1c3c0dab)   
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/2331f229-a0c7-46ad-b299-58287a70eada)
```
발사한 총알이 적에게 적중했을 때 연출을 재생하도록 Bullet 스크립트를 수정하였습니다.

hitParticlePrefab으로서 연출이 자동 재생되는 프리팹을 프로퍼티로 설정합니다.
총알의 발사 적중 시점에 프리팹으로부터 게임 오브젝트를 생성함으로써 연출이 재생됩니다.

HitParticles Prefab의 Particle System 컴포넌트의 Play On Awake에 체크하여 자동 재생되도록 하고
생성한 게임 오브젝트가 자동으로 제거되도록 AutoDestroy 컴포넌트를 적용하고 Lifetime 프로퍼티를 0.4로 설정합니다.

그 후 Bullet 프리팹에서 Bullet 컴포넌트의 Hit Particle Prefab의 프로퍼티로 HitParticles 프리팹을 드래그 앤 드롭합니다.

실행해서 총알 발사가 적에게 적중했을 때 연출이 재생되는 것을 확인할 수 있습니다.
```
## 사격 시의 효과음 추가
[오디오 소스 유니티 매뉴얼](https://docs.unity3d.com/kr/560/Manual/class-AudioSource.html)   
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/bc66de31-aa60-4cbc-8126-7f5be402352b)
```
먼저 하이어라키 창의 GunBarrelEnd(총구)에 Audio Source 컴포넌트를 적용합니다.

그 후 Audio Source 컴포넌트의 AudioClip 프로퍼티에 프로젝트 창의 Audio/Effects/Player GunShot을 설정합니다.
Play on Awake에 체크를 해제(자동으로 재생되는 것을 방지, 스크립트의 Play()함수로 소리 재생) 
Spatial Blend를 0.8로 설정합니다.(3D 엔진이 오디오 소스에 영향을 미치는 정도를 뜻함, 즉 음원과의 위치 관계를 어느 정도 반영할지 결정)
0이면 위치 관계에 관계없이 같은 소리를 득고 1에 가까울수록 위치 관계를 반영한 소리르 듣는 것
```
## 사격 시 효과음이 나도록 Shooter C# Script 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/562e5393-d6df-4385-bb41-b143203417db)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/6bb59730-273c-42a5-a940-d4bfef1415a5)
```
Shooter 스크립트 내부에 gunAudioSource 멤버 변수를 선언, 발사 시 AudioSource를
프로퍼티에서 지정해서 지정한 음원을 사격 시 gunAudioSource.Play()로 재생하는 처리를 스크립트에 추가하였습니다.

또 PlayerGun 게임 오브젝트에 적용된 Shooter 컴포넌트의 Gun Audio Soure 프로퍼티에 하이어라키 창으로부터
GunBarrelEnd를 드래그 앤 드롭하여 설정합니다.

실행해서 사격했을 때 소리가 재생되는 것을 확인할 수 있습니다.
```
## 적의 위치에서 나타났을 때 효과음 추가 

```
현재 만들고 있느 프로젝트에서 적이 출현했을 때 소리가 나는 것 즉 이것은 적의 방향을 나타내는
게임의 힌트 요소로 생각할 수 있습니다.

따라서 출현시의 소리를 ZomBear Death 오디오 소스로 대용합니다.

ZomBear 프리팹에 Audio Source 컴포넌트를 적용하고 Play on Awake 해제, Spatial Blend를 0.8로 설정합니다.
```
## 적의 위치가 나타났을 때, 적이 총알에 맞았을 때의 효과음 추가 (Enemy C# Script 수정)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/260c673f-d286-4cb5-b467-2a62643323a7)
```
적의 출현 시와 총알의 명중 시에 해당하는 AudioClip을 프로퍼티로서 정의하고
콜라이더와 렌더러의 프로퍼티는 ZomBear 자신의 콜라이더와 렌더러를 지정하도록 하여 총알을 맞았을 때의 처리에
필요하기에 보유합니다

출현 시의 소리를 Start함수에서 AudioSource 컴포넌트를 취득해서 재생합니다.

명중 시의 소리를 재생한 후에 총알을 맞았을 때 GoDown 함수를 호출합니다.
소리의 재생은 게임 오브젝트를 제거하기 전에 재생되어야 하므로 1초 후에 삭제하도록 설정합니다.
(Destroy(gameObject, 1f))
goDown 함수에서는 콜라이더와 렌더러를 무효화함으로써 충돌 판정과 표시를 지우고, 적이 없어진 것처럼 보이게 합니다.

ZomBear 프리팹의 Spawn Clip 프로퍼티에 ZomBear Death를 설정합니다.
Hit Clip 프로퍼티에는 ZomBear Hurt를 설정합니다.
Enemy Collider 프로퍼티에는 ZomBear 프리팹 자신을 드래그 앤드롭으로 설정합니다.
Enemy Renderer 프로퍼티에는 ZomBea 프리팹의 자식 요소를 드래그 앤 드롭으로 설정합니다.

설정하고 실행하면 적이 출현할 때와 적에게 총알이 명중했을 때 소리가 재생됩니다.
```
## BGM(Background Music) 게임 브금 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/7f34f0e2-b652-489a-9ba2-8c76036673b8)
```
BGM 흔히 말해 브금이라고 하는 것을 설정해 보았습니다.
씬에 들어간 후 루프 반복 재생 로직을 돌려서 중단되지 않도록 합니다.

BGM을 재생하기 위한 bgm 게임 오브젝트를 생성하고 Audio Source 컴포넌트를 적용,
AudioClip 프로퍼티에 Background Music 소스를 설정하고
Loop 프로퍼티에 체크를 합니다.
볼륨이 너무 크기에 Volume 프로퍼티를 0.2로 설정하였습니다.

실행하면 BGM이 재생됩니다.
```
