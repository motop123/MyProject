<?php
ob_start();
print("<html>
<head>
    <meta http-equiv=\"content-type\" content=\"text/html; charset=windows-1251\" />
    <link href=\"css/style.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"css/reset.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"https://fonts.googleapis.com/css?family=Russo+One\" rel=\"stylesheet\">
    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css\" integrity=\"sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4\" crossorigin=\"anonymous\">
    <link href=\"css/style-category.css\" rel=\"stylesheet\" type=\"text/css\" />
    <link href=\"bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\">
    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>
    <script src=\"bootstrap/js/bootstrap.min.js\"></script>
    <script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>
    <style>
    </style>
</head>
<body>
<div id=\"block-body\">");
?>
<?php
require 'db.php';
?>
<?php
require 'DataBase.php';
?>
<?php
require("include/block-header.php");
?>
<div id="block-content-administration">


    



</div>
<?php
require 'include/block-footer.php';
?>
</div>
</body>
</html>

