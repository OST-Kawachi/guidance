using Assets.Scripts.Presenters.Mains;
using Guidance.Services.Scenes.Parameters;
using UnityEngine.SceneManagement;

namespace Guidance.Services.Scenes {

	public partial class SceneServiceFactory {

		/// <summary>
		/// シーン操作Serviceの実装クラス
		/// </summary>
		private class SceneService : ISceneService {

			/// <summary>
			/// 画面遷移時に渡すパラメータ
			/// </summary>
			private static object Parameter;

			/// <summary>
			/// シングルモードで遷移した場合の前シーンの名前
			/// </summary>
			private static string BeforeSingleModeSceneName {
				set;
				get;
			}

			/// <summary>
			/// シングルモードで遷移した場合の前シーンの名前取得
			/// </summary>
			/// <returns>シーン名</returns>
			public string GetBeforeSingleModeSceneName()
				=> BeforeSingleModeSceneName;

			/// <summary>
			/// シングルモードで遷移した場合の現在のシーン名
			/// </summary>
			private static string CurrentSingleModeSceneName {
				set;
				get;
			}

			/// <summary>
			/// シングルモードで遷移した場合の現在のシーン名取得
			/// </summary>
			/// <returns>シーン名</returns>
			public string GetCurrentSingleModeSceneName()
				=> CurrentSingleModeSceneName;

			/// <summary>
			/// コンストラクタ
			/// </summary>
			public SceneService() {

				// シーン切り替え時イベント追加
				SceneManager.sceneLoaded += OnSceneLoaded;

				// 最初は必ずMainシーンからスタートする
				SceneManager.LoadScene( "Main" );

			}

			/// <summary>
			/// シーン切り替え時イベント
			/// </summary>
			/// <param name="scene">遷移後シーン</param>
			/// <param name="loadSceneMode">遷移モード</param>
			private static void OnSceneLoaded(
				Scene scene ,
				LoadSceneMode loadSceneMode
			) {

				// シングルモードで遷移した場合は前シーンの名前を保持しておく
				if( loadSceneMode == LoadSceneMode.Single ) {
					BeforeSingleModeSceneName = CurrentSingleModeSceneName;
					CurrentSingleModeSceneName = scene.name;
				}

				// シーン切り替え時にはおおもとになるPresenterのインスタンスを生成
				switch( scene.name ) {
					case "Main":
						new MainPresenter( (MainParameter)Parameter );
						break;
					default:
						break;
				}

				// staticフィールドなので、一回使ったらパラメータ内を削除
				Parameter = null;
				
			}

			/// <summary>
			/// シーン読み込み
			/// </summary>
			/// <param name="sceneName">読み込みシーン名</param>
			/// <param name="parameter">遷移先シーンに渡すパラメータ</param>
			public void LoadScene( string sceneName , object parameter ) {
				Parameter = parameter;
				SceneManager.LoadScene( sceneName );
			}

			/// <summary>
			/// 現在のシーン名が指定のシーン名と一致するかどうか
			/// </summary>
			/// <param name="sceneName">シーン名</param>
			/// <returns>現在のシーン名が指定のシーン名と一致するかどうか</returns>
			private static bool EqualsActiveSceneName( string sceneName )
				=> SceneManager.GetActiveScene().name.Equals( sceneName );
			
		}

	}

}

