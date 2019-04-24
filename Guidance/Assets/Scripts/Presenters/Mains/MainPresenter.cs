using Assets.Scripts.Views.Inputs.KeyboardAndMouseInputs;
using Guidance.Services.Scenes.Parameters;
using Guidance.Views.Cameras.PlayerCameras;
using UnityEngine;

namespace Assets.Scripts.Presenters.Mains {

	/// <summary>
	/// MainシーンのPresenter
	/// </summary>
	public class MainPresenter {

		/// <summary>
		/// カメラView
		/// </summary>
		private readonly IPlayerCameraView cameraView;

		private readonly KeyboardAndMouseInputView inputView;

		/// <summary>
		/// パラメータ
		/// </summary>
		private readonly MainParameter parameter;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="parameter">パラメータ</param>
		public MainPresenter( MainParameter parameter ) {
			this.parameter = parameter;

			this.cameraView = GameObject.Find( "Main Camera" ).gameObject.AddComponent<PlayerCameraView>();
			this.cameraView.ResetPlayerPosition();
			
			this.inputView = GameObject.Find( "Main Camera" ).gameObject.AddComponent<KeyboardAndMouseInputView>();
			this.inputView.MoveUp = ( value ) => this.cameraView.AddMoveValue( new Vector3( 0f , 0f , 1f ) );
			this.inputView.MoveLeft = ( value ) => this.cameraView.AddMoveValue( new Vector3( -1f , 0f , 0f ) );
			this.inputView.MoveDown = ( value ) => this.cameraView.AddMoveValue( new Vector3( 0f , 0f , -1f ) );
			this.inputView.MoveRight = ( value ) => this.cameraView.AddMoveValue( new Vector3( 1f , 0f , 0f ) );

		}

	}
}
