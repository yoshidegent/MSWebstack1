using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Oef3.Models
{
    public class Pizza
    {
        public string Besteller { get; set; }
        public string PizzaNaam { get; set; }
        public bool ExtraKaas { get; set; }
        public Betaalmogelijkheid Betaalwijze { get; set; }
    }

    public enum Betaalmogelijkheid
    {
        cash,
        cheque,
        overschrijving
    };
}