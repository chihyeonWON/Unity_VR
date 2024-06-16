# Unity_Project
Unity_Project on 2023 Summer Vacation.

## 구글 플레이스토어에서 Shooting Game을 다운로드하세요 !
[Zombie Shooting Game](https://play.google.com/console/u/0/developers/5278863456701079981/app/4973751470112176361/app-dashboard?timespan=thirtyDays)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9d474644-ed7e-4f20-a48a-404c013a0062)
```
개발자 : wonchihyeon
업데이트 : 1.0 버전 23.07.06
향후 업데이트 계획 : 화면 자동 회전으로 변경, Player RPC 3인칭 시점으로 변경, 조이스틱 레버로 Player의 이동 조작 기능 추가 예정
```

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
## [UI] 제한 시간 표시 Text
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/af47980f-1ab6-4c6e-9841-a60fb4f1f227)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/e62441fb-4cbc-4731-a010-d60268e5357c)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/f1666e49-1c1d-4d2a-8d36-ef3e75673b2a)

```
Canvas와 그 자식요소에 Text를 생성하고 Canvas 컴포넌트의 Render Mode를 World Space로 변경한 후
PosX = 0, PosY = 0, PosZ = 800, Width = 1920, Height = 1080 으로 설정합니다.

Text 오브젝트를 선택하고 Text 프로퍼티 창에 '남은 시간: 30초'를 입력하고
FontSize, Alignment, Horizontal Overflow, Vertical Overflow 프로퍼티를 수정합니다.

또 Color 프로퍼티에서 빨간색으로 설정한 후 Rect Transform 컴포넌트의 PosX, PosY 프로퍼티를 0, 360으로 설정한후
오브젝트 명을 Text에서 RemainTimer로 변경하였습니다.
```
## 남은 시간을 카운트하는 RemainTimer C# Script의 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/722ccd49-86f3-4a66-a0bf-55b1b184a5e6)
```
게임 제한 시간을 에디터에서 설정할 수 있도록 gameTime 프로퍼티를 작성하고
Update 함수에서 currentTime에는 게임의 제한 시간을 대입합니다.
타이머의 남은 시간을 갱신하고, 0초 이하가 되지 않게 합니다.
현재 남은 시간을 Text 컴포넌트의 텍스트로 변경함으로써 표시를 갱신합니다.

IsCountingDown 함수는 남은 시간의 카운트 여부를 판정합니다.

작성된 RemainTimer 컴포넌트를 하이어라키의 RemainTimer Text위로 드래그 앤 드롭한 후

실행하여 남은 시간이 카운트 되어 0초에 카운트가 정지되는 것을 확인합니다.
```
## [UI] 점수 표시 Text
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/73c47e68-b202-4812-8c02-3919b059b366)   
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/ff912666-cc04-40fb-8da9-fd8dc3ebbe5e)
```
게임 플레이를 잘하는 지 확인하기 위한 지표로 점수 시스템을 도입해보았습니다.

기존 Canvas - Text 오브젝트를 생성하고 '점수 : 000점'을 입력하고
Font Size, Alignment, Horizontal Overflow, Vertical Overflow, PosX, PosY 프로퍼티를
각각 적절하게 설정해줍니다.

또 오브젝트의 이름을 Text에서 Score로 수정한 후 글씨 색을 지정해줍니다.
```
## 점수 Score C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/8e327f57-e9b8-47ab-973f-7b7ffd8b5860)
```
현재 점수를 저장하기 위한 Points 프로퍼티를 설정하고 AddScore 함수가 호출되면 점수 텍스트가 갱신되도록
설계하였습니다. Score 스크립트를 Score Text의 컴포넌트로 추가합니다.
```
## Score Tag 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/32a60a1c-4c88-4f6f-865b-78c6666481da)
```
게임 오브젝트를 식별하기 위해 사용자가 자유롭게 붙일 수 있는 이름(Tag)를 Score Text에 추가하였습니다.

하이어라키 창의 Score 텍스트를 선택하고 인스펙터 창의 Tag - add Tag - Score 태그를 생성하고 설정합니다.
```
## Enemy 스크립트를 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/7f3a6b6d-da6d-4bed-ae97-9e614c69fe79)
```
적을 쓰러뜨렸을 때 더해지는 점수를 에디터에 설정할 수 있도록 point로 설정하고
Score를 참조하는 변수 score를 추가합니다.

또 Start함수에서 Score Text 게임 오브젝트를 FindWithTag 함수를 사용하여
Score 태그가 붙은 게임 오브젝트를 찾습니다.

그 게임 오브젝트에 해당하는 컴포넌트를 취득할 수 있게 되었고
GoDown 함수에서 에디터에 설정한 변수 point 값을 넘겨주면서 AddScore 함수를 호출해서

실행하여 총으로 적을 처치했을 때 점수가 +1 되는 것을 확인할 수 있습니다. 
```
## [UI] 게임 준비, 시작, 종료 표시 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/ae003413-6b2e-40ca-9539-a1ea55df5174)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/34a111ec-e8f4-4ced-9bab-dd7bc1f27e5d)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/13c4f24a-63f1-44ee-a3bf-4bba30b8731d)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/27e6e901-a2e0-49b1-be68-807808481a03)
```
준비, 시작, 종료 Text(GameReady, GameStart, GameOver)를 다음과 같이 설정합니다.

설정한 후 인스펙터 창에서 오브젝트 명의 체크표시를 해제하여 모두 숨겨놓습니다.
```
## [UI] 게임 결과 표시 작성

