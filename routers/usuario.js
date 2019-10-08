const express = require('express');
const router = express.Router();

const Usuario = require('../queries/usuario');

router.get('/', async function(req, res, next) {
  const result = await Usuario.all().catch(next);
  res.send(result.rows)
});

router.post('/', async function(req, res, next) {
  const usuario = req.body;
  const result = await Usuario.insert(usuario).catch(next);
  res.send(result.rows);
});

router.get('/:mail', async function(req, res, next) {
  const mail = req.params.mail;
  const usuario = await Usuario.select(mail).catch(next);
  res.send({ usuario: usuario.rows[0],});
});

router.put('/:mail', async function(req, res, next) {
  const mail = req.params.ci;
  const usuario = req.body;
  const result = await Usuario.update(mail, Usuario).catch(next);
  res.send(result.rows);
});

router.delete('/:mail', async function(req, res, next) {
  const mail = req.params.mail;
  const result = await Usuario.del(mail).catch(next);
  res.send(result.rows);
});
