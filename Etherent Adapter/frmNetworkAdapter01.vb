Imports System.Net.NetworkInformation
Imports System.Management

Public Class frmNetworkAdapter01
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Get a result of WML query 
        Dim Query = New SelectQuery("SELECT * FROM Win32_NetworkAdapter " & "WHERE NetConnectionId != null " & "AND Manufacturer != 'Microsoft' ")

        'Create object searcher
        Dim Searcher As New ManagementObjectSearcher(Query)

        For Each item As ManagementObject In Searcher.[Get]()
            'Add items to the list box
            lstMessages.Items.Add(DirectCast(item("NetConnectionId"), [String]))

            If DirectCast(item("NetConnectionId"), [String]) = "Printer" Then
                lstMessages.Items.Add("Found Disable it...")
                Using item
                    item.InvokeMethod("Disable", Nothing)
                    lstMessages.Items.Add("Disable...")
                End Using
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Get a result of WML query 
        Dim Query = New SelectQuery("SELECT * FROM Win32_NetworkAdapter " & "WHERE NetConnectionId != null " & "AND Manufacturer != 'Microsoft' ")

        'Create object searcher
        Dim Searcher As New ManagementObjectSearcher(Query)

        For Each item As ManagementObject In Searcher.[Get]()
            If DirectCast(item("NetConnectionId"), [String]) = "Printer" Then
                lstMessages.Items.Add("Found Enable it...")
                Using item
                    item.InvokeMethod("Enable", Nothing)
                    lstMessages.Items.Add("Enable...")
                End Using
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lstMessages.Items.Clear()
    End Sub

End Class
