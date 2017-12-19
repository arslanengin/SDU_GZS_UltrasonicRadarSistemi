Imports System.IO.Ports

Public Class Form2

    Dim port As Array
    Delegate Sub SetTextCallBack(ByVal [text] As String)
    Private Delegate Sub UpdateTextboxDelegate(ByVal myText As String)

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ss.DataReceived
        On Error Resume Next
        Dim myResponse As String = ss.ReadLine
        UpdateTextbox(myResponse)
    End Sub

    Private Sub UpdateTextbox(ByVal myText As String)
        If Me.TextBox1.InvokeRequired Then
            Dim d As New UpdateTextboxDelegate(AddressOf UpdateTextbox)
            Me.TextBox1.Invoke(d, New Object() {myText})
        Else
            TextBox1.Text = myText
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ss.Close()
    End Sub

    Private Sub skaydet()
        Me.Validate()
        Me.VerilersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VeriSDataSet)
        Me.VerilersTableAdapter.Fill(Me.VeriSDataSet.verilers)
    End Sub

    Private Sub mkaydet()
        Me.Validate()
        Me.VerilermBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.VeriMDataSet)
        Me.VerilermTableAdapter.Fill(Me.VeriMDataSet.verilerm)
    End Sub

    Private Sub listele()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each u In My.Settings.user
            ListBox1.Items.Add(u)
        Next
        For Each p In My.Settings.pass
            ListBox2.Items.Add(p)
        Next
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F8 Then
            Dim cvp = InputBox("Yeni başlığı yazınız", "Başlık Değiştirme")
            If cvp.Length > 2 Then
                Me.Text = cvp
                My.Settings.baslik = cvp
            End If
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Settings.baslik
        'TODO: This line of code loads data into the 'VeriMDataSet.verilerm' table. You can move, or remove it, as needed.
        Me.VerilermTableAdapter.Fill(Me.VeriMDataSet.verilerm)
        'TODO: This line of code loads data into the 'VeriNDataSet.verilern' table. You can move, or remove it, as needed.
        Me.VerilernTableAdapter.Fill(Me.VeriNDataSet.verilern)
        'TODO: This line of code loads data into the 'VeriSDataSet.verilers' table. You can move, or remove it, as needed.
        Me.VerilersTableAdapter.Fill(Me.VeriSDataSet.verilers)
        ss.PortName = My.Settings.port
        listele()
        ss.Open()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = "" Then
            If TextBox1.Text.Contains("derece:") = True Then
                Dim l, d As Integer
                Dim msj As String() = Split(TextBox1.Text, ":")
                d = msj(1)
                l = Label4.Text
                Label2.Text = d
                If d > l Then
                    VerilersBindingSource.AddNew()
                    VerilersDataGridView.CurrentRow.Cells(0).Value = Label4.Text
                    VerilersDataGridView.CurrentRow.Cells(1).Value = Label2.Text
                    VerilersDataGridView.CurrentRow.Cells(2).Value = Now.ToShortDateString
                    VerilersDataGridView.CurrentRow.Cells(3).Value = Now.ToShortTimeString
                    skaydet()
                    ss.Write("SCK")
                End If
            End If

            If TextBox1.Text.Contains("mesafe:") = True Then
                Dim l, d As Integer
                Dim msj As String() = Split(TextBox1.Text, ":")
                d = msj(1)
                l = Label9.Text
                Label11.Text = d
                If d < l Then
                    VerilermBindingSource.AddNew()
                    VerilermDataGridView.CurrentRow.Cells(0).Value = Label9.Text
                    VerilermDataGridView.CurrentRow.Cells(1).Value = Label11.Text
                    VerilermDataGridView.CurrentRow.Cells(2).Value = Now.ToShortDateString
                    VerilermDataGridView.CurrentRow.Cells(3).Value = Now.ToShortTimeString
                    mkaydet()
                    ss.Write("MES")
                End If
            End If

            If TextBox1.Text.Contains("aydinlik:") = True Then
                Dim d As Integer
                Dim msj As String() = Split(TextBox1.Text, ":")
                d = msj(1)
                Label13.Text = "% " & d
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cvp = InputBox("Yeni Limit Sıcaklığı Yazınız", "Limit Değişimi")
        Label4.Text = cvp
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim cvp = InputBox("Yeni Limit Nem Yazınız", "Limit Değişimi")
        Label5.Text = cvp
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cvp = InputBox("Yeni Limit Mesafeyi Yazınız", "Limit Değişimi")
        Label9.Text = cvp
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex >= 0 Then
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex >= 0 Then
            ListBox1.SelectedIndex = ListBox2.SelectedIndex
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cvp = MsgBox("Seçili kayıt silinecek", MsgBoxStyle.YesNo, "Dikkat")
        If cvp = MsgBoxResult.Yes Then
            My.Settings.pass.RemoveAt(ListBox1.SelectedIndex)
            My.Settings.user.RemoveAt(ListBox1.SelectedIndex)
            My.Settings.Save()
            listele()
            ListBox1.SelectedIndex = -1
        End If
       
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cvpa = InputBox("Kullanıcı Adını Yazınız", "Kullanıcı Ekleme")
        If cvpa.Length > 1 Then
            Dim cvpb = InputBox("Prolayı Yazınız", "Kullanıcı Ekleme")
            If cvpb.Length > 1 Then
                My.Settings.user.Add(cvpa)
                My.Settings.pass.Add(cvpb)
                My.Settings.Save()
                listele()
                ListBox1.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            If VerilersDataGridView.RowCount > 0 Then
                VerilersBindingSource.Filter = "tarih = '" & Now.ToShortDateString & "'"
            End If
        Else
            VerilersBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            If VerilermDataGridView.RowCount > 0 Then
                VerilermBindingSource.Filter = "tarih = '" & Now.ToShortDateString & "'"
            End If
        Else
            VerilermBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ss.Write("TRA")
        Else
            ss.Write("TRK")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ss.IsOpen = True Then
            ss.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        ss.Write("BIR" & TextBox2.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ss.Write("IKI" & TextBox3.Text)
    End Sub
End Class