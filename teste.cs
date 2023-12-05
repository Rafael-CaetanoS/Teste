// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public abstract class Pessoa{
    public string Nome  {get; set; }
    private string _cpf;
    public string Cpf  {get; set; }
}


public class Endereco {
    public string Bairro {get; set; }
    public string Rua {get; set; }
    public int Numero {get; set; }
    public int Cep {get; set; } 
    
    public Endereco(string bairro, string rua, int numero, int cep){
        Bairro = bairro;
        Rua = rua;
        Numero = numero;
        Cep = cep;
    }
}

public interface ICalculaSalario{
    public double CalcularSarlario();
}

public class Funcionario :  Pessoa, ICalculaSalario{
    public string Email {get; set; }
    public double Salario {get; set; }
    public Endereco End {get; set; }   
    public static int quantidadeFuncionarios;
    
    public Funcionario (string nome, string cpf, string email, double salario){
       try{
        this.Nome = nome.ToUpper();
        this.Cpf = cpf;
        this.Email = email;
        this.Salario = salario;
        quantidadeFuncionarios++;
       }catch (Exception e){
            Console.WriteLine("ocorreu um erro " + e.Message);
        }   
    }
     public double CalcularSarlario(){
         Salario = Salario +(Salario * 0.15); 
         return Salario;
     }
     public double CalcularSarlario (double valor){
         Salario += valor;
         return Salario;
     }
    public void RetornarDados(){
        Console.WriteLine($"Nome:{this.Nome}, Cpf:{this.Cpf}, Email:{this.Email}, Salario:{this.Salario}, Endereco {End.Bairro} rua {End.Rua} numero {End.Numero} CEP {End.Cep}");
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Funcionario rafael = new Funcionario("Rafael", "12345678910", "rafael@gmail.com", 1025);
            Endereco endRafael = new Endereco("12 hc", "4", 212, 12346780);
            rafael.End = endRafael;
            rafael.RetornarDados();
        
            Console.WriteLine(rafael.CalcularSarlario());
            Console.WriteLine(rafael.CalcularSarlario(20));
            
             Funcionario igor = new Funcionario("igor", "42345678611", "igor@gmail.com", 1025);
            Console.WriteLine("Quatidade de funcionarios cadastrados " + Funcionario.quantidadeFuncionarios);
            
             List(Funcionario) parts = new List(Funcionario)();;
        }catch (Exception e){
            Console.WriteLine("ocorreu um erro " + e.Message);
        } 
      
        
    }
}
