
    function preencheDados(conteudo) {
        if (!("erro" in conteudo)) {
        document.getElementById('logradouro').value = (conteudo.logradouro);
    document.getElementById('bairro').value=(conteudo.bairro);
    document.getElementById('cidade').value=(conteudo.localidade);
    document.getElementById('estado').value=(conteudo.uf);
        }
    else {
        limpa_formulário_cep();
    alert("CEP não encontrado.");
        }
    }


    function pesquisacep(valor) {
        var cep = valor.replace(/\D/g, '');
    if (cep != "") {
            var validacep = /^[0-9]{8}$/;
    if (validacep.test(cep)) {
                var script = document.createElement('script');
    script.src = 'https://viacep.com.br/ws/' + cep + '/json/?callback=preencheDados';
    document.body.appendChild(script);
            }
    else {
        alert("Formato de CEP inválido.");
            }
        } 
    };
