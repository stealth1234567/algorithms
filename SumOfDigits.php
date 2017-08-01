<?php
  function sumOfDigits($num) {
    if($num < 10) {
      return $num;
    }
    $remainder = $num % 10;
    $quotient = floor($num / 10);

    return $remainder + sumOfDigits($quotient);
  }

  // TEST
  $number = 13489;
  echo sumOfDigits($number);
?>
