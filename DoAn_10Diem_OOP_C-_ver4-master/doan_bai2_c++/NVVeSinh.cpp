#include "NVVeSinh.h"

int NVVeSinh::getiShift()
{
    return this->iShift;
}

void NVVeSinh::setiShift(int ca)
{
    this->iShift = ca;
}

double NVVeSinh::getdThuong()
{
    return this->dThuong;
}

void NVVeSinh::setdThuong(double thuong)
{
    this->dThuong = thuong;
}

NVVeSinh::NVVeSinh(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int ca, double thuong) : CaNhan(hoten, thoigianhopdong
    , luongcoban, cmnd, namsinh)
{
    this->iShift = ca;
    this->dThuong = thuong;
}

NVVeSinh::NVVeSinh(string hoten, double luongcoban, string cmnd, int time) : CaNhan(hoten, luongcoban, cmnd)
{
    this->iShift = time;
}

NVVeSinh::NVVeSinh() : CaNhan()
{
    this->sNghe = "NVVeSinh";
}

void NVVeSinh::Nhap()
{
    cout << "Moi nhap thong tin Nhan Vien Ve Sinh ~~ " << endl;
    CaNhan::Nhap();
    //cout << endl;
    cout << "Moi nhap ca lam viec: ";
    cin >> this->iShift;


    cout << "Moi nhap luong Thuong: ";
    cin >> this->dThuong;
    cout << endl;
}

double NVVeSinh::TinhLuong()
{
    return this->dLuongCoBan + this->dThuong * this->hesoluong;
}

void NVVeSinh::Xuat()
{
    CaNhan::Xuat();
    cout << "Ca lam viec cua NVVS la: " << this->iShift << endl;
    cout << "Thuong them cua Doi Bong danh cho NVVS la: " << this->dThuong << " VND" << endl;
}

double NVVeSinh::operator+(const double num)
{
    return this->TinhLuong() + num;
}
