init();


function init() {
    loadResources();    
}




function loadResources() {
    ajaxRequest('/Resources/GetResources', afterGetResources, null);
}

function afterGetResources(resources) {
    for (var i = 0; i < resources.length; i++) {
        var resource = resources[i],
            firstColumn = div('col-md-6 no-padding').append(img(resource.Image, 'img-responsive')),
            secondColumn = div('col-md-10 donation-wrap2').append(header(5, resource.Title).addClass('product-title'))
                .append(div('product-author').html(resource.Author))
                .append(p(resource.Description)).append(div('donation-btn').append(a('#', 'Descargar')));

        div('col-md-16 shop-item-list').append(div('row').append(firstColumn).append(secondColumn)).appendTo($('#resources-container'));
    }

}
