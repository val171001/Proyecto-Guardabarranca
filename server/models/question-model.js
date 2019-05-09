/*
Proyecto guardabarranca
*/

const mongoose = require('mongoose');
const Schema = mongoose.Schema;

let QuestionSchema = new Schema({
    question: {type: String, required: true},
    answer: {type: String, required: true},    
});

module.exports = mongoose.model('Question', QuestionSchema);
