window.quizFunctions = {
    changeButtonText: function (element) {
        element.classList.add("red-text");
    },
    resetButtonText: function () {
        var eles = document.getElementsByClassName('red-text');
        console.log(eles);
        Array.from(eles).forEach(function (element) {
            element.classList.remove('red-text');
        });
    }
};