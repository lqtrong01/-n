#pragma once
#include<iostream>
using namespace std;
class GiaSuc
{
protected:
	string maSo;
	float canNang;
	int tuoi;
public:
	GiaSuc() {
		this->maSo = "0";
		this->canNang = 0;
		this->tuoi = 0;
	}
	GiaSuc(string maSo, float canNang,int tuoi) {
		this->maSo = maSo;
		this->canNang = canNang;
		this->tuoi = tuoi;
	}
	~GiaSuc() {
		return;
	}
	string getMaSo() {
		return this->maSo;
	}
	void setMaSo(float maSo) {
		this->maSo = maSo;
	}
	float getCanNang() {
		return this->canNang;
	}
	void setCanNang(float canNang) {
		this->canNang = canNang;
	}
	int getTuoi() {
		return this->tuoi;
	}
	void setTuoi(float tuoi) {
		this->tuoi = tuoi;
	}
	virtual void nhap() {
		cout << "Nhap ma so: ";
		cin >> this->maSo;
		cout << "Nhap canNang: ";
		cin >> this->canNang;
		cout << "Nhap tuoi: ";
		cin >> this->tuoi;
	}
	virtual void xuat() {

	}
	virtual float tinhLuongSua() = 0;
};

