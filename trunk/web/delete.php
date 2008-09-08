<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8"/>
    <title>loci: delete</title>
  </head>
  <body>
<?php
  // create short variable names
  $id=$_REQUEST['id'];
  $lat=$_REQUEST['lat'];
  $lng=$_REQUEST['lng'];

  if (!$id || !$lng || !$lat)
  {
     echo 'You have not entered all the required details.<br />'
          .'Please go back and try again.';
     exit;
  }
  if (!get_magic_quotes_gpc())
  {
    $id = addslashes($id);
	$lat = addslashes($lat);
    $lng = addslashes($lng);
  }

  @ $db = new mysqli('localhost', 'root', '', 'loci', '3306');

  if (mysqli_connect_errno())
  {
     echo 'Error: Could not connect to database.  Please try again later.';
     exit;
  }

  $delete = "delete from map where id=".$id."";
  $result = $db->query($delete);
  if ($result)
      echo  $db->affected_rows.' place removed into database.';

  $db->close();

  echo '<br />';

echo '<a href="';
echo 'search.php?lat=';
echo stripslashes($lat);
echo '&lng=';
echo stripslashes($lng);
echo '">back</a>';
?>
</body>
</html>


