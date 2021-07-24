using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using TrelloNet;

namespace TrelloWriterCS
{
    public partial class Form1 : Form
    {
        // 定数 デスクトップパス
        public string DESKTOP_PATH = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        // 定数 読込ファイル形式指定 CSV形式ファイル(*.csv)|*.csv
        public const string FILE_FORMAT_CSV = "CSV形式ファイル(*.csv)|*.csv";
        // 定数 読込ファイル形式指定 インデックス (1のみ)
        public const int FILE_FORMAT_INDEX = 1;
        // 定数 コモンダイアログ タイトル「CSVファイルを選択してください」
        public const string DIALOG_TITLE_CSV = "CSVファイルを選択してください";
        // 定数 コモンダイアログ デフォルトファイル名 (とりあえず空欄)
        public const string DIALOG_DEFAULT_FILE_NAME = "";

        // 定数 デリミタ ','
        public const char FILE_DELIMITER_CONMA = ',';
        // 定数 デリミタ '\'
        public const char FILE_DELIMITER_DOLLER = '\\';
        // 定数 メッセージ内改行コード \n
        public const string NEW_LINE_CHAR = "\n";
        // 定数 コロン
        public const string COLON = " : ";

        // 定数 開発者情報ファイル 1行あたりの要素数
        public const int FILE_FORMAT_LINE_LENGTH_DEV_INFO = 3;
        // 定数 各種ファイル 1行あたりの要素数を指定しない (0)
        public const int FILE_FORMAT_LINE_LENGTH_FREE = 0;

        // アプリケーションの実行ディレクトリ
        public string APP_CURRENT_DIR = Directory.GetCurrentDirectory();

        // ファイル名 開発者情報ファイル (JP)
        public const string FILE_NAME_DEV_INFO_JP = "開発者情報";
        // ファイル名 開発者情報ファイル (EN) 初期値 devInfo.csv (将来的には設定ファイルを外部化するが、当面はハードコーディング)
        public const string FILE_NAME_DEV_INFO_EN = "devInfo.csv";
        // ファイル名 ボード情報ファイル (JP)
        public const string FILE_NAME_BOARD_INFO_JP = "ボード情報";
        // ファイル名 ボード情報ファイル (EN) 初期値 boardInfo.csv (同上)
        public const string FILE_NAME_BOARD_INFO_EN = "boardInfo.csv";
        // ファイル名 リスト情報ファイル (JP)
        public const string FILE_NAME_LIST_INFO_JP = "リスト情報";
        // ファイル名 リスト情報ファイル (EN) 初期値 listInfo.csv
        public const string FILE_NAME_LIST_INFO_EN = "listInfo.csv";

        // エラータイトル ファイル存在チェックエラー
        public const string ERROR_TITLE_FILE_NOT_EXIST = "存在チェックエラー";
        // エラータイトル ファイルサイズチェックエラー
        public const string ERROR_TITLE_FILE_SIZE_EMPTY = "サイズチェックエラー";
        // エラータイトル ユーザ認証エラー
        public const string ERROR_TITLE_USER_AUTH_FAILURE = "ユーザ認証エラー";
        // エラータイトル ボード検索エラー
        public const string ERROR_TITLE_JOINING_BOARD_NOT_FOUND = "ボード検索エラー";
        // 確認タイトル 確認
        public const string TITLE_VERIFICATION = "確認";
        // ヘルプタイトル バージョン情報
        public const string TITLE_VERSION_INFO = "バージョン情報";

        // ラベル 氏名
        public const string LABEL_NAME = "氏名";
        // ラベル 登録先ボード
        public const string LABEL_BOARD_FORWARD = "登録先ボード";
        // ラベル 登録先リスト
        public const string LABEL_LIST_FORWARD = "登録先リスト";

