
#include <iostream>


#include"QuanLyNhanVien.h"

using namespace std;


int main()
{

    QuanLyNhanVien* a = new QuanLyNhanVien();
    a->Nhap();
    a->XuatDSNhanVien();
    BacSi* b = new BacSi();
    b = a->ChonBacSi();
    b->Xuat();
}
