using System.Collections.Generic; 

namespace PasswordValidation.Models
{
    public class PasswordValidationResult
    {
        public bool IsValid { get; set; }                   // Propriedade para indicar se a validação da senha foi bem-sucedida
        public List<string> Errors { get; set; }            // Lista de erros de validação da senha

        public PasswordValidationResult()           
        {
            Errors = new List<string>();                    // Inicializa a lista de erros
        }
    }
}
