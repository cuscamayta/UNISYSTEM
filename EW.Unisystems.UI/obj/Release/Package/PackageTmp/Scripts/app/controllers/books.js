init();

function init() {
    loadBooks();
}


function loadBooks() {
    ajaxRequest('/Resources/GetBooksByCareer', afterGetBooks, { career: 1 });
}

function afterGetBooks(books) {    

    for (var i = 0; i < books.length; i++) {
        var book = books[i],
            elementBook= li().append(div('col-md-5').append(img(book.Image, 'img-responsive')))
            .append(div('col-md-11').append(header(4, book.Title)).append(p(book.Resume))
            .append(div('donation-btn').append(a('#', 'Descargar'))));
        
        $('#books-container').append(elementBook);
    }
}

