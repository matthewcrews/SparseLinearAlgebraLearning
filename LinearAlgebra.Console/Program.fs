// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    LinearAlgebara.Sparse.Say.hello "Katie"

    printfn "Press any key to exit..."
    Console.ReadKey() |> ignore
    0 // return an integer exit code
