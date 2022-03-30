<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MP_RollTheDice_ListBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToRollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PressRollButtonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PressExitButtonOrXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.IntegralHeight = False
        Me.DisplayListBox.ItemHeight = 18
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 31)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(463, 119)
        Me.DisplayListBox.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(486, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem
        '
        Me.ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem.Name = "ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStri" &
    "pMenuItem"
        Me.ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem.Size = New System.Drawing.Size(686, 26)
        Me.ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem.Text = "This program ""rolls the dice"" 1000 times, and then displays in a form the results" &
    " of the roll."
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToRollToolStripMenuItem, Me.ToExitToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(137, 26)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ToRollToolStripMenuItem
        '
        Me.ToRollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PressRollButtonToolStripMenuItem})
        Me.ToRollToolStripMenuItem.Name = "ToRollToolStripMenuItem"
        Me.ToRollToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.ToRollToolStripMenuItem.Text = "To Roll"
        '
        'PressRollButtonToolStripMenuItem
        '
        Me.PressRollButtonToolStripMenuItem.Name = "PressRollButtonToolStripMenuItem"
        Me.PressRollButtonToolStripMenuItem.Size = New System.Drawing.Size(234, 26)
        Me.PressRollButtonToolStripMenuItem.Text = "Press Roll button or R"
        '
        'ToExitToolStripMenuItem
        '
        Me.ToExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PressExitButtonOrXToolStripMenuItem})
        Me.ToExitToolStripMenuItem.Name = "ToExitToolStripMenuItem"
        Me.ToExitToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.ToExitToolStripMenuItem.Text = "To Exit"
        '
        'PressExitButtonOrXToolStripMenuItem
        '
        Me.PressExitButtonOrXToolStripMenuItem.Name = "PressExitButtonOrXToolStripMenuItem"
        Me.PressExitButtonOrXToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.PressExitButtonOrXToolStripMenuItem.Text = "Press Exit button or X"
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(12, 156)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(227, 34)
        Me.RollButton.TabIndex = 2
        Me.RollButton.Tag = ""
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseCompatibleTextRendering = True
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(245, 156)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(230, 34)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MP_RollTheDice_ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 193)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MP_RollTheDice_ListBox"
        Me.Text = "MP"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThisProgramrollsTheDice1000TimesAndThenDisplaysInAFormTheResultsOfTheRollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToRollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PressRollButtonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PressExitButtonOrXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RollButton As Button
    Friend WithEvents ExitButton As Button
End Class
