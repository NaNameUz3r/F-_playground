// 47.4.1
let f n = 
    let mutable sum = 1
    let go_iter x = sum <- sum * x
    List.iter go_iter [1 .. n]
    sum

// 47.4.2
let fibo n = 
  if n < 0 || n = 0 
    then 0
  elif n = 1 
    then 1
  else
    let mutable item = 0
    let mutable next_item = 1
    let mutable count = 2
    while count <= n do
      let swap_var = item + next_item
      item <- next_item
      next_item <- swap_var
      count <- count + 1 
    next_item
