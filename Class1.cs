﻿namespace RestSharpDemo.Models
{
    internal class Card
    {

        public string? cep { get; set; }
        public string? logradouro { get; set; }
        public string? complemento { get; set; }
        public string? bairro { get; set; }
        public string? localidade { get; set; }
        public string? uf { get; set; }
        public string? ibge { get; set; }
        public string? gia { get; set; }
        public string? ddd { get; set; }
        public string? siafi { get; set; }
        public override string ToString()
        {
            return $"Cep: {cep}, Logradouro: {logradouro}, Complemento: {complemento}, Bairro: {bairro}, Localidade: {localidade}, Uf: {uf}, IBGE: {ibge} , Gia: {gia}, DDD: {ddd}, Siafi: {siafi}";
        }
    }

}


