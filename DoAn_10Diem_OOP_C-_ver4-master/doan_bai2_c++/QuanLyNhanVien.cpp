#include "QuanLyNhanVien.h"

list<CaNhan>* QuanLyNhanVien::getlCaNhan()
{
    return this->lCaNhan;
}

void QuanLyNhanVien::setlCaNhan(list<CaNhan>* lcanhan)
{
    this->lCaNhan = lcanhan;
}

list<BacSi>* QuanLyNhanVien::getlBacSi()
{
    return this->lBacSi;
}

void QuanLyNhanVien::setlBacSi(list<BacSi>* lbacsi)
{
    this->lBacSi = lbacsi;
}

list<HLVChienThuat>* QuanLyNhanVien::getlHLVCT()
{
    return this->lHLVCT;
}

void QuanLyNhanVien::setlHlVCT(list<HLVChienThuat>* lhlvct)
{
    this->lHLVCT = lhlvct;
}

list<HLVTheLuc>* QuanLyNhanVien::getlHLVTL()
{
    return this->lHLVTL;
}

void QuanLyNhanVien::setlHLVTL(list<HLVTheLuc>* lhlvtl)
{
    this->lHLVTL = lhlvtl;
}

list<NVBaoVe>* QuanLyNhanVien::getlNVBV()
{
    return this->lNVBV;
}

void QuanLyNhanVien::setlNVBV(list<NVBaoVe>* lnvbv)
{
    this->lNVBV = lnvbv;
}

list<NVVeSinh>* QuanLyNhanVien::getlNVVS()
{
    return this->lNVVS;
}

void QuanLyNhanVien::setlNVVS(list<NVVeSinh>* lnvvs)
{
    this->lNVVS = lnvvs;
}

QuanLyNhanVien::QuanLyNhanVien()
{
    this->lCaNhan = new list<CaNhan>();
    this->lBacSi = new list<BacSi>();
    this->lHLVCT = new list<HLVChienThuat>();
    this->lHLVTL = new list<HLVTheLuc>();
    this->lNVBV = new list<NVBaoVe>();
    this->lNVVS = new list<NVVeSinh>();
}

QuanLyNhanVien::QuanLyNhanVien(list<CaNhan>* lcanhan, list<BacSi>* lbacsi, list<HLVChienThuat>* lhlvct, list<HLVTheLuc>* lhlvtl, list<NVBaoVe>* lnvbv, list<NVVeSinh>* lnvvs)
{
    this->lCaNhan = lcanhan;
    this->lBacSi = lbacsi;
    this->lHLVCT = lhlvct;
    this->lHLVTL = lhlvtl;
    this->lNVBV = lnvbv;
    this->lNVVS = lnvvs;
}

QuanLyNhanVien::~QuanLyNhanVien()
{
    delete this->lCaNhan;
    delete this->lBacSi;
    delete this->lHLVCT;
    delete this->lHLVTL;
    delete this->lNVBV;
    delete this->lNVVS;
}

void QuanLyNhanVien::Nhap()
{
    cout << "Moi nhap so luong Bac Si: ";
    int bs; cin >> bs;
    for (int i = 0; i < bs; i++)
    {
        BacSi a;
        a.Nhap();
        CaNhan* temp = &a;
        this->lCaNhan->push_back(*temp);
        this->lBacSi->push_back(a);
    }

    cout << "Moi nhap so luong HLV Chien Thuat: ";
    int hlvct; cin >> hlvct;
    for (int i = 0; i < hlvct; i++)
    {
        HLVChienThuat* a = new HLVChienThuat();
        a->Nhap();
        CaNhan* temp = a;
        this->lCaNhan->push_back(*temp);
        this->lHLVCT->push_back(*a);
    }

    cout << "Moi nhap so luong HLV The Luc: ";
    int hlvtl; cin >> hlvtl;
    for (int i = 0; i < hlvtl; i++)
    {
        HLVTheLuc* a = new HLVTheLuc();
        a->Nhap();
        CaNhan* temp = a;
        this->lCaNhan->push_back(*temp);
        this->lHLVTL->push_back(*a);
    }

    cout << "Moi nhap so luong NV Bao Ve: ";
    int nvbv; cin >> nvbv;
    for (int i = 0; i < nvbv; i++)
    {
        NVBaoVe* a = new NVBaoVe();
        a->Nhap();
        CaNhan* temp = a;
        this->lCaNhan->push_back(*temp);
        this->lNVBV->push_back(*a);
    }

    cout << "Moi nhap so luong NV Ve Sinh: ";
    int nvvs; cin >> nvvs;
    for (int i = 0; i < nvvs; i++)
    {
        NVVeSinh* a = new NVVeSinh();
        a->Nhap();
        CaNhan* temp = a;
        this->lCaNhan->push_back(* temp);
        this->lNVVS->push_back(*a);
    }
}