![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/5279fe4d-3a20-448c-bba3-8f5463a13a9d)
#### Retry Button
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/a75ac044-abff-48f3-a1d8-1f41329235a0)
```
Panel을 하나 생성하고 자식 요소로 두 개의 Text와 하나의 Button을 생성합니다.
그 후 Panel의 이름을 Result로 변경합니다.
그 후 Anchor Presets 을 Center/Middle 로 변경하고 Width :600, Height: 400으로 설정합니다.

Textures/UIPanel을 Source Image 파라미터로 드래그앤 드롭하여 설정하고 Color를 설정합니다.

첫 번째 Text는 Title로 변경하고 위치와 폰트사이즈, 색상을 설정하고
두 번째 Text는 Score로 변경하고 위치, 폰트사이즈, 색상을 설정한 후 Score 컴포넌트를 적용합니다.
버튼은 Retry로 변경하고 크기와 이미지를 설정합니다.

버튼의 자식요소의 Text의 텍스트/폰트/색상을 변경합니다.
```
## SceneChanger C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/588ee61b-f325-4c89-8b66-0f0a9e768da1)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/6b483064-a049-4880-9a23-9387fd56b806)
```
유니티에는 SceneManager 라는 씬을 관리하는 기능이 있으며, 여러 개의 씬을 바꾸거나 동시에 여러 개의 씬을
읽어 들일 수 있습니다. ReloadScene 함수를 이용하여 현재 사용 중인 씬을 다시 읽어들이는(초기 상태)로 되돌릴
수 있습니다.

Retry 버튼을 눌렀을 때 현재의 씬을 다시 로드하는 기능을 넣어주기 위해서 SceneChanger 스크립트를 작성하고 
SceneChanger 이름의 빈 오브젝트를 생성한 후 SceneChanger 컴포넌트를 적용합니다.

Retry Button 을 클릭한 후 onClick 이벤트에 SceneChanger 오브젝트를 넣고 SceneChanger -> ReloadScene()을 선택합니다.

그 후 SceneChanger를 프리팹화하여 공통으로 사용할 수 있도록 설정하고 씬을 실행하고 Retry 버튼을 눌러
제한 시간이 초기화되는 것을 확인합니다.
```
## ResultScore C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/ad18d49d-f4b2-427a-afa8-56eece165b2f)
```
획득한 점수를 결과 표시의 득점에 반영하는 ResultScore 스크립트를 작성합니다.

Score 컴포넌트를 태그 검색을 이용해서 구한 다음 Score의 컴포넌트에 저장되어 있는 Points 값을
Text 컴포넌트의 text 프로퍼티에 대입함으로써 점수 표시를 갱신합니다.
그 후 Result 패널의 Score Text에 ResultScore 컴포넌트를 적용합니다.

Result 패널은 체크 해제하여 숨김상태로 만듭니다.
```
## 게임의 진행을 관리하는 GameStateController C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/565d2af7-58b2-4dee-81f5-3539ad1165ed)
```
지금까지 작성한 오브젝트 참조를 에디터에서 설정할 수 있게 합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b4951e55-d81b-4b90-b695-2761f459a761)
```
게임 상태를 나타내기 위해 BaseState 추상 클래스를 정의합니다.
이 클래스는 부모 클래스인 GameStateController의 멤버 변수를 취급하기 위해 Controller 변수를 갖습니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/67ce7b34-afcf-46c6-b7da-1363e106c49b)
```
ReadyState 클래스는 Ready 오브젝트를 5초간만 표시하고 다음 상태로 전환합니다.
경과 시간을 유지하기 위해서 timer 변수를 갖고 OnUpdate 함수에서 시간을 더해 5초 이상이 되면
StateAction.STATE_ACTION_NEXT를 반환하고 다음 상태로 진행합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/c31c0f83-2b10-40fe-8dd8-e12bcb32c268)
```
게임시작 StartState 클래스는 Timer, GameStart, PlayerGun, Spawners 오브젝트를 표시하며
GameStart 오브젝트를 1초만 표시하고 다음의 상태로 전환합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/e0822a9f-9226-4ba1-a061-1c84f2998781)
```
PlayingState 클래스는 OnUpdate 함수에서 제한 시간이 끝나기를 기다리고
제한 시간이 종료되면 다음 상태로 전환합니다.

OnExit 함수에서 PlayerGun, Spawners 오브젝트를 비표시로해서 처리를 멈춥니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/4241eebb-3531-4ed7-a59b-29d92146a520)
```
게임오버 클래스는 GameOver 오브젝트를 2초간만 표시하고 다음 상태로 전환합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/8c35a215-1a6b-4811-96b6-d49b2f5d7c7a)
```
ResultState 클래스는 Result 오브젝트를 표시하고 이 이상 상태를 전환하지 않게 합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/24504fde-c065-4051-8c91-6f3c2883241a)
```
GameStateController 빈 오브젝트를 생성하고 GameStateController 컴포넌트를 적용하고
하이어라키 창에서 드래그 앤 드롭으로 각 프로퍼티를 설정합니다.

