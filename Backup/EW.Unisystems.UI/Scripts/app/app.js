function loadPage(page, container) {
    var containerView = container || '.content-view';
    $(containerView).load(page);
}


$(window).on('hashchange', function(event) {
    event.preventDefault();
    var pathFile = readParameterFromUrl();
    pathFile = !pathFile ? 'home' : pathFile;
    var url = '/Scripts/app/partials/'.concat(pathFile, '.html');
    loadPage(url);
});

$(window).load(function() {
    $(window).trigger("hashchange");
});


function changeUrl(url) {
    window.location.hash = '#/' + url;
}

function readParameterFromUrl() {
    if (!parent.location.hash) return;
    var parametersList = parent.location.hash.split("#")[1].split("/"),
        parameters = [];
    for (var i = 2; i < parametersList.length; i++) {
        parameters.push(parametersList[i]);
    }
    window.location.parameters = parameters;
    return parametersList[1];
}
