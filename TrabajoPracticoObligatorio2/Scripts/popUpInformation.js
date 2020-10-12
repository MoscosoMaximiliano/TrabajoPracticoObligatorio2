  
function ShowInformation(idName) {

    const article = document.getElementById(idName);

    document.getElementById('POPImg').src = article.dataset.img;
    document.getElementById('POPName').innerHTML = article.dataset.name;
    document.getElementById('POPPrice').innerHTML = "Price: " + article.dataset.price;
    document.getElementById('POPDescription').innerHTML = article.dataset.description;

    document.getElementById('POPClose').href = "#" + article.dataset.idName
}