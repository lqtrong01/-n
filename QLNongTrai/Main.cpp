#include"NongTrai.h"
#include"GiaSuc.h"
#include"De.h"
#include"Bo.h"

void main() {
	NongTrai nt;
	nt.nhap();
	nt.xuat();
	cout << "Tong luong sua: "<<nt.tinhTongLuongSua() << endl;
	cout << "Tong luong sua bo: " << nt.tinhTongLuongSuaBo() << endl;
}