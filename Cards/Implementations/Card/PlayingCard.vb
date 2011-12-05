Imports Cards_Interfaces.Interfaces.Card


Namespace Implementations.Card


  Public Class PlayingCard
#Region "Implements"
    Implements ICardSuitFace(Of CardFace, CardSuit)
    Implements ICardComparor(Of PlayingCard)
#End Region
#Region "Protected"
    Protected _Face As CardFace
    Protected _Suit As CardSuit
#End Region

#Region "Constructor"
    Public Sub New(Face As CardFace, Suit As CardSuit)
      _Face = CType(Face, CardFace)
      _Suit = CType(Suit, CardSuit)
    End Sub
#End Region

#Region "ToString"
    Public Overrides Function ToString() As String
      Return String.Format("{0} of {1}", [Enum].GetName(GetType(CardFace), Face), [Enum].GetName(GetType(CardSuit), Suit))
    End Function
#End Region

#Region "Properties"
    Public ReadOnly Property Face As CardFace Implements ICardFace(Of CardFace).Face
      Get
        Return _Face
      End Get
    End Property
    Public ReadOnly Property Suit As CardSuit Implements ICardSuit(Of CardSuit).Suit
      Get
        Return _Suit
      End Get
    End Property
#End Region

#Region "Comparision"
    Public Function CompareTo(other As PlayingCard) As Integer Implements IComparable(Of PlayingCard).CompareTo
      Return Me.Face.CompareTo(other.Face)
    End Function
#End Region

#Region "Enums"
    Public Enum CardFace As Integer
      Ace = 1
      Two = 2
      Three = 3
      Four = 4
      Five = 5
      Six = 6
      Seven = 7
      Eight = 8
      Nine = 9
      Ten = 10
      Jack = 11
      Queen = 12
      King = 13
    End Enum
    Public Enum CardSuit As Integer
      Hearts = 1
      Clubs = 2
      Diamonds = 3
      Spades = 4
    End Enum
#End Region

  End Class
End Namespace