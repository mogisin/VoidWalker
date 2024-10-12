## 🎮Void Walker programming guidence

- Merge Conflict 발생시 빠른 연락을 취하도록 합시다.
- Blueprint를 건드리게 될 경우 디스코드/카카오톡에 공지합시다.
- Pull Request 발생시 디스코드/카카오톡에 공지합시다.

## Ref : Unreal Coding Standard
- 클래스 체계는 public -> private 순으로 작성합시다.
- 명명 규칙은 pascal casing을 사용합니다. (다만 Snake/Camel 혼용에 대해서는 논의 바랍니다)
- 접두사 규칙은 아래를 사용합니다.

| Template | Uobject | AActor | Swidget | Abstract Interface | Enum | Bool | Etc
| --- | --- | --- | --- | --- | --- | --- | --- |
| T | U | A | S | I | E | b | F |

- bool을 반환하는 모든 함수는 질의형으로 작성하도록 합시다.
- Parameter에 대해서는 In/Out을 통해 명시하도록 합시다.
- **STL을 사용하지 맙시다.** (사용 가능하나 Source Code가 Heavy해짐 -> 언리얼 자체 기능 사용)
- const는 가능하면 최대한 사용합시다.
- **NULL 사용 금지 (컴파일러에서 0으로 처리됨 -> nullptr 사용)**
- auto 지양, 범위 기반 for문 사용 권장
- 타입을 쓰고 바로 오른쪽에 포인터나 레퍼런스를 쓰고 난 뒤 한칸의 공백을 두도록 합시다.
- **주석을 성실하게 작성하도록 합니다. (다만 알아 볼 수 있게)**
- **행복하고 즐거운 코딩이 되도록 합니다.**
