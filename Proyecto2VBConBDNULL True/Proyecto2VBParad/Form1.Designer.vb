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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim SalesOrderIDLabel As System.Windows.Forms.Label
        Dim SalesOrderDetailIDLabel As System.Windows.Forms.Label
        Dim CarrierTrackingNumberLabel As System.Windows.Forms.Label
        Dim OrderQtyLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim SpecialOfferIDLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UnitPriceDiscountLabel As System.Windows.Forms.Label
        Dim LineTotalLabel As System.Windows.Forms.Label
        Dim RowguidLabel As System.Windows.Forms.Label
        Dim ModifiedDateLabel As System.Windows.Forms.Label
        Me.AdventureWorks2008_DataDataSet = New WindowsApplication1.AdventureWorks2008_DataDataSet()
        Me.SalesOrderDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesOrderDetailTableAdapter = New WindowsApplication1.AdventureWorks2008_DataDataSetTableAdapters.SalesOrderDetailTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AdventureWorks2008_DataDataSetTableAdapters.TableAdapterManager()
        Me.SalesOrderDetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesOrderDetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesOrderIDTextBox = New System.Windows.Forms.TextBox()
        Me.SalesOrderDetailIDTextBox = New System.Windows.Forms.TextBox()
        Me.CarrierTrackingNumberTextBox = New System.Windows.Forms.TextBox()
        Me.OrderQtyTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialOfferIDTextBox = New System.Windows.Forms.TextBox()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.UnitPriceDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.LineTotalTextBox = New System.Windows.Forms.TextBox()
        Me.RowguidTextBox = New System.Windows.Forms.TextBox()
        Me.ModifiedDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        SalesOrderIDLabel = New System.Windows.Forms.Label()
        SalesOrderDetailIDLabel = New System.Windows.Forms.Label()
        CarrierTrackingNumberLabel = New System.Windows.Forms.Label()
        OrderQtyLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        SpecialOfferIDLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        UnitPriceDiscountLabel = New System.Windows.Forms.Label()
        LineTotalLabel = New System.Windows.Forms.Label()
        RowguidLabel = New System.Windows.Forms.Label()
        ModifiedDateLabel = New System.Windows.Forms.Label()
        CType(Me.AdventureWorks2008_DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesOrderDetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesOrderDetailBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdventureWorks2008_DataDataSet
        '
        Me.AdventureWorks2008_DataDataSet.DataSetName = "AdventureWorks2008_DataDataSet"
        Me.AdventureWorks2008_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesOrderDetailBindingSource
        '
        Me.SalesOrderDetailBindingSource.DataMember = "SalesOrderDetail"
        Me.SalesOrderDetailBindingSource.DataSource = Me.AdventureWorks2008_DataDataSet
        '
        'SalesOrderDetailTableAdapter
        '
        Me.SalesOrderDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesOrderDetailTableAdapter = Me.SalesOrderDetailTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AdventureWorks2008_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesOrderDetailBindingNavigator
        '
        Me.SalesOrderDetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesOrderDetailBindingNavigator.BindingSource = Me.SalesOrderDetailBindingSource
        Me.SalesOrderDetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesOrderDetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesOrderDetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesOrderDetailBindingNavigatorSaveItem})
        Me.SalesOrderDetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesOrderDetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesOrderDetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesOrderDetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesOrderDetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesOrderDetailBindingNavigator.Name = "SalesOrderDetailBindingNavigator"
        Me.SalesOrderDetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesOrderDetailBindingNavigator.Size = New System.Drawing.Size(364, 25)
        Me.SalesOrderDetailBindingNavigator.TabIndex = 0
        Me.SalesOrderDetailBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'SalesOrderDetailBindingNavigatorSaveItem
        '
        Me.SalesOrderDetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesOrderDetailBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesOrderDetailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesOrderDetailBindingNavigatorSaveItem.Name = "SalesOrderDetailBindingNavigatorSaveItem"
        Me.SalesOrderDetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SalesOrderDetailBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SalesOrderIDLabel
        '
        SalesOrderIDLabel.AutoSize = True
        SalesOrderIDLabel.Location = New System.Drawing.Point(14, 32)
        SalesOrderIDLabel.Name = "SalesOrderIDLabel"
        SalesOrderIDLabel.Size = New System.Drawing.Size(79, 13)
        SalesOrderIDLabel.TabIndex = 1
        SalesOrderIDLabel.Text = "Sales Order ID:"
        '
        'SalesOrderIDTextBox
        '
        Me.SalesOrderIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "SalesOrderID", True))
        Me.SalesOrderIDTextBox.Location = New System.Drawing.Point(145, 29)
        Me.SalesOrderIDTextBox.Name = "SalesOrderIDTextBox"
        Me.SalesOrderIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesOrderIDTextBox.TabIndex = 2
        '
        'SalesOrderDetailIDLabel
        '
        SalesOrderDetailIDLabel.AutoSize = True
        SalesOrderDetailIDLabel.Location = New System.Drawing.Point(14, 58)
        SalesOrderDetailIDLabel.Name = "SalesOrderDetailIDLabel"
        SalesOrderDetailIDLabel.Size = New System.Drawing.Size(109, 13)
        SalesOrderDetailIDLabel.TabIndex = 3
        SalesOrderDetailIDLabel.Text = "Sales Order Detail ID:"
        '
        'SalesOrderDetailIDTextBox
        '
        Me.SalesOrderDetailIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "SalesOrderDetailID", True))
        Me.SalesOrderDetailIDTextBox.Location = New System.Drawing.Point(145, 55)
        Me.SalesOrderDetailIDTextBox.Name = "SalesOrderDetailIDTextBox"
        Me.SalesOrderDetailIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SalesOrderDetailIDTextBox.TabIndex = 4
        '
        'CarrierTrackingNumberLabel
        '
        CarrierTrackingNumberLabel.AutoSize = True
        CarrierTrackingNumberLabel.Location = New System.Drawing.Point(14, 84)
        CarrierTrackingNumberLabel.Name = "CarrierTrackingNumberLabel"
        CarrierTrackingNumberLabel.Size = New System.Drawing.Size(125, 13)
        CarrierTrackingNumberLabel.TabIndex = 5
        CarrierTrackingNumberLabel.Text = "Carrier Tracking Number:"
        '
        'CarrierTrackingNumberTextBox
        '
        Me.CarrierTrackingNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "CarrierTrackingNumber", True))
        Me.CarrierTrackingNumberTextBox.Location = New System.Drawing.Point(145, 81)
        Me.CarrierTrackingNumberTextBox.Name = "CarrierTrackingNumberTextBox"
        Me.CarrierTrackingNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CarrierTrackingNumberTextBox.TabIndex = 6
        '
        'OrderQtyLabel
        '
        OrderQtyLabel.AutoSize = True
        OrderQtyLabel.Location = New System.Drawing.Point(14, 110)
        OrderQtyLabel.Name = "OrderQtyLabel"
        OrderQtyLabel.Size = New System.Drawing.Size(55, 13)
        OrderQtyLabel.TabIndex = 7
        OrderQtyLabel.Text = "Order Qty:"
        '
        'OrderQtyTextBox
        '
        Me.OrderQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "OrderQty", True))
        Me.OrderQtyTextBox.Location = New System.Drawing.Point(145, 107)
        Me.OrderQtyTextBox.Name = "OrderQtyTextBox"
        Me.OrderQtyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OrderQtyTextBox.TabIndex = 8
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(14, 136)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(61, 13)
        ProductIDLabel.TabIndex = 9
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(145, 133)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProductIDTextBox.TabIndex = 10
        '
        'SpecialOfferIDLabel
        '
        SpecialOfferIDLabel.AutoSize = True
        SpecialOfferIDLabel.Location = New System.Drawing.Point(14, 162)
        SpecialOfferIDLabel.Name = "SpecialOfferIDLabel"
        SpecialOfferIDLabel.Size = New System.Drawing.Size(85, 13)
        SpecialOfferIDLabel.TabIndex = 11
        SpecialOfferIDLabel.Text = "Special Offer ID:"
        '
        'SpecialOfferIDTextBox
        '
        Me.SpecialOfferIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "SpecialOfferID", True))
        Me.SpecialOfferIDTextBox.Location = New System.Drawing.Point(145, 159)
        Me.SpecialOfferIDTextBox.Name = "SpecialOfferIDTextBox"
        Me.SpecialOfferIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SpecialOfferIDTextBox.TabIndex = 12
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(14, 188)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 13
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(145, 185)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnitPriceTextBox.TabIndex = 14
        '
        'UnitPriceDiscountLabel
        '
        UnitPriceDiscountLabel.AutoSize = True
        UnitPriceDiscountLabel.Location = New System.Drawing.Point(14, 214)
        UnitPriceDiscountLabel.Name = "UnitPriceDiscountLabel"
        UnitPriceDiscountLabel.Size = New System.Drawing.Size(101, 13)
        UnitPriceDiscountLabel.TabIndex = 15
        UnitPriceDiscountLabel.Text = "Unit Price Discount:"
        '
        'UnitPriceDiscountTextBox
        '
        Me.UnitPriceDiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "UnitPriceDiscount", True))
        Me.UnitPriceDiscountTextBox.Location = New System.Drawing.Point(145, 211)
        Me.UnitPriceDiscountTextBox.Name = "UnitPriceDiscountTextBox"
        Me.UnitPriceDiscountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnitPriceDiscountTextBox.TabIndex = 16
        '
        'LineTotalLabel
        '
        LineTotalLabel.AutoSize = True
        LineTotalLabel.Location = New System.Drawing.Point(14, 240)
        LineTotalLabel.Name = "LineTotalLabel"
        LineTotalLabel.Size = New System.Drawing.Size(57, 13)
        LineTotalLabel.TabIndex = 17
        LineTotalLabel.Text = "Line Total:"
        '
        'LineTotalTextBox
        '
        Me.LineTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "LineTotal", True))
        Me.LineTotalTextBox.Location = New System.Drawing.Point(145, 237)
        Me.LineTotalTextBox.Name = "LineTotalTextBox"
        Me.LineTotalTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LineTotalTextBox.TabIndex = 18
        '
        'RowguidLabel
        '
        RowguidLabel.AutoSize = True
        RowguidLabel.Location = New System.Drawing.Point(14, 266)
        RowguidLabel.Name = "RowguidLabel"
        RowguidLabel.Size = New System.Drawing.Size(47, 13)
        RowguidLabel.TabIndex = 19
        RowguidLabel.Text = "rowguid:"
        '
        'RowguidTextBox
        '
        Me.RowguidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesOrderDetailBindingSource, "rowguid", True))
        Me.RowguidTextBox.Location = New System.Drawing.Point(145, 263)
        Me.RowguidTextBox.Name = "RowguidTextBox"
        Me.RowguidTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RowguidTextBox.TabIndex = 20
        '
        'ModifiedDateLabel
        '
        ModifiedDateLabel.AutoSize = True
        ModifiedDateLabel.Location = New System.Drawing.Point(14, 293)
        ModifiedDateLabel.Name = "ModifiedDateLabel"
        ModifiedDateLabel.Size = New System.Drawing.Size(76, 13)
        ModifiedDateLabel.TabIndex = 21
        ModifiedDateLabel.Text = "Modified Date:"
        '
        'ModifiedDateDateTimePicker
        '
        Me.ModifiedDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesOrderDetailBindingSource, "ModifiedDate", True))
        Me.ModifiedDateDateTimePicker.Location = New System.Drawing.Point(145, 289)
        Me.ModifiedDateDateTimePicker.Name = "ModifiedDateDateTimePicker"
        Me.ModifiedDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ModifiedDateDateTimePicker.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 315)
        Me.Controls.Add(SalesOrderIDLabel)
        Me.Controls.Add(Me.SalesOrderIDTextBox)
        Me.Controls.Add(SalesOrderDetailIDLabel)
        Me.Controls.Add(Me.SalesOrderDetailIDTextBox)
        Me.Controls.Add(CarrierTrackingNumberLabel)
        Me.Controls.Add(Me.CarrierTrackingNumberTextBox)
        Me.Controls.Add(OrderQtyLabel)
        Me.Controls.Add(Me.OrderQtyTextBox)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(SpecialOfferIDLabel)
        Me.Controls.Add(Me.SpecialOfferIDTextBox)
        Me.Controls.Add(UnitPriceLabel)
        Me.Controls.Add(Me.UnitPriceTextBox)
        Me.Controls.Add(UnitPriceDiscountLabel)
        Me.Controls.Add(Me.UnitPriceDiscountTextBox)
        Me.Controls.Add(LineTotalLabel)
        Me.Controls.Add(Me.LineTotalTextBox)
        Me.Controls.Add(RowguidLabel)
        Me.Controls.Add(Me.RowguidTextBox)
        Me.Controls.Add(ModifiedDateLabel)
        Me.Controls.Add(Me.ModifiedDateDateTimePicker)
        Me.Controls.Add(Me.SalesOrderDetailBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AdventureWorks2008_DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesOrderDetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesOrderDetailBindingNavigator.ResumeLayout(False)
        Me.SalesOrderDetailBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdventureWorks2008_DataDataSet As WindowsApplication1.AdventureWorks2008_DataDataSet
    Friend WithEvents SalesOrderDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesOrderDetailTableAdapter As WindowsApplication1.AdventureWorks2008_DataDataSetTableAdapters.SalesOrderDetailTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AdventureWorks2008_DataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesOrderDetailBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalesOrderDetailBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SalesOrderIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalesOrderDetailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarrierTrackingNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecialOfferIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceDiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LineTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RowguidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ModifiedDateDateTimePicker As System.Windows.Forms.DateTimePicker

End Class
