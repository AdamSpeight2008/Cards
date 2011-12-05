Namespace Interfaces.Shuffle
  Public Interface IShuffle(Of TCards As Interfaces.Card.ICard)
    Function Shuffle(Cards As Interfaces.Cards.ICards) As IEnumerable(Of TCards)
  End Interface
End Namespace