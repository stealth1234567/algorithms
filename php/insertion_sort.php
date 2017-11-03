<?php
  function insertion_sort(&$array) {
    for($i = 1; $i < count($array); $i++) {
      $j = $i - 1;
      $current_element = $array[$i];
      while($j >= 0 && ($array[$j] > $current_element)) {
        $array[$j+1] = $array[$j];
        $j--;
      }
      $array[$j+1] = $current_element;
    }
  }
?>
