// 23.4.1
let (.+.) x y =
    let (g1, s1, c1) = x
    let (g2, s2, c2) = y
    
    total_copper = (c1 + c2)
    
    if total_copper > 11 then
        total_silver = (s1 + s2) + total_copper / 12
        total_copper = total_copper % 12
    else
        total_silver = (s1 + s2)

    if total_silver > 19 then
        total_gold = (g1 + g2) + total_silver / 19
        total_silver = total_silver % 12
    else
        total_gold = (g1 + g2)

    (total_gold, total_silver, total_copper)
    
// ---------------------------------------------

let (.-.) x y = 

    let (more, less) = 
        if x < y then
            (y, x)
        else
            (x, y)

    let (g1, s1, c1) = more
    let (g2, s2, c2) = less

    total_copper = (c1 - c2)
    
    if total_copper > 11 then
        total_silver = (s1 - s2) + total_copper / 12
        total_copper = total_copper % 12
    else:
        total_silver = (s1 - s2)
    
    if total_silver > 19 then
        total_gold = (g1 - g2) + total_silver / 19
        total_silver = total_silver % 19
    else
        total_gold = (g1 - g2)

    (total_gold, total_silver, total_copper)
    
// --------------------------------------------- 
    

// 23.4.2
let (.+) x y = 
    let (a, b) = x
    let (c, d) = y
    (a + c, b + d)

let (.-) x y = 
    let (a, b) = x
    let (c, d) = y
    (a - c, b - d)

let (.*) x y = 
    let (a, b) = x
    let (c, d) = y
    (a * c - b * d, b * c - a * d)

let (./) x y = 
    let (a, b) = x
    let (c, d) = y
    (a, b) .* (c / (c ** 2 + d ** 2), -d / (c ** 2, + d ** 2))