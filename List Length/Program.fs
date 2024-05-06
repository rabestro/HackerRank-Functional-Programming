//Enter your code here. Read input from STDIN. Print output to STDOUT

Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.takeWhile (fun line -> line <> null)
|> Seq.length
|> printfn "%i"
