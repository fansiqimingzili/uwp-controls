using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace Controls
{
    public sealed class TitleBar : Control
    {
        private TextBlock _textBlock;
        public TitleBar()
        {
            this.DefaultStyleKey = typeof(TitleBar);
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if(_textBlock == null)
            {
                _textBlock = GetTemplateChild("titleName") as TextBlock;
            }
        }

        /// </summary>  
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.RegisterAttached("Title", typeof(string), typeof(TitleBar), new PropertyMetadata(string.Empty));

    }
}
