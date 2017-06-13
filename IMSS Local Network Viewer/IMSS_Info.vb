Imports System.Net.NetworkInformation

Public Class IMSS_Info
    Friend Shared Function _IMSS_GetGetewayIpAddressLocal() As String
        Dim NetworkAdapters() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim myAdapterProps As IPInterfaceProperties = Nothing
        Dim myGateways As GatewayIPAddressInformationCollection = Nothing


        For Each adapter As NetworkInterface In NetworkAdapters
            myAdapterProps = adapter.GetIPProperties
            myGateways = myAdapterProps.GatewayAddresses
            For Each Gateway As GatewayIPAddressInformation In myGateways
                If Not Gateway.Address.ToString = "0.0.0.0" Then
                    Return Gateway.Address.ToString()
                    Exit Function
                End If
            Next Gateway
        Next adapter : Return "192.168.1.1"
    End Function
    Friend ReadOnly Property _IMSS_GatewayIpAddress As String
        Get
            Return _IMSS_GetGetewayIpAddressLocal()
        End Get
    End Property
End Class
