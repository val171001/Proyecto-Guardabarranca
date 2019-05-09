/*
Proyecto Guardabarranca
*/

const express = require('express');
const router = express.Router();

const user_controller = require('../controllers/user-controller');

router.get('/info', user_controller.user);
router.post('/signup',user_controller.create);
router.get('/login', user_controller.auth);

module.exports = router;
