﻿$(document).ready(function () {
    $("#btnReset").click(function (event) {

        event.preventDefault();
        var obj_reset = new Object();
        obj_reset.Email = $("#inputEmail").val();

        if ($("#inputEmail").val() == "") {
            document.getElementById("inputEmail").className = "form-control is-invalid";
            $("#msgEmail").html("Email can't be empty");
        } else {
            document.getElementById("inputEmail").className = "form-control is-valid";
            obj_reset.ID = $("#inputEmail").val();
            $.ajax({
                url: "/ForgotPasswords/forgotpass",
                method: 'PUT',
                dataType: 'json',
                contentType: 'application/x-www-form-urlencoded',
                data: obj_reset,
                beforeSend: function () {
                    Swal.fire({
                        title: "Checking...",
                        text: "Please wait",
                        imageUrl: "https://c.tenor.com/5o2p0tH5LFQAAAAi/hug.gif",
                        imageWidth: 200,
                        imageHeight: 200,
                        imageAlt: 'Custom image',
                        showConfirmButton: false,
                        allowOutsideClick: false
                    })
                },
                success: function (data) {
                    Swal.fire({
                        title: 'Password Baru Anda Dikirim ke Email!',
                        text: 'Press Any Button to Continue',
                        icon: 'success',
                        confirmButtonText: 'Okay'
                    }).then(function () {
                        window.location = "/logins/login-page";
                        /*          document.location = Url.Action("login-page","Logins");*/
                    })
                },
                error: function (xhr, status, error) {
                    console.log(xhr.responseJSON.errors);
                    if (xhr.responseJSON.errors != undefined) {

                        checkValid(xhr.responseJSON.errors.Email, "inputEmail", "#msgEmail");

                    }

                }
            })

        }
      

    });

});