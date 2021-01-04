#include "QuanLyCauThu.h"

QuanLyCauThu::QuanLyCauThu()
{
    this->listCauThu = new list<CauThu>();
}

QuanLyCauThu::QuanLyCauThu(list<CauThu>* lcauthu)
{
    this->listCauThu = lcauthu;
}

QuanLyCauThu::~QuanLyCauThu()
{
    delete this->listCauThu;
}

list<CauThu> *QuanLyCauThu::getlistCauThu()
{
    return this->listCauThu;
}

void QuanLyCauThu::setlistCauThu(list<CauThu> *listCauThu)
{
    this->listCauThu = listCauThu;
}

void QuanLyCauThu::Nhap()
{
    cout << "Moi nhap so luong cau thu trong doi bong: ";
    int cauthu;
    cin >> cauthu;
    for (int i = 0; i < cauthu; i++)
    {
        CauThu *a = new CauThu();
        a->Nhap();
        listCauThu->push_back(*a);
    }
}

void QuanLyCauThu::Xuat()
{
    //this->sort();
    for (auto item : *listCauThu)
    {
        item.Xuat();
    }
}

bool compare1(const CauThu& a, const CauThu& b)
{
    return a.sHoTen < b.sHoTen;
}

bool compare2(CauThu a, CauThu b)
{
    return a.TinhTuoi() < b.TinhTuoi();
}

bool compare3(CauThu a, CauThu b)
{
    return a.iThoiGianHopDong < b.iThoiGianHopDong;
}

bool compare4(CauThu a, CauThu b)
{
    return a.ThoiGianHopDongConLai() < b.ThoiGianHopDongConLai();
}

bool compare5(CauThu a, CauThu b)
{
    return a.getiSoAo() < b.getiSoAo();
}

bool compare6(CauThu a, CauThu b)
{
    return a.getiTinhTrangTheLuc() < b.getiTinhTrangTheLuc();
}

bool compare7(CauThu a, CauThu b)
{
    return a.getiTinhTrangSucKhoe() < b.getiTinhTrangSucKhoe();
}

void QuanLyCauThu::Sort()
{
    cout << "\t\t\t************************MENU************************\t\t\t" << endl;
    cout << "\t\t\t***              1. Ho ten                       ***\t\t\t" << endl;
    cout << "\t\t\t***              2. Tuoi                         ***\t\t\t" << endl;
    cout << "\t\t\t***              3. Ngay gia nhap                ***\t\t\t" << endl;
    cout << "\t\t\t***              4. Thoi han hop dong con lai    ***\t\t\t" << endl;
    cout << "\t\t\t***              5. So ao                        ***\t\t\t" << endl;
    cout << "\t\t\t***              6. TT the luc                   ***\t\t\t" << endl;
    cout << "\t\t\t***              7. TT Suc Khoe                  ***\t\t\t" << endl;
    cout << "\t\t\t***              8. Thoat                        ***\t\t\t" << endl;
    cout << "\t\t\t****************************************************\t\t\t" << endl;
    cout << "Moi nhap lua chon cua ba => Your choice: ";
    int choice;
    cin >> choice;
    switch (choice)
    {
    case 1:
    {
        listCauThu->sort(compare1);
        break;
    }
    case 2:
    {
        listCauThu->sort(compare2);
    }
    case 3:
    {
        listCauThu->sort(compare3);
        break;
    }
    case 4:
    {
        listCauThu->sort(compare4);
        break;
    }
    case 5:
    {
        listCauThu->sort(compare5);
        break;
    }
    case 6:
    {
        listCauThu->sort(compare6);
        break;
    }
    case 7:
    {
        listCauThu->sort(compare7);
        break;
    }
    case 8:
        break;
    default:
        cout << "Nhap sai, moi nhap lai!!  \n";
        break;
    }
}

