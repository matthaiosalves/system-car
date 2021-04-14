using System;
using System.Collections.Generic;
using System.Linq;
/*  Pessoas                 Carros
    ----------------        ---------------
    Alice Caroline          foxy
    Thiago Santos           verso
    Amanda Cruz             powerRanger
    Rubens de Souza         astrus          */
class MainClass {
    public static void Main (string[] args) {
        Pessoa alice  = new Pessoa("Alice Caroline" , new DateTime(1992, 05, 26), "123.456.789-85", "A" );
        Pessoa thiago = new Pessoa("Thiago Santos"  , new DateTime(1985, 09, 02), "234.567.890-12", "AC");
        Pessoa amanda = new Pessoa("Amanda Cruz"    , new DateTime(1991, 05, 26), "238.885.890-10", "A" );
        Pessoa rubens = new Pessoa("Rubens de Souza", new DateTime(1981, 07, 15), "345.678.901-23", "AB");

        Carro foxy        = new Carro(2004, "WolksVARGEM", "Foxy"       , "Vermelho", alice , alice );
        Carro verso       = new Carro(2007, "Ninsão"     , "Verso"      , "Verde"   , thiago, thiago);
        Carro powerRanger = new Carro(2014, "Forti"      , "PowerRanger", "Azul"    , thiago, amanda);
        Carro astrus      = new Carro(2018, "Ronda"      , "Astrus"     , "Cinza"   , rubens, rubens);

        alice .DefineCarroDirigido(foxy);

        thiago.DefineCarroDirigido(verso);
        thiago.DefineCarroDirigido(powerRanger);

        amanda.DefineCarroDirigido(verso);
        amanda.DefineCarroDirigido(powerRanger);

        rubens.DefineCarroDirigido(astrus);

        alice .ExibeInfos();
        thiago.ExibeInfos();
        amanda.ExibeInfos();
        rubens.ExibeInfos();

        foxy       .ExibeInfos();
        verso      .ExibeInfos();
        powerRanger.ExibeInfos();
        astrus     .ExibeInfos();
    }
}