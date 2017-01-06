init();

function init() {
    loadNews();
}

function loadNews() {
    ajaxRequest('/News/GetListNews', afterGetNews);
}

function afterGetNews(news) {
    for (var i = 0; i < news.length; i++) {
        var res = news[i],
            divPostInfo = div("post-info").append(span("post-meta", res.DateNew)).append(header(4, res.Title)).append(p(res.Content)).append(div("line", "leer mas...")).append(a("#", res.content)),
            elementres = div("portfolio-inner").append(div('folio-item col-md-4 isotope-item').append(article().append(img(res.Image, 'img-responsive')).append(divPostInfo)));
        $('#folio').append(elementres);
    }
}