<?php
  // PHP implementation of selection sort
  $myArray = [26,54,93,17,77,31,44,55,20];

  function SelectionSort(&$array) {
    for($i = 0; $i < count($array); $i++) {
      $minIndex = $i;
      for($j = $i + 1; $j < count($array); $j++) {
        // identify location of smallest item  
        if($array[$j] < $array[$minIndex]) {
          $minIndex = $j;
        }
      }
      $temp = $array[$i];
      $array[$i] = $array[$minIndex];
      $array[$minIndex] = $temp;
    }
  }

  // TEST
  SelectionSort($myArray);
  echo "<pre>";
  print_r($myArray);
  echo "</pre>";
?>
