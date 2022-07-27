using Painter.Controls;

namespace Painter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTollbox = new System.Windows.Forms.Panel();
            this.PnlTools = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.PnlColors = new System.Windows.Forms.Panel();
            this.FlwColors = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRed = new Painter.Controls.PainterColor();
            this.BtnBlue = new Painter.Controls.PainterColor();
            this.BtnGreen = new Painter.Controls.PainterColor();
            this.BtnOrange = new Painter.Controls.PainterColor();
            this.BtnBlack = new Painter.Controls.PainterColor();
            this.BtnPurple = new Painter.Controls.PainterColor();
            this.BtnBrown = new Painter.Controls.PainterColor();
            this.PnlShapes = new System.Windows.Forms.Panel();
            this.FlwShapes = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnTriangle = new System.Windows.Forms.Button();
            this.BtnHexagon = new System.Windows.Forms.Button();
            this.Canvas = new Painter.Controls.Canvas();
            this.PnlTollbox.SuspendLayout();
            this.PnlTools.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PnlColors.SuspendLayout();
            this.FlwColors.SuspendLayout();
            this.PnlShapes.SuspendLayout();
            this.FlwShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTollbox
            // 
            this.PnlTollbox.Controls.Add(this.PnlTools);
            this.PnlTollbox.Controls.Add(this.PnlColors);
            this.PnlTollbox.Controls.Add(this.PnlShapes);
            this.PnlTollbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlTollbox.Location = new System.Drawing.Point(832, 0);
            this.PnlTollbox.Name = "PnlTollbox";
            this.PnlTollbox.Size = new System.Drawing.Size(176, 650);
            this.PnlTollbox.TabIndex = 0;
            // 
            // PnlTools
            // 
            this.PnlTools.Controls.Add(this.flowLayoutPanel3);
            this.PnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTools.Location = new System.Drawing.Point(0, 319);
            this.PnlTools.Name = "PnlTools";
            this.PnlTools.Size = new System.Drawing.Size(176, 259);
            this.PnlTools.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BtnSelect);
            this.flowLayoutPanel3.Controls.Add(this.BtnClear);
            this.flowLayoutPanel3.Controls.Add(this.BtnEdit);
            this.flowLayoutPanel3.Controls.Add(this.BtnOpen);
            this.flowLayoutPanel3.Controls.Add(this.BtnSave);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(176, 259);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSelect.Image = global::Painter.Properties.Resources._007_tap;
            this.BtnSelect.Location = new System.Drawing.Point(8, 8);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 75);
            this.BtnSelect.TabIndex = 5;
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClear.Image = global::Painter.Properties.Resources._004_delete;
            this.BtnClear.Location = new System.Drawing.Point(89, 8);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 75);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEdit.Image = global::Painter.Properties.Resources._006_edit;
            this.BtnEdit.Location = new System.Drawing.Point(8, 89);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 75);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOpen.Image = global::Painter.Properties.Resources._002_open;
            this.BtnOpen.Location = new System.Drawing.Point(89, 89);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 75);
            this.BtnOpen.TabIndex = 9;
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Image = global::Painter.Properties.Resources._005_floppy_disk;
            this.BtnSave.Location = new System.Drawing.Point(8, 170);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 75);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PnlColors
            // 
            this.PnlColors.Controls.Add(this.FlwColors);
            this.PnlColors.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlColors.Location = new System.Drawing.Point(0, 174);
            this.PnlColors.Name = "PnlColors";
            this.PnlColors.Size = new System.Drawing.Size(176, 145);
            this.PnlColors.TabIndex = 1;
            // 
            // FlwColors
            // 
            this.FlwColors.Controls.Add(this.BtnRed);
            this.FlwColors.Controls.Add(this.BtnBlue);
            this.FlwColors.Controls.Add(this.BtnGreen);
            this.FlwColors.Controls.Add(this.BtnOrange);
            this.FlwColors.Controls.Add(this.BtnBlack);
            this.FlwColors.Controls.Add(this.BtnPurple);
            this.FlwColors.Controls.Add(this.BtnBrown);
            this.FlwColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwColors.Location = new System.Drawing.Point(0, 0);
            this.FlwColors.Name = "FlwColors";
            this.FlwColors.Padding = new System.Windows.Forms.Padding(5);
            this.FlwColors.Size = new System.Drawing.Size(176, 145);
            this.FlwColors.TabIndex = 0;
            // 
            // BtnRed
            // 
            this.BtnRed.BackColor = System.Drawing.Color.Red;
            this.BtnRed.Color = System.Drawing.Color.Red;
            this.BtnRed.FlatAppearance.BorderSize = 0;
            this.BtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRed.Location = new System.Drawing.Point(8, 8);
            this.BtnRed.Name = "BtnRed";
            this.BtnRed.Size = new System.Drawing.Size(40, 40);
            this.BtnRed.TabIndex = 8;
            this.BtnRed.UseVisualStyleBackColor = false;
            this.BtnRed.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnBlue
            // 
            this.BtnBlue.BackColor = System.Drawing.Color.Blue;
            this.BtnBlue.Color = System.Drawing.Color.Blue;
            this.BtnBlue.FlatAppearance.BorderSize = 0;
            this.BtnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlue.Location = new System.Drawing.Point(54, 8);
            this.BtnBlue.Name = "BtnBlue";
            this.BtnBlue.Size = new System.Drawing.Size(40, 40);
            this.BtnBlue.TabIndex = 9;
            this.BtnBlue.UseVisualStyleBackColor = false;
            this.BtnBlue.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnGreen
            // 
            this.BtnGreen.BackColor = System.Drawing.Color.Green;
            this.BtnGreen.Color = System.Drawing.Color.Green;
            this.BtnGreen.FlatAppearance.BorderSize = 0;
            this.BtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGreen.Location = new System.Drawing.Point(100, 8);
            this.BtnGreen.Name = "BtnGreen";
            this.BtnGreen.Size = new System.Drawing.Size(40, 40);
            this.BtnGreen.TabIndex = 10;
            this.BtnGreen.UseVisualStyleBackColor = false;
            this.BtnGreen.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnOrange
            // 
            this.BtnOrange.BackColor = System.Drawing.Color.Orange;
            this.BtnOrange.Color = System.Drawing.Color.Orange;
            this.BtnOrange.FlatAppearance.BorderSize = 0;
            this.BtnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrange.Location = new System.Drawing.Point(8, 54);
            this.BtnOrange.Name = "BtnOrange";
            this.BtnOrange.Size = new System.Drawing.Size(40, 40);
            this.BtnOrange.TabIndex = 11;
            this.BtnOrange.UseVisualStyleBackColor = false;
            this.BtnOrange.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnBlack
            // 
            this.BtnBlack.BackColor = System.Drawing.Color.Black;
            this.BtnBlack.Color = System.Drawing.Color.Black;
            this.BtnBlack.FlatAppearance.BorderSize = 0;
            this.BtnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBlack.Location = new System.Drawing.Point(54, 54);
            this.BtnBlack.Name = "BtnBlack";
            this.BtnBlack.Size = new System.Drawing.Size(40, 40);
            this.BtnBlack.TabIndex = 12;
            this.BtnBlack.UseVisualStyleBackColor = false;
            this.BtnBlack.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnPurple
            // 
            this.BtnPurple.BackColor = System.Drawing.Color.Purple;
            this.BtnPurple.Color = System.Drawing.Color.Purple;
            this.BtnPurple.FlatAppearance.BorderSize = 0;
            this.BtnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPurple.Location = new System.Drawing.Point(100, 54);
            this.BtnPurple.Name = "BtnPurple";
            this.BtnPurple.Size = new System.Drawing.Size(40, 40);
            this.BtnPurple.TabIndex = 13;
            this.BtnPurple.UseVisualStyleBackColor = false;
            this.BtnPurple.Click += new System.EventHandler(this.SelectColor);
            // 
            // BtnBrown
            // 
            this.BtnBrown.BackColor = System.Drawing.Color.Brown;
            this.BtnBrown.Color = System.Drawing.Color.Brown;
            this.BtnBrown.FlatAppearance.BorderSize = 0;
            this.BtnBrown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrown.Location = new System.Drawing.Point(8, 100);
            this.BtnBrown.Name = "BtnBrown";
            this.BtnBrown.Size = new System.Drawing.Size(40, 40);
            this.BtnBrown.TabIndex = 14;
            this.BtnBrown.UseVisualStyleBackColor = false;
            this.BtnBrown.Click += new System.EventHandler(this.SelectColor);
            // 
            // PnlShapes
            // 
            this.PnlShapes.Controls.Add(this.FlwShapes);
            this.PnlShapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlShapes.Location = new System.Drawing.Point(0, 0);
            this.PnlShapes.Name = "PnlShapes";
            this.PnlShapes.Size = new System.Drawing.Size(176, 174);
            this.PnlShapes.TabIndex = 0;
            // 
            // FlwShapes
            // 
            this.FlwShapes.Controls.Add(this.BtnRectangle);
            this.FlwShapes.Controls.Add(this.BtnCircle);
            this.FlwShapes.Controls.Add(this.BtnTriangle);
            this.FlwShapes.Controls.Add(this.BtnHexagon);
            this.FlwShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwShapes.Location = new System.Drawing.Point(0, 0);
            this.FlwShapes.Name = "FlwShapes";
            this.FlwShapes.Padding = new System.Windows.Forms.Padding(5);
            this.FlwShapes.Size = new System.Drawing.Size(176, 174);
            this.FlwShapes.TabIndex = 0;
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnRectangle.FlatAppearance.BorderSize = 0;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.Image = global::Painter.Properties.Resources.rectangle;
            this.BtnRectangle.Location = new System.Drawing.Point(8, 8);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(75, 75);
            this.BtnRectangle.TabIndex = 0;
            this.BtnRectangle.Tag = "1";
            this.BtnRectangle.UseVisualStyleBackColor = false;
            this.BtnRectangle.Click += new System.EventHandler(this.Select_ShapeType);
            // 
            // BtnCircle
            // 
            this.BtnCircle.FlatAppearance.BorderSize = 0;
            this.BtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCircle.Image = global::Painter.Properties.Resources.circle;
            this.BtnCircle.Location = new System.Drawing.Point(89, 8);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(75, 75);
            this.BtnCircle.TabIndex = 1;
            this.BtnCircle.Tag = "2";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.Select_ShapeType);
            // 
            // BtnTriangle
            // 
            this.BtnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnTriangle.FlatAppearance.BorderSize = 0;
            this.BtnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTriangle.Image = global::Painter.Properties.Resources.triangle;
            this.BtnTriangle.Location = new System.Drawing.Point(8, 89);
            this.BtnTriangle.Name = "BtnTriangle";
            this.BtnTriangle.Size = new System.Drawing.Size(75, 75);
            this.BtnTriangle.TabIndex = 2;
            this.BtnTriangle.Tag = "3";
            this.BtnTriangle.UseVisualStyleBackColor = false;
            this.BtnTriangle.Click += new System.EventHandler(this.Select_ShapeType);
            // 
            // BtnHexagon
            // 
            this.BtnHexagon.FlatAppearance.BorderSize = 0;
            this.BtnHexagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHexagon.Image = global::Painter.Properties.Resources.hexagon;
            this.BtnHexagon.Location = new System.Drawing.Point(89, 89);
            this.BtnHexagon.Name = "BtnHexagon";
            this.BtnHexagon.Size = new System.Drawing.Size(75, 75);
            this.BtnHexagon.TabIndex = 3;
            this.BtnHexagon.Tag = "4";
            this.BtnHexagon.UseVisualStyleBackColor = true;
            this.BtnHexagon.Click += new System.EventHandler(this.Select_ShapeType);
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Point1 = new System.Drawing.Point(0, 0);
            this.Canvas.Point2 = new System.Drawing.Point(0, 0);
            this.Canvas.SelectedColor = System.Drawing.Color.Black;
            this.Canvas.selectedshape = null;
            this.Canvas.SelectedShape = Painter.Enums.ShapeTypeEnum.RECTANGLE;
            this.Canvas.Shapes = null;
            this.Canvas.Size = new System.Drawing.Size(832, 650);
            this.Canvas.TabIndex = 1;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 650);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.PnlTollbox);
            this.Name = "Form1";
            this.Text = "Painter";
            this.PnlTollbox.ResumeLayout(false);
            this.PnlTools.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PnlColors.ResumeLayout(false);
            this.FlwColors.ResumeLayout(false);
            this.PnlShapes.ResumeLayout(false);
            this.FlwShapes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlTollbox;
        private Panel PnlTools;
        private Panel PnlColors;
        private Panel PnlShapes;
        private Button BtnRectangle;
        private FlowLayoutPanel FlwColors;
        private FlowLayoutPanel FlwShapes;
        private Button BtnCircle;
        private Button BtnTriangle;
        private Button BtnHexagon;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button BtnSelect;
        private Button BtnClear;
        private Button BtnEdit;
        private Button BtnOpen;
        private Button BtnSave;
        private Canvas Canvas;
        private PainterColor BtnRed;
        private PainterColor BtnBlue;
        private PainterColor BtnGreen;
        private PainterColor BtnOrange;
        private PainterColor BtnBlack;
        private PainterColor BtnPurple;
        private PainterColor BtnBrown;
    }
}