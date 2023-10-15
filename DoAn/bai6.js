function Ngay(thang,nam){
    var kiemtra;

    if(((nam % 4 == 0) && (nam % 100 !=0)) || (nam % 400 == 0)){
        kiemtra = true;
    }
    else{
        kiemtra = false;
    }
    
    switch(thang){
        case 1:
        case 3:
        case 5:
        case 7:
        case 8:
        case 10:
        case 12: return 31;
        case 4:
        case 6:
        case 9:
        case 11: return 30;
        case 2:
            if(kiemtra == true){
                return 29;
            }
            else{
                return 28;
            }
    }
}


module.exports = {
    Ngay
}