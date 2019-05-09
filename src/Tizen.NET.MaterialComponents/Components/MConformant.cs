using System;
using ElmSharp;

namespace Tizen.NET.MaterialComponents
{
    public class MConformant : Conformant
    {
        Layout _layout = null;
        Box _box = null;

        public MConformant(Window parent) : base(parent)
        {
            _layout = new Layout(parent)
            {
                WeightX = 1,
                WeightY = 1,
                AlignmentX = -1,
                AlignmentY = -1,
            };
            _layout.SetTheme("layout", "material_application", "default");
            _layout.Show();
            base.SetContent(_layout);
        }

        public new void SetContent(EvasObject content)
        {
            _layout.SetContent(content);
        }

        public EvasObject FloatingLayout
        {
            get
            {
                if (_box == null)
                {
                    _box = new Box(_layout);
                    _box.Show();
                    _layout.SetPartContent(Parts.Layout.FloatingButton, _box);
                }
                return _box;
            }
        }
    }
}
