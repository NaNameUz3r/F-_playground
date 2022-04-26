// 34.1

let upto n =
    let rec unfoldL (n, l) = 
        if n > 0 then unfoldL (n-1, n :: l)
        else l
    unfoldL (n, [])


// 34.2
let rec dnto n  =
    let rec reverse_list accumulator = function 
     | [] -> accumulator
     | head :: tail -> reverse_list (head :: accumulator) tail
    reverse_list [] (upto n)


// 34.3
let evenn n = 
    let rec generate_evens (n, x) = match n with
     | 0 -> []
     | _ -> x * 2 :: generate_evens (n-1, x+1)
    generate_evens (n, 1)

printfn "%A" (evenn 5)  


