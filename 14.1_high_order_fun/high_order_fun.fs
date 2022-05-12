// 41.4.1
let list_filter f xs = 
    let filter_accum x accum = if f(x) then x::accum else accum
    List.foldBack filter_accum xs []

// 41.4.2
let sum (p, xs) = 
    let sum_accum accum x = if (p x) then (accum + x) else accum
    List.fold sum_accum 0 xs

// 41.4.3
let revrev = fun xs ->
    let rev_fold head tail = (List.rev tail)::head
    List.fold rev_fold [] xs
