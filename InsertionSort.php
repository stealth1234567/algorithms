<?php
  $array = [26,54,93,17];
  
  function InsertionSort($array, $startIndex) {
    if(count($array) === 1 || $startIndex >= count($array)) {
      return $array;
    }

    for($i = $startIndex; $i > 0; $i--) {
      if($array[$i] < $array[$i - 1]) {
        $temp = $array[$i - 1];
        $array[$i - 1] = $array[$i];
        $array[$i] = $temp;
      }
    }
    return InsertionSort($array, $startIndex + 1);
  }

  $myArray = [2, 1, 10, 15, 5, 8, 8, 22, 0];
  $myArray = InsertionSort($myArray, 1);
  
  foreach($myArray as $item) {
    echo $item . "\n";
  }
?>
