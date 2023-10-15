function songuyento(n) {

     if(n<2){

         a= false;
     }
    for(var i=2;i<n;i++){
        if(n % i == 0){
            a= false; 
        }
    }
    a= true;

    if(a==true)
    {
        var a= n+ "la so nguyen to";
    }
    else{
        var a= n+ "khong la so nguyen to";
    }
    return a;
}
module.exports = { 
    songuyento
    };