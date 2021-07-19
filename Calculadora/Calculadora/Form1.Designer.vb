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
        Me.lblSomar = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.lblValor2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.lblValor1 = New System.Windows.Forms.Label()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.grpCalculadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCalculadora
        '
        Me.grpCalculadora.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grpCalculadora.Controls.Add(Me.lblSomar)
        Me.grpCalculadora.Controls.Add(Me.lblResultado)
        Me.grpCalculadora.Controls.Add(Me.txtResultado)
        Me.grpCalculadora.Controls.Add(Me.btnSomar)
        Me.grpCalculadora.Controls.Add(Me.txtValor2)
        Me.grpCalculadora.Controls.Add(Me.lblValor2)
        Me.grpCalculadora.Controls.Add(Me.txtValor1)
        Me.grpCalculadora.Controls.Add(Me.lblValor1)
        Me.grpCalculadora.Location = New System.Drawing.Point(12, 12)
        Me.grpCalculadora.Name = "grpCalculadora"
        Me.grpCalculadora.Size = New System.Drawing.Size(510, 94)
        Me.grpCalculadora.TabIndex = 0
        Me.grpCalculadora.TabStop = False
        Me.grpCalculadora.Text = "Soma"
        '
        'lblSomar
        '
        Me.lblSomar.AutoSize = True
        Me.lblSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSomar.Location = New System.Drawing.Point(119, 44)
        Me.lblSomar.Name = "lblSomar"
        Me.lblSomar.Size = New System.Drawing.Size(25, 26)
        Me.lblSomar.TabIndex = 7
        Me.lblSomar.Text = "+"
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
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(370, 44)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 5
        '
        'btnSomar
        '
        Me.btnSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSomar.Location = New System.Drawing.Point(261, 41)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(75, 23)
        Me.btnSomar.TabIndex = 4
        Me.btnSomar.Text = "="
        Me.btnSomar.UseVisualStyleBackColor = True
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
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(36, 44)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(69, 20)
        Me.txtValor1.TabIndex = 1
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
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Location = New System.Drawing.Point(9, 121)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(39, 13)
        Me.lblAviso.TabIndex = 1
        Me.lblAviso.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblAviso)
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
    Friend WithEvents btnSomar As Button
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents lblValor2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents lblValor1 As Label
    Friend WithEvents lblAviso As Label
End Class
