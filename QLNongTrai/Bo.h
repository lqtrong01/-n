#pragma once
#include"GiaSuc.h"
#include<algorithm>
class Bo: public GiaSuc
{
public:
	~Bo() {
		return;
	}
	void nhap() {

	}
	void xuat() {

	}
	float tinhLuongSua() {
		float luongSua;
		if (2 <= getTuoi() and getTuoi() <= 5) {
			luongSua = MAX(0, (getCanNang() - getTuoi()))/10;
		}
		else {
			luongSua = 0;
		}
		return luongSua;
	}
};

