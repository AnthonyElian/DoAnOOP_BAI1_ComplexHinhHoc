#pragma once
#include "CaNhan.h"

using namespace std;

class HLVChienThuat : public CaNhan
{
private:
    const double hesoluong = 1.3;
    string sRank;
    string sQuocGia;
    int iKinhNghiem;
public:
    string getsRank();
    void setsRank(string rank);
    string getsQuocGia();
    void setsQuocGia(string quocgia);
    int getiKinhNghiem();
    void setiKinhNghiem(int kinhnghiem);
    HLVChienThuat(string hoten, int thoigianhoatdong, double luongcoban, string cmnd, int namsinh, string rank, string quocgia, int kinhnghiem);
    HLVChienThuat(string hoten, double luongcoban, string cmnd, string rank);
    HLVChienThuat();
    void Nhap();
    double TinhLuong();
    void Xuat();
    string ChonChienThuat();
    double operator +(const double num);
};

