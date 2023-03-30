<?php

// Read input
$n = intval(trim(fgets(STDIN)));
$members = explode(" ", trim(fgets(STDIN)));

// Check input validity
if (count($members) != $n) {
    echo "Input must be equal with count of family\n";
    exit;
}

// Count number of buses needed
$num_buses = 0;
$num_families = 0;
foreach ($members as $m) {
    $num_families += ceil($m / 4);
}
$num_buses = ceil($num_families / 2);

// Output result
echo $num_buses . "\n";

?>



