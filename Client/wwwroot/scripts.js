window.quizFunctions = {
    changeButtonText: function (element) {
        element.classList.add("red-text");
    },
    correctAnswerText: function (element) {
        element.classList.add("green-text");
    },
    resetButtonText: function () {
        var eles = document.getElementsByClassName('red-text');
        Array.from(eles).forEach(function (element) {
            element.classList.remove('red-text');
        });
        var eles = document.getElementsByClassName('green-text');
        Array.from(eles).forEach(function (element) {
            element.classList.remove('green-text');
        });
    },
    removeSparaKnapp: function () {
        var knappen = document.getElementById('spara-btn');
        knappen.style.visibility = "hidden";
    },    
};

    


    
