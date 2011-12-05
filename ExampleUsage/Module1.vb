#Region "Options"
Option Explicit On
Option Strict On
Option Infer On
#End Region

#Region "Imports"
Imports Cards.Implementations.Card
Imports Cards.Implementations.Deck
Imports Cards.Implementations.Generators
'Imports Cards.Implementations.Evaluators.Card
Imports Cards.Implementations.Shuffle
Imports Cards.Implementations.Hand
Imports Cards.Implementations.Evaluators
Imports Cards_Interfaces.Interfaces
Imports Console_Read_Stuff
#End Region

Module Module1

  Sub Main()
    Dim Deck = New PlayingCards_Gen().GenerateDeck
    Dim s As New RandomShuffle(Of PlayingCard)
    Deck.Shuffle(s)
    Dim BlackJackCard_Eval As New Cards.Implementations.Evaluators.Card.BlackJack_Card(True)
    Dim BlackJackHand_Eval As New Cards.Implementations.Evaluators.Hands.BlackJack_Hand(True)
    Dim DealerHand As New Hand(Of PlayingCard)(5)
    Dim MyHand As New Hand(Of PlayingCard)(5)
    For i = 1 To 2
      MyHand.AddCard(Deck.Deal)
      DealerHand.AddCard(Deck.Deal)
    Next
    Dim YourHandScores = 0
    While YourHandScores <= 21 AndAlso MyHand.CardCount < 5
      Console.WriteLine()
      ShowHand(MyHand)
      YourHandScores = BlackJackHand_Eval.Evaluate(MyHand)
      Console.WriteLine("Score: {0}", YourHandScores)
      If YourHandScores > 21 Then Exit While
      Console.Write("Stick? ")
      Dim r = Console_Read_Stuff.WaitForYesNo(5000, True)
      If Char.ToUpper(r.KeyChar) = "Y" Then Exit While
      MyHand.AddCard(Deck.Deal)
    End While
    Console.WriteLine()
    If YourHandScores <= 21 Then
      Console.WriteLine("Dealer's Hand")
      ShowHand(DealerHand)
      Dim rng As New Random
      Dim DealerHandScores = BlackJackHand_Eval.Evaluate(DealerHand)
      While DealerHandScores < 15 AndAlso DealerHand.CardCount < 5
        If rng.NextDouble > 0.97 Then Exit While
        Console.WriteLine("Dealer takes a card")
        DealerHand.AddCard(Deck.Deal)
        ShowHand(DealerHand)
        DealerHandScores = BlackJackHand_Eval.Evaluate(DealerHand)
        Console.WriteLine("Dealer: {0}", DealerHandScores)
      End While
      If DealerHandScores > 21 Then
        Console.WriteLine("Dealer Bust. You Win!")
      ElseIf DealerHandScores < YourHandScores Then
        Console.WriteLine("You Win")
      Else
        Console.WriteLine("Dealer Wins")
      End If
    Else
      Console.WriteLine("You Bust. Dealer Wins!")
    End If

    '        Dim BlackJackHand_Eval As New Cards.Implementations.Evaluators.Hands.BlackJack_Hand(True)
    'Dim Score = BlackJackHand_Eval.Evaluate(MyHand)

  End Sub

  Public Sub ShowHand(Of TCards As Cards_Interfaces.Interfaces.Card.ICard)(ByVal thisHand As Hand.IHand(Of TCards))
    For Each c In thisHand.Cards
      Console.WriteLine(c.ToString)
    Next
    Console.WriteLine()

  End Sub

End Module