module BmukIO.Tests

open BmukIO
open NUnit.Framework

[<Test>]
let ``Dummy Test`` () =
  let result = 42
  printfn "%i" result
  Assert.AreEqual(42,result)
