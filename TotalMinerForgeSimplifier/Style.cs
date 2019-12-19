using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMF_Simplifier
{
    static class Style
    {
        public static readonly Color ButtonActiveTheme = ColorTranslator.FromHtml("#4489FE");
        public static readonly Color ButtonHighlightTheme = ColorTranslator.FromHtml("#7A718B");
        public static readonly Color ButtonTheme = ColorTranslator.FromHtml("#C0C0FF");
        public static readonly Color ButtonSelection = ColorTranslator.FromHtml("#8080FF");
        public static readonly Color DarkText = ColorTranslator.FromHtml("#404040");
        public static readonly Color LightText = ColorTranslator.FromHtml("#FFFFFF");
        public static readonly Color PageSelectionText = ColorTranslator.FromHtml("#404040");
        public static readonly Color HeadTab = ColorTranslator.FromHtml("#303F9E");

        public static void LabelButtonSelected(Label label)
        {
            label.BackColor = ButtonSelection;
            label.ForeColor = LightText;
        }
        public static void LabelButtonUnselected(Label label)
        {
            label.BackColor = ButtonTheme;
            label.ForeColor = DarkText;
        }
    }
}
