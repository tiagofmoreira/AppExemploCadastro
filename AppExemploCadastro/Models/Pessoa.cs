using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExemploCadastro.Models
{
    public class Pessoa
    {
       public int Id { get; set; }  
       public string Nome { get; set; }
       public string Cpf { get; set; }
       public string RegistroGeral { get; set; }
       public string Email {  get; set; }   
    }
}

