<?php
  // Bubble Sort PHP Implementation
  function BubbleSort(&$array, $endIndex) {
    if($endIndex > 0) {
      for($i = 0; $i < $endIndex; $i++) {
        if($array[$i] > $array[$i+1]) {
          echo "SWAP {$array[$i]} with {$array[$i+1]}\n";
          $temp = $array[$i];
          $array[$i] = $array[$i+1];
          $array[$i+1] = $temp;
        }
      }
      $endIndex = $endIndex - 1;
      BubbleSort($array, $endIndex);
    }
    return $array;
  }

  // TEST
  $array = [26,54,93,17];
  $myArray = BubbleSort($array, 3);

  print_r($myArray);
?>
