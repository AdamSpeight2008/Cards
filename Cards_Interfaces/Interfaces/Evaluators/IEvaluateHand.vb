Imports Cards_Interfaces.Interfaces.Card
Imports Cards_Interfaces.Interfaces.Hand
Namespace Interfaces.Evaluators
  Public Interface IEvaluateHand(Of Cards As ICard, Out Rt)
    Function Evaluate(ByVal Hand As Hand.IHand(Of Cards)) As Rt
  End Interface
End Namespace
