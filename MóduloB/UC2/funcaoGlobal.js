//As seguintes variáveis estão definidas no escopo global
var num1 = 2;
    num2 = 3;
    nome = "SENAC EAD";
// Esta função é definida no escopo global
function multiplica() {
    return num1 * num2;
}
console.log(multiplica()); //Retorna 6
// Um exemplo de função aninhada
function getScore(){
    var num1 = 2,
        num2 = 5;
        function add(){
            return nome + " scored " + (num1 + num2);
        }
        return add();
}
console.log(getScore()); //Retorna "SENAC EAD scored 7"