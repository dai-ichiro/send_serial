using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort = null;

        public Form1()
        {
            InitializeComponent();
            LoadAvailablePorts();
        }

        /// <summary>
        /// 利用可能なシリアルポート一覧をComboBoxに読み込みます
        /// </summary>
        private void LoadAvailablePorts()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                portSelector.Items.Clear();

                foreach (string port in ports)
                {
                    portSelector.Items.Add(port);
                }

                // 最初のポートを選択
                if (portSelector.Items.Count > 0)
                {
                    portSelector.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ポート一覧の取得に失敗しました: {ex.Message}", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 接続ボタンのクリックイベントハンドラ
        /// </summary>
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (portSelector.SelectedItem == null)
                {
                    MessageBox.Show("ポートを選択してください", "警告",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedPort = portSelector.SelectedItem.ToString();

                // SerialPortインスタンスの作成と設定
                serialPort = new SerialPort(selectedPort);
                serialPort.BaudRate = 9600;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Parity = Parity.None;

                // ポートを開く
                serialPort.Open();

                // 接続ボタンを無効化
                connectBtn.Enabled = false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ポートは既に使用されています", "接続エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort = null;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show($"ポートが見つかりません: {ex.Message}", "接続エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"接続エラー: {ex.Message}", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                serialPort = null;
            }
        }

        /// <summary>
        /// 送信ボタンのクリックイベントハンドラ
        /// </summary>
        private void sendButton_Click(object sender, EventArgs e)
        {
            // ボタンのTextから数値を取得
            Button btn = (Button)sender;
            if (!int.TryParse(btn.Text, out int number))
            {
                return;
            }

            // シリアルポートが開いているか確認
            if (serialPort != null && serialPort.IsOpen)
            {
                try
                {
                    // 1バイトのバイナリデータとして送信
                    byte[] data = new byte[] { (byte)number };
                    serialPort.Write(data, 0, 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"送信エラー: {ex.Message}", "エラー",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// フォームクローズイベントハンドラ - ポートのクローズとリソース解放
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    try
                    {
                        serialPort.Close();
                    }
                    catch { }
                }
                serialPort.Dispose();
                serialPort = null;
            }

            base.OnFormClosing(e);
        }
    }
}
