これは制作した音楽ゲームに関するリポジトリです。

タッチセンサから入力された信号がシリアル通信を通じてUnityへと伝わり、ノーツを叩くことができます。

本リポジトリには、私が実装したスクリプトのみを掲載しています。  
使用した音源や3Dモデル等のアセット、mocopiやMMDに関するスクリプトが入ったSDKは外部リソースを利用したため含まれていません。 

上記については下記参考サイトを参考に。

実行する場合は各自で適切なアセットを用意してください。<br><br>

[参考にしたサイト]

[1] 「Unity C# 音ゲーの作り方 初心者でもスマホで遊べる音ゲーが作れる！」

https://3dunity.org/game-create-lesson/music-game/

[2] 「Sonyのモーションキャプチャー「mocopi」をつかってみた（前編）〜Unityで動かすまで」

https://note.com/thedesignium/n/n2c14e47b2acd#b15633df-d6f0-4570-b3e3-1f48be0a91d4

[3] 「[Unity]MMDのモーションをUnityに入れて鑑賞会をしよう」

https://qiita.com/saba383810/items/c55043bdbc47dd4cb6f4

[4] 「mocopiをUnityで使ってみた（Windows10)」

https://tatsuya1970.com/?p=17310

[5] 「UnityとArduinoをシリアル通信」

https://qiita.com/yjiro0403/items/54e9518b5624c0030531 <br><br><br>
[内容]

・没入型音楽ゲーム作成に関するスライド資料.pdf ：12枚あります。

・touch-sensor.ino  ：タッチセンサのファイル（Arduino）

・times.csv         ：設置すべきノーツのz座標はここに表示

・AspectKeeper.cs   ：アスペクト比の設定*<br>
・Changescene.cs    ：Title画面に遷移*<br>
・Combotext.cs      ：コンボ数を数えて画面上のTextMeshProに表示*<br>
・MinusComboSm.cs   ：resetboxにぶつかったらコンボ数をリセットしてノーツを削除*<br>
・Musicboxslide.cs  ：ノーツを一定の速度で手前側（Z方向）に移動*<br>
・Next.cs           ：スコア表示のためにゲーム終了時までパネル非表示*<br>
・NotesBreaking.cs  ：ノーツを叩いてサウンドやスコア加算<br>
・Resourcesblue.cs  ：ノーツをインスタンスで生成（times.csvをもとに上手く調整）<br>
・Resourcesgreen.cs ：ノーツをインスタンスで生成（times.csvをもとに上手く調整）<br>
・Resourcesorange.cs：ノーツをインスタンスで生成（times.csvをもとに上手く調整）<br>
・Resourcespink.cs  ：ノーツをインスタンスで生成（times.csvをもとに上手く調整）<br>
・Scoretext.cs      ：スコアを管理して、その数値をTextMeshProで画面に表示*<br>
・SerialHandler.cs  ：Arduinoからのセンサ値をシリアル通信でUnityに伝達**<br>
・SerialReceiver.cs ：SerialHandlerから受け取ったシリアルデータを整数に変換して格納**<br>
・TimeOutput.cs     ：F/G/H/Jキーを押した時点での経過時間と計算結果（設置すべきノーツのz座標）をtimes.csvに記録<br>
・Title.cs          ：Title画面でタッチセンサからの入力を検知したら効果音を鳴らし、2秒後にゲームシーンへ遷移<br>

\* 主に[1]を参考に音楽ゲームの基盤となるスクリプトを制作したため、構造が似通っています。

\** 主に[5]を参考にシリアル通信の基盤となるスクリプトを制作したため、構造が似通っています。
