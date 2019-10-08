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

  let query = `update candidato set `;

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
  const query = `delete from oferta where numSerie = ${numserie} returning *;`

  return client.query(query);
}

module.exports = {
  all,
  select,
  selectBy,
  insert,
  update,
  del,
};
