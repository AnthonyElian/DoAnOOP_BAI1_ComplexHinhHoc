#pragma once
#include"CauThu.h"
#include<list>
#include<algorithm>

class QuanLyCauThu
{
private:
	list<CauThu> *listCauThu;
public:
	QuanLyCauThu();
	QuanLyCauThu(list<CauThu>* lcauthu);
	~QuanLyCauThu();
	list<CauThu> *getlistCauThu();
	void setlistCauThu(list<CauThu>* listCauThu);
	void Nhap();
	void Xuat();
	void Sort();
	list<CauThu>* Loc();
	list<CauThu>* Search();
	void XemTinhTrangTheLuc();
	void XemTinhTrangSucKhoe();
	CauThu* CauThuCoTheLucTotNhat();
	CauThu* CauThuCoSucKhoeYeuNhat();
	double TongLuongToanCauThu();
};

