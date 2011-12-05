Imports Cards_Interfaces.Interfaces.Card
Imports Cards_Interfaces.Interfaces.Hand

Namespace Implementations.Hand
  Public Class Hand(Of TCards As ICard)
    Implements IHand(Of TCards)

    Private _MaxCount As Integer
    Private _Cards As New List(Of TCards)

    Public Sub New(ByVal MaxCount As Integer)
      _MaxCount = MaxCount
    End Sub

    Public Function Cards() As System.Collections.Generic.IEnumerable(Of Cards_Interfaces.Interfaces.Card.ICard) Implements Cards_Interfaces.Interfaces.Cards.ICards.Cards
      Return _Cards.AsEnumerable
    End Function

    Public Sub Shuffle(Shuffler As Cards_Interfaces.Interfaces.Shuffle.IShuffle(Of TCards)) Implements Cards_Interfaces.Interfaces.Cards.IShuffable(Of TCards).Shuffle
      _Cards = New List(Of TCards)(Shuffler.Shuffle(Me))
    End Sub

    Public Function AddCard(Card As TCards) As Boolean Implements Cards_Interfaces.Interfaces.Hand.IHand(Of TCards).AddCard
      If CardCount() = _MaxCount Then Return False
      _Cards.Add(Card)
      Return True
    End Function

    Public Function CardCount() As Integer Implements Cards_Interfaces.Interfaces.Hand.IHand(Of TCards).CardCount
      Return _Cards.Count
    End Function

    Public Function MaxCardsInHand() As Integer Implements Cards_Interfaces.Interfaces.Hand.IHand(Of TCards).MaxCardsInHand
      Return _MaxCount
    End Function

    Public Function RemoveCard(Card As TCards) As TCards Implements Cards_Interfaces.Interfaces.Hand.IHand(Of TCards).RemoveCard
      Return If(_Cards.Remove(Card), Card, Nothing)
    End Function

  End Class
End Namespace