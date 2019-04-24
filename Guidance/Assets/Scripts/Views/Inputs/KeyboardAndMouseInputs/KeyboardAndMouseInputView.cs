using System;
using UnityEngine;

namespace Assets.Scripts.Views.Inputs.KeyboardAndMouseInputs {

	/// <summary>
	/// キー入力とマウスからの入力についてのView
	/// </summary>
	public class KeyboardAndMouseInputView : MonoBehaviour {

		private int PushACount { set; get; } = 0;

		private int PushSCount { set; get; } = 0;

		private int PushDCount { set; get; } = 0;

		public int PushWCount { set; get; } = 0;

		public Action<int> MoveLeft { set; get; }

		public Action<int> MoveRight { set; get; }

		public Action<int> MoveUp { set; get; }

		public Action<int> MoveDown { set; get; }

		public void Update() {

			if( Input.GetKey( KeyCode.A ) ) {
				this.PushACount++;
				this.MoveLeft?.Invoke( this.PushACount );
			}
			else {
				this.PushACount = 0;
			}
			if( Input.GetKey( KeyCode.S ) ) {
				this.PushSCount++;
				this.MoveDown?.Invoke( this.PushSCount );
			}
			else {
				this.PushSCount = 0;
			}
			if( Input.GetKey( KeyCode.D ) ) {
				this.PushDCount++;
				this.MoveRight?.Invoke( this.PushDCount );
			}
			else {
				this.PushDCount = 0;
			}

			if( Input.GetKey( KeyCode.W ) ) {
				this.PushWCount++;
				this.MoveUp?.Invoke( this.PushWCount );
			}
			else {
				this.PushWCount = 0;
			}
			
		}


	}

}
