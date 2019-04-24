using Guidance.Services.Scenes;
using UnityEngine;

/// <summary>
/// アプリ起動時初期設定クラス
/// </summary>
public class RuntimeInitializer : MonoBehaviour {

	/// <summary>
	/// アプリ起動時に行う初期設定をする
	/// </summary>
	[RuntimeInitializeOnLoadMethod]
	public static void Initialize()
		// シーン操作Serviceの操作開始
		=> SceneServiceFactory.CreateSceneService();

}
