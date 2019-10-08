var table = document.getElementById('table');
console.log(table);
cargarArticulos();

function ajax(url, type, cb, data) {
    const http = new XMLHttpRequest();

    http.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            cb(this.responseText);
        }
    }

    http.open(type, url);
    if (data) {
        http.setRequestHeader("Content-type", "application/json");
        http.send(JSON.stringify(data));
    } else {
        http.setRequestHeader("Content-type", "application/json");
        http.send();
    }
}

function cargarArticulos() {
    ajax('api/Articulos', 'GET', function (res) {
        var articulos = JSON.parse(res);
        var html = '';

        for (let articulo of articulos) {
            html += `<tr>
                        <td>${articulo.Nombre}</td>
                        <td>${articulo.Precio}</td>
                        <td>${articulo.stock}</td>
                    </tr>`;
        }
        table.innerHTML = html;
    });

}