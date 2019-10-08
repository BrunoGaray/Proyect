const client = require('../client');

function all() {
  const query = `select * from usuario;`;
  return client.query(query)
}

function select(mail) {
  const query = `select usuario.* from usuario
                where mail = ${mail};`;
  return client.query(query)
}

function selectBy(key, value) {
  const query = `select usuario.* from usuario
                  where ${key} = ${value};`;
  return client.query(query)
}

function insert(usuario) {
  const columns = Object.keys(usuario);
  let values = Object.values(usuario);

  values = values.map(function (usuario) {
    return `'${value}'`;
  })

  const query = `insert into usuario (${columns.join(',')})
                  values (${values.join(',')})
                  returning *;`;

  return client.query(query);
}

function update(mail, usuario) {
  const entries = Object.entries(usuario);

  let query = `update usuario set `;

  entries.forEach(function (key, index) {
    query += `${key[0]} = '${key[1]}'`;

    if (index < entries.length - 1) {
      query += `,`;
    }
  });

  query += `where mail = ${mail} returning *;`;
  return client.query(query);
}

function del(mail) {
  const query = `delete from usuario where mail = ${mail} returning *;`

  return client.query(query);
}

function insertUsuario(data){

  const query = `insert into usuario(mail, nombre, apellido, contrasenia, telefono, fechanac)
                  values('${data.email}','${data.nombre}','${data.apellido}','${data.contraseña}','${data.telefono}','${data.fechanac}')`;

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
  insertUsuario,
};
