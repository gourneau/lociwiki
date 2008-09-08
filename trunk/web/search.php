<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8"/>
    <title>loci: search places</title>
  </head>
  <body>
<?php
  // create short variable names
  $lat=$_REQUEST['lat'];
  $lng=$_REQUEST['lng'];

  if (!$lat || !$lng)
  {
     echo 'Please click reload';
     exit;
  }
  
  if (!get_magic_quotes_gpc())
  {
    $lat = addslashes($lat);
    $lng = addslashes($lng);
  }
  
  //connect to the database
  @ $db = new mysqli('localhost', 'root', '', 'loci', '3306');

  if (mysqli_connect_errno())
  {
     echo 'Error: Could not connect to database.  Please try again later.';
     exit;
  }

	echo "lat: ".$lat." <br /> lng: ".$lng."<p />";

  $query = "select * from map where lat = ".$lat." and lng = ".$lng." ";
  
  $range_query = "SELECT *, (acos(sin(radians(".$lat.")) * sin(radians(Lat)) + cos(radians(".$lat.")) 
					* cos(radians(Lat)) * cos(radians(".$lng." - Lng))))
					* 6371 as dist FROM map order by dist asc limit 5";

  $result = $db->query($range_query);

  $num_results = $result->num_rows;
	
  if ($num_results !=0){
	for ($i=0; $i <$num_results; $i++)
	{
		$row = $result->fetch_assoc();
		echo '<p><strong> ';
		echo htmlspecialchars(stripslashes($row['title']));
		echo '</strong><br />';
		echo stripslashes($row['dist']);
		echo " miles ";
		echo ' (lat: ';
		echo stripslashes($row['lat']);
		echo ', lng: ';
		echo stripslashes($row['lng']);
		echo ') <br />msg: ';
		echo stripslashes($row['msg']);
		echo '<br /><a href="edit.php?id=';
		echo stripslashes($row['id']);
		echo '">edit</a> | <a href="delete.php?id=';
		echo stripslashes($row['id']);
		echo '&lat=';
		echo stripslashes($row['lat']);
		echo '&lng=';
		echo stripslashes($row['lng']);
		echo '">delete</a>	</p>';
	}
  }else{
	
	//if there are no entries for this location allow the user to add 
	
	echo "There is no data for this location. <br /> lat: ".$lat." lng: ".$lng." <p />";
}
	echo "add location info:<p />";
	$add_url= "add.php?lat=".$lat."&lng=".$lng."";
	echo '<form action="';
	echo stripslashes($add_url);
	echo '" method="post">';
?>


  <table border="0">
    <tr>
      <td>title</td>
       <td><input type="text" name="title" maxlength="13" size="13"></td>
    </tr>
    <tr>
      <td>msg</td>
      <td> <input type="text" name="msg" maxlength="30" size="30"></td>
    </tr>
      <td colspan="2"><input type="submit" value="add place"></td>
    </tr>
  </table>
</form>

<?php
  

  $result->free();
  $db->close();

?>
</body>
</html>