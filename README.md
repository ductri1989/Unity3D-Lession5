# Bài 5 : Bài tập giữa kỳ
Chủ đề : cả lớp cùng làm 1 game nhập vai. Điều khiển 1 nhân vật đánh quái, mở rương và nhặt item. Giết quái và đánh nhiều boss ở các map, nhân vật sẽ thu thập được Gold và vật phẩm. Sử dụng vật phẩm để tăng HP,Attack và Gold

### Phạm vi bài giảng
- Tạo project 3D
- Trang trí map
- Setup nhân vật ErikaArcher
  1. Tạo 1 `GameoOject` mới
  2. Thêm component `Mesh Filter` → gắn Mesh của mũi tên
  3. Thêm component `Mesh Renderer` → gắn Materials của mũi tên
  4. Tạo Prefab : Arrow
- Setup camera
- Setup quái
  - Quái di chuyển theo 1 quỹ đạo
  - Quái chuyển sang trạng thái tấn công khi nhân vật nằm trong `Attack Zone` hoặc bị `Attack`
- Setup vùng làm việc canvas
  - Túi đồ
  - Setting
  - Mission : nhiệm vụ trong game
  - PlayerInfo : thông tin nhân vật
- 

### Resource

| Mixamo | https://www.mixamo.com |
| ------ | ------ |
| MyPlayer | Erika Archer With Bow Arrow |
| Idle | standing idle 01 |
| Moving | Standing run forward |
| Rút tên | standing draw arrow |
| Kéo tên | standing aim overdraw |
| Thả tên | standing aim recoil |
| Rơi xuống | fall a loop |
| Rơi xuống chạm đất | fall a land to standing idle 01 |
| Jump | jumping up |
| ------ | ------ |
| Quái | Doozy |
| Quái | Mousey |
| Boss | Ortiz |
| Đá | standing melee kick |
| Đấm | standing melee punch |
| Bị tấn công | Head hit |

### Cấu trúc Folder
+ Assets
    + 📁Các plugin trong game
    + 📁Scenes
        + 📁Model
            + 📁ErikaArcher : chứa 📁Animations + 🔊Musics
            + 📁Enemies : chứa các quái và boss trong game
            + 📁Prefabs : chứa các vật thể trong game
        + 📁SC_Splash : nơi chứa tài nguyên của Scene 
        + 📁SC_Home : Sau khi vào splash thì vào home
        + 📁SC_LV1 :
            + 📄Scene_LV1 : tên scene có tiền tố `Scene_` để dễ search trên `Unity Editor`
            + ⚙️GameManager.cs : script quản lý chung của scene
+ Document
    * Tài liệu chung
    * SC_Splash
    * SC_Home




## License
Quyển sở hữu của thầy Dương Đức Trí

`Zalo` : 0379711459
