$(document).ready(function () {                     // Aguarda o documento estar pronto para executar o código jQuery
    $("#btnValidarSenha").click(function () {
        var senha = $("#senha").val();              // Obtém o valor do campo de entrada com ID "senha"

        $.ajax({ 
            url: "/api/validacao/validarsenha",
            type: "POST",                           // Método HTTP utilizado na requisição
            contentType: "application/json",        // Tipo de conteúdo enviado na requisição
            data: JSON.stringify(senha),            // Dados enviados na requisição, convertidos para formato JSON
            success: function (response) {
                $("#mensagem").html(response);      // Escreve uma mensagem caso a requisição de certo
            },
            error: function (xhr, status, error) {
                // Verifica se há uma resposta JSON
                if (xhr.responseJSON && xhr.responseJSON.Message) {
                    var errorMessage = xhr.responseJSON.Message;            // Obtém a mensagem de erro                            
                    errorMessage = errorMessage.replace(/\n/g, "<br>");     // Substitua \n por quebra de linha HTML <br>                            
                    $("#mensagem").html(errorMessage);                      // Exiba a mensagem de erro para o usuário
                } else {
                    // Se não houver uma resposta JSON válida, exiba uma mensagem genérica
                    $("#mensagem").html("Ocorreu um erro ao validar a senha.");
                }
            } 
        });
    });
});
