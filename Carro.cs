using System;
using System.Collections.Generic;
using System.Linq;

public class Carro{
    public int    Ano;
    public string Marca;
    public string Modelo;
    public string Cor;

    public Pessoa Dono;
    public Pessoa Responsavel;
    public List<Pessoa> Motoristas;

    public Carro(){
        this.Motoristas = new List<Pessoa>();
    }

    public Carro(int ano, string marca, string modelo, string cor, Pessoa dono = null, Pessoa responsavel = null){
        Ano         = ano;
        Marca       = marca;
        Modelo      = modelo;
        Cor         = cor;
        Dono        = dono;
        Responsavel = responsavel;
        this.Motoristas = new List<Pessoa>();

        if(dono != null){
            dono.CarrosPossuidos.Add(this);
        }

        if(responsavel != null){
            responsavel.CarroSobResponsabilidade = this;
        }
    }

    public void ExibeInfos(){
        Console.WriteLine (Modelo+":");
        Console.WriteLine ("\t» É de propriedade do(a): "+ Dono.Nome);
        Console.WriteLine ("\t» Tem como responsável: "  + Responsavel.Nome);
        Console.WriteLine ("\t» Possui como motorista(s):");
        foreach(var pessoa in Motoristas){
            Console.WriteLine ("\t\t» "+pessoa.Nome);
        }
    }
}
