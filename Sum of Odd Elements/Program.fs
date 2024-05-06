open System

(*USER CODE BEGIN*)
let isOdd x = x % 2 = 1
let f arr = arr |> Seq.filter isOdd |> Seq.sum
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr