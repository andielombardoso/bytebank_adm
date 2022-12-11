using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema interno!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}
