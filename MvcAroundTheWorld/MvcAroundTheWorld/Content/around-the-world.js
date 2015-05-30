
var canvas = document.getElementById('TargetCanvas'),
context = canvas.getContext('2d');

make_base();

function make_base() {
    base_image = new Image();
    base_image.src = 'chalkboard-image.jpg';
    base_image.onload = function () {
        context.drawImage(base_image, 100, 100);
    }
}

