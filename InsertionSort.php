<?php
  function InsertionSort(&$array) {
    for($i = 1; $i < count($array); $i++) {
      $j = $i - 1;
      $currentElement = $array[$i];
      while($j >= 0 && ($array[$j] > $currentElement)) {
        $array[$j+1] = $array[$j];
        $j--;
      }
      $array[$j+1] = $currentElement;
    }
  }
?>
