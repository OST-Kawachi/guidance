using UnityEngine;

namespace Guidance.Views.Cameras.PlayerCameras {

	/// <summary>
	/// カメラ操作用実装クラス
	/// </summary>
	public class PlayerCameraView : MonoBehaviour , IPlayerCameraView {
		
		/// <summary>
		/// 初期位置に戻す
		/// </summary>
		public void ResetPlayerPosition() {
			this.gameObject.transform.position = new Vector3( 0f , 168f , 0f );
			this.gameObject.transform.rotation = new Quaternion();
		}

		/// <summary>
		/// 与えられたベクトル分移動する
		/// </summary>
		/// <param name="value">移動量</param>
		public void AddMoveValue( Vector3 value )
			=> this.gameObject.transform.position += value;

	}

}