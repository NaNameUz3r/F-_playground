// 20.3.1
let vat n x = (x * float(n) / 100.0) + x

// printfn "%f" (vat 5 100)

// 20.3.2
let unvat n x = x * (float(100) / float(100 + n))

// printfn "%f" (unvat 5 105)

// 20.3.3
let rec min f = 
    let rec iterMin n = 
        if f(n) = 0 then n
        else iterMin(n + 1)
    iterMin 1 

// let testFunc n = 10 - n
// printfn "%d" (min testFunc)