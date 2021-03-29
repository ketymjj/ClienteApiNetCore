using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCliente.Models
{
    [Table("ClientesWeb")]
    public class ClienteModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public long Id { get; set; }

        /// <summary>
        /// CEP
        /// </summary>
        /// 
        [Column("CEP")]
        [Display(Name = "CEP")]
        [Required]
        public string CEP { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        /// 
        [Column("Cidade")]
        [Display(Name = "Cidade")]
        [Required]
        public string Cidade { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        /// 
        [Column("Email")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        /// 
        [Column("Estado")]
        [Display(Name = "Estado")]
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        /// 
        [Column("Logradouro")]
        [Display(Name = "Logradouro")]
        [Required]
        public string Logradouro { get; set; }

        /// <summary>
        /// Nacionalidade
        /// </summary>
        /// 
        [Column("Nacionalidade")]
        [Display(Name = "Nacionalidade")]
        [Required]
        public string Nacionalidade { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        /// 
        [Column("Nome")]
        [Display(Name = "Nome")]
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Sobrenome
        /// </summary>
        /// 
        [Column("Sobrenome")]
        [Display(Name = "Sobrenome")]
        [Required]
        public string Sobrenome { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        /// 
        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        /// 
        [Column("CPF")]
        [Display(Name = "CPF")]
        [Required]
        public string CPF { get; set; }
    }
}
