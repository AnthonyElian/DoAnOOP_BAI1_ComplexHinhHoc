#pragma once
#include<list>
#include"CaNhan.h"
#include"BacSi.h"
#include"HLVChienThuat.h"
#include"HLVTheLuc.h"
#include"NVBaoVe.h"
#include"NVVeSinh.h"

using namespace std;

class QuanLyNhanVien
{
private:
	list<CaNhan>* lCaNhan;
	list<BacSi>* lBacSi;
	list<HLVChienThuat>* lHLVCT;
	list<HLVTheLuc>* lHLVTL;
	list<NVBaoVe>* lNVBV;
	list<NVVeSinh>*lNVVS;
public:
	list<CaNhan>* getlCaNhan();
	void setlCaNhan(list<CaNhan>* lcanhan);
	list<BacSi>* getlBacSi();
	void setlBacSi(list<BacSi>* lbacsi);
	list<HLVChienThuat>* getlHLVCT();
	void setlHlVCT(list<HLVChienThuat>* lhlvct);
	list<HLVTheLuc>* getlHLVTL();
	void setlHLVTL(list<HLVTheLuc>* lhlvtl);
	list<NVBaoVe>* getlNVBV();
	void setlNVBV(list<NVBaoVe>* lnvbv);
	list<NVVeSinh>* getlNVVS();
	void setlNVVS(list<NVVeSinh>* lnvvs);
	QuanLyNhanVien();
	QuanLyNhanVien(list<CaNhan>* lcanhan, list<BacSi>* lbacsi, list<HLVChienThuat>* lhlvct, list<HLVTheLuc>* lhlvtl, list<NVBaoVe>* lnvbv, list<NVVeSinh>* lnvs);
	~QuanLyNhanVien();
	void Nhap();
	double TinhLuongToanBoNV();
	void SapXepTheoLuong();
	void XuatDSBacSi();
	BacSi* ChonBacSi();
	void XuatDSHLVCT();
	HLVChienThuat* ChonHLVCT();
	void XuatDSHLVTL();
	HLVTheLuc* ChonHLVTL();
	void XuatDSNVBV();
	void XuatDSNVVS();
	void XuatDSNhanVien();
};

