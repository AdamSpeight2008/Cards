Imports Cards_Interfaces.Interfaces.Card
Imports Cards_Interfaces.Interfaces.Cards
Imports Cards_Interfaces.Interfaces.Shuffle
Namespace Implementations.Shuffle

  Public Class RandomShuffle(Of TCards As ICard)
    Implements IShuffle(Of TCards)

    Dim rng As New Random
    Public Iterator Function Shuffle(Cards As ICards) As IEnumerable(Of TCards) _
      Implements IShuffle(Of TCards).Shuffle
      Dim xs = Cards.Cards.ToList()
      Dim rn As Integer = 0
      While xs.Count > 0
        rn = rng.Next(xs.Count)
        Yield CType(xs(rn), TCards)
        xs.RemoveAt(rn)
      End While
    End Function
  End Class
End Namespace