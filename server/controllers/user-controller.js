/*
*/

const User = require('../models/user-model')

//Test
exports.user = function (req, res){
    User.find({user: req.body.user}, function (err, result){
        if(err) {
            res.send('No user found');
        } else {
            res.send(result);
        }
    })
}

exports.create = function(req, res) {
    let user = new User({
        user: req.body.user,
        name: req.body.name,
        password: req.body.password,
        age: req.body.age,
        currentLevel: '1',
        points: '0'
    });

    user.save(function(err){
        if (err) {
            res.send('error');
        } else{
            res.send('Product Created successfully');
        }
    });
}

exports.auth = function(req, res) {
    User.find({
        user: req.body.user,
        password: req.body.password
    }, function(err, result) {
        if (err) {
            res.send({});
        } else if (result) {
            res.send(result);
        } else {
            res.send({});            
        }
    });
}
