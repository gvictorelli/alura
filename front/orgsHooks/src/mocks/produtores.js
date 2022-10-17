import green from '../assets/produtores/green.png';
import salad from '../assets/produtores/salad.png';
import jennyJack from '../assets/produtores/jenny-jack.png';
import grow from '../assets/produtores/grow.png';
import potager from '../assets/produtores/potager.png';

const geraNumeroAleatorio = (min, max) => {
    return Math.floor(Math.random() * (max - min + 1) + min);
}

const produtores ={
    titulo: "Produtores",
    lista:[
        {
            nome: "Green",
            imagem: green,
            distancia: `${geraNumeroAleatorio(1, 500)}`,
            estrelas: `${geraNumeroAleatorio(1, 5)}m`, 
        },
        {
            nome: "Salad",
            imagem: salad,
            distancia: `${geraNumeroAleatorio(1, 500)}`,
            estrelas: `${geraNumeroAleatorio(1, 5)}m`, 
        },
        {
            nome: "Jenny Jack Farm",
            imagem: jennyJack,
            distancia: `${geraNumeroAleatorio(1, 500)}`,
            estrelas: `${geraNumeroAleatorio(1, 5)}m`, 
        },
        {
            nome: "Grow",
            imagem: grow,
            distancia: `${geraNumeroAleatorio(1, 500)}`,
            estrelas: `${geraNumeroAleatorio(1, 5)}m`, 
        },
        {
            nome: "Potager",
            imagem: potager,
            distancia: `${geraNumeroAleatorio(1, 500)}`,
            estrelas: `${geraNumeroAleatorio(1, 5)}m`, 
        }
    ]
}

export default produtores;