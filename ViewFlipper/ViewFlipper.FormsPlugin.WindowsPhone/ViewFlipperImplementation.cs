using ViewFlipper.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using ViewFlipper.FormsPlugin.WindowsPhone;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(ViewFlipper.FormsPlugin.Abstractions.ViewFlipperControl), typeof(ViewFlipperRenderer))]
namespace ViewFlipper.FormsPlugin.WindowsPhone
{
    /// <summary>
    /// ViewFlipper Renderer
    /// </summary>
    public class ViewFlipperRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
