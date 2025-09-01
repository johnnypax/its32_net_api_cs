async function stampa(){
    let response = await fetch("https://localhost:7076/api/studenti")

    if(response.ok){
        let body = await response.json();

        console.log(body)

        let contenuto = ``;

        for(let i=0; i<body.length; i++){
            contenuto += `
                <tr>
                    <td>${body[i].id}</td>
                    <td>${body[i].nome}</td>
                    <td>${body[i].cognome}</td>
                    <td>${body[i].matricola}</td>
                </tr>
            `
        }

        document.getElementById("corpo-tabella").innerHTML = contenuto;
    }
}

stampa();