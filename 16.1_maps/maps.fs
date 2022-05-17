let try_find key m = 
    let inlisted_map = Map.toList m
    
    let rec seek_key x = match x with
     | [] -> None
     | (item_key, item_value)::tail -> if item_key = key then Some(item_value) else seek_key tail
    
    seek_key inlisted_map
