<?php
  // PHP implementation of selection sort
  $my_array = [26,54,93,17,77,31,44,55,20];

  function selection_sort(&$array) {
    for($i = 0; $i < count($array); $i++) {
      $min_index = $i;
      for($j = $i + 1; $j < count($array); $j++) {
        // identify location of smallest item  
        if($array[$j] < $array[$min_index]) {
          $min_index = $j;
        }
      }
      $temp = $array[$i];
      $array[$i] = $array[$min_index];
      $array[$min_index] = $temp;
    }
  }

  // TEST
  selection_sort($my_array);
  echo "<pre>";
  print_r($my_array);
  echo "</pre>";
?>
