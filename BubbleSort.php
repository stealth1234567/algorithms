<?php
  // Bubble Sort PHP Implementation
  function BubbleSort(&$array, $endIndex) {
    if($endIndex === 0) {
      return $array;
    }
    for($i = 0; $i < $endIndex; $i++) {
      if($array[$i] > $array[$i+1]) {
        echo "SWAP {$array[$i]} with {$array[$i+1]}\n";
        $temp = $array[$i];
        $array[$i] = $array[$i+1];
        $array[$i+1] = $temp;
      }
    }
    return BubbleSort($array, $endIndex - 1);
  }
  
  // TEST
  $array = [ 26, 54, 93, 17, 77, 31, 44, 55, 20 ];
  $myArray = BubbleSort($array, 8);
  print_r($myArray);
?>
