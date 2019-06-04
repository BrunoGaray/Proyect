const express = require("express")
const app = express()
app.listen(80);
app.set ('view engine', 'ejs');//Por defecto va a suponer que guardamos nuestras vistas en una carpeta llamda views, y a partir de ahoara va a guardar todo en esa carpeta
app.get ('/', function(req,res){
 res.render('prueba_ejs', {miVariable:Math.random()});//Match.random devuelve numeros al azahar entre cero y uno
});
