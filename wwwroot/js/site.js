function arriesgarLetra(){
    let letra = document.getElementById("letra").value.toLowerCase();
    let cantIntentos = document.getElementById("cantIntentos");
    let palabraOculta = document.getElementById("palabraOculta").value;
    let mostrarPalabra = document.getElementById("mostrarPalabra");
    let resultado = document.getElementById("resultado");

    if(cantIntentos.innerText >0 && mostrarPalabra.innerText != palabraOculta.toUpperCase()){
        if(palabraOculta.includes(letra)){
            let palabraintermedia = "";
            for(let i = 0; i < palabraOculta.length; i++){
                if(letra === palabraOculta[i]){
                    palabraintermedia += letra.toUpperCase();
                }
                else{
                    palabraintermedia += mostrarPalabra.innerText[i];
                }
            }
            mostrarPalabra.innerText = palabraintermedia;
        }
        else{
            cantIntentos.innerText -= 1;
        }
    }
    
    
    if(mostrarPalabra.innerText == palabraOculta.toUpperCase()){
        resultado.innerHTML = "Ganaste!!!!! felicidades por tu victoria"
        resultado.style.color = "green"
    }
    if(cantIntentos.innerText == 0){
        resultado.innerHTML = "Perdiste, suerte la proxima!"
        resultado.style.color = "red"
    }
}