double QuanLyNhanVien::TinhLuongToanBoNV()
{
    double temp = 0;
    for (auto item : *lBacSi)
    {
        item.operator+(temp);
    }

    for (auto item : *lHLVCT)
    {
        item.operator+(temp);
    }

    for (auto item : *lHLVTL)
    {
        item.operator+(temp);
    }

    for (auto item : *lNVBV)
    {
        item.operator+(temp);
    }

    for (auto item : *lNVVS)
    {
        item.operator+(temp);
    }
    return temp;
}

bool compare(CaNhan *a, CaNhan *b)
{
    return a->TinhLuong() < b->TinhLuong();
}

void QuanLyNhanVien::SapXepTheoLuong()
{
    this->lCaNhan->sort(compare);
}

void QuanLyNhanVien::XuatDSBacSi()
{
    if (this->lBacSi->size() == 0)
        cout << "Khong co Bac Si nao!\n";
    else
    {
        for (auto item : *this->lBacSi)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}

BacSi* QuanLyNhanVien::ChonBacSi()
{
    this->XuatDSBacSi();
    if (this->lBacSi->size() != 0)
    {
        cout << "Ban muon chon bac si so may: ";
        int key; cin >> key;
        int dem = 0;
        for (auto item : *lBacSi)
        {
            dem++;
            if (dem == key)
            {
                return &item;
            }
        }
    }
    return nullptr;
}

void QuanLyNhanVien::XuatDSHLVCT()
{
    if (this->lHLVCT->size() == 0)
        cout << "Khong co HLV Chien Thuat nao!\n";
    else
    {
        for (auto item : *this->lHLVCT)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}

HLVChienThuat* QuanLyNhanVien::ChonHLVCT()
{
    this->XuatDSHLVCT();
    if (this->lHLVCT->size() != 0)
    {
        cout << "Ban muon chon hlv chien thuat so may: ";
        int key; cin >> key;
        int dem = 0;
        for (auto item : *this->lHLVCT)
        {
            dem++;
            if (dem == key)
            {
                return &item;
            }
        }
    }
    return nullptr;
}

void QuanLyNhanVien::XuatDSHLVTL()
{
    if (this->lHLVTL->size() != 0)
        cout << "Khong Co HLV The Luc nao\n";
    else
    {
        for (auto item : *this->lHLVTL)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}

HLVTheLuc* QuanLyNhanVien::ChonHLVTL()
{
    this->XuatDSHLVTL();
    if (this->lHLVTL->size() != 0)
    {
        cout << "Ban muon chon hlv the luc so may: ";
        int key; cin >> key;
        int dem = 0;
        for (auto item : *this->lHLVTL)
        {
            dem++;
            if (dem == key)
            {
                return &item;
            }
        }
    }
    return nullptr;
}

void QuanLyNhanVien::XuatDSNVBV()
{
    if (this->lNVBV->size() != 0)
    {
        cout << "Khong co Nhan Vien Bao Ve nao!\n";
    }
    else
    {
        for (auto item : *this->lNVBV)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}

void QuanLyNhanVien::XuatDSNVVS()
{
    if (this->lNVVS->size() != 0)
        cout << "Khong co Nhan Vien Ve Sinh nao!\n";
    else
    {
        for (auto item : *this->lNVVS)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}

void QuanLyNhanVien::XuatDSNhanVien()
{
    if (this->lCaNhan->size() != 0)
        cout << "Khong co Nhan Vien nao!\n";
    else
    {
        for (auto item : *this->lCaNhan)
        {
            cout << "Ten: " << item.sHoTen << " ___ Chuc Vu: " << item.sNghe << endl;
        }
    }
}


