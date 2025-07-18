using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) 
            : base(message) // Chama o construtor da classe base ApplicationException com a mensagem de erro
        {
        }
    }
}
