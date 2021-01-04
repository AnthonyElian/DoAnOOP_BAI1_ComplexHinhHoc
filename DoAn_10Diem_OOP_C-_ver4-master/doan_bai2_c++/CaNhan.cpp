#include"CaNhan.h"
#pragma warning(disable:4996)
#include<iostream>

CaNhan::CaNhan() 
{

}

CaNhan :: ~CaNhan()
{
}

CaNhan::CaNhan(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh)
{
    this->sHoTen = hoten;
    this->iThoiGianHopDong = thoigianhopdong;
    this->dLuongCoBan = luongcoban;
    this->sCMND = cmnd;
    this->iNamSinh = namsinh;
}

CaNhan::CaNhan(string hoten, double luongcoban, string cmnd)
{
    this->sHoTen = hoten;
    this->dLuongCoBan = luongcoban;
    this->sCMND = cmnd;
}

void CaNhan::Nhap()
{
    cout << "Moi nhap Ho Ten thanh vien: ";
    cin.ignore();
    cin >> this->sHoTen;
    cout << endl;

    cout << "Moi nhap Ngay gia nhap: ";
    cin >> this->iNgayGiaNhap; 
    cout << "Moi nhap thang gia nhap: ";
    cin >> this->iThangGiaNgap;
    cout << "Moi nhap Nam gia nhap: "; 
    cin >> this->iNamGiaNhap;
    cout << endl;

    cout << "Moi nhap Thoi Gia Hop Dong: ";
    cin >> this->iThoiGianHopDong;
    //cout << endl;

    cout << "Moi nhap Luong Co Ban cua thanh vien: ";
    cin >> this->dLuongCoBan;
    //cout << endl;

    cout << "Moi nhap so CMND cua thanh vien: ";
    cin.ignore();
    cin >> this->sCMND;
    //cout << endl;

    cout << "Moi nhap Nam Sinh cua thanh vien: ";
    cin >> this->iNamSinh;
    //cout << endl;
}

void CaNhan::Xuat()
{
    cout << "Ho Ten thanh vien la: " << this->sHoTen << endl;
    cout << "Ngay Gia Nhap: " << this->iNgayGiaNhap << "/" << this->iThangGiaNgap << "/" << this->iNamGiaNhap << endl;
    cout << "Thoi gian Hop Dong cua thanh vien la: " << this->iThoiGianHopDong << " Nam" << endl;
    cout << "Luong co ban cua thanh vien la: " << this->dLuongCoBan << " VND" << endl;
    cout << "So CMND cua thanh vien la: " << this->sCMND << endl;
    cout << "Nam sinh cua thanh vien la: " << this->iNamSinh << endl;
    cout << "Tuoi cua thanh vien la: " << this->TinhTuoi() << endl;
}

double CaNhan::GiamTru(double heso)
{
    double GiamTruGiaCanhBanThan = 11000000;
    //8% BHXH, 1.5% BHYT, 1% BHTN
    double BaoHiem = this->dLuongCoBan * heso * (0.08 + 0.015 + 0.01);
    double GiamTru = GiamTruGiaCanhBanThan + BaoHiem;
    return GiamTru;
}

int CaNhan::XacDinhBacThue(double heso)
{
    double ThuNhapTinhThue = this->dLuongCoBan * heso - this->GiamTru(heso);
    if (ThuNhapTinhThue <= 0)
        return Bac0;

    if (ThuNhapTinhThue <= 500)
        return Bac1;
    else
    {
        if (ThuNhapTinhThue <= 10000000)
        {
            return Bac2;
        }
        else
        {
            if (ThuNhapTinhThue <= 18000000)
            {
                return Bac3;
            }
            else
            {
                if (ThuNhapTinhThue <= 32000000)
                {
                    return Bac4;
                }
                else
                {
                    if (ThuNhapTinhThue <= 52000000)
                    {
                        return Bac5;
                    }
                    else
                    {
                        if (ThuNhapTinhThue <= 80000000)
                        {
                            return Bac6;
                        }
                        else
                            return Bac7;
                    }
                }
            }
        }
    }
}

double CaNhan::TinhThue(double heso)
{
    double ThuNhapTinhThue = this->dLuongCoBan * heso - this->GiamTru(heso);
    int Bac = XacDinhBacThue(heso);
    double SoThuePhaiNop = 0;
    switch (Bac)
    {
    case 0:
    {
        return 0;
    }
    case 1:
    {
        SoThuePhaiNop = ThuNhapTinhThue * 0.05;
        break;
    }
    case 2:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.1) - 250000;
        break;
    }
    case 3:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.15) - 750000;
        break;
    }
    case 4:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.2) - 1650000;
        break;
    }
    case 5:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.25) - 3250000;
        break;
    }
    case 6:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.3) - 5850000;
        break;
    }
    default:
    {
        SoThuePhaiNop = (ThuNhapTinhThue * 0.35) - 9850000;
        break;
    }
    }
    return SoThuePhaiNop;
}

int CaNhan::TinhTuoi()
{
    return 2020 - this->iNamSinh;
}

int CaNhan::thisIsMagic(int year, int month, int day)
{
    if (month < 3)
    {
        year--;
        month += 12;
    }
    return 365 * year + year / 4 - year / 100 + year / 400 + (153 * month - 457) / 5 + day - 306;
}

int CaNhan::ThoiGianHopDongConLai()
{
    time_t curr = time(0);
    tm* ltm = localtime(&curr);
    int temp1 = this->thisIsMagic(1900 + ltm->tm_year, 1 + ltm->tm_mon, ltm->tm_mday);
    int temp2 = this->thisIsMagic(this->iNamGiaNhap, this->iThangGiaNgap, this->iNgayGiaNhap);

    return temp1 - temp2;
}


