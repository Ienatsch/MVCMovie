// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    let imdb_id = $("#imageContainer").data("imdb");

    if (imdb_id) {
        $.getJSON("https://www.omdbapi.com/?i=" + imdb_id + "&apikey=714916ec", function (data) {
            console.log(data);
            $("#movieImage").attr("src", data.Poster);
        });
    }
})