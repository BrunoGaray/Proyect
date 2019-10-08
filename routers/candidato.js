const express = require('express');
const router = express.Router();

const Candidato = require('../queries/candidato');

router.get('/', async function(req, res, next) {
  const result = await Candidato.all().catch(next);
  res.send(result.rows)
});

router.post('/', async function(req, res, next) {
  const candidato = req.body;
  const result = await Candidato.insert(candidato).catch(next);
  res.send(result.rows);
});

router.get('/:ci', async function(req, res, next) {
  const ci = req.params.ci;
  const candidato = await Candidato.select(ci).catch(next);
  res.send({ candidato: candidato.rows[0],});
});

router.put('/:ci', async function(req, res, next) {
  const ci = req.params.ci;
  const candidato = req.body;
  const result = await Candidato.update(ci, candidato).catch(next);
  res.send(result.rows);
});

router.delete('/:ci', async function(req, res, next) {
  const ci = req.params.mail;
  const result = await Candidato.del(ci).catch(next);
  res.send(result.rows);
});
