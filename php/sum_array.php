<?php
  $array = [1,2,3,4,5,6,7,8,9,10];

  function sum($array, $start_index) {
    if(count($array) == 0 || $start_index >= count($array)) {
      return 0;
    }
    return $array[$start_index] + sum($array, $start_index + 1);
  }
  echo sum($array, 1);
?>
