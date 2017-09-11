<?php
  function BinarySearch($arr, $key, $start, $end) {
    $middle = floor(($start + $end) / 2); // need to use floor() in PHP
    
    if($start <= $end) {
      if($arr[$middle] == $key) {
        return $middle;
      }
      else if($arr[$middle] < $key) {
        return BinarySearch($arr, $start, $middle+1, $end);
      }
      else {
        return BinarySearch($arr, $key, $start, $middle-1);
      }
    }
    return -1;
  }
?>
