const client = require('../client');

function all() {
  const query = `select * from candidato;`;
  return client.query(query)
}

function select(ci) {
  const query = `select candidato.* from candidato
                where ci = ${ci};`;
  return client.query(query)
}

function selectBy(key, value) {
  const query = `select candidato.* from candidato
                  where ${key} = ${value};`;
  return client.query(query)
}

function insert(candidato) {
  const columns = Object.keys(candidato);
  let values = Object.values(candidato);

  values = values.map(function (candidato) {
    return `'${value}'`;
  })

  const query = `insert into candidato (${columns.join(',')})
                  values (${values.join(',')})
                  returning *;`;

  return client.query(query);
}

function update(ci, candidato) {
  const entries = Object.entries(candidato);

  let query = `update candidato set `;

  entries.forEach(function (key, index) {
    query += `${key[0]} = '${key[1]}'`;

    if (index < entries.length - 1) {
      query += `,`;
    }
  });

  query += `where ci = ${ci} returning *;`;
  return client.query(query);
}

function del(ci) {
  const query = `delete from candidato where ci = ${ci} returning *;`

  return client.query(query);
}

function insertCandidato(data){

  const query = `insert into candidato(mail, ci, sexo, ciudad, rubro, direccion)
                  values('${data.email}','${data.cedula}','${data.sexo}','${data.ciudad}','${data.rubro}','${data.direccion}')`;

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
  insertCandidato,
};
