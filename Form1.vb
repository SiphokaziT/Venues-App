Option Explicit On
Option Strict On


Public Class Form1

    Dim Numvenues As Integer

    Dim AverageProfit As Double
    Dim TotalProfit As Integer
    Dim max As Double
    Dim count As Integer
    Private Venuesarr() As Venue

    Private Structure Venue


        Public VenueName As String
        Public Location As String
        Public Maximum As Integer
        Public Artist As Integer
        Public Profit As Integer


    End Structure
    Private Sub PlaceOnGrid(r As Integer, c As Integer, t As String)
        gridVenue.Row = r
        gridVenue.Col = c
        gridVenue.Text = t

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalProfit = 0


    End Sub
    Private Sub btnNumVenues_Click(sender As Object, e As EventArgs) Handles btnNumVenues.Click
        Numvenues = CInt(InputBox("enter the number of venues to monitor"))

        ReDim venuesarr(Numvenues)
        gridVenue.Rows = Numvenues + 1
        gridVenue.Cols = 5

        PlaceOnGrid(0, 1, "Venue Name")
        PlaceOnGrid(0, 2, "Location")
        PlaceOnGrid(0, 3, "Maximum")
        PlaceOnGrid(0, 4, "Artist employed")

        For i = 1 To Numvenues
            PlaceOnGrid(i, 0, "Venue:" + CStr(i))

        Next

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click


        For i = 1 To Numvenues

            Venuesarr(i).VenueName = InputBox("what is the name of this book?")
            Venuesarr(i).Location = InputBox("what is the Genre of this book?")
            Venuesarr(i).Maximum = CInt(InputBox("How many pages does this book have?"))
            Venuesarr(i).Artist = CInt(InputBox("what is the Price of this book?"))
        Next

    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click


        For i = 1 To Numvenues
            PlaceOnGrid(i, 1, Venuesarr(i).VenueName)
            PlaceOnGrid(i, 2, Venuesarr(i).Location)
            PlaceOnGrid(i, 3, CStr(Venuesarr(i).Maximum))
            PlaceOnGrid(i, 4, CStr(Venuesarr(i).Artist))
        Next


    End Sub
    Private Sub btnTotalProfit_Click(sender As Object, e As EventArgs) Handles btnTotalProfit.Click

        TotalProfit = 0
        For i = 1 To Numvenues
            TotalProfit = TotalProfit + Venuesarr(i).Profit
        Next


        txtTotalProfit.Text = CStr(TotalProfit)
    End Sub
    Private Sub btnaverage_Click(sender As Object, e As EventArgs) Handles btnaverage.Click
        AverageProfit = TotalProfit / Numvenues
        txtAverage.Text = CStr(AverageProfit)
    End Sub

    Private Sub btnmaximum_Click(sender As Object, e As EventArgs) Handles btnmaximum.Click
        max = Venuesarr(1).Maximum
        Dim Maxindex = 1

        For i = 1 To Numvenues
            If Venuesarr(i).Profit > max Then
                max = Venuesarr(i).Maximum
                Maxindex = 1
            End If
        Next i
        txtMax.Text = CStr(Maxindex)
    End Sub

    Private Sub btnLess_Click(sender As Object, e As EventArgs) Handles btnLess.Click

        count = 0
        For i = 1 To Numvenues
            If Venuesarr(i).Artist < 3 Then
                count = count + 1
            End If
        Next i

        txtLess.Text = CStr(count)
    End Sub


End Class
