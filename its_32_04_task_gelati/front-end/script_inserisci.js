function salvataggio(){
    let gusto = document.getElementById("input-gusto").value;
    let disponibilita = document.getElementById("input-disponibilita").value;
    let quantita = document.getElementById("input-quantita").value;
    let venduto = document.getElementById("input-venduto").value;
    let prezzo = document.getElementById("input-prezzo").value;

    let gelato = {
        gusto,
        disponibile: disponibilita,
        prodotto: quantita,
        acquistato: venduto,
        prezzo,
    }

    fetch("https://localhost:7218/api/gelati", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(gelato)
    })
    .then(response => {
        if(response.status === 201)
            alert("STAPPOOOOOOOOOOOOOOOOO")
        else
            alert("ERRORE ERRORE")
    })
    .catch(errore => {
        alert("ERRORE ERRORE")
        console.log(errore)
    })
    .finally(() => {
        window.location.href = "index.html"
    })
}