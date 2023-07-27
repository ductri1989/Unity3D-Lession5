# Bài 5 : Bài tập giữa kỳ
Chủ đề : cả lớp cùng làm 1 game nhập vai. Điều khiển 1 nhân vật đánh quái, mở rương và nhặt item. Giết quái và đánh nhiều boss ở các map, nhân vật sẽ thu thập được Gold và vật phẩm. Sử dụng vật phẩm để tăng HP,Attack và Gold

### Phạm vi bài giảng
- Tạo project 3D
- Trang trí map
- Setup nhân vật
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
| Nhân vật | Maria W/Prop J J Ong |
| Idle | Unarmed Idle |
| Move | Unarmed Run Forward |
| Attack | Standing Melee Attack Horizontal |
| Jump | jumping |

### Cấu trúc Folder
+ Assets
    + 📁Các plugin trong game
    + 📁Scenes
        + 📁Model
            + 📁Maria : tất cả resource của nhân vật `Maria` sẽ nằm trong folder này (những anim riêng cũng nằm trong folder này). Cả Materials và Textures của riêng nhân vật Maria cũng nằm trong Folder này
            + 📁Animation : nơi chứa các animation chung của tất cả nhân vật
        + 📁SC_Splash : nơi chứa tài nguyên của Scene 
        + 📁SC_Home : Sau khi vào splash thì vào home
        + 📁SC_LV1 : Sau khi vào splash thì vào home
            + 📄Scene_LV1 : tên scene có tiền tố `Scene_` để dễ search trên `Unity Editor`
            + ⚙️GameManager.cs : script quản lý chung của scene
+ Document
    * tài liệu chung
    * SC_Splash
    * SC_Home




## License
Quyển sở hữu của thầy Dương Đức Trí

`Zalo` : 0379711459
