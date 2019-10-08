# Template de servidor API utilizando node.js y express
Este template muestra una posible manera de organizar un proyecto de un servidor API capaz de interactuar con una base de datos postgres. Las dependencias que se utilizan on:
- `express` - Para el servidor.
- `pg` - Para la conexión con la BD.
- `body-parser` - Para interpretar los campos de las peticiones HTTP.
- `nodemon` - Reinicia el servidor ante cambios en el código, muy útil durante las etapas de desarrollo.
## Inicializacion
- Clonar el repo `git clone https://github.com/FabioLG1989/demo-node-postgress.git`
- Instalar las dependencias `npm install`
## Estructura
```
├── README.md
├── client
│   ├── index.js
│   └── initDB.js
├── index.js
├── package-lock.json
├── package.json
├── public
│   └── styles
│       ├── categorias.css
│       └── index.css
├── queries
│   ├── categorias.js
│   └── cosas.js
├── routers
│   ├── categorias.js
│   └── cosas.js
└── views
    ├── categoria.ejs
    └── categorias.ejs
```
- `client`: El archivo `index.js` contiene la inicializacion del cliente de la BD, en este archivo se especifican las configuraciones de la BD. Exporta el cliente conectado. El archivo `initDB.js` es un script que crea datos de prueba en la BD, este archivo no debería estar en el proyecto final.
- `public`: Carpeta donde el servidor express busca archivos estáticos.
- `queries`: Se dividen en archivos por cada modelo, cada archivo contiene y exporta las funciones necesarias para acceder a datos a la BD. Estas funciones pueden ser: insert, delete, update, select, y también operaciones más complejas.
- `routers`: Rutas de acceso para cada modelo, separadas en archivos individuales. Para cada modelo se especifica una lista de rutas aceptadas y desde cada una de ellas se llama a las funciones de `queries`. Estos ruteos son luego montados con un prefijo en la aplicación principal.
- `views`: Carpeta donde el servidor express busca archivos dinámicos (.ejs).
## Uso de routers
https://expressjs.com/en/api.html#router <-- Documentación oficial.

A continuacion se muestra un extracto de código del inicio de `routers/categorias.js`, donde se declara un objeto `router = express.Router()`. Este objeto funciona como una sub aplicación que luego puede ser añadida a nuestra app de express. 
```javascript
const express = require('express');
const router = express.Router();

const Categorias = require('../queries/categorias');

router.get('/', async function(req, res, next) {
  const result = await Categorias.all().catch(next);
  res.send(result.rows)  
});
```
Observar también que se utiliza el objeto `Categorias`, exportado desde las queries. Este objeto contiene las funciones necesarias para acceder a la informacion de categorías en la BD.
Observar la línea `Categorias.all().catch(next);`, en esta línea se introduce un elemento nuevo `catch()` que se llama cuando hay un error en la query a la BD (se explicará más adelante cuando se vean las *promesas*). La función de `catch(next)` es tomar el error y pasarlo a la próxima ruta que corresponda, esta ruta se declara al final del archivo:
```javascript
router.all('*', function (err, req, res, next) {
  if (err) { 
    res.send(err);
  } else {
    res.send();
  }
});
```
La función de esta ruta es envíar el mensaje de error al usuario y evitar que la aplicación crashee.

También existen dos elementos más que no hemos visto `async` (antes de delcarar la función), y `await` al llamar a `Categorias.all()`. Esto se explicará cuando se vean las *promesas*.

### Montaje de los routers

Una vez que tenemos declarados los routers de nuestros modelos podemos montarlos en la aplicación principal, en el archivo `index.js` tenemos:
```javascript
const express = require('express');

const routerCategorias = require('./routers/categorias');
const routerCosas = require('./routers/cosas');

const app = express();

app.use('/categorias', routerCategorias);
app.use('/cosas', routerCosas);
```
De esta manera, toda ruta que inicie con `/categorias` se dirigirá al router definido en `routers/categorias.js` y toda ruta que inicie con `/cosas` se dirigirá al router definido en `routers/cosas.js`.

## Promesas
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise <-- Documentación oficial
https://platzi.com/blog/que-es-y-como-funcionan-las-promesas-en-javascript/ <-- Español

#### TODO

## async/await
#### TODO
