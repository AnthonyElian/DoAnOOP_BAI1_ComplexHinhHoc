#pragma once
#include "CaNhan.h"

using namespace std;

class HLVTheLuc :
    public CaNhan
{
private:
    const double hesoluong = 1.3;
    int iChiSoNangCaoTL;
    string sNoiSinh;
public:
    int getiChiSoNangCaoTL();
    void setiChiSoNangCaoTL(int chiso);
    string getsNoiSinh();
    void setsNoiSinh(string noisinh);
    HLVTheLuc();
    HLVTheLuc(string hoten, int thoigianhopdong, double luongcoban, int NangCaoTL, string cmnd, int namsinh, string noisinh);
    HLVTheLuc(string hoten, double luongcoban, int NangCaoTL, string cmnd, string noisinh);
    void Nhap();
    double TinhLuong();
    void Xuat();
    double operator +(const double num);
};

