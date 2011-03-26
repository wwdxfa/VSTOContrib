using Microsoft.Office.Interop.PowerPoint;
using Office.Contrib.RibbonFactory.Interfaces;

namespace Office.PowerPoint.Contrib.RibbonFactory
{
    /// <summary>
    /// Gets the document for a view
    /// </summary>
    public class PowerPointViewContextProvider : IViewContextProvider
    {
        public object GetContextForView(object view)
        {
            var window = view as DocumentWindow;
            if (window != null)
                return window.Presentation;

            //var slide = view as SlideShowView;
            //if (slide != null)
            //    return slide.Slide;

            //var slideWindow = view as SlideShowWindow;
            //if (slideWindow != null)
            //    return slideWindow.Presentation;

            //var protectedWindow = view as ProtectedViewWindow;
            //if (protectedWindow != null)
            //    return protectedWindow.Presentation;

            return null;
        }
    }
}