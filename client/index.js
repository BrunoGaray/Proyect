const { Client } = require('pg');
const initDB = require('./initDB');

let client = new Client({
  user: 'postgres',
  host: '10.1.2.4',
  database: 'anijobs',
  password: 'root',
  port: 5432,
});

//client = new Client();

client.connect();

initDB(client, function(){
  console.log("Todo Pronto Guacho");
});

module.exports = client
