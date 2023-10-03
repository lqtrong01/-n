#pragma once
#include"GiaSuc.h"
#include"Bo.h";
#include"De.h";
class NongTrai
{
private:
	int soLuong;
	GiaSuc** dsGiaSuc;
public:
	NongTrai() {
		this->soLuong = 0;
		dsGiaSuc = new GiaSuc * [this->soLuong];
	}
	~NongTrai() {
		return;
	}
	void nhap() {
		int loai;
		cout << "Nhap so luong gia suc: ";
		cin >> this->soLuong;
		dsGiaSuc = new GiaSuc * [this->soLuong];
		for (int i = 0; i < this->soLuong; i++) {
			cout << "Nhap loai gia suc: 0-Bo	1-De: ";
			cin >> loai;
			if (loai == 0) {
				dsGiaSuc[i] = new Bo();
			}
			else if (loai == 1) {
				dsGiaSuc[i] = new De();
			}
			dsGiaSuc[i]->nhap();
		}
	}
	void xuat() {
		for (int i = 0; i < this->soLuong; i++) {
			this->dsGiaSuc[i]->xuat();
		}
	}
	float tinhTongLuongSua() {
		float tong=0;
		for (int i = 0; i < this->soLuong; i++) {
			tong += this->dsGiaSuc[i]->tinhLuongSua();
		}
		return tong;
	}
	float tinhTongLuongSuaBo() {
		string loai = NULL;
		float tong=0;
		for (int i = 0; i < this->soLuong; i++) {
			string loai = typeid(*this->dsGiaSuc[i]).name();
			if (loai == "class Bo") {
				tong += this->dsGiaSuc[i]->tinhLuongSua();
			}
		}
		return tong;
	}
	float tinhTongLuongSuaDe() {
		string loai = NULL;
		float tong = 0;
		for (int i = 0; i < this->soLuong; i++) {
			string loai = typeid(*this->dsGiaSuc[i]).name();
			if (loai == "class De") {
				tong += this->dsGiaSuc[i]->tinhLuongSua();
			}
		}
		return tong;
	}
	float timLuongSuaMax() {
		float max = 0;
		if (tinhTongLuongSuaBo() < tinhTongLuongSuaDe()) {
			max = tinhTongLuongSuaDe();
		}
		else {
			max = tinhTongLuongSuaBo();
		}
		return max;
	}
	NongTrai timGiaSucCoLuongSuaMax() {

	}

};

