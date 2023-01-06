using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return String.IsNullOrWhiteSpace(ResourceId) ? null : ImageSource.FromResource(ResourceId);
        }
    }
}
