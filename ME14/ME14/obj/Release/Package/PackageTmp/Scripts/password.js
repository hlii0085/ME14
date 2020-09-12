var password = "";
password = prompt('Please Enter the Password(Only If You Enter the Correct Password):', '');

while (password != '334455') {
    alert("Wrong Password");
    password = prompt('Please Enter the Password(Only If You Enter the Correct Password):', '');

    //window.opener = null; window.close();
}