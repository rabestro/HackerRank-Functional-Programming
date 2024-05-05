let limit = System.Console.ReadLine() |> int

Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.takeWhile (fun line -> line <> null)
|> Seq.map int
|> Seq.filter (fun n -> n < limit)
|> Seq.iter (printfn "%i")
