<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCalculadora = New System.Windows.Forms.GroupBox()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblSomar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCalculadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCalculadora
        '
        Me.grpCalculadora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpCalculadora.Controls.Add(Me.lblSomar)
        Me.grpCalculadora.Controls.Add(Me.lblResultado)
        Me.grpCalculadora.Controls.Add(Me.txtResultado)
        Me.grpCalculadora.Controls.Add(Me.Button1)
        Me.grpCalculadora.Controls.Add(Me.txtValor2)
        Me.grpCalculadora.Controls.Add(Me.lblValor2)
        Me.grpCalculadora.Controls.Add(Me.txtValor1)
        Me.grpCalculadora.Controls.Add(Me.lblValor1)
        Me.grpCalculadora.Location = New System.Drawing.Point(12, 12)
        Me.grpCalculadora.Name = "grpCalculadora"
        Me.grpCalculadora.Size = New System.Drawing.Size(510, 82)
        Me.grpCalculadora.TabIndex = 0
        Me.grpCalculadora.TabStop = False
        Me.grpCalculadora.Text = "Soma"
        '
        'lblValor1
        '
        Me.lblValor1.AutoSize = True
        Me.lblValor1.Location = New System.Drawing.Point(33, 28)
        Me.lblValor1.Name = "lblValor1"
        Me.lblValor1.Size = New System.Drawing.Size(40, 13)
        Me.lblValor1.TabIndex = 0
        Me.lblValor1.Text = "Valor 1"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(36, 44)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(69, 20)
        Me.txtValor1.TabIndex = 1
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(153, 44)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(71, 20)
        Me.txtValor2.TabIndex = 3
        '
        'lblValor2
        '
        Me.lblValor2.AutoSize = True
        Me.lblValor2.Location = New System.Drawing.Point(150, 28)
        Me.lblValor2.Name = "lblValor2"
        Me.lblValor2.Size = New System.Drawing.Size(40, 13)
        Me.lblValor2.TabIndex = 2
        Me.lblValor2.Text = "Valor 2"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(264, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "="
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(370, 44)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 5
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(367, 28)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Resultado"
        '
        'lblSomar
        '
        Me.lblSomar.AutoSize = True
        Me.lblSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSomar.Location = New System.Drawing.Point(119, 39)
        Me.lblSomar.Name = "lblSomar"
        Me.lblSomar.Size = New System.Drawing.Size(25, 26)
        Me.lblSomar.TabIndex = 7
        Me.lblSomar.Text = "+"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpCalculadora)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Natural"
        Me.grpCalculadora.ResumeLayout(False)
        Me.grpCalculadora.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCalculadora As GroupBox
    Friend WithEvents lblSomar As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents lblValor2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents lblValor1 As Label
    Friend WithEvents Label1 As Label
End Class
