<?php
  function GCD($a, $b)
  {
    /*
      The Euclidean Algorithm for finding GCD(A,B) is as follows:
        If A = 0 then GCD(A,B)=B, since the GCD(0,B)=B, and we can stop.  
        If B = 0 then GCD(A,B)=A, since the GCD(A,0)=A, and we can stop.  
        Write A in quotient remainder form (A = B⋅Q + R)
        Find GCD(B,R) using the Euclidean Algorithm since GCD(A,B) = GCD(B,R)
     */
     
    if($a != 0 && $b == 0)
    {
      return $a;
    }
    else if($b != 0 && $a == 0) {
      return $b;
    }
    else {
      $quotient = $a / $b;
      $remainder = $a % $b;
      return GCD($b, $remainder);
    }
  }
  
  // TEST
  echo GCD(270, 192);
?> 
