let days_in_month n = match n with
 | n when n < 1  -> 0 | n when n > 12 -> 0
 | n when List.contains n [1; 3; 5; 7; 8; 10; 12] -> 31
 | 2 -> 28
 | _ -> 30
