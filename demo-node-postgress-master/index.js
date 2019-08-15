const express = require('express');
const bodyParser = require('body-parser');
const app = express();
const { Client } = require('pg');
const initDB = require('./initDB');

const client = new Client({
  user: 'postgres',
  //host: '127.0.0.1',
  database: 'AniJobs',
  password: 'root',
  //port: 5432,
});

client.connect();
initDB(client, function(){
  console.log("Todo pronto guacho");
});

app.listen(80);

app.get('/categorias', function(req, res){
  selectCategorias(function(err, result) {
    res.send(result);
  });
});

app.get('/candidato', function(req, res){
  selectCandidato(function(err, result) {
    res.send(result);
  });
});

//app.get('/curriculum', function(req, res){
  //selectCurriculum(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/empresa', function(req, res){
  //selectEmpresa(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/envia', function(req, res){
  //selectEnvia(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/gestorempresa', function(req, res){
  //selectGestorEmpresa(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/invitaciones', function(req, res){
  //selectInvitaciones(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/oferta', function(req, res){
  //selectOferta(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/postula', function(req, res){
  //selectPostula(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/privacidad', function(req, res){
  //selectPrivacidad(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/publica', function(req, res){
  //selectPublica(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/recibe', function(req, res){
  //selectRecibe(function(err, result) {
    //res.send(result);
  //});
//});

//app.get('/usuario', function(req, res){
  //selectUsuario(function(err, result) {
    //res.send(result);
  //});
//});
//app.get('/categorias/:id', function(req, res){
//  const id = req.params.id;
  //selectCategoria(id, function(err, result) {
//    res.send(result);
////  });
//});

//app.get('/categorias/:id/cosas', function(req, res){
  //const id = req.params.id;
  //selectCosas(id, function(err, result){
    //res.send(result);
  //});
//});

function selectCategorias(callback) {
  const query = `select * from categorias;`;
  client.query(query, callback)
}

function selectCategoria(id, callback) {
  const query = `select categorias.* from categorias
                where id = ${id};`;
  client.query(query, callback)
}

function selectCosas(categoria_id, callback) {
  const query =   `select cosas.nombre from cosas
                  inner join cosas_categorias on cosas_categorias.cosa_id=cosas.id
                  where cosas_categorias.categoria_id=${categoria_id};`
  client.query(query, callback);
}
//------------------------------------------------------------------------------

function selectCandidatos(callback) {
  const query = `select * candidato`
  client.query(query, callback)
}
        function selectCandidato(nombre, callback) {
          const query = `select candidato.* from candidato
                        where nombre = ${nombre};`;
          client.query(query, callback)
        }

        function selectCandidato(sexo, callback) {
          const query = `select candidato.* from candidato
                        where sexo = ${sexo};`;
          client.query(query, callback)
        }

        function selectCandidato(ciudad, callback) {
          const query = `select candidato.* from candidato
                        where ciudad = ${ciudad};`;
          client.query(query, callback)
        }

        function selectCandidato(rubro, callback) {
          const query = `select candidato.* from candidato
                        where rubro = ${rubro};`;
          client.query(query, callback)
        }

        function selectCandidato(direccion, callback) {
          const query = `select candidato.* from candidato
                        where direccion = ${direccion};`;
          client.query(query, callback)
        }

        function selectCandidato(idcurriculum, callback) {
          const query = `select candidato.* from candidato
                        where idcurriculum = ${idcurriculum};`;
          client.query(query, callback)
        }

        function selectCandidato(ci, callback) {
          const query = `select candidato.* from candidato
                        where ci = ${ci};`;
          client.query(query, callback)
        }

        function selectCandidato(mail, callback) {
          const query = `select candidato.* from candidato
                        where mail = ${mail};`;
          client.query(query, callback)
        }


function selectCurriculums(callback) {
  const query = `select * curriculum`
  client.query(query, callback)
}
        function selectCurriculum(mail, callback) {
          const query = `select candidatos.* from candidatos
                        where mail = ${mail};`;
          client.query(query, callback)
        }

function selectEmpresa(callback) {
  const query = `select * empresa`
  client.query(query, callback)
}

function selectCandidato(callback) {
  const query = `select * candidato`
  client.query(query, callback)
}

function selectEnvia(callback) {
  const query = `select * envia`
  client.query(query, callback)
}

function selectGestorEmpresa(callback) {
  const query = `select * gestorempresa`
  client.query(query, callback)
}

function selectInvitaciones(callback) {
  const query = `select * invitaciones`
  client.query(query, callback)
}

function selectOferta(callback) {
  const query = `select * oferta`
  client.query(query, callback)
}

function selectPostula(callback) {
  const query = `select * postula`
  client.query(query, callback)
}

function selectPrivacidad(callback) {
  const query = `select * privacidad`
  client.query(query, callback)
}

function selectPublica(callback) {
  const query = `select * publica`
  client.query(query, callback)
}

function selectRecibe(callback) {
  const query = `select * recibe`
  client.query(query, callback)
}

function selectUsuario(callback) {
  const query = `select * usuario`
  client.query(query, callback)
}
