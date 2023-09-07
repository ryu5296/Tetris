/* グローバル変数 */
const int FIELD_HEIGHT = 20; // フィールドの高さ
const int FIELD_WIDTH = 10;  // フィールドの幅
const int FIELD_WALL = 1;    // 壁の厚さ
const int FIELD_FLOOR = 1;   // 床の厚さ
const int FIELD_SPACE = 2;   // 上の空間

int[,] field = new int[FIELD_HEIGHT + FIELD_SPACE + FIELD_FLOOR, FIELD_WIDTH + FIELD_WALL * 2];