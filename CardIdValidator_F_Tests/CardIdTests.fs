namespace Tests

open NUnit.Framework
open CardIdValidator_F
open System.Diagnostics

[<TestClass>]
type TestClass () =

    [<Test>]
    member this.GivenCorrectCountryDni_WhenValidate_ThenGetTrue () =
        // Arrange
        let anyValidDni = "36076973R"
        
        // Act
        let mutable isValid = true
        for i = 1 to 1000000 do
            isValid <- CardId.isValid(anyValidDni)

        // Assert
        Assert.IsTrue(isValid)
