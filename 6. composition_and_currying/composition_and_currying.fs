// 20.3.1
let vat n x = (x * float(n) / 100.0)) + x

// 20.3.2
let unvat n x = x * (float(n) / float(100 + n))

// 20.3.3
let rec min f = 
    let rec iterMin n = match n with
     | f(n) when n = 0 -> n
     | _ -> iterMin(n + 1)
    iterMin 1