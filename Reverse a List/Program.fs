Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.takeWhile (fun line -> line <> null)
|> Seq.rev
|> Seq.iter (printfn "%s")

