// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_Notifications.Screens.iPhone.Home {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("Home_iPhone")]
	public partial class Home_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnAddLocalNotification;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnAddLocalNotification")]
		private MonoTouch.UIKit.UIButton btnAddLocalNotification {
			get {
				this.__mt_btnAddLocalNotification = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnAddLocalNotification")));
				return this.__mt_btnAddLocalNotification;
			}
			set {
				this.__mt_btnAddLocalNotification = value;
				this.SetNativeField("btnAddLocalNotification", value);
			}
		}
	}
}
