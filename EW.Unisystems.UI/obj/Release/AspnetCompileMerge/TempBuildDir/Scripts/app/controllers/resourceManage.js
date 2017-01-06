init();

function init() {
    createUpLoad($('.upload-file'), afterUpload);
    $('#btn-add-resource').click(function (e) {
        showModalAddResource(e);
    });
}


function afterUpload(file, textResponse) {
    $('#file').val(file);
    console.log('file');
    console.log(file);
    console.log('text response');
    console.log(textResponse);
}

function saveResource() {
    var newResource = {
        Author: $('#author').val(),
        Description: $('#author').text(),
        Image: resourceScope.IdImage,
        ResourceLink: $('#author').val(),
        Title: $('#author').val(),
        TypeResource: $('#author').val(),
        Career: $('#author').val()
    };
}