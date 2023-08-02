namespace AirdropHunter
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer

        private void InitializeComponent()
        {
            this.getAccountBalanceBackground = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.rpcURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.accountCount = new System.Windows.Forms.TextBox();
            this.accountCountLabel = new System.Windows.Forms.Label();
            this.extraWord = new System.Windows.Forms.TextBox();
            this.extraWordLabel = new System.Windows.Forms.Label();
            this.seedPhrase = new System.Windows.Forms.TextBox();
            this.seedPhraseLabel = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.privateKeyCheck6 = new System.Windows.Forms.CheckBox();
            this.privateKeyCheck5 = new System.Windows.Forms.CheckBox();
            this.privateKeyCheck4 = new System.Windows.Forms.CheckBox();
            this.privateKeyCheck3 = new System.Windows.Forms.CheckBox();
            this.privateKeyCheck2 = new System.Windows.Forms.CheckBox();
            this.privateKeyCheck1 = new System.Windows.Forms.CheckBox();
            this.balanceBox6 = new System.Windows.Forms.TextBox();
            this.balanceBox5 = new System.Windows.Forms.TextBox();
            this.balanceBox4 = new System.Windows.Forms.TextBox();
            this.balanceBox3 = new System.Windows.Forms.TextBox();
            this.balanceBox2 = new System.Windows.Forms.TextBox();
            this.balanceBox1 = new System.Windows.Forms.TextBox();
            this.privateKeyBox5 = new System.Windows.Forms.TextBox();
            this.privateKeyBox6 = new System.Windows.Forms.TextBox();
            this.privateKeyBox3 = new System.Windows.Forms.TextBox();
            this.privateKeyBox4 = new System.Windows.Forms.TextBox();
            this.privateKeyBox1 = new System.Windows.Forms.TextBox();
            this.privateKeyBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.privateKeyMode = new System.Windows.Forms.RadioButton();
            this.seedMode = new System.Windows.Forms.RadioButton();
            this.testRPCBackground = new System.ComponentModel.BackgroundWorker();
            this.loadAccountsFromPrivateKey = new System.ComponentModel.BackgroundWorker();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nativeTransferCooldown = new System.Windows.Forms.TextBox();
            this.nativeTransferCooldownLabel = new System.Windows.Forms.Label();
            this.nativeTransferPercent = new System.Windows.Forms.TextBox();
            this.nativeTransferPercentLabel = new System.Windows.Forms.Label();
            this.nativeTransferLoop = new System.Windows.Forms.TextBox();
            this.nativeTransferLoopLabel = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tokenSwapCooldown = new System.Windows.Forms.TextBox();
            this.tokenSwapCooldownLabel = new System.Windows.Forms.Label();
            this.swapTokenSlippage = new System.Windows.Forms.TextBox();
            this.swapTokenSlippageLabel = new System.Windows.Forms.Label();
            this.swapBackNativeToken4 = new System.Windows.Forms.CheckBox();
            this.swapBackNativeToken3 = new System.Windows.Forms.CheckBox();
            this.swapBackNativeToken2 = new System.Windows.Forms.CheckBox();
            this.swapBackNativeToken1 = new System.Windows.Forms.CheckBox();
            this.enableSwapToken4 = new System.Windows.Forms.CheckBox();
            this.swapPercentToken4Label = new System.Windows.Forms.Label();
            this.enableSwapToken3 = new System.Windows.Forms.CheckBox();
            this.swapPercentToken4 = new System.Windows.Forms.TextBox();
            this.enableSwapToken2 = new System.Windows.Forms.CheckBox();
            this.swapPercentToken3Label = new System.Windows.Forms.Label();
            this.swapPercentToken3 = new System.Windows.Forms.TextBox();
            this.enableSwapToken1 = new System.Windows.Forms.CheckBox();
            this.swapPercentToken2Label = new System.Windows.Forms.Label();
            this.swapPercentToken2 = new System.Windows.Forms.TextBox();
            this.swapPercentToken1Label = new System.Windows.Forms.Label();
            this.swapTokenLoopCount = new System.Windows.Forms.TextBox();
            this.swapPercentToken1 = new System.Windows.Forms.TextBox();
            this.swapTokenLoopCountLabel = new System.Windows.Forms.Label();
            this.swapContract1 = new System.Windows.Forms.TextBox();
            this.swapContract4 = new System.Windows.Forms.TextBox();
            this.routerContractBoxLabel = new System.Windows.Forms.Label();
            this.swapContract4Label = new System.Windows.Forms.Label();
            this.routerContractBox = new System.Windows.Forms.TextBox();
            this.swapContract3 = new System.Windows.Forms.TextBox();
            this.swapContract1Label = new System.Windows.Forms.Label();
            this.swapContract3Label = new System.Windows.Forms.Label();
            this.swapContract2Label = new System.Windows.Forms.Label();
            this.swapContract2 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tokenTransferCooldown = new System.Windows.Forms.TextBox();
            this.tokenTransferCooldownLabel = new System.Windows.Forms.Label();
            this.enableTransferToken4 = new System.Windows.Forms.CheckBox();
            this.transferPercentToken4Label = new System.Windows.Forms.Label();
            this.enableTransferToken3 = new System.Windows.Forms.CheckBox();
            this.transferPercentToken4 = new System.Windows.Forms.TextBox();
            this.enableTransferToken2 = new System.Windows.Forms.CheckBox();
            this.transferPercentToken3Label = new System.Windows.Forms.Label();
            this.transferPercentToken3 = new System.Windows.Forms.TextBox();
            this.enableTransferToken1 = new System.Windows.Forms.CheckBox();
            this.transferPercentToken2Label = new System.Windows.Forms.Label();
            this.transferPercentToken2 = new System.Windows.Forms.TextBox();
            this.transferPercentToken1Label = new System.Windows.Forms.Label();
            this.transferTokenLoopCount = new System.Windows.Forms.TextBox();
            this.transferPercentToken1 = new System.Windows.Forms.TextBox();
            this.transferTokenLoopCountLabel = new System.Windows.Forms.Label();
            this.transferContract1 = new System.Windows.Forms.TextBox();
            this.transferContract4 = new System.Windows.Forms.TextBox();
            this.transferContract4Label = new System.Windows.Forms.Label();
            this.transferContract3 = new System.Windows.Forms.TextBox();
            this.transferContract1Label = new System.Windows.Forms.Label();
            this.transferContract3Label = new System.Windows.Forms.Label();
            this.transferContract2Label = new System.Windows.Forms.Label();
            this.transferContract2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nativeBalanceTransferEngine = new System.ComponentModel.BackgroundWorker();
            this.transferNativeBalanceCheck = new System.Windows.Forms.CheckBox();
            this.swapTokensCheck = new System.Windows.Forms.CheckBox();
            this.transferTokensCheck = new System.Windows.Forms.CheckBox();
            this.tokenTransferEngine = new System.ComponentModel.BackgroundWorker();
            this.tokenSwapEngine = new System.ComponentModel.BackgroundWorker();
            this.nativePairContractLabel = new System.Windows.Forms.Label();
            this.nativePairContract = new System.Windows.Forms.TextBox();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // getAccountBalanceBackground
            // 
            this.getAccountBalanceBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.getAccountBalanceBackground_DoWork);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(898, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Test RPC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rpcURL
            // 
            this.rpcURL.Location = new System.Drawing.Point(437, 9);
            this.rpcURL.Name = "rpcURL";
            this.rpcURL.Size = new System.Drawing.Size(455, 20);
            this.rpcURL.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "RPC";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Location = new System.Drawing.Point(15, 66);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(748, 202);
            this.tabControl3.TabIndex = 28;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.accountCount);
            this.tabPage3.Controls.Add(this.accountCountLabel);
            this.tabPage3.Controls.Add(this.extraWord);
            this.tabPage3.Controls.Add(this.extraWordLabel);
            this.tabPage3.Controls.Add(this.seedPhrase);
            this.tabPage3.Controls.Add(this.seedPhraseLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(740, 176);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Seed Section";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // accountCount
            // 
            this.accountCount.Location = new System.Drawing.Point(108, 69);
            this.accountCount.Name = "accountCount";
            this.accountCount.Size = new System.Drawing.Size(612, 20);
            this.accountCount.TabIndex = 46;
            // 
            // accountCountLabel
            // 
            this.accountCountLabel.AutoSize = true;
            this.accountCountLabel.Location = new System.Drawing.Point(11, 72);
            this.accountCountLabel.Name = "accountCountLabel";
            this.accountCountLabel.Size = new System.Drawing.Size(78, 13);
            this.accountCountLabel.TabIndex = 45;
            this.accountCountLabel.Text = "Account Count";
            // 
            // extraWord
            // 
            this.extraWord.Location = new System.Drawing.Point(108, 43);
            this.extraWord.Name = "extraWord";
            this.extraWord.Size = new System.Drawing.Size(612, 20);
            this.extraWord.TabIndex = 44;
            // 
            // extraWordLabel
            // 
            this.extraWordLabel.AutoSize = true;
            this.extraWordLabel.Location = new System.Drawing.Point(11, 46);
            this.extraWordLabel.Name = "extraWordLabel";
            this.extraWordLabel.Size = new System.Drawing.Size(66, 13);
            this.extraWordLabel.TabIndex = 43;
            this.extraWordLabel.Text = "Extra Word?";
            // 
            // seedPhrase
            // 
            this.seedPhrase.Location = new System.Drawing.Point(108, 17);
            this.seedPhrase.Name = "seedPhrase";
            this.seedPhrase.Size = new System.Drawing.Size(612, 20);
            this.seedPhrase.TabIndex = 42;
            // 
            // seedPhraseLabel
            // 
            this.seedPhraseLabel.AutoSize = true;
            this.seedPhraseLabel.Location = new System.Drawing.Point(11, 20);
            this.seedPhraseLabel.Name = "seedPhraseLabel";
            this.seedPhraseLabel.Size = new System.Drawing.Size(32, 13);
            this.seedPhraseLabel.TabIndex = 41;
            this.seedPhraseLabel.Text = "Seed";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.privateKeyCheck6);
            this.tabPage4.Controls.Add(this.privateKeyCheck5);
            this.tabPage4.Controls.Add(this.privateKeyCheck4);
            this.tabPage4.Controls.Add(this.privateKeyCheck3);
            this.tabPage4.Controls.Add(this.privateKeyCheck2);
            this.tabPage4.Controls.Add(this.privateKeyCheck1);
            this.tabPage4.Controls.Add(this.balanceBox6);
            this.tabPage4.Controls.Add(this.balanceBox5);
            this.tabPage4.Controls.Add(this.balanceBox4);
            this.tabPage4.Controls.Add(this.balanceBox3);
            this.tabPage4.Controls.Add(this.balanceBox2);
            this.tabPage4.Controls.Add(this.balanceBox1);
            this.tabPage4.Controls.Add(this.privateKeyBox5);
            this.tabPage4.Controls.Add(this.privateKeyBox6);
            this.tabPage4.Controls.Add(this.privateKeyBox3);
            this.tabPage4.Controls.Add(this.privateKeyBox4);
            this.tabPage4.Controls.Add(this.privateKeyBox1);
            this.tabPage4.Controls.Add(this.privateKeyBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(740, 176);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Private Key Section";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // privateKeyCheck6
            // 
            this.privateKeyCheck6.AutoSize = true;
            this.privateKeyCheck6.Enabled = false;
            this.privateKeyCheck6.Location = new System.Drawing.Point(7, 142);
            this.privateKeyCheck6.Name = "privateKeyCheck6";
            this.privateKeyCheck6.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck6.TabIndex = 45;
            this.privateKeyCheck6.Text = "EnablePrivateKey6";
            this.privateKeyCheck6.UseVisualStyleBackColor = true;
            this.privateKeyCheck6.CheckedChanged += new System.EventHandler(this.enablePrivateKey6_CheckedChanged);
            // 
            // privateKeyCheck5
            // 
            this.privateKeyCheck5.AutoSize = true;
            this.privateKeyCheck5.Enabled = false;
            this.privateKeyCheck5.Location = new System.Drawing.Point(7, 117);
            this.privateKeyCheck5.Name = "privateKeyCheck5";
            this.privateKeyCheck5.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck5.TabIndex = 44;
            this.privateKeyCheck5.Text = "EnablePrivateKey5";
            this.privateKeyCheck5.UseVisualStyleBackColor = true;
            this.privateKeyCheck5.CheckedChanged += new System.EventHandler(this.enablePrivateKey5_CheckedChanged);
            // 
            // privateKeyCheck4
            // 
            this.privateKeyCheck4.AutoSize = true;
            this.privateKeyCheck4.Enabled = false;
            this.privateKeyCheck4.Location = new System.Drawing.Point(7, 90);
            this.privateKeyCheck4.Name = "privateKeyCheck4";
            this.privateKeyCheck4.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck4.TabIndex = 43;
            this.privateKeyCheck4.Text = "EnablePrivateKey4";
            this.privateKeyCheck4.UseVisualStyleBackColor = true;
            this.privateKeyCheck4.CheckedChanged += new System.EventHandler(this.enablePrivateKey4_CheckedChanged);
            // 
            // privateKeyCheck3
            // 
            this.privateKeyCheck3.AutoSize = true;
            this.privateKeyCheck3.Enabled = false;
            this.privateKeyCheck3.Location = new System.Drawing.Point(7, 65);
            this.privateKeyCheck3.Name = "privateKeyCheck3";
            this.privateKeyCheck3.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck3.TabIndex = 42;
            this.privateKeyCheck3.Text = "EnablePrivateKey3";
            this.privateKeyCheck3.UseVisualStyleBackColor = true;
            this.privateKeyCheck3.CheckedChanged += new System.EventHandler(this.enablePrivateKey3_CheckedChanged);
            // 
            // privateKeyCheck2
            // 
            this.privateKeyCheck2.AutoSize = true;
            this.privateKeyCheck2.Enabled = false;
            this.privateKeyCheck2.Location = new System.Drawing.Point(7, 39);
            this.privateKeyCheck2.Name = "privateKeyCheck2";
            this.privateKeyCheck2.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck2.TabIndex = 41;
            this.privateKeyCheck2.Text = "EnablePrivateKey2";
            this.privateKeyCheck2.UseVisualStyleBackColor = true;
            this.privateKeyCheck2.CheckedChanged += new System.EventHandler(this.enablePrivateKey2_CheckedChanged);
            // 
            // privateKeyCheck1
            // 
            this.privateKeyCheck1.AutoSize = true;
            this.privateKeyCheck1.Location = new System.Drawing.Point(7, 12);
            this.privateKeyCheck1.Name = "privateKeyCheck1";
            this.privateKeyCheck1.Size = new System.Drawing.Size(116, 17);
            this.privateKeyCheck1.TabIndex = 40;
            this.privateKeyCheck1.Text = "EnablePrivateKey1";
            this.privateKeyCheck1.UseVisualStyleBackColor = true;
            this.privateKeyCheck1.CheckedChanged += new System.EventHandler(this.enablePrivateKey1_CheckedChanged);
            // 
            // balanceBox6
            // 
            this.balanceBox6.Enabled = false;
            this.balanceBox6.Location = new System.Drawing.Point(590, 139);
            this.balanceBox6.Name = "balanceBox6";
            this.balanceBox6.Size = new System.Drawing.Size(134, 20);
            this.balanceBox6.TabIndex = 39;
            this.balanceBox6.Text = "Balance: ";
            // 
            // balanceBox5
            // 
            this.balanceBox5.Enabled = false;
            this.balanceBox5.Location = new System.Drawing.Point(590, 113);
            this.balanceBox5.Name = "balanceBox5";
            this.balanceBox5.Size = new System.Drawing.Size(134, 20);
            this.balanceBox5.TabIndex = 38;
            this.balanceBox5.Text = "Balance: ";
            // 
            // balanceBox4
            // 
            this.balanceBox4.Enabled = false;
            this.balanceBox4.Location = new System.Drawing.Point(590, 87);
            this.balanceBox4.Name = "balanceBox4";
            this.balanceBox4.Size = new System.Drawing.Size(134, 20);
            this.balanceBox4.TabIndex = 37;
            this.balanceBox4.Text = "Balance: ";
            // 
            // balanceBox3
            // 
            this.balanceBox3.Enabled = false;
            this.balanceBox3.Location = new System.Drawing.Point(590, 61);
            this.balanceBox3.Name = "balanceBox3";
            this.balanceBox3.Size = new System.Drawing.Size(134, 20);
            this.balanceBox3.TabIndex = 36;
            this.balanceBox3.Text = "Balance: ";
            // 
            // balanceBox2
            // 
            this.balanceBox2.Enabled = false;
            this.balanceBox2.Location = new System.Drawing.Point(590, 35);
            this.balanceBox2.Name = "balanceBox2";
            this.balanceBox2.Size = new System.Drawing.Size(134, 20);
            this.balanceBox2.TabIndex = 35;
            this.balanceBox2.Text = "Balance: ";
            // 
            // balanceBox1
            // 
            this.balanceBox1.Enabled = false;
            this.balanceBox1.Location = new System.Drawing.Point(590, 9);
            this.balanceBox1.Name = "balanceBox1";
            this.balanceBox1.Size = new System.Drawing.Size(134, 20);
            this.balanceBox1.TabIndex = 34;
            this.balanceBox1.Text = "Balance: ";
            // 
            // privateKeyBox5
            // 
            this.privateKeyBox5.Enabled = false;
            this.privateKeyBox5.Location = new System.Drawing.Point(129, 113);
            this.privateKeyBox5.Name = "privateKeyBox5";
            this.privateKeyBox5.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox5.TabIndex = 31;
            // 
            // privateKeyBox6
            // 
            this.privateKeyBox6.Enabled = false;
            this.privateKeyBox6.Location = new System.Drawing.Point(129, 139);
            this.privateKeyBox6.Name = "privateKeyBox6";
            this.privateKeyBox6.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox6.TabIndex = 33;
            // 
            // privateKeyBox3
            // 
            this.privateKeyBox3.Enabled = false;
            this.privateKeyBox3.Location = new System.Drawing.Point(129, 61);
            this.privateKeyBox3.Name = "privateKeyBox3";
            this.privateKeyBox3.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox3.TabIndex = 27;
            // 
            // privateKeyBox4
            // 
            this.privateKeyBox4.Enabled = false;
            this.privateKeyBox4.Location = new System.Drawing.Point(129, 87);
            this.privateKeyBox4.Name = "privateKeyBox4";
            this.privateKeyBox4.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox4.TabIndex = 29;
            // 
            // privateKeyBox1
            // 
            this.privateKeyBox1.Enabled = false;
            this.privateKeyBox1.Location = new System.Drawing.Point(129, 9);
            this.privateKeyBox1.Name = "privateKeyBox1";
            this.privateKeyBox1.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox1.TabIndex = 8;
            // 
            // privateKeyBox2
            // 
            this.privateKeyBox2.Enabled = false;
            this.privateKeyBox2.Location = new System.Drawing.Point(129, 35);
            this.privateKeyBox2.Name = "privateKeyBox2";
            this.privateKeyBox2.Size = new System.Drawing.Size(455, 20);
            this.privateKeyBox2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(19, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(740, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Load Account Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // privateKeyMode
            // 
            this.privateKeyMode.AutoSize = true;
            this.privateKeyMode.Location = new System.Drawing.Point(125, 39);
            this.privateKeyMode.Name = "privateKeyMode";
            this.privateKeyMode.Size = new System.Drawing.Size(248, 17);
            this.privateKeyMode.TabIndex = 27;
            this.privateKeyMode.Text = "Work With Private Keys (Limited To 6 Account)";
            this.privateKeyMode.UseVisualStyleBackColor = true;
            this.privateKeyMode.CheckedChanged += new System.EventHandler(this.privateKeyMode_CheckedChanged);
            // 
            // seedMode
            // 
            this.seedMode.AutoSize = true;
            this.seedMode.Checked = true;
            this.seedMode.Location = new System.Drawing.Point(15, 39);
            this.seedMode.Name = "seedMode";
            this.seedMode.Size = new System.Drawing.Size(104, 17);
            this.seedMode.TabIndex = 26;
            this.seedMode.TabStop = true;
            this.seedMode.Text = "Work With Seed";
            this.seedMode.UseVisualStyleBackColor = true;
            this.seedMode.CheckedChanged += new System.EventHandler(this.seedMode_CheckedChanged);
            // 
            // testRPCBackground
            // 
            this.testRPCBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.testRPCBackground_DoWork);
            // 
            // loadAccountsFromPrivateKey
            // 
            this.loadAccountsFromPrivateKey.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadAccountsFromPrivateKey_DoWork);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(297, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "Import";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Config Name";
            // 
            // settingsName
            // 
            this.settingsName.Location = new System.Drawing.Point(86, 9);
            this.settingsName.Name = "settingsName";
            this.settingsName.Size = new System.Drawing.Size(100, 20);
            this.settingsName.TabIndex = 36;
            this.settingsName.Text = "config";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Save / Export";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(769, 66);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1004, 202);
            this.tabControl2.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nativeTransferCooldown);
            this.tabPage1.Controls.Add(this.nativeTransferCooldownLabel);
            this.tabPage1.Controls.Add(this.nativeTransferPercent);
            this.tabPage1.Controls.Add(this.nativeTransferPercentLabel);
            this.tabPage1.Controls.Add(this.nativeTransferLoop);
            this.tabPage1.Controls.Add(this.nativeTransferLoopLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(996, 176);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Transfer Native Balance Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nativeTransferCooldown
            // 
            this.nativeTransferCooldown.Enabled = false;
            this.nativeTransferCooldown.Location = new System.Drawing.Point(127, 65);
            this.nativeTransferCooldown.Name = "nativeTransferCooldown";
            this.nativeTransferCooldown.Size = new System.Drawing.Size(52, 20);
            this.nativeTransferCooldown.TabIndex = 49;
            this.nativeTransferCooldown.Text = "20";
            // 
            // nativeTransferCooldownLabel
            // 
            this.nativeTransferCooldownLabel.AutoSize = true;
            this.nativeTransferCooldownLabel.Enabled = false;
            this.nativeTransferCooldownLabel.Location = new System.Drawing.Point(16, 69);
            this.nativeTransferCooldownLabel.Name = "nativeTransferCooldownLabel";
            this.nativeTransferCooldownLabel.Size = new System.Drawing.Size(105, 13);
            this.nativeTransferCooldownLabel.TabIndex = 48;
            this.nativeTransferCooldownLabel.Text = "Cooldown (Seconds)";
            // 
            // nativeTransferPercent
            // 
            this.nativeTransferPercent.Enabled = false;
            this.nativeTransferPercent.Location = new System.Drawing.Point(127, 13);
            this.nativeTransferPercent.Name = "nativeTransferPercent";
            this.nativeTransferPercent.Size = new System.Drawing.Size(52, 20);
            this.nativeTransferPercent.TabIndex = 47;
            // 
            // nativeTransferPercentLabel
            // 
            this.nativeTransferPercentLabel.AutoSize = true;
            this.nativeTransferPercentLabel.Enabled = false;
            this.nativeTransferPercentLabel.Location = new System.Drawing.Point(16, 20);
            this.nativeTransferPercentLabel.Name = "nativeTransferPercentLabel";
            this.nativeTransferPercentLabel.Size = new System.Drawing.Size(86, 13);
            this.nativeTransferPercentLabel.TabIndex = 46;
            this.nativeTransferPercentLabel.Text = "Transfer Percent";
            // 
            // nativeTransferLoop
            // 
            this.nativeTransferLoop.Enabled = false;
            this.nativeTransferLoop.Location = new System.Drawing.Point(127, 40);
            this.nativeTransferLoop.Name = "nativeTransferLoop";
            this.nativeTransferLoop.Size = new System.Drawing.Size(52, 20);
            this.nativeTransferLoop.TabIndex = 45;
            // 
            // nativeTransferLoopLabel
            // 
            this.nativeTransferLoopLabel.AutoSize = true;
            this.nativeTransferLoopLabel.Enabled = false;
            this.nativeTransferLoopLabel.Location = new System.Drawing.Point(16, 46);
            this.nativeTransferLoopLabel.Name = "nativeTransferLoopLabel";
            this.nativeTransferLoopLabel.Size = new System.Drawing.Size(62, 13);
            this.nativeTransferLoopLabel.TabIndex = 44;
            this.nativeTransferLoopLabel.Text = "Loop Count";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.nativePairContractLabel);
            this.tabPage7.Controls.Add(this.nativePairContract);
            this.tabPage7.Controls.Add(this.tokenSwapCooldown);
            this.tabPage7.Controls.Add(this.tokenSwapCooldownLabel);
            this.tabPage7.Controls.Add(this.swapTokenSlippage);
            this.tabPage7.Controls.Add(this.swapTokenSlippageLabel);
            this.tabPage7.Controls.Add(this.swapBackNativeToken4);
            this.tabPage7.Controls.Add(this.swapBackNativeToken3);
            this.tabPage7.Controls.Add(this.swapBackNativeToken2);
            this.tabPage7.Controls.Add(this.swapBackNativeToken1);
            this.tabPage7.Controls.Add(this.enableSwapToken4);
            this.tabPage7.Controls.Add(this.swapPercentToken4Label);
            this.tabPage7.Controls.Add(this.enableSwapToken3);
            this.tabPage7.Controls.Add(this.swapPercentToken4);
            this.tabPage7.Controls.Add(this.enableSwapToken2);
            this.tabPage7.Controls.Add(this.swapPercentToken3Label);
            this.tabPage7.Controls.Add(this.swapPercentToken3);
            this.tabPage7.Controls.Add(this.enableSwapToken1);
            this.tabPage7.Controls.Add(this.swapPercentToken2Label);
            this.tabPage7.Controls.Add(this.swapPercentToken2);
            this.tabPage7.Controls.Add(this.swapPercentToken1Label);
            this.tabPage7.Controls.Add(this.swapTokenLoopCount);
            this.tabPage7.Controls.Add(this.swapPercentToken1);
            this.tabPage7.Controls.Add(this.swapTokenLoopCountLabel);
            this.tabPage7.Controls.Add(this.swapContract1);
            this.tabPage7.Controls.Add(this.swapContract4);
            this.tabPage7.Controls.Add(this.routerContractBoxLabel);
            this.tabPage7.Controls.Add(this.swapContract4Label);
            this.tabPage7.Controls.Add(this.routerContractBox);
            this.tabPage7.Controls.Add(this.swapContract3);
            this.tabPage7.Controls.Add(this.swapContract1Label);
            this.tabPage7.Controls.Add(this.swapContract3Label);
            this.tabPage7.Controls.Add(this.swapContract2Label);
            this.tabPage7.Controls.Add(this.swapContract2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(996, 176);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Token Swap Settings";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tokenSwapCooldown
            // 
            this.tokenSwapCooldown.Enabled = false;
            this.tokenSwapCooldown.Location = new System.Drawing.Point(419, 143);
            this.tokenSwapCooldown.Name = "tokenSwapCooldown";
            this.tokenSwapCooldown.Size = new System.Drawing.Size(52, 20);
            this.tokenSwapCooldown.TabIndex = 51;
            this.tokenSwapCooldown.Text = "20";
            // 
            // tokenSwapCooldownLabel
            // 
            this.tokenSwapCooldownLabel.AutoSize = true;
            this.tokenSwapCooldownLabel.Enabled = false;
            this.tokenSwapCooldownLabel.Location = new System.Drawing.Point(308, 147);
            this.tokenSwapCooldownLabel.Name = "tokenSwapCooldownLabel";
            this.tokenSwapCooldownLabel.Size = new System.Drawing.Size(105, 13);
            this.tokenSwapCooldownLabel.TabIndex = 50;
            this.tokenSwapCooldownLabel.Text = "Cooldown (Seconds)";
            // 
            // swapTokenSlippage
            // 
            this.swapTokenSlippage.Enabled = false;
            this.swapTokenSlippage.Location = new System.Drawing.Point(98, 144);
            this.swapTokenSlippage.Name = "swapTokenSlippage";
            this.swapTokenSlippage.Size = new System.Drawing.Size(52, 20);
            this.swapTokenSlippage.TabIndex = 43;
            // 
            // swapTokenSlippageLabel
            // 
            this.swapTokenSlippageLabel.AutoSize = true;
            this.swapTokenSlippageLabel.Enabled = false;
            this.swapTokenSlippageLabel.Location = new System.Drawing.Point(6, 147);
            this.swapTokenSlippageLabel.Name = "swapTokenSlippageLabel";
            this.swapTokenSlippageLabel.Size = new System.Drawing.Size(88, 13);
            this.swapTokenSlippageLabel.TabIndex = 42;
            this.swapTokenSlippageLabel.Text = "Slippage Percent";
            // 
            // swapBackNativeToken4
            // 
            this.swapBackNativeToken4.AutoSize = true;
            this.swapBackNativeToken4.Enabled = false;
            this.swapBackNativeToken4.Location = new System.Drawing.Point(769, 117);
            this.swapBackNativeToken4.Name = "swapBackNativeToken4";
            this.swapBackNativeToken4.Size = new System.Drawing.Size(220, 17);
            this.swapBackNativeToken4.TabIndex = 41;
            this.swapBackNativeToken4.Text = "Swap Back To Native Token After Swap";
            this.swapBackNativeToken4.UseVisualStyleBackColor = true;
            // 
            // swapBackNativeToken3
            // 
            this.swapBackNativeToken3.AutoSize = true;
            this.swapBackNativeToken3.Enabled = false;
            this.swapBackNativeToken3.Location = new System.Drawing.Point(769, 91);
            this.swapBackNativeToken3.Name = "swapBackNativeToken3";
            this.swapBackNativeToken3.Size = new System.Drawing.Size(220, 17);
            this.swapBackNativeToken3.TabIndex = 40;
            this.swapBackNativeToken3.Text = "Swap Back To Native Token After Swap";
            this.swapBackNativeToken3.UseVisualStyleBackColor = true;
            // 
            // swapBackNativeToken2
            // 
            this.swapBackNativeToken2.AutoSize = true;
            this.swapBackNativeToken2.Enabled = false;
            this.swapBackNativeToken2.Location = new System.Drawing.Point(769, 65);
            this.swapBackNativeToken2.Name = "swapBackNativeToken2";
            this.swapBackNativeToken2.Size = new System.Drawing.Size(220, 17);
            this.swapBackNativeToken2.TabIndex = 39;
            this.swapBackNativeToken2.Text = "Swap Back To Native Token After Swap";
            this.swapBackNativeToken2.UseVisualStyleBackColor = true;
            // 
            // swapBackNativeToken1
            // 
            this.swapBackNativeToken1.AutoSize = true;
            this.swapBackNativeToken1.Enabled = false;
            this.swapBackNativeToken1.Location = new System.Drawing.Point(769, 38);
            this.swapBackNativeToken1.Name = "swapBackNativeToken1";
            this.swapBackNativeToken1.Size = new System.Drawing.Size(220, 17);
            this.swapBackNativeToken1.TabIndex = 38;
            this.swapBackNativeToken1.Text = "Swap Back To Native Token After Swap";
            this.swapBackNativeToken1.UseVisualStyleBackColor = true;
            // 
            // enableSwapToken4
            // 
            this.enableSwapToken4.AutoSize = true;
            this.enableSwapToken4.Enabled = false;
            this.enableSwapToken4.Location = new System.Drawing.Point(6, 117);
            this.enableSwapToken4.Name = "enableSwapToken4";
            this.enableSwapToken4.Size = new System.Drawing.Size(89, 17);
            this.enableSwapToken4.TabIndex = 37;
            this.enableSwapToken4.Text = "Enable Swap";
            this.enableSwapToken4.UseVisualStyleBackColor = true;
            this.enableSwapToken4.CheckedChanged += new System.EventHandler(this.enableSwapToken4_CheckedChanged);
            // 
            // swapPercentToken4Label
            // 
            this.swapPercentToken4Label.AutoSize = true;
            this.swapPercentToken4Label.Enabled = false;
            this.swapPercentToken4Label.Location = new System.Drawing.Point(646, 117);
            this.swapPercentToken4Label.Name = "swapPercentToken4Label";
            this.swapPercentToken4Label.Size = new System.Drawing.Size(44, 13);
            this.swapPercentToken4Label.TabIndex = 32;
            this.swapPercentToken4Label.Text = "Percent";
            // 
            // enableSwapToken3
            // 
            this.enableSwapToken3.AutoSize = true;
            this.enableSwapToken3.Enabled = false;
            this.enableSwapToken3.Location = new System.Drawing.Point(6, 91);
            this.enableSwapToken3.Name = "enableSwapToken3";
            this.enableSwapToken3.Size = new System.Drawing.Size(89, 17);
            this.enableSwapToken3.TabIndex = 36;
            this.enableSwapToken3.Text = "Enable Swap";
            this.enableSwapToken3.UseVisualStyleBackColor = true;
            this.enableSwapToken3.CheckedChanged += new System.EventHandler(this.enableSwapToken3_CheckedChanged);
            // 
            // swapPercentToken4
            // 
            this.swapPercentToken4.Enabled = false;
            this.swapPercentToken4.Location = new System.Drawing.Point(696, 114);
            this.swapPercentToken4.Name = "swapPercentToken4";
            this.swapPercentToken4.Size = new System.Drawing.Size(67, 20);
            this.swapPercentToken4.TabIndex = 33;
            // 
            // enableSwapToken2
            // 
            this.enableSwapToken2.AutoSize = true;
            this.enableSwapToken2.Enabled = false;
            this.enableSwapToken2.Location = new System.Drawing.Point(6, 65);
            this.enableSwapToken2.Name = "enableSwapToken2";
            this.enableSwapToken2.Size = new System.Drawing.Size(89, 17);
            this.enableSwapToken2.TabIndex = 35;
            this.enableSwapToken2.Text = "Enable Swap";
            this.enableSwapToken2.UseVisualStyleBackColor = true;
            this.enableSwapToken2.CheckedChanged += new System.EventHandler(this.enableSwapToken2_CheckedChanged);
            // 
            // swapPercentToken3Label
            // 
            this.swapPercentToken3Label.AutoSize = true;
            this.swapPercentToken3Label.Enabled = false;
            this.swapPercentToken3Label.Location = new System.Drawing.Point(646, 91);
            this.swapPercentToken3Label.Name = "swapPercentToken3Label";
            this.swapPercentToken3Label.Size = new System.Drawing.Size(44, 13);
            this.swapPercentToken3Label.TabIndex = 30;
            this.swapPercentToken3Label.Text = "Percent";
            // 
            // swapPercentToken3
            // 
            this.swapPercentToken3.Enabled = false;
            this.swapPercentToken3.Location = new System.Drawing.Point(696, 88);
            this.swapPercentToken3.Name = "swapPercentToken3";
            this.swapPercentToken3.Size = new System.Drawing.Size(67, 20);
            this.swapPercentToken3.TabIndex = 31;
            // 
            // enableSwapToken1
            // 
            this.enableSwapToken1.AutoSize = true;
            this.enableSwapToken1.Enabled = false;
            this.enableSwapToken1.Location = new System.Drawing.Point(6, 38);
            this.enableSwapToken1.Name = "enableSwapToken1";
            this.enableSwapToken1.Size = new System.Drawing.Size(89, 17);
            this.enableSwapToken1.TabIndex = 34;
            this.enableSwapToken1.Text = "Enable Swap";
            this.enableSwapToken1.UseVisualStyleBackColor = true;
            this.enableSwapToken1.CheckedChanged += new System.EventHandler(this.enableSwapToken1_CheckedChanged);
            // 
            // swapPercentToken2Label
            // 
            this.swapPercentToken2Label.AutoSize = true;
            this.swapPercentToken2Label.Enabled = false;
            this.swapPercentToken2Label.Location = new System.Drawing.Point(646, 65);
            this.swapPercentToken2Label.Name = "swapPercentToken2Label";
            this.swapPercentToken2Label.Size = new System.Drawing.Size(44, 13);
            this.swapPercentToken2Label.TabIndex = 28;
            this.swapPercentToken2Label.Text = "Percent";
            // 
            // swapPercentToken2
            // 
            this.swapPercentToken2.Enabled = false;
            this.swapPercentToken2.Location = new System.Drawing.Point(696, 62);
            this.swapPercentToken2.Name = "swapPercentToken2";
            this.swapPercentToken2.Size = new System.Drawing.Size(67, 20);
            this.swapPercentToken2.TabIndex = 29;
            // 
            // swapPercentToken1Label
            // 
            this.swapPercentToken1Label.AutoSize = true;
            this.swapPercentToken1Label.Enabled = false;
            this.swapPercentToken1Label.Location = new System.Drawing.Point(646, 39);
            this.swapPercentToken1Label.Name = "swapPercentToken1Label";
            this.swapPercentToken1Label.Size = new System.Drawing.Size(44, 13);
            this.swapPercentToken1Label.TabIndex = 26;
            this.swapPercentToken1Label.Text = "Percent";
            // 
            // swapTokenLoopCount
            // 
            this.swapTokenLoopCount.Enabled = false;
            this.swapTokenLoopCount.Location = new System.Drawing.Point(239, 144);
            this.swapTokenLoopCount.Name = "swapTokenLoopCount";
            this.swapTokenLoopCount.Size = new System.Drawing.Size(52, 20);
            this.swapTokenLoopCount.TabIndex = 25;
            // 
            // swapPercentToken1
            // 
            this.swapPercentToken1.Enabled = false;
            this.swapPercentToken1.Location = new System.Drawing.Point(696, 36);
            this.swapPercentToken1.Name = "swapPercentToken1";
            this.swapPercentToken1.Size = new System.Drawing.Size(67, 20);
            this.swapPercentToken1.TabIndex = 27;
            // 
            // swapTokenLoopCountLabel
            // 
            this.swapTokenLoopCountLabel.AutoSize = true;
            this.swapTokenLoopCountLabel.Enabled = false;
            this.swapTokenLoopCountLabel.Location = new System.Drawing.Point(171, 147);
            this.swapTokenLoopCountLabel.Name = "swapTokenLoopCountLabel";
            this.swapTokenLoopCountLabel.Size = new System.Drawing.Size(62, 13);
            this.swapTokenLoopCountLabel.TabIndex = 24;
            this.swapTokenLoopCountLabel.Text = "Loop Count";
            // 
            // swapContract1
            // 
            this.swapContract1.Enabled = false;
            this.swapContract1.Location = new System.Drawing.Point(185, 36);
            this.swapContract1.Name = "swapContract1";
            this.swapContract1.Size = new System.Drawing.Size(455, 20);
            this.swapContract1.TabIndex = 14;
            // 
            // swapContract4
            // 
            this.swapContract4.Enabled = false;
            this.swapContract4.Location = new System.Drawing.Point(185, 114);
            this.swapContract4.Name = "swapContract4";
            this.swapContract4.Size = new System.Drawing.Size(455, 20);
            this.swapContract4.TabIndex = 20;
            // 
            // routerContractBoxLabel
            // 
            this.routerContractBoxLabel.AutoSize = true;
            this.routerContractBoxLabel.Enabled = false;
            this.routerContractBoxLabel.Location = new System.Drawing.Point(3, 14);
            this.routerContractBoxLabel.Name = "routerContractBoxLabel";
            this.routerContractBoxLabel.Size = new System.Drawing.Size(82, 13);
            this.routerContractBoxLabel.TabIndex = 11;
            this.routerContractBoxLabel.Text = "Router Contract";
            // 
            // swapContract4Label
            // 
            this.swapContract4Label.AutoSize = true;
            this.swapContract4Label.Enabled = false;
            this.swapContract4Label.Location = new System.Drawing.Point(95, 117);
            this.swapContract4Label.Name = "swapContract4Label";
            this.swapContract4Label.Size = new System.Drawing.Size(87, 13);
            this.swapContract4Label.TabIndex = 19;
            this.swapContract4Label.Text = "Token4 Contract";
            // 
            // routerContractBox
            // 
            this.routerContractBox.Enabled = false;
            this.routerContractBox.Location = new System.Drawing.Point(93, 11);
            this.routerContractBox.Name = "routerContractBox";
            this.routerContractBox.Size = new System.Drawing.Size(378, 20);
            this.routerContractBox.TabIndex = 12;
            // 
            // swapContract3
            // 
            this.swapContract3.Enabled = false;
            this.swapContract3.Location = new System.Drawing.Point(185, 88);
            this.swapContract3.Name = "swapContract3";
            this.swapContract3.Size = new System.Drawing.Size(455, 20);
            this.swapContract3.TabIndex = 18;
            // 
            // swapContract1Label
            // 
            this.swapContract1Label.AutoSize = true;
            this.swapContract1Label.Enabled = false;
            this.swapContract1Label.Location = new System.Drawing.Point(95, 39);
            this.swapContract1Label.Name = "swapContract1Label";
            this.swapContract1Label.Size = new System.Drawing.Size(87, 13);
            this.swapContract1Label.TabIndex = 13;
            this.swapContract1Label.Text = "Token1 Contract";
            // 
            // swapContract3Label
            // 
            this.swapContract3Label.AutoSize = true;
            this.swapContract3Label.Enabled = false;
            this.swapContract3Label.Location = new System.Drawing.Point(95, 91);
            this.swapContract3Label.Name = "swapContract3Label";
            this.swapContract3Label.Size = new System.Drawing.Size(87, 13);
            this.swapContract3Label.TabIndex = 17;
            this.swapContract3Label.Text = "Token3 Contract";
            // 
            // swapContract2Label
            // 
            this.swapContract2Label.AutoSize = true;
            this.swapContract2Label.Enabled = false;
            this.swapContract2Label.Location = new System.Drawing.Point(95, 65);
            this.swapContract2Label.Name = "swapContract2Label";
            this.swapContract2Label.Size = new System.Drawing.Size(87, 13);
            this.swapContract2Label.TabIndex = 15;
            this.swapContract2Label.Text = "Token2 Contract";
            // 
            // swapContract2
            // 
            this.swapContract2.Enabled = false;
            this.swapContract2.Location = new System.Drawing.Point(185, 62);
            this.swapContract2.Name = "swapContract2";
            this.swapContract2.Size = new System.Drawing.Size(455, 20);
            this.swapContract2.TabIndex = 16;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tokenTransferCooldown);
            this.tabPage6.Controls.Add(this.tokenTransferCooldownLabel);
            this.tabPage6.Controls.Add(this.enableTransferToken4);
            this.tabPage6.Controls.Add(this.transferPercentToken4Label);
            this.tabPage6.Controls.Add(this.enableTransferToken3);
            this.tabPage6.Controls.Add(this.transferPercentToken4);
            this.tabPage6.Controls.Add(this.enableTransferToken2);
            this.tabPage6.Controls.Add(this.transferPercentToken3Label);
            this.tabPage6.Controls.Add(this.transferPercentToken3);
            this.tabPage6.Controls.Add(this.enableTransferToken1);
            this.tabPage6.Controls.Add(this.transferPercentToken2Label);
            this.tabPage6.Controls.Add(this.transferPercentToken2);
            this.tabPage6.Controls.Add(this.transferPercentToken1Label);
            this.tabPage6.Controls.Add(this.transferTokenLoopCount);
            this.tabPage6.Controls.Add(this.transferPercentToken1);
            this.tabPage6.Controls.Add(this.transferTokenLoopCountLabel);
            this.tabPage6.Controls.Add(this.transferContract1);
            this.tabPage6.Controls.Add(this.transferContract4);
            this.tabPage6.Controls.Add(this.transferContract4Label);
            this.tabPage6.Controls.Add(this.transferContract3);
            this.tabPage6.Controls.Add(this.transferContract1Label);
            this.tabPage6.Controls.Add(this.transferContract3Label);
            this.tabPage6.Controls.Add(this.transferContract2Label);
            this.tabPage6.Controls.Add(this.transferContract2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(996, 176);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Token Transfer Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tokenTransferCooldown
            // 
            this.tokenTransferCooldown.Enabled = false;
            this.tokenTransferCooldown.Location = new System.Drawing.Point(417, 144);
            this.tokenTransferCooldown.Name = "tokenTransferCooldown";
            this.tokenTransferCooldown.Size = new System.Drawing.Size(52, 20);
            this.tokenTransferCooldown.TabIndex = 73;
            this.tokenTransferCooldown.Text = "20";
            // 
            // tokenTransferCooldownLabel
            // 
            this.tokenTransferCooldownLabel.AutoSize = true;
            this.tokenTransferCooldownLabel.Enabled = false;
            this.tokenTransferCooldownLabel.Location = new System.Drawing.Point(306, 148);
            this.tokenTransferCooldownLabel.Name = "tokenTransferCooldownLabel";
            this.tokenTransferCooldownLabel.Size = new System.Drawing.Size(105, 13);
            this.tokenTransferCooldownLabel.TabIndex = 72;
            this.tokenTransferCooldownLabel.Text = "Cooldown (Seconds)";
            // 
            // enableTransferToken4
            // 
            this.enableTransferToken4.AutoSize = true;
            this.enableTransferToken4.Enabled = false;
            this.enableTransferToken4.Location = new System.Drawing.Point(6, 117);
            this.enableTransferToken4.Name = "enableTransferToken4";
            this.enableTransferToken4.Size = new System.Drawing.Size(59, 17);
            this.enableTransferToken4.TabIndex = 67;
            this.enableTransferToken4.Text = "Enable";
            this.enableTransferToken4.UseVisualStyleBackColor = true;
            this.enableTransferToken4.CheckedChanged += new System.EventHandler(this.enableTransferToken4_CheckedChanged);
            // 
            // transferPercentToken4Label
            // 
            this.transferPercentToken4Label.AutoSize = true;
            this.transferPercentToken4Label.Enabled = false;
            this.transferPercentToken4Label.Location = new System.Drawing.Point(646, 117);
            this.transferPercentToken4Label.Name = "transferPercentToken4Label";
            this.transferPercentToken4Label.Size = new System.Drawing.Size(44, 13);
            this.transferPercentToken4Label.TabIndex = 62;
            this.transferPercentToken4Label.Text = "Percent";
            // 
            // enableTransferToken3
            // 
            this.enableTransferToken3.AutoSize = true;
            this.enableTransferToken3.Enabled = false;
            this.enableTransferToken3.Location = new System.Drawing.Point(6, 91);
            this.enableTransferToken3.Name = "enableTransferToken3";
            this.enableTransferToken3.Size = new System.Drawing.Size(59, 17);
            this.enableTransferToken3.TabIndex = 66;
            this.enableTransferToken3.Text = "Enable";
            this.enableTransferToken3.UseVisualStyleBackColor = true;
            this.enableTransferToken3.CheckedChanged += new System.EventHandler(this.enableTransferToken3_CheckedChanged);
            // 
            // transferPercentToken4
            // 
            this.transferPercentToken4.Enabled = false;
            this.transferPercentToken4.Location = new System.Drawing.Point(696, 114);
            this.transferPercentToken4.Name = "transferPercentToken4";
            this.transferPercentToken4.Size = new System.Drawing.Size(67, 20);
            this.transferPercentToken4.TabIndex = 63;
            // 
            // enableTransferToken2
            // 
            this.enableTransferToken2.AutoSize = true;
            this.enableTransferToken2.Enabled = false;
            this.enableTransferToken2.Location = new System.Drawing.Point(6, 65);
            this.enableTransferToken2.Name = "enableTransferToken2";
            this.enableTransferToken2.Size = new System.Drawing.Size(59, 17);
            this.enableTransferToken2.TabIndex = 65;
            this.enableTransferToken2.Text = "Enable";
            this.enableTransferToken2.UseVisualStyleBackColor = true;
            this.enableTransferToken2.CheckedChanged += new System.EventHandler(this.enableTransferToken2_CheckedChanged);
            // 
            // transferPercentToken3Label
            // 
            this.transferPercentToken3Label.AutoSize = true;
            this.transferPercentToken3Label.Enabled = false;
            this.transferPercentToken3Label.Location = new System.Drawing.Point(646, 91);
            this.transferPercentToken3Label.Name = "transferPercentToken3Label";
            this.transferPercentToken3Label.Size = new System.Drawing.Size(44, 13);
            this.transferPercentToken3Label.TabIndex = 60;
            this.transferPercentToken3Label.Text = "Percent";
            // 
            // transferPercentToken3
            // 
            this.transferPercentToken3.Enabled = false;
            this.transferPercentToken3.Location = new System.Drawing.Point(696, 88);
            this.transferPercentToken3.Name = "transferPercentToken3";
            this.transferPercentToken3.Size = new System.Drawing.Size(67, 20);
            this.transferPercentToken3.TabIndex = 61;
            // 
            // enableTransferToken1
            // 
            this.enableTransferToken1.AutoSize = true;
            this.enableTransferToken1.Enabled = false;
            this.enableTransferToken1.Location = new System.Drawing.Point(6, 38);
            this.enableTransferToken1.Name = "enableTransferToken1";
            this.enableTransferToken1.Size = new System.Drawing.Size(59, 17);
            this.enableTransferToken1.TabIndex = 64;
            this.enableTransferToken1.Text = "Enable";
            this.enableTransferToken1.UseVisualStyleBackColor = true;
            this.enableTransferToken1.CheckedChanged += new System.EventHandler(this.enableTransferToken1_CheckedChanged);
            // 
            // transferPercentToken2Label
            // 
            this.transferPercentToken2Label.AutoSize = true;
            this.transferPercentToken2Label.Enabled = false;
            this.transferPercentToken2Label.Location = new System.Drawing.Point(646, 65);
            this.transferPercentToken2Label.Name = "transferPercentToken2Label";
            this.transferPercentToken2Label.Size = new System.Drawing.Size(44, 13);
            this.transferPercentToken2Label.TabIndex = 58;
            this.transferPercentToken2Label.Text = "Percent";
            // 
            // transferPercentToken2
            // 
            this.transferPercentToken2.Enabled = false;
            this.transferPercentToken2.Location = new System.Drawing.Point(696, 62);
            this.transferPercentToken2.Name = "transferPercentToken2";
            this.transferPercentToken2.Size = new System.Drawing.Size(67, 20);
            this.transferPercentToken2.TabIndex = 59;
            // 
            // transferPercentToken1Label
            // 
            this.transferPercentToken1Label.AutoSize = true;
            this.transferPercentToken1Label.Enabled = false;
            this.transferPercentToken1Label.Location = new System.Drawing.Point(646, 39);
            this.transferPercentToken1Label.Name = "transferPercentToken1Label";
            this.transferPercentToken1Label.Size = new System.Drawing.Size(44, 13);
            this.transferPercentToken1Label.TabIndex = 56;
            this.transferPercentToken1Label.Text = "Percent";
            // 
            // transferTokenLoopCount
            // 
            this.transferTokenLoopCount.Enabled = false;
            this.transferTokenLoopCount.Location = new System.Drawing.Point(239, 144);
            this.transferTokenLoopCount.Name = "transferTokenLoopCount";
            this.transferTokenLoopCount.Size = new System.Drawing.Size(52, 20);
            this.transferTokenLoopCount.TabIndex = 55;
            // 
            // transferPercentToken1
            // 
            this.transferPercentToken1.Enabled = false;
            this.transferPercentToken1.Location = new System.Drawing.Point(696, 36);
            this.transferPercentToken1.Name = "transferPercentToken1";
            this.transferPercentToken1.Size = new System.Drawing.Size(67, 20);
            this.transferPercentToken1.TabIndex = 57;
            // 
            // transferTokenLoopCountLabel
            // 
            this.transferTokenLoopCountLabel.AutoSize = true;
            this.transferTokenLoopCountLabel.Enabled = false;
            this.transferTokenLoopCountLabel.Location = new System.Drawing.Point(171, 147);
            this.transferTokenLoopCountLabel.Name = "transferTokenLoopCountLabel";
            this.transferTokenLoopCountLabel.Size = new System.Drawing.Size(62, 13);
            this.transferTokenLoopCountLabel.TabIndex = 54;
            this.transferTokenLoopCountLabel.Text = "Loop Count";
            // 
            // transferContract1
            // 
            this.transferContract1.Enabled = false;
            this.transferContract1.Location = new System.Drawing.Point(185, 36);
            this.transferContract1.Name = "transferContract1";
            this.transferContract1.Size = new System.Drawing.Size(455, 20);
            this.transferContract1.TabIndex = 47;
            // 
            // transferContract4
            // 
            this.transferContract4.Enabled = false;
            this.transferContract4.Location = new System.Drawing.Point(185, 114);
            this.transferContract4.Name = "transferContract4";
            this.transferContract4.Size = new System.Drawing.Size(455, 20);
            this.transferContract4.TabIndex = 53;
            // 
            // transferContract4Label
            // 
            this.transferContract4Label.AutoSize = true;
            this.transferContract4Label.Enabled = false;
            this.transferContract4Label.Location = new System.Drawing.Point(95, 117);
            this.transferContract4Label.Name = "transferContract4Label";
            this.transferContract4Label.Size = new System.Drawing.Size(87, 13);
            this.transferContract4Label.TabIndex = 52;
            this.transferContract4Label.Text = "Token4 Contract";
            // 
            // transferContract3
            // 
            this.transferContract3.Enabled = false;
            this.transferContract3.Location = new System.Drawing.Point(185, 88);
            this.transferContract3.Name = "transferContract3";
            this.transferContract3.Size = new System.Drawing.Size(455, 20);
            this.transferContract3.TabIndex = 51;
            // 
            // transferContract1Label
            // 
            this.transferContract1Label.AutoSize = true;
            this.transferContract1Label.Enabled = false;
            this.transferContract1Label.Location = new System.Drawing.Point(95, 39);
            this.transferContract1Label.Name = "transferContract1Label";
            this.transferContract1Label.Size = new System.Drawing.Size(87, 13);
            this.transferContract1Label.TabIndex = 46;
            this.transferContract1Label.Text = "Token1 Contract";
            // 
            // transferContract3Label
            // 
            this.transferContract3Label.AutoSize = true;
            this.transferContract3Label.Enabled = false;
            this.transferContract3Label.Location = new System.Drawing.Point(95, 91);
            this.transferContract3Label.Name = "transferContract3Label";
            this.transferContract3Label.Size = new System.Drawing.Size(87, 13);
            this.transferContract3Label.TabIndex = 50;
            this.transferContract3Label.Text = "Token3 Contract";
            // 
            // transferContract2Label
            // 
            this.transferContract2Label.AutoSize = true;
            this.transferContract2Label.Enabled = false;
            this.transferContract2Label.Location = new System.Drawing.Point(95, 65);
            this.transferContract2Label.Name = "transferContract2Label";
            this.transferContract2Label.Size = new System.Drawing.Size(87, 13);
            this.transferContract2Label.TabIndex = 48;
            this.transferContract2Label.Text = "Token2 Contract";
            // 
            // transferContract2
            // 
            this.transferContract2.Enabled = false;
            this.transferContract2.Location = new System.Drawing.Point(185, 62);
            this.transferContract2.Name = "transferContract2";
            this.transferContract2.Size = new System.Drawing.Size(455, 20);
            this.transferContract2.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(773, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(996, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nativeBalanceTransferEngine
            // 
            this.nativeBalanceTransferEngine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.nativeBalanceTransferEngine_DoWork);
            // 
            // transferNativeBalanceCheck
            // 
            this.transferNativeBalanceCheck.AutoSize = true;
            this.transferNativeBalanceCheck.Location = new System.Drawing.Point(773, 40);
            this.transferNativeBalanceCheck.Name = "transferNativeBalanceCheck";
            this.transferNativeBalanceCheck.Size = new System.Drawing.Size(141, 17);
            this.transferNativeBalanceCheck.TabIndex = 45;
            this.transferNativeBalanceCheck.Text = "Transfer Native Balance";
            this.transferNativeBalanceCheck.UseVisualStyleBackColor = true;
            this.transferNativeBalanceCheck.CheckedChanged += new System.EventHandler(this.transferNativeBalanceCheck_CheckedChanged);
            // 
            // swapTokensCheck
            // 
            this.swapTokensCheck.AutoSize = true;
            this.swapTokensCheck.Location = new System.Drawing.Point(920, 40);
            this.swapTokensCheck.Name = "swapTokensCheck";
            this.swapTokensCheck.Size = new System.Drawing.Size(92, 17);
            this.swapTokensCheck.TabIndex = 46;
            this.swapTokensCheck.Text = "Swap Tokens";
            this.swapTokensCheck.UseVisualStyleBackColor = true;
            this.swapTokensCheck.CheckedChanged += new System.EventHandler(this.swapTokensCheck_CheckedChanged);
            // 
            // transferTokensCheck
            // 
            this.transferTokensCheck.AutoSize = true;
            this.transferTokensCheck.Location = new System.Drawing.Point(1018, 39);
            this.transferTokensCheck.Name = "transferTokensCheck";
            this.transferTokensCheck.Size = new System.Drawing.Size(104, 17);
            this.transferTokensCheck.TabIndex = 47;
            this.transferTokensCheck.Text = "Transfer Tokens";
            this.transferTokensCheck.UseVisualStyleBackColor = true;
            this.transferTokensCheck.CheckedChanged += new System.EventHandler(this.transferTokensCheck_CheckedChanged);
            // 
            // tokenTransferEngine
            // 
            this.tokenTransferEngine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tokenTransferEngine_DoWork);
            // 
            // tokenSwapEngine
            // 
            this.tokenSwapEngine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.tokenSwapEngine_DoWork);
            // 
            // nativePairContractLabel
            // 
            this.nativePairContractLabel.AutoSize = true;
            this.nativePairContractLabel.Enabled = false;
            this.nativePairContractLabel.Location = new System.Drawing.Point(477, 14);
            this.nativePairContractLabel.Name = "nativePairContractLabel";
            this.nativePairContractLabel.Size = new System.Drawing.Size(102, 13);
            this.nativePairContractLabel.TabIndex = 52;
            this.nativePairContractLabel.Text = "Native Pair Contract";
            // 
            // nativePairContract
            // 
            this.nativePairContract.Enabled = false;
            this.nativePairContract.Location = new System.Drawing.Point(584, 10);
            this.nativePairContract.Name = "nativePairContract";
            this.nativePairContract.Size = new System.Drawing.Size(405, 20);
            this.nativePairContract.TabIndex = 53;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 299);
            this.Controls.Add(this.transferTokensCheck);
            this.Controls.Add(this.swapTokensCheck);
            this.Controls.Add(this.transferNativeBalanceCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rpcURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.settingsName);
            this.Controls.Add(this.privateKeyMode);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.seedMode);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Airdrop Hunter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker getAccountBalanceBackground;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox privateKeyBox2;
        private System.Windows.Forms.TextBox privateKeyBox1;
        private System.ComponentModel.BackgroundWorker testRPCBackground;
        private System.Windows.Forms.RadioButton privateKeyMode;
        private System.Windows.Forms.RadioButton seedMode;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox privateKeyBox3;
        private System.Windows.Forms.TextBox privateKeyBox4;
        private System.Windows.Forms.TextBox privateKeyBox5;
        private System.Windows.Forms.TextBox privateKeyBox6;
        private System.ComponentModel.BackgroundWorker loadAccountsFromPrivateKey;
        private System.Windows.Forms.TextBox balanceBox6;
        private System.Windows.Forms.TextBox balanceBox5;
        private System.Windows.Forms.TextBox balanceBox4;
        private System.Windows.Forms.TextBox balanceBox3;
        private System.Windows.Forms.TextBox balanceBox2;
        private System.Windows.Forms.TextBox balanceBox1;
        private System.Windows.Forms.TextBox rpcURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox privateKeyCheck6;
        private System.Windows.Forms.CheckBox privateKeyCheck5;
        private System.Windows.Forms.CheckBox privateKeyCheck4;
        private System.Windows.Forms.CheckBox privateKeyCheck3;
        private System.Windows.Forms.CheckBox privateKeyCheck2;
        private System.Windows.Forms.CheckBox privateKeyCheck1;
        private System.Windows.Forms.TextBox seedPhrase;
        private System.Windows.Forms.Label seedPhraseLabel;
        private System.Windows.Forms.TextBox extraWord;
        private System.Windows.Forms.Label extraWordLabel;
        private System.Windows.Forms.TextBox accountCount;
        private System.Windows.Forms.Label accountCountLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox settingsName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox swapTokenSlippage;
        private System.Windows.Forms.Label swapTokenSlippageLabel;
        private System.Windows.Forms.CheckBox swapBackNativeToken4;
        private System.Windows.Forms.CheckBox swapBackNativeToken3;
        private System.Windows.Forms.CheckBox swapBackNativeToken2;
        private System.Windows.Forms.CheckBox swapBackNativeToken1;
        private System.Windows.Forms.CheckBox enableSwapToken4;
        private System.Windows.Forms.Label swapPercentToken4Label;
        private System.Windows.Forms.CheckBox enableSwapToken3;
        private System.Windows.Forms.TextBox swapPercentToken4;
        private System.Windows.Forms.CheckBox enableSwapToken2;
        private System.Windows.Forms.Label swapPercentToken3Label;
        private System.Windows.Forms.TextBox swapPercentToken3;
        private System.Windows.Forms.CheckBox enableSwapToken1;
        private System.Windows.Forms.Label swapPercentToken2Label;
        private System.Windows.Forms.TextBox swapPercentToken2;
        private System.Windows.Forms.Label swapPercentToken1Label;
        private System.Windows.Forms.TextBox swapTokenLoopCount;
        private System.Windows.Forms.TextBox swapPercentToken1;
        private System.Windows.Forms.Label swapTokenLoopCountLabel;
        private System.Windows.Forms.TextBox swapContract1;
        private System.Windows.Forms.TextBox swapContract4;
        private System.Windows.Forms.Label routerContractBoxLabel;
        private System.Windows.Forms.Label swapContract4Label;
        private System.Windows.Forms.TextBox routerContractBox;
        private System.Windows.Forms.TextBox swapContract3;
        private System.Windows.Forms.Label swapContract1Label;
        private System.Windows.Forms.Label swapContract3Label;
        private System.Windows.Forms.Label swapContract2Label;
        private System.Windows.Forms.TextBox swapContract2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.CheckBox enableTransferToken4;
        private System.Windows.Forms.Label transferPercentToken4Label;
        private System.Windows.Forms.CheckBox enableTransferToken3;
        private System.Windows.Forms.TextBox transferPercentToken4;
        private System.Windows.Forms.CheckBox enableTransferToken2;
        private System.Windows.Forms.Label transferPercentToken3Label;
        private System.Windows.Forms.TextBox transferPercentToken3;
        private System.Windows.Forms.CheckBox enableTransferToken1;
        private System.Windows.Forms.Label transferPercentToken2Label;
        private System.Windows.Forms.TextBox transferPercentToken2;
        private System.Windows.Forms.Label transferPercentToken1Label;
        private System.Windows.Forms.TextBox transferTokenLoopCount;
        private System.Windows.Forms.TextBox transferPercentToken1;
        private System.Windows.Forms.Label transferTokenLoopCountLabel;
        private System.Windows.Forms.TextBox transferContract1;
        private System.Windows.Forms.TextBox transferContract4;
        private System.Windows.Forms.Label transferContract4Label;
        private System.Windows.Forms.TextBox transferContract3;
        private System.Windows.Forms.Label transferContract1Label;
        private System.Windows.Forms.Label transferContract3Label;
        private System.Windows.Forms.Label transferContract2Label;
        private System.Windows.Forms.TextBox transferContract2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker nativeBalanceTransferEngine;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label nativeTransferPercentLabel;
        private System.Windows.Forms.TextBox nativeTransferLoop;
        private System.Windows.Forms.Label nativeTransferLoopLabel;
        private System.Windows.Forms.CheckBox transferNativeBalanceCheck;
        private System.Windows.Forms.CheckBox swapTokensCheck;
        private System.Windows.Forms.CheckBox transferTokensCheck;
        private System.Windows.Forms.TextBox nativeTransferCooldown;
        private System.Windows.Forms.Label nativeTransferCooldownLabel;
        private System.Windows.Forms.TextBox tokenSwapCooldown;
        private System.Windows.Forms.Label tokenSwapCooldownLabel;
        private System.Windows.Forms.TextBox tokenTransferCooldown;
        private System.Windows.Forms.Label tokenTransferCooldownLabel;
        private System.ComponentModel.BackgroundWorker tokenTransferEngine;
        private System.Windows.Forms.TextBox nativeTransferPercent;
        private System.ComponentModel.BackgroundWorker tokenSwapEngine;
        private System.Windows.Forms.Label nativePairContractLabel;
        private System.Windows.Forms.TextBox nativePairContract;
    }
}

