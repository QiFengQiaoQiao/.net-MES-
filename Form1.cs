
// 命名空间，表示属于TEST项目
namespace TEST;

// Form1窗体类，继承自System.Windows.Forms.Form，代表一个窗口界面
public partial class Form1 : Form
{
    // 构造函数，初始化窗体和控件
    public Form1()
    {
        InitializeComponent();
    }

    // 确认按钮点击事件，进行过账检测和提示
    private void buttonConfirm_Click(object sender, EventArgs e)
    {
        // 获取输入内容
        string account = textBoxAccount.Text.Trim();
        string amountText = textBoxAmount.Text.Trim();
        // 检查账户是否为空
        if (string.IsNullOrEmpty(account))
        {
            MessageBox.Show("请输入账户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxAccount.Focus();
            return;
        }
        // 检查金额是否为空
        if (string.IsNullOrEmpty(amountText))
        {
            MessageBox.Show("请输入过账金额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxAmount.Focus();
            return;
        }
        // 检查金额格式和范围
        if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
        {
            MessageBox.Show("请输入有效的正数金额！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBoxAmount.Focus();
            return;
        }
        // 这里可添加实际过账逻辑
        MessageBox.Show("过账成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // 保存历史记录
        AddHistory(account, amount);
    }

    // 金额输入框按键事件，只允许输入数字和一个小数点
    private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
    {
        // 非数字、非控制键、非小数点则禁止输入
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        {
            e.Handled = true;
        }
        // 只允许一个小数点
        var tb = sender as TextBox;
        if (e.KeyChar == '.' && tb != null && tb.Text.Contains('.'))
        {
            e.Handled = true;
        }
    }

    // 历史查询按钮点击事件，弹窗显示历史记录
    private void buttonHistory_Click(object sender, EventArgs e)
    {
        // 创建历史查询弹窗
        var form = new Form();
        form.Text = "历史查询";
        form.Size = new System.Drawing.Size(350, 400);
        var listBox = new ListBox();
        listBox.Dock = DockStyle.Fill;
        listBox.HorizontalScrollbar = true;
        listBox.ScrollAlwaysVisible = true;
        // 判断是否有历史记录
        if (_historyList.Count == 0)
        {
            listBox.Items.Add("暂无历史记录。");
        }
        else
        {
            foreach (var h in _historyList)
            {
                listBox.Items.Add($"账户: {h.Account}    金额: {h.Amount}");
            }
        }
        form.Controls.Add(listBox);
        form.StartPosition = FormStartPosition.CenterParent;
        form.ShowDialog(this);
    }

    // 简单历史记录存储，保存每次过账的账户和金额
    private List<(string Account, decimal Amount)> _historyList = new List<(string, decimal)>();
    // 添加历史记录方法
    private void AddHistory(string account, decimal amount)
    {
        _historyList.Add((account, amount));
    }
}
