Namespace Interfaces.Cards
  Public Interface ICards
    Function Cards() As IEnumerable(Of Card.ICard)

  End Interface
  Public Interface IShuffable(Of TCards As Card.ICard)
    Sub Shuffle(ByVal Shuffler As Interfaces.Shuffle.IShuffle(Of TCards))
  End Interface
End Namespace

