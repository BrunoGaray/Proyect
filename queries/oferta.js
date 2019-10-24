const client = require('../client');

function all() {
  const query = `select * from oferta;`;
  return client.query(query)
}

function select(numserie) {
  const query = `select oferta.* from oferta
                where numSerie = ${numserie};`;
  return client.query(query)
}

function selectBy(key, value) {
  const query = `select oferta.* from oferta
                  where ${key} = ${value};`;
  return client.query(query)
}

function insert(oferta) {
  const columns = Object.keys(oferta);
  let values = Object.values(oferta);

  values = values.map(function (oferta) {
    return `'${value}'`;
  })

  const query = `insert into oferta (${columns.join(',')})
                  values (${values.join(',')})
                  returning *;`;

  return client.query(query);
}

function update(numserie, oferta) {
  const entries = Object.entries(oferta);

  let query = `update oferta set `;

  entries.forEach(function (key, index) {
    query += `${key[0]} = '${key[1]}'`;

    if (index < entries.length - 1) {
      query += `,`;
    }
  });

  query += `where numSerie = ${numserie} returning *;`;
  return client.query(query);
}

function del(numserie) {
  const query = `delete from oferta where numSerie = ${numserie} returning *`;

  return client.query(query);
}

  async function buscarOferta(data){
  
    const query = `select * from oferta where puesto = '${data.puesto}' AND area = '${data.area}'`;
    console.log(query);
     /*router.post('/buscaroferta',function(req,res){
      res.sendFile (__dirname+'/Inicio.html');
      console.log(req.body);
    });*/

    client.query(query, (error, result) => {
      console.log(result)
    })

    let result = await client.query(query);

    console.log('result', result.rows);
    

    //res.render('listarofertas', { oferta: filas });

    console.log(query)
  

    return result.rows;
  }

  
  function insertOferta(data){
    
      const query = `insert into oferta(numSerie, sueldo, requisitos, area, puestosVacantes, descripcion, edadRequerida, puesto)
                      values('${data.numSerie}','${data.sueldo}','${data.requisitos}','${data.area}','${data.puestosVacantes}',
                      '${data.descripcion}', '${data.edadRequerida}','${data.puesto}')`;
    
      console.log(query)
    
      return client.query(query);
    }

module.exports = {
  all,
  select,
  selectBy,
  insert,
  update,
  del,
  buscarOferta,
  insertOferta,
};
