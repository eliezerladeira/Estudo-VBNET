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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSubResultado = New System.Windows.Forms.TextBox()
        Me.btnSubtrair = New System.Windows.Forms.Button()
        Me.txtSub2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSub1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMultResultado = New System.Windows.Forms.TextBox()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.txtMult2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMult1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDivResultado = New System.Windows.Forms.TextBox()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.txtDiv2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiv1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpCalculadora.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.lblAviso.Location = New System.Drawing.Point(12, 409)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(39, 13)
        Me.lblAviso.TabIndex = 1
        Me.lblAviso.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSubResultado)
        Me.GroupBox1.Controls.Add(Me.btnSubtrair)
        Me.GroupBox1.Controls.Add(Me.txtSub2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSub1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subtração"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Resultado"
        '
        'txtSubResultado
        '
        Me.txtSubResultado.Enabled = False
        Me.txtSubResultado.Location = New System.Drawing.Point(370, 44)
        Me.txtSubResultado.Name = "txtSubResultado"
        Me.txtSubResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtSubResultado.TabIndex = 5
        '
        'btnSubtrair
        '
        Me.btnSubtrair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtrair.Location = New System.Drawing.Point(261, 41)
        Me.btnSubtrair.Name = "btnSubtrair"
        Me.btnSubtrair.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtrair.TabIndex = 4
        Me.btnSubtrair.Text = "="
        Me.btnSubtrair.UseVisualStyleBackColor = True
        '
        'txtSub2
        '
        Me.txtSub2.Location = New System.Drawing.Point(153, 44)
        Me.txtSub2.Name = "txtSub2"
        Me.txtSub2.Size = New System.Drawing.Size(71, 20)
        Me.txtSub2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor 2"
        '
        'txtSub1
        '
        Me.txtSub1.Location = New System.Drawing.Point(36, 44)
        Me.txtSub1.Name = "txtSub1"
        Me.txtSub1.Size = New System.Drawing.Size(69, 20)
        Me.txtSub1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Valor 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtMultResultado)
        Me.GroupBox2.Controls.Add(Me.btnMultiplicar)
        Me.GroupBox2.Controls.Add(Me.txtMult2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtMult1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 94)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multiplicação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 26)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Resultado"
        '
        'txtMultResultado
        '
        Me.txtMultResultado.Enabled = False
        Me.txtMultResultado.Location = New System.Drawing.Point(370, 44)
        Me.txtMultResultado.Name = "txtMultResultado"
        Me.txtMultResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtMultResultado.TabIndex = 5
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicar.Location = New System.Drawing.Point(261, 41)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 4
        Me.btnMultiplicar.Text = "="
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'txtMult2
        '
        Me.txtMult2.Location = New System.Drawing.Point(153, 44)
        Me.txtMult2.Name = "txtMult2"
        Me.txtMult2.Size = New System.Drawing.Size(71, 20)
        Me.txtMult2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(150, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Valor 2"
        '
        'txtMult1
        '
        Me.txtMult1.Location = New System.Drawing.Point(36, 44)
        Me.txtMult1.Name = "txtMult1"
        Me.txtMult1.Size = New System.Drawing.Size(69, 20)
        Me.txtMult1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Valor 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtDivResultado)
        Me.GroupBox3.Controls.Add(Me.btnDividir)
        Me.GroupBox3.Controls.Add(Me.txtDiv2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDiv1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(510, 94)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Divisão"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(119, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 26)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "/"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Resultado"
        '
        'txtDivResultado
        '
        Me.txtDivResultado.Enabled = False
        Me.txtDivResultado.Location = New System.Drawing.Point(370, 44)
        Me.txtDivResultado.Name = "txtDivResultado"
        Me.txtDivResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtDivResultado.TabIndex = 5
        '
        'btnDividir
        '
        Me.btnDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDividir.Location = New System.Drawing.Point(261, 41)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 4
        Me.btnDividir.Text = "="
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'txtDiv2
        '
        Me.txtDiv2.Location = New System.Drawing.Point(153, 44)
        Me.txtDiv2.Name = "txtDiv2"
        Me.txtDiv2.Size = New System.Drawing.Size(71, 20)
        Me.txtDiv2.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(150, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Valor 2"
        '
        'txtDiv1
        '
        Me.txtDiv1.Location = New System.Drawing.Point(36, 44)
        Me.txtDiv1.Name = "txtDiv1"
        Me.txtDiv1.Size = New System.Drawing.Size(69, 20)
        Me.txtDiv1.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Valor 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(536, 426)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpCalculadora)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora Natural"
        Me.grpCalculadora.ResumeLayout(False)
        Me.grpCalculadora.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSubResultado As TextBox
    Friend WithEvents btnSubtrair As Button
    Friend WithEvents txtSub2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSub1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMultResultado As TextBox
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents txtMult2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMult1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDivResultado As TextBox
    Friend WithEvents btnDividir As Button
    Friend WithEvents txtDiv2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDiv1 As TextBox
    Friend WithEvents Label12 As Label
End Class
