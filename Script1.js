// JavaScript source code
const express = require('express');
const app = express();
app.use(express.urlencoded());
app.listen(80);


app.set ('view engine', 'ejs')
app.get('/',function(req,res){
	res.sendFile (__dirname+'/views/Inicio.html');
});

app.get('/registro',function(req,res){
	res.sendFile (__dirname+'/views/Registro.html');
});

app.get('/micuenta',function(req,res){
	res.sendFile (__dirname+'/views/Micuenta.html');
});

app.get('/listabusqueda',function(req,res){
	res.sendFile (__dirname+'/views/Listabuusqueda.html');
});

app.get('/postular',function(req,res){
	res.sendFile (__dirname+'/views/Postular.html');
});