﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.pds_2024
{
    internal class Empresa
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string SituacaoCad { get; set; }
        public string RegimeTribu { get; set; }
        public DateTime DataInicio { get; set; }
        public string Telefone { get; set; }
        public int CapitalSocial { get; set; }
        public string Endereço { get; set; }
        public string Tipo { get; set; }
        public string PorteEmpre { get; set; }
        public string NaturezaJuri { get; set; }
        public string NomePropri { get; set; }
        public string CPFpropri { get; set; }


        public Empresa(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCad, string regimeTribu, DateTime dataInicio, string telefone, int capitalSocial, string endereço, string tipo, string porteEmpre, string naturezaJuri, string nomePropri, string cPFpropri)
        {
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            SituacaoCad = situacaoCad;
            RegimeTribu = regimeTribu;
            DataInicio = dataInicio;
            Telefone = telefone;
            CapitalSocial = capitalSocial;
            Endereço = endereço;
            Tipo = tipo;
            PorteEmpre = porteEmpre;
            NaturezaJuri = naturezaJuri;
            NomePropri = nomePropri;
            CPFpropri = cPFpropri;
        }

        public Empresa()
        {
        }
    }
}