실행해서 게임 준비 -> 게임 시작 -> 게임 중 -> 게임 종료 -> 결과 표시 순서로 작동하는 것을 확인할 수 있습니다.
```    
## ZomBear 적에 애니메이션 추가
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/4e6fda9a-7892-4845-b4f4-f1896b89bf98)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/a0cdc713-12bb-4e9b-bafe-10494e6ef2f2)
```
ZomBear 프리팹에 EnemyAnimator Controller를 Animator 컴포넌트의 Controller 프로퍼티에 드래그 앤 드롭하여
설정합니다.

실행하여 ZomBear가 동작하는 것을 확인할 수 있습니다.

애니메이터 화면에서 애니메이션 스테이트 머신을 사용하여 복잡한 애니메이션을 제어할 수 있습니다.
외부 툴에서 작성한 애니메이션을 FBX 데이터로서 유니티로 임포트하여 애니메이션 클립으로
등록할 수 있습니다. 클립을 컨트롤러에 스테이트로 배치함으로써 애니메이션을 간단하게 재생할 수 있습니다.
```
## DOTween 플러그인 다운로드
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/aa4a93ff-d133-4e26-8a38-03e0a253fe1b)
```
에셋 스토어에서 애니메이션을 간단하게 할 수 있는 DOTween 이라는 플러그인을 임포트하여
UI에 애니메이션을 추가할 수 있습니다. 임포트하고 Setup DOTween 까지 하면 DOTween을 사용할 수
있게 됩니다.
```
## DOTween 을 사용하여 GameOver를 페이드로 표시
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/4987f19b-570a-4d81-a484-943f7628395f)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/37a2b747-aaff-44fa-a23a-52546b29fe66)
```
CanvasGroupFade 스크립트를 작성하고 하이어라키의 GameOver 게임 오브젝트에 추가한 후
CanvasGroup 컴포넌트의 alpha 프로퍼티 값을 0으로 설정합니다.

