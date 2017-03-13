function loadQuestion()
{
    $.get("/Api/Questions/1", function (data) {
        console.log(data);
        $("#Question").text(data.QuestionText);
        $("#Answer1").text(data.Answer1Text);
        $("#Answer2").text(data.Answer2Text);
    });
}

$(function () {
    loadQuestion();
});

