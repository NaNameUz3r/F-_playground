type F = 
 | AM 
 | PM 

type TimeOfDay = { hours : int; minutes : int; f: F }

let transform_time (a:TimeOfDay) = match a with
 | { hours = _ ; minutes = _; f = AM } -> a.hours * 60 + a.minutes
 | { hours = _ ; minutes = _; f = PM } -> (a.hours + 12) * 60 + a.minutes


let (.>.) x y = (transform_time x) > (transform_time y)

