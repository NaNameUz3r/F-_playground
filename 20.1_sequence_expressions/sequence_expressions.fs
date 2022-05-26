// 50.2.1
let fac_seq = 
    let rec findFactorial n =
        match n with
        | 0 -> 1
        | 1 -> 1
        | _ -> n * findFactorial(n-1)
    let mutable i = 0
    let buildedSeq = seq {
        while true do 
            yield findFactorial i
            i <- i + 1
        }
    buildedSeq

// 50.2.2
let seq_seq = seq {
    let mutable i = 0
    yield i
    while true do
        i <- i + 1
        yield! seq {-i; i}
}