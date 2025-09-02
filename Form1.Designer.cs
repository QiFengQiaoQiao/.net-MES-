namespace TEST;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    // 设计器自动生成的组件容器
    private System.ComponentModel.IContainer components = null;
    // 账户标签控件
    private System.Windows.Forms.Label labelAccount;
    // 账户输入框控件
    private System.Windows.Forms.TextBox textBoxAccount;
    // 金额标签控件
    private System.Windows.Forms.Label labelAmount;
    // 金额输入框控件
    private System.Windows.Forms.TextBox textBoxAmount;
    // 确认按钮控件
    private System.Windows.Forms.Button buttonConfirm;
    // 历史查询按钮控件
    private System.Windows.Forms.Button buttonHistory;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
    // 初始化组件容器
    this.components = new System.ComponentModel.Container();
    // 设置窗体自动缩放模式
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

    // 账户标签控件属性设置
    this.labelAccount = new System.Windows.Forms.Label();
    this.labelAccount.AutoSize = true;
    this.labelAccount.Location = new System.Drawing.Point(50, 50);
    this.labelAccount.Name = "labelAccount";
    this.labelAccount.Size = new System.Drawing.Size(65, 20);
    this.labelAccount.TabIndex = 0;
    this.labelAccount.Text = "账户：";

    // 账户输入框控件属性设置
    this.textBoxAccount = new System.Windows.Forms.TextBox();
    this.textBoxAccount.Location = new System.Drawing.Point(150, 47);
    this.textBoxAccount.Name = "textBoxAccount";
    this.textBoxAccount.Size = new System.Drawing.Size(180, 27);
    this.textBoxAccount.TabIndex = 1;

    // 金额标签控件属性设置
    this.labelAmount = new System.Windows.Forms.Label();
    this.labelAmount.AutoSize = true;
    this.labelAmount.Location = new System.Drawing.Point(50, 100);
    this.labelAmount.Name = "labelAmount";
    this.labelAmount.Size = new System.Drawing.Size(89, 20);
    this.labelAmount.TabIndex = 2;
    this.labelAmount.Text = "过账金额：";
    this.labelAmount.BackColor = System.Drawing.Color.Transparent;

    // 金额输入框控件属性设置
    this.textBoxAmount = new System.Windows.Forms.TextBox();
    this.textBoxAmount.Location = new System.Drawing.Point(150, 97);
    this.textBoxAmount.Name = "textBoxAmount";
    this.textBoxAmount.Size = new System.Drawing.Size(180, 27);
    this.textBoxAmount.TabIndex = 3;
    // 限制只能输入数字和小数点
    this.textBoxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAmount_KeyPress);

    // 历史查询按钮控件属性设置
    this.buttonHistory = new System.Windows.Forms.Button();
    this.buttonHistory.Location = new System.Drawing.Point(270, 140);
    this.buttonHistory.Name = "buttonHistory";
    this.buttonHistory.Size = new System.Drawing.Size(100, 32);
    this.buttonHistory.TabIndex = 5;
    this.buttonHistory.Text = "历史查询";
    this.buttonHistory.UseVisualStyleBackColor = true;
    // 点击事件绑定
    this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);

    // 确认按钮控件属性设置
    this.buttonConfirm = new System.Windows.Forms.Button();
    this.buttonConfirm.Location = new System.Drawing.Point(150, 140);
    this.buttonConfirm.Name = "buttonConfirm";
    this.buttonConfirm.Size = new System.Drawing.Size(100, 32);
    this.buttonConfirm.TabIndex = 4;
    this.buttonConfirm.Text = "确认";
    this.buttonConfirm.UseVisualStyleBackColor = true;
    // 点击事件绑定
    this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);

    // 将控件添加到窗体上
    this.Controls.Add(this.labelAccount);
    this.Controls.Add(this.textBoxAccount);
    this.Controls.Add(this.labelAmount);
    this.Controls.Add(this.textBoxAmount);
    this.Controls.Add(this.buttonConfirm);
    this.Controls.Add(this.buttonHistory);

    // 设置窗体大小和标题
    this.ClientSize = new System.Drawing.Size(400, 220);
    this.Text = "账户过账界面";
    }

    #endregion
}
