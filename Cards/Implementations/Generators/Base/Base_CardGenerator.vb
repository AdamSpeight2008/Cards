Imports Cards_Interfaces.Interfaces.Card
Imports Cards_Interfaces.Interfaces.Generators
Imports Cards_Interfaces.Interfaces.Deck
Namespace Implementations.Generators.Base
  Public MustInherit Class CardGenerator(Of Cards As ICard)
    Implements IGenerateDeck(Of Cards)

    Public MustOverride Function GenerateDeck() As IDeck(Of Cards) _
      Implements IGenerateDeck(Of Cards).GenerateDeck

  End Class
End Namespace
