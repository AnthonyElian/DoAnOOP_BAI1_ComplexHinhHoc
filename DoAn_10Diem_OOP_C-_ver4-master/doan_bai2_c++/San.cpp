#include "San.h"

string San::getsTenSan()
{
    return this->sTenSan;
}

void San::setsTenSan(string tensan)
{
    this->sTenSan = tensan;
}

int San::getiSoLuongKhanGia()
{
    return this->iSoLuongKhanGia;
}

void San::getiSoLuongKhanGia(int soluong)
{
    this->iSoLuongKhanGia = soluong;
}

double San::getdGiaVe()
{
    return this->dGiaVe;
}

void San::setdGiaVe(double gia)
{
    this->dGiaVe = gia;
}

San::San()
{
}

San::San(int soluong, double GiaVe)
{
    this->iSoLuongKhanGia = soluong;
    this->dGiaVe = GiaVe;
}

San::~San()
{
}

void San::Nhap()
{
    cout << "Moi nhap Ten San Van Dong: ";
    cin.ignore();
    cin >> this->sTenSan;
    cout << endl;

    cout << "Moi nhap Gia Ve vao san: ";
    cin >> this->dGiaVe;
    cout << endl;

    cout << "Moi nhap So Luong Khan Gia ma san chua duoc toi da la: ";
    cin >> this->iSoLuongKhanGia;
    cout << endl;
}

void San::Xuat()
{
    cout << "Ten San Van Dong cua Doi Bong la: " << this->sTenSan << endl;
    cout << "Gia ve vao san la: " << this->dGiaVe << endl;
    cout << "So luong Khan Gia khan dai co the chua duoc la: " << this->iSoLuongKhanGia << endl;
}
