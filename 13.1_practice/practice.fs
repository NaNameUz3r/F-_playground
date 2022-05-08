// 40.1
let rec sum (p, xs) = match xs with
 | head::tail when p head -> head + sum (p, tail)
 | _::tail -> sum (p, tail)
 | _ -> 0

// 40.2.1
let rec count (xs, n) = match xs with
 | [] -> 0
 | head::tail when head < n -> count (tail, n)
 | head::tail when head = n -> 1 + count (tail, n)
 | _ -> 0

// 40.2.2
let rec insert (xs, n) = match xs with
 | [x] -> if x < n then [x; n] else [n; x]
 | head::tail when head < n -> head::insert (tail, n)
 | head::tail when head > n || head = n -> n::head::tail
 | _ -> [] 

// 40.2.3
let rec intersect (xs1, xs2) = match (xs1, xs2) with
 | xhead::xtail, yhead::ytail when xhead = yhead -> xhead::intersect (xtail, ytail)
 | xhead::xtail, yhead::ytail when xhead < yhead -> intersect (xtail, yhead::ytail)
 | xhead::xtail, yhead::ytail when xhead > yhead -> intersect (xhead::xtail, ytail)
 | _, _ -> []

// 40.2.4
let rec plus (xs1, xs2) = match (xs1, xs2) with
 | xhead::xtail, yhead::ytail when xhead = yhead -> xhead::yhead::plus (xtail, ytail)
 | xhead::xtail, yhead::ytail when xhead < yhead -> xhead::plus (xtail, yhead::ytail)
 | xhead::xtail, yhead::ytail when xhead > yhead -> yhead::plus (xhead::xtail, ytail)
 | (xhead::xtail, []) -> xhead::xtail
 | ([], yhead::ytail) -> yhead::ytail
 | _, _ -> []


// // 40.2.5
let rec minus (xs1, xs2) = match (xs1, xs2) with
 | xhead::xtail, yhead::ytail when xhead = yhead -> minus (xtail, ytail)
 | xhead::xtail, yhead::ytail when xhead < yhead -> xhead::minus (xtail, yhead::ytail)
 | xhead::xtail, yhead::ytail when xhead > yhead -> minus (xhead::xtail, ytail)
 | (xhead::xtail, []) -> xhead::xtail
 | ([], _) -> []
 | _, _ -> []

// 40.3.1
let rec smallest = function
 | [] -> None
 | [head] -> Some head
 | head::tail -> min (Some head) (smallest tail)

// // 40.3.2
let rec delete (n, xs) = match xs with
 | head::tail when head = n -> tail 
 | head::tail -> head::delete (n, tail)
 | _ -> []

let rec sort = function
 | [] -> []
 | xs ->
      let smallestElement = smallest(xs)
      [Option.get(smallestElement)] @ sort (delete (Option.get(smallestElement), xs))

// 40.4

let rec listRev= function
 | [] -> []
 | head::tail -> (listRev tail) @ [head]
  
let rec revrev = function
 | [] -> []
 | head::tail -> (revrev tail) @ [listRev head]

            
