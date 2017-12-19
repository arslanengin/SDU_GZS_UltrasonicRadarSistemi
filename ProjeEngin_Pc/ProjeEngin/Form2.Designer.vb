<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.ss = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VerilersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerilersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeriSDataSet = New ProjeEngin.veriSDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.VerilermDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerilermBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeriMDataSet = New ProjeEngin.veriMDataSet()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.VerilernBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VeriNDataSet = New ProjeEngin.veriNDataSet()
        Me.VerilersTableAdapter = New ProjeEngin.veriSDataSetTableAdapters.verilersTableAdapter()
        Me.TableAdapterManager = New ProjeEngin.veriSDataSetTableAdapters.TableAdapterManager()
        Me.VerilernTableAdapter = New ProjeEngin.veriNDataSetTableAdapters.verilernTableAdapter()
        Me.TableAdapterManager1 = New ProjeEngin.veriNDataSetTableAdapters.TableAdapterManager()
        Me.VerilermTableAdapter = New ProjeEngin.veriMDataSetTableAdapters.verilermTableAdapter()
        Me.TableAdapterManager2 = New ProjeEngin.veriMDataSetTableAdapters.TableAdapterManager()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.VerilersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerilersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeriSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.VerilermDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerilermBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeriMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.VerilernBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VeriNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ss
        '
        Me.ss.PortName = "COM3"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(206, 206)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(451, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 404)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.VerilersDataGridView)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 378)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SICAKLIK EKRANI"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 92)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(196, 24)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Sadece Bugünü Göster"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'VerilersDataGridView
        '
        Me.VerilersDataGridView.AllowUserToAddRows = False
        Me.VerilersDataGridView.AllowUserToDeleteRows = False
        Me.VerilersDataGridView.AutoGenerateColumns = False
        Me.VerilersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerilersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.VerilersDataGridView.DataSource = Me.VerilersBindingSource
        Me.VerilersDataGridView.Location = New System.Drawing.Point(6, 122)
        Me.VerilersDataGridView.Name = "VerilersDataGridView"
        Me.VerilersDataGridView.ReadOnly = True
        Me.VerilersDataGridView.RowHeadersVisible = False
        Me.VerilersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VerilersDataGridView.Size = New System.Drawing.Size(740, 250)
        Me.VerilersDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "limit"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LİMİT SICAKLIK"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "deger"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ÖLÇÜLEN SICAKLIK"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tarih"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ÖLÇÜM TARİHİ"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "saat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ÖLÇÜM SAATİ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'VerilersBindingSource
        '
        Me.VerilersBindingSource.DataMember = "verilers"
        Me.VerilersBindingSource.DataSource = Me.VeriSDataSet
        '
        'VeriSDataSet
        '
        Me.VeriSDataSet.DataSetName = "veriSDataSet"
        Me.VeriSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(604, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "DEĞİŞTİR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(535, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "999"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LİMİT SICAKLIK:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEVCUT SICAKLIK:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 378)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LCD EKRANI"
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button7.Location = New System.Drawing.Point(484, 222)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 29)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "GÖNDER"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "2.SATIR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(249, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "1.SATIR"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(484, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "GÖNDER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(253, 222)
        Me.TextBox3.MaxLength = 16
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 29)
        Me.TextBox3.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(253, 119)
        Me.TextBox2.MaxLength = 16
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(225, 29)
        Me.TextBox2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.VerilermDataGridView)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(752, 378)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MESAFE EKRANI"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(628, 92)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox4.TabIndex = 16
        Me.CheckBox4.Text = "Tarama Aktif"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(6, 92)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(196, 24)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Sadece Bugünü Göster"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'VerilermDataGridView
        '
        Me.VerilermDataGridView.AllowUserToAddRows = False
        Me.VerilermDataGridView.AllowUserToDeleteRows = False
        Me.VerilermDataGridView.AutoGenerateColumns = False
        Me.VerilermDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VerilermDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.VerilermDataGridView.DataSource = Me.VerilermBindingSource
        Me.VerilermDataGridView.Location = New System.Drawing.Point(6, 122)
        Me.VerilermDataGridView.Name = "VerilermDataGridView"
        Me.VerilermDataGridView.ReadOnly = True
        Me.VerilermDataGridView.RowHeadersVisible = False
        Me.VerilermDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VerilermDataGridView.Size = New System.Drawing.Size(740, 250)
        Me.VerilermDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "limit"
        Me.DataGridViewTextBoxColumn10.HeaderText = "LİMİT MESAFE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "deger"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ÖLÇÜLEN MESAFE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "tarih"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ÖLÇÜM TARİHİ"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "saat"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ÖLÇÜM SAATİ"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'VerilermBindingSource
        '
        Me.VerilermBindingSource.DataMember = "verilerm"
        Me.VerilermBindingSource.DataSource = Me.VeriMDataSet
        '
        'VeriMDataSet
        '
        Me.VeriMDataSet.DataSetName = "veriMDataSet"
        Me.VeriMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button3.Location = New System.Drawing.Point(604, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 33)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "DEĞİŞTİR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(529, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 25)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "25"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(359, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "LİMİT MESAFE:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(239, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 25)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 25)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "MEVCUT MESAFE:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(752, 378)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "AYDINLIK EKRANI"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(400, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 25)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(192, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(202, 25)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "ORTAM AYDINLIĞI:"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.ListBox2)
        Me.TabPage5.Controls.Add(Me.ListBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(752, 378)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "AYARLAR"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(394, 109)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(153, 23)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Yeni Kullanıcı Ekle"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(394, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Seçili Kullanıcıyı Sil"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.Location = New System.Drawing.Point(193, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "PAROLA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "KULLANICILAR"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(197, 80)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(191, 290)
        Me.ListBox2.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(191, 290)
        Me.ListBox1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(738, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(34, 27)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'VerilernBindingSource
        '
        Me.VerilernBindingSource.DataMember = "verilern"
        Me.VerilernBindingSource.DataSource = Me.VeriNDataSet
        '
        'VeriNDataSet
        '
        Me.VeriNDataSet.DataSetName = "veriNDataSet"
        Me.VeriNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerilersTableAdapter
        '
        Me.VerilersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = ProjeEngin.veriSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.verilersTableAdapter = Me.VerilersTableAdapter
        '
        'VerilernTableAdapter
        '
        Me.VerilernTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = ProjeEngin.veriNDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.verilernTableAdapter = Me.VerilernTableAdapter
        '
        'VerilermTableAdapter
        '
        Me.VerilermTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.UpdateOrder = ProjeEngin.veriMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.verilermTableAdapter = Me.VerilermTableAdapter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALAN TARAMALI RADAR SİSTEMİ"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.VerilersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerilersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeriSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.VerilermDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerilermBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeriMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.VerilernBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VeriNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ss As System.IO.Ports.SerialPort
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents VeriSDataSet As ProjeEngin.veriSDataSet
    Friend WithEvents VerilersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VerilersTableAdapter As ProjeEngin.veriSDataSetTableAdapters.verilersTableAdapter
    Friend WithEvents TableAdapterManager As ProjeEngin.veriSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerilersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VeriNDataSet As ProjeEngin.veriNDataSet
    Friend WithEvents VerilernBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VerilernTableAdapter As ProjeEngin.veriNDataSetTableAdapters.verilernTableAdapter
    Friend WithEvents TableAdapterManager1 As ProjeEngin.veriNDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents VeriMDataSet As ProjeEngin.veriMDataSet
    Friend WithEvents VerilermBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VerilermTableAdapter As ProjeEngin.veriMDataSetTableAdapters.verilermTableAdapter
    Friend WithEvents TableAdapterManager2 As ProjeEngin.veriMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VerilermDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
