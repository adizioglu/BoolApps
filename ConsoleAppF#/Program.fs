open System

[<EntryPoint>]
let main argv =
    // true or false

    let isComplete = true

    //isComplete <- not isComplete

    printfn "%b" (not isComplete)
    printfn "%b" isComplete

    0 // return an integer exit code

