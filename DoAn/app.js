const tinhtong = require('./bai1'); 
console.log(`tong la: ${tinhtong.tong_sn(5)}`);

const uocso = require('./bai2'); 
console.log(`uoc so la: ${uocso.uoc_so(25)}`);

const snt = require('./bai3'); 
console.log(`kiem tra so nguyen to la: ${snt.songuyento(15)}`);


const sht = require('./bai4'); 
console.log(`ktra so hoan thien la: ${sht.Sohoanthien(30)}`);

const namnhuan = require('./bai5'); 
console.log(`ktra nam la: ${namnhuan.kiemtranamnhan(2023)}`);

const songay = require('./bai6');
console.log(`so ngay la: ${songay.Ngay(2,2023)}`);

const ptb1 = require('./bai7'); 
console.log(`phuong trinh b1 la: ${ptb1.giaiphuongtrinhbac1(8,4)}`);

const ptb2 = require('./bai8'); 
console.log(`pt bac 2 la: ${ptb2.giaiphuongtrinhbac2(8,4,2)}`);


const docso = require('./bai9'); 
console.log(`doc la la: ${docso.docchuso(302)}`);

const hinhtron = require('./bai10'); 
const ht = new hinhtron(5); 
console.log(`dien tich hinh tron la ${ht.dientich()}`);
console.log(`chu vi hinh tron la  ${ht.chuvi()}`);

const hinhchunhat = require('./bai11'); 
const hcn = new hinhchunhat(5,4); 
console.log(`dien tich hcn la ${hcn.dientich()}`);
console.log(`chu vi hcn la  ${hcn.chuvi()}`);

const hinhtamgiac = require('./bai12'); 
const htg = new hinhtamgiac(5,4,3); 
console.log(`dien tich tam giac la ${htg.dientich()}`);
console.log(`chu vi tam giac la  ${htg.chuvi()}`);
