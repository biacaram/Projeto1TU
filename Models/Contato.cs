using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto1TU.Models
{
    public class Contato
    {
        [Required]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(10, ErrorMessage = "O apelido não pode exceder 10 caracteres.")]
        public string Apelido { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cpf { get; set; }

        //[Required(ErrorMessage = "Campo obrigatório.")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Email { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cep { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Endereco { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(20, ErrorMessage = "O complemento não pode exceder 20 caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        //[Required(ErrorMessage = "Campo obrigatório.")]
        public string EstadoID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public bool Ativo { get; set; }
    }
}