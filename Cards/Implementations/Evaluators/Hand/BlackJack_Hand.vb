Imports Cards_Interfaces.Interfaces.Evaluators
Imports Cards.Implementations.Card
Imports Cards_Interfaces.Interfaces.Hand

Namespace Implementations.Evaluators.Hands
  Public Class BlackJack_Hand
    Implements IEvaluateHand(Of PlayingCard, Integer)

    Private _BlackJackCardEval As Card.BlackJack_Card
    Public Sub New(Optional AcesHigh As Boolean = True)
      _BlackJackCardEval = New Evaluators.Card.BlackJack_Card(AcesHigh)
    End Sub

    Public Function Evaluate(Hand As IHand(Of PlayingCard)) As Integer _
      Implements IEvaluateHand(Of PlayingCard, Integer).Evaluate
      Return Hand.Cards.Sum(Function(Card) _BlackJackCardEval.Evaluate(Card))
    End Function
  End Class
End Namespace