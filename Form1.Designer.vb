<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tabMain = New TabControl()
        tabCustomer = New TabPage()
        btnSubmitFeedback = New Button()
        lblfeedbk = New Label()
        txtComment = New TextBox()
        cmbRating = New ComboBox()
        lblFeedback = New Label()
        lblshiro = New Label()
        lblruzdinich = New Label()
        lblkinche = New Label()
        lblfirfir = New Label()
        lblenkulal = New Label()
        lblaynet = New Label()
        Picshiro = New PictureBox()
        Picruzdinich = New PictureBox()
        Pickinche = New PictureBox()
        Picenkulal = New PictureBox()
        Picfirfir = New PictureBox()
        Picaynet = New PictureBox()
        lblTitleCustomer = New Label()
        tabSystem = New TabPage()
        showlogs = New ListBox()
        btnReady = New Button()
        btnFinish = New Button()
        btnDeliver = New Button()
        btnCook = New Button()
        lblKitchenStatus = New Label()
        tabKitchen = New TabPage()
        lblTotalRevenue = New Label()
        btnCalculateRevenue = New Button()
        btnRefresh = New Button()
        lblLiveStatus = New Label()
        KitchenOrders = New ListBox()
        lblKitchenDashboard = New Label()
        lbltitle = New Label()
        tabMain.SuspendLayout()
        tabCustomer.SuspendLayout()
        CType(Picshiro, ComponentModel.ISupportInitialize).BeginInit()
        CType(Picruzdinich, ComponentModel.ISupportInitialize).BeginInit()
        CType(Pickinche, ComponentModel.ISupportInitialize).BeginInit()
        CType(Picenkulal, ComponentModel.ISupportInitialize).BeginInit()
        CType(Picfirfir, ComponentModel.ISupportInitialize).BeginInit()
        CType(Picaynet, ComponentModel.ISupportInitialize).BeginInit()
        tabSystem.SuspendLayout()
        tabKitchen.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(tabCustomer)
        tabMain.Controls.Add(tabSystem)
        tabMain.Controls.Add(tabKitchen)
        tabMain.Location = New Point(66, 78)
        tabMain.Margin = New Padding(3, 4, 3, 4)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(836, 584)
        tabMain.TabIndex = 0
        ' 
        ' tabCustomer
        ' 
        tabCustomer.Controls.Add(btnSubmitFeedback)
        tabCustomer.Controls.Add(lblfeedbk)
        tabCustomer.Controls.Add(txtComment)
        tabCustomer.Controls.Add(cmbRating)
        tabCustomer.Controls.Add(lblFeedback)
        tabCustomer.Controls.Add(lblshiro)
        tabCustomer.Controls.Add(lblruzdinich)
        tabCustomer.Controls.Add(lblkinche)
        tabCustomer.Controls.Add(lblfirfir)
        tabCustomer.Controls.Add(lblenkulal)
        tabCustomer.Controls.Add(lblaynet)
        tabCustomer.Controls.Add(Picshiro)
        tabCustomer.Controls.Add(Picruzdinich)
        tabCustomer.Controls.Add(Pickinche)
        tabCustomer.Controls.Add(Picenkulal)
        tabCustomer.Controls.Add(Picfirfir)
        tabCustomer.Controls.Add(Picaynet)
        tabCustomer.Controls.Add(lblTitleCustomer)
        tabCustomer.Cursor = Cursors.Hand
        tabCustomer.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabCustomer.Location = New Point(4, 29)
        tabCustomer.Margin = New Padding(3, 4, 3, 4)
        tabCustomer.Name = "tabCustomer"
        tabCustomer.Padding = New Padding(3, 4, 3, 4)
        tabCustomer.Size = New Size(828, 551)
        tabCustomer.TabIndex = 0
        tabCustomer.Text = "Customer"
        tabCustomer.UseVisualStyleBackColor = True
        ' 
        ' btnSubmitFeedback
        ' 
        btnSubmitFeedback.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitFeedback.Location = New Point(674, 433)
        btnSubmitFeedback.Name = "btnSubmitFeedback"
        btnSubmitFeedback.Size = New Size(75, 36)
        btnSubmitFeedback.TabIndex = 19
        btnSubmitFeedback.Text = """Submit"""
        btnSubmitFeedback.UseVisualStyleBackColor = True
        ' 
        ' lblfeedbk
        ' 
        lblfeedbk.AutoSize = True
        lblfeedbk.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblfeedbk.ForeColor = SystemColors.MenuText
        lblfeedbk.Location = New Point(408, 369)
        lblfeedbk.Name = "lblfeedbk"
        lblfeedbk.Size = New Size(196, 21)
        lblfeedbk.TabIndex = 18
        lblfeedbk.Text = "Please Give Me Feed Back"
        ' 
        ' txtComment
        ' 
        txtComment.Location = New Point(408, 420)
        txtComment.Multiline = True
        txtComment.Name = "txtComment"
        txtComment.Size = New Size(235, 86)
        txtComment.TabIndex = 17
        ' 
        ' cmbRating
        ' 
        cmbRating.FormattingEnabled = True
        cmbRating.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cmbRating.Location = New Point(95, 433)
        cmbRating.Name = "cmbRating"
        cmbRating.Size = New Size(190, 25)
        cmbRating.TabIndex = 16
        cmbRating.Text = " Select Rating"
        ' 
        ' lblFeedback
        ' 
        lblFeedback.AutoSize = True
        lblFeedback.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblFeedback.ForeColor = SystemColors.MenuText
        lblFeedback.Location = New Point(85, 395)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(187, 21)
        lblFeedback.TabIndex = 15
        lblFeedback.Text = """Rate Our Service (1-5)"""
        ' 
        ' lblshiro
        ' 
        lblshiro.AutoSize = True
        lblshiro.Location = New Point(574, 155)
        lblshiro.Name = "lblshiro"
        lblshiro.Size = New Size(100, 17)
        lblshiro.TabIndex = 14
        lblshiro.Text = "SHIRO - 80 birr"
        ' 
        ' lblruzdinich
        ' 
        lblruzdinich.AutoSize = True
        lblruzdinich.Location = New Point(574, 319)
        lblruzdinich.Name = "lblruzdinich"
        lblruzdinich.Size = New Size(135, 17)
        lblruzdinich.TabIndex = 13
        lblruzdinich.Text = "RUZ&DINCH - 170 birr"
        ' 
        ' lblkinche
        ' 
        lblkinche.AutoSize = True
        lblkinche.Location = New Point(306, 319)
        lblkinche.Name = "lblkinche"
        lblkinche.Size = New Size(101, 17)
        lblkinche.TabIndex = 12
        lblkinche.Text = "KINCE- 120 birr"
        ' 
        ' lblfirfir
        ' 
        lblfirfir.AutoSize = True
        lblfirfir.Location = New Point(73, 319)
        lblfirfir.Name = "lblfirfir"
        lblfirfir.Size = New Size(99, 17)
        lblfirfir.TabIndex = 11
        lblfirfir.Text = "FIRFIR - 90 birr"
        ' 
        ' lblenkulal
        ' 
        lblenkulal.AutoSize = True
        lblenkulal.Location = New Point(301, 155)
        lblenkulal.Name = "lblenkulal"
        lblenkulal.Size = New Size(114, 17)
        lblenkulal.TabIndex = 10
        lblenkulal.Text = "ENKULA- 110 birr"
        ' 
        ' lblaynet
        ' 
        lblaynet.AutoSize = True
        lblaynet.Location = New Point(73, 155)
        lblaynet.Name = "lblaynet"
        lblaynet.Size = New Size(109, 17)
        lblaynet.TabIndex = 9
        lblaynet.Text = "AYNET - 100 birr"
        ' 
        ' Picshiro
        ' 
        Picshiro.Image = My.Resources.Resources.shiro
        Picshiro.Location = New Point(574, 66)
        Picshiro.Name = "Picshiro"
        Picshiro.Size = New Size(109, 68)
        Picshiro.SizeMode = PictureBoxSizeMode.StretchImage
        Picshiro.TabIndex = 8
        Picshiro.TabStop = False
        ' 
        ' Picruzdinich
        ' 
        Picruzdinich.Image = My.Resources.Resources.ruzdinich
        Picruzdinich.Location = New Point(574, 224)
        Picruzdinich.Name = "Picruzdinich"
        Picruzdinich.Size = New Size(109, 68)
        Picruzdinich.SizeMode = PictureBoxSizeMode.StretchImage
        Picruzdinich.TabIndex = 7
        Picruzdinich.TabStop = False
        ' 
        ' Pickinche
        ' 
        Pickinche.Image = My.Resources.Resources.kinche
        Pickinche.Location = New Point(306, 224)
        Pickinche.Name = "Pickinche"
        Pickinche.Size = New Size(109, 68)
        Pickinche.SizeMode = PictureBoxSizeMode.StretchImage
        Pickinche.TabIndex = 6
        Pickinche.TabStop = False
        ' 
        ' Picenkulal
        ' 
        Picenkulal.Image = My.Resources.Resources.enkulal
        Picenkulal.Location = New Point(306, 66)
        Picenkulal.Name = "Picenkulal"
        Picenkulal.Size = New Size(109, 68)
        Picenkulal.SizeMode = PictureBoxSizeMode.StretchImage
        Picenkulal.TabIndex = 5
        Picenkulal.TabStop = False
        ' 
        ' Picfirfir
        ' 
        Picfirfir.Image = My.Resources.Resources.firfir
        Picfirfir.Location = New Point(73, 224)
        Picfirfir.Name = "Picfirfir"
        Picfirfir.Size = New Size(119, 68)
        Picfirfir.SizeMode = PictureBoxSizeMode.StretchImage
        Picfirfir.TabIndex = 4
        Picfirfir.TabStop = False
        ' 
        ' Picaynet
        ' 
        Picaynet.Image = My.Resources.Resources.aynet
        Picaynet.Location = New Point(73, 66)
        Picaynet.Name = "Picaynet"
        Picaynet.Size = New Size(109, 68)
        Picaynet.SizeMode = PictureBoxSizeMode.StretchImage
        Picaynet.TabIndex = 3
        Picaynet.TabStop = False
        ' 
        ' lblTitleCustomer
        ' 
        lblTitleCustomer.AutoSize = True
        lblTitleCustomer.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleCustomer.ForeColor = SystemColors.Highlight
        lblTitleCustomer.Location = New Point(275, 13)
        lblTitleCustomer.Name = "lblTitleCustomer"
        lblTitleCustomer.Size = New Size(162, 25)
        lblTitleCustomer.TabIndex = 2
        lblTitleCustomer.Text = "Select Your Food"
        ' 
        ' tabSystem
        ' 
        tabSystem.Controls.Add(showlogs)
        tabSystem.Controls.Add(btnReady)
        tabSystem.Controls.Add(btnFinish)
        tabSystem.Controls.Add(btnDeliver)
        tabSystem.Controls.Add(btnCook)
        tabSystem.Controls.Add(lblKitchenStatus)
        tabSystem.ForeColor = SystemColors.WindowText
        tabSystem.Location = New Point(4, 24)
        tabSystem.Margin = New Padding(3, 4, 3, 4)
        tabSystem.Name = "tabSystem"
        tabSystem.Padding = New Padding(3, 4, 3, 4)
        tabSystem.Size = New Size(828, 556)
        tabSystem.TabIndex = 1
        tabSystem.Text = "System"
        tabSystem.UseVisualStyleBackColor = True
        ' 
        ' showlogs
        ' 
        showlogs.FormattingEnabled = True
        showlogs.ItemHeight = 20
        showlogs.Location = New Point(401, 100)
        showlogs.Name = "showlogs"
        showlogs.Size = New Size(267, 224)
        showlogs.TabIndex = 5
        ' 
        ' btnReady
        ' 
        btnReady.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReady.Location = New Point(61, 278)
        btnReady.Name = "btnReady"
        btnReady.Size = New Size(75, 36)
        btnReady.TabIndex = 4
        btnReady.Text = "Ready"
        btnReady.UseVisualStyleBackColor = True
        ' 
        ' btnFinish
        ' 
        btnFinish.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFinish.Location = New Point(242, 278)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(75, 36)
        btnFinish.TabIndex = 3
        btnFinish.Text = "Finish"
        btnFinish.UseVisualStyleBackColor = True
        ' 
        ' btnDeliver
        ' 
        btnDeliver.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeliver.Location = New Point(242, 112)
        btnDeliver.Name = "btnDeliver"
        btnDeliver.Size = New Size(75, 36)
        btnDeliver.TabIndex = 2
        btnDeliver.Text = "Deliver"
        btnDeliver.UseVisualStyleBackColor = True
        ' 
        ' btnCook
        ' 
        btnCook.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCook.Location = New Point(61, 112)
        btnCook.Name = "btnCook"
        btnCook.Size = New Size(75, 36)
        btnCook.TabIndex = 1
        btnCook.Text = "Cook"
        btnCook.UseVisualStyleBackColor = True
        ' 
        ' lblKitchenStatus
        ' 
        lblKitchenStatus.AutoSize = True
        lblKitchenStatus.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKitchenStatus.Location = New Point(61, 54)
        lblKitchenStatus.Name = "lblKitchenStatus"
        lblKitchenStatus.Size = New Size(230, 20)
        lblKitchenStatus.TabIndex = 0
        lblKitchenStatus.Text = "THE STATUS OF THE PROCESS"
        ' 
        ' tabKitchen
        ' 
        tabKitchen.Controls.Add(lblTotalRevenue)
        tabKitchen.Controls.Add(btnCalculateRevenue)
        tabKitchen.Controls.Add(btnRefresh)
        tabKitchen.Controls.Add(lblLiveStatus)
        tabKitchen.Controls.Add(KitchenOrders)
        tabKitchen.Controls.Add(lblKitchenDashboard)
        tabKitchen.Location = New Point(4, 29)
        tabKitchen.Margin = New Padding(3, 4, 3, 4)
        tabKitchen.Name = "tabKitchen"
        tabKitchen.Padding = New Padding(3, 4, 3, 4)
        tabKitchen.Size = New Size(828, 551)
        tabKitchen.TabIndex = 2
        tabKitchen.Text = "Kitchen"
        tabKitchen.UseVisualStyleBackColor = True
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.Location = New Point(106, 382)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(173, 21)
        lblTotalRevenue.TabIndex = 5
        lblTotalRevenue.Text = """Total Revenue: 0 birr"""
        ' 
        ' btnCalculateRevenue
        ' 
        btnCalculateRevenue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculateRevenue.Location = New Point(92, 320)
        btnCalculateRevenue.Name = "btnCalculateRevenue"
        btnCalculateRevenue.Size = New Size(201, 39)
        btnCalculateRevenue.TabIndex = 4
        btnCalculateRevenue.Text = """Calculate Revenue"""
        btnCalculateRevenue.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(569, 320)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(109, 47)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' lblLiveStatus
        ' 
        lblLiveStatus.AutoSize = True
        lblLiveStatus.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLiveStatus.Location = New Point(544, 279)
        lblLiveStatus.Name = "lblLiveStatus"
        lblLiveStatus.Size = New Size(160, 20)
        lblLiveStatus.TabIndex = 2
        lblLiveStatus.Text = """Live Status Monitor"""
        ' 
        ' KitchenOrders
        ' 
        KitchenOrders.FormattingEnabled = True
        KitchenOrders.ItemHeight = 20
        KitchenOrders.Location = New Point(106, 111)
        KitchenOrders.Name = "KitchenOrders"
        KitchenOrders.Size = New Size(665, 124)
        KitchenOrders.TabIndex = 1
        ' 
        ' lblKitchenDashboard
        ' 
        lblKitchenDashboard.AutoSize = True
        lblKitchenDashboard.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKitchenDashboard.Location = New Point(250, 36)
        lblKitchenDashboard.Name = "lblKitchenDashboard"
        lblKitchenDashboard.Size = New Size(212, 25)
        lblKitchenDashboard.TabIndex = 0
        lblKitchenDashboard.Text = """Kitchen Dashboard"""
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitle.Location = New Point(305, 39)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(219, 21)
        lbltitle.TabIndex = 1
        lbltitle.Text = "GROUP 7 CAFE & RESTORANT"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(914, 648)
        Controls.Add(lbltitle)
        Controls.Add(tabMain)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        tabMain.ResumeLayout(False)
        tabCustomer.ResumeLayout(False)
        tabCustomer.PerformLayout()
        CType(Picshiro, ComponentModel.ISupportInitialize).EndInit()
        CType(Picruzdinich, ComponentModel.ISupportInitialize).EndInit()
        CType(Pickinche, ComponentModel.ISupportInitialize).EndInit()
        CType(Picenkulal, ComponentModel.ISupportInitialize).EndInit()
        CType(Picfirfir, ComponentModel.ISupportInitialize).EndInit()
        CType(Picaynet, ComponentModel.ISupportInitialize).EndInit()
        tabSystem.ResumeLayout(False)
        tabSystem.PerformLayout()
        tabKitchen.ResumeLayout(False)
        tabKitchen.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabCustomer As TabPage
    Friend WithEvents tabSystem As TabPage
    Friend WithEvents tabKitchen As TabPage
    Friend WithEvents lbltitle As Label
    Friend WithEvents Picaynet As PictureBox
    Friend WithEvents lblTitleCustomer As Label
    Friend WithEvents Picshiro As PictureBox
    Friend WithEvents Picruzdinich As PictureBox
    Friend WithEvents Pickinche As PictureBox
    Friend WithEvents Picenkulal As PictureBox
    Friend WithEvents Picfirfir As PictureBox
    Friend WithEvents lblshiro As Label
    Friend WithEvents lblruzdinich As Label
    Friend WithEvents lblkinche As Label
    Friend WithEvents lblfirfir As Label
    Friend WithEvents lblenkulal As Label
    Friend WithEvents lblaynet As Label
    Friend WithEvents btnReady As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents btnDeliver As Button
    Friend WithEvents btnCook As Button
    Friend WithEvents lblKitchenStatus As Label
    Friend WithEvents showlogs As ListBox
    Friend WithEvents lblLiveStatus As Label
    Friend WithEvents KitchenOrders As ListBox
    Friend WithEvents lblKitchenDashboard As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents cmbRating As ComboBox
    Friend WithEvents lblFeedback As Label
    Friend WithEvents btnSubmitFeedback As Button
    Friend WithEvents lblfeedbk As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents btnCalculateRevenue As Button

End Class
