Imports Cards.Implementations.Card
Namespace Implementations.Generators
  Public Class PlayingCards_Gen
    Inherits Base.CardGenerator(Of PlayingCard)

    Public Overrides Function GenerateDeck() As Cards_Interfaces.Interfaces.Deck.IDeck(Of Card.PlayingCard)
      Return New Deck.Deck(Of Card.PlayingCard)(
        From suit In [Enum].GetValues(GetType(PlayingCard.CardSuit)).Cast(Of PlayingCard.CardSuit)()
        From face In [Enum].GetValues(GetType(PlayingCard.CardFace)).Cast(Of PlayingCard.CardFace)()
        Select New PlayingCard(face, suit)
        )
    End Function
  End Class
End Namespace
