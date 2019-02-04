namespace CardIdValidator_F

module CardId =
    let LetterPattern = 
        [| 
            'T'
            'R'
            'W'
            'A'
            'G'
            'M'
            'Y'
            'F'
            'P'
            'D'
            'X'
            'B'
            'N'
            'J'
            'Z'
            'S'
            'Q'
            'V'
            'H'
            'L'
            'C'
            'K'
            'E' 
        |]
    let getNumber (dni:string) : int = dni.[..dni.Length - 2] |> int
    let getLetter (dni:string) : char = dni.[dni.Length - 1]
    let isValid (dni:string) : bool = 
        let position = getNumber(dni) % 23
        let letter = LetterPattern.[position]
        let dniLetter = getLetter(dni)
        dniLetter.Equals(letter)
 


