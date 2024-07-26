<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim LibroLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EditorialLabel As System.Windows.Forms.Label
        Dim Genero_LiterarioLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.tbx_id = New System.Windows.Forms.TextBox()
        Me.BibliotecaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New Daniela.Database1DataSet1()
        Me.tbx_book = New System.Windows.Forms.TextBox()
        Me.tbx_author = New System.Windows.Forms.TextBox()
        Me.tbx_editorial = New System.Windows.Forms.TextBox()
        Me.tbx_literary_gender = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.tbx_date = New System.Windows.Forms.DateTimePicker()
        Me.BibliotecaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BibliotecaTableAdapter1 = New Daniela.Database1DataSet1TableAdapters.BibliotecaTableAdapter()
        Me.TableAdapterManager1 = New Daniela.Database1DataSet1TableAdapters.TableAdapterManager()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_credits = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BibliotecaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        LibroLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EditorialLabel = New System.Windows.Forms.Label()
        Genero_LiterarioLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.BibliotecaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BibliotecaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(755, 112)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'LibroLabel
        '
        LibroLabel.AutoSize = True
        LibroLabel.Location = New System.Drawing.Point(741, 138)
        LibroLabel.Name = "LibroLabel"
        LibroLabel.Size = New System.Drawing.Size(33, 13)
        LibroLabel.TabIndex = 4
        LibroLabel.Text = "Libro:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(739, 164)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(35, 13)
        AutorLabel.TabIndex = 6
        AutorLabel.Text = "Autor:"
        '
        'EditorialLabel
        '
        EditorialLabel.AutoSize = True
        EditorialLabel.Location = New System.Drawing.Point(727, 190)
        EditorialLabel.Name = "EditorialLabel"
        EditorialLabel.Size = New System.Drawing.Size(47, 13)
        EditorialLabel.TabIndex = 8
        EditorialLabel.Text = "Editorial:"
        '
        'Genero_LiterarioLabel
        '
        Genero_LiterarioLabel.AutoSize = True
        Genero_LiterarioLabel.Location = New System.Drawing.Point(689, 216)
        Genero_LiterarioLabel.Name = "Genero_LiterarioLabel"
        Genero_LiterarioLabel.Size = New System.Drawing.Size(85, 13)
        Genero_LiterarioLabel.TabIndex = 12
        Genero_LiterarioLabel.Text = "Genero Literario:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(658, 279)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 17
        FechaLabel.Text = "Fecha:"
        '
        'tbx_id
        '
        Me.tbx_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BibliotecaBindingSource1, "Id", True))
        Me.tbx_id.Location = New System.Drawing.Point(780, 109)
        Me.tbx_id.Name = "tbx_id"
        Me.tbx_id.Size = New System.Drawing.Size(100, 20)
        Me.tbx_id.TabIndex = 3
        '
        'BibliotecaBindingSource1
        '
        Me.BibliotecaBindingSource1.DataMember = "Biblioteca"
        Me.BibliotecaBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbx_book
        '
        Me.tbx_book.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BibliotecaBindingSource1, "Libro", True))
        Me.tbx_book.Location = New System.Drawing.Point(780, 135)
        Me.tbx_book.Name = "tbx_book"
        Me.tbx_book.Size = New System.Drawing.Size(100, 20)
        Me.tbx_book.TabIndex = 5
        '
        'tbx_author
        '
        Me.tbx_author.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BibliotecaBindingSource1, "Autor", True))
        Me.tbx_author.Location = New System.Drawing.Point(780, 161)
        Me.tbx_author.Name = "tbx_author"
        Me.tbx_author.Size = New System.Drawing.Size(100, 20)
        Me.tbx_author.TabIndex = 7
        '
        'tbx_editorial
        '
        Me.tbx_editorial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BibliotecaBindingSource1, "Editorial", True))
        Me.tbx_editorial.Location = New System.Drawing.Point(780, 187)
        Me.tbx_editorial.Name = "tbx_editorial"
        Me.tbx_editorial.Size = New System.Drawing.Size(100, 20)
        Me.tbx_editorial.TabIndex = 9
        '
        'tbx_literary_gender
        '
        Me.tbx_literary_gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BibliotecaBindingSource1, "Genero Literario", True))
        Me.tbx_literary_gender.Location = New System.Drawing.Point(780, 213)
        Me.tbx_literary_gender.Name = "tbx_literary_gender"
        Me.tbx_literary_gender.Size = New System.Drawing.Size(100, 20)
        Me.tbx_literary_gender.TabIndex = 13
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(158, 312)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(252, 312)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Agregar"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(434, 312)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 16
        Me.btn_delete.Text = "Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_modify
        '
        Me.btn_modify.Location = New System.Drawing.Point(342, 312)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(75, 23)
        Me.btn_modify.TabIndex = 17
        Me.btn_modify.Text = "Modificar"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'tbx_date
        '
        Me.tbx_date.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BibliotecaBindingSource1, "Fecha", True))
        Me.tbx_date.Location = New System.Drawing.Point(705, 273)
        Me.tbx_date.Name = "tbx_date"
        Me.tbx_date.Size = New System.Drawing.Size(200, 20)
        Me.tbx_date.TabIndex = 18
        '
        'BibliotecaDataGridView
        '
        Me.BibliotecaDataGridView.AutoGenerateColumns = False
        Me.BibliotecaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BibliotecaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BibliotecaDataGridView.DataSource = Me.BibliotecaBindingSource1
        Me.BibliotecaDataGridView.Location = New System.Drawing.Point(12, 72)
        Me.BibliotecaDataGridView.Name = "BibliotecaDataGridView"
        Me.BibliotecaDataGridView.Size = New System.Drawing.Size(640, 220)
        Me.BibliotecaDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Libro"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Libro"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Autor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Autor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Editorial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Editorial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Genero Literario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Genero Literario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'BibliotecaTableAdapter1
        '
        Me.BibliotecaTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BibliotecaTableAdapter = Me.BibliotecaTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Daniela.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(12, 312)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 23)
        Me.btn_back.TabIndex = 19
        Me.btn_back.Text = "Volver"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_credits
        '
        Me.btn_credits.Location = New System.Drawing.Point(829, 312)
        Me.btn_credits.Name = "btn_credits"
        Me.btn_credits.Size = New System.Drawing.Size(75, 23)
        Me.btn_credits.TabIndex = 20
        Me.btn_credits.Text = "Creditos"
        Me.btn_credits.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Blackadder ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 34)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Biblioteca Daniela's"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(780, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(73, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Daniela"
        '
        'BibliotecaBindingSource
        '
        Me.BibliotecaBindingSource.DataMember = "Biblioteca"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(917, 360)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_credits)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.BibliotecaDataGridView)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.tbx_date)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Genero_LiterarioLabel)
        Me.Controls.Add(Me.tbx_literary_gender)
        Me.Controls.Add(EditorialLabel)
        Me.Controls.Add(Me.tbx_editorial)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.tbx_author)
        Me.Controls.Add(LibroLabel)
        Me.Controls.Add(Me.tbx_book)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.tbx_id)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Biblioteca"
        CType(Me.BibliotecaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BibliotecaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents BibliotecaBindingSource As BindingSource
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents BibliotecaBindingSource1 As BindingSource
    Friend WithEvents BibliotecaTableAdapter1 As Database1DataSet1TableAdapters.BibliotecaTableAdapter
    Friend WithEvents TableAdapterManager1 As Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents tbx_id As TextBox
    Friend WithEvents tbx_book As TextBox
    Friend WithEvents tbx_author As TextBox
    Friend WithEvents tbx_editorial As TextBox
    Friend WithEvents tbx_literary_gender As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_modify As Button
    Friend WithEvents tbx_date As DateTimePicker
    Friend WithEvents BibliotecaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_credits As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
