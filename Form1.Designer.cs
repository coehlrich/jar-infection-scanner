﻿namespace JarInfectionScanner {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.buttonBrowse = new System.Windows.Forms.Button();
      this.textBoxFolderFile = new System.Windows.Forms.TextBox();
      this.buttonScan = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.textBoxOutput = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.buttonClearOutput = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.textBoxDetections = new System.Windows.Forms.TextBox();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.labelStatus = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.buttonBrowse);
      this.groupBox1.Controls.Add(this.textBoxFolderFile);
      this.groupBox1.Location = new System.Drawing.Point(13, 21);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1447, 59);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Folder/File:";
      // 
      // buttonBrowse
      // 
      this.buttonBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.buttonBrowse.Location = new System.Drawing.Point(1366, 22);
      this.buttonBrowse.Name = "buttonBrowse";
      this.buttonBrowse.Size = new System.Drawing.Size(75, 26);
      this.buttonBrowse.TabIndex = 1;
      this.buttonBrowse.Text = "Browse";
      this.buttonBrowse.UseVisualStyleBackColor = true;
      this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
      // 
      // textBoxFolderFile
      // 
      this.textBoxFolderFile.AllowDrop = true;
      this.textBoxFolderFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxFolderFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxFolderFile.Location = new System.Drawing.Point(7, 22);
      this.textBoxFolderFile.Name = "textBoxFolderFile";
      this.textBoxFolderFile.Size = new System.Drawing.Size(1352, 26);
      this.textBoxFolderFile.TabIndex = 0;
      this.textBoxFolderFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFolderFile_DragDrop);
      // 
      // buttonScan
      // 
      this.buttonScan.Location = new System.Drawing.Point(12, 93);
      this.buttonScan.Name = "buttonScan";
      this.buttonScan.Size = new System.Drawing.Size(83, 33);
      this.buttonScan.TabIndex = 1;
      this.buttonScan.Text = "Scan";
      this.buttonScan.UseVisualStyleBackColor = true;
      this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.textBoxOutput);
      this.groupBox2.Location = new System.Drawing.Point(20, 133);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(764, 645);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Output:";
      // 
      // textBoxOutput
      // 
      this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxOutput.Location = new System.Drawing.Point(7, 22);
      this.textBoxOutput.Multiline = true;
      this.textBoxOutput.Name = "textBoxOutput";
      this.textBoxOutput.ReadOnly = true;
      this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxOutput.Size = new System.Drawing.Size(745, 605);
      this.textBoxOutput.TabIndex = 0;
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Location = new System.Drawing.Point(0, 781);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1477, 22);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // buttonClearOutput
      // 
      this.buttonClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClearOutput.Location = new System.Drawing.Point(1379, 94);
      this.buttonClearOutput.Name = "buttonClearOutput";
      this.buttonClearOutput.Size = new System.Drawing.Size(82, 33);
      this.buttonClearOutput.TabIndex = 4;
      this.buttonClearOutput.Text = "Clear";
      this.buttonClearOutput.UseVisualStyleBackColor = true;
      this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.Controls.Add(this.textBoxDetections);
      this.groupBox3.Location = new System.Drawing.Point(790, 133);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(675, 645);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Infected files:";
      // 
      // textBoxDetections
      // 
      this.textBoxDetections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxDetections.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxDetections.ForeColor = System.Drawing.Color.Red;
      this.textBoxDetections.Location = new System.Drawing.Point(6, 22);
      this.textBoxDetections.Multiline = true;
      this.textBoxDetections.Name = "textBoxDetections";
      this.textBoxDetections.ReadOnly = true;
      this.textBoxDetections.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxDetections.Size = new System.Drawing.Size(658, 605);
      this.textBoxDetections.TabIndex = 1;
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(122, 99);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(689, 20);
      this.progressBar.TabIndex = 6;
      // 
      // labelStatus
      // 
      this.labelStatus.AutoSize = true;
      this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelStatus.Location = new System.Drawing.Point(829, 99);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(0, 20);
      this.labelStatus.TabIndex = 7;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1477, 803);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.buttonClearOutput);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.buttonScan);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "Jar Malware Scanner";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBoxFolderFile;
    private System.Windows.Forms.Button buttonScan;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox textBoxOutput;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.Button buttonBrowse;
    private System.Windows.Forms.Button buttonClearOutput;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox textBoxDetections;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label labelStatus;
  }
}

