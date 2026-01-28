from PySide6 import QtSerialPort
from PySide6.QtCore import QIODevice, QSize, Qt, Slot
from PySide6.QtWidgets import QApplication, QMainWindow, QWidget, QComboBox, QPushButton, QVBoxLayout, QHBoxLayout
from PySide6.QtGui import QFont

class Window(QMainWindow):

    serial = QtSerialPort.QSerialPort()

    def __init__(self):
        super().__init__()

        self.initUI()
        
    def initUI(self):

        # フォント設定（1.2倍のサイズ）
        control_font = QFont()
        control_font.setPointSize(12)  # デフォルトの約1.2倍

        self.connectBtn = QPushButton('connect')
        self.connectBtn.clicked.connect(self.pushBtn)
        self.connectBtn.setMaximumWidth(500)
        self.connectBtn.setMinimumHeight(40)
        self.connectBtn.setFont(control_font)

        self.port_selector = QComboBox()
        self.port_selector.setMaximumWidth(500)
        self.port_selector.setMinimumHeight(40)
        self.port_selector.setFont(control_font)
        self.port_list = QtSerialPort.QSerialPortInfo.availablePorts()
        for each_port in self.port_list:
            self.port_selector.addItem(f'{each_port.portName()}: {each_port.description()}')

        # 6つの送信ボタンを作成
        send_buttons = []
        for i in range(1, 7):
            btn = QPushButton(str(i))
            btn.setMinimumSize(QSize(80, 80))
            font = QFont()
            font.setPointSize(24)
            font.setBold(True)
            btn.setFont(font)
            btn.clicked.connect(lambda _, num=i: self.send_button_clicked(num))
            send_buttons.append(btn)

        # 2段に分けて配置（3列×2行）
        row1_layout = QHBoxLayout()
        for i in range(3):
            row1_layout.addWidget(send_buttons[i])

        row2_layout = QHBoxLayout()
        for i in range(3, 6):
            row2_layout.addWidget(send_buttons[i])

        # メインレイアウトに追加
        main_layout = QVBoxLayout()
        main_layout.addWidget(self.port_selector)
        main_layout.addWidget(self.connectBtn)
        main_layout.addLayout(row1_layout)
        main_layout.addLayout(row2_layout)

        main = QWidget()
        main.setLayout(main_layout)

        self.setCentralWidget(main)
        self.setFixedSize(800, 300)
            
    @Slot()
    def pushBtn(self):
        list_index = self.port_selector.currentIndex()
        self.serial.setPort(self.port_list[list_index])
        self.serial.setBaudRate(QtSerialPort.QSerialPort.Baud9600)
        self.serial.open(QIODevice.WriteOnly)

        self.connectBtn.setEnabled(False)

    @Slot(int)
    def send_button_clicked(self, num):
        if self.serial.isOpen():
            # 数字をバイナリに変換してシリアル送信
            data = num.to_bytes(1, byteorder='big')
            self.serial.write(data)

    def closeEvent(self, e):
       self.serial.close()
       e.accept()
            
if __name__ == "__main__":
    app = QApplication([])
    ex =Window()
    ex.show()
    app.exec()