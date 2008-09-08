<?php
//this script just writes the gps data from google maps out to a text file
$myFile = "gps.txt";
$fh = fopen($myFile, 'w') or die("can't open file");
fwrite($fh, $_REQUEST["lat"]);
fwrite($fh, ",");
fwrite($fh, $_REQUEST["lng"]);
fclose($fh);

echo $_REQUEST["lat"];
echo ",";
echo $_REQUEST["lng"];

?>
