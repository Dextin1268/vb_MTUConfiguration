<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
     Inherits System.Windows.Forms.Form

     'Form 覆寫 Dispose 以清除元件清單。
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

     '為 Windows Form 設計工具的必要項
     Private components As System.ComponentModel.IContainer

     '注意: 以下為 Windows Form 設計工具所需的程序
     '可以使用 Windows Form 設計工具進行修改。
     '請勿使用程式碼編輯器進行修改。
     <System.Diagnostics.DebuggerStepThrough()> _
     Private Sub InitializeComponent()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.txtSetValue = New System.Windows.Forms.TextBox()
        Me.txtGetValue = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnJumboEnable = New System.Windows.Forms.Button()
        Me.btnJumboDisable = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(136, 125)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(93, 29)
        Me.btnSet.TabIndex = 0
        Me.btnSet.Text = "Set MTU"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(136, 162)
        Me.btnGet.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(93, 29)
        Me.btnGet.TabIndex = 1
        Me.btnGet.Text = "Get MTU"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'txtSetValue
        '
        Me.txtSetValue.Location = New System.Drawing.Point(22, 127)
        Me.txtSetValue.Name = "txtSetValue"
        Me.txtSetValue.Size = New System.Drawing.Size(107, 25)
        Me.txtSetValue.TabIndex = 2
        Me.txtSetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGetValue
        '
        Me.txtGetValue.Location = New System.Drawing.Point(22, 164)
        Me.txtGetValue.Name = "txtGetValue"
        Me.txtGetValue.ReadOnly = True
        Me.txtGetValue.Size = New System.Drawing.Size(107, 25)
        Me.txtGetValue.TabIndex = 3
        Me.txtGetValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(22, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 23)
        Me.ComboBox1.TabIndex = 4
        '
        'btnJumboEnable
        '
        Me.btnJumboEnable.Location = New System.Drawing.Point(22, 51)
        Me.btnJumboEnable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJumboEnable.Name = "btnJumboEnable"
        Me.btnJumboEnable.Size = New System.Drawing.Size(207, 29)
        Me.btnJumboEnable.TabIndex = 5
        Me.btnJumboEnable.Text = "Enable Jumbo Frames"
        Me.btnJumboEnable.UseVisualStyleBackColor = True
        '
        'btnJumboDisable
        '
        Me.btnJumboDisable.Location = New System.Drawing.Point(22, 88)
        Me.btnJumboDisable.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJumboDisable.Name = "btnJumboDisable"
        Me.btnJumboDisable.Size = New System.Drawing.Size(207, 29)
        Me.btnJumboDisable.TabIndex = 6
        Me.btnJumboDisable.Text = "Disable Jumbo Frames"
        Me.btnJumboDisable.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 199)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Get MTU 2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 247)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnJumboDisable)
        Me.Controls.Add(Me.btnJumboEnable)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtGetValue)
        Me.Controls.Add(Me.txtSetValue)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.btnSet)
        Me.Font = New System.Drawing.Font("新細明體", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "MTU Config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSet As Button
    Friend WithEvents btnGet As Button
    Friend WithEvents txtSetValue As TextBox
    Friend WithEvents txtGetValue As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnJumboEnable As Button
    Friend WithEvents btnJumboDisable As Button
    Friend WithEvents Button1 As Button
End Class
