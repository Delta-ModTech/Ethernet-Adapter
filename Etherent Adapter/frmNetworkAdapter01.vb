Imports System.Net.NetworkInformation
Imports System.Management

Public Class frmNetworkAdapter01

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Get a result of WML query 
        Dim Query = New SelectQuery("SELECT * FROM Win32_NetworkAdapter " & "WHERE NetConnectionId != null " & "AND Manufacturer != 'Microsoft' ")
        Dim IsAdapterFound As Boolean = False
        'Create object searcher
        Dim Searcher As New ManagementObjectSearcher(Query)

        'Check to see if there is a name in the text boxe
        If Not txtAdapterName.Text.Length = 0 Then
            'search thru the network adapters for the one we want to disable
            For Each item As ManagementObject In Searcher.[Get]()
                'look for the adapter we are going to disable
                If DirectCast(item("NetConnectionId"), [String]) = txtAdapterName.Text Then
                    lstMessages.Items.Add("Adapter Found it...")
                    Using item
                        item.InvokeMethod("Disable", Nothing)
                        lstMessages.Items.Add("Adapter Disable...")
                        IsAdapterFound = True
                    End Using
                End If
            Next
            'check to see if adapter fountd
            If Not IsAdapterFound Then
                lstMessages.Items.Add("Adapter Not Found...")
            End If
        Else
            MsgBox("Please entry adapter to control first.", MsgBoxStyle.Exclamation, "No Adapter Entry")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Get a result of WML query 
        Dim Query = New SelectQuery("SELECT * FROM Win32_NetworkAdapter " & "WHERE NetConnectionId != null " & "AND Manufacturer != 'Microsoft' ")
        Dim IsAdapterFound As Boolean = False
        'Create object searcher
        Dim Searcher As New ManagementObjectSearcher(Query)
        'Check to see if there is a name in the text boxe
        If Not txtAdapterName.Text.Length = 0 Then
            For Each item As ManagementObject In Searcher.[Get]()
                If DirectCast(item("NetConnectionId"), [String]) = txtAdapterName.Text Then
                    lstMessages.Items.Add("Adapter Found...")
                    Using item
                        item.InvokeMethod("Enable", Nothing, Nothing)
                        lstMessages.Items.Add("Adapter Enable...")
                        IsAdapterFound = True
                    End Using
                End If
            Next
            'check to see if adapter fountd
            If Not IsAdapterFound Then
                lstMessages.Items.Add("Adapter Not Found...")
            End If
        Else
            MsgBox("Please entry adapter to control first.", MsgBoxStyle.Exclamation, "No Adapter Entry")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstMessages.Items.Clear()
    End Sub

    Private Sub cmdSearchAdapters_Click(sender As Object, e As EventArgs) Handles cmdSearchAdapters.Click
        'Get a result of WML query 
        Dim Query = New SelectQuery("SELECT * FROM Win32_NetworkAdapter " & "WHERE NetConnectionId != null " & "AND Manufacturer != 'Microsoft' ")
        'Create object searcher
        Dim Searcher As New ManagementObjectSearcher(Query)
        'Prep the list box
        lstMessages.Items.Add("All Network Adapters...")

        For Each item As ManagementObject In Searcher.[Get]()
            'fill the list box with the adapters
            lstMessages.Items.Add(DirectCast(item("NetConnectionId"), [String]))
        Next
    End Sub

End Class
