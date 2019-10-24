const express = require('express');
const router = express.Router();

const Empresa = require('../queries/empresa');

router.get('/', async function(req, res, next) {
  const result = await Empresa.all().catch(next);
  res.send(result.rows)
});

router.post('/', async function(req, res, next) {
  const empresa = req.body;
  const result = await Empresa.insert(empresa).catch(next);
  res.send(result.rows);
});

router.get('/:idEmpresa', async function(req, res, next) {
  const idEmpresa = req.params.idEmpresa;
  const empresa = await Empresa.select(idEmpresa).catch(next);
  res.send({ empresa: empresa.rows[0],});
});

router.put('/:idEmpresa', async function(req, res, next) {
  const idEmpresa = req.params.idEmpresa;
  const empresa = req.body;
  const result = await Empresa.update(idEmpresa, Empresa).catch(next);
  res.send(result.rows);
});

router.delete('/:idEmpresa', async function(req, res, next) {
  const idEmpresa = req.params.idEmpresa;
  const result = await Empresa.del(idEmpresa).catch(next);
  res.send(result.rows);
});
