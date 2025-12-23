async function createUser(){
            const dados = {
                username: document.getElementById('username').value,
                email: document.getElementById('email').value
            };

            const response = await fetch('/users', {
                method: 'POST',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify(dados)
            });
            const  resultado = await response.json();
            alert('Usuario criado com ID: ' + resultado.id);    
        }