        // エラーメッセージ ファイルがみつかりません
        public const string ERROR_MSG_FILE_NOT_FOUND = "ファイルがみつかりません。\n実行ディレクトリに格納してから起動しなおしてください。";
        // エラーメッセージ ファイルが空です
        public const string ERROR_MSG_FILE_SIZE_EMPTY = "ファイルが空です。\nファイルの内容を確認してから起動しなおしてください。";
        // エラーメッセージ ファイルの登録情報が不正です
        public const string ERROR_MSG_FILE_FORMAT_WRONG = "ファイルの登録情報が不正です。\n";
        // エラーメッセージ ユーザ認証に失敗しました
        public const string ERROR_MSG_USER_AUTH_FAILURE = "ユーザ認証に失敗しました。\n開発者情報ファイルの登録内容を再確認してください。";
        // エラーメッセージ 参加中のボードがありません (念の為)
        public const string ERROR_MSG_JOINING_BOARD_NOT_FOUND = "参加中のボード情報が取得できませんでした。\n1つ以上のボードに参加してください。";

        // ヘルプメッセージ 開発者情報ファイル
        public const string HELP_MSG_DEV_INFO_FORMAT = "開発者情報ファイルは\n\n　氏名,キー,トークン\n\nの並びで1行ずつ記入してください。";
        // ヘルプメッセージ ボード情報ファイル
        public const string HELP_MSG_BOARD_INFO_FORMAT = "ボード情報ファイルは\n\n　ボード名,ボードID,リスト1名,リスト1ID,リスト2名,リスト2ID... の並びで\n\nボード毎に1行ずつ記入して下さい。";
        // ヘルプメッセージ ファイル再取り込み
        public const string HELP_MSG_FILE_RELOAD = "ファイル更新後は メニュー＞設定ファイル再取り込み を実行してください。";

        // インフォメッセージ バージョン情報
        public const string MSG_VERSION_INFO = "TrelloWriterCS ver.β\n\n　製作者：3007\n\n※β版につき予期せぬ動作をする場合があります。\n初回実行前に、必ず取扱説明書を一読ください。\n本アプリ利用におけるいかなる責任も負いかねます。";

        // 確認メッセージ 登録前最終確認
        public const string REG_VERIFICATION_MSG = "下記情報にて、カードを一括登録します。よろしいですか？";


        // 内部保持データ 開発者情報ファイルの中身 UI上 プルダウンに表示するために使う
        Dictionary<int, string[]> FILE_DATA_DEV_INFO;
        // 内部保持データ ボード情報とリスト情報 UI上 各プルダウンに表示するために使う
        Dictionary<string, List<string>> IN_DATA_BOARD_AND_LIST_INFO;
        // 内部保持データ 登録データファイルの中身 バックグラウンドで保持する
        Dictionary<int, string[]> FILE_DATA_MONTHLY_CSV;

        // 内部保持データ Trelloインスタンス
        Trello trello;
        // 内部保持データ 認証後ユーザ情報
        Member myInfo;

        public Form1()
        {
            InitializeComponent();

            // 内部保持データの初期化
            FILE_DATA_DEV_INFO = new Dictionary<int, string[]>();
            IN_DATA_BOARD_AND_LIST_INFO = new Dictionary<string, List<string>>();
            FILE_DATA_MONTHLY_CSV = new Dictionary<int, string[]>();

            // 開発者情報ファイルのチェック処理
            checkFile_DevInfo();
            // 起動直後、認証前は一括登録ボタンを非活性 (認証後に活性)
            this.button_commit.Enabled = false;
            // 起動直後、登録先ボード、リストは非活性
            this.comboBox_boardName.Enabled = false;
            this.comboBox_listName.Enabled = false;

        }

