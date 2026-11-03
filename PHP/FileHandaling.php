<?php

$file = fopen("student.txt", "w");

if ($file)
{
    fwrite($file, "Welcome to PHP");
    fwrite($file, "This is a file handling example");

    fclose($file);

    echo "File created & data written successfully.";
}
else
{
    echo "Unable to create the file.";
}

?>