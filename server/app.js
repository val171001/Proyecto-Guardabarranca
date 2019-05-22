/*
Proyecto Guardabarranca
*/

const express = require('express');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');

// Set up mongoose connection
let url = 'mongodb://127.0.0.1:27017/guardabarranca';
let mongoDB = process.env.MONGODB_URI || url;
mongoose.connect(mongoDB, {useNewUrlParser: true});
mongoose.Promise = global.Promise;
let db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error:'));


const user = require('./routes/user-route')

const app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: false}));
app.use('/user', user)

let port = 3000;

app.listen(port, () => {
    console.log('listening on port ' + port);
});
