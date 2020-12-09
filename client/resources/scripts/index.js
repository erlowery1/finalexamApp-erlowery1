function GetPasta(){
    const ApiUrl = "https://localhost:5001/api/food";
    /*fetch the url and itll get a response. we want to change that response into json
    and use the json to create the table.*/
    fetch(ApiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        /*border and hover are built into bootstrap and make it prettier*/
        let html = message;
        document.getElementById("message").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}

function GetChicago(){
    const ApiUrl = "https://localhost:5001/api/food/Chicago";
    /*fetch the url and itll get a response. we want to change that response into json
    and use the json to create the table.*/
    fetch(ApiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        /*border and hover are built into bootstrap and make it prettier*/
        let html = message;
        document.getElementById("message").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}

function GetDeepDish(){
    const ApiUrl = "https://localhost:5001/api/food/Deep";
    /*fetch the url and itll get a response. we want to change that response into json
    and use the json to create the table.*/
    fetch(ApiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        /*border and hover are built into bootstrap and make it prettier*/
        let html = message;
        document.getElementById("message").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    });
}