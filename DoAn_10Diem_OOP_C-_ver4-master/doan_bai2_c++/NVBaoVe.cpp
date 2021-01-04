#include "NVBaoVe.h"

int NVBaoVe::getiThoiGianLamTrongNgay()
{
    return this->iThoiGianLamTrongNgay;
}

void NVBaoVe::setiThoiGianLamTrongNgay(int time)
{
    this->iThoiGianLamTrongNgay = time;
}

string NVBaoVe::getsMauDongPhuc()
{
    return this->sMauDongPhuc;
}

void NVBaoVe::setsMauDongPhuc(string color)
{
    this->sMauDongPhuc = color;
}

NVBaoVe::NVBaoVe() :CaNhan()
{
    this->sNghe = "NVBaoVe";
}

NVBaoVe::NVBaoVe(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int time, string color) : CaNhan(hoten, thoigianhopdong
    , luongcoban, cmnd, namsinh)
{
    this->iThoiGianLamTrongNgay = time;
    this->sMauDongPhuc = color;
}

NVBaoVe::NVBaoVe(string hoten, double luongcoban, string cmnd, int time) : CaNhan(hoten, luongcoban, cmnd)
{
    this->iThoiGianLamTrongNgay = time;
}

void NVBaoVe::Nhap()
{
    cout << "Moi nhap thong tin Nhan Vien Bao Ve ~~ " << endl;
    CaNhan::Nhap();
    //cout << endl;

    cout << "Moi nhap Thoi Gian Lam Viec/Ngay cua Nhan Vien Bao Ve: ";
    cin >> this->iThoiGianLamTrongNgay;
    

    cout << "Moi nhap Mau Dong Phuc hom nay: ";
    cin.ignore();
    cin >> this->sMauDongPhuc;
    cout << endl;
}

double NVBaoVe::TinhLuong()
{
    return this->dLuongCoBan + this->dLuongCoBan * this->hesoluong;
}

void NVBaoVe::Xuat()
{
    CaNhan::Xuat();
    cout << "Tong thoi gian lam viec tren mot ngay la: " << this->iThoiGianLamTrongNgay << endl;
    cout << "Mau Dong Phuc hom nay: " << this->sMauDongPhuc << endl;
}

double NVBaoVe::operator+(const double num)
{
    return this->TinhLuong() + num;
}
