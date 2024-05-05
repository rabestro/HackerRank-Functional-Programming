let n = System.Console.ReadLine() |> int

Seq.initInfinite (fun _ -> System.Console.ReadLine())
    |> Seq.takeWhile (fun line -> line <> null)
    |> Seq.collect (Seq.replicate n)
    |> Seq.iter (printfn "%s")
    
    