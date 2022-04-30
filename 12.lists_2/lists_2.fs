// 39.1
let rmodd l = 
    let list_length = List.length l
    let odd_elements = [ for i in 1 .. 2 .. list_length -> l.Item(i)]
    odd_elements

// 39.2
let del_even l = 
    let odds_only = List.filter (fun x -> x % 2 <> 0) l
    odds_only

// 39.3
let rec multiplicity x xs = 
    let only_x = List.filter (fun n -> n = xs ) x
    let times = List.length only_x
    times

// 39.4
let rec split = function
 | [x; y] -> ([x], [y])
 | x::y::n -> 
            let (odd, even) = split n
            (x::odd, y::even)
 | _ -> failwith "Input list should have even lengs"

// 39.5
let rec zip = function
 | ([x], [y]) -> [(x, y)]
 | (x::tail_x, y::tail_y) -> (x, y)::zip(tail_x, tail_y)
 | _ -> failwith "Both of input lists should have even lengths"
