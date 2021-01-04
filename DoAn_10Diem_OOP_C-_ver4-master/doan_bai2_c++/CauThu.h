#pragma once
#include <iostream>
#include"CaNhan.h"
using namespace std;

class CauThu : public CaNhan
{
private:
    const double hesoluong = 1.3;
    int iSoAo;
    int iTinhTrangTheLuc;
    int iTinhTrangSucKhoe;
    string sChanThuan;
    string sViTriDaChinh;
public: 
    ~CauThu();
    int getiSoAo();
    void setiSoAo(int soao);
    int getiTinhTrangTheLuc();
    void setiTinhTrangTheLuc(int theluc);
    int getiTinhTrangSucKhoe();
    void setiTinhTrangSucKhoe(int suckhoe);
    string getsChanThuan();
    void setsChanThuan(string chanthuan);
    string getsViTriDaChinh();
    void setsViTriDaChinh(string vitri);
    CauThu(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe);
    CauThu(string hoten, double luongcoban, string cmnd, int soao);
    CauThu();
    void Nhap();
    double TinhLuong();
    //int TinhTuoi();
    void Xuat();
    bool operator >(const CauThu* a);
    bool operator <(const CauThu* a);
    double operator +(const double num);
    //friend CauThu operator=(const CauThu& a, const CauThu& b);
};

