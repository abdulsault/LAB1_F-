open System
// 6. Using Filter and Reduce with a Collection of Strings
let stringList = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredStrings = List.filter (fun (s: string) -> s.Contains("i") || s.Contains("I")) stringList
let concatenatedNames = List.fold (fun acc name -> acc + name + "-") "" filteredStrings

printfn "Concatenated names with 'i': %s" concatenatedNames