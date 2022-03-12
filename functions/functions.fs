let g some_integer = some_integer + 5 // type of function g is int -> int

let gg = fun some_integer -> some_integer + 5

let h (x,y) = 
    let squares_sum = (x * x) + (y * y)
    System.Math.Sqrt(squares_sum)
