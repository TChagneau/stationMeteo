Public Class aidevb
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Comment utiliser?" Then
            RichTextBox1.Text = "            Comment utiliser ce programme?" & vbCrLf
            RichTextBox1.AppendText("--------------------------------------------------------------------" & vbCrLf)
            RichTextBox1.AppendText("Pour utiliser correctement ce programme, il vous suffit de sélectionner un port COM dans la boite de sélection du portCOM." & vbCrLf)
            RichTextBox1.AppendText("Une fois ceci fait, appuyez sur le bouton 'connect' et patientez le temps de la réception des données par le programme." & vbCrLf)

        ElseIf ComboBox1.SelectedItem = "La réception de données" Then
            RichTextBox1.Text = "La réception de données" & vbCrLf
            RichTextBox1.AppendText("-----------------------------------------------------------------" & vbCrLf)
            RichTextBox1.AppendText("Si vous rencontrez une erreur au niveau de la réception de données veuillez verifier plusieurs choses:" & vbCrLf)
            RichTextBox1.AppendText("" & vbCrLf)
            RichTextBox1.AppendText("1 - que le bon port COM soit sélectionné." & vbCrLf)
            RichTextBox1.AppendText("" & vbCrLf)
            RichTextBox1.AppendText("2 - que vous ayez bien un envoi de données sur le port COM, il faut impérativement que votre staion envoie des données sur le port pour que vous puissiez les recevoir." & vbCrLf)
            RichTextBox1.AppendText("" & vbCrLf)
            RichTextBox1.AppendText("3 - Que votre station météo envoie bien les données sous la forme ci-dessous:" & vbCrLf)
            RichTextBox1.AppendText("x est une donnée récoltée à partir des différents capteurs" & vbCrLf)
            RichTextBox1.AppendText("Txxx" & vbCrLf)
            RichTextBox1.AppendText("Hxxx" & vbCrLf)
            RichTextBox1.AppendText("Pxxxx" & vbCrLf)
            RichTextBox1.AppendText("Vxx" & vbCrLf)
            RichTextBox1.AppendText("Dxx" & vbCrLf)


        End If
    End Sub
End Class