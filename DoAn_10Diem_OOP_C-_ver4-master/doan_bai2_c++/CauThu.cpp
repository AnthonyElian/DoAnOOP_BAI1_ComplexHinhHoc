#include "CauThu.h"

CauThu::~CauThu()
{
}

int CauThu::getiSoAo()
{
	return this->iSoAo;
}

void CauThu::setiSoAo(int soao)
{
	this->iSoAo = soao;
}

int CauThu::getiTinhTrangTheLuc()
{
	return this->iTinhTrangTheLuc;
}

void CauThu::setiTinhTrangTheLuc(int theluc)
{
	this->iTinhTrangTheLuc = theluc;
}

int CauThu::getiTinhTrangSucKhoe()
{
	return this->iTinhTrangSucKhoe;
}

void CauThu::setiTinhTrangSucKhoe(int suckhoe)
{
	this->iTinhTrangSucKhoe = suckhoe;
}

string CauThu::getsChanThuan()
{
	return this->sChanThuan;
}

void CauThu::setsChanThuan(string chanthuan)
{
	this->sChanThuan = chanthuan;
}

string CauThu::getsViTriDaChinh()
{
	return this->sViTriDaChinh;
}

void CauThu::setsViTriDaChinh(string vitri)
{
	this->sViTriDaChinh = vitri;
}

CauThu::CauThu(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh, int soao, int tinhtrangsuckhoe) : CaNhan(hoten, thoigianhopdong, luongcoban, cmnd, namsinh)
{
	this->iSoAo = soao;
	this->iTinhTrangSucKhoe = tinhtrangsuckhoe;
}

CauThu::CauThu(string hoten, double luongcoban, string cmnd, int soao) : CaNhan(hoten, luongcoban, cmnd)
{
	this->iSoAo = soao;
}

CauThu::CauThu() : CaNhan()
{
}

void CauThu::Nhap()
{
	cout << "Moi nhap thong tin Cau Thu ~~ " << endl;
	CaNhan::Nhap();
	//cout << endl;

	cout << "So Ao cua Cau Thu la: ";
	cin >> this->iSoAo;
	//cout << endl;

	cout << "Tinh Trang The Luc cua Cau Thu la: ";
	cin >> this->iTinhTrangTheLuc;
	//cout << endl;

	cout << "Tinh Trang Suc Khoe cua Cau thu la: ";
	cin >> this->iTinhTrangSucKhoe;
	//cout << endl;

	cout << "Chan Thuan cua Cau Thu la: ";
	cin.ignore();
	cin >> this->sChanThuan;
	//cout << endl;

	cout << "Vi Tri So Truong cua Cau Thu la: ";
	cin.ignore();
	cin >> this->sViTriDaChinh;
	cout << endl;
}

double CauThu::TinhLuong()
{
	return this->dLuongCoBan * this->hesoluong - this->TinhThue(this->hesoluong);
}

void CauThu::Xuat()
{
	cout << "Thong tin Cau Thu ~~ " << endl;
	CaNhan::Xuat();

	cout << "So Ao co dinh cua Cau Thu la: " << this->iSoAo << endl;

	cout << "Chan Thuan cua Cau Thu la: " << this->sChanThuan << endl;

	cout << "Vi Tri So Truong cua Cau Thu la: " << this->sViTriDaChinh << endl;

	cout << "Luong cua Cau Thu la: " << this->TinhLuong() << " VND" << endl;

	if (this->dLuongCoBan > 11000000)
		cout << "Thue thu nhap ca nhan cua Cau Thu la: " << this->TinhThue(hesoluong) << " VND\n";
	else
		cout << "Doi tuong khong nam trong danh sach dong thue!! \n";
}

bool CauThu::operator>(const CauThu* a)
{
	int value1 = this->iTinhTrangTheLuc;
	int value2 = a->iTinhTrangTheLuc;
	return value1 > value2;
}

bool CauThu::operator<(const CauThu* a)
{
	int value1 = this->iTinhTrangSucKhoe;
	int value2 = a->iTinhTrangSucKhoe;
	return value1 < value2;
}

double CauThu::operator+(const double num)
{
	return this->TinhLuong() + num;
}

//CauThu operator=(const CauThu& a, const CauThu& b)
//{
//	return b;
//}

