<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8"/>
    <title>add racenight user</title>
  </head>
  <body>
<?php

echo 'fuck';
  // create short variable names
  $name=$_GET['name'];
  $phone=$_GET['phone'];
  $address1=$_GET['address1'];
  $address2=$_GET['address2'];
  $email=$_GET['email'];
  $question=$_GET['question'];
  
  if (!$name || !$phone || !$address1 || !$address2 || $email || $question)
  {
     echo 'You have not entered all the required details.<br />'
          .'Please go back and try again.';
     exit;
  }
  
  //protect from sql injections
  if (!get_magic_quotes_gpc())
  {
    $name    = addslashes($name);
	$phone   = addslashes($phone);
	$address1= addslashes($address1);
	$address2= addslashes($address2);
	$email   = addslashes($email);
	$question= addslashes(question);
  }

  @ $db = new mysqli('localhost', 'fc-racenights', 'racenights', 'foodcity_racenights', '3306');

  if (mysqli_connect_errno())
  {
     echo 'Error: Could not connect to database.  Please try again later.';
     exit;
  }

  $query = "insert into racenights (name,phone,address1,address2,email,question) values
            ('','','".$name."', '".$phone."', '".$address1."', '".$address2."', '".$email."', '"$question."')";
  $result = $db->query($query);
  if ($result)
      echo  $db->affected_rows.' place inserted into database.';

  $db->close();

?>
</body>
</html>


