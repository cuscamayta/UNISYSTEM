init();

function init() {
    loadBooks();
}

function loadBooks() {
    ajaxRequest('/Resources/GetBooksByTypeAndCareer', afterGetBooks, { nameType: "Libro", nameCareer: "trabajosocial" });
}

function afterGetBooks(books) {
    for (var i = 0; i < books.length; i++) {
        var book = books[i],
            elementBook = li().addClass("content").append(div('col-md-5').append(img("../../../Content/img/book.jpg", 'img-responsive')))
            .append(div('col-md-11').append(header(4, book.Title)).append(span('post-meta', book.Author)).append(p(book.Description))
            .append(div('donation-btn').append(a(book.ResourceLink, 'Descargar').attr('target', '_blank'))));

        $('#books-container').append(elementBook);
    }
}

pageSize = 3;

showPage = function (page) {
    $(".content").hide();
    $(".content").each(function (n) {
        if (n >= pageSize * (page - 1) && n < pageSize * page)
            $(this).show();
    });
}

showPage(1);

$("#pagin li a").click(function () {
    $("#pagin li a").removeClass("current");
    $(this).addClass("current");
    showPage(parseInt($(this).text()))
});