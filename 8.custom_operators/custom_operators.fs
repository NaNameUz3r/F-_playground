// 23.4.1
let (.+.) x y =
    let (g1, s1, c1) = x
    let (g2, s2, c2) = y
    
    let total_wallet = (g1 + g2, s1 + s2, c1 + c2)
    
    let rec count_coppers = function
     | (g, s, c) when c <= 11 -> (g, s, c)
     | (g, s, c) -> count_coppers (g, s + 1, c - 12)

    let rec count_silvers = function
     | (g, s, c) when s <= 19 -> (g, s, c)
     | (g, s, c) -> count_silvers (g + 1, s - 20, c)

    let copper_conversioned = count_coppers total_wallet
    let converted_wallet = count_silvers copper_conversioned
    converted_wallet
    
// ---------------------------------------------

let (.-.) x y = 

    let (more, less) = 
        if x < y then
            (y, x)
        else
            (x, y)

    let (g1, s1, c1) = more
    let (g2, s2, c2) = less

    let rec count_coppers = function
     | (g, s, c) when c <= 11 -> (g, s, c)
     | (g, s, c) -> count_coppers (g, s + 1, c - 12)

    let rec count_silvers = function
     | (g, s, c) when s <= 19 -> (g, s, c)
     | (g, s, c) -> count_silvers (g + 1, s - 20, c)

    let bigger_copper_conversioned = count_coppers more
    let bigger_converted_wallet = count_silvers bigger_copper_conversioned
    
    let smaller_copper_conversioned = count_coppers less
    let smaller_converted_wallet = count_silvers smaller_copper_conversioned

    let (bigger_g, bigger_s, bigger_c) = bigger_converted_wallet
    let (smaller_g, smaller_s, smaller_c) = smaller_converted_wallet
    (bigger_g - smaller_g, bigger_s - smaller_s, bigger_c - smaller_c)


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
    (a * c - b * d, b * c + a * d)

let (./) x y = 
    let (a, b) = x
    let (c, d) = y
    (a, b) .* (c / (c * c + d * d), -d / (c * c + d * d))