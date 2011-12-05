Namespace Interfaces.Deck
  Public Interface IDeck(Of Cards As Card.ICard)
    Inherits Interfaces.Cards.ICards
    Inherits Interfaces.Cards.IShuffable(Of Cards)
    Function Deal() As Cards
    Sub ReturnCard(thisCard As Cards)
    Function CardsLeft() As Integer
  End Interface
End Namespace
