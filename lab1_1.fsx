open System
// 1. Partial Application
let power exponent value =
    value ** float exponent

let square = power 2.0
let cube = power 3.0

printfn "Square of 4: %f" (square 4.0)
printfn "Cube of 3: %f" (cube 3.0)