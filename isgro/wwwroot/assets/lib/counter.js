let counterObserverOptions = {
    root: null,
    threshold: 0.5
}

var counterObserver = new IntersectionObserver(counterObserverCallback, counterObserverOptions);

function counterObserverCallback(entries, counterObserver) {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            startCounter(entry.target);
            return;
        }
    });
};


function startCounter(counter){
    const _data = Number($(counter).data("val"));
    const _height = $(counter).height();
    if ($(counter).hasClass("started")) {
        return;
    }
    const _transform = _height * (_data - 1);
    $(counter).addClass("started");
    $(counter).html(`<span class="counter-data" style="text-align: center;
    position: absolute;left:0;right:0;
    transition-property: transform;
    transition-duration: 1s;
    transition-timing-function: linear;">${getCounterHtml(_data)}</span>`);
    setTimeout(() => {
        $(counter).find('.counter-data').css('transform', `translateY(-${_transform}px)`);
    },200)
}
function getCounterHtml(number) {
    let _content = '';
    for (let i = 0; i < Number(number); i++) {
        _content += `${i + 1}<br>`;
    }
    return _content;
}
$(document).ready(function () {
    const counters = document.querySelectorAll(".counter");
    counters.forEach((counterEle) => {
        counterObserver.observe(counterEle);
    });
});