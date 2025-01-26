let mutable x = 10
let mutable y = 20

let swap () = 
    let temp = x
    x <- y
    y <- temp

swap ()
printfn "%d %d" x y