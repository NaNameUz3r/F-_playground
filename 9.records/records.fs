type TimeOfDay = { hours : int;  minutes : int; f :string}


let (.>.) x y = 
    let x_time = (x.hours, x.minutes)
    let y_time = (y.hours, y.minutes)

    let x_majority = x_time > y_time
    if x.f = "AM" && y.f = "PM" then
        not x_majority
    else
        x_majority

