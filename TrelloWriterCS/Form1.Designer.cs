
namespace TrelloWriterCS
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Help_Version = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_devInfo = new System.Windows.Forms.GroupBox();
            this.button_user_auth = new System.Windows.Forms.Button();
            this.label_devInfoDesc1 = new System.Windows.Forms.Label();
            this.label_debugDesc2 = new System.Windows.Forms.Label();
            this.label_debugDesc1 = new System.Windows.Forms.Label();
            this.comboBox_devToken = new System.Windows.Forms.ComboBox();
            this.comboBox_devKey = new System.Windows.Forms.ComboBox();
            this.comboBox_userName = new System.Windows.Forms.ComboBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_devKey = new System.Windows.Forms.Label();
            this.groupBox_boardInfo = new System.Windows.Forms.GroupBox();
            this.label_boardInfoDesc2 = new System.Windows.Forms.Label();
            this.label_boardInfoDesc1 = new System.Windows.Forms.Label();
            this.label_listName = new System.Windows.Forms.Label();
            this.comboBox_listName = new System.Windows.Forms.ComboBox();
            this.comboBox_boardName = new System.Windows.Forms.ComboBox();
            this.label_bordName = new System.Windows.Forms.Label();
            this.button_commit = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_devInfo.SuspendLayout();
            this.groupBox_boardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File,
            this.MenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_File
            // 
            this.MenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_File_Exit});
            this.MenuItem_File.Name = "MenuItem_File";
            this.MenuItem_File.Size = new System.Drawing.Size(53, 20);
            this.MenuItem_File.Text = "ファイル";
            // 
            // MenuItem_File_Exit
            // 
            this.MenuItem_File_Exit.Name = "MenuItem_File_Exit";
            this.MenuItem_File_Exit.Size = new System.Drawing.Size(98, 22);
            this.MenuItem_File_Exit.Text = "終了";
            this.MenuItem_File_Exit.Click += new System.EventHandler(this.MenuItem_File_Exit_Click);
            // 
            // MenuItem_Help
            // 
            this.MenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Help_Version});
            this.MenuItem_Help.Name = "MenuItem_Help";
            this.MenuItem_Help.Size = new System.Drawing.Size(48, 20);
            this.MenuItem_Help.Text = "ヘルプ";
            // 
            // MenuItem_Help_Version
            // 
            this.MenuItem_Help_Version.Name = "MenuItem_Help_Version";
            this.MenuItem_Help_Version.Size = new System.Drawing.Size(142, 22);
            this.MenuItem_Help_Version.Text = "バージョン情報";
            this.MenuItem_Help_Version.Click += new System.EventHandler(this.MenuItem_Help_Version_Click);
            // 
            // groupBox_devInfo
            // 
            this.groupBox_devInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_devInfo.Controls.Add(this.button_user_auth);
            this.groupBox_devInfo.Controls.Add(this.label_devInfoDesc1);
            this.groupBox_devInfo.Controls.Add(this.label_debugDesc2);
            this.groupBox_devInfo.Controls.Add(this.label_debugDesc1);
            this.groupBox_devInfo.Controls.Add(this.comboBox_devToken);
            this.groupBox_devInfo.Controls.Add(this.comboBox_devKey);
            this.groupBox_devInfo.Controls.Add(this.comboBox_userName);
            this.groupBox_devInfo.Controls.Add(this.label_userName);
            this.groupBox_devInfo.Controls.Add(this.label1);
            this.groupBox_devInfo.Controls.Add(this.label_devKey);
            this.groupBox_devInfo.Location = new System.Drawing.Point(12, 27);
            this.groupBox_devInfo.Name = "groupBox_devInfo";
            this.groupBox_devInfo.Size = new System.Drawing.Size(723, 127);
            this.groupBox_devInfo.TabIndex = 1;
            this.groupBox_devInfo.TabStop = false;
            this.groupBox_devInfo.Text = "開発者情報";
            // 
            // button_user_auth
            // 
            this.button_user_auth.Location = new System.Drawing.Point(642, 17);
            this.button_user_auth.Name = "button_user_auth";
            this.button_user_auth.Size = new System.Drawing.Size(75, 23);
            this.button_user_auth.TabIndex = 3;
            this.button_user_auth.Text = "認証";
            this.button_user_auth.UseVisualStyleBackColor = true;
            this.button_user_auth.Click += new System.EventHandler(this.button_user_auth_Click);
            // 
            // label_devInfoDesc1
            // 
            this.label_devInfoDesc1.AutoSize = true;
            this.label_devInfoDesc1.Location = new System.Drawing.Point(6, 103);
            this.label_devInfoDesc1.Name = "label_devInfoDesc1";
            this.label_devInfoDesc1.Size = new System.Drawing.Size(441, 12);
            this.label_devInfoDesc1.TabIndex = 95;
            this.label_devInfoDesc1.Text = "・認証ボタン押下後でないと一括登録できません。（キーとトークンが不正な場合は登録不可）";
            // 
            // label_debugDesc2
            // 
            this.label_debugDesc2.AutoSize = true;
            this.label_debugDesc2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_debugDesc2.ForeColor = System.Drawing.Color.Red;
            this.label_debugDesc2.Location = new System.Drawing.Point(492, 75);
            this.label_debugDesc2.Name = "label_debugDesc2";
            this.label_debugDesc2.Size = new System.Drawing.Size(150, 11);
            this.label_debugDesc2.TabIndex = 94;
            this.label_debugDesc2.Text = "※デバッグ情報 (リリース版で削除)";
            this.label_debugDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_debugDesc1
            // 
            this.label_debugDesc1.AutoSize = true;
            this.label_debugDesc1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_debugDesc1.ForeColor = System.Drawing.Color.Red;
            this.label_debugDesc1.Location = new System.Drawing.Point(326, 49);
            this.label_debugDesc1.Name = "label_debugDesc1";
            this.label_debugDesc1.Size = new System.Drawing.Size(150, 11);
            this.label_debugDesc1.TabIndex = 93;
            this.label_debugDesc1.Text = "※デバッグ情報 (リリース版で削除)";
            this.label_debugDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_devToken
            // 
            this.comboBox_devToken.Enabled = false;
            this.comboBox_devToken.FormattingEnabled = true;
            this.comboBox_devToken.Location = new System.Drawing.Point(77, 71);
            this.comboBox_devToken.Name = "comboBox_devToken";
            this.comboBox_devToken.Size = new System.Drawing.Size(409, 20);
            this.comboBox_devToken.TabIndex = 5;
            // 
            // comboBox_devKey
            // 
            this.comboBox_devKey.Enabled = false;
            this.comboBox_devKey.FormattingEnabled = true;
            this.comboBox_devKey.Location = new System.Drawing.Point(77, 45);
            this.comboBox_devKey.Name = "comboBox_devKey";
            this.comboBox_devKey.Size = new System.Drawing.Size(243, 20);
            this.comboBox_devKey.TabIndex = 4;
            // 
            // comboBox_userName
            // 
            this.comboBox_userName.FormattingEnabled = true;
            this.comboBox_userName.Location = new System.Drawing.Point(77, 19);
            this.comboBox_userName.Name = "comboBox_userName";
            this.comboBox_userName.Size = new System.Drawing.Size(138, 20);
            this.comboBox_userName.TabIndex = 2;
            this.comboBox_userName.SelectedIndexChanged += new System.EventHandler(this.comboBox_userName_SelectedIndexChanged);
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Location = new System.Drawing.Point(29, 22);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(29, 12);
            this.label_userName.TabIndex = 90;
            this.label_userName.Text = "氏名";
            this.label_userName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 92;
            this.label1.Text = "トークン";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_devKey
            // 
            this.label_devKey.AutoSize = true;
            this.label_devKey.Location = new System.Drawing.Point(33, 48);
            this.label_devKey.Name = "label_devKey";
            this.label_devKey.Size = new System.Drawing.Size(25, 12);
            this.label_devKey.TabIndex = 91;
            this.label_devKey.Text = "キー";
            this.label_devKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox_boardInfo
            // 
            this.groupBox_boardInfo.Controls.Add(this.label_boardInfoDesc2);
            this.groupBox_boardInfo.Controls.Add(this.label_boardInfoDesc1);
            this.groupBox_boardInfo.Controls.Add(this.label_listName);
            this.groupBox_boardInfo.Controls.Add(this.comboBox_listName);
            this.groupBox_boardInfo.Controls.Add(this.comboBox_boardName);
            this.groupBox_boardInfo.Controls.Add(this.label_bordName);
            this.groupBox_boardInfo.Location = new System.Drawing.Point(12, 160);
            this.groupBox_boardInfo.Name = "groupBox_boardInfo";
            this.groupBox_boardInfo.Size = new System.Drawing.Size(723, 96);
            this.groupBox_boardInfo.TabIndex = 6;
            this.groupBox_boardInfo.TabStop = false;
            this.groupBox_boardInfo.Text = "登録先のボード情報";
            // 
            // label_boardInfoDesc2
            // 
            this.label_boardInfoDesc2.AutoSize = true;
            this.label_boardInfoDesc2.Location = new System.Drawing.Point(6, 73);
            this.label_boardInfoDesc2.Name = "label_boardInfoDesc2";
            this.label_boardInfoDesc2.Size = new System.Drawing.Size(368, 12);
            this.label_boardInfoDesc2.TabIndex = 99;
            this.label_boardInfoDesc2.Text = "・テンプレート情報、ラベル、ユーザ、チェックリストは登録されません（β版仕様）";
            // 
            // label_boardInfoDesc1
            // 
            this.label_boardInfoDesc1.AutoSize = true;
            this.label_boardInfoDesc1.Location = new System.Drawing.Point(6, 52);
            this.label_boardInfoDesc1.Name = "label_boardInfoDesc1";
            this.label_boardInfoDesc1.Size = new System.Drawing.Size(287, 12);
            this.label_boardInfoDesc1.TabIndex = 98;
            this.label_boardInfoDesc1.Text = "・登録先のボード、リストが存在しない場合はエラーとなります";
            // 
            // label_listName
            // 
            this.label_listName.AutoSize = true;
            this.label_listName.Location = new System.Drawing.Point(381, 21);
            this.label_listName.Name = "label_listName";
            this.label_listName.Size = new System.Drawing.Size(87, 12);
            this.label_listName.TabIndex = 97;
            this.label_listName.Text = "登録先のリスト名";
            this.label_listName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_listName
            // 
            this.comboBox_listName.FormattingEnabled = true;
            this.comboBox_listName.Location = new System.Drawing.Point(474, 18);
            this.comboBox_listName.Name = "comboBox_listName";
            this.comboBox_listName.Size = new System.Drawing.Size(243, 20);
            this.comboBox_listName.TabIndex = 8;
            this.comboBox_listName.SelectedIndexChanged += new System.EventHandler(this.comboBox_listName_SelectedIndexChanged);
            // 
            // comboBox_boardName
            // 
            this.comboBox_boardName.FormattingEnabled = true;
            this.comboBox_boardName.Location = new System.Drawing.Point(110, 18);
            this.comboBox_boardName.Name = "comboBox_boardName";
            this.comboBox_boardName.Size = new System.Drawing.Size(243, 20);
            this.comboBox_boardName.TabIndex = 7;
            this.comboBox_boardName.SelectedIndexChanged += new System.EventHandler(this.comboBox_boardName_SelectedIndexChanged);
            // 
            // label_bordName
            // 
            this.label_bordName.AutoSize = true;
            this.label_bordName.Location = new System.Drawing.Point(12, 21);
            this.label_bordName.Name = "label_bordName";
            this.label_bordName.Size = new System.Drawing.Size(92, 12);
            this.label_bordName.TabIndex = 96;
            this.label_bordName.Text = "登録先のボード名";
            this.label_bordName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_commit
            // 
            this.button_commit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_commit.Location = new System.Drawing.Point(12, 262);
            this.button_commit.Name = "button_commit";
            this.button_commit.Size = new System.Drawing.Size(357, 31);
            this.button_commit.TabIndex = 9;
            this.button_commit.Text = "カード一括登録";
            this.button_commit.UseVisualStyleBackColor = true;
            this.button_commit.Click += new System.EventHandler(this.button_commit_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(376, 262);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(357, 31);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "終了";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 303);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_commit);
            this.Controls.Add(this.groupBox_boardInfo);
            this.Controls.Add(this.groupBox_devInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TrelloWriterCS ver.β";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_devInfo.ResumeLayout(false);
            this.groupBox_devInfo.PerformLayout();
            this.groupBox_boardInfo.ResumeLayout(false);
            this.groupBox_boardInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Help_Version;
        private System.Windows.Forms.GroupBox groupBox_devInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_devKey;
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.ComboBox comboBox_userName;
        private System.Windows.Forms.ComboBox comboBox_devToken;
        private System.Windows.Forms.ComboBox comboBox_devKey;
        private System.Windows.Forms.GroupBox groupBox_boardInfo;
        private System.Windows.Forms.Label label_debugDesc2;
        private System.Windows.Forms.Label label_debugDesc1;
        private System.Windows.Forms.ComboBox comboBox_listName;
        private System.Windows.Forms.ComboBox comboBox_boardName;
        private System.Windows.Forms.Label label_bordName;
        private System.Windows.Forms.Label label_devInfoDesc1;
        private System.Windows.Forms.Label label_listName;
        private System.Windows.Forms.Button button_commit;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_boardInfoDesc1;
        private System.Windows.Forms.Label label_boardInfoDesc2;
        private System.Windows.Forms.Button button_user_auth;
    }
}