실행하여 GameOver 문자가 떠오르고 사라지는 것을 확인할 수 있습니다.
```
## DOTween을 사용하여 GameStart에 애니메이션 적용
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/2c0ed736-9473-47b5-a910-d49fbf8aed18)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/aff1d04d-331c-4e68-a805-27b4a68fed44)
```
화면 오른쪽에서 슬라이드인 하고 왼쪽으로 슬라이드아웃 하는 애니메이션을 주는
SlideInOut Script를 작성하고 GameStart Text Ui에 이 컴포넌트를 적용합니다.

Rect Transform 컴포넌트의 PosX 프로퍼티 값을 1400으로 설정합니다.

실행하여 GameStart TEXT UI가 오른쪽 끝에서 출현해 왼쪽 끝으로 사라지는 것을 확인할 수 있습니다.
```
## 타이틀 화면 생성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9da565aa-ad2b-4133-a815-e7fdc850a183)

#### Canvas의 컴포넌트 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/abc95065-7f06-4d06-a413-b27f400de509)

#### Text의 컴포넌트 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9ca49111-e45b-42e4-82e6-d2274c3b6143)

#### StartButton의 컴포넌트 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/a77cd2ec-ab38-4c29-ad4e-b814416bfdfa)

#### QuitButton의 컴포넌트 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/69328f83-3996-496d-8d6b-891e2c3ddb89)

```
File -> New Scene을 선택하고 새로운 씬으로 전환합니다.
씬의 이름은 Title로 하고 필요한 UI 들을 배치합니다.

Canvas의 자식 요소로 Text와 Button을 생성합니다
```

## 스테이지 선택 화면 생성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/59549eca-10b8-40b3-a572-2d7fcb33a6e2)
```
새로운 씬을 생성하고 Text와 버튼 UI를 배치합니다.

버튼 하나는 스테이지 선택 버튼, 나머지 하나는 Title 씬으로 돌아가는 기능을 합니다.
```

## 스테이지 종료 버튼 생성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/49731358-a4f3-4204-9d92-64ad5f86c782)
```
ShootingStage1 씬의 Result 결과 표시 화면의 Retry 버튼을 복제하여 End 버튼을 생성하고
버튼의 이벤트를 Reload에서 LoadScene으로 수정합니다.
```

## 씬을 등록
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/9ded06b1-e615-4030-b201-2ee1d3ebf9ba)
```
지금까지 생성한 Title, SelectStage, ShootingStage1 세 개의 씬을 Build Settings에 등록합니다.

씬의 등록 순서를 1: Title 2: SelectStage 3: ShootingStage1 으로 하고 실행하여 버튼을 눌러서

씬이 개발 의도한대로 전환되는 것을 확인할 수 있습니다.
```

## 적의 종류를 늘리기

#### Hellephant 프리팹의 Enemy 컴포넌트 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/37671f95-d21a-4e46-b976-cf511e6552df)
```
ZomBear 프리팹을 작성했던 것처럼 Hellephant 프리팹을 작성하여 적의 종류를 늘려보았습니다.

