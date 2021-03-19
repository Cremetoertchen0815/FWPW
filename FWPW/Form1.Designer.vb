<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RmBtnA = New System.Windows.Forms.Button()
        Me.AddBtnA = New System.Windows.Forms.Button()
        Me.KatA_SA = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RmBtnB = New System.Windows.Forms.Button()
        Me.AddBtnB = New System.Windows.Forms.Button()
        Me.KatB_SA = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(74, 446)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(282, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Algorithmus"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 68)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Berechnen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(350, 434)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kategorie A"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kategorie B"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "X.te Wahl"
        Me.ColumnHeader3.Width = 100
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(372, 588)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(364, 562)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hinzufügen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(364, 562)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Einstellen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListView1)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.ComboBox3)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(364, 562)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Berechnen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RmBtnA)
        Me.GroupBox2.Controls.Add(Me.AddBtnA)
        Me.GroupBox2.Controls.Add(Me.KatA_SA)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 279)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategorie A"
        '
        'RmBtnA
        '
        Me.RmBtnA.Location = New System.Drawing.Point(87, 250)
        Me.RmBtnA.Name = "RmBtnA"
        Me.RmBtnA.Size = New System.Drawing.Size(75, 23)
        Me.RmBtnA.TabIndex = 10
        Me.RmBtnA.Text = "Entfernen"
        Me.RmBtnA.UseVisualStyleBackColor = True
        '
        'AddBtnA
        '
        Me.AddBtnA.Location = New System.Drawing.Point(6, 250)
        Me.AddBtnA.Name = "AddBtnA"
        Me.AddBtnA.Size = New System.Drawing.Size(75, 23)
        Me.AddBtnA.TabIndex = 9
        Me.AddBtnA.Text = "Hinzufügen"
        Me.AddBtnA.UseVisualStyleBackColor = True
        '
        'KatA_SA
        '
        Me.KatA_SA.Dock = System.Windows.Forms.DockStyle.Top
        Me.KatA_SA.FormattingEnabled = True
        Me.KatA_SA.Location = New System.Drawing.Point(3, 16)
        Me.KatA_SA.Name = "KatA_SA"
        Me.KatA_SA.Size = New System.Drawing.Size(352, 225)
        Me.KatA_SA.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RmBtnB)
        Me.GroupBox1.Controls.Add(Me.AddBtnB)
        Me.GroupBox1.Controls.Add(Me.KatB_SA)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 277)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategorie B"
        '
        'RmBtnB
        '
        Me.RmBtnB.Location = New System.Drawing.Point(87, 248)
        Me.RmBtnB.Name = "RmBtnB"
        Me.RmBtnB.Size = New System.Drawing.Size(75, 23)
        Me.RmBtnB.TabIndex = 10
        Me.RmBtnB.Text = "Entfernen"
        Me.RmBtnB.UseVisualStyleBackColor = True
        '
        'AddBtnB
        '
        Me.AddBtnB.Location = New System.Drawing.Point(6, 248)
        Me.AddBtnB.Name = "AddBtnB"
        Me.AddBtnB.Size = New System.Drawing.Size(75, 23)
        Me.AddBtnB.TabIndex = 9
        Me.AddBtnB.Text = "Hinzufügen"
        Me.AddBtnB.UseVisualStyleBackColor = True
        '
        'KatB_SA
        '
        Me.KatB_SA.Dock = System.Windows.Forms.DockStyle.Top
        Me.KatB_SA.FormattingEnabled = True
        Me.KatB_SA.Location = New System.Drawing.Point(3, 16)
        Me.KatB_SA.Name = "KatB_SA"
        Me.KatB_SA.Size = New System.Drawing.Size(352, 225)
        Me.KatB_SA.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RmBtnB As Button
    Friend WithEvents AddBtnB As Button
    Friend WithEvents KatB_SA As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RmBtnA As Button
    Friend WithEvents AddBtnA As Button
    Friend WithEvents KatA_SA As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
