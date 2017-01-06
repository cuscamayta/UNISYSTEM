init();

function init() {
    loadVideos();
}


function loadVideos() {
    ajaxRequest('/Resources/GetVideosByCareer', afterGetVideos, { career: 1 });
}

function afterGetVideos(videos) {

    for (var iterator = 0; iterator < videos.length; iterator++) {
        var video = videos[iterator];
        var firstCol = div('col-md-4').append(img(video.Image, 'img-responsive')),
            secondCol = div('col-md-7').append(header(4, video.Title)).append(span('post-meta', video.Author).append(a('#', '    La vida es bella')))
                .append(div('clear'))
                .append(ul('hb-social').append(li('hb-fb').append(a('#', i('fa fa-facebook'))))
                    .append(li('hb-fb').append(a('#', i('fa fa-twitter'))))
                    .append(li('hb-fb').append(a('#', i('fa fa-plus'))))),
            thirdCol = div('col-md-5').append(ul('m-ico').append(li().append(a('#').addClass('m-ico1')))
                .append(li().append(a('#').addClass('m-ico2')))
                .append(li().append(a('#').addClass('m-ico3'))));

        var elementVideo = div('sermon-content').append(div('row').append(firstCol).append(secondCol).append(thirdCol));

        $('#videos-container').append(elementVideo);
    }
}
