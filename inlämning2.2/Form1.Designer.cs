namespace inlämning2._2
{
    partial class FormShotgun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShotgun));
            buttonShoot = new Button();
            buttonBlock = new Button();
            buttonReload = new Button();
            SCPlayer = new TextBox();
            SCNpc = new TextBox();
            History = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonShoot
            // 
            buttonShoot.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonShoot.Location = new Point(105, 222);
            buttonShoot.Margin = new Padding(3, 2, 3, 2);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(82, 22);
            buttonShoot.TabIndex = 0;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = true;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonBlock
            // 
            buttonBlock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBlock.Location = new Point(105, 249);
            buttonBlock.Margin = new Padding(3, 2, 3, 2);
            buttonBlock.Name = "buttonBlock";
            buttonBlock.Size = new Size(82, 22);
            buttonBlock.TabIndex = 1;
            buttonBlock.Text = "Block";
            buttonBlock.UseVisualStyleBackColor = true;
            buttonBlock.Click += buttonBlock_Click;
            // 
            // buttonReload
            // 
            buttonReload.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReload.Location = new Point(105, 275);
            buttonReload.Margin = new Padding(3, 2, 3, 2);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(82, 22);
            buttonReload.TabIndex = 2;
            buttonReload.Text = "Reload";
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Click += buttonReload_Click;
            // 
            // SCPlayer
            // 
            SCPlayer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SCPlayer.Location = new Point(105, 197);
            SCPlayer.Margin = new Padding(3, 2, 3, 2);
            SCPlayer.Name = "SCPlayer";
            SCPlayer.Size = new Size(80, 23);
            SCPlayer.TabIndex = 3;
            // 
            // SCNpc
            // 
            SCNpc.Location = new Point(471, 197);
            SCNpc.Margin = new Padding(3, 2, 3, 2);
            SCNpc.Name = "SCNpc";
            SCNpc.Size = new Size(74, 23);
            SCNpc.TabIndex = 4;
            // 
            // History
            // 
            History.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.FormattingEnabled = true;
            History.ItemHeight = 20;
            History.Location = new Point(219, 180);
            History.Margin = new Padding(3, 2, 3, 2);
            History.Name = "History";
            History.Size = new Size(221, 204);
            History.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 180);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Player Ammo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(471, 180);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = " NPC Ammo";
            // 
            // FormShotgun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(635, 438);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(History);
            Controls.Add(SCNpc);
            Controls.Add(SCPlayer);
            Controls.Add(buttonReload);
            Controls.Add(buttonBlock);
            Controls.Add(buttonShoot);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormShotgun";
            Text = "SHOTGUN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShoot;
        private Button buttonBlock;
        private Button buttonReload;
        private TextBox SCPlayer;
        private TextBox SCNpc;
        private ListBox History;
        private Label label1;
        private Label label2;
    }
}
