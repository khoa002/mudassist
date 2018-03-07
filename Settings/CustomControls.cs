using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Mud.Settings
{
    // Part of the code below is taken from Shinra CR,
    // obviously the credit for this goes all to Auk.
    // Thank him before me, he deserve it ;)
    // Shinra CR Repo: https://github.com/aukon/Shinra
    [DesignerCategory("code")]

    #region GroupBox

    public sealed class CustomGroupBox : GroupBox
    {
        private readonly Color _borderColor = Color.FromArgb(85, 81, 85);
        private readonly Color _textColor = Color.FromArgb(0, 0, 0);

        public CustomGroupBox()
        {
            Font = new Font("Segoe UI", 8.25F);
            TabStop = false;
            SetStyle(
                ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var tRect = ClientRectangle;
            const int tOffset = 6;
            tRect.X += tOffset;
            tRect.Width -= 2 * tOffset;
            const TextFormatFlags f = TextFormatFlags.TextBoxControl;
            var tSize = TextRenderer.MeasureText(Text, Font, new Size(tRect.Width, int.MaxValue), f);
            TextRenderer.DrawText(e.Graphics, Text, Font, tRect, _textColor, f);

            var bPen = new Pen(new SolidBrush(_borderColor));
            var tRight = Math.Min(tOffset + tSize.Width, Width - 6);
            var bTop = FontHeight / 2;
            e.Graphics.DrawLine(bPen, 0, bTop, 0, Height - 1);
            e.Graphics.DrawLine(bPen, 0, Height - 1, Width, Height - 1);
            e.Graphics.DrawLine(bPen, 0, bTop, tOffset, bTop);
            e.Graphics.DrawLine(bPen, tRight - 2, bTop, Width - 1, bTop);
            e.Graphics.DrawLine(bPen, Width - 1, bTop, Width - 1, Height - 1);
        }
    }

    #endregion
}