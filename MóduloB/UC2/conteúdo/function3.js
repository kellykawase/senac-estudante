function mapeamento(f,a) {
    var result = []; //Cria um novo Array
    var i;
    for (i = 0; i != a.length; i++)
    result[i] = f(a[i]);
    return console.log(result);
}
mapeamento(function (x) {return x*x*x}, [0,1,2,5,10]);