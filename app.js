const express = require('express');
const app = express();
app.use(express.urlencoded());
app.listen(80);
let mensajes = [];
app.set ('view engine', 'ejs');
app.get('/', function(req,res){
  res.sendFile (__dirname+'/Index.html');
});

//app.post('/mensaje', function(req,res){
  //datosForm = req.body;
  //mensajes.push(datosForm);
  //res.send(mensajes);
  //console.log(datosForm); Devuelve datos en consola
  //res.send(datosForm);
//});

app.post('/mensaje', function(req,res){
  let mensaje = {autor:req.body.autor,
                texto:req.body.texto
              }
                mensajes.push(mensaje);
                res.redirect('/mensajes');
});
//app.get('/mensajes', function(req,res) {
  //res.send(mensajes);
//});

//app.get("/mensajes", function(req,res){
  //res.write("<html><body>")
  //mensajes.forEach(function(m){
    //res.write("<div class='msg'>");
    //res.write("<div class ='autor'>");
    //res.write(m.autor);
    //res.write("</div>");
    //res.write("<div class ='texto'>");
    //res.write(m.texto);
    //res.write("</div>");
    //res.write("</div>");
  //});
  //res.end("</body></html>")
//});
app.get("/mensajes", function(req, res){
  res.render('mensaje_ejs', { mensajes: mensajes });
});