Hellephant의 Layer, SphereCollider, Rigidbody, Audio Source 컴포넌트를 적용하고 파라미터를 설정합니다.
Animator 컴포넌트의 Controller 프로퍼티에 HellephantAnimator OvrrideController 를 설정합니다.
Enemy 컴포넌트를 적용하고 설정합니다. 하이어라키 창의 Hellephant를 오브젝트 창의 Prefab에 드래그 앤 드롭하여
프리팹화합니다.
```

## 적의 체력을 설정할 수 있도록 Enemy C# Script 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/2cc6ebe3-701b-45de-9b91-6c403187d71b)
```
적의 체력을 에디터에서 설정할 수 있도록 hp 변수를 추가합니다.
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/e6aa8111-7b0d-48d4-bea5-e2b6247b2294)
```
OnHitBullet 함수에서는 총을 맞을 때마다 체력을 감산해서 체력이 0 이하가 되면 쓰러지는 처리가 이루어지도록
수정합니다. Hellephant 인스펙터 창의 Enemy 컴포넌트의 hp를 5로 설정하면 총을 맞아도 체력이 있는 한 쓰러지지 않게 됩니다.
```

## 랜덤으로 적이 출현되도록 Enemy Spawner C# Script 수정

#### 새로운 적 Hellephant 몹 추가
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/3cae413e-2f43-478d-9053-28ddf52f16f7)
```
hp : 5 , 처치 시 10만큼의 Point 획득 (ZomBear는 hp 1, Point 1)
```
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/66c2d791-c428-4415-8479-c5ebef444fa1)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b68207c6-e799-4c3f-a9eb-b826eca4b44f)
```
적의 프리팹을 배열로 변경해서 에디터에서 등록할 수 있게 하고 Spawn 메서드를 그 배열 중에서 하나를 랜덤으로
선택하도록 변경하여 EnemySpawner 컴포넌트에 등록된 적의 프리팹 안에서 적 하나가 랜덤으로 나오게 되며
출현하는 적을 설정할 수 있습니다.

실행하여 Zombear, Hellephant 두 개의 적이 랜덤하여 생성되는 것을 알 수 있습니다.

또 Hellephant의 hp를 5로 설정하였기에 총으로 Hellephant를 5번 맞춰야 Hellephant가 사라지는 것을 확인할 수 있습니다.
```
## 새로운 적 ZomBunny 몹 추가 

#### navigation 설정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/b544292d-56c9-4d90-ae99-f0a89fef7425)     
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/82387830-1ece-465a-9443-c98f7ad00b6a)     
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/6f92ff40-a6d0-4903-ade5-08f46f4daeba)      
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/87595a8c-a933-479a-85ef-7afd7bfcab64)     
```
hellephant와 같이 capsule collider, rigidbody, audio source, enemy 컴포넌트를 적용하고 프로퍼티를 설정합니다.

Zombunny에게는 내비게이션 기능을 이용하여 걸을 수 있도록 설정합니다.

window -> ai -> navigation을 선택하여 네비게이션 화면을 열고 Agents 탭을 설정합니다.
bake탭에서 bake를 실행하고 Scene Filter를 All을 선택하여 하이어라키 창을 되돌립니다.

nav mesh agent 컴포넌트 적용하고 speed의 프로퍼티의 값을 1로 설정합니다.
```

## ZomBunny의 이동 장소를 결정하는 MoveAgent C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/46341314-a33e-4fdf-a334-977c83613d93)
```
Start 함수에서 NavMeshAgent 컴포넌트를 취득해 agent 변수에 저장하고, GotoNextPoint 함수를 호출하여
최초의 목적지를 결정합니다.

Update 함수에서 NavMeshAgent를 갖고 있는 오브젝트가 목적지까지의 거리가 0.5m 이내가 되면 다음 이동 장소가 되는
새로운 목적지를 결정합니다.

GotoNextPoint 함수에서는 Planks 게임 오브젝트의 크기인 X좌표(-20.0, 20.0)와 Z좌표(-20.0, 20.0)의 범위에서
무작위로 목적지를 정하고 agent.SetDestination 함수에서 NavMeshAgent 컴포넌트의 새로운 목적지를 설정하여
이동 경로를 재계산합니다.

Zombunny 오브젝트에 작성한 MoveAgent 컴포넌트를 적용하고 실행하여 Zombunny가 맵에 돌아다니는 것을 확인할 수 있습니다.
```

