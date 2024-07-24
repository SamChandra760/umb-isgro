let videoObserverOptions = {
    root: null,
    threshold: 0.5
}
const videoObserver = new IntersectionObserver(videoObserverCallback, videoObserverOptions);
function videoObserverCallback(entries, videoObserver) {
    entries.forEach(entry => {
        if (!entry.isIntersecting) {
            pauseVideo(entry.target);
            return;
        }
    });
};
function pauseVideo(video) {
    $(video).parent().removeClass("playing");
    video.pause();
}
function playVideo(video) {
    $(video).parent().addClass("playing");
    video.play();
    video.addEventListener("timeupdate", () => {
        let curr = (video.currentTime / video.duration) * 100
        if (video.ended || curr == 100) {
            $(video).parent().removeClass("playing");
        }
    })
}
$(document).ready(function () {
    const videos = document.querySelectorAll(".video_wraper video");
    videos.forEach((videoEle) => {
        videoObserver.observe(videoEle);
    });
    $(".video_wraper .play").on('click', function (event) {
        event.stopPropagation();
        event.stopImmediatePropagation();
        playVideo($(this).parent().find("video")[0]);
    });
});