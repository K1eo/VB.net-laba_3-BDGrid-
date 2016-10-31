Imports System.Data.OleDb


Public Class Access
    Private Sub Add1_Click(sender As Object, e As EventArgs) Handles Add1.Click
        FAdd.ShowDialog()
        Dim string1, string2, string3 As String
        Dim res As DialogResult
        string1 = FAdd.TB1.Text
        string2 = FAdd.TB2.Text
        string3 = FAdd.TB3.Text
        res = FAdd.DialogResult
        FAdd.Close()

        If res <> DialogResult.OK Then
            Exit Sub
        End If

        Dim c As New OleDbCommand
            c.Connection = conn
        c.CommandText = "insert into Пряма_у_просторі (coefficients_ABC,Name,color_straight) values('" & string1 & "','" & string2 & "','" & string3 & "')"
        c.ExecuteNonQuery()

            refGrip()
    End Sub

    Private Sub Open1_Click(sender As Object, e As EventArgs) Handles Open1.Click
        refGrip()
    End Sub
    ' оновлення на формі БАЗИ ДАНИХ
    Private Sub refGrip()
        Dim c As New OleDbCommand
        c.Connection = conn                                  ' зєднуємось з базою даних
        c.CommandText = "select * from Пряма_у_просторі"      ' задаєм з якої таблиці в базі даних будемо зчитувати інформацію


        Dim ds As New DataSet                                 ' обєкт який хранить n-кількість таблиці в цей обєкт ми занисим певну таблицю яку вказали в ConnetcionText
        Dim da As New OleDbDataAdapter(c)                     '
        da.Fill(ds, "Пряма_у_просторі")
        DataGrid1.DataSource = ds
        DataGrid1.DataMember = "Пряма_у_просторі"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Валентин\Documents\BazaStraight.accdb;Persist Security Info=False;" 'задаємо параметри і адрес до бази даних
        conn.Open()                 'зчитуємо з бази даних
    End Sub

    Private Sub Delete1_Click(sender As Object, e As EventArgs) Handles Delete1.Click
        Dim index As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        index = DataGrid1.CurrentRow.Cells("i").Value
        c.CommandText = "delete from Пряма_у_просторі where i = " & index
        c.ExecuteNonQuery()
        refGrip()
    End Sub
End Class
