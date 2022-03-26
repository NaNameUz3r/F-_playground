open System
// // 17.1
let rec pow (s:string, n:int) = match (s, n) with
 | s, n when n > 0 -> s + pow (s, n - 1)
 | _ -> ""

// 17.2
let isIthChar (s:string, n, c) = match c with
 | c when n >= 0 && n < String.length s && c = s.[n] -> true
 | _ -> false

// 17.3
let rec occFromIth = function
 | (s:string, n:int, c) when n > String.length s - 1 || n < 0 -> 0
 | (s:string, n:int, c) -> 
    if s.[n] = c then
        occFromIth (s, n + 1, c) + 1
    else
        occFromIth (s, n + 1, c)