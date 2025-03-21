open System
// 2. Tail Recursion 1: Product of all elements in a list
let rec productTailRec (lst: int list) (acc: int) =
    match lst with
    | [] -> acc
    | h::t -> productTailRec t (acc * h)

let product lst = productTailRec lst 1

printfn "Product of list: %d" (product [1; 2; 3; 4; 5])