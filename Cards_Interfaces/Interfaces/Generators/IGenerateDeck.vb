Namespace Interfaces.Generators
  Public Interface IGenerateDeck(Of Cards As Card.ICard)
    Function GenerateDeck() As Deck.IDeck(Of Cards)
  End Interface
End Namespace
