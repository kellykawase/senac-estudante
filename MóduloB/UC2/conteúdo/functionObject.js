function minhaFuncao(objeto){
    objeto.make = "Fiat";
}
var meucarro = { make: "Nissan", model: "Sentra", year: 2012 };
var x, y;
x = meucarro.make; // x recebe o valor "Nissan"
minhaFuncao(meucarro);
y = meucarro.make;
//y recebe o valor "Fiat"
// (a propriedade make foi alterada pela função)
console.log(y)