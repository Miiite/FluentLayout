// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class LayoutExtensions
    {

        
        public static TBindable BindIsClippedToBoundsLayout<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Layout
                => self.Bind(Layout.IsClippedToBoundsProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindCascadeInputTransparentLayout<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Layout
                => self.Bind(Layout.CascadeInputTransparentProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
        
        public static TBindable BindPaddingLayout<TBindable>(this TBindable self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null) where TBindable : Layout
                => self.Bind(Layout.PaddingProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}