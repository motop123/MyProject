<?php 

require_once('phpmailer/PHPMailerAutoload.php');
$mail = new PHPMailer;
$mail->CharSet = 'utf-8';

$msg = $_POST['msg'];
$email = $_POST['email'];

//$mail->SMTPDebug = 3;                               // Enable verbose debug output

$mail->isSMTP();                                      // Set mailer to use SMTP
$mail->Host = 'smtp.mail.ru';  																							// Specify main and backup SMTP servers
$mail->SMTPAuth = true;                               // Enable SMTP authentication
$mail->Username = 'zinurovda@mail.ru'; // Ваш логин от почты с которой будут отправляться письма
$mail->Password = '25232499q'; // Ваш пароль от почты с которой будут отправляться письма
$mail->SMTPSecure = 'ssl';                            // Enable TLS encryption, `ssl` also accepted
$mail->Port =  465; // TCP port to connect to / этот порт может отличаться у других провайдеров

$mail->setFrom('zinurovda@mail.ru'); // от кого будет уходить письмо?
$mail->addAddress('zinurov_danil@mail.ru');     // Кому будет уходить письмо 
$mail->isHTML(true);                            // Set email format to HTML

$mail->Subject = 'Здравствуйте!';
$mail->Body    = ' Пользователь  '.$email .' задал вопрос : ' .$msg;
$mail->AltBody = '';

if(!$mail->send()) {
    echo 'Error';
} else {
    echo '<script>location.replace("indexServer.php");</script>';
}
?>