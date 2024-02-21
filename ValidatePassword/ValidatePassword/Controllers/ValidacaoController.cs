using System; 
using System.Linq;
using System.Web.Http;
using PasswordValidation.Models;

namespace PasswordValidation.Controllers
{
    public class ValidacaoController : ApiController 
    {
        // POST api/validacao/validarsenha
        [HttpPost]                                                          // Define que este método responde a requisições HTTP POST
        [Route("api/validacao/validarsenha")]                               // Define a rota para este método
        public IHttpActionResult ValidarSenha([FromBody] string senha) 
        {
            var validationResult = new PasswordValidationResult();          // Instancia um objeto para armazenar os resultados da validação da senha

            // Verifica se a senha está em branco
            if (string.IsNullOrWhiteSpace(senha))
            {
                validationResult.Errors.Add("A senha não pode estar em branco.");   
            }
            else
            {
                // Verifica se a senha atende aos critérios mínimos
                if (senha.Length < 8)
                {
                    validationResult.Errors.Add("A senha deve ter no mínimo 8 caracteres.");    
                }

                // Verifica se a senha contém pelo menos um caractere especial
                if (!senha.Any(c => !Char.IsLetter(c) && !Char.IsDigit(c)))
                {
                    validationResult.Errors.Add("A senha deve conter pelo menos um caractere especial.");
                }

                // Verifica se a senha contém pelo menos um número
                if (!senha.Any(char.IsDigit))
                {
                    validationResult.Errors.Add("A senha deve conter pelo menos um número.");
                }

                // Verifica se a senha contém pelo menos uma letra maiúscula
                if (!senha.Any(char.IsUpper))
                {
                    validationResult.Errors.Add("A senha deve conter pelo menos uma letra maiúscula.");
                }

                // Verifica se a senha contém pelo menos uma letra minúscula
                if (!senha.Any(char.IsLower))
                {
                    validationResult.Errors.Add("A senha deve conter pelo menos uma letra minúscula.");
                }
            }

            // Se houver erros, retorna BadRequest com a lista de erros
            if (validationResult.Errors.Any())
            {
                return BadRequest(string.Join("\n", validationResult.Errors));
            }

            // Senão, a senha é válida, retorna Ok
            return Ok("Senha válida!");
        }
    }
}
