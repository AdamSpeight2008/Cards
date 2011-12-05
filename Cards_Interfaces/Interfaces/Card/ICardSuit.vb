Namespace Interfaces.Card
  Public Interface ICardSuit(Of CardSuit)
    Inherits ICard
    ReadOnly Property Suit As CardSuit
  End Interface
End Namespace