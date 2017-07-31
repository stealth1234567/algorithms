<?php
  /*
   * Find the sum of an array using recursion
   */
   
  $array = [1,2,3,4,5,6,7,8,9,10];

  function sum($array, $startIndex) {
    if(count($array) == 0 || $startIndex >= count($array)) {
      return 0;
    }
    return $array[$startIndex] + sum($array, $startIndex+1);
  }
  echo sum($array, 1);
?>
