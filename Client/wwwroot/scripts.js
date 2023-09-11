window.quizFunctions = {
    changeButtonText: function (element) {
        element.classList.add("red-text");
    },
    resetButtonText: function () {
        var eles = document.getElementsByClassName('red-text');
        Array.from(eles).forEach(function (element) {
            element.classList.remove('red-text');
        });
    },
    removeSparaKnapp: function () {
        var knappen = document.getElementById('spara-btn');
        var input = document.getElementById('playerName-input')
        knappen.style.visibility = "hidden";
        input.style.visibility = "hidden";
    },
};