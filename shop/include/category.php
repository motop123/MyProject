
<!DOCTYPE html>

<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="style.css">
</head>
<body>
<div class="container content">
    <div class="row">
        <div class="col-md-4">
            <div id="block-barmen-category">
                <h1>Бармен </h1>
            </div>
            <div class="list-group">
                <a class="list-group-item salary" style="color: white">Акции</a>
                <?php
                include ('DataBase.php');
                mysqli_query($link,"SET NAMES cp1251");
                mysqli_query($link,"SET CHARACTER SET cp1251");
                mysqli_query($link,"SET character_set_client = cp1251");
                mysqli_query($link,"SET character_set_connection = cp1251");
                mysqli_query($link,"SET character_set_results = cp1251");
                $res = mysqli_query($link,'SELECT * FROM undercategory' ) or die("ERROR: ".mysqli_error($link));
                while($row = mysqli_fetch_array($res)) {

                    print '<a class="list-group-item">' . $row['Name_undercategory'] . '<br /></a>';
                }
                mysqli_close($link)
                ?>

            </div>
        </div>
        <div class="col-md-8 products">
            <div class="row">
                <?php
                include ('DataBase.php');
                mysqli_query($link,"SET NAMES cp1251");
                mysqli_query($link,"SET CHARACTER SET cp1251");
                mysqli_query($link,"SET character_set_client = cp1251");
                mysqli_query($link,"SET character_set_connection = cp1251");
                mysqli_query($link,"SET character_set_results = cp1251");
                $res = mysqli_query($link,'SELECT * FROM tovar' ) or die("ERROR: ".mysqli_error($link));
                while($row = mysqli_fetch_array($res)){

                    print '<div class="col-sm-4"><div class="product" data-id="'.$row['id'].'"><div class="product-img"><a href="#"><img src="images/'.$row['img'].'.jpg" alt=""></a></div><div class="block-product-content"><p class="product-title"><a href="#">'.$row['Name'].'</a></p><div class="rasdelitel">&nbsp;</div><p class="product-desc">Размер: '.$row['size'].'</p><p class="product-desc">Материал: '.$row['material'].'</p><p class="product-desc">Цвет: '.$row['color'].'</p><div class="rasdelitel">&nbsp;</div><p class="product-price">'.$row['Price'].'<a href="#" class="button-trash"></a></p></div></div></div>';

                }
                mysqli_close($link)
                ?>
            </div>
        </div>
    </div>
</div>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<script src="bootstrap/js/bootstrap.min.js"></script>

</body>
</html>