// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showProjects() {
    $(".hover").css({
        display: "block"
    })
}

function hideProjects() {
    $(".hover").css({
        display: "none"
    })
}
$("#projects").hover(showProjects, hideProjects)

//$(document).ready(function () {
//    $('#Carousel').carousel({
//        interval: 5000
//    })
//});