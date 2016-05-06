using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SudokuPlayer
{
    public class TwzyToolStripRenderer : ToolStripRenderer
    {
        public static TwzyToolStripRenderer CreatMyToolStripRenderer()
        {
            return new TwzyToolStripRenderer();
        }

        /// <summary>
        /// 背景色
        /// </summary>
        private Color BackColor = Color.White;
        /// <summary>
        /// 被选中图标
        /// </summary>
        private Color SelectColor = Color.PowderBlue;
        /// <summary>
        /// 被选中文字颜色
        /// </summary>
        private Color SelectedTextColor = Color.Black;
        /// <summary>
        /// 文字颜色
        /// </summary>
        private Color TextColor = Color.Black;
        /// <summary>
        /// 分割线颜色
        /// </summary>
        private Color SpanLineColor = Color.SkyBlue;

        //背景
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            e.ToolStrip.BackColor = BackColor;
        }
        //选中
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                return;
            }
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(SelectColor), new Rectangle(new Point(0, 0), e.Item.Size));
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        //文字
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // e.TextFont = new Font("黑体",10);
            base.OnRenderItemText(e);
            if (!e.Item.Enabled)
            {
                return;
            }

            if (e.Item.Selected)
            {
                e.Item.ForeColor = SelectedTextColor;
            }
            else
            {
                e.Item.ForeColor = TextColor;
            }
        }
        //分割线
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            base.OnRenderSeparator(e);
            if (e.Vertical)
            {
                e.Graphics.DrawLine(new Pen(SpanLineColor, 1f), new Point(e.Item.Width / 2, 4), new Point(e.Item.Width / 2, e.Item.Height - 4));

            }
            else
            {
                e.Graphics.DrawLine(new Pen(SpanLineColor, 1f), new Point(30, e.Item.Height / 2), new Point(e.Item.Width - 10, e.Item.Height / 2));
            }
        }

        ////左边的条状
        //protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        //{
        //    base.OnRenderImageMargin(e);
        //    e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), e.AffectedBounds);
        //}

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            if (!(e.Item is ToolStripMenuItem) && e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(SelectColor), new Rectangle(0, 0, e.Item.Width, e.Item.Height));
            }
            base.OnRenderItemImage(e);
        }
    }
}
