<?php
require "Auth.php";
$auth = new Auth();

$login = $_POST['login'];
$pwrd = $_POST['pwrd'];
$email = $_POST['email'];
echo $auth->register($login, $email, $pwrd);
?>
