<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGameID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.comboGenre = New System.Windows.Forms.ComboBox()
        Me.comboAge = New System.Windows.Forms.ComboBox()
        Me.comboYear = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gamesDataGrid = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.gamesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(490, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Games"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Game ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Genre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age Restrictions"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Year of Release"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGameID
        '
        Me.txtGameID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameID.Location = New System.Drawing.Point(381, 135)
        Me.txtGameID.Name = "txtGameID"
        Me.txtGameID.Size = New System.Drawing.Size(346, 30)
        Me.txtGameID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(381, 186)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(346, 30)
        Me.txtName.TabIndex = 7
        '
        'comboGenre
        '
        Me.comboGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGenre.FormattingEnabled = True
        Me.comboGenre.Items.AddRange(New Object() {"Stealth", "Action", "Platformer", "Shooter", "Fighting", "Horror"})
        Me.comboGenre.Location = New System.Drawing.Point(381, 232)
        Me.comboGenre.Name = "comboGenre"
        Me.comboGenre.Size = New System.Drawing.Size(346, 30)
        Me.comboGenre.TabIndex = 8
        '
        'comboAge
        '
        Me.comboAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboAge.FormattingEnabled = True
        Me.comboAge.Items.AddRange(New Object() {"3", "7", "12", "16", "18"})
        Me.comboAge.Location = New System.Drawing.Point(381, 280)
        Me.comboAge.Name = "comboAge"
        Me.comboAge.Size = New System.Drawing.Size(346, 30)
        Me.comboAge.TabIndex = 9
        '
        'comboYear
        '
        Me.comboYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboYear.FormattingEnabled = True
        Me.comboYear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021"})
        Me.comboYear.Location = New System.Drawing.Point(381, 330)
        Me.comboYear.Name = "comboYear"
        Me.comboYear.Size = New System.Drawing.Size(346, 30)
        Me.comboYear.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(425, 382)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(258, 41)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add To Database"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gamesDataGrid
        '
        Me.gamesDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.gamesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gamesDataGrid.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.gamesDataGrid.Location = New System.Drawing.Point(12, 557)
        Me.gamesDataGrid.Name = "gamesDataGrid"
        Me.gamesDataGrid.RowHeadersWidth = 51
        Me.gamesDataGrid.RowTemplate.Height = 24
        Me.gamesDataGrid.Size = New System.Drawing.Size(915, 139)
        Me.gamesDataGrid.TabIndex = 12
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DimGray
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(223, 510)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(258, 41)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DimGray
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(531, 510)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(258, 41)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.DimGray
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(751, 135)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(176, 41)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(955, 708)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.gamesDataGrid)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.comboYear)
        Me.Controls.Add(Me.comboAge)
        Me.Controls.Add(Me.comboGenre)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtGameID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gamesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGameID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents comboGenre As ComboBox
    Friend WithEvents comboAge As ComboBox
    Friend WithEvents comboYear As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents gamesDataGrid As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
End Class
