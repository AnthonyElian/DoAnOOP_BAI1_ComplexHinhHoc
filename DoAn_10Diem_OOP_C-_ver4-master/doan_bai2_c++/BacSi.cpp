#include "BacSi.h"

string BacSi::getsRank()
{
    return this->sRank;
}

void BacSi::setsRank(string rank)
{
    this->sRank = rank;
}

string BacSi::getsTruongDaoTao()
{
    return this->sTruongDaoTao;
}

void BacSi::setsTruongDao(string truong)
{
    this->sTruongDaoTao = truong;
}

BacSi::BacSi() : CaNhan()
{
    this->sNghe = "bacsi";
}

BacSi::BacSi(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, string rank, string tentruong) : CaNhan(hoten, thoigianhopdong, luongcoban, cmnd, namsinh)
{
    this->sRank = rank;
    this->sTruongDaoTao = tentruong;
}

BacSi::BacSi(string hoten, double luongcoban, string cmnd, string tentruong) : CaNhan(hoten, luongcoban, cmnd)
{
    this->sTruongDaoTao = tentruong;
}

void BacSi::Nhap()
{
    cout << "Moi nhap thong tin Bac Si ~~ " << endl;
    CaNhan::Nhap();

    cout << "Moi nhap loai bang cua Bac Si: ";
    cin >> this->sRank;
    cout << endl;

    cout << "Moi nhap truong dao tao Bac Si: ";
    cin >> this->sTruongDaoTao;
    cout << endl;
}

int BacSi::Kham(int& a)
{
    int b;
    cout << "Moi nhap Tinh Trang Cau Thu: ";
    cin >> b;
    if (b < 50)
    {
        cout << "Cau thu bi chan thuong" << endl;
        cout << "1_Chua Benh || 2_Khong Chua => your choice: ";
        int temp;
        cin >> temp;
        if (temp == 1)
        {
            a = this->ChuaBenh(b);
            cout << "Cau thu da duoc chua ne :3 " << endl;
            return a;
        }
        else
        {
            cout << "Cau thu dang dau qua ne T-T " << endl;
            return b;
        }
    }
    else
    {
        cout << "Cau thu o tinh trang the luc tot !! " << endl;
        return b;
    }
}

int BacSi::ChuaBenh(int& a)
{
    return a = 100;
}

double BacSi::TinhLuong()
{
    return this->dLuongCoBan * hesoluong - this->TinhThue(hesoluong);
}

void BacSi::Xuat()
{
    CaNhan::Xuat();

    cout << "Bang cua Bac Si hang: " << this->sRank << endl;
    cout << "Truong dao tao Bac Si la: " << this->sTruongDaoTao << endl;
    cout << "Luong cua Bac Si la: " << this->TinhLuong() << " VND" << endl;
    if (this->dLuongCoBan > 11000000)
        std::cout << "Thue thu nhap ca nhan cua Bac Si la: " << this->TinhThue(hesoluong) << " VND";
    else
        std::cout << "Doi tuong khong nam trong danh sach dong thue!! ";
}

double BacSi::operator+(const double num)
{
    return this->TinhLuong() + num;
}
