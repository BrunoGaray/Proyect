const client = require('../client');

function all() {
  const query = `select * from empresa;`;
  return client.query(query)
}

function select(idEmpresa) {
  const query = `select empresa.* from empresa
                where idEmpresa = ${idEmpresa};`;
  return client.query(query)
}

function selectBy(key, value) {
  const query = `select empresa.* from empresa
                  where ${key} = ${value};`;
  return client.query(query)
}

function insert(empresa) {
  const columns = Object.keys(empresa);
  let values = Object.values(empresa);

  values = values.map(function (empresa) {
    return `'${value}'`;
  })

  const query = `insert into empresa (${columns.join(',')})
                  values (${values.join(',')})
                  returning *;`;

  return client.query(query);
}

function update(idEmpresa, empresa) {
  const entries = Object.entries(empresa);

  let query = `update empresa set `;

  entries.forEach(function (key, index) {
    query += `${key[0]} = '${key[1]}'`;

    if (index < entries.length - 1) {
      query += `,`;
    }
  });

  query += `where idEmpresa = ${idEmpresa} returning *;`;
  return client.query(query);
}

function del(idEmpresa) {
  const query = `delete from empresa where mail = ${idEmpresa} returning *;`

  return client.query(query);
}

function insertEmpresa(data){

  const query = `insert into empresa(idEmpresa, nombre, direccion, ciudad, rubro)
                  values('${data.idEmpresa}','${data.nombre}','${data.direccion}','${data.ciudad}','${data.rubro}')`;

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
  insertEmpresa,
};
