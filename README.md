# 5x7dotfont2microbit
マイクロビットに5x7フォント文字を送信します。

## Windowsに「pixelfont-5x7.ttf」をインストールしてください。
　pixelfont-5x7.ttfは、ユズノカ様作成の mikannnoki-fontの1つです。以下のサイトよりダウンロードできます。

[https://mikannnoki-font.booth.pm/](https://mikannnoki-font.booth.pm/)

[https://booth.pm/ja/items/1477300](https://booth.pm/ja/items/1477300)

## マイクロビットプログラムは、以下のリポジトリからインポートしてください。
[https://github.com/tarosay/microbit-microbit-airsend](https://github.com/tarosay/microbit-microbit-airsend)

## マイクロビット間の無線通信にも対応しています
　複数のマイクロビットに同じプログラムを入れると、マイクロビット間でシンクロして文字が表示されます。

## PCからの送信データとマイクロビットLEDの5x5点灯の説明
マイクロビットの5x5LEDの点灯パラメータとして、1列ごとに1文字の英数文字を割り付けています。

![5x5LED](https://github.com/tarosay/5x7dotfont2microbit/blob/main/5x5led.png)


列のLEDはビットで設定し、0が全消灯、31が全点灯となります。
この32パターンのビットを32個の英数文字に割り付けています。

{"0":"0", "1":"1", "2":"2", "3":"3", "4":"4", "5":"5", "6":"6", "7":"7",

 "8":"8", "9":"9","10":"a","11":"b","12":"c","13":"d","14":"e","15":"f",

"16":"g","17":"h","18":"i","19":"j","20":"k","21":"l","22":"m","23":"n",

"24":"o","25":"p","26":"q","27":"r","28":"s","29":"t","30":"u","31":"v"}


例えば、「マ」という文字は、"1599lj0"という文字列を、5文字ずつ送信します。

![マ](https://github.com/tarosay/5x7dotfont2microbit/blob/main/ma.png)

1599l → 送信

599lj → 送信

99lj0 → 送信

こんな感じです。