list<CauThu>* QuanLyCauThu::Loc()
{
    list<CauThu> *temp = new list<CauThu>();
    cout << "\t\t\t************************MENU************************\t\t\t" << endl;
    cout << "\t\t\t***       1. Danh sach cau thu thuan chan trai   ***\t\t\t" << endl;
    cout << "\t\t\t***       2. Danh sach cau thu thuan chan phai   ***\t\t\t" << endl;
    cout << "\t\t\t***       3. Danh sach cau thu co the da tien dao***\t\t\t" << endl;
    cout << "\t\t\t***       4. Danh sach cau thu co the da tien ve ***\t\t\t" << endl;
    cout << "\t\t\t***       5. Danh sach cau thu co the da hau ve  ***\t\t\t" << endl;
    cout << "\t\t\t***       6. Thoat                               ***\t\t\t" << endl;
    cout << "\t\t\t****************************************************\t\t\t" << endl;
    cout << "Moi nhap lua chon cua ba => Your choice: ";
    int choice;
    cin >> choice;
    switch (choice)
    {
    case 1:
    {
        for (auto item : *listCauThu)
            if (item.getsChanThuan() == "trai")
                temp->push_back(item);
        return temp;
    }
    case 2:
    {
        for (auto item : *listCauThu)
            if (item.getsChanThuan() == "phai")
                temp->push_back(item);
        return temp;
    }
    case 3:
    {
        for (auto item : *listCauThu)
            if (item.getsViTriDaChinh() == "tiendao")
                temp->push_back(item);
        return temp;
    }
    case 4:
    {
        for (auto item : *listCauThu)
            if (item.getsViTriDaChinh() == "tienve")
                temp->push_back(item);
        return temp;
    }
    case 5:
    {
        for (auto item : *listCauThu)
            if (item.getsViTriDaChinh() == "hauve")
                temp->push_back(item);
        return temp;
    }
    case 6:
    {
        return temp;
    }
    default:
    {
        cout << "Nhap sai, moi nhap lai!!  " << endl;
        return temp;
    }
    }
    return temp;
}

list<CauThu>* QuanLyCauThu::Search()
{
    cout << "\t\t\t************************MENU************************\t\t\t" << endl;
    cout << "\t\t\t***            1. Ho ten                         ***\t\t\t" << endl;
    cout << "\t\t\t***            2. So ao                          ***\t\t\t" << endl;
    cout << "\t\t\t***            3. Thoat                          ***\t\t\t" << endl;
    cout << "\t\t\t****************************************************\t\t\t" << endl;
    cout << ("Moi nhap lua chon cua ban => Your choice: ");
    int choice;
    cin >> choice;
    list<CauThu>* temp = new list<CauThu>();
    switch (choice)
    {
    case 1:
    {
        cout << "Moi nhap Ho Ten muon tim kiem: ";
        string key;
        cin >> key;
        for (auto object : *listCauThu)
        {
            if (object.sHoTen == key)
            {
                temp->push_back(object);
            }
        }
        return temp;
    }
    case 2:
    {
        int soao;
        cout << "Moi nhap So Ao muon tim kiem: ";
        cin >> soao;
        for (auto item : *listCauThu)
        {
            if (item.getiSoAo() == soao)
            {
                temp->push_back(item);
            }
        }
        return temp;
    }
    case 3:
    {
        //CauThu* temp = &listCauThu->front();
        return temp;
    }
    default:
    {
        //CauThu* temp = &listCauThu->front();
        cout << "Nhap sai, moi nhap lai!! ";
        //temp = nullptr;
        return temp;
    }
    }
}

void QuanLyCauThu::XemTinhTrangTheLuc()
{
    cout << "Xem tinh trang The Luc cac Cau Thu trong Doi Bong" << endl;
    for (auto a : *listCauThu)
    {
        cout << "Cau Thu: " << a.sHoTen << " chi so The Luc la: " << a.getiTinhTrangTheLuc() << endl;
    }
}

void QuanLyCauThu::XemTinhTrangSucKhoe()
{
    cout << "Xem tinh trang Suc Khoe cac Cau Thu trong Doi Bong" << endl;
    for (auto a : *listCauThu)
    {
        cout << "Cau Thu: " << a.sHoTen << " chi so Suc Khoe la: " << a.getiTinhTrangSucKhoe() << endl;
    }
}

CauThu* QuanLyCauThu::CauThuCoTheLucTotNhat()
{
    if (listCauThu->size() == 0)
        return nullptr;
    else
    {
        CauThu* temp = &listCauThu->front();
        for (auto item : *listCauThu)
        {
            if (item.operator>(temp))
                temp = &item;
        }
        return temp;
    }
}

CauThu* QuanLyCauThu::CauThuCoSucKhoeYeuNhat()
{
    if (listCauThu->size() == 0)
        return nullptr;
    else
    {
        CauThu* temp = &listCauThu->front();
        for (auto item : *listCauThu)
        {
            if (item.operator<(temp))
                temp = &item;
        }
        return temp;
    }
}

double QuanLyCauThu::TongLuongToanCauThu()
{
    double temp=0;
    for (auto object : *listCauThu)
    {
        temp = object.operator+(temp);
    }
    return temp;
}





