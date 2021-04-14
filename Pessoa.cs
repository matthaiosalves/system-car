using System;
using System.Collections.Generic;
using System.Linq;

public class Pessoa
{
  public string   Nome;
  public DateTime Nascimento;
  public string   Cpf;
  public string   CategoriaCnh;

  public Carro       CarroSobResponsabilidade;
  public List<Carro> CarrosPossuidos;
  public List<Carro> CarrosDirigidos;


  public Pessoa()
  {
  	CarrosPossuidos = new List<Carro>();
  	CarrosDirigidos = new List<Carro>();
  }

  public pessoa(string nomeDaPessoa, DataTime dataDeNascimento, string categodiraDaCnh)
  {
  	this.nome = nomeDaPessoa;
  	this.nascimento = dataDeNascimento;
  	this.Cpf = Cpf;
  	this.CategoriaCnh = categodiraDaCnh;
  	CarrosPossuidos = new List<Carro>();
  	CarrosDirigidos = new List<Carro>(); 
  }

  public void ExibeInfos(){
        Console.WriteLine (this.Nome+":");
        Console.WriteLine ("\t» É responsável pelo carro: "+ CarroSobResponsabilidade.Modelo);
        Console.WriteLine ("\t» Possui o(s) carro(s):");
        foreach(var carro in CarrosPossuidos){
            Console.WriteLine ("\t\t» "+carro.Modelo);
        }

        Console.WriteLine ("\t» Dirige o(s) carro(s):");
        foreach(var carro in CarrosDirigidos){
            Console.WriteLine ("\t\t» "+carro.Modelo);
        }
    }

}
