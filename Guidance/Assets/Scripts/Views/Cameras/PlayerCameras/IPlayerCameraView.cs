using UnityEngine;

namespace Guidance.Views.Cameras.PlayerCameras {

	/// <summary>
	/// カメラ操作用インタフェース
	/// </summary>
	public interface IPlayerCameraView {

		/// <summary>
		/// 初期位置に戻す
		/// </summary>
		void ResetPlayerPosition();

		/// <summary>
		/// 与えられたベクトル分移動する
		/// </summary>
		/// <param name="value">移動量</param>
		void AddMoveValue( Vector3 value );

	}

}