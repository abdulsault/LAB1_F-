open System
// 4. Using Map Function with a Collection
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = List.map (fun (name: string) -> name.Trim()) names

printfn "Trimmed Names: %A" trimmedNames