        /// <summary>
        /// 開発者情報ファイルのチェック処理
        /// 
        ///  (1) ファイルの存在チェック
        ///  (2) ファイルサイズチェック
        ///  (2) ファイルの書式チェック
        ///
        /// </summary>
        private void checkFile_DevInfo()
        {
            // 開発者情報ファイルのパス
            string devInfoFilePath = APP_CURRENT_DIR + FILE_DELIMITER_DOLLER + FILE_NAME_DEV_INFO_EN;

            // ★チェック1 ファイルの存在
            if (!File.Exists(devInfoFilePath))
            {
                // エラーダイアログ表示
                MessageBox.Show(
                    FILE_NAME_DEV_INFO_JP + ERROR_MSG_FILE_NOT_FOUND,
                    FILE_NAME_DEV_INFO_JP + ERROR_TITLE_FILE_NOT_EXIST,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                // アプリケーションを終了する
                this.Close();
            }

            // 開発者情報ファイルを取得
            FileInfo fileInfo = new FileInfo(devInfoFilePath);

            // ★チェック2 ファイルサイズ
            if (fileInfo.Length.Equals(0))
            {
                // エラーダイアログ表示
                MessageBox.Show(
                    FILE_NAME_DEV_INFO_JP + ERROR_MSG_FILE_SIZE_EMPTY,
                    FILE_NAME_DEV_INFO_JP + ERROR_TITLE_FILE_SIZE_EMPTY,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                // アプリケーションを終了する
                this.Close();
            }

            // ★チェック3 ファイルフォーマット (中身取得先で項目数チェックを実施)
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (StreamReader reader = new StreamReader(devInfoFilePath, Encoding.GetEncoding("Shift_JIS")))
            {
                // 開発者情報ファイルの中身を取得、1行あたりの要素数は 3 固定
                FILE_DATA_DEV_INFO = readCsvFile(reader, FILE_FORMAT_LINE_LENGTH_DEV_INFO);
            }

            // 開発者情報グループ キーのプルダウンに値を格納
            foreach (KeyValuePair<int, string[]> keyValuePairDevKey in FILE_DATA_DEV_INFO)
            {
                // ファイルから読み込んだ各行の配列要素を取得する
                string[] valList = new string[keyValuePairDevKey.Value.Length];
                valList = keyValuePairDevKey.Value;
                // 開発者情報ファイルの各行1要素目(index=0)を、氏名コンボボックスに1つずつ格納
                this.comboBox_userName.Items.Add(valList.GetValue(0));
                // 開発者情報ファイルの各行2要素目(index=1)を、キーコンボボックスに1つずつ格納
                this.comboBox_devKey.Items.Add(valList.GetValue(1));
                // 開発者情報ファイルの各行3要素目(index=2)を、トークンコンボボックスに1つずつ格納
                this.comboBox_devToken.Items.Add(valList.GetValue(2));
            }
            // 各コンボボックスの初期表示は先頭行
            this.comboBox_userName.SelectedIndex = 0;
            this.comboBox_devKey.SelectedIndex = 0;
            this.comboBox_devToken.SelectedIndex = 0;
            // 各コンボボックスを読み取り専用にする
            this.comboBox_userName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_devKey.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_devToken.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_boardName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox_listName.DropDownStyle = ComboBoxStyle.DropDownList;
            // 各コンボボックス背景色を見やすいよう白にする
            this.comboBox_userName.FlatStyle = FlatStyle.Flat;
            this.comboBox_devKey.FlatStyle = FlatStyle.Flat;
            this.comboBox_devToken.FlatStyle = FlatStyle.Flat;
            this.comboBox_boardName.FlatStyle = FlatStyle.Flat;
            this.comboBox_listName.FlatStyle = FlatStyle.Flat;
        }


        /// <summary>
        /// 氏名コンボボックス操作時のキー・トークン自動切り替え処理
        /// </summary>
        /// 氏名コンボボックスの選択が変更されたとき、
        /// 変更後の氏名に対応するキーとトークンに表示を切り替える動的メソッド。
        /// (キーとトークンは変更の必要がないため常時非活性、名前の変更で表示を切り替える)
        /// デバッグ的な側面を除けばユーザにキーとトークンを知らせる必要は全く無いが、
        /// 将来的に選択中のキーおよびトークンは内部で共通変数にもたせるだけに済ませ、
        /// 画面上からは見えなくさせる可能性もある。
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_userName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択中の氏名の文字列を取得
            string nameVal = this.comboBox_userName.Text;
            // 選択中の氏名のインデックスを取得 (開発者情報からキーとトークンを取得するために使用)
            int nameIndex = this.comboBox_userName.SelectedIndex;

            // 選択中の氏名のコンボボックス内のインデックス = 開発者情報オブジェクトのKEY部
            foreach (KeyValuePair<int, string[]> keyValuePairDevKey in FILE_DATA_DEV_INFO)
            {
                // ファイルから読み込んだ各行の配列要素を取得する
                string[] valList = new string[keyValuePairDevKey.Value.Length];
                valList = keyValuePairDevKey.Value;

                // 開発者情報オブジェクトのKEY部(<int>行数)とコンボボックスのインデックスが合致
                if (keyValuePairDevKey.Key.Equals(nameIndex))
                {
                    // 画面表示のキーに 該当行の2項目目を取得しセット
                    this.comboBox_devKey.Text = (string)valList.GetValue(1);
                    // 画面表示のトークンに 該当行の3項目目を取得しセット
                    this.comboBox_devToken.Text = (string)valList.GetValue(2);
                }
            }
        }

        /// <summary>
        /// 【メニューバー】メニュー＞終了　押下時処理
        /// </summary>
        /// プログラムを終了し、メモリ領域を解放する
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_File_Exit_Click(object sender, EventArgs e)
        {
            // 終了処理を呼び出す
            this.Close();
        }

        /// <summary>
        /// 【共通メソッド】
        /// ファイルを読み込み、StreamReaderオブジェクトを返すメソッド
        /// </summary>
        /// ・読み取りのみ。書き込みは別の共通メソッドで行うこと。
        /// 
        /// 戻り値
        /// 　行番号, 行の配列要素(=string型配列) のDirectory型オブジェクトを返す
        /// 　基本的にこのメソッドはファイルの存在およびサイズチェック後に呼ぶ前提だが、
        /// 　呼び元の後続処理で例外を出さないために、null値が返る実装をしないよう留意する。
        /// 
        /// 例外処理
        /// 　ファイルが存在しない - コモンダイアログでファイル指定後に削除されたなど
        /// 　ファイルが開けない - 読み取り専用など
        /// 　ファイルの中身の書式が指定書式ではない - 指定書式は定数で共通変数化しておくこと
        /// 　
        /// <param name="filename">ファイルの中身(Directoryオブジェクト)</param>
        private Dictionary<int, string[]> readCsvFile(StreamReader reader, int len)
        {

            Dictionary<int, string[]> result = new Dictionary<int, string[]>();

            // 戻り値の行番号指定 (0開始)
            int rownum = 0;

            while (!reader.EndOfStream)
            {
                // 1行読み込み
                string line = reader.ReadLine();
                // 読み込んだ1行をデリミタ毎に分けて配列に格納
                string[] splitWords = line.Split(FILE_DELIMITER_CONMA);
                // 行のデータ格納用、要素数はwhileループで読み込んだ行内に存在する要素数であり可変長
                string[] strVal = new string[splitWords.Length];

                // 行末まで要素を1つずつ取得し、string配列に格納していく
                for (int i=0; i < splitWords.Length; i++)
                {
                    // デリミタで区切った文字列を1要素ずつ抽出し、戻り値のValue部のstring配列に格納
                    // 戻り値は「1行に1配列(内に複数要素)」という構成
                    strVal[i] = (string)splitWords.GetValue(i);
                }
                // 要素数チェック
                checkLineLength(splitWords, len);

                // 戻り値のDirectoryオブジェクトに格納 (行番号, 該当行の要素配列)
                result.Add(rownum, strVal);
                // 行数をインクリメント
                rownum++;
            }
            // 戻り値 Directoryオブジェクト
            return result;
        }

        /// <summary>
        /// 【共通メソッド】
        /// 配列および指定の要素数を渡し、その要素数通りかチェック
        /// </summary>
        /// 　要素数に不備がある場合はダイアログ表示後、アプリを終了させる。
        /// <param name="str"></param>
        private void checkLineLength(string[] str, int len)
        {
            // 長さ0指定でなく、かつ、1行の要素数と合致しない場合
            if (!FILE_FORMAT_LINE_LENGTH_FREE.Equals(len) && !len.Equals(str.Length))
            {
                // エラーダイアログ表示
                MessageBox.Show(
                    FILE_NAME_DEV_INFO_JP + ERROR_MSG_FILE_SIZE_EMPTY,
                    FILE_NAME_DEV_INFO_JP + ERROR_TITLE_FILE_SIZE_EMPTY,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                // アプリケーションを終了する
                this.Close();
            }
        }

        /// <summary>
        /// 【共通メソッド】
        /// CSVファイルを開くコモンダイアログ生成メソッド
        /// </summary>
        /// <returns></returns>
        private OpenFileDialog createOpenFileDialog()
        {
            // インスタンス生成
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // デフォルトのファイル名 (空欄)
            openFileDialog.FileName = DIALOG_DEFAULT_FILE_NAME;
            // デフォルトのフォルダ（C:\Users>デスクトップ）C以外のデスクトップ編成は考慮しない
            openFileDialog.InitialDirectory = DESKTOP_PATH;
            // ファイルの種類 *.csv形式のみ有効
            openFileDialog.Filter = FILE_FORMAT_CSV;
            // ファイルの種類 1番目(csv形式)をデフォルト表示にする
            openFileDialog.FilterIndex = FILE_FORMAT_INDEX;
            // ダイアログのタイトル
            openFileDialog.Title = DIALOG_TITLE_CSV;
            // 現在のディレクトリを復元する
            openFileDialog.RestoreDirectory = true;
            // 存在しないファイルの警告 あり
            openFileDialog.CheckFileExists = true;
            // 存在しないディレクトリの警告 あり
            openFileDialog.CheckPathExists = true;

            // 生成したインスタンスを返す
            return openFileDialog;
        }

        /// <summary>
        /// 終了ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_exit_Click(object sender, EventArgs e)
        {
            // アプリを終了
            this.Close();
        }

        /// <summary>
        /// カード一括登録ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_commit_Click(object sender, EventArgs e)
        {
            // 登録前最終確認ダイアログ - 登録氏名、登録先ボード、リストの最終確認
            var verificationResult
                = MessageBox.Show(
                    REG_VERIFICATION_MSG
                    + NEW_LINE_CHAR + LABEL_NAME          + COLON + this.comboBox_userName.Text
                    + NEW_LINE_CHAR + LABEL_BOARD_FORWARD + COLON + this.comboBox_boardName.Text
                    + NEW_LINE_CHAR + LABEL_LIST_FORWARD  + COLON + this.comboBox_listName.Text,
                    TITLE_VERIFICATION,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

            // DialogResult.Yes以外は登録中断
            if (!6.Equals(verificationResult))
            {
                return;
            }




            // カード一括登録
            // 指定の場所に指定のファイル(月間作業予定csv)が存在する場合のみ、登録を行う
            // 月間作業予定csvに関するチェックを最初に行い、正常な場合のみ登録を行う



        }

        /// <summary>
        /// 認証ボタン押下時処理
        /// </summary>
        /// 選択ユーザに紐づくキーおよびトークンで接続を試行。
        /// 認証に成功した場合、登録先ボード コンボボックスに参加中の全ボードを格納し、活性化。
        /// 認証に失敗した場合、エラーダイアログを表示し、選び直させる。(登録先ボードは非活性のまま)
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_user_auth_Click(object sender, EventArgs e)
        {
            try
            {
                // TrelloNetインスタンス生成
                trello = new Trello(this.comboBox_devKey.Text);
                // Trello認証
                trello.Authorize(this.comboBox_devToken.Text);
                // ユーザ情報を取得 (認証できていない場合はここで例外をスロー)
                myInfo = trello.Members.Me();

                // 認証成功時
                
                // ボードおよびリスト情報を取得
                fetchBoardAndListData(trello);
            }
            catch
            {
                // 認証まわりの全例外を回収しエラーダイアログ表示
                // プログラム自体は終了せず、再試行可能とする。
                MessageBox.Show(
                    ERROR_MSG_USER_AUTH_FAILURE
                     + NEW_LINE_CHAR
                     + HELP_MSG_FILE_RELOAD,
                    ERROR_TITLE_USER_AUTH_FAILURE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ボード(およびリスト)情報を取得し画面に表示する
        /// </summary>
        /// このメソッドは認証成功後に呼び出される。
        /// ボードおよびリスト情報が取得できた場合のみ、登録先コンボボックスのみ活性化。
        /// 
        /// 取得途中でエラーの場合はコンボボックスを活性化させない
        /// カード一括登録ボタン、登録先リストコンボボックスはこの時点では非活性のまま
        /// 　1. 登録先リストコンボボックスは、登録先ボードに値が入り、活性化した時点で活性化
        /// 　2. カード一括登録ボタンは、登録先ボード・リストを選択した時点で活性化
        /// <param name="trello"></param>
        private void fetchBoardAndListData(Trello trello)
        {
            // ボード情報
            IEnumerable<Board> board;
            // 各ボードに属するリストを戻り値のValue部に格納するための変数
            List<string> insertList = new List<string>();

            try
            {
                // 参加中の全ボードを取得
                board = trello.Boards.ForMe();
                // ボード毎にリストを取得しDictionary<string, string[]>オブジェクトに格納
                IEnumerator<Board> enumeratorBoard = board.GetEnumerator();

                // 参加ボード数だけ繰り返し
                while (enumeratorBoard.MoveNext())
                {
                    // 各ボードのリストを取得しそれぞれ配列に格納
                    IEnumerator<List> enumeratorList = trello.Lists.ForBoard(enumeratorBoard.Current).GetEnumerator();
                    // 移し替え用のリストはボード毎に初期化
                    insertList = new List<string>();

                    while (enumeratorList.MoveNext())
                    {
                        insertList.Add(enumeratorList.Current.ToString());
                    }
                    // 該当ボードのリストを全部移し替え次第、戻り値のValue部に格納
                    IN_DATA_BOARD_AND_LIST_INFO.Add(enumeratorBoard.Current.Name, insertList);
                }

                // コンボボックスに値を格納
                foreach (KeyValuePair<string, List<string>> keyValuePair in IN_DATA_BOARD_AND_LIST_INFO)
                {
                    // Key部(ボード名)を登録先ボードコンボボックスに1つずつ格納
                    this.comboBox_boardName.Items.Add(keyValuePair.Key);
                    // 登録先リスト コンボボックスは選択したボードによって可変なので、ここでは格納しない
                    // (初期値 空白)
                }
                // 登録先ボード コンボボックスを活性
                this.comboBox_boardName.Enabled = true;

            }
            catch
            {
                // 管理権限をもちながらボード参加数0は恐らくあり得ないが、念の為例外を捕捉
                MessageBox.Show(ERROR_MSG_JOINING_BOARD_NOT_FOUND,
                    ERROR_TITLE_JOINING_BOARD_NOT_FOUND,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 登録先ボード コンボボックス値変更時処理
        /// </summary>
        /// 認証ボタン押下後、任意の登録先ボードを選択した際、
        /// 登録先リストコンボボックスに、ボードに対応したリストを動的に表示させる。
        /// 認証直後、登録先リストは空のままなので、必ず登録先ボードコンボボックスを操作しなければならない。
        /// この仕様は、いずれ変更される可能性があります。（登録先リストの初期値を入れる可能性）
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_boardName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 登録先ボード変更直後はリスト未選択状態なので、一括登録ボタンを一時的に非活性に戻す
            this.button_commit.Enabled = false;
            // 変更前のボードに紐付くリストを初期化
            this.comboBox_listName.Items.Clear();

            // 選択中の登録先ボード名を取得 (DictionaryオブジェクトのKey部に該当)
            string selectedBoardName = this.comboBox_boardName.Text;

            foreach (KeyValuePair<string, List<string>> keyValuePair in IN_DATA_BOARD_AND_LIST_INFO)
            {
                // 選択中の登録先ボード名で検索し、合致するKeyのValueを取得
                if (keyValuePair.Key.Equals(selectedBoardName))
                {
                    foreach (string str in keyValuePair.Value)
                    {
                        // 登録先リストにリスト名を1つずつ格納
                        this.comboBox_listName.Items.Add(str);
                    }
                }
            }
            // 初回変更時のみ
            if (!this.comboBox_listName.Enabled)
            {
                // 登録先リスト コンボボックスを活性
                this.comboBox_listName.Enabled = true;
            }
        }

        /// <summary>
        /// 登録先リスト コンボボックス 値変更時処理
        /// </summary>
        /// 登録先リストの値が空白以外に変更され、登録先ボードおよびリストが空白ではない場合のみ
        /// カード一括登録ボタンを活性化させる。
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_listName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 登録先ボード、登録先リスト両方空欄ではない場合のみ、一括登録ボタンを活性化
            if (this.comboBox_boardName.Text != "" && this.comboBox_listName.Text != "")
            {
                this.button_commit.Enabled = true;
            }
        }

        /// <summary>
        /// 【メニューバー】ヘルプ＞バージョン情報 押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Help_Version_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MSG_VERSION_INFO,
                TITLE_VERSION_INFO,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
