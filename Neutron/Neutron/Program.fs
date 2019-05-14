open System

let mutable currPlayer = "1"
let mutable firstTurn = true
let mutable winner = " "
let mutable cellAvailable = false

let gameBoard = [|[|"1";"1";"1";"1";"1"|];
                  [|" ";" ";" ";" ";" "|];
                  [|" ";" ";"N";" ";" "|];
                  [|" ";" ";" ";" ";" "|];
                  [|"2";"2";"2";"2";"2"|];|]

let PrintBoard (board: string[][]) = 
    Console.WriteLine("---------------------")
    for row in 0..4 do
        Console.Write("| ")
        for col in 0..4 do
            Console.Write(board.[row].[col] + " | ")
        Console.WriteLine()
        Console.WriteLine("---------------------")

let PrintDirection (board: string[][]) = 
    Console.WriteLine("1|2|3")
    Console.WriteLine("8|*|4")
    Console.WriteLine("7|6|5")

let GetRowOffset (direction: int) = 
    if(direction = 1 || direction = 2 || direction = 3) then -1
    elif(direction = 7 || direction = 6 || direction = 5)then 1
    else 0

let GetColOffset (direction: int) = 
    if(direction = 1 || direction = 8 || direction = 7) then -1
    elif(direction = 3 || direction = 4 || direction = 5)then 1
    else 0

let CheckAvailability (board: string[][])(row: int)(col:int)=
    if((row < 0 || row > 4) || (col < 0 || col > 4))then cellAvailable <- false
    else
        if(board.[row].[col] = " ") then cellAvailable <- true
        else cellAvailable <- false

let MoveNeutron (board: string[][])(direction :int) = 
    let mutable success = false
    for row in 0..4 do
        for col in 0..4 do
            if(gameBoard.[row].[col] = "N")then
                //if the destination is available, place the neutron there and open up old position
                CheckAvailability gameBoard (row + GetRowOffset direction) (col + GetColOffset direction)
                if(cellAvailable)then
                    gameBoard.[row + GetRowOffset direction].[col + GetColOffset direction] <- "N"
                    gameBoard.[row].[col] <- " "
                    success <- true
    if(success)then true
    else false

let MoveSoldier (board: string[][])(row: int)(col: int)(direction) = 
    let mutable success = false
    //if destination is available, place the soldier in that cell and open up old cell
    CheckAvailability gameBoard (row + GetRowOffset direction) (col + GetColOffset direction)
    if(cellAvailable)then
        gameBoard.[row + GetRowOffset direction].[col + GetColOffset direction] <- currPlayer
        gameBoard.[row].[col] <- " "
        success <- true
    if(success)then true
    else false

let ChangePlayer (board: string[][]) = 
    if(currPlayer = "1") then currPlayer <- "2"
    else currPlayer <- "1"

let CheckWinner (board: string[][]) = 
    for i in 0..4 do
        if(gameBoard.[0].[i] = "N")then
            winner <- "1"
    for i in 0..4 do
        if(gameBoard.[4].[i] = "N")then
            winner <- "2"
    if(winner <> " ")then
        Console.WriteLine("Player " + winner + " controls the Neutron!")
        PrintBoard board

[<EntryPoint>]
let main argv = 
    let mutable validInput = false

    //display game rules
    Console.WriteLine("Neutron rules: Players take turns moving the Neutron (N) followed by")
    Console.WriteLine("moving a soldier (1 and 2). The Neutron is not moved on the first turn.")
    Console.WriteLine("Soldiers and the Neutron can move one space orthogonal or diagonal.")
    Console.WriteLine("The winner is the player who has the Neutron on their home row")
    Console.WriteLine("Press enter to continue")
    Console.ReadLine() |> ignore
    Console.WriteLine()

    
    //normal game loop
    while(winner = " ")do
        let mutable direction = 1
        let mutable row = -1
        let mutable col = -1
        
        //PrintBoard gameBoard
        Console.WriteLine("It is player " + currPlayer + "'s turn.")
        if(firstTurn = false)then
            //move neutron
            while(validInput = false)do
                PrintBoard gameBoard
                Console.WriteLine("Select a direction to move the Neutron (1-8).")
                PrintDirection gameBoard
                direction <- System.Int32.Parse(Console.ReadLine())
                //if the neutron was able to be moved
                if(MoveNeutron gameBoard direction)then
                    validInput <- true
                else
                    Console.WriteLine("You can't move the Neutron there.")
            validInput <- false
        while(validInput = false)do
            PrintBoard gameBoard
            Console.WriteLine("Select a Soldier.")
            Console.Write("Select a row: 0-4 ")
            row <- System.Int32.Parse(Console.ReadLine())
            Console.Write("Select a column: 0-4 ")
            col <- System.Int32.Parse(Console.ReadLine())

            if((row < 0 || row > 4) || col < 0 || col > 4) then
                Console.WriteLine("Invalid input(s) for row/column.")
            else
                //move unit
                if(gameBoard.[row].[col] = currPlayer)then
                    Console.WriteLine("Select a direction to move your soldier.")
                    PrintDirection gameBoard
                    direction <- System.Int32.Parse(Console.ReadLine())
                    if(MoveSoldier gameBoard row col direction)then
                        validInput <- true
                    else
                        Console.WriteLine("You can't move to that location.")
                else
                    Console.WriteLine("You must select a soldier you control.")
        //check if neutron is on row 0 or 4
        CheckWinner gameBoard
        ChangePlayer gameBoard
        validInput <- false
        firstTurn <- false
        
    Console.ReadKey() |> ignore
    0 // return an integer exit code
