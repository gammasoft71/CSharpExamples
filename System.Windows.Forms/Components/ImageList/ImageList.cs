﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examples {
  class Form1 : Form {
    [STAThread]
    public static void Main() {
      Application.EnableVisualStyles();
      Application.Run(new Form1());
    }

    public Form1() {
      Text = "ImageList Example";
      ClientSize = new System.Drawing.Size(300, 250);
      Controls.AddRange(new Control[] { picture, buttonPrevious, buttonNext});

      pictures.ImageSize = new System.Drawing.Size(128, 128);
      pictures.ColorDepth = ColorDepth.Depth32Bit;

      picture.BackColor = SystemColors.Window;
      picture.BorderStyle = BorderStyle.Fixed3D;
      picture.Bounds = new Rectangle(75, 25, 150, 150);
      picture.SizeMode = PictureBoxSizeMode.CenterImage;
      picture.Click += delegate {
        LoadImages();
      };

      buttonPrevious.Text = "&<";
      buttonPrevious.Location = new Point(75, 200);
      buttonPrevious.Enabled = false;
      buttonPrevious.Click += delegate {
        if (currentImageIndex > 0) picture.Image = pictures.Images[--currentImageIndex];
        buttonPrevious.Enabled = currentImageIndex > 0;
        buttonNext.Enabled = currentImageIndex < pictures.Images.Count - 1;
      };

      buttonNext.Text = "&>";
      buttonNext.Location = new Point(150, 200);
      buttonNext.Enabled = false;
      buttonNext.Click += delegate {
        if (currentImageIndex < pictures.Images.Count) picture.Image = pictures.Images[++currentImageIndex];
        buttonPrevious.Enabled = currentImageIndex > 0;
        buttonNext.Enabled = currentImageIndex < pictures.Images.Count - 1;
      };

      Show();
      LoadImages();
    }

    private void LoadImages() {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Multiselect = true;
      ofd.Filter = "All Image Files|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Bitmap Files|*.bmp|Gif Files|*.gif|Jpeg Files|*.jpg;*.jpeg|Png Files|*.png|Tiff Files|*.tif;*.tiff";
      if (ofd.ShowDialog() == DialogResult.OK) {
        pictures.Images.Clear();
        foreach (var file in ofd.FileNames)
          pictures.Images.Add(Image.FromFile(file));
        currentImageIndex = 0;
        picture.Image = pictures.Images[currentImageIndex];
        buttonPrevious.Enabled = currentImageIndex > 0;
        buttonNext.Enabled = currentImageIndex < pictures.Images.Count - 1;
      }
    }

    private int currentImageIndex = 0;
    private ImageList pictures = new ImageList();
    private PictureBox picture = new PictureBox();
    private Button buttonPrevious = new Button();
    private Button buttonNext = new Button();
  }
}
