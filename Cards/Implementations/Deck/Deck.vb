Imports Cards_Interfaces.Interfaces.Card
Imports Cards_Interfaces.Interfaces.Deck
Imports Cards_Interfaces.Interfaces.Cards
Imports Cards_Interfaces.Interfaces.Shuffle

Namespace Implementations.Deck
  Public Class Deck(Of TCards As ICard)
    Implements IDeck(Of TCards)

    Protected _Cards As New Queue(Of TCards)

    Public Sub New(ByVal Cards As IEnumerable(Of TCards))
      _Cards = New Queue(Of TCards)(Cards)
    End Sub

    Public Function CardsLeft() As Integer Implements IDeck(Of TCards).CardsLeft
      Return _Cards.Count
    End Function

    Public Function Deal() As TCards Implements IDeck(Of TCards).Deal
      Return If(Me.CardsLeft() > 0, _Cards.Dequeue, Nothing)
    End Function

    Public Sub ReturnCard(thisCard As TCards) Implements IDeck(Of TCards).ReturnCard
      _Cards.Enqueue(thisCard)
    End Sub


    Public Function Cards() As System.Collections.Generic.IEnumerable(Of ICard) _
      Implements ICards.Cards
      Return _Cards.AsEnumerable
    End Function

    Public Sub Shuffle(Shuffler As IShuffle(Of TCards)) _
      Implements IShuffable(Of TCards).Shuffle
      _Cards = New Queue(Of TCards)(Shuffler.Shuffle(Me))
    End Sub
  End Class
End Namespace
