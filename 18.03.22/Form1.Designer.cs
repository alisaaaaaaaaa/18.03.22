
namespace _18._03._22
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.ships = new System.Windows.Forms.TabPage();
            this.shiptable = new System.Windows.Forms.DataGridView();
            this.loadcapacitucoloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricecoloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagelevelcoloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submarines = new System.Windows.Forms.TabPage();
            this.submarinetable = new System.Windows.Forms.DataGridView();
            this.rockets = new System.Windows.Forms.TabPage();
            this.damagelevelcoloumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricecoloumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthcoloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rockettable = new System.Windows.Forms.DataGridView();
            this.damagelevel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricecoloumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeofflightcoloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.ships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiptable)).BeginInit();
            this.submarines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submarinetable)).BeginInit();
            this.rockets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rockettable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.ships);
            this.tabs.Controls.Add(this.submarines);
            this.tabs.Controls.Add(this.rockets);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 450);
            this.tabs.TabIndex = 0;
            // 
            // ships
            // 
            this.ships.Controls.Add(this.shiptable);
            this.ships.Location = new System.Drawing.Point(4, 22);
            this.ships.Name = "ships";
            this.ships.Padding = new System.Windows.Forms.Padding(3);
            this.ships.Size = new System.Drawing.Size(792, 424);
            this.ships.TabIndex = 0;
            this.ships.Text = "корабли";
            this.ships.UseVisualStyleBackColor = true;
            // 
            // shiptable
            // 
            this.shiptable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiptable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loadcapacitucoloumn,
            this.pricecoloumn,
            this.damagelevelcoloumn});
            this.shiptable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiptable.Location = new System.Drawing.Point(3, 3);
            this.shiptable.Name = "shiptable";
            this.shiptable.Size = new System.Drawing.Size(786, 418);
            this.shiptable.TabIndex = 0;
            // 
            // loadcapacitucoloumn
            // 
            this.loadcapacitucoloumn.HeaderText = "грузоподъемность";
            this.loadcapacitucoloumn.Name = "loadcapacitucoloumn";
            // 
            // pricecoloumn
            // 
            this.pricecoloumn.HeaderText = "стоимость";
            this.pricecoloumn.Name = "pricecoloumn";
            // 
            // damagelevelcoloumn
            // 
            this.damagelevelcoloumn.HeaderText = "уровень урона";
            this.damagelevelcoloumn.Name = "damagelevelcoloumn";
            // 
            // submarines
            // 
            this.submarines.Controls.Add(this.submarinetable);
            this.submarines.Location = new System.Drawing.Point(4, 22);
            this.submarines.Name = "submarines";
            this.submarines.Padding = new System.Windows.Forms.Padding(3);
            this.submarines.Size = new System.Drawing.Size(792, 424);
            this.submarines.TabIndex = 1;
            this.submarines.Text = "подводные лодки";
            this.submarines.UseVisualStyleBackColor = true;
            // 
            // submarinetable
            // 
            this.submarinetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.submarinetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.damagelevelcoloumn1,
            this.pricecoloumn1,
            this.depthcoloumn});
            this.submarinetable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submarinetable.Location = new System.Drawing.Point(3, 3);
            this.submarinetable.Name = "submarinetable";
            this.submarinetable.Size = new System.Drawing.Size(786, 418);
            this.submarinetable.TabIndex = 0;
            // 
            // rockets
            // 
            this.rockets.Controls.Add(this.rockettable);
            this.rockets.Location = new System.Drawing.Point(4, 22);
            this.rockets.Name = "rockets";
            this.rockets.Size = new System.Drawing.Size(792, 424);
            this.rockets.TabIndex = 2;
            this.rockets.Text = "ракеты";
            this.rockets.UseVisualStyleBackColor = true;
            // 
            // damagelevelcoloumn1
            // 
            this.damagelevelcoloumn1.HeaderText = "уровень урона";
            this.damagelevelcoloumn1.Name = "damagelevelcoloumn1";
            // 
            // pricecoloumn1
            // 
            this.pricecoloumn1.HeaderText = "стоимость ";
            this.pricecoloumn1.Name = "pricecoloumn1";
            // 
            // depthcoloumn
            // 
            this.depthcoloumn.HeaderText = "глубина погрузки";
            this.depthcoloumn.Name = "depthcoloumn";
            // 
            // rockettable
            // 
            this.rockettable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rockettable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.damagelevel2,
            this.pricecoloumn2,
            this.rangeofflightcoloumn});
            this.rockettable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rockettable.Location = new System.Drawing.Point(0, 0);
            this.rockettable.Name = "rockettable";
            this.rockettable.Size = new System.Drawing.Size(792, 424);
            this.rockettable.TabIndex = 0;
            // 
            // damagelevel2
            // 
            this.damagelevel2.HeaderText = "уровень урона";
            this.damagelevel2.Name = "damagelevel2";
            // 
            // pricecoloumn2
            // 
            this.pricecoloumn2.HeaderText = "стоимость";
            this.pricecoloumn2.Name = "pricecoloumn2";
            // 
            // rangeofflightcoloumn
            // 
            this.rangeofflightcoloumn.HeaderText = "дальность полета";
            this.rangeofflightcoloumn.Name = "rangeofflightcoloumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Флот";
            this.tabs.ResumeLayout(false);
            this.ships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shiptable)).EndInit();
            this.submarines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submarinetable)).EndInit();
            this.rockets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rockettable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage ships;
        private System.Windows.Forms.TabPage submarines;
        private System.Windows.Forms.TabPage rockets;
        private System.Windows.Forms.DataGridView shiptable;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadcapacitucoloumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricecoloumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagelevelcoloumn;
        private System.Windows.Forms.DataGridView submarinetable;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagelevelcoloumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricecoloumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthcoloumn;
        private System.Windows.Forms.DataGridView rockettable;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagelevel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricecoloumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeofflightcoloumn;
    }
}

