Public Class ExceptionTemplate1
  Inherits ApplicationException

  Public Sub New()
    MyBase.New()
  End Sub
  Public Sub New(ByVal message As String)
    MyBase.New(message)
  End Sub
  Public Sub New(ByVal message As String, ByVal InnerExecption As Exception)
    MyBase.New(message, InnerExecption)
  End Sub
  Public Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
    MyBase.New(info, context)
  End Sub
End Class
