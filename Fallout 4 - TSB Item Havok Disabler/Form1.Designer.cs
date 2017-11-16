namespace Fallout_4___TSB_Item_Havok_Disabler
{
    partial class formProgramWindow
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
            this.formGroup = new System.Windows.Forms.GroupBox();
            this.formButtonLoadBlueprint = new System.Windows.Forms.Button();
            this.formTextBlueprintPath = new System.Windows.Forms.TextBox();
            this.dialogOpenBlueprint = new System.Windows.Forms.OpenFileDialog();
            this.formButtonBegin = new System.Windows.Forms.Button();
            this.formGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // formGroup
            // 
            this.formGroup.Controls.Add(this.formButtonBegin);
            this.formGroup.Controls.Add(this.formTextBlueprintPath);
            this.formGroup.Controls.Add(this.formButtonLoadBlueprint);
            this.formGroup.Location = new System.Drawing.Point(12, 12);
            this.formGroup.Name = "formGroup";
            this.formGroup.Size = new System.Drawing.Size(626, 102);
            this.formGroup.TabIndex = 0;
            this.formGroup.TabStop = false;
            // 
            // formButtonLoadBlueprint
            // 
            this.formButtonLoadBlueprint.Location = new System.Drawing.Point(6, 19);
            this.formButtonLoadBlueprint.Name = "formButtonLoadBlueprint";
            this.formButtonLoadBlueprint.Size = new System.Drawing.Size(83, 33);
            this.formButtonLoadBlueprint.TabIndex = 0;
            this.formButtonLoadBlueprint.Text = "Load Blueprint";
            this.formButtonLoadBlueprint.UseVisualStyleBackColor = true;
            this.formButtonLoadBlueprint.Click += new System.EventHandler(this.formButtonLoadBlueprint_Click);
            // 
            // formTextBlueprintPath
            // 
            this.formTextBlueprintPath.Location = new System.Drawing.Point(95, 26);
            this.formTextBlueprintPath.Name = "formTextBlueprintPath";
            this.formTextBlueprintPath.Size = new System.Drawing.Size(525, 20);
            this.formTextBlueprintPath.TabIndex = 1;
            // 
            // dialogOpenBlueprint
            // 
            this.dialogOpenBlueprint.Filter = "TSB Blueprint|*.json";
            // 
            // formButtonBegin
            // 
            this.formButtonBegin.Location = new System.Drawing.Point(537, 52);
            this.formButtonBegin.Name = "formButtonBegin";
            this.formButtonBegin.Size = new System.Drawing.Size(83, 35);
            this.formButtonBegin.TabIndex = 2;
            this.formButtonBegin.Text = "Begin";
            this.formButtonBegin.UseVisualStyleBackColor = true;
            this.formButtonBegin.Click += new System.EventHandler(this.formButtonBegin_Click);
            // 
            // formProgramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 126);
            this.Controls.Add(this.formGroup);
            this.Name = "formProgramWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSB Item Havok Disabler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.formGroup.ResumeLayout(false);
            this.formGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formGroup;
        private System.Windows.Forms.Button formButtonLoadBlueprint;
        private System.Windows.Forms.Button formButtonBegin;
        private System.Windows.Forms.TextBox formTextBlueprintPath;
        private System.Windows.Forms.OpenFileDialog dialogOpenBlueprint;
    }
}

