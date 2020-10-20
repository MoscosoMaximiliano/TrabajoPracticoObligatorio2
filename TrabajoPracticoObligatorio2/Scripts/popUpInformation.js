  
function ShowInformation(item) {

    const article = document.getElementById(item);
    
    console.log(article);
    
    document.getElementById('POPImg').src = article.dataset.img;
    // document.getElementById('POPImg').src = item.ID;
    document.getElementById('POPName').innerHTML = article.dataset.name;
    // document.getElementById('POPImg').src = item.Name;
    document.getElementById('POPPrice').innerHTML = "Price: " + article.dataset.price;
    // document.getElementById('POPImg').src = item.Price;
    document.getElementById('POPDescription').innerHTML = article.dataset.description;
    // document.getElementById('POPImg').src = item.Description;
    //
    document.getElementById('POPClose').href = "#" + article.dataset.idName;
    // document.getElementById('POPClose').href = "#" + item.ID;
}