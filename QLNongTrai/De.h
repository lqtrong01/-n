#pragma once
#include"GiaSuc.h"
class De : public GiaSuc
{
public:
	~De() {
		return;
	}
	void nhap() {

	}
	void xuat() {

	}
	float tinhLuongSua() {
		float luongSua;
		if (1 <= getTuoi() and getTuoi() <= 2) {
			luongSua = getCanNang() / 10;
		}
		else if (2 < getTuoi() and getTuoi() <= 4) {
			luongSua = getCanNang() / 15;
		}
		else {
			luongSua = 0;
		}
		return luongSua;
	}
};

