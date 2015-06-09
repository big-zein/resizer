namespace Resizer
{
    partial class Resizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resizer));
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.ListBox();
            this.btAddPreset = new System.Windows.Forms.Button();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResize = new System.Windows.Forms.Button();
            this.rbKeep = new System.Windows.Forms.RadioButton();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeletePreset = new System.Windows.Forms.Button();
            this.lbPosition = new System.Windows.Forms.ListBox();
            this.btAddPos = new System.Windows.Forms.Button();
            this.btnDelPos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerDelay
            // 
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(60, 155);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(58, 20);
            this.tbWidth.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // lbSize
            // 
            this.lbSize.FormattingEnabled = true;
            this.lbSize.Location = new System.Drawing.Point(60, 53);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(120, 95);
            this.lbSize.Sorted = true;
            this.lbSize.TabIndex = 3;
            // 
            // btAddPreset
            // 
            this.btAddPreset.Location = new System.Drawing.Point(60, 181);
            this.btAddPreset.Name = "btAddPreset";
            this.btAddPreset.Size = new System.Drawing.Size(38, 23);
            this.btAddPreset.TabIndex = 8;
            this.btAddPreset.Text = "Add";
            this.btAddPreset.UseVisualStyleBackColor = true;
            this.btAddPreset.Click += new System.EventHandler(this.btAddPreset_Click);
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(124, 155);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(58, 20);
            this.tbHeight.TabIndex = 7;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(244, 155);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(58, 20);
            this.tbX.TabIndex = 10;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(308, 155);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(58, 20);
            this.tbY.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Position";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(60, 210);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(69, 23);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "Resize (F1)";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // rbKeep
            // 
            this.rbKeep.AutoSize = true;
            this.rbKeep.Location = new System.Drawing.Point(244, 7);
            this.rbKeep.Name = "rbKeep";
            this.rbKeep.Size = new System.Drawing.Size(90, 17);
            this.rbKeep.TabIndex = 1;
            this.rbKeep.TabStop = true;
            this.rbKeep.Tag = "0";
            this.rbKeep.Text = "Keep Position";
            this.rbKeep.UseVisualStyleBackColor = true;
            this.rbKeep.CheckedChanged += new System.EventHandler(this.rbMove_CheckedChanged);
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(244, 30);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(68, 17);
            this.rbMove.TabIndex = 2;
            this.rbMove.TabStop = true;
            this.rbMove.Tag = "1";
            this.rbMove.Text = "Move To";
            this.rbMove.UseVisualStyleBackColor = true;
            this.rbMove.CheckedChanged += new System.EventHandler(this.rbMove_CheckedChanged);
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(60, 6);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(58, 20);
            this.tbDelay.TabIndex = 0;
            this.tbDelay.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Delay";
            // 
            // btnDeletePreset
            // 
            this.btnDeletePreset.Location = new System.Drawing.Point(104, 181);
            this.btnDeletePreset.Name = "btnDeletePreset";
            this.btnDeletePreset.Size = new System.Drawing.Size(56, 23);
            this.btnDeletePreset.TabIndex = 9;
            this.btnDeletePreset.Text = "Delete";
            this.btnDeletePreset.UseVisualStyleBackColor = true;
            this.btnDeletePreset.Click += new System.EventHandler(this.btnDeletePreset_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.FormattingEnabled = true;
            this.lbPosition.Location = new System.Drawing.Point(244, 53);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(120, 95);
            this.lbPosition.Sorted = true;
            this.lbPosition.TabIndex = 4;
            // 
            // btAddPos
            // 
            this.btAddPos.Location = new System.Drawing.Point(244, 181);
            this.btAddPos.Name = "btAddPos";
            this.btAddPos.Size = new System.Drawing.Size(34, 23);
            this.btAddPos.TabIndex = 12;
            this.btAddPos.Text = "Add";
            this.btAddPos.UseVisualStyleBackColor = true;
            this.btAddPos.Click += new System.EventHandler(this.btAddPos_Click);
            // 
            // btnDelPos
            // 
            this.btnDelPos.Location = new System.Drawing.Point(284, 181);
            this.btnDelPos.Name = "btnDelPos";
            this.btnDelPos.Size = new System.Drawing.Size(50, 23);
            this.btnDelPos.TabIndex = 13;
            this.btnDelPos.Text = "Delete";
            this.btnDelPos.UseVisualStyleBackColor = true;
            this.btnDelPos.Click += new System.EventHandler(this.btnDelPos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ms";
            // 
            // Resizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.rbMove);
            this.Controls.Add(this.rbKeep);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnDelPos);
            this.Controls.Add(this.btnDeletePreset);
            this.Controls.Add(this.btAddPos);
            this.Controls.Add(this.btAddPreset);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbHeight);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resizer";
            this.Text = "Resizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Resizer_FormClosed);
            this.Load += new System.EventHandler(this.Resizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSize;
        private System.Windows.Forms.Button btAddPreset;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.RadioButton rbKeep;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.TextBox tbDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeletePreset;
        private System.Windows.Forms.ListBox lbPosition;
        private System.Windows.Forms.Button btAddPos;
        private System.Windows.Forms.Button btnDelPos;
        private System.Windows.Forms.Label label2;

    }
}

