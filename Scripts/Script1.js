// JavaScript source code
const express = require('express')
let app = express();
app.listen (80, function() {
	console.log ("Escuchoenpuerto 80");
});

app.get ('*', function(req,res,next){
	console.log(req.ip);
	next();
	});

app.get ('/spanish', function(req,res){
	res.send("Hola Mundo!");
	});

app.get ('/english', function(req,res){
	res.send("Hello");
	});

app.get ('*', function(req,res){
	res.send("ruta invalida");
	});

