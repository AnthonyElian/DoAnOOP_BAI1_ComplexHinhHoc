#pragma once
#include "CaNhan.h"
#include<iostream>

using namespace std;

class BacSi :
    public CaNhan
{
private:
    const double hesoluong = 1.15;
    string sRank;
    string sTruongDaoTao;
public:
    string getsRank();
    void setsRank(string rank);
    string getsTruongDaoTao();
    void setsTruongDao(string truong);
    BacSi();
    BacSi(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string tentruong);
    BacSi(string hoten, double luongcoban, string cmnd, string tentruong);
    void Nhap();
    int Kham(int& a);
    int ChuaBenh(int& a);
    double TinhLuong();
    void Xuat();
    double operator +(const double num);
};

