// 16.1
let notDivisible (n, m) = n % m = 0

// 16.2
let rec recPrime = function
 | n, 1 -> true 
 | n, m -> (n % m <> 0) && recPrime (n, m - 1)

let prime n = recPrime (n, n - 1)
