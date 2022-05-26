// 49.5.1
let even_seq = Seq.initInfinite (fun i  -> i * 2 + 2)

// 49.5.2
let fac_seq = 
    let rec findFactorial n =
        match n with
        | 0 -> 1
        | 1 -> 1
        | _ -> n * findFactorial(n-1)

    Seq.initInfinite findFactorial

// 49.5.3
let seq_seq = 
    let generateMirroredInt n =
        match n with
        | 0 -> 0
        | n when n % 2 = 0 -> n / 2
        | _ -> -n / 2 - 1
    Seq.initInfinite generateMirroredInt
