using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1,nome2;//variáveis do primeiro nome e sobrenome
            ushort dia,mes,ano;// data de aniversário
            float idade1;
            int idade,nasc, atual;
            int ano1 = DateTime.Now.Year;//ano atual
		    int dia1 = DateTime.Now.Day;//dia atual
		    int mes1 = DateTime.Now.Month;//mês atual
            //solicitando nome
            Console.WriteLine("Digite o seu primeiro nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            nome2 = Console.ReadLine();
            //solicitando dia de nascimento
            Console.WriteLine("Digite o dia do seu nascimento: ");
            dia = ushort.Parse(Console.ReadLine());
	      if(dia<32 && dia>0)//verificando se o dia está correto(de 1 a 30)
            {//solicitando o mês, caso o dia esteja certo 
	        Console.WriteLine("Digite o mês do seu nascimento: ");
            mes = ushort.Parse(Console.ReadLine());	
                //verificando se o mês pode ter 29, 30 ou 31 dias
                if(((mes==4 || mes==6 || mes==9 || mes==11) && (dia<31)) || (mes==2 && dia<30) 
                ||((mes==1 || mes==3 || mes==5 || mes==7 || mes==8 || mes==10) && (dia<32)) )
                {//solicitando o ano de nascimento, caso o dia e o mês esteja correto
                Console.WriteLine("Digite o ano do seu nascimento: ");
                ano = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Seu aniversário é: {0}/{1}/{2}",dia,mes,ano); 
                nasc = ano*365 + mes*12 + dia;
                atual = ano1*365 + mes1*12 + dia1; 
                idade1 = (atual - nasc)/365;
                idade = (int)idade1;
                    if((ano<2020 && ano>1900))//verificando se a pessoa nasceu antes de 2020 
                    {//e após 1900 - eu achei melhor usar esse critério
                        if(ano<2002 || (ano==2002 && mes<11) || (ano==(ano1-18) && mes==mes1 && dia<=dia1))//verficiando se a pessoa tem 18 anos ou mais
					    {
                        Console.WriteLine("Você tem {0} anos",idade);
					    Console.WriteLine("Seu nome é {0} {1}",nome1,nome2);
                        //concatenando idade e nome, se o usuário ter 18 ou mais anos.    
				        Console.WriteLine("Sua senha é: {0}{1}{2}",idade,nome1,nome2);
                        }						
                        else//caso a pessoa tenha menos de 18 anos
					    {
                        Console.WriteLine("Você tem {0} anos",idade);
					    Console.WriteLine("Seu nome é {0} {1}",nome1,nome2);
                        //concatenando nome e idade, se o usuário ter menos que 18 anos
                        Console.WriteLine("Sua senha é: {0}{1}{2}",nome1,nome2,idade);
                        }					
				    } 
					else//caso o ano não esteja correto, de acordo com os critérios
                    Console.WriteLine(" O ano está digitado incorretamente");
				} 
			    else//caso o mês não esteja correto, de acordo com os critérios
                Console.WriteLine(" O mes está digitado incorretamente");
            }           
            else//caso o dia não esteja correto, de acordo com os critérios.
            Console.WriteLine(" O dia está digitado incorretamente");
        }
    }
}
