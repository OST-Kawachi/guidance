namespace Guidance.Services.Scenes {

	/// <summary>
	/// シーン操作Service生成クラス
	/// </summary>
	public static partial class SceneServiceFactory {

		/// <summary>
		/// シーン操作Service
		/// </summary>
		private static ISceneService sceneService = null;

		/// <summary>
		/// シーン操作Serviceの生成
		/// </summary>
		/// <returns>シーン操作Serviceのインタフェース</returns>
		public static ISceneService CreateSceneService() {
			if( sceneService is null ) {
				sceneService = new SceneService();
			}
			return sceneService;
		}

	}

}
