// This file is generated by FluentCodegen
// It does not make sense to change something here
// No stress :)
using System;
namespace Xamarin.Forms.Fluent
{
    public static partial class FileImageSourceExtensions
    {

        
        public static FileImageSource BindFileFileImageSource(this FileImageSource self,
            string path,
            BindingMode mode = BindingMode.Default,
            IValueConverter converter = null,
            object converterParameter = null,
            string stringFormat = null,
            object source = null,
            object targetNullValue = null,
            object fallbackValue = null)
                => self.Bind(FileImageSource.FileProperty, path, mode, converter, converterParameter, stringFormat, source, targetNullValue, fallbackValue);
    }
}