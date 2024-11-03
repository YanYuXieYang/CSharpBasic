using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp.src
{
    // 自定义复合控件
    public class CompositeControl : UserControl
    {
        private Label label;
        private TextBox textBox;

        // 自定义属性
        [Browsable(true)]
        [Description("获取或设置文本框中的文本")]
        [Category("自定义")]
        public string CustomText
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public CompositeControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();

            // 设置label和textBox的属性
            this.label.Location = new System.Drawing.Point(0, 0);
            this.textBox.Location = new System.Drawing.Point(0, 20);

            // 添加到UserControl
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);

            // 设置UserControl的大小
            this.Size = new System.Drawing.Size(200, 50);
        }
    }
}