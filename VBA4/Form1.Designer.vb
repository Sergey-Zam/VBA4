<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnExportTable = New System.Windows.Forms.Button()
        Me.btnClearTable = New System.Windows.Forms.Button()
        Me.lblCountOfRows = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetData = New System.Windows.Forms.Button()
        Me.tbInventorDirectory = New System.Windows.Forms.TextBox()
        Me.tbExcelDirectory = New System.Windows.Forms.TextBox()
        Me.btnGetInventorPath = New System.Windows.Forms.Button()
        Me.btnGetExcelPath = New System.Windows.Forms.Button()
        Me.dgvAspects = New System.Windows.Forms.DataGridView()
        CType(Me.dgvAspects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportTable
        '
        Me.btnExportTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportTable.Location = New System.Drawing.Point(482, 312)
        Me.btnExportTable.Name = "btnExportTable"
        Me.btnExportTable.Size = New System.Drawing.Size(142, 23)
        Me.btnExportTable.TabIndex = 21
        Me.btnExportTable.Text = "Экспорт таблицы..."
        Me.btnExportTable.UseVisualStyleBackColor = True
        '
        'btnClearTable
        '
        Me.btnClearTable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearTable.Location = New System.Drawing.Point(630, 312)
        Me.btnClearTable.Name = "btnClearTable"
        Me.btnClearTable.Size = New System.Drawing.Size(142, 23)
        Me.btnClearTable.TabIndex = 20
        Me.btnClearTable.Text = "Очистить таблицу"
        Me.btnClearTable.UseVisualStyleBackColor = True
        '
        'lblCountOfRows
        '
        Me.lblCountOfRows.AutoSize = True
        Me.lblCountOfRows.Location = New System.Drawing.Point(252, 100)
        Me.lblCountOfRows.Name = "lblCountOfRows"
        Me.lblCountOfRows.Size = New System.Drawing.Size(13, 13)
        Me.lblCountOfRows.TabIndex = 19
        Me.lblCountOfRows.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Таблица полученных аспектов, всего:"
        '
        'btnGetData
        '
        Me.btnGetData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetData.Enabled = False
        Me.btnGetData.Location = New System.Drawing.Point(12, 74)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(760, 23)
        Me.btnGetData.TabIndex = 16
        Me.btnGetData.Text = "Считать и сравнить данные"
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'tbInventorDirectory
        '
        Me.tbInventorDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbInventorDirectory.Location = New System.Drawing.Point(341, 47)
        Me.tbInventorDirectory.Name = "tbInventorDirectory"
        Me.tbInventorDirectory.ReadOnly = True
        Me.tbInventorDirectory.Size = New System.Drawing.Size(431, 20)
        Me.tbInventorDirectory.TabIndex = 15
        '
        'tbExcelDirectory
        '
        Me.tbExcelDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbExcelDirectory.Location = New System.Drawing.Point(341, 17)
        Me.tbExcelDirectory.Name = "tbExcelDirectory"
        Me.tbExcelDirectory.ReadOnly = True
        Me.tbExcelDirectory.Size = New System.Drawing.Size(431, 20)
        Me.tbExcelDirectory.TabIndex = 14
        '
        'btnGetInventorPath
        '
        Me.btnGetInventorPath.Location = New System.Drawing.Point(12, 45)
        Me.btnGetInventorPath.Name = "btnGetInventorPath"
        Me.btnGetInventorPath.Size = New System.Drawing.Size(323, 23)
        Me.btnGetInventorPath.TabIndex = 13
        Me.btnGetInventorPath.Text = "Выберите документ детали (*.ipt)..."
        Me.btnGetInventorPath.UseVisualStyleBackColor = True
        '
        'btnGetExcelPath
        '
        Me.btnGetExcelPath.Location = New System.Drawing.Point(12, 15)
        Me.btnGetExcelPath.Name = "btnGetExcelPath"
        Me.btnGetExcelPath.Size = New System.Drawing.Size(323, 23)
        Me.btnGetExcelPath.TabIndex = 12
        Me.btnGetExcelPath.Text = "Выберите документ Excel c характеристиками (*.xlsx, *.xls)..."
        Me.btnGetExcelPath.UseVisualStyleBackColor = True
        '
        'dgvAspects
        '
        Me.dgvAspects.AllowUserToAddRows = False
        Me.dgvAspects.AllowUserToDeleteRows = False
        Me.dgvAspects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAspects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAspects.Location = New System.Drawing.Point(11, 116)
        Me.dgvAspects.Name = "dgvAspects"
        Me.dgvAspects.ReadOnly = True
        Me.dgvAspects.RowHeadersVisible = False
        Me.dgvAspects.Size = New System.Drawing.Size(762, 190)
        Me.dgvAspects.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 351)
        Me.Controls.Add(Me.btnExportTable)
        Me.Controls.Add(Me.btnClearTable)
        Me.Controls.Add(Me.lblCountOfRows)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.tbInventorDirectory)
        Me.Controls.Add(Me.tbExcelDirectory)
        Me.Controls.Add(Me.btnGetInventorPath)
        Me.Controls.Add(Me.btnGetExcelPath)
        Me.Controls.Add(Me.dgvAspects)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VBA4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvAspects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExportTable As Button
    Friend WithEvents btnClearTable As Button
    Friend WithEvents lblCountOfRows As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGetData As Button
    Friend WithEvents tbInventorDirectory As TextBox
    Friend WithEvents tbExcelDirectory As TextBox
    Friend WithEvents btnGetInventorPath As Button
    Friend WithEvents btnGetExcelPath As Button
    Friend WithEvents dgvAspects As DataGridView
End Class
