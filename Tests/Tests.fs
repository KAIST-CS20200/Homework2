namespace CS220

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.A``() =
    let r = Program.prob1 30
    Assert.AreEqual (4, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.B``() =
    let r = Program.prob1 328
    Assert.AreEqual (218, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.C``() =
    let r = Program.prob1 1337
    Assert.AreEqual (12207, r)

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1.D``() =
    let r = Program.prob1 -1000
    Assert.AreEqual (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.A``() =
    let r = Program.prob2 59129123 1929149
    Assert.AreEqual (1, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.B``() =
    let r = Program.prob2 10502050 4012032
    Assert.AreEqual (2, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.C``() =
    let r = Program.prob2 -1 -1
    Assert.AreEqual (1, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.D``() =
    let r = Program.prob2 10 0
    Assert.AreEqual (10, r)

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2.E``() =
    let r = Program.prob2 0 0
    Assert.AreEqual (-1, r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.A``() =
    let r = Program.prob3 "cs220" 0
    Assert.AreEqual ("", r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.B``() =
    let r = Program.prob3 "cs220" -1
    Assert.AreEqual ("022sc", r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.C``() =
    let r = Program.prob3 "cs220" 5
    Assert.AreEqual ("cs220cs220cs220cs220cs220", r)

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3.D``() =
    let r = Program.prob3 "abcde" -5
    Assert.AreEqual ("edcbaedcbaedcbaedcbaedcba", r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.A``() =
    let r = Program.prob4 0u
    Assert.AreEqual (0u, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.B``() =
    let r = Program.prob4 120u
    Assert.AreEqual (2u, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.C``() =
    let r = Program.prob4 65537u
    Assert.AreEqual (65537u, r)

  [<TestMethod; Timeout 1000; TestCategory "4">]
  member __.``Problem 4.D``() =
    let r = Program.prob4 1688611u
    Assert.AreEqual (401u, r)

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.A``() =
    let r = Program.prob5 402103u
    Assert.IsFalse r

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.B``() =
    let r = Program.prob5 65537u
    Assert.IsTrue r

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.C``() =
    let r = Program.prob5 2u
    Assert.IsTrue r

  [<TestMethod; Timeout 1000; TestCategory "5">]
  member __.``Problem 5.D``() =
    let r = Program.prob5 1u
    Assert.IsFalse r
