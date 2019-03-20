namespace Guidance.Services.Scenes {

	/// <summary>
	/// シーン操作Serviceのインタフェース
	/// </summary>
	public interface ISceneService {

		/// <summary>
		/// シングルモードで遷移した場合の前シーンの名前取得
		/// </summary>
		/// <returns>シーン名</returns>
		string GetBeforeSingleModeSceneName();

		/// <summary>
		/// シングルモードで遷移した場合の現在のシーン名取得
		/// </summary>
		/// <returns>シーン名</returns>
		string GetCurrentSingleModeSceneName();

		/// <summary>
		/// シーン読み込み
		/// </summary>
		/// <param name="sceneName">読み込みシーン名</param>
		/// <param name="parameter">遷移先シーンに渡すパラメータ</param>
		void LoadScene( string sceneName , object parameter );

	}

}