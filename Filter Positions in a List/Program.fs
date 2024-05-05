let removeOdd i x = if i % 2 = 1 then Some x else None

Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.takeWhile (fun line -> line <> null)
|> Seq.mapi removeOdd
|> Seq.choose id
|> Seq.iter (printfn "%s")
