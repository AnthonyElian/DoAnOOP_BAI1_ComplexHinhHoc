#pragma once
#include<iostream>

using namespace std;

class San
{
private:
	string sTenSan;
	int iSoLuongKhanGia;
	double dGiaVe;
public:
	string getsTenSan();
	void setsTenSan(string tensan);
	int getiSoLuongKhanGia();
	void getiSoLuongKhanGia(int soluong);
	double getdGiaVe();
	void setdGiaVe(double gia);
	San();
	San(int soluong, double GiaVe);
	~San();
	void Nhap();
	void Xuat();
};

