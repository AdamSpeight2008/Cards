Namespace Interfaces.Card
  Public Interface ICardSuitFace(Of CardFace, CardSuit)
    Inherits ICardFace(Of CardFace)
    Inherits ICardSuit(Of CardSuit)
    Inherits ICard
  End Interface
End Namespace
