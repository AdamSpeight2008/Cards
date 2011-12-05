Namespace Interfaces.Hand
  Public Interface IHand(Of Cards As Card.ICard)
    Inherits Interfaces.Cards.ICards
    Inherits Interfaces.Cards.IShuffable(Of Cards)

    Function MaxCardsInHand() As Integer
    Function RemoveCard(ByVal Card As Cards) As Cards
    Function CardCount() As Integer
    Function AddCard(ByVal Card As Cards) As Boolean
  End Interface
End Namespace