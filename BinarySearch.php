<?php
  function BinarySearch($array, $item, $firstIndex, $lastIndex) {
    $middleIndex = round((($firstIndex + $lastIndex) / 2), 0, PHP_ROUND_HALF_DOWN);
    $middleItem = $array[$middleIndex];

    if($firstIndex > $lastIndex) {
        return -1;
    }

    if($item == $middleItem) {
        return $middleIndex;
    }
    else if($item > $middleItem) {
        return BinarySearch($array, $item, $middleIndex+1, $lastIndex);
    }
    else if($item < $middleItem) {
        return BinarySearch($array, $item, $firstIndex, $middleIndex-1);
    }
    return -1;
  }

  // create array
  $myArray = array();
  $num = 1;
  for($i = 0; $i < 10000; $i++) {
    $myArray[$i] = $num;
    $num++;
  }

  // execute function
  echo BinarySearch($myArray, 156, 0, 9999);
?>
