using System;
using Xamarin.Forms;

namespace AccessibilitySample.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Contrast { get; set; }
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }
    }
}