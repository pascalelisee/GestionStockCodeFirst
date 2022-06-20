using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//valable pour les base de donnees
using System.ComponentModel.DataAnnotations.Schema;


namespace MetierStock.Model
{
    public class Categorie
    {
        [Key, ScaffoldColumn(false)]
        public int IdCategorie { get; set; }
        [Display(Name ="Code catégorie"),Required(ErrorMessage ="*")]
        [MaxLength(4,ErrorMessage ="la taille maximal est de 4 carataire")]
        public String CodeCategorie { get; set; }

        [Display(Name = "Libelle  catégorie")]
        [MaxLength(80, ErrorMessage = "la taille maximal est de 80 carataire")]
        public string LibelleCategorie { get; set; }
    }
}