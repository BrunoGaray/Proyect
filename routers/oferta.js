const express = require('express');
const router = express.Router();

const Oferta = require('../queries/oferta');

router.get('/', async function(req, res, next) {
  const result = await Oferta.all().catch(next);
  res.send(result.rows)
});

router.post('/', async function(req, res, next) {
  const oferta = req.body;
  const result = await Oferta.insert(oferta).catch(next);
  res.send(result.rows);
});

router.get('/:numserie', async function(req, res, next) {
  const numserie = req.params.numserie;
  const oferta = await Oferta.select(numserie).catch(next);
  res.send({ oferta: oferta.rows[0],});
});

router.put('/:oferta', async function(req, res, next) {
  const oferta = req.params.oferta;
  const oferta = req.body;
  const result = await Oferta.update(numserie, Oferta).catch(next);
  res.send(result.rows);
});

router.delete('/:numserie', async function(req, res, next) {
  const numserie = req.params.numserie;
  const result = await Oferta.del(numserie).catch(next);
  res.send(result.rows);
});
