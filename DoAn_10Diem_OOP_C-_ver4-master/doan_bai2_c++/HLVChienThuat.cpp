#include "HLVChienThuat.h"

string HLVChienThuat::getsRank()
{
    return this->sRank;
}

void HLVChienThuat::setsRank(string rank)
{
    this->sRank = rank;
}

string HLVChienThuat::getsQuocGia()
{
    return this->sQuocGia;
}

void HLVChienThuat::setsQuocGia(string quocgia)
{
    this->sQuocGia = quocgia;
}

int HLVChienThuat::getiKinhNghiem()
{
    return this->iKinhNghiem;
}

void HLVChienThuat::setiKinhNghiem(int kinhnghiem)
{
    this->iKinhNghiem = kinhnghiem;
}

HLVChienThuat::HLVChienThuat(string hoten, int thoigianhoatdong, double luongcoban, string cmnd, int namsinh, string rank, string quocgia, int kinhnghiem) : CaNhan(hoten, thoigianhoatdong, luongcoban, cmnd, namsinh)
{
    this->sRank = rank;
    this->sQuocGia = quocgia;
    this->iKinhNghiem = kinhnghiem;
}

HLVChienThuat::HLVChienThuat(string hoten, double luongcoban, string cmnd, string rank) : CaNhan(hoten, luongcoban, cmnd)
{
    this->sRank = rank;
}

HLVChienThuat::HLVChienThuat() : CaNhan()
{
    this->sNghe = "HLVCT";
}

void HLVChienThuat::Nhap()
{
    cout << "Moi nhap thong tin HLV Chien Thuat ~~ " << endl;
    CaNhan::Nhap();
    //cout << endl;

    cout << "Moi nhap hang cua HLV //Hang: C_B_A_Pro : ";
    cin.ignore();
    cin >> this->sRank;
    //cout << endl;

    cout << "Moi nhap Quoc Gia cua HLV: ";
    cin.ignore();
    cin >> this->sQuocGia;
    

    cout << "Moi nhap so doi HLV tung cong tac truoc day: ";
    cin >> this->iKinhNghiem;
    cout << endl;
}

double HLVChienThuat::TinhLuong()
{
    return this->dLuongCoBan * hesoluong - TinhThue(hesoluong);
}

void HLVChienThuat::Xuat()
{
    CaNhan::Xuat();

    cout << "Hang cua HLV Chien Thuat la: " << this->sRank << endl;
    cout << "Quoc gia cua HLV Chien Thuat la: " << this->sQuocGia << endl;
    cout << "So doi HLV Chien Thuat da tung cong tac la: " << this->iKinhNghiem << endl;
    if (this->dLuongCoBan > 11000000)
        std::cout << "Thue thu nhap ca nhan cua HLV Chien Thuat la: " << this->TinhThue(hesoluong) << " VND\n";
    else
        std::cout << "Doi tuong khong nam trong danh sach dong thue!! \n";
}

string HLVChienThuat::ChonChienThuat()
{
    cout << "Ban muon chon so do chien thuat nao: ";
    string temp;
    cin >> temp;
    return temp;
}

double HLVChienThuat::operator+(const double num)
{
    return this->TinhLuong() + num;
}
