const express = require('express');
const bodyParser = require('body-parser');
const router = require('./ruta');

const Candidato = require('./queries/candidato');
const Usuario = require('./queries/usuario');
const Empresa = require('./queries/empresa');
const Oferta = require('./queries/oferta');

const PORT = 3000;

const app = express();

app.use(bodyParser.json());
app.use(bodyParser.urlencoded());
app.use(router);
app.use(express.static('views'));

app.listen(PORT, function(err) {
  if(err) throw err;
  console.log(`Servidor escuchando en puerto ${PORT}`)
});

//app.get("/Registro.html", async function(req, res) {
//  let candidatos = await Candidato.insert();
//  console.log(candidatos);
//  res.send(candidatos.rows);
//});

/*app.post("/candidato", async function(req, res){
  let info = req.body;
  console.log(req.body);
  console.log('hola')
  Candidato.insertCandidato(info).then(() => {
    console.log('ejecutado con exito')
  }).catch(err => {
    console.log('errorrrrr')
    console.log(err)
  });
});*/

app.post("/usuario", async function(req, res){
  let info = req.body;
  // console.log(req.body);
  Usuario.insertUsuario(info).then(() => {
    console.log('ejecutado con exito')
  }).catch(err => {
    console.log('errorrrrr')
    console.log(err)
  });
});

app.post("/buscaroferta", async function(req, res){
  let info = req.body;
  // console.log(req.body);
  Oferta.buscarOferta(info).then(() => {
    // console.log('ejecutado con exito')
  }).catch(err => {
  console.log('errorrrrr')
    console.log(err)
  });

  let ofertas = await Oferta.buscarOferta(info);
  // console.log('ofertas => ',ofertas);
  res.send(ofertas);
});

app.post("/oferta", async function(req, res){
  let info = req.body;
  // console.log(req.body);
  Oferta.insertOferta(info).then(() => {
    console.log('ejecutado con exito')
  }).catch(err => {
    console.log('errorrrrr')
    console.log(err)
  });
});

app.post("/empresa", async function(req, res){
  let info = req.body;
  // console.log(req.body);
  Empresa.insertEmpresa(info).then(() => {
    console.log('ejecutado con exito')
  }).catch(err => {
    console.log('errorrrrr')
    console.log(err)
  });
});

/*app.post("/registrocandidato", async function(req, res){
  let info = req.body;
  Candidato.insertCandidato(info);
  console.log(req.body);
});*/

//app.post("/registrousuario", async function(req, res){
  //let info = req.body;
  //Usuario.insertUsuario(info);
  //console.log(req.body);
//});
