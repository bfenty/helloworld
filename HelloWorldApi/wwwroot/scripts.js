function sendKey(key) {
    fetch(`/roku/${key}`, {
        method: 'GET'
    }).then(response => {
        if (!response.ok) {
            alert("Command failed.");
        }
    });
}
