﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdT_Manca
{
    public class Socio : IEquatable<Socio>
    {
        public string _cognome;
        public string _nome;
        public double _telefono;
        public int _debito;
        public string _zona;
        public bool _segreteria; // Indica se il socio fa parte della segreteria

        [JsonProperty]
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _cognome = value;
                else
                    throw new Exception("Cognome non valido");
            }
        }
        [JsonProperty]
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _nome = value;
                else
                    throw new Exception("Nome non valido");
            }
        }
        [JsonProperty]
        public double Telefono
        {
            get
            {
                return _telefono;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()) && value.ToString().Length == 10)
                    _telefono = value;
                else
                    throw new Exception("Numero di Telefono non valido");
            }
        }
        [JsonProperty]
        public int Debito
        {
            get
            {
                return _debito;
            }
            set
            {
                _debito = value;
            }
        }
        [JsonProperty]
        public string Zona
        {
            get
            {
                return _zona;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                    _zona = value;
                else
                    throw new Exception("Zona non valida");
            }
        }
        [JsonProperty]
        public bool Segreteria
        {
            get
            {
                return _segreteria;
            }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value.ToString()))
                    _segreteria = value;
                else
                    throw new Exception("Partecipazione alla segreteria non valida");
            }
        }

        [JsonProperty]
        public List<Prestazione> Prestazioni { get; set; } // Elenco delle prestazioni offerte o ricevute dal socio

        public Socio(string cognome, string nome, double telefono,int debito,string zona, bool segreteria)
        {
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            Debito = debito;
            Zona = zona;
            Segreteria = segreteria;
            Prestazioni = new List<Prestazione>();
        }
        public Socio()
        {
            Cognome = "NoData";
            Nome = "NoData";
            Telefono = 1000000000;
            Debito = 0;
            Segreteria = false;
            Prestazioni = new List<Prestazione>();
        }
        // Metodo per aggiungere una prestazione alla lista del socio
        public void AggiungiPrestazione(Prestazione prestazione)
        {
            Prestazioni.Add(prestazione);
        }

        // Metodo per calcolare il saldo del socio (ore erogate - ore ricevute)
        public int CalcolaDebito()
        {
            int oreErogate = 0;
            int oreRicevute = 0;

            foreach (Prestazione prestazione in Prestazioni)
            {
                if (prestazione.Erogatore.Equals(this))
                {
                    oreErogate += prestazione.Ore;
                }
                else if (prestazione.Ricevente.Equals(this))
                {
                    oreRicevute += prestazione.Ore;
                }
            }

            this.Debito = oreRicevute-oreErogate;
            return this.Debito;
        }

        protected Socio(Socio other) : this(other.Cognome,other.Nome,other.Telefono,other.Debito,other.Zona,other.Segreteria)
        {

        }
        public Socio Clone()
        {
            return new Socio(this);
        }
        public bool Equals(Socio u)
        {
            if (u == null) return false;

            if (this == u) return true;

            return (this.Cognome == u.Cognome && this.Nome == u.Nome);
        }

        public override string ToString()
        {
            return $"Socio: {this.Cognome} {this.Nome}; {this.Telefono}, {this.Debito}, {this.Zona}";
        }
    }
}
