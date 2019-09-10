printfn "Hello World from F#!"    

// 1
let double(x) = x * 2
let doubleRes = double(5)
printf "double %A\n" doubleRes

// 2
let addOne(x) = x + 1
let addRes = addOne(5)
printf "addOne %A\n" addRes

// 3
let isEven(x) = x % 2 = 0
let isEvenRes = isEven(7)
printf "isEven %A\n" isEvenRes

// 4
let rec sumAll(n) = if n = 0 then n else n + sumAll(n - 1)
let sumAllRes = sumAll(5)
printf "sumAll %A\n" sumAllRes

// 5
let rec sumBetween(m, n) = 
    if m>n then 0 else
        if m = n then m else n + sumBetween(m, n-1)

let sumBetweenRes = sumBetween(2,4)
printf "sumBetween %A\n" sumBetweenRes

// 6
let rec fib(n) =
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> fib(n-1) + fib(n-2)

let fibRes = fib(11)
printf "sumBetween %A\n" fibRes


