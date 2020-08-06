namespace WindowControll
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupWindowMoveControl = new System.Windows.Forms.GroupBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.checkShowWindow = new System.Windows.Forms.CheckBox();
            this.groupWindowCoordinateControl = new System.Windows.Forms.GroupBox();
            this.labelHeightValue = new System.Windows.Forms.Label();
            this.labelWidthValue = new System.Windows.Forms.Label();
            this.labelMoveDistanceValue = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelMoveDistance = new System.Windows.Forms.Label();
            this.trackHeight = new System.Windows.Forms.TrackBar();
            this.trackWidth = new System.Windows.Forms.TrackBar();
            this.trackMoveDistance = new System.Windows.Forms.TrackBar();
            this.groupWindowColoerControl = new System.Windows.Forms.GroupBox();
            this.labelColorBValue = new System.Windows.Forms.Label();
            this.labelColorGValue = new System.Windows.Forms.Label();
            this.labelColorRValue = new System.Windows.Forms.Label();
            this.labelColorG = new System.Windows.Forms.Label();
            this.labelColorB = new System.Windows.Forms.Label();
            this.labelColorR = new System.Windows.Forms.Label();
            this.trackColorB = new System.Windows.Forms.TrackBar();
            this.trackColorG = new System.Windows.Forms.TrackBar();
            this.trackColorR = new System.Windows.Forms.TrackBar();
            this.groupWindowMoveControl.SuspendLayout();
            this.groupWindowCoordinateControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMoveDistance)).BeginInit();
            this.groupWindowColoerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupWindowMoveControl
            // 
            this.groupWindowMoveControl.Controls.Add(this.buttonDown);
            this.groupWindowMoveControl.Controls.Add(this.buttonRight);
            this.groupWindowMoveControl.Controls.Add(this.buttonCenter);
            this.groupWindowMoveControl.Controls.Add(this.buttonLeft);
            this.groupWindowMoveControl.Controls.Add(this.buttonUp);
            this.groupWindowMoveControl.Location = new System.Drawing.Point(12, 32);
            this.groupWindowMoveControl.Name = "groupWindowMoveControl";
            this.groupWindowMoveControl.Size = new System.Drawing.Size(134, 136);
            this.groupWindowMoveControl.TabIndex = 0;
            this.groupWindowMoveControl.TabStop = false;
            this.groupWindowMoveControl.Text = "子ウィンドウ位置制御";
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDown.Location = new System.Drawing.Point(55, 88);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(24, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMoveController_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRight.Location = new System.Drawing.Point(85, 59);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(24, 23);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMoveController_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCenter.Location = new System.Drawing.Point(55, 59);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(24, 23);
            this.buttonCenter.TabIndex = 2;
            this.buttonCenter.Text = "-";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonMoveController_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLeft.Location = new System.Drawing.Point(25, 59);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(24, 23);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMoveController_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUp.Location = new System.Drawing.Point(55, 30);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(24, 23);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMoveController_Click);
            // 
            // checkShowWindow
            // 
            this.checkShowWindow.AutoSize = true;
            this.checkShowWindow.Location = new System.Drawing.Point(214, 32);
            this.checkShowWindow.Name = "checkShowWindow";
            this.checkShowWindow.Size = new System.Drawing.Size(103, 16);
            this.checkShowWindow.TabIndex = 1;
            this.checkShowWindow.Text = "子ウィンドウ表示";
            this.checkShowWindow.UseVisualStyleBackColor = true;
            this.checkShowWindow.CheckedChanged += new System.EventHandler(this.checkShowWindow_CheckedChanged);
            // 
            // groupWindowCoordinateControl
            // 
            this.groupWindowCoordinateControl.Controls.Add(this.labelHeightValue);
            this.groupWindowCoordinateControl.Controls.Add(this.labelWidthValue);
            this.groupWindowCoordinateControl.Controls.Add(this.labelMoveDistanceValue);
            this.groupWindowCoordinateControl.Controls.Add(this.labelWidth);
            this.groupWindowCoordinateControl.Controls.Add(this.labelHeight);
            this.groupWindowCoordinateControl.Controls.Add(this.labelMoveDistance);
            this.groupWindowCoordinateControl.Controls.Add(this.trackHeight);
            this.groupWindowCoordinateControl.Controls.Add(this.trackWidth);
            this.groupWindowCoordinateControl.Controls.Add(this.trackMoveDistance);
            this.groupWindowCoordinateControl.Location = new System.Drawing.Point(214, 54);
            this.groupWindowCoordinateControl.Name = "groupWindowCoordinateControl";
            this.groupWindowCoordinateControl.Size = new System.Drawing.Size(206, 125);
            this.groupWindowCoordinateControl.TabIndex = 2;
            this.groupWindowCoordinateControl.TabStop = false;
            this.groupWindowCoordinateControl.Text = "子ウィンドウ座標制御";
            // 
            // labelHeightValue
            // 
            this.labelHeightValue.AutoSize = true;
            this.labelHeightValue.Location = new System.Drawing.Point(69, 94);
            this.labelHeightValue.Name = "labelHeightValue";
            this.labelHeightValue.Size = new System.Drawing.Size(11, 12);
            this.labelHeightValue.TabIndex = 8;
            this.labelHeightValue.Text = "1";
            // 
            // labelWidthValue
            // 
            this.labelWidthValue.AutoSize = true;
            this.labelWidthValue.Location = new System.Drawing.Point(69, 62);
            this.labelWidthValue.Name = "labelWidthValue";
            this.labelWidthValue.Size = new System.Drawing.Size(11, 12);
            this.labelWidthValue.TabIndex = 7;
            this.labelWidthValue.Text = "1";
            // 
            // labelMoveDistanceValue
            // 
            this.labelMoveDistanceValue.AutoSize = true;
            this.labelMoveDistanceValue.Location = new System.Drawing.Point(69, 30);
            this.labelMoveDistanceValue.Name = "labelMoveDistanceValue";
            this.labelMoveDistanceValue.Size = new System.Drawing.Size(11, 12);
            this.labelMoveDistanceValue.TabIndex = 6;
            this.labelMoveDistanceValue.Text = "1";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(18, 62);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(19, 12);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "幅:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(18, 94);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(27, 12);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "高さ:";
            // 
            // labelMoveDistance
            // 
            this.labelMoveDistance.AutoSize = true;
            this.labelMoveDistance.Location = new System.Drawing.Point(18, 30);
            this.labelMoveDistance.Name = "labelMoveDistance";
            this.labelMoveDistance.Size = new System.Drawing.Size(43, 12);
            this.labelMoveDistance.TabIndex = 3;
            this.labelMoveDistance.Text = "移動量:";
            // 
            // trackHeight
            // 
            this.trackHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackHeight.AutoSize = false;
            this.trackHeight.Location = new System.Drawing.Point(96, 88);
            this.trackHeight.Maximum = 1000;
            this.trackHeight.Minimum = 1;
            this.trackHeight.Name = "trackHeight";
            this.trackHeight.Size = new System.Drawing.Size(104, 25);
            this.trackHeight.TabIndex = 1;
            this.trackHeight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackHeight.Value = 1;
            this.trackHeight.Scroll += new System.EventHandler(this.trackCoordinateController_Scroll);
            // 
            // trackWidth
            // 
            this.trackWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackWidth.AutoSize = false;
            this.trackWidth.Location = new System.Drawing.Point(96, 56);
            this.trackWidth.Maximum = 1000;
            this.trackWidth.Minimum = 1;
            this.trackWidth.Name = "trackWidth";
            this.trackWidth.Size = new System.Drawing.Size(104, 25);
            this.trackWidth.TabIndex = 1;
            this.trackWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackWidth.Value = 1;
            this.trackWidth.Scroll += new System.EventHandler(this.trackCoordinateController_Scroll);
            // 
            // trackMoveDistance
            // 
            this.trackMoveDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackMoveDistance.AutoSize = false;
            this.trackMoveDistance.Location = new System.Drawing.Point(96, 24);
            this.trackMoveDistance.Maximum = 100;
            this.trackMoveDistance.Minimum = 1;
            this.trackMoveDistance.Name = "trackMoveDistance";
            this.trackMoveDistance.Size = new System.Drawing.Size(104, 25);
            this.trackMoveDistance.TabIndex = 0;
            this.trackMoveDistance.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackMoveDistance.Value = 1;
            this.trackMoveDistance.Scroll += new System.EventHandler(this.trackCoordinateController_Scroll);
            // 
            // groupWindowColoerControl
            // 
            this.groupWindowColoerControl.Controls.Add(this.labelColorBValue);
            this.groupWindowColoerControl.Controls.Add(this.labelColorGValue);
            this.groupWindowColoerControl.Controls.Add(this.labelColorRValue);
            this.groupWindowColoerControl.Controls.Add(this.labelColorG);
            this.groupWindowColoerControl.Controls.Add(this.labelColorB);
            this.groupWindowColoerControl.Controls.Add(this.labelColorR);
            this.groupWindowColoerControl.Controls.Add(this.trackColorB);
            this.groupWindowColoerControl.Controls.Add(this.trackColorG);
            this.groupWindowColoerControl.Controls.Add(this.trackColorR);
            this.groupWindowColoerControl.Location = new System.Drawing.Point(214, 185);
            this.groupWindowColoerControl.Name = "groupWindowColoerControl";
            this.groupWindowColoerControl.Size = new System.Drawing.Size(206, 126);
            this.groupWindowColoerControl.TabIndex = 9;
            this.groupWindowColoerControl.TabStop = false;
            this.groupWindowColoerControl.Text = "子ウィンドウ背景色制御";
            // 
            // labelColorBValue
            // 
            this.labelColorBValue.AutoSize = true;
            this.labelColorBValue.Location = new System.Drawing.Point(69, 94);
            this.labelColorBValue.Name = "labelColorBValue";
            this.labelColorBValue.Size = new System.Drawing.Size(11, 12);
            this.labelColorBValue.TabIndex = 8;
            this.labelColorBValue.Text = "0";
            // 
            // labelColorGValue
            // 
            this.labelColorGValue.AutoSize = true;
            this.labelColorGValue.Location = new System.Drawing.Point(69, 62);
            this.labelColorGValue.Name = "labelColorGValue";
            this.labelColorGValue.Size = new System.Drawing.Size(11, 12);
            this.labelColorGValue.TabIndex = 7;
            this.labelColorGValue.Text = "0";
            // 
            // labelColorRValue
            // 
            this.labelColorRValue.AutoSize = true;
            this.labelColorRValue.Location = new System.Drawing.Point(69, 30);
            this.labelColorRValue.Name = "labelColorRValue";
            this.labelColorRValue.Size = new System.Drawing.Size(11, 12);
            this.labelColorRValue.TabIndex = 6;
            this.labelColorRValue.Text = "0";
            // 
            // labelColorG
            // 
            this.labelColorG.AutoSize = true;
            this.labelColorG.Location = new System.Drawing.Point(18, 62);
            this.labelColorG.Name = "labelColorG";
            this.labelColorG.Size = new System.Drawing.Size(35, 12);
            this.labelColorG.TabIndex = 5;
            this.labelColorG.Text = "色(G):";
            // 
            // labelColorB
            // 
            this.labelColorB.AutoSize = true;
            this.labelColorB.Location = new System.Drawing.Point(18, 94);
            this.labelColorB.Name = "labelColorB";
            this.labelColorB.Size = new System.Drawing.Size(35, 12);
            this.labelColorB.TabIndex = 4;
            this.labelColorB.Text = "色(B):";
            // 
            // labelColorR
            // 
            this.labelColorR.AutoSize = true;
            this.labelColorR.Location = new System.Drawing.Point(18, 30);
            this.labelColorR.Name = "labelColorR";
            this.labelColorR.Size = new System.Drawing.Size(35, 12);
            this.labelColorR.TabIndex = 3;
            this.labelColorR.Text = "色(R):";
            // 
            // trackColorB
            // 
            this.trackColorB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackColorB.AutoSize = false;
            this.trackColorB.Location = new System.Drawing.Point(96, 88);
            this.trackColorB.Maximum = 255;
            this.trackColorB.Name = "trackColorB";
            this.trackColorB.Size = new System.Drawing.Size(104, 25);
            this.trackColorB.TabIndex = 2;
            this.trackColorB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackColorB.Scroll += new System.EventHandler(this.trackColorController_Scroll);
            // 
            // trackColorG
            // 
            this.trackColorG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackColorG.AutoSize = false;
            this.trackColorG.Location = new System.Drawing.Point(96, 56);
            this.trackColorG.Maximum = 255;
            this.trackColorG.Name = "trackColorG";
            this.trackColorG.Size = new System.Drawing.Size(104, 25);
            this.trackColorG.TabIndex = 1;
            this.trackColorG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackColorG.Scroll += new System.EventHandler(this.trackColorController_Scroll);
            // 
            // trackColorR
            // 
            this.trackColorR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackColorR.AutoSize = false;
            this.trackColorR.Location = new System.Drawing.Point(96, 24);
            this.trackColorR.Maximum = 255;
            this.trackColorR.Name = "trackColorR";
            this.trackColorR.Size = new System.Drawing.Size(104, 25);
            this.trackColorR.TabIndex = 0;
            this.trackColorR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackColorR.Scroll += new System.EventHandler(this.trackColorController_Scroll);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.groupWindowColoerControl);
            this.Controls.Add(this.groupWindowCoordinateControl);
            this.Controls.Add(this.checkShowWindow);
            this.Controls.Add(this.groupWindowMoveControl);
            this.Name = "Main";
            this.Text = "入門課題";
            this.groupWindowMoveControl.ResumeLayout(false);
            this.groupWindowCoordinateControl.ResumeLayout(false);
            this.groupWindowCoordinateControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMoveDistance)).EndInit();
            this.groupWindowColoerControl.ResumeLayout(false);
            this.groupWindowColoerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackColorR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupWindowMoveControl;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.CheckBox checkShowWindow;
        private System.Windows.Forms.GroupBox groupWindowCoordinateControl;
        private System.Windows.Forms.TrackBar trackHeight;
        private System.Windows.Forms.TrackBar trackWidth;
        private System.Windows.Forms.TrackBar trackMoveDistance;
        private System.Windows.Forms.Label labelHeightValue;
        private System.Windows.Forms.Label labelWidthValue;
        private System.Windows.Forms.Label labelMoveDistanceValue;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelMoveDistance;
        private System.Windows.Forms.GroupBox groupWindowColoerControl;
        private System.Windows.Forms.Label labelColorBValue;
        private System.Windows.Forms.Label labelColorGValue;
        private System.Windows.Forms.Label labelColorRValue;
        private System.Windows.Forms.Label labelColorG;
        private System.Windows.Forms.Label labelColorB;
        private System.Windows.Forms.Label labelColorR;
        private System.Windows.Forms.TrackBar trackColorB;
        private System.Windows.Forms.TrackBar trackColorG;
        private System.Windows.Forms.TrackBar trackColorR;
    }
}

