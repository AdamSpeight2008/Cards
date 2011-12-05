Imports Cards_Interfaces.Interfaces.Evaluators
Imports Cards.Implementations.Card

Namespace Implementations.Evaluators.Card
  Public Class BlackJack_Card
    Implements IEvaluateCard(Of PlayingCard, Integer)

    Private _AcesHigh As Boolean = True
    Public Sub New(Optional AcesHigh As Boolean = True)
      _AcesHigh = AcesHigh
    End Sub
    Public ReadOnly Property AcesHigh As Boolean
      Get
        Return _AcesHigh
      End Get
    End Property

    Public Function Evaluate(Card As PlayingCard) As Integer Implements IEvaluateCard(Of PlayingCard, Integer).Evaluate
      Select Case Card.Face
        Case PlayingCard.CardFace.Ace : Return If(AcesHigh, 11, 1)
        Case Is > PlayingCard.CardFace.Ten : Return 10
        Case Else
          Return Card.Face
      End Select
    End Function
  End Class
End Namespace