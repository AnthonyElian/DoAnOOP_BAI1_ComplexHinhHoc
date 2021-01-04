#pragma once
#include "CaNhan.h"

using namespace std;

class NVBaoVe :
    public CaNhan
{
private:
    const double hesoluong = 1.0;
    int iThoiGianLamTrongNgay;
    string sMauDongPhuc;
public:
    int getiThoiGianLamTrongNgay();
    void setiThoiGianLamTrongNgay(int time);
    string getsMauDongPhuc();
    void setsMauDongPhuc(string color);
    NVBaoVe();
    NVBaoVe(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int time, string color);
    NVBaoVe(string hoten, double luongcoban, string cmnd, int time);
    void Nhap();
    double TinhLuong();
    void Xuat();
    double operator +(const double num);
};

