// JavaScript source code
const express = require('express');
const router = express.Router();
const Candidato = require('./queries/candidato');
const Usuario = require('./queries/usuario');
const Empresa = require('./queries/empresa');
const bodyParser = require('body-parser');

router.use(bodyParser.json());
router.use(bodyParser.urlencoded());

router.get('/',function(req,res){
	res.sendFile (__dirname+'/views/Inicio.html');
});

router.get('/cambiosdeusuario',function(req,res){
	res.sendFile (__dirname+'/views/CambiosDeUsuario.html');
});

router.get('/activarodesactivarcurriculum',function(req,res){
	res.sendFile (__dirname+'/views/CurriculumActDesc.html');
});

router.get('/curriculum',function(req,res){
	res.sendFile (__dirname+'/views/CV.html');
});

router.get('/editarcurriculum',function(req,res){
	res.sendFile (__dirname+'/views/CVEdit.html');
});

router.get('/formulariodeverificacion',function(req,res){
	res.sendFile (__dirname+'/views/FormularioVerificacion.html');
});

router.get('/invitaciones',function(req,res){
	res.sendFile (__dirname+'/views/Invitaciones.html');
});

router.get('/invitarcandidato',function(req,res){
	res.sendFile (__dirname+'/views/InvitarCandidato.html');
});

router.get('/missolicitudes',function(req,res){
	res.sendFile (__dirname+'/views/MisSolicitudes.html');
});

router.get('/mistestinvitaciones',function(req,res){
	res.sendFile (__dirname+'/views/MisTestInvitaciones.html');
});

router.get('/oferta',function(req,res){
	res.sendFile (__dirname+'/views/Oferta.html');
});

router.get('/ofertamisinvitaciones',function(req,res){
	res.sendFile (__dirname+'/views/OfertasMisInvitaciones.html');
});

router.get('/ofertasmisofertas',function(req,res){
	res.sendFile (__dirname+'/views/MisTestInvitaciones.html');
});

router.get('/ofertasquepublique',function(req,res){
	res.sendFile (__dirname+'/views/OfertasQuePublique.html');
});

router.get('/perfilcandidato',function(req,res){
	res.sendFile (__dirname+'/views/PerfilCandidato.html');
});

router.get('/perfilgestorempresa',function(req,res){
	res.sendFile (__dirname+'/views/PerfilGestorEmpresa.html');
});

router.get('/postular',function(req,res){
	res.sendFile (__dirname+'/views/Postular.html');
});

router.get('/registroempresa',function(req,res){
	res.sendFile (__dirname+'/views/registroEmpresa.html');
});

router.get('/solicitud',function(req,res){
	res.sendFile (__dirname+'/views/Solicitud.html');
});

router.get('/testdecompetencia',function(req,res){
	res.sendFile (__dirname+'/views/TestDeCompetencia.html');
});

router.get('/iniciarsesion', function(req, res) {
	res.sendfile (__dirname+'/views/IniciarSesion.html');
});

router.get('/registrousuario',function(req,res){
	res.sendFile (__dirname+'/Registro.html');
});

router.get('/iniciousuario',function(req,res){
	res.sendFile (__dirname+'/views/inicioUsuario.html');
});

router.get('/test', async function(req, res) {
	let c = await Candidato.all();
	res.json(c.rows);
});

router.get('/test', async function(req, res) {
	let u = await Usuario.all();
	res.json(u.rows);
});

router.post('/registrousuario',function(req,res){
	//res.sendFile (__dirname+'/Registro.html');
	console.log(req.body);
});

router.post('/registroempresa',function(req,res){
	//res.sendFile (__dirname+'/Registro.html');
	console.log(req.body);
});

module.exports = router;
