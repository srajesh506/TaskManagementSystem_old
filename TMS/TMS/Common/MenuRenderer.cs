﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TMS.App_Code
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color primarycolor;
        private Color textColor;
        private int arroThickness;
        public MenuRenderer(bool isMainMenu, Color PrimaryColor, Color textcolor) : base(new MenuColorTable(isMainMenu,PrimaryColor))
        {
            this.primarycolor = PrimaryColor;
            this.textColor = textcolor;
            if (isMainMenu)
                arroThickness = 3;
            else
                arroThickness = 2;

        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : primarycolor;
        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            base.OnRenderArrow(e);
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primarycolor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-arrowSize.Height)/2,arrowSize.Width,arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arroThickness))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2,rect.Left,rect.Top+rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}
