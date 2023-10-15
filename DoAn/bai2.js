function uoc_so(n) {
    var dem=0;
    for(var i = 1; i <= n; i++) {
        if(n % i == 0) {
             dem++;
        }
    }
    return dem;
}
module.exports = { 
    uoc_so
    };