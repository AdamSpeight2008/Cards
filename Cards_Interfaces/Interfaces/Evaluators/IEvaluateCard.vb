Namespace Interfaces.Evaluators
  Public Interface IEvaluateCard(Of In ICard, Out Rt)
    Function Evaluate(ByVal Card As ICard) As Rt
  End Interface
End Namespace
