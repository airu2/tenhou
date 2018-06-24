Imports System.Runtime.InteropServices
Imports System.Text

Public Class inifileaccess
    <DllImport("KERNEL32.DLL")>
    Public Shared Function WritePrivateProfileString(
ByVal lpAppName As String,
ByVal lpKeyName As String,
ByVal lpString As String,
ByVal lpFileName As String) As Integer
    End Function
    ' ANSI版 GetPrivateProfileString
    Public Declare Function GetPrivateProfileString Lib "kernel32" _
        Alias "GetPrivateProfileStringA" (
        <MarshalAs(UnmanagedType.LPStr)> ByVal lpApplicationName As String,
        <MarshalAs(UnmanagedType.LPStr)> ByVal lpKeyName As String,
        <MarshalAs(UnmanagedType.LPStr)> ByVal lpDefault As String,
        <MarshalAs(UnmanagedType.LPStr)> ByVal lpReturnedString As StringBuilder,
        ByVal nSize As UInt32,
        <MarshalAs(UnmanagedType.LPStr)> ByVal lpFileName As String) As UInt32

    <DllImport("KERNEL32.DLL", CharSet:=CharSet.Auto)>
    Public Shared Function GetPrivateProfileInt(
ByVal lpAppName As String,
ByVal lpKeyName As String, ByVal nDefault As Integer,
ByVal lpFileName As String) As Integer
    End Function
End Class
