// 39.1
let rmodd l = 
    let list_length = List.length l
    let odd_elements = [ for i in 1 .. 2 .. list_length -> l.Item(i)]
    odd_elements  

// 39.2
// let del_even l = 
//     let odds_only = List.filter (fun x -> x % 2 <> 0) l
//     odds_only

let rec del_even = function
 | head::tail when head % 2 = 0 -> del_even(tail)
 | head::tail -> head::del_even(tail)
 | [] -> [] 

// 39.3
let rec multiplicity x xs = match xs with
 | [] -> 0
 | head::tail when head = x -> 1 + multiplicity x tail
 | head::tail -> multiplicity x tail

// 39.4
let rec split = function
 | [x; y] -> ([x], [y])
 | x::y::n -> 
            let (odd, even) = split n
            (x::odd, y::even)
 | _ -> failwith "Input list should have even length"


// 39.5
let rec zip (xs1,xs2)= match (xs1,xs2) with
 | ([],[]) -> []
 | (xhead::xtail, yhead::ytail) -> (xhead,yhead)::zip(xtail,ytail)
