function stampa(){
    fetch("https://localhost:7218/api/gelati")
        .then(response => response.json())
        .then(body => {

            for(let [index, item] of body.entries()){

                document.getElementById("corpo-tabella").innerHTML += `
                    <tr>
                        <td>${item.gusto}</td>
                        <td>${item.disponibile}</td>
                        <td>${item.prodotto}</td>
                        <td>${item.acquistato}</td>
                        <td>${item.prezzo} &euro;</td>
                    </tr>
                `;

            }

        })
}

stampa();