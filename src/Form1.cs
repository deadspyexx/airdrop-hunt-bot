using Microsoft.Scripting.Utils;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using Nethereum.HdWallet;
using Nethereum.Uniswap.Contracts.UniswapV2Pair.ContractDefinition;
using Nethereum.Uniswap.Contracts.UniswapV2Router02;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirdropHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string rpc { get; set; }
        public static string accountname { get; set; }

        int privatekeycount = 0;
        public static string tempbalance { get; set; }
        public static int walletcount { get; set; }

        string[] accountprivatekey = new string[9999];

        string[] accountaddress = new string[9999];

        string[] accountbalance = new string[9999];
        string[] token1balanceaccount = new string[9999];
        string[] token2balanceaccount = new string[9999];
        string[] token3balanceaccount = new string[9999];
        string[] token4balanceaccount = new string[9999];


        int transferNativeBalancePercent = 0;
        int transferNativeBalanceLoop = 0;


        static string GetAccountAddress(string privatekey)
        {
            var account = new Account(privatekey);
            return account.Address;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (privateKeyMode.Checked == true)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                rpc = rpcURL.Text;
                if (privatekeycount == 1)
                {
                    Console.WriteLine("Only Token Swap Mode Can Be Used When There Is Only 1 Account.");
                    swapTokensCheck.Checked = true;
                    transferNativeBalanceCheck.Enabled = false;
                    transferTokensCheck.Enabled = false;
                }
                if (privatekeycount > 1)
                {
                    swapTokensCheck.Enabled = true;
                    transferNativeBalanceCheck.Enabled = true;
                    transferTokensCheck.Enabled = true;
                }


                if (privatekeycount == 1)
                {
                    accountprivatekey[privatekeycount - 1] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 2)
                {
                    accountprivatekey[privatekeycount - 2] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 3)
                {
                    accountprivatekey[privatekeycount - 3] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 4)
                {
                    accountprivatekey[privatekeycount - 4] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 1];
                }
                if (privatekeycount == 5)
                {
                    accountprivatekey[privatekeycount - 5] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 5] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 5;
                    accountname = accountaddress[privatekeycount - 5];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 5] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 5];
                    accountprivatekey[privatekeycount - 4] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox5.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox5.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox5.Text = accountbalance[privatekeycount - 1];

                }
                if (privatekeycount == 6)
                {
                    accountprivatekey[privatekeycount - 6] = privateKeyBox1.Text;
                    accountaddress[privatekeycount - 6] = GetAccountAddress(privateKeyBox1.Text);
                    walletcount = privatekeycount - 6;
                    accountname = accountaddress[privatekeycount - 6];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 6] = tempbalance;
                    balanceBox1.Text = accountbalance[privatekeycount - 6];
                    accountprivatekey[privatekeycount - 5] = privateKeyBox2.Text;
                    accountaddress[privatekeycount - 5] = GetAccountAddress(privateKeyBox2.Text);
                    walletcount = privatekeycount - 5;
                    accountname = accountaddress[privatekeycount - 5];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 5] = tempbalance;
                    balanceBox2.Text = accountbalance[privatekeycount - 5];
                    accountprivatekey[privatekeycount - 4] = privateKeyBox3.Text;
                    accountaddress[privatekeycount - 4] = GetAccountAddress(privateKeyBox3.Text);
                    walletcount = privatekeycount - 4;
                    accountname = accountaddress[privatekeycount - 4];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 4] = tempbalance;
                    balanceBox3.Text = accountbalance[privatekeycount - 4];
                    accountprivatekey[privatekeycount - 3] = privateKeyBox4.Text;
                    accountaddress[privatekeycount - 3] = GetAccountAddress(privateKeyBox4.Text);
                    walletcount = privatekeycount - 3;
                    accountname = accountaddress[privatekeycount - 3];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 3] = tempbalance;
                    balanceBox4.Text = accountbalance[privatekeycount - 3];
                    accountprivatekey[privatekeycount - 2] = privateKeyBox5.Text;
                    accountaddress[privatekeycount - 2] = GetAccountAddress(privateKeyBox5.Text);
                    walletcount = privatekeycount - 2;
                    accountname = accountaddress[privatekeycount - 2];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 2] = tempbalance;
                    balanceBox5.Text = accountbalance[privatekeycount - 2];
                    accountprivatekey[privatekeycount - 1] = privateKeyBox6.Text;
                    accountaddress[privatekeycount - 1] = GetAccountAddress(privateKeyBox6.Text);
                    walletcount = privatekeycount - 1;
                    accountname = accountaddress[privatekeycount - 1];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[privatekeycount - 1] = tempbalance;
                    balanceBox6.Text = accountbalance[privatekeycount - 1];
                }

                while (loadAccountsFromPrivateKey.IsBusy == true)
                {
                    Application.DoEvents();
                }

                if (loadAccountsFromPrivateKey.IsBusy == false)
                {
                    loadAccountsFromPrivateKey.RunWorkerAsync();
                }
                while (loadAccountsFromPrivateKey.IsBusy == true)
                {
                    Application.DoEvents();
                }
                button3.Enabled = true;

            }

            if (seedMode.Checked == true)
            {

                privatekeycount = 0;
                var wallet = new Wallet(seedPhrase.Text, extraWord.Text);
                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    var account = wallet.GetAccount(i);
                    accountaddress[i] = account.Address;
                    accountprivatekey[i] = account.PrivateKey;
                    privatekeycount++;
                }

                button3.Enabled = false;
                button1.Enabled = false;
                rpc = rpcURL.Text;
                if (privatekeycount == 1)
                {
                    Console.WriteLine("Only Token Swap Mode Can Be Used When There Is Only 1 Account.");
                    swapTokensCheck.Checked = true;
                    transferNativeBalanceCheck.Enabled = false;
                    transferTokensCheck.Enabled = false;
                }
                if (privatekeycount > 1)
                {
                    swapTokensCheck.Enabled = true;
                    transferNativeBalanceCheck.Enabled = true;
                    transferTokensCheck.Enabled = true;
                }
                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    accountname = accountaddress[i];
                    getAccountBalanceBackground.RunWorkerAsync();
                    while (getAccountBalanceBackground.IsBusy == true)
                    {
                        Application.DoEvents();
                    }
                    accountbalance[i] = tempbalance;

                }
                for (int i = 0; i < Convert.ToInt32(accountCount.Text); i++)
                {
                    Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                }

                button3.Enabled = true;




            }

            button1.Enabled = true;
        }

        private void seedMode_CheckedChanged(object sender, EventArgs e)
        {

            if (seedMode.Checked == true)
            {
                privateKeyMode.Checked = false;
                Console.WriteLine("Seed Mode Selected");
                Console.WriteLine("You Can Work With As Wanted As Accounts");
                tabControl3.SelectedTab = tabControl3.TabPages["tabPage3"];
                seedPhrase.Enabled = true; seedPhraseLabel.Enabled = true; extraWord.Enabled = true; extraWordLabel.Enabled = true; accountCount.Enabled = true; accountCountLabel.Enabled = true;

            }

            if (seedMode.Checked == false)
            {
                seedPhrase.Enabled = false; seedPhraseLabel.Enabled = false; extraWord.Enabled = false; extraWordLabel.Enabled = false; accountCount.Enabled = false; accountCountLabel.Enabled = false;
            }

            button3.Enabled = true;
        }

        private void privateKeyMode_CheckedChanged(object sender, EventArgs e)
        {

            if (privateKeyMode.Checked == true)
            {
                seedMode.Checked = false; Console.WriteLine("Private Key Mode Selected");
                Console.WriteLine("You Can Work Up To 6 Accounts");
                tabControl3.SelectedTab = tabControl3.TabPages["tabPage4"];
                privateKeyCheck1.Enabled = true;
            }
            if (privateKeyMode.Checked == false)
            {

                privateKeyCheck1.Enabled = false; privateKeyBox1.Enabled = false; balanceBox1.Enabled = false;
                privateKeyCheck2.Enabled = false; privateKeyBox2.Enabled = false; balanceBox2.Enabled = false;
                privateKeyCheck3.Enabled = false; privateKeyBox3.Enabled = false; balanceBox3.Enabled = false;
                privateKeyCheck4.Enabled = false; privateKeyBox4.Enabled = false; balanceBox4.Enabled = false;
                privateKeyCheck5.Enabled = false; privateKeyBox5.Enabled = false; balanceBox5.Enabled = false;
                privateKeyCheck6.Enabled = false; privateKeyBox6.Enabled = false; balanceBox6.Enabled = false;
            }
            button3.Enabled = true;

        }
        private void transferNativeBalanceCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transferNativeBalanceCheck.Checked == true)
            {
                Console.WriteLine("Transfer Native Balance Mode Selected");
                Console.WriteLine("Bot Will Transfer Native Balance (ETH, BNB, Matic, AVAX etc.) For Loaded Accounts In Order. Set Percent and Loop Count Correctly. This Process Will Take As Long As The Number Of Loop Count.");
                swapTokensCheck.Checked = false;
                transferTokensCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage1"];
                nativeTransferLoop.Enabled = true; nativeTransferLoopLabel.Enabled = true; nativeTransferPercent.Enabled = true; nativeTransferPercentLabel.Enabled = true;
                nativeTransferCooldown.Enabled = true; nativeTransferCooldownLabel.Enabled = true;

            }
            if (transferNativeBalanceCheck.Checked == false)

            {
                nativeTransferLoop.Enabled = false; nativeTransferLoopLabel.Enabled = false; nativeTransferPercent.Enabled = false; nativeTransferPercentLabel.Enabled = false;
                nativeTransferCooldown.Enabled = false; nativeTransferCooldownLabel.Enabled = false;

            }


        }

        private void transferTokensCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transferTokensCheck.Checked == true)
            {
                Console.WriteLine("Transfer Tokens Mode Selected");
                Console.WriteLine("Bot Will Transfer Token Balances. You Can Define Token Contracts Up To 4. Set Percent and Loop Count Correctly. This Process Will Take As Long As The Number Of Loop Count.");
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage6"];
                enableTransferToken1.Enabled = true;
                transferTokenLoopCount.Enabled = true; transferTokenLoopCountLabel.Enabled = true;
                tokenTransferCooldown.Enabled = true; tokenTransferCooldownLabel.Enabled = true;
            }
            if (transferTokensCheck.Checked == false)
            {
                enableTransferToken1.Enabled = false; enableTransferToken2.Enabled = false; enableTransferToken3.Enabled = false; enableTransferToken4.Enabled = false;
                transferContract1.Enabled = false; transferContract2.Enabled = false; transferContract3.Enabled = false; transferContract4.Enabled = false;
                transferPercentToken1.Enabled = false; transferPercentToken2.Enabled = false; transferPercentToken3.Enabled = false; transferPercentToken4.Enabled = false;

                transferTokenLoopCount.Enabled = false;
                transferContract1Label.Enabled = false; transferContract2Label.Enabled = false; transferContract3Label.Enabled = false; transferContract4Label.Enabled = false;
                transferPercentToken1Label.Enabled = false; transferPercentToken2Label.Enabled = false; transferPercentToken3Label.Enabled = false; transferPercentToken4Label.Enabled = false;
                transferTokenLoopCountLabel.Enabled = false;
                enableTransferToken1.Checked = false;
                enableTransferToken2.Checked = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;
                tokenTransferCooldown.Enabled = false; tokenTransferCooldownLabel.Enabled = false;


            }
        }
        private void swapTokensCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (swapTokensCheck.Checked == true)
            {
                Console.WriteLine("Swap Tokens Mode Selected");
                Console.WriteLine("Bot Will Swap Tokens. You Can Define Token Contracts Up To 4. Set Router Contract, Percent, Loop Count And Slippage Correctly. Router Contract Differs For Every Network. This Process Will Take As Long As The Number Of Loop Count.");
                transferTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                tabControl2.SelectedTab = tabControl2.TabPages["tabPage7"];
                enableSwapToken1.Enabled = true; routerContractBox.Enabled = true; routerContractBoxLabel.Enabled = true;
                swapTokenSlippage.Enabled = true; swapTokenLoopCount.Enabled = true; swapTokenSlippageLabel.Enabled = true; swapTokenLoopCountLabel.Enabled = true;
                tokenSwapCooldown.Enabled = true; tokenSwapCooldownLabel.Enabled = true;
                nativePairContract.Enabled = true; nativePairContractLabel.Enabled = true;
            }
            if (swapTokensCheck.Checked == false)
            {
                enableSwapToken1.Enabled = false; enableSwapToken2.Enabled = false; enableSwapToken3.Enabled = false; enableSwapToken4.Enabled = false;
                routerContractBox.Enabled = false; swapContract1.Enabled = false; swapContract2.Enabled = false; swapContract3.Enabled = false; swapContract4.Enabled = false;
                swapPercentToken1.Enabled = false; swapPercentToken2.Enabled = false; swapPercentToken3.Enabled = false; swapPercentToken4.Enabled = false;
                swapBackNativeToken1.Enabled = false; swapBackNativeToken2.Enabled = false; swapBackNativeToken3.Enabled = false; swapBackNativeToken4.Enabled = false;
                swapBackNativeToken1.Checked = false; swapBackNativeToken2.Checked = false; swapBackNativeToken3.Checked = false; swapBackNativeToken4.Checked = false;
                swapTokenSlippage.Enabled = false; swapTokenLoopCount.Enabled = false;
                routerContractBoxLabel.Enabled = false; swapContract1Label.Enabled = false; swapContract2Label.Enabled = false; swapContract3Label.Enabled = false; swapContract4Label.Enabled = false;
                swapPercentToken1Label.Enabled = false; swapPercentToken2Label.Enabled = false; swapPercentToken3Label.Enabled = false; swapPercentToken4Label.Enabled = false;
                swapTokenSlippageLabel.Enabled = false; swapTokenLoopCountLabel.Enabled = false;
                enableSwapToken1.Checked = false;
                enableSwapToken2.Checked = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;
                tokenSwapCooldown.Enabled = false; tokenSwapCooldownLabel.Enabled = false;
                nativePairContract.Enabled = false; nativePairContractLabel.Enabled = false;


            }

        }


        private void loadAccountsFromPrivateKey_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < privatekeycount; i++)
            {
                Console.WriteLine("Account " + i + " : - Address : " + accountaddress[i] + " - Private key : " + accountprivatekey[i] + " - Account Balance : " + accountbalance[i]);
            }
        }

        private void enablePrivateKey1_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck1.Checked == true)
            {
                privateKeyBox1.Enabled = true;
                privateKeyCheck2.Enabled = true;
                privatekeycount = 1;
                button3.Enabled = true;

            }
            if (privateKeyCheck1.Checked == false)
            {
                privateKeyBox1.Enabled = false;
                privateKeyCheck2.Enabled = false;
                privateKeyBox2.Enabled = false;
                privateKeyCheck3.Enabled = false;
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck2.Checked = false;
                privateKeyCheck3.Checked = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                button3.Enabled = false;

                privatekeycount = 0;


            }
        }

        private void enablePrivateKey2_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck2.Checked == true)
            {
                privateKeyBox2.Enabled = true;
                privateKeyCheck3.Enabled = true;
                privatekeycount = 2;

            }
            if (privateKeyCheck2.Checked == false)
            {
                privateKeyBox2.Enabled = false;
                privateKeyCheck3.Enabled = false;
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck3.Checked = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 1;

            }
        }

        private void enablePrivateKey3_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck3.Checked == true)
            {
                privateKeyBox3.Enabled = true;
                privateKeyCheck4.Enabled = true;
                privatekeycount = 3;

            }
            if (privateKeyCheck3.Checked == false)
            {
                privateKeyBox3.Enabled = false;
                privateKeyCheck4.Enabled = false;
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck4.Checked = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 2;


            }
        }

        private void enablePrivateKey4_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck4.Checked == true)
            {
                privateKeyBox4.Enabled = true;
                privateKeyCheck5.Enabled = true;
                privatekeycount = 4;

            }
            if (privateKeyCheck4.Checked == false)
            {
                privateKeyBox4.Enabled = false;
                privateKeyCheck5.Enabled = false;
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck5.Checked = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 3;


            }
        }

        private void enablePrivateKey5_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck5.Checked == true)
            {
                privateKeyBox5.Enabled = true;
                privateKeyCheck6.Enabled = true;
                privatekeycount = 5;

            }
            if (privateKeyCheck5.Checked == false)
            {
                privateKeyBox5.Enabled = false;
                privateKeyCheck6.Enabled = false;
                privateKeyBox6.Enabled = false;
                privateKeyCheck6.Checked = false;
                privatekeycount = 4;

            }
        }

        private void enablePrivateKey6_CheckedChanged(object sender, EventArgs e)
        {
            if (privateKeyCheck6.Checked == true)
            {
                privateKeyBox6.Enabled = true;
                privatekeycount = 6;

            }
            if (privateKeyCheck6.Checked == false)
            {
                privateKeyBox6.Enabled = false;
                privatekeycount = 5;

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            rpc = rpcURL.Text;
            testRPCBackground.RunWorkerAsync();
            while (testRPCBackground.IsBusy == true)
            {
                Application.DoEvents();
            }
            button2.Enabled = true;

        }

        private void getAccountBalanceBackground_DoWork(object sender, DoWorkEventArgs e)
        {

            GetAccountData().Wait();

        }

        public static async Task GetAccountData()
        {
            await GetBalance();
        }

        static async Task GetBalance()
        {
            var web3 = new Web3(rpc);
            var balance = await web3.Eth.GetBalance.SendRequestAsync(accountname);
            //Console.WriteLine($"Balance in Wei: {balance.Value}");
            var etherAmount = Web3.Convert.FromWei(balance.Value);
            //Console.WriteLine($"Balance in Ether: {etherAmount}");
            tempbalance = etherAmount.ToString();
        }







        private void testRPCBackground_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectTestRPCAsync().Wait();

        }

        public static async Task ConnectTestRPCAsync()
        {
            await ConnectTestRPC();
        }

        static async Task ConnectTestRPC()
        {
            var web3 = new Web3(rpc);
            var latestBlockNumber = await web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
            Console.WriteLine($"Connection Established To RPC. Last Block Number is: {latestBlockNumber.Value}");


        }

        public class TokenTransferSettings
        {
            public bool TransferToken { get; set; }
            public bool EnableToken1 { get; set; }
            public string TokenContract1 { get; set; }
            public string Token1TransferPercent { get; set; }
            public bool EnableToken2 { get; set; }
            public string TokenContract2 { get; set; }
            public string Token2TransferPercent { get; set; }
            public bool EnableToken3 { get; set; }
            public string TokenContract3 { get; set; }
            public string Token3TransferPercent { get; set; }
            public bool EnableToken4 { get; set; }
            public string TokenContract4 { get; set; }
            public string Token4TransferPercent { get; set; }
            public string TransferTokenLoopCount { get; set; }
            public string TokenTransferCooldown { get; set; }





        }

        public class General
        {
            public string SettingsName { get; set; }
            public string RPC { get; set; }
        }

        public class NativeBalanceSettings
        {
            public bool TransferNativeBalance { get; set; }
            public string NativeTransferLoop { get; set; }
            public string NativeTransferPercent { get; set; }
            public string NativeTransferCooldown { get; set; }


        }

        public class PrivateKeyModeSettings
        {
            public bool EnablePrivateKey1 { get; set; }
            public string PrivateKeyBox1 { get; set; }
            public bool EnablePrivateKey2 { get; set; }
            public string PrivateKeyBox2 { get; set; }
            public bool EnablePrivateKey3 { get; set; }
            public string PrivateKeyBox3 { get; set; }
            public bool EnablePrivateKey4 { get; set; }
            public string PrivateKeyBox4 { get; set; }
            public bool EnablePrivateKey5 { get; set; }
            public string PrivateKeyBox5 { get; set; }
            public bool EnablePrivateKey6 { get; set; }
            public string PrivateKeyBox6 { get; set; }
        }

        public class Config
        {
            public General General { get; set; }
            public WorkingModeSettings WorkingModeSettings { get; set; }
            public PrivateKeyModeSettings PrivateKeyModeSettings { get; set; }
            public SeedModeSettings SeedModeSettings { get; set; }
        }

        public class SeedModeSettings
        {
            public string Seed { get; set; }
            public string ExtraWord { get; set; }
            public string AccountCount { get; set; }
        }

        public class TokenSwapSettings
        {
            public bool SwapToken { get; set; }
            public string RouterContract { get; set; }
            public string NativeTokenContract { get; set; }
            public string SlippagePercent { get; set; }
            public string TokenSwapCooldown { get; set; }
            public string SwapTokenLoopCount { get; set; }
            public bool EnableToken1 { get; set; }
            public string TokenContract1 { get; set; }
            public string Token1SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken1 { get; set; }
            public bool EnableToken2 { get; set; }
            public string TokenContract2 { get; set; }
            public string Token2SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken2 { get; set; }
            public bool EnableToken3 { get; set; }
            public string TokenContract3 { get; set; }
            public string Token3SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken3 { get; set; }
            public bool EnableToken4 { get; set; }
            public string TokenContract4 { get; set; }
            public string Token4SwapPercent { get; set; }
            public bool SwapBackERC20ToNativeToken4 { get; set; }
        }

        public class WorkingModeSettings
        {
            public bool PrivateKeyMode { get; set; }
            public bool SeedMode { get; set; }
            public NativeBalanceSettings NativeBalanceSettings { get; set; }
            public TokenTransferSettings TokenTransferSettings { get; set; }
            public TokenSwapSettings TokenSwapSettings { get; set; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            //RPC

            rpcURL.Text = appConfig.General.RPC;
            settingsName.Text = appConfig.General.SettingsName;



            //TokenSwapSettings
            routerContractBox.Text = appConfig.WorkingModeSettings.TokenSwapSettings.RouterContract;
            nativePairContract.Text = appConfig.WorkingModeSettings.TokenSwapSettings.NativeTokenContract;

            if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken1 == true)
            {
                enableSwapToken1.Checked = true;
                if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken1 == true)
                {
                    swapBackNativeToken1.Checked = true;

                }
                else
                {
                    swapBackNativeToken1.Checked = false;
                }
                if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken2 == true)
                {
                    enableSwapToken2.Checked = true;
                    if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken2 == true)
                    {
                        swapBackNativeToken2.Checked = true;

                    }
                    else
                    {
                        swapBackNativeToken2.Checked = false;
                    }
                    if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken3 == true)
                    {
                        enableSwapToken3.Checked = true;
                        if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken3 == true)
                        {
                            swapBackNativeToken3.Checked = true;


                        }
                        else
                        {
                            swapBackNativeToken3.Checked = false;
                        }

                        if (appConfig.WorkingModeSettings.TokenSwapSettings.EnableToken4 == true)
                        {
                            enableSwapToken4.Checked = true;
                            if (appConfig.WorkingModeSettings.TokenSwapSettings.SwapBackERC20ToNativeToken4 == true)
                            {
                                swapBackNativeToken4.Checked = true;
                            }
                            else
                            {
                                swapBackNativeToken4.Checked = false;
                            }
                        }
                        else
                        {
                            enableSwapToken4.Checked = false;
                        }
                    }
                    else
                    {
                        enableSwapToken3.Checked = false;
                    }
                }
                else
                {
                    enableSwapToken2.Checked = false;
                }
            }
            else
            {
                enableSwapToken1.Checked = false;
            }

            swapContract1.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract1;
            swapPercentToken1.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token1SwapPercent;
            swapContract2.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract2;
            swapPercentToken2.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token2SwapPercent;
            swapContract3.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract3;
            swapPercentToken3.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token3SwapPercent;
            swapContract4.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenContract4;
            swapPercentToken4.Text = appConfig.WorkingModeSettings.TokenSwapSettings.Token4SwapPercent;
            swapTokenSlippage.Text = appConfig.WorkingModeSettings.TokenSwapSettings.SlippagePercent;
            swapTokenLoopCount.Text = appConfig.WorkingModeSettings.TokenSwapSettings.SwapTokenLoopCount;
            tokenSwapCooldown.Text = appConfig.WorkingModeSettings.TokenSwapSettings.TokenSwapCooldown;


            //TokenTransferSettings
            if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken1 == true)
            {
                enableTransferToken1.Checked = true;

                if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken2 == true)
                {
                    enableTransferToken2.Checked = true;

                    if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken3 == true)
                    {
                        enableTransferToken3.Checked = true;


                        if (appConfig.WorkingModeSettings.TokenTransferSettings.EnableToken4 == true)
                        {
                            enableTransferToken4.Checked = true;

                        }
                        else
                        {
                            enableTransferToken4.Checked = false;
                        }
                    }
                    else
                    {
                        enableTransferToken3.Checked = false;
                    }
                }
                else
                {
                    enableTransferToken2.Checked = false;
                }
            }
            else
            {
                enableTransferToken1.Checked = false;
            }

            transferContract1.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract1;
            transferPercentToken1.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token1TransferPercent;
            transferContract2.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract2;
            transferPercentToken2.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token2TransferPercent;
            transferContract3.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract3;
            transferPercentToken3.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token3TransferPercent;
            transferContract4.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenContract4;
            transferPercentToken4.Text = appConfig.WorkingModeSettings.TokenTransferSettings.Token4TransferPercent;
            transferTokenLoopCount.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TransferTokenLoopCount;
            tokenTransferCooldown.Text = appConfig.WorkingModeSettings.TokenTransferSettings.TokenTransferCooldown;

            //NativeBalanceTransferSettings
            nativeTransferLoop.Text = appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferLoop;
            nativeTransferPercent.Text = appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferPercent;
            nativeTransferCooldown.Text = appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferCooldown;

            //SeedSettings
            seedPhrase.Text = appConfig.SeedModeSettings.Seed;
            extraWord.Text = appConfig.SeedModeSettings.ExtraWord;
            accountCount.Text = appConfig.SeedModeSettings.AccountCount;

            //PrivateKeySetup
            if (appConfig.PrivateKeyModeSettings.EnablePrivateKey1 == true)
            {
                privateKeyCheck1.Checked = true;
                if (appConfig.PrivateKeyModeSettings.EnablePrivateKey2 == true)
                {
                    privateKeyCheck2.Checked = true;
                    if (appConfig.PrivateKeyModeSettings.EnablePrivateKey3 == true)
                    {
                        privateKeyCheck3.Checked = true;
                        if (appConfig.PrivateKeyModeSettings.EnablePrivateKey4 == true)
                        {
                            privateKeyCheck4.Checked = true;
                            if (appConfig.PrivateKeyModeSettings.EnablePrivateKey5 == true)
                            {
                                privateKeyCheck5.Checked = true;
                                if (appConfig.PrivateKeyModeSettings.EnablePrivateKey6 == true)
                                {
                                    privateKeyCheck6.Checked = true;
                                }
                                if (appConfig.PrivateKeyModeSettings.EnablePrivateKey6 == false)
                                {
                                    privateKeyCheck6.Checked = false;
                                }
                            }
                            if (appConfig.PrivateKeyModeSettings.EnablePrivateKey5 == false)
                            {
                                privateKeyCheck5.Checked = false;
                            }

                        }
                        if (appConfig.PrivateKeyModeSettings.EnablePrivateKey4 == false)
                        {
                            privateKeyCheck4.Checked = false;
                        }

                    }
                    if (appConfig.PrivateKeyModeSettings.EnablePrivateKey3 == false)
                    {
                        privateKeyCheck3.Checked = false;
                    }

                }
                if (appConfig.PrivateKeyModeSettings.EnablePrivateKey2 == false)
                {
                    privateKeyCheck2.Checked = false;
                }

            }
            if (appConfig.PrivateKeyModeSettings.EnablePrivateKey1 == false)
            {
                privateKeyCheck1.Checked = false;
            }

            privateKeyBox1.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox1;
            privateKeyBox2.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox2;
            privateKeyBox3.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox3;
            privateKeyBox4.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox4;
            privateKeyBox5.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox5;
            privateKeyBox6.Text = appConfig.PrivateKeyModeSettings.PrivateKeyBox6;
            if (appConfig.WorkingModeSettings.SeedMode == true && appConfig.WorkingModeSettings.PrivateKeyMode == false)
            {
                privateKeyMode.Checked = false;

                seedMode.Checked = true;
            }
            if (appConfig.WorkingModeSettings.SeedMode == false && appConfig.WorkingModeSettings.PrivateKeyMode == true)
            {
                seedMode.Checked = false;

                privateKeyMode.Checked = true;
            }
            if (appConfig.WorkingModeSettings.SeedMode == true && appConfig.WorkingModeSettings.PrivateKeyMode == true)
            {
                privateKeyMode.Checked = false;
                seedMode.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "'PrivateKeyMode' And 'SeedMode' Parameters Cannot Be 'true' Both.");
            }
            if (appConfig.WorkingModeSettings.SeedMode == false && appConfig.WorkingModeSettings.PrivateKeyMode == false)
            {
                privateKeyMode.Checked = false;
                seedMode.Checked = false;
                MessageBox.Show("'PrivateKeyMode' or 'SeedMode' Parameter Must Set To 'true'.");
            }

            //TransferNativeBalanceCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == false)
            {

                transferNativeBalanceCheck.Checked = true;


            }

            //SwapTokenCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == false)
            {
                transferNativeBalanceCheck.Checked = false;
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = true;

            }


            //TransferTokenCheck
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == true)
            {

                transferTokensCheck.Checked = true;
            }

            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferToken' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferToken' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == true)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferToken' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == true && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == true && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == false)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferToken' or 'SwapToken' to 'true'.");
            }
            if (appConfig.WorkingModeSettings.NativeBalanceSettings.TransferNativeBalance == false && appConfig.WorkingModeSettings.TokenSwapSettings.SwapToken == false && appConfig.WorkingModeSettings.TokenTransferSettings.TransferToken == false)
            {
                transferTokensCheck.Checked = false;
                swapTokensCheck.Checked = false;
                transferNativeBalanceCheck.Checked = false;
                MessageBox.Show("Working Mode Settings Cannot Import." + "\n" +
                    "Select One Of Parameters 'TransferNativeBalance' or 'TransferToken' or 'SwapToken' to 'true'.");
            }



        }



        private void enableSwapToken1_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken1.Checked == true)
            {
                swapContract1.Enabled = true;
                swapContract1Label.Enabled = true;
                swapPercentToken1.Enabled = true;
                swapBackNativeToken1.Enabled = true;
                swapPercentToken1Label.Enabled = true;
                enableSwapToken2.Enabled = true;

            }
            if (enableSwapToken1.Checked == false)
            {
                swapContract1.Enabled = false;
                swapContract1Label.Enabled = false;
                swapPercentToken1.Enabled = false;
                swapBackNativeToken1.Enabled = false;
                swapBackNativeToken1.Checked = false;
                swapPercentToken1Label.Enabled = false;
                swapContract2.Enabled = false;
                swapContract2Label.Enabled = false;
                swapPercentToken2.Enabled = false;
                swapBackNativeToken2.Enabled = false;
                swapBackNativeToken2.Checked = false;
                swapPercentToken2Label.Enabled = false;
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken2.Enabled = false;
                enableSwapToken3.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken2.Checked = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;
            }
        }

        private void enableSwapToken2_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken2.Checked == true)
            {
                swapContract2.Enabled = true;
                swapContract2Label.Enabled = true;
                swapPercentToken2.Enabled = true;
                swapBackNativeToken2.Enabled = true;
                swapPercentToken2Label.Enabled = true;
                enableSwapToken3.Enabled = true;

            }
            if (enableSwapToken2.Checked == false)
            {
                swapContract2.Enabled = false;
                swapContract2Label.Enabled = false;
                swapPercentToken2.Enabled = false;
                swapBackNativeToken2.Enabled = false;
                swapBackNativeToken2.Checked = false;
                swapPercentToken2Label.Enabled = false;
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken3.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken3.Checked = false;
                enableSwapToken4.Checked = false;

            }
        }

        private void enableSwapToken3_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken3.Checked == true)
            {
                swapContract3.Enabled = true;
                swapContract3Label.Enabled = true;
                swapPercentToken3.Enabled = true;
                swapBackNativeToken3.Enabled = true;
                swapPercentToken3Label.Enabled = true;
                enableSwapToken4.Enabled = true;

            }
            if (enableSwapToken3.Checked == false)
            {
                swapContract3.Enabled = false;
                swapContract3Label.Enabled = false;
                swapPercentToken3.Enabled = false;
                swapBackNativeToken3.Enabled = false;
                swapBackNativeToken3.Checked = false;
                swapPercentToken3Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
                enableSwapToken4.Enabled = false;
                enableSwapToken4.Checked = false;
            }
        }

        private void enableSwapToken4_CheckedChanged(object sender, EventArgs e)
        {
            if (enableSwapToken4.Checked == true)
            {
                swapContract4.Enabled = true;
                swapContract4Label.Enabled = true;
                swapPercentToken4.Enabled = true;
                swapBackNativeToken4.Enabled = true;
                swapPercentToken4Label.Enabled = true;
            }
            if (enableSwapToken4.Checked == false)
            {
                swapContract4.Enabled = false;
                swapContract4Label.Enabled = false;
                swapPercentToken4.Enabled = false;
                swapBackNativeToken4.Enabled = false;
                swapBackNativeToken4.Checked = false;
                swapPercentToken4Label.Enabled = false;
            }
        }



        private void enableTransferToken1_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken1.Checked == true)
            {
                transferContract1.Enabled = true;
                transferContract1Label.Enabled = true;
                transferPercentToken1.Enabled = true;
                transferPercentToken1Label.Enabled = true;
                enableTransferToken2.Enabled = true;

            }
            if (enableTransferToken1.Checked == false)
            {
                transferContract1.Enabled = false;
                transferContract1Label.Enabled = false;
                transferPercentToken1.Enabled = false;

                transferPercentToken1Label.Enabled = false;
                transferContract2.Enabled = false;
                transferContract2Label.Enabled = false;
                transferPercentToken2.Enabled = false;

                transferPercentToken2Label.Enabled = false;
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;

                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;

                transferPercentToken4Label.Enabled = false;
                enableTransferToken2.Enabled = false;
                enableTransferToken3.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken2.Checked = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken2_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken2.Checked == true)
            {
                transferContract2.Enabled = true;
                transferContract2Label.Enabled = true;
                transferPercentToken2.Enabled = true;
                transferPercentToken2Label.Enabled = true;
                enableTransferToken3.Enabled = true;

            }
            if (enableTransferToken2.Checked == false)
            {
                transferContract2.Enabled = false;
                transferContract2Label.Enabled = false;
                transferPercentToken2.Enabled = false;

                transferPercentToken2Label.Enabled = false;
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;

                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;

                transferPercentToken4Label.Enabled = false;
                enableTransferToken3.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken3.Checked = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken3_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken3.Checked == true)
            {
                transferContract3.Enabled = true;
                transferContract3Label.Enabled = true;
                transferPercentToken3.Enabled = true;
                transferPercentToken3Label.Enabled = true;
                enableTransferToken4.Enabled = true;

            }
            if (enableTransferToken3.Checked == false)
            {
                transferContract3.Enabled = false;
                transferContract3Label.Enabled = false;
                transferPercentToken3.Enabled = false;

                transferPercentToken3Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;

                transferPercentToken4Label.Enabled = false;
                enableTransferToken4.Enabled = false;
                enableTransferToken4.Checked = false;
            }
        }

        private void enableTransferToken4_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTransferToken4.Checked == true)
            {
                transferContract4.Enabled = true;
                transferContract4Label.Enabled = true;
                transferPercentToken4.Enabled = true;

                transferPercentToken4Label.Enabled = true;

            }
            if (enableTransferToken4.Checked == false)
            {
                transferContract4.Enabled = false;
                transferContract4Label.Enabled = false;
                transferPercentToken4.Enabled = false;
                transferPercentToken4Label.Enabled = false;

            }
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine(DateTime.Now + " # start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();


            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            button1.Text = "Stop";
            if (transferNativeBalanceCheck.Checked == true)
            {
                if (nativeBalanceTransferEngine.IsBusy == true)
                {
                    Console.WriteLine("Engine will shutdown at the finish of loop...");
                    button1.Enabled = false;
                    button1.Text = "Stopping";

                }

                if (nativeBalanceTransferEngine.IsBusy == false)
                {
                    Console.Clear();
                    Console.WriteLine("Airdrop Hunter Bot Started");
                    if (seedMode.Checked == true) { Console.WriteLine("Seed Mode Selected"); Console.WriteLine("You Can Work With As Wanted As Accounts"); Console.WriteLine("Seed Mode Loaded With " + privatekeycount + " Accounts."); }
                    if (privateKeyMode.Checked == true) { Console.WriteLine("Private Key Mode Selected"); Console.WriteLine("You Can Work Up To 6 Accounts"); Console.WriteLine("Private Key Mode Loaded With " + privatekeycount + " Accounts."); }
                    for (int i = 0; i < privatekeycount; i++)
                    {
                        Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                    }
                    if (transferNativeBalanceCheck.Checked == true)
                    {
                        Console.WriteLine("Transfer Native Balance Mode Selected"); Console.WriteLine("Bot Will Transfer Native Balance (ETH, BNB, Matic, AVAX etc.) For Loaded Accounts In Order. At Least 2 Accounts Needed. This Process Will Take As Long As The Number Of Loop Count.");
                        transferNativeBalancePercent = Convert.ToInt32(nativeTransferPercent.Text);
                        transferNativeBalanceLoop = Convert.ToInt32(nativeTransferLoop.Text);
                        nativeBalanceTransferEngine.RunWorkerAsync();
                    }

                }
            }
            if (transferTokensCheck.Checked == true)
            {
                if (tokenTransferEngine.IsBusy == true)
                {
                    Console.WriteLine("Engine will shutdown at the finish of loop...");
                    button1.Enabled = false;
                    button1.Text = "Stopping";

                }

                if (tokenTransferEngine.IsBusy == false)
                {
                    Console.Clear();
                    Console.WriteLine("Airdrop Hunter Bot Started");
                    if (seedMode.Checked == true) { Console.WriteLine("Seed Mode Selected"); Console.WriteLine("You Can Work With As Wanted As Accounts"); Console.WriteLine("Seed Mode Loaded With " + privatekeycount + " Accounts."); }
                    if (privateKeyMode.Checked == true) { Console.WriteLine("Private Key Mode Selected"); Console.WriteLine("You Can Work Up To 6 Accounts"); Console.WriteLine("Private Key Mode Loaded With " + privatekeycount + " Accounts."); }
                    for (int i = 0; i < privatekeycount; i++)
                    {
                        Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                    }
                    if (transferTokensCheck.Checked == true) { Console.WriteLine("Transfer Tokens Mode Selected"); Console.WriteLine("Bot Will Transfer Token Balances For Loaded Accounts In Order. At Least 2 Accounts Needed. You Can Define Token Contracts Up To 4. Set Percent Correctly. This Process Will Take As Long As The Number Of Loop Count."); }


                    tokenTransferEngine.RunWorkerAsync();

                }
            }
            if (swapTokensCheck.Checked == true)
            {
                if (tokenSwapEngine.IsBusy == true)
                {
                    Console.WriteLine("Engine will shutdown at the finish of loop...");
                    button1.Enabled = false;
                    button1.Text = "Stopping";

                }

                if (tokenSwapEngine.IsBusy == false)
                {
                    Console.Clear();
                    Console.WriteLine("Airdrop Hunter Bot Started");
                    if (seedMode.Checked == true) { Console.WriteLine("Seed Mode Selected"); Console.WriteLine("You Can Work With As Wanted As Accounts"); Console.WriteLine("Seed Mode Loaded With " + privatekeycount + " Accounts."); }
                    if (privateKeyMode.Checked == true) { Console.WriteLine("Private Key Mode Selected"); Console.WriteLine("You Can Work Up To 6 Accounts"); Console.WriteLine("Private Key Mode Loaded With " + privatekeycount + " Accounts."); }
                    for (int i = 0; i < privatekeycount; i++)
                    {
                        Console.WriteLine("Account index : " + i + " - Address : " + accountaddress[i] + " - Balance : " + accountbalance[i] + " - Private key : " + accountprivatekey[i]);
                    }

                    if (swapTokensCheck.Checked == true) { Console.WriteLine("Swap Tokens Mode Selected"); Console.WriteLine("Bot Will Swap Tokens. You Can Define Token Contracts Up To 4. Set Router Contract, Percent And Slippage Correctly. Router Contract Differs For Every Network. This Process Will Take As Long As The Number Of Loop Count."); }
                    tokenSwapEngine.RunWorkerAsync();
                }
            }


        }
        [Function("balanceOf", "uint256")]
        public class BalanceOfFunction : FunctionMessage
        {
            [Parameter("address", "_owner", 1)]
            public string Owner { get; set; }
        }
        [Function("transfer", "bool")]
        public class TransferFunction : FunctionMessage
        {
            [Parameter("address", "_to", 1)]
            public string To { get; set; }

            [Parameter("uint256", "_value", 2)]
            public BigInteger TokenAmount { get; set; }
        }


        static private string TransferEther(Web3 web3, Account account, string toAddress, decimal amount)
        {
            var TransactionHash = "";
            try
            {
                var res = web3.Eth.GetEtherTransferService()
                                .TransferEtherAndWaitForReceiptAsync(toAddress, amount);
                //Console.WriteLine(toAddress + "amount: " + amount);

                res.Wait();
                var transaction = res.Result;
                TransactionHash = transaction.TransactionHash;
                Console.WriteLine("transaction : {0}", transaction.TransactionHash);
            }
            catch (Exception error)
            {
                Console.WriteLine("error : {0}", error);
            }
            return TransactionHash;
        }

        public static void GetTransactionReceipt(Web3 web3, string transactionHash)
        {

            try
            {
                var GetTransactionReceipt = web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                GetTransactionReceipt.Wait();
                var receipt = GetTransactionReceipt.Result;
                Console.WriteLine("BlockHash : {0}", receipt.BlockHash);
                Console.WriteLine("BlockNumber : {0}", receipt.BlockNumber.Value.ToString());
                //Console.WriteLine("GasUsed : {0}", receipt.GasUsed.Value.ToString());
                //Console.WriteLine("ContractAddress : {0}", receipt.ContractAddress);
                if (receipt.Status.Value == 1)
                {
                    Console.WriteLine("Status : Balance Transferred Successfully.");
                }
                else
                {
                    Console.WriteLine("Status : {0}", receipt.Status.Value.ToString());

                }
                //Console.WriteLine("Logs : {0}", receipt.Logs);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Get contract address failed : {0}", exp.Message);
            }
        }

        static private async Task CheckBalance(Web3 web3, string address)
        {
            var balance = await web3.Eth.GetBalance.SendRequestAsync(address);
            var etherAmount = Web3.Convert.FromWei(balance.Value);
            Console.WriteLine(address + ": " + etherAmount + " Ether");

        }

        private void nativeBalanceTransferEngine_DoWork(object sender, DoWorkEventArgs e)
        {
            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            for (int loop = 0; loop < Convert.ToInt32(appConfig.WorkingModeSettings.NativeBalanceSettings.NativeTransferLoop); loop++)
            {
                if (button1.Text == "Stopping")
                {
                    button1.Text = "Start";
                    button1.Enabled = true;
                    break;

                }
                for (int i = 0; i < privatekeycount; i++)
                {
                    if (button1.Text == "Stopping")
                    {
                        button1.Text = "Start";
                        button1.Enabled = true;
                        break;
                    }

                    var account = new Account(accountprivatekey[i]);
                    rpc = rpcURL.Text;
                    var web3 = new Web3(account, rpc);


                    if (i + 1 == privatekeycount)
                    {
                        // Check balance
                        //CheckBalance(web3, accountaddress[0]).Wait();
                        // Transfer ether from account to 0xa2271e783f3D469e94C4bFc099E8d7913cD99612
                        Console.WriteLine("\n" + "Balance Transfering Account " + i + " to Account 0");
                        var TransactionHash = TransferEther(web3, account, accountaddress[0], Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100);
                        // check the status of transaction
                        GetTransactionReceipt(web3, TransactionHash);
                        accountbalance[0] = (Convert.ToDecimal(accountbalance[0]) + Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        accountbalance[i] = (Convert.ToDecimal(accountbalance[i]) - Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        for (int b = 0; b < accountaddress.Length; b++)
                        {
                            if (accountaddress[b] == null)
                            {
                                break;
                            }
                            Console.WriteLine("Account " + (b) + " Balance: " + accountbalance[b]);

                        }
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                    }
                    else
                    {
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                        // Transfer ether from account to 0xa2271e783f3D469e94C4bFc099E8d7913cD99612
                        Console.WriteLine("\n" + "Balance Transfering Account " + i + " to Account " + (i + 1));
                        var TransactionHash = TransferEther(web3, account, accountaddress[i + 1], Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100);
                        // check the status of transaction
                        GetTransactionReceipt(web3, TransactionHash);
                        // Check balance
                        //CheckBalance(web3, accountaddress[i + 1]).Wait();
                        accountbalance[i + 1] = (Convert.ToDecimal(accountbalance[i + 1]) + Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        accountbalance[i] = (Convert.ToDecimal(accountbalance[i]) - Convert.ToDecimal(accountbalance[i]) * transferNativeBalancePercent / 100).ToString();
                        for (int b = 0; b < accountaddress.Length; b++)
                        {
                            if (accountaddress[b] == null)
                            {
                                break;
                            }
                            Console.WriteLine("Account " + (b) + " Balance: " + accountbalance[b]);

                        }
                    }

                    wait(Convert.ToInt32(nativeTransferCooldown.Text) * 1000);


                }
            }
            button1.Text = "Start";

        }
        private async void tokenTransferEngine_DoWork(object sender, DoWorkEventArgs e)
        {


            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            int contractCount = 0;
            int loopcount = Convert.ToInt32(transferTokenLoopCount.Text);
            if (enableTransferToken1.Enabled == true)
            {
                contractCount = 1;
                if (enableTransferToken2.Enabled == true)
                {
                    contractCount = 2;
                    if (enableTransferToken3.Enabled == true)
                    {
                        contractCount = 3;
                        if (enableTransferToken4.Enabled == true)
                        {
                            contractCount = 4;

                        }
                    }
                }
            }

            string contract = "";
            string trasferpercent = "100";

            for (int loop = 0; loop < loopcount; loop++)
            {
                for (int contractloop = 0; contractloop < contractCount; contractloop++)
                {

                    if (button1.Text == "Stopping")
                    {
                        button1.Text = "Start";
                        button1.Enabled = true;
                        break;

                    }

                    if (contractloop == 0)
                    {
                        contract = transferContract1.Text;
                        trasferpercent = transferPercentToken1.Text;
                    }
                    if (contractloop == 1)
                    {
                        contract = transferContract2.Text;
                        trasferpercent = transferPercentToken2.Text;


                    }
                    if (contractloop == 2)
                    {
                        contract = transferContract3.Text;
                        trasferpercent = transferPercentToken3.Text;


                    }
                    if (contractloop == 3)
                    {
                        contract = transferContract4.Text;
                        trasferpercent = transferPercentToken4.Text;


                    }


                    for (int i = 0; i < privatekeycount; i++)
                    {
                        if (button1.Text == "Stopping")
                        {
                            button1.Text = "Start";
                            button1.Enabled = true;
                            break;
                        }
                        var account = new Account(accountprivatekey[i]);
                        rpc = rpcURL.Text;
                        var web3 = new Web3(account, rpc);






                        if (i + 1 == privatekeycount)
                        {

                            Console.WriteLine("\n" + "Token Balance Transfering Account " + i + " to Account 0");

                            var balanceOfSender = new BalanceOfFunction()
                            {
                                Owner = account.Address,
                            };

                            var balanceSenderHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                            var balanceSender = await balanceSenderHandler.QueryAsync<BigInteger>(contract, balanceOfSender);
                            Console.WriteLine("Account " + i + " Token Balance: " + balanceSender);
                            var receiverAddress = accountaddress[0];
                            var transferHandler = web3.Eth.GetContractTransactionHandler<TransferFunction>();
                            int balance = Convert.ToInt32(balanceSender) * Convert.ToInt32(trasferpercent) / 100;
                            var transfer = new TransferFunction()
                            {
                                To = receiverAddress,
                                TokenAmount = balance
                            };
                            var transactionReceipt = await transferHandler.SendRequestAndWaitForReceiptAsync(contract, transfer);


                            var balanceOfReceiver = new BalanceOfFunction()
                            {
                                Owner = accountaddress[0],
                            };

                            var balanceReceiverHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                            var balanceReceiver = await balanceReceiverHandler.QueryAsync<BigInteger>(contract, balanceOfReceiver);
                            Console.WriteLine("Transaction is Successful " + transactionReceipt + "Account 0 Token Balance: " + balanceReceiver);

                        }
                        else
                        {

                            Console.WriteLine("\n" + "Token Balance Transfering Account " + i + " to Account " + (i + 1));

                            var balanceOfSender = new BalanceOfFunction()
                            {
                                Owner = account.Address,
                            };

                            var balanceSenderHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                            var balanceSender = await balanceSenderHandler.QueryAsync<BigInteger>(contract, balanceOfSender);
                            Console.WriteLine("Account " + i + " Token Balance: " + balanceSender);
                            var receiverAddress = accountaddress[i + 1];
                            var transferHandler = web3.Eth.GetContractTransactionHandler<TransferFunction>();
                            int balance = Convert.ToInt32(balanceSender) * Convert.ToInt32(trasferpercent) / 100;
                            var transfer = new TransferFunction()
                            {
                                To = receiverAddress,
                                TokenAmount = balance
                            };
                            var transactionReceipt = await transferHandler.SendRequestAndWaitForReceiptAsync(contract, transfer);


                            var balanceOfReceiver = new BalanceOfFunction()
                            {
                                Owner = accountaddress[i + 1],
                            };

                            var balanceReceiverHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                            var balanceReceiver = await balanceReceiverHandler.QueryAsync<BigInteger>(contract, balanceOfReceiver);
                            Console.WriteLine("Transaction is Successful " + transactionReceipt + "Account " + (i + 1) + " Token Balance: " + balanceReceiver);
                        }

                        wait(Convert.ToInt32(tokenTransferCooldown.Text) * 1000);

                    }
                }

            }


            button1.Text = "Start";



        }


        public async Task swapUniswapV2(Web3 web3, string _accountAddress, string _routerAddress, string _nativePairContract, string _swapTokenContract, BigInteger _swapAmount)
        {
            var myAddress = _accountAddress;
            var routerV2Address = _routerAddress;
            var uniswapV2Router02Service = new UniswapV2Router02Service(web3, routerV2Address);
            var nativePair = _nativePairContract;
            var targetPair = _swapTokenContract;
            var swapTargetService = new Nethereum.StandardTokenEIP20.StandardTokenService(web3, targetPair);

            var path = new List<string> { nativePair, targetPair };
            var amountEth = Web3.Convert.ToWei(_swapAmount);

            var amounts = await uniswapV2Router02Service.GetAmountsOutQueryAsync(amountEth, path);

            var deadline = DateTimeOffset.Now.AddMinutes(15).ToUnixTimeSeconds();

            var swapEthForExactTokens = new Nethereum.Uniswap.Contracts.UniswapV2Router02.ContractDefinition.SwapExactETHForTokensFunction()
            {
                AmountOutMin = amounts[1],
                Path = path,
                Deadline = deadline,
                To = myAddress,
                AmountToSend = amountEth
            };

            var balanceOriginal = await swapTargetService.BalanceOfQueryAsync(myAddress);


            var swapReceipt = await uniswapV2Router02Service.SwapExactETHForTokensRequestAndWaitForReceiptAsync(swapEthForExactTokens);
            var swapLog = swapReceipt.Logs.DecodeAllEvents<SwapEventDTO>();
            var transferLog = swapReceipt.Logs.DecodeAllEvents<TransferEventDTO>();

            var balanceNew = await swapTargetService.BalanceOfQueryAsync(myAddress);

            Assert.Equals(swapLog[0].Event.Amount0Out, balanceNew - balanceOriginal);

        }





        private async void tokenSwapEngine_DoWork(object sender, DoWorkEventArgs e)
        {
            Config appConfig = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@Path.GetDirectoryName(Application.ExecutablePath) + "\\" + settingsName.Text + ".json"));
            int contractCount = 0;
            int loopcount = Convert.ToInt32(swapTokenLoopCount.Text);
            if (enableSwapToken1.Enabled == true)
            {
                contractCount = 1;
                if (enableSwapToken2.Enabled == true)
                {
                    contractCount = 2;
                    if (enableSwapToken3.Enabled == true)
                    {
                        contractCount = 3;
                        if (enableSwapToken4.Enabled == true)
                        {
                            contractCount = 4;

                        }
                    }
                }
            }

            string contract = "";
            string swappercent = "100";


            for (int loop = 0; loop < loopcount; loop++)
            {
                for (int contractloop = 0; contractloop < contractCount; contractloop++)
                {

                    if (button1.Text == "Stopping")
                    {
                        button1.Text = "Start";
                        button1.Enabled = true;
                        break;

                    }

                    if (contractloop == 0)
                    {
                        contract = swapContract1.Text;
                        swappercent = swapPercentToken1.Text;
                    }
                    if (contractloop == 1)
                    {
                        contract = swapContract2.Text;
                        swappercent = swapPercentToken2.Text;


                    }
                    if (contractloop == 2)
                    {
                        contract = swapContract3.Text;
                        swappercent = swapPercentToken3.Text;


                    }
                    if (contractloop == 3)
                    {
                        contract = swapContract4.Text;
                        swappercent = swapPercentToken4.Text;


                    }

                    for (int i = 0; i < privatekeycount; i++)
                    {
                        if (button1.Text == "Stopping")
                        {
                            button1.Text = "Start";
                            button1.Enabled = true;
                            break;
                        }
                        var account = new Account(accountprivatekey[i]);
                        rpc = rpcURL.Text;
                        var web3 = new Web3(account, rpc);
                        var balanceOfSender = new BalanceOfFunction()
                        {
                            Owner = account.Address,
                        };

                        var balanceSenderHandler = web3.Eth.GetContractQueryHandler<BalanceOfFunction>();
                        var balanceSender = await balanceSenderHandler.QueryAsync<BigInteger>(contract, balanceOfSender);

                        await swapUniswapV2(web3, account.Address, routerContractBox.Text, nativePairContract.Text, contract, balanceSender);

                        if (swapBackNativeToken1.Checked == true)
                        {
                            await swapUniswapV2(web3, account.Address, routerContractBox.Text, contract, nativePairContract.Text, balanceSender);

                        }

                        Console.WriteLine("\n" + "Token Swap Completed");
                        wait(Convert.ToInt32(tokenSwapCooldown.Text) * 1000);

                    }



                }

            }


            button1.Text = "Start";


        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(settingsName.Text + ".json"))
            {
                File.Delete(settingsName.Text + ".json");
            }



            string _seedmode = "false";
            if (seedMode.Checked == true)
            {
                _seedmode = "true";
            }
            string _transfernativebalance = "false";
            if (transferNativeBalanceCheck.Checked == true)
            {
                _transfernativebalance = "true";
            }
            string _tokentransfer = "false";
            if (transferTokensCheck.Checked == true)
            {
                _tokentransfer = "true";
            }
            string _transferenabletoken1 = "false";
            if (enableTransferToken1.Checked == true)
            {
                _transferenabletoken1 = "true";
            }
            string _transferenabletoken2 = "false";
            if (enableTransferToken2.Checked == true)
            {
                _transferenabletoken2 = "true";
            }
            string _transferenabletoken3 = "false";
            if (enableTransferToken3.Checked == true)
            {
                _transferenabletoken3 = "true";
            }
            string _transferenabletoken4 = "false";
            if (enableTransferToken4.Checked == true)
            {
                _transferenabletoken4 = "true";
            }
            string _tokenswap = "false";
            if (swapTokensCheck.Checked == true)
            {
                _tokenswap = "true";
            }
            string _swapenabletoken1 = "false";
            if (enableSwapToken1.Checked == true)
            {
                _swapenabletoken1 = "true";
            }
            string _swapenabletoken2 = "false";
            if (enableSwapToken2.Checked == true)
            {
                _swapenabletoken2 = "true";
            }
            string _swapenabletoken3 = "false";
            if (enableSwapToken3.Checked == true)
            {
                _swapenabletoken3 = "true";
            }
            string _swapenabletoken4 = "false";
            if (enableSwapToken4.Checked == true)
            {
                _swapenabletoken4 = "true";
            }
            string _swapbackenabletoken1 = "false";
            if (swapBackNativeToken1.Checked == true)
            {
                _swapbackenabletoken1 = "true";
            }
            string _swapbackenabletoken2 = "false";
            if (swapBackNativeToken2.Checked == true)
            {
                _swapbackenabletoken2 = "true";
            }
            string _swapbackenabletoken3 = "false";
            if (swapBackNativeToken3.Checked == true)
            {
                _swapbackenabletoken3 = "true";
            }
            string _swapbackenabletoken4 = "false";
            if (swapBackNativeToken4.Checked == true)
            {
                _swapbackenabletoken4 = "true";
            }
            string _privatekeymode = "false";
            if (privateKeyMode.Checked == true)
            {
                _privatekeymode = "true";
            }
            string _enableprivatekey1 = "false";
            if (privateKeyCheck1.Checked == true)
            {
                _enableprivatekey1 = "true";
            }
            string _enableprivatekey2 = "false";
            if (privateKeyCheck2.Checked == true)
            {
                _enableprivatekey2 = "true";
            }
            string _enableprivatekey3 = "false";
            if (privateKeyCheck3.Checked == true)
            {
                _enableprivatekey3 = "true";
            }
            string _enableprivatekey4 = "false";
            if (privateKeyCheck4.Checked == true)
            {
                _enableprivatekey4 = "true";
            }
            string _enableprivatekey5 = "false";
            if (privateKeyCheck5.Checked == true)
            {
                _enableprivatekey5 = "true";
            }
            string _enableprivatekey6 = "false";
            if (privateKeyCheck6.Checked == true)
            {
                _enableprivatekey6 = "true";
            }



            FileStream fs = new FileStream(settingsName.Text + ".json", FileMode.Append);
            TextWriter sw = new StreamWriter(fs);
            sw.WriteLine(
                "{" + "\n" +
                "    \"General\": {" + "\n" +
                "    \"SettingsName\": \"" + settingsName.Text + "\"," + "\n" +
                "    \"RPC\": \"" + rpcURL.Text + "\"" + "\n" +
                "  }," + "\n" +
                "  \"WorkingModeSettings\": {" + "\n" +
                "    \"PrivateKeyMode\": \"" + _privatekeymode + "\"," + "\n" +
                "    \"SeedMode\": \"" + _seedmode + "\"," + "\n" +
                "    \"NativeBalanceSettings\": {" + "\n" +
                "      \"TransferNativeBalance\": \"" + _transfernativebalance + "\"," + "\n" +
                "      \"NativeTransferPercent\": \"" + nativeTransferPercent.Text + "\"," + "\n" +
                "      \"NativeTransferCooldown\": \"" + nativeTransferCooldown.Text + "\"," + "\n" +
                "      \"NativeTransferLoop\": \"" + nativeTransferLoop.Text + "\"" + "\n" +
                "    }," + "\n" +
                "    \"TokenTransferSettings\": {" + "\n" +
                "      \"TransferToken\": \"" + _tokentransfer + "\"," + "\n" +
                "      \"EnableToken1\": \"" + _transferenabletoken1 + "\"," + "\n" +
                "      \"TokenContract1\": \"" + transferContract1.Text + "\"," + "\n" +
                "      \"Token1TransferPercent\": \"" + transferPercentToken1.Text + "\"," + "\n" +
                "      \"EnableToken2\": \"" + _transferenabletoken2 + "\"," + "\n" +
                "      \"TokenContract2\": \"" + transferContract2.Text + "\"," + "\n" +
                "      \"Token2TransferPercent\": \"" + transferPercentToken2.Text + "\"," + "\n" +
                "      \"EnableToken3\": \"" + _transferenabletoken3 + "\"," + "\n" +
                "      \"TokenContract3\": \"" + transferContract3.Text + "\"," + "\n" +
                "      \"Token3TransferPercent\": \"" + transferPercentToken3.Text + "\"," + "\n" +
                "      \"EnableToken4\": \"" + _transferenabletoken4 + "\"," + "\n" +
                "      \"TokenContract4\": \"" + transferContract4.Text + "\"," + "\n" +
                "      \"Token4TransferPercent\": \"" + transferPercentToken4.Text + "\"," + "\n" +
                "      \"TokenTransferCooldown\": \"" + tokenTransferCooldown.Text + "\"," + "\n" +
                "      \"TransferTokenLoopCount\": \"" + transferTokenLoopCount.Text + "\"" + "\n" +
                "    }," + "\n" +
                "    \"TokenSwapSettings\": {" + "\n" +
                "      \"SwapToken\": \"" + _tokenswap + "\"," + "\n" +
                "      \"RouterContract\": \"" + routerContractBox.Text + "\"," + "\n" +
                "      \"NativeTokenContract\": \"" + nativePairContract.Text + "\"," + "\n" +
                "      \"SlippagePercent\": \"" + swapTokenSlippage.Text + "\"," + "\n" +
                "      \"SwapTokenLoopCount\": \"" + swapTokenLoopCount.Text + "\"," + "\n" +
                "      \"EnableToken1\": \"" + _swapenabletoken1 + "\"," + "\n" +
                "      \"TokenContract1\": \"" + swapContract1.Text + "\"," + "\n" +
                "      \"Token1SwapPercent\": \"" + swapPercentToken1.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken1\": \"" + _swapbackenabletoken1 + "\"," + "\n" +
                "      \"EnableToken2\": \"" + _swapenabletoken2 + "\"," + "\n" +
                "      \"TokenContract2\": \"" + swapContract2.Text + "\"," + "\n" +
                "      \"Token2SwapPercent\": \"" + swapPercentToken2.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken2\": \"" + _swapbackenabletoken2 + "\"," + "\n" +
                "      \"EnableToken3\": \"" + _swapenabletoken3 + "\"," + "\n" +
                "      \"TokenContract3\": \"" + swapContract3.Text + "\"," + "\n" +
                "      \"Token3SwapPercent\": \"" + swapPercentToken3.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken3\": \"" + _swapbackenabletoken3 + "\"," + "\n" +
                "      \"EnableToken4\": \"" + _swapenabletoken4 + "\"," + "\n" +
                "      \"TokenContract4\": \"" + swapContract4.Text + "\"," + "\n" +
                "      \"Token4SwapPercent\": \"" + swapPercentToken4.Text + "\"," + "\n" +
                "      \"TokenSwapCooldown\": \"" + tokenSwapCooldown.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken4\": \"" + _swapbackenabletoken4 + "\"" + "\n" +
                "    }" + "\n" +
                "  }," + "\n" +
                "  \"PrivateKeyModeSettings\": {" + "\n" +
                "    \"EnablePrivateKey1\": \"" + _enableprivatekey1 + "\"," + "\n" +
                "    \"PrivateKeyBox1\": \"" + privateKeyBox1.Text + "\"," + "\n" +
                "    \"EnablePrivateKey2\": \"" + _enableprivatekey2 + "\"," + "\n" +
                "    \"PrivateKeyBox2\": \"" + privateKeyBox2.Text + "\"," + "\n" +
                "    \"EnablePrivateKey3\": \"" + _enableprivatekey3 + "\"," + "\n" +
                "    \"PrivateKeyBox3\": \"" + privateKeyBox3.Text + "\"," + "\n" +
                "    \"EnablePrivateKey4\": \"" + _enableprivatekey4 + "\"," + "\n" +
                "    \"PrivateKeyBox4\": \"" + privateKeyBox4.Text + "\"," + "\n" +
                "    \"EnablePrivateKey5\": \"" + _enableprivatekey5 + "\"," + "\n" +
                "    \"PrivateKeyBox5\": \"" + privateKeyBox5.Text + "\"," + "\n" +
                "    \"EnablePrivateKey6\": \"" + _enableprivatekey6 + "\"," + "\n" +
                "    \"PrivateKeyBox6\": \"" + privateKeyBox6.Text + "\"" + "\n" +
                "  }," + "\n" +
                "  \"SeedModeSettings\": {" + "\n" +
                "    \"Seed\": \"" + seedPhrase.Text + "\"," + "\n" +
                "    \"ExtraWord\": \"" + extraWord.Text + "\"," + "\n" +
                "    \"AccountCount\": \"" + accountCount.Text + "\"" + "\n" +
                "  }" + "\n" +
                "}");
            sw.Close();

            Console.WriteLine(
                "{" + "\n" +
                "    \"SettingsName\": \"" + settingsName.Text + "\"," + "\n" +
                "    \"RPC\": \"" + rpcURL.Text + "\"" + "\n" +
                "  }," + "\n" +
                "  \"WorkingModeSettings\": {" + "\n" +
                "    \"PrivateKeyMode\": \"" + _privatekeymode + "\"," + "\n" +
                "    \"SeedMode\": \"" + _seedmode + "\"," + "\n" +
                "    \"NativeBalanceSettings\": {" + "\n" +
                "      \"TransferNativeBalance\": \"" + _transfernativebalance + "\"," + "\n" +
                "      \"NativeTransferPercent\": \"" + nativeTransferPercent.Text + "\"," + "\n" +
                "      \"NativeTransferCooldown\": \"" + nativeTransferCooldown.Text + "\"," + "\n" +
                "      \"NativeTransferLoop\": \"" + nativeTransferLoop.Text + "\"" + "\n" +
                "    }," + "\n" +
                "    \"TokenTransferSettings\": {" + "\n" +
                "      \"TransferToken\": \"" + _tokentransfer + "\"," + "\n" +
                "      \"EnableToken1\": \"" + _transferenabletoken1 + "\"," + "\n" +
                "      \"TokenContract1\": \"" + transferContract1.Text + "\"," + "\n" +
                "      \"Token1TransferPercent\": \"" + transferPercentToken1.Text + "\"," + "\n" +
                "      \"EnableToken2\": \"" + _transferenabletoken2 + "\"," + "\n" +
                "      \"TokenContract2\": \"" + transferContract2.Text + "\"," + "\n" +
                "      \"Token2TransferPercent\": \"" + transferPercentToken2.Text + "\"," + "\n" +
                "      \"EnableToken3\": \"" + _transferenabletoken3 + "\"," + "\n" +
                "      \"TokenContract3\": \"" + transferContract3.Text + "\"," + "\n" +
                "      \"Token3TransferPercent\": \"" + transferPercentToken3.Text + "\"," + "\n" +
                "      \"EnableToken4\": \"" + _transferenabletoken4 + "\"," + "\n" +
                "      \"TokenContract4\": \"" + transferContract4.Text + "\"," + "\n" +
                "      \"Token4TransferPercent\": \"" + transferPercentToken4.Text + "\"," + "\n" +
                "      \"TokenTransferCooldown\": \"" + tokenTransferCooldown.Text + "\"," + "\n" +
                "      \"TransferTokenLoopCount\": \"" + transferTokenLoopCount.Text + "\"" + "\n" +
                "    }," + "\n" +
                "    \"TokenSwapSettings\": {" + "\n" +
                "      \"SwapToken\": \"" + _tokenswap + "\"," + "\n" +
                "      \"RouterContract\": \"" + routerContractBox.Text + "\"," + "\n" +
                "      \"NativeTokenContract\": \"" + nativePairContract.Text + "\"," + "\n" +
                "      \"SlippagePercent\": \"" + swapTokenSlippage.Text + "\"," + "\n" +
                "      \"SwapTokenLoopCount\": \"" + swapTokenLoopCount.Text + "\"," + "\n" +
                "      \"EnableToken1\": \"" + _swapenabletoken1 + "\"," + "\n" +
                "      \"TokenContract1\": \"" + swapContract1.Text + "\"," + "\n" +
                "      \"Token1SwapPercent\": \"" + swapPercentToken1.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken1\": \"" + _swapbackenabletoken1 + "\"," + "\n" +
                "      \"EnableToken2\": \"" + _swapenabletoken2 + "\"," + "\n" +
                "      \"TokenContract2\": \"" + swapContract2.Text + "\"," + "\n" +
                "      \"Token2SwapPercent\": \"" + swapPercentToken2.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken2\": \"" + _swapbackenabletoken2 + "\"," + "\n" +
                "      \"EnableToken3\": \"" + _swapenabletoken3 + "\"," + "\n" +
                "      \"TokenContract3\": \"" + swapContract3.Text + "\"," + "\n" +
                "      \"Token3SwapPercent\": \"" + swapPercentToken3.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken3\": \"" + _swapbackenabletoken3 + "\"," + "\n" +
                "      \"EnableToken4\": \"" + _swapenabletoken4 + "\"," + "\n" +
                "      \"TokenContract4\": \"" + swapContract4.Text + "\"," + "\n" +
                "      \"Token4SwapPercent\": \"" + swapPercentToken4.Text + "\"," + "\n" +
                "      \"TokenSwapCooldown\": \"" + tokenSwapCooldown.Text + "\"," + "\n" +
                "      \"SwapBackERC20ToNativeToken4\": \"" + _swapbackenabletoken4 + "\"" + "\n" +
                "    }" + "\n" +
                "  }," + "\n" +
                "  \"PrivateKeyModeSettings\": {" + "\n" +
                "    \"EnablePrivateKey1\": \"" + _enableprivatekey1 + "\"," + "\n" +
                "    \"PrivateKeyBox1\": \"" + privateKeyBox1.Text + "\"," + "\n" +
                "    \"EnablePrivateKey2\": \"" + _enableprivatekey2 + "\"," + "\n" +
                "    \"PrivateKeyBox2\": \"" + privateKeyBox2.Text + "\"," + "\n" +
                "    \"EnablePrivateKey3\": \"" + _enableprivatekey3 + "\"," + "\n" +
                "    \"PrivateKeyBox3\": \"" + privateKeyBox3.Text + "\"," + "\n" +
                "    \"EnablePrivateKey4\": \"" + _enableprivatekey4 + "\"," + "\n" +
                "    \"PrivateKeyBox4\": \"" + privateKeyBox4.Text + "\"," + "\n" +
                "    \"EnablePrivateKey5\": \"" + _enableprivatekey5 + "\"," + "\n" +
                "    \"PrivateKeyBox5\": \"" + privateKeyBox5.Text + "\"," + "\n" +
                "    \"EnablePrivateKey6\": \"" + _enableprivatekey6 + "\"," + "\n" +
                "    \"PrivateKeyBox6\": \"" + privateKeyBox6.Text + "\"" + "\n" +
                "  }," + "\n" +
                "  \"SeedModeSettings\": {" + "\n" +
                "    \"Seed\": \"" + seedPhrase.Text + "\"," + "\n" +
                "    \"ExtraWord\": \"" + extraWord.Text + "\"," + "\n" +
                "    \"AccountCount\": \"" + accountCount.Text + "\"" + "\n" +
                "  }" + "\n" +
                "}");
            Console.WriteLine("\n Settings Exported..");


        }


    }
}
