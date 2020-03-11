
let z = 42

let addTwice x y =
    let z = x + y
    printfn "Value inside function scope: %i" z
    x + y + z

[<EntryPoint>]
let main _ =

    addTwice 4 2 |> printfn "Function result: %i"
    printfn "Value outside function scope: %i" z

    0
