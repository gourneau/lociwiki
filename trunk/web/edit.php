<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8"/>
    <title>loci: edit places</title>
  </head>
  <body>
<?php
  // create short variable names
  $id=$_REQUEST['id'];
  $save=$_REQUEST['save'];
  $title=$_REQUEST['title'];
  $msg=$_REQUEST['msg'];


  if (!$id)
  {
     echo 'You have not entered id info.  Please go back and try again.';
     exit;
  }
  
  if (!get_magic_quotes_gpc())
  {
    $id = addslashes($id);
  }
  
  //connect to the database
  @ $db = new mysqli('localhost', 'root', '', 'loci', '3306');

  if (mysqli_connect_errno())
  {
     echo 'Error: Could not connect to database.  Please try again later.';
     exit;
  }

  //if y flag was sent then write the info to the database
  if ($save == "y")
	{
      $update = "update map SET title='".$title."',msg='".$msg."' where id=".$id." ";
	  $db->query($update);
	  echo "Update Made!<p />";
	}


  $query = "select * from map where id = ".$id." ";

  $result = $db->query($query);

  $num_results = $result->num_rows;

	for ($i=0; $i <$num_results; $i++)
	{
		$row = $result->fetch_assoc();

		//if there are no entries for this location allow the user to add 
		$edits_url= "edit.php?id=".$id."&save=y";

		echo "Edit data for: <br /> lat: ".stripslashes($row['lat'])." lng: ".stripslashes($row['lng'])." <p /> ";
		echo '<form action="';
		echo stripslashes($edits_url);
		echo '" method="post">';

?>
		  <table border="0">
		    <tr>
		      <td>title</td>
		       <td><input type="text" name="title" maxlength="255" size="13" value="<?php echo stripslashes($row['title']); ?>"></td>
		    </tr>
		    <tr>
		      <td>msg</td>
		      <td> <input type="text" name="msg" maxlength="10000" size="30" value="<?php echo stripslashes($row['msg']); ?>"></td>
		    </tr>
			<tr>	
			<td colspan="2"><input type="submit" value="save edit"></td>
			  </form>
			</tr>  
			  

<tr><td colspan="2">		


<?php
echo '<a href=';
echo 'search.php?lat=';
echo stripslashes($row['lat']);
echo '&lng=';
echo stripslashes($row['lng']);
echo '>back</a>';

	}

  $result->free();
  $db->close();

?>
		    </td></tr>
		  </table>
</body>
</html>