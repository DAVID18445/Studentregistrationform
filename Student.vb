Public Class Student

    ' Private backing fields
    Private _fullName As String = ""
    Private _registrationNumber As String = ""
    Private _programme As String = ""

    ' Full Name property
    Public Property FullName As String
        Get
            Return _fullName
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                _fullName = value.Trim()
            End If
        End Set
    End Property

    ' Registration Number property
    Public Property RegistrationNumber As String
        Get
            Return _registrationNumber
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                _registrationNumber = value.Trim()
            End If
        End Set
    End Property

    ' Programme property
    Public Property Programme As String
        Get
            Return _programme
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                _programme = value.Trim()
            End If
        End Set
    End Property

    ' Validate student details
    Public Function IsValid() As Boolean

        Return Not String.IsNullOrWhiteSpace(_fullName) AndAlso
               Not String.IsNullOrWhiteSpace(_registrationNumber) AndAlso
               Not String.IsNullOrWhiteSpace(_programme)

    End Function

End Class
