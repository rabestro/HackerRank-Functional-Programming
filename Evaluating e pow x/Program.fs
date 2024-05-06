(*
    The challenge is to accomplish this without either mutable state or direct declaration of local variables.
*)

let testCases = int <| System.Console.ReadLine()

let exp x =
    let rec term n =
        match n with
        | 0 -> 1.0
        | 1 -> x
        | _ -> x / double n * term (n - 1)

    seq { 0..9 } |> Seq.map term |> Seq.sum

Seq.initInfinite (fun _ -> System.Console.ReadLine())
|> Seq.truncate testCases
|> Seq.map double
|> Seq.map exp
|> Seq.iter (printfn "%A")
