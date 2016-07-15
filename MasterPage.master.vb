
Partial Class MasterPage
	Inherits System.Web.UI.MasterPage


	Protected Sub lbDebug_Click(sender As Object, e As EventArgs) Handles lbDebug.Click
		lDebug.Text = Now.Millisecond.ToString
	End Sub

End Class

