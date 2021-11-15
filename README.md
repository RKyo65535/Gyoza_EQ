# Gyoza_EQ
人の声には母音というものがあるそうですね。
ところで、母音の周波数には特定の強勢(フォルマント)が存在するらしいですね。
じゃあ、逆に特定の周波数を強めたら、母音になるんじゃね！？
というわけで、一部の周波数を強化してそれ以外を弱めるアプリケーションを作ってみました。


# 使い方
ファイルを起動します。
そのあと、加工したいwavファイルへのパスを入力します。
その際、拡張子の「.wav」は入力してはいけません。
すると、そのwavファイルがある同一フォルダに、〇〇_A.wavや、〇〇_E.wavなど、計五個のファイルが出力されます。
そのファイルはたぶんその母音っぽく聞こえると思います。

# クレジット表記
## 使用したライブラリ
NAudio( https://github.com/naudio/NAudio )
MITライセンスの元公開されています。
### ライセンス原文

Copyright 2020 Mark Heath

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

# 注意事項
また、まだ1ファイルでしか試してないのでバグ報告使ってみた報告などしていただけると助かります。
