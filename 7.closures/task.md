Даны две функции

    curry: (int * int -> int) -> int -> int ->int
    uncurry: (int -> int ->int) -> int * int -> int

curry f -- это функция g, где g x -- это функция h, где h y = f(x,y).

uncurry g -- это функция f, где f(x,y) -- это значение h y для функции h = g x.

Напишите их реализации. 