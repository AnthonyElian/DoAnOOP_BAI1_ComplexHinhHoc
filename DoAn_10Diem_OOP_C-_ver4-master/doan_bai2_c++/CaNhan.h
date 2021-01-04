#include<iostream>
#include<string.h>
#include<time.h>

using namespace std;

class CaNhan
{
public:
	string sHoTen;
	int iNgayGiaNhap;
	int iThangGiaNgap;
	int iNamGiaNhap;
	int iThoiGianHopDong;
	double dLuongCoBan;
	string sCMND;
	int iNamSinh;
	string sNghe;
	CaNhan();
	~CaNhan();
	CaNhan(string hoten, int thoigianhopdong, double luongcoban, string cmnd, int namsinh);
	CaNhan(string hoten, double luongcoban, string cmnd);
	virtual double TinhLuong() = 0;
	virtual void Nhap();
	virtual void Xuat();
	double GiamTru(double heso);
	int XacDinhBacThue(double heso);
	virtual double TinhThue(double heso);
	int TinhTuoi();
	int thisIsMagic(int year, int month, int day);
	int ThoiGianHopDongConLai();
	enum Bac
	{
		Bac0 = 0,
		Bac1 = 1,
		Bac2,
		Bac3,
		Bac4,
		Bac5,
		Bac6,
		Bac7
	};
};