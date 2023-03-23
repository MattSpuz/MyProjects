// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function checkFullness(numOfItems) {
    if (numOfItems == 0) {
        document.getElementById("post").innerHTML = "The table is empty";
        document.getElementById("post").className += "bg-danger";
    }
    else if (numOfItems == 10) {
        document.getElementById("post").innerHTML = "The table is full";
        document.getElementById("post").className += "bg-success";
    }
}
