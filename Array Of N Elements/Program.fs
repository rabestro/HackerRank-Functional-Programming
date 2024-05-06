(*
    Create an array of integers, where the value of is passed as an argument to the pre-filled function in your editor. 
    This challenge uses a custom checker, so you can create any array of n integers. 
    For example, if , n = 4 you could return [1, 2, 3, 4], [1, 1, 1, 1], or any other array of equal length.
*)

open System

let f n : int[] = Array.zeroCreate n

let main () =
    let input = Console.ReadLine()
    let n = int input
    printfn $"%A{f n}"

main ()
