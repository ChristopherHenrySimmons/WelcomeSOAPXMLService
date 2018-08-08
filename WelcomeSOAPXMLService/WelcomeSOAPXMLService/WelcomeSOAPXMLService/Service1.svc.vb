' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.


Imports WelcomeSOAPXMLService

Public Class Service1
    Implements IService1

    'Public Sub New()
    'End Sub

    Public Function Welcome(ByVal yourName As String) As String Implements IService1.Welcome

        Return "Welcome to WCF Web services with SOAP and XML: " & yourName & "!"
    End Function

    Public Function Welcome(value As Integer) As String Implements IService1.Welcome
        Throw New NotImplementedException()
    End Function

    'Public Function Welcome(yourName As String) As String Implements IService1.Welcome
    '    Throw New NotImplementedException()
    'End Function

    'Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
    '    If composite Is Nothing Then
    '        Throw New ArgumentNullException("composite")
    '    End If
    '    If composite.BoolValue Then
    '        composite.StringValue &= "Suffix"
    '    End If
    '    Return composite
    'End Function

End Class
