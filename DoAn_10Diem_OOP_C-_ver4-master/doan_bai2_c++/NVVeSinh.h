#pragma once
#include<iostream>
#include "CaNhan.h"

using namespace std;

class NVVeSinh : public CaNhan
{
private:
    const double hesoluong = 1.0;
    int iShift;
    double dThuong;
public:
    int getiShift();
    void setiShift(int ca);
    double getdThuong();
    void setdThuong(double thuong);
    NVVeSinh(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int ca, double thuong);
    NVVeSinh(string hoten, double luongcoban, string cmnd, int time);
    NVVeSinh();
    void Nhap();
    double TinhLuong();
    void Xuat();
    double operator +(const double num);
};

