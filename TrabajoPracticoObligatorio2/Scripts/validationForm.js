const name = document.getElementById('name');
const email = document.getElementById('email');
const phone = document.getElementById('phone');
const message = document.getElementById('message');

const form = document.getElementById('contactForm');

const errorMessages = document.getElementById('errorMessages');

const ck_alphanumerics = /^[A-Za-z0-9-]/;

form.addEventListener('submit', (e) => {
    let messages = [];

    if (name.value === '' || name.value == null)
        messages.push("Name field its empty");

    else if (name.value.length < 4 && ck_alphanumerics.test(name.value.length)) {
        messages.push("The name can only contain alphanumeric characters");
        messages.push("The name its too short");
    }


    else if (name.value.length > 30 && ck_alphanumerics.test(name.value.length)) {
        messages.push("The name its too long");
        messages.push("The name can only contain alphanumeric characters");
    }




    if (email.value === '' || email.value == null)
        messages.push("Email field its empty");

    else if (!validateEmail(email.value)) {
        messages.push("Enter a valid mail")
    }

    if (phone.value === '' || phone.value == null)
        messages.push("Business field its empty");

    else if (phone.value.length > 20) {
        messages.push("Business message cannot be more than 20 characters")
    }

    if (message.value === '' || message.value == null)
        messages.push("Message field its empty");

    else if (message.value.length < 10) {
        messages.push("Message its too short")
    }

    else if (message.value.length > 100) {
        messages.push("Message its too long")
    }

    var formatTextError = "<ul>"
    if (messages.length > 0) {
        e.preventDefault();
        for (let index = 0; index < messages.length; index++) {
            const element = messages[index];

            formatTextError += "<li>" + element + "</li>";

        }

        errorMessages.innerHTML = formatTextError;

    }

});

function validateEmail(email) {
    var re = /\S+@\S+\.\S+/;
    return re.test(email);
}       