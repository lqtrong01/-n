function kiemtranamnhan(n)
{

    if(((n % 4 == 0) && (n % 100 !=0)) || (n % 400 == 0))
    {

        var a = n + "khong phai la nam nhuan";
      

    }
    else 
    {
        var a = n + " la nam nhuan";
    }

    return a;
}


module.exports = {
    kiemtranamnhan
}