## 스테이지를 늘리기

![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/cda6b4fa-97de-479b-8111-8f6bba2d344f)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/a0e1154b-e865-40b0-a2b7-ba84d2219c88)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/4c6c8ef6-1825-49e6-8f82-417210035244)
```
Stage 1 : 'ZomBear'를 출현시킨다.
Stage 2 : 'ZomBear', 'Hellephant'를 랜덤으로 출현시킨다.
Stage 3 : 'ZomBear', 'Hellephant', 'ZomBunny'를 랜덤으로 출현시킨다.

모든 스테이지에 공통적으로 사용되는 오브젝트인 Main Camera, Canvas, Floor 프리팹화합니다.

ShootingStage3 복사해서 ShootingStage2를 생성하고 EnemySpawner들의 Size프로퍼티를 2로 설정,
다시 ShootingStage2를 복사해서 ShootingStage1을 생성하고 EnemySpawner들의 Size 프로퍼티를 1로 설정합니다.

SelectStage scene에서 stage1 버튼을 복사하여 stage2, stage3 버튼을 생성하고 on Click 이벤트 프로퍼티의
Scene.load(string)의 프로퍼티 값 ShootingStage{1, 2, 3}으로 수정합니다.

Build Setting 설정 창에 ShootingStage2와 ShootingStage3을 추가하고 실행하여 스테이지가 추가된 것을 확인할 수 있습니다.
```

## 배경에 벽 추가

#### Floor의 Wall 추가
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/cf187f48-9403-4140-ac5b-315bbe24d408)

#### Floor의 Wall(1) 추가
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/cd1766a8-252a-4b81-8c0e-88752c78ed40)

```
ShootingStage1의 하이어라키 창의 Floor의 자식요소로 Models/Environment/Wall을 2회 드래그 앤 드롭하여 설정합니다.

Wall(1)의 PosX -: 48, PosY:0, PosZ: -48, RotationX : 0 RotationY : 180 RotationZ : 0 으로 설정합니다.

그 후 Floor의 Overrides 창에서 Apply all을 눌러서 ShootingStage2와 ShootingStage3 Scene의 Floor Wall을 추가합니다.
```

## Player의 움직임을 제어하는 조이스틱 구현
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/a817e34b-c526-4fea-ad51-6ea7e44ab5c7)
```
Joystick 이미지를 추가하고 그 아래에 Lever 이미지를 적절한 위치에 추가합니다.
```

## 조이스틱 기능을 하는 VirtualJoystick C# Script 작성
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/5485d8f0-905b-4cfb-bf5b-5598298b4ea1)
```
터치한 위치를 따라서 레버 이미지가 따라 움직이도록 만듭니다.

우선 빨간 레버 이미지의 Rect Transform 컴포넌트를 가질 lever 변수와 Joystick의 Rect Transform을 가지고 있을 rectTransform 변수를 선언합니다.
그리고 lever 렉트 트랜스폼은 에디터의 인스펙터 뷰에서 넣어주기 위해서 SerializeField 어트리뷰트를 걸어주고
본체의 rectTransform은 Awake 함수에서 GetComponent로 가지고 와서 저장해둡니다.

그 다음은 터치한 위치를 찾아내서 lever 이미지가 그 위치로 이동하게 만들어 줘야합니다.

터치한 위치는 이벤트 함수의 매개변수로 받는 eventData.position을 통해서 가져올 수 있습니다.
이렇게 가져온 eventData.position에서 가상 조이스틱 게임 오브젝트의 위치인 rectTransform.anchoredPosition을 빼주면 lever가 있어야할 위치를 구할 수 있게 됩니다.
구한 inputDir를 lever.anchoredPosition에 넣어줍니다. 이 과정은 OnBeginDrag와 OnDrag, 두 이벤트에서 동일하게 처리해줍니다.

그리고 마지막으로 가상 조이스틱에서 손을 뗐을 때의 이벤트인 OnEndDrag에서는 lever.anchoredPosition을 Vector2.zero로 만들어서 조이스틱의 중심으로 다시 돌아가게 만들어준다.

이 컴포넌트를 Joystick 오브젝트에 적용하고 lever 프로퍼티에 Joystick Lever를 넣어줍니다.

실행하면 조이스틱 영역 밖으로 움직이면 빨간 레버 역시 조이스틱 위치를 벗어나 버립니다.
레버가 조이스틱 영역을 벗어나지 않도록 수정할 필요가 있어보입니다.
```

## 조이스틱 레버가 조이스틱 영역을 벗어나지 않도록 VirtualJoystick C# Script 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/faa35600-c709-4be9-ad3c-a1c3560dc2f3)
```
조이스틱 레버가 조이스틱 영역을 벗어나지 않도록 VirtualJoystick C# Script 수정합니다.

먼저 레버가 움직일 수 있는 거리를 조이스틱의 중심부로부터 일정 거리로 제한시키기 위해서 float 타입으로 leverRange라는 변수를 추가합니다.
private으로 두되 에디터에서 수정할 수 있도록 SerializeField 어트리뷰트와 특정 범위 내에서만 값을 조절할 수 있도록 Range 어트리뷰트를 추가해줍니다.
Range의 범위는 10에서 150 사이로 합니다.

leverRange 변수를 만들고 나면 이벤트 함수에서 inputPos를 lever의 anchoredPosition에 바로 넣지 말고 inputPos의 길이와 leverRange를 비교한 뒤,
leverRange보다 짧으면 inputPos를 바로 주고, 길면 inputPos를 정규화한 다음 leverRange를 곱하는 방식으로 inputPos의 거리를 제한하여 lever의 anchoredPosition에 넣어줍니다.
이 과정도 OnDrag에서 똑같이 처리해줍니다.

레버 이미지가 조이스틱 영역을 크게 벗어나지 않는 적절한 영역을 확인합니다. 지금은 100 정도가 적당해 보입니다.
VirtualJoystick 컴포넌트가 부착되어 있는 Joystick 게임 오브젝트를 선택하고 인스펙터 뷰에서 Lever Range 프로퍼티를 34정로 설정합니다.

게임을 플레이시키고 가상 조이스틱을 움직여보면 드래그를 조이스틱 밖으로 끌어도 조이스틱의 레버가 조이스틱 영역을 벗어나지 않는 것을 볼 수 있습니다.
```
## 조작 기능을 추가하도록 VitualJoystick C# Script 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/3712f919-34a5-4b7b-b6c9-625f540adc8b)     
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/76092965-7941-4108-950b-df3385dfb759)   
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/1dbedc2b-ca35-4dce-892c-c1aea69a3f93)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/ee24571b-559c-4e44-ac79-aa0c847bb3a1)
```
조작 기능을 추가할 차례입니다.
이번에는 Vector2로 inputVector 변수와 bool 타입으로 isInput 변수를 추가합니다.
그리고 OnBeginDrag와 OnDrag 이벤트 함수에서 inputVector 값을 넣어줄 차례인데,
두 이벤트 모두 동작하고 있는 함수의 내용이 완전히 동일하다는 것을 알 수 있습니다.
그렇기 때문에 ControlJoystickLever라는 함수를 새로 만들고 두 함수의 내용을 복사해서 붙여넣어 줍니다.

그 다음에는 ControlJoystickLever 함수에서 clampedDir를 leverRange로 나누어서 inputVector에 넣어줍니다.
clampedDir를 바로 써도 될 것 같은데 굳이 leverRange로 나누어서 사용하는 이유는
 이 clampedDir는 해상도를 기반으로 만들어진 값이라 캐릭터의 이동속도로 쓰기에는 너무 큰 값을 가지고 있기 때문입니다.
이런 값으로 캐릭터를 움직이면 너무 빠른 속도로 캐릭터가 움직일게 분명하기 때문에
입력 방향의 값을 0-1 사이 값으로 만들어서 정규화된 값으로 캐릭터에 전달하기 위한 것입니다.

그리고 화면 해상도를 기준으로 값이 정해지기 때문에 해상도가 바뀌면 입력 방향 값의 크기가 바뀌어서
캐릭터의 이동 속도가 바뀌는 문제도 있어서 0-1사이로 정규화된 값을 사용해야 합니다.
캐릭터는 이렇게 전달받은 정규화된 이동 벡터에 이동속도를 곱해서 일정한 속도로 이동하게 됩니다.

그 다음엔 OnBeginDrag에서 isInput을 true로 바꿔주고 OnEndDrag에서는 false로 바꿔줍니다.

isInput이 활성화된 상태일 때 Update 함수에서 InputControlVector 함수를 지속적으로 호출하도록 하기 위해서 Update 함수 안에서 처리합니다.
즉, 드래그 함수에 넣을 경우 조이스틱 드래그를 멈춘 상태일 때 이벤트가 들어오지 않기 때문에 Drag 함수에 넣지 않고 Update 함수 안에서 처리합니다.
```
## VirtualJoyStick C# Script 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/72467b2c-9748-4b67-bad1-3c4c6c406b4c)     
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/29684f88-c232-44ee-801b-1ff043b6f2de)
```
3인칭 시점의 TPS 패키지를 import하고 character를 가져온다음 VirtualJoyStick 스크립트에
TPS 컨트롤러를 설정할 수 있도록 controller 변수를 선언한 다음 onEndDrag 함수와 InputControlVector 함수에
controller.Move(Vector2.zero), controller.Move(inputVector)를 각각 넣어줍니다.

그 후 Joystick 프리팹에 적용된 Controller 프로퍼티에 TPS Character Controller 컴포넌트가 적용되어 있는 Character를
넣어줍니다. 그 후 실행하면 Joystick에 따라서 캐릭터가 움직이는 것을 확인할 수 있습니다.
```
## TPS Character Controller C# Script Move 메서드 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/70b99ace-1077-40c3-a187-4e5cbf6006b2)
```
TPS Character Controller 스크립트의 Move 함수에서 캐릭터 이동의 입력을 키보드의 입력에서 받아오는 것이 아닌
VirtualJoyStick의 InputControlVector에서 주어지는 InputVector의 x, y 값을 받아와서 움직이도록 수정합니다.
```

## TPS Character Controller C# Script LookAround 메서드 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/655400e3-af0c-409c-b060-1f972b91c4db)
```
TPS Character Controller 스크립트의 LookAround 함수가 inputVector를 받아오도록 수정합니다.
```

## VirtualJoystick C# Script의 수정 (조이스틱 타입에 따라 다른 함수가 호출되도록)
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/8055524e-4e76-4b5f-80a6-61a621790086)    
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/e9885c34-f4fd-4285-b132-8a670d5afc2d)
```
열거형 타입 JoyStickType { Move, Rotate } 을 생성하고 JoyStickType 변수 joystickType을 생성합니다.

그리고 onEndDrag 함수와 InputControlVector 함수의 controller.move 함수를 호출하는 부분을 switch 문으로 바꾸어서
JoystickType의 값(move or rotate)에 따라서 Move or Rotate 함수가 호출되도록 변경합니다.
```

## 3인칭 RPC 시점으로 수정
![image](https://github.com/chihyeonWON/Unity_VR/assets/58906858/421a03c9-f5bf-4f10-921a-77408e07a381)
