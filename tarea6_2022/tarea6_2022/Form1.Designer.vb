<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BAmenos = New System.Windows.Forms.Button()
        Me.BAmas = New System.Windows.Forms.Button()
        Me.BBmenos = New System.Windows.Forms.Button()
        Me.BBmas = New System.Windows.Forms.Button()
        Me.Bsuma = New System.Windows.Forms.Button()
        Me.Bresta = New System.Windows.Forms.Button()
        Me.Bmultiplicar = New System.Windows.Forms.Button()
        Me.Bdividir = New System.Windows.Forms.Button()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.LA = New System.Windows.Forms.Label()
        Me.LB = New System.Windows.Forms.Label()
        Me.Lresultado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BAmenos
        '
        Me.BAmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAmenos.Location = New System.Drawing.Point(185, 176)
        Me.BAmenos.Margin = New System.Windows.Forms.Padding(5)
        Me.BAmenos.Name = "BAmenos"
        Me.BAmenos.Size = New System.Drawing.Size(72, 57)
        Me.BAmenos.TabIndex = 0
        Me.BAmenos.Text = "-"
        Me.BAmenos.UseVisualStyleBackColor = True
        '
        'BAmas
        '
        Me.BAmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAmas.Location = New System.Drawing.Point(431, 176)
        Me.BAmas.Margin = New System.Windows.Forms.Padding(5)
        Me.BAmas.Name = "BAmas"
        Me.BAmas.Size = New System.Drawing.Size(72, 57)
        Me.BAmas.TabIndex = 1
        Me.BAmas.Text = "+"
        Me.BAmas.UseVisualStyleBackColor = True
        '
        'BBmenos
        '
        Me.BBmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBmenos.Location = New System.Drawing.Point(185, 331)
        Me.BBmenos.Margin = New System.Windows.Forms.Padding(5)
        Me.BBmenos.Name = "BBmenos"
        Me.BBmenos.Size = New System.Drawing.Size(72, 55)
        Me.BBmenos.TabIndex = 2
        Me.BBmenos.Text = "-"
        Me.BBmenos.UseVisualStyleBackColor = True
        '
        'BBmas
        '
        Me.BBmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBmas.Location = New System.Drawing.Point(431, 342)
        Me.BBmas.Margin = New System.Windows.Forms.Padding(5)
        Me.BBmas.Name = "BBmas"
        Me.BBmas.Size = New System.Drawing.Size(72, 44)
        Me.BBmas.TabIndex = 3
        Me.BBmas.Text = "+"
        Me.BBmas.UseVisualStyleBackColor = True
        '
        'Bsuma
        '
        Me.Bsuma.Location = New System.Drawing.Point(638, 98)
        Me.Bsuma.Margin = New System.Windows.Forms.Padding(5)
        Me.Bsuma.Name = "Bsuma"
        Me.Bsuma.Size = New System.Drawing.Size(125, 35)
        Me.Bsuma.TabIndex = 4
        Me.Bsuma.Text = "Sumar"
        Me.Bsuma.UseVisualStyleBackColor = True
        '
        'Bresta
        '
        Me.Bresta.Location = New System.Drawing.Point(638, 176)
        Me.Bresta.Margin = New System.Windows.Forms.Padding(5)
        Me.Bresta.Name = "Bresta"
        Me.Bresta.Size = New System.Drawing.Size(125, 35)
        Me.Bresta.TabIndex = 5
        Me.Bresta.Text = "Restar"
        Me.Bresta.UseVisualStyleBackColor = True
        '
        'Bmultiplicar
        '
        Me.Bmultiplicar.Location = New System.Drawing.Point(638, 255)
        Me.Bmultiplicar.Margin = New System.Windows.Forms.Padding(5)
        Me.Bmultiplicar.Name = "Bmultiplicar"
        Me.Bmultiplicar.Size = New System.Drawing.Size(125, 35)
        Me.Bmultiplicar.TabIndex = 6
        Me.Bmultiplicar.Text = "Multiplicar"
        Me.Bmultiplicar.UseVisualStyleBackColor = True
        '
        'Bdividir
        '
        Me.Bdividir.Location = New System.Drawing.Point(638, 330)
        Me.Bdividir.Margin = New System.Windows.Forms.Padding(5)
        Me.Bdividir.Name = "Bdividir"
        Me.Bdividir.Size = New System.Drawing.Size(125, 35)
        Me.Bdividir.TabIndex = 7
        Me.Bdividir.Text = "Dividir"
        Me.Bdividir.UseVisualStyleBackColor = True
        '
        'Blimpiar
        '
        Me.Blimpiar.Location = New System.Drawing.Point(638, 410)
        Me.Blimpiar.Margin = New System.Windows.Forms.Padding(5)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(125, 35)
        Me.Blimpiar.TabIndex = 8
        Me.Blimpiar.Text = "Limpiar"
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'LA
        '
        Me.LA.AutoSize = True
        Me.LA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LA.Location = New System.Drawing.Point(336, 191)
        Me.LA.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LA.Name = "LA"
        Me.LA.Size = New System.Drawing.Size(19, 20)
        Me.LA.TabIndex = 9
        Me.LA.Text = "0"
        '
        'LB
        '
        Me.LB.AutoSize = True
        Me.LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB.Location = New System.Drawing.Point(336, 359)
        Me.LB.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(19, 20)
        Me.LB.TabIndex = 10
        Me.LB.Text = "0"
        '
        'Lresultado
        '
        Me.Lresultado.AutoSize = True
        Me.Lresultado.Location = New System.Drawing.Point(289, 499)
        Me.Lresultado.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lresultado.Name = "Lresultado"
        Me.Lresultado.Size = New System.Drawing.Size(141, 20)
        Me.Lresultado.TabIndex = 11
        Me.Lresultado.Text = "El Resultado es:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 345)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "B"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 31)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Calculadora"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(656, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "201807045"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(856, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 624)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lresultado)
        Me.Controls.Add(Me.LB)
        Me.Controls.Add(Me.LA)
        Me.Controls.Add(Me.Blimpiar)
        Me.Controls.Add(Me.Bdividir)
        Me.Controls.Add(Me.Bmultiplicar)
        Me.Controls.Add(Me.Bresta)
        Me.Controls.Add(Me.Bsuma)
        Me.Controls.Add(Me.BBmas)
        Me.Controls.Add(Me.BBmenos)
        Me.Controls.Add(Me.BAmas)
        Me.Controls.Add(Me.BAmenos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BAmenos As Button
    Friend WithEvents BAmas As Button
    Friend WithEvents BBmenos As Button
    Friend WithEvents BBmas As Button
    Friend WithEvents Bsuma As Button
    Friend WithEvents Bresta As Button
    Friend WithEvents Bmultiplicar As Button
    Friend WithEvents Bdividir As Button
    Friend WithEvents Blimpiar As Button
    Friend WithEvents LA As Label
    Friend WithEvents LB As Label
    Friend WithEvents Lresultado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
