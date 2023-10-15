function Sohoanthien(n){

    var s = 0;

    for(var i = 1; i < n;i++ ){
        if(n % i == 0){

            s = parseInt(s) + i;
        }
    }
        if(s == n){
            var a = n + " la so hoan thien";
        }
        else{
            var a = n + " khong la so hoan thien";
        }
    return a;
}


module.exports = {
    Sohoanthien
}