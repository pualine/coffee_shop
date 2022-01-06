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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelCost = New System.Windows.Forms.Panel()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.VATTextBox = New System.Windows.Forms.TextBox()
        Me.VATLabel = New System.Windows.Forms.Label()
        Me.BCTextBox = New System.Windows.Forms.TextBox()
        Me.LabelCost = New System.Windows.Forms.Label()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.OkBttn = New System.Windows.Forms.Button()
        Me.PsswdTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsrNmTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAccount = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.acctLogIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.acctLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboDrinkType = New System.Windows.Forms.ToolStripComboBox()
        Me.btnPurchase = New System.Windows.Forms.ToolStripButton()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelCost.SuspendLayout()
        Me.PanelLogin.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCost
        '
        Me.PanelCost.Controls.Add(Me.TotalTextBox)
        Me.PanelCost.Controls.Add(Me.TotalLabel)
        Me.PanelCost.Controls.Add(Me.VATTextBox)
        Me.PanelCost.Controls.Add(Me.VATLabel)
        Me.PanelCost.Controls.Add(Me.BCTextBox)
        Me.PanelCost.Controls.Add(Me.LabelCost)
        Me.PanelCost.Location = New System.Drawing.Point(33, 122)
        Me.PanelCost.Name = "PanelCost"
        Me.PanelCost.Size = New System.Drawing.Size(341, 221)
        Me.PanelCost.TabIndex = 0
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(172, 138)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(141, 28)
        Me.TotalTextBox.TabIndex = 1
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(110, 141)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(51, 24)
        Me.TotalLabel.TabIndex = 0
        Me.TotalLabel.Text = "Total"
        '
        'VATTextBox
        '
        Me.VATTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATTextBox.Location = New System.Drawing.Point(172, 89)
        Me.VATTextBox.Name = "VATTextBox"
        Me.VATTextBox.Size = New System.Drawing.Size(141, 28)
        Me.VATTextBox.TabIndex = 1
        '
        'VATLabel
        '
        Me.VATLabel.AutoSize = True
        Me.VATLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VATLabel.Location = New System.Drawing.Point(113, 92)
        Me.VATLabel.Name = "VATLabel"
        Me.VATLabel.Size = New System.Drawing.Size(48, 24)
        Me.VATLabel.TabIndex = 0
        Me.VATLabel.Text = "VAT"
        '
        'BCTextBox
        '
        Me.BCTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCTextBox.Location = New System.Drawing.Point(172, 38)
        Me.BCTextBox.Name = "BCTextBox"
        Me.BCTextBox.Size = New System.Drawing.Size(141, 28)
        Me.BCTextBox.TabIndex = 1
        '
        'LabelCost
        '
        Me.LabelCost.AutoSize = True
        Me.LabelCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCost.Location = New System.Drawing.Point(28, 38)
        Me.LabelCost.Name = "LabelCost"
        Me.LabelCost.Size = New System.Drawing.Size(133, 24)
        Me.LabelCost.TabIndex = 0
        Me.LabelCost.Text = "Beverage Cost"
        '
        'PanelLogin
        '
        Me.PanelLogin.Controls.Add(Me.OkBttn)
        Me.PanelLogin.Controls.Add(Me.PsswdTextBox)
        Me.PanelLogin.Controls.Add(Me.Label3)
        Me.PanelLogin.Controls.Add(Me.UsrNmTextBox)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Location = New System.Drawing.Point(436, 122)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(326, 221)
        Me.PanelLogin.TabIndex = 1
        '
        'OkBttn
        '
        Me.OkBttn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.OkBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBttn.ForeColor = System.Drawing.Color.GhostWhite
        Me.OkBttn.Location = New System.Drawing.Point(153, 168)
        Me.OkBttn.Name = "OkBttn"
        Me.OkBttn.Size = New System.Drawing.Size(107, 35)
        Me.OkBttn.TabIndex = 2
        Me.OkBttn.Text = "OK"
        Me.OkBttn.UseVisualStyleBackColor = False
        '
        'PsswdTextBox
        '
        Me.PsswdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PsswdTextBox.Location = New System.Drawing.Point(128, 113)
        Me.PsswdTextBox.Name = "PsswdTextBox"
        Me.PsswdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PsswdTextBox.Size = New System.Drawing.Size(182, 28)
        Me.PsswdTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password"
        '
        'UsrNmTextBox
        '
        Me.UsrNmTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsrNmTextBox.Location = New System.Drawing.Point(128, 38)
        Me.UsrNmTextBox.Name = "UsrNmTextBox"
        Me.UsrNmTextBox.Size = New System.Drawing.Size(182, 28)
        Me.UsrNmTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAccount, Me.ToolStripSeparator1, Me.cboDrinkType, Me.btnPurchase})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(807, 56)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAccount
        '
        Me.btnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.acctLogIn, Me.acctLogOut})
        Me.btnAccount.Image = CType(resources.GetObject("btnAccount.Image"), System.Drawing.Image)
        Me.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(76, 53)
        Me.btnAccount.Tag = ""
        Me.btnAccount.Text = "Account"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'acctLogIn
        '
        Me.acctLogIn.Name = "acctLogIn"
        Me.acctLogIn.Size = New System.Drawing.Size(160, 24)
        Me.acctLogIn.Text = "Log In"
        '
        'acctLogOut
        '
        Me.acctLogOut.Name = "acctLogOut"
        Me.acctLogOut.Size = New System.Drawing.Size(160, 24)
        Me.acctLogOut.Text = "Log Out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 56)
        '
        'cboDrinkType
        '
        Me.cboDrinkType.Items.AddRange(New Object() {"Black Coffee", "Strawberry Coffee", "Expresso", "Cappucino", "Latte", "Daily Brew"})
        Me.cboDrinkType.Name = "cboDrinkType"
        Me.cboDrinkType.Size = New System.Drawing.Size(150, 56)
        Me.cboDrinkType.Text = "Select Drink Type"
        Me.cboDrinkType.Visible = False
        '
        'btnPurchase
        '
        Me.btnPurchase.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnPurchase.BackColor = System.Drawing.Color.LightSalmon
        Me.btnPurchase.CheckOnClick = True
        Me.btnPurchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPurchase.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.ForeColor = System.Drawing.Color.White
        Me.btnPurchase.Image = CType(resources.GetObject("btnPurchase.Image"), System.Drawing.Image)
        Me.btnPurchase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPurchase.Margin = New System.Windows.Forms.Padding(0, 10, 20, 10)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Padding = New System.Windows.Forms.Padding(1)
        Me.btnPurchase.Size = New System.Drawing.Size(134, 36)
        Me.btnPurchase.Text = "Order Now"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.RosyBrown
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(260, 394)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(114, 41)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(807, 501)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelCost)
        Me.Name = "Form1"
        Me.Text = "Coffee Shop"
        Me.PanelCost.ResumeLayout(False)
        Me.PanelCost.PerformLayout()
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelCost As System.Windows.Forms.Panel
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents VATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VATLabel As System.Windows.Forms.Label
    Friend WithEvents BCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LabelCost As System.Windows.Forms.Label
    Friend WithEvents PanelLogin As System.Windows.Forms.Panel
    Friend WithEvents OkBttn As System.Windows.Forms.Button
    Friend WithEvents PsswdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UsrNmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAccount As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents acctLogIn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents acctLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cboDrinkType As System.Windows.Forms.ToolStripComboBox

    Private Sub cboDrinkTye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Prices of drinks in array
    Private ReadOnly coffeePrices As Double() = {2.0, 1.5, 1.03, 2.2, 3.0, 1.0, 1.06}
    Private ReadOnly vatRate As Double = 0.047

    Private Sub orderNowBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'User click to order 
        MessageBox.Show("Your order is placed!")

    End Sub

    Private Sub OkBttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBttn.Click
        'upon user click to log in
        PanelLogin.Visible = False
        cboDrinkType.Visible = True
    End Sub

    'Account Log In
    Private Sub acctLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctLogIn.Click
        PanelLogin.Visible = True
    End Sub
    'Account Log Out
    Private Sub acctLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctLogOut.Click
        cboDrinkType.Visible = False
        PanelLogin.Visible = False
        PanelCost.Visible = False
    End Sub

    Private Sub cboDrinkType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDrinkType.SelectedIndexChanged
        Dim cost As Double = coffeePrices(cboDrinkType.SelectedIndex)
        Dim vat As Double = cost * vatRate
        Dim total As Double = cost + vat

        BCTextBox.Text = cost.ToString("n")
        VATTextBox.Text = vat.ToString("n")
        TotalTextBox.Text = total.ToString("c")


        PanelCost.Visible = True
        btnPurchase.Visible = True


    End Sub
    Friend WithEvents btnPurchase As System.Windows.Forms.ToolStripButton

    Private Sub btnPurchase_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        'User click to order
        MessageBox.Show("Thank you, YOUR ORDER IS PLACED!")
    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
