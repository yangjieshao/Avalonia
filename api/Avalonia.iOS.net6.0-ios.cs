//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia
{
    public static partial class IOSApplicationExtensions
    {
        public static Avalonia.AppBuilder UseiOS(this Avalonia.AppBuilder builder) { throw null; }
    }
}
namespace Avalonia.iOS
{
    public partial class AvaloniaAppDelegate<TApp> : UIKit.UIResponder, ObjCRuntime.INativeObject, System.IDisposable, UIKit.IUIApplicationDelegate where TApp : Avalonia.Application, new()
    {
        public AvaloniaAppDelegate() { }
        [Foundation.ExportAttribute("window")]
        public UIKit.UIWindow Window { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        protected virtual Avalonia.AppBuilder CustomizeAppBuilder(Avalonia.AppBuilder builder) { throw null; }
        [Foundation.ExportAttribute("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIKit.UIApplication application, Foundation.NSDictionary launchOptions) { throw null; }
    }
    public partial class AvaloniaView : UIKit.UIView, Avalonia.Input.TextInput.ITextInputMethodImpl
    {
        public AvaloniaView() { }
        public override bool CanBecomeFirstResponder { get { throw null; } }
        public override bool CanResignFirstResponder { get { throw null; } }
        public Avalonia.Controls.Control Content { get { throw null; } set { } }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.Reset() { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetClient(Avalonia.Input.TextInput.ITextInputMethodClient? client) { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetCursorRect(Avalonia.Rect rect) { }
        void Avalonia.Input.TextInput.ITextInputMethodImpl.SetOptions(Avalonia.Input.TextInput.TextInputOptions options) { }
        public override bool BecomeFirstResponder() { throw null; }
        [Foundation.ExportAttribute("layerClass")]
        public static ObjCRuntime.Class LayerClass() { throw null; }
        public override void LayoutSubviews() { }
        public override bool ResignFirstResponder() { throw null; }
        public override void TintColorDidChange() { }
        public override void TouchesBegan(Foundation.NSSet touches, UIKit.UIEvent evt) { }
        public override void TouchesCancelled(Foundation.NSSet touches, UIKit.UIEvent evt) { }
        public override void TouchesEnded(Foundation.NSSet touches, UIKit.UIEvent evt) { }
        public override void TouchesMoved(Foundation.NSSet touches, UIKit.UIEvent evt) { }
        public override void TraitCollectionDidChange(UIKit.UITraitCollection previousTraitCollection) { }
    }
    public partial class UIViewControlHandle : Avalonia.Controls.Platform.INativeControlHostDestroyableControlHandle, Avalonia.Platform.IPlatformHandle
    {
        public UIViewControlHandle(UIKit.UIView view) { }
        System.IntPtr Avalonia.Platform.IPlatformHandle.Handle { get { throw null; } }
        public string HandleDescriptor { get { throw null; } }
        public UIKit.UIView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public void Destroy() { }
    }
}
