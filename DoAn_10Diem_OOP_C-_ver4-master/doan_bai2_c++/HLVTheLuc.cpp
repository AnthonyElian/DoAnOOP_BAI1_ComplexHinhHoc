#include "HLVTheLuc.h"

int HLVTheLuc::getiChiSoNangCaoTL()
{
    return this->iChiSoNangCaoTL;
}

void HLVTheLuc::setiChiSoNangCaoTL(int chiso)
{
    this->iChiSoNangCaoTL = chiso;
}

string HLVTheLuc::getsNoiSinh()
{
    return this->sNoiSinh;
}

void HLVTheLuc::setsNoiSinh(string noisinh)
{
    this->sNoiSinh = noisinh;
}

HLVTheLuc::HLVTheLuc() : CaNhan()
{
    this->sNghe = "HLVTL";
}

HLVTheLuc::HLVTheLuc(string hoten, int thoigianhopdong, double luongcoban, int NangCaoTL, string cmnd, int namsinh, string noisinh) : CaNhan(hoten, thoigianhopdong, luongcoban, cmnd, namsinh)
{
    this->iChiSoNangCaoTL = NangCaoTL;
    this->sNoiSinh = noisinh;
}

HLVTheLuc::HLVTheLuc(string hoten, double luongcoban, int NangCaoTL, string cmnd, string noisinh) : CaNhan(hoten, luongcoban, cmnd)
{
    this->iChiSoNangCaoTL = NangCaoTL;
    this->sNoiSinh = noisinh;
}

void HLVTheLuc::Nhap()
{
    cout << "Moi nhap thong tin HLV The Luc ~~ " << endl;
    CaNhan::Nhap();
    //cout << endl;

    cout << "Moi nhap Quoc Gia cua HLV The Luc: ";
    cin.ignore();
    cin >> this->sNoiSinh;
    

    cout << "Moi nhap chi so nang cao the luc cua HLV The Luc: ";
    cin >> this->iChiSoNangCaoTL;
    cout << endl;
}

double HLVTheLuc::TinhLuong()
{
    return this->dLuongCoBan * hesoluong - this->TinhThue(hesoluong);
}

void HLVTheLuc::Xuat()
{
    CaNhan::Xuat();

    cout << "Quoc Gia cua HLV The Luc la: " << this->sNoiSinh << endl;

    cout << "Chi so nang cao the luc la: " << this->iChiSoNangCaoTL << endl;

    cout << "Luong cua HLV The Luc la: " << this->TinhLuong() << " VND" << endl;

    if (this->dLuongCoBan > 11000000)
        std::cout << "Thue thu nhap ca nhan cua HLV The Luc la: " << this->TinhThue(hesoluong) << " VND\n";
    else
        std::cout << "Doi tuong khong nam trong danh sach dong thue!! \n";
}

double HLVTheLuc::operator+(const double num)
{
    return this->TinhLuong() + num;
}
