# TrelloWriterCS 
業務用アプリその２　身内用。  

◆概要◆  
特定形式のCSVファイルを読み込み、Trello認証後、  
参加中のボード・リスト情報を取得します。  
同ディレクトリに格納したファイルを読み込み、カードとして一括起票します。  
コードを読めば大体はわかると思いますが、汎用性はありません。  
  
基本的に動けばいいレベルのものなので  
リファクタを行う予定はありません  
  
  
◆前提条件◆  
schedule.csv  
1-4行目はヘッダー行、汎用的に考えるなら空行でもよい。  
ここにはデータが入る便宜上ヘッダとして処理を飛ばす。   
5行目以降にデータ行（フォーマット、カラムの並びはコード参照）
現場名が同じかつ作業内容が異なる行は同じ現場名として1カードに集約され登録されます。  
ただし、一部末端処理がうまくいかない場合があります（同一現場判定を次回ループ冒頭で行う）  
最終行近辺の現場名・作業内容のカードは登録漏れが生じる恐れがあります。  
そのうち直すかもしれませんが、今の所軽微なのでそのままです。  
  
devInfo.csv（大文字小文字注意。完全一致のみ受付）  
ファイルがないと起動できません。氏名,APIキー（32文字）,トークン（64文字）で構成。  
トレロに起票するためには上記2点が必要です。  
StreamReaderはSJISで読み込むようusingしていないので、UTF-8で保存してください。  
SJISだと名前が文字化けします。（APIキーとトークンは半角英数なので関係ありません）  
文字化け、気になる方だけUTF-8で保存してください。複数行登録できますが悪用厳禁。  
基本的に1ユーザ1アカウントの使用を想定しています。  
  
listInfo.csv  
コード上には定数として存在しますが、  
リスト情報は認証後に自動で取得（ボード毎に自動入替実施）するので  
このファイルは不要です。  
  
◆その他◆  
他の企業内で使用するのは問題ありませんが、営利目的はご遠慮ください。  
それに伴い生じた損害については一切責任を負いかねます。  
自己責任でご利用ください。  

2021.8.4 梨莉 